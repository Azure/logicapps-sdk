//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ewaycrm
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EwaycrmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteCompany([WorkflowExpression] Func<string> deleteCompanyWrapperitemGuid = null)
        {
            var apiCallPath = "/DeleteCompany";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteCompanyWrapper = new JObject();
            var deleteCompanyWrapperpropCount = 0;
            if (deleteCompanyWrapperitemGuid != null)
            {
                deleteCompanyWrapper["itemGuid"] = ExpressionConverter.ConvertO(deleteCompanyWrapperitemGuid);
                deleteCompanyWrapperpropCount++;
            }

            if (deleteCompanyWrapperpropCount > 0)
            {
                callPayload.Body = deleteCompanyWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteContact([WorkflowExpression] Func<string> deleteContactWrapperitemGuid = null)
        {
            var apiCallPath = "/DeleteContact";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteContactWrapper = new JObject();
            var deleteContactWrapperpropCount = 0;
            if (deleteContactWrapperitemGuid != null)
            {
                deleteContactWrapper["itemGuid"] = ExpressionConverter.ConvertO(deleteContactWrapperitemGuid);
                deleteContactWrapperpropCount++;
            }

            if (deleteContactWrapperpropCount > 0)
            {
                callPayload.Body = deleteContactWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteJournal([WorkflowExpression] Func<string> deleteJournalWrapperitemGuid = null)
        {
            var apiCallPath = "/DeleteJournal";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteJournalWrapper = new JObject();
            var deleteJournalWrapperpropCount = 0;
            if (deleteJournalWrapperitemGuid != null)
            {
                deleteJournalWrapper["itemGuid"] = ExpressionConverter.ConvertO(deleteJournalWrapperitemGuid);
                deleteJournalWrapperpropCount++;
            }

            if (deleteJournalWrapperpropCount > 0)
            {
                callPayload.Body = deleteJournalWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteLead([WorkflowExpression] Func<string> deleteLeadWrapperitemGuid = null)
        {
            var apiCallPath = "/DeleteLead";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteLeadWrapper = new JObject();
            var deleteLeadWrapperpropCount = 0;
            if (deleteLeadWrapperitemGuid != null)
            {
                deleteLeadWrapper["itemGuid"] = ExpressionConverter.ConvertO(deleteLeadWrapperitemGuid);
                deleteLeadWrapperpropCount++;
            }

            if (deleteLeadWrapperpropCount > 0)
            {
                callPayload.Body = deleteLeadWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteProject([WorkflowExpression] Func<string> deleteProjectWrapperitemGuid = null)
        {
            var apiCallPath = "/DeleteProject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteProjectWrapper = new JObject();
            var deleteProjectWrapperpropCount = 0;
            if (deleteProjectWrapperitemGuid != null)
            {
                deleteProjectWrapper["itemGuid"] = ExpressionConverter.ConvertO(deleteProjectWrapperitemGuid);
                deleteProjectWrapperpropCount++;
            }

            if (deleteProjectWrapperpropCount > 0)
            {
                callPayload.Body = deleteProjectWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteTask([WorkflowExpression] Func<string> deleteTaskWrapperitemGuid = null)
        {
            var apiCallPath = "/DeleteTask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteTaskWrapper = new JObject();
            var deleteTaskWrapperpropCount = 0;
            if (deleteTaskWrapperitemGuid != null)
            {
                deleteTaskWrapper["itemGuid"] = ExpressionConverter.ConvertO(deleteTaskWrapperitemGuid);
                deleteTaskWrapperpropCount++;
            }

            if (deleteTaskWrapperpropCount > 0)
            {
                callPayload.Body = deleteTaskWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveCompany([WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaccountNumber = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress1POBox = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress1Street = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress1City = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress1State = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress1CountryEn = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress1PostalCode = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress2POBox = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress2Street = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress2City = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress2State = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress2CountryEn = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress2PostalCode = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress3POBox = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress3Street = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress3City = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress3State = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress3CountryEn = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress3PostalCode = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectcompanyName = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectdepartment = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectemail = null, [WorkflowExpression] Func<int> saveCompanyWrappertransmitObjectemployeesCount = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectfax = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectfirstContactEn = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectiCQ = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectidentificationNumber = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectimportanceEn = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectlineOfBusiness = null, [WorkflowExpression] Func<bool> saveCompanyWrappertransmitObjectmailingListOther = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectmobile = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectmobileNormalized = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectmSN = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectnote = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectphone = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectphoneNormalized = null, [WorkflowExpression] Func<bool> saveCompanyWrappertransmitObjectpurchaser = null, [WorkflowExpression] Func<double> saveCompanyWrappertransmitObjectreversal = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectskype = null, [WorkflowExpression] Func<bool> saveCompanyWrappertransmitObjectsuppliers = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectvATNumber = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectwebPage = null, [WorkflowExpression] Func<double> saveCompanyWrappertransmitObjectadditionalDiscount = null, [WorkflowExpression] Func<int> saveCompanyWrappertransmitObjectiD = null, [WorkflowExpression] Func<bool> saveCompanyWrappertransmitObjectcompetitor = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectsalePriceGuid = null, [WorkflowExpression] Func<bool> saveCompanyWrappertransmitObjectnotificationByEmail = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectnotificationBy = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectlastActivity = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectnextStep = null, [WorkflowExpression] Func<bool> saveCompanyWrappertransmitObjectemailOptOut = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectpicture = null, [WorkflowExpression] Func<int> saveCompanyWrappertransmitObjectpictureWidth = null, [WorkflowExpression] Func<int> saveCompanyWrappertransmitObjectpictureHeight = null, [WorkflowExpression] Func<bool> saveCompanyWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> saveCompanyWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> saveCompanyWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> saveCompanyWrapperdieOnItemConflict = null, [WorkflowExpression] Func<string[]> saveCompanyWrapperignoredUserErrorMessages = null)
        {
            var apiCallPath = "/SaveCompany";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var saveCompanyWrapper = new JObject();
            var saveCompanyWrapperpropCount = 0;
            var transmitObjectObject = new JObject();
            var transmitObjectObjectpropCount = 0;
            if (saveCompanyWrappertransmitObjectaccountNumber != null)
            {
                transmitObjectObject["AccountNumber"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectaccountNumber);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress1POBox != null)
            {
                transmitObjectObject["Address1POBox"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectaddress1POBox);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress1Street != null)
            {
                transmitObjectObject["Address1Street"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectaddress1Street);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress1City != null)
            {
                transmitObjectObject["Address1City"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectaddress1City);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress1State != null)
            {
                transmitObjectObject["Address1State"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectaddress1State);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress1CountryEn != null)
            {
                transmitObjectObject["Address1CountryEn"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectaddress1CountryEn);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress1PostalCode != null)
            {
                transmitObjectObject["Address1PostalCode"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectaddress1PostalCode);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress2POBox != null)
            {
                transmitObjectObject["Address2POBox"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectaddress2POBox);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress2Street != null)
            {
                transmitObjectObject["Address2Street"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectaddress2Street);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress2City != null)
            {
                transmitObjectObject["Address2City"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectaddress2City);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress2State != null)
            {
                transmitObjectObject["Address2State"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectaddress2State);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress2CountryEn != null)
            {
                transmitObjectObject["Address2CountryEn"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectaddress2CountryEn);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress2PostalCode != null)
            {
                transmitObjectObject["Address2PostalCode"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectaddress2PostalCode);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress3POBox != null)
            {
                transmitObjectObject["Address3POBox"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectaddress3POBox);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress3Street != null)
            {
                transmitObjectObject["Address3Street"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectaddress3Street);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress3City != null)
            {
                transmitObjectObject["Address3City"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectaddress3City);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress3State != null)
            {
                transmitObjectObject["Address3State"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectaddress3State);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress3CountryEn != null)
            {
                transmitObjectObject["Address3CountryEn"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectaddress3CountryEn);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress3PostalCode != null)
            {
                transmitObjectObject["Address3PostalCode"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectaddress3PostalCode);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectcompanyName != null)
            {
                transmitObjectObject["CompanyName"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectcompanyName);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectdepartment != null)
            {
                transmitObjectObject["Department"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectdepartment);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectemail != null)
            {
                transmitObjectObject["Email"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectemail);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectemployeesCount != null)
            {
                transmitObjectObject["EmployeesCount"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectemployeesCount);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectfax != null)
            {
                transmitObjectObject["Fax"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectfax);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectfirstContactEn != null)
            {
                transmitObjectObject["FirstContactEn"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectfirstContactEn);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectiCQ != null)
            {
                transmitObjectObject["ICQ"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectiCQ);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectidentificationNumber != null)
            {
                transmitObjectObject["IdentificationNumber"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectidentificationNumber);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectimportanceEn != null)
            {
                transmitObjectObject["ImportanceEn"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectimportanceEn);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectlineOfBusiness != null)
            {
                transmitObjectObject["LineOfBusiness"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectlineOfBusiness);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectmailingListOther != null)
            {
                transmitObjectObject["MailingListOther"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectmailingListOther);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectmobile != null)
            {
                transmitObjectObject["Mobile"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectmobile);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectmobileNormalized != null)
            {
                transmitObjectObject["MobileNormalized"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectmobileNormalized);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectmSN != null)
            {
                transmitObjectObject["MSN"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectmSN);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectnote != null)
            {
                transmitObjectObject["Note"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectnote);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectphone != null)
            {
                transmitObjectObject["Phone"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectphone);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectphoneNormalized != null)
            {
                transmitObjectObject["PhoneNormalized"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectphoneNormalized);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectpurchaser != null)
            {
                transmitObjectObject["Purchaser"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectpurchaser);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectreversal != null)
            {
                transmitObjectObject["Reversal"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectreversal);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectskype != null)
            {
                transmitObjectObject["Skype"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectskype);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectsuppliers != null)
            {
                transmitObjectObject["Suppliers"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectsuppliers);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectvATNumber != null)
            {
                transmitObjectObject["VATNumber"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectvATNumber);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectwebPage != null)
            {
                transmitObjectObject["WebPage"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectwebPage);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectadditionalDiscount != null)
            {
                transmitObjectObject["AdditionalDiscount"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectadditionalDiscount);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectiD != null)
            {
                transmitObjectObject["ID"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectiD);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectcompetitor != null)
            {
                transmitObjectObject["Competitor"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectcompetitor);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectsalePriceGuid != null)
            {
                transmitObjectObject["SalePriceGuid"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectsalePriceGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectnotificationByEmail != null)
            {
                transmitObjectObject["NotificationByEmail"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectnotificationByEmail);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectnotificationBy != null)
            {
                transmitObjectObject["NotificationBy"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectnotificationBy);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectlastActivity != null)
            {
                transmitObjectObject["LastActivity"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectlastActivity);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectnextStep != null)
            {
                transmitObjectObject["NextStep"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectnextStep);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectemailOptOut != null)
            {
                transmitObjectObject["EmailOptOut"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectemailOptOut);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectpicture != null)
            {
                transmitObjectObject["Picture"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectpicture);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectpictureWidth != null)
            {
                transmitObjectObject["PictureWidth"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectpictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectpictureHeight != null)
            {
                transmitObjectObject["PictureHeight"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectpictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(saveCompanyWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                saveCompanyWrapper["transmitObject"] = transmitObjectObject;
                saveCompanyWrapperpropCount++;
            }

            if (saveCompanyWrapperdieOnItemConflict != null)
            {
                saveCompanyWrapper["dieOnItemConflict"] = ExpressionConverter.ConvertO(saveCompanyWrapperdieOnItemConflict);
                saveCompanyWrapperpropCount++;
            }

            if (saveCompanyWrapperignoredUserErrorMessages != null)
            {
                saveCompanyWrapper["ignoredUserErrorMessages"] = ExpressionConverter.ConvertO(saveCompanyWrapperignoredUserErrorMessages);
                saveCompanyWrapperpropCount++;
            }

            if (saveCompanyWrapperpropCount > 0)
            {
                callPayload.Body = saveCompanyWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveContact([WorkflowExpression] Func<string> saveContactWrappertransmitObjectbusinessAddressStreet = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectbusinessAddressCity = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectbusinessAddressState = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectbusinessAddressCountryEn = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectbusinessAddressPOBox = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectbusinessAddressPostalCode = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecthomeAddressStreet = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecthomeAddressCity = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecthomeAddressState = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecthomeAddressCountryEn = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecthomeAddressPOBox = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecthomeAddressPostalCode = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectotherAddressStreet = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectotherAddressCity = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectotherAddressState = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectotherAddressCountryEn = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectotherAddressPOBox = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectotherAddressPostalCode = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectcompany = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectemail1Address = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectemail2Address = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectemail3Address = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectfirstName = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectiCQ = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectimportanceEn = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectlastName = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectmiddleName = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectmSN = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectnote = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectprefixEn = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectsuffixEn = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectskype = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber1 = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber2 = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber3 = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber4 = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber5 = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber6 = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber1Normalized = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber2Normalized = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber3Normalized = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber4Normalized = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber5Normalized = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber6Normalized = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectdepartment = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttitle = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectwebPage = null, [WorkflowExpression] Func<bool> saveContactWrappertransmitObjectdoNotSendNewsletter = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectprofilePicture = null, [WorkflowExpression] Func<int> saveContactWrappertransmitObjectprofilePictureWidth = null, [WorkflowExpression] Func<int> saveContactWrappertransmitObjectprofilePictureHeight = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectlastActivity = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectnextStep = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectcompaniesCompanyGuid = null, [WorkflowExpression] Func<bool> saveContactWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> saveContactWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> saveContactWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> saveContactWrapperdieOnItemConflict = null, [WorkflowExpression] Func<string[]> saveContactWrapperignoredUserErrorMessages = null)
        {
            var apiCallPath = "/SaveContact";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var saveContactWrapper = new JObject();
            var saveContactWrapperpropCount = 0;
            var transmitObjectObject = new JObject();
            var transmitObjectObjectpropCount = 0;
            if (saveContactWrappertransmitObjectbusinessAddressStreet != null)
            {
                transmitObjectObject["BusinessAddressStreet"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectbusinessAddressStreet);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectbusinessAddressCity != null)
            {
                transmitObjectObject["BusinessAddressCity"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectbusinessAddressCity);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectbusinessAddressState != null)
            {
                transmitObjectObject["BusinessAddressState"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectbusinessAddressState);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectbusinessAddressCountryEn != null)
            {
                transmitObjectObject["BusinessAddressCountryEn"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectbusinessAddressCountryEn);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectbusinessAddressPOBox != null)
            {
                transmitObjectObject["BusinessAddressPOBox"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectbusinessAddressPOBox);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectbusinessAddressPostalCode != null)
            {
                transmitObjectObject["BusinessAddressPostalCode"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectbusinessAddressPostalCode);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecthomeAddressStreet != null)
            {
                transmitObjectObject["HomeAddressStreet"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjecthomeAddressStreet);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecthomeAddressCity != null)
            {
                transmitObjectObject["HomeAddressCity"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjecthomeAddressCity);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecthomeAddressState != null)
            {
                transmitObjectObject["HomeAddressState"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjecthomeAddressState);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecthomeAddressCountryEn != null)
            {
                transmitObjectObject["HomeAddressCountryEn"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjecthomeAddressCountryEn);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecthomeAddressPOBox != null)
            {
                transmitObjectObject["HomeAddressPOBox"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjecthomeAddressPOBox);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecthomeAddressPostalCode != null)
            {
                transmitObjectObject["HomeAddressPostalCode"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjecthomeAddressPostalCode);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectotherAddressStreet != null)
            {
                transmitObjectObject["OtherAddressStreet"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectotherAddressStreet);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectotherAddressCity != null)
            {
                transmitObjectObject["OtherAddressCity"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectotherAddressCity);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectotherAddressState != null)
            {
                transmitObjectObject["OtherAddressState"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectotherAddressState);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectotherAddressCountryEn != null)
            {
                transmitObjectObject["OtherAddressCountryEn"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectotherAddressCountryEn);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectotherAddressPOBox != null)
            {
                transmitObjectObject["OtherAddressPOBox"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectotherAddressPOBox);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectotherAddressPostalCode != null)
            {
                transmitObjectObject["OtherAddressPostalCode"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectotherAddressPostalCode);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectcompany != null)
            {
                transmitObjectObject["Company"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectcompany);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectemail1Address != null)
            {
                transmitObjectObject["Email1Address"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectemail1Address);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectemail2Address != null)
            {
                transmitObjectObject["Email2Address"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectemail2Address);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectemail3Address != null)
            {
                transmitObjectObject["Email3Address"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectemail3Address);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectfirstName != null)
            {
                transmitObjectObject["FirstName"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectfirstName);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectiCQ != null)
            {
                transmitObjectObject["ICQ"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectiCQ);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectimportanceEn != null)
            {
                transmitObjectObject["ImportanceEn"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectimportanceEn);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectlastName != null)
            {
                transmitObjectObject["LastName"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectlastName);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectmiddleName != null)
            {
                transmitObjectObject["MiddleName"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectmiddleName);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectmSN != null)
            {
                transmitObjectObject["MSN"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectmSN);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectnote != null)
            {
                transmitObjectObject["Note"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectnote);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectprefixEn != null)
            {
                transmitObjectObject["PrefixEn"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectprefixEn);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectsuffixEn != null)
            {
                transmitObjectObject["SuffixEn"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectsuffixEn);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectskype != null)
            {
                transmitObjectObject["Skype"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectskype);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber1 != null)
            {
                transmitObjectObject["TelephoneNumber1"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjecttelephoneNumber1);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber2 != null)
            {
                transmitObjectObject["TelephoneNumber2"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjecttelephoneNumber2);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber3 != null)
            {
                transmitObjectObject["TelephoneNumber3"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjecttelephoneNumber3);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber4 != null)
            {
                transmitObjectObject["TelephoneNumber4"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjecttelephoneNumber4);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber5 != null)
            {
                transmitObjectObject["TelephoneNumber5"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjecttelephoneNumber5);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber6 != null)
            {
                transmitObjectObject["TelephoneNumber6"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjecttelephoneNumber6);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber1Normalized != null)
            {
                transmitObjectObject["TelephoneNumber1Normalized"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjecttelephoneNumber1Normalized);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber2Normalized != null)
            {
                transmitObjectObject["TelephoneNumber2Normalized"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjecttelephoneNumber2Normalized);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber3Normalized != null)
            {
                transmitObjectObject["TelephoneNumber3Normalized"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjecttelephoneNumber3Normalized);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber4Normalized != null)
            {
                transmitObjectObject["TelephoneNumber4Normalized"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjecttelephoneNumber4Normalized);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber5Normalized != null)
            {
                transmitObjectObject["TelephoneNumber5Normalized"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjecttelephoneNumber5Normalized);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber6Normalized != null)
            {
                transmitObjectObject["TelephoneNumber6Normalized"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjecttelephoneNumber6Normalized);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectdepartment != null)
            {
                transmitObjectObject["Department"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectdepartment);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttitle != null)
            {
                transmitObjectObject["Title"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjecttitle);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectwebPage != null)
            {
                transmitObjectObject["WebPage"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectwebPage);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectdoNotSendNewsletter != null)
            {
                transmitObjectObject["DoNotSendNewsletter"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectdoNotSendNewsletter);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectprofilePicture != null)
            {
                transmitObjectObject["ProfilePicture"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectprofilePicture);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectprofilePictureWidth != null)
            {
                transmitObjectObject["ProfilePictureWidth"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectprofilePictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectprofilePictureHeight != null)
            {
                transmitObjectObject["ProfilePictureHeight"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectprofilePictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectlastActivity != null)
            {
                transmitObjectObject["LastActivity"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectlastActivity);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectnextStep != null)
            {
                transmitObjectObject["NextStep"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectnextStep);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectcompaniesCompanyGuid != null)
            {
                transmitObjectObject["Companies_CompanyGuid"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectcompaniesCompanyGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(saveContactWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                saveContactWrapper["transmitObject"] = transmitObjectObject;
                saveContactWrapperpropCount++;
            }

            if (saveContactWrapperdieOnItemConflict != null)
            {
                saveContactWrapper["dieOnItemConflict"] = ExpressionConverter.ConvertO(saveContactWrapperdieOnItemConflict);
                saveContactWrapperpropCount++;
            }

            if (saveContactWrapperignoredUserErrorMessages != null)
            {
                saveContactWrapper["ignoredUserErrorMessages"] = ExpressionConverter.ConvertO(saveContactWrapperignoredUserErrorMessages);
                saveContactWrapperpropCount++;
            }

            if (saveContactWrapperpropCount > 0)
            {
                callPayload.Body = saveContactWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveJournal([WorkflowExpression] Func<string> saveJournalWrappertransmitObjectcalendarEntryID = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectcalendarORIGIN = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectchangedField = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjecteventEnd = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjecteventStart = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectfieldValue = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectimportanceEn = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectnote = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectprevFieldValue = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<bool> saveJournalWrappertransmitObjectisSystem = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectphone = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectphoneNormalized = null, [WorkflowExpression] Func<bool> saveJournalWrappertransmitObjectisGdprRelevant = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectpicture = null, [WorkflowExpression] Func<int> saveJournalWrappertransmitObjectpictureWidth = null, [WorkflowExpression] Func<int> saveJournalWrappertransmitObjectpictureHeight = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectcompaniesCompanyGuid = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectcontactsContactGuid = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectleadsSuperiorItemGuid = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectprojectsSuperiorItemGuid = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectmarketingMarketingGuid = null, [WorkflowExpression] Func<bool> saveJournalWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> saveJournalWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> saveJournalWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> saveJournalWrapperdieOnItemConflict = null, [WorkflowExpression] Func<string[]> saveJournalWrapperignoredUserErrorMessages = null)
        {
            var apiCallPath = "/SaveJournal";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var saveJournalWrapper = new JObject();
            var saveJournalWrapperpropCount = 0;
            var transmitObjectObject = new JObject();
            var transmitObjectObjectpropCount = 0;
            if (saveJournalWrappertransmitObjectcalendarEntryID != null)
            {
                transmitObjectObject["CalendarEntryID"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectcalendarEntryID);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectcalendarORIGIN != null)
            {
                transmitObjectObject["Calendar_ORIGIN"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectcalendarORIGIN);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectchangedField != null)
            {
                transmitObjectObject["ChangedField"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectchangedField);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjecteventEnd != null)
            {
                transmitObjectObject["EventEnd"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjecteventEnd);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjecteventStart != null)
            {
                transmitObjectObject["EventStart"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjecteventStart);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectfieldValue != null)
            {
                transmitObjectObject["FieldValue"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectfieldValue);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectimportanceEn != null)
            {
                transmitObjectObject["ImportanceEn"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectimportanceEn);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectnote != null)
            {
                transmitObjectObject["Note"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectnote);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectprevFieldValue != null)
            {
                transmitObjectObject["PrevFieldValue"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectprevFieldValue);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectisSystem != null)
            {
                transmitObjectObject["IsSystem"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectisSystem);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectphone != null)
            {
                transmitObjectObject["Phone"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectphone);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectphoneNormalized != null)
            {
                transmitObjectObject["PhoneNormalized"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectphoneNormalized);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectisGdprRelevant != null)
            {
                transmitObjectObject["IsGdprRelevant"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectisGdprRelevant);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectpicture != null)
            {
                transmitObjectObject["Picture"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectpicture);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectpictureWidth != null)
            {
                transmitObjectObject["PictureWidth"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectpictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectpictureHeight != null)
            {
                transmitObjectObject["PictureHeight"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectpictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectcompaniesCompanyGuid != null)
            {
                transmitObjectObject["Companies_CompanyGuid"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectcompaniesCompanyGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectcontactsContactGuid != null)
            {
                transmitObjectObject["Contacts_ContactGuid"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectcontactsContactGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectleadsSuperiorItemGuid != null)
            {
                transmitObjectObject["Leads_SuperiorItemGuid"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectleadsSuperiorItemGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectprojectsSuperiorItemGuid != null)
            {
                transmitObjectObject["Projects_SuperiorItemGuid"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectprojectsSuperiorItemGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectmarketingMarketingGuid != null)
            {
                transmitObjectObject["Marketing_MarketingGuid"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectmarketingMarketingGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(saveJournalWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                saveJournalWrapper["transmitObject"] = transmitObjectObject;
                saveJournalWrapperpropCount++;
            }

            if (saveJournalWrapperdieOnItemConflict != null)
            {
                saveJournalWrapper["dieOnItemConflict"] = ExpressionConverter.ConvertO(saveJournalWrapperdieOnItemConflict);
                saveJournalWrapperpropCount++;
            }

            if (saveJournalWrapperignoredUserErrorMessages != null)
            {
                saveJournalWrapper["ignoredUserErrorMessages"] = ExpressionConverter.ConvertO(saveJournalWrapperignoredUserErrorMessages);
                saveJournalWrapperpropCount++;
            }

            if (saveJournalWrapperpropCount > 0)
            {
                callPayload.Body = saveJournalWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveLead([WorkflowExpression] Func<string> saveLeadWrappertransmitObjectcity = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectcontactPerson = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectcurrencyEn = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectcustomer = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectemail = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectestimatedEnd = null, [WorkflowExpression] Func<int> saveLeadWrappertransmitObjecthID = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectleadOriginEn = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectnote = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectphone = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectphoneNormalized = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<double> saveLeadWrappertransmitObjectprice = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectpriceChanged = null, [WorkflowExpression] Func<double> saveLeadWrappertransmitObjectpriceDefaultCurrency = null, [WorkflowExpression] Func<double> saveLeadWrappertransmitObjectprobability = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectreceiveDate = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectstreet = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectzip = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectlastActivity = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectnextStep = null, [WorkflowExpression] Func<double> saveLeadWrappertransmitObjectestimatedValue = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectcountryEn = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectstate = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectpOBox = null, [WorkflowExpression] Func<bool> saveLeadWrappertransmitObjectemailOptOut = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectpicture = null, [WorkflowExpression] Func<int> saveLeadWrappertransmitObjectpictureWidth = null, [WorkflowExpression] Func<int> saveLeadWrappertransmitObjectpictureHeight = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectcompaniesCustomerGuid = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectcontactsContactPersonGuid = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectmarketingMarketingGuid = null, [WorkflowExpression] Func<bool> saveLeadWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> saveLeadWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> saveLeadWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> saveLeadWrapperdieOnItemConflict = null, [WorkflowExpression] Func<string[]> saveLeadWrapperignoredUserErrorMessages = null)
        {
            var apiCallPath = "/SaveLead";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var saveLeadWrapper = new JObject();
            var saveLeadWrapperpropCount = 0;
            var transmitObjectObject = new JObject();
            var transmitObjectObjectpropCount = 0;
            if (saveLeadWrappertransmitObjectcity != null)
            {
                transmitObjectObject["City"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectcity);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectcontactPerson != null)
            {
                transmitObjectObject["ContactPerson"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectcontactPerson);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectcurrencyEn != null)
            {
                transmitObjectObject["CurrencyEn"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectcurrencyEn);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectcustomer != null)
            {
                transmitObjectObject["Customer"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectcustomer);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectemail != null)
            {
                transmitObjectObject["Email"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectemail);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectestimatedEnd != null)
            {
                transmitObjectObject["EstimatedEnd"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectestimatedEnd);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjecthID != null)
            {
                transmitObjectObject["HID"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjecthID);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectleadOriginEn != null)
            {
                transmitObjectObject["LeadOriginEn"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectleadOriginEn);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectnote != null)
            {
                transmitObjectObject["Note"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectnote);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectphone != null)
            {
                transmitObjectObject["Phone"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectphone);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectphoneNormalized != null)
            {
                transmitObjectObject["PhoneNormalized"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectphoneNormalized);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectprice != null)
            {
                transmitObjectObject["Price"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectprice);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectpriceChanged != null)
            {
                transmitObjectObject["PriceChanged"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectpriceChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectpriceDefaultCurrency != null)
            {
                transmitObjectObject["PriceDefaultCurrency"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectpriceDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectprobability != null)
            {
                transmitObjectObject["Probability"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectprobability);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectreceiveDate != null)
            {
                transmitObjectObject["ReceiveDate"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectreceiveDate);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectstreet != null)
            {
                transmitObjectObject["Street"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectstreet);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectzip != null)
            {
                transmitObjectObject["Zip"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectzip);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectlastActivity != null)
            {
                transmitObjectObject["LastActivity"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectlastActivity);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectnextStep != null)
            {
                transmitObjectObject["NextStep"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectnextStep);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectestimatedValue != null)
            {
                transmitObjectObject["EstimatedValue"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectestimatedValue);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectcountryEn != null)
            {
                transmitObjectObject["CountryEn"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectcountryEn);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectstate != null)
            {
                transmitObjectObject["State"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectstate);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectpOBox != null)
            {
                transmitObjectObject["POBox"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectpOBox);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectemailOptOut != null)
            {
                transmitObjectObject["EmailOptOut"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectemailOptOut);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectpicture != null)
            {
                transmitObjectObject["Picture"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectpicture);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectpictureWidth != null)
            {
                transmitObjectObject["PictureWidth"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectpictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectpictureHeight != null)
            {
                transmitObjectObject["PictureHeight"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectpictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectcompaniesCustomerGuid != null)
            {
                transmitObjectObject["Companies_CustomerGuid"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectcompaniesCustomerGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectcontactsContactPersonGuid != null)
            {
                transmitObjectObject["Contacts_ContactPersonGuid"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectcontactsContactPersonGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectmarketingMarketingGuid != null)
            {
                transmitObjectObject["Marketing_MarketingGuid"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectmarketingMarketingGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(saveLeadWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                saveLeadWrapper["transmitObject"] = transmitObjectObject;
                saveLeadWrapperpropCount++;
            }

            if (saveLeadWrapperdieOnItemConflict != null)
            {
                saveLeadWrapper["dieOnItemConflict"] = ExpressionConverter.ConvertO(saveLeadWrapperdieOnItemConflict);
                saveLeadWrapperpropCount++;
            }

            if (saveLeadWrapperignoredUserErrorMessages != null)
            {
                saveLeadWrapper["ignoredUserErrorMessages"] = ExpressionConverter.ConvertO(saveLeadWrapperignoredUserErrorMessages);
                saveLeadWrapperpropCount++;
            }

            if (saveLeadWrapperpropCount > 0)
            {
                callPayload.Body = saveLeadWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveProject([WorkflowExpression] Func<string> saveProjectWrappertransmitObjectnote = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectprice = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectprojectEnd = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectprojectName = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectpeopleExpenses = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectprojectRealEnd = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectestimatedPrice = null, [WorkflowExpression] Func<int> saveProjectWrappertransmitObjecthID = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectprojectOriginEn = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectpaymentTypeEn = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectotherExpenses = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectmargin = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectprofit = null, [WorkflowExpression] Func<int> saveProjectWrappertransmitObjectpaymentMaturity = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectinvoicePaymentDate = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectinvoiceIssueDate = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectestimatedMargin = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectestimatedProfit = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectestimatedPeopleExpenses = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectestimatedOtherExpenses = null, [WorkflowExpression] Func<int> saveProjectWrappertransmitObjectlicensesCount = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectlicensePrice = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<bool> saveProjectWrappertransmitObjectshowInCaplan = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectprojectStart = null, [WorkflowExpression] Func<int> saveProjectWrappertransmitObjectestimatedWorkHours = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjecttotalWorkHours = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectestimatedOtherExpensesDefaultCurrency = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectestimatedPriceDefaultCurrency = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectpeopleExpensesDefaultCurrency = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectotherExpensesDefaultCurrency = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectpriceDefaultCurrency = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectprofitDefaultCurrency = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectestimatedProfitDefaultCurrency = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectcurrencyEn = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectestimatedPeopleExpensesChanged = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectestimatedOtherExpensesChanged = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectotherExpensesChanged = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectestimatedPriceChanged = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectpriceChanged = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectlicensePriceChanged = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectlicensePriceDefaultCurrency = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectlastActivity = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectnextStep = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectpeopleExpensesChanged = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectpicture = null, [WorkflowExpression] Func<int> saveProjectWrappertransmitObjectpictureWidth = null, [WorkflowExpression] Func<int> saveProjectWrappertransmitObjectpictureHeight = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectcompaniesCustomerGuid = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectcontactsContactPersonGuid = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectleadsProjectOriginGuid = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectprojectsSuperiorProjectGuid = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectusersSupervisorGuid = null, [WorkflowExpression] Func<bool> saveProjectWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> saveProjectWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> saveProjectWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> saveProjectWrapperdieOnItemConflict = null, [WorkflowExpression] Func<string[]> saveProjectWrapperignoredUserErrorMessages = null)
        {
            var apiCallPath = "/SaveProject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var saveProjectWrapper = new JObject();
            var saveProjectWrapperpropCount = 0;
            var transmitObjectObject = new JObject();
            var transmitObjectObjectpropCount = 0;
            if (saveProjectWrappertransmitObjectnote != null)
            {
                transmitObjectObject["Note"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectnote);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectprice != null)
            {
                transmitObjectObject["Price"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectprice);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectprojectEnd != null)
            {
                transmitObjectObject["ProjectEnd"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectprojectEnd);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectprojectName != null)
            {
                transmitObjectObject["ProjectName"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectprojectName);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectpeopleExpenses != null)
            {
                transmitObjectObject["PeopleExpenses"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectpeopleExpenses);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectprojectRealEnd != null)
            {
                transmitObjectObject["ProjectRealEnd"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectprojectRealEnd);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedPrice != null)
            {
                transmitObjectObject["EstimatedPrice"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectestimatedPrice);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjecthID != null)
            {
                transmitObjectObject["HID"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjecthID);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectprojectOriginEn != null)
            {
                transmitObjectObject["ProjectOriginEn"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectprojectOriginEn);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectpaymentTypeEn != null)
            {
                transmitObjectObject["PaymentTypeEn"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectpaymentTypeEn);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectotherExpenses != null)
            {
                transmitObjectObject["OtherExpenses"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectotherExpenses);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectmargin != null)
            {
                transmitObjectObject["Margin"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectmargin);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectprofit != null)
            {
                transmitObjectObject["Profit"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectprofit);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectpaymentMaturity != null)
            {
                transmitObjectObject["PaymentMaturity"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectpaymentMaturity);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectinvoicePaymentDate != null)
            {
                transmitObjectObject["InvoicePaymentDate"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectinvoicePaymentDate);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectinvoiceIssueDate != null)
            {
                transmitObjectObject["InvoiceIssueDate"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectinvoiceIssueDate);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedMargin != null)
            {
                transmitObjectObject["EstimatedMargin"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectestimatedMargin);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedProfit != null)
            {
                transmitObjectObject["EstimatedProfit"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectestimatedProfit);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedPeopleExpenses != null)
            {
                transmitObjectObject["EstimatedPeopleExpenses"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectestimatedPeopleExpenses);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedOtherExpenses != null)
            {
                transmitObjectObject["EstimatedOtherExpenses"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectestimatedOtherExpenses);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectlicensesCount != null)
            {
                transmitObjectObject["LicensesCount"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectlicensesCount);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectlicensePrice != null)
            {
                transmitObjectObject["LicensePrice"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectlicensePrice);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectshowInCaplan != null)
            {
                transmitObjectObject["ShowInCaplan"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectshowInCaplan);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectprojectStart != null)
            {
                transmitObjectObject["ProjectStart"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectprojectStart);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedWorkHours != null)
            {
                transmitObjectObject["EstimatedWorkHours"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectestimatedWorkHours);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjecttotalWorkHours != null)
            {
                transmitObjectObject["TotalWorkHours"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjecttotalWorkHours);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency != null)
            {
                transmitObjectObject["EstimatedPeopleExpensesDefaultCurrency"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedOtherExpensesDefaultCurrency != null)
            {
                transmitObjectObject["EstimatedOtherExpensesDefaultCurrency"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectestimatedOtherExpensesDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedPriceDefaultCurrency != null)
            {
                transmitObjectObject["EstimatedPriceDefaultCurrency"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectestimatedPriceDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectpeopleExpensesDefaultCurrency != null)
            {
                transmitObjectObject["PeopleExpensesDefaultCurrency"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectpeopleExpensesDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectotherExpensesDefaultCurrency != null)
            {
                transmitObjectObject["OtherExpensesDefaultCurrency"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectotherExpensesDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectpriceDefaultCurrency != null)
            {
                transmitObjectObject["PriceDefaultCurrency"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectpriceDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectprofitDefaultCurrency != null)
            {
                transmitObjectObject["ProfitDefaultCurrency"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectprofitDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedProfitDefaultCurrency != null)
            {
                transmitObjectObject["EstimatedProfitDefaultCurrency"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectestimatedProfitDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectcurrencyEn != null)
            {
                transmitObjectObject["CurrencyEn"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectcurrencyEn);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedPeopleExpensesChanged != null)
            {
                transmitObjectObject["EstimatedPeopleExpensesChanged"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectestimatedPeopleExpensesChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedOtherExpensesChanged != null)
            {
                transmitObjectObject["EstimatedOtherExpensesChanged"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectestimatedOtherExpensesChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectotherExpensesChanged != null)
            {
                transmitObjectObject["OtherExpensesChanged"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectotherExpensesChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedPriceChanged != null)
            {
                transmitObjectObject["EstimatedPriceChanged"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectestimatedPriceChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectpriceChanged != null)
            {
                transmitObjectObject["PriceChanged"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectpriceChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectlicensePriceChanged != null)
            {
                transmitObjectObject["LicensePriceChanged"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectlicensePriceChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectlicensePriceDefaultCurrency != null)
            {
                transmitObjectObject["LicensePriceDefaultCurrency"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectlicensePriceDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectlastActivity != null)
            {
                transmitObjectObject["LastActivity"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectlastActivity);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectnextStep != null)
            {
                transmitObjectObject["NextStep"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectnextStep);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectpeopleExpensesChanged != null)
            {
                transmitObjectObject["PeopleExpensesChanged"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectpeopleExpensesChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectpicture != null)
            {
                transmitObjectObject["Picture"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectpicture);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectpictureWidth != null)
            {
                transmitObjectObject["PictureWidth"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectpictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectpictureHeight != null)
            {
                transmitObjectObject["PictureHeight"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectpictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectcompaniesCustomerGuid != null)
            {
                transmitObjectObject["Companies_CustomerGuid"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectcompaniesCustomerGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectcontactsContactPersonGuid != null)
            {
                transmitObjectObject["Contacts_ContactPersonGuid"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectcontactsContactPersonGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectleadsProjectOriginGuid != null)
            {
                transmitObjectObject["Leads_Project_OriginGuid"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectleadsProjectOriginGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectprojectsSuperiorProjectGuid != null)
            {
                transmitObjectObject["Projects_SuperiorProjectGuid"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectprojectsSuperiorProjectGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectusersSupervisorGuid != null)
            {
                transmitObjectObject["Users_SupervisorGuid"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectusersSupervisorGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(saveProjectWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                saveProjectWrapper["transmitObject"] = transmitObjectObject;
                saveProjectWrapperpropCount++;
            }

            if (saveProjectWrapperdieOnItemConflict != null)
            {
                saveProjectWrapper["dieOnItemConflict"] = ExpressionConverter.ConvertO(saveProjectWrapperdieOnItemConflict);
                saveProjectWrapperpropCount++;
            }

            if (saveProjectWrapperignoredUserErrorMessages != null)
            {
                saveProjectWrapper["ignoredUserErrorMessages"] = ExpressionConverter.ConvertO(saveProjectWrapperignoredUserErrorMessages);
                saveProjectWrapperpropCount++;
            }

            if (saveProjectWrapperpropCount > 0)
            {
                callPayload.Body = saveProjectWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesBooleanResponse> SaveRelation([WorkflowExpression] Func<string> saveRelationWrappertransmitObjectitemGUID1 = null, [WorkflowExpression] Func<string> saveRelationWrappertransmitObjectitemGUID2 = null, [WorkflowExpression] Func<saveRelationWrappertransmitObjectfolderName1Input> saveRelationWrappertransmitObjectfolderName1 = null, [WorkflowExpression] Func<saveRelationWrappertransmitObjectfolderName2Input> saveRelationWrappertransmitObjectfolderName2 = null)
        {
            var apiCallPath = "/SaveRelation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var saveRelationWrapper = new JObject();
            var saveRelationWrapperpropCount = 0;
            var transmitObjectObject = new JObject();
            var transmitObjectObjectpropCount = 0;
            if (saveRelationWrappertransmitObjectitemGUID1 != null)
            {
                transmitObjectObject["ItemGUID1"] = ExpressionConverter.ConvertO(saveRelationWrappertransmitObjectitemGUID1);
                transmitObjectObjectpropCount++;
            }

            if (saveRelationWrappertransmitObjectitemGUID2 != null)
            {
                transmitObjectObject["ItemGUID2"] = ExpressionConverter.ConvertO(saveRelationWrappertransmitObjectitemGUID2);
                transmitObjectObjectpropCount++;
            }

            if (saveRelationWrappertransmitObjectfolderName1 != null)
            {
                transmitObjectObject["FolderName1"] = ExpressionConverter.ConvertO(saveRelationWrappertransmitObjectfolderName1);
                transmitObjectObjectpropCount++;
            }

            if (saveRelationWrappertransmitObjectfolderName2 != null)
            {
                transmitObjectObject["FolderName2"] = ExpressionConverter.ConvertO(saveRelationWrappertransmitObjectfolderName2);
                transmitObjectObjectpropCount++;
            }

            transmitObjectObject["RelationType"] = "GENERAL";
            transmitObjectObjectpropCount++;
            if (transmitObjectObjectpropCount > 0)
            {
                saveRelationWrapper["transmitObject"] = transmitObjectObject;
                saveRelationWrapperpropCount++;
            }

            if (saveRelationWrapperpropCount > 0)
            {
                callPayload.Body = saveRelationWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesBooleanResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveTask([WorkflowExpression] Func<string> saveTaskWrappertransmitObjectbody = null, [WorkflowExpression] Func<bool> saveTaskWrappertransmitObjectisCompleted = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectdueDate = null, [WorkflowExpression] Func<double> saveTaskWrappertransmitObjectpercentCompleteDecimal = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectstartDate = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectsubject = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<int> saveTaskWrappertransmitObjectlevel = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectimportanceEn = null, [WorkflowExpression] Func<double> saveTaskWrappertransmitObjectactualWorkHours = null, [WorkflowExpression] Func<double> saveTaskWrappertransmitObjectestimatedWorkHours = null, [WorkflowExpression] Func<bool> saveTaskWrappertransmitObjectisReminderSet = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectreminderDate = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectcompletedDate = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectpicture = null, [WorkflowExpression] Func<int> saveTaskWrappertransmitObjectpictureWidth = null, [WorkflowExpression] Func<int> saveTaskWrappertransmitObjectpictureHeight = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectleadsTaskParentGuid = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectprojectsTaskParentGuid = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjecttasksTaskParentGuid = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectmarketingTaskParentGuid = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectcompaniesCompanyGuid = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectcontactsContactGuid = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectusersTaskDelegatorGuid = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectusersTaskSolverGuid = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjecttasksTaskOriginGuid = null, [WorkflowExpression] Func<bool> saveTaskWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> saveTaskWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> saveTaskWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> saveTaskWrapperdieOnItemConflict = null, [WorkflowExpression] Func<string[]> saveTaskWrapperignoredUserErrorMessages = null)
        {
            var apiCallPath = "/SaveTask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var saveTaskWrapper = new JObject();
            var saveTaskWrapperpropCount = 0;
            var transmitObjectObject = new JObject();
            var transmitObjectObjectpropCount = 0;
            if (saveTaskWrappertransmitObjectbody != null)
            {
                transmitObjectObject["Body"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectbody);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectisCompleted != null)
            {
                transmitObjectObject["IsCompleted"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectisCompleted);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectdueDate != null)
            {
                transmitObjectObject["DueDate"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectdueDate);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectpercentCompleteDecimal != null)
            {
                transmitObjectObject["PercentCompleteDecimal"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectpercentCompleteDecimal);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectstartDate != null)
            {
                transmitObjectObject["StartDate"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectstartDate);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectsubject != null)
            {
                transmitObjectObject["Subject"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectsubject);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectlevel != null)
            {
                transmitObjectObject["Level"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectlevel);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectimportanceEn != null)
            {
                transmitObjectObject["ImportanceEn"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectimportanceEn);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectactualWorkHours != null)
            {
                transmitObjectObject["ActualWorkHours"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectactualWorkHours);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectestimatedWorkHours != null)
            {
                transmitObjectObject["EstimatedWorkHours"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectestimatedWorkHours);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectisReminderSet != null)
            {
                transmitObjectObject["IsReminderSet"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectisReminderSet);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectreminderDate != null)
            {
                transmitObjectObject["ReminderDate"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectreminderDate);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectcompletedDate != null)
            {
                transmitObjectObject["CompletedDate"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectcompletedDate);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectpicture != null)
            {
                transmitObjectObject["Picture"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectpicture);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectpictureWidth != null)
            {
                transmitObjectObject["PictureWidth"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectpictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectpictureHeight != null)
            {
                transmitObjectObject["PictureHeight"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectpictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectleadsTaskParentGuid != null)
            {
                transmitObjectObject["Leads_TaskParentGuid"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectleadsTaskParentGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectprojectsTaskParentGuid != null)
            {
                transmitObjectObject["Projects_TaskParentGuid"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectprojectsTaskParentGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjecttasksTaskParentGuid != null)
            {
                transmitObjectObject["Tasks_TaskParentGuid"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjecttasksTaskParentGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectmarketingTaskParentGuid != null)
            {
                transmitObjectObject["Marketing_TaskParentGuid"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectmarketingTaskParentGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectcompaniesCompanyGuid != null)
            {
                transmitObjectObject["Companies_CompanyGuid"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectcompaniesCompanyGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectcontactsContactGuid != null)
            {
                transmitObjectObject["Contacts_ContactGuid"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectcontactsContactGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectusersTaskDelegatorGuid != null)
            {
                transmitObjectObject["Users_TaskDelegatorGuid"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectusersTaskDelegatorGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectusersTaskSolverGuid != null)
            {
                transmitObjectObject["Users_TaskSolverGuid"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectusersTaskSolverGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjecttasksTaskOriginGuid != null)
            {
                transmitObjectObject["Tasks_TaskOriginGuid"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjecttasksTaskOriginGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(saveTaskWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                saveTaskWrapper["transmitObject"] = transmitObjectObject;
                saveTaskWrapperpropCount++;
            }

            if (saveTaskWrapperdieOnItemConflict != null)
            {
                saveTaskWrapper["dieOnItemConflict"] = ExpressionConverter.ConvertO(saveTaskWrapperdieOnItemConflict);
                saveTaskWrapperpropCount++;
            }

            if (saveTaskWrapperignoredUserErrorMessages != null)
            {
                saveTaskWrapper["ignoredUserErrorMessages"] = ExpressionConverter.ConvertO(saveTaskWrapperignoredUserErrorMessages);
                saveTaskWrapperpropCount++;
            }

            if (saveTaskWrapperpropCount > 0)
            {
                callPayload.Body = saveTaskWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany> SearchCompanies([WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaccountNumber = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress1POBox = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress1Street = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress1City = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress1State = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress1CountryEn = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress1PostalCode = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress2POBox = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress2Street = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress2City = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress2State = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress2CountryEn = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress2PostalCode = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress3POBox = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress3Street = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress3City = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress3State = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress3CountryEn = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress3PostalCode = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectcompanyName = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectdepartment = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectemail = null, [WorkflowExpression] Func<int> searchCompaniesWrappertransmitObjectemployeesCount = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectfax = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectfirstContactEn = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectiCQ = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectidentificationNumber = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectimportanceEn = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectlineOfBusiness = null, [WorkflowExpression] Func<bool> searchCompaniesWrappertransmitObjectmailingListOther = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectmobile = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectmobileNormalized = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectmSN = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectnote = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectphone = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectphoneNormalized = null, [WorkflowExpression] Func<bool> searchCompaniesWrappertransmitObjectpurchaser = null, [WorkflowExpression] Func<double> searchCompaniesWrappertransmitObjectreversal = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectskype = null, [WorkflowExpression] Func<bool> searchCompaniesWrappertransmitObjectsuppliers = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectvATNumber = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectwebPage = null, [WorkflowExpression] Func<double> searchCompaniesWrappertransmitObjectadditionalDiscount = null, [WorkflowExpression] Func<int> searchCompaniesWrappertransmitObjectiD = null, [WorkflowExpression] Func<bool> searchCompaniesWrappertransmitObjectcompetitor = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectsalePriceGuid = null, [WorkflowExpression] Func<bool> searchCompaniesWrappertransmitObjectnotificationByEmail = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectnotificationBy = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectlastActivity = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectnextStep = null, [WorkflowExpression] Func<bool> searchCompaniesWrappertransmitObjectemailOptOut = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectpicture = null, [WorkflowExpression] Func<int> searchCompaniesWrappertransmitObjectpictureWidth = null, [WorkflowExpression] Func<int> searchCompaniesWrappertransmitObjectpictureHeight = null, [WorkflowExpression] Func<bool> searchCompaniesWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectserverItemCreated = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectserverItemChanged = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> searchCompaniesWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]> searchCompaniesWrappertransmitObjectrelations = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> searchCompaniesWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> searchCompaniesWrapperincludeRelations = null, [WorkflowExpression] Func<string> searchCompaniesWrapperrelationsFilterrelationType = null, [WorkflowExpression] Func<string> searchCompaniesWrapperrelationsFilterforeignFolderName = null, [WorkflowExpression] Func<string> searchCompaniesWrapperbinaryLogicalOperator = null)
        {
            var apiCallPath = "/SearchCompanies";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var searchCompaniesWrapper = new JObject();
            var searchCompaniesWrapperpropCount = 0;
            var transmitObjectObject = new JObject();
            var transmitObjectObjectpropCount = 0;
            if (searchCompaniesWrappertransmitObjectaccountNumber != null)
            {
                transmitObjectObject["AccountNumber"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectaccountNumber);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress1POBox != null)
            {
                transmitObjectObject["Address1POBox"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectaddress1POBox);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress1Street != null)
            {
                transmitObjectObject["Address1Street"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectaddress1Street);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress1City != null)
            {
                transmitObjectObject["Address1City"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectaddress1City);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress1State != null)
            {
                transmitObjectObject["Address1State"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectaddress1State);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress1CountryEn != null)
            {
                transmitObjectObject["Address1CountryEn"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectaddress1CountryEn);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress1PostalCode != null)
            {
                transmitObjectObject["Address1PostalCode"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectaddress1PostalCode);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress2POBox != null)
            {
                transmitObjectObject["Address2POBox"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectaddress2POBox);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress2Street != null)
            {
                transmitObjectObject["Address2Street"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectaddress2Street);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress2City != null)
            {
                transmitObjectObject["Address2City"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectaddress2City);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress2State != null)
            {
                transmitObjectObject["Address2State"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectaddress2State);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress2CountryEn != null)
            {
                transmitObjectObject["Address2CountryEn"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectaddress2CountryEn);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress2PostalCode != null)
            {
                transmitObjectObject["Address2PostalCode"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectaddress2PostalCode);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress3POBox != null)
            {
                transmitObjectObject["Address3POBox"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectaddress3POBox);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress3Street != null)
            {
                transmitObjectObject["Address3Street"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectaddress3Street);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress3City != null)
            {
                transmitObjectObject["Address3City"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectaddress3City);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress3State != null)
            {
                transmitObjectObject["Address3State"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectaddress3State);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress3CountryEn != null)
            {
                transmitObjectObject["Address3CountryEn"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectaddress3CountryEn);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress3PostalCode != null)
            {
                transmitObjectObject["Address3PostalCode"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectaddress3PostalCode);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectcompanyName != null)
            {
                transmitObjectObject["CompanyName"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectcompanyName);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectdepartment != null)
            {
                transmitObjectObject["Department"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectdepartment);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectemail != null)
            {
                transmitObjectObject["Email"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectemail);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectemployeesCount != null)
            {
                transmitObjectObject["EmployeesCount"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectemployeesCount);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectfax != null)
            {
                transmitObjectObject["Fax"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectfax);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectfirstContactEn != null)
            {
                transmitObjectObject["FirstContactEn"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectfirstContactEn);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectiCQ != null)
            {
                transmitObjectObject["ICQ"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectiCQ);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectidentificationNumber != null)
            {
                transmitObjectObject["IdentificationNumber"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectidentificationNumber);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectimportanceEn != null)
            {
                transmitObjectObject["ImportanceEn"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectimportanceEn);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectlineOfBusiness != null)
            {
                transmitObjectObject["LineOfBusiness"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectlineOfBusiness);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectmailingListOther != null)
            {
                transmitObjectObject["MailingListOther"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectmailingListOther);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectmobile != null)
            {
                transmitObjectObject["Mobile"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectmobile);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectmobileNormalized != null)
            {
                transmitObjectObject["MobileNormalized"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectmobileNormalized);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectmSN != null)
            {
                transmitObjectObject["MSN"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectmSN);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectnote != null)
            {
                transmitObjectObject["Note"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectnote);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectphone != null)
            {
                transmitObjectObject["Phone"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectphone);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectphoneNormalized != null)
            {
                transmitObjectObject["PhoneNormalized"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectphoneNormalized);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectpurchaser != null)
            {
                transmitObjectObject["Purchaser"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectpurchaser);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectreversal != null)
            {
                transmitObjectObject["Reversal"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectreversal);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectskype != null)
            {
                transmitObjectObject["Skype"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectskype);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectsuppliers != null)
            {
                transmitObjectObject["Suppliers"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectsuppliers);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectvATNumber != null)
            {
                transmitObjectObject["VATNumber"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectvATNumber);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectwebPage != null)
            {
                transmitObjectObject["WebPage"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectwebPage);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectadditionalDiscount != null)
            {
                transmitObjectObject["AdditionalDiscount"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectadditionalDiscount);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectiD != null)
            {
                transmitObjectObject["ID"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectiD);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectcompetitor != null)
            {
                transmitObjectObject["Competitor"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectcompetitor);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectsalePriceGuid != null)
            {
                transmitObjectObject["SalePriceGuid"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectsalePriceGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectnotificationByEmail != null)
            {
                transmitObjectObject["NotificationByEmail"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectnotificationByEmail);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectnotificationBy != null)
            {
                transmitObjectObject["NotificationBy"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectnotificationBy);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectlastActivity != null)
            {
                transmitObjectObject["LastActivity"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectlastActivity);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectnextStep != null)
            {
                transmitObjectObject["NextStep"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectnextStep);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectemailOptOut != null)
            {
                transmitObjectObject["EmailOptOut"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectemailOptOut);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectpicture != null)
            {
                transmitObjectObject["Picture"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectpicture);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectpictureWidth != null)
            {
                transmitObjectObject["PictureWidth"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectpictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectpictureHeight != null)
            {
                transmitObjectObject["PictureHeight"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectpictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectserverItemCreated != null)
            {
                transmitObjectObject["Server_ItemCreated"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectserverItemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectserverItemChanged != null)
            {
                transmitObjectObject["Server_ItemChanged"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectserverItemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectrelations != null)
            {
                transmitObjectObject["Relations"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectrelations);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(searchCompaniesWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                searchCompaniesWrapper["transmitObject"] = transmitObjectObject;
                searchCompaniesWrapperpropCount++;
            }

            if (searchCompaniesWrapperincludeRelations != null)
            {
                searchCompaniesWrapper["includeRelations"] = ExpressionConverter.ConvertO(searchCompaniesWrapperincludeRelations);
                searchCompaniesWrapperpropCount++;
            }

            var relationsFilterObject = new JObject();
            var relationsFilterObjectpropCount = 0;
            if (searchCompaniesWrapperrelationsFilterrelationType != null)
            {
                relationsFilterObject["RelationType"] = ExpressionConverter.ConvertO(searchCompaniesWrapperrelationsFilterrelationType);
                relationsFilterObjectpropCount++;
            }

            if (searchCompaniesWrapperrelationsFilterforeignFolderName != null)
            {
                relationsFilterObject["ForeignFolderName"] = ExpressionConverter.ConvertO(searchCompaniesWrapperrelationsFilterforeignFolderName);
                relationsFilterObjectpropCount++;
            }

            if (relationsFilterObjectpropCount > 0)
            {
                searchCompaniesWrapper["relationsFilter"] = relationsFilterObject;
                searchCompaniesWrapperpropCount++;
            }

            if (searchCompaniesWrapperbinaryLogicalOperator != null)
            {
                searchCompaniesWrapper["binaryLogicalOperator"] = ExpressionConverter.ConvertO(searchCompaniesWrapperbinaryLogicalOperator);
                searchCompaniesWrapperpropCount++;
            }

            if (searchCompaniesWrapperpropCount > 0)
            {
                callPayload.Body = searchCompaniesWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact> SearchContacts([WorkflowExpression] Func<string> searchContactsWrappertransmitObjectcompaniesCompanyGuid = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectbusinessAddressStreet = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectbusinessAddressCity = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectbusinessAddressState = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectbusinessAddressCountryEn = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectbusinessAddressPOBox = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectbusinessAddressPostalCode = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecthomeAddressStreet = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecthomeAddressCity = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecthomeAddressState = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecthomeAddressCountryEn = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecthomeAddressPOBox = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecthomeAddressPostalCode = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectotherAddressStreet = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectotherAddressCity = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectotherAddressState = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectotherAddressCountryEn = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectotherAddressPOBox = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectotherAddressPostalCode = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectcompany = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectemail1Address = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectemail2Address = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectemail3Address = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectfirstName = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectiCQ = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectimportanceEn = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectlastName = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectmiddleName = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectmSN = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectnote = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectprefixEn = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectsuffixEn = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectskype = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber1 = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber2 = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber3 = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber4 = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber5 = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber6 = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber1Normalized = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber2Normalized = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber3Normalized = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber4Normalized = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber5Normalized = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber6Normalized = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectdepartment = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttitle = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectwebPage = null, [WorkflowExpression] Func<bool> searchContactsWrappertransmitObjectdoNotSendNewsletter = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectprofilePicture = null, [WorkflowExpression] Func<int> searchContactsWrappertransmitObjectprofilePictureWidth = null, [WorkflowExpression] Func<int> searchContactsWrappertransmitObjectprofilePictureHeight = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectlastActivity = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectnextStep = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<bool> searchContactsWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectserverItemCreated = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectserverItemChanged = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> searchContactsWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]> searchContactsWrappertransmitObjectrelations = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> searchContactsWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> searchContactsWrapperincludeRelations = null, [WorkflowExpression] Func<string> searchContactsWrapperrelationsFilterrelationType = null, [WorkflowExpression] Func<string> searchContactsWrapperrelationsFilterforeignFolderName = null, [WorkflowExpression] Func<bool> searchContactsWrapperincludeProfilePictures = null, [WorkflowExpression] Func<string> searchContactsWrapperbinaryLogicalOperator = null)
        {
            var apiCallPath = "/SearchContacts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var searchContactsWrapper = new JObject();
            var searchContactsWrapperpropCount = 0;
            var transmitObjectObject = new JObject();
            var transmitObjectObjectpropCount = 0;
            if (searchContactsWrappertransmitObjectcompaniesCompanyGuid != null)
            {
                transmitObjectObject["Companies_CompanyGuid"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectcompaniesCompanyGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectbusinessAddressStreet != null)
            {
                transmitObjectObject["BusinessAddressStreet"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectbusinessAddressStreet);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectbusinessAddressCity != null)
            {
                transmitObjectObject["BusinessAddressCity"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectbusinessAddressCity);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectbusinessAddressState != null)
            {
                transmitObjectObject["BusinessAddressState"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectbusinessAddressState);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectbusinessAddressCountryEn != null)
            {
                transmitObjectObject["BusinessAddressCountryEn"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectbusinessAddressCountryEn);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectbusinessAddressPOBox != null)
            {
                transmitObjectObject["BusinessAddressPOBox"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectbusinessAddressPOBox);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectbusinessAddressPostalCode != null)
            {
                transmitObjectObject["BusinessAddressPostalCode"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectbusinessAddressPostalCode);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecthomeAddressStreet != null)
            {
                transmitObjectObject["HomeAddressStreet"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjecthomeAddressStreet);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecthomeAddressCity != null)
            {
                transmitObjectObject["HomeAddressCity"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjecthomeAddressCity);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecthomeAddressState != null)
            {
                transmitObjectObject["HomeAddressState"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjecthomeAddressState);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecthomeAddressCountryEn != null)
            {
                transmitObjectObject["HomeAddressCountryEn"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjecthomeAddressCountryEn);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecthomeAddressPOBox != null)
            {
                transmitObjectObject["HomeAddressPOBox"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjecthomeAddressPOBox);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecthomeAddressPostalCode != null)
            {
                transmitObjectObject["HomeAddressPostalCode"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjecthomeAddressPostalCode);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectotherAddressStreet != null)
            {
                transmitObjectObject["OtherAddressStreet"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectotherAddressStreet);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectotherAddressCity != null)
            {
                transmitObjectObject["OtherAddressCity"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectotherAddressCity);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectotherAddressState != null)
            {
                transmitObjectObject["OtherAddressState"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectotherAddressState);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectotherAddressCountryEn != null)
            {
                transmitObjectObject["OtherAddressCountryEn"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectotherAddressCountryEn);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectotherAddressPOBox != null)
            {
                transmitObjectObject["OtherAddressPOBox"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectotherAddressPOBox);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectotherAddressPostalCode != null)
            {
                transmitObjectObject["OtherAddressPostalCode"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectotherAddressPostalCode);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectcompany != null)
            {
                transmitObjectObject["Company"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectcompany);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectemail1Address != null)
            {
                transmitObjectObject["Email1Address"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectemail1Address);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectemail2Address != null)
            {
                transmitObjectObject["Email2Address"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectemail2Address);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectemail3Address != null)
            {
                transmitObjectObject["Email3Address"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectemail3Address);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectfirstName != null)
            {
                transmitObjectObject["FirstName"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectfirstName);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectiCQ != null)
            {
                transmitObjectObject["ICQ"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectiCQ);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectimportanceEn != null)
            {
                transmitObjectObject["ImportanceEn"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectimportanceEn);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectlastName != null)
            {
                transmitObjectObject["LastName"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectlastName);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectmiddleName != null)
            {
                transmitObjectObject["MiddleName"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectmiddleName);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectmSN != null)
            {
                transmitObjectObject["MSN"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectmSN);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectnote != null)
            {
                transmitObjectObject["Note"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectnote);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectprefixEn != null)
            {
                transmitObjectObject["PrefixEn"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectprefixEn);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectsuffixEn != null)
            {
                transmitObjectObject["SuffixEn"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectsuffixEn);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectskype != null)
            {
                transmitObjectObject["Skype"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectskype);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber1 != null)
            {
                transmitObjectObject["TelephoneNumber1"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjecttelephoneNumber1);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber2 != null)
            {
                transmitObjectObject["TelephoneNumber2"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjecttelephoneNumber2);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber3 != null)
            {
                transmitObjectObject["TelephoneNumber3"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjecttelephoneNumber3);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber4 != null)
            {
                transmitObjectObject["TelephoneNumber4"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjecttelephoneNumber4);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber5 != null)
            {
                transmitObjectObject["TelephoneNumber5"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjecttelephoneNumber5);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber6 != null)
            {
                transmitObjectObject["TelephoneNumber6"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjecttelephoneNumber6);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber1Normalized != null)
            {
                transmitObjectObject["TelephoneNumber1Normalized"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjecttelephoneNumber1Normalized);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber2Normalized != null)
            {
                transmitObjectObject["TelephoneNumber2Normalized"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjecttelephoneNumber2Normalized);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber3Normalized != null)
            {
                transmitObjectObject["TelephoneNumber3Normalized"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjecttelephoneNumber3Normalized);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber4Normalized != null)
            {
                transmitObjectObject["TelephoneNumber4Normalized"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjecttelephoneNumber4Normalized);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber5Normalized != null)
            {
                transmitObjectObject["TelephoneNumber5Normalized"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjecttelephoneNumber5Normalized);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber6Normalized != null)
            {
                transmitObjectObject["TelephoneNumber6Normalized"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjecttelephoneNumber6Normalized);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectdepartment != null)
            {
                transmitObjectObject["Department"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectdepartment);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttitle != null)
            {
                transmitObjectObject["Title"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjecttitle);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectwebPage != null)
            {
                transmitObjectObject["WebPage"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectwebPage);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectdoNotSendNewsletter != null)
            {
                transmitObjectObject["DoNotSendNewsletter"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectdoNotSendNewsletter);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectprofilePicture != null)
            {
                transmitObjectObject["ProfilePicture"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectprofilePicture);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectprofilePictureWidth != null)
            {
                transmitObjectObject["ProfilePictureWidth"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectprofilePictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectprofilePictureHeight != null)
            {
                transmitObjectObject["ProfilePictureHeight"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectprofilePictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectlastActivity != null)
            {
                transmitObjectObject["LastActivity"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectlastActivity);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectnextStep != null)
            {
                transmitObjectObject["NextStep"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectnextStep);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectserverItemCreated != null)
            {
                transmitObjectObject["Server_ItemCreated"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectserverItemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectserverItemChanged != null)
            {
                transmitObjectObject["Server_ItemChanged"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectserverItemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectrelations != null)
            {
                transmitObjectObject["Relations"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectrelations);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(searchContactsWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                searchContactsWrapper["transmitObject"] = transmitObjectObject;
                searchContactsWrapperpropCount++;
            }

            if (searchContactsWrapperincludeRelations != null)
            {
                searchContactsWrapper["includeRelations"] = ExpressionConverter.ConvertO(searchContactsWrapperincludeRelations);
                searchContactsWrapperpropCount++;
            }

            var relationsFilterObject = new JObject();
            var relationsFilterObjectpropCount = 0;
            if (searchContactsWrapperrelationsFilterrelationType != null)
            {
                relationsFilterObject["RelationType"] = ExpressionConverter.ConvertO(searchContactsWrapperrelationsFilterrelationType);
                relationsFilterObjectpropCount++;
            }

            if (searchContactsWrapperrelationsFilterforeignFolderName != null)
            {
                relationsFilterObject["ForeignFolderName"] = ExpressionConverter.ConvertO(searchContactsWrapperrelationsFilterforeignFolderName);
                relationsFilterObjectpropCount++;
            }

            if (relationsFilterObjectpropCount > 0)
            {
                searchContactsWrapper["relationsFilter"] = relationsFilterObject;
                searchContactsWrapperpropCount++;
            }

            if (searchContactsWrapperincludeProfilePictures != null)
            {
                searchContactsWrapper["includeProfilePictures"] = ExpressionConverter.ConvertO(searchContactsWrapperincludeProfilePictures);
                searchContactsWrapperpropCount++;
            }

            if (searchContactsWrapperbinaryLogicalOperator != null)
            {
                searchContactsWrapper["binaryLogicalOperator"] = ExpressionConverter.ConvertO(searchContactsWrapperbinaryLogicalOperator);
                searchContactsWrapperpropCount++;
            }

            if (searchContactsWrapperpropCount > 0)
            {
                callPayload.Body = searchContactsWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal> SearchJournals([WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectmarketingSuperiorItemGuid = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectcompaniesCompanyGuid = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectcontactsContactGuid = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectleadsSuperiorItemGuid = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectprojectsSuperiorItemGuid = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectmarketingMarketingGuid = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectcalendarEntryID = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectcalendarORIGIN = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectchangedField = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjecteventEnd = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjecteventStart = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectfieldValue = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectimportanceEn = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectnote = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectprevFieldValue = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<bool> searchJournalsWrappertransmitObjectisSystem = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectphone = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectphoneNormalized = null, [WorkflowExpression] Func<bool> searchJournalsWrappertransmitObjectisGdprRelevant = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectpicture = null, [WorkflowExpression] Func<int> searchJournalsWrappertransmitObjectpictureWidth = null, [WorkflowExpression] Func<int> searchJournalsWrappertransmitObjectpictureHeight = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<bool> searchJournalsWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectserverItemCreated = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectserverItemChanged = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> searchJournalsWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]> searchJournalsWrappertransmitObjectrelations = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> searchJournalsWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> searchJournalsWrapperincludeRelations = null, [WorkflowExpression] Func<string> searchJournalsWrapperrelationsFilterrelationType = null, [WorkflowExpression] Func<string> searchJournalsWrapperrelationsFilterforeignFolderName = null, [WorkflowExpression] Func<string> searchJournalsWrapperbinaryLogicalOperator = null)
        {
            var apiCallPath = "/SearchJournals";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var searchJournalsWrapper = new JObject();
            var searchJournalsWrapperpropCount = 0;
            var transmitObjectObject = new JObject();
            var transmitObjectObjectpropCount = 0;
            if (searchJournalsWrappertransmitObjectmarketingSuperiorItemGuid != null)
            {
                transmitObjectObject["Marketing_SuperiorItemGuid"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectmarketingSuperiorItemGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectcompaniesCompanyGuid != null)
            {
                transmitObjectObject["Companies_CompanyGuid"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectcompaniesCompanyGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectcontactsContactGuid != null)
            {
                transmitObjectObject["Contacts_ContactGuid"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectcontactsContactGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectleadsSuperiorItemGuid != null)
            {
                transmitObjectObject["Leads_SuperiorItemGuid"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectleadsSuperiorItemGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectprojectsSuperiorItemGuid != null)
            {
                transmitObjectObject["Projects_SuperiorItemGuid"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectprojectsSuperiorItemGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectmarketingMarketingGuid != null)
            {
                transmitObjectObject["Marketing_MarketingGuid"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectmarketingMarketingGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectcalendarEntryID != null)
            {
                transmitObjectObject["CalendarEntryID"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectcalendarEntryID);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectcalendarORIGIN != null)
            {
                transmitObjectObject["Calendar_ORIGIN"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectcalendarORIGIN);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectchangedField != null)
            {
                transmitObjectObject["ChangedField"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectchangedField);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjecteventEnd != null)
            {
                transmitObjectObject["EventEnd"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjecteventEnd);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjecteventStart != null)
            {
                transmitObjectObject["EventStart"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjecteventStart);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectfieldValue != null)
            {
                transmitObjectObject["FieldValue"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectfieldValue);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectimportanceEn != null)
            {
                transmitObjectObject["ImportanceEn"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectimportanceEn);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectnote != null)
            {
                transmitObjectObject["Note"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectnote);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectprevFieldValue != null)
            {
                transmitObjectObject["PrevFieldValue"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectprevFieldValue);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectisSystem != null)
            {
                transmitObjectObject["IsSystem"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectisSystem);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectphone != null)
            {
                transmitObjectObject["Phone"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectphone);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectphoneNormalized != null)
            {
                transmitObjectObject["PhoneNormalized"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectphoneNormalized);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectisGdprRelevant != null)
            {
                transmitObjectObject["IsGdprRelevant"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectisGdprRelevant);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectpicture != null)
            {
                transmitObjectObject["Picture"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectpicture);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectpictureWidth != null)
            {
                transmitObjectObject["PictureWidth"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectpictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectpictureHeight != null)
            {
                transmitObjectObject["PictureHeight"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectpictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectserverItemCreated != null)
            {
                transmitObjectObject["Server_ItemCreated"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectserverItemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectserverItemChanged != null)
            {
                transmitObjectObject["Server_ItemChanged"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectserverItemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectrelations != null)
            {
                transmitObjectObject["Relations"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectrelations);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(searchJournalsWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                searchJournalsWrapper["transmitObject"] = transmitObjectObject;
                searchJournalsWrapperpropCount++;
            }

            if (searchJournalsWrapperincludeRelations != null)
            {
                searchJournalsWrapper["includeRelations"] = ExpressionConverter.ConvertO(searchJournalsWrapperincludeRelations);
                searchJournalsWrapperpropCount++;
            }

            var relationsFilterObject = new JObject();
            var relationsFilterObjectpropCount = 0;
            if (searchJournalsWrapperrelationsFilterrelationType != null)
            {
                relationsFilterObject["RelationType"] = ExpressionConverter.ConvertO(searchJournalsWrapperrelationsFilterrelationType);
                relationsFilterObjectpropCount++;
            }

            if (searchJournalsWrapperrelationsFilterforeignFolderName != null)
            {
                relationsFilterObject["ForeignFolderName"] = ExpressionConverter.ConvertO(searchJournalsWrapperrelationsFilterforeignFolderName);
                relationsFilterObjectpropCount++;
            }

            if (relationsFilterObjectpropCount > 0)
            {
                searchJournalsWrapper["relationsFilter"] = relationsFilterObject;
                searchJournalsWrapperpropCount++;
            }

            if (searchJournalsWrapperbinaryLogicalOperator != null)
            {
                searchJournalsWrapper["binaryLogicalOperator"] = ExpressionConverter.ConvertO(searchJournalsWrapperbinaryLogicalOperator);
                searchJournalsWrapperpropCount++;
            }

            if (searchJournalsWrapperpropCount > 0)
            {
                callPayload.Body = searchJournalsWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead> SearchLeads([WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectcompaniesCustomerGuid = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectcontactsContactPersonGuid = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectmarketingMarketingGuid = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectcity = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectcontactPerson = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectcurrencyEn = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectcustomer = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectemail = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectestimatedEnd = null, [WorkflowExpression] Func<int> searchLeadsWrappertransmitObjecthID = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectleadOriginEn = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectnote = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectphone = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectphoneNormalized = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<double> searchLeadsWrappertransmitObjectprice = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectpriceChanged = null, [WorkflowExpression] Func<double> searchLeadsWrappertransmitObjectpriceDefaultCurrency = null, [WorkflowExpression] Func<double> searchLeadsWrappertransmitObjectprobability = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectreceiveDate = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectstreet = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectzip = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectlastActivity = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectnextStep = null, [WorkflowExpression] Func<double> searchLeadsWrappertransmitObjectestimatedValue = null, [WorkflowExpression] Func<bool> searchLeadsWrappertransmitObjectisCompleted = null, [WorkflowExpression] Func<bool> searchLeadsWrappertransmitObjectisLost = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectcountryEn = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectstate = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectpOBox = null, [WorkflowExpression] Func<bool> searchLeadsWrappertransmitObjectemailOptOut = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectpicture = null, [WorkflowExpression] Func<int> searchLeadsWrappertransmitObjectpictureWidth = null, [WorkflowExpression] Func<int> searchLeadsWrappertransmitObjectpictureHeight = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectcompletedDate = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectlostDate = null, [WorkflowExpression] Func<bool> searchLeadsWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectserverItemCreated = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectserverItemChanged = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> searchLeadsWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]> searchLeadsWrappertransmitObjectrelations = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> searchLeadsWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> searchLeadsWrapperincludeRelations = null, [WorkflowExpression] Func<string> searchLeadsWrapperrelationsFilterrelationType = null, [WorkflowExpression] Func<string> searchLeadsWrapperrelationsFilterforeignFolderName = null, [WorkflowExpression] Func<string> searchLeadsWrapperbinaryLogicalOperator = null)
        {
            var apiCallPath = "/SearchLeads";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var searchLeadsWrapper = new JObject();
            var searchLeadsWrapperpropCount = 0;
            var transmitObjectObject = new JObject();
            var transmitObjectObjectpropCount = 0;
            if (searchLeadsWrappertransmitObjectcompaniesCustomerGuid != null)
            {
                transmitObjectObject["Companies_CustomerGuid"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectcompaniesCustomerGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectcontactsContactPersonGuid != null)
            {
                transmitObjectObject["Contacts_ContactPersonGuid"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectcontactsContactPersonGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectmarketingMarketingGuid != null)
            {
                transmitObjectObject["Marketing_MarketingGuid"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectmarketingMarketingGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectcity != null)
            {
                transmitObjectObject["City"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectcity);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectcontactPerson != null)
            {
                transmitObjectObject["ContactPerson"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectcontactPerson);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectcurrencyEn != null)
            {
                transmitObjectObject["CurrencyEn"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectcurrencyEn);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectcustomer != null)
            {
                transmitObjectObject["Customer"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectcustomer);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectemail != null)
            {
                transmitObjectObject["Email"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectemail);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectestimatedEnd != null)
            {
                transmitObjectObject["EstimatedEnd"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectestimatedEnd);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjecthID != null)
            {
                transmitObjectObject["HID"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjecthID);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectleadOriginEn != null)
            {
                transmitObjectObject["LeadOriginEn"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectleadOriginEn);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectnote != null)
            {
                transmitObjectObject["Note"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectnote);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectphone != null)
            {
                transmitObjectObject["Phone"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectphone);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectphoneNormalized != null)
            {
                transmitObjectObject["PhoneNormalized"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectphoneNormalized);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectprice != null)
            {
                transmitObjectObject["Price"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectprice);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectpriceChanged != null)
            {
                transmitObjectObject["PriceChanged"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectpriceChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectpriceDefaultCurrency != null)
            {
                transmitObjectObject["PriceDefaultCurrency"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectpriceDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectprobability != null)
            {
                transmitObjectObject["Probability"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectprobability);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectreceiveDate != null)
            {
                transmitObjectObject["ReceiveDate"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectreceiveDate);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectstreet != null)
            {
                transmitObjectObject["Street"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectstreet);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectzip != null)
            {
                transmitObjectObject["Zip"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectzip);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectlastActivity != null)
            {
                transmitObjectObject["LastActivity"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectlastActivity);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectnextStep != null)
            {
                transmitObjectObject["NextStep"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectnextStep);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectestimatedValue != null)
            {
                transmitObjectObject["EstimatedValue"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectestimatedValue);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectisCompleted != null)
            {
                transmitObjectObject["IsCompleted"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectisCompleted);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectisLost != null)
            {
                transmitObjectObject["IsLost"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectisLost);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectcountryEn != null)
            {
                transmitObjectObject["CountryEn"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectcountryEn);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectstate != null)
            {
                transmitObjectObject["State"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectstate);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectpOBox != null)
            {
                transmitObjectObject["POBox"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectpOBox);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectemailOptOut != null)
            {
                transmitObjectObject["EmailOptOut"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectemailOptOut);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectpicture != null)
            {
                transmitObjectObject["Picture"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectpicture);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectpictureWidth != null)
            {
                transmitObjectObject["PictureWidth"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectpictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectpictureHeight != null)
            {
                transmitObjectObject["PictureHeight"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectpictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectcompletedDate != null)
            {
                transmitObjectObject["CompletedDate"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectcompletedDate);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectlostDate != null)
            {
                transmitObjectObject["LostDate"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectlostDate);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectserverItemCreated != null)
            {
                transmitObjectObject["Server_ItemCreated"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectserverItemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectserverItemChanged != null)
            {
                transmitObjectObject["Server_ItemChanged"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectserverItemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectrelations != null)
            {
                transmitObjectObject["Relations"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectrelations);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(searchLeadsWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                searchLeadsWrapper["transmitObject"] = transmitObjectObject;
                searchLeadsWrapperpropCount++;
            }

            if (searchLeadsWrapperincludeRelations != null)
            {
                searchLeadsWrapper["includeRelations"] = ExpressionConverter.ConvertO(searchLeadsWrapperincludeRelations);
                searchLeadsWrapperpropCount++;
            }

            var relationsFilterObject = new JObject();
            var relationsFilterObjectpropCount = 0;
            if (searchLeadsWrapperrelationsFilterrelationType != null)
            {
                relationsFilterObject["RelationType"] = ExpressionConverter.ConvertO(searchLeadsWrapperrelationsFilterrelationType);
                relationsFilterObjectpropCount++;
            }

            if (searchLeadsWrapperrelationsFilterforeignFolderName != null)
            {
                relationsFilterObject["ForeignFolderName"] = ExpressionConverter.ConvertO(searchLeadsWrapperrelationsFilterforeignFolderName);
                relationsFilterObjectpropCount++;
            }

            if (relationsFilterObjectpropCount > 0)
            {
                searchLeadsWrapper["relationsFilter"] = relationsFilterObject;
                searchLeadsWrapperpropCount++;
            }

            if (searchLeadsWrapperbinaryLogicalOperator != null)
            {
                searchLeadsWrapper["binaryLogicalOperator"] = ExpressionConverter.ConvertO(searchLeadsWrapperbinaryLogicalOperator);
                searchLeadsWrapperpropCount++;
            }

            if (searchLeadsWrapperpropCount > 0)
            {
                callPayload.Body = searchLeadsWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject> SearchProjects([WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectcompaniesCustomerGuid = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectcontactsContactPersonGuid = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectleadsProjectOriginGuid = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectprojectsSuperiorProjectGuid = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectusersSupervisorGuid = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectnote = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectprice = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectprojectEnd = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectprojectName = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectpeopleExpenses = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectprojectRealEnd = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectestimatedPrice = null, [WorkflowExpression] Func<int> searchProjectsWrappertransmitObjecthID = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectprojectOriginEn = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectpaymentTypeEn = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectotherExpenses = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectmargin = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectprofit = null, [WorkflowExpression] Func<int> searchProjectsWrappertransmitObjectpaymentMaturity = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectinvoicePaymentDate = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectinvoiceIssueDate = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectestimatedMargin = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectestimatedProfit = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectestimatedPeopleExpenses = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectestimatedOtherExpenses = null, [WorkflowExpression] Func<int> searchProjectsWrappertransmitObjectlicensesCount = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectlicensePrice = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<bool> searchProjectsWrappertransmitObjectshowInCaplan = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectprojectStart = null, [WorkflowExpression] Func<int> searchProjectsWrappertransmitObjectestimatedWorkHours = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjecttotalWorkHours = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectestimatedOtherExpensesDefaultCurrency = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectestimatedPriceDefaultCurrency = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectpeopleExpensesDefaultCurrency = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectotherExpensesDefaultCurrency = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectpriceDefaultCurrency = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectprofitDefaultCurrency = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectestimatedProfitDefaultCurrency = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectcurrencyEn = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectestimatedPeopleExpensesChanged = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectestimatedOtherExpensesChanged = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectotherExpensesChanged = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectestimatedPriceChanged = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectpriceChanged = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectlicensePriceChanged = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectlicensePriceDefaultCurrency = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectlastActivity = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectnextStep = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectcompletedDate = null, [WorkflowExpression] Func<bool> searchProjectsWrappertransmitObjectisCompleted = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectlostDate = null, [WorkflowExpression] Func<bool> searchProjectsWrappertransmitObjectisLost = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectpeopleExpensesChanged = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectpicture = null, [WorkflowExpression] Func<int> searchProjectsWrappertransmitObjectpictureWidth = null, [WorkflowExpression] Func<int> searchProjectsWrappertransmitObjectpictureHeight = null, [WorkflowExpression] Func<bool> searchProjectsWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectserverItemCreated = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectserverItemChanged = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> searchProjectsWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]> searchProjectsWrappertransmitObjectrelations = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> searchProjectsWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> searchProjectsWrapperincludeRelations = null, [WorkflowExpression] Func<string> searchProjectsWrapperrelationsFilterrelationType = null, [WorkflowExpression] Func<string> searchProjectsWrapperrelationsFilterforeignFolderName = null, [WorkflowExpression] Func<string> searchProjectsWrapperbinaryLogicalOperator = null)
        {
            var apiCallPath = "/SearchProjects";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var searchProjectsWrapper = new JObject();
            var searchProjectsWrapperpropCount = 0;
            var transmitObjectObject = new JObject();
            var transmitObjectObjectpropCount = 0;
            if (searchProjectsWrappertransmitObjectcompaniesCustomerGuid != null)
            {
                transmitObjectObject["Companies_CustomerGuid"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectcompaniesCustomerGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectcontactsContactPersonGuid != null)
            {
                transmitObjectObject["Contacts_ContactPersonGuid"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectcontactsContactPersonGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectleadsProjectOriginGuid != null)
            {
                transmitObjectObject["Leads_Project_OriginGuid"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectleadsProjectOriginGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectprojectsSuperiorProjectGuid != null)
            {
                transmitObjectObject["Projects_SuperiorProjectGuid"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectprojectsSuperiorProjectGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectusersSupervisorGuid != null)
            {
                transmitObjectObject["Users_SupervisorGuid"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectusersSupervisorGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectnote != null)
            {
                transmitObjectObject["Note"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectnote);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectprice != null)
            {
                transmitObjectObject["Price"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectprice);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectprojectEnd != null)
            {
                transmitObjectObject["ProjectEnd"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectprojectEnd);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectprojectName != null)
            {
                transmitObjectObject["ProjectName"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectprojectName);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectpeopleExpenses != null)
            {
                transmitObjectObject["PeopleExpenses"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectpeopleExpenses);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectprojectRealEnd != null)
            {
                transmitObjectObject["ProjectRealEnd"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectprojectRealEnd);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedPrice != null)
            {
                transmitObjectObject["EstimatedPrice"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectestimatedPrice);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjecthID != null)
            {
                transmitObjectObject["HID"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjecthID);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectprojectOriginEn != null)
            {
                transmitObjectObject["ProjectOriginEn"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectprojectOriginEn);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectpaymentTypeEn != null)
            {
                transmitObjectObject["PaymentTypeEn"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectpaymentTypeEn);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectotherExpenses != null)
            {
                transmitObjectObject["OtherExpenses"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectotherExpenses);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectmargin != null)
            {
                transmitObjectObject["Margin"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectmargin);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectprofit != null)
            {
                transmitObjectObject["Profit"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectprofit);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectpaymentMaturity != null)
            {
                transmitObjectObject["PaymentMaturity"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectpaymentMaturity);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectinvoicePaymentDate != null)
            {
                transmitObjectObject["InvoicePaymentDate"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectinvoicePaymentDate);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectinvoiceIssueDate != null)
            {
                transmitObjectObject["InvoiceIssueDate"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectinvoiceIssueDate);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedMargin != null)
            {
                transmitObjectObject["EstimatedMargin"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectestimatedMargin);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedProfit != null)
            {
                transmitObjectObject["EstimatedProfit"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectestimatedProfit);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedPeopleExpenses != null)
            {
                transmitObjectObject["EstimatedPeopleExpenses"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectestimatedPeopleExpenses);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedOtherExpenses != null)
            {
                transmitObjectObject["EstimatedOtherExpenses"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectestimatedOtherExpenses);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectlicensesCount != null)
            {
                transmitObjectObject["LicensesCount"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectlicensesCount);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectlicensePrice != null)
            {
                transmitObjectObject["LicensePrice"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectlicensePrice);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectshowInCaplan != null)
            {
                transmitObjectObject["ShowInCaplan"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectshowInCaplan);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectprojectStart != null)
            {
                transmitObjectObject["ProjectStart"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectprojectStart);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedWorkHours != null)
            {
                transmitObjectObject["EstimatedWorkHours"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectestimatedWorkHours);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjecttotalWorkHours != null)
            {
                transmitObjectObject["TotalWorkHours"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjecttotalWorkHours);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency != null)
            {
                transmitObjectObject["EstimatedPeopleExpensesDefaultCurrency"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedOtherExpensesDefaultCurrency != null)
            {
                transmitObjectObject["EstimatedOtherExpensesDefaultCurrency"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectestimatedOtherExpensesDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedPriceDefaultCurrency != null)
            {
                transmitObjectObject["EstimatedPriceDefaultCurrency"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectestimatedPriceDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectpeopleExpensesDefaultCurrency != null)
            {
                transmitObjectObject["PeopleExpensesDefaultCurrency"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectpeopleExpensesDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectotherExpensesDefaultCurrency != null)
            {
                transmitObjectObject["OtherExpensesDefaultCurrency"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectotherExpensesDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectpriceDefaultCurrency != null)
            {
                transmitObjectObject["PriceDefaultCurrency"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectpriceDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectprofitDefaultCurrency != null)
            {
                transmitObjectObject["ProfitDefaultCurrency"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectprofitDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedProfitDefaultCurrency != null)
            {
                transmitObjectObject["EstimatedProfitDefaultCurrency"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectestimatedProfitDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectcurrencyEn != null)
            {
                transmitObjectObject["CurrencyEn"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectcurrencyEn);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedPeopleExpensesChanged != null)
            {
                transmitObjectObject["EstimatedPeopleExpensesChanged"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectestimatedPeopleExpensesChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedOtherExpensesChanged != null)
            {
                transmitObjectObject["EstimatedOtherExpensesChanged"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectestimatedOtherExpensesChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectotherExpensesChanged != null)
            {
                transmitObjectObject["OtherExpensesChanged"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectotherExpensesChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedPriceChanged != null)
            {
                transmitObjectObject["EstimatedPriceChanged"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectestimatedPriceChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectpriceChanged != null)
            {
                transmitObjectObject["PriceChanged"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectpriceChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectlicensePriceChanged != null)
            {
                transmitObjectObject["LicensePriceChanged"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectlicensePriceChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectlicensePriceDefaultCurrency != null)
            {
                transmitObjectObject["LicensePriceDefaultCurrency"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectlicensePriceDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectlastActivity != null)
            {
                transmitObjectObject["LastActivity"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectlastActivity);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectnextStep != null)
            {
                transmitObjectObject["NextStep"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectnextStep);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectcompletedDate != null)
            {
                transmitObjectObject["CompletedDate"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectcompletedDate);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectisCompleted != null)
            {
                transmitObjectObject["IsCompleted"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectisCompleted);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectlostDate != null)
            {
                transmitObjectObject["LostDate"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectlostDate);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectisLost != null)
            {
                transmitObjectObject["IsLost"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectisLost);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectpeopleExpensesChanged != null)
            {
                transmitObjectObject["PeopleExpensesChanged"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectpeopleExpensesChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectpicture != null)
            {
                transmitObjectObject["Picture"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectpicture);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectpictureWidth != null)
            {
                transmitObjectObject["PictureWidth"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectpictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectpictureHeight != null)
            {
                transmitObjectObject["PictureHeight"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectpictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectserverItemCreated != null)
            {
                transmitObjectObject["Server_ItemCreated"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectserverItemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectserverItemChanged != null)
            {
                transmitObjectObject["Server_ItemChanged"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectserverItemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectrelations != null)
            {
                transmitObjectObject["Relations"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectrelations);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(searchProjectsWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                searchProjectsWrapper["transmitObject"] = transmitObjectObject;
                searchProjectsWrapperpropCount++;
            }

            if (searchProjectsWrapperincludeRelations != null)
            {
                searchProjectsWrapper["includeRelations"] = ExpressionConverter.ConvertO(searchProjectsWrapperincludeRelations);
                searchProjectsWrapperpropCount++;
            }

            var relationsFilterObject = new JObject();
            var relationsFilterObjectpropCount = 0;
            if (searchProjectsWrapperrelationsFilterrelationType != null)
            {
                relationsFilterObject["RelationType"] = ExpressionConverter.ConvertO(searchProjectsWrapperrelationsFilterrelationType);
                relationsFilterObjectpropCount++;
            }

            if (searchProjectsWrapperrelationsFilterforeignFolderName != null)
            {
                relationsFilterObject["ForeignFolderName"] = ExpressionConverter.ConvertO(searchProjectsWrapperrelationsFilterforeignFolderName);
                relationsFilterObjectpropCount++;
            }

            if (relationsFilterObjectpropCount > 0)
            {
                searchProjectsWrapper["relationsFilter"] = relationsFilterObject;
                searchProjectsWrapperpropCount++;
            }

            if (searchProjectsWrapperbinaryLogicalOperator != null)
            {
                searchProjectsWrapper["binaryLogicalOperator"] = ExpressionConverter.ConvertO(searchProjectsWrapperbinaryLogicalOperator);
                searchProjectsWrapperpropCount++;
            }

            if (searchProjectsWrapperpropCount > 0)
            {
                callPayload.Body = searchProjectsWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask> SearchTasks([WorkflowExpression] Func<string> searchTasksWrappertransmitObjectleadsTopLevelProjectGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectleadsTaskParentGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectprojectsTopLevelProjectGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectprojectsTaskParentGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjecttasksTaskParentGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectmarketingTopLevelProjectGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectmarketingTaskParentGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectcompaniesCompanyGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectcontactsContactGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectusersTaskDelegatorGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectusersTaskSolverGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjecttasksTaskOriginGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectbody = null, [WorkflowExpression] Func<bool> searchTasksWrappertransmitObjectisCompleted = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectdueDate = null, [WorkflowExpression] Func<double> searchTasksWrappertransmitObjectpercentCompleteDecimal = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectstartDate = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectsubject = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<int> searchTasksWrappertransmitObjectlevel = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectimportanceEn = null, [WorkflowExpression] Func<double> searchTasksWrappertransmitObjectactualWorkHours = null, [WorkflowExpression] Func<double> searchTasksWrappertransmitObjectestimatedWorkHours = null, [WorkflowExpression] Func<bool> searchTasksWrappertransmitObjectisReminderSet = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectreminderDate = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectcompletedDate = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectpicture = null, [WorkflowExpression] Func<int> searchTasksWrappertransmitObjectpictureWidth = null, [WorkflowExpression] Func<int> searchTasksWrappertransmitObjectpictureHeight = null, [WorkflowExpression] Func<bool> searchTasksWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectserverItemCreated = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectserverItemChanged = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> searchTasksWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]> searchTasksWrappertransmitObjectrelations = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> searchTasksWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> searchTasksWrapperincludeRelations = null, [WorkflowExpression] Func<string> searchTasksWrapperrelationsFilterrelationType = null, [WorkflowExpression] Func<string> searchTasksWrapperrelationsFilterforeignFolderName = null, [WorkflowExpression] Func<string> searchTasksWrapperbinaryLogicalOperator = null)
        {
            var apiCallPath = "/SearchTasks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var searchTasksWrapper = new JObject();
            var searchTasksWrapperpropCount = 0;
            var transmitObjectObject = new JObject();
            var transmitObjectObjectpropCount = 0;
            if (searchTasksWrappertransmitObjectleadsTopLevelProjectGuid != null)
            {
                transmitObjectObject["Leads_TopLevelProjectGuid"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectleadsTopLevelProjectGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectleadsTaskParentGuid != null)
            {
                transmitObjectObject["Leads_TaskParentGuid"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectleadsTaskParentGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectprojectsTopLevelProjectGuid != null)
            {
                transmitObjectObject["Projects_TopLevelProjectGuid"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectprojectsTopLevelProjectGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectprojectsTaskParentGuid != null)
            {
                transmitObjectObject["Projects_TaskParentGuid"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectprojectsTaskParentGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjecttasksTaskParentGuid != null)
            {
                transmitObjectObject["Tasks_TaskParentGuid"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjecttasksTaskParentGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectmarketingTopLevelProjectGuid != null)
            {
                transmitObjectObject["Marketing_TopLevelProjectGuid"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectmarketingTopLevelProjectGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectmarketingTaskParentGuid != null)
            {
                transmitObjectObject["Marketing_TaskParentGuid"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectmarketingTaskParentGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectcompaniesCompanyGuid != null)
            {
                transmitObjectObject["Companies_CompanyGuid"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectcompaniesCompanyGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectcontactsContactGuid != null)
            {
                transmitObjectObject["Contacts_ContactGuid"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectcontactsContactGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectusersTaskDelegatorGuid != null)
            {
                transmitObjectObject["Users_TaskDelegatorGuid"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectusersTaskDelegatorGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectusersTaskSolverGuid != null)
            {
                transmitObjectObject["Users_TaskSolverGuid"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectusersTaskSolverGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjecttasksTaskOriginGuid != null)
            {
                transmitObjectObject["Tasks_TaskOriginGuid"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjecttasksTaskOriginGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectbody != null)
            {
                transmitObjectObject["Body"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectbody);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectisCompleted != null)
            {
                transmitObjectObject["IsCompleted"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectisCompleted);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectdueDate != null)
            {
                transmitObjectObject["DueDate"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectdueDate);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectpercentCompleteDecimal != null)
            {
                transmitObjectObject["PercentCompleteDecimal"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectpercentCompleteDecimal);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectstartDate != null)
            {
                transmitObjectObject["StartDate"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectstartDate);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectsubject != null)
            {
                transmitObjectObject["Subject"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectsubject);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectlevel != null)
            {
                transmitObjectObject["Level"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectlevel);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectimportanceEn != null)
            {
                transmitObjectObject["ImportanceEn"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectimportanceEn);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectactualWorkHours != null)
            {
                transmitObjectObject["ActualWorkHours"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectactualWorkHours);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectestimatedWorkHours != null)
            {
                transmitObjectObject["EstimatedWorkHours"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectestimatedWorkHours);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectisReminderSet != null)
            {
                transmitObjectObject["IsReminderSet"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectisReminderSet);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectreminderDate != null)
            {
                transmitObjectObject["ReminderDate"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectreminderDate);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectcompletedDate != null)
            {
                transmitObjectObject["CompletedDate"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectcompletedDate);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectpicture != null)
            {
                transmitObjectObject["Picture"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectpicture);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectpictureWidth != null)
            {
                transmitObjectObject["PictureWidth"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectpictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectpictureHeight != null)
            {
                transmitObjectObject["PictureHeight"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectpictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectserverItemCreated != null)
            {
                transmitObjectObject["Server_ItemCreated"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectserverItemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectserverItemChanged != null)
            {
                transmitObjectObject["Server_ItemChanged"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectserverItemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectrelations != null)
            {
                transmitObjectObject["Relations"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectrelations);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(searchTasksWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                searchTasksWrapper["transmitObject"] = transmitObjectObject;
                searchTasksWrapperpropCount++;
            }

            if (searchTasksWrapperincludeRelations != null)
            {
                searchTasksWrapper["includeRelations"] = ExpressionConverter.ConvertO(searchTasksWrapperincludeRelations);
                searchTasksWrapperpropCount++;
            }

            var relationsFilterObject = new JObject();
            var relationsFilterObjectpropCount = 0;
            if (searchTasksWrapperrelationsFilterrelationType != null)
            {
                relationsFilterObject["RelationType"] = ExpressionConverter.ConvertO(searchTasksWrapperrelationsFilterrelationType);
                relationsFilterObjectpropCount++;
            }

            if (searchTasksWrapperrelationsFilterforeignFolderName != null)
            {
                relationsFilterObject["ForeignFolderName"] = ExpressionConverter.ConvertO(searchTasksWrapperrelationsFilterforeignFolderName);
                relationsFilterObjectpropCount++;
            }

            if (relationsFilterObjectpropCount > 0)
            {
                searchTasksWrapper["relationsFilter"] = relationsFilterObject;
                searchTasksWrapperpropCount++;
            }

            if (searchTasksWrapperbinaryLogicalOperator != null)
            {
                searchTasksWrapper["binaryLogicalOperator"] = ExpressionConverter.ConvertO(searchTasksWrapperbinaryLogicalOperator);
                searchTasksWrapperpropCount++;
            }

            if (searchTasksWrapperpropCount > 0)
            {
                callPayload.Body = searchTasksWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1SystemGuid> UnlinkItems([WorkflowExpression] Func<string> unlinkItemsWrapperitemGuid = null, [WorkflowExpression] Func<unlinkItemsWrapperfolderNameInput> unlinkItemsWrapperfolderName = null, [WorkflowExpression] Func<string[]> unlinkItemsWrapperrelatedItemGuids = null, [WorkflowExpression] Func<unlinkItemsWrapperrelatedFolderNameInput> unlinkItemsWrapperrelatedFolderName = null, [WorkflowExpression] Func<bool> unlinkItemsWrapperskipUnlinkAvailabilityCheck = null)
        {
            var apiCallPath = "/UnlinkItems";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var unlinkItemsWrapper = new JObject();
            var unlinkItemsWrapperpropCount = 0;
            if (unlinkItemsWrapperitemGuid != null)
            {
                unlinkItemsWrapper["itemGuid"] = ExpressionConverter.ConvertO(unlinkItemsWrapperitemGuid);
                unlinkItemsWrapperpropCount++;
            }

            if (unlinkItemsWrapperfolderName != null)
            {
                unlinkItemsWrapper["folderName"] = ExpressionConverter.ConvertO(unlinkItemsWrapperfolderName);
                unlinkItemsWrapperpropCount++;
            }

            if (unlinkItemsWrapperrelatedItemGuids != null)
            {
                unlinkItemsWrapper["relatedItemGuids"] = ExpressionConverter.ConvertO(unlinkItemsWrapperrelatedItemGuids);
                unlinkItemsWrapperpropCount++;
            }

            if (unlinkItemsWrapperrelatedFolderName != null)
            {
                unlinkItemsWrapper["relatedFolderName"] = ExpressionConverter.ConvertO(unlinkItemsWrapperrelatedFolderName);
                unlinkItemsWrapperpropCount++;
            }

            if (unlinkItemsWrapperskipUnlinkAvailabilityCheck != null)
            {
                unlinkItemsWrapper["skipUnlinkAvailabilityCheck"] = ExpressionConverter.ConvertO(unlinkItemsWrapperskipUnlinkAvailabilityCheck);
                unlinkItemsWrapperpropCount++;
            }

            if (unlinkItemsWrapperpropCount > 0)
            {
                callPayload.Body = unlinkItemsWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1SystemGuid>(callPayload);
        }
    }

    public class EwaycrmTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal> NewOrUpdatedJournal(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/NewOrUpdatedJournal";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany> NewOrUpdatedCompanies(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/NewOrUpdatedCompanies";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact> NewOrUpdatedContacts(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/NewOrUpdatedContacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead> NewOrUpdatedLeads(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/NewOrUpdatedLeads";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject> NewOrUpdatedProjects(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/NewOrUpdatedProjects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask> NewOrUpdatedTasks(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/NewOrUpdatedTasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask>(callPayload, triggerName, recurrence);
        }
    }

    public class EWayWcfServiceResponsesResponseBase
    {
        public string ReturnCode { get; set; }
        public string Description { get; set; }
    }

    public class EWayWcfServiceResponsesSaveResponse
    {
        [JsonProperty("Guid")]
        public string Id { get; set; }
        public string UserMessage { get; set; }
        public bool IsUserMessageOptionalError { get; set; }
        public string ReturnCode { get; set; }
        public string Description { get; set; }
    }

    public class EWayWcfServiceResponsesBooleanResponse
    {
        public bool Result { get; set; }
        public string ReturnCode { get; set; }
        public string Description { get; set; }
    }

    public enum saveRelationWrappertransmitObjectfolderName1Input
    {
        Actions,
        AdditionalFields,
        Bonuses,
        Calendar,
        CapacityNotes,
        CapacityNoteTypes,
        Carts,
        ColumnPermissions,
        Companies,
        Contacts,
        CurrencyExchangeRates,
        Documents,
        Emails,
        EnumTypes,
        EnumValues,
        EnumValuesRelations,
        Features,
        Flows,
        GlobalSettings,
        Goals,
        Goods,
        GoodsInCart,
        GoodsInSet,
        Groups,
        History,
        Holidays,
        Children,
        IndividualDiscounts,
        InvoiceItems,
        Invoices,
        ItemCopyRelations,
        Journal,
        Knowledge,
        Layouts,
        LayoutsModels,
        Leads,
        Ledger,
        Mappings,
        Marketing,
        MarketingList,
        MarketingListSources,
        Models,
        ModulePermissions,
        ObjectTypesOptions,
        Payments,
        PriceListGroups,
        ProjectAssignments,
        ProjectAssignmentsPerUserProject,
        ProjectAssignmentsTotal,
        ProjectAssignmentsTotalUserProject,
        ProjectList,
        Projects,
        ProjectUsersInCaPlan,
        RelationData,
        Relations,
        Reports,
        RevisionsHistory,
        Salaries,
        SalePrices,
        Prices,
        SqlObjects,
        Tasks,
        RecurrencePatterns,
        TeamRoles,
        Templates,
        Training,
        UnifiedRelations,
        Users,
        UserSettings,
        Vacation,
        WebAccess2Options,
        WebAccessOptions,
        WorkCommitments,
        WorkflowHistory,
        WorkReports,
        WrongClientVersions,
        XsltTransformations
    }

    public enum saveRelationWrappertransmitObjectfolderName2Input
    {
        Actions,
        AdditionalFields,
        Bonuses,
        Calendar,
        CapacityNotes,
        CapacityNoteTypes,
        Carts,
        ColumnPermissions,
        Companies,
        Contacts,
        CurrencyExchangeRates,
        Documents,
        Emails,
        EnumTypes,
        EnumValues,
        EnumValuesRelations,
        Features,
        Flows,
        GlobalSettings,
        Goals,
        Goods,
        GoodsInCart,
        GoodsInSet,
        Groups,
        History,
        Holidays,
        Children,
        IndividualDiscounts,
        InvoiceItems,
        Invoices,
        ItemCopyRelations,
        Journal,
        Knowledge,
        Layouts,
        LayoutsModels,
        Leads,
        Ledger,
        Mappings,
        Marketing,
        MarketingList,
        MarketingListSources,
        Models,
        ModulePermissions,
        ObjectTypesOptions,
        Payments,
        PriceListGroups,
        ProjectAssignments,
        ProjectAssignmentsPerUserProject,
        ProjectAssignmentsTotal,
        ProjectAssignmentsTotalUserProject,
        ProjectList,
        Projects,
        ProjectUsersInCaPlan,
        RelationData,
        Relations,
        Reports,
        RevisionsHistory,
        Salaries,
        SalePrices,
        Prices,
        SqlObjects,
        Tasks,
        RecurrencePatterns,
        TeamRoles,
        Templates,
        Training,
        UnifiedRelations,
        Users,
        UserSettings,
        Vacation,
        WebAccess2Options,
        WebAccessOptions,
        WorkCommitments,
        WorkflowHistory,
        WorkReports,
        WrongClientVersions,
        XsltTransformations
    }

    public class EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany
    {
        public EWayWcfServiceItemTypesGeneratedCompany[] Data { get; set; }
        public string ReturnCode { get; set; }
        public string Description { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedCompany
    {
        public string AccountNumber { get; set; }
        public string Address1POBox { get; set; }
        public string Address1Street { get; set; }
        public string Address1City { get; set; }
        public string Address1State { get; set; }
        public string Address1CountryEn { get; set; }
        public string Address1PostalCode { get; set; }
        public string Address2POBox { get; set; }
        public string Address2Street { get; set; }
        public string Address2City { get; set; }
        public string Address2State { get; set; }
        public string Address2CountryEn { get; set; }
        public string Address2PostalCode { get; set; }
        public string Address3POBox { get; set; }
        public string Address3Street { get; set; }
        public string Address3City { get; set; }
        public string Address3State { get; set; }
        public string Address3CountryEn { get; set; }
        public string Address3PostalCode { get; set; }
        public string CompanyName { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public int EmployeesCount { get; set; }
        public string Fax { get; set; }
        public string FirstContactEn { get; set; }
        public string ICQ { get; set; }
        public string IdentificationNumber { get; set; }
        public string ImportanceEn { get; set; }
        public string LineOfBusiness { get; set; }
        public bool MailingListOther { get; set; }
        public string Mobile { get; set; }
        public string MobileNormalized { get; set; }
        public string MSN { get; set; }
        public string Note { get; set; }
        public string Phone { get; set; }
        public string PhoneNormalized { get; set; }
        public bool Purchaser { get; set; }
        public double Reversal { get; set; }
        public string Skype { get; set; }
        public bool Suppliers { get; set; }
        public string VATNumber { get; set; }
        public string WebPage { get; set; }
        public double AdditionalDiscount { get; set; }
        public int ID { get; set; }
        public bool Competitor { get; set; }
        public string SalePriceGuid { get; set; }
        public bool NotificationByEmail { get; set; }
        public string NotificationBy { get; set; }
        public string LastActivity { get; set; }
        public string NextStep { get; set; }
        public bool EmailOptOut { get; set; }
        public string TypeEn { get; set; }
        public string StateEn { get; set; }
        public string PrevStateEn { get; set; }
        public string Picture { get; set; }
        public int PictureWidth { get; set; }
        public int PictureHeight { get; set; }
        public bool IsPrivate { get; set; }

        [JsonProperty("Server_ItemCreated")]
        public string ServerItemCreated { get; set; }

        [JsonProperty("Server_ItemChanged")]
        public string ServerItemChanged { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public EWayWcfServiceItemTypesInnerTypesBoundRelation[] Relations { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class EWayWcfServiceItemTypesInnerTypesBoundRelation
    {
        public string ItemGUID { get; set; }
        public string RelationDataGUID { get; set; }
        public string RelationType { get; set; }
        public string ForeignFolderName { get; set; }
        public string ForeignItemGUID { get; set; }
        public bool DifferDirection { get; set; }
        public string OwnerGUID { get; set; }
        public string MainItemGUID { get; set; }
    }

    public class EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact
    {
        public EWayWcfServiceItemTypesGeneratedContact[] Data { get; set; }
        public string ReturnCode { get; set; }
        public string Description { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedContact
    {
        public string BusinessAddressStreet { get; set; }
        public string BusinessAddressCity { get; set; }
        public string BusinessAddressState { get; set; }
        public string BusinessAddressCountryEn { get; set; }
        public string BusinessAddressPOBox { get; set; }
        public string BusinessAddressPostalCode { get; set; }
        public string HomeAddressStreet { get; set; }
        public string HomeAddressCity { get; set; }
        public string HomeAddressState { get; set; }
        public string HomeAddressCountryEn { get; set; }
        public string HomeAddressPOBox { get; set; }
        public string HomeAddressPostalCode { get; set; }
        public string OtherAddressStreet { get; set; }
        public string OtherAddressCity { get; set; }
        public string OtherAddressState { get; set; }
        public string OtherAddressCountryEn { get; set; }
        public string OtherAddressPOBox { get; set; }
        public string OtherAddressPostalCode { get; set; }
        public string Company { get; set; }
        public string Email1Address { get; set; }
        public string Email2Address { get; set; }
        public string Email3Address { get; set; }
        public string FirstName { get; set; }
        public string ICQ { get; set; }
        public string ImportanceEn { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string MSN { get; set; }
        public string Note { get; set; }
        public string PrefixEn { get; set; }
        public string SuffixEn { get; set; }
        public string Skype { get; set; }
        public string TelephoneNumber1 { get; set; }
        public string TelephoneNumber2 { get; set; }
        public string TelephoneNumber3 { get; set; }
        public string TelephoneNumber4 { get; set; }
        public string TelephoneNumber5 { get; set; }
        public string TelephoneNumber6 { get; set; }
        public string TelephoneNumber1Normalized { get; set; }
        public string TelephoneNumber2Normalized { get; set; }
        public string TelephoneNumber3Normalized { get; set; }
        public string TelephoneNumber4Normalized { get; set; }
        public string TelephoneNumber5Normalized { get; set; }
        public string TelephoneNumber6Normalized { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public string WebPage { get; set; }
        public bool DoNotSendNewsletter { get; set; }
        public string ProfilePicture { get; set; }
        public int ProfilePictureWidth { get; set; }
        public int ProfilePictureHeight { get; set; }
        public string LastActivity { get; set; }
        public string NextStep { get; set; }
        public string TypeEn { get; set; }
        public string StateEn { get; set; }
        public string PrevStateEn { get; set; }
        public bool IsPrivate { get; set; }

        [JsonProperty("Server_ItemCreated")]
        public string ServerItemCreated { get; set; }

        [JsonProperty("Server_ItemChanged")]
        public string ServerItemChanged { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public EWayWcfServiceItemTypesInnerTypesBoundRelation[] Relations { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal
    {
        public EWayWcfServiceItemTypesGeneratedJournal[] Data { get; set; }
        public string ReturnCode { get; set; }
        public string Description { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedJournal
    {
        public string CalendarEntryID { get; set; }

        [JsonProperty("Calendar_ORIGIN")]
        public string CalendarORIGIN { get; set; }
        public string ChangedField { get; set; }
        public string EventEnd { get; set; }
        public string EventStart { get; set; }
        public string FieldValue { get; set; }
        public string ImportanceEn { get; set; }
        public string Note { get; set; }
        public string PrevFieldValue { get; set; }
        public string TypeEn { get; set; }
        public bool IsSystem { get; set; }
        public string Phone { get; set; }
        public string PhoneNormalized { get; set; }
        public bool IsGdprRelevant { get; set; }
        public string Picture { get; set; }
        public int PictureWidth { get; set; }
        public int PictureHeight { get; set; }
        public string StateEn { get; set; }
        public string PrevStateEn { get; set; }
        public bool IsPrivate { get; set; }

        [JsonProperty("Server_ItemCreated")]
        public string ServerItemCreated { get; set; }

        [JsonProperty("Server_ItemChanged")]
        public string ServerItemChanged { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public EWayWcfServiceItemTypesInnerTypesBoundRelation[] Relations { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead
    {
        public EWayWcfServiceItemTypesGeneratedLead[] Data { get; set; }
        public string ReturnCode { get; set; }
        public string Description { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedLead
    {
        public string City { get; set; }
        public string ContactPerson { get; set; }
        public string CurrencyEn { get; set; }
        public string Customer { get; set; }
        public string Email { get; set; }
        public string EstimatedEnd { get; set; }
        public int HID { get; set; }
        public string LeadOriginEn { get; set; }
        public string Note { get; set; }
        public string Phone { get; set; }
        public string PhoneNormalized { get; set; }
        public string PrevStateEn { get; set; }
        public double Price { get; set; }
        public string PriceChanged { get; set; }
        public double PriceDefaultCurrency { get; set; }
        public double Probability { get; set; }
        public string ReceiveDate { get; set; }
        public string StateEn { get; set; }
        public string Street { get; set; }
        public string TypeEn { get; set; }
        public string Zip { get; set; }
        public string LastActivity { get; set; }
        public string NextStep { get; set; }
        public double EstimatedValue { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsLost { get; set; }
        public string CountryEn { get; set; }
        public string State { get; set; }
        public string POBox { get; set; }
        public bool EmailOptOut { get; set; }
        public string Picture { get; set; }
        public int PictureWidth { get; set; }
        public int PictureHeight { get; set; }
        public string CompletedDate { get; set; }
        public string LostDate { get; set; }
        public bool IsPrivate { get; set; }

        [JsonProperty("Server_ItemCreated")]
        public string ServerItemCreated { get; set; }

        [JsonProperty("Server_ItemChanged")]
        public string ServerItemChanged { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public EWayWcfServiceItemTypesInnerTypesBoundRelation[] Relations { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject
    {
        public EWayWcfServiceItemTypesGeneratedProject[] Data { get; set; }
        public string ReturnCode { get; set; }
        public string Description { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedProject
    {
        public string Note { get; set; }
        public double Price { get; set; }
        public string ProjectEnd { get; set; }
        public string ProjectName { get; set; }
        public string TypeEn { get; set; }
        public string StateEn { get; set; }
        public double PeopleExpenses { get; set; }
        public string ProjectRealEnd { get; set; }
        public double EstimatedPrice { get; set; }
        public int HID { get; set; }
        public string ProjectOriginEn { get; set; }
        public string PaymentTypeEn { get; set; }
        public double OtherExpenses { get; set; }
        public double Margin { get; set; }
        public double Profit { get; set; }
        public int PaymentMaturity { get; set; }
        public string InvoicePaymentDate { get; set; }
        public string InvoiceIssueDate { get; set; }
        public double EstimatedMargin { get; set; }
        public double EstimatedProfit { get; set; }
        public double EstimatedPeopleExpenses { get; set; }
        public double EstimatedOtherExpenses { get; set; }
        public int LicensesCount { get; set; }
        public double LicensePrice { get; set; }
        public string PrevStateEn { get; set; }
        public bool ShowInCaplan { get; set; }
        public string ProjectStart { get; set; }
        public int EstimatedWorkHours { get; set; }
        public double TotalWorkHours { get; set; }
        public double EstimatedPeopleExpensesDefaultCurrency { get; set; }
        public double EstimatedOtherExpensesDefaultCurrency { get; set; }
        public double EstimatedPriceDefaultCurrency { get; set; }
        public double PeopleExpensesDefaultCurrency { get; set; }
        public double OtherExpensesDefaultCurrency { get; set; }
        public double PriceDefaultCurrency { get; set; }
        public double ProfitDefaultCurrency { get; set; }
        public double EstimatedProfitDefaultCurrency { get; set; }
        public string CurrencyEn { get; set; }
        public string EstimatedPeopleExpensesChanged { get; set; }
        public string EstimatedOtherExpensesChanged { get; set; }
        public string OtherExpensesChanged { get; set; }
        public string EstimatedPriceChanged { get; set; }
        public string PriceChanged { get; set; }
        public string LicensePriceChanged { get; set; }
        public double LicensePriceDefaultCurrency { get; set; }
        public string LastActivity { get; set; }
        public string NextStep { get; set; }
        public string CompletedDate { get; set; }
        public bool IsCompleted { get; set; }
        public string LostDate { get; set; }
        public bool IsLost { get; set; }
        public string PeopleExpensesChanged { get; set; }
        public string Picture { get; set; }
        public int PictureWidth { get; set; }
        public int PictureHeight { get; set; }
        public bool IsPrivate { get; set; }

        [JsonProperty("Server_ItemCreated")]
        public string ServerItemCreated { get; set; }

        [JsonProperty("Server_ItemChanged")]
        public string ServerItemChanged { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public EWayWcfServiceItemTypesInnerTypesBoundRelation[] Relations { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask
    {
        public EWayWcfServiceItemTypesGeneratedTask[] Data { get; set; }
        public string ReturnCode { get; set; }
        public string Description { get; set; }
    }

    public class EWayWcfServiceItemTypesGeneratedTask
    {
        public string Body { get; set; }
        public bool IsCompleted { get; set; }
        public string DueDate { get; set; }
        public double PercentCompleteDecimal { get; set; }
        public string PrevStateEn { get; set; }
        public string StartDate { get; set; }
        public string StateEn { get; set; }
        public string Subject { get; set; }
        public string TypeEn { get; set; }
        public int Level { get; set; }
        public string ImportanceEn { get; set; }
        public double ActualWorkHours { get; set; }
        public double EstimatedWorkHours { get; set; }
        public bool IsReminderSet { get; set; }
        public string ReminderDate { get; set; }
        public string CompletedDate { get; set; }
        public string Picture { get; set; }
        public int PictureWidth { get; set; }
        public int PictureHeight { get; set; }
        public bool IsPrivate { get; set; }

        [JsonProperty("Server_ItemCreated")]
        public string ServerItemCreated { get; set; }

        [JsonProperty("Server_ItemChanged")]
        public string ServerItemChanged { get; set; }
        public string ItemCreated { get; set; }
        public string ItemChanged { get; set; }
        public string FileAs { get; set; }
        public string OwnerGUID { get; set; }
        public string CreatedByGUID { get; set; }
        public string ModifiedByGUID { get; set; }
        public JToken AdditionalFields { get; set; }
        public EWayWcfServiceItemTypesInnerTypesBoundRelation[] Relations { get; set; }
        public string ItemGUID { get; set; }
        public int ItemVersion { get; set; }
    }

    public class EWayWcfServiceResponsesDataResponse1SystemGuid
    {
        public string[] Data { get; set; }
        public string ReturnCode { get; set; }
        public string Description { get; set; }
    }

    public enum unlinkItemsWrapperfolderNameInput
    {
        Actions,
        AdditionalFields,
        Bonuses,
        Calendar,
        CapacityNotes,
        CapacityNoteTypes,
        Carts,
        ColumnPermissions,
        Companies,
        Contacts,
        CurrencyExchangeRates,
        Documents,
        Emails,
        EnumTypes,
        EnumValues,
        EnumValuesRelations,
        Features,
        Flows,
        GlobalSettings,
        Goals,
        Goods,
        GoodsInCart,
        GoodsInSet,
        Groups,
        History,
        Holidays,
        Children,
        IndividualDiscounts,
        InvoiceItems,
        Invoices,
        ItemCopyRelations,
        Journal,
        Knowledge,
        Layouts,
        LayoutsModels,
        Leads,
        Ledger,
        Mappings,
        Marketing,
        MarketingList,
        MarketingListSources,
        Models,
        ModulePermissions,
        ObjectTypesOptions,
        Payments,
        PriceListGroups,
        ProjectAssignments,
        ProjectAssignmentsPerUserProject,
        ProjectAssignmentsTotal,
        ProjectAssignmentsTotalUserProject,
        ProjectList,
        Projects,
        ProjectUsersInCaPlan,
        RelationData,
        Relations,
        Reports,
        RevisionsHistory,
        Salaries,
        SalePrices,
        Prices,
        SqlObjects,
        Tasks,
        RecurrencePatterns,
        TeamRoles,
        Templates,
        Training,
        UnifiedRelations,
        Users,
        UserSettings,
        Vacation,
        WebAccess2Options,
        WebAccessOptions,
        WorkCommitments,
        WorkflowHistory,
        WorkReports,
        WrongClientVersions,
        XsltTransformations
    }

    public enum unlinkItemsWrapperrelatedFolderNameInput
    {
        Actions,
        AdditionalFields,
        Bonuses,
        Calendar,
        CapacityNotes,
        CapacityNoteTypes,
        Carts,
        ColumnPermissions,
        Companies,
        Contacts,
        CurrencyExchangeRates,
        Documents,
        Emails,
        EnumTypes,
        EnumValues,
        EnumValuesRelations,
        Features,
        Flows,
        GlobalSettings,
        Goals,
        Goods,
        GoodsInCart,
        GoodsInSet,
        Groups,
        History,
        Holidays,
        Children,
        IndividualDiscounts,
        InvoiceItems,
        Invoices,
        ItemCopyRelations,
        Journal,
        Knowledge,
        Layouts,
        LayoutsModels,
        Leads,
        Ledger,
        Mappings,
        Marketing,
        MarketingList,
        MarketingListSources,
        Models,
        ModulePermissions,
        ObjectTypesOptions,
        Payments,
        PriceListGroups,
        ProjectAssignments,
        ProjectAssignmentsPerUserProject,
        ProjectAssignmentsTotal,
        ProjectAssignmentsTotalUserProject,
        ProjectList,
        Projects,
        ProjectUsersInCaPlan,
        RelationData,
        Relations,
        Reports,
        RevisionsHistory,
        Salaries,
        SalePrices,
        Prices,
        SqlObjects,
        Tasks,
        RecurrencePatterns,
        TeamRoles,
        Templates,
        Training,
        UnifiedRelations,
        Users,
        UserSettings,
        Vacation,
        WebAccess2Options,
        WebAccessOptions,
        WorkCommitments,
        WorkflowHistory,
        WorkReports,
        WrongClientVersions,
        XsltTransformations
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ewaycrm;

    public partial class WorkflowManagedActions
    {
        public EwaycrmActions Ewaycrm(string connectionId) => new EwaycrmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EwaycrmTriggers Ewaycrm(string connectionId) => new EwaycrmTriggers(connectionId);
    }
}