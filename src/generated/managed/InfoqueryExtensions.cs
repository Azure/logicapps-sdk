//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Infoquery
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InfoqueryActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<AddNewPartnerEmployeeToPartnerCompanyResponse, ApiConnectionActionConfiguration> AddNewPartnerEmployeeToPartnerCompany(Expression<Func<string>> partnerCompanyId, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodypasswordExpirationDate = null, Expression<Func<bool>> bodyenabled = null, Expression<Func<bool>> bodywebsiteAccess = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodycontactInformationemailAddress = null)
        {
            var __workflow_partnerCompanyId = WorkflowExpression.Compile(partnerCompanyId, nameof(partnerCompanyId), required: true);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodypasswordExpirationDate = WorkflowExpression.Compile(bodypasswordExpirationDate, nameof(bodypasswordExpirationDate), required: false);
            var __workflow_bodyenabled = WorkflowExpression.Compile(bodyenabled, nameof(bodyenabled), required: false);
            var __workflow_bodywebsiteAccess = WorkflowExpression.Compile(bodywebsiteAccess, nameof(bodywebsiteAccess), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodycontactInformationemailAddress = WorkflowExpression.Compile(bodycontactInformationemailAddress, nameof(bodycontactInformationemailAddress), required: false);
            return new DeferredBodyAction<AddNewPartnerEmployeeToPartnerCompanyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AddNewPartnerEmployeeToPartnerCompany";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["PartnerCompanyID"] = ExpressionConverter.Convert(__workflow_partnerCompanyId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypassword != null)
                {
                    body["Password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodypasswordExpirationDate != null)
                {
                    body["PasswordExpirationDate"] = ExpressionConverter.ConvertO(__workflow_bodypasswordExpirationDate);
                    bodypropCount++;
                }

                if (__workflow_bodyenabled != null)
                {
                    body["Enabled"] = ExpressionConverter.ConvertO(__workflow_bodyenabled);
                    bodypropCount++;
                }

                if (__workflow_bodywebsiteAccess != null)
                {
                    body["WebsiteAccess"] = ExpressionConverter.ConvertO(__workflow_bodywebsiteAccess);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["FirstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["LastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                var contactInformationObject = new JObject();
                var contactInformationObjectpropCount = 0;
                if (__workflow_bodycontactInformationemailAddress != null)
                {
                    contactInformationObject["EmailAddress"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationemailAddress);
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

                return new ApiConnectionAction<AddNewPartnerEmployeeToPartnerCompanyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<CreateNewFileResponse, ApiConnectionActionConfiguration> CreateNewFile(Expression<Func<bodybuyersInputItem[]>> bodybuyers = null, Expression<Func<bodysellersInputItem[]>> bodysellers = null, Expression<Func<string>> bodyestimatedSettlementDate = null, Expression<Func<int>> bodytransactionProductTypetransactionTypeId = null, Expression<Func<int>> bodytransactionProductTypeproductTypeId = null, Expression<Func<int>> bodysalesPrice = null, Expression<Func<string>> bodyclientFileNumber = null, Expression<Func<string>> bodypiggybackFileNumber = null, Expression<Func<string>> bodymainFileNumber = null, Expression<Func<int>> bodysourceOfBusinessId = null, Expression<Func<string>> bodynote = null, Expression<Func<bodycustomFieldsInputItem[]>> bodycustomFields = null, Expression<Func<bodyloansInputItem[]>> bodyloans = null, Expression<Func<bodypropertiesInputItem[]>> bodyproperties = null)
        {
            var __workflow_bodybuyers = WorkflowExpression.Compile(bodybuyers, nameof(bodybuyers), required: false);
            var __workflow_bodysellers = WorkflowExpression.Compile(bodysellers, nameof(bodysellers), required: false);
            var __workflow_bodyestimatedSettlementDate = WorkflowExpression.Compile(bodyestimatedSettlementDate, nameof(bodyestimatedSettlementDate), required: false);
            var __workflow_bodytransactionProductTypetransactionTypeId = WorkflowExpression.Compile(bodytransactionProductTypetransactionTypeId, nameof(bodytransactionProductTypetransactionTypeId), required: false);
            var __workflow_bodytransactionProductTypeproductTypeId = WorkflowExpression.Compile(bodytransactionProductTypeproductTypeId, nameof(bodytransactionProductTypeproductTypeId), required: false);
            var __workflow_bodysalesPrice = WorkflowExpression.Compile(bodysalesPrice, nameof(bodysalesPrice), required: false);
            var __workflow_bodyclientFileNumber = WorkflowExpression.Compile(bodyclientFileNumber, nameof(bodyclientFileNumber), required: false);
            var __workflow_bodypiggybackFileNumber = WorkflowExpression.Compile(bodypiggybackFileNumber, nameof(bodypiggybackFileNumber), required: false);
            var __workflow_bodymainFileNumber = WorkflowExpression.Compile(bodymainFileNumber, nameof(bodymainFileNumber), required: false);
            var __workflow_bodysourceOfBusinessId = WorkflowExpression.Compile(bodysourceOfBusinessId, nameof(bodysourceOfBusinessId), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            var __workflow_bodycustomFields = WorkflowExpression.Compile(bodycustomFields, nameof(bodycustomFields), required: false);
            var __workflow_bodyloans = WorkflowExpression.Compile(bodyloans, nameof(bodyloans), required: false);
            var __workflow_bodyproperties = WorkflowExpression.Compile(bodyproperties, nameof(bodyproperties), required: false);
            return new DeferredBodyAction<CreateNewFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CreateNewFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodybuyers != null)
                {
                    body["Buyers"] = ExpressionConverter.ConvertO(__workflow_bodybuyers);
                    bodypropCount++;
                }

                if (__workflow_bodysellers != null)
                {
                    body["Sellers"] = ExpressionConverter.ConvertO(__workflow_bodysellers);
                    bodypropCount++;
                }

                if (__workflow_bodyestimatedSettlementDate != null)
                {
                    body["EstimatedSettlementDate"] = ExpressionConverter.ConvertO(__workflow_bodyestimatedSettlementDate);
                    bodypropCount++;
                }

                var transactionProductTypeObject = new JObject();
                var transactionProductTypeObjectpropCount = 0;
                if (__workflow_bodytransactionProductTypetransactionTypeId != null)
                {
                    transactionProductTypeObject["TransactionTypeID"] = ExpressionConverter.ConvertO(__workflow_bodytransactionProductTypetransactionTypeId);
                    transactionProductTypeObjectpropCount++;
                }

                if (__workflow_bodytransactionProductTypeproductTypeId != null)
                {
                    transactionProductTypeObject["ProductTypeID"] = ExpressionConverter.ConvertO(__workflow_bodytransactionProductTypeproductTypeId);
                    transactionProductTypeObjectpropCount++;
                }

                if (transactionProductTypeObjectpropCount > 0)
                {
                    body["TransactionProductType"] = transactionProductTypeObject;
                    bodypropCount++;
                }

                if (__workflow_bodysalesPrice != null)
                {
                    body["SalesPrice"] = ExpressionConverter.ConvertO(__workflow_bodysalesPrice);
                    bodypropCount++;
                }

                if (__workflow_bodyclientFileNumber != null)
                {
                    body["ClientFileNumber"] = ExpressionConverter.ConvertO(__workflow_bodyclientFileNumber);
                    bodypropCount++;
                }

                if (__workflow_bodypiggybackFileNumber != null)
                {
                    body["PiggybackFileNumber"] = ExpressionConverter.ConvertO(__workflow_bodypiggybackFileNumber);
                    bodypropCount++;
                }

                if (__workflow_bodymainFileNumber != null)
                {
                    body["MainFileNumber"] = ExpressionConverter.ConvertO(__workflow_bodymainFileNumber);
                    bodypropCount++;
                }

                if (__workflow_bodysourceOfBusinessId != null)
                {
                    body["SourceOfBusinessID"] = ExpressionConverter.ConvertO(__workflow_bodysourceOfBusinessId);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["Note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFields != null)
                {
                    body["CustomFields"] = ExpressionConverter.ConvertO(__workflow_bodycustomFields);
                    bodypropCount++;
                }

                if (__workflow_bodyloans != null)
                {
                    body["Loans"] = ExpressionConverter.ConvertO(__workflow_bodyloans);
                    bodypropCount++;
                }

                if (__workflow_bodyproperties != null)
                {
                    body["Properties"] = ExpressionConverter.ConvertO(__workflow_bodyproperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateNewFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItem[], ApiConnectionActionConfiguration> GetTransactionAndProductTypesForEstimationAndOrderPlacement(Expression<Func<string>> state = null, Expression<Func<string>> county = null)
        {
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            var __workflow_county = WorkflowExpression.Compile(county, nameof(county), required: false);
            return new DeferredBodyAction<GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetTransactionAndProductTypesForEstimationAndOrderPlacement";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_state != null)
                    callPayload.Queries["State"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_county != null)
                    callPayload.Queries["County"] = ExpressionConverter.Convert(__workflow_county);
                return new ApiConnectionAction<GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<UpdateActionForFileResponse, ApiConnectionActionConfiguration> UpdateActionForFile(Expression<Func<string>> fileId, Expression<Func<string>> fileActionId, Expression<Func<int>> bodystartTaskcoordinatorTypeId = null, Expression<Func<string>> bodystartTaskdueDate = null, Expression<Func<bool>> bodystartTaskdoneDateLocked = null, Expression<Func<int>> bodycompleteTaskcoordinatorTypeId = null, Expression<Func<string>> bodycompleteTaskdueDate = null, Expression<Func<bool>> bodycompleteTaskdoneDateLocked = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_fileActionId = WorkflowExpression.Compile(fileActionId, nameof(fileActionId), required: true);
            var __workflow_bodystartTaskcoordinatorTypeId = WorkflowExpression.Compile(bodystartTaskcoordinatorTypeId, nameof(bodystartTaskcoordinatorTypeId), required: false);
            var __workflow_bodystartTaskdueDate = WorkflowExpression.Compile(bodystartTaskdueDate, nameof(bodystartTaskdueDate), required: false);
            var __workflow_bodystartTaskdoneDateLocked = WorkflowExpression.Compile(bodystartTaskdoneDateLocked, nameof(bodystartTaskdoneDateLocked), required: false);
            var __workflow_bodycompleteTaskcoordinatorTypeId = WorkflowExpression.Compile(bodycompleteTaskcoordinatorTypeId, nameof(bodycompleteTaskcoordinatorTypeId), required: false);
            var __workflow_bodycompleteTaskdueDate = WorkflowExpression.Compile(bodycompleteTaskdueDate, nameof(bodycompleteTaskdueDate), required: false);
            var __workflow_bodycompleteTaskdoneDateLocked = WorkflowExpression.Compile(bodycompleteTaskdoneDateLocked, nameof(bodycompleteTaskdoneDateLocked), required: false);
            return new DeferredBodyAction<UpdateActionForFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UpdateActionForFile";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                callPayload.Queries["FileActionID"] = ExpressionConverter.Convert(__workflow_fileActionId);
                var body = new JObject();
                var bodypropCount = 0;
                var startTaskObject = new JObject();
                var startTaskObjectpropCount = 0;
                if (__workflow_bodystartTaskcoordinatorTypeId != null)
                {
                    startTaskObject["CoordinatorTypeID"] = ExpressionConverter.ConvertO(__workflow_bodystartTaskcoordinatorTypeId);
                    startTaskObjectpropCount++;
                }

                if (__workflow_bodystartTaskdueDate != null)
                {
                    startTaskObject["DueDate"] = ExpressionConverter.ConvertO(__workflow_bodystartTaskdueDate);
                    startTaskObjectpropCount++;
                }

                if (__workflow_bodystartTaskdoneDateLocked != null)
                {
                    startTaskObject["DoneDateLocked"] = ExpressionConverter.ConvertO(__workflow_bodystartTaskdoneDateLocked);
                    startTaskObjectpropCount++;
                }

                if (startTaskObjectpropCount > 0)
                {
                    body["StartTask"] = startTaskObject;
                    bodypropCount++;
                }

                var completeTaskObject = new JObject();
                var completeTaskObjectpropCount = 0;
                if (__workflow_bodycompleteTaskcoordinatorTypeId != null)
                {
                    completeTaskObject["CoordinatorTypeID"] = ExpressionConverter.ConvertO(__workflow_bodycompleteTaskcoordinatorTypeId);
                    completeTaskObjectpropCount++;
                }

                if (__workflow_bodycompleteTaskdueDate != null)
                {
                    completeTaskObject["DueDate"] = ExpressionConverter.ConvertO(__workflow_bodycompleteTaskdueDate);
                    completeTaskObjectpropCount++;
                }

                if (__workflow_bodycompleteTaskdoneDateLocked != null)
                {
                    completeTaskObject["DoneDateLocked"] = ExpressionConverter.ConvertO(__workflow_bodycompleteTaskdoneDateLocked);
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

                return new ApiConnectionAction<UpdateActionForFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetsFilesFromGivenSearchCriteria(Expression<Func<string>> bodyfileNumber = null, Expression<Func<int>> bodyfileId = null, Expression<Func<int>> bodyofficeId = null, Expression<Func<string>> bodyclientsFileNumber = null, Expression<Func<int>> bodytransactionProductTypetransactionTypeId = null, Expression<Func<int>> bodytransactionProductTypeproductTypeId = null, Expression<Func<bodystatusesInputItem[]>> bodystatuses = null, Expression<Func<string>> bodypolicyNumber = null, Expression<Func<string>> bodysearchNumber = null, Expression<Func<string>> bodyloanNumber = null, Expression<Func<bool>> bodypropertyisPrimary = null, Expression<Func<string>> bodypropertystreetNumber = null, Expression<Func<string>> bodypropertystreetName = null, Expression<Func<string>> bodypropertycity = null, Expression<Func<string>> bodypropertystate = null, Expression<Func<string>> bodypropertyzip = null, Expression<Func<string>> bodypropertysubdivision = null, Expression<Func<string>> bodypropertyparcelId = null, Expression<Func<string>> bodybuyerentityType = null, Expression<Func<string>> bodybuyerprimaryfirst = null, Expression<Func<string>> bodybuyerprimarylast = null, Expression<Func<bool>> bodybuyerusePropertyAddress = null, Expression<Func<string>> bodybuyermaritalStatus = null, Expression<Func<int>> bodyfilePartnerprimaryEmployeeuserId = null, Expression<Func<int>> bodyfilePartnerpartnerTypeId = null, Expression<Func<int>> bodyfilePartnerpartnerId = null, Expression<Func<int>> bodyfilePartnerpartnerTypepartnerTypeId = null, Expression<Func<string>> bodyopenedFromDate = null, Expression<Func<string>> bodyopenedToDate = null)
        {
            var __workflow_bodyfileNumber = WorkflowExpression.Compile(bodyfileNumber, nameof(bodyfileNumber), required: false);
            var __workflow_bodyfileId = WorkflowExpression.Compile(bodyfileId, nameof(bodyfileId), required: false);
            var __workflow_bodyofficeId = WorkflowExpression.Compile(bodyofficeId, nameof(bodyofficeId), required: false);
            var __workflow_bodyclientsFileNumber = WorkflowExpression.Compile(bodyclientsFileNumber, nameof(bodyclientsFileNumber), required: false);
            var __workflow_bodytransactionProductTypetransactionTypeId = WorkflowExpression.Compile(bodytransactionProductTypetransactionTypeId, nameof(bodytransactionProductTypetransactionTypeId), required: false);
            var __workflow_bodytransactionProductTypeproductTypeId = WorkflowExpression.Compile(bodytransactionProductTypeproductTypeId, nameof(bodytransactionProductTypeproductTypeId), required: false);
            var __workflow_bodystatuses = WorkflowExpression.Compile(bodystatuses, nameof(bodystatuses), required: false);
            var __workflow_bodypolicyNumber = WorkflowExpression.Compile(bodypolicyNumber, nameof(bodypolicyNumber), required: false);
            var __workflow_bodysearchNumber = WorkflowExpression.Compile(bodysearchNumber, nameof(bodysearchNumber), required: false);
            var __workflow_bodyloanNumber = WorkflowExpression.Compile(bodyloanNumber, nameof(bodyloanNumber), required: false);
            var __workflow_bodypropertyisPrimary = WorkflowExpression.Compile(bodypropertyisPrimary, nameof(bodypropertyisPrimary), required: false);
            var __workflow_bodypropertystreetNumber = WorkflowExpression.Compile(bodypropertystreetNumber, nameof(bodypropertystreetNumber), required: false);
            var __workflow_bodypropertystreetName = WorkflowExpression.Compile(bodypropertystreetName, nameof(bodypropertystreetName), required: false);
            var __workflow_bodypropertycity = WorkflowExpression.Compile(bodypropertycity, nameof(bodypropertycity), required: false);
            var __workflow_bodypropertystate = WorkflowExpression.Compile(bodypropertystate, nameof(bodypropertystate), required: false);
            var __workflow_bodypropertyzip = WorkflowExpression.Compile(bodypropertyzip, nameof(bodypropertyzip), required: false);
            var __workflow_bodypropertysubdivision = WorkflowExpression.Compile(bodypropertysubdivision, nameof(bodypropertysubdivision), required: false);
            var __workflow_bodypropertyparcelId = WorkflowExpression.Compile(bodypropertyparcelId, nameof(bodypropertyparcelId), required: false);
            var __workflow_bodybuyerentityType = WorkflowExpression.Compile(bodybuyerentityType, nameof(bodybuyerentityType), required: false);
            var __workflow_bodybuyerprimaryfirst = WorkflowExpression.Compile(bodybuyerprimaryfirst, nameof(bodybuyerprimaryfirst), required: false);
            var __workflow_bodybuyerprimarylast = WorkflowExpression.Compile(bodybuyerprimarylast, nameof(bodybuyerprimarylast), required: false);
            var __workflow_bodybuyerusePropertyAddress = WorkflowExpression.Compile(bodybuyerusePropertyAddress, nameof(bodybuyerusePropertyAddress), required: false);
            var __workflow_bodybuyermaritalStatus = WorkflowExpression.Compile(bodybuyermaritalStatus, nameof(bodybuyermaritalStatus), required: false);
            var __workflow_bodyfilePartnerprimaryEmployeeuserId = WorkflowExpression.Compile(bodyfilePartnerprimaryEmployeeuserId, nameof(bodyfilePartnerprimaryEmployeeuserId), required: false);
            var __workflow_bodyfilePartnerpartnerTypeId = WorkflowExpression.Compile(bodyfilePartnerpartnerTypeId, nameof(bodyfilePartnerpartnerTypeId), required: false);
            var __workflow_bodyfilePartnerpartnerId = WorkflowExpression.Compile(bodyfilePartnerpartnerId, nameof(bodyfilePartnerpartnerId), required: false);
            var __workflow_bodyfilePartnerpartnerTypepartnerTypeId = WorkflowExpression.Compile(bodyfilePartnerpartnerTypepartnerTypeId, nameof(bodyfilePartnerpartnerTypepartnerTypeId), required: false);
            var __workflow_bodyopenedFromDate = WorkflowExpression.Compile(bodyopenedFromDate, nameof(bodyopenedFromDate), required: false);
            var __workflow_bodyopenedToDate = WorkflowExpression.Compile(bodyopenedToDate, nameof(bodyopenedToDate), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetsFilesFromGivenSearchCriteria";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfileNumber != null)
                {
                    body["FileNumber"] = ExpressionConverter.ConvertO(__workflow_bodyfileNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyfileId != null)
                {
                    body["FileID"] = ExpressionConverter.ConvertO(__workflow_bodyfileId);
                    bodypropCount++;
                }

                if (__workflow_bodyofficeId != null)
                {
                    body["OfficeID"] = ExpressionConverter.ConvertO(__workflow_bodyofficeId);
                    bodypropCount++;
                }

                if (__workflow_bodyclientsFileNumber != null)
                {
                    body["ClientsFileNumber"] = ExpressionConverter.ConvertO(__workflow_bodyclientsFileNumber);
                    bodypropCount++;
                }

                var transactionProductTypeObject = new JObject();
                var transactionProductTypeObjectpropCount = 0;
                if (__workflow_bodytransactionProductTypetransactionTypeId != null)
                {
                    transactionProductTypeObject["TransactionTypeID"] = ExpressionConverter.ConvertO(__workflow_bodytransactionProductTypetransactionTypeId);
                    transactionProductTypeObjectpropCount++;
                }

                if (__workflow_bodytransactionProductTypeproductTypeId != null)
                {
                    transactionProductTypeObject["ProductTypeID"] = ExpressionConverter.ConvertO(__workflow_bodytransactionProductTypeproductTypeId);
                    transactionProductTypeObjectpropCount++;
                }

                if (transactionProductTypeObjectpropCount > 0)
                {
                    body["TransactionProductType"] = transactionProductTypeObject;
                    bodypropCount++;
                }

                if (__workflow_bodystatuses != null)
                {
                    body["Statuses"] = ExpressionConverter.ConvertO(__workflow_bodystatuses);
                    bodypropCount++;
                }

                if (__workflow_bodypolicyNumber != null)
                {
                    body["PolicyNumber"] = ExpressionConverter.ConvertO(__workflow_bodypolicyNumber);
                    bodypropCount++;
                }

                if (__workflow_bodysearchNumber != null)
                {
                    body["SearchNumber"] = ExpressionConverter.ConvertO(__workflow_bodysearchNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyloanNumber != null)
                {
                    body["LoanNumber"] = ExpressionConverter.ConvertO(__workflow_bodyloanNumber);
                    bodypropCount++;
                }

                var propertyObject = new JObject();
                var propertyObjectpropCount = 0;
                if (__workflow_bodypropertyisPrimary != null)
                {
                    propertyObject["IsPrimary"] = ExpressionConverter.ConvertO(__workflow_bodypropertyisPrimary);
                    propertyObjectpropCount++;
                }

                if (__workflow_bodypropertystreetNumber != null)
                {
                    propertyObject["StreetNumber"] = ExpressionConverter.ConvertO(__workflow_bodypropertystreetNumber);
                    propertyObjectpropCount++;
                }

                if (__workflow_bodypropertystreetName != null)
                {
                    propertyObject["StreetName"] = ExpressionConverter.ConvertO(__workflow_bodypropertystreetName);
                    propertyObjectpropCount++;
                }

                if (__workflow_bodypropertycity != null)
                {
                    propertyObject["City"] = ExpressionConverter.ConvertO(__workflow_bodypropertycity);
                    propertyObjectpropCount++;
                }

                if (__workflow_bodypropertystate != null)
                {
                    propertyObject["State"] = ExpressionConverter.ConvertO(__workflow_bodypropertystate);
                    propertyObjectpropCount++;
                }

                if (__workflow_bodypropertyzip != null)
                {
                    propertyObject["Zip"] = ExpressionConverter.ConvertO(__workflow_bodypropertyzip);
                    propertyObjectpropCount++;
                }

                if (__workflow_bodypropertysubdivision != null)
                {
                    propertyObject["Subdivision"] = ExpressionConverter.ConvertO(__workflow_bodypropertysubdivision);
                    propertyObjectpropCount++;
                }

                if (__workflow_bodypropertyparcelId != null)
                {
                    propertyObject["ParcelID"] = ExpressionConverter.ConvertO(__workflow_bodypropertyparcelId);
                    propertyObjectpropCount++;
                }

                if (propertyObjectpropCount > 0)
                {
                    body["Property"] = propertyObject;
                    bodypropCount++;
                }

                var buyerObject = new JObject();
                var buyerObjectpropCount = 0;
                if (__workflow_bodybuyerentityType != null)
                {
                    buyerObject["EntityType"] = ExpressionConverter.ConvertO(__workflow_bodybuyerentityType);
                    buyerObjectpropCount++;
                }

                var primaryObject = new JObject();
                var primaryObjectpropCount = 0;
                if (__workflow_bodybuyerprimaryfirst != null)
                {
                    primaryObject["First"] = ExpressionConverter.ConvertO(__workflow_bodybuyerprimaryfirst);
                    primaryObjectpropCount++;
                }

                if (__workflow_bodybuyerprimarylast != null)
                {
                    primaryObject["Last"] = ExpressionConverter.ConvertO(__workflow_bodybuyerprimarylast);
                    primaryObjectpropCount++;
                }

                if (primaryObjectpropCount > 0)
                {
                    buyerObject["Primary"] = primaryObject;
                    buyerObjectpropCount++;
                }

                if (__workflow_bodybuyerusePropertyAddress != null)
                {
                    buyerObject["UsePropertyAddress"] = ExpressionConverter.ConvertO(__workflow_bodybuyerusePropertyAddress);
                    buyerObjectpropCount++;
                }

                if (__workflow_bodybuyermaritalStatus != null)
                {
                    buyerObject["MaritalStatus"] = ExpressionConverter.ConvertO(__workflow_bodybuyermaritalStatus);
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
                if (__workflow_bodyfilePartnerprimaryEmployeeuserId != null)
                {
                    primaryEmployeeObject["UserID"] = ExpressionConverter.ConvertO(__workflow_bodyfilePartnerprimaryEmployeeuserId);
                    primaryEmployeeObjectpropCount++;
                }

                if (primaryEmployeeObjectpropCount > 0)
                {
                    filePartnerObject["PrimaryEmployee"] = primaryEmployeeObject;
                    filePartnerObjectpropCount++;
                }

                if (__workflow_bodyfilePartnerpartnerTypeId != null)
                {
                    filePartnerObject["PartnerTypeID"] = ExpressionConverter.ConvertO(__workflow_bodyfilePartnerpartnerTypeId);
                    filePartnerObjectpropCount++;
                }

                if (__workflow_bodyfilePartnerpartnerId != null)
                {
                    filePartnerObject["PartnerID"] = ExpressionConverter.ConvertO(__workflow_bodyfilePartnerpartnerId);
                    filePartnerObjectpropCount++;
                }

                var partnerTypeObject = new JObject();
                var partnerTypeObjectpropCount = 0;
                if (__workflow_bodyfilePartnerpartnerTypepartnerTypeId != null)
                {
                    partnerTypeObject["PartnerTypeID"] = ExpressionConverter.ConvertO(__workflow_bodyfilePartnerpartnerTypepartnerTypeId);
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

                if (__workflow_bodyopenedFromDate != null)
                {
                    body["OpenedFromDate"] = ExpressionConverter.ConvertO(__workflow_bodyopenedFromDate);
                    bodypropCount++;
                }

                if (__workflow_bodyopenedToDate != null)
                {
                    body["OpenedToDate"] = ExpressionConverter.ConvertO(__workflow_bodyopenedToDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DeletePartnerOnSpecificFile(Expression<Func<string>> fileId, Expression<Func<bodypartnersInputItem[]>> bodypartners = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_bodypartners = WorkflowExpression.Compile(bodypartners, nameof(bodypartners), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DeletePartnerOnSpecificFile";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypartners != null)
                {
                    body["Partners"] = ExpressionConverter.ConvertO(__workflow_bodypartners);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetPartnerInformationResponse, ApiConnectionActionConfiguration> GetPartnerInformation(Expression<Func<string>> partnerCompanyId)
        {
            var __workflow_partnerCompanyId = WorkflowExpression.Compile(partnerCompanyId, nameof(partnerCompanyId), required: true);
            return new DeferredBodyAction<GetPartnerInformationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetPartnerInformation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["PartnerCompanyID"] = ExpressionConverter.Convert(__workflow_partnerCompanyId);
                return new ApiConnectionAction<GetPartnerInformationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CancelsPreviouslyPlacedOrder(Expression<Func<string>> fileId, Expression<Func<int>> bodyfileId = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_bodyfileId = WorkflowExpression.Compile(bodyfileId, nameof(bodyfileId), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CancelsPreviouslyPlacedOrder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfileId != null)
                {
                    body["FileID"] = ExpressionConverter.ConvertO(__workflow_bodyfileId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<CreateNewDocumentOnSpecificFileResponse, ApiConnectionActionConfiguration> CreateNewDocumentOnSpecificFile(Expression<Func<string>> fileId, Expression<Func<string>> bodydocumentName = null, Expression<Func<int>> bodydocumentTypedocumentTypeId = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyinternalOnly = null, Expression<Func<string>> bodydocumentBody = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_bodydocumentName = WorkflowExpression.Compile(bodydocumentName, nameof(bodydocumentName), required: false);
            var __workflow_bodydocumentTypedocumentTypeId = WorkflowExpression.Compile(bodydocumentTypedocumentTypeId, nameof(bodydocumentTypedocumentTypeId), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyinternalOnly = WorkflowExpression.Compile(bodyinternalOnly, nameof(bodyinternalOnly), required: false);
            var __workflow_bodydocumentBody = WorkflowExpression.Compile(bodydocumentBody, nameof(bodydocumentBody), required: false);
            return new DeferredBodyAction<CreateNewDocumentOnSpecificFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CreateNewDocumentOnSpecificFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydocumentName != null)
                {
                    body["DocumentName"] = ExpressionConverter.ConvertO(__workflow_bodydocumentName);
                    bodypropCount++;
                }

                var documentTypeObject = new JObject();
                var documentTypeObjectpropCount = 0;
                if (__workflow_bodydocumentTypedocumentTypeId != null)
                {
                    documentTypeObject["DocumentTypeID"] = ExpressionConverter.ConvertO(__workflow_bodydocumentTypedocumentTypeId);
                    documentTypeObjectpropCount++;
                }

                if (documentTypeObjectpropCount > 0)
                {
                    body["DocumentType"] = documentTypeObject;
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyinternalOnly != null)
                {
                    body["InternalOnly"] = ExpressionConverter.ConvertO(__workflow_bodyinternalOnly);
                    bodypropCount++;
                }

                if (__workflow_bodydocumentBody != null)
                {
                    body["DocumentBody"] = ExpressionConverter.ConvertO(__workflow_bodydocumentBody);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateNewDocumentOnSpecificFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DeletePreviouslyPlacedOrder(Expression<Func<string>> fileId, Expression<Func<int>> bodyfileId = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_bodyfileId = WorkflowExpression.Compile(bodyfileId, nameof(bodyfileId), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DeletePreviouslyPlacedOrder";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfileId != null)
                {
                    body["FileID"] = ExpressionConverter.ConvertO(__workflow_bodyfileId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> AddOrUpdateCustomFieldOnSpecificFile(Expression<Func<string>> fileId, Expression<Func<bodycustomFieldsInputItem[]>> bodycustomFields = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_bodycustomFields = WorkflowExpression.Compile(bodycustomFields, nameof(bodycustomFields), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AddOrUpdateCustomFieldOnSpecificFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycustomFields != null)
                {
                    body["CustomFields"] = ExpressionConverter.ConvertO(__workflow_bodycustomFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> AddPartnerToSpecificFile(Expression<Func<string>> fileId, Expression<Func<bodypartnersInputItem2[]>> bodypartners = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_bodypartners = WorkflowExpression.Compile(bodypartners, nameof(bodypartners), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AddPartnerToSpecificFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypartners != null)
                {
                    body["Partners"] = ExpressionConverter.ConvertO(__workflow_bodypartners);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<UpdatePartnerInformationForSpecificFileResponse, ApiConnectionActionConfiguration> UpdatePartnerInformationForSpecificFile(Expression<Func<string>> fileId, Expression<Func<string>> partnerId, Expression<Func<int>> bodyfileId = null, Expression<Func<int>> bodyprimaryEmployeeuserId = null, Expression<Func<string>> bodyprimaryEmployeename = null, Expression<Func<string>> bodyprimaryEmployeefirstName = null, Expression<Func<string>> bodyprimaryEmployeelastName = null, Expression<Func<string>> bodyprimaryEmployeecontactInformationphoneNumber = null, Expression<Func<string>> bodyprimaryEmployeecontactInformationhomePhoneNumber = null, Expression<Func<string>> bodyprimaryEmployeecontactInformationcellPhoneNumber = null, Expression<Func<string>> bodyprimaryEmployeecontactInformationvoicemail = null, Expression<Func<string>> bodyprimaryEmployeecontactInformationfaxNumber = null, Expression<Func<string>> bodyprimaryEmployeecontactInformationemailAddress = null, Expression<Func<string>> bodyprimaryEmployeecontactInformationpreferredCommunicationMethod = null, Expression<Func<string>> bodyprimaryEmployeecontactInformationwebsite = null, Expression<Func<bodysecondaryEmployeesInputItem[]>> bodysecondaryEmployees = null, Expression<Func<string>> bodyreferenceNumber = null, Expression<Func<string>> bodyremoteFileNumber = null, Expression<Func<int>> bodypartnerTypeId = null, Expression<Func<int>> bodypartnerId = null, Expression<Func<int>> bodypartnerTypepartnerTypeId = null, Expression<Func<string>> bodypartnerTypepartnerTypeName = null, Expression<Func<int>> bodyofficeId = null, Expression<Func<string>> bodypartnerName = null, Expression<Func<string>> bodymailingAddressaddress1 = null, Expression<Func<string>> bodymailingAddressaddress2 = null, Expression<Func<string>> bodymailingAddresscity = null, Expression<Func<string>> bodymailingAddressstate = null, Expression<Func<string>> bodymailingAddresszip = null, Expression<Func<string>> bodycontactInformationphoneNumber = null, Expression<Func<string>> bodycontactInformationhomePhoneNumber = null, Expression<Func<string>> bodycontactInformationcellPhoneNumber = null, Expression<Func<string>> bodycontactInformationvoicemail = null, Expression<Func<string>> bodycontactInformationfaxNumber = null, Expression<Func<string>> bodycontactInformationemailAddress = null, Expression<Func<string>> bodycontactInformationpreferredCommunicationMethod = null, Expression<Func<string>> bodycontactInformationwebsite = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_partnerId = WorkflowExpression.Compile(partnerId, nameof(partnerId), required: true);
            var __workflow_bodyfileId = WorkflowExpression.Compile(bodyfileId, nameof(bodyfileId), required: false);
            var __workflow_bodyprimaryEmployeeuserId = WorkflowExpression.Compile(bodyprimaryEmployeeuserId, nameof(bodyprimaryEmployeeuserId), required: false);
            var __workflow_bodyprimaryEmployeename = WorkflowExpression.Compile(bodyprimaryEmployeename, nameof(bodyprimaryEmployeename), required: false);
            var __workflow_bodyprimaryEmployeefirstName = WorkflowExpression.Compile(bodyprimaryEmployeefirstName, nameof(bodyprimaryEmployeefirstName), required: false);
            var __workflow_bodyprimaryEmployeelastName = WorkflowExpression.Compile(bodyprimaryEmployeelastName, nameof(bodyprimaryEmployeelastName), required: false);
            var __workflow_bodyprimaryEmployeecontactInformationphoneNumber = WorkflowExpression.Compile(bodyprimaryEmployeecontactInformationphoneNumber, nameof(bodyprimaryEmployeecontactInformationphoneNumber), required: false);
            var __workflow_bodyprimaryEmployeecontactInformationhomePhoneNumber = WorkflowExpression.Compile(bodyprimaryEmployeecontactInformationhomePhoneNumber, nameof(bodyprimaryEmployeecontactInformationhomePhoneNumber), required: false);
            var __workflow_bodyprimaryEmployeecontactInformationcellPhoneNumber = WorkflowExpression.Compile(bodyprimaryEmployeecontactInformationcellPhoneNumber, nameof(bodyprimaryEmployeecontactInformationcellPhoneNumber), required: false);
            var __workflow_bodyprimaryEmployeecontactInformationvoicemail = WorkflowExpression.Compile(bodyprimaryEmployeecontactInformationvoicemail, nameof(bodyprimaryEmployeecontactInformationvoicemail), required: false);
            var __workflow_bodyprimaryEmployeecontactInformationfaxNumber = WorkflowExpression.Compile(bodyprimaryEmployeecontactInformationfaxNumber, nameof(bodyprimaryEmployeecontactInformationfaxNumber), required: false);
            var __workflow_bodyprimaryEmployeecontactInformationemailAddress = WorkflowExpression.Compile(bodyprimaryEmployeecontactInformationemailAddress, nameof(bodyprimaryEmployeecontactInformationemailAddress), required: false);
            var __workflow_bodyprimaryEmployeecontactInformationpreferredCommunicationMethod = WorkflowExpression.Compile(bodyprimaryEmployeecontactInformationpreferredCommunicationMethod, nameof(bodyprimaryEmployeecontactInformationpreferredCommunicationMethod), required: false);
            var __workflow_bodyprimaryEmployeecontactInformationwebsite = WorkflowExpression.Compile(bodyprimaryEmployeecontactInformationwebsite, nameof(bodyprimaryEmployeecontactInformationwebsite), required: false);
            var __workflow_bodysecondaryEmployees = WorkflowExpression.Compile(bodysecondaryEmployees, nameof(bodysecondaryEmployees), required: false);
            var __workflow_bodyreferenceNumber = WorkflowExpression.Compile(bodyreferenceNumber, nameof(bodyreferenceNumber), required: false);
            var __workflow_bodyremoteFileNumber = WorkflowExpression.Compile(bodyremoteFileNumber, nameof(bodyremoteFileNumber), required: false);
            var __workflow_bodypartnerTypeId = WorkflowExpression.Compile(bodypartnerTypeId, nameof(bodypartnerTypeId), required: false);
            var __workflow_bodypartnerId = WorkflowExpression.Compile(bodypartnerId, nameof(bodypartnerId), required: false);
            var __workflow_bodypartnerTypepartnerTypeId = WorkflowExpression.Compile(bodypartnerTypepartnerTypeId, nameof(bodypartnerTypepartnerTypeId), required: false);
            var __workflow_bodypartnerTypepartnerTypeName = WorkflowExpression.Compile(bodypartnerTypepartnerTypeName, nameof(bodypartnerTypepartnerTypeName), required: false);
            var __workflow_bodyofficeId = WorkflowExpression.Compile(bodyofficeId, nameof(bodyofficeId), required: false);
            var __workflow_bodypartnerName = WorkflowExpression.Compile(bodypartnerName, nameof(bodypartnerName), required: false);
            var __workflow_bodymailingAddressaddress1 = WorkflowExpression.Compile(bodymailingAddressaddress1, nameof(bodymailingAddressaddress1), required: false);
            var __workflow_bodymailingAddressaddress2 = WorkflowExpression.Compile(bodymailingAddressaddress2, nameof(bodymailingAddressaddress2), required: false);
            var __workflow_bodymailingAddresscity = WorkflowExpression.Compile(bodymailingAddresscity, nameof(bodymailingAddresscity), required: false);
            var __workflow_bodymailingAddressstate = WorkflowExpression.Compile(bodymailingAddressstate, nameof(bodymailingAddressstate), required: false);
            var __workflow_bodymailingAddresszip = WorkflowExpression.Compile(bodymailingAddresszip, nameof(bodymailingAddresszip), required: false);
            var __workflow_bodycontactInformationphoneNumber = WorkflowExpression.Compile(bodycontactInformationphoneNumber, nameof(bodycontactInformationphoneNumber), required: false);
            var __workflow_bodycontactInformationhomePhoneNumber = WorkflowExpression.Compile(bodycontactInformationhomePhoneNumber, nameof(bodycontactInformationhomePhoneNumber), required: false);
            var __workflow_bodycontactInformationcellPhoneNumber = WorkflowExpression.Compile(bodycontactInformationcellPhoneNumber, nameof(bodycontactInformationcellPhoneNumber), required: false);
            var __workflow_bodycontactInformationvoicemail = WorkflowExpression.Compile(bodycontactInformationvoicemail, nameof(bodycontactInformationvoicemail), required: false);
            var __workflow_bodycontactInformationfaxNumber = WorkflowExpression.Compile(bodycontactInformationfaxNumber, nameof(bodycontactInformationfaxNumber), required: false);
            var __workflow_bodycontactInformationemailAddress = WorkflowExpression.Compile(bodycontactInformationemailAddress, nameof(bodycontactInformationemailAddress), required: false);
            var __workflow_bodycontactInformationpreferredCommunicationMethod = WorkflowExpression.Compile(bodycontactInformationpreferredCommunicationMethod, nameof(bodycontactInformationpreferredCommunicationMethod), required: false);
            var __workflow_bodycontactInformationwebsite = WorkflowExpression.Compile(bodycontactInformationwebsite, nameof(bodycontactInformationwebsite), required: false);
            return new DeferredBodyAction<UpdatePartnerInformationForSpecificFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UpdatePartnerInformationForSpecificFile";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                callPayload.Queries["PartnerID"] = ExpressionConverter.Convert(__workflow_partnerId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfileId != null)
                {
                    body["FileID"] = ExpressionConverter.ConvertO(__workflow_bodyfileId);
                    bodypropCount++;
                }

                var primaryEmployeeObject = new JObject();
                var primaryEmployeeObjectpropCount = 0;
                if (__workflow_bodyprimaryEmployeeuserId != null)
                {
                    primaryEmployeeObject["UserID"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryEmployeeuserId);
                    primaryEmployeeObjectpropCount++;
                }

                if (__workflow_bodyprimaryEmployeename != null)
                {
                    primaryEmployeeObject["Name"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryEmployeename);
                    primaryEmployeeObjectpropCount++;
                }

                if (__workflow_bodyprimaryEmployeefirstName != null)
                {
                    primaryEmployeeObject["FirstName"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryEmployeefirstName);
                    primaryEmployeeObjectpropCount++;
                }

                if (__workflow_bodyprimaryEmployeelastName != null)
                {
                    primaryEmployeeObject["LastName"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryEmployeelastName);
                    primaryEmployeeObjectpropCount++;
                }

                var contactInformationObject = new JObject();
                var contactInformationObjectpropCount = 0;
                if (__workflow_bodyprimaryEmployeecontactInformationphoneNumber != null)
                {
                    contactInformationObject["PhoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryEmployeecontactInformationphoneNumber);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodyprimaryEmployeecontactInformationhomePhoneNumber != null)
                {
                    contactInformationObject["HomePhoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryEmployeecontactInformationhomePhoneNumber);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodyprimaryEmployeecontactInformationcellPhoneNumber != null)
                {
                    contactInformationObject["CellPhoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryEmployeecontactInformationcellPhoneNumber);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodyprimaryEmployeecontactInformationvoicemail != null)
                {
                    contactInformationObject["Voicemail"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryEmployeecontactInformationvoicemail);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodyprimaryEmployeecontactInformationfaxNumber != null)
                {
                    contactInformationObject["FaxNumber"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryEmployeecontactInformationfaxNumber);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodyprimaryEmployeecontactInformationemailAddress != null)
                {
                    contactInformationObject["EmailAddress"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryEmployeecontactInformationemailAddress);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodyprimaryEmployeecontactInformationpreferredCommunicationMethod != null)
                {
                    contactInformationObject["PreferredCommunicationMethod"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryEmployeecontactInformationpreferredCommunicationMethod);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodyprimaryEmployeecontactInformationwebsite != null)
                {
                    contactInformationObject["Website"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryEmployeecontactInformationwebsite);
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

                if (__workflow_bodysecondaryEmployees != null)
                {
                    body["SecondaryEmployees"] = ExpressionConverter.ConvertO(__workflow_bodysecondaryEmployees);
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceNumber != null)
                {
                    body["ReferenceNumber"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyremoteFileNumber != null)
                {
                    body["RemoteFileNumber"] = ExpressionConverter.ConvertO(__workflow_bodyremoteFileNumber);
                    bodypropCount++;
                }

                if (__workflow_bodypartnerTypeId != null)
                {
                    body["PartnerTypeID"] = ExpressionConverter.ConvertO(__workflow_bodypartnerTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodypartnerId != null)
                {
                    body["PartnerID"] = ExpressionConverter.ConvertO(__workflow_bodypartnerId);
                    bodypropCount++;
                }

                var partnerTypeObject = new JObject();
                var partnerTypeObjectpropCount = 0;
                if (__workflow_bodypartnerTypepartnerTypeId != null)
                {
                    partnerTypeObject["PartnerTypeID"] = ExpressionConverter.ConvertO(__workflow_bodypartnerTypepartnerTypeId);
                    partnerTypeObjectpropCount++;
                }

                if (__workflow_bodypartnerTypepartnerTypeName != null)
                {
                    partnerTypeObject["PartnerTypeName"] = ExpressionConverter.ConvertO(__workflow_bodypartnerTypepartnerTypeName);
                    partnerTypeObjectpropCount++;
                }

                if (partnerTypeObjectpropCount > 0)
                {
                    body["PartnerType"] = partnerTypeObject;
                    bodypropCount++;
                }

                if (__workflow_bodyofficeId != null)
                {
                    body["OfficeID"] = ExpressionConverter.ConvertO(__workflow_bodyofficeId);
                    bodypropCount++;
                }

                if (__workflow_bodypartnerName != null)
                {
                    body["PartnerName"] = ExpressionConverter.ConvertO(__workflow_bodypartnerName);
                    bodypropCount++;
                }

                var mailingAddressObject = new JObject();
                var mailingAddressObjectpropCount = 0;
                if (__workflow_bodymailingAddressaddress1 != null)
                {
                    mailingAddressObject["Address1"] = ExpressionConverter.ConvertO(__workflow_bodymailingAddressaddress1);
                    mailingAddressObjectpropCount++;
                }

                if (__workflow_bodymailingAddressaddress2 != null)
                {
                    mailingAddressObject["Address2"] = ExpressionConverter.ConvertO(__workflow_bodymailingAddressaddress2);
                    mailingAddressObjectpropCount++;
                }

                if (__workflow_bodymailingAddresscity != null)
                {
                    mailingAddressObject["City"] = ExpressionConverter.ConvertO(__workflow_bodymailingAddresscity);
                    mailingAddressObjectpropCount++;
                }

                if (__workflow_bodymailingAddressstate != null)
                {
                    mailingAddressObject["State"] = ExpressionConverter.ConvertO(__workflow_bodymailingAddressstate);
                    mailingAddressObjectpropCount++;
                }

                if (__workflow_bodymailingAddresszip != null)
                {
                    mailingAddressObject["Zip"] = ExpressionConverter.ConvertO(__workflow_bodymailingAddresszip);
                    mailingAddressObjectpropCount++;
                }

                if (mailingAddressObjectpropCount > 0)
                {
                    body["MailingAddress"] = mailingAddressObject;
                    bodypropCount++;
                }

                var contactInformationObject2 = new JObject();
                var contactInformationObject2propCount = 0;
                if (__workflow_bodycontactInformationphoneNumber != null)
                {
                    contactInformationObject2["PhoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationphoneNumber);
                    contactInformationObject2propCount++;
                }

                if (__workflow_bodycontactInformationhomePhoneNumber != null)
                {
                    contactInformationObject2["HomePhoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationhomePhoneNumber);
                    contactInformationObject2propCount++;
                }

                if (__workflow_bodycontactInformationcellPhoneNumber != null)
                {
                    contactInformationObject2["CellPhoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationcellPhoneNumber);
                    contactInformationObject2propCount++;
                }

                if (__workflow_bodycontactInformationvoicemail != null)
                {
                    contactInformationObject2["Voicemail"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationvoicemail);
                    contactInformationObject2propCount++;
                }

                if (__workflow_bodycontactInformationfaxNumber != null)
                {
                    contactInformationObject2["FaxNumber"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationfaxNumber);
                    contactInformationObject2propCount++;
                }

                if (__workflow_bodycontactInformationemailAddress != null)
                {
                    contactInformationObject2["EmailAddress"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationemailAddress);
                    contactInformationObject2propCount++;
                }

                if (__workflow_bodycontactInformationpreferredCommunicationMethod != null)
                {
                    contactInformationObject2["PreferredCommunicationMethod"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationpreferredCommunicationMethod);
                    contactInformationObject2propCount++;
                }

                if (__workflow_bodycontactInformationwebsite != null)
                {
                    contactInformationObject2["Website"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationwebsite);
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

                return new ApiConnectionAction<UpdatePartnerInformationForSpecificFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<AddNoteToFileResponse, ApiConnectionActionConfiguration> AddNoteToFile(Expression<Func<string>> fileId, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodybody = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodybody = WorkflowExpression.Compile(bodybody, nameof(bodybody), required: false);
            return new DeferredBodyAction<AddNoteToFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AddNoteToFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysubject != null)
                {
                    body["Subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodybody != null)
                {
                    body["Body"] = ExpressionConverter.ConvertO(__workflow_bodybody);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddNoteToFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetPartnersForSpecificFileResponse, ApiConnectionActionConfiguration> GetPartnersForSpecificFile(Expression<Func<string>> fileId)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<GetPartnersForSpecificFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetPartnersForSpecificFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                return new ApiConnectionAction<GetPartnersForSpecificFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<UploadWebURLDocumentToSpecificFileResponse, ApiConnectionActionConfiguration> UploadWebURLDocumentToSpecificFile(Expression<Func<string>> fileId, Expression<Func<string>> bodydocumentName = null, Expression<Func<int>> bodydocumentTypedocumentTypeId = null, Expression<Func<string>> bodydescription = null, Expression<Func<bool>> bodyinternalOnly = null, Expression<Func<string>> bodywebURL = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_bodydocumentName = WorkflowExpression.Compile(bodydocumentName, nameof(bodydocumentName), required: false);
            var __workflow_bodydocumentTypedocumentTypeId = WorkflowExpression.Compile(bodydocumentTypedocumentTypeId, nameof(bodydocumentTypedocumentTypeId), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyinternalOnly = WorkflowExpression.Compile(bodyinternalOnly, nameof(bodyinternalOnly), required: false);
            var __workflow_bodywebURL = WorkflowExpression.Compile(bodywebURL, nameof(bodywebURL), required: false);
            return new DeferredBodyAction<UploadWebURLDocumentToSpecificFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UploadWebUrlDocumentToSpecificFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydocumentName != null)
                {
                    body["DocumentName"] = ExpressionConverter.ConvertO(__workflow_bodydocumentName);
                    bodypropCount++;
                }

                var documentTypeObject = new JObject();
                var documentTypeObjectpropCount = 0;
                if (__workflow_bodydocumentTypedocumentTypeId != null)
                {
                    documentTypeObject["DocumentTypeID"] = ExpressionConverter.ConvertO(__workflow_bodydocumentTypedocumentTypeId);
                    documentTypeObjectpropCount++;
                }

                if (documentTypeObjectpropCount > 0)
                {
                    body["DocumentType"] = documentTypeObject;
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyinternalOnly != null)
                {
                    body["InternalOnly"] = ExpressionConverter.ConvertO(__workflow_bodyinternalOnly);
                    bodypropCount++;
                }

                if (__workflow_bodywebURL != null)
                {
                    body["WebURL"] = ExpressionConverter.ConvertO(__workflow_bodywebURL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UploadWebURLDocumentToSpecificFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> AddOrUpdateCustomFieldOnSpecificDocument(Expression<Func<string>> fileId, Expression<Func<string>> documentId, Expression<Func<bodycustomFieldsInputItem[]>> bodycustomFields = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_bodycustomFields = WorkflowExpression.Compile(bodycustomFields, nameof(bodycustomFields), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AddOrUpdateCustomFieldOnSpecificDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                callPayload.Queries["DocumentID"] = ExpressionConverter.Convert(__workflow_documentId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycustomFields != null)
                {
                    body["CustomFields"] = ExpressionConverter.ConvertO(__workflow_bodycustomFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<UpdatePartnerEmployeeResponse, ApiConnectionActionConfiguration> UpdatePartnerEmployee(Expression<Func<string>> userId, Expression<Func<string>> partnerCompanyId, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodypasswordExpirationDate = null, Expression<Func<bodyrolesInputItem[]>> bodyroles = null, Expression<Func<bool>> bodyenabled = null, Expression<Func<bool>> bodywebsiteAccess = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodycontactInformationemailAddress = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_partnerCompanyId = WorkflowExpression.Compile(partnerCompanyId, nameof(partnerCompanyId), required: true);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodypasswordExpirationDate = WorkflowExpression.Compile(bodypasswordExpirationDate, nameof(bodypasswordExpirationDate), required: false);
            var __workflow_bodyroles = WorkflowExpression.Compile(bodyroles, nameof(bodyroles), required: false);
            var __workflow_bodyenabled = WorkflowExpression.Compile(bodyenabled, nameof(bodyenabled), required: false);
            var __workflow_bodywebsiteAccess = WorkflowExpression.Compile(bodywebsiteAccess, nameof(bodywebsiteAccess), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodycontactInformationemailAddress = WorkflowExpression.Compile(bodycontactInformationemailAddress, nameof(bodycontactInformationemailAddress), required: false);
            return new DeferredBodyAction<UpdatePartnerEmployeeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UpdatePartnerEmployee";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["UserID"] = ExpressionConverter.Convert(__workflow_userId);
                callPayload.Queries["PartnerCompanyID"] = ExpressionConverter.Convert(__workflow_partnerCompanyId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypassword != null)
                {
                    body["Password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodypasswordExpirationDate != null)
                {
                    body["PasswordExpirationDate"] = ExpressionConverter.ConvertO(__workflow_bodypasswordExpirationDate);
                    bodypropCount++;
                }

                if (__workflow_bodyroles != null)
                {
                    body["Roles"] = ExpressionConverter.ConvertO(__workflow_bodyroles);
                    bodypropCount++;
                }

                if (__workflow_bodyenabled != null)
                {
                    body["Enabled"] = ExpressionConverter.ConvertO(__workflow_bodyenabled);
                    bodypropCount++;
                }

                if (__workflow_bodywebsiteAccess != null)
                {
                    body["WebsiteAccess"] = ExpressionConverter.ConvertO(__workflow_bodywebsiteAccess);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["FirstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["LastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                var contactInformationObject = new JObject();
                var contactInformationObjectpropCount = 0;
                if (__workflow_bodycontactInformationemailAddress != null)
                {
                    contactInformationObject["EmailAddress"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationemailAddress);
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

                return new ApiConnectionAction<UpdatePartnerEmployeeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetPartiesForSpecificFileResponse, ApiConnectionActionConfiguration> GetPartiesForSpecificFile(Expression<Func<string>> fileId)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<GetPartiesForSpecificFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetPartiesForSpecificFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                return new ApiConnectionAction<GetPartiesForSpecificFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetNotesForSpecificFileResponse, ApiConnectionActionConfiguration> GetNotesForSpecificFile(Expression<Func<string>> fileId)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<GetNotesForSpecificFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetNotesForSpecificFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                return new ApiConnectionAction<GetNotesForSpecificFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetNoteResponse, ApiConnectionActionConfiguration> GetNote(Expression<Func<string>> noteId)
        {
            var __workflow_noteId = WorkflowExpression.Compile(noteId, nameof(noteId), required: true);
            return new DeferredBodyAction<GetNoteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetNote";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["NoteID"] = ExpressionConverter.Convert(__workflow_noteId);
                return new ApiConnectionAction<GetNoteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<AddActionToFileResponse, ApiConnectionActionConfiguration> AddActionToFile(Expression<Func<string>> fileId, Expression<Func<int>> bodyactionTypeactionTypeId = null, Expression<Func<int>> bodygroupactionGroupId = null, Expression<Func<int>> bodystartTaskcoordinatorTypeId = null, Expression<Func<string>> bodystartTaskdueDate = null, Expression<Func<int>> bodycompleteTaskpartnerpartnerTypepartnerTypeId = null, Expression<Func<string>> bodycompleteTaskdueDate = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_bodyactionTypeactionTypeId = WorkflowExpression.Compile(bodyactionTypeactionTypeId, nameof(bodyactionTypeactionTypeId), required: false);
            var __workflow_bodygroupactionGroupId = WorkflowExpression.Compile(bodygroupactionGroupId, nameof(bodygroupactionGroupId), required: false);
            var __workflow_bodystartTaskcoordinatorTypeId = WorkflowExpression.Compile(bodystartTaskcoordinatorTypeId, nameof(bodystartTaskcoordinatorTypeId), required: false);
            var __workflow_bodystartTaskdueDate = WorkflowExpression.Compile(bodystartTaskdueDate, nameof(bodystartTaskdueDate), required: false);
            var __workflow_bodycompleteTaskpartnerpartnerTypepartnerTypeId = WorkflowExpression.Compile(bodycompleteTaskpartnerpartnerTypepartnerTypeId, nameof(bodycompleteTaskpartnerpartnerTypepartnerTypeId), required: false);
            var __workflow_bodycompleteTaskdueDate = WorkflowExpression.Compile(bodycompleteTaskdueDate, nameof(bodycompleteTaskdueDate), required: false);
            return new DeferredBodyAction<AddActionToFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AddActionToFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                var body = new JObject();
                var bodypropCount = 0;
                var actionTypeObject = new JObject();
                var actionTypeObjectpropCount = 0;
                if (__workflow_bodyactionTypeactionTypeId != null)
                {
                    actionTypeObject["ActionTypeID"] = ExpressionConverter.ConvertO(__workflow_bodyactionTypeactionTypeId);
                    actionTypeObjectpropCount++;
                }

                if (actionTypeObjectpropCount > 0)
                {
                    body["ActionType"] = actionTypeObject;
                    bodypropCount++;
                }

                var groupObject = new JObject();
                var groupObjectpropCount = 0;
                if (__workflow_bodygroupactionGroupId != null)
                {
                    groupObject["ActionGroupID"] = ExpressionConverter.ConvertO(__workflow_bodygroupactionGroupId);
                    groupObjectpropCount++;
                }

                if (groupObjectpropCount > 0)
                {
                    body["Group"] = groupObject;
                    bodypropCount++;
                }

                var startTaskObject = new JObject();
                var startTaskObjectpropCount = 0;
                if (__workflow_bodystartTaskcoordinatorTypeId != null)
                {
                    startTaskObject["CoordinatorTypeID"] = ExpressionConverter.ConvertO(__workflow_bodystartTaskcoordinatorTypeId);
                    startTaskObjectpropCount++;
                }

                if (__workflow_bodystartTaskdueDate != null)
                {
                    startTaskObject["DueDate"] = ExpressionConverter.ConvertO(__workflow_bodystartTaskdueDate);
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
                if (__workflow_bodycompleteTaskpartnerpartnerTypepartnerTypeId != null)
                {
                    partnerTypeObject["PartnerTypeID"] = ExpressionConverter.ConvertO(__workflow_bodycompleteTaskpartnerpartnerTypepartnerTypeId);
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

                if (__workflow_bodycompleteTaskdueDate != null)
                {
                    completeTaskObject["DueDate"] = ExpressionConverter.ConvertO(__workflow_bodycompleteTaskdueDate);
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

                return new ApiConnectionAction<AddActionToFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetCustomFieldsOnSpecificDocumentResponse, ApiConnectionActionConfiguration> GetCustomFieldsOnSpecificDocument(Expression<Func<string>> fileId, Expression<Func<string>> documentId)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<GetCustomFieldsOnSpecificDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetCustomFieldsOnSpecificDocument";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                callPayload.Queries["DocumentID"] = ExpressionConverter.Convert(__workflow_documentId);
                return new ApiConnectionAction<GetCustomFieldsOnSpecificDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetDocumentsForSpecificFileResponse, ApiConnectionActionConfiguration> GetDocumentsForSpecificFile(Expression<Func<string>> fileId)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<GetDocumentsForSpecificFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetDocumentsForSpecificFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                return new ApiConnectionAction<GetDocumentsForSpecificFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetDocumentResponse, ApiConnectionActionConfiguration> GetDocument(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<GetDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetDocument";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["DocumentID"] = ExpressionConverter.Convert(__workflow_documentId);
                return new ApiConnectionAction<GetDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetCustomFieldsForSpecificFileResponse, ApiConnectionActionConfiguration> GetCustomFieldsForSpecificFile(Expression<Func<string>> fileId)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<GetCustomFieldsForSpecificFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetCustomFieldsForSpecificFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                return new ApiConnectionAction<GetCustomFieldsForSpecificFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetClosingFeeEstimateReceiptResponse, ApiConnectionActionConfiguration> GetClosingFeeEstimateReceipt(Expression<Func<string>> closingFeeId)
        {
            var __workflow_closingFeeId = WorkflowExpression.Compile(closingFeeId, nameof(closingFeeId), required: true);
            return new DeferredBodyAction<GetClosingFeeEstimateReceiptResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetClosingFeeEstimateReceipt";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ClosingFeeID"] = ExpressionConverter.Convert(__workflow_closingFeeId);
                return new ApiConnectionAction<GetClosingFeeEstimateReceiptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetClosingFeeEstimateReceiptPDF(Expression<Func<string>> closingFeeId)
        {
            var __workflow_closingFeeId = WorkflowExpression.Compile(closingFeeId, nameof(closingFeeId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetClosingFeeEstimateReceiptPDF";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ClosingFeeID"] = ExpressionConverter.Convert(__workflow_closingFeeId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetActionsForSpecificFileResponse, ApiConnectionActionConfiguration> GetActionsForSpecificFile(Expression<Func<string>> fileId)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<GetActionsForSpecificFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetActionsForSpecificFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileID"] = ExpressionConverter.Convert(__workflow_fileId);
                return new ApiConnectionAction<GetActionsForSpecificFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<GetCurrentUserInfoResponse, ApiConnectionActionConfiguration> GetCurrentUserInfo()
        {
            return new DeferredBodyAction<GetCurrentUserInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetCurrentUserInfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCurrentUserInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoquery")]
        public IBodyWorkflowAction<EstimateClosingFeeResponse, ApiConnectionActionConfiguration> EstimateClosingFee(Expression<Func<int>> bodytransactionProductTypetransactionTypeId = null, Expression<Func<int>> bodytransactionProductTypeproductTypeId = null, Expression<Func<string>> bodysettlementStatementVersion = null, Expression<Func<int>> bodysalesPrice = null, Expression<Func<bodyloansInputItem2[]>> bodyloans = null, Expression<Func<bodypropertiesInputItem[]>> bodyproperties = null, Expression<Func<bodyfilePartnersInputItem[]>> bodyfilePartners = null, Expression<Func<bodyendorsementsInputItem[]>> bodyendorsements = null)
        {
            var __workflow_bodytransactionProductTypetransactionTypeId = WorkflowExpression.Compile(bodytransactionProductTypetransactionTypeId, nameof(bodytransactionProductTypetransactionTypeId), required: false);
            var __workflow_bodytransactionProductTypeproductTypeId = WorkflowExpression.Compile(bodytransactionProductTypeproductTypeId, nameof(bodytransactionProductTypeproductTypeId), required: false);
            var __workflow_bodysettlementStatementVersion = WorkflowExpression.Compile(bodysettlementStatementVersion, nameof(bodysettlementStatementVersion), required: false);
            var __workflow_bodysalesPrice = WorkflowExpression.Compile(bodysalesPrice, nameof(bodysalesPrice), required: false);
            var __workflow_bodyloans = WorkflowExpression.Compile(bodyloans, nameof(bodyloans), required: false);
            var __workflow_bodyproperties = WorkflowExpression.Compile(bodyproperties, nameof(bodyproperties), required: false);
            var __workflow_bodyfilePartners = WorkflowExpression.Compile(bodyfilePartners, nameof(bodyfilePartners), required: false);
            var __workflow_bodyendorsements = WorkflowExpression.Compile(bodyendorsements, nameof(bodyendorsements), required: false);
            return new DeferredBodyAction<EstimateClosingFeeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EstimateClosingFee";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var transactionProductTypeObject = new JObject();
                var transactionProductTypeObjectpropCount = 0;
                if (__workflow_bodytransactionProductTypetransactionTypeId != null)
                {
                    transactionProductTypeObject["TransactionTypeID"] = ExpressionConverter.ConvertO(__workflow_bodytransactionProductTypetransactionTypeId);
                    transactionProductTypeObjectpropCount++;
                }

                if (__workflow_bodytransactionProductTypeproductTypeId != null)
                {
                    transactionProductTypeObject["ProductTypeID"] = ExpressionConverter.ConvertO(__workflow_bodytransactionProductTypeproductTypeId);
                    transactionProductTypeObjectpropCount++;
                }

                if (transactionProductTypeObjectpropCount > 0)
                {
                    body["TransactionProductType"] = transactionProductTypeObject;
                    bodypropCount++;
                }

                if (__workflow_bodysettlementStatementVersion != null)
                {
                    body["SettlementStatementVersion"] = ExpressionConverter.ConvertO(__workflow_bodysettlementStatementVersion);
                    bodypropCount++;
                }

                if (__workflow_bodysalesPrice != null)
                {
                    body["SalesPrice"] = ExpressionConverter.ConvertO(__workflow_bodysalesPrice);
                    bodypropCount++;
                }

                if (__workflow_bodyloans != null)
                {
                    body["Loans"] = ExpressionConverter.ConvertO(__workflow_bodyloans);
                    bodypropCount++;
                }

                if (__workflow_bodyproperties != null)
                {
                    body["Properties"] = ExpressionConverter.ConvertO(__workflow_bodyproperties);
                    bodypropCount++;
                }

                if (__workflow_bodyfilePartners != null)
                {
                    body["FilePartners"] = ExpressionConverter.ConvertO(__workflow_bodyfilePartners);
                    bodypropCount++;
                }

                if (__workflow_bodyendorsements != null)
                {
                    body["Endorsements"] = ExpressionConverter.ConvertO(__workflow_bodyendorsements);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EstimateClosingFeeResponse>(callPayload);
            });
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
        [JsonProperty("PartnerCompanyID")]
        public int PartnerCompanyId { get; set; }
        public bool Enabled { get; set; }
        public bool WebsiteAccess { get; set; }

        [JsonProperty("UserID")]
        public int UserId { get; set; }
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
        [JsonProperty("FileID")]
        public int FileId { get; set; }
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

        [JsonProperty("TransactionTypeID")]
        public int TransactionTypeId { get; set; }
        public string ProductType { get; set; }

        [JsonProperty("ProductTypeID")]
        public int ProductTypeId { get; set; }
        public GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItemAncillaryProductsTypeItem[] AncillaryProducts { get; set; }
        public GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItemAddOnProductsTypeItem[] AddOnProducts { get; set; }
    }

    public class GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItemAncillaryProductsTypeItem
    {
        public string Name { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }
        public GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItemAncillaryProductsTypeItemOptionsTypeItem[] Options { get; set; }
    }

    public class GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItemAncillaryProductsTypeItemOptionsTypeItem
    {
        [JsonProperty("ID")]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class GetTransactionAndProductTypesForEstimationAndOrderPlacementResponseItemAddOnProductsTypeItem
    {
        public string TransactionType { get; set; }

        [JsonProperty("TransactionTypeID")]
        public int TransactionTypeId { get; set; }
        public string ProductType { get; set; }

        [JsonProperty("ProductTypeID")]
        public int ProductTypeId { get; set; }
    }

    public class UpdateActionForFileResponse
    {
        [JsonProperty("FileActionID")]
        public int FileActionId { get; set; }
    }

    public class bodystatusesInputItem
    {
        [JsonProperty("StatusID")]
        public int StatusId { get; set; }
        public string Name { get; set; }
    }

    public class bodypartnersInputItem
    {
        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }

        [JsonProperty("PartnerID")]
        public int PartnerId { get; set; }
        public bodypartnersInputItemPartnerTypeType PartnerType { get; set; }
    }

    public class bodypartnersInputItemPartnerTypeType
    {
        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }
    }

    public class GetPartnerInformationResponse
    {
        [JsonProperty("PartnerCompanyID")]
        public int PartnerCompanyId { get; set; }
        public GetPartnerInformationResponsePartnerTypesTypeItem[] PartnerTypes { get; set; }

        [JsonProperty("OfficeID")]
        public int OfficeId { get; set; }
        public string PartnerName { get; set; }
        public string CompanyAbbreviation { get; set; }
        public string ProperCompanyName { get; set; }
        public GetPartnerInformationResponseMailingAddressType MailingAddress { get; set; }
        public GetPartnerInformationResponseContactInformationType ContactInformation { get; set; }
        public GetPartnerInformationResponseCompanyInformationType CompanyInformation { get; set; }
        public bool SendDocumentsAsWebLinks { get; set; }

        [JsonProperty("WireConfirmationEmailTemplateID")]
        public int WireConfirmationEmailTemplateId { get; set; }
        public GetPartnerInformationResponseCourierAddressType CourierAddress { get; set; }
    }

    public class GetPartnerInformationResponsePartnerTypesTypeItem
    {
        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }
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

        [JsonProperty("TaxID")]
        public string TaxId { get; set; }
        public string AccountingCode { get; set; }
        public string CommentsSpecialInstructions { get; set; }
        public bool DontAllowSelectionInSettlement { get; set; }
        public bool Needs1099 { get; set; }
        public bool MWBE { get; set; }
    }

    public class GetPartnerInformationResponseCompanyInformationTypeParentCompanyType
    {
        [JsonProperty("ID")]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class GetPartnerInformationResponseCompanyInformationTypePartnerEntityType
    {
        [JsonProperty("ID")]
        public int Id { get; set; }

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
        [JsonProperty("DocumentID")]
        public int DocumentId { get; set; }
    }

    public class bodypartnersInputItem2
    {
        public bodypartnersInputItemPrimaryEmployeeType PrimaryEmployee { get; set; }
        public bodypartnersInputItemSecondaryEmployeesTypeItem[] SecondaryEmployees { get; set; }

        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }

        [JsonProperty("PartnerID")]
        public int PartnerId { get; set; }
        public bodypartnersInputItemPartnerTypeType PartnerType { get; set; }
    }

    public class bodypartnersInputItemPrimaryEmployeeType
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }
    }

    public class bodypartnersInputItemSecondaryEmployeesTypeItem
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileResponse
    {
        [JsonProperty("FileID")]
        public int FileId { get; set; }
        public string FileNumber { get; set; }
        public UpdatePartnerInformationForSpecificFileResponsePrimaryEmployeeType PrimaryEmployee { get; set; }
        public UpdatePartnerInformationForSpecificFileResponseSecondaryEmployeesTypeItem[] SecondaryEmployees { get; set; }
        public string ReferenceNumber { get; set; }
        public string RemoteFileNumber { get; set; }

        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }

        [JsonProperty("PartnerID")]
        public int PartnerId { get; set; }
        public UpdatePartnerInformationForSpecificFileResponsePartnerTypeType PartnerType { get; set; }

        [JsonProperty("OfficeID")]
        public int OfficeId { get; set; }
        public string PartnerName { get; set; }
        public UpdatePartnerInformationForSpecificFileResponseMailingAddressType MailingAddress { get; set; }
        public UpdatePartnerInformationForSpecificFileResponseContactInformationType ContactInformation { get; set; }
    }

    public class UpdatePartnerInformationForSpecificFileResponsePrimaryEmployeeType
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }
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
        [JsonProperty("UserID")]
        public int UserId { get; set; }
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
        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }
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
        [JsonProperty("UserID")]
        public int UserId { get; set; }
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
        [JsonProperty("NoteID")]
        public int NoteId { get; set; }
    }

    public class GetPartnersForSpecificFileResponse
    {
        public GetPartnersForSpecificFileResponsePartnersTypeItem[] Partners { get; set; }
    }

    public class GetPartnersForSpecificFileResponsePartnersTypeItem
    {
        public GetPartnersForSpecificFileResponsePartnersTypeItemPrimaryEmployeeType PrimaryEmployee { get; set; }

        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }

        [JsonProperty("PartnerID")]
        public int PartnerId { get; set; }
        public GetPartnersForSpecificFileResponsePartnersTypeItemPartnerTypeType PartnerType { get; set; }
        public string PartnerName { get; set; }
    }

    public class GetPartnersForSpecificFileResponsePartnersTypeItemPrimaryEmployeeType
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }
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
        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }
        public string PartnerTypeName { get; set; }
    }

    public class UploadWebURLDocumentToSpecificFileResponse
    {
        public UploadWebURLDocumentToSpecificFileResponseDocumentType Document { get; set; }
    }

    public class UploadWebURLDocumentToSpecificFileResponseDocumentType
    {
        [JsonProperty("DocumentID")]
        public int DocumentId { get; set; }
    }

    public class UpdatePartnerEmployeeResponse
    {
        public UpdatePartnerEmployeeResponseEmployeeType Employee { get; set; }
    }

    public class UpdatePartnerEmployeeResponseEmployeeType
    {
        [JsonProperty("PartnerCompanyID")]
        public int PartnerCompanyId { get; set; }
        public UpdatePartnerEmployeeResponseEmployeeTypeRolesTypeItem[] Roles { get; set; }
        public bool Enabled { get; set; }
        public bool WebsiteAccess { get; set; }

        [JsonProperty("UserID")]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UpdatePartnerEmployeeResponseEmployeeTypeContactInformationType ContactInformation { get; set; }
    }

    public class UpdatePartnerEmployeeResponseEmployeeTypeRolesTypeItem
    {
        [JsonProperty("RoleID")]
        public int RoleId { get; set; }
        public string Name { get; set; }
    }

    public class UpdatePartnerEmployeeResponseEmployeeTypeContactInformationType
    {
        public string EmailAddress { get; set; }
    }

    public class bodyrolesInputItem
    {
        [JsonProperty("RoleID")]
        public int RoleId { get; set; }
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
        [JsonProperty("LegalEntityID")]
        public int LegalEntityId { get; set; }
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
        [JsonProperty("LegalEntityID")]
        public int LegalEntityId { get; set; }
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
        [JsonProperty("NoteID")]
        public int NoteId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public GetNotesForSpecificFileResponseNotesTypeItemCreatedByType CreatedBy { get; set; }
        public string CreatedDate { get; set; }

        [JsonProperty("FileID")]
        public int FileId { get; set; }
        public bool Expedite { get; set; }
    }

    public class GetNotesForSpecificFileResponseNotesTypeItemCreatedByType
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }
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
        [JsonProperty("NoteID")]
        public int NoteId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public GetNoteResponseCreatedByType CreatedBy { get; set; }
        public string CreatedDate { get; set; }

        [JsonProperty("FileID")]
        public int FileId { get; set; }
    }

    public class GetNoteResponseCreatedByType
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }
    }

    public class AddActionToFileResponse
    {
        [JsonProperty("FileActionID")]
        public int FileActionId { get; set; }
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
        [JsonProperty("DocumentID")]
        public int DocumentId { get; set; }
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
        [JsonProperty("DocumentTypeID")]
        public int DocumentTypeId { get; set; }
        public string Name { get; set; }
    }

    public class GetDocumentsForSpecificFileResponseDocumentsTypeItemAssociatedNotesTypeItem
    {
        [JsonProperty("NoteID")]
        public int NoteId { get; set; }
    }

    public class GetDocumentsForSpecificFileResponseDocumentsTypeItemCreateUserType
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }
        public string Name { get; set; }
    }

    public class GetDocumentsForSpecificFileResponseDocumentsTypeItemModifyUserType
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }
        public string Name { get; set; }
    }

    public class GetDocumentResponse
    {
        [JsonProperty("DocumentID")]
        public int DocumentId { get; set; }
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
        [JsonProperty("DocumentTypeID")]
        public int DocumentTypeId { get; set; }
        public string Name { get; set; }
    }

    public class GetDocumentResponseCreateUserType
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }
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
        [JsonProperty("TransactionTypeID")]
        public int TransactionTypeId { get; set; }

        [JsonProperty("ProductTypeID")]
        public int ProductTypeId { get; set; }
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
        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }

        [JsonProperty("PartnerID")]
        public int PartnerId { get; set; }
        public GetClosingFeeEstimateReceiptResponseRequestTypeFilePartnersTypeItemPartnerTypeType PartnerType { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseRequestTypeFilePartnersTypeItemPartnerTypeType
    {
        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseRequestTypeEndorsementsTypeItem
    {
        public string Name { get; set; }
    }

    public class GetClosingFeeEstimateReceiptResponseResponseType
    {
        [JsonProperty("ClosingFeeEstimateID")]
        public int ClosingFeeEstimateId { get; set; }
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
        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }
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
        [JsonProperty("FileActionID")]
        public int FileActionId { get; set; }
        public GetActionsForSpecificFileResponseActionsTypeItemActionTypeType ActionType { get; set; }
        public GetActionsForSpecificFileResponseActionsTypeItemGroupType Group { get; set; }
        public GetActionsForSpecificFileResponseActionsTypeItemStartTaskType StartTask { get; set; }
        public GetActionsForSpecificFileResponseActionsTypeItemCompleteTaskType CompleteTask { get; set; }
    }

    public class GetActionsForSpecificFileResponseActionsTypeItemActionTypeType
    {
        [JsonProperty("ActionTypeID")]
        public int ActionTypeId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }

    public class GetActionsForSpecificFileResponseActionsTypeItemGroupType
    {
        [JsonProperty("ActionGroupID")]
        public int ActionGroupId { get; set; }
        public string Name { get; set; }
    }

    public class GetActionsForSpecificFileResponseActionsTypeItemStartTaskType
    {
        [JsonProperty("CoordinatorTypeID")]
        public int CoordinatorTypeId { get; set; }
        public string DueDate { get; set; }
        public bool DueDateLocked { get; set; }
        public string DoneDate { get; set; }
        public bool DoneDateLocked { get; set; }
        public GetActionsForSpecificFileResponseActionsTypeItemStartTaskTypeDoneByType DoneBy { get; set; }
    }

    public class GetActionsForSpecificFileResponseActionsTypeItemStartTaskTypeDoneByType
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }
        public string Name { get; set; }
    }

    public class GetActionsForSpecificFileResponseActionsTypeItemCompleteTaskType
    {
        [JsonProperty("CoordinatorTypeID")]
        public int CoordinatorTypeId { get; set; }
        public string DueDate { get; set; }
        public bool DueDateLocked { get; set; }
        public bool DoneDateLocked { get; set; }
        public GetActionsForSpecificFileResponseActionsTypeItemCompleteTaskTypeDoneByType DoneBy { get; set; }
    }

    public class GetActionsForSpecificFileResponseActionsTypeItemCompleteTaskTypeDoneByType
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }
        public string Name { get; set; }
    }

    public class GetCurrentUserInfoResponse
    {
        public string Title { get; set; }
        public string PasswordExpirationDate { get; set; }

        [JsonProperty("UserID")]
        public int UserId { get; set; }
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
        [JsonProperty("ClosingFeeEstimateID")]
        public int ClosingFeeEstimateId { get; set; }
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
        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }
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
        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }

        [JsonProperty("PartnerID")]
        public int PartnerId { get; set; }
        public bodyfilePartnersInputItemPartnerTypeType PartnerType { get; set; }
    }

    public class bodyfilePartnersInputItemPartnerTypeType
    {
        [JsonProperty("PartnerTypeID")]
        public int PartnerTypeId { get; set; }
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