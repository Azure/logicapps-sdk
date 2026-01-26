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
        public IBodyWorkflowAction<AddNewPartnerEmployeeToPartnerCompanyResponse> AddNewPartnerEmployeeToPartnerCompany(Expression<Func<string>> partnerCompanyID, Expression<Func<string>> bodyPassword = null, Expression<Func<string>> bodyPasswordExpirationDate = null, Expression<Func<bool>> bodyEnabled = null, Expression<Func<bool>> bodyWebsiteAccess = null, Expression<Func<string>> bodyName = null, Expression<Func<string>> bodyFirstName = null, Expression<Func<string>> bodyLastName = null, Expression<Func<string>> bodyContactInformationEmailAddress = null)
        {
            var apiCallPath = "/AddNewPartnerEmployeeToPartnerCompany";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["PartnerCompanyID"] = ExpressionConverter.Convert(partnerCompanyID);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyPassword != null)
            {
                body["Password"] = ExpressionConverter.ConvertO(bodyPassword);
                bodypropCount++;
            }

            if (bodyPasswordExpirationDate != null)
            {
                body["PasswordExpirationDate"] = ExpressionConverter.ConvertO(bodyPasswordExpirationDate);
                bodypropCount++;
            }

            if (bodyEnabled != null)
            {
                body["Enabled"] = ExpressionConverter.ConvertO(bodyEnabled);
                bodypropCount++;
            }

            if (bodyWebsiteAccess != null)
            {
                body["WebsiteAccess"] = ExpressionConverter.ConvertO(bodyWebsiteAccess);
                bodypropCount++;
            }

            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodyFirstName != null)
            {
                body["FirstName"] = ExpressionConverter.ConvertO(bodyFirstName);
                bodypropCount++;
            }

            if (bodyLastName != null)
            {
                body["LastName"] = ExpressionConverter.ConvertO(bodyLastName);
                bodypropCount++;
            }

            var ContactInformationObject = new JObject();
            var ContactInformationObjectpropCount = 0;
            if (bodyContactInformationEmailAddress != null)
            {
                ContactInformationObject["EmailAddress"] = ExpressionConverter.ConvertO(bodyContactInformationEmailAddress);
                ContactInformationObjectpropCount++;
            }

            if (ContactInformationObjectpropCount > 0)
            {
                body["ContactInformation"] = ContactInformationObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddNewPartnerEmployeeToPartnerCompanyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<CreateNewFileResponse> CreateNewFile(Expression<Func<bodyBuyersInputItem[]>> bodyBuyers = null, Expression<Func<bodySellersInputItem[]>> bodySellers = null, Expression<Func<string>> bodyEstimatedSettlementDate = null, Expression<Func<int>> bodyTransactionProductTypeTransactionTypeID = null, Expression<Func<int>> bodyTransactionProductTypeProductTypeID = null, Expression<Func<int>> bodySalesPrice = null, Expression<Func<string>> bodyClientFileNumber = null, Expression<Func<string>> bodyPiggybackFileNumber = null, Expression<Func<string>> bodyMainFileNumber = null, Expression<Func<int>> bodySourceOfBusinessID = null, Expression<Func<string>> bodyNote = null, Expression<Func<bodyCustomFieldsInputItem[]>> bodyCustomFields = null, Expression<Func<bodyLoansInputItem[]>> bodyLoans = null, Expression<Func<bodyPropertiesInputItem[]>> bodyProperties = null)
        {
            var apiCallPath = "/CreateNewFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyBuyers != null)
            {
                body["Buyers"] = ExpressionConverter.ConvertO(bodyBuyers);
                bodypropCount++;
            }

            if (bodySellers != null)
            {
                body["Sellers"] = ExpressionConverter.ConvertO(bodySellers);
                bodypropCount++;
            }

            if (bodyEstimatedSettlementDate != null)
            {
                body["EstimatedSettlementDate"] = ExpressionConverter.ConvertO(bodyEstimatedSettlementDate);
                bodypropCount++;
            }

            var TransactionProductTypeObject = new JObject();
            var TransactionProductTypeObjectpropCount = 0;
            if (bodyTransactionProductTypeTransactionTypeID != null)
            {
                TransactionProductTypeObject["TransactionTypeID"] = ExpressionConverter.ConvertO(bodyTransactionProductTypeTransactionTypeID);
                TransactionProductTypeObjectpropCount++;
            }

            if (bodyTransactionProductTypeProductTypeID != null)
            {
                TransactionProductTypeObject["ProductTypeID"] = ExpressionConverter.ConvertO(bodyTransactionProductTypeProductTypeID);
                TransactionProductTypeObjectpropCount++;
            }

            if (TransactionProductTypeObjectpropCount > 0)
            {
                body["TransactionProductType"] = TransactionProductTypeObject;
                bodypropCount++;
            }

            if (bodySalesPrice != null)
            {
                body["SalesPrice"] = ExpressionConverter.ConvertO(bodySalesPrice);
                bodypropCount++;
            }

            if (bodyClientFileNumber != null)
            {
                body["ClientFileNumber"] = ExpressionConverter.ConvertO(bodyClientFileNumber);
                bodypropCount++;
            }

            if (bodyPiggybackFileNumber != null)
            {
                body["PiggybackFileNumber"] = ExpressionConverter.ConvertO(bodyPiggybackFileNumber);
                bodypropCount++;
            }

            if (bodyMainFileNumber != null)
            {
                body["MainFileNumber"] = ExpressionConverter.ConvertO(bodyMainFileNumber);
                bodypropCount++;
            }

            if (bodySourceOfBusinessID != null)
            {
                body["SourceOfBusinessID"] = ExpressionConverter.ConvertO(bodySourceOfBusinessID);
                bodypropCount++;
            }

            if (bodyNote != null)
            {
                body["Note"] = ExpressionConverter.ConvertO(bodyNote);
                bodypropCount++;
            }

            if (bodyCustomFields != null)
            {
                body["CustomFields"] = ExpressionConverter.ConvertO(bodyCustomFields);
                bodypropCount++;
            }

            if (bodyLoans != null)
            {
                body["Loans"] = ExpressionConverter.ConvertO(bodyLoans);
                bodypropCount++;
            }

            if (bodyProperties != null)
            {
                body["Properties"] = ExpressionConverter.ConvertO(bodyProperties);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateNewFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItem[]> GetTransactionAndProductTypesForEstimationAndOrderPlacement(Expression<Func<string>> state = null, Expression<Func<string>> county = null)
        {
            var apiCallPath = "/GetTransactionAndProductTypesForEstimationAndOrderPlacement";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (state != null)
                callPayload.Queries["State"] = ExpressionConverter.Convert(state);
            if (county != null)
                callPayload.Queries["County"] = ExpressionConverter.Convert(county);
            return new ApiConnectionAction<GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<UpdateActionForFileResponse> UpdateActionForFile(Expression<Func<string>> fileID, Expression<Func<string>> fileActionID, Expression<Func<int>> bodyStartTaskCoordinatorTypeID = null, Expression<Func<string>> bodyStartTaskDueDate = null, Expression<Func<bool>> bodyStartTaskDoneDateLocked = null, Expression<Func<int>> bodyCompleteTaskCoordinatorTypeID = null, Expression<Func<string>> bodyCompleteTaskDueDate = null, Expression<Func<bool>> bodyCompleteTaskDoneDateLocked = null)
        {
            var apiCallPath = "/UpdateActionForFile";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FileID"] = ExpressionConverter.Convert(fileID);
            callPayload.Queries["FileActionID"] = ExpressionConverter.Convert(fileActionID);
            var body = new JObject();
            var bodypropCount = 0;
            var StartTaskObject = new JObject();
            var StartTaskObjectpropCount = 0;
            if (bodyStartTaskCoordinatorTypeID != null)
            {
                StartTaskObject["CoordinatorTypeID"] = ExpressionConverter.ConvertO(bodyStartTaskCoordinatorTypeID);
                StartTaskObjectpropCount++;
            }

            if (bodyStartTaskDueDate != null)
            {
                StartTaskObject["DueDate"] = ExpressionConverter.ConvertO(bodyStartTaskDueDate);
                StartTaskObjectpropCount++;
            }

            if (bodyStartTaskDoneDateLocked != null)
            {
                StartTaskObject["DoneDateLocked"] = ExpressionConverter.ConvertO(bodyStartTaskDoneDateLocked);
                StartTaskObjectpropCount++;
            }

            if (StartTaskObjectpropCount > 0)
            {
                body["StartTask"] = StartTaskObject;
                bodypropCount++;
            }

            var CompleteTaskObject = new JObject();
            var CompleteTaskObjectpropCount = 0;
            if (bodyCompleteTaskCoordinatorTypeID != null)
            {
                CompleteTaskObject["CoordinatorTypeID"] = ExpressionConverter.ConvertO(bodyCompleteTaskCoordinatorTypeID);
                CompleteTaskObjectpropCount++;
            }

            if (bodyCompleteTaskDueDate != null)
            {
                CompleteTaskObject["DueDate"] = ExpressionConverter.ConvertO(bodyCompleteTaskDueDate);
                CompleteTaskObjectpropCount++;
            }

            if (bodyCompleteTaskDoneDateLocked != null)
            {
                CompleteTaskObject["DoneDateLocked"] = ExpressionConverter.ConvertO(bodyCompleteTaskDoneDateLocked);
                CompleteTaskObjectpropCount++;
            }

            if (CompleteTaskObjectpropCount > 0)
            {
                body["CompleteTask"] = CompleteTaskObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateActionForFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken> GetsFilesFromGivenSearchCriteria(Expression<Func<string>> bodyFileNumber = null, Expression<Func<int>> bodyFileID = null, Expression<Func<int>> bodyOfficeID = null, Expression<Func<string>> bodyClientsFileNumber = null, Expression<Func<int>> bodyTransactionProductTypeTransactionTypeID = null, Expression<Func<int>> bodyTransactionProductTypeProductTypeID = null, Expression<Func<bodyStatusesInputItem[]>> bodyStatuses = null, Expression<Func<string>> bodyPolicyNumber = null, Expression<Func<string>> bodySearchNumber = null, Expression<Func<string>> bodyLoanNumber = null, Expression<Func<bool>> bodyPropertyIsPrimary = null, Expression<Func<string>> bodyPropertyStreetNumber = null, Expression<Func<string>> bodyPropertyStreetName = null, Expression<Func<string>> bodyPropertyCity = null, Expression<Func<string>> bodyPropertyState = null, Expression<Func<string>> bodyPropertyZip = null, Expression<Func<string>> bodyPropertySubdivision = null, Expression<Func<string>> bodyPropertyParcelID = null, Expression<Func<string>> bodyBuyerEntityType = null, Expression<Func<string>> bodyBuyerPrimaryFirst = null, Expression<Func<string>> bodyBuyerPrimaryLast = null, Expression<Func<bool>> bodyBuyerUsePropertyAddress = null, Expression<Func<string>> bodyBuyerMaritalStatus = null, Expression<Func<int>> bodyFilePartnerPrimaryEmployeeUserID = null, Expression<Func<int>> bodyFilePartnerPartnerTypeID = null, Expression<Func<int>> bodyFilePartnerPartnerID = null, Expression<Func<int>> bodyFilePartnerPartnerTypePartnerTypeID = null, Expression<Func<string>> bodyOpenedFromDate = null, Expression<Func<string>> bodyOpenedToDate = null)
        {
            var apiCallPath = "/GetsFilesFromGivenSearchCriteria";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyFileNumber != null)
            {
                body["FileNumber"] = ExpressionConverter.ConvertO(bodyFileNumber);
                bodypropCount++;
            }

            if (bodyFileID != null)
            {
                body["FileID"] = ExpressionConverter.ConvertO(bodyFileID);
                bodypropCount++;
            }

            if (bodyOfficeID != null)
            {
                body["OfficeID"] = ExpressionConverter.ConvertO(bodyOfficeID);
                bodypropCount++;
            }

            if (bodyClientsFileNumber != null)
            {
                body["ClientsFileNumber"] = ExpressionConverter.ConvertO(bodyClientsFileNumber);
                bodypropCount++;
            }

            var TransactionProductTypeObject = new JObject();
            var TransactionProductTypeObjectpropCount = 0;
            if (bodyTransactionProductTypeTransactionTypeID != null)
            {
                TransactionProductTypeObject["TransactionTypeID"] = ExpressionConverter.ConvertO(bodyTransactionProductTypeTransactionTypeID);
                TransactionProductTypeObjectpropCount++;
            }

            if (bodyTransactionProductTypeProductTypeID != null)
            {
                TransactionProductTypeObject["ProductTypeID"] = ExpressionConverter.ConvertO(bodyTransactionProductTypeProductTypeID);
                TransactionProductTypeObjectpropCount++;
            }

            if (TransactionProductTypeObjectpropCount > 0)
            {
                body["TransactionProductType"] = TransactionProductTypeObject;
                bodypropCount++;
            }

            if (bodyStatuses != null)
            {
                body["Statuses"] = ExpressionConverter.ConvertO(bodyStatuses);
                bodypropCount++;
            }

            if (bodyPolicyNumber != null)
            {
                body["PolicyNumber"] = ExpressionConverter.ConvertO(bodyPolicyNumber);
                bodypropCount++;
            }

            if (bodySearchNumber != null)
            {
                body["SearchNumber"] = ExpressionConverter.ConvertO(bodySearchNumber);
                bodypropCount++;
            }

            if (bodyLoanNumber != null)
            {
                body["LoanNumber"] = ExpressionConverter.ConvertO(bodyLoanNumber);
                bodypropCount++;
            }

            var PropertyObject = new JObject();
            var PropertyObjectpropCount = 0;
            if (bodyPropertyIsPrimary != null)
            {
                PropertyObject["IsPrimary"] = ExpressionConverter.ConvertO(bodyPropertyIsPrimary);
                PropertyObjectpropCount++;
            }

            if (bodyPropertyStreetNumber != null)
            {
                PropertyObject["StreetNumber"] = ExpressionConverter.ConvertO(bodyPropertyStreetNumber);
                PropertyObjectpropCount++;
            }

            if (bodyPropertyStreetName != null)
            {
                PropertyObject["StreetName"] = ExpressionConverter.ConvertO(bodyPropertyStreetName);
                PropertyObjectpropCount++;
            }

            if (bodyPropertyCity != null)
            {
                PropertyObject["City"] = ExpressionConverter.ConvertO(bodyPropertyCity);
                PropertyObjectpropCount++;
            }

            if (bodyPropertyState != null)
            {
                PropertyObject["State"] = ExpressionConverter.ConvertO(bodyPropertyState);
                PropertyObjectpropCount++;
            }

            if (bodyPropertyZip != null)
            {
                PropertyObject["Zip"] = ExpressionConverter.ConvertO(bodyPropertyZip);
                PropertyObjectpropCount++;
            }

            if (bodyPropertySubdivision != null)
            {
                PropertyObject["Subdivision"] = ExpressionConverter.ConvertO(bodyPropertySubdivision);
                PropertyObjectpropCount++;
            }

            if (bodyPropertyParcelID != null)
            {
                PropertyObject["ParcelID"] = ExpressionConverter.ConvertO(bodyPropertyParcelID);
                PropertyObjectpropCount++;
            }

            if (PropertyObjectpropCount > 0)
            {
                body["Property"] = PropertyObject;
                bodypropCount++;
            }

            var BuyerObject = new JObject();
            var BuyerObjectpropCount = 0;
            if (bodyBuyerEntityType != null)
            {
                BuyerObject["EntityType"] = ExpressionConverter.ConvertO(bodyBuyerEntityType);
                BuyerObjectpropCount++;
            }

            var PrimaryObject = new JObject();
            var PrimaryObjectpropCount = 0;
            if (bodyBuyerPrimaryFirst != null)
            {
                PrimaryObject["First"] = ExpressionConverter.ConvertO(bodyBuyerPrimaryFirst);
                PrimaryObjectpropCount++;
            }

            if (bodyBuyerPrimaryLast != null)
            {
                PrimaryObject["Last"] = ExpressionConverter.ConvertO(bodyBuyerPrimaryLast);
                PrimaryObjectpropCount++;
            }

            if (PrimaryObjectpropCount > 0)
            {
                BuyerObject["Primary"] = PrimaryObject;
                BuyerObjectpropCount++;
            }

            if (bodyBuyerUsePropertyAddress != null)
            {
                BuyerObject["UsePropertyAddress"] = ExpressionConverter.ConvertO(bodyBuyerUsePropertyAddress);
                BuyerObjectpropCount++;
            }

            if (bodyBuyerMaritalStatus != null)
            {
                BuyerObject["MaritalStatus"] = ExpressionConverter.ConvertO(bodyBuyerMaritalStatus);
                BuyerObjectpropCount++;
            }

            if (BuyerObjectpropCount > 0)
            {
                body["Buyer"] = BuyerObject;
                bodypropCount++;
            }

            var FilePartnerObject = new JObject();
            var FilePartnerObjectpropCount = 0;
            var PrimaryEmployeeObject = new JObject();
            var PrimaryEmployeeObjectpropCount = 0;
            if (bodyFilePartnerPrimaryEmployeeUserID != null)
            {
                PrimaryEmployeeObject["UserID"] = ExpressionConverter.ConvertO(bodyFilePartnerPrimaryEmployeeUserID);
                PrimaryEmployeeObjectpropCount++;
            }

            if (PrimaryEmployeeObjectpropCount > 0)
            {
                FilePartnerObject["PrimaryEmployee"] = PrimaryEmployeeObject;
                FilePartnerObjectpropCount++;
            }

            if (bodyFilePartnerPartnerTypeID != null)
            {
                FilePartnerObject["PartnerTypeID"] = ExpressionConverter.ConvertO(bodyFilePartnerPartnerTypeID);
                FilePartnerObjectpropCount++;
            }

            if (bodyFilePartnerPartnerID != null)
            {
                FilePartnerObject["PartnerID"] = ExpressionConverter.ConvertO(bodyFilePartnerPartnerID);
                FilePartnerObjectpropCount++;
            }

            var PartnerTypeObject = new JObject();
            var PartnerTypeObjectpropCount = 0;
            if (bodyFilePartnerPartnerTypePartnerTypeID != null)
            {
                PartnerTypeObject["PartnerTypeID"] = ExpressionConverter.ConvertO(bodyFilePartnerPartnerTypePartnerTypeID);
                PartnerTypeObjectpropCount++;
            }

            if (PartnerTypeObjectpropCount > 0)
            {
                FilePartnerObject["PartnerType"] = PartnerTypeObject;
                FilePartnerObjectpropCount++;
            }

            if (FilePartnerObjectpropCount > 0)
            {
                body["FilePartner"] = FilePartnerObject;
                bodypropCount++;
            }

            if (bodyOpenedFromDate != null)
            {
                body["OpenedFromDate"] = ExpressionConverter.ConvertO(bodyOpenedFromDate);
                bodypropCount++;
            }

            if (bodyOpenedToDate != null)
            {
                body["OpenedToDate"] = ExpressionConverter.ConvertO(bodyOpenedToDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken> DeletePartnerOnSpecificFile(Expression<Func<string>> fileID, Expression<Func<bodyPartnersInputItem[]>> bodyPartners = null)
        {
            var apiCallPath = "/DeletePartnerOnSpecificFile";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FileID"] = ExpressionConverter.Convert(fileID);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyPartners != null)
            {
                body["Partners"] = ExpressionConverter.ConvertO(bodyPartners);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetPartnerInformationResponse> GetPartnerInformation(Expression<Func<string>> partnerCompanyID)
        {
            var apiCallPath = "/GetPartnerInformation";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["PartnerCompanyID"] = ExpressionConverter.Convert(partnerCompanyID);
            return new ApiConnectionAction<GetPartnerInformationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken> CancelsPreviouslyPlacedOrder(Expression<Func<string>> fileID, Expression<Func<int>> bodyFileID = null)
        {
            var apiCallPath = "/CancelsPreviouslyPlacedOrder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FileID"] = ExpressionConverter.Convert(fileID);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyFileID != null)
            {
                body["FileID"] = ExpressionConverter.ConvertO(bodyFileID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<CreateNewDocumentOnSpecificFileResponse> CreateNewDocumentOnSpecificFile(Expression<Func<string>> fileID, Expression<Func<string>> bodyDocumentName = null, Expression<Func<int>> bodyDocumentTypeDocumentTypeID = null, Expression<Func<string>> bodyDescription = null, Expression<Func<string>> bodyInternalOnly = null, Expression<Func<string>> bodyDocumentBody = null)
        {
            var apiCallPath = "/CreateNewDocumentOnSpecificFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FileID"] = ExpressionConverter.Convert(fileID);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyDocumentName != null)
            {
                body["DocumentName"] = ExpressionConverter.ConvertO(bodyDocumentName);
                bodypropCount++;
            }

            var DocumentTypeObject = new JObject();
            var DocumentTypeObjectpropCount = 0;
            if (bodyDocumentTypeDocumentTypeID != null)
            {
                DocumentTypeObject["DocumentTypeID"] = ExpressionConverter.ConvertO(bodyDocumentTypeDocumentTypeID);
                DocumentTypeObjectpropCount++;
            }

            if (DocumentTypeObjectpropCount > 0)
            {
                body["DocumentType"] = DocumentTypeObject;
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodyInternalOnly != null)
            {
                body["InternalOnly"] = ExpressionConverter.ConvertO(bodyInternalOnly);
                bodypropCount++;
            }

            if (bodyDocumentBody != null)
            {
                body["DocumentBody"] = ExpressionConverter.ConvertO(bodyDocumentBody);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateNewDocumentOnSpecificFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken> DeletePreviouslyPlacedOrder(Expression<Func<string>> fileID, Expression<Func<int>> bodyFileID = null)
        {
            var apiCallPath = "/DeletePreviouslyPlacedOrder";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FileID"] = ExpressionConverter.Convert(fileID);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyFileID != null)
            {
                body["FileID"] = ExpressionConverter.ConvertO(bodyFileID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken> AddOrUpdateCustomFieldOnSpecificFile(Expression<Func<string>> fileID, Expression<Func<bodyCustomFieldsInputItem[]>> bodyCustomFields = null)
        {
            var apiCallPath = "/AddOrUpdateCustomFieldOnSpecificFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FileID"] = ExpressionConverter.Convert(fileID);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyCustomFields != null)
            {
                body["CustomFields"] = ExpressionConverter.ConvertO(bodyCustomFields);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken> AddPartnerToSpecificFile(Expression<Func<string>> fileID, Expression<Func<bodyPartnersInputItem2[]>> bodyPartners = null)
        {
            var apiCallPath = "/AddPartnerToSpecificFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FileID"] = ExpressionConverter.Convert(fileID);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyPartners != null)
            {
                body["Partners"] = ExpressionConverter.ConvertO(bodyPartners);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<UpdatePartnerInformationForSpecificFileResponse> UpdatePartnerInformationForSpecificFile(Expression<Func<string>> fileID, Expression<Func<string>> partnerID, Expression<Func<int>> bodyFileID = null, Expression<Func<int>> bodyPrimaryEmployeeUserID = null, Expression<Func<string>> bodyPrimaryEmployeeName = null, Expression<Func<string>> bodyPrimaryEmployeeFirstName = null, Expression<Func<string>> bodyPrimaryEmployeeLastName = null, Expression<Func<string>> bodyPrimaryEmployeeContactInformationPhoneNumber = null, Expression<Func<string>> bodyPrimaryEmployeeContactInformationHomePhoneNumber = null, Expression<Func<string>> bodyPrimaryEmployeeContactInformationCellPhoneNumber = null, Expression<Func<string>> bodyPrimaryEmployeeContactInformationVoicemail = null, Expression<Func<string>> bodyPrimaryEmployeeContactInformationFaxNumber = null, Expression<Func<string>> bodyPrimaryEmployeeContactInformationEmailAddress = null, Expression<Func<string>> bodyPrimaryEmployeeContactInformationPreferredCommunicationMethod = null, Expression<Func<string>> bodyPrimaryEmployeeContactInformationWebsite = null, Expression<Func<bodySecondaryEmployeesInputItem[]>> bodySecondaryEmployees = null, Expression<Func<string>> bodyReferenceNumber = null, Expression<Func<string>> bodyRemoteFileNumber = null, Expression<Func<int>> bodyPartnerTypeID = null, Expression<Func<int>> bodyPartnerID = null, Expression<Func<int>> bodyPartnerTypePartnerTypeID = null, Expression<Func<string>> bodyPartnerTypePartnerTypeName = null, Expression<Func<int>> bodyOfficeID = null, Expression<Func<string>> bodyPartnerName = null, Expression<Func<string>> bodyMailingAddressAddress1 = null, Expression<Func<string>> bodyMailingAddressAddress2 = null, Expression<Func<string>> bodyMailingAddressCity = null, Expression<Func<string>> bodyMailingAddressState = null, Expression<Func<string>> bodyMailingAddressZip = null, Expression<Func<string>> bodyContactInformationPhoneNumber = null, Expression<Func<string>> bodyContactInformationHomePhoneNumber = null, Expression<Func<string>> bodyContactInformationCellPhoneNumber = null, Expression<Func<string>> bodyContactInformationVoicemail = null, Expression<Func<string>> bodyContactInformationFaxNumber = null, Expression<Func<string>> bodyContactInformationEmailAddress = null, Expression<Func<string>> bodyContactInformationPreferredCommunicationMethod = null, Expression<Func<string>> bodyContactInformationWebsite = null)
        {
            var apiCallPath = "/UpdatePartnerInformationForSpecificFile";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FileID"] = ExpressionConverter.Convert(fileID);
            callPayload.Queries["PartnerID"] = ExpressionConverter.Convert(partnerID);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyFileID != null)
            {
                body["FileID"] = ExpressionConverter.ConvertO(bodyFileID);
                bodypropCount++;
            }

            var PrimaryEmployeeObject = new JObject();
            var PrimaryEmployeeObjectpropCount = 0;
            if (bodyPrimaryEmployeeUserID != null)
            {
                PrimaryEmployeeObject["UserID"] = ExpressionConverter.ConvertO(bodyPrimaryEmployeeUserID);
                PrimaryEmployeeObjectpropCount++;
            }

            if (bodyPrimaryEmployeeName != null)
            {
                PrimaryEmployeeObject["Name"] = ExpressionConverter.ConvertO(bodyPrimaryEmployeeName);
                PrimaryEmployeeObjectpropCount++;
            }

            if (bodyPrimaryEmployeeFirstName != null)
            {
                PrimaryEmployeeObject["FirstName"] = ExpressionConverter.ConvertO(bodyPrimaryEmployeeFirstName);
                PrimaryEmployeeObjectpropCount++;
            }

            if (bodyPrimaryEmployeeLastName != null)
            {
                PrimaryEmployeeObject["LastName"] = ExpressionConverter.ConvertO(bodyPrimaryEmployeeLastName);
                PrimaryEmployeeObjectpropCount++;
            }

            var ContactInformationObject = new JObject();
            var ContactInformationObjectpropCount = 0;
            if (bodyPrimaryEmployeeContactInformationPhoneNumber != null)
            {
                ContactInformationObject["PhoneNumber"] = ExpressionConverter.ConvertO(bodyPrimaryEmployeeContactInformationPhoneNumber);
                ContactInformationObjectpropCount++;
            }

            if (bodyPrimaryEmployeeContactInformationHomePhoneNumber != null)
            {
                ContactInformationObject["HomePhoneNumber"] = ExpressionConverter.ConvertO(bodyPrimaryEmployeeContactInformationHomePhoneNumber);
                ContactInformationObjectpropCount++;
            }

            if (bodyPrimaryEmployeeContactInformationCellPhoneNumber != null)
            {
                ContactInformationObject["CellPhoneNumber"] = ExpressionConverter.ConvertO(bodyPrimaryEmployeeContactInformationCellPhoneNumber);
                ContactInformationObjectpropCount++;
            }

            if (bodyPrimaryEmployeeContactInformationVoicemail != null)
            {
                ContactInformationObject["Voicemail"] = ExpressionConverter.ConvertO(bodyPrimaryEmployeeContactInformationVoicemail);
                ContactInformationObjectpropCount++;
            }

            if (bodyPrimaryEmployeeContactInformationFaxNumber != null)
            {
                ContactInformationObject["FaxNumber"] = ExpressionConverter.ConvertO(bodyPrimaryEmployeeContactInformationFaxNumber);
                ContactInformationObjectpropCount++;
            }

            if (bodyPrimaryEmployeeContactInformationEmailAddress != null)
            {
                ContactInformationObject["EmailAddress"] = ExpressionConverter.ConvertO(bodyPrimaryEmployeeContactInformationEmailAddress);
                ContactInformationObjectpropCount++;
            }

            if (bodyPrimaryEmployeeContactInformationPreferredCommunicationMethod != null)
            {
                ContactInformationObject["PreferredCommunicationMethod"] = ExpressionConverter.ConvertO(bodyPrimaryEmployeeContactInformationPreferredCommunicationMethod);
                ContactInformationObjectpropCount++;
            }

            if (bodyPrimaryEmployeeContactInformationWebsite != null)
            {
                ContactInformationObject["Website"] = ExpressionConverter.ConvertO(bodyPrimaryEmployeeContactInformationWebsite);
                ContactInformationObjectpropCount++;
            }

            if (ContactInformationObjectpropCount > 0)
            {
                PrimaryEmployeeObject["ContactInformation"] = ContactInformationObject;
                PrimaryEmployeeObjectpropCount++;
            }

            if (PrimaryEmployeeObjectpropCount > 0)
            {
                body["PrimaryEmployee"] = PrimaryEmployeeObject;
                bodypropCount++;
            }

            if (bodySecondaryEmployees != null)
            {
                body["SecondaryEmployees"] = ExpressionConverter.ConvertO(bodySecondaryEmployees);
                bodypropCount++;
            }

            if (bodyReferenceNumber != null)
            {
                body["ReferenceNumber"] = ExpressionConverter.ConvertO(bodyReferenceNumber);
                bodypropCount++;
            }

            if (bodyRemoteFileNumber != null)
            {
                body["RemoteFileNumber"] = ExpressionConverter.ConvertO(bodyRemoteFileNumber);
                bodypropCount++;
            }

            if (bodyPartnerTypeID != null)
            {
                body["PartnerTypeID"] = ExpressionConverter.ConvertO(bodyPartnerTypeID);
                bodypropCount++;
            }

            if (bodyPartnerID != null)
            {
                body["PartnerID"] = ExpressionConverter.ConvertO(bodyPartnerID);
                bodypropCount++;
            }

            var PartnerTypeObject = new JObject();
            var PartnerTypeObjectpropCount = 0;
            if (bodyPartnerTypePartnerTypeID != null)
            {
                PartnerTypeObject["PartnerTypeID"] = ExpressionConverter.ConvertO(bodyPartnerTypePartnerTypeID);
                PartnerTypeObjectpropCount++;
            }

            if (bodyPartnerTypePartnerTypeName != null)
            {
                PartnerTypeObject["PartnerTypeName"] = ExpressionConverter.ConvertO(bodyPartnerTypePartnerTypeName);
                PartnerTypeObjectpropCount++;
            }

            if (PartnerTypeObjectpropCount > 0)
            {
                body["PartnerType"] = PartnerTypeObject;
                bodypropCount++;
            }

            if (bodyOfficeID != null)
            {
                body["OfficeID"] = ExpressionConverter.ConvertO(bodyOfficeID);
                bodypropCount++;
            }

            if (bodyPartnerName != null)
            {
                body["PartnerName"] = ExpressionConverter.ConvertO(bodyPartnerName);
                bodypropCount++;
            }

            var MailingAddressObject = new JObject();
            var MailingAddressObjectpropCount = 0;
            if (bodyMailingAddressAddress1 != null)
            {
                MailingAddressObject["Address1"] = ExpressionConverter.ConvertO(bodyMailingAddressAddress1);
                MailingAddressObjectpropCount++;
            }

            if (bodyMailingAddressAddress2 != null)
            {
                MailingAddressObject["Address2"] = ExpressionConverter.ConvertO(bodyMailingAddressAddress2);
                MailingAddressObjectpropCount++;
            }

            if (bodyMailingAddressCity != null)
            {
                MailingAddressObject["City"] = ExpressionConverter.ConvertO(bodyMailingAddressCity);
                MailingAddressObjectpropCount++;
            }

            if (bodyMailingAddressState != null)
            {
                MailingAddressObject["State"] = ExpressionConverter.ConvertO(bodyMailingAddressState);
                MailingAddressObjectpropCount++;
            }

            if (bodyMailingAddressZip != null)
            {
                MailingAddressObject["Zip"] = ExpressionConverter.ConvertO(bodyMailingAddressZip);
                MailingAddressObjectpropCount++;
            }

            if (MailingAddressObjectpropCount > 0)
            {
                body["MailingAddress"] = MailingAddressObject;
                bodypropCount++;
            }

            var ContactInformationObject = new JObject();
            var ContactInformationObjectpropCount = 0;
            if (bodyContactInformationPhoneNumber != null)
            {
                ContactInformationObject["PhoneNumber"] = ExpressionConverter.ConvertO(bodyContactInformationPhoneNumber);
                ContactInformationObjectpropCount++;
            }

            if (bodyContactInformationHomePhoneNumber != null)
            {
                ContactInformationObject["HomePhoneNumber"] = ExpressionConverter.ConvertO(bodyContactInformationHomePhoneNumber);
                ContactInformationObjectpropCount++;
            }

            if (bodyContactInformationCellPhoneNumber != null)
            {
                ContactInformationObject["CellPhoneNumber"] = ExpressionConverter.ConvertO(bodyContactInformationCellPhoneNumber);
                ContactInformationObjectpropCount++;
            }

            if (bodyContactInformationVoicemail != null)
            {
                ContactInformationObject["Voicemail"] = ExpressionConverter.ConvertO(bodyContactInformationVoicemail);
                ContactInformationObjectpropCount++;
            }

            if (bodyContactInformationFaxNumber != null)
            {
                ContactInformationObject["FaxNumber"] = ExpressionConverter.ConvertO(bodyContactInformationFaxNumber);
                ContactInformationObjectpropCount++;
            }

            if (bodyContactInformationEmailAddress != null)
            {
                ContactInformationObject["EmailAddress"] = ExpressionConverter.ConvertO(bodyContactInformationEmailAddress);
                ContactInformationObjectpropCount++;
            }

            if (bodyContactInformationPreferredCommunicationMethod != null)
            {
                ContactInformationObject["PreferredCommunicationMethod"] = ExpressionConverter.ConvertO(bodyContactInformationPreferredCommunicationMethod);
                ContactInformationObjectpropCount++;
            }

            if (bodyContactInformationWebsite != null)
            {
                ContactInformationObject["Website"] = ExpressionConverter.ConvertO(bodyContactInformationWebsite);
                ContactInformationObjectpropCount++;
            }

            if (ContactInformationObjectpropCount > 0)
            {
                body["ContactInformation"] = ContactInformationObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdatePartnerInformationForSpecificFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<AddNoteToFileResponse> AddNoteToFile(Expression<Func<string>> fileID, Expression<Func<string>> bodySubject = null, Expression<Func<string>> bodyBody = null)
        {
            var apiCallPath = "/AddNoteToFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FileID"] = ExpressionConverter.Convert(fileID);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodySubject != null)
            {
                body["Subject"] = ExpressionConverter.ConvertO(bodySubject);
                bodypropCount++;
            }

            if (bodyBody != null)
            {
                body["Body"] = ExpressionConverter.ConvertO(bodyBody);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddNoteToFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetPartnersForSpecificFileResponse> GetPartnersForSpecificFile(Expression<Func<string>> fileID)
        {
            var apiCallPath = "/GetPartnersForSpecificFile";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FileID"] = ExpressionConverter.Convert(fileID);
            return new ApiConnectionAction<GetPartnersForSpecificFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<UploadWebURLDocumentToSpecificFileResponse> UploadWebURLDocumentToSpecificFile(Expression<Func<string>> fileID, Expression<Func<string>> bodyDocumentName = null, Expression<Func<int>> bodyDocumentTypeDocumentTypeID = null, Expression<Func<string>> bodyDescription = null, Expression<Func<bool>> bodyInternalOnly = null, Expression<Func<string>> bodyWebURL = null)
        {
            var apiCallPath = "/UploadWebUrlDocumentToSpecificFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FileID"] = ExpressionConverter.Convert(fileID);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyDocumentName != null)
            {
                body["DocumentName"] = ExpressionConverter.ConvertO(bodyDocumentName);
                bodypropCount++;
            }

            var DocumentTypeObject = new JObject();
            var DocumentTypeObjectpropCount = 0;
            if (bodyDocumentTypeDocumentTypeID != null)
            {
                DocumentTypeObject["DocumentTypeID"] = ExpressionConverter.ConvertO(bodyDocumentTypeDocumentTypeID);
                DocumentTypeObjectpropCount++;
            }

            if (DocumentTypeObjectpropCount > 0)
            {
                body["DocumentType"] = DocumentTypeObject;
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodyInternalOnly != null)
            {
                body["InternalOnly"] = ExpressionConverter.ConvertO(bodyInternalOnly);
                bodypropCount++;
            }

            if (bodyWebURL != null)
            {
                body["WebURL"] = ExpressionConverter.ConvertO(bodyWebURL);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UploadWebURLDocumentToSpecificFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken> AddOrUpdateCustomFieldOnSpecificDocument(Expression<Func<string>> fileID, Expression<Func<string>> documentID, Expression<Func<bodyCustomFieldsInputItem[]>> bodyCustomFields = null)
        {
            var apiCallPath = "/AddOrUpdateCustomFieldOnSpecificDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FileID"] = ExpressionConverter.Convert(fileID);
            callPayload.Queries["DocumentID"] = ExpressionConverter.Convert(documentID);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyCustomFields != null)
            {
                body["CustomFields"] = ExpressionConverter.ConvertO(bodyCustomFields);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<UpdatePartnerEmployeeResponse> UpdatePartnerEmployee(Expression<Func<string>> userID, Expression<Func<string>> partnerCompanyID, Expression<Func<string>> bodyPassword = null, Expression<Func<string>> bodyPasswordExpirationDate = null, Expression<Func<bodyRolesInputItem[]>> bodyRoles = null, Expression<Func<bool>> bodyEnabled = null, Expression<Func<bool>> bodyWebsiteAccess = null, Expression<Func<string>> bodyName = null, Expression<Func<string>> bodyFirstName = null, Expression<Func<string>> bodyLastName = null, Expression<Func<string>> bodyContactInformationEmailAddress = null)
        {
            var apiCallPath = "/UpdatePartnerEmployee";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["UserID"] = ExpressionConverter.Convert(userID);
            callPayload.Queries["PartnerCompanyID"] = ExpressionConverter.Convert(partnerCompanyID);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyPassword != null)
            {
                body["Password"] = ExpressionConverter.ConvertO(bodyPassword);
                bodypropCount++;
            }

            if (bodyPasswordExpirationDate != null)
            {
                body["PasswordExpirationDate"] = ExpressionConverter.ConvertO(bodyPasswordExpirationDate);
                bodypropCount++;
            }

            if (bodyRoles != null)
            {
                body["Roles"] = ExpressionConverter.ConvertO(bodyRoles);
                bodypropCount++;
            }

            if (bodyEnabled != null)
            {
                body["Enabled"] = ExpressionConverter.ConvertO(bodyEnabled);
                bodypropCount++;
            }

            if (bodyWebsiteAccess != null)
            {
                body["WebsiteAccess"] = ExpressionConverter.ConvertO(bodyWebsiteAccess);
                bodypropCount++;
            }

            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodyFirstName != null)
            {
                body["FirstName"] = ExpressionConverter.ConvertO(bodyFirstName);
                bodypropCount++;
            }

            if (bodyLastName != null)
            {
                body["LastName"] = ExpressionConverter.ConvertO(bodyLastName);
                bodypropCount++;
            }

            var ContactInformationObject = new JObject();
            var ContactInformationObjectpropCount = 0;
            if (bodyContactInformationEmailAddress != null)
            {
                ContactInformationObject["EmailAddress"] = ExpressionConverter.ConvertO(bodyContactInformationEmailAddress);
                ContactInformationObjectpropCount++;
            }

            if (ContactInformationObjectpropCount > 0)
            {
                body["ContactInformation"] = ContactInformationObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdatePartnerEmployeeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetPartiesForSpecificFileResponse> GetPartiesForSpecificFile(Expression<Func<string>> fileID)
        {
            var apiCallPath = "/GetPartiesForSpecificFile";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FileID"] = ExpressionConverter.Convert(fileID);
            return new ApiConnectionAction<GetPartiesForSpecificFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetNotesForSpecificFileResponse> GetNotesForSpecificFile(Expression<Func<string>> fileID)
        {
            var apiCallPath = "/GetNotesForSpecificFile";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FileID"] = ExpressionConverter.Convert(fileID);
            return new ApiConnectionAction<GetNotesForSpecificFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetNoteResponse> GetNote(Expression<Func<string>> noteID)
        {
            var apiCallPath = "/GetNote";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["NoteID"] = ExpressionConverter.Convert(noteID);
            return new ApiConnectionAction<GetNoteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<AddActionToFileResponse> AddActionToFile(Expression<Func<string>> fileID, Expression<Func<int>> bodyActionTypeActionTypeID = null, Expression<Func<int>> bodyGroupActionGroupID = null, Expression<Func<int>> bodyStartTaskCoordinatorTypeID = null, Expression<Func<string>> bodyStartTaskDueDate = null, Expression<Func<int>> bodyCompleteTaskPartnerPartnerTypePartnerTypeID = null, Expression<Func<string>> bodyCompleteTaskDueDate = null)
        {
            var apiCallPath = "/AddActionToFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FileID"] = ExpressionConverter.Convert(fileID);
            var body = new JObject();
            var bodypropCount = 0;
            var ActionTypeObject = new JObject();
            var ActionTypeObjectpropCount = 0;
            if (bodyActionTypeActionTypeID != null)
            {
                ActionTypeObject["ActionTypeID"] = ExpressionConverter.ConvertO(bodyActionTypeActionTypeID);
                ActionTypeObjectpropCount++;
            }

            if (ActionTypeObjectpropCount > 0)
            {
                body["ActionType"] = ActionTypeObject;
                bodypropCount++;
            }

            var GroupObject = new JObject();
            var GroupObjectpropCount = 0;
            if (bodyGroupActionGroupID != null)
            {
                GroupObject["ActionGroupID"] = ExpressionConverter.ConvertO(bodyGroupActionGroupID);
                GroupObjectpropCount++;
            }

            if (GroupObjectpropCount > 0)
            {
                body["Group"] = GroupObject;
                bodypropCount++;
            }

            var StartTaskObject = new JObject();
            var StartTaskObjectpropCount = 0;
            if (bodyStartTaskCoordinatorTypeID != null)
            {
                StartTaskObject["CoordinatorTypeID"] = ExpressionConverter.ConvertO(bodyStartTaskCoordinatorTypeID);
                StartTaskObjectpropCount++;
            }

            if (bodyStartTaskDueDate != null)
            {
                StartTaskObject["DueDate"] = ExpressionConverter.ConvertO(bodyStartTaskDueDate);
                StartTaskObjectpropCount++;
            }

            if (StartTaskObjectpropCount > 0)
            {
                body["StartTask"] = StartTaskObject;
                bodypropCount++;
            }

            var CompleteTaskObject = new JObject();
            var CompleteTaskObjectpropCount = 0;
            var PartnerObject = new JObject();
            var PartnerObjectpropCount = 0;
            var PartnerTypeObject = new JObject();
            var PartnerTypeObjectpropCount = 0;
            if (bodyCompleteTaskPartnerPartnerTypePartnerTypeID != null)
            {
                PartnerTypeObject["PartnerTypeID"] = ExpressionConverter.ConvertO(bodyCompleteTaskPartnerPartnerTypePartnerTypeID);
                PartnerTypeObjectpropCount++;
            }

            if (PartnerTypeObjectpropCount > 0)
            {
                PartnerObject["PartnerType"] = PartnerTypeObject;
                PartnerObjectpropCount++;
            }

            if (PartnerObjectpropCount > 0)
            {
                CompleteTaskObject["Partner"] = PartnerObject;
                CompleteTaskObjectpropCount++;
            }

            if (bodyCompleteTaskDueDate != null)
            {
                CompleteTaskObject["DueDate"] = ExpressionConverter.ConvertO(bodyCompleteTaskDueDate);
                CompleteTaskObjectpropCount++;
            }

            if (CompleteTaskObjectpropCount > 0)
            {
                body["CompleteTask"] = CompleteTaskObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddActionToFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetCustomFieldsOnSpecificDocumentResponse> GetCustomFieldsOnSpecificDocument(Expression<Func<string>> fileID, Expression<Func<string>> documentID)
        {
            var apiCallPath = "/GetCustomFieldsOnSpecificDocument";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FileID"] = ExpressionConverter.Convert(fileID);
            callPayload.Queries["DocumentID"] = ExpressionConverter.Convert(documentID);
            return new ApiConnectionAction<GetCustomFieldsOnSpecificDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetDocumentsForSpecificFileResponse> GetDocumentsForSpecificFile(Expression<Func<string>> fileID)
        {
            var apiCallPath = "/GetDocumentsForSpecificFile";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FileID"] = ExpressionConverter.Convert(fileID);
            return new ApiConnectionAction<GetDocumentsForSpecificFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetDocumentResponse> GetDocument(Expression<Func<string>> documentID)
        {
            var apiCallPath = "/GetDocument";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["DocumentID"] = ExpressionConverter.Convert(documentID);
            return new ApiConnectionAction<GetDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetCustomFieldsForSpecificFileResponse> GetCustomFieldsForSpecificFile(Expression<Func<string>> fileID)
        {
            var apiCallPath = "/GetCustomFieldsForSpecificFile";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FileID"] = ExpressionConverter.Convert(fileID);
            return new ApiConnectionAction<GetCustomFieldsForSpecificFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetClosingFeeEstimateReceiptResponse> GetClosingFeeEstimateReceipt(Expression<Func<string>> closingFeeID)
        {
            var apiCallPath = "/GetClosingFeeEstimateReceipt";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ClosingFeeID"] = ExpressionConverter.Convert(closingFeeID);
            return new ApiConnectionAction<GetClosingFeeEstimateReceiptResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken> GetClosingFeeEstimateReceiptPDF(Expression<Func<string>> closingFeeID)
        {
            var apiCallPath = "/GetClosingFeeEstimateReceiptPDF";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ClosingFeeID"] = ExpressionConverter.Convert(closingFeeID);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetActionsForSpecificFileResponse> GetActionsForSpecificFile(Expression<Func<string>> fileID)
        {
            var apiCallPath = "/GetActionsForSpecificFile";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FileID"] = ExpressionConverter.Convert(fileID);
            return new ApiConnectionAction<GetActionsForSpecificFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetCurrentUserInfoResponse> GetCurrentUserInfo()
        {
            var apiCallPath = "/GetCurrentUserInfo";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCurrentUserInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<EstimateClosingFeeResponse> EstimateClosingFee(Expression<Func<int>> bodyTransactionProductTypeTransactionTypeID = null, Expression<Func<int>> bodyTransactionProductTypeProductTypeID = null, Expression<Func<string>> bodySettlementStatementVersion = null, Expression<Func<int>> bodySalesPrice = null, Expression<Func<bodyLoansInputItem2[]>> bodyLoans = null, Expression<Func<bodyPropertiesInputItem[]>> bodyProperties = null, Expression<Func<bodyFilePartnersInputItem[]>> bodyFilePartners = null, Expression<Func<bodyEndorsementsInputItem[]>> bodyEndorsements = null)
        {
            var apiCallPath = "/EstimateClosingFee";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var TransactionProductTypeObject = new JObject();
            var TransactionProductTypeObjectpropCount = 0;
            if (bodyTransactionProductTypeTransactionTypeID != null)
            {
                TransactionProductTypeObject["TransactionTypeID"] = ExpressionConverter.ConvertO(bodyTransactionProductTypeTransactionTypeID);
                TransactionProductTypeObjectpropCount++;
            }

            if (bodyTransactionProductTypeProductTypeID != null)
            {
                TransactionProductTypeObject["ProductTypeID"] = ExpressionConverter.ConvertO(bodyTransactionProductTypeProductTypeID);
                TransactionProductTypeObjectpropCount++;
            }

            if (TransactionProductTypeObjectpropCount > 0)
            {
                body["TransactionProductType"] = TransactionProductTypeObject;
                bodypropCount++;
            }

            if (bodySettlementStatementVersion != null)
            {
                body["SettlementStatementVersion"] = ExpressionConverter.ConvertO(bodySettlementStatementVersion);
                bodypropCount++;
            }

            if (bodySalesPrice != null)
            {
                body["SalesPrice"] = ExpressionConverter.ConvertO(bodySalesPrice);
                bodypropCount++;
            }

            if (bodyLoans != null)
            {
                body["Loans"] = ExpressionConverter.ConvertO(bodyLoans);
                bodypropCount++;
            }

            if (bodyProperties != null)
            {
                body["Properties"] = ExpressionConverter.ConvertO(bodyProperties);
                bodypropCount++;
            }

            if (bodyFilePartners != null)
            {
                body["FilePartners"] = ExpressionConverter.ConvertO(bodyFilePartners);
                bodypropCount++;
            }

            if (bodyEndorsements != null)
            {
                body["Endorsements"] = ExpressionConverter.ConvertO(bodyEndorsements);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EstimateClosingFeeResponse>(callPayload);
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

    public class bodyBuyersInputItem
    {
        public string EntityType { get; set; }
        public bool IsPrimaryTransactee { get; set; }
        public bodyBuyersInputItemPrimaryType Primary { get; set; }
        public bool UsePropertyAddress { get; set; }
        public bodyBuyersInputItemAddressType Address { get; set; }
        public string MaritalStatus { get; set; }
        public string Email { get; set; }
    }

    public class bodyBuyersInputItemPrimaryType
    {
        public string First { get; set; }
        public string Last { get; set; }
    }

    public class bodyBuyersInputItemAddressType
    {
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class bodySellersInputItem
    {
        public string EntityType { get; set; }
        public bool IsPrimaryTransactee { get; set; }
        public bodySellersInputItemPrimaryType Primary { get; set; }
        public bool UsePropertyAddress { get; set; }
        public bodySellersInputItemAddressType Address { get; set; }
        public string MaritalStatus { get; set; }
        public string Email { get; set; }
    }

    public class bodySellersInputItemPrimaryType
    {
        public string First { get; set; }
        public string Last { get; set; }
    }

    public class bodySellersInputItemAddressType
    {
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class bodyCustomFieldsInputItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class bodyLoansInputItem
    {
        public int LienPosition { get; set; }
        public string LoanNumber { get; set; }
        public int LoanAmount { get; set; }
        public string LoanType { get; set; }
    }

    public class bodyPropertiesInputItem
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

    public class bodyStatusesInputItem
    {
        public int StatusID { get; set; }
        public string Name { get; set; }
    }

    public class bodyPartnersInputItem
    {
        public int PartnerTypeID { get; set; }
        public int PartnerID { get; set; }
        public bodyPartnersInputItemPartnerTypeType PartnerType { get; set; }
    }

    public class bodyPartnersInputItemPartnerTypeType
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

    public class bodyPartnersInputItem2
    {
        public bodyPartnersInputItemPrimaryEmployeeType PrimaryEmployee { get; set; }
        public bodyPartnersInputItemSecondaryEmployeesTypeItem[] SecondaryEmployees { get; set; }
        public int PartnerTypeID { get; set; }
        public int PartnerID { get; set; }
        public bodyPartnersInputItemPartnerTypeType PartnerType { get; set; }
    }

    public class bodyPartnersInputItemPrimaryEmployeeType
    {
        public int UserID { get; set; }
    }

    public class bodyPartnersInputItemSecondaryEmployeesTypeItem
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

    public class bodySecondaryEmployeesInputItem
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bodySecondaryEmployeesInputItemContactInformationType ContactInformation { get; set; }
    }

    public class bodySecondaryEmployeesInputItemContactInformationType
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

    public class bodyRolesInputItem
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

    public class bodyLoansInputItem2
    {
        public int LienPosition { get; set; }
        public int LoanAmount { get; set; }
        public string LoanType { get; set; }
    }

    public class bodyFilePartnersInputItem
    {
        public int PartnerTypeID { get; set; }
        public int PartnerID { get; set; }
        public bodyFilePartnersInputItemPartnerTypeType PartnerType { get; set; }
    }

    public class bodyFilePartnersInputItemPartnerTypeType
    {
        public int PartnerTypeID { get; set; }
    }

    public class bodyEndorsementsInputItem
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