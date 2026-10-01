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
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteCompany([WorkflowExpression] Func<string> deleteCompanyWrapperitemGuid = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DeleteCompany";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteCompanyWrapper = new JObject();
                var deleteCompanyWrapperpropCount = 0;
                if (deleteCompanyWrapperitemGuid != null)
                {
                    deleteCompanyWrapper["itemGuid"] = SourceExpressionConverter.ConvertToken(deleteCompanyWrapperitemGuid);
                    deleteCompanyWrapperpropCount++;
                }

                if (deleteCompanyWrapperpropCount > 0)
                {
                    callPayload.Body = deleteCompanyWrapper;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteContact([WorkflowExpression] Func<string> deleteContactWrapperitemGuid = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DeleteContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteContactWrapper = new JObject();
                var deleteContactWrapperpropCount = 0;
                if (deleteContactWrapperitemGuid != null)
                {
                    deleteContactWrapper["itemGuid"] = SourceExpressionConverter.ConvertToken(deleteContactWrapperitemGuid);
                    deleteContactWrapperpropCount++;
                }

                if (deleteContactWrapperpropCount > 0)
                {
                    callPayload.Body = deleteContactWrapper;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteJournal([WorkflowExpression] Func<string> deleteJournalWrapperitemGuid = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DeleteJournal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteJournalWrapper = new JObject();
                var deleteJournalWrapperpropCount = 0;
                if (deleteJournalWrapperitemGuid != null)
                {
                    deleteJournalWrapper["itemGuid"] = SourceExpressionConverter.ConvertToken(deleteJournalWrapperitemGuid);
                    deleteJournalWrapperpropCount++;
                }

                if (deleteJournalWrapperpropCount > 0)
                {
                    callPayload.Body = deleteJournalWrapper;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteLead([WorkflowExpression] Func<string> deleteLeadWrapperitemGuid = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DeleteLead";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteLeadWrapper = new JObject();
                var deleteLeadWrapperpropCount = 0;
                if (deleteLeadWrapperitemGuid != null)
                {
                    deleteLeadWrapper["itemGuid"] = SourceExpressionConverter.ConvertToken(deleteLeadWrapperitemGuid);
                    deleteLeadWrapperpropCount++;
                }

                if (deleteLeadWrapperpropCount > 0)
                {
                    callPayload.Body = deleteLeadWrapper;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteProject([WorkflowExpression] Func<string> deleteProjectWrapperitemGuid = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DeleteProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteProjectWrapper = new JObject();
                var deleteProjectWrapperpropCount = 0;
                if (deleteProjectWrapperitemGuid != null)
                {
                    deleteProjectWrapper["itemGuid"] = SourceExpressionConverter.ConvertToken(deleteProjectWrapperitemGuid);
                    deleteProjectWrapperpropCount++;
                }

                if (deleteProjectWrapperpropCount > 0)
                {
                    callPayload.Body = deleteProjectWrapper;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteTask([WorkflowExpression] Func<string> deleteTaskWrapperitemGuid = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DeleteTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteTaskWrapper = new JObject();
                var deleteTaskWrapperpropCount = 0;
                if (deleteTaskWrapperitemGuid != null)
                {
                    deleteTaskWrapper["itemGuid"] = SourceExpressionConverter.ConvertToken(deleteTaskWrapperitemGuid);
                    deleteTaskWrapperpropCount++;
                }

                if (deleteTaskWrapperpropCount > 0)
                {
                    callPayload.Body = deleteTaskWrapper;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveCompany([WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaccountNumber = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress1POBox = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress1Street = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress1City = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress1State = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress1CountryEn = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress1PostalCode = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress2POBox = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress2Street = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress2City = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress2State = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress2CountryEn = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress2PostalCode = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress3POBox = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress3Street = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress3City = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress3State = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress3CountryEn = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectaddress3PostalCode = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectcompanyName = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectdepartment = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectemail = null, [WorkflowExpression] Func<int> saveCompanyWrappertransmitObjectemployeesCount = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectfax = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectfirstContactEn = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectiCQ = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectidentificationNumber = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectimportanceEn = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectlineOfBusiness = null, [WorkflowExpression] Func<bool> saveCompanyWrappertransmitObjectmailingListOther = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectmobile = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectmobileNormalized = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectmSN = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectnote = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectphone = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectphoneNormalized = null, [WorkflowExpression] Func<bool> saveCompanyWrappertransmitObjectpurchaser = null, [WorkflowExpression] Func<double> saveCompanyWrappertransmitObjectreversal = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectskype = null, [WorkflowExpression] Func<bool> saveCompanyWrappertransmitObjectsuppliers = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectvATNumber = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectwebPage = null, [WorkflowExpression] Func<double> saveCompanyWrappertransmitObjectadditionalDiscount = null, [WorkflowExpression] Func<int> saveCompanyWrappertransmitObjectid = null, [WorkflowExpression] Func<bool> saveCompanyWrappertransmitObjectcompetitor = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectsalePriceGuid = null, [WorkflowExpression] Func<bool> saveCompanyWrappertransmitObjectnotificationByEmail = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectnotificationBy = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectlastActivity = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectnextStep = null, [WorkflowExpression] Func<bool> saveCompanyWrappertransmitObjectemailOptOut = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectpicture = null, [WorkflowExpression] Func<int> saveCompanyWrappertransmitObjectpictureWidth = null, [WorkflowExpression] Func<int> saveCompanyWrappertransmitObjectpictureHeight = null, [WorkflowExpression] Func<bool> saveCompanyWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> saveCompanyWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<string> saveCompanyWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> saveCompanyWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> saveCompanyWrapperdieOnItemConflict = null, [WorkflowExpression] Func<string[]> saveCompanyWrapperignoredUserErrorMessages = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    transmitObjectObject["AccountNumber"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaccountNumber);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectaddress1POBox != null)
                {
                    transmitObjectObject["Address1POBox"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress1POBox);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectaddress1Street != null)
                {
                    transmitObjectObject["Address1Street"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress1Street);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectaddress1City != null)
                {
                    transmitObjectObject["Address1City"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress1City);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectaddress1State != null)
                {
                    transmitObjectObject["Address1State"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress1State);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectaddress1CountryEn != null)
                {
                    transmitObjectObject["Address1CountryEn"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress1CountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectaddress1PostalCode != null)
                {
                    transmitObjectObject["Address1PostalCode"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress1PostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectaddress2POBox != null)
                {
                    transmitObjectObject["Address2POBox"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress2POBox);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectaddress2Street != null)
                {
                    transmitObjectObject["Address2Street"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress2Street);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectaddress2City != null)
                {
                    transmitObjectObject["Address2City"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress2City);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectaddress2State != null)
                {
                    transmitObjectObject["Address2State"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress2State);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectaddress2CountryEn != null)
                {
                    transmitObjectObject["Address2CountryEn"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress2CountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectaddress2PostalCode != null)
                {
                    transmitObjectObject["Address2PostalCode"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress2PostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectaddress3POBox != null)
                {
                    transmitObjectObject["Address3POBox"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress3POBox);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectaddress3Street != null)
                {
                    transmitObjectObject["Address3Street"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress3Street);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectaddress3City != null)
                {
                    transmitObjectObject["Address3City"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress3City);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectaddress3State != null)
                {
                    transmitObjectObject["Address3State"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress3State);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectaddress3CountryEn != null)
                {
                    transmitObjectObject["Address3CountryEn"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress3CountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectaddress3PostalCode != null)
                {
                    transmitObjectObject["Address3PostalCode"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectaddress3PostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectcompanyName != null)
                {
                    transmitObjectObject["CompanyName"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectcompanyName);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectdepartment != null)
                {
                    transmitObjectObject["Department"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectdepartment);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectemail != null)
                {
                    transmitObjectObject["Email"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectemail);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectemployeesCount != null)
                {
                    transmitObjectObject["EmployeesCount"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectemployeesCount);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectfax != null)
                {
                    transmitObjectObject["Fax"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectfax);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectfirstContactEn != null)
                {
                    transmitObjectObject["FirstContactEn"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectfirstContactEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectiCQ != null)
                {
                    transmitObjectObject["ICQ"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectiCQ);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectidentificationNumber != null)
                {
                    transmitObjectObject["IdentificationNumber"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectidentificationNumber);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectimportanceEn != null)
                {
                    transmitObjectObject["ImportanceEn"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectimportanceEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectlineOfBusiness != null)
                {
                    transmitObjectObject["LineOfBusiness"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectlineOfBusiness);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectmailingListOther != null)
                {
                    transmitObjectObject["MailingListOther"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectmailingListOther);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectmobile != null)
                {
                    transmitObjectObject["Mobile"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectmobile);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectmobileNormalized != null)
                {
                    transmitObjectObject["MobileNormalized"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectmobileNormalized);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectmSN != null)
                {
                    transmitObjectObject["MSN"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectmSN);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectnote != null)
                {
                    transmitObjectObject["Note"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectnote);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectphone != null)
                {
                    transmitObjectObject["Phone"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectphone);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectphoneNormalized != null)
                {
                    transmitObjectObject["PhoneNormalized"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectphoneNormalized);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectpurchaser != null)
                {
                    transmitObjectObject["Purchaser"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectpurchaser);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectreversal != null)
                {
                    transmitObjectObject["Reversal"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectreversal);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectskype != null)
                {
                    transmitObjectObject["Skype"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectskype);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectsuppliers != null)
                {
                    transmitObjectObject["Suppliers"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectsuppliers);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectvATNumber != null)
                {
                    transmitObjectObject["VATNumber"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectvATNumber);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectwebPage != null)
                {
                    transmitObjectObject["WebPage"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectwebPage);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectadditionalDiscount != null)
                {
                    transmitObjectObject["AdditionalDiscount"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectadditionalDiscount);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectid != null)
                {
                    transmitObjectObject["ID"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectid);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectcompetitor != null)
                {
                    transmitObjectObject["Competitor"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectcompetitor);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectsalePriceGuid != null)
                {
                    transmitObjectObject["SalePriceGuid"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectsalePriceGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectnotificationByEmail != null)
                {
                    transmitObjectObject["NotificationByEmail"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectnotificationByEmail);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectnotificationBy != null)
                {
                    transmitObjectObject["NotificationBy"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectnotificationBy);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectlastActivity != null)
                {
                    transmitObjectObject["LastActivity"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectlastActivity);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectnextStep != null)
                {
                    transmitObjectObject["NextStep"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectnextStep);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectemailOptOut != null)
                {
                    transmitObjectObject["EmailOptOut"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectemailOptOut);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectpicture != null)
                {
                    transmitObjectObject["Picture"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectpicture);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectpictureWidth != null)
                {
                    transmitObjectObject["PictureWidth"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectpictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectpictureHeight != null)
                {
                    transmitObjectObject["PictureHeight"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectpictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveCompanyWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = SourceExpressionConverter.ConvertToken(saveCompanyWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    saveCompanyWrapper["transmitObject"] = transmitObjectObject;
                    saveCompanyWrapperpropCount++;
                }

                if (saveCompanyWrapperdieOnItemConflict != null)
                {
                    saveCompanyWrapper["dieOnItemConflict"] = SourceExpressionConverter.ConvertToken(saveCompanyWrapperdieOnItemConflict);
                    saveCompanyWrapperpropCount++;
                }

                if (saveCompanyWrapperignoredUserErrorMessages != null)
                {
                    saveCompanyWrapper["ignoredUserErrorMessages"] = SourceExpressionConverter.ConvertToken(saveCompanyWrapperignoredUserErrorMessages);
                    saveCompanyWrapperpropCount++;
                }

                if (saveCompanyWrapperpropCount > 0)
                {
                    callPayload.Body = saveCompanyWrapper;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveContact([WorkflowExpression] Func<string> saveContactWrappertransmitObjectbusinessAddressStreet = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectbusinessAddressCity = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectbusinessAddressState = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectbusinessAddressCountryEn = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectbusinessAddressPOBox = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectbusinessAddressPostalCode = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecthomeAddressStreet = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecthomeAddressCity = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecthomeAddressState = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecthomeAddressCountryEn = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecthomeAddressPOBox = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecthomeAddressPostalCode = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectotherAddressStreet = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectotherAddressCity = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectotherAddressState = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectotherAddressCountryEn = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectotherAddressPOBox = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectotherAddressPostalCode = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectcompany = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectemail1Address = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectemail2Address = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectemail3Address = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectfirstName = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectiCQ = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectimportanceEn = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectlastName = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectmiddleName = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectmSN = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectnote = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectprefixEn = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectsuffixEn = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectskype = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber1 = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber2 = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber3 = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber4 = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber5 = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber6 = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber1Normalized = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber2Normalized = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber3Normalized = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber4Normalized = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber5Normalized = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttelephoneNumber6Normalized = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectdepartment = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttitle = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectwebPage = null, [WorkflowExpression] Func<bool> saveContactWrappertransmitObjectdoNotSendNewsletter = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectprofilePicture = null, [WorkflowExpression] Func<int> saveContactWrappertransmitObjectprofilePictureWidth = null, [WorkflowExpression] Func<int> saveContactWrappertransmitObjectprofilePictureHeight = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectlastActivity = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectnextStep = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectcompaniesCompanyGuid = null, [WorkflowExpression] Func<bool> saveContactWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> saveContactWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<string> saveContactWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> saveContactWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> saveContactWrapperdieOnItemConflict = null, [WorkflowExpression] Func<string[]> saveContactWrapperignoredUserErrorMessages = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    transmitObjectObject["BusinessAddressStreet"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectbusinessAddressStreet);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectbusinessAddressCity != null)
                {
                    transmitObjectObject["BusinessAddressCity"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectbusinessAddressCity);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectbusinessAddressState != null)
                {
                    transmitObjectObject["BusinessAddressState"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectbusinessAddressState);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectbusinessAddressCountryEn != null)
                {
                    transmitObjectObject["BusinessAddressCountryEn"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectbusinessAddressCountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectbusinessAddressPOBox != null)
                {
                    transmitObjectObject["BusinessAddressPOBox"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectbusinessAddressPOBox);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectbusinessAddressPostalCode != null)
                {
                    transmitObjectObject["BusinessAddressPostalCode"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectbusinessAddressPostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjecthomeAddressStreet != null)
                {
                    transmitObjectObject["HomeAddressStreet"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjecthomeAddressStreet);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjecthomeAddressCity != null)
                {
                    transmitObjectObject["HomeAddressCity"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjecthomeAddressCity);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjecthomeAddressState != null)
                {
                    transmitObjectObject["HomeAddressState"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjecthomeAddressState);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjecthomeAddressCountryEn != null)
                {
                    transmitObjectObject["HomeAddressCountryEn"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjecthomeAddressCountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjecthomeAddressPOBox != null)
                {
                    transmitObjectObject["HomeAddressPOBox"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjecthomeAddressPOBox);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjecthomeAddressPostalCode != null)
                {
                    transmitObjectObject["HomeAddressPostalCode"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjecthomeAddressPostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectotherAddressStreet != null)
                {
                    transmitObjectObject["OtherAddressStreet"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectotherAddressStreet);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectotherAddressCity != null)
                {
                    transmitObjectObject["OtherAddressCity"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectotherAddressCity);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectotherAddressState != null)
                {
                    transmitObjectObject["OtherAddressState"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectotherAddressState);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectotherAddressCountryEn != null)
                {
                    transmitObjectObject["OtherAddressCountryEn"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectotherAddressCountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectotherAddressPOBox != null)
                {
                    transmitObjectObject["OtherAddressPOBox"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectotherAddressPOBox);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectotherAddressPostalCode != null)
                {
                    transmitObjectObject["OtherAddressPostalCode"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectotherAddressPostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectcompany != null)
                {
                    transmitObjectObject["Company"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectcompany);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectemail1Address != null)
                {
                    transmitObjectObject["Email1Address"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectemail1Address);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectemail2Address != null)
                {
                    transmitObjectObject["Email2Address"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectemail2Address);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectemail3Address != null)
                {
                    transmitObjectObject["Email3Address"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectemail3Address);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectfirstName != null)
                {
                    transmitObjectObject["FirstName"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectfirstName);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectiCQ != null)
                {
                    transmitObjectObject["ICQ"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectiCQ);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectimportanceEn != null)
                {
                    transmitObjectObject["ImportanceEn"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectimportanceEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectlastName != null)
                {
                    transmitObjectObject["LastName"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectlastName);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectmiddleName != null)
                {
                    transmitObjectObject["MiddleName"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectmiddleName);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectmSN != null)
                {
                    transmitObjectObject["MSN"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectmSN);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectnote != null)
                {
                    transmitObjectObject["Note"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectnote);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectprefixEn != null)
                {
                    transmitObjectObject["PrefixEn"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectprefixEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectsuffixEn != null)
                {
                    transmitObjectObject["SuffixEn"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectsuffixEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectskype != null)
                {
                    transmitObjectObject["Skype"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectskype);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjecttelephoneNumber1 != null)
                {
                    transmitObjectObject["TelephoneNumber1"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber1);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjecttelephoneNumber2 != null)
                {
                    transmitObjectObject["TelephoneNumber2"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber2);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjecttelephoneNumber3 != null)
                {
                    transmitObjectObject["TelephoneNumber3"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber3);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjecttelephoneNumber4 != null)
                {
                    transmitObjectObject["TelephoneNumber4"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber4);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjecttelephoneNumber5 != null)
                {
                    transmitObjectObject["TelephoneNumber5"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber5);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjecttelephoneNumber6 != null)
                {
                    transmitObjectObject["TelephoneNumber6"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber6);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjecttelephoneNumber1Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber1Normalized"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber1Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjecttelephoneNumber2Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber2Normalized"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber2Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjecttelephoneNumber3Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber3Normalized"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber3Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjecttelephoneNumber4Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber4Normalized"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber4Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjecttelephoneNumber5Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber5Normalized"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber5Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjecttelephoneNumber6Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber6Normalized"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttelephoneNumber6Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectdepartment != null)
                {
                    transmitObjectObject["Department"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectdepartment);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjecttitle != null)
                {
                    transmitObjectObject["Title"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttitle);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectwebPage != null)
                {
                    transmitObjectObject["WebPage"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectwebPage);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectdoNotSendNewsletter != null)
                {
                    transmitObjectObject["DoNotSendNewsletter"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectdoNotSendNewsletter);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectprofilePicture != null)
                {
                    transmitObjectObject["ProfilePicture"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectprofilePicture);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectprofilePictureWidth != null)
                {
                    transmitObjectObject["ProfilePictureWidth"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectprofilePictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectprofilePictureHeight != null)
                {
                    transmitObjectObject["ProfilePictureHeight"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectprofilePictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectlastActivity != null)
                {
                    transmitObjectObject["LastActivity"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectlastActivity);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectnextStep != null)
                {
                    transmitObjectObject["NextStep"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectnextStep);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectcompaniesCompanyGuid != null)
                {
                    transmitObjectObject["Companies_CompanyGuid"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectcompaniesCompanyGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveContactWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = SourceExpressionConverter.ConvertToken(saveContactWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    saveContactWrapper["transmitObject"] = transmitObjectObject;
                    saveContactWrapperpropCount++;
                }

                if (saveContactWrapperdieOnItemConflict != null)
                {
                    saveContactWrapper["dieOnItemConflict"] = SourceExpressionConverter.ConvertToken(saveContactWrapperdieOnItemConflict);
                    saveContactWrapperpropCount++;
                }

                if (saveContactWrapperignoredUserErrorMessages != null)
                {
                    saveContactWrapper["ignoredUserErrorMessages"] = SourceExpressionConverter.ConvertToken(saveContactWrapperignoredUserErrorMessages);
                    saveContactWrapperpropCount++;
                }

                if (saveContactWrapperpropCount > 0)
                {
                    callPayload.Body = saveContactWrapper;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveJournal([WorkflowExpression] Func<string> saveJournalWrappertransmitObjectcalendarEntryId = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectcalendarORIGIN = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectchangedField = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjecteventEnd = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjecteventStart = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectfieldValue = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectimportanceEn = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectnote = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectprevFieldValue = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<bool> saveJournalWrappertransmitObjectisSystem = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectphone = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectphoneNormalized = null, [WorkflowExpression] Func<bool> saveJournalWrappertransmitObjectisGdprRelevant = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectpicture = null, [WorkflowExpression] Func<int> saveJournalWrappertransmitObjectpictureWidth = null, [WorkflowExpression] Func<int> saveJournalWrappertransmitObjectpictureHeight = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectcompaniesCompanyGuid = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectcontactsContactGuid = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectleadsSuperiorItemGuid = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectprojectsSuperiorItemGuid = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectmarketingMarketingGuid = null, [WorkflowExpression] Func<bool> saveJournalWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> saveJournalWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<string> saveJournalWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> saveJournalWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> saveJournalWrapperdieOnItemConflict = null, [WorkflowExpression] Func<string[]> saveJournalWrapperignoredUserErrorMessages = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SaveJournal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var saveJournalWrapper = new JObject();
                var saveJournalWrapperpropCount = 0;
                var transmitObjectObject = new JObject();
                var transmitObjectObjectpropCount = 0;
                if (saveJournalWrappertransmitObjectcalendarEntryId != null)
                {
                    transmitObjectObject["CalendarEntryID"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectcalendarEntryId);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectcalendarORIGIN != null)
                {
                    transmitObjectObject["Calendar_ORIGIN"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectcalendarORIGIN);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectchangedField != null)
                {
                    transmitObjectObject["ChangedField"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectchangedField);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjecteventEnd != null)
                {
                    transmitObjectObject["EventEnd"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjecteventEnd);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjecteventStart != null)
                {
                    transmitObjectObject["EventStart"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjecteventStart);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectfieldValue != null)
                {
                    transmitObjectObject["FieldValue"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectfieldValue);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectimportanceEn != null)
                {
                    transmitObjectObject["ImportanceEn"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectimportanceEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectnote != null)
                {
                    transmitObjectObject["Note"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectnote);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectprevFieldValue != null)
                {
                    transmitObjectObject["PrevFieldValue"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectprevFieldValue);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectisSystem != null)
                {
                    transmitObjectObject["IsSystem"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectisSystem);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectphone != null)
                {
                    transmitObjectObject["Phone"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectphone);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectphoneNormalized != null)
                {
                    transmitObjectObject["PhoneNormalized"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectphoneNormalized);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectisGdprRelevant != null)
                {
                    transmitObjectObject["IsGdprRelevant"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectisGdprRelevant);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectpicture != null)
                {
                    transmitObjectObject["Picture"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectpicture);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectpictureWidth != null)
                {
                    transmitObjectObject["PictureWidth"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectpictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectpictureHeight != null)
                {
                    transmitObjectObject["PictureHeight"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectpictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectcompaniesCompanyGuid != null)
                {
                    transmitObjectObject["Companies_CompanyGuid"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectcompaniesCompanyGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectcontactsContactGuid != null)
                {
                    transmitObjectObject["Contacts_ContactGuid"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectcontactsContactGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectleadsSuperiorItemGuid != null)
                {
                    transmitObjectObject["Leads_SuperiorItemGuid"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectleadsSuperiorItemGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectprojectsSuperiorItemGuid != null)
                {
                    transmitObjectObject["Projects_SuperiorItemGuid"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectprojectsSuperiorItemGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectmarketingMarketingGuid != null)
                {
                    transmitObjectObject["Marketing_MarketingGuid"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectmarketingMarketingGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveJournalWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = SourceExpressionConverter.ConvertToken(saveJournalWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    saveJournalWrapper["transmitObject"] = transmitObjectObject;
                    saveJournalWrapperpropCount++;
                }

                if (saveJournalWrapperdieOnItemConflict != null)
                {
                    saveJournalWrapper["dieOnItemConflict"] = SourceExpressionConverter.ConvertToken(saveJournalWrapperdieOnItemConflict);
                    saveJournalWrapperpropCount++;
                }

                if (saveJournalWrapperignoredUserErrorMessages != null)
                {
                    saveJournalWrapper["ignoredUserErrorMessages"] = SourceExpressionConverter.ConvertToken(saveJournalWrapperignoredUserErrorMessages);
                    saveJournalWrapperpropCount++;
                }

                if (saveJournalWrapperpropCount > 0)
                {
                    callPayload.Body = saveJournalWrapper;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveLead([WorkflowExpression] Func<string> saveLeadWrappertransmitObjectcity = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectcontactPerson = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectcurrencyEn = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectcustomer = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectemail = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectestimatedEnd = null, [WorkflowExpression] Func<int> saveLeadWrappertransmitObjecthId = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectleadOriginEn = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectnote = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectphone = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectphoneNormalized = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<double> saveLeadWrappertransmitObjectprice = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectpriceChanged = null, [WorkflowExpression] Func<double> saveLeadWrappertransmitObjectpriceDefaultCurrency = null, [WorkflowExpression] Func<double> saveLeadWrappertransmitObjectprobability = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectreceiveDate = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectstreet = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectzip = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectlastActivity = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectnextStep = null, [WorkflowExpression] Func<double> saveLeadWrappertransmitObjectestimatedValue = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectcountryEn = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectstate = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectpOBox = null, [WorkflowExpression] Func<bool> saveLeadWrappertransmitObjectemailOptOut = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectpicture = null, [WorkflowExpression] Func<int> saveLeadWrappertransmitObjectpictureWidth = null, [WorkflowExpression] Func<int> saveLeadWrappertransmitObjectpictureHeight = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectcompaniesCustomerGuid = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectcontactsContactPersonGuid = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectmarketingMarketingGuid = null, [WorkflowExpression] Func<bool> saveLeadWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> saveLeadWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<string> saveLeadWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> saveLeadWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> saveLeadWrapperdieOnItemConflict = null, [WorkflowExpression] Func<string[]> saveLeadWrapperignoredUserErrorMessages = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    transmitObjectObject["City"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectcity);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectcontactPerson != null)
                {
                    transmitObjectObject["ContactPerson"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectcontactPerson);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectcurrencyEn != null)
                {
                    transmitObjectObject["CurrencyEn"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectcurrencyEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectcustomer != null)
                {
                    transmitObjectObject["Customer"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectcustomer);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectemail != null)
                {
                    transmitObjectObject["Email"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectemail);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectestimatedEnd != null)
                {
                    transmitObjectObject["EstimatedEnd"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectestimatedEnd);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjecthId != null)
                {
                    transmitObjectObject["HID"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjecthId);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectleadOriginEn != null)
                {
                    transmitObjectObject["LeadOriginEn"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectleadOriginEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectnote != null)
                {
                    transmitObjectObject["Note"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectnote);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectphone != null)
                {
                    transmitObjectObject["Phone"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectphone);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectphoneNormalized != null)
                {
                    transmitObjectObject["PhoneNormalized"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectphoneNormalized);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectprice != null)
                {
                    transmitObjectObject["Price"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectprice);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectpriceChanged != null)
                {
                    transmitObjectObject["PriceChanged"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectpriceChanged);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectpriceDefaultCurrency != null)
                {
                    transmitObjectObject["PriceDefaultCurrency"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectpriceDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectprobability != null)
                {
                    transmitObjectObject["Probability"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectprobability);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectreceiveDate != null)
                {
                    transmitObjectObject["ReceiveDate"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectreceiveDate);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectstreet != null)
                {
                    transmitObjectObject["Street"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectstreet);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectzip != null)
                {
                    transmitObjectObject["Zip"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectzip);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectlastActivity != null)
                {
                    transmitObjectObject["LastActivity"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectlastActivity);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectnextStep != null)
                {
                    transmitObjectObject["NextStep"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectnextStep);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectestimatedValue != null)
                {
                    transmitObjectObject["EstimatedValue"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectestimatedValue);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectcountryEn != null)
                {
                    transmitObjectObject["CountryEn"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectcountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectstate != null)
                {
                    transmitObjectObject["State"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectstate);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectpOBox != null)
                {
                    transmitObjectObject["POBox"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectpOBox);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectemailOptOut != null)
                {
                    transmitObjectObject["EmailOptOut"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectemailOptOut);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectpicture != null)
                {
                    transmitObjectObject["Picture"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectpicture);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectpictureWidth != null)
                {
                    transmitObjectObject["PictureWidth"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectpictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectpictureHeight != null)
                {
                    transmitObjectObject["PictureHeight"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectpictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectcompaniesCustomerGuid != null)
                {
                    transmitObjectObject["Companies_CustomerGuid"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectcompaniesCustomerGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectcontactsContactPersonGuid != null)
                {
                    transmitObjectObject["Contacts_ContactPersonGuid"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectcontactsContactPersonGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectmarketingMarketingGuid != null)
                {
                    transmitObjectObject["Marketing_MarketingGuid"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectmarketingMarketingGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveLeadWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = SourceExpressionConverter.ConvertToken(saveLeadWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    saveLeadWrapper["transmitObject"] = transmitObjectObject;
                    saveLeadWrapperpropCount++;
                }

                if (saveLeadWrapperdieOnItemConflict != null)
                {
                    saveLeadWrapper["dieOnItemConflict"] = SourceExpressionConverter.ConvertToken(saveLeadWrapperdieOnItemConflict);
                    saveLeadWrapperpropCount++;
                }

                if (saveLeadWrapperignoredUserErrorMessages != null)
                {
                    saveLeadWrapper["ignoredUserErrorMessages"] = SourceExpressionConverter.ConvertToken(saveLeadWrapperignoredUserErrorMessages);
                    saveLeadWrapperpropCount++;
                }

                if (saveLeadWrapperpropCount > 0)
                {
                    callPayload.Body = saveLeadWrapper;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveProject([WorkflowExpression] Func<string> saveProjectWrappertransmitObjectnote = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectprice = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectprojectEnd = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectprojectName = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectpeopleExpenses = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectprojectRealEnd = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectestimatedPrice = null, [WorkflowExpression] Func<int> saveProjectWrappertransmitObjecthId = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectprojectOriginEn = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectpaymentTypeEn = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectotherExpenses = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectmargin = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectprofit = null, [WorkflowExpression] Func<int> saveProjectWrappertransmitObjectpaymentMaturity = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectinvoicePaymentDate = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectinvoiceIssueDate = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectestimatedMargin = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectestimatedProfit = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectestimatedPeopleExpenses = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectestimatedOtherExpenses = null, [WorkflowExpression] Func<int> saveProjectWrappertransmitObjectlicensesCount = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectlicensePrice = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<bool> saveProjectWrappertransmitObjectshowInCaplan = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectprojectStart = null, [WorkflowExpression] Func<int> saveProjectWrappertransmitObjectestimatedWorkHours = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjecttotalWorkHours = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectestimatedOtherExpensesDefaultCurrency = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectestimatedPriceDefaultCurrency = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectpeopleExpensesDefaultCurrency = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectotherExpensesDefaultCurrency = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectpriceDefaultCurrency = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectprofitDefaultCurrency = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectestimatedProfitDefaultCurrency = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectcurrencyEn = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectestimatedPeopleExpensesChanged = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectestimatedOtherExpensesChanged = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectotherExpensesChanged = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectestimatedPriceChanged = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectpriceChanged = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectlicensePriceChanged = null, [WorkflowExpression] Func<double> saveProjectWrappertransmitObjectlicensePriceDefaultCurrency = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectlastActivity = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectnextStep = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectpeopleExpensesChanged = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectpicture = null, [WorkflowExpression] Func<int> saveProjectWrappertransmitObjectpictureWidth = null, [WorkflowExpression] Func<int> saveProjectWrappertransmitObjectpictureHeight = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectcompaniesCustomerGuid = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectcontactsContactPersonGuid = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectleadsProjectOriginGuid = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectprojectsSuperiorProjectGuid = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectusersSupervisorGuid = null, [WorkflowExpression] Func<bool> saveProjectWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> saveProjectWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<string> saveProjectWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> saveProjectWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> saveProjectWrapperdieOnItemConflict = null, [WorkflowExpression] Func<string[]> saveProjectWrapperignoredUserErrorMessages = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    transmitObjectObject["Note"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectnote);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectprice != null)
                {
                    transmitObjectObject["Price"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectprice);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectprojectEnd != null)
                {
                    transmitObjectObject["ProjectEnd"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectprojectEnd);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectprojectName != null)
                {
                    transmitObjectObject["ProjectName"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectprojectName);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectpeopleExpenses != null)
                {
                    transmitObjectObject["PeopleExpenses"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectpeopleExpenses);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectprojectRealEnd != null)
                {
                    transmitObjectObject["ProjectRealEnd"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectprojectRealEnd);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectestimatedPrice != null)
                {
                    transmitObjectObject["EstimatedPrice"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedPrice);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjecthId != null)
                {
                    transmitObjectObject["HID"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjecthId);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectprojectOriginEn != null)
                {
                    transmitObjectObject["ProjectOriginEn"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectprojectOriginEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectpaymentTypeEn != null)
                {
                    transmitObjectObject["PaymentTypeEn"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectpaymentTypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectotherExpenses != null)
                {
                    transmitObjectObject["OtherExpenses"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectotherExpenses);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectmargin != null)
                {
                    transmitObjectObject["Margin"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectmargin);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectprofit != null)
                {
                    transmitObjectObject["Profit"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectprofit);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectpaymentMaturity != null)
                {
                    transmitObjectObject["PaymentMaturity"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectpaymentMaturity);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectinvoicePaymentDate != null)
                {
                    transmitObjectObject["InvoicePaymentDate"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectinvoicePaymentDate);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectinvoiceIssueDate != null)
                {
                    transmitObjectObject["InvoiceIssueDate"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectinvoiceIssueDate);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectestimatedMargin != null)
                {
                    transmitObjectObject["EstimatedMargin"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedMargin);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectestimatedProfit != null)
                {
                    transmitObjectObject["EstimatedProfit"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedProfit);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectestimatedPeopleExpenses != null)
                {
                    transmitObjectObject["EstimatedPeopleExpenses"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedPeopleExpenses);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectestimatedOtherExpenses != null)
                {
                    transmitObjectObject["EstimatedOtherExpenses"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedOtherExpenses);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectlicensesCount != null)
                {
                    transmitObjectObject["LicensesCount"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectlicensesCount);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectlicensePrice != null)
                {
                    transmitObjectObject["LicensePrice"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectlicensePrice);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectshowInCaplan != null)
                {
                    transmitObjectObject["ShowInCaplan"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectshowInCaplan);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectprojectStart != null)
                {
                    transmitObjectObject["ProjectStart"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectprojectStart);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectestimatedWorkHours != null)
                {
                    transmitObjectObject["EstimatedWorkHours"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedWorkHours);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjecttotalWorkHours != null)
                {
                    transmitObjectObject["TotalWorkHours"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjecttotalWorkHours);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency != null)
                {
                    transmitObjectObject["EstimatedPeopleExpensesDefaultCurrency"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectestimatedOtherExpensesDefaultCurrency != null)
                {
                    transmitObjectObject["EstimatedOtherExpensesDefaultCurrency"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedOtherExpensesDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectestimatedPriceDefaultCurrency != null)
                {
                    transmitObjectObject["EstimatedPriceDefaultCurrency"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedPriceDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectpeopleExpensesDefaultCurrency != null)
                {
                    transmitObjectObject["PeopleExpensesDefaultCurrency"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectpeopleExpensesDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectotherExpensesDefaultCurrency != null)
                {
                    transmitObjectObject["OtherExpensesDefaultCurrency"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectotherExpensesDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectpriceDefaultCurrency != null)
                {
                    transmitObjectObject["PriceDefaultCurrency"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectpriceDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectprofitDefaultCurrency != null)
                {
                    transmitObjectObject["ProfitDefaultCurrency"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectprofitDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectestimatedProfitDefaultCurrency != null)
                {
                    transmitObjectObject["EstimatedProfitDefaultCurrency"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedProfitDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectcurrencyEn != null)
                {
                    transmitObjectObject["CurrencyEn"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectcurrencyEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectestimatedPeopleExpensesChanged != null)
                {
                    transmitObjectObject["EstimatedPeopleExpensesChanged"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedPeopleExpensesChanged);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectestimatedOtherExpensesChanged != null)
                {
                    transmitObjectObject["EstimatedOtherExpensesChanged"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedOtherExpensesChanged);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectotherExpensesChanged != null)
                {
                    transmitObjectObject["OtherExpensesChanged"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectotherExpensesChanged);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectestimatedPriceChanged != null)
                {
                    transmitObjectObject["EstimatedPriceChanged"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectestimatedPriceChanged);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectpriceChanged != null)
                {
                    transmitObjectObject["PriceChanged"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectpriceChanged);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectlicensePriceChanged != null)
                {
                    transmitObjectObject["LicensePriceChanged"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectlicensePriceChanged);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectlicensePriceDefaultCurrency != null)
                {
                    transmitObjectObject["LicensePriceDefaultCurrency"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectlicensePriceDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectlastActivity != null)
                {
                    transmitObjectObject["LastActivity"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectlastActivity);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectnextStep != null)
                {
                    transmitObjectObject["NextStep"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectnextStep);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectpeopleExpensesChanged != null)
                {
                    transmitObjectObject["PeopleExpensesChanged"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectpeopleExpensesChanged);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectpicture != null)
                {
                    transmitObjectObject["Picture"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectpicture);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectpictureWidth != null)
                {
                    transmitObjectObject["PictureWidth"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectpictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectpictureHeight != null)
                {
                    transmitObjectObject["PictureHeight"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectpictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectcompaniesCustomerGuid != null)
                {
                    transmitObjectObject["Companies_CustomerGuid"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectcompaniesCustomerGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectcontactsContactPersonGuid != null)
                {
                    transmitObjectObject["Contacts_ContactPersonGuid"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectcontactsContactPersonGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectleadsProjectOriginGuid != null)
                {
                    transmitObjectObject["Leads_Project_OriginGuid"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectleadsProjectOriginGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectprojectsSuperiorProjectGuid != null)
                {
                    transmitObjectObject["Projects_SuperiorProjectGuid"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectprojectsSuperiorProjectGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectusersSupervisorGuid != null)
                {
                    transmitObjectObject["Users_SupervisorGuid"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectusersSupervisorGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveProjectWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = SourceExpressionConverter.ConvertToken(saveProjectWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    saveProjectWrapper["transmitObject"] = transmitObjectObject;
                    saveProjectWrapperpropCount++;
                }

                if (saveProjectWrapperdieOnItemConflict != null)
                {
                    saveProjectWrapper["dieOnItemConflict"] = SourceExpressionConverter.ConvertToken(saveProjectWrapperdieOnItemConflict);
                    saveProjectWrapperpropCount++;
                }

                if (saveProjectWrapperignoredUserErrorMessages != null)
                {
                    saveProjectWrapper["ignoredUserErrorMessages"] = SourceExpressionConverter.ConvertToken(saveProjectWrapperignoredUserErrorMessages);
                    saveProjectWrapperpropCount++;
                }

                if (saveProjectWrapperpropCount > 0)
                {
                    callPayload.Body = saveProjectWrapper;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesBooleanResponse> SaveRelation([WorkflowExpression] Func<string> saveRelationWrappertransmitObjectitemGUID1 = null, [WorkflowExpression] Func<string> saveRelationWrappertransmitObjectitemGUID2 = null, [WorkflowExpression] Func<saveRelationWrappertransmitObjectfolderName1Input> saveRelationWrappertransmitObjectfolderName1 = null, [WorkflowExpression] Func<saveRelationWrappertransmitObjectfolderName2Input> saveRelationWrappertransmitObjectfolderName2 = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    transmitObjectObject["ItemGUID1"] = SourceExpressionConverter.ConvertToken(saveRelationWrappertransmitObjectitemGUID1);
                    transmitObjectObjectpropCount++;
                }

                if (saveRelationWrappertransmitObjectitemGUID2 != null)
                {
                    transmitObjectObject["ItemGUID2"] = SourceExpressionConverter.ConvertToken(saveRelationWrappertransmitObjectitemGUID2);
                    transmitObjectObjectpropCount++;
                }

                if (saveRelationWrappertransmitObjectfolderName1 != null)
                {
                    transmitObjectObject["FolderName1"] = SourceExpressionConverter.Convert(saveRelationWrappertransmitObjectfolderName1);
                    transmitObjectObjectpropCount++;
                }

                if (saveRelationWrappertransmitObjectfolderName2 != null)
                {
                    transmitObjectObject["FolderName2"] = SourceExpressionConverter.Convert(saveRelationWrappertransmitObjectfolderName2);
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
                return callPayload;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesBooleanResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveTask([WorkflowExpression] Func<string> saveTaskWrappertransmitObjectbody = null, [WorkflowExpression] Func<bool> saveTaskWrappertransmitObjectisCompleted = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectdueDate = null, [WorkflowExpression] Func<double> saveTaskWrappertransmitObjectpercentCompleteDecimal = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectstartDate = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectsubject = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<int> saveTaskWrappertransmitObjectlevel = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectimportanceEn = null, [WorkflowExpression] Func<double> saveTaskWrappertransmitObjectactualWorkHours = null, [WorkflowExpression] Func<double> saveTaskWrappertransmitObjectestimatedWorkHours = null, [WorkflowExpression] Func<bool> saveTaskWrappertransmitObjectisReminderSet = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectreminderDate = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectcompletedDate = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectpicture = null, [WorkflowExpression] Func<int> saveTaskWrappertransmitObjectpictureWidth = null, [WorkflowExpression] Func<int> saveTaskWrappertransmitObjectpictureHeight = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectleadsTaskParentGuid = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectprojectsTaskParentGuid = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjecttasksTaskParentGuid = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectmarketingTaskParentGuid = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectcompaniesCompanyGuid = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectcontactsContactGuid = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectusersTaskDelegatorGuid = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectusersTaskSolverGuid = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjecttasksTaskOriginGuid = null, [WorkflowExpression] Func<bool> saveTaskWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> saveTaskWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<string> saveTaskWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> saveTaskWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> saveTaskWrapperdieOnItemConflict = null, [WorkflowExpression] Func<string[]> saveTaskWrapperignoredUserErrorMessages = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    transmitObjectObject["Body"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectbody);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectisCompleted != null)
                {
                    transmitObjectObject["IsCompleted"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectisCompleted);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectdueDate != null)
                {
                    transmitObjectObject["DueDate"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectdueDate);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectpercentCompleteDecimal != null)
                {
                    transmitObjectObject["PercentCompleteDecimal"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectpercentCompleteDecimal);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectstartDate != null)
                {
                    transmitObjectObject["StartDate"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectstartDate);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectsubject != null)
                {
                    transmitObjectObject["Subject"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectsubject);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectlevel != null)
                {
                    transmitObjectObject["Level"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectlevel);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectimportanceEn != null)
                {
                    transmitObjectObject["ImportanceEn"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectimportanceEn);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectactualWorkHours != null)
                {
                    transmitObjectObject["ActualWorkHours"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectactualWorkHours);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectestimatedWorkHours != null)
                {
                    transmitObjectObject["EstimatedWorkHours"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectestimatedWorkHours);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectisReminderSet != null)
                {
                    transmitObjectObject["IsReminderSet"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectisReminderSet);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectreminderDate != null)
                {
                    transmitObjectObject["ReminderDate"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectreminderDate);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectcompletedDate != null)
                {
                    transmitObjectObject["CompletedDate"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectcompletedDate);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectpicture != null)
                {
                    transmitObjectObject["Picture"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectpicture);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectpictureWidth != null)
                {
                    transmitObjectObject["PictureWidth"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectpictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectpictureHeight != null)
                {
                    transmitObjectObject["PictureHeight"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectpictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectleadsTaskParentGuid != null)
                {
                    transmitObjectObject["Leads_TaskParentGuid"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectleadsTaskParentGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectprojectsTaskParentGuid != null)
                {
                    transmitObjectObject["Projects_TaskParentGuid"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectprojectsTaskParentGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjecttasksTaskParentGuid != null)
                {
                    transmitObjectObject["Tasks_TaskParentGuid"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjecttasksTaskParentGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectmarketingTaskParentGuid != null)
                {
                    transmitObjectObject["Marketing_TaskParentGuid"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectmarketingTaskParentGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectcompaniesCompanyGuid != null)
                {
                    transmitObjectObject["Companies_CompanyGuid"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectcompaniesCompanyGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectcontactsContactGuid != null)
                {
                    transmitObjectObject["Contacts_ContactGuid"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectcontactsContactGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectusersTaskDelegatorGuid != null)
                {
                    transmitObjectObject["Users_TaskDelegatorGuid"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectusersTaskDelegatorGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectusersTaskSolverGuid != null)
                {
                    transmitObjectObject["Users_TaskSolverGuid"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectusersTaskSolverGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjecttasksTaskOriginGuid != null)
                {
                    transmitObjectObject["Tasks_TaskOriginGuid"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjecttasksTaskOriginGuid);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (saveTaskWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = SourceExpressionConverter.ConvertToken(saveTaskWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    saveTaskWrapper["transmitObject"] = transmitObjectObject;
                    saveTaskWrapperpropCount++;
                }

                if (saveTaskWrapperdieOnItemConflict != null)
                {
                    saveTaskWrapper["dieOnItemConflict"] = SourceExpressionConverter.ConvertToken(saveTaskWrapperdieOnItemConflict);
                    saveTaskWrapperpropCount++;
                }

                if (saveTaskWrapperignoredUserErrorMessages != null)
                {
                    saveTaskWrapper["ignoredUserErrorMessages"] = SourceExpressionConverter.ConvertToken(saveTaskWrapperignoredUserErrorMessages);
                    saveTaskWrapperpropCount++;
                }

                if (saveTaskWrapperpropCount > 0)
                {
                    callPayload.Body = saveTaskWrapper;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany> SearchCompanies([WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaccountNumber = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress1POBox = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress1Street = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress1City = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress1State = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress1CountryEn = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress1PostalCode = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress2POBox = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress2Street = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress2City = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress2State = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress2CountryEn = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress2PostalCode = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress3POBox = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress3Street = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress3City = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress3State = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress3CountryEn = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectaddress3PostalCode = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectcompanyName = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectdepartment = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectemail = null, [WorkflowExpression] Func<int> searchCompaniesWrappertransmitObjectemployeesCount = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectfax = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectfirstContactEn = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectiCQ = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectidentificationNumber = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectimportanceEn = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectlineOfBusiness = null, [WorkflowExpression] Func<bool> searchCompaniesWrappertransmitObjectmailingListOther = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectmobile = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectmobileNormalized = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectmSN = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectnote = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectphone = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectphoneNormalized = null, [WorkflowExpression] Func<bool> searchCompaniesWrappertransmitObjectpurchaser = null, [WorkflowExpression] Func<double> searchCompaniesWrappertransmitObjectreversal = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectskype = null, [WorkflowExpression] Func<bool> searchCompaniesWrappertransmitObjectsuppliers = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectvATNumber = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectwebPage = null, [WorkflowExpression] Func<double> searchCompaniesWrappertransmitObjectadditionalDiscount = null, [WorkflowExpression] Func<int> searchCompaniesWrappertransmitObjectid = null, [WorkflowExpression] Func<bool> searchCompaniesWrappertransmitObjectcompetitor = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectsalePriceGuid = null, [WorkflowExpression] Func<bool> searchCompaniesWrappertransmitObjectnotificationByEmail = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectnotificationBy = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectlastActivity = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectnextStep = null, [WorkflowExpression] Func<bool> searchCompaniesWrappertransmitObjectemailOptOut = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectpicture = null, [WorkflowExpression] Func<int> searchCompaniesWrappertransmitObjectpictureWidth = null, [WorkflowExpression] Func<int> searchCompaniesWrappertransmitObjectpictureHeight = null, [WorkflowExpression] Func<bool> searchCompaniesWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectserverItemCreated = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectserverItemChanged = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> searchCompaniesWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]> searchCompaniesWrappertransmitObjectrelations = null, [WorkflowExpression] Func<string> searchCompaniesWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> searchCompaniesWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> searchCompaniesWrapperincludeRelations = null, [WorkflowExpression] Func<string> searchCompaniesWrapperrelationsFilterrelationType = null, [WorkflowExpression] Func<string> searchCompaniesWrapperrelationsFilterforeignFolderName = null, [WorkflowExpression] Func<string> searchCompaniesWrapperbinaryLogicalOperator = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    transmitObjectObject["AccountNumber"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaccountNumber);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectaddress1POBox != null)
                {
                    transmitObjectObject["Address1POBox"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress1POBox);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectaddress1Street != null)
                {
                    transmitObjectObject["Address1Street"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress1Street);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectaddress1City != null)
                {
                    transmitObjectObject["Address1City"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress1City);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectaddress1State != null)
                {
                    transmitObjectObject["Address1State"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress1State);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectaddress1CountryEn != null)
                {
                    transmitObjectObject["Address1CountryEn"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress1CountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectaddress1PostalCode != null)
                {
                    transmitObjectObject["Address1PostalCode"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress1PostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectaddress2POBox != null)
                {
                    transmitObjectObject["Address2POBox"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress2POBox);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectaddress2Street != null)
                {
                    transmitObjectObject["Address2Street"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress2Street);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectaddress2City != null)
                {
                    transmitObjectObject["Address2City"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress2City);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectaddress2State != null)
                {
                    transmitObjectObject["Address2State"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress2State);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectaddress2CountryEn != null)
                {
                    transmitObjectObject["Address2CountryEn"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress2CountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectaddress2PostalCode != null)
                {
                    transmitObjectObject["Address2PostalCode"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress2PostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectaddress3POBox != null)
                {
                    transmitObjectObject["Address3POBox"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress3POBox);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectaddress3Street != null)
                {
                    transmitObjectObject["Address3Street"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress3Street);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectaddress3City != null)
                {
                    transmitObjectObject["Address3City"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress3City);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectaddress3State != null)
                {
                    transmitObjectObject["Address3State"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress3State);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectaddress3CountryEn != null)
                {
                    transmitObjectObject["Address3CountryEn"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress3CountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectaddress3PostalCode != null)
                {
                    transmitObjectObject["Address3PostalCode"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectaddress3PostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectcompanyName != null)
                {
                    transmitObjectObject["CompanyName"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectcompanyName);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectdepartment != null)
                {
                    transmitObjectObject["Department"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectdepartment);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectemail != null)
                {
                    transmitObjectObject["Email"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectemail);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectemployeesCount != null)
                {
                    transmitObjectObject["EmployeesCount"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectemployeesCount);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectfax != null)
                {
                    transmitObjectObject["Fax"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectfax);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectfirstContactEn != null)
                {
                    transmitObjectObject["FirstContactEn"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectfirstContactEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectiCQ != null)
                {
                    transmitObjectObject["ICQ"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectiCQ);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectidentificationNumber != null)
                {
                    transmitObjectObject["IdentificationNumber"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectidentificationNumber);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectimportanceEn != null)
                {
                    transmitObjectObject["ImportanceEn"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectimportanceEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectlineOfBusiness != null)
                {
                    transmitObjectObject["LineOfBusiness"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectlineOfBusiness);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectmailingListOther != null)
                {
                    transmitObjectObject["MailingListOther"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectmailingListOther);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectmobile != null)
                {
                    transmitObjectObject["Mobile"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectmobile);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectmobileNormalized != null)
                {
                    transmitObjectObject["MobileNormalized"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectmobileNormalized);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectmSN != null)
                {
                    transmitObjectObject["MSN"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectmSN);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectnote != null)
                {
                    transmitObjectObject["Note"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectnote);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectphone != null)
                {
                    transmitObjectObject["Phone"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectphone);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectphoneNormalized != null)
                {
                    transmitObjectObject["PhoneNormalized"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectphoneNormalized);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectpurchaser != null)
                {
                    transmitObjectObject["Purchaser"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectpurchaser);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectreversal != null)
                {
                    transmitObjectObject["Reversal"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectreversal);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectskype != null)
                {
                    transmitObjectObject["Skype"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectskype);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectsuppliers != null)
                {
                    transmitObjectObject["Suppliers"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectsuppliers);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectvATNumber != null)
                {
                    transmitObjectObject["VATNumber"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectvATNumber);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectwebPage != null)
                {
                    transmitObjectObject["WebPage"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectwebPage);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectadditionalDiscount != null)
                {
                    transmitObjectObject["AdditionalDiscount"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectadditionalDiscount);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectid != null)
                {
                    transmitObjectObject["ID"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectid);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectcompetitor != null)
                {
                    transmitObjectObject["Competitor"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectcompetitor);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectsalePriceGuid != null)
                {
                    transmitObjectObject["SalePriceGuid"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectsalePriceGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectnotificationByEmail != null)
                {
                    transmitObjectObject["NotificationByEmail"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectnotificationByEmail);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectnotificationBy != null)
                {
                    transmitObjectObject["NotificationBy"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectnotificationBy);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectlastActivity != null)
                {
                    transmitObjectObject["LastActivity"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectlastActivity);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectnextStep != null)
                {
                    transmitObjectObject["NextStep"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectnextStep);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectemailOptOut != null)
                {
                    transmitObjectObject["EmailOptOut"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectemailOptOut);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectpicture != null)
                {
                    transmitObjectObject["Picture"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectpicture);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectpictureWidth != null)
                {
                    transmitObjectObject["PictureWidth"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectpictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectpictureHeight != null)
                {
                    transmitObjectObject["PictureHeight"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectpictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectserverItemCreated != null)
                {
                    transmitObjectObject["Server_ItemCreated"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectserverItemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectserverItemChanged != null)
                {
                    transmitObjectObject["Server_ItemChanged"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectserverItemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectrelations != null)
                {
                    transmitObjectObject["Relations"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectrelations);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchCompaniesWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    searchCompaniesWrapper["transmitObject"] = transmitObjectObject;
                    searchCompaniesWrapperpropCount++;
                }

                if (searchCompaniesWrapperincludeRelations != null)
                {
                    searchCompaniesWrapper["includeRelations"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrapperincludeRelations);
                    searchCompaniesWrapperpropCount++;
                }

                var relationsFilterObject = new JObject();
                var relationsFilterObjectpropCount = 0;
                if (searchCompaniesWrapperrelationsFilterrelationType != null)
                {
                    relationsFilterObject["RelationType"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrapperrelationsFilterrelationType);
                    relationsFilterObjectpropCount++;
                }

                if (searchCompaniesWrapperrelationsFilterforeignFolderName != null)
                {
                    relationsFilterObject["ForeignFolderName"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrapperrelationsFilterforeignFolderName);
                    relationsFilterObjectpropCount++;
                }

                if (relationsFilterObjectpropCount > 0)
                {
                    searchCompaniesWrapper["relationsFilter"] = relationsFilterObject;
                    searchCompaniesWrapperpropCount++;
                }

                if (searchCompaniesWrapperbinaryLogicalOperator != null)
                {
                    searchCompaniesWrapper["binaryLogicalOperator"] = SourceExpressionConverter.ConvertToken(searchCompaniesWrapperbinaryLogicalOperator);
                    searchCompaniesWrapperpropCount++;
                }

                if (searchCompaniesWrapperpropCount > 0)
                {
                    callPayload.Body = searchCompaniesWrapper;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact> SearchContacts([WorkflowExpression] Func<string> searchContactsWrappertransmitObjectcompaniesCompanyGuid = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectbusinessAddressStreet = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectbusinessAddressCity = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectbusinessAddressState = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectbusinessAddressCountryEn = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectbusinessAddressPOBox = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectbusinessAddressPostalCode = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecthomeAddressStreet = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecthomeAddressCity = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecthomeAddressState = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecthomeAddressCountryEn = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecthomeAddressPOBox = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecthomeAddressPostalCode = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectotherAddressStreet = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectotherAddressCity = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectotherAddressState = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectotherAddressCountryEn = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectotherAddressPOBox = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectotherAddressPostalCode = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectcompany = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectemail1Address = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectemail2Address = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectemail3Address = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectfirstName = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectiCQ = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectimportanceEn = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectlastName = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectmiddleName = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectmSN = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectnote = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectprefixEn = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectsuffixEn = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectskype = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber1 = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber2 = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber3 = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber4 = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber5 = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber6 = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber1Normalized = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber2Normalized = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber3Normalized = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber4Normalized = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber5Normalized = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttelephoneNumber6Normalized = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectdepartment = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttitle = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectwebPage = null, [WorkflowExpression] Func<bool> searchContactsWrappertransmitObjectdoNotSendNewsletter = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectprofilePicture = null, [WorkflowExpression] Func<int> searchContactsWrappertransmitObjectprofilePictureWidth = null, [WorkflowExpression] Func<int> searchContactsWrappertransmitObjectprofilePictureHeight = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectlastActivity = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectnextStep = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<bool> searchContactsWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectserverItemCreated = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectserverItemChanged = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> searchContactsWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]> searchContactsWrappertransmitObjectrelations = null, [WorkflowExpression] Func<string> searchContactsWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> searchContactsWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> searchContactsWrapperincludeRelations = null, [WorkflowExpression] Func<string> searchContactsWrapperrelationsFilterrelationType = null, [WorkflowExpression] Func<string> searchContactsWrapperrelationsFilterforeignFolderName = null, [WorkflowExpression] Func<bool> searchContactsWrapperincludeProfilePictures = null, [WorkflowExpression] Func<string> searchContactsWrapperbinaryLogicalOperator = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    transmitObjectObject["Companies_CompanyGuid"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectcompaniesCompanyGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectbusinessAddressStreet != null)
                {
                    transmitObjectObject["BusinessAddressStreet"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectbusinessAddressStreet);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectbusinessAddressCity != null)
                {
                    transmitObjectObject["BusinessAddressCity"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectbusinessAddressCity);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectbusinessAddressState != null)
                {
                    transmitObjectObject["BusinessAddressState"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectbusinessAddressState);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectbusinessAddressCountryEn != null)
                {
                    transmitObjectObject["BusinessAddressCountryEn"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectbusinessAddressCountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectbusinessAddressPOBox != null)
                {
                    transmitObjectObject["BusinessAddressPOBox"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectbusinessAddressPOBox);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectbusinessAddressPostalCode != null)
                {
                    transmitObjectObject["BusinessAddressPostalCode"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectbusinessAddressPostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjecthomeAddressStreet != null)
                {
                    transmitObjectObject["HomeAddressStreet"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecthomeAddressStreet);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjecthomeAddressCity != null)
                {
                    transmitObjectObject["HomeAddressCity"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecthomeAddressCity);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjecthomeAddressState != null)
                {
                    transmitObjectObject["HomeAddressState"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecthomeAddressState);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjecthomeAddressCountryEn != null)
                {
                    transmitObjectObject["HomeAddressCountryEn"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecthomeAddressCountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjecthomeAddressPOBox != null)
                {
                    transmitObjectObject["HomeAddressPOBox"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecthomeAddressPOBox);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjecthomeAddressPostalCode != null)
                {
                    transmitObjectObject["HomeAddressPostalCode"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecthomeAddressPostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectotherAddressStreet != null)
                {
                    transmitObjectObject["OtherAddressStreet"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectotherAddressStreet);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectotherAddressCity != null)
                {
                    transmitObjectObject["OtherAddressCity"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectotherAddressCity);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectotherAddressState != null)
                {
                    transmitObjectObject["OtherAddressState"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectotherAddressState);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectotherAddressCountryEn != null)
                {
                    transmitObjectObject["OtherAddressCountryEn"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectotherAddressCountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectotherAddressPOBox != null)
                {
                    transmitObjectObject["OtherAddressPOBox"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectotherAddressPOBox);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectotherAddressPostalCode != null)
                {
                    transmitObjectObject["OtherAddressPostalCode"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectotherAddressPostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectcompany != null)
                {
                    transmitObjectObject["Company"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectcompany);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectemail1Address != null)
                {
                    transmitObjectObject["Email1Address"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectemail1Address);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectemail2Address != null)
                {
                    transmitObjectObject["Email2Address"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectemail2Address);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectemail3Address != null)
                {
                    transmitObjectObject["Email3Address"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectemail3Address);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectfirstName != null)
                {
                    transmitObjectObject["FirstName"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectfirstName);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectiCQ != null)
                {
                    transmitObjectObject["ICQ"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectiCQ);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectimportanceEn != null)
                {
                    transmitObjectObject["ImportanceEn"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectimportanceEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectlastName != null)
                {
                    transmitObjectObject["LastName"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectlastName);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectmiddleName != null)
                {
                    transmitObjectObject["MiddleName"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectmiddleName);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectmSN != null)
                {
                    transmitObjectObject["MSN"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectmSN);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectnote != null)
                {
                    transmitObjectObject["Note"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectnote);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectprefixEn != null)
                {
                    transmitObjectObject["PrefixEn"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectprefixEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectsuffixEn != null)
                {
                    transmitObjectObject["SuffixEn"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectsuffixEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectskype != null)
                {
                    transmitObjectObject["Skype"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectskype);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjecttelephoneNumber1 != null)
                {
                    transmitObjectObject["TelephoneNumber1"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber1);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjecttelephoneNumber2 != null)
                {
                    transmitObjectObject["TelephoneNumber2"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber2);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjecttelephoneNumber3 != null)
                {
                    transmitObjectObject["TelephoneNumber3"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber3);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjecttelephoneNumber4 != null)
                {
                    transmitObjectObject["TelephoneNumber4"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber4);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjecttelephoneNumber5 != null)
                {
                    transmitObjectObject["TelephoneNumber5"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber5);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjecttelephoneNumber6 != null)
                {
                    transmitObjectObject["TelephoneNumber6"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber6);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjecttelephoneNumber1Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber1Normalized"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber1Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjecttelephoneNumber2Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber2Normalized"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber2Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjecttelephoneNumber3Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber3Normalized"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber3Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjecttelephoneNumber4Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber4Normalized"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber4Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjecttelephoneNumber5Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber5Normalized"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber5Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjecttelephoneNumber6Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber6Normalized"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttelephoneNumber6Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectdepartment != null)
                {
                    transmitObjectObject["Department"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectdepartment);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjecttitle != null)
                {
                    transmitObjectObject["Title"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttitle);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectwebPage != null)
                {
                    transmitObjectObject["WebPage"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectwebPage);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectdoNotSendNewsletter != null)
                {
                    transmitObjectObject["DoNotSendNewsletter"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectdoNotSendNewsletter);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectprofilePicture != null)
                {
                    transmitObjectObject["ProfilePicture"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectprofilePicture);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectprofilePictureWidth != null)
                {
                    transmitObjectObject["ProfilePictureWidth"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectprofilePictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectprofilePictureHeight != null)
                {
                    transmitObjectObject["ProfilePictureHeight"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectprofilePictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectlastActivity != null)
                {
                    transmitObjectObject["LastActivity"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectlastActivity);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectnextStep != null)
                {
                    transmitObjectObject["NextStep"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectnextStep);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectserverItemCreated != null)
                {
                    transmitObjectObject["Server_ItemCreated"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectserverItemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectserverItemChanged != null)
                {
                    transmitObjectObject["Server_ItemChanged"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectserverItemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectrelations != null)
                {
                    transmitObjectObject["Relations"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectrelations);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchContactsWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = SourceExpressionConverter.ConvertToken(searchContactsWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    searchContactsWrapper["transmitObject"] = transmitObjectObject;
                    searchContactsWrapperpropCount++;
                }

                if (searchContactsWrapperincludeRelations != null)
                {
                    searchContactsWrapper["includeRelations"] = SourceExpressionConverter.ConvertToken(searchContactsWrapperincludeRelations);
                    searchContactsWrapperpropCount++;
                }

                var relationsFilterObject = new JObject();
                var relationsFilterObjectpropCount = 0;
                if (searchContactsWrapperrelationsFilterrelationType != null)
                {
                    relationsFilterObject["RelationType"] = SourceExpressionConverter.ConvertToken(searchContactsWrapperrelationsFilterrelationType);
                    relationsFilterObjectpropCount++;
                }

                if (searchContactsWrapperrelationsFilterforeignFolderName != null)
                {
                    relationsFilterObject["ForeignFolderName"] = SourceExpressionConverter.ConvertToken(searchContactsWrapperrelationsFilterforeignFolderName);
                    relationsFilterObjectpropCount++;
                }

                if (relationsFilterObjectpropCount > 0)
                {
                    searchContactsWrapper["relationsFilter"] = relationsFilterObject;
                    searchContactsWrapperpropCount++;
                }

                if (searchContactsWrapperincludeProfilePictures != null)
                {
                    searchContactsWrapper["includeProfilePictures"] = SourceExpressionConverter.ConvertToken(searchContactsWrapperincludeProfilePictures);
                    searchContactsWrapperpropCount++;
                }

                if (searchContactsWrapperbinaryLogicalOperator != null)
                {
                    searchContactsWrapper["binaryLogicalOperator"] = SourceExpressionConverter.ConvertToken(searchContactsWrapperbinaryLogicalOperator);
                    searchContactsWrapperpropCount++;
                }

                if (searchContactsWrapperpropCount > 0)
                {
                    callPayload.Body = searchContactsWrapper;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal> SearchJournals([WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectmarketingSuperiorItemGuid = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectcompaniesCompanyGuid = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectcontactsContactGuid = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectleadsSuperiorItemGuid = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectprojectsSuperiorItemGuid = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectmarketingMarketingGuid = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectcalendarEntryId = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectcalendarORIGIN = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectchangedField = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjecteventEnd = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjecteventStart = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectfieldValue = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectimportanceEn = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectnote = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectprevFieldValue = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<bool> searchJournalsWrappertransmitObjectisSystem = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectphone = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectphoneNormalized = null, [WorkflowExpression] Func<bool> searchJournalsWrappertransmitObjectisGdprRelevant = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectpicture = null, [WorkflowExpression] Func<int> searchJournalsWrappertransmitObjectpictureWidth = null, [WorkflowExpression] Func<int> searchJournalsWrappertransmitObjectpictureHeight = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<bool> searchJournalsWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectserverItemCreated = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectserverItemChanged = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> searchJournalsWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]> searchJournalsWrappertransmitObjectrelations = null, [WorkflowExpression] Func<string> searchJournalsWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> searchJournalsWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> searchJournalsWrapperincludeRelations = null, [WorkflowExpression] Func<string> searchJournalsWrapperrelationsFilterrelationType = null, [WorkflowExpression] Func<string> searchJournalsWrapperrelationsFilterforeignFolderName = null, [WorkflowExpression] Func<string> searchJournalsWrapperbinaryLogicalOperator = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    transmitObjectObject["Marketing_SuperiorItemGuid"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectmarketingSuperiorItemGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectcompaniesCompanyGuid != null)
                {
                    transmitObjectObject["Companies_CompanyGuid"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectcompaniesCompanyGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectcontactsContactGuid != null)
                {
                    transmitObjectObject["Contacts_ContactGuid"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectcontactsContactGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectleadsSuperiorItemGuid != null)
                {
                    transmitObjectObject["Leads_SuperiorItemGuid"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectleadsSuperiorItemGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectprojectsSuperiorItemGuid != null)
                {
                    transmitObjectObject["Projects_SuperiorItemGuid"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectprojectsSuperiorItemGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectmarketingMarketingGuid != null)
                {
                    transmitObjectObject["Marketing_MarketingGuid"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectmarketingMarketingGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectcalendarEntryId != null)
                {
                    transmitObjectObject["CalendarEntryID"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectcalendarEntryId);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectcalendarORIGIN != null)
                {
                    transmitObjectObject["Calendar_ORIGIN"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectcalendarORIGIN);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectchangedField != null)
                {
                    transmitObjectObject["ChangedField"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectchangedField);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjecteventEnd != null)
                {
                    transmitObjectObject["EventEnd"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjecteventEnd);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjecteventStart != null)
                {
                    transmitObjectObject["EventStart"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjecteventStart);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectfieldValue != null)
                {
                    transmitObjectObject["FieldValue"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectfieldValue);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectimportanceEn != null)
                {
                    transmitObjectObject["ImportanceEn"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectimportanceEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectnote != null)
                {
                    transmitObjectObject["Note"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectnote);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectprevFieldValue != null)
                {
                    transmitObjectObject["PrevFieldValue"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectprevFieldValue);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectisSystem != null)
                {
                    transmitObjectObject["IsSystem"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectisSystem);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectphone != null)
                {
                    transmitObjectObject["Phone"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectphone);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectphoneNormalized != null)
                {
                    transmitObjectObject["PhoneNormalized"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectphoneNormalized);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectisGdprRelevant != null)
                {
                    transmitObjectObject["IsGdprRelevant"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectisGdprRelevant);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectpicture != null)
                {
                    transmitObjectObject["Picture"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectpicture);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectpictureWidth != null)
                {
                    transmitObjectObject["PictureWidth"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectpictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectpictureHeight != null)
                {
                    transmitObjectObject["PictureHeight"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectpictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectserverItemCreated != null)
                {
                    transmitObjectObject["Server_ItemCreated"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectserverItemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectserverItemChanged != null)
                {
                    transmitObjectObject["Server_ItemChanged"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectserverItemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectrelations != null)
                {
                    transmitObjectObject["Relations"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectrelations);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchJournalsWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = SourceExpressionConverter.ConvertToken(searchJournalsWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    searchJournalsWrapper["transmitObject"] = transmitObjectObject;
                    searchJournalsWrapperpropCount++;
                }

                if (searchJournalsWrapperincludeRelations != null)
                {
                    searchJournalsWrapper["includeRelations"] = SourceExpressionConverter.ConvertToken(searchJournalsWrapperincludeRelations);
                    searchJournalsWrapperpropCount++;
                }

                var relationsFilterObject = new JObject();
                var relationsFilterObjectpropCount = 0;
                if (searchJournalsWrapperrelationsFilterrelationType != null)
                {
                    relationsFilterObject["RelationType"] = SourceExpressionConverter.ConvertToken(searchJournalsWrapperrelationsFilterrelationType);
                    relationsFilterObjectpropCount++;
                }

                if (searchJournalsWrapperrelationsFilterforeignFolderName != null)
                {
                    relationsFilterObject["ForeignFolderName"] = SourceExpressionConverter.ConvertToken(searchJournalsWrapperrelationsFilterforeignFolderName);
                    relationsFilterObjectpropCount++;
                }

                if (relationsFilterObjectpropCount > 0)
                {
                    searchJournalsWrapper["relationsFilter"] = relationsFilterObject;
                    searchJournalsWrapperpropCount++;
                }

                if (searchJournalsWrapperbinaryLogicalOperator != null)
                {
                    searchJournalsWrapper["binaryLogicalOperator"] = SourceExpressionConverter.ConvertToken(searchJournalsWrapperbinaryLogicalOperator);
                    searchJournalsWrapperpropCount++;
                }

                if (searchJournalsWrapperpropCount > 0)
                {
                    callPayload.Body = searchJournalsWrapper;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead> SearchLeads([WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectcompaniesCustomerGuid = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectcontactsContactPersonGuid = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectmarketingMarketingGuid = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectcity = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectcontactPerson = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectcurrencyEn = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectcustomer = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectemail = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectestimatedEnd = null, [WorkflowExpression] Func<int> searchLeadsWrappertransmitObjecthId = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectleadOriginEn = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectnote = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectphone = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectphoneNormalized = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<double> searchLeadsWrappertransmitObjectprice = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectpriceChanged = null, [WorkflowExpression] Func<double> searchLeadsWrappertransmitObjectpriceDefaultCurrency = null, [WorkflowExpression] Func<double> searchLeadsWrappertransmitObjectprobability = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectreceiveDate = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectstreet = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectzip = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectlastActivity = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectnextStep = null, [WorkflowExpression] Func<double> searchLeadsWrappertransmitObjectestimatedValue = null, [WorkflowExpression] Func<bool> searchLeadsWrappertransmitObjectisCompleted = null, [WorkflowExpression] Func<bool> searchLeadsWrappertransmitObjectisLost = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectcountryEn = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectstate = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectpOBox = null, [WorkflowExpression] Func<bool> searchLeadsWrappertransmitObjectemailOptOut = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectpicture = null, [WorkflowExpression] Func<int> searchLeadsWrappertransmitObjectpictureWidth = null, [WorkflowExpression] Func<int> searchLeadsWrappertransmitObjectpictureHeight = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectcompletedDate = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectlostDate = null, [WorkflowExpression] Func<bool> searchLeadsWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectserverItemCreated = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectserverItemChanged = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> searchLeadsWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]> searchLeadsWrappertransmitObjectrelations = null, [WorkflowExpression] Func<string> searchLeadsWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> searchLeadsWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> searchLeadsWrapperincludeRelations = null, [WorkflowExpression] Func<string> searchLeadsWrapperrelationsFilterrelationType = null, [WorkflowExpression] Func<string> searchLeadsWrapperrelationsFilterforeignFolderName = null, [WorkflowExpression] Func<string> searchLeadsWrapperbinaryLogicalOperator = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    transmitObjectObject["Companies_CustomerGuid"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectcompaniesCustomerGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectcontactsContactPersonGuid != null)
                {
                    transmitObjectObject["Contacts_ContactPersonGuid"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectcontactsContactPersonGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectmarketingMarketingGuid != null)
                {
                    transmitObjectObject["Marketing_MarketingGuid"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectmarketingMarketingGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectcity != null)
                {
                    transmitObjectObject["City"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectcity);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectcontactPerson != null)
                {
                    transmitObjectObject["ContactPerson"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectcontactPerson);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectcurrencyEn != null)
                {
                    transmitObjectObject["CurrencyEn"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectcurrencyEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectcustomer != null)
                {
                    transmitObjectObject["Customer"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectcustomer);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectemail != null)
                {
                    transmitObjectObject["Email"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectemail);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectestimatedEnd != null)
                {
                    transmitObjectObject["EstimatedEnd"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectestimatedEnd);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjecthId != null)
                {
                    transmitObjectObject["HID"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjecthId);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectleadOriginEn != null)
                {
                    transmitObjectObject["LeadOriginEn"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectleadOriginEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectnote != null)
                {
                    transmitObjectObject["Note"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectnote);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectphone != null)
                {
                    transmitObjectObject["Phone"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectphone);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectphoneNormalized != null)
                {
                    transmitObjectObject["PhoneNormalized"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectphoneNormalized);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectprice != null)
                {
                    transmitObjectObject["Price"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectprice);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectpriceChanged != null)
                {
                    transmitObjectObject["PriceChanged"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectpriceChanged);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectpriceDefaultCurrency != null)
                {
                    transmitObjectObject["PriceDefaultCurrency"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectpriceDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectprobability != null)
                {
                    transmitObjectObject["Probability"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectprobability);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectreceiveDate != null)
                {
                    transmitObjectObject["ReceiveDate"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectreceiveDate);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectstreet != null)
                {
                    transmitObjectObject["Street"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectstreet);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectzip != null)
                {
                    transmitObjectObject["Zip"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectzip);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectlastActivity != null)
                {
                    transmitObjectObject["LastActivity"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectlastActivity);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectnextStep != null)
                {
                    transmitObjectObject["NextStep"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectnextStep);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectestimatedValue != null)
                {
                    transmitObjectObject["EstimatedValue"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectestimatedValue);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectisCompleted != null)
                {
                    transmitObjectObject["IsCompleted"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectisCompleted);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectisLost != null)
                {
                    transmitObjectObject["IsLost"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectisLost);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectcountryEn != null)
                {
                    transmitObjectObject["CountryEn"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectcountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectstate != null)
                {
                    transmitObjectObject["State"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectstate);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectpOBox != null)
                {
                    transmitObjectObject["POBox"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectpOBox);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectemailOptOut != null)
                {
                    transmitObjectObject["EmailOptOut"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectemailOptOut);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectpicture != null)
                {
                    transmitObjectObject["Picture"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectpicture);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectpictureWidth != null)
                {
                    transmitObjectObject["PictureWidth"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectpictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectpictureHeight != null)
                {
                    transmitObjectObject["PictureHeight"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectpictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectcompletedDate != null)
                {
                    transmitObjectObject["CompletedDate"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectcompletedDate);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectlostDate != null)
                {
                    transmitObjectObject["LostDate"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectlostDate);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectserverItemCreated != null)
                {
                    transmitObjectObject["Server_ItemCreated"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectserverItemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectserverItemChanged != null)
                {
                    transmitObjectObject["Server_ItemChanged"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectserverItemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectrelations != null)
                {
                    transmitObjectObject["Relations"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectrelations);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchLeadsWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = SourceExpressionConverter.ConvertToken(searchLeadsWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    searchLeadsWrapper["transmitObject"] = transmitObjectObject;
                    searchLeadsWrapperpropCount++;
                }

                if (searchLeadsWrapperincludeRelations != null)
                {
                    searchLeadsWrapper["includeRelations"] = SourceExpressionConverter.ConvertToken(searchLeadsWrapperincludeRelations);
                    searchLeadsWrapperpropCount++;
                }

                var relationsFilterObject = new JObject();
                var relationsFilterObjectpropCount = 0;
                if (searchLeadsWrapperrelationsFilterrelationType != null)
                {
                    relationsFilterObject["RelationType"] = SourceExpressionConverter.ConvertToken(searchLeadsWrapperrelationsFilterrelationType);
                    relationsFilterObjectpropCount++;
                }

                if (searchLeadsWrapperrelationsFilterforeignFolderName != null)
                {
                    relationsFilterObject["ForeignFolderName"] = SourceExpressionConverter.ConvertToken(searchLeadsWrapperrelationsFilterforeignFolderName);
                    relationsFilterObjectpropCount++;
                }

                if (relationsFilterObjectpropCount > 0)
                {
                    searchLeadsWrapper["relationsFilter"] = relationsFilterObject;
                    searchLeadsWrapperpropCount++;
                }

                if (searchLeadsWrapperbinaryLogicalOperator != null)
                {
                    searchLeadsWrapper["binaryLogicalOperator"] = SourceExpressionConverter.ConvertToken(searchLeadsWrapperbinaryLogicalOperator);
                    searchLeadsWrapperpropCount++;
                }

                if (searchLeadsWrapperpropCount > 0)
                {
                    callPayload.Body = searchLeadsWrapper;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject> SearchProjects([WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectcompaniesCustomerGuid = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectcontactsContactPersonGuid = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectleadsProjectOriginGuid = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectprojectsSuperiorProjectGuid = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectusersSupervisorGuid = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectnote = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectprice = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectprojectEnd = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectprojectName = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectpeopleExpenses = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectprojectRealEnd = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectestimatedPrice = null, [WorkflowExpression] Func<int> searchProjectsWrappertransmitObjecthId = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectprojectOriginEn = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectpaymentTypeEn = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectotherExpenses = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectmargin = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectprofit = null, [WorkflowExpression] Func<int> searchProjectsWrappertransmitObjectpaymentMaturity = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectinvoicePaymentDate = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectinvoiceIssueDate = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectestimatedMargin = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectestimatedProfit = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectestimatedPeopleExpenses = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectestimatedOtherExpenses = null, [WorkflowExpression] Func<int> searchProjectsWrappertransmitObjectlicensesCount = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectlicensePrice = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<bool> searchProjectsWrappertransmitObjectshowInCaplan = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectprojectStart = null, [WorkflowExpression] Func<int> searchProjectsWrappertransmitObjectestimatedWorkHours = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjecttotalWorkHours = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectestimatedOtherExpensesDefaultCurrency = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectestimatedPriceDefaultCurrency = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectpeopleExpensesDefaultCurrency = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectotherExpensesDefaultCurrency = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectpriceDefaultCurrency = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectprofitDefaultCurrency = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectestimatedProfitDefaultCurrency = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectcurrencyEn = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectestimatedPeopleExpensesChanged = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectestimatedOtherExpensesChanged = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectotherExpensesChanged = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectestimatedPriceChanged = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectpriceChanged = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectlicensePriceChanged = null, [WorkflowExpression] Func<double> searchProjectsWrappertransmitObjectlicensePriceDefaultCurrency = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectlastActivity = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectnextStep = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectcompletedDate = null, [WorkflowExpression] Func<bool> searchProjectsWrappertransmitObjectisCompleted = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectlostDate = null, [WorkflowExpression] Func<bool> searchProjectsWrappertransmitObjectisLost = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectpeopleExpensesChanged = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectpicture = null, [WorkflowExpression] Func<int> searchProjectsWrappertransmitObjectpictureWidth = null, [WorkflowExpression] Func<int> searchProjectsWrappertransmitObjectpictureHeight = null, [WorkflowExpression] Func<bool> searchProjectsWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectserverItemCreated = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectserverItemChanged = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> searchProjectsWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]> searchProjectsWrappertransmitObjectrelations = null, [WorkflowExpression] Func<string> searchProjectsWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> searchProjectsWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> searchProjectsWrapperincludeRelations = null, [WorkflowExpression] Func<string> searchProjectsWrapperrelationsFilterrelationType = null, [WorkflowExpression] Func<string> searchProjectsWrapperrelationsFilterforeignFolderName = null, [WorkflowExpression] Func<string> searchProjectsWrapperbinaryLogicalOperator = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    transmitObjectObject["Companies_CustomerGuid"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectcompaniesCustomerGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectcontactsContactPersonGuid != null)
                {
                    transmitObjectObject["Contacts_ContactPersonGuid"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectcontactsContactPersonGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectleadsProjectOriginGuid != null)
                {
                    transmitObjectObject["Leads_Project_OriginGuid"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectleadsProjectOriginGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectprojectsSuperiorProjectGuid != null)
                {
                    transmitObjectObject["Projects_SuperiorProjectGuid"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectprojectsSuperiorProjectGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectusersSupervisorGuid != null)
                {
                    transmitObjectObject["Users_SupervisorGuid"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectusersSupervisorGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectnote != null)
                {
                    transmitObjectObject["Note"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectnote);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectprice != null)
                {
                    transmitObjectObject["Price"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectprice);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectprojectEnd != null)
                {
                    transmitObjectObject["ProjectEnd"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectprojectEnd);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectprojectName != null)
                {
                    transmitObjectObject["ProjectName"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectprojectName);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectpeopleExpenses != null)
                {
                    transmitObjectObject["PeopleExpenses"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectpeopleExpenses);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectprojectRealEnd != null)
                {
                    transmitObjectObject["ProjectRealEnd"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectprojectRealEnd);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectestimatedPrice != null)
                {
                    transmitObjectObject["EstimatedPrice"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedPrice);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjecthId != null)
                {
                    transmitObjectObject["HID"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjecthId);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectprojectOriginEn != null)
                {
                    transmitObjectObject["ProjectOriginEn"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectprojectOriginEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectpaymentTypeEn != null)
                {
                    transmitObjectObject["PaymentTypeEn"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectpaymentTypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectotherExpenses != null)
                {
                    transmitObjectObject["OtherExpenses"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectotherExpenses);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectmargin != null)
                {
                    transmitObjectObject["Margin"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectmargin);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectprofit != null)
                {
                    transmitObjectObject["Profit"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectprofit);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectpaymentMaturity != null)
                {
                    transmitObjectObject["PaymentMaturity"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectpaymentMaturity);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectinvoicePaymentDate != null)
                {
                    transmitObjectObject["InvoicePaymentDate"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectinvoicePaymentDate);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectinvoiceIssueDate != null)
                {
                    transmitObjectObject["InvoiceIssueDate"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectinvoiceIssueDate);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectestimatedMargin != null)
                {
                    transmitObjectObject["EstimatedMargin"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedMargin);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectestimatedProfit != null)
                {
                    transmitObjectObject["EstimatedProfit"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedProfit);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectestimatedPeopleExpenses != null)
                {
                    transmitObjectObject["EstimatedPeopleExpenses"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedPeopleExpenses);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectestimatedOtherExpenses != null)
                {
                    transmitObjectObject["EstimatedOtherExpenses"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedOtherExpenses);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectlicensesCount != null)
                {
                    transmitObjectObject["LicensesCount"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectlicensesCount);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectlicensePrice != null)
                {
                    transmitObjectObject["LicensePrice"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectlicensePrice);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectshowInCaplan != null)
                {
                    transmitObjectObject["ShowInCaplan"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectshowInCaplan);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectprojectStart != null)
                {
                    transmitObjectObject["ProjectStart"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectprojectStart);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectestimatedWorkHours != null)
                {
                    transmitObjectObject["EstimatedWorkHours"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedWorkHours);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjecttotalWorkHours != null)
                {
                    transmitObjectObject["TotalWorkHours"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjecttotalWorkHours);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency != null)
                {
                    transmitObjectObject["EstimatedPeopleExpensesDefaultCurrency"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectestimatedOtherExpensesDefaultCurrency != null)
                {
                    transmitObjectObject["EstimatedOtherExpensesDefaultCurrency"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedOtherExpensesDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectestimatedPriceDefaultCurrency != null)
                {
                    transmitObjectObject["EstimatedPriceDefaultCurrency"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedPriceDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectpeopleExpensesDefaultCurrency != null)
                {
                    transmitObjectObject["PeopleExpensesDefaultCurrency"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectpeopleExpensesDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectotherExpensesDefaultCurrency != null)
                {
                    transmitObjectObject["OtherExpensesDefaultCurrency"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectotherExpensesDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectpriceDefaultCurrency != null)
                {
                    transmitObjectObject["PriceDefaultCurrency"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectpriceDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectprofitDefaultCurrency != null)
                {
                    transmitObjectObject["ProfitDefaultCurrency"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectprofitDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectestimatedProfitDefaultCurrency != null)
                {
                    transmitObjectObject["EstimatedProfitDefaultCurrency"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedProfitDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectcurrencyEn != null)
                {
                    transmitObjectObject["CurrencyEn"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectcurrencyEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectestimatedPeopleExpensesChanged != null)
                {
                    transmitObjectObject["EstimatedPeopleExpensesChanged"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedPeopleExpensesChanged);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectestimatedOtherExpensesChanged != null)
                {
                    transmitObjectObject["EstimatedOtherExpensesChanged"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedOtherExpensesChanged);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectotherExpensesChanged != null)
                {
                    transmitObjectObject["OtherExpensesChanged"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectotherExpensesChanged);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectestimatedPriceChanged != null)
                {
                    transmitObjectObject["EstimatedPriceChanged"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectestimatedPriceChanged);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectpriceChanged != null)
                {
                    transmitObjectObject["PriceChanged"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectpriceChanged);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectlicensePriceChanged != null)
                {
                    transmitObjectObject["LicensePriceChanged"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectlicensePriceChanged);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectlicensePriceDefaultCurrency != null)
                {
                    transmitObjectObject["LicensePriceDefaultCurrency"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectlicensePriceDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectlastActivity != null)
                {
                    transmitObjectObject["LastActivity"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectlastActivity);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectnextStep != null)
                {
                    transmitObjectObject["NextStep"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectnextStep);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectcompletedDate != null)
                {
                    transmitObjectObject["CompletedDate"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectcompletedDate);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectisCompleted != null)
                {
                    transmitObjectObject["IsCompleted"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectisCompleted);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectlostDate != null)
                {
                    transmitObjectObject["LostDate"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectlostDate);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectisLost != null)
                {
                    transmitObjectObject["IsLost"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectisLost);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectpeopleExpensesChanged != null)
                {
                    transmitObjectObject["PeopleExpensesChanged"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectpeopleExpensesChanged);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectpicture != null)
                {
                    transmitObjectObject["Picture"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectpicture);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectpictureWidth != null)
                {
                    transmitObjectObject["PictureWidth"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectpictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectpictureHeight != null)
                {
                    transmitObjectObject["PictureHeight"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectpictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectserverItemCreated != null)
                {
                    transmitObjectObject["Server_ItemCreated"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectserverItemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectserverItemChanged != null)
                {
                    transmitObjectObject["Server_ItemChanged"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectserverItemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectrelations != null)
                {
                    transmitObjectObject["Relations"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectrelations);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchProjectsWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = SourceExpressionConverter.ConvertToken(searchProjectsWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    searchProjectsWrapper["transmitObject"] = transmitObjectObject;
                    searchProjectsWrapperpropCount++;
                }

                if (searchProjectsWrapperincludeRelations != null)
                {
                    searchProjectsWrapper["includeRelations"] = SourceExpressionConverter.ConvertToken(searchProjectsWrapperincludeRelations);
                    searchProjectsWrapperpropCount++;
                }

                var relationsFilterObject = new JObject();
                var relationsFilterObjectpropCount = 0;
                if (searchProjectsWrapperrelationsFilterrelationType != null)
                {
                    relationsFilterObject["RelationType"] = SourceExpressionConverter.ConvertToken(searchProjectsWrapperrelationsFilterrelationType);
                    relationsFilterObjectpropCount++;
                }

                if (searchProjectsWrapperrelationsFilterforeignFolderName != null)
                {
                    relationsFilterObject["ForeignFolderName"] = SourceExpressionConverter.ConvertToken(searchProjectsWrapperrelationsFilterforeignFolderName);
                    relationsFilterObjectpropCount++;
                }

                if (relationsFilterObjectpropCount > 0)
                {
                    searchProjectsWrapper["relationsFilter"] = relationsFilterObject;
                    searchProjectsWrapperpropCount++;
                }

                if (searchProjectsWrapperbinaryLogicalOperator != null)
                {
                    searchProjectsWrapper["binaryLogicalOperator"] = SourceExpressionConverter.ConvertToken(searchProjectsWrapperbinaryLogicalOperator);
                    searchProjectsWrapperpropCount++;
                }

                if (searchProjectsWrapperpropCount > 0)
                {
                    callPayload.Body = searchProjectsWrapper;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask> SearchTasks([WorkflowExpression] Func<string> searchTasksWrappertransmitObjectleadsTopLevelProjectGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectleadsTaskParentGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectprojectsTopLevelProjectGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectprojectsTaskParentGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjecttasksTaskParentGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectmarketingTopLevelProjectGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectmarketingTaskParentGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectcompaniesCompanyGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectcontactsContactGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectusersTaskDelegatorGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectusersTaskSolverGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjecttasksTaskOriginGuid = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectbody = null, [WorkflowExpression] Func<bool> searchTasksWrappertransmitObjectisCompleted = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectdueDate = null, [WorkflowExpression] Func<double> searchTasksWrappertransmitObjectpercentCompleteDecimal = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectprevStateEn = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectstartDate = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectstateEn = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectsubject = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjecttypeEn = null, [WorkflowExpression] Func<int> searchTasksWrappertransmitObjectlevel = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectimportanceEn = null, [WorkflowExpression] Func<double> searchTasksWrappertransmitObjectactualWorkHours = null, [WorkflowExpression] Func<double> searchTasksWrappertransmitObjectestimatedWorkHours = null, [WorkflowExpression] Func<bool> searchTasksWrappertransmitObjectisReminderSet = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectreminderDate = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectcompletedDate = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectpicture = null, [WorkflowExpression] Func<int> searchTasksWrappertransmitObjectpictureWidth = null, [WorkflowExpression] Func<int> searchTasksWrappertransmitObjectpictureHeight = null, [WorkflowExpression] Func<bool> searchTasksWrappertransmitObjectisPrivate = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectserverItemCreated = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectserverItemChanged = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectitemCreated = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectitemChanged = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectfileAs = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectownerGUID = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectcreatedByGUID = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectmodifiedByGUID = null, [WorkflowExpression] Func<object> searchTasksWrappertransmitObjectadditionalFields = null, [WorkflowExpression] Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]> searchTasksWrappertransmitObjectrelations = null, [WorkflowExpression] Func<string> searchTasksWrappertransmitObjectitemGUID = null, [WorkflowExpression] Func<int> searchTasksWrappertransmitObjectitemVersion = null, [WorkflowExpression] Func<bool> searchTasksWrapperincludeRelations = null, [WorkflowExpression] Func<string> searchTasksWrapperrelationsFilterrelationType = null, [WorkflowExpression] Func<string> searchTasksWrapperrelationsFilterforeignFolderName = null, [WorkflowExpression] Func<string> searchTasksWrapperbinaryLogicalOperator = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    transmitObjectObject["Leads_TopLevelProjectGuid"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectleadsTopLevelProjectGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectleadsTaskParentGuid != null)
                {
                    transmitObjectObject["Leads_TaskParentGuid"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectleadsTaskParentGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectprojectsTopLevelProjectGuid != null)
                {
                    transmitObjectObject["Projects_TopLevelProjectGuid"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectprojectsTopLevelProjectGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectprojectsTaskParentGuid != null)
                {
                    transmitObjectObject["Projects_TaskParentGuid"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectprojectsTaskParentGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjecttasksTaskParentGuid != null)
                {
                    transmitObjectObject["Tasks_TaskParentGuid"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjecttasksTaskParentGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectmarketingTopLevelProjectGuid != null)
                {
                    transmitObjectObject["Marketing_TopLevelProjectGuid"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectmarketingTopLevelProjectGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectmarketingTaskParentGuid != null)
                {
                    transmitObjectObject["Marketing_TaskParentGuid"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectmarketingTaskParentGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectcompaniesCompanyGuid != null)
                {
                    transmitObjectObject["Companies_CompanyGuid"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectcompaniesCompanyGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectcontactsContactGuid != null)
                {
                    transmitObjectObject["Contacts_ContactGuid"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectcontactsContactGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectusersTaskDelegatorGuid != null)
                {
                    transmitObjectObject["Users_TaskDelegatorGuid"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectusersTaskDelegatorGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectusersTaskSolverGuid != null)
                {
                    transmitObjectObject["Users_TaskSolverGuid"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectusersTaskSolverGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjecttasksTaskOriginGuid != null)
                {
                    transmitObjectObject["Tasks_TaskOriginGuid"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjecttasksTaskOriginGuid);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectbody != null)
                {
                    transmitObjectObject["Body"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectbody);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectisCompleted != null)
                {
                    transmitObjectObject["IsCompleted"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectisCompleted);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectdueDate != null)
                {
                    transmitObjectObject["DueDate"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectdueDate);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectpercentCompleteDecimal != null)
                {
                    transmitObjectObject["PercentCompleteDecimal"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectpercentCompleteDecimal);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectstartDate != null)
                {
                    transmitObjectObject["StartDate"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectstartDate);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectsubject != null)
                {
                    transmitObjectObject["Subject"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectsubject);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectlevel != null)
                {
                    transmitObjectObject["Level"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectlevel);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectimportanceEn != null)
                {
                    transmitObjectObject["ImportanceEn"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectimportanceEn);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectactualWorkHours != null)
                {
                    transmitObjectObject["ActualWorkHours"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectactualWorkHours);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectestimatedWorkHours != null)
                {
                    transmitObjectObject["EstimatedWorkHours"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectestimatedWorkHours);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectisReminderSet != null)
                {
                    transmitObjectObject["IsReminderSet"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectisReminderSet);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectreminderDate != null)
                {
                    transmitObjectObject["ReminderDate"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectreminderDate);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectcompletedDate != null)
                {
                    transmitObjectObject["CompletedDate"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectcompletedDate);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectpicture != null)
                {
                    transmitObjectObject["Picture"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectpicture);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectpictureWidth != null)
                {
                    transmitObjectObject["PictureWidth"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectpictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectpictureHeight != null)
                {
                    transmitObjectObject["PictureHeight"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectpictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectserverItemCreated != null)
                {
                    transmitObjectObject["Server_ItemCreated"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectserverItemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectserverItemChanged != null)
                {
                    transmitObjectObject["Server_ItemChanged"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectserverItemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectrelations != null)
                {
                    transmitObjectObject["Relations"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectrelations);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (searchTasksWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = SourceExpressionConverter.ConvertToken(searchTasksWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    searchTasksWrapper["transmitObject"] = transmitObjectObject;
                    searchTasksWrapperpropCount++;
                }

                if (searchTasksWrapperincludeRelations != null)
                {
                    searchTasksWrapper["includeRelations"] = SourceExpressionConverter.ConvertToken(searchTasksWrapperincludeRelations);
                    searchTasksWrapperpropCount++;
                }

                var relationsFilterObject = new JObject();
                var relationsFilterObjectpropCount = 0;
                if (searchTasksWrapperrelationsFilterrelationType != null)
                {
                    relationsFilterObject["RelationType"] = SourceExpressionConverter.ConvertToken(searchTasksWrapperrelationsFilterrelationType);
                    relationsFilterObjectpropCount++;
                }

                if (searchTasksWrapperrelationsFilterforeignFolderName != null)
                {
                    relationsFilterObject["ForeignFolderName"] = SourceExpressionConverter.ConvertToken(searchTasksWrapperrelationsFilterforeignFolderName);
                    relationsFilterObjectpropCount++;
                }

                if (relationsFilterObjectpropCount > 0)
                {
                    searchTasksWrapper["relationsFilter"] = relationsFilterObject;
                    searchTasksWrapperpropCount++;
                }

                if (searchTasksWrapperbinaryLogicalOperator != null)
                {
                    searchTasksWrapper["binaryLogicalOperator"] = SourceExpressionConverter.ConvertToken(searchTasksWrapperbinaryLogicalOperator);
                    searchTasksWrapperpropCount++;
                }

                if (searchTasksWrapperpropCount > 0)
                {
                    callPayload.Body = searchTasksWrapper;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1SystemGuid> UnlinkItems([WorkflowExpression] Func<string> unlinkItemsWrapperitemGuid = null, [WorkflowExpression] Func<unlinkItemsWrapperfolderNameInput> unlinkItemsWrapperfolderName = null, [WorkflowExpression] Func<string[]> unlinkItemsWrapperrelatedItemGuids = null, [WorkflowExpression] Func<unlinkItemsWrapperrelatedFolderNameInput> unlinkItemsWrapperrelatedFolderName = null, [WorkflowExpression] Func<bool> unlinkItemsWrapperskipUnlinkAvailabilityCheck = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UnlinkItems";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var unlinkItemsWrapper = new JObject();
                var unlinkItemsWrapperpropCount = 0;
                if (unlinkItemsWrapperitemGuid != null)
                {
                    unlinkItemsWrapper["itemGuid"] = SourceExpressionConverter.ConvertToken(unlinkItemsWrapperitemGuid);
                    unlinkItemsWrapperpropCount++;
                }

                if (unlinkItemsWrapperfolderName != null)
                {
                    unlinkItemsWrapper["folderName"] = SourceExpressionConverter.Convert(unlinkItemsWrapperfolderName);
                    unlinkItemsWrapperpropCount++;
                }

                if (unlinkItemsWrapperrelatedItemGuids != null)
                {
                    unlinkItemsWrapper["relatedItemGuids"] = SourceExpressionConverter.ConvertToken(unlinkItemsWrapperrelatedItemGuids);
                    unlinkItemsWrapperpropCount++;
                }

                if (unlinkItemsWrapperrelatedFolderName != null)
                {
                    unlinkItemsWrapper["relatedFolderName"] = SourceExpressionConverter.Convert(unlinkItemsWrapperrelatedFolderName);
                    unlinkItemsWrapperpropCount++;
                }

                if (unlinkItemsWrapperskipUnlinkAvailabilityCheck != null)
                {
                    unlinkItemsWrapper["skipUnlinkAvailabilityCheck"] = SourceExpressionConverter.ConvertToken(unlinkItemsWrapperskipUnlinkAvailabilityCheck);
                    unlinkItemsWrapperpropCount++;
                }

                if (unlinkItemsWrapperpropCount > 0)
                {
                    callPayload.Body = unlinkItemsWrapper;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1SystemGuid>(BuildSourceInput);
        }
    }

    public class EwaycrmTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal> NewOrUpdatedJournal(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/NewOrUpdatedJournal";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany> NewOrUpdatedCompanies(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/NewOrUpdatedCompanies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact> NewOrUpdatedContacts(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/NewOrUpdatedContacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead> NewOrUpdatedLeads(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/NewOrUpdatedLeads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject> NewOrUpdatedProjects(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/NewOrUpdatedProjects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask> NewOrUpdatedTasks(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/NewOrUpdatedTasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask>(BuildSourceInput, triggerName, recurrence);
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