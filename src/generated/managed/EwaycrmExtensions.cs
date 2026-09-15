//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ewaycrm
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EwaycrmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteCompany(Expression<Func<string>> deleteCompanyWrapperitemGuid = null)
        {
            var apiCallPath = "/DeleteCompany";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteCompanyWrapper = new JObject();
            var deleteCompanyWrapperpropCount = 0;
            if (deleteCompanyWrapperitemGuid != null)
            {
                deleteCompanyWrapper["itemGuid"] = CSharpExpressionConverter.ConvertToken(deleteCompanyWrapperitemGuid);
                deleteCompanyWrapperpropCount++;
            }

            if (deleteCompanyWrapperpropCount > 0)
            {
                callPayload.Body = deleteCompanyWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteContact(Expression<Func<string>> deleteContactWrapperitemGuid = null)
        {
            var apiCallPath = "/DeleteContact";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteContactWrapper = new JObject();
            var deleteContactWrapperpropCount = 0;
            if (deleteContactWrapperitemGuid != null)
            {
                deleteContactWrapper["itemGuid"] = CSharpExpressionConverter.ConvertToken(deleteContactWrapperitemGuid);
                deleteContactWrapperpropCount++;
            }

            if (deleteContactWrapperpropCount > 0)
            {
                callPayload.Body = deleteContactWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteJournal(Expression<Func<string>> deleteJournalWrapperitemGuid = null)
        {
            var apiCallPath = "/DeleteJournal";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteJournalWrapper = new JObject();
            var deleteJournalWrapperpropCount = 0;
            if (deleteJournalWrapperitemGuid != null)
            {
                deleteJournalWrapper["itemGuid"] = CSharpExpressionConverter.ConvertToken(deleteJournalWrapperitemGuid);
                deleteJournalWrapperpropCount++;
            }

            if (deleteJournalWrapperpropCount > 0)
            {
                callPayload.Body = deleteJournalWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteLead(Expression<Func<string>> deleteLeadWrapperitemGuid = null)
        {
            var apiCallPath = "/DeleteLead";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteLeadWrapper = new JObject();
            var deleteLeadWrapperpropCount = 0;
            if (deleteLeadWrapperitemGuid != null)
            {
                deleteLeadWrapper["itemGuid"] = CSharpExpressionConverter.ConvertToken(deleteLeadWrapperitemGuid);
                deleteLeadWrapperpropCount++;
            }

            if (deleteLeadWrapperpropCount > 0)
            {
                callPayload.Body = deleteLeadWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteProject(Expression<Func<string>> deleteProjectWrapperitemGuid = null)
        {
            var apiCallPath = "/DeleteProject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteProjectWrapper = new JObject();
            var deleteProjectWrapperpropCount = 0;
            if (deleteProjectWrapperitemGuid != null)
            {
                deleteProjectWrapper["itemGuid"] = CSharpExpressionConverter.ConvertToken(deleteProjectWrapperitemGuid);
                deleteProjectWrapperpropCount++;
            }

            if (deleteProjectWrapperpropCount > 0)
            {
                callPayload.Body = deleteProjectWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteTask(Expression<Func<string>> deleteTaskWrapperitemGuid = null)
        {
            var apiCallPath = "/DeleteTask";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteTaskWrapper = new JObject();
            var deleteTaskWrapperpropCount = 0;
            if (deleteTaskWrapperitemGuid != null)
            {
                deleteTaskWrapper["itemGuid"] = CSharpExpressionConverter.ConvertToken(deleteTaskWrapperitemGuid);
                deleteTaskWrapperpropCount++;
            }

            if (deleteTaskWrapperpropCount > 0)
            {
                callPayload.Body = deleteTaskWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveCompany(Expression<Func<string>> saveCompanyWrappertransmitObjectaccountNumber = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress1POBox = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress1Street = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress1City = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress1State = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress1CountryEn = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress1PostalCode = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress2POBox = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress2Street = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress2City = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress2State = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress2CountryEn = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress2PostalCode = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress3POBox = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress3Street = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress3City = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress3State = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress3CountryEn = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress3PostalCode = null, Expression<Func<string>> saveCompanyWrappertransmitObjectcompanyName = null, Expression<Func<string>> saveCompanyWrappertransmitObjectdepartment = null, Expression<Func<string>> saveCompanyWrappertransmitObjectemail = null, Expression<Func<int>> saveCompanyWrappertransmitObjectemployeesCount = null, Expression<Func<string>> saveCompanyWrappertransmitObjectfax = null, Expression<Func<string>> saveCompanyWrappertransmitObjectfirstContactEn = null, Expression<Func<string>> saveCompanyWrappertransmitObjectiCQ = null, Expression<Func<string>> saveCompanyWrappertransmitObjectidentificationNumber = null, Expression<Func<string>> saveCompanyWrappertransmitObjectimportanceEn = null, Expression<Func<string>> saveCompanyWrappertransmitObjectlineOfBusiness = null, Expression<Func<bool>> saveCompanyWrappertransmitObjectmailingListOther = null, Expression<Func<string>> saveCompanyWrappertransmitObjectmobile = null, Expression<Func<string>> saveCompanyWrappertransmitObjectmobileNormalized = null, Expression<Func<string>> saveCompanyWrappertransmitObjectmSN = null, Expression<Func<string>> saveCompanyWrappertransmitObjectnote = null, Expression<Func<string>> saveCompanyWrappertransmitObjectphone = null, Expression<Func<string>> saveCompanyWrappertransmitObjectphoneNormalized = null, Expression<Func<bool>> saveCompanyWrappertransmitObjectpurchaser = null, Expression<Func<double>> saveCompanyWrappertransmitObjectreversal = null, Expression<Func<string>> saveCompanyWrappertransmitObjectskype = null, Expression<Func<bool>> saveCompanyWrappertransmitObjectsuppliers = null, Expression<Func<string>> saveCompanyWrappertransmitObjectvATNumber = null, Expression<Func<string>> saveCompanyWrappertransmitObjectwebPage = null, Expression<Func<double>> saveCompanyWrappertransmitObjectadditionalDiscount = null, Expression<Func<int>> saveCompanyWrappertransmitObjectiD = null, Expression<Func<bool>> saveCompanyWrappertransmitObjectcompetitor = null, Expression<Func<string>> saveCompanyWrappertransmitObjectsalePriceGuid = null, Expression<Func<bool>> saveCompanyWrappertransmitObjectnotificationByEmail = null, Expression<Func<string>> saveCompanyWrappertransmitObjectnotificationBy = null, Expression<Func<string>> saveCompanyWrappertransmitObjectlastActivity = null, Expression<Func<string>> saveCompanyWrappertransmitObjectnextStep = null, Expression<Func<bool>> saveCompanyWrappertransmitObjectemailOptOut = null, Expression<Func<string>> saveCompanyWrappertransmitObjecttypeEn = null, Expression<Func<string>> saveCompanyWrappertransmitObjectstateEn = null, Expression<Func<string>> saveCompanyWrappertransmitObjectprevStateEn = null, Expression<Func<string>> saveCompanyWrappertransmitObjectpicture = null, Expression<Func<int>> saveCompanyWrappertransmitObjectpictureWidth = null, Expression<Func<int>> saveCompanyWrappertransmitObjectpictureHeight = null, Expression<Func<bool>> saveCompanyWrappertransmitObjectisPrivate = null, Expression<Func<string>> saveCompanyWrappertransmitObjectitemCreated = null, Expression<Func<string>> saveCompanyWrappertransmitObjectitemChanged = null, Expression<Func<string>> saveCompanyWrappertransmitObjectfileAs = null, Expression<Func<string>> saveCompanyWrappertransmitObjectownerGUID = null, Expression<Func<string>> saveCompanyWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> saveCompanyWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> saveCompanyWrappertransmitObjectadditionalFields = null, Expression<Func<string>> saveCompanyWrappertransmitObjectitemGUID = null, Expression<Func<int>> saveCompanyWrappertransmitObjectitemVersion = null, Expression<Func<bool>> saveCompanyWrapperdieOnItemConflict = null, Expression<Func<string[]>> saveCompanyWrapperignoredUserErrorMessages = null)
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
                transmitObjectObject["AccountNumber"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaccountNumber);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress1POBox != null)
            {
                transmitObjectObject["Address1POBox"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress1POBox);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress1Street != null)
            {
                transmitObjectObject["Address1Street"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress1Street);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress1City != null)
            {
                transmitObjectObject["Address1City"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress1City);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress1State != null)
            {
                transmitObjectObject["Address1State"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress1State);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress1CountryEn != null)
            {
                transmitObjectObject["Address1CountryEn"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress1CountryEn);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress1PostalCode != null)
            {
                transmitObjectObject["Address1PostalCode"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress1PostalCode);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress2POBox != null)
            {
                transmitObjectObject["Address2POBox"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress2POBox);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress2Street != null)
            {
                transmitObjectObject["Address2Street"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress2Street);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress2City != null)
            {
                transmitObjectObject["Address2City"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress2City);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress2State != null)
            {
                transmitObjectObject["Address2State"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress2State);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress2CountryEn != null)
            {
                transmitObjectObject["Address2CountryEn"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress2CountryEn);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress2PostalCode != null)
            {
                transmitObjectObject["Address2PostalCode"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress2PostalCode);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress3POBox != null)
            {
                transmitObjectObject["Address3POBox"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress3POBox);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress3Street != null)
            {
                transmitObjectObject["Address3Street"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress3Street);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress3City != null)
            {
                transmitObjectObject["Address3City"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress3City);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress3State != null)
            {
                transmitObjectObject["Address3State"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress3State);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress3CountryEn != null)
            {
                transmitObjectObject["Address3CountryEn"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress3CountryEn);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectaddress3PostalCode != null)
            {
                transmitObjectObject["Address3PostalCode"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress3PostalCode);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectcompanyName != null)
            {
                transmitObjectObject["CompanyName"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectcompanyName);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectdepartment != null)
            {
                transmitObjectObject["Department"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectdepartment);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectemail != null)
            {
                transmitObjectObject["Email"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectemail);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectemployeesCount != null)
            {
                transmitObjectObject["EmployeesCount"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectemployeesCount);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectfax != null)
            {
                transmitObjectObject["Fax"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectfax);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectfirstContactEn != null)
            {
                transmitObjectObject["FirstContactEn"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectfirstContactEn);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectiCQ != null)
            {
                transmitObjectObject["ICQ"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectiCQ);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectidentificationNumber != null)
            {
                transmitObjectObject["IdentificationNumber"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectidentificationNumber);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectimportanceEn != null)
            {
                transmitObjectObject["ImportanceEn"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectimportanceEn);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectlineOfBusiness != null)
            {
                transmitObjectObject["LineOfBusiness"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectlineOfBusiness);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectmailingListOther != null)
            {
                transmitObjectObject["MailingListOther"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectmailingListOther);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectmobile != null)
            {
                transmitObjectObject["Mobile"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectmobile);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectmobileNormalized != null)
            {
                transmitObjectObject["MobileNormalized"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectmobileNormalized);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectmSN != null)
            {
                transmitObjectObject["MSN"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectmSN);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectnote != null)
            {
                transmitObjectObject["Note"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectnote);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectphone != null)
            {
                transmitObjectObject["Phone"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectphone);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectphoneNormalized != null)
            {
                transmitObjectObject["PhoneNormalized"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectphoneNormalized);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectpurchaser != null)
            {
                transmitObjectObject["Purchaser"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectpurchaser);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectreversal != null)
            {
                transmitObjectObject["Reversal"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectreversal);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectskype != null)
            {
                transmitObjectObject["Skype"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectskype);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectsuppliers != null)
            {
                transmitObjectObject["Suppliers"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectsuppliers);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectvATNumber != null)
            {
                transmitObjectObject["VATNumber"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectvATNumber);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectwebPage != null)
            {
                transmitObjectObject["WebPage"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectwebPage);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectadditionalDiscount != null)
            {
                transmitObjectObject["AdditionalDiscount"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectadditionalDiscount);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectiD != null)
            {
                transmitObjectObject["ID"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectiD);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectcompetitor != null)
            {
                transmitObjectObject["Competitor"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectcompetitor);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectsalePriceGuid != null)
            {
                transmitObjectObject["SalePriceGuid"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectsalePriceGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectnotificationByEmail != null)
            {
                transmitObjectObject["NotificationByEmail"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectnotificationByEmail);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectnotificationBy != null)
            {
                transmitObjectObject["NotificationBy"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectnotificationBy);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectlastActivity != null)
            {
                transmitObjectObject["LastActivity"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectlastActivity);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectnextStep != null)
            {
                transmitObjectObject["NextStep"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectnextStep);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectemailOptOut != null)
            {
                transmitObjectObject["EmailOptOut"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectemailOptOut);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectpicture != null)
            {
                transmitObjectObject["Picture"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectpicture);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectpictureWidth != null)
            {
                transmitObjectObject["PictureWidth"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectpictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectpictureHeight != null)
            {
                transmitObjectObject["PictureHeight"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectpictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveCompanyWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                saveCompanyWrapper["transmitObject"] = transmitObjectObject;
                saveCompanyWrapperpropCount++;
            }

            if (saveCompanyWrapperdieOnItemConflict != null)
            {
                saveCompanyWrapper["dieOnItemConflict"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrapperdieOnItemConflict);
                saveCompanyWrapperpropCount++;
            }

            if (saveCompanyWrapperignoredUserErrorMessages != null)
            {
                saveCompanyWrapper["ignoredUserErrorMessages"] = CSharpExpressionConverter.ConvertToken(saveCompanyWrapperignoredUserErrorMessages);
                saveCompanyWrapperpropCount++;
            }

            if (saveCompanyWrapperpropCount > 0)
            {
                callPayload.Body = saveCompanyWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveContact(Expression<Func<string>> saveContactWrappertransmitObjectbusinessAddressStreet = null, Expression<Func<string>> saveContactWrappertransmitObjectbusinessAddressCity = null, Expression<Func<string>> saveContactWrappertransmitObjectbusinessAddressState = null, Expression<Func<string>> saveContactWrappertransmitObjectbusinessAddressCountryEn = null, Expression<Func<string>> saveContactWrappertransmitObjectbusinessAddressPOBox = null, Expression<Func<string>> saveContactWrappertransmitObjectbusinessAddressPostalCode = null, Expression<Func<string>> saveContactWrappertransmitObjecthomeAddressStreet = null, Expression<Func<string>> saveContactWrappertransmitObjecthomeAddressCity = null, Expression<Func<string>> saveContactWrappertransmitObjecthomeAddressState = null, Expression<Func<string>> saveContactWrappertransmitObjecthomeAddressCountryEn = null, Expression<Func<string>> saveContactWrappertransmitObjecthomeAddressPOBox = null, Expression<Func<string>> saveContactWrappertransmitObjecthomeAddressPostalCode = null, Expression<Func<string>> saveContactWrappertransmitObjectotherAddressStreet = null, Expression<Func<string>> saveContactWrappertransmitObjectotherAddressCity = null, Expression<Func<string>> saveContactWrappertransmitObjectotherAddressState = null, Expression<Func<string>> saveContactWrappertransmitObjectotherAddressCountryEn = null, Expression<Func<string>> saveContactWrappertransmitObjectotherAddressPOBox = null, Expression<Func<string>> saveContactWrappertransmitObjectotherAddressPostalCode = null, Expression<Func<string>> saveContactWrappertransmitObjectcompany = null, Expression<Func<string>> saveContactWrappertransmitObjectemail1Address = null, Expression<Func<string>> saveContactWrappertransmitObjectemail2Address = null, Expression<Func<string>> saveContactWrappertransmitObjectemail3Address = null, Expression<Func<string>> saveContactWrappertransmitObjectfirstName = null, Expression<Func<string>> saveContactWrappertransmitObjectiCQ = null, Expression<Func<string>> saveContactWrappertransmitObjectimportanceEn = null, Expression<Func<string>> saveContactWrappertransmitObjectlastName = null, Expression<Func<string>> saveContactWrappertransmitObjectmiddleName = null, Expression<Func<string>> saveContactWrappertransmitObjectmSN = null, Expression<Func<string>> saveContactWrappertransmitObjectnote = null, Expression<Func<string>> saveContactWrappertransmitObjectprefixEn = null, Expression<Func<string>> saveContactWrappertransmitObjectsuffixEn = null, Expression<Func<string>> saveContactWrappertransmitObjectskype = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber1 = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber2 = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber3 = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber4 = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber5 = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber6 = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber1Normalized = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber2Normalized = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber3Normalized = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber4Normalized = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber5Normalized = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber6Normalized = null, Expression<Func<string>> saveContactWrappertransmitObjectdepartment = null, Expression<Func<string>> saveContactWrappertransmitObjecttitle = null, Expression<Func<string>> saveContactWrappertransmitObjectwebPage = null, Expression<Func<bool>> saveContactWrappertransmitObjectdoNotSendNewsletter = null, Expression<Func<string>> saveContactWrappertransmitObjectprofilePicture = null, Expression<Func<int>> saveContactWrappertransmitObjectprofilePictureWidth = null, Expression<Func<int>> saveContactWrappertransmitObjectprofilePictureHeight = null, Expression<Func<string>> saveContactWrappertransmitObjectlastActivity = null, Expression<Func<string>> saveContactWrappertransmitObjectnextStep = null, Expression<Func<string>> saveContactWrappertransmitObjecttypeEn = null, Expression<Func<string>> saveContactWrappertransmitObjectstateEn = null, Expression<Func<string>> saveContactWrappertransmitObjectprevStateEn = null, Expression<Func<string>> saveContactWrappertransmitObjectcompaniesCompanyGuid = null, Expression<Func<bool>> saveContactWrappertransmitObjectisPrivate = null, Expression<Func<string>> saveContactWrappertransmitObjectitemCreated = null, Expression<Func<string>> saveContactWrappertransmitObjectitemChanged = null, Expression<Func<string>> saveContactWrappertransmitObjectfileAs = null, Expression<Func<string>> saveContactWrappertransmitObjectownerGUID = null, Expression<Func<string>> saveContactWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> saveContactWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> saveContactWrappertransmitObjectadditionalFields = null, Expression<Func<string>> saveContactWrappertransmitObjectitemGUID = null, Expression<Func<int>> saveContactWrappertransmitObjectitemVersion = null, Expression<Func<bool>> saveContactWrapperdieOnItemConflict = null, Expression<Func<string[]>> saveContactWrapperignoredUserErrorMessages = null)
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
                transmitObjectObject["BusinessAddressStreet"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectbusinessAddressStreet);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectbusinessAddressCity != null)
            {
                transmitObjectObject["BusinessAddressCity"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectbusinessAddressCity);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectbusinessAddressState != null)
            {
                transmitObjectObject["BusinessAddressState"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectbusinessAddressState);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectbusinessAddressCountryEn != null)
            {
                transmitObjectObject["BusinessAddressCountryEn"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectbusinessAddressCountryEn);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectbusinessAddressPOBox != null)
            {
                transmitObjectObject["BusinessAddressPOBox"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectbusinessAddressPOBox);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectbusinessAddressPostalCode != null)
            {
                transmitObjectObject["BusinessAddressPostalCode"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectbusinessAddressPostalCode);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecthomeAddressStreet != null)
            {
                transmitObjectObject["HomeAddressStreet"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjecthomeAddressStreet);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecthomeAddressCity != null)
            {
                transmitObjectObject["HomeAddressCity"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjecthomeAddressCity);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecthomeAddressState != null)
            {
                transmitObjectObject["HomeAddressState"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjecthomeAddressState);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecthomeAddressCountryEn != null)
            {
                transmitObjectObject["HomeAddressCountryEn"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjecthomeAddressCountryEn);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecthomeAddressPOBox != null)
            {
                transmitObjectObject["HomeAddressPOBox"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjecthomeAddressPOBox);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecthomeAddressPostalCode != null)
            {
                transmitObjectObject["HomeAddressPostalCode"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjecthomeAddressPostalCode);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectotherAddressStreet != null)
            {
                transmitObjectObject["OtherAddressStreet"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectotherAddressStreet);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectotherAddressCity != null)
            {
                transmitObjectObject["OtherAddressCity"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectotherAddressCity);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectotherAddressState != null)
            {
                transmitObjectObject["OtherAddressState"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectotherAddressState);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectotherAddressCountryEn != null)
            {
                transmitObjectObject["OtherAddressCountryEn"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectotherAddressCountryEn);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectotherAddressPOBox != null)
            {
                transmitObjectObject["OtherAddressPOBox"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectotherAddressPOBox);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectotherAddressPostalCode != null)
            {
                transmitObjectObject["OtherAddressPostalCode"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectotherAddressPostalCode);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectcompany != null)
            {
                transmitObjectObject["Company"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectcompany);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectemail1Address != null)
            {
                transmitObjectObject["Email1Address"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectemail1Address);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectemail2Address != null)
            {
                transmitObjectObject["Email2Address"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectemail2Address);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectemail3Address != null)
            {
                transmitObjectObject["Email3Address"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectemail3Address);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectfirstName != null)
            {
                transmitObjectObject["FirstName"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectfirstName);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectiCQ != null)
            {
                transmitObjectObject["ICQ"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectiCQ);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectimportanceEn != null)
            {
                transmitObjectObject["ImportanceEn"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectimportanceEn);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectlastName != null)
            {
                transmitObjectObject["LastName"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectlastName);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectmiddleName != null)
            {
                transmitObjectObject["MiddleName"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectmiddleName);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectmSN != null)
            {
                transmitObjectObject["MSN"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectmSN);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectnote != null)
            {
                transmitObjectObject["Note"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectnote);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectprefixEn != null)
            {
                transmitObjectObject["PrefixEn"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectprefixEn);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectsuffixEn != null)
            {
                transmitObjectObject["SuffixEn"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectsuffixEn);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectskype != null)
            {
                transmitObjectObject["Skype"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectskype);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber1 != null)
            {
                transmitObjectObject["TelephoneNumber1"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber1);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber2 != null)
            {
                transmitObjectObject["TelephoneNumber2"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber2);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber3 != null)
            {
                transmitObjectObject["TelephoneNumber3"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber3);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber4 != null)
            {
                transmitObjectObject["TelephoneNumber4"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber4);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber5 != null)
            {
                transmitObjectObject["TelephoneNumber5"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber5);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber6 != null)
            {
                transmitObjectObject["TelephoneNumber6"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber6);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber1Normalized != null)
            {
                transmitObjectObject["TelephoneNumber1Normalized"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber1Normalized);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber2Normalized != null)
            {
                transmitObjectObject["TelephoneNumber2Normalized"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber2Normalized);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber3Normalized != null)
            {
                transmitObjectObject["TelephoneNumber3Normalized"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber3Normalized);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber4Normalized != null)
            {
                transmitObjectObject["TelephoneNumber4Normalized"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber4Normalized);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber5Normalized != null)
            {
                transmitObjectObject["TelephoneNumber5Normalized"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber5Normalized);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttelephoneNumber6Normalized != null)
            {
                transmitObjectObject["TelephoneNumber6Normalized"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber6Normalized);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectdepartment != null)
            {
                transmitObjectObject["Department"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectdepartment);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttitle != null)
            {
                transmitObjectObject["Title"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttitle);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectwebPage != null)
            {
                transmitObjectObject["WebPage"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectwebPage);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectdoNotSendNewsletter != null)
            {
                transmitObjectObject["DoNotSendNewsletter"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectdoNotSendNewsletter);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectprofilePicture != null)
            {
                transmitObjectObject["ProfilePicture"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectprofilePicture);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectprofilePictureWidth != null)
            {
                transmitObjectObject["ProfilePictureWidth"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectprofilePictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectprofilePictureHeight != null)
            {
                transmitObjectObject["ProfilePictureHeight"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectprofilePictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectlastActivity != null)
            {
                transmitObjectObject["LastActivity"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectlastActivity);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectnextStep != null)
            {
                transmitObjectObject["NextStep"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectnextStep);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectcompaniesCompanyGuid != null)
            {
                transmitObjectObject["Companies_CompanyGuid"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectcompaniesCompanyGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveContactWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = CSharpExpressionConverter.ConvertToken(saveContactWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                saveContactWrapper["transmitObject"] = transmitObjectObject;
                saveContactWrapperpropCount++;
            }

            if (saveContactWrapperdieOnItemConflict != null)
            {
                saveContactWrapper["dieOnItemConflict"] = CSharpExpressionConverter.ConvertToken(saveContactWrapperdieOnItemConflict);
                saveContactWrapperpropCount++;
            }

            if (saveContactWrapperignoredUserErrorMessages != null)
            {
                saveContactWrapper["ignoredUserErrorMessages"] = CSharpExpressionConverter.ConvertToken(saveContactWrapperignoredUserErrorMessages);
                saveContactWrapperpropCount++;
            }

            if (saveContactWrapperpropCount > 0)
            {
                callPayload.Body = saveContactWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveJournal(Expression<Func<string>> saveJournalWrappertransmitObjectcalendarEntryID = null, Expression<Func<string>> saveJournalWrappertransmitObjectcalendarORIGIN = null, Expression<Func<string>> saveJournalWrappertransmitObjectchangedField = null, Expression<Func<string>> saveJournalWrappertransmitObjecteventEnd = null, Expression<Func<string>> saveJournalWrappertransmitObjecteventStart = null, Expression<Func<string>> saveJournalWrappertransmitObjectfieldValue = null, Expression<Func<string>> saveJournalWrappertransmitObjectimportanceEn = null, Expression<Func<string>> saveJournalWrappertransmitObjectnote = null, Expression<Func<string>> saveJournalWrappertransmitObjectprevFieldValue = null, Expression<Func<string>> saveJournalWrappertransmitObjecttypeEn = null, Expression<Func<bool>> saveJournalWrappertransmitObjectisSystem = null, Expression<Func<string>> saveJournalWrappertransmitObjectphone = null, Expression<Func<string>> saveJournalWrappertransmitObjectphoneNormalized = null, Expression<Func<bool>> saveJournalWrappertransmitObjectisGdprRelevant = null, Expression<Func<string>> saveJournalWrappertransmitObjectpicture = null, Expression<Func<int>> saveJournalWrappertransmitObjectpictureWidth = null, Expression<Func<int>> saveJournalWrappertransmitObjectpictureHeight = null, Expression<Func<string>> saveJournalWrappertransmitObjectstateEn = null, Expression<Func<string>> saveJournalWrappertransmitObjectprevStateEn = null, Expression<Func<string>> saveJournalWrappertransmitObjectcompaniesCompanyGuid = null, Expression<Func<string>> saveJournalWrappertransmitObjectcontactsContactGuid = null, Expression<Func<string>> saveJournalWrappertransmitObjectleadsSuperiorItemGuid = null, Expression<Func<string>> saveJournalWrappertransmitObjectprojectsSuperiorItemGuid = null, Expression<Func<string>> saveJournalWrappertransmitObjectmarketingMarketingGuid = null, Expression<Func<bool>> saveJournalWrappertransmitObjectisPrivate = null, Expression<Func<string>> saveJournalWrappertransmitObjectitemCreated = null, Expression<Func<string>> saveJournalWrappertransmitObjectitemChanged = null, Expression<Func<string>> saveJournalWrappertransmitObjectfileAs = null, Expression<Func<string>> saveJournalWrappertransmitObjectownerGUID = null, Expression<Func<string>> saveJournalWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> saveJournalWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> saveJournalWrappertransmitObjectadditionalFields = null, Expression<Func<string>> saveJournalWrappertransmitObjectitemGUID = null, Expression<Func<int>> saveJournalWrappertransmitObjectitemVersion = null, Expression<Func<bool>> saveJournalWrapperdieOnItemConflict = null, Expression<Func<string[]>> saveJournalWrapperignoredUserErrorMessages = null)
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
                transmitObjectObject["CalendarEntryID"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectcalendarEntryID);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectcalendarORIGIN != null)
            {
                transmitObjectObject["Calendar_ORIGIN"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectcalendarORIGIN);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectchangedField != null)
            {
                transmitObjectObject["ChangedField"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectchangedField);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjecteventEnd != null)
            {
                transmitObjectObject["EventEnd"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjecteventEnd);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjecteventStart != null)
            {
                transmitObjectObject["EventStart"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjecteventStart);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectfieldValue != null)
            {
                transmitObjectObject["FieldValue"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectfieldValue);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectimportanceEn != null)
            {
                transmitObjectObject["ImportanceEn"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectimportanceEn);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectnote != null)
            {
                transmitObjectObject["Note"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectnote);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectprevFieldValue != null)
            {
                transmitObjectObject["PrevFieldValue"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectprevFieldValue);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectisSystem != null)
            {
                transmitObjectObject["IsSystem"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectisSystem);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectphone != null)
            {
                transmitObjectObject["Phone"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectphone);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectphoneNormalized != null)
            {
                transmitObjectObject["PhoneNormalized"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectphoneNormalized);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectisGdprRelevant != null)
            {
                transmitObjectObject["IsGdprRelevant"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectisGdprRelevant);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectpicture != null)
            {
                transmitObjectObject["Picture"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectpicture);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectpictureWidth != null)
            {
                transmitObjectObject["PictureWidth"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectpictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectpictureHeight != null)
            {
                transmitObjectObject["PictureHeight"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectpictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectcompaniesCompanyGuid != null)
            {
                transmitObjectObject["Companies_CompanyGuid"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectcompaniesCompanyGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectcontactsContactGuid != null)
            {
                transmitObjectObject["Contacts_ContactGuid"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectcontactsContactGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectleadsSuperiorItemGuid != null)
            {
                transmitObjectObject["Leads_SuperiorItemGuid"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectleadsSuperiorItemGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectprojectsSuperiorItemGuid != null)
            {
                transmitObjectObject["Projects_SuperiorItemGuid"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectprojectsSuperiorItemGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectmarketingMarketingGuid != null)
            {
                transmitObjectObject["Marketing_MarketingGuid"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectmarketingMarketingGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveJournalWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = CSharpExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                saveJournalWrapper["transmitObject"] = transmitObjectObject;
                saveJournalWrapperpropCount++;
            }

            if (saveJournalWrapperdieOnItemConflict != null)
            {
                saveJournalWrapper["dieOnItemConflict"] = CSharpExpressionConverter.ConvertToken(saveJournalWrapperdieOnItemConflict);
                saveJournalWrapperpropCount++;
            }

            if (saveJournalWrapperignoredUserErrorMessages != null)
            {
                saveJournalWrapper["ignoredUserErrorMessages"] = CSharpExpressionConverter.ConvertToken(saveJournalWrapperignoredUserErrorMessages);
                saveJournalWrapperpropCount++;
            }

            if (saveJournalWrapperpropCount > 0)
            {
                callPayload.Body = saveJournalWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveLead(Expression<Func<string>> saveLeadWrappertransmitObjectcity = null, Expression<Func<string>> saveLeadWrappertransmitObjectcontactPerson = null, Expression<Func<string>> saveLeadWrappertransmitObjectcurrencyEn = null, Expression<Func<string>> saveLeadWrappertransmitObjectcustomer = null, Expression<Func<string>> saveLeadWrappertransmitObjectemail = null, Expression<Func<string>> saveLeadWrappertransmitObjectestimatedEnd = null, Expression<Func<int>> saveLeadWrappertransmitObjecthID = null, Expression<Func<string>> saveLeadWrappertransmitObjectleadOriginEn = null, Expression<Func<string>> saveLeadWrappertransmitObjectnote = null, Expression<Func<string>> saveLeadWrappertransmitObjectphone = null, Expression<Func<string>> saveLeadWrappertransmitObjectphoneNormalized = null, Expression<Func<string>> saveLeadWrappertransmitObjectprevStateEn = null, Expression<Func<double>> saveLeadWrappertransmitObjectprice = null, Expression<Func<string>> saveLeadWrappertransmitObjectpriceChanged = null, Expression<Func<double>> saveLeadWrappertransmitObjectpriceDefaultCurrency = null, Expression<Func<double>> saveLeadWrappertransmitObjectprobability = null, Expression<Func<string>> saveLeadWrappertransmitObjectreceiveDate = null, Expression<Func<string>> saveLeadWrappertransmitObjectstateEn = null, Expression<Func<string>> saveLeadWrappertransmitObjectstreet = null, Expression<Func<string>> saveLeadWrappertransmitObjecttypeEn = null, Expression<Func<string>> saveLeadWrappertransmitObjectzip = null, Expression<Func<string>> saveLeadWrappertransmitObjectlastActivity = null, Expression<Func<string>> saveLeadWrappertransmitObjectnextStep = null, Expression<Func<double>> saveLeadWrappertransmitObjectestimatedValue = null, Expression<Func<string>> saveLeadWrappertransmitObjectcountryEn = null, Expression<Func<string>> saveLeadWrappertransmitObjectstate = null, Expression<Func<string>> saveLeadWrappertransmitObjectpOBox = null, Expression<Func<bool>> saveLeadWrappertransmitObjectemailOptOut = null, Expression<Func<string>> saveLeadWrappertransmitObjectpicture = null, Expression<Func<int>> saveLeadWrappertransmitObjectpictureWidth = null, Expression<Func<int>> saveLeadWrappertransmitObjectpictureHeight = null, Expression<Func<string>> saveLeadWrappertransmitObjectcompaniesCustomerGuid = null, Expression<Func<string>> saveLeadWrappertransmitObjectcontactsContactPersonGuid = null, Expression<Func<string>> saveLeadWrappertransmitObjectmarketingMarketingGuid = null, Expression<Func<bool>> saveLeadWrappertransmitObjectisPrivate = null, Expression<Func<string>> saveLeadWrappertransmitObjectitemCreated = null, Expression<Func<string>> saveLeadWrappertransmitObjectitemChanged = null, Expression<Func<string>> saveLeadWrappertransmitObjectfileAs = null, Expression<Func<string>> saveLeadWrappertransmitObjectownerGUID = null, Expression<Func<string>> saveLeadWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> saveLeadWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> saveLeadWrappertransmitObjectadditionalFields = null, Expression<Func<string>> saveLeadWrappertransmitObjectitemGUID = null, Expression<Func<int>> saveLeadWrappertransmitObjectitemVersion = null, Expression<Func<bool>> saveLeadWrapperdieOnItemConflict = null, Expression<Func<string[]>> saveLeadWrapperignoredUserErrorMessages = null)
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
                transmitObjectObject["City"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectcity);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectcontactPerson != null)
            {
                transmitObjectObject["ContactPerson"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectcontactPerson);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectcurrencyEn != null)
            {
                transmitObjectObject["CurrencyEn"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectcurrencyEn);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectcustomer != null)
            {
                transmitObjectObject["Customer"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectcustomer);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectemail != null)
            {
                transmitObjectObject["Email"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectemail);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectestimatedEnd != null)
            {
                transmitObjectObject["EstimatedEnd"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectestimatedEnd);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjecthID != null)
            {
                transmitObjectObject["HID"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjecthID);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectleadOriginEn != null)
            {
                transmitObjectObject["LeadOriginEn"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectleadOriginEn);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectnote != null)
            {
                transmitObjectObject["Note"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectnote);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectphone != null)
            {
                transmitObjectObject["Phone"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectphone);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectphoneNormalized != null)
            {
                transmitObjectObject["PhoneNormalized"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectphoneNormalized);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectprice != null)
            {
                transmitObjectObject["Price"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectprice);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectpriceChanged != null)
            {
                transmitObjectObject["PriceChanged"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectpriceChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectpriceDefaultCurrency != null)
            {
                transmitObjectObject["PriceDefaultCurrency"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectpriceDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectprobability != null)
            {
                transmitObjectObject["Probability"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectprobability);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectreceiveDate != null)
            {
                transmitObjectObject["ReceiveDate"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectreceiveDate);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectstreet != null)
            {
                transmitObjectObject["Street"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectstreet);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectzip != null)
            {
                transmitObjectObject["Zip"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectzip);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectlastActivity != null)
            {
                transmitObjectObject["LastActivity"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectlastActivity);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectnextStep != null)
            {
                transmitObjectObject["NextStep"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectnextStep);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectestimatedValue != null)
            {
                transmitObjectObject["EstimatedValue"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectestimatedValue);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectcountryEn != null)
            {
                transmitObjectObject["CountryEn"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectcountryEn);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectstate != null)
            {
                transmitObjectObject["State"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectstate);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectpOBox != null)
            {
                transmitObjectObject["POBox"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectpOBox);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectemailOptOut != null)
            {
                transmitObjectObject["EmailOptOut"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectemailOptOut);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectpicture != null)
            {
                transmitObjectObject["Picture"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectpicture);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectpictureWidth != null)
            {
                transmitObjectObject["PictureWidth"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectpictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectpictureHeight != null)
            {
                transmitObjectObject["PictureHeight"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectpictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectcompaniesCustomerGuid != null)
            {
                transmitObjectObject["Companies_CustomerGuid"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectcompaniesCustomerGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectcontactsContactPersonGuid != null)
            {
                transmitObjectObject["Contacts_ContactPersonGuid"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectcontactsContactPersonGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectmarketingMarketingGuid != null)
            {
                transmitObjectObject["Marketing_MarketingGuid"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectmarketingMarketingGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveLeadWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = CSharpExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                saveLeadWrapper["transmitObject"] = transmitObjectObject;
                saveLeadWrapperpropCount++;
            }

            if (saveLeadWrapperdieOnItemConflict != null)
            {
                saveLeadWrapper["dieOnItemConflict"] = CSharpExpressionConverter.ConvertToken(saveLeadWrapperdieOnItemConflict);
                saveLeadWrapperpropCount++;
            }

            if (saveLeadWrapperignoredUserErrorMessages != null)
            {
                saveLeadWrapper["ignoredUserErrorMessages"] = CSharpExpressionConverter.ConvertToken(saveLeadWrapperignoredUserErrorMessages);
                saveLeadWrapperpropCount++;
            }

            if (saveLeadWrapperpropCount > 0)
            {
                callPayload.Body = saveLeadWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveProject(Expression<Func<string>> saveProjectWrappertransmitObjectnote = null, Expression<Func<double>> saveProjectWrappertransmitObjectprice = null, Expression<Func<string>> saveProjectWrappertransmitObjectprojectEnd = null, Expression<Func<string>> saveProjectWrappertransmitObjectprojectName = null, Expression<Func<string>> saveProjectWrappertransmitObjecttypeEn = null, Expression<Func<string>> saveProjectWrappertransmitObjectstateEn = null, Expression<Func<double>> saveProjectWrappertransmitObjectpeopleExpenses = null, Expression<Func<string>> saveProjectWrappertransmitObjectprojectRealEnd = null, Expression<Func<double>> saveProjectWrappertransmitObjectestimatedPrice = null, Expression<Func<int>> saveProjectWrappertransmitObjecthID = null, Expression<Func<string>> saveProjectWrappertransmitObjectprojectOriginEn = null, Expression<Func<string>> saveProjectWrappertransmitObjectpaymentTypeEn = null, Expression<Func<double>> saveProjectWrappertransmitObjectotherExpenses = null, Expression<Func<double>> saveProjectWrappertransmitObjectmargin = null, Expression<Func<double>> saveProjectWrappertransmitObjectprofit = null, Expression<Func<int>> saveProjectWrappertransmitObjectpaymentMaturity = null, Expression<Func<string>> saveProjectWrappertransmitObjectinvoicePaymentDate = null, Expression<Func<string>> saveProjectWrappertransmitObjectinvoiceIssueDate = null, Expression<Func<double>> saveProjectWrappertransmitObjectestimatedMargin = null, Expression<Func<double>> saveProjectWrappertransmitObjectestimatedProfit = null, Expression<Func<double>> saveProjectWrappertransmitObjectestimatedPeopleExpenses = null, Expression<Func<double>> saveProjectWrappertransmitObjectestimatedOtherExpenses = null, Expression<Func<int>> saveProjectWrappertransmitObjectlicensesCount = null, Expression<Func<double>> saveProjectWrappertransmitObjectlicensePrice = null, Expression<Func<string>> saveProjectWrappertransmitObjectprevStateEn = null, Expression<Func<bool>> saveProjectWrappertransmitObjectshowInCaplan = null, Expression<Func<string>> saveProjectWrappertransmitObjectprojectStart = null, Expression<Func<int>> saveProjectWrappertransmitObjectestimatedWorkHours = null, Expression<Func<double>> saveProjectWrappertransmitObjecttotalWorkHours = null, Expression<Func<double>> saveProjectWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency = null, Expression<Func<double>> saveProjectWrappertransmitObjectestimatedOtherExpensesDefaultCurrency = null, Expression<Func<double>> saveProjectWrappertransmitObjectestimatedPriceDefaultCurrency = null, Expression<Func<double>> saveProjectWrappertransmitObjectpeopleExpensesDefaultCurrency = null, Expression<Func<double>> saveProjectWrappertransmitObjectotherExpensesDefaultCurrency = null, Expression<Func<double>> saveProjectWrappertransmitObjectpriceDefaultCurrency = null, Expression<Func<double>> saveProjectWrappertransmitObjectprofitDefaultCurrency = null, Expression<Func<double>> saveProjectWrappertransmitObjectestimatedProfitDefaultCurrency = null, Expression<Func<string>> saveProjectWrappertransmitObjectcurrencyEn = null, Expression<Func<string>> saveProjectWrappertransmitObjectestimatedPeopleExpensesChanged = null, Expression<Func<string>> saveProjectWrappertransmitObjectestimatedOtherExpensesChanged = null, Expression<Func<string>> saveProjectWrappertransmitObjectotherExpensesChanged = null, Expression<Func<string>> saveProjectWrappertransmitObjectestimatedPriceChanged = null, Expression<Func<string>> saveProjectWrappertransmitObjectpriceChanged = null, Expression<Func<string>> saveProjectWrappertransmitObjectlicensePriceChanged = null, Expression<Func<double>> saveProjectWrappertransmitObjectlicensePriceDefaultCurrency = null, Expression<Func<string>> saveProjectWrappertransmitObjectlastActivity = null, Expression<Func<string>> saveProjectWrappertransmitObjectnextStep = null, Expression<Func<string>> saveProjectWrappertransmitObjectpeopleExpensesChanged = null, Expression<Func<string>> saveProjectWrappertransmitObjectpicture = null, Expression<Func<int>> saveProjectWrappertransmitObjectpictureWidth = null, Expression<Func<int>> saveProjectWrappertransmitObjectpictureHeight = null, Expression<Func<string>> saveProjectWrappertransmitObjectcompaniesCustomerGuid = null, Expression<Func<string>> saveProjectWrappertransmitObjectcontactsContactPersonGuid = null, Expression<Func<string>> saveProjectWrappertransmitObjectleadsProjectOriginGuid = null, Expression<Func<string>> saveProjectWrappertransmitObjectprojectsSuperiorProjectGuid = null, Expression<Func<string>> saveProjectWrappertransmitObjectusersSupervisorGuid = null, Expression<Func<bool>> saveProjectWrappertransmitObjectisPrivate = null, Expression<Func<string>> saveProjectWrappertransmitObjectitemCreated = null, Expression<Func<string>> saveProjectWrappertransmitObjectitemChanged = null, Expression<Func<string>> saveProjectWrappertransmitObjectfileAs = null, Expression<Func<string>> saveProjectWrappertransmitObjectownerGUID = null, Expression<Func<string>> saveProjectWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> saveProjectWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> saveProjectWrappertransmitObjectadditionalFields = null, Expression<Func<string>> saveProjectWrappertransmitObjectitemGUID = null, Expression<Func<int>> saveProjectWrappertransmitObjectitemVersion = null, Expression<Func<bool>> saveProjectWrapperdieOnItemConflict = null, Expression<Func<string[]>> saveProjectWrapperignoredUserErrorMessages = null)
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
                transmitObjectObject["Note"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectnote);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectprice != null)
            {
                transmitObjectObject["Price"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectprice);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectprojectEnd != null)
            {
                transmitObjectObject["ProjectEnd"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectprojectEnd);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectprojectName != null)
            {
                transmitObjectObject["ProjectName"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectprojectName);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectpeopleExpenses != null)
            {
                transmitObjectObject["PeopleExpenses"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectpeopleExpenses);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectprojectRealEnd != null)
            {
                transmitObjectObject["ProjectRealEnd"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectprojectRealEnd);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedPrice != null)
            {
                transmitObjectObject["EstimatedPrice"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedPrice);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjecthID != null)
            {
                transmitObjectObject["HID"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjecthID);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectprojectOriginEn != null)
            {
                transmitObjectObject["ProjectOriginEn"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectprojectOriginEn);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectpaymentTypeEn != null)
            {
                transmitObjectObject["PaymentTypeEn"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectpaymentTypeEn);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectotherExpenses != null)
            {
                transmitObjectObject["OtherExpenses"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectotherExpenses);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectmargin != null)
            {
                transmitObjectObject["Margin"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectmargin);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectprofit != null)
            {
                transmitObjectObject["Profit"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectprofit);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectpaymentMaturity != null)
            {
                transmitObjectObject["PaymentMaturity"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectpaymentMaturity);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectinvoicePaymentDate != null)
            {
                transmitObjectObject["InvoicePaymentDate"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectinvoicePaymentDate);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectinvoiceIssueDate != null)
            {
                transmitObjectObject["InvoiceIssueDate"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectinvoiceIssueDate);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedMargin != null)
            {
                transmitObjectObject["EstimatedMargin"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedMargin);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedProfit != null)
            {
                transmitObjectObject["EstimatedProfit"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedProfit);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedPeopleExpenses != null)
            {
                transmitObjectObject["EstimatedPeopleExpenses"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedPeopleExpenses);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedOtherExpenses != null)
            {
                transmitObjectObject["EstimatedOtherExpenses"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedOtherExpenses);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectlicensesCount != null)
            {
                transmitObjectObject["LicensesCount"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectlicensesCount);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectlicensePrice != null)
            {
                transmitObjectObject["LicensePrice"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectlicensePrice);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectshowInCaplan != null)
            {
                transmitObjectObject["ShowInCaplan"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectshowInCaplan);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectprojectStart != null)
            {
                transmitObjectObject["ProjectStart"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectprojectStart);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedWorkHours != null)
            {
                transmitObjectObject["EstimatedWorkHours"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedWorkHours);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjecttotalWorkHours != null)
            {
                transmitObjectObject["TotalWorkHours"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjecttotalWorkHours);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency != null)
            {
                transmitObjectObject["EstimatedPeopleExpensesDefaultCurrency"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedOtherExpensesDefaultCurrency != null)
            {
                transmitObjectObject["EstimatedOtherExpensesDefaultCurrency"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedOtherExpensesDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedPriceDefaultCurrency != null)
            {
                transmitObjectObject["EstimatedPriceDefaultCurrency"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedPriceDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectpeopleExpensesDefaultCurrency != null)
            {
                transmitObjectObject["PeopleExpensesDefaultCurrency"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectpeopleExpensesDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectotherExpensesDefaultCurrency != null)
            {
                transmitObjectObject["OtherExpensesDefaultCurrency"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectotherExpensesDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectpriceDefaultCurrency != null)
            {
                transmitObjectObject["PriceDefaultCurrency"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectpriceDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectprofitDefaultCurrency != null)
            {
                transmitObjectObject["ProfitDefaultCurrency"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectprofitDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedProfitDefaultCurrency != null)
            {
                transmitObjectObject["EstimatedProfitDefaultCurrency"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedProfitDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectcurrencyEn != null)
            {
                transmitObjectObject["CurrencyEn"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectcurrencyEn);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedPeopleExpensesChanged != null)
            {
                transmitObjectObject["EstimatedPeopleExpensesChanged"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedPeopleExpensesChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedOtherExpensesChanged != null)
            {
                transmitObjectObject["EstimatedOtherExpensesChanged"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedOtherExpensesChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectotherExpensesChanged != null)
            {
                transmitObjectObject["OtherExpensesChanged"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectotherExpensesChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectestimatedPriceChanged != null)
            {
                transmitObjectObject["EstimatedPriceChanged"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedPriceChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectpriceChanged != null)
            {
                transmitObjectObject["PriceChanged"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectpriceChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectlicensePriceChanged != null)
            {
                transmitObjectObject["LicensePriceChanged"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectlicensePriceChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectlicensePriceDefaultCurrency != null)
            {
                transmitObjectObject["LicensePriceDefaultCurrency"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectlicensePriceDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectlastActivity != null)
            {
                transmitObjectObject["LastActivity"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectlastActivity);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectnextStep != null)
            {
                transmitObjectObject["NextStep"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectnextStep);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectpeopleExpensesChanged != null)
            {
                transmitObjectObject["PeopleExpensesChanged"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectpeopleExpensesChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectpicture != null)
            {
                transmitObjectObject["Picture"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectpicture);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectpictureWidth != null)
            {
                transmitObjectObject["PictureWidth"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectpictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectpictureHeight != null)
            {
                transmitObjectObject["PictureHeight"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectpictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectcompaniesCustomerGuid != null)
            {
                transmitObjectObject["Companies_CustomerGuid"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectcompaniesCustomerGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectcontactsContactPersonGuid != null)
            {
                transmitObjectObject["Contacts_ContactPersonGuid"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectcontactsContactPersonGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectleadsProjectOriginGuid != null)
            {
                transmitObjectObject["Leads_Project_OriginGuid"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectleadsProjectOriginGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectprojectsSuperiorProjectGuid != null)
            {
                transmitObjectObject["Projects_SuperiorProjectGuid"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectprojectsSuperiorProjectGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectusersSupervisorGuid != null)
            {
                transmitObjectObject["Users_SupervisorGuid"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectusersSupervisorGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveProjectWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = CSharpExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                saveProjectWrapper["transmitObject"] = transmitObjectObject;
                saveProjectWrapperpropCount++;
            }

            if (saveProjectWrapperdieOnItemConflict != null)
            {
                saveProjectWrapper["dieOnItemConflict"] = CSharpExpressionConverter.ConvertToken(saveProjectWrapperdieOnItemConflict);
                saveProjectWrapperpropCount++;
            }

            if (saveProjectWrapperignoredUserErrorMessages != null)
            {
                saveProjectWrapper["ignoredUserErrorMessages"] = CSharpExpressionConverter.ConvertToken(saveProjectWrapperignoredUserErrorMessages);
                saveProjectWrapperpropCount++;
            }

            if (saveProjectWrapperpropCount > 0)
            {
                callPayload.Body = saveProjectWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesBooleanResponse> SaveRelation(Expression<Func<string>> saveRelationWrappertransmitObjectitemGUID1 = null, Expression<Func<string>> saveRelationWrappertransmitObjectitemGUID2 = null, Expression<Func<saveRelationWrappertransmitObjectfolderName1Input>> saveRelationWrappertransmitObjectfolderName1 = null, Expression<Func<saveRelationWrappertransmitObjectfolderName2Input>> saveRelationWrappertransmitObjectfolderName2 = null)
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
                transmitObjectObject["ItemGUID1"] = CSharpExpressionConverter.ConvertToken(saveRelationWrappertransmitObjectitemGUID1);
                transmitObjectObjectpropCount++;
            }

            if (saveRelationWrappertransmitObjectitemGUID2 != null)
            {
                transmitObjectObject["ItemGUID2"] = CSharpExpressionConverter.ConvertToken(saveRelationWrappertransmitObjectitemGUID2);
                transmitObjectObjectpropCount++;
            }

            if (saveRelationWrappertransmitObjectfolderName1 != null)
            {
                transmitObjectObject["FolderName1"] = CSharpExpressionConverter.Convert(saveRelationWrappertransmitObjectfolderName1);
                transmitObjectObjectpropCount++;
            }

            if (saveRelationWrappertransmitObjectfolderName2 != null)
            {
                transmitObjectObject["FolderName2"] = CSharpExpressionConverter.Convert(saveRelationWrappertransmitObjectfolderName2);
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
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveTask(Expression<Func<string>> saveTaskWrappertransmitObjectbody = null, Expression<Func<bool>> saveTaskWrappertransmitObjectisCompleted = null, Expression<Func<string>> saveTaskWrappertransmitObjectdueDate = null, Expression<Func<double>> saveTaskWrappertransmitObjectpercentCompleteDecimal = null, Expression<Func<string>> saveTaskWrappertransmitObjectprevStateEn = null, Expression<Func<string>> saveTaskWrappertransmitObjectstartDate = null, Expression<Func<string>> saveTaskWrappertransmitObjectstateEn = null, Expression<Func<string>> saveTaskWrappertransmitObjectsubject = null, Expression<Func<string>> saveTaskWrappertransmitObjecttypeEn = null, Expression<Func<int>> saveTaskWrappertransmitObjectlevel = null, Expression<Func<string>> saveTaskWrappertransmitObjectimportanceEn = null, Expression<Func<double>> saveTaskWrappertransmitObjectactualWorkHours = null, Expression<Func<double>> saveTaskWrappertransmitObjectestimatedWorkHours = null, Expression<Func<bool>> saveTaskWrappertransmitObjectisReminderSet = null, Expression<Func<string>> saveTaskWrappertransmitObjectreminderDate = null, Expression<Func<string>> saveTaskWrappertransmitObjectcompletedDate = null, Expression<Func<string>> saveTaskWrappertransmitObjectpicture = null, Expression<Func<int>> saveTaskWrappertransmitObjectpictureWidth = null, Expression<Func<int>> saveTaskWrappertransmitObjectpictureHeight = null, Expression<Func<string>> saveTaskWrappertransmitObjectleadsTaskParentGuid = null, Expression<Func<string>> saveTaskWrappertransmitObjectprojectsTaskParentGuid = null, Expression<Func<string>> saveTaskWrappertransmitObjecttasksTaskParentGuid = null, Expression<Func<string>> saveTaskWrappertransmitObjectmarketingTaskParentGuid = null, Expression<Func<string>> saveTaskWrappertransmitObjectcompaniesCompanyGuid = null, Expression<Func<string>> saveTaskWrappertransmitObjectcontactsContactGuid = null, Expression<Func<string>> saveTaskWrappertransmitObjectusersTaskDelegatorGuid = null, Expression<Func<string>> saveTaskWrappertransmitObjectusersTaskSolverGuid = null, Expression<Func<string>> saveTaskWrappertransmitObjecttasksTaskOriginGuid = null, Expression<Func<bool>> saveTaskWrappertransmitObjectisPrivate = null, Expression<Func<string>> saveTaskWrappertransmitObjectitemCreated = null, Expression<Func<string>> saveTaskWrappertransmitObjectitemChanged = null, Expression<Func<string>> saveTaskWrappertransmitObjectfileAs = null, Expression<Func<string>> saveTaskWrappertransmitObjectownerGUID = null, Expression<Func<string>> saveTaskWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> saveTaskWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> saveTaskWrappertransmitObjectadditionalFields = null, Expression<Func<string>> saveTaskWrappertransmitObjectitemGUID = null, Expression<Func<int>> saveTaskWrappertransmitObjectitemVersion = null, Expression<Func<bool>> saveTaskWrapperdieOnItemConflict = null, Expression<Func<string[]>> saveTaskWrapperignoredUserErrorMessages = null)
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
                transmitObjectObject["Body"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectbody);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectisCompleted != null)
            {
                transmitObjectObject["IsCompleted"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectisCompleted);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectdueDate != null)
            {
                transmitObjectObject["DueDate"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectdueDate);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectpercentCompleteDecimal != null)
            {
                transmitObjectObject["PercentCompleteDecimal"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectpercentCompleteDecimal);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectstartDate != null)
            {
                transmitObjectObject["StartDate"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectstartDate);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectsubject != null)
            {
                transmitObjectObject["Subject"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectsubject);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectlevel != null)
            {
                transmitObjectObject["Level"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectlevel);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectimportanceEn != null)
            {
                transmitObjectObject["ImportanceEn"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectimportanceEn);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectactualWorkHours != null)
            {
                transmitObjectObject["ActualWorkHours"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectactualWorkHours);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectestimatedWorkHours != null)
            {
                transmitObjectObject["EstimatedWorkHours"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectestimatedWorkHours);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectisReminderSet != null)
            {
                transmitObjectObject["IsReminderSet"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectisReminderSet);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectreminderDate != null)
            {
                transmitObjectObject["ReminderDate"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectreminderDate);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectcompletedDate != null)
            {
                transmitObjectObject["CompletedDate"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectcompletedDate);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectpicture != null)
            {
                transmitObjectObject["Picture"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectpicture);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectpictureWidth != null)
            {
                transmitObjectObject["PictureWidth"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectpictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectpictureHeight != null)
            {
                transmitObjectObject["PictureHeight"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectpictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectleadsTaskParentGuid != null)
            {
                transmitObjectObject["Leads_TaskParentGuid"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectleadsTaskParentGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectprojectsTaskParentGuid != null)
            {
                transmitObjectObject["Projects_TaskParentGuid"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectprojectsTaskParentGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjecttasksTaskParentGuid != null)
            {
                transmitObjectObject["Tasks_TaskParentGuid"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjecttasksTaskParentGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectmarketingTaskParentGuid != null)
            {
                transmitObjectObject["Marketing_TaskParentGuid"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectmarketingTaskParentGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectcompaniesCompanyGuid != null)
            {
                transmitObjectObject["Companies_CompanyGuid"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectcompaniesCompanyGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectcontactsContactGuid != null)
            {
                transmitObjectObject["Contacts_ContactGuid"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectcontactsContactGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectusersTaskDelegatorGuid != null)
            {
                transmitObjectObject["Users_TaskDelegatorGuid"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectusersTaskDelegatorGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectusersTaskSolverGuid != null)
            {
                transmitObjectObject["Users_TaskSolverGuid"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectusersTaskSolverGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjecttasksTaskOriginGuid != null)
            {
                transmitObjectObject["Tasks_TaskOriginGuid"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjecttasksTaskOriginGuid);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (saveTaskWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = CSharpExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                saveTaskWrapper["transmitObject"] = transmitObjectObject;
                saveTaskWrapperpropCount++;
            }

            if (saveTaskWrapperdieOnItemConflict != null)
            {
                saveTaskWrapper["dieOnItemConflict"] = CSharpExpressionConverter.ConvertToken(saveTaskWrapperdieOnItemConflict);
                saveTaskWrapperpropCount++;
            }

            if (saveTaskWrapperignoredUserErrorMessages != null)
            {
                saveTaskWrapper["ignoredUserErrorMessages"] = CSharpExpressionConverter.ConvertToken(saveTaskWrapperignoredUserErrorMessages);
                saveTaskWrapperpropCount++;
            }

            if (saveTaskWrapperpropCount > 0)
            {
                callPayload.Body = saveTaskWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany> SearchCompanies(Expression<Func<string>> searchCompaniesWrappertransmitObjectaccountNumber = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress1POBox = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress1Street = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress1City = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress1State = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress1CountryEn = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress1PostalCode = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress2POBox = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress2Street = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress2City = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress2State = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress2CountryEn = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress2PostalCode = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress3POBox = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress3Street = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress3City = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress3State = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress3CountryEn = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress3PostalCode = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectcompanyName = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectdepartment = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectemail = null, Expression<Func<int>> searchCompaniesWrappertransmitObjectemployeesCount = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectfax = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectfirstContactEn = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectiCQ = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectidentificationNumber = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectimportanceEn = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectlineOfBusiness = null, Expression<Func<bool>> searchCompaniesWrappertransmitObjectmailingListOther = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectmobile = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectmobileNormalized = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectmSN = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectnote = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectphone = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectphoneNormalized = null, Expression<Func<bool>> searchCompaniesWrappertransmitObjectpurchaser = null, Expression<Func<double>> searchCompaniesWrappertransmitObjectreversal = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectskype = null, Expression<Func<bool>> searchCompaniesWrappertransmitObjectsuppliers = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectvATNumber = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectwebPage = null, Expression<Func<double>> searchCompaniesWrappertransmitObjectadditionalDiscount = null, Expression<Func<int>> searchCompaniesWrappertransmitObjectiD = null, Expression<Func<bool>> searchCompaniesWrappertransmitObjectcompetitor = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectsalePriceGuid = null, Expression<Func<bool>> searchCompaniesWrappertransmitObjectnotificationByEmail = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectnotificationBy = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectlastActivity = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectnextStep = null, Expression<Func<bool>> searchCompaniesWrappertransmitObjectemailOptOut = null, Expression<Func<string>> searchCompaniesWrappertransmitObjecttypeEn = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectstateEn = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectprevStateEn = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectpicture = null, Expression<Func<int>> searchCompaniesWrappertransmitObjectpictureWidth = null, Expression<Func<int>> searchCompaniesWrappertransmitObjectpictureHeight = null, Expression<Func<bool>> searchCompaniesWrappertransmitObjectisPrivate = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectserverItemCreated = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectserverItemChanged = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectitemCreated = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectitemChanged = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectfileAs = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectownerGUID = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> searchCompaniesWrappertransmitObjectadditionalFields = null, Expression<Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]>> searchCompaniesWrappertransmitObjectrelations = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectitemGUID = null, Expression<Func<int>> searchCompaniesWrappertransmitObjectitemVersion = null, Expression<Func<bool>> searchCompaniesWrapperincludeRelations = null, Expression<Func<string>> searchCompaniesWrapperrelationsFilterrelationType = null, Expression<Func<string>> searchCompaniesWrapperrelationsFilterforeignFolderName = null, Expression<Func<string>> searchCompaniesWrapperbinaryLogicalOperator = null)
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
                transmitObjectObject["AccountNumber"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaccountNumber);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress1POBox != null)
            {
                transmitObjectObject["Address1POBox"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress1POBox);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress1Street != null)
            {
                transmitObjectObject["Address1Street"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress1Street);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress1City != null)
            {
                transmitObjectObject["Address1City"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress1City);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress1State != null)
            {
                transmitObjectObject["Address1State"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress1State);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress1CountryEn != null)
            {
                transmitObjectObject["Address1CountryEn"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress1CountryEn);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress1PostalCode != null)
            {
                transmitObjectObject["Address1PostalCode"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress1PostalCode);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress2POBox != null)
            {
                transmitObjectObject["Address2POBox"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress2POBox);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress2Street != null)
            {
                transmitObjectObject["Address2Street"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress2Street);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress2City != null)
            {
                transmitObjectObject["Address2City"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress2City);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress2State != null)
            {
                transmitObjectObject["Address2State"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress2State);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress2CountryEn != null)
            {
                transmitObjectObject["Address2CountryEn"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress2CountryEn);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress2PostalCode != null)
            {
                transmitObjectObject["Address2PostalCode"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress2PostalCode);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress3POBox != null)
            {
                transmitObjectObject["Address3POBox"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress3POBox);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress3Street != null)
            {
                transmitObjectObject["Address3Street"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress3Street);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress3City != null)
            {
                transmitObjectObject["Address3City"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress3City);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress3State != null)
            {
                transmitObjectObject["Address3State"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress3State);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress3CountryEn != null)
            {
                transmitObjectObject["Address3CountryEn"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress3CountryEn);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectaddress3PostalCode != null)
            {
                transmitObjectObject["Address3PostalCode"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress3PostalCode);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectcompanyName != null)
            {
                transmitObjectObject["CompanyName"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectcompanyName);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectdepartment != null)
            {
                transmitObjectObject["Department"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectdepartment);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectemail != null)
            {
                transmitObjectObject["Email"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectemail);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectemployeesCount != null)
            {
                transmitObjectObject["EmployeesCount"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectemployeesCount);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectfax != null)
            {
                transmitObjectObject["Fax"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectfax);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectfirstContactEn != null)
            {
                transmitObjectObject["FirstContactEn"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectfirstContactEn);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectiCQ != null)
            {
                transmitObjectObject["ICQ"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectiCQ);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectidentificationNumber != null)
            {
                transmitObjectObject["IdentificationNumber"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectidentificationNumber);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectimportanceEn != null)
            {
                transmitObjectObject["ImportanceEn"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectimportanceEn);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectlineOfBusiness != null)
            {
                transmitObjectObject["LineOfBusiness"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectlineOfBusiness);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectmailingListOther != null)
            {
                transmitObjectObject["MailingListOther"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectmailingListOther);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectmobile != null)
            {
                transmitObjectObject["Mobile"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectmobile);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectmobileNormalized != null)
            {
                transmitObjectObject["MobileNormalized"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectmobileNormalized);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectmSN != null)
            {
                transmitObjectObject["MSN"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectmSN);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectnote != null)
            {
                transmitObjectObject["Note"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectnote);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectphone != null)
            {
                transmitObjectObject["Phone"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectphone);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectphoneNormalized != null)
            {
                transmitObjectObject["PhoneNormalized"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectphoneNormalized);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectpurchaser != null)
            {
                transmitObjectObject["Purchaser"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectpurchaser);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectreversal != null)
            {
                transmitObjectObject["Reversal"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectreversal);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectskype != null)
            {
                transmitObjectObject["Skype"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectskype);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectsuppliers != null)
            {
                transmitObjectObject["Suppliers"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectsuppliers);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectvATNumber != null)
            {
                transmitObjectObject["VATNumber"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectvATNumber);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectwebPage != null)
            {
                transmitObjectObject["WebPage"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectwebPage);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectadditionalDiscount != null)
            {
                transmitObjectObject["AdditionalDiscount"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectadditionalDiscount);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectiD != null)
            {
                transmitObjectObject["ID"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectiD);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectcompetitor != null)
            {
                transmitObjectObject["Competitor"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectcompetitor);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectsalePriceGuid != null)
            {
                transmitObjectObject["SalePriceGuid"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectsalePriceGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectnotificationByEmail != null)
            {
                transmitObjectObject["NotificationByEmail"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectnotificationByEmail);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectnotificationBy != null)
            {
                transmitObjectObject["NotificationBy"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectnotificationBy);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectlastActivity != null)
            {
                transmitObjectObject["LastActivity"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectlastActivity);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectnextStep != null)
            {
                transmitObjectObject["NextStep"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectnextStep);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectemailOptOut != null)
            {
                transmitObjectObject["EmailOptOut"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectemailOptOut);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectpicture != null)
            {
                transmitObjectObject["Picture"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectpicture);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectpictureWidth != null)
            {
                transmitObjectObject["PictureWidth"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectpictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectpictureHeight != null)
            {
                transmitObjectObject["PictureHeight"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectpictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectserverItemCreated != null)
            {
                transmitObjectObject["Server_ItemCreated"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectserverItemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectserverItemChanged != null)
            {
                transmitObjectObject["Server_ItemChanged"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectserverItemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectrelations != null)
            {
                transmitObjectObject["Relations"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectrelations);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchCompaniesWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                searchCompaniesWrapper["transmitObject"] = transmitObjectObject;
                searchCompaniesWrapperpropCount++;
            }

            if (searchCompaniesWrapperincludeRelations != null)
            {
                searchCompaniesWrapper["includeRelations"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrapperincludeRelations);
                searchCompaniesWrapperpropCount++;
            }

            var relationsFilterObject = new JObject();
            var relationsFilterObjectpropCount = 0;
            if (searchCompaniesWrapperrelationsFilterrelationType != null)
            {
                relationsFilterObject["RelationType"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrapperrelationsFilterrelationType);
                relationsFilterObjectpropCount++;
            }

            if (searchCompaniesWrapperrelationsFilterforeignFolderName != null)
            {
                relationsFilterObject["ForeignFolderName"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrapperrelationsFilterforeignFolderName);
                relationsFilterObjectpropCount++;
            }

            if (relationsFilterObjectpropCount > 0)
            {
                searchCompaniesWrapper["relationsFilter"] = relationsFilterObject;
                searchCompaniesWrapperpropCount++;
            }

            if (searchCompaniesWrapperbinaryLogicalOperator != null)
            {
                searchCompaniesWrapper["binaryLogicalOperator"] = CSharpExpressionConverter.ConvertToken(searchCompaniesWrapperbinaryLogicalOperator);
                searchCompaniesWrapperpropCount++;
            }

            if (searchCompaniesWrapperpropCount > 0)
            {
                callPayload.Body = searchCompaniesWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact> SearchContacts(Expression<Func<string>> searchContactsWrappertransmitObjectcompaniesCompanyGuid = null, Expression<Func<string>> searchContactsWrappertransmitObjectbusinessAddressStreet = null, Expression<Func<string>> searchContactsWrappertransmitObjectbusinessAddressCity = null, Expression<Func<string>> searchContactsWrappertransmitObjectbusinessAddressState = null, Expression<Func<string>> searchContactsWrappertransmitObjectbusinessAddressCountryEn = null, Expression<Func<string>> searchContactsWrappertransmitObjectbusinessAddressPOBox = null, Expression<Func<string>> searchContactsWrappertransmitObjectbusinessAddressPostalCode = null, Expression<Func<string>> searchContactsWrappertransmitObjecthomeAddressStreet = null, Expression<Func<string>> searchContactsWrappertransmitObjecthomeAddressCity = null, Expression<Func<string>> searchContactsWrappertransmitObjecthomeAddressState = null, Expression<Func<string>> searchContactsWrappertransmitObjecthomeAddressCountryEn = null, Expression<Func<string>> searchContactsWrappertransmitObjecthomeAddressPOBox = null, Expression<Func<string>> searchContactsWrappertransmitObjecthomeAddressPostalCode = null, Expression<Func<string>> searchContactsWrappertransmitObjectotherAddressStreet = null, Expression<Func<string>> searchContactsWrappertransmitObjectotherAddressCity = null, Expression<Func<string>> searchContactsWrappertransmitObjectotherAddressState = null, Expression<Func<string>> searchContactsWrappertransmitObjectotherAddressCountryEn = null, Expression<Func<string>> searchContactsWrappertransmitObjectotherAddressPOBox = null, Expression<Func<string>> searchContactsWrappertransmitObjectotherAddressPostalCode = null, Expression<Func<string>> searchContactsWrappertransmitObjectcompany = null, Expression<Func<string>> searchContactsWrappertransmitObjectemail1Address = null, Expression<Func<string>> searchContactsWrappertransmitObjectemail2Address = null, Expression<Func<string>> searchContactsWrappertransmitObjectemail3Address = null, Expression<Func<string>> searchContactsWrappertransmitObjectfirstName = null, Expression<Func<string>> searchContactsWrappertransmitObjectiCQ = null, Expression<Func<string>> searchContactsWrappertransmitObjectimportanceEn = null, Expression<Func<string>> searchContactsWrappertransmitObjectlastName = null, Expression<Func<string>> searchContactsWrappertransmitObjectmiddleName = null, Expression<Func<string>> searchContactsWrappertransmitObjectmSN = null, Expression<Func<string>> searchContactsWrappertransmitObjectnote = null, Expression<Func<string>> searchContactsWrappertransmitObjectprefixEn = null, Expression<Func<string>> searchContactsWrappertransmitObjectsuffixEn = null, Expression<Func<string>> searchContactsWrappertransmitObjectskype = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber1 = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber2 = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber3 = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber4 = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber5 = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber6 = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber1Normalized = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber2Normalized = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber3Normalized = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber4Normalized = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber5Normalized = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber6Normalized = null, Expression<Func<string>> searchContactsWrappertransmitObjectdepartment = null, Expression<Func<string>> searchContactsWrappertransmitObjecttitle = null, Expression<Func<string>> searchContactsWrappertransmitObjectwebPage = null, Expression<Func<bool>> searchContactsWrappertransmitObjectdoNotSendNewsletter = null, Expression<Func<string>> searchContactsWrappertransmitObjectprofilePicture = null, Expression<Func<int>> searchContactsWrappertransmitObjectprofilePictureWidth = null, Expression<Func<int>> searchContactsWrappertransmitObjectprofilePictureHeight = null, Expression<Func<string>> searchContactsWrappertransmitObjectlastActivity = null, Expression<Func<string>> searchContactsWrappertransmitObjectnextStep = null, Expression<Func<string>> searchContactsWrappertransmitObjecttypeEn = null, Expression<Func<string>> searchContactsWrappertransmitObjectstateEn = null, Expression<Func<string>> searchContactsWrappertransmitObjectprevStateEn = null, Expression<Func<bool>> searchContactsWrappertransmitObjectisPrivate = null, Expression<Func<string>> searchContactsWrappertransmitObjectserverItemCreated = null, Expression<Func<string>> searchContactsWrappertransmitObjectserverItemChanged = null, Expression<Func<string>> searchContactsWrappertransmitObjectitemCreated = null, Expression<Func<string>> searchContactsWrappertransmitObjectitemChanged = null, Expression<Func<string>> searchContactsWrappertransmitObjectfileAs = null, Expression<Func<string>> searchContactsWrappertransmitObjectownerGUID = null, Expression<Func<string>> searchContactsWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> searchContactsWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> searchContactsWrappertransmitObjectadditionalFields = null, Expression<Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]>> searchContactsWrappertransmitObjectrelations = null, Expression<Func<string>> searchContactsWrappertransmitObjectitemGUID = null, Expression<Func<int>> searchContactsWrappertransmitObjectitemVersion = null, Expression<Func<bool>> searchContactsWrapperincludeRelations = null, Expression<Func<string>> searchContactsWrapperrelationsFilterrelationType = null, Expression<Func<string>> searchContactsWrapperrelationsFilterforeignFolderName = null, Expression<Func<bool>> searchContactsWrapperincludeProfilePictures = null, Expression<Func<string>> searchContactsWrapperbinaryLogicalOperator = null)
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
                transmitObjectObject["Companies_CompanyGuid"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectcompaniesCompanyGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectbusinessAddressStreet != null)
            {
                transmitObjectObject["BusinessAddressStreet"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectbusinessAddressStreet);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectbusinessAddressCity != null)
            {
                transmitObjectObject["BusinessAddressCity"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectbusinessAddressCity);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectbusinessAddressState != null)
            {
                transmitObjectObject["BusinessAddressState"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectbusinessAddressState);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectbusinessAddressCountryEn != null)
            {
                transmitObjectObject["BusinessAddressCountryEn"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectbusinessAddressCountryEn);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectbusinessAddressPOBox != null)
            {
                transmitObjectObject["BusinessAddressPOBox"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectbusinessAddressPOBox);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectbusinessAddressPostalCode != null)
            {
                transmitObjectObject["BusinessAddressPostalCode"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectbusinessAddressPostalCode);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecthomeAddressStreet != null)
            {
                transmitObjectObject["HomeAddressStreet"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecthomeAddressStreet);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecthomeAddressCity != null)
            {
                transmitObjectObject["HomeAddressCity"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecthomeAddressCity);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecthomeAddressState != null)
            {
                transmitObjectObject["HomeAddressState"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecthomeAddressState);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecthomeAddressCountryEn != null)
            {
                transmitObjectObject["HomeAddressCountryEn"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecthomeAddressCountryEn);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecthomeAddressPOBox != null)
            {
                transmitObjectObject["HomeAddressPOBox"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecthomeAddressPOBox);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecthomeAddressPostalCode != null)
            {
                transmitObjectObject["HomeAddressPostalCode"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecthomeAddressPostalCode);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectotherAddressStreet != null)
            {
                transmitObjectObject["OtherAddressStreet"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectotherAddressStreet);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectotherAddressCity != null)
            {
                transmitObjectObject["OtherAddressCity"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectotherAddressCity);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectotherAddressState != null)
            {
                transmitObjectObject["OtherAddressState"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectotherAddressState);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectotherAddressCountryEn != null)
            {
                transmitObjectObject["OtherAddressCountryEn"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectotherAddressCountryEn);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectotherAddressPOBox != null)
            {
                transmitObjectObject["OtherAddressPOBox"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectotherAddressPOBox);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectotherAddressPostalCode != null)
            {
                transmitObjectObject["OtherAddressPostalCode"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectotherAddressPostalCode);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectcompany != null)
            {
                transmitObjectObject["Company"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectcompany);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectemail1Address != null)
            {
                transmitObjectObject["Email1Address"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectemail1Address);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectemail2Address != null)
            {
                transmitObjectObject["Email2Address"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectemail2Address);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectemail3Address != null)
            {
                transmitObjectObject["Email3Address"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectemail3Address);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectfirstName != null)
            {
                transmitObjectObject["FirstName"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectfirstName);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectiCQ != null)
            {
                transmitObjectObject["ICQ"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectiCQ);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectimportanceEn != null)
            {
                transmitObjectObject["ImportanceEn"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectimportanceEn);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectlastName != null)
            {
                transmitObjectObject["LastName"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectlastName);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectmiddleName != null)
            {
                transmitObjectObject["MiddleName"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectmiddleName);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectmSN != null)
            {
                transmitObjectObject["MSN"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectmSN);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectnote != null)
            {
                transmitObjectObject["Note"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectnote);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectprefixEn != null)
            {
                transmitObjectObject["PrefixEn"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectprefixEn);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectsuffixEn != null)
            {
                transmitObjectObject["SuffixEn"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectsuffixEn);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectskype != null)
            {
                transmitObjectObject["Skype"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectskype);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber1 != null)
            {
                transmitObjectObject["TelephoneNumber1"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber1);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber2 != null)
            {
                transmitObjectObject["TelephoneNumber2"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber2);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber3 != null)
            {
                transmitObjectObject["TelephoneNumber3"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber3);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber4 != null)
            {
                transmitObjectObject["TelephoneNumber4"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber4);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber5 != null)
            {
                transmitObjectObject["TelephoneNumber5"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber5);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber6 != null)
            {
                transmitObjectObject["TelephoneNumber6"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber6);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber1Normalized != null)
            {
                transmitObjectObject["TelephoneNumber1Normalized"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber1Normalized);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber2Normalized != null)
            {
                transmitObjectObject["TelephoneNumber2Normalized"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber2Normalized);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber3Normalized != null)
            {
                transmitObjectObject["TelephoneNumber3Normalized"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber3Normalized);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber4Normalized != null)
            {
                transmitObjectObject["TelephoneNumber4Normalized"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber4Normalized);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber5Normalized != null)
            {
                transmitObjectObject["TelephoneNumber5Normalized"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber5Normalized);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttelephoneNumber6Normalized != null)
            {
                transmitObjectObject["TelephoneNumber6Normalized"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber6Normalized);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectdepartment != null)
            {
                transmitObjectObject["Department"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectdepartment);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttitle != null)
            {
                transmitObjectObject["Title"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttitle);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectwebPage != null)
            {
                transmitObjectObject["WebPage"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectwebPage);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectdoNotSendNewsletter != null)
            {
                transmitObjectObject["DoNotSendNewsletter"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectdoNotSendNewsletter);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectprofilePicture != null)
            {
                transmitObjectObject["ProfilePicture"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectprofilePicture);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectprofilePictureWidth != null)
            {
                transmitObjectObject["ProfilePictureWidth"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectprofilePictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectprofilePictureHeight != null)
            {
                transmitObjectObject["ProfilePictureHeight"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectprofilePictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectlastActivity != null)
            {
                transmitObjectObject["LastActivity"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectlastActivity);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectnextStep != null)
            {
                transmitObjectObject["NextStep"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectnextStep);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectserverItemCreated != null)
            {
                transmitObjectObject["Server_ItemCreated"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectserverItemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectserverItemChanged != null)
            {
                transmitObjectObject["Server_ItemChanged"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectserverItemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectrelations != null)
            {
                transmitObjectObject["Relations"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectrelations);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchContactsWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = CSharpExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                searchContactsWrapper["transmitObject"] = transmitObjectObject;
                searchContactsWrapperpropCount++;
            }

            if (searchContactsWrapperincludeRelations != null)
            {
                searchContactsWrapper["includeRelations"] = CSharpExpressionConverter.ConvertToken(searchContactsWrapperincludeRelations);
                searchContactsWrapperpropCount++;
            }

            var relationsFilterObject = new JObject();
            var relationsFilterObjectpropCount = 0;
            if (searchContactsWrapperrelationsFilterrelationType != null)
            {
                relationsFilterObject["RelationType"] = CSharpExpressionConverter.ConvertToken(searchContactsWrapperrelationsFilterrelationType);
                relationsFilterObjectpropCount++;
            }

            if (searchContactsWrapperrelationsFilterforeignFolderName != null)
            {
                relationsFilterObject["ForeignFolderName"] = CSharpExpressionConverter.ConvertToken(searchContactsWrapperrelationsFilterforeignFolderName);
                relationsFilterObjectpropCount++;
            }

            if (relationsFilterObjectpropCount > 0)
            {
                searchContactsWrapper["relationsFilter"] = relationsFilterObject;
                searchContactsWrapperpropCount++;
            }

            if (searchContactsWrapperincludeProfilePictures != null)
            {
                searchContactsWrapper["includeProfilePictures"] = CSharpExpressionConverter.ConvertToken(searchContactsWrapperincludeProfilePictures);
                searchContactsWrapperpropCount++;
            }

            if (searchContactsWrapperbinaryLogicalOperator != null)
            {
                searchContactsWrapper["binaryLogicalOperator"] = CSharpExpressionConverter.ConvertToken(searchContactsWrapperbinaryLogicalOperator);
                searchContactsWrapperpropCount++;
            }

            if (searchContactsWrapperpropCount > 0)
            {
                callPayload.Body = searchContactsWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal> SearchJournals(Expression<Func<string>> searchJournalsWrappertransmitObjectmarketingSuperiorItemGuid = null, Expression<Func<string>> searchJournalsWrappertransmitObjectcompaniesCompanyGuid = null, Expression<Func<string>> searchJournalsWrappertransmitObjectcontactsContactGuid = null, Expression<Func<string>> searchJournalsWrappertransmitObjectleadsSuperiorItemGuid = null, Expression<Func<string>> searchJournalsWrappertransmitObjectprojectsSuperiorItemGuid = null, Expression<Func<string>> searchJournalsWrappertransmitObjectmarketingMarketingGuid = null, Expression<Func<string>> searchJournalsWrappertransmitObjectcalendarEntryID = null, Expression<Func<string>> searchJournalsWrappertransmitObjectcalendarORIGIN = null, Expression<Func<string>> searchJournalsWrappertransmitObjectchangedField = null, Expression<Func<string>> searchJournalsWrappertransmitObjecteventEnd = null, Expression<Func<string>> searchJournalsWrappertransmitObjecteventStart = null, Expression<Func<string>> searchJournalsWrappertransmitObjectfieldValue = null, Expression<Func<string>> searchJournalsWrappertransmitObjectimportanceEn = null, Expression<Func<string>> searchJournalsWrappertransmitObjectnote = null, Expression<Func<string>> searchJournalsWrappertransmitObjectprevFieldValue = null, Expression<Func<string>> searchJournalsWrappertransmitObjecttypeEn = null, Expression<Func<bool>> searchJournalsWrappertransmitObjectisSystem = null, Expression<Func<string>> searchJournalsWrappertransmitObjectphone = null, Expression<Func<string>> searchJournalsWrappertransmitObjectphoneNormalized = null, Expression<Func<bool>> searchJournalsWrappertransmitObjectisGdprRelevant = null, Expression<Func<string>> searchJournalsWrappertransmitObjectpicture = null, Expression<Func<int>> searchJournalsWrappertransmitObjectpictureWidth = null, Expression<Func<int>> searchJournalsWrappertransmitObjectpictureHeight = null, Expression<Func<string>> searchJournalsWrappertransmitObjectstateEn = null, Expression<Func<string>> searchJournalsWrappertransmitObjectprevStateEn = null, Expression<Func<bool>> searchJournalsWrappertransmitObjectisPrivate = null, Expression<Func<string>> searchJournalsWrappertransmitObjectserverItemCreated = null, Expression<Func<string>> searchJournalsWrappertransmitObjectserverItemChanged = null, Expression<Func<string>> searchJournalsWrappertransmitObjectitemCreated = null, Expression<Func<string>> searchJournalsWrappertransmitObjectitemChanged = null, Expression<Func<string>> searchJournalsWrappertransmitObjectfileAs = null, Expression<Func<string>> searchJournalsWrappertransmitObjectownerGUID = null, Expression<Func<string>> searchJournalsWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> searchJournalsWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> searchJournalsWrappertransmitObjectadditionalFields = null, Expression<Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]>> searchJournalsWrappertransmitObjectrelations = null, Expression<Func<string>> searchJournalsWrappertransmitObjectitemGUID = null, Expression<Func<int>> searchJournalsWrappertransmitObjectitemVersion = null, Expression<Func<bool>> searchJournalsWrapperincludeRelations = null, Expression<Func<string>> searchJournalsWrapperrelationsFilterrelationType = null, Expression<Func<string>> searchJournalsWrapperrelationsFilterforeignFolderName = null, Expression<Func<string>> searchJournalsWrapperbinaryLogicalOperator = null)
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
                transmitObjectObject["Marketing_SuperiorItemGuid"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectmarketingSuperiorItemGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectcompaniesCompanyGuid != null)
            {
                transmitObjectObject["Companies_CompanyGuid"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectcompaniesCompanyGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectcontactsContactGuid != null)
            {
                transmitObjectObject["Contacts_ContactGuid"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectcontactsContactGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectleadsSuperiorItemGuid != null)
            {
                transmitObjectObject["Leads_SuperiorItemGuid"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectleadsSuperiorItemGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectprojectsSuperiorItemGuid != null)
            {
                transmitObjectObject["Projects_SuperiorItemGuid"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectprojectsSuperiorItemGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectmarketingMarketingGuid != null)
            {
                transmitObjectObject["Marketing_MarketingGuid"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectmarketingMarketingGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectcalendarEntryID != null)
            {
                transmitObjectObject["CalendarEntryID"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectcalendarEntryID);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectcalendarORIGIN != null)
            {
                transmitObjectObject["Calendar_ORIGIN"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectcalendarORIGIN);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectchangedField != null)
            {
                transmitObjectObject["ChangedField"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectchangedField);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjecteventEnd != null)
            {
                transmitObjectObject["EventEnd"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjecteventEnd);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjecteventStart != null)
            {
                transmitObjectObject["EventStart"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjecteventStart);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectfieldValue != null)
            {
                transmitObjectObject["FieldValue"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectfieldValue);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectimportanceEn != null)
            {
                transmitObjectObject["ImportanceEn"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectimportanceEn);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectnote != null)
            {
                transmitObjectObject["Note"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectnote);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectprevFieldValue != null)
            {
                transmitObjectObject["PrevFieldValue"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectprevFieldValue);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectisSystem != null)
            {
                transmitObjectObject["IsSystem"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectisSystem);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectphone != null)
            {
                transmitObjectObject["Phone"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectphone);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectphoneNormalized != null)
            {
                transmitObjectObject["PhoneNormalized"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectphoneNormalized);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectisGdprRelevant != null)
            {
                transmitObjectObject["IsGdprRelevant"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectisGdprRelevant);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectpicture != null)
            {
                transmitObjectObject["Picture"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectpicture);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectpictureWidth != null)
            {
                transmitObjectObject["PictureWidth"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectpictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectpictureHeight != null)
            {
                transmitObjectObject["PictureHeight"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectpictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectserverItemCreated != null)
            {
                transmitObjectObject["Server_ItemCreated"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectserverItemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectserverItemChanged != null)
            {
                transmitObjectObject["Server_ItemChanged"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectserverItemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectrelations != null)
            {
                transmitObjectObject["Relations"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectrelations);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchJournalsWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                searchJournalsWrapper["transmitObject"] = transmitObjectObject;
                searchJournalsWrapperpropCount++;
            }

            if (searchJournalsWrapperincludeRelations != null)
            {
                searchJournalsWrapper["includeRelations"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrapperincludeRelations);
                searchJournalsWrapperpropCount++;
            }

            var relationsFilterObject = new JObject();
            var relationsFilterObjectpropCount = 0;
            if (searchJournalsWrapperrelationsFilterrelationType != null)
            {
                relationsFilterObject["RelationType"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrapperrelationsFilterrelationType);
                relationsFilterObjectpropCount++;
            }

            if (searchJournalsWrapperrelationsFilterforeignFolderName != null)
            {
                relationsFilterObject["ForeignFolderName"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrapperrelationsFilterforeignFolderName);
                relationsFilterObjectpropCount++;
            }

            if (relationsFilterObjectpropCount > 0)
            {
                searchJournalsWrapper["relationsFilter"] = relationsFilterObject;
                searchJournalsWrapperpropCount++;
            }

            if (searchJournalsWrapperbinaryLogicalOperator != null)
            {
                searchJournalsWrapper["binaryLogicalOperator"] = CSharpExpressionConverter.ConvertToken(searchJournalsWrapperbinaryLogicalOperator);
                searchJournalsWrapperpropCount++;
            }

            if (searchJournalsWrapperpropCount > 0)
            {
                callPayload.Body = searchJournalsWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead> SearchLeads(Expression<Func<string>> searchLeadsWrappertransmitObjectcompaniesCustomerGuid = null, Expression<Func<string>> searchLeadsWrappertransmitObjectcontactsContactPersonGuid = null, Expression<Func<string>> searchLeadsWrappertransmitObjectmarketingMarketingGuid = null, Expression<Func<string>> searchLeadsWrappertransmitObjectcity = null, Expression<Func<string>> searchLeadsWrappertransmitObjectcontactPerson = null, Expression<Func<string>> searchLeadsWrappertransmitObjectcurrencyEn = null, Expression<Func<string>> searchLeadsWrappertransmitObjectcustomer = null, Expression<Func<string>> searchLeadsWrappertransmitObjectemail = null, Expression<Func<string>> searchLeadsWrappertransmitObjectestimatedEnd = null, Expression<Func<int>> searchLeadsWrappertransmitObjecthID = null, Expression<Func<string>> searchLeadsWrappertransmitObjectleadOriginEn = null, Expression<Func<string>> searchLeadsWrappertransmitObjectnote = null, Expression<Func<string>> searchLeadsWrappertransmitObjectphone = null, Expression<Func<string>> searchLeadsWrappertransmitObjectphoneNormalized = null, Expression<Func<string>> searchLeadsWrappertransmitObjectprevStateEn = null, Expression<Func<double>> searchLeadsWrappertransmitObjectprice = null, Expression<Func<string>> searchLeadsWrappertransmitObjectpriceChanged = null, Expression<Func<double>> searchLeadsWrappertransmitObjectpriceDefaultCurrency = null, Expression<Func<double>> searchLeadsWrappertransmitObjectprobability = null, Expression<Func<string>> searchLeadsWrappertransmitObjectreceiveDate = null, Expression<Func<string>> searchLeadsWrappertransmitObjectstateEn = null, Expression<Func<string>> searchLeadsWrappertransmitObjectstreet = null, Expression<Func<string>> searchLeadsWrappertransmitObjecttypeEn = null, Expression<Func<string>> searchLeadsWrappertransmitObjectzip = null, Expression<Func<string>> searchLeadsWrappertransmitObjectlastActivity = null, Expression<Func<string>> searchLeadsWrappertransmitObjectnextStep = null, Expression<Func<double>> searchLeadsWrappertransmitObjectestimatedValue = null, Expression<Func<bool>> searchLeadsWrappertransmitObjectisCompleted = null, Expression<Func<bool>> searchLeadsWrappertransmitObjectisLost = null, Expression<Func<string>> searchLeadsWrappertransmitObjectcountryEn = null, Expression<Func<string>> searchLeadsWrappertransmitObjectstate = null, Expression<Func<string>> searchLeadsWrappertransmitObjectpOBox = null, Expression<Func<bool>> searchLeadsWrappertransmitObjectemailOptOut = null, Expression<Func<string>> searchLeadsWrappertransmitObjectpicture = null, Expression<Func<int>> searchLeadsWrappertransmitObjectpictureWidth = null, Expression<Func<int>> searchLeadsWrappertransmitObjectpictureHeight = null, Expression<Func<string>> searchLeadsWrappertransmitObjectcompletedDate = null, Expression<Func<string>> searchLeadsWrappertransmitObjectlostDate = null, Expression<Func<bool>> searchLeadsWrappertransmitObjectisPrivate = null, Expression<Func<string>> searchLeadsWrappertransmitObjectserverItemCreated = null, Expression<Func<string>> searchLeadsWrappertransmitObjectserverItemChanged = null, Expression<Func<string>> searchLeadsWrappertransmitObjectitemCreated = null, Expression<Func<string>> searchLeadsWrappertransmitObjectitemChanged = null, Expression<Func<string>> searchLeadsWrappertransmitObjectfileAs = null, Expression<Func<string>> searchLeadsWrappertransmitObjectownerGUID = null, Expression<Func<string>> searchLeadsWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> searchLeadsWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> searchLeadsWrappertransmitObjectadditionalFields = null, Expression<Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]>> searchLeadsWrappertransmitObjectrelations = null, Expression<Func<string>> searchLeadsWrappertransmitObjectitemGUID = null, Expression<Func<int>> searchLeadsWrappertransmitObjectitemVersion = null, Expression<Func<bool>> searchLeadsWrapperincludeRelations = null, Expression<Func<string>> searchLeadsWrapperrelationsFilterrelationType = null, Expression<Func<string>> searchLeadsWrapperrelationsFilterforeignFolderName = null, Expression<Func<string>> searchLeadsWrapperbinaryLogicalOperator = null)
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
                transmitObjectObject["Companies_CustomerGuid"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectcompaniesCustomerGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectcontactsContactPersonGuid != null)
            {
                transmitObjectObject["Contacts_ContactPersonGuid"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectcontactsContactPersonGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectmarketingMarketingGuid != null)
            {
                transmitObjectObject["Marketing_MarketingGuid"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectmarketingMarketingGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectcity != null)
            {
                transmitObjectObject["City"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectcity);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectcontactPerson != null)
            {
                transmitObjectObject["ContactPerson"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectcontactPerson);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectcurrencyEn != null)
            {
                transmitObjectObject["CurrencyEn"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectcurrencyEn);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectcustomer != null)
            {
                transmitObjectObject["Customer"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectcustomer);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectemail != null)
            {
                transmitObjectObject["Email"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectemail);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectestimatedEnd != null)
            {
                transmitObjectObject["EstimatedEnd"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectestimatedEnd);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjecthID != null)
            {
                transmitObjectObject["HID"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjecthID);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectleadOriginEn != null)
            {
                transmitObjectObject["LeadOriginEn"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectleadOriginEn);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectnote != null)
            {
                transmitObjectObject["Note"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectnote);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectphone != null)
            {
                transmitObjectObject["Phone"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectphone);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectphoneNormalized != null)
            {
                transmitObjectObject["PhoneNormalized"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectphoneNormalized);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectprice != null)
            {
                transmitObjectObject["Price"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectprice);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectpriceChanged != null)
            {
                transmitObjectObject["PriceChanged"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectpriceChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectpriceDefaultCurrency != null)
            {
                transmitObjectObject["PriceDefaultCurrency"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectpriceDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectprobability != null)
            {
                transmitObjectObject["Probability"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectprobability);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectreceiveDate != null)
            {
                transmitObjectObject["ReceiveDate"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectreceiveDate);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectstreet != null)
            {
                transmitObjectObject["Street"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectstreet);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectzip != null)
            {
                transmitObjectObject["Zip"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectzip);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectlastActivity != null)
            {
                transmitObjectObject["LastActivity"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectlastActivity);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectnextStep != null)
            {
                transmitObjectObject["NextStep"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectnextStep);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectestimatedValue != null)
            {
                transmitObjectObject["EstimatedValue"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectestimatedValue);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectisCompleted != null)
            {
                transmitObjectObject["IsCompleted"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectisCompleted);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectisLost != null)
            {
                transmitObjectObject["IsLost"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectisLost);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectcountryEn != null)
            {
                transmitObjectObject["CountryEn"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectcountryEn);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectstate != null)
            {
                transmitObjectObject["State"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectstate);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectpOBox != null)
            {
                transmitObjectObject["POBox"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectpOBox);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectemailOptOut != null)
            {
                transmitObjectObject["EmailOptOut"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectemailOptOut);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectpicture != null)
            {
                transmitObjectObject["Picture"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectpicture);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectpictureWidth != null)
            {
                transmitObjectObject["PictureWidth"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectpictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectpictureHeight != null)
            {
                transmitObjectObject["PictureHeight"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectpictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectcompletedDate != null)
            {
                transmitObjectObject["CompletedDate"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectcompletedDate);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectlostDate != null)
            {
                transmitObjectObject["LostDate"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectlostDate);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectserverItemCreated != null)
            {
                transmitObjectObject["Server_ItemCreated"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectserverItemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectserverItemChanged != null)
            {
                transmitObjectObject["Server_ItemChanged"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectserverItemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectrelations != null)
            {
                transmitObjectObject["Relations"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectrelations);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchLeadsWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                searchLeadsWrapper["transmitObject"] = transmitObjectObject;
                searchLeadsWrapperpropCount++;
            }

            if (searchLeadsWrapperincludeRelations != null)
            {
                searchLeadsWrapper["includeRelations"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrapperincludeRelations);
                searchLeadsWrapperpropCount++;
            }

            var relationsFilterObject = new JObject();
            var relationsFilterObjectpropCount = 0;
            if (searchLeadsWrapperrelationsFilterrelationType != null)
            {
                relationsFilterObject["RelationType"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrapperrelationsFilterrelationType);
                relationsFilterObjectpropCount++;
            }

            if (searchLeadsWrapperrelationsFilterforeignFolderName != null)
            {
                relationsFilterObject["ForeignFolderName"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrapperrelationsFilterforeignFolderName);
                relationsFilterObjectpropCount++;
            }

            if (relationsFilterObjectpropCount > 0)
            {
                searchLeadsWrapper["relationsFilter"] = relationsFilterObject;
                searchLeadsWrapperpropCount++;
            }

            if (searchLeadsWrapperbinaryLogicalOperator != null)
            {
                searchLeadsWrapper["binaryLogicalOperator"] = CSharpExpressionConverter.ConvertToken(searchLeadsWrapperbinaryLogicalOperator);
                searchLeadsWrapperpropCount++;
            }

            if (searchLeadsWrapperpropCount > 0)
            {
                callPayload.Body = searchLeadsWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject> SearchProjects(Expression<Func<string>> searchProjectsWrappertransmitObjectcompaniesCustomerGuid = null, Expression<Func<string>> searchProjectsWrappertransmitObjectcontactsContactPersonGuid = null, Expression<Func<string>> searchProjectsWrappertransmitObjectleadsProjectOriginGuid = null, Expression<Func<string>> searchProjectsWrappertransmitObjectprojectsSuperiorProjectGuid = null, Expression<Func<string>> searchProjectsWrappertransmitObjectusersSupervisorGuid = null, Expression<Func<string>> searchProjectsWrappertransmitObjectnote = null, Expression<Func<double>> searchProjectsWrappertransmitObjectprice = null, Expression<Func<string>> searchProjectsWrappertransmitObjectprojectEnd = null, Expression<Func<string>> searchProjectsWrappertransmitObjectprojectName = null, Expression<Func<string>> searchProjectsWrappertransmitObjecttypeEn = null, Expression<Func<string>> searchProjectsWrappertransmitObjectstateEn = null, Expression<Func<double>> searchProjectsWrappertransmitObjectpeopleExpenses = null, Expression<Func<string>> searchProjectsWrappertransmitObjectprojectRealEnd = null, Expression<Func<double>> searchProjectsWrappertransmitObjectestimatedPrice = null, Expression<Func<int>> searchProjectsWrappertransmitObjecthID = null, Expression<Func<string>> searchProjectsWrappertransmitObjectprojectOriginEn = null, Expression<Func<string>> searchProjectsWrappertransmitObjectpaymentTypeEn = null, Expression<Func<double>> searchProjectsWrappertransmitObjectotherExpenses = null, Expression<Func<double>> searchProjectsWrappertransmitObjectmargin = null, Expression<Func<double>> searchProjectsWrappertransmitObjectprofit = null, Expression<Func<int>> searchProjectsWrappertransmitObjectpaymentMaturity = null, Expression<Func<string>> searchProjectsWrappertransmitObjectinvoicePaymentDate = null, Expression<Func<string>> searchProjectsWrappertransmitObjectinvoiceIssueDate = null, Expression<Func<double>> searchProjectsWrappertransmitObjectestimatedMargin = null, Expression<Func<double>> searchProjectsWrappertransmitObjectestimatedProfit = null, Expression<Func<double>> searchProjectsWrappertransmitObjectestimatedPeopleExpenses = null, Expression<Func<double>> searchProjectsWrappertransmitObjectestimatedOtherExpenses = null, Expression<Func<int>> searchProjectsWrappertransmitObjectlicensesCount = null, Expression<Func<double>> searchProjectsWrappertransmitObjectlicensePrice = null, Expression<Func<string>> searchProjectsWrappertransmitObjectprevStateEn = null, Expression<Func<bool>> searchProjectsWrappertransmitObjectshowInCaplan = null, Expression<Func<string>> searchProjectsWrappertransmitObjectprojectStart = null, Expression<Func<int>> searchProjectsWrappertransmitObjectestimatedWorkHours = null, Expression<Func<double>> searchProjectsWrappertransmitObjecttotalWorkHours = null, Expression<Func<double>> searchProjectsWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency = null, Expression<Func<double>> searchProjectsWrappertransmitObjectestimatedOtherExpensesDefaultCurrency = null, Expression<Func<double>> searchProjectsWrappertransmitObjectestimatedPriceDefaultCurrency = null, Expression<Func<double>> searchProjectsWrappertransmitObjectpeopleExpensesDefaultCurrency = null, Expression<Func<double>> searchProjectsWrappertransmitObjectotherExpensesDefaultCurrency = null, Expression<Func<double>> searchProjectsWrappertransmitObjectpriceDefaultCurrency = null, Expression<Func<double>> searchProjectsWrappertransmitObjectprofitDefaultCurrency = null, Expression<Func<double>> searchProjectsWrappertransmitObjectestimatedProfitDefaultCurrency = null, Expression<Func<string>> searchProjectsWrappertransmitObjectcurrencyEn = null, Expression<Func<string>> searchProjectsWrappertransmitObjectestimatedPeopleExpensesChanged = null, Expression<Func<string>> searchProjectsWrappertransmitObjectestimatedOtherExpensesChanged = null, Expression<Func<string>> searchProjectsWrappertransmitObjectotherExpensesChanged = null, Expression<Func<string>> searchProjectsWrappertransmitObjectestimatedPriceChanged = null, Expression<Func<string>> searchProjectsWrappertransmitObjectpriceChanged = null, Expression<Func<string>> searchProjectsWrappertransmitObjectlicensePriceChanged = null, Expression<Func<double>> searchProjectsWrappertransmitObjectlicensePriceDefaultCurrency = null, Expression<Func<string>> searchProjectsWrappertransmitObjectlastActivity = null, Expression<Func<string>> searchProjectsWrappertransmitObjectnextStep = null, Expression<Func<string>> searchProjectsWrappertransmitObjectcompletedDate = null, Expression<Func<bool>> searchProjectsWrappertransmitObjectisCompleted = null, Expression<Func<string>> searchProjectsWrappertransmitObjectlostDate = null, Expression<Func<bool>> searchProjectsWrappertransmitObjectisLost = null, Expression<Func<string>> searchProjectsWrappertransmitObjectpeopleExpensesChanged = null, Expression<Func<string>> searchProjectsWrappertransmitObjectpicture = null, Expression<Func<int>> searchProjectsWrappertransmitObjectpictureWidth = null, Expression<Func<int>> searchProjectsWrappertransmitObjectpictureHeight = null, Expression<Func<bool>> searchProjectsWrappertransmitObjectisPrivate = null, Expression<Func<string>> searchProjectsWrappertransmitObjectserverItemCreated = null, Expression<Func<string>> searchProjectsWrappertransmitObjectserverItemChanged = null, Expression<Func<string>> searchProjectsWrappertransmitObjectitemCreated = null, Expression<Func<string>> searchProjectsWrappertransmitObjectitemChanged = null, Expression<Func<string>> searchProjectsWrappertransmitObjectfileAs = null, Expression<Func<string>> searchProjectsWrappertransmitObjectownerGUID = null, Expression<Func<string>> searchProjectsWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> searchProjectsWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> searchProjectsWrappertransmitObjectadditionalFields = null, Expression<Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]>> searchProjectsWrappertransmitObjectrelations = null, Expression<Func<string>> searchProjectsWrappertransmitObjectitemGUID = null, Expression<Func<int>> searchProjectsWrappertransmitObjectitemVersion = null, Expression<Func<bool>> searchProjectsWrapperincludeRelations = null, Expression<Func<string>> searchProjectsWrapperrelationsFilterrelationType = null, Expression<Func<string>> searchProjectsWrapperrelationsFilterforeignFolderName = null, Expression<Func<string>> searchProjectsWrapperbinaryLogicalOperator = null)
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
                transmitObjectObject["Companies_CustomerGuid"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectcompaniesCustomerGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectcontactsContactPersonGuid != null)
            {
                transmitObjectObject["Contacts_ContactPersonGuid"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectcontactsContactPersonGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectleadsProjectOriginGuid != null)
            {
                transmitObjectObject["Leads_Project_OriginGuid"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectleadsProjectOriginGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectprojectsSuperiorProjectGuid != null)
            {
                transmitObjectObject["Projects_SuperiorProjectGuid"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectprojectsSuperiorProjectGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectusersSupervisorGuid != null)
            {
                transmitObjectObject["Users_SupervisorGuid"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectusersSupervisorGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectnote != null)
            {
                transmitObjectObject["Note"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectnote);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectprice != null)
            {
                transmitObjectObject["Price"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectprice);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectprojectEnd != null)
            {
                transmitObjectObject["ProjectEnd"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectprojectEnd);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectprojectName != null)
            {
                transmitObjectObject["ProjectName"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectprojectName);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectpeopleExpenses != null)
            {
                transmitObjectObject["PeopleExpenses"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectpeopleExpenses);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectprojectRealEnd != null)
            {
                transmitObjectObject["ProjectRealEnd"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectprojectRealEnd);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedPrice != null)
            {
                transmitObjectObject["EstimatedPrice"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedPrice);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjecthID != null)
            {
                transmitObjectObject["HID"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjecthID);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectprojectOriginEn != null)
            {
                transmitObjectObject["ProjectOriginEn"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectprojectOriginEn);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectpaymentTypeEn != null)
            {
                transmitObjectObject["PaymentTypeEn"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectpaymentTypeEn);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectotherExpenses != null)
            {
                transmitObjectObject["OtherExpenses"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectotherExpenses);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectmargin != null)
            {
                transmitObjectObject["Margin"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectmargin);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectprofit != null)
            {
                transmitObjectObject["Profit"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectprofit);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectpaymentMaturity != null)
            {
                transmitObjectObject["PaymentMaturity"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectpaymentMaturity);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectinvoicePaymentDate != null)
            {
                transmitObjectObject["InvoicePaymentDate"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectinvoicePaymentDate);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectinvoiceIssueDate != null)
            {
                transmitObjectObject["InvoiceIssueDate"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectinvoiceIssueDate);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedMargin != null)
            {
                transmitObjectObject["EstimatedMargin"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedMargin);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedProfit != null)
            {
                transmitObjectObject["EstimatedProfit"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedProfit);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedPeopleExpenses != null)
            {
                transmitObjectObject["EstimatedPeopleExpenses"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedPeopleExpenses);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedOtherExpenses != null)
            {
                transmitObjectObject["EstimatedOtherExpenses"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedOtherExpenses);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectlicensesCount != null)
            {
                transmitObjectObject["LicensesCount"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectlicensesCount);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectlicensePrice != null)
            {
                transmitObjectObject["LicensePrice"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectlicensePrice);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectshowInCaplan != null)
            {
                transmitObjectObject["ShowInCaplan"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectshowInCaplan);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectprojectStart != null)
            {
                transmitObjectObject["ProjectStart"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectprojectStart);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedWorkHours != null)
            {
                transmitObjectObject["EstimatedWorkHours"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedWorkHours);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjecttotalWorkHours != null)
            {
                transmitObjectObject["TotalWorkHours"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjecttotalWorkHours);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency != null)
            {
                transmitObjectObject["EstimatedPeopleExpensesDefaultCurrency"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedOtherExpensesDefaultCurrency != null)
            {
                transmitObjectObject["EstimatedOtherExpensesDefaultCurrency"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedOtherExpensesDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedPriceDefaultCurrency != null)
            {
                transmitObjectObject["EstimatedPriceDefaultCurrency"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedPriceDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectpeopleExpensesDefaultCurrency != null)
            {
                transmitObjectObject["PeopleExpensesDefaultCurrency"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectpeopleExpensesDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectotherExpensesDefaultCurrency != null)
            {
                transmitObjectObject["OtherExpensesDefaultCurrency"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectotherExpensesDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectpriceDefaultCurrency != null)
            {
                transmitObjectObject["PriceDefaultCurrency"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectpriceDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectprofitDefaultCurrency != null)
            {
                transmitObjectObject["ProfitDefaultCurrency"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectprofitDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedProfitDefaultCurrency != null)
            {
                transmitObjectObject["EstimatedProfitDefaultCurrency"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedProfitDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectcurrencyEn != null)
            {
                transmitObjectObject["CurrencyEn"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectcurrencyEn);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedPeopleExpensesChanged != null)
            {
                transmitObjectObject["EstimatedPeopleExpensesChanged"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedPeopleExpensesChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedOtherExpensesChanged != null)
            {
                transmitObjectObject["EstimatedOtherExpensesChanged"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedOtherExpensesChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectotherExpensesChanged != null)
            {
                transmitObjectObject["OtherExpensesChanged"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectotherExpensesChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectestimatedPriceChanged != null)
            {
                transmitObjectObject["EstimatedPriceChanged"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedPriceChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectpriceChanged != null)
            {
                transmitObjectObject["PriceChanged"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectpriceChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectlicensePriceChanged != null)
            {
                transmitObjectObject["LicensePriceChanged"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectlicensePriceChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectlicensePriceDefaultCurrency != null)
            {
                transmitObjectObject["LicensePriceDefaultCurrency"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectlicensePriceDefaultCurrency);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectlastActivity != null)
            {
                transmitObjectObject["LastActivity"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectlastActivity);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectnextStep != null)
            {
                transmitObjectObject["NextStep"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectnextStep);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectcompletedDate != null)
            {
                transmitObjectObject["CompletedDate"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectcompletedDate);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectisCompleted != null)
            {
                transmitObjectObject["IsCompleted"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectisCompleted);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectlostDate != null)
            {
                transmitObjectObject["LostDate"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectlostDate);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectisLost != null)
            {
                transmitObjectObject["IsLost"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectisLost);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectpeopleExpensesChanged != null)
            {
                transmitObjectObject["PeopleExpensesChanged"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectpeopleExpensesChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectpicture != null)
            {
                transmitObjectObject["Picture"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectpicture);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectpictureWidth != null)
            {
                transmitObjectObject["PictureWidth"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectpictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectpictureHeight != null)
            {
                transmitObjectObject["PictureHeight"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectpictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectserverItemCreated != null)
            {
                transmitObjectObject["Server_ItemCreated"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectserverItemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectserverItemChanged != null)
            {
                transmitObjectObject["Server_ItemChanged"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectserverItemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectrelations != null)
            {
                transmitObjectObject["Relations"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectrelations);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchProjectsWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                searchProjectsWrapper["transmitObject"] = transmitObjectObject;
                searchProjectsWrapperpropCount++;
            }

            if (searchProjectsWrapperincludeRelations != null)
            {
                searchProjectsWrapper["includeRelations"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrapperincludeRelations);
                searchProjectsWrapperpropCount++;
            }

            var relationsFilterObject = new JObject();
            var relationsFilterObjectpropCount = 0;
            if (searchProjectsWrapperrelationsFilterrelationType != null)
            {
                relationsFilterObject["RelationType"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrapperrelationsFilterrelationType);
                relationsFilterObjectpropCount++;
            }

            if (searchProjectsWrapperrelationsFilterforeignFolderName != null)
            {
                relationsFilterObject["ForeignFolderName"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrapperrelationsFilterforeignFolderName);
                relationsFilterObjectpropCount++;
            }

            if (relationsFilterObjectpropCount > 0)
            {
                searchProjectsWrapper["relationsFilter"] = relationsFilterObject;
                searchProjectsWrapperpropCount++;
            }

            if (searchProjectsWrapperbinaryLogicalOperator != null)
            {
                searchProjectsWrapper["binaryLogicalOperator"] = CSharpExpressionConverter.ConvertToken(searchProjectsWrapperbinaryLogicalOperator);
                searchProjectsWrapperpropCount++;
            }

            if (searchProjectsWrapperpropCount > 0)
            {
                callPayload.Body = searchProjectsWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask> SearchTasks(Expression<Func<string>> searchTasksWrappertransmitObjectleadsTopLevelProjectGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjectleadsTaskParentGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjectprojectsTopLevelProjectGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjectprojectsTaskParentGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjecttasksTaskParentGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjectmarketingTopLevelProjectGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjectmarketingTaskParentGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjectcompaniesCompanyGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjectcontactsContactGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjectusersTaskDelegatorGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjectusersTaskSolverGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjecttasksTaskOriginGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjectbody = null, Expression<Func<bool>> searchTasksWrappertransmitObjectisCompleted = null, Expression<Func<string>> searchTasksWrappertransmitObjectdueDate = null, Expression<Func<double>> searchTasksWrappertransmitObjectpercentCompleteDecimal = null, Expression<Func<string>> searchTasksWrappertransmitObjectprevStateEn = null, Expression<Func<string>> searchTasksWrappertransmitObjectstartDate = null, Expression<Func<string>> searchTasksWrappertransmitObjectstateEn = null, Expression<Func<string>> searchTasksWrappertransmitObjectsubject = null, Expression<Func<string>> searchTasksWrappertransmitObjecttypeEn = null, Expression<Func<int>> searchTasksWrappertransmitObjectlevel = null, Expression<Func<string>> searchTasksWrappertransmitObjectimportanceEn = null, Expression<Func<double>> searchTasksWrappertransmitObjectactualWorkHours = null, Expression<Func<double>> searchTasksWrappertransmitObjectestimatedWorkHours = null, Expression<Func<bool>> searchTasksWrappertransmitObjectisReminderSet = null, Expression<Func<string>> searchTasksWrappertransmitObjectreminderDate = null, Expression<Func<string>> searchTasksWrappertransmitObjectcompletedDate = null, Expression<Func<string>> searchTasksWrappertransmitObjectpicture = null, Expression<Func<int>> searchTasksWrappertransmitObjectpictureWidth = null, Expression<Func<int>> searchTasksWrappertransmitObjectpictureHeight = null, Expression<Func<bool>> searchTasksWrappertransmitObjectisPrivate = null, Expression<Func<string>> searchTasksWrappertransmitObjectserverItemCreated = null, Expression<Func<string>> searchTasksWrappertransmitObjectserverItemChanged = null, Expression<Func<string>> searchTasksWrappertransmitObjectitemCreated = null, Expression<Func<string>> searchTasksWrappertransmitObjectitemChanged = null, Expression<Func<string>> searchTasksWrappertransmitObjectfileAs = null, Expression<Func<string>> searchTasksWrappertransmitObjectownerGUID = null, Expression<Func<string>> searchTasksWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> searchTasksWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> searchTasksWrappertransmitObjectadditionalFields = null, Expression<Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]>> searchTasksWrappertransmitObjectrelations = null, Expression<Func<string>> searchTasksWrappertransmitObjectitemGUID = null, Expression<Func<int>> searchTasksWrappertransmitObjectitemVersion = null, Expression<Func<bool>> searchTasksWrapperincludeRelations = null, Expression<Func<string>> searchTasksWrapperrelationsFilterrelationType = null, Expression<Func<string>> searchTasksWrapperrelationsFilterforeignFolderName = null, Expression<Func<string>> searchTasksWrapperbinaryLogicalOperator = null)
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
                transmitObjectObject["Leads_TopLevelProjectGuid"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectleadsTopLevelProjectGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectleadsTaskParentGuid != null)
            {
                transmitObjectObject["Leads_TaskParentGuid"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectleadsTaskParentGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectprojectsTopLevelProjectGuid != null)
            {
                transmitObjectObject["Projects_TopLevelProjectGuid"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectprojectsTopLevelProjectGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectprojectsTaskParentGuid != null)
            {
                transmitObjectObject["Projects_TaskParentGuid"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectprojectsTaskParentGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjecttasksTaskParentGuid != null)
            {
                transmitObjectObject["Tasks_TaskParentGuid"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjecttasksTaskParentGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectmarketingTopLevelProjectGuid != null)
            {
                transmitObjectObject["Marketing_TopLevelProjectGuid"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectmarketingTopLevelProjectGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectmarketingTaskParentGuid != null)
            {
                transmitObjectObject["Marketing_TaskParentGuid"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectmarketingTaskParentGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectcompaniesCompanyGuid != null)
            {
                transmitObjectObject["Companies_CompanyGuid"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectcompaniesCompanyGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectcontactsContactGuid != null)
            {
                transmitObjectObject["Contacts_ContactGuid"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectcontactsContactGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectusersTaskDelegatorGuid != null)
            {
                transmitObjectObject["Users_TaskDelegatorGuid"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectusersTaskDelegatorGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectusersTaskSolverGuid != null)
            {
                transmitObjectObject["Users_TaskSolverGuid"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectusersTaskSolverGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjecttasksTaskOriginGuid != null)
            {
                transmitObjectObject["Tasks_TaskOriginGuid"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjecttasksTaskOriginGuid);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectbody != null)
            {
                transmitObjectObject["Body"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectbody);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectisCompleted != null)
            {
                transmitObjectObject["IsCompleted"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectisCompleted);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectdueDate != null)
            {
                transmitObjectObject["DueDate"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectdueDate);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectpercentCompleteDecimal != null)
            {
                transmitObjectObject["PercentCompleteDecimal"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectpercentCompleteDecimal);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectprevStateEn != null)
            {
                transmitObjectObject["PrevStateEn"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectprevStateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectstartDate != null)
            {
                transmitObjectObject["StartDate"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectstartDate);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectstateEn != null)
            {
                transmitObjectObject["StateEn"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectstateEn);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectsubject != null)
            {
                transmitObjectObject["Subject"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectsubject);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjecttypeEn != null)
            {
                transmitObjectObject["TypeEn"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjecttypeEn);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectlevel != null)
            {
                transmitObjectObject["Level"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectlevel);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectimportanceEn != null)
            {
                transmitObjectObject["ImportanceEn"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectimportanceEn);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectactualWorkHours != null)
            {
                transmitObjectObject["ActualWorkHours"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectactualWorkHours);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectestimatedWorkHours != null)
            {
                transmitObjectObject["EstimatedWorkHours"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectestimatedWorkHours);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectisReminderSet != null)
            {
                transmitObjectObject["IsReminderSet"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectisReminderSet);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectreminderDate != null)
            {
                transmitObjectObject["ReminderDate"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectreminderDate);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectcompletedDate != null)
            {
                transmitObjectObject["CompletedDate"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectcompletedDate);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectpicture != null)
            {
                transmitObjectObject["Picture"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectpicture);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectpictureWidth != null)
            {
                transmitObjectObject["PictureWidth"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectpictureWidth);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectpictureHeight != null)
            {
                transmitObjectObject["PictureHeight"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectpictureHeight);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectisPrivate != null)
            {
                transmitObjectObject["IsPrivate"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectisPrivate);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectserverItemCreated != null)
            {
                transmitObjectObject["Server_ItemCreated"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectserverItemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectserverItemChanged != null)
            {
                transmitObjectObject["Server_ItemChanged"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectserverItemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectitemCreated != null)
            {
                transmitObjectObject["ItemCreated"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectitemCreated);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectitemChanged != null)
            {
                transmitObjectObject["ItemChanged"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectitemChanged);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectfileAs != null)
            {
                transmitObjectObject["FileAs"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectfileAs);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectownerGUID != null)
            {
                transmitObjectObject["OwnerGUID"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectownerGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectcreatedByGUID != null)
            {
                transmitObjectObject["CreatedByGUID"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectcreatedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectmodifiedByGUID != null)
            {
                transmitObjectObject["ModifiedByGUID"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectmodifiedByGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectadditionalFields != null)
            {
                transmitObjectObject["AdditionalFields"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectadditionalFields);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectrelations != null)
            {
                transmitObjectObject["Relations"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectrelations);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectitemGUID != null)
            {
                transmitObjectObject["ItemGUID"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectitemGUID);
                transmitObjectObjectpropCount++;
            }

            if (searchTasksWrappertransmitObjectitemVersion != null)
            {
                transmitObjectObject["ItemVersion"] = CSharpExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectitemVersion);
                transmitObjectObjectpropCount++;
            }

            if (transmitObjectObjectpropCount > 0)
            {
                searchTasksWrapper["transmitObject"] = transmitObjectObject;
                searchTasksWrapperpropCount++;
            }

            if (searchTasksWrapperincludeRelations != null)
            {
                searchTasksWrapper["includeRelations"] = CSharpExpressionConverter.ConvertToken(searchTasksWrapperincludeRelations);
                searchTasksWrapperpropCount++;
            }

            var relationsFilterObject = new JObject();
            var relationsFilterObjectpropCount = 0;
            if (searchTasksWrapperrelationsFilterrelationType != null)
            {
                relationsFilterObject["RelationType"] = CSharpExpressionConverter.ConvertToken(searchTasksWrapperrelationsFilterrelationType);
                relationsFilterObjectpropCount++;
            }

            if (searchTasksWrapperrelationsFilterforeignFolderName != null)
            {
                relationsFilterObject["ForeignFolderName"] = CSharpExpressionConverter.ConvertToken(searchTasksWrapperrelationsFilterforeignFolderName);
                relationsFilterObjectpropCount++;
            }

            if (relationsFilterObjectpropCount > 0)
            {
                searchTasksWrapper["relationsFilter"] = relationsFilterObject;
                searchTasksWrapperpropCount++;
            }

            if (searchTasksWrapperbinaryLogicalOperator != null)
            {
                searchTasksWrapper["binaryLogicalOperator"] = CSharpExpressionConverter.ConvertToken(searchTasksWrapperbinaryLogicalOperator);
                searchTasksWrapperpropCount++;
            }

            if (searchTasksWrapperpropCount > 0)
            {
                callPayload.Body = searchTasksWrapper;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1SystemGuid> UnlinkItems(Expression<Func<string>> unlinkItemsWrapperitemGuid = null, Expression<Func<unlinkItemsWrapperfolderNameInput>> unlinkItemsWrapperfolderName = null, Expression<Func<string[]>> unlinkItemsWrapperrelatedItemGuids = null, Expression<Func<unlinkItemsWrapperrelatedFolderNameInput>> unlinkItemsWrapperrelatedFolderName = null, Expression<Func<bool>> unlinkItemsWrapperskipUnlinkAvailabilityCheck = null)
        {
            var apiCallPath = "/UnlinkItems";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var unlinkItemsWrapper = new JObject();
            var unlinkItemsWrapperpropCount = 0;
            if (unlinkItemsWrapperitemGuid != null)
            {
                unlinkItemsWrapper["itemGuid"] = CSharpExpressionConverter.ConvertToken(unlinkItemsWrapperitemGuid);
                unlinkItemsWrapperpropCount++;
            }

            if (unlinkItemsWrapperfolderName != null)
            {
                unlinkItemsWrapper["folderName"] = CSharpExpressionConverter.Convert(unlinkItemsWrapperfolderName);
                unlinkItemsWrapperpropCount++;
            }

            if (unlinkItemsWrapperrelatedItemGuids != null)
            {
                unlinkItemsWrapper["relatedItemGuids"] = CSharpExpressionConverter.ConvertToken(unlinkItemsWrapperrelatedItemGuids);
                unlinkItemsWrapperpropCount++;
            }

            if (unlinkItemsWrapperrelatedFolderName != null)
            {
                unlinkItemsWrapper["relatedFolderName"] = CSharpExpressionConverter.Convert(unlinkItemsWrapperrelatedFolderName);
                unlinkItemsWrapperpropCount++;
            }

            if (unlinkItemsWrapperskipUnlinkAvailabilityCheck != null)
            {
                unlinkItemsWrapper["skipUnlinkAvailabilityCheck"] = CSharpExpressionConverter.ConvertToken(unlinkItemsWrapperskipUnlinkAvailabilityCheck);
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