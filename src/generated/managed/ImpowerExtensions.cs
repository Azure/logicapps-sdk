//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Impower
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImpowerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<ErrorCodesUsingGETResponseItem[]> ErrorCodesUsingGET()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/error-codes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ErrorCodesUsingGETResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<ErrorCodeDetailsDto> ErrorCodeUsingGET([WorkflowExpression] Func<valueInput> value)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/error-codes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(value, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ErrorCodeDetailsDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<ConnectionDto> UpdateConnectionUsingPUT([WorkflowExpression] Func<int> connectionIdX, [WorkflowExpression] Func<string> connectionUpdateDtonameOfTheConnectionAsItShallBePresentedInTheUIIfNotSpecifiedWillBeDefaultedToTheNameOfTheApplication = null, [WorkflowExpression] Func<string> connectionUpdateDtotheURLWillBeCalledWithAnAuthorizationTokenYouMayValidateAndTheFollowingBodyConnectionId123EntityTypePropertiesEntityId123EventTypeUPDATE = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/connections/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(connectionIdX, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var connectionUpdateDto = new JObject();
                var connectionUpdateDtopropCount = 0;
                if (connectionUpdateDtonameOfTheConnectionAsItShallBePresentedInTheUIIfNotSpecifiedWillBeDefaultedToTheNameOfTheApplication != null)
                {
                    connectionUpdateDto["name"] = SourceExpressionConverter.ConvertToken(connectionUpdateDtonameOfTheConnectionAsItShallBePresentedInTheUIIfNotSpecifiedWillBeDefaultedToTheNameOfTheApplication);
                    connectionUpdateDtopropCount++;
                }

                if (connectionUpdateDtotheURLWillBeCalledWithAnAuthorizationTokenYouMayValidateAndTheFollowingBodyConnectionId123EntityTypePropertiesEntityId123EventTypeUPDATE != null)
                {
                    connectionUpdateDto["webhookUrl"] = SourceExpressionConverter.ConvertToken(connectionUpdateDtotheURLWillBeCalledWithAnAuthorizationTokenYouMayValidateAndTheFollowingBodyConnectionId123EntityTypePropertiesEntityId123EventTypeUPDATE);
                    connectionUpdateDtopropCount++;
                }

                if (connectionUpdateDtopropCount > 0)
                {
                    callPayload.Body = connectionUpdateDto;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConnectionDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IWorkflowAction DeleteConnectionUsingDELETE([WorkflowExpression] Func<int> connectionIdX)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/connections/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(connectionIdX, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<ConnectionDto> GetConnectionUsingGET([WorkflowExpression] Func<int> connectionIdX)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/connections/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(connectionIdX, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConnectionDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<PageOfContactDto> GetContactsByFilterUsingGET([WorkflowExpression] Func<int[]> contactIds = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> sort = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (contactIds != null)
                    callPayload.Queries["contactIds"] = SourceExpressionConverter.ConvertO(contactIds);
                if (email != null)
                    callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<PageOfContactDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<ContactDto> GetContactByIdUsingGET([WorkflowExpression] Func<int> contactId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(contactId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ContactDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<PageOfContractDto> GetContractsByFilterUsingGET([WorkflowExpression] Func<int> contactId = null, [WorkflowExpression] Func<int[]> contractIds = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> propertyId = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<typeInputItem[]> type = null, [WorkflowExpression] Func<int> unitId = null, [WorkflowExpression] Func<string> validAtDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/contracts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (contactId != null)
                    callPayload.Queries["contactId"] = SourceExpressionConverter.ConvertO(contactId);
                if (contractIds != null)
                    callPayload.Queries["contractIds"] = SourceExpressionConverter.ConvertO(contractIds);
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (propertyId != null)
                    callPayload.Queries["propertyId"] = SourceExpressionConverter.ConvertO(propertyId);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                if (unitId != null)
                    callPayload.Queries["unitId"] = SourceExpressionConverter.ConvertO(unitId);
                if (validAtDate != null)
                    callPayload.Queries["validAtDate"] = SourceExpressionConverter.ConvertO(validAtDate);
                return callPayload;
            }

            return new ApiConnectionAction<PageOfContractDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<ContractDto> GetContractByIdUsingGET([WorkflowExpression] Func<int> contractId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/contracts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(contractId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ContractDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<DocumentTagDto[]> GetDocumentTagsUsingGET([WorkflowExpression] Func<string> description = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/document-tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (description != null)
                    callPayload.Queries["description"] = SourceExpressionConverter.ConvertO(description);
                return callPayload;
            }

            return new ApiConnectionAction<DocumentTagDto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<DocumentTagDto> CreateDocumentTagUsingPOST([WorkflowExpression] Func<string> createDtodescriptionOfTheNewlyCreatedDocumentTag = null, [WorkflowExpression] Func<string> createDtonameOfTheNewlyCreatedDocumentTag = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/document-tags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var createDto = new JObject();
                var createDtopropCount = 0;
                if (createDtodescriptionOfTheNewlyCreatedDocumentTag != null)
                {
                    createDto["description"] = SourceExpressionConverter.ConvertToken(createDtodescriptionOfTheNewlyCreatedDocumentTag);
                    createDtopropCount++;
                }

                if (createDtonameOfTheNewlyCreatedDocumentTag != null)
                {
                    createDto["name"] = SourceExpressionConverter.ConvertToken(createDtonameOfTheNewlyCreatedDocumentTag);
                    createDtopropCount++;
                }

                if (createDtopropCount > 0)
                {
                    callPayload.Body = createDto;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocumentTagDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<DocumentTagDto> UpdateDocumentTagUsingPUT([WorkflowExpression] Func<int> tagId, [WorkflowExpression] Func<string> updateDtonewDescriptionOfTheDocumentTag = null, [WorkflowExpression] Func<string> updateDtonewNameOfTheDocumentTag = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/document-tags/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(tagId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var updateDto = new JObject();
                var updateDtopropCount = 0;
                if (updateDtonewDescriptionOfTheDocumentTag != null)
                {
                    updateDto["description"] = SourceExpressionConverter.ConvertToken(updateDtonewDescriptionOfTheDocumentTag);
                    updateDtopropCount++;
                }

                if (updateDtonewNameOfTheDocumentTag != null)
                {
                    updateDto["name"] = SourceExpressionConverter.ConvertToken(updateDtonewNameOfTheDocumentTag);
                    updateDtopropCount++;
                }

                if (updateDtopropCount > 0)
                {
                    callPayload.Body = updateDto;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocumentTagDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IWorkflowAction DeleteDocumentTagUsingDELETE([WorkflowExpression] Func<int> tagId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/document-tags/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(tagId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<PageOfDocumentDto> GetDocumentsByFilterUsingGET([WorkflowExpression] Func<string> accountant = null, [WorkflowExpression] Func<string> administrator = null, [WorkflowExpression] Func<int> contactId = null, [WorkflowExpression] Func<string> contractName = null, [WorkflowExpression] Func<int[]> documentIds = null, [WorkflowExpression] Func<string> documentName = null, [WorkflowExpression] Func<string> issuedDate = null, [WorkflowExpression] Func<string> maxIssuedDate = null, [WorkflowExpression] Func<string> minIssuedDate = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> propertyHrId = null, [WorkflowExpression] Func<int> propertyId = null, [WorkflowExpression] Func<string> propertyName = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<int> sourceId = null, [WorkflowExpression] Func<sourceTypeInputItem[]> sourceType = null, [WorkflowExpression] Func<int[]> tagIds = null, [WorkflowExpression] Func<string> tagName = null, [WorkflowExpression] Func<int> unitId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/documents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (accountant != null)
                    callPayload.Queries["accountant"] = SourceExpressionConverter.ConvertO(accountant);
                if (administrator != null)
                    callPayload.Queries["administrator"] = SourceExpressionConverter.ConvertO(administrator);
                if (contactId != null)
                    callPayload.Queries["contactId"] = SourceExpressionConverter.ConvertO(contactId);
                if (contractName != null)
                    callPayload.Queries["contractName"] = SourceExpressionConverter.ConvertO(contractName);
                if (documentIds != null)
                    callPayload.Queries["documentIds"] = SourceExpressionConverter.ConvertO(documentIds);
                if (documentName != null)
                    callPayload.Queries["documentName"] = SourceExpressionConverter.ConvertO(documentName);
                if (issuedDate != null)
                    callPayload.Queries["issuedDate"] = SourceExpressionConverter.ConvertO(issuedDate);
                if (maxIssuedDate != null)
                    callPayload.Queries["maxIssuedDate"] = SourceExpressionConverter.ConvertO(maxIssuedDate);
                if (minIssuedDate != null)
                    callPayload.Queries["minIssuedDate"] = SourceExpressionConverter.ConvertO(minIssuedDate);
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (propertyHrId != null)
                    callPayload.Queries["propertyHrId"] = SourceExpressionConverter.ConvertO(propertyHrId);
                if (propertyId != null)
                    callPayload.Queries["propertyId"] = SourceExpressionConverter.ConvertO(propertyId);
                if (propertyName != null)
                    callPayload.Queries["propertyName"] = SourceExpressionConverter.ConvertO(propertyName);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (sourceId != null)
                    callPayload.Queries["sourceId"] = SourceExpressionConverter.ConvertO(sourceId);
                if (sourceType != null)
                    callPayload.Queries["sourceType"] = SourceExpressionConverter.ConvertO(sourceType);
                if (tagIds != null)
                    callPayload.Queries["tagIds"] = SourceExpressionConverter.ConvertO(tagIds);
                if (tagName != null)
                    callPayload.Queries["tagName"] = SourceExpressionConverter.ConvertO(tagName);
                if (unitId != null)
                    callPayload.Queries["unitId"] = SourceExpressionConverter.ConvertO(unitId);
                return callPayload;
            }

            return new ApiConnectionAction<PageOfDocumentDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<DocumentDto[]> UpdateDocumentsUsingPUT([WorkflowExpression] Func<DocumentUpdateDto[]> documentUpdateDtos = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/documents";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(documentUpdateDtos);
                return callPayload;
            }

            return new ApiConnectionAction<DocumentDto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<object> DownloadDocumentsByFilterUsingGET([WorkflowExpression] Func<string> accountant = null, [WorkflowExpression] Func<string> administrator = null, [WorkflowExpression] Func<int> contactId = null, [WorkflowExpression] Func<string> contractName = null, [WorkflowExpression] Func<int[]> documentIds = null, [WorkflowExpression] Func<string> documentName = null, [WorkflowExpression] Func<string> issuedDate = null, [WorkflowExpression] Func<string> maxIssuedDate = null, [WorkflowExpression] Func<string> minIssuedDate = null, [WorkflowExpression] Func<string> propertyHrId = null, [WorkflowExpression] Func<int> propertyId = null, [WorkflowExpression] Func<string> propertyName = null, [WorkflowExpression] Func<int> sourceId = null, [WorkflowExpression] Func<sourceTypeInputItem[]> sourceType = null, [WorkflowExpression] Func<int[]> tagIds = null, [WorkflowExpression] Func<string> tagName = null, [WorkflowExpression] Func<int> unitId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/documents/download-zip";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (accountant != null)
                    callPayload.Queries["accountant"] = SourceExpressionConverter.ConvertO(accountant);
                if (administrator != null)
                    callPayload.Queries["administrator"] = SourceExpressionConverter.ConvertO(administrator);
                if (contactId != null)
                    callPayload.Queries["contactId"] = SourceExpressionConverter.ConvertO(contactId);
                if (contractName != null)
                    callPayload.Queries["contractName"] = SourceExpressionConverter.ConvertO(contractName);
                if (documentIds != null)
                    callPayload.Queries["documentIds"] = SourceExpressionConverter.ConvertO(documentIds);
                if (documentName != null)
                    callPayload.Queries["documentName"] = SourceExpressionConverter.ConvertO(documentName);
                if (issuedDate != null)
                    callPayload.Queries["issuedDate"] = SourceExpressionConverter.ConvertO(issuedDate);
                if (maxIssuedDate != null)
                    callPayload.Queries["maxIssuedDate"] = SourceExpressionConverter.ConvertO(maxIssuedDate);
                if (minIssuedDate != null)
                    callPayload.Queries["minIssuedDate"] = SourceExpressionConverter.ConvertO(minIssuedDate);
                if (propertyHrId != null)
                    callPayload.Queries["propertyHrId"] = SourceExpressionConverter.ConvertO(propertyHrId);
                if (propertyId != null)
                    callPayload.Queries["propertyId"] = SourceExpressionConverter.ConvertO(propertyId);
                if (propertyName != null)
                    callPayload.Queries["propertyName"] = SourceExpressionConverter.ConvertO(propertyName);
                if (sourceId != null)
                    callPayload.Queries["sourceId"] = SourceExpressionConverter.ConvertO(sourceId);
                if (sourceType != null)
                    callPayload.Queries["sourceType"] = SourceExpressionConverter.ConvertO(sourceType);
                if (tagIds != null)
                    callPayload.Queries["tagIds"] = SourceExpressionConverter.ConvertO(tagIds);
                if (tagName != null)
                    callPayload.Queries["tagName"] = SourceExpressionConverter.ConvertO(tagName);
                if (unitId != null)
                    callPayload.Queries["unitId"] = SourceExpressionConverter.ConvertO(unitId);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IWorkflowAction DeleteDocumentUsingDELETE([WorkflowExpression] Func<int> documentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/documents/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(documentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<object> DownloadUsingGET([WorkflowExpression] Func<int> documentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/documents/{0}/download", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<InvoiceItemDto> UpdateInvoiceItemUsingPUT([WorkflowExpression] Func<int> invoiceItemId, [WorkflowExpression] Func<string> updateDtobookingTextOfTheInvoiceItem = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/invoice-items/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(invoiceItemId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var updateDto = new JObject();
                var updateDtopropCount = 0;
                if (updateDtobookingTextOfTheInvoiceItem != null)
                {
                    updateDto["bookingText"] = SourceExpressionConverter.ConvertToken(updateDtobookingTextOfTheInvoiceItem);
                    updateDtopropCount++;
                }

                if (updateDtopropCount > 0)
                {
                    callPayload.Body = updateDto;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InvoiceItemDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<PageOfInvoiceDto> GetInvoicesByFilterUsingGET([WorkflowExpression] Func<int> counterpartContactId = null, [WorkflowExpression] Func<string> issuedDate = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> propertyId = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<statesInputItem[]> states = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/invoices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (counterpartContactId != null)
                    callPayload.Queries["counterpartContactId"] = SourceExpressionConverter.ConvertO(counterpartContactId);
                if (issuedDate != null)
                    callPayload.Queries["issuedDate"] = SourceExpressionConverter.ConvertO(issuedDate);
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (propertyId != null)
                    callPayload.Queries["propertyId"] = SourceExpressionConverter.ConvertO(propertyId);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (states != null)
                    callPayload.Queries["states"] = SourceExpressionConverter.ConvertO(states);
                return callPayload;
            }

            return new ApiConnectionAction<PageOfInvoiceDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<InvoiceDto> GetInvoiceByIdUsingGET([WorkflowExpression] Func<int> invoiceId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/invoices/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(invoiceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<InvoiceDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<InvoiceDto> UpdateInvoiceUsingPUT([WorkflowExpression] Func<int> invoiceId, [WorkflowExpression] Func<string> updateDtonewIssuedDateOfTheInvoice = null, [WorkflowExpression] Func<string> updateDtonewNameOfTheInvoice = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/invoices/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(invoiceId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var updateDto = new JObject();
                var updateDtopropCount = 0;
                if (updateDtonewIssuedDateOfTheInvoice != null)
                {
                    updateDto["issuedDate"] = SourceExpressionConverter.ConvertToken(updateDtonewIssuedDateOfTheInvoice);
                    updateDtopropCount++;
                }

                if (updateDtonewNameOfTheInvoice != null)
                {
                    updateDto["name"] = SourceExpressionConverter.ConvertToken(updateDtonewNameOfTheInvoice);
                    updateDtopropCount++;
                }

                if (updateDtopropCount > 0)
                {
                    callPayload.Body = updateDto;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InvoiceDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<PageOfPropertyDto> GetPropertiesByFilterUsingGET([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> propertyHrId = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> sort = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/properties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (propertyHrId != null)
                    callPayload.Queries["propertyHrId"] = SourceExpressionConverter.ConvertO(propertyHrId);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<PageOfPropertyDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<PropertyDto> GetPropertyByIdUsingGET([WorkflowExpression] Func<int> propertyId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/properties/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(propertyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PropertyDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<PageOfUnitDto> GetUnitsByFilterUsingGET([WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> propertyId = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> sort = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/units";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (propertyId != null)
                    callPayload.Queries["propertyId"] = SourceExpressionConverter.ConvertO(propertyId);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<PageOfUnitDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<UnitDto> GetUnitByIdUsingGET([WorkflowExpression] Func<int> unitId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/units/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(unitId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UnitDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<LegacyInvoiceDto> GetInvoice([WorkflowExpression] Func<int> invoiceId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/services/pmp-accounting/api/v1/invoices/id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["invoiceId"] = SourceExpressionConverter.ConvertO(invoiceId);
                return callPayload;
            }

            return new ApiConnectionAction<LegacyInvoiceDto>(BuildSourceInput);
        }
    }

    public class ImpowerTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ConnectionDto> CreateConnectionUsingPOST(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/connections";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var connectionCreateDto = new JObject();
                var connectionCreateDtopropCount = 0;
                connectionCreateDto["appId"] = 4;
                connectionCreateDtopropCount++;
                connectionCreateDto["name"] = "Powerautomate webhook";
                connectionCreateDtopropCount++;
                connectionCreateDto["webhookUrl"] = "#{listCallbackUrl()}";
                connectionCreateDtopropCount++;
                if (connectionCreateDtopropCount > 0)
                {
                    callPayload.Body = connectionCreateDto;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<ConnectionDto>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public enum ErrorCodesUsingGETResponseItem
    {
        [EnumMember(Value = "BAD_CONTACT_ADDRESS")]
        BADCONTACTADDRESS,
        [EnumMember(Value = "BAD_TYPE_OF_EP")]
        BADTYPEOFEP,
        [EnumMember(Value = "BAD_STATE_OF_EP")]
        BADSTATEOFEP,
        [EnumMember(Value = "DUPLICATE_START_DATE")]
        DUPLICATESTARTDATE,
        [EnumMember(Value = "MISSING_CORRECTION_BOOKING_DATE")]
        MISSINGCORRECTIONBOOKINGDATE,
        [EnumMember(Value = "INVALID_ACCOUNT_AMOUNTS")]
        INVALIdACCOUNTAMOUNTS,
        [EnumMember(Value = "INVALID_PROPERTY")]
        INVALIdPROPERTY,
        [EnumMember(Value = "NOT_FOUND")]
        NOTFOUND,
        [EnumMember(Value = "MUST_REGENERATE_HGA")]
        MUSTREGENERATEHGA,
        [EnumMember(Value = "FAILED_RETRIEVING_REQUIRED_DATA")]
        FAILEDRETRIEVINGREQUIREDDATA,
        [EnumMember(Value = "WATERMARK_PDF_MUST_BE_ONE_PAGE")]
        WATERMARKPDFMUSTBEONEPAGE,
        [EnumMember(Value = "DOCUMENT_DOCUMENT_IS_REFERENCED")]
        DOCUMENTDOCUMENTISREFERENCED,
        [EnumMember(Value = "DS_NAME_NOT_UNIQUE")]
        DSNAMENOTUNIQUE,
        [EnumMember(Value = "DV_INVALID_START_END_DATE_MARKERS")]
        DVINVALIdSTARTENDDATEMARKERS,
        [EnumMember(Value = "DV_INVALID")]
        DVINVALId,
        [EnumMember(Value = "USER_DOMAIN_ALREADY_EXISTS")]
        USERDOMAINALREADYEXISTS,
        [EnumMember(Value = "USER_DOMAIN_REGISTRATION_DISABLED")]
        USERDOMAINREGISTRATIONDISABLED,
        [EnumMember(Value = "COMMON_VALIDATION_INVALID_DATA")]
        COMMONVALIdATIONINVALIdDATA,
        [EnumMember(Value = "WEG_OWNED_UNIT_CANNOT_HAVE_OWNER_CONTRACT")]
        WEGOWNEDUNITCANNOTHAVEOWNERCONTRACT
    }

    public class ErrorCodeDetailsDto
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public enum valueInput
    {
        [EnumMember(Value = "BAD_CONTACT_ADDRESS")]
        BADCONTACTADDRESS,
        [EnumMember(Value = "BAD_TYPE_OF_EP")]
        BADTYPEOFEP,
        [EnumMember(Value = "BAD_STATE_OF_EP")]
        BADSTATEOFEP,
        [EnumMember(Value = "DUPLICATE_START_DATE")]
        DUPLICATESTARTDATE,
        [EnumMember(Value = "MISSING_CORRECTION_BOOKING_DATE")]
        MISSINGCORRECTIONBOOKINGDATE,
        [EnumMember(Value = "INVALID_ACCOUNT_AMOUNTS")]
        INVALIdACCOUNTAMOUNTS,
        [EnumMember(Value = "INVALID_PROPERTY")]
        INVALIdPROPERTY,
        [EnumMember(Value = "NOT_FOUND")]
        NOTFOUND,
        [EnumMember(Value = "MUST_REGENERATE_HGA")]
        MUSTREGENERATEHGA,
        [EnumMember(Value = "FAILED_RETRIEVING_REQUIRED_DATA")]
        FAILEDRETRIEVINGREQUIREDDATA,
        [EnumMember(Value = "WATERMARK_PDF_MUST_BE_ONE_PAGE")]
        WATERMARKPDFMUSTBEONEPAGE,
        [EnumMember(Value = "DOCUMENT_DOCUMENT_IS_REFERENCED")]
        DOCUMENTDOCUMENTISREFERENCED,
        [EnumMember(Value = "DS_NAME_NOT_UNIQUE")]
        DSNAMENOTUNIQUE,
        [EnumMember(Value = "DV_INVALID_START_END_DATE_MARKERS")]
        DVINVALIdSTARTENDDATEMARKERS,
        [EnumMember(Value = "DV_INVALID")]
        DVINVALId,
        [EnumMember(Value = "USER_DOMAIN_ALREADY_EXISTS")]
        USERDOMAINALREADYEXISTS,
        [EnumMember(Value = "USER_DOMAIN_REGISTRATION_DISABLED")]
        USERDOMAINREGISTRATIONDISABLED,
        [EnumMember(Value = "COMMON_VALIDATION_INVALID_DATA")]
        COMMONVALIdATIONINVALIdDATA,
        [EnumMember(Value = "WEG_OWNED_UNIT_CANNOT_HAVE_OWNER_CONTRACT")]
        WEGOWNEDUNITCANNOTHAVEOWNERCONTRACT
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
        public string CountryCodeAccordingToISO31661Alpha2Standard { get; set; }

        [JsonProperty("created")]
        public string CreationTimeOfTheContact { get; set; }

        [JsonProperty("details")]
        public ContactDetailsDto Details { get; set; }

        [JsonProperty("firstName")]
        public string FirstNameOfTheContactInCaseTheContactIsAPerson { get; set; }

        [JsonProperty("id")]
        public int IDOfTheContactInstance { get; set; }

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
        public string VATIdOfTheContact { get; set; }

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

    public enum orderInput
    {
        ASC,
        DESC
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
        public int IDOfTheContractInstance { get; set; }

        [JsonProperty("isVacant")]
        public bool IsVacant { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("propertyId")]
        public int IDOfThePropertyInstanceTheContractBelongsTo { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("type")]
        public ContractDtoTypeType Type { get; set; }

        [JsonProperty("unitId")]
        public int IDOfTheUnitInstanceTheContractBelongsTo { get; set; }

        [JsonProperty("updated")]
        public string LastUpdateTimeOfTheContract { get; set; }
    }

    public class ContactSimpleDto
    {
        [JsonProperty("id")]
        public int IDOfTheContactInstance { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum ContractDtoTypeType
    {
        OWNER,
        TENANT,
        [EnumMember(Value = "PROPERTY_OWNER")]
        PROPERTYOWNER
    }

    public enum typeInputItem
    {
        OWNER,
        TENANT,
        [EnumMember(Value = "PROPERTY_OWNER")]
        PROPERTYOWNER
    }

    public class DocumentTagDto
    {
        [JsonProperty("description")]
        public string DescriptionOfTheDocumentTag { get; set; }

        [JsonProperty("id")]
        public int IDOfTheDocumentTag { get; set; }

        [JsonProperty("name")]
        public string NameOfTheDocumentTag { get; set; }
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
        public int IDOfTheBuildingTheDocumentBelongsTo { get; set; }

        [JsonProperty("contactId")]
        public int IDOfTheContactTheDocumentBelongsTo { get; set; }

        [JsonProperty("contractId")]
        public int IDOfTheContractTheDocumentBelongsTo { get; set; }

        [JsonProperty("created")]
        public string CreationTimeOfTheDocument { get; set; }

        [JsonProperty("id")]
        public int IDOfTheDocumentInstance { get; set; }

        [JsonProperty("issuedDate")]
        public string IssuedDateOfTheDocument { get; set; }

        [JsonProperty("name")]
        public string NameOfTheDocumentInstance { get; set; }

        [JsonProperty("propertyHrId")]
        public string PropertyHrId { get; set; }

        [JsonProperty("propertyId")]
        public int IDOfThePropertyTheDocumentBelongsTo { get; set; }

        [JsonProperty("propertyName")]
        public string NameOfThePropertyTheDocumentIsAssignedTo { get; set; }

        [JsonProperty("sourceId")]
        public int IDOfTheSourceEntityTheDocumentBelongsTo { get; set; }

        [JsonProperty("sourceType")]
        public DocumentDtoSourceTypeType SourceType { get; set; }

        [JsonProperty("state")]
        public DocumentDtoStateOfTheDocumentType StateOfTheDocument { get; set; }

        [JsonProperty("tags")]
        public DocumentTagSimpleDto[] Tags { get; set; }

        [JsonProperty("unitHrId")]
        public string HumanReadableIdOfTheUnitTheDocumentIsAssignedTo { get; set; }

        [JsonProperty("unitId")]
        public int IDOfTheUnitTheDocumentBelongsTo { get; set; }

        [JsonProperty("updated")]
        public string LastUpdateTimeOfTheDocument { get; set; }
    }

    public enum DocumentDtoSourceTypeType
    {
        [EnumMember(Value = "HOUSE_MONEY_SETTLEMENT")]
        HOUSEMONEYSETTLEMENT,
        [EnumMember(Value = "ECONOMIC_PLAN")]
        ECONOMICPLAN,
        [EnumMember(Value = "BANK_ORDER")]
        BANKORDER,
        [EnumMember(Value = "BANK_TRANSACTION")]
        BANKTRANSACTION,
        [EnumMember(Value = "HEATING_COST_DISTRIBUTION")]
        HEATINGCOSTDISTRIBUTION,
        INVOICE,
        [EnumMember(Value = "SERIAL_LETTER")]
        SERIALLETTER,
        [EnumMember(Value = "OWNERS_MEETING_INVITATION")]
        OWNERSMEETINGINVITATION,
        [EnumMember(Value = "OWNERS_MEETING_PROTOCOL")]
        OWNERSMEETINGPROTOCOL,
        [EnumMember(Value = "PROFIT_AND_LOSS")]
        PROFITANDLOSS,
        [EnumMember(Value = "OPS_COST_REPORT")]
        OPSCOSTREPORT,
        [EnumMember(Value = "SPECIAL_CONTRIBUTION")]
        SPECIALCONTRIBUTION,
        [EnumMember(Value = "DUNNING_ANNEX")]
        DUNNINGANNEX,
        DUNNING,
        [EnumMember(Value = "DUNNING_DD_MANDATE")]
        DUNNINGDDMANDATE,
        WATERMARK,
        MESSAGE,
        OTHER
    }

    public enum DocumentDtoStateOfTheDocumentType
    {
        DRAFT,
        GENERATING,
        READY,
        FAILED,
        DELETED
    }

    public class DocumentTagSimpleDto
    {
        [JsonProperty("id")]
        public int UniqueIdentifierOfTheDocumentTag { get; set; }

        [JsonProperty("name")]
        public string NameOfTheDocumentTag { get; set; }
    }

    public enum sourceTypeInputItem
    {
        [EnumMember(Value = "HOUSE_MONEY_SETTLEMENT")]
        HOUSEMONEYSETTLEMENT,
        [EnumMember(Value = "ECONOMIC_PLAN")]
        ECONOMICPLAN,
        [EnumMember(Value = "BANK_ORDER")]
        BANKORDER,
        [EnumMember(Value = "BANK_TRANSACTION")]
        BANKTRANSACTION,
        [EnumMember(Value = "HEATING_COST_DISTRIBUTION")]
        HEATINGCOSTDISTRIBUTION,
        INVOICE,
        [EnumMember(Value = "SERIAL_LETTER")]
        SERIALLETTER,
        [EnumMember(Value = "OWNERS_MEETING_INVITATION")]
        OWNERSMEETINGINVITATION,
        [EnumMember(Value = "OWNERS_MEETING_PROTOCOL")]
        OWNERSMEETINGPROTOCOL,
        [EnumMember(Value = "PROFIT_AND_LOSS")]
        PROFITANDLOSS,
        [EnumMember(Value = "OPS_COST_REPORT")]
        OPSCOSTREPORT,
        [EnumMember(Value = "SPECIAL_CONTRIBUTION")]
        SPECIALCONTRIBUTION,
        [EnumMember(Value = "DUNNING_ANNEX")]
        DUNNINGANNEX,
        DUNNING,
        [EnumMember(Value = "DUNNING_DD_MANDATE")]
        DUNNINGDDMANDATE,
        WATERMARK,
        MESSAGE,
        OTHER
    }

    public class DocumentUpdateDto
    {
        [JsonProperty("amount")]
        public double NewValueTheDocumentAmountToBeUpdatedTo { get; set; }

        [JsonProperty("buildingId")]
        public int NewBuildingBuildingTheDocumentToBeAssignedTo { get; set; }

        [JsonProperty("contactId")]
        public int NewContactTheDocumentToBeAssignedTo { get; set; }

        [JsonProperty("contractId")]
        public int NewContractTheDocumentToBeAssignedTo { get; set; }

        [JsonProperty("id")]
        public int TheUniqueIdentifierOfTheDocumentToBeUpdated { get; set; }

        [JsonProperty("issuedDate")]
        public string NewDateTheDocumentIssuedDateToBeUpdatedTo { get; set; }

        [JsonProperty("name")]
        public string NewValueTheDocumentNameToBeUpdatedTo { get; set; }

        [JsonProperty("propertyId")]
        public int NewPropertyTheDocumentToBeAssignedTo { get; set; }

        [JsonProperty("sourceId")]
        public int NewSourceProcessIdTheDocumentToBeAssignedTo { get; set; }

        [JsonProperty("tagIds")]
        public int[] IdentifiersOfTagsToBeAssignedToTheDocument { get; set; }

        [JsonProperty("unitId")]
        public int NewUnitTheDocumentToBeAssignedTo { get; set; }
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

    public enum InvoiceItemDtoLaborCostTypeType
    {
        [EnumMember(Value = "HOUSEHOLD_RELATED_SERVICES")]
        HOUSEHOLDRELATEDSERVICES,
        [EnumMember(Value = "TECHNICIAN_SERVICE")]
        TECHNICIANSERVICE,
        [EnumMember(Value = "MARGINAL_EMPLOYMENT")]
        MARGINALEMPLOYMENT,
        [EnumMember(Value = "INSURABLE_EMPLOYMENT")]
        INSURABLEEMPLOYMENT
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
        public int IDOfTheCounterpartContactOfTheInvoice { get; set; }

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
        public string BICNumberOfTheCounterpartSBankAccount { get; set; }

        [JsonProperty("orderCounterpartIban")]
        public string IBANOfTheCounterpartSBankAccount { get; set; }

        [JsonProperty("orderDayOffset")]
        public int OrderDayOffset { get; set; }

        [JsonProperty("orderPropertyBankAccountId")]
        public int UniqueIdentifierOfTheBankAccountOfTheProperty { get; set; }

        [JsonProperty("orderPropertyBic")]
        public string BICNumberOfThePropertyBankAccount { get; set; }

        [JsonProperty("orderPropertyIban")]
        public string IBANOfThePropertyBankAccount { get; set; }

        [JsonProperty("orderRequired")]
        public bool TrueInCaseThereIsACorrespondingOrderOfTheInvoice { get; set; }

        [JsonProperty("orderStatement")]
        public string StatementOfTheGeneratedOrder { get; set; }

        [JsonProperty("propertyHrId")]
        public string HumanReadableIdOfThePropertyTheInvoiceBelongsTo { get; set; }

        [JsonProperty("propertyId")]
        public int IDOfThePropertyTheInvoiceBelongsTo { get; set; }

        [JsonProperty("propertyName")]
        public string NameOfThePropertyTheInvoiceBelongsTo { get; set; }

        [JsonProperty("state")]
        public InvoiceDtoStateType State { get; set; }

        [JsonProperty("updated")]
        public string LastUpdateTimeOfTheEntity { get; set; }
    }

    public enum InvoiceDtoStateType
    {
        DRAFT,
        READY,
        BOOKED,
        SCHEDULED,
        REVERSED
    }

    public enum statesInputItem
    {
        DRAFT,
        READY,
        BOOKED,
        SCHEDULED,
        REVERSED
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
        public int IDOfThePropertyInstance { get; set; }

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

    public enum PropertyDtoStateType
    {
        DRAFT,
        READY,
        DISABLED
    }

    public enum PropertyDtoTypeType
    {
        OWNER,
        RENTAL
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
        public int IDOfTheUnitInstance { get; set; }

        [JsonProperty("position")]
        public string PositionOfTheUnitWithinTheFloor { get; set; }

        [JsonProperty("propertyId")]
        public int IDOfThePropertyInstanceTheUnitBelongsTo { get; set; }

        [JsonProperty("type")]
        public UnitDtoTypeType Type { get; set; }

        [JsonProperty("unitHrId")]
        public string HumanReadableIdOfTheUnitInstance { get; set; }

        [JsonProperty("unitRank")]
        public int UnitRank { get; set; }

        [JsonProperty("updated")]
        public string UpdateTimeOfTheUnitInstance { get; set; }
    }

    public enum UnitDtoTypeType
    {
        APARTMENT,
        PARKING,
        OTHER,
        COMMERCIAL
    }

    public class LegacyInvoiceDto
    {
        [JsonProperty("counterpartBic")]
        public string BICCounterpart { get; set; }

        [JsonProperty("counterpartContactId")]
        public int ContactIDCounterpart { get; set; }

        [JsonProperty("counterpartIban")]
        public string IBANCounterpart { get; set; }

        [JsonProperty("counterpartName")]
        public string Counterpart { get; set; }

        [JsonProperty("created")]
        public string Date { get; set; }

        [JsonProperty("documentUrl")]
        public string InvoiceURL { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("invoiceDate")]
        public string InvoiceDate { get; set; }

        [JsonProperty("invoiceHrId")]
        public string InvoiceID { get; set; }

        [JsonProperty("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("paymentTargetDate")]
        public string PaymentTargetDate { get; set; }

        [JsonProperty("paymentType")]
        public string PaymentType { get; set; }

        [JsonProperty("propertyHrId")]
        public string PropertyNR { get; set; }

        [JsonProperty("propertyId")]
        public int PropertyID { get; set; }

        [JsonProperty("propertyIdInternal")]
        public string PropertyInternalID { get; set; }

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
        public bool VATIncl { get; set; }

        [JsonProperty("vatPercentage")]
        public double VATPercentage { get; set; }
    }

    public enum LegacyInvoiceDtoStatusOfInvoiceType
    {
        NEW,
        APPROVED,
        RECURRING,
        [EnumMember(Value = "RECURRING_STOPPED")]
        RECURRINGSTOPPED,
        DELETED
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