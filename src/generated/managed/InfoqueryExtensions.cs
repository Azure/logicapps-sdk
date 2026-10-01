//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Infoquery
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InfoqueryActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<AddNewPartnerEmployeeToPartnerCompanyResponse> AddNewPartnerEmployeeToPartnerCompany([WorkflowExpression] Func<string> partnerCompanyId, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodypasswordExpirationDate = null, [WorkflowExpression] Func<bool> bodyenabled = null, [WorkflowExpression] Func<bool> bodywebsiteAccess = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodycontactInformationemailAddress = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AddNewPartnerEmployeeToPartnerCompany";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["PartnerCompanyID"] = SourceExpressionConverter.ConvertO(partnerCompanyId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypassword != null)
                {
                    body["Password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodypasswordExpirationDate != null)
                {
                    body["PasswordExpirationDate"] = SourceExpressionConverter.ConvertToken(bodypasswordExpirationDate);
                    bodypropCount++;
                }

                if (bodyenabled != null)
                {
                    body["Enabled"] = SourceExpressionConverter.ConvertToken(bodyenabled);
                    bodypropCount++;
                }

                if (bodywebsiteAccess != null)
                {
                    body["WebsiteAccess"] = SourceExpressionConverter.ConvertToken(bodywebsiteAccess);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["FirstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["LastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                var contactInformationObject = new JObject();
                var contactInformationObjectpropCount = 0;
                if (bodycontactInformationemailAddress != null)
                {
                    contactInformationObject["EmailAddress"] = SourceExpressionConverter.ConvertToken(bodycontactInformationemailAddress);
                    contactInformationObjectpropCount++;
                }

                if (contactInformationObjectpropCount > 0)
                {
                    body["ContactInformation"] = contactInformationObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddNewPartnerEmployeeToPartnerCompanyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<CreateNewFileResponse> CreateNewFile([WorkflowExpression] Func<bodybuyersInputItem[]> bodybuyers = null, [WorkflowExpression] Func<bodysellersInputItem[]> bodysellers = null, [WorkflowExpression] Func<string> bodyestimatedSettlementDate = null, [WorkflowExpression] Func<int> bodytransactionProductTypetransactionTypeId = null, [WorkflowExpression] Func<int> bodytransactionProductTypeproductTypeId = null, [WorkflowExpression] Func<int> bodysalesPrice = null, [WorkflowExpression] Func<string> bodyclientFileNumber = null, [WorkflowExpression] Func<string> bodypiggybackFileNumber = null, [WorkflowExpression] Func<string> bodymainFileNumber = null, [WorkflowExpression] Func<int> bodysourceOfBusinessId = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<bodycustomFieldsInputItem[]> bodycustomFields = null, [WorkflowExpression] Func<bodyloansInputItem[]> bodyloans = null, [WorkflowExpression] Func<bodypropertiesInputItem[]> bodyproperties = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CreateNewFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodybuyers != null)
                {
                    body["Buyers"] = SourceExpressionConverter.ConvertToken(bodybuyers);
                    bodypropCount++;
                }

                if (bodysellers != null)
                {
                    body["Sellers"] = SourceExpressionConverter.ConvertToken(bodysellers);
                    bodypropCount++;
                }

                if (bodyestimatedSettlementDate != null)
                {
                    body["EstimatedSettlementDate"] = SourceExpressionConverter.ConvertToken(bodyestimatedSettlementDate);
                    bodypropCount++;
                }

                var transactionProductTypeObject = new JObject();
                var transactionProductTypeObjectpropCount = 0;
                if (bodytransactionProductTypetransactionTypeId != null)
                {
                    transactionProductTypeObject["TransactionTypeID"] = SourceExpressionConverter.ConvertToken(bodytransactionProductTypetransactionTypeId);
                    transactionProductTypeObjectpropCount++;
                }

                if (bodytransactionProductTypeproductTypeId != null)
                {
                    transactionProductTypeObject["ProductTypeID"] = SourceExpressionConverter.ConvertToken(bodytransactionProductTypeproductTypeId);
                    transactionProductTypeObjectpropCount++;
                }

                if (transactionProductTypeObjectpropCount > 0)
                {
                    body["TransactionProductType"] = transactionProductTypeObject;
                    bodypropCount++;
                }

                if (bodysalesPrice != null)
                {
                    body["SalesPrice"] = SourceExpressionConverter.ConvertToken(bodysalesPrice);
                    bodypropCount++;
                }

                if (bodyclientFileNumber != null)
                {
                    body["ClientFileNumber"] = SourceExpressionConverter.ConvertToken(bodyclientFileNumber);
                    bodypropCount++;
                }

                if (bodypiggybackFileNumber != null)
                {
                    body["PiggybackFileNumber"] = SourceExpressionConverter.ConvertToken(bodypiggybackFileNumber);
                    bodypropCount++;
                }

                if (bodymainFileNumber != null)
                {
                    body["MainFileNumber"] = SourceExpressionConverter.ConvertToken(bodymainFileNumber);
                    bodypropCount++;
                }

                if (bodysourceOfBusinessId != null)
                {
                    body["SourceOfBusinessID"] = SourceExpressionConverter.ConvertToken(bodysourceOfBusinessId);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["Note"] = SourceExpressionConverter.ConvertToken(bodynote);
                    bodypropCount++;
                }

                if (bodycustomFields != null)
                {
                    body["CustomFields"] = SourceExpressionConverter.ConvertToken(bodycustomFields);
                    bodypropCount++;
                }

                if (bodyloans != null)
                {
                    body["Loans"] = SourceExpressionConverter.ConvertToken(bodyloans);
                    bodypropCount++;
                }

                if (bodyproperties != null)
                {
                    body["Properties"] = SourceExpressionConverter.ConvertToken(bodyproperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateNewFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItem[]> GetTransactionAndProductTypesForEstimationAndOrderPlacement([WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<string> county = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetTransactionAndProductTypesForEstimationAndOrderPlacement";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (state != null)
                    callPayload.Queries["State"] = SourceExpressionConverter.ConvertO(state);
                if (county != null)
                    callPayload.Queries["County"] = SourceExpressionConverter.ConvertO(county);
                return callPayload;
            }

            return new ApiConnectionAction<GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<UpdateActionForFileResponse> UpdateActionForFile([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<string> fileActionId, [WorkflowExpression] Func<int> bodystartTaskcoordinatorTypeId = null, [WorkflowExpression] Func<string> bodystartTaskdueDate = null, [WorkflowExpression] Func<bool> bodystartTaskdoneDateLocked = null, [WorkflowExpression] Func<int> bodycompleteTaskcoordinatorTypeId = null, [WorkflowExpression] Func<string> bodycompleteTaskdueDate = null, [WorkflowExpression] Func<bool> bodycompleteTaskdoneDateLocked = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UpdateActionForFile";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = SourceExpressionConverter.ConvertO(fileId);
                callPayload.Queries["FileActionID"] = SourceExpressionConverter.ConvertO(fileActionId);
                var body = new JObject();
                var bodypropCount = 0;
                var startTaskObject = new JObject();
                var startTaskObjectpropCount = 0;
                if (bodystartTaskcoordinatorTypeId != null)
                {
                    startTaskObject["CoordinatorTypeID"] = SourceExpressionConverter.ConvertToken(bodystartTaskcoordinatorTypeId);
                    startTaskObjectpropCount++;
                }

                if (bodystartTaskdueDate != null)
                {
                    startTaskObject["DueDate"] = SourceExpressionConverter.ConvertToken(bodystartTaskdueDate);
                    startTaskObjectpropCount++;
                }

                if (bodystartTaskdoneDateLocked != null)
                {
                    startTaskObject["DoneDateLocked"] = SourceExpressionConverter.ConvertToken(bodystartTaskdoneDateLocked);
                    startTaskObjectpropCount++;
                }

                if (startTaskObjectpropCount > 0)
                {
                    body["StartTask"] = startTaskObject;
                    bodypropCount++;
                }

                var completeTaskObject = new JObject();
                var completeTaskObjectpropCount = 0;
                if (bodycompleteTaskcoordinatorTypeId != null)
                {
                    completeTaskObject["CoordinatorTypeID"] = SourceExpressionConverter.ConvertToken(bodycompleteTaskcoordinatorTypeId);
                    completeTaskObjectpropCount++;
                }

                if (bodycompleteTaskdueDate != null)
                {
                    completeTaskObject["DueDate"] = SourceExpressionConverter.ConvertToken(bodycompleteTaskdueDate);
                    completeTaskObjectpropCount++;
                }

                if (bodycompleteTaskdoneDateLocked != null)
                {
                    completeTaskObject["DoneDateLocked"] = SourceExpressionConverter.ConvertToken(bodycompleteTaskdoneDateLocked);
                    completeTaskObjectpropCount++;
                }

                if (completeTaskObjectpropCount > 0)
                {
                    body["CompleteTask"] = completeTaskObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateActionForFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken> GetsFilesFromGivenSearchCriteria([WorkflowExpression] Func<string> bodyfileNumber = null, [WorkflowExpression] Func<int> bodyfileId = null, [WorkflowExpression] Func<int> bodyofficeId = null, [WorkflowExpression] Func<string> bodyclientsFileNumber = null, [WorkflowExpression] Func<int> bodytransactionProductTypetransactionTypeId = null, [WorkflowExpression] Func<int> bodytransactionProductTypeproductTypeId = null, [WorkflowExpression] Func<bodystatusesInputItem[]> bodystatuses = null, [WorkflowExpression] Func<string> bodypolicyNumber = null, [WorkflowExpression] Func<string> bodysearchNumber = null, [WorkflowExpression] Func<string> bodyloanNumber = null, [WorkflowExpression] Func<bool> bodypropertyisPrimary = null, [WorkflowExpression] Func<string> bodypropertystreetNumber = null, [WorkflowExpression] Func<string> bodypropertystreetName = null, [WorkflowExpression] Func<string> bodypropertycity = null, [WorkflowExpression] Func<string> bodypropertystate = null, [WorkflowExpression] Func<string> bodypropertyzip = null, [WorkflowExpression] Func<string> bodypropertysubdivision = null, [WorkflowExpression] Func<string> bodypropertyparcelId = null, [WorkflowExpression] Func<string> bodybuyerentityType = null, [WorkflowExpression] Func<string> bodybuyerprimaryfirst = null, [WorkflowExpression] Func<string> bodybuyerprimarylast = null, [WorkflowExpression] Func<bool> bodybuyerusePropertyAddress = null, [WorkflowExpression] Func<string> bodybuyermaritalStatus = null, [WorkflowExpression] Func<int> bodyfilePartnerprimaryEmployeeuserId = null, [WorkflowExpression] Func<int> bodyfilePartnerpartnerTypeId = null, [WorkflowExpression] Func<int> bodyfilePartnerpartnerId = null, [WorkflowExpression] Func<int> bodyfilePartnerpartnerTypepartnerTypeId = null, [WorkflowExpression] Func<string> bodyopenedFromDate = null, [WorkflowExpression] Func<string> bodyopenedToDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetsFilesFromGivenSearchCriteria";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfileNumber != null)
                {
                    body["FileNumber"] = SourceExpressionConverter.ConvertToken(bodyfileNumber);
                    bodypropCount++;
                }

                if (bodyfileId != null)
                {
                    body["FileID"] = SourceExpressionConverter.ConvertToken(bodyfileId);
                    bodypropCount++;
                }

                if (bodyofficeId != null)
                {
                    body["OfficeID"] = SourceExpressionConverter.ConvertToken(bodyofficeId);
                    bodypropCount++;
                }

                if (bodyclientsFileNumber != null)
                {
                    body["ClientsFileNumber"] = SourceExpressionConverter.ConvertToken(bodyclientsFileNumber);
                    bodypropCount++;
                }

                var transactionProductTypeObject = new JObject();
                var transactionProductTypeObjectpropCount = 0;
                if (bodytransactionProductTypetransactionTypeId != null)
                {
                    transactionProductTypeObject["TransactionTypeID"] = SourceExpressionConverter.ConvertToken(bodytransactionProductTypetransactionTypeId);
                    transactionProductTypeObjectpropCount++;
                }

                if (bodytransactionProductTypeproductTypeId != null)
                {
                    transactionProductTypeObject["ProductTypeID"] = SourceExpressionConverter.ConvertToken(bodytransactionProductTypeproductTypeId);
                    transactionProductTypeObjectpropCount++;
                }

                if (transactionProductTypeObjectpropCount > 0)
                {
                    body["TransactionProductType"] = transactionProductTypeObject;
                    bodypropCount++;
                }

                if (bodystatuses != null)
                {
                    body["Statuses"] = SourceExpressionConverter.ConvertToken(bodystatuses);
                    bodypropCount++;
                }

                if (bodypolicyNumber != null)
                {
                    body["PolicyNumber"] = SourceExpressionConverter.ConvertToken(bodypolicyNumber);
                    bodypropCount++;
                }

                if (bodysearchNumber != null)
                {
                    body["SearchNumber"] = SourceExpressionConverter.ConvertToken(bodysearchNumber);
                    bodypropCount++;
                }

                if (bodyloanNumber != null)
                {
                    body["LoanNumber"] = SourceExpressionConverter.ConvertToken(bodyloanNumber);
                    bodypropCount++;
                }

                var propertyObject = new JObject();
                var propertyObjectpropCount = 0;
                if (bodypropertyisPrimary != null)
                {
                    propertyObject["IsPrimary"] = SourceExpressionConverter.ConvertToken(bodypropertyisPrimary);
                    propertyObjectpropCount++;
                }

                if (bodypropertystreetNumber != null)
                {
                    propertyObject["StreetNumber"] = SourceExpressionConverter.ConvertToken(bodypropertystreetNumber);
                    propertyObjectpropCount++;
                }

                if (bodypropertystreetName != null)
                {
                    propertyObject["StreetName"] = SourceExpressionConverter.ConvertToken(bodypropertystreetName);
                    propertyObjectpropCount++;
                }

                if (bodypropertycity != null)
                {
                    propertyObject["City"] = SourceExpressionConverter.ConvertToken(bodypropertycity);
                    propertyObjectpropCount++;
                }

                if (bodypropertystate != null)
                {
                    propertyObject["State"] = SourceExpressionConverter.ConvertToken(bodypropertystate);
                    propertyObjectpropCount++;
                }

                if (bodypropertyzip != null)
                {
                    propertyObject["Zip"] = SourceExpressionConverter.ConvertToken(bodypropertyzip);
                    propertyObjectpropCount++;
                }

                if (bodypropertysubdivision != null)
                {
                    propertyObject["Subdivision"] = SourceExpressionConverter.ConvertToken(bodypropertysubdivision);
                    propertyObjectpropCount++;
                }

                if (bodypropertyparcelId != null)
                {
                    propertyObject["ParcelID"] = SourceExpressionConverter.ConvertToken(bodypropertyparcelId);
                    propertyObjectpropCount++;
                }

                if (propertyObjectpropCount > 0)
                {
                    body["Property"] = propertyObject;
                    bodypropCount++;
                }

                var buyerObject = new JObject();
                var buyerObjectpropCount = 0;
                if (bodybuyerentityType != null)
                {
                    buyerObject["EntityType"] = SourceExpressionConverter.ConvertToken(bodybuyerentityType);
                    buyerObjectpropCount++;
                }

                var primaryObject = new JObject();
                var primaryObjectpropCount = 0;
                if (bodybuyerprimaryfirst != null)
                {
                    primaryObject["First"] = SourceExpressionConverter.ConvertToken(bodybuyerprimaryfirst);
                    primaryObjectpropCount++;
                }

                if (bodybuyerprimarylast != null)
                {
                    primaryObject["Last"] = SourceExpressionConverter.ConvertToken(bodybuyerprimarylast);
                    primaryObjectpropCount++;
                }

                if (primaryObjectpropCount > 0)
                {
                    buyerObject["Primary"] = primaryObject;
                    buyerObjectpropCount++;
                }

                if (bodybuyerusePropertyAddress != null)
                {
                    buyerObject["UsePropertyAddress"] = SourceExpressionConverter.ConvertToken(bodybuyerusePropertyAddress);
                    buyerObjectpropCount++;
                }

                if (bodybuyermaritalStatus != null)
                {
                    buyerObject["MaritalStatus"] = SourceExpressionConverter.ConvertToken(bodybuyermaritalStatus);
                    buyerObjectpropCount++;
                }

                if (buyerObjectpropCount > 0)
                {
                    body["Buyer"] = buyerObject;
                    bodypropCount++;
                }

                var filePartnerObject = new JObject();
                var filePartnerObjectpropCount = 0;
                var primaryEmployeeObject = new JObject();
                var primaryEmployeeObjectpropCount = 0;
                if (bodyfilePartnerprimaryEmployeeuserId != null)
                {
                    primaryEmployeeObject["UserID"] = SourceExpressionConverter.ConvertToken(bodyfilePartnerprimaryEmployeeuserId);
                    primaryEmployeeObjectpropCount++;
                }

                if (primaryEmployeeObjectpropCount > 0)
                {
                    filePartnerObject["PrimaryEmployee"] = primaryEmployeeObject;
                    filePartnerObjectpropCount++;
                }

                if (bodyfilePartnerpartnerTypeId != null)
                {
                    filePartnerObject["PartnerTypeID"] = SourceExpressionConverter.ConvertToken(bodyfilePartnerpartnerTypeId);
                    filePartnerObjectpropCount++;
                }

                if (bodyfilePartnerpartnerId != null)
                {
                    filePartnerObject["PartnerID"] = SourceExpressionConverter.ConvertToken(bodyfilePartnerpartnerId);
                    filePartnerObjectpropCount++;
                }

                var partnerTypeObject = new JObject();
                var partnerTypeObjectpropCount = 0;
                if (bodyfilePartnerpartnerTypepartnerTypeId != null)
                {
                    partnerTypeObject["PartnerTypeID"] = SourceExpressionConverter.ConvertToken(bodyfilePartnerpartnerTypepartnerTypeId);
                    partnerTypeObjectpropCount++;
                }

                if (partnerTypeObjectpropCount > 0)
                {
                    filePartnerObject["PartnerType"] = partnerTypeObject;
                    filePartnerObjectpropCount++;
                }

                if (filePartnerObjectpropCount > 0)
                {
                    body["FilePartner"] = filePartnerObject;
                    bodypropCount++;
                }

                if (bodyopenedFromDate != null)
                {
                    body["OpenedFromDate"] = SourceExpressionConverter.ConvertToken(bodyopenedFromDate);
                    bodypropCount++;
                }

                if (bodyopenedToDate != null)
                {
                    body["OpenedToDate"] = SourceExpressionConverter.ConvertToken(bodyopenedToDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken> DeletePartnerOnSpecificFile([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<bodypartnersInputItem[]> bodypartners = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DeletePartnerOnSpecificFile";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = SourceExpressionConverter.ConvertO(fileId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypartners != null)
                {
                    body["Partners"] = SourceExpressionConverter.ConvertToken(bodypartners);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetPartnerInformationResponse> GetPartnerInformation([WorkflowExpression] Func<string> partnerCompanyId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetPartnerInformation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["PartnerCompanyID"] = SourceExpressionConverter.ConvertO(partnerCompanyId);
                return callPayload;
            }

            return new ApiConnectionAction<GetPartnerInformationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken> CancelsPreviouslyPlacedOrder([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<int> bodyfileId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CancelsPreviouslyPlacedOrder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = SourceExpressionConverter.ConvertO(fileId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfileId != null)
                {
                    body["FileID"] = SourceExpressionConverter.ConvertToken(bodyfileId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<CreateNewDocumentOnSpecificFileResponse> CreateNewDocumentOnSpecificFile([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<string> bodydocumentName = null, [WorkflowExpression] Func<int> bodydocumentTypedocumentTypeId = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyinternalOnly = null, [WorkflowExpression] Func<string> bodydocumentBody = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CreateNewDocumentOnSpecificFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = SourceExpressionConverter.ConvertO(fileId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydocumentName != null)
                {
                    body["DocumentName"] = SourceExpressionConverter.ConvertToken(bodydocumentName);
                    bodypropCount++;
                }

                var documentTypeObject = new JObject();
                var documentTypeObjectpropCount = 0;
                if (bodydocumentTypedocumentTypeId != null)
                {
                    documentTypeObject["DocumentTypeID"] = SourceExpressionConverter.ConvertToken(bodydocumentTypedocumentTypeId);
                    documentTypeObjectpropCount++;
                }

                if (documentTypeObjectpropCount > 0)
                {
                    body["DocumentType"] = documentTypeObject;
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyinternalOnly != null)
                {
                    body["InternalOnly"] = SourceExpressionConverter.ConvertToken(bodyinternalOnly);
                    bodypropCount++;
                }

                if (bodydocumentBody != null)
                {
                    body["DocumentBody"] = SourceExpressionConverter.ConvertToken(bodydocumentBody);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateNewDocumentOnSpecificFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken> DeletePreviouslyPlacedOrder([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<int> bodyfileId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DeletePreviouslyPlacedOrder";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = SourceExpressionConverter.ConvertO(fileId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfileId != null)
                {
                    body["FileID"] = SourceExpressionConverter.ConvertToken(bodyfileId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken> AddOrUpdateCustomFieldOnSpecificFile([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<bodycustomFieldsInputItem[]> bodycustomFields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AddOrUpdateCustomFieldOnSpecificFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = SourceExpressionConverter.ConvertO(fileId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycustomFields != null)
                {
                    body["CustomFields"] = SourceExpressionConverter.ConvertToken(bodycustomFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken> AddPartnerToSpecificFile([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<bodypartnersInputItem2[]> bodypartners = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AddPartnerToSpecificFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = SourceExpressionConverter.ConvertO(fileId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypartners != null)
                {
                    body["Partners"] = SourceExpressionConverter.ConvertToken(bodypartners);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<UpdatePartnerInformationForSpecificFileResponse> UpdatePartnerInformationForSpecificFile([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<string> partnerId, [WorkflowExpression] Func<int> bodyfileId = null, [WorkflowExpression] Func<int> bodyprimaryEmployeeuserId = null, [WorkflowExpression] Func<string> bodyprimaryEmployeename = null, [WorkflowExpression] Func<string> bodyprimaryEmployeefirstName = null, [WorkflowExpression] Func<string> bodyprimaryEmployeelastName = null, [WorkflowExpression] Func<string> bodyprimaryEmployeecontactInformationphoneNumber = null, [WorkflowExpression] Func<string> bodyprimaryEmployeecontactInformationhomePhoneNumber = null, [WorkflowExpression] Func<string> bodyprimaryEmployeecontactInformationcellPhoneNumber = null, [WorkflowExpression] Func<string> bodyprimaryEmployeecontactInformationvoicemail = null, [WorkflowExpression] Func<string> bodyprimaryEmployeecontactInformationfaxNumber = null, [WorkflowExpression] Func<string> bodyprimaryEmployeecontactInformationemailAddress = null, [WorkflowExpression] Func<string> bodyprimaryEmployeecontactInformationpreferredCommunicationMethod = null, [WorkflowExpression] Func<string> bodyprimaryEmployeecontactInformationwebsite = null, [WorkflowExpression] Func<bodysecondaryEmployeesInputItem[]> bodysecondaryEmployees = null, [WorkflowExpression] Func<string> bodyreferenceNumber = null, [WorkflowExpression] Func<string> bodyremoteFileNumber = null, [WorkflowExpression] Func<int> bodypartnerTypeId = null, [WorkflowExpression] Func<int> bodypartnerId = null, [WorkflowExpression] Func<int> bodypartnerTypepartnerTypeId = null, [WorkflowExpression] Func<string> bodypartnerTypepartnerTypeName = null, [WorkflowExpression] Func<int> bodyofficeId = null, [WorkflowExpression] Func<string> bodypartnerName = null, [WorkflowExpression] Func<string> bodymailingAddressaddress1 = null, [WorkflowExpression] Func<string> bodymailingAddressaddress2 = null, [WorkflowExpression] Func<string> bodymailingAddresscity = null, [WorkflowExpression] Func<string> bodymailingAddressstate = null, [WorkflowExpression] Func<string> bodymailingAddresszip = null, [WorkflowExpression] Func<string> bodycontactInformationphoneNumber = null, [WorkflowExpression] Func<string> bodycontactInformationhomePhoneNumber = null, [WorkflowExpression] Func<string> bodycontactInformationcellPhoneNumber = null, [WorkflowExpression] Func<string> bodycontactInformationvoicemail = null, [WorkflowExpression] Func<string> bodycontactInformationfaxNumber = null, [WorkflowExpression] Func<string> bodycontactInformationemailAddress = null, [WorkflowExpression] Func<string> bodycontactInformationpreferredCommunicationMethod = null, [WorkflowExpression] Func<string> bodycontactInformationwebsite = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UpdatePartnerInformationForSpecificFile";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = SourceExpressionConverter.ConvertO(fileId);
                callPayload.Queries["PartnerID"] = SourceExpressionConverter.ConvertO(partnerId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfileId != null)
                {
                    body["FileID"] = SourceExpressionConverter.ConvertToken(bodyfileId);
                    bodypropCount++;
                }

                var primaryEmployeeObject = new JObject();
                var primaryEmployeeObjectpropCount = 0;
                if (bodyprimaryEmployeeuserId != null)
                {
                    primaryEmployeeObject["UserID"] = SourceExpressionConverter.ConvertToken(bodyprimaryEmployeeuserId);
                    primaryEmployeeObjectpropCount++;
                }

                if (bodyprimaryEmployeename != null)
                {
                    primaryEmployeeObject["Name"] = SourceExpressionConverter.ConvertToken(bodyprimaryEmployeename);
                    primaryEmployeeObjectpropCount++;
                }

                if (bodyprimaryEmployeefirstName != null)
                {
                    primaryEmployeeObject["FirstName"] = SourceExpressionConverter.ConvertToken(bodyprimaryEmployeefirstName);
                    primaryEmployeeObjectpropCount++;
                }

                if (bodyprimaryEmployeelastName != null)
                {
                    primaryEmployeeObject["LastName"] = SourceExpressionConverter.ConvertToken(bodyprimaryEmployeelastName);
                    primaryEmployeeObjectpropCount++;
                }

                var contactInformationObject = new JObject();
                var contactInformationObjectpropCount = 0;
                if (bodyprimaryEmployeecontactInformationphoneNumber != null)
                {
                    contactInformationObject["PhoneNumber"] = SourceExpressionConverter.ConvertToken(bodyprimaryEmployeecontactInformationphoneNumber);
                    contactInformationObjectpropCount++;
                }

                if (bodyprimaryEmployeecontactInformationhomePhoneNumber != null)
                {
                    contactInformationObject["HomePhoneNumber"] = SourceExpressionConverter.ConvertToken(bodyprimaryEmployeecontactInformationhomePhoneNumber);
                    contactInformationObjectpropCount++;
                }

                if (bodyprimaryEmployeecontactInformationcellPhoneNumber != null)
                {
                    contactInformationObject["CellPhoneNumber"] = SourceExpressionConverter.ConvertToken(bodyprimaryEmployeecontactInformationcellPhoneNumber);
                    contactInformationObjectpropCount++;
                }

                if (bodyprimaryEmployeecontactInformationvoicemail != null)
                {
                    contactInformationObject["Voicemail"] = SourceExpressionConverter.ConvertToken(bodyprimaryEmployeecontactInformationvoicemail);
                    contactInformationObjectpropCount++;
                }

                if (bodyprimaryEmployeecontactInformationfaxNumber != null)
                {
                    contactInformationObject["FaxNumber"] = SourceExpressionConverter.ConvertToken(bodyprimaryEmployeecontactInformationfaxNumber);
                    contactInformationObjectpropCount++;
                }

                if (bodyprimaryEmployeecontactInformationemailAddress != null)
                {
                    contactInformationObject["EmailAddress"] = SourceExpressionConverter.ConvertToken(bodyprimaryEmployeecontactInformationemailAddress);
                    contactInformationObjectpropCount++;
                }

                if (bodyprimaryEmployeecontactInformationpreferredCommunicationMethod != null)
                {
                    contactInformationObject["PreferredCommunicationMethod"] = SourceExpressionConverter.ConvertToken(bodyprimaryEmployeecontactInformationpreferredCommunicationMethod);
                    contactInformationObjectpropCount++;
                }

                if (bodyprimaryEmployeecontactInformationwebsite != null)
                {
                    contactInformationObject["Website"] = SourceExpressionConverter.ConvertToken(bodyprimaryEmployeecontactInformationwebsite);
                    contactInformationObjectpropCount++;
                }

                if (contactInformationObjectpropCount > 0)
                {
                    primaryEmployeeObject["ContactInformation"] = contactInformationObject;
                    primaryEmployeeObjectpropCount++;
                }

                if (primaryEmployeeObjectpropCount > 0)
                {
                    body["PrimaryEmployee"] = primaryEmployeeObject;
                    bodypropCount++;
                }

                if (bodysecondaryEmployees != null)
                {
                    body["SecondaryEmployees"] = SourceExpressionConverter.ConvertToken(bodysecondaryEmployees);
                    bodypropCount++;
                }

                if (bodyreferenceNumber != null)
                {
                    body["ReferenceNumber"] = SourceExpressionConverter.ConvertToken(bodyreferenceNumber);
                    bodypropCount++;
                }

                if (bodyremoteFileNumber != null)
                {
                    body["RemoteFileNumber"] = SourceExpressionConverter.ConvertToken(bodyremoteFileNumber);
                    bodypropCount++;
                }

                if (bodypartnerTypeId != null)
                {
                    body["PartnerTypeID"] = SourceExpressionConverter.ConvertToken(bodypartnerTypeId);
                    bodypropCount++;
                }

                if (bodypartnerId != null)
                {
                    body["PartnerID"] = SourceExpressionConverter.ConvertToken(bodypartnerId);
                    bodypropCount++;
                }

                var partnerTypeObject = new JObject();
                var partnerTypeObjectpropCount = 0;
                if (bodypartnerTypepartnerTypeId != null)
                {
                    partnerTypeObject["PartnerTypeID"] = SourceExpressionConverter.ConvertToken(bodypartnerTypepartnerTypeId);
                    partnerTypeObjectpropCount++;
                }

                if (bodypartnerTypepartnerTypeName != null)
                {
                    partnerTypeObject["PartnerTypeName"] = SourceExpressionConverter.ConvertToken(bodypartnerTypepartnerTypeName);
                    partnerTypeObjectpropCount++;
                }

                if (partnerTypeObjectpropCount > 0)
                {
                    body["PartnerType"] = partnerTypeObject;
                    bodypropCount++;
                }

                if (bodyofficeId != null)
                {
                    body["OfficeID"] = SourceExpressionConverter.ConvertToken(bodyofficeId);
                    bodypropCount++;
                }

                if (bodypartnerName != null)
                {
                    body["PartnerName"] = SourceExpressionConverter.ConvertToken(bodypartnerName);
                    bodypropCount++;
                }

                var mailingAddressObject = new JObject();
                var mailingAddressObjectpropCount = 0;
                if (bodymailingAddressaddress1 != null)
                {
                    mailingAddressObject["Address1"] = SourceExpressionConverter.ConvertToken(bodymailingAddressaddress1);
                    mailingAddressObjectpropCount++;
                }

                if (bodymailingAddressaddress2 != null)
                {
                    mailingAddressObject["Address2"] = SourceExpressionConverter.ConvertToken(bodymailingAddressaddress2);
                    mailingAddressObjectpropCount++;
                }

                if (bodymailingAddresscity != null)
                {
                    mailingAddressObject["City"] = SourceExpressionConverter.ConvertToken(bodymailingAddresscity);
                    mailingAddressObjectpropCount++;
                }

                if (bodymailingAddressstate != null)
                {
                    mailingAddressObject["State"] = SourceExpressionConverter.ConvertToken(bodymailingAddressstate);
                    mailingAddressObjectpropCount++;
                }

                if (bodymailingAddresszip != null)
                {
                    mailingAddressObject["Zip"] = SourceExpressionConverter.ConvertToken(bodymailingAddresszip);
                    mailingAddressObjectpropCount++;
                }

                if (mailingAddressObjectpropCount > 0)
                {
                    body["MailingAddress"] = mailingAddressObject;
                    bodypropCount++;
                }

                var contactInformationObject2 = new JObject();
                var contactInformationObject2propCount = 0;
                if (bodycontactInformationphoneNumber != null)
                {
                    contactInformationObject2["PhoneNumber"] = SourceExpressionConverter.ConvertToken(bodycontactInformationphoneNumber);
                    contactInformationObject2propCount++;
                }

                if (bodycontactInformationhomePhoneNumber != null)
                {
                    contactInformationObject2["HomePhoneNumber"] = SourceExpressionConverter.ConvertToken(bodycontactInformationhomePhoneNumber);
                    contactInformationObject2propCount++;
                }

                if (bodycontactInformationcellPhoneNumber != null)
                {
                    contactInformationObject2["CellPhoneNumber"] = SourceExpressionConverter.ConvertToken(bodycontactInformationcellPhoneNumber);
                    contactInformationObject2propCount++;
                }

                if (bodycontactInformationvoicemail != null)
                {
                    contactInformationObject2["Voicemail"] = SourceExpressionConverter.ConvertToken(bodycontactInformationvoicemail);
                    contactInformationObject2propCount++;
                }

                if (bodycontactInformationfaxNumber != null)
                {
                    contactInformationObject2["FaxNumber"] = SourceExpressionConverter.ConvertToken(bodycontactInformationfaxNumber);
                    contactInformationObject2propCount++;
                }

                if (bodycontactInformationemailAddress != null)
                {
                    contactInformationObject2["EmailAddress"] = SourceExpressionConverter.ConvertToken(bodycontactInformationemailAddress);
                    contactInformationObject2propCount++;
                }

                if (bodycontactInformationpreferredCommunicationMethod != null)
                {
                    contactInformationObject2["PreferredCommunicationMethod"] = SourceExpressionConverter.ConvertToken(bodycontactInformationpreferredCommunicationMethod);
                    contactInformationObject2propCount++;
                }

                if (bodycontactInformationwebsite != null)
                {
                    contactInformationObject2["Website"] = SourceExpressionConverter.ConvertToken(bodycontactInformationwebsite);
                    contactInformationObject2propCount++;
                }

                if (contactInformationObject2propCount > 0)
                {
                    body["ContactInformation"] = contactInformationObject2;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdatePartnerInformationForSpecificFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<AddNoteToFileResponse> AddNoteToFile([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodybody = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AddNoteToFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = SourceExpressionConverter.ConvertO(fileId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysubject != null)
                {
                    body["Subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodybody != null)
                {
                    body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddNoteToFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetPartnersForSpecificFileResponse> GetPartnersForSpecificFile([WorkflowExpression] Func<string> fileId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetPartnersForSpecificFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = SourceExpressionConverter.ConvertO(fileId);
                return callPayload;
            }

            return new ApiConnectionAction<GetPartnersForSpecificFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<UploadWebURLDocumentToSpecificFileResponse> UploadWebURLDocumentToSpecificFile([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<string> bodydocumentName = null, [WorkflowExpression] Func<int> bodydocumentTypedocumentTypeId = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bool> bodyinternalOnly = null, [WorkflowExpression] Func<string> bodywebURL = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UploadWebUrlDocumentToSpecificFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = SourceExpressionConverter.ConvertO(fileId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydocumentName != null)
                {
                    body["DocumentName"] = SourceExpressionConverter.ConvertToken(bodydocumentName);
                    bodypropCount++;
                }

                var documentTypeObject = new JObject();
                var documentTypeObjectpropCount = 0;
                if (bodydocumentTypedocumentTypeId != null)
                {
                    documentTypeObject["DocumentTypeID"] = SourceExpressionConverter.ConvertToken(bodydocumentTypedocumentTypeId);
                    documentTypeObjectpropCount++;
                }

                if (documentTypeObjectpropCount > 0)
                {
                    body["DocumentType"] = documentTypeObject;
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyinternalOnly != null)
                {
                    body["InternalOnly"] = SourceExpressionConverter.ConvertToken(bodyinternalOnly);
                    bodypropCount++;
                }

                if (bodywebURL != null)
                {
                    body["WebURL"] = SourceExpressionConverter.ConvertToken(bodywebURL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UploadWebURLDocumentToSpecificFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken> AddOrUpdateCustomFieldOnSpecificDocument([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<bodycustomFieldsInputItem[]> bodycustomFields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AddOrUpdateCustomFieldOnSpecificDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = SourceExpressionConverter.ConvertO(fileId);
                callPayload.Queries["DocumentID"] = SourceExpressionConverter.ConvertO(documentId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycustomFields != null)
                {
                    body["CustomFields"] = SourceExpressionConverter.ConvertToken(bodycustomFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<UpdatePartnerEmployeeResponse> UpdatePartnerEmployee([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> partnerCompanyId, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodypasswordExpirationDate = null, [WorkflowExpression] Func<bodyrolesInputItem[]> bodyroles = null, [WorkflowExpression] Func<bool> bodyenabled = null, [WorkflowExpression] Func<bool> bodywebsiteAccess = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodycontactInformationemailAddress = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UpdatePartnerEmployee";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["UserID"] = SourceExpressionConverter.ConvertO(userId);
                callPayload.Queries["PartnerCompanyID"] = SourceExpressionConverter.ConvertO(partnerCompanyId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypassword != null)
                {
                    body["Password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodypasswordExpirationDate != null)
                {
                    body["PasswordExpirationDate"] = SourceExpressionConverter.ConvertToken(bodypasswordExpirationDate);
                    bodypropCount++;
                }

                if (bodyroles != null)
                {
                    body["Roles"] = SourceExpressionConverter.ConvertToken(bodyroles);
                    bodypropCount++;
                }

                if (bodyenabled != null)
                {
                    body["Enabled"] = SourceExpressionConverter.ConvertToken(bodyenabled);
                    bodypropCount++;
                }

                if (bodywebsiteAccess != null)
                {
                    body["WebsiteAccess"] = SourceExpressionConverter.ConvertToken(bodywebsiteAccess);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["FirstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["LastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                var contactInformationObject = new JObject();
                var contactInformationObjectpropCount = 0;
                if (bodycontactInformationemailAddress != null)
                {
                    contactInformationObject["EmailAddress"] = SourceExpressionConverter.ConvertToken(bodycontactInformationemailAddress);
                    contactInformationObjectpropCount++;
                }

                if (contactInformationObjectpropCount > 0)
                {
                    body["ContactInformation"] = contactInformationObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdatePartnerEmployeeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetPartiesForSpecificFileResponse> GetPartiesForSpecificFile([WorkflowExpression] Func<string> fileId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetPartiesForSpecificFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = SourceExpressionConverter.ConvertO(fileId);
                return callPayload;
            }

            return new ApiConnectionAction<GetPartiesForSpecificFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetNotesForSpecificFileResponse> GetNotesForSpecificFile([WorkflowExpression] Func<string> fileId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetNotesForSpecificFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = SourceExpressionConverter.ConvertO(fileId);
                return callPayload;
            }

            return new ApiConnectionAction<GetNotesForSpecificFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetNoteResponse> GetNote([WorkflowExpression] Func<string> noteId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetNote";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["NoteID"] = SourceExpressionConverter.ConvertO(noteId);
                return callPayload;
            }

            return new ApiConnectionAction<GetNoteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<AddActionToFileResponse> AddActionToFile([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<int> bodyactionTypeactionTypeId = null, [WorkflowExpression] Func<int> bodygroupactionGroupId = null, [WorkflowExpression] Func<int> bodystartTaskcoordinatorTypeId = null, [WorkflowExpression] Func<string> bodystartTaskdueDate = null, [WorkflowExpression] Func<int> bodycompleteTaskpartnerpartnerTypepartnerTypeId = null, [WorkflowExpression] Func<string> bodycompleteTaskdueDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AddActionToFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = SourceExpressionConverter.ConvertO(fileId);
                var body = new JObject();
                var bodypropCount = 0;
                var actionTypeObject = new JObject();
                var actionTypeObjectpropCount = 0;
                if (bodyactionTypeactionTypeId != null)
                {
                    actionTypeObject["ActionTypeID"] = SourceExpressionConverter.ConvertToken(bodyactionTypeactionTypeId);
                    actionTypeObjectpropCount++;
                }

                if (actionTypeObjectpropCount > 0)
                {
                    body["ActionType"] = actionTypeObject;
                    bodypropCount++;
                }

                var groupObject = new JObject();
                var groupObjectpropCount = 0;
                if (bodygroupactionGroupId != null)
                {
                    groupObject["ActionGroupID"] = SourceExpressionConverter.ConvertToken(bodygroupactionGroupId);
                    groupObjectpropCount++;
                }

                if (groupObjectpropCount > 0)
                {
                    body["Group"] = groupObject;
                    bodypropCount++;
                }

                var startTaskObject = new JObject();
                var startTaskObjectpropCount = 0;
                if (bodystartTaskcoordinatorTypeId != null)
                {
                    startTaskObject["CoordinatorTypeID"] = SourceExpressionConverter.ConvertToken(bodystartTaskcoordinatorTypeId);
                    startTaskObjectpropCount++;
                }

                if (bodystartTaskdueDate != null)
                {
                    startTaskObject["DueDate"] = SourceExpressionConverter.ConvertToken(bodystartTaskdueDate);
                    startTaskObjectpropCount++;
                }

                if (startTaskObjectpropCount > 0)
                {
                    body["StartTask"] = startTaskObject;
                    bodypropCount++;
                }

                var completeTaskObject = new JObject();
                var completeTaskObjectpropCount = 0;
                var partnerObject = new JObject();
                var partnerObjectpropCount = 0;
                var partnerTypeObject = new JObject();
                var partnerTypeObjectpropCount = 0;
                if (bodycompleteTaskpartnerpartnerTypepartnerTypeId != null)
                {
                    partnerTypeObject["PartnerTypeID"] = SourceExpressionConverter.ConvertToken(bodycompleteTaskpartnerpartnerTypepartnerTypeId);
                    partnerTypeObjectpropCount++;
                }

                if (partnerTypeObjectpropCount > 0)
                {
                    partnerObject["PartnerType"] = partnerTypeObject;
                    partnerObjectpropCount++;
                }

                if (partnerObjectpropCount > 0)
                {
                    completeTaskObject["Partner"] = partnerObject;
                    completeTaskObjectpropCount++;
                }

                if (bodycompleteTaskdueDate != null)
                {
                    completeTaskObject["DueDate"] = SourceExpressionConverter.ConvertToken(bodycompleteTaskdueDate);
                    completeTaskObjectpropCount++;
                }

                if (completeTaskObjectpropCount > 0)
                {
                    body["CompleteTask"] = completeTaskObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddActionToFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetCustomFieldsOnSpecificDocumentResponse> GetCustomFieldsOnSpecificDocument([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<string> documentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetCustomFieldsOnSpecificDocument";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = SourceExpressionConverter.ConvertO(fileId);
                callPayload.Queries["DocumentID"] = SourceExpressionConverter.ConvertO(documentId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCustomFieldsOnSpecificDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetDocumentsForSpecificFileResponse> GetDocumentsForSpecificFile([WorkflowExpression] Func<string> fileId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetDocumentsForSpecificFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = SourceExpressionConverter.ConvertO(fileId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentsForSpecificFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetDocumentResponse> GetDocument([WorkflowExpression] Func<string> documentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetDocument";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["DocumentID"] = SourceExpressionConverter.ConvertO(documentId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetCustomFieldsForSpecificFileResponse> GetCustomFieldsForSpecificFile([WorkflowExpression] Func<string> fileId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetCustomFieldsForSpecificFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = SourceExpressionConverter.ConvertO(fileId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCustomFieldsForSpecificFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetClosingFeeEstimateReceiptResponse> GetClosingFeeEstimateReceipt([WorkflowExpression] Func<string> closingFeeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetClosingFeeEstimateReceipt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ClosingFeeID"] = SourceExpressionConverter.ConvertO(closingFeeId);
                return callPayload;
            }

            return new ApiConnectionAction<GetClosingFeeEstimateReceiptResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken> GetClosingFeeEstimateReceiptPDF([WorkflowExpression] Func<string> closingFeeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetClosingFeeEstimateReceiptPDF";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ClosingFeeID"] = SourceExpressionConverter.ConvertO(closingFeeId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetActionsForSpecificFileResponse> GetActionsForSpecificFile([WorkflowExpression] Func<string> fileId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetActionsForSpecificFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = SourceExpressionConverter.ConvertO(fileId);
                return callPayload;
            }

            return new ApiConnectionAction<GetActionsForSpecificFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetCurrentUserInfoResponse> GetCurrentUserInfo()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetCurrentUserInfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCurrentUserInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<EstimateClosingFeeResponse> EstimateClosingFee([WorkflowExpression] Func<int> bodytransactionProductTypetransactionTypeId = null, [WorkflowExpression] Func<int> bodytransactionProductTypeproductTypeId = null, [WorkflowExpression] Func<string> bodysettlementStatementVersion = null, [WorkflowExpression] Func<int> bodysalesPrice = null, [WorkflowExpression] Func<bodyloansInputItem2[]> bodyloans = null, [WorkflowExpression] Func<bodypropertiesInputItem[]> bodyproperties = null, [WorkflowExpression] Func<bodyfilePartnersInputItem[]> bodyfilePartners = null, [WorkflowExpression] Func<bodyendorsementsInputItem[]> bodyendorsements = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/EstimateClosingFee";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var transactionProductTypeObject = new JObject();
                var transactionProductTypeObjectpropCount = 0;
                if (bodytransactionProductTypetransactionTypeId != null)
                {
                    transactionProductTypeObject["TransactionTypeID"] = SourceExpressionConverter.ConvertToken(bodytransactionProductTypetransactionTypeId);
                    transactionProductTypeObjectpropCount++;
                }

                if (bodytransactionProductTypeproductTypeId != null)
                {
                    transactionProductTypeObject["ProductTypeID"] = SourceExpressionConverter.ConvertToken(bodytransactionProductTypeproductTypeId);
                    transactionProductTypeObjectpropCount++;
                }

                if (transactionProductTypeObjectpropCount > 0)
                {
                    body["TransactionProductType"] = transactionProductTypeObject;
                    bodypropCount++;
                }

                if (bodysettlementStatementVersion != null)
                {
                    body["SettlementStatementVersion"] = SourceExpressionConverter.ConvertToken(bodysettlementStatementVersion);
                    bodypropCount++;
                }

                if (bodysalesPrice != null)
                {
                    body["SalesPrice"] = SourceExpressionConverter.ConvertToken(bodysalesPrice);
                    bodypropCount++;
                }

                if (bodyloans != null)
                {
                    body["Loans"] = SourceExpressionConverter.ConvertToken(bodyloans);
                    bodypropCount++;
                }

                if (bodyproperties != null)
                {
                    body["Properties"] = SourceExpressionConverter.ConvertToken(bodyproperties);
                    bodypropCount++;
                }

                if (bodyfilePartners != null)
                {
                    body["FilePartners"] = SourceExpressionConverter.ConvertToken(bodyfilePartners);
                    bodypropCount++;
                }

                if (bodyendorsements != null)
                {
                    body["Endorsements"] = SourceExpressionConverter.ConvertToken(bodyendorsements);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EstimateClosingFeeResponse>(BuildSourceInput);
        }
    }

    public class InfoqueryTriggers([ConnectionName] string connectionId)
    {
    }

    public class AddNewPartnerEmployeeToPartnerCompanyResponse
    {
        public AddNewPartnerEmployeeToPartnerCompanyResponseEmployeeType Employee { get; set; }
    }

    public class AddNewPartnerEmployeeToPartnerCompanyResponseEmployeeType
    {
        public int PartnerCompanyID { get; set; }
        public bool Enabled { get; set; }
        public bool WebsiteAccess { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddNewPartnerEmployeeToPartnerCompanyResponseEmployeeTypeContactInformationType ContactInformation { get; set; }
    }

    public class AddNewPartnerEmployeeToPartnerCompanyResponseEmployeeTypeContactInformationType
    {
        public string EmailAddress { get; set; }
    }

    public class CreateNewFileResponse
    {
        public int FileID { get; set; }
        public string FileNumber { get; set; }
        public string[] Warnings { get; set; }
    }

    public class bodybuyersInputItem
    {
        public string EntityType { get; set; }
        public bool IsPrimaryTransactee { get; set; }
        public bodybuyersInputItemPrimaryType Primary { get; set; }
        public bool UsePropertyAddress { get; set; }
        public bodybuyersInputItemAddressType Address { get; set; }
        public string MaritalStatus { get; set; }
        public string Email { get; set; }
    }

    public class bodybuyersInputItemPrimaryType
    {
        public string First { get; set; }
        public string Last { get; set; }
    }

    public class bodybuyersInputItemAddressType
    {
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class bodysellersInputItem
    {
        public string EntityType { get; set; }
        public bool IsPrimaryTransactee { get; set; }
        public bodysellersInputItemPrimaryType Primary { get; set; }
        public bool UsePropertyAddress { get; set; }
        public bodysellersInputItemAddressType Address { get; set; }
        public string MaritalStatus { get; set; }
        public string Email { get; set; }
    }

    public class bodysellersInputItemPrimaryType
    {
        public string First { get; set; }
        public string Last { get; set; }
    }

    public class bodysellersInputItemAddressType
    {
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class bodycustomFieldsInputItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class bodyloansInputItem
    {
        public int LienPosition { get; set; }
        public string LoanNumber { get; set; }
        public int LoanAmount { get; set; }
        public string LoanType { get; set; }
    }

    public class bodypropertiesInputItem
    {
        public bool IsPrimary { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string Zip { get; set; }
    }

    public class GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItem
    {
        public string TransactionType { get; set; }
        public int TransactionTypeID { get; set; }
        public string ProductType { get; set; }
        public int ProductTypeID { get; set; }
        public GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItemAncillaryProductsTypeItem[] AncillaryProducts { get; set; }
        public GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItemAddOnProductsTypeItem[] AddOnProducts { get; set; }
    }

    public class GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItemAncillaryProductsTypeItem
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItemAncillaryProductsTypeItemOptionsTypeItem[] Options { get; set; }
    }

    public class GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItemAncillaryProductsTypeItemOptionsTypeItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItemAddOnProductsTypeItem
    {
        public string TransactionType { get; set; }
        public int TransactionTypeID { get; set; }
        public string ProductType { get; set; }
        public int ProductTypeID { get; set; }
    }

    public class UpdateActionForFileResponse
    {
        public int FileActionID { get; set; }
    }

    public class bodystatusesInputItem
    {
        public int StatusID { get; set; }
        public string Name { get; set; }
    }

    public class bodypartnersInputItem
    {
        public int PartnerTypeID { get; set; }
        public int PartnerID { get; set; }
        public bodypartnersInputItemPartnerTypeType PartnerType { get; set; }
    }

    public class bodypartnersInputItemPartnerTypeType
    {
        public int PartnerTypeID { get; set; }
    }

    public class GetPartnerInformationResponse
    {
        public int PartnerCompanyID { get; set; }
        public GetPartnerInformationResponsePartnerTypesTypeItem[] PartnerTypes { get; set; }
        public int OfficeID { get; set; }
        public string PartnerName { get; set; }
        public string CompanyAbbreviation { get; set; }
        public string ProperCompanyName { get; set; }
        public GetPartnerInformationResponseMailingAddressType MailingAddress { get; set; }
        public GetPartnerInformationResponseContactInformationType ContactInformation { get; set; }
        public GetPartnerInformationResponseCompanyInformationType CompanyInformation { get; set; }
        public bool SendDocumentsAsWebLinks { get; set; }
        public int WireConfirmationEmailTemplateID { get; set; }
        public GetPartnerInformationResponseCourierAddressType CourierAddress { get; set; }
    }

    public class GetPartnerInformationResponsePartnerTypesTypeItem
    {
        public int PartnerTypeID { get; set; }
        public string PartnerTypeName { get; set; }
    }

    public class GetPartnerInformationResponseMailingAddressType
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class GetPartnerInformationResponseContactInformationType
    {
        public string PhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }
        public string Voicemail { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PreferredCommunicationMethod { get; set; }
        public string Website { get; set; }
    }

    public class GetPartnerInformationResponseCompanyInformationType
    {
        public GetPartnerInformationResponseCompanyInformationTypeParentCompanyType ParentCompany { get; set; }
        public GetPartnerInformationResponseCompanyInformationTypePartnerEntityType PartnerEntity { get; set; }
        public bool IsBillable { get; set; }
        public bool IsInvoiceable { get; set; }
        public string TaxID { get; set; }
        public string AccountingCode { get; set; }
        public string CommentsSpecialInstructions { get; set; }
        public bool DontAllowSelectionInSettlement { get; set; }
        public bool Needs1099 { get; set; }
        public bool MWBE { get; set; }
    }

    public class GetPartnerInformationResponseCompanyInformationTypeParentCompanyType
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class GetPartnerInformationResponseCompanyInformationTypePartnerEntityType
    {
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetPartnerInformationResponseCourierAddressType
    {
        public bool UseOnDisbursements { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class CreateNewDocumentOnSpecificFileResponse
    {
        public CreateNewDocumentOnSpecificFileResponseDocumentType Document { get; set; }
    }

    public class CreateNewDocumentOnSpecificFileResponseDocumentType
    {
        public int DocumentID { get; set; }
    }

    public class bodypartnersInputItem2
    {
        public bodypartnersInputItemPrimaryEmployeeType PrimaryEmployee { get; set; }
        public bodypartnersInputItemSecondaryEmployeesTypeItem[] SecondaryEmployees { get; set; }
        public int PartnerTypeID { get; set; }
        public int PartnerID { get; set; }
        public bodypartnersInputItemPartnerTypeType PartnerType { get; set; }
    }

    public class bodypartnersInputItemPrimaryEmployeeType
    {
        public int UserID { get; set; }
    }

    public class bodypartnersInputItemSecondaryEmployeesTypeItem
    {
        public int UserID { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileResponse
    {
        public int FileID { get; set; }
        public string FileNumber { get; set; }
        public UpdatePartnerInformationForSpecificFileResponsePrimaryEmployeeType PrimaryEmployee { get; set; }
        public UpdatePartnerInformationForSpecificFileResponseSecondaryEmployeesTypeItem[] SecondaryEmployees { get; set; }
        public string ReferenceNumber { get; set; }
        public string RemoteFileNumber { get; set; }
        public int PartnerTypeID { get; set; }
        public int PartnerID { get; set; }
        public UpdatePartnerInformationForSpecificFileResponsePartnerTypeType PartnerType { get; set; }
        public int OfficeID { get; set; }
        public string PartnerName { get; set; }
        public UpdatePartnerInformationForSpecificFileResponseMailingAddressType MailingAddress { get; set; }
        public UpdatePartnerInformationForSpecificFileResponseContactInformationType ContactInformation { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileResponsePrimaryEmployeeType
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UpdatePartnerInformationForSpecificFileResponsePrimaryEmployeeTypeContactInformationType ContactInformation { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileResponsePrimaryEmployeeTypeContactInformationType
    {
        public string PhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }
        public string Voicemail { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PreferredCommunicationMethod { get; set; }
        public string Website { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileResponseSecondaryEmployeesTypeItem
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UpdatePartnerInformationForSpecificFileResponseSecondaryEmployeesTypeItemContactInformationType ContactInformation { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileResponseSecondaryEmployeesTypeItemContactInformationType
    {
        public string PhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }
        public string Voicemail { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PreferredCommunicationMethod { get; set; }
        public string Website { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileResponsePartnerTypeType
    {
        public int PartnerTypeID { get; set; }
        public string PartnerTypeName { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileResponseMailingAddressType
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileResponseContactInformationType
    {
        public string PhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }
        public string Voicemail { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PreferredCommunicationMethod { get; set; }
        public string Website { get; set; }
    }

    public class bodysecondaryEmployeesInputItem
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bodysecondaryEmployeesInputItemContactInformationType ContactInformation { get; set; }
    }

    public class bodysecondaryEmployeesInputItemContactInformationType
    {
        public string PhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }
        public string Voicemail { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PreferredCommunicationMethod { get; set; }
        public string Website { get; set; }
    }

    public class AddNoteToFileResponse
    {
        [JsonProperty("note")]
        public AddNoteToFileResponseNoteType Note { get; set; }
    }

    public class AddNoteToFileResponseNoteType
    {
        public int NoteID { get; set; }
    }

    public class GetPartnersForSpecificFileResponse
    {
        public GetPartnersForSpecificFileResponsePartnersTypeItem[] Partners { get; set; }
    }

    public class GetPartnersForSpecificFileResponsePartnersTypeItem
    {
        public GetPartnersForSpecificFileResponsePartnersTypeItemPrimaryEmployeeType PrimaryEmployee { get; set; }
        public int PartnerTypeID { get; set; }
        public int PartnerID { get; set; }
        public GetPartnersForSpecificFileResponsePartnersTypeItemPartnerTypeType PartnerType { get; set; }
        public string PartnerName { get; set; }
    }

    public class GetPartnersForSpecificFileResponsePartnersTypeItemPrimaryEmployeeType
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GetPartnersForSpecificFileResponsePartnersTypeItemPrimaryEmployeeTypeContactInformationType ContactInformation { get; set; }
    }

    public class GetPartnersForSpecificFileResponsePartnersTypeItemPrimaryEmployeeTypeContactInformationType
    {
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }

    public class GetPartnersForSpecificFileResponsePartnersTypeItemPartnerTypeType
    {
        public int PartnerTypeID { get; set; }
        public string PartnerTypeName { get; set; }
    }

    public class UploadWebURLDocumentToSpecificFileResponse
    {
        public UploadWebURLDocumentToSpecificFileResponseDocumentType Document { get; set; }
    }

    public class UploadWebURLDocumentToSpecificFileResponseDocumentType
    {
        public int DocumentID { get; set; }
    }

    public class UpdatePartnerEmployeeResponse
    {
        public UpdatePartnerEmployeeResponseEmployeeType Employee { get; set; }
    }

    public class UpdatePartnerEmployeeResponseEmployeeType
    {
        public int PartnerCompanyID { get; set; }
        public UpdatePartnerEmployeeResponseEmployeeTypeRolesTypeItem[] Roles { get; set; }
        public bool Enabled { get; set; }
        public bool WebsiteAccess { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UpdatePartnerEmployeeResponseEmployeeTypeContactInformationType ContactInformation { get; set; }
    }

    public class UpdatePartnerEmployeeResponseEmployeeTypeRolesTypeItem
    {
        public int RoleID { get; set; }
        public string Name { get; set; }
    }

    public class UpdatePartnerEmployeeResponseEmployeeTypeContactInformationType
    {
        public string EmailAddress { get; set; }
    }

    public class bodyrolesInputItem
    {
        public int RoleID { get; set; }
        public string Name { get; set; }
    }

    public class GetPartiesForSpecificFileResponse
    {
        public GetPartiesForSpecificFileResponseBuyersTypeItem[] Buyers { get; set; }
        public GetPartiesForSpecificFileResponseSellersTypeItem[] Sellers { get; set; }
        public string[] Customers { get; set; }
    }

    public class GetPartiesForSpecificFileResponseBuyersTypeItem
    {
        public int LegalEntityID { get; set; }
        public string EntityType { get; set; }
        public GetPartiesForSpecificFileResponseBuyersTypeItemPrimaryType Primary { get; set; }
        public GetPartiesForSpecificFileResponseBuyersTypeItemSecondaryType Secondary { get; set; }
        public bool UsePropertyAddress { get; set; }
        public GetPartiesForSpecificFileResponseBuyersTypeItemAddressType Address { get; set; }
        public string MaritalStatus { get; set; }
        public string Email { get; set; }
        public string HomePhone { get; set; }
        public string EmailSecondary { get; set; }
    }

    public class GetPartiesForSpecificFileResponseBuyersTypeItemPrimaryType
    {
        public string Prefix { get; set; }
        public string First { get; set; }
        public string Middle { get; set; }
        public string Last { get; set; }
        public string Suffix { get; set; }
    }

    public class GetPartiesForSpecificFileResponseBuyersTypeItemSecondaryType
    {
        public string Prefix { get; set; }
        public string First { get; set; }
        public string Middle { get; set; }
        public string Last { get; set; }
    }

    public class GetPartiesForSpecificFileResponseBuyersTypeItemAddressType
    {
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class GetPartiesForSpecificFileResponseSellersTypeItem
    {
        public int LegalEntityID { get; set; }
        public string EntityType { get; set; }
        public GetPartiesForSpecificFileResponseSellersTypeItemPrimaryType Primary { get; set; }
        public bool UsePropertyAddress { get; set; }
        public GetPartiesForSpecificFileResponseSellersTypeItemAddressType Address { get; set; }
        public string MaritalStatus { get; set; }
        public string Email { get; set; }
    }

    public class GetPartiesForSpecificFileResponseSellersTypeItemPrimaryType
    {
        public string BusinessName { get; set; }
    }

    public class GetPartiesForSpecificFileResponseSellersTypeItemAddressType
    {
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class GetNotesForSpecificFileResponse
    {
        public GetNotesForSpecificFileResponseNotesTypeItem[] Notes { get; set; }
    }

    public class GetNotesForSpecificFileResponseNotesTypeItem
    {
        public int NoteID { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public GetNotesForSpecificFileResponseNotesTypeItemCreatedByType CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public int FileID { get; set; }
        public bool Expedite { get; set; }
    }

    public class GetNotesForSpecificFileResponseNotesTypeItemCreatedByType
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GetNotesForSpecificFileResponseNotesTypeItemCreatedByTypeContactInformationType ContactInformation { get; set; }
    }

    public class GetNotesForSpecificFileResponseNotesTypeItemCreatedByTypeContactInformationType
    {
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }

    public class GetNoteResponse
    {
        public int NoteID { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public GetNoteResponseCreatedByType CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public int FileID { get; set; }
    }

    public class GetNoteResponseCreatedByType
    {
        public int UserID { get; set; }
    }

    public class AddActionToFileResponse
    {
        public int FileActionID { get; set; }
    }

    public class GetCustomFieldsOnSpecificDocumentResponse
    {
        public GetCustomFieldsOnSpecificDocumentResponseCustomFieldsTypeItem[] CustomFields { get; set; }
        public int CustomFieldListCount { get; set; }
    }

    public class GetCustomFieldsOnSpecificDocumentResponseCustomFieldsTypeItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class GetDocumentsForSpecificFileResponse
    {
        public GetDocumentsForSpecificFileResponseDocumentsTypeItem[] Documents { get; set; }
    }

    public class GetDocumentsForSpecificFileResponseDocumentsTypeItem
    {
        public int DocumentID { get; set; }
        public string DocumentName { get; set; }
        public GetDocumentsForSpecificFileResponseDocumentsTypeItemDocumentTypeType DocumentType { get; set; }
        public string Description { get; set; }
        public bool InternalOnly { get; set; }
        public bool Approved { get; set; }
        public GetDocumentsForSpecificFileResponseDocumentsTypeItemAssociatedNotesTypeItem[] AssociatedNotes { get; set; }
        public GetDocumentsForSpecificFileResponseDocumentsTypeItemCreateUserType CreateUser { get; set; }
        public string CreateDate { get; set; }
        public GetDocumentsForSpecificFileResponseDocumentsTypeItemModifyUserType ModifyUser { get; set; }
        public string ModifyDate { get; set; }
    }

    public class GetDocumentsForSpecificFileResponseDocumentsTypeItemDocumentTypeType
    {
        public int DocumentTypeID { get; set; }
        public string Name { get; set; }
    }

    public class GetDocumentsForSpecificFileResponseDocumentsTypeItemAssociatedNotesTypeItem
    {
        public int NoteID { get; set; }
    }

    public class GetDocumentsForSpecificFileResponseDocumentsTypeItemCreateUserType
    {
        public int UserID { get; set; }
        public string Name { get; set; }
    }

    public class GetDocumentsForSpecificFileResponseDocumentsTypeItemModifyUserType
    {
        public int UserID { get; set; }
        public string Name { get; set; }
    }

    public class GetDocumentResponse
    {
        public int DocumentID { get; set; }
        public string DocumentName { get; set; }
        public GetDocumentResponseDocumentTypeType DocumentType { get; set; }
        public string Description { get; set; }
        public bool InternalOnly { get; set; }
        public bool Approved { get; set; }
        public GetDocumentResponseCreateUserType CreateUser { get; set; }
        public string CreateDate { get; set; }
    }

    public class GetDocumentResponseDocumentTypeType
    {
        public int DocumentTypeID { get; set; }
        public string Name { get; set; }
    }

    public class GetDocumentResponseCreateUserType
    {
        public int UserID { get; set; }
    }

    public class GetCustomFieldsForSpecificFileResponse
    {
        public GetCustomFieldsForSpecificFileResponseCustomFieldsTypeItem[] CustomFields { get; set; }
        public int CustomFieldListCount { get; set; }
    }

    public class GetCustomFieldsForSpecificFileResponseCustomFieldsTypeItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponse
    {
        public string EstimateDate { get; set; }
        public GetClosingFeeEstimateReceiptResponseRequestType Request { get; set; }
        public GetClosingFeeEstimateReceiptResponseResponseType Response { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseRequestType
    {
        public GetClosingFeeEstimateReceiptResponseRequestTypeTransactionProductTypeType TransactionProductType { get; set; }
        public string SettlementStatementVersion { get; set; }
        public int SalesPrice { get; set; }
        public GetClosingFeeEstimateReceiptResponseRequestTypeLoansTypeItem[] Loans { get; set; }
        public GetClosingFeeEstimateReceiptResponseRequestTypePropertiesTypeItem[] Properties { get; set; }
        public GetClosingFeeEstimateReceiptResponseRequestTypeFilePartnersTypeItem[] FilePartners { get; set; }
        public GetClosingFeeEstimateReceiptResponseRequestTypeEndorsementsTypeItem[] Endorsements { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseRequestTypeTransactionProductTypeType
    {
        public int TransactionTypeID { get; set; }
        public int ProductTypeID { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseRequestTypeLoansTypeItem
    {
        public int LienPosition { get; set; }
        public int LoanAmount { get; set; }
        public string LoanType { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseRequestTypePropertiesTypeItem
    {
        public bool IsPrimary { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string Zip { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseRequestTypeFilePartnersTypeItem
    {
        public int PartnerTypeID { get; set; }
        public int PartnerID { get; set; }
        public GetClosingFeeEstimateReceiptResponseRequestTypeFilePartnersTypeItemPartnerTypeType PartnerType { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseRequestTypeFilePartnersTypeItemPartnerTypeType
    {
        public int PartnerTypeID { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseRequestTypeEndorsementsTypeItem
    {
        public string Name { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseResponseType
    {
        public int ClosingFeeEstimateID { get; set; }
        public GetClosingFeeEstimateReceiptResponseResponseTypeHUDFeesTypeItem[] HUDFees { get; set; }
        public GetClosingFeeEstimateReceiptResponseResponseTypeGFETypeItem[] GFE { get; set; }
        public GetClosingFeeEstimateReceiptResponseResponseTypePremiumsType Premiums { get; set; }
        public string Timestamp { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseResponseTypeHUDFeesTypeItem
    {
        public int Amount { get; set; }
        public string Description { get; set; }
        public string LineNumber { get; set; }
        public int BuyerAmount { get; set; }
        public int BuyerPOCAmount { get; set; }
        public int SellerAmount { get; set; }
        public int SellerPOCAmount { get; set; }
        public int OtherPOCAmount { get; set; }
        public GetClosingFeeEstimateReceiptResponseResponseTypeHUDFeesTypeItemOtherPOCPartnerTypeType OtherPOCPartnerType { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseResponseTypeHUDFeesTypeItemOtherPOCPartnerTypeType
    {
        public int PartnerTypeID { get; set; }
        public string PartnerTypeName { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseResponseTypeGFETypeItem
    {
        public string Description { get; set; }
        public int Amount { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseResponseTypePremiumsType
    {
        public int LendersPremium { get; set; }
        public int FullLendersPremium { get; set; }
    }

    public class GetActionsForSpecificFileResponse
    {
        public GetActionsForSpecificFileResponseActionsTypeItem[] Actions { get; set; }
    }

    public class GetActionsForSpecificFileResponseActionsTypeItem
    {
        public int FileActionID { get; set; }
        public GetActionsForSpecificFileResponseActionsTypeItemActionTypeType ActionType { get; set; }
        public GetActionsForSpecificFileResponseActionsTypeItemGroupType Group { get; set; }
        public GetActionsForSpecificFileResponseActionsTypeItemStartTaskType StartTask { get; set; }
        public GetActionsForSpecificFileResponseActionsTypeItemCompleteTaskType CompleteTask { get; set; }
    }

    public class GetActionsForSpecificFileResponseActionsTypeItemActionTypeType
    {
        public int ActionTypeID { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }

    public class GetActionsForSpecificFileResponseActionsTypeItemGroupType
    {
        public int ActionGroupID { get; set; }
        public string Name { get; set; }
    }

    public class GetActionsForSpecificFileResponseActionsTypeItemStartTaskType
    {
        public int CoordinatorTypeID { get; set; }
        public string DueDate { get; set; }
        public bool DueDateLocked { get; set; }
        public string DoneDate { get; set; }
        public bool DoneDateLocked { get; set; }
        public GetActionsForSpecificFileResponseActionsTypeItemStartTaskTypeDoneByType DoneBy { get; set; }
    }

    public class GetActionsForSpecificFileResponseActionsTypeItemStartTaskTypeDoneByType
    {
        public int UserID { get; set; }
        public string Name { get; set; }
    }

    public class GetActionsForSpecificFileResponseActionsTypeItemCompleteTaskType
    {
        public int CoordinatorTypeID { get; set; }
        public string DueDate { get; set; }
        public bool DueDateLocked { get; set; }
        public bool DoneDateLocked { get; set; }
        public GetActionsForSpecificFileResponseActionsTypeItemCompleteTaskTypeDoneByType DoneBy { get; set; }
    }

    public class GetActionsForSpecificFileResponseActionsTypeItemCompleteTaskTypeDoneByType
    {
        public int UserID { get; set; }
        public string Name { get; set; }
    }

    public class GetCurrentUserInfoResponse
    {
        public string Title { get; set; }
        public string PasswordExpirationDate { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GetCurrentUserInfoResponseContactInformationType ContactInformation { get; set; }
    }

    public class GetCurrentUserInfoResponseContactInformationType
    {
        public string CellPhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PreferredCommunicationMethod { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Website { get; set; }
    }

    public class EstimateClosingFeeResponse
    {
        public EstimateClosingFeeResponseClosingFeeEstimateType ClosingFeeEstimate { get; set; }
    }

    public class EstimateClosingFeeResponseClosingFeeEstimateType
    {
        public int ClosingFeeEstimateID { get; set; }
        public EstimateClosingFeeResponseClosingFeeEstimateTypeHUDFeesTypeItem[] HUDFees { get; set; }
        public EstimateClosingFeeResponseClosingFeeEstimateTypeGFETypeItem[] GFE { get; set; }
        public EstimateClosingFeeResponseClosingFeeEstimateTypePremiumsType Premiums { get; set; }
        public string Timestamp { get; set; }
    }

    public class EstimateClosingFeeResponseClosingFeeEstimateTypeHUDFeesTypeItem
    {
        public int Amount { get; set; }
        public string Description { get; set; }
        public string LineNumber { get; set; }
        public int BuyerAmount { get; set; }
        public int BuyerPOCAmount { get; set; }
        public int SellerAmount { get; set; }
        public int SellerPOCAmount { get; set; }
        public int OtherPOCAmount { get; set; }
        public EstimateClosingFeeResponseClosingFeeEstimateTypeHUDFeesTypeItemOtherPOCPartnerTypeType OtherPOCPartnerType { get; set; }
    }

    public class EstimateClosingFeeResponseClosingFeeEstimateTypeHUDFeesTypeItemOtherPOCPartnerTypeType
    {
        public int PartnerTypeID { get; set; }
        public string PartnerTypeName { get; set; }
    }

    public class EstimateClosingFeeResponseClosingFeeEstimateTypeGFETypeItem
    {
        public string Description { get; set; }
        public int Amount { get; set; }
    }

    public class EstimateClosingFeeResponseClosingFeeEstimateTypePremiumsType
    {
        public int LendersPremium { get; set; }
        public int FullLendersPremium { get; set; }
    }

    public class bodyloansInputItem2
    {
        public int LienPosition { get; set; }
        public int LoanAmount { get; set; }
        public string LoanType { get; set; }
    }

    public class bodyfilePartnersInputItem
    {
        public int PartnerTypeID { get; set; }
        public int PartnerID { get; set; }
        public bodyfilePartnersInputItemPartnerTypeType PartnerType { get; set; }
    }

    public class bodyfilePartnersInputItemPartnerTypeType
    {
        public int PartnerTypeID { get; set; }
    }

    public class bodyendorsementsInputItem
    {
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Infoquery;

    public partial class WorkflowManagedActions
    {
        public InfoqueryActions Infoquery(string connectionId) => new InfoqueryActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InfoqueryTriggers Infoquery(string connectionId) => new InfoqueryTriggers(connectionId);
    }
}