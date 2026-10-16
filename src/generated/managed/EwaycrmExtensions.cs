//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ewaycrm
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class EwaycrmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteCompany(Expression<Func<string>> deleteCompanyWrapperitemGuid = null)
        {
            var __workflow_deleteCompanyWrapperitemGuid = WorkflowExpression.Compile(deleteCompanyWrapperitemGuid, nameof(deleteCompanyWrapperitemGuid), required: false);
            return new DeferredBodyAction<EWayWcfServiceResponsesResponseBase>(() =>
            {
                var apiCallPath = "/DeleteCompany";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteCompanyWrapper = new JObject();
                var deleteCompanyWrapperpropCount = 0;
                if (__workflow_deleteCompanyWrapperitemGuid != null)
                {
                    deleteCompanyWrapper["itemGuid"] = ExpressionConverter.ConvertO(__workflow_deleteCompanyWrapperitemGuid);
                    deleteCompanyWrapperpropCount++;
                }

                if (deleteCompanyWrapperpropCount > 0)
                {
                    callPayload.Body = deleteCompanyWrapper;
                }

                return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteContact(Expression<Func<string>> deleteContactWrapperitemGuid = null)
        {
            var __workflow_deleteContactWrapperitemGuid = WorkflowExpression.Compile(deleteContactWrapperitemGuid, nameof(deleteContactWrapperitemGuid), required: false);
            return new DeferredBodyAction<EWayWcfServiceResponsesResponseBase>(() =>
            {
                var apiCallPath = "/DeleteContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteContactWrapper = new JObject();
                var deleteContactWrapperpropCount = 0;
                if (__workflow_deleteContactWrapperitemGuid != null)
                {
                    deleteContactWrapper["itemGuid"] = ExpressionConverter.ConvertO(__workflow_deleteContactWrapperitemGuid);
                    deleteContactWrapperpropCount++;
                }

                if (deleteContactWrapperpropCount > 0)
                {
                    callPayload.Body = deleteContactWrapper;
                }

                return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteJournal(Expression<Func<string>> deleteJournalWrapperitemGuid = null)
        {
            var __workflow_deleteJournalWrapperitemGuid = WorkflowExpression.Compile(deleteJournalWrapperitemGuid, nameof(deleteJournalWrapperitemGuid), required: false);
            return new DeferredBodyAction<EWayWcfServiceResponsesResponseBase>(() =>
            {
                var apiCallPath = "/DeleteJournal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteJournalWrapper = new JObject();
                var deleteJournalWrapperpropCount = 0;
                if (__workflow_deleteJournalWrapperitemGuid != null)
                {
                    deleteJournalWrapper["itemGuid"] = ExpressionConverter.ConvertO(__workflow_deleteJournalWrapperitemGuid);
                    deleteJournalWrapperpropCount++;
                }

                if (deleteJournalWrapperpropCount > 0)
                {
                    callPayload.Body = deleteJournalWrapper;
                }

                return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteLead(Expression<Func<string>> deleteLeadWrapperitemGuid = null)
        {
            var __workflow_deleteLeadWrapperitemGuid = WorkflowExpression.Compile(deleteLeadWrapperitemGuid, nameof(deleteLeadWrapperitemGuid), required: false);
            return new DeferredBodyAction<EWayWcfServiceResponsesResponseBase>(() =>
            {
                var apiCallPath = "/DeleteLead";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteLeadWrapper = new JObject();
                var deleteLeadWrapperpropCount = 0;
                if (__workflow_deleteLeadWrapperitemGuid != null)
                {
                    deleteLeadWrapper["itemGuid"] = ExpressionConverter.ConvertO(__workflow_deleteLeadWrapperitemGuid);
                    deleteLeadWrapperpropCount++;
                }

                if (deleteLeadWrapperpropCount > 0)
                {
                    callPayload.Body = deleteLeadWrapper;
                }

                return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteProject(Expression<Func<string>> deleteProjectWrapperitemGuid = null)
        {
            var __workflow_deleteProjectWrapperitemGuid = WorkflowExpression.Compile(deleteProjectWrapperitemGuid, nameof(deleteProjectWrapperitemGuid), required: false);
            return new DeferredBodyAction<EWayWcfServiceResponsesResponseBase>(() =>
            {
                var apiCallPath = "/DeleteProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteProjectWrapper = new JObject();
                var deleteProjectWrapperpropCount = 0;
                if (__workflow_deleteProjectWrapperitemGuid != null)
                {
                    deleteProjectWrapper["itemGuid"] = ExpressionConverter.ConvertO(__workflow_deleteProjectWrapperitemGuid);
                    deleteProjectWrapperpropCount++;
                }

                if (deleteProjectWrapperpropCount > 0)
                {
                    callPayload.Body = deleteProjectWrapper;
                }

                return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesResponseBase> DeleteTask(Expression<Func<string>> deleteTaskWrapperitemGuid = null)
        {
            var __workflow_deleteTaskWrapperitemGuid = WorkflowExpression.Compile(deleteTaskWrapperitemGuid, nameof(deleteTaskWrapperitemGuid), required: false);
            return new DeferredBodyAction<EWayWcfServiceResponsesResponseBase>(() =>
            {
                var apiCallPath = "/DeleteTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteTaskWrapper = new JObject();
                var deleteTaskWrapperpropCount = 0;
                if (__workflow_deleteTaskWrapperitemGuid != null)
                {
                    deleteTaskWrapper["itemGuid"] = ExpressionConverter.ConvertO(__workflow_deleteTaskWrapperitemGuid);
                    deleteTaskWrapperpropCount++;
                }

                if (deleteTaskWrapperpropCount > 0)
                {
                    callPayload.Body = deleteTaskWrapper;
                }

                return new ApiConnectionAction<EWayWcfServiceResponsesResponseBase>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveCompany(Expression<Func<string>> saveCompanyWrappertransmitObjectaccountNumber = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress1POBox = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress1Street = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress1City = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress1State = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress1CountryEn = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress1PostalCode = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress2POBox = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress2Street = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress2City = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress2State = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress2CountryEn = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress2PostalCode = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress3POBox = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress3Street = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress3City = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress3State = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress3CountryEn = null, Expression<Func<string>> saveCompanyWrappertransmitObjectaddress3PostalCode = null, Expression<Func<string>> saveCompanyWrappertransmitObjectcompanyName = null, Expression<Func<string>> saveCompanyWrappertransmitObjectdepartment = null, Expression<Func<string>> saveCompanyWrappertransmitObjectemail = null, Expression<Func<int>> saveCompanyWrappertransmitObjectemployeesCount = null, Expression<Func<string>> saveCompanyWrappertransmitObjectfax = null, Expression<Func<string>> saveCompanyWrappertransmitObjectfirstContactEn = null, Expression<Func<string>> saveCompanyWrappertransmitObjectiCQ = null, Expression<Func<string>> saveCompanyWrappertransmitObjectidentificationNumber = null, Expression<Func<string>> saveCompanyWrappertransmitObjectimportanceEn = null, Expression<Func<string>> saveCompanyWrappertransmitObjectlineOfBusiness = null, Expression<Func<bool>> saveCompanyWrappertransmitObjectmailingListOther = null, Expression<Func<string>> saveCompanyWrappertransmitObjectmobile = null, Expression<Func<string>> saveCompanyWrappertransmitObjectmobileNormalized = null, Expression<Func<string>> saveCompanyWrappertransmitObjectmSN = null, Expression<Func<string>> saveCompanyWrappertransmitObjectnote = null, Expression<Func<string>> saveCompanyWrappertransmitObjectphone = null, Expression<Func<string>> saveCompanyWrappertransmitObjectphoneNormalized = null, Expression<Func<bool>> saveCompanyWrappertransmitObjectpurchaser = null, Expression<Func<double>> saveCompanyWrappertransmitObjectreversal = null, Expression<Func<string>> saveCompanyWrappertransmitObjectskype = null, Expression<Func<bool>> saveCompanyWrappertransmitObjectsuppliers = null, Expression<Func<string>> saveCompanyWrappertransmitObjectvATNumber = null, Expression<Func<string>> saveCompanyWrappertransmitObjectwebPage = null, Expression<Func<double>> saveCompanyWrappertransmitObjectadditionalDiscount = null, Expression<Func<int>> saveCompanyWrappertransmitObjectiD = null, Expression<Func<bool>> saveCompanyWrappertransmitObjectcompetitor = null, Expression<Func<string>> saveCompanyWrappertransmitObjectsalePriceGuid = null, Expression<Func<bool>> saveCompanyWrappertransmitObjectnotificationByEmail = null, Expression<Func<string>> saveCompanyWrappertransmitObjectnotificationBy = null, Expression<Func<string>> saveCompanyWrappertransmitObjectlastActivity = null, Expression<Func<string>> saveCompanyWrappertransmitObjectnextStep = null, Expression<Func<bool>> saveCompanyWrappertransmitObjectemailOptOut = null, Expression<Func<string>> saveCompanyWrappertransmitObjecttypeEn = null, Expression<Func<string>> saveCompanyWrappertransmitObjectstateEn = null, Expression<Func<string>> saveCompanyWrappertransmitObjectprevStateEn = null, Expression<Func<string>> saveCompanyWrappertransmitObjectpicture = null, Expression<Func<int>> saveCompanyWrappertransmitObjectpictureWidth = null, Expression<Func<int>> saveCompanyWrappertransmitObjectpictureHeight = null, Expression<Func<bool>> saveCompanyWrappertransmitObjectisPrivate = null, Expression<Func<string>> saveCompanyWrappertransmitObjectitemCreated = null, Expression<Func<string>> saveCompanyWrappertransmitObjectitemChanged = null, Expression<Func<string>> saveCompanyWrappertransmitObjectfileAs = null, Expression<Func<string>> saveCompanyWrappertransmitObjectownerGUID = null, Expression<Func<string>> saveCompanyWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> saveCompanyWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> saveCompanyWrappertransmitObjectadditionalFields = null, Expression<Func<string>> saveCompanyWrappertransmitObjectitemGUID = null, Expression<Func<int>> saveCompanyWrappertransmitObjectitemVersion = null, Expression<Func<bool>> saveCompanyWrapperdieOnItemConflict = null, Expression<Func<string[]>> saveCompanyWrapperignoredUserErrorMessages = null)
        {
            var __workflow_saveCompanyWrappertransmitObjectaccountNumber = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaccountNumber, nameof(saveCompanyWrappertransmitObjectaccountNumber), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress1POBox = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress1POBox, nameof(saveCompanyWrappertransmitObjectaddress1POBox), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress1Street = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress1Street, nameof(saveCompanyWrappertransmitObjectaddress1Street), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress1City = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress1City, nameof(saveCompanyWrappertransmitObjectaddress1City), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress1State = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress1State, nameof(saveCompanyWrappertransmitObjectaddress1State), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress1CountryEn = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress1CountryEn, nameof(saveCompanyWrappertransmitObjectaddress1CountryEn), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress1PostalCode = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress1PostalCode, nameof(saveCompanyWrappertransmitObjectaddress1PostalCode), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress2POBox = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress2POBox, nameof(saveCompanyWrappertransmitObjectaddress2POBox), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress2Street = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress2Street, nameof(saveCompanyWrappertransmitObjectaddress2Street), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress2City = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress2City, nameof(saveCompanyWrappertransmitObjectaddress2City), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress2State = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress2State, nameof(saveCompanyWrappertransmitObjectaddress2State), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress2CountryEn = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress2CountryEn, nameof(saveCompanyWrappertransmitObjectaddress2CountryEn), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress2PostalCode = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress2PostalCode, nameof(saveCompanyWrappertransmitObjectaddress2PostalCode), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress3POBox = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress3POBox, nameof(saveCompanyWrappertransmitObjectaddress3POBox), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress3Street = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress3Street, nameof(saveCompanyWrappertransmitObjectaddress3Street), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress3City = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress3City, nameof(saveCompanyWrappertransmitObjectaddress3City), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress3State = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress3State, nameof(saveCompanyWrappertransmitObjectaddress3State), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress3CountryEn = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress3CountryEn, nameof(saveCompanyWrappertransmitObjectaddress3CountryEn), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress3PostalCode = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress3PostalCode, nameof(saveCompanyWrappertransmitObjectaddress3PostalCode), required: false);
            var __workflow_saveCompanyWrappertransmitObjectcompanyName = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectcompanyName, nameof(saveCompanyWrappertransmitObjectcompanyName), required: false);
            var __workflow_saveCompanyWrappertransmitObjectdepartment = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectdepartment, nameof(saveCompanyWrappertransmitObjectdepartment), required: false);
            var __workflow_saveCompanyWrappertransmitObjectemail = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectemail, nameof(saveCompanyWrappertransmitObjectemail), required: false);
            var __workflow_saveCompanyWrappertransmitObjectemployeesCount = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectemployeesCount, nameof(saveCompanyWrappertransmitObjectemployeesCount), required: false);
            var __workflow_saveCompanyWrappertransmitObjectfax = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectfax, nameof(saveCompanyWrappertransmitObjectfax), required: false);
            var __workflow_saveCompanyWrappertransmitObjectfirstContactEn = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectfirstContactEn, nameof(saveCompanyWrappertransmitObjectfirstContactEn), required: false);
            var __workflow_saveCompanyWrappertransmitObjectiCQ = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectiCQ, nameof(saveCompanyWrappertransmitObjectiCQ), required: false);
            var __workflow_saveCompanyWrappertransmitObjectidentificationNumber = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectidentificationNumber, nameof(saveCompanyWrappertransmitObjectidentificationNumber), required: false);
            var __workflow_saveCompanyWrappertransmitObjectimportanceEn = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectimportanceEn, nameof(saveCompanyWrappertransmitObjectimportanceEn), required: false);
            var __workflow_saveCompanyWrappertransmitObjectlineOfBusiness = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectlineOfBusiness, nameof(saveCompanyWrappertransmitObjectlineOfBusiness), required: false);
            var __workflow_saveCompanyWrappertransmitObjectmailingListOther = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectmailingListOther, nameof(saveCompanyWrappertransmitObjectmailingListOther), required: false);
            var __workflow_saveCompanyWrappertransmitObjectmobile = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectmobile, nameof(saveCompanyWrappertransmitObjectmobile), required: false);
            var __workflow_saveCompanyWrappertransmitObjectmobileNormalized = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectmobileNormalized, nameof(saveCompanyWrappertransmitObjectmobileNormalized), required: false);
            var __workflow_saveCompanyWrappertransmitObjectmSN = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectmSN, nameof(saveCompanyWrappertransmitObjectmSN), required: false);
            var __workflow_saveCompanyWrappertransmitObjectnote = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectnote, nameof(saveCompanyWrappertransmitObjectnote), required: false);
            var __workflow_saveCompanyWrappertransmitObjectphone = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectphone, nameof(saveCompanyWrappertransmitObjectphone), required: false);
            var __workflow_saveCompanyWrappertransmitObjectphoneNormalized = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectphoneNormalized, nameof(saveCompanyWrappertransmitObjectphoneNormalized), required: false);
            var __workflow_saveCompanyWrappertransmitObjectpurchaser = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectpurchaser, nameof(saveCompanyWrappertransmitObjectpurchaser), required: false);
            var __workflow_saveCompanyWrappertransmitObjectreversal = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectreversal, nameof(saveCompanyWrappertransmitObjectreversal), required: false);
            var __workflow_saveCompanyWrappertransmitObjectskype = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectskype, nameof(saveCompanyWrappertransmitObjectskype), required: false);
            var __workflow_saveCompanyWrappertransmitObjectsuppliers = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectsuppliers, nameof(saveCompanyWrappertransmitObjectsuppliers), required: false);
            var __workflow_saveCompanyWrappertransmitObjectvATNumber = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectvATNumber, nameof(saveCompanyWrappertransmitObjectvATNumber), required: false);
            var __workflow_saveCompanyWrappertransmitObjectwebPage = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectwebPage, nameof(saveCompanyWrappertransmitObjectwebPage), required: false);
            var __workflow_saveCompanyWrappertransmitObjectadditionalDiscount = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectadditionalDiscount, nameof(saveCompanyWrappertransmitObjectadditionalDiscount), required: false);
            var __workflow_saveCompanyWrappertransmitObjectiD = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectiD, nameof(saveCompanyWrappertransmitObjectiD), required: false);
            var __workflow_saveCompanyWrappertransmitObjectcompetitor = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectcompetitor, nameof(saveCompanyWrappertransmitObjectcompetitor), required: false);
            var __workflow_saveCompanyWrappertransmitObjectsalePriceGuid = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectsalePriceGuid, nameof(saveCompanyWrappertransmitObjectsalePriceGuid), required: false);
            var __workflow_saveCompanyWrappertransmitObjectnotificationByEmail = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectnotificationByEmail, nameof(saveCompanyWrappertransmitObjectnotificationByEmail), required: false);
            var __workflow_saveCompanyWrappertransmitObjectnotificationBy = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectnotificationBy, nameof(saveCompanyWrappertransmitObjectnotificationBy), required: false);
            var __workflow_saveCompanyWrappertransmitObjectlastActivity = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectlastActivity, nameof(saveCompanyWrappertransmitObjectlastActivity), required: false);
            var __workflow_saveCompanyWrappertransmitObjectnextStep = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectnextStep, nameof(saveCompanyWrappertransmitObjectnextStep), required: false);
            var __workflow_saveCompanyWrappertransmitObjectemailOptOut = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectemailOptOut, nameof(saveCompanyWrappertransmitObjectemailOptOut), required: false);
            var __workflow_saveCompanyWrappertransmitObjecttypeEn = WorkflowExpression.Compile(saveCompanyWrappertransmitObjecttypeEn, nameof(saveCompanyWrappertransmitObjecttypeEn), required: false);
            var __workflow_saveCompanyWrappertransmitObjectstateEn = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectstateEn, nameof(saveCompanyWrappertransmitObjectstateEn), required: false);
            var __workflow_saveCompanyWrappertransmitObjectprevStateEn = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectprevStateEn, nameof(saveCompanyWrappertransmitObjectprevStateEn), required: false);
            var __workflow_saveCompanyWrappertransmitObjectpicture = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectpicture, nameof(saveCompanyWrappertransmitObjectpicture), required: false);
            var __workflow_saveCompanyWrappertransmitObjectpictureWidth = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectpictureWidth, nameof(saveCompanyWrappertransmitObjectpictureWidth), required: false);
            var __workflow_saveCompanyWrappertransmitObjectpictureHeight = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectpictureHeight, nameof(saveCompanyWrappertransmitObjectpictureHeight), required: false);
            var __workflow_saveCompanyWrappertransmitObjectisPrivate = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectisPrivate, nameof(saveCompanyWrappertransmitObjectisPrivate), required: false);
            var __workflow_saveCompanyWrappertransmitObjectitemCreated = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectitemCreated, nameof(saveCompanyWrappertransmitObjectitemCreated), required: false);
            var __workflow_saveCompanyWrappertransmitObjectitemChanged = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectitemChanged, nameof(saveCompanyWrappertransmitObjectitemChanged), required: false);
            var __workflow_saveCompanyWrappertransmitObjectfileAs = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectfileAs, nameof(saveCompanyWrappertransmitObjectfileAs), required: false);
            var __workflow_saveCompanyWrappertransmitObjectownerGUID = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectownerGUID, nameof(saveCompanyWrappertransmitObjectownerGUID), required: false);
            var __workflow_saveCompanyWrappertransmitObjectcreatedByGUID = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectcreatedByGUID, nameof(saveCompanyWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_saveCompanyWrappertransmitObjectmodifiedByGUID = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectmodifiedByGUID, nameof(saveCompanyWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_saveCompanyWrappertransmitObjectadditionalFields = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectadditionalFields, nameof(saveCompanyWrappertransmitObjectadditionalFields), required: false);
            var __workflow_saveCompanyWrappertransmitObjectitemGUID = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectitemGUID, nameof(saveCompanyWrappertransmitObjectitemGUID), required: false);
            var __workflow_saveCompanyWrappertransmitObjectitemVersion = WorkflowExpression.Compile(saveCompanyWrappertransmitObjectitemVersion, nameof(saveCompanyWrappertransmitObjectitemVersion), required: false);
            var __workflow_saveCompanyWrapperdieOnItemConflict = WorkflowExpression.Compile(saveCompanyWrapperdieOnItemConflict, nameof(saveCompanyWrapperdieOnItemConflict), required: false);
            var __workflow_saveCompanyWrapperignoredUserErrorMessages = WorkflowExpression.Compile(saveCompanyWrapperignoredUserErrorMessages, nameof(saveCompanyWrapperignoredUserErrorMessages), required: false);
            return new DeferredBodyAction<EWayWcfServiceResponsesSaveResponse>(() =>
            {
                var apiCallPath = "/SaveCompany";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var saveCompanyWrapper = new JObject();
                var saveCompanyWrapperpropCount = 0;
                var transmitObjectObject = new JObject();
                var transmitObjectObjectpropCount = 0;
                if (__workflow_saveCompanyWrappertransmitObjectaccountNumber != null)
                {
                    transmitObjectObject["AccountNumber"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectaccountNumber);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectaddress1POBox != null)
                {
                    transmitObjectObject["Address1POBox"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectaddress1POBox);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectaddress1Street != null)
                {
                    transmitObjectObject["Address1Street"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectaddress1Street);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectaddress1City != null)
                {
                    transmitObjectObject["Address1City"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectaddress1City);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectaddress1State != null)
                {
                    transmitObjectObject["Address1State"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectaddress1State);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectaddress1CountryEn != null)
                {
                    transmitObjectObject["Address1CountryEn"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectaddress1CountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectaddress1PostalCode != null)
                {
                    transmitObjectObject["Address1PostalCode"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectaddress1PostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectaddress2POBox != null)
                {
                    transmitObjectObject["Address2POBox"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectaddress2POBox);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectaddress2Street != null)
                {
                    transmitObjectObject["Address2Street"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectaddress2Street);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectaddress2City != null)
                {
                    transmitObjectObject["Address2City"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectaddress2City);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectaddress2State != null)
                {
                    transmitObjectObject["Address2State"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectaddress2State);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectaddress2CountryEn != null)
                {
                    transmitObjectObject["Address2CountryEn"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectaddress2CountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectaddress2PostalCode != null)
                {
                    transmitObjectObject["Address2PostalCode"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectaddress2PostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectaddress3POBox != null)
                {
                    transmitObjectObject["Address3POBox"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectaddress3POBox);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectaddress3Street != null)
                {
                    transmitObjectObject["Address3Street"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectaddress3Street);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectaddress3City != null)
                {
                    transmitObjectObject["Address3City"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectaddress3City);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectaddress3State != null)
                {
                    transmitObjectObject["Address3State"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectaddress3State);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectaddress3CountryEn != null)
                {
                    transmitObjectObject["Address3CountryEn"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectaddress3CountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectaddress3PostalCode != null)
                {
                    transmitObjectObject["Address3PostalCode"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectaddress3PostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectcompanyName != null)
                {
                    transmitObjectObject["CompanyName"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectcompanyName);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectdepartment != null)
                {
                    transmitObjectObject["Department"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectdepartment);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectemail != null)
                {
                    transmitObjectObject["Email"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectemail);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectemployeesCount != null)
                {
                    transmitObjectObject["EmployeesCount"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectemployeesCount);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectfax != null)
                {
                    transmitObjectObject["Fax"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectfax);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectfirstContactEn != null)
                {
                    transmitObjectObject["FirstContactEn"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectfirstContactEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectiCQ != null)
                {
                    transmitObjectObject["ICQ"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectiCQ);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectidentificationNumber != null)
                {
                    transmitObjectObject["IdentificationNumber"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectidentificationNumber);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectimportanceEn != null)
                {
                    transmitObjectObject["ImportanceEn"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectimportanceEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectlineOfBusiness != null)
                {
                    transmitObjectObject["LineOfBusiness"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectlineOfBusiness);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectmailingListOther != null)
                {
                    transmitObjectObject["MailingListOther"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectmailingListOther);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectmobile != null)
                {
                    transmitObjectObject["Mobile"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectmobile);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectmobileNormalized != null)
                {
                    transmitObjectObject["MobileNormalized"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectmobileNormalized);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectmSN != null)
                {
                    transmitObjectObject["MSN"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectmSN);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectnote != null)
                {
                    transmitObjectObject["Note"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectnote);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectphone != null)
                {
                    transmitObjectObject["Phone"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectphone);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectphoneNormalized != null)
                {
                    transmitObjectObject["PhoneNormalized"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectphoneNormalized);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectpurchaser != null)
                {
                    transmitObjectObject["Purchaser"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectpurchaser);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectreversal != null)
                {
                    transmitObjectObject["Reversal"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectreversal);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectskype != null)
                {
                    transmitObjectObject["Skype"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectskype);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectsuppliers != null)
                {
                    transmitObjectObject["Suppliers"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectsuppliers);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectvATNumber != null)
                {
                    transmitObjectObject["VATNumber"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectvATNumber);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectwebPage != null)
                {
                    transmitObjectObject["WebPage"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectwebPage);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectadditionalDiscount != null)
                {
                    transmitObjectObject["AdditionalDiscount"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectadditionalDiscount);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectiD != null)
                {
                    transmitObjectObject["ID"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectiD);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectcompetitor != null)
                {
                    transmitObjectObject["Competitor"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectcompetitor);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectsalePriceGuid != null)
                {
                    transmitObjectObject["SalePriceGuid"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectsalePriceGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectnotificationByEmail != null)
                {
                    transmitObjectObject["NotificationByEmail"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectnotificationByEmail);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectnotificationBy != null)
                {
                    transmitObjectObject["NotificationBy"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectnotificationBy);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectlastActivity != null)
                {
                    transmitObjectObject["LastActivity"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectlastActivity);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectnextStep != null)
                {
                    transmitObjectObject["NextStep"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectnextStep);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectemailOptOut != null)
                {
                    transmitObjectObject["EmailOptOut"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectemailOptOut);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectpicture != null)
                {
                    transmitObjectObject["Picture"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectpicture);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectpictureWidth != null)
                {
                    transmitObjectObject["PictureWidth"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectpictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectpictureHeight != null)
                {
                    transmitObjectObject["PictureHeight"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectpictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveCompanyWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    saveCompanyWrapper["transmitObject"] = transmitObjectObject;
                    saveCompanyWrapperpropCount++;
                }

                if (__workflow_saveCompanyWrapperdieOnItemConflict != null)
                {
                    saveCompanyWrapper["dieOnItemConflict"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrapperdieOnItemConflict);
                    saveCompanyWrapperpropCount++;
                }

                if (__workflow_saveCompanyWrapperignoredUserErrorMessages != null)
                {
                    saveCompanyWrapper["ignoredUserErrorMessages"] = ExpressionConverter.ConvertO(__workflow_saveCompanyWrapperignoredUserErrorMessages);
                    saveCompanyWrapperpropCount++;
                }

                if (saveCompanyWrapperpropCount > 0)
                {
                    callPayload.Body = saveCompanyWrapper;
                }

                return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveContact(Expression<Func<string>> saveContactWrappertransmitObjectbusinessAddressStreet = null, Expression<Func<string>> saveContactWrappertransmitObjectbusinessAddressCity = null, Expression<Func<string>> saveContactWrappertransmitObjectbusinessAddressState = null, Expression<Func<string>> saveContactWrappertransmitObjectbusinessAddressCountryEn = null, Expression<Func<string>> saveContactWrappertransmitObjectbusinessAddressPOBox = null, Expression<Func<string>> saveContactWrappertransmitObjectbusinessAddressPostalCode = null, Expression<Func<string>> saveContactWrappertransmitObjecthomeAddressStreet = null, Expression<Func<string>> saveContactWrappertransmitObjecthomeAddressCity = null, Expression<Func<string>> saveContactWrappertransmitObjecthomeAddressState = null, Expression<Func<string>> saveContactWrappertransmitObjecthomeAddressCountryEn = null, Expression<Func<string>> saveContactWrappertransmitObjecthomeAddressPOBox = null, Expression<Func<string>> saveContactWrappertransmitObjecthomeAddressPostalCode = null, Expression<Func<string>> saveContactWrappertransmitObjectotherAddressStreet = null, Expression<Func<string>> saveContactWrappertransmitObjectotherAddressCity = null, Expression<Func<string>> saveContactWrappertransmitObjectotherAddressState = null, Expression<Func<string>> saveContactWrappertransmitObjectotherAddressCountryEn = null, Expression<Func<string>> saveContactWrappertransmitObjectotherAddressPOBox = null, Expression<Func<string>> saveContactWrappertransmitObjectotherAddressPostalCode = null, Expression<Func<string>> saveContactWrappertransmitObjectcompany = null, Expression<Func<string>> saveContactWrappertransmitObjectemail1Address = null, Expression<Func<string>> saveContactWrappertransmitObjectemail2Address = null, Expression<Func<string>> saveContactWrappertransmitObjectemail3Address = null, Expression<Func<string>> saveContactWrappertransmitObjectfirstName = null, Expression<Func<string>> saveContactWrappertransmitObjectiCQ = null, Expression<Func<string>> saveContactWrappertransmitObjectimportanceEn = null, Expression<Func<string>> saveContactWrappertransmitObjectlastName = null, Expression<Func<string>> saveContactWrappertransmitObjectmiddleName = null, Expression<Func<string>> saveContactWrappertransmitObjectmSN = null, Expression<Func<string>> saveContactWrappertransmitObjectnote = null, Expression<Func<string>> saveContactWrappertransmitObjectprefixEn = null, Expression<Func<string>> saveContactWrappertransmitObjectsuffixEn = null, Expression<Func<string>> saveContactWrappertransmitObjectskype = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber1 = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber2 = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber3 = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber4 = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber5 = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber6 = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber1Normalized = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber2Normalized = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber3Normalized = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber4Normalized = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber5Normalized = null, Expression<Func<string>> saveContactWrappertransmitObjecttelephoneNumber6Normalized = null, Expression<Func<string>> saveContactWrappertransmitObjectdepartment = null, Expression<Func<string>> saveContactWrappertransmitObjecttitle = null, Expression<Func<string>> saveContactWrappertransmitObjectwebPage = null, Expression<Func<bool>> saveContactWrappertransmitObjectdoNotSendNewsletter = null, Expression<Func<string>> saveContactWrappertransmitObjectprofilePicture = null, Expression<Func<int>> saveContactWrappertransmitObjectprofilePictureWidth = null, Expression<Func<int>> saveContactWrappertransmitObjectprofilePictureHeight = null, Expression<Func<string>> saveContactWrappertransmitObjectlastActivity = null, Expression<Func<string>> saveContactWrappertransmitObjectnextStep = null, Expression<Func<string>> saveContactWrappertransmitObjecttypeEn = null, Expression<Func<string>> saveContactWrappertransmitObjectstateEn = null, Expression<Func<string>> saveContactWrappertransmitObjectprevStateEn = null, Expression<Func<string>> saveContactWrappertransmitObjectcompaniesCompanyGuid = null, Expression<Func<bool>> saveContactWrappertransmitObjectisPrivate = null, Expression<Func<string>> saveContactWrappertransmitObjectitemCreated = null, Expression<Func<string>> saveContactWrappertransmitObjectitemChanged = null, Expression<Func<string>> saveContactWrappertransmitObjectfileAs = null, Expression<Func<string>> saveContactWrappertransmitObjectownerGUID = null, Expression<Func<string>> saveContactWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> saveContactWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> saveContactWrappertransmitObjectadditionalFields = null, Expression<Func<string>> saveContactWrappertransmitObjectitemGUID = null, Expression<Func<int>> saveContactWrappertransmitObjectitemVersion = null, Expression<Func<bool>> saveContactWrapperdieOnItemConflict = null, Expression<Func<string[]>> saveContactWrapperignoredUserErrorMessages = null)
        {
            var __workflow_saveContactWrappertransmitObjectbusinessAddressStreet = WorkflowExpression.Compile(saveContactWrappertransmitObjectbusinessAddressStreet, nameof(saveContactWrappertransmitObjectbusinessAddressStreet), required: false);
            var __workflow_saveContactWrappertransmitObjectbusinessAddressCity = WorkflowExpression.Compile(saveContactWrappertransmitObjectbusinessAddressCity, nameof(saveContactWrappertransmitObjectbusinessAddressCity), required: false);
            var __workflow_saveContactWrappertransmitObjectbusinessAddressState = WorkflowExpression.Compile(saveContactWrappertransmitObjectbusinessAddressState, nameof(saveContactWrappertransmitObjectbusinessAddressState), required: false);
            var __workflow_saveContactWrappertransmitObjectbusinessAddressCountryEn = WorkflowExpression.Compile(saveContactWrappertransmitObjectbusinessAddressCountryEn, nameof(saveContactWrappertransmitObjectbusinessAddressCountryEn), required: false);
            var __workflow_saveContactWrappertransmitObjectbusinessAddressPOBox = WorkflowExpression.Compile(saveContactWrappertransmitObjectbusinessAddressPOBox, nameof(saveContactWrappertransmitObjectbusinessAddressPOBox), required: false);
            var __workflow_saveContactWrappertransmitObjectbusinessAddressPostalCode = WorkflowExpression.Compile(saveContactWrappertransmitObjectbusinessAddressPostalCode, nameof(saveContactWrappertransmitObjectbusinessAddressPostalCode), required: false);
            var __workflow_saveContactWrappertransmitObjecthomeAddressStreet = WorkflowExpression.Compile(saveContactWrappertransmitObjecthomeAddressStreet, nameof(saveContactWrappertransmitObjecthomeAddressStreet), required: false);
            var __workflow_saveContactWrappertransmitObjecthomeAddressCity = WorkflowExpression.Compile(saveContactWrappertransmitObjecthomeAddressCity, nameof(saveContactWrappertransmitObjecthomeAddressCity), required: false);
            var __workflow_saveContactWrappertransmitObjecthomeAddressState = WorkflowExpression.Compile(saveContactWrappertransmitObjecthomeAddressState, nameof(saveContactWrappertransmitObjecthomeAddressState), required: false);
            var __workflow_saveContactWrappertransmitObjecthomeAddressCountryEn = WorkflowExpression.Compile(saveContactWrappertransmitObjecthomeAddressCountryEn, nameof(saveContactWrappertransmitObjecthomeAddressCountryEn), required: false);
            var __workflow_saveContactWrappertransmitObjecthomeAddressPOBox = WorkflowExpression.Compile(saveContactWrappertransmitObjecthomeAddressPOBox, nameof(saveContactWrappertransmitObjecthomeAddressPOBox), required: false);
            var __workflow_saveContactWrappertransmitObjecthomeAddressPostalCode = WorkflowExpression.Compile(saveContactWrappertransmitObjecthomeAddressPostalCode, nameof(saveContactWrappertransmitObjecthomeAddressPostalCode), required: false);
            var __workflow_saveContactWrappertransmitObjectotherAddressStreet = WorkflowExpression.Compile(saveContactWrappertransmitObjectotherAddressStreet, nameof(saveContactWrappertransmitObjectotherAddressStreet), required: false);
            var __workflow_saveContactWrappertransmitObjectotherAddressCity = WorkflowExpression.Compile(saveContactWrappertransmitObjectotherAddressCity, nameof(saveContactWrappertransmitObjectotherAddressCity), required: false);
            var __workflow_saveContactWrappertransmitObjectotherAddressState = WorkflowExpression.Compile(saveContactWrappertransmitObjectotherAddressState, nameof(saveContactWrappertransmitObjectotherAddressState), required: false);
            var __workflow_saveContactWrappertransmitObjectotherAddressCountryEn = WorkflowExpression.Compile(saveContactWrappertransmitObjectotherAddressCountryEn, nameof(saveContactWrappertransmitObjectotherAddressCountryEn), required: false);
            var __workflow_saveContactWrappertransmitObjectotherAddressPOBox = WorkflowExpression.Compile(saveContactWrappertransmitObjectotherAddressPOBox, nameof(saveContactWrappertransmitObjectotherAddressPOBox), required: false);
            var __workflow_saveContactWrappertransmitObjectotherAddressPostalCode = WorkflowExpression.Compile(saveContactWrappertransmitObjectotherAddressPostalCode, nameof(saveContactWrappertransmitObjectotherAddressPostalCode), required: false);
            var __workflow_saveContactWrappertransmitObjectcompany = WorkflowExpression.Compile(saveContactWrappertransmitObjectcompany, nameof(saveContactWrappertransmitObjectcompany), required: false);
            var __workflow_saveContactWrappertransmitObjectemail1Address = WorkflowExpression.Compile(saveContactWrappertransmitObjectemail1Address, nameof(saveContactWrappertransmitObjectemail1Address), required: false);
            var __workflow_saveContactWrappertransmitObjectemail2Address = WorkflowExpression.Compile(saveContactWrappertransmitObjectemail2Address, nameof(saveContactWrappertransmitObjectemail2Address), required: false);
            var __workflow_saveContactWrappertransmitObjectemail3Address = WorkflowExpression.Compile(saveContactWrappertransmitObjectemail3Address, nameof(saveContactWrappertransmitObjectemail3Address), required: false);
            var __workflow_saveContactWrappertransmitObjectfirstName = WorkflowExpression.Compile(saveContactWrappertransmitObjectfirstName, nameof(saveContactWrappertransmitObjectfirstName), required: false);
            var __workflow_saveContactWrappertransmitObjectiCQ = WorkflowExpression.Compile(saveContactWrappertransmitObjectiCQ, nameof(saveContactWrappertransmitObjectiCQ), required: false);
            var __workflow_saveContactWrappertransmitObjectimportanceEn = WorkflowExpression.Compile(saveContactWrappertransmitObjectimportanceEn, nameof(saveContactWrappertransmitObjectimportanceEn), required: false);
            var __workflow_saveContactWrappertransmitObjectlastName = WorkflowExpression.Compile(saveContactWrappertransmitObjectlastName, nameof(saveContactWrappertransmitObjectlastName), required: false);
            var __workflow_saveContactWrappertransmitObjectmiddleName = WorkflowExpression.Compile(saveContactWrappertransmitObjectmiddleName, nameof(saveContactWrappertransmitObjectmiddleName), required: false);
            var __workflow_saveContactWrappertransmitObjectmSN = WorkflowExpression.Compile(saveContactWrappertransmitObjectmSN, nameof(saveContactWrappertransmitObjectmSN), required: false);
            var __workflow_saveContactWrappertransmitObjectnote = WorkflowExpression.Compile(saveContactWrappertransmitObjectnote, nameof(saveContactWrappertransmitObjectnote), required: false);
            var __workflow_saveContactWrappertransmitObjectprefixEn = WorkflowExpression.Compile(saveContactWrappertransmitObjectprefixEn, nameof(saveContactWrappertransmitObjectprefixEn), required: false);
            var __workflow_saveContactWrappertransmitObjectsuffixEn = WorkflowExpression.Compile(saveContactWrappertransmitObjectsuffixEn, nameof(saveContactWrappertransmitObjectsuffixEn), required: false);
            var __workflow_saveContactWrappertransmitObjectskype = WorkflowExpression.Compile(saveContactWrappertransmitObjectskype, nameof(saveContactWrappertransmitObjectskype), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber1 = WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber1, nameof(saveContactWrappertransmitObjecttelephoneNumber1), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber2 = WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber2, nameof(saveContactWrappertransmitObjecttelephoneNumber2), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber3 = WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber3, nameof(saveContactWrappertransmitObjecttelephoneNumber3), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber4 = WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber4, nameof(saveContactWrappertransmitObjecttelephoneNumber4), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber5 = WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber5, nameof(saveContactWrappertransmitObjecttelephoneNumber5), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber6 = WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber6, nameof(saveContactWrappertransmitObjecttelephoneNumber6), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber1Normalized = WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber1Normalized, nameof(saveContactWrappertransmitObjecttelephoneNumber1Normalized), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber2Normalized = WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber2Normalized, nameof(saveContactWrappertransmitObjecttelephoneNumber2Normalized), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber3Normalized = WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber3Normalized, nameof(saveContactWrappertransmitObjecttelephoneNumber3Normalized), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber4Normalized = WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber4Normalized, nameof(saveContactWrappertransmitObjecttelephoneNumber4Normalized), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber5Normalized = WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber5Normalized, nameof(saveContactWrappertransmitObjecttelephoneNumber5Normalized), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber6Normalized = WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber6Normalized, nameof(saveContactWrappertransmitObjecttelephoneNumber6Normalized), required: false);
            var __workflow_saveContactWrappertransmitObjectdepartment = WorkflowExpression.Compile(saveContactWrappertransmitObjectdepartment, nameof(saveContactWrappertransmitObjectdepartment), required: false);
            var __workflow_saveContactWrappertransmitObjecttitle = WorkflowExpression.Compile(saveContactWrappertransmitObjecttitle, nameof(saveContactWrappertransmitObjecttitle), required: false);
            var __workflow_saveContactWrappertransmitObjectwebPage = WorkflowExpression.Compile(saveContactWrappertransmitObjectwebPage, nameof(saveContactWrappertransmitObjectwebPage), required: false);
            var __workflow_saveContactWrappertransmitObjectdoNotSendNewsletter = WorkflowExpression.Compile(saveContactWrappertransmitObjectdoNotSendNewsletter, nameof(saveContactWrappertransmitObjectdoNotSendNewsletter), required: false);
            var __workflow_saveContactWrappertransmitObjectprofilePicture = WorkflowExpression.Compile(saveContactWrappertransmitObjectprofilePicture, nameof(saveContactWrappertransmitObjectprofilePicture), required: false);
            var __workflow_saveContactWrappertransmitObjectprofilePictureWidth = WorkflowExpression.Compile(saveContactWrappertransmitObjectprofilePictureWidth, nameof(saveContactWrappertransmitObjectprofilePictureWidth), required: false);
            var __workflow_saveContactWrappertransmitObjectprofilePictureHeight = WorkflowExpression.Compile(saveContactWrappertransmitObjectprofilePictureHeight, nameof(saveContactWrappertransmitObjectprofilePictureHeight), required: false);
            var __workflow_saveContactWrappertransmitObjectlastActivity = WorkflowExpression.Compile(saveContactWrappertransmitObjectlastActivity, nameof(saveContactWrappertransmitObjectlastActivity), required: false);
            var __workflow_saveContactWrappertransmitObjectnextStep = WorkflowExpression.Compile(saveContactWrappertransmitObjectnextStep, nameof(saveContactWrappertransmitObjectnextStep), required: false);
            var __workflow_saveContactWrappertransmitObjecttypeEn = WorkflowExpression.Compile(saveContactWrappertransmitObjecttypeEn, nameof(saveContactWrappertransmitObjecttypeEn), required: false);
            var __workflow_saveContactWrappertransmitObjectstateEn = WorkflowExpression.Compile(saveContactWrappertransmitObjectstateEn, nameof(saveContactWrappertransmitObjectstateEn), required: false);
            var __workflow_saveContactWrappertransmitObjectprevStateEn = WorkflowExpression.Compile(saveContactWrappertransmitObjectprevStateEn, nameof(saveContactWrappertransmitObjectprevStateEn), required: false);
            var __workflow_saveContactWrappertransmitObjectcompaniesCompanyGuid = WorkflowExpression.Compile(saveContactWrappertransmitObjectcompaniesCompanyGuid, nameof(saveContactWrappertransmitObjectcompaniesCompanyGuid), required: false);
            var __workflow_saveContactWrappertransmitObjectisPrivate = WorkflowExpression.Compile(saveContactWrappertransmitObjectisPrivate, nameof(saveContactWrappertransmitObjectisPrivate), required: false);
            var __workflow_saveContactWrappertransmitObjectitemCreated = WorkflowExpression.Compile(saveContactWrappertransmitObjectitemCreated, nameof(saveContactWrappertransmitObjectitemCreated), required: false);
            var __workflow_saveContactWrappertransmitObjectitemChanged = WorkflowExpression.Compile(saveContactWrappertransmitObjectitemChanged, nameof(saveContactWrappertransmitObjectitemChanged), required: false);
            var __workflow_saveContactWrappertransmitObjectfileAs = WorkflowExpression.Compile(saveContactWrappertransmitObjectfileAs, nameof(saveContactWrappertransmitObjectfileAs), required: false);
            var __workflow_saveContactWrappertransmitObjectownerGUID = WorkflowExpression.Compile(saveContactWrappertransmitObjectownerGUID, nameof(saveContactWrappertransmitObjectownerGUID), required: false);
            var __workflow_saveContactWrappertransmitObjectcreatedByGUID = WorkflowExpression.Compile(saveContactWrappertransmitObjectcreatedByGUID, nameof(saveContactWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_saveContactWrappertransmitObjectmodifiedByGUID = WorkflowExpression.Compile(saveContactWrappertransmitObjectmodifiedByGUID, nameof(saveContactWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_saveContactWrappertransmitObjectadditionalFields = WorkflowExpression.Compile(saveContactWrappertransmitObjectadditionalFields, nameof(saveContactWrappertransmitObjectadditionalFields), required: false);
            var __workflow_saveContactWrappertransmitObjectitemGUID = WorkflowExpression.Compile(saveContactWrappertransmitObjectitemGUID, nameof(saveContactWrappertransmitObjectitemGUID), required: false);
            var __workflow_saveContactWrappertransmitObjectitemVersion = WorkflowExpression.Compile(saveContactWrappertransmitObjectitemVersion, nameof(saveContactWrappertransmitObjectitemVersion), required: false);
            var __workflow_saveContactWrapperdieOnItemConflict = WorkflowExpression.Compile(saveContactWrapperdieOnItemConflict, nameof(saveContactWrapperdieOnItemConflict), required: false);
            var __workflow_saveContactWrapperignoredUserErrorMessages = WorkflowExpression.Compile(saveContactWrapperignoredUserErrorMessages, nameof(saveContactWrapperignoredUserErrorMessages), required: false);
            return new DeferredBodyAction<EWayWcfServiceResponsesSaveResponse>(() =>
            {
                var apiCallPath = "/SaveContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var saveContactWrapper = new JObject();
                var saveContactWrapperpropCount = 0;
                var transmitObjectObject = new JObject();
                var transmitObjectObjectpropCount = 0;
                if (__workflow_saveContactWrappertransmitObjectbusinessAddressStreet != null)
                {
                    transmitObjectObject["BusinessAddressStreet"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectbusinessAddressStreet);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectbusinessAddressCity != null)
                {
                    transmitObjectObject["BusinessAddressCity"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectbusinessAddressCity);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectbusinessAddressState != null)
                {
                    transmitObjectObject["BusinessAddressState"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectbusinessAddressState);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectbusinessAddressCountryEn != null)
                {
                    transmitObjectObject["BusinessAddressCountryEn"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectbusinessAddressCountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectbusinessAddressPOBox != null)
                {
                    transmitObjectObject["BusinessAddressPOBox"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectbusinessAddressPOBox);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectbusinessAddressPostalCode != null)
                {
                    transmitObjectObject["BusinessAddressPostalCode"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectbusinessAddressPostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjecthomeAddressStreet != null)
                {
                    transmitObjectObject["HomeAddressStreet"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjecthomeAddressStreet);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjecthomeAddressCity != null)
                {
                    transmitObjectObject["HomeAddressCity"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjecthomeAddressCity);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjecthomeAddressState != null)
                {
                    transmitObjectObject["HomeAddressState"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjecthomeAddressState);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjecthomeAddressCountryEn != null)
                {
                    transmitObjectObject["HomeAddressCountryEn"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjecthomeAddressCountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjecthomeAddressPOBox != null)
                {
                    transmitObjectObject["HomeAddressPOBox"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjecthomeAddressPOBox);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjecthomeAddressPostalCode != null)
                {
                    transmitObjectObject["HomeAddressPostalCode"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjecthomeAddressPostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectotherAddressStreet != null)
                {
                    transmitObjectObject["OtherAddressStreet"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectotherAddressStreet);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectotherAddressCity != null)
                {
                    transmitObjectObject["OtherAddressCity"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectotherAddressCity);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectotherAddressState != null)
                {
                    transmitObjectObject["OtherAddressState"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectotherAddressState);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectotherAddressCountryEn != null)
                {
                    transmitObjectObject["OtherAddressCountryEn"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectotherAddressCountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectotherAddressPOBox != null)
                {
                    transmitObjectObject["OtherAddressPOBox"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectotherAddressPOBox);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectotherAddressPostalCode != null)
                {
                    transmitObjectObject["OtherAddressPostalCode"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectotherAddressPostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectcompany != null)
                {
                    transmitObjectObject["Company"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectcompany);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectemail1Address != null)
                {
                    transmitObjectObject["Email1Address"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectemail1Address);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectemail2Address != null)
                {
                    transmitObjectObject["Email2Address"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectemail2Address);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectemail3Address != null)
                {
                    transmitObjectObject["Email3Address"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectemail3Address);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectfirstName != null)
                {
                    transmitObjectObject["FirstName"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectfirstName);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectiCQ != null)
                {
                    transmitObjectObject["ICQ"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectiCQ);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectimportanceEn != null)
                {
                    transmitObjectObject["ImportanceEn"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectimportanceEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectlastName != null)
                {
                    transmitObjectObject["LastName"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectlastName);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectmiddleName != null)
                {
                    transmitObjectObject["MiddleName"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectmiddleName);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectmSN != null)
                {
                    transmitObjectObject["MSN"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectmSN);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectnote != null)
                {
                    transmitObjectObject["Note"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectnote);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectprefixEn != null)
                {
                    transmitObjectObject["PrefixEn"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectprefixEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectsuffixEn != null)
                {
                    transmitObjectObject["SuffixEn"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectsuffixEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectskype != null)
                {
                    transmitObjectObject["Skype"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectskype);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjecttelephoneNumber1 != null)
                {
                    transmitObjectObject["TelephoneNumber1"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjecttelephoneNumber1);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjecttelephoneNumber2 != null)
                {
                    transmitObjectObject["TelephoneNumber2"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjecttelephoneNumber2);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjecttelephoneNumber3 != null)
                {
                    transmitObjectObject["TelephoneNumber3"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjecttelephoneNumber3);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjecttelephoneNumber4 != null)
                {
                    transmitObjectObject["TelephoneNumber4"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjecttelephoneNumber4);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjecttelephoneNumber5 != null)
                {
                    transmitObjectObject["TelephoneNumber5"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjecttelephoneNumber5);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjecttelephoneNumber6 != null)
                {
                    transmitObjectObject["TelephoneNumber6"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjecttelephoneNumber6);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjecttelephoneNumber1Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber1Normalized"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjecttelephoneNumber1Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjecttelephoneNumber2Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber2Normalized"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjecttelephoneNumber2Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjecttelephoneNumber3Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber3Normalized"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjecttelephoneNumber3Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjecttelephoneNumber4Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber4Normalized"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjecttelephoneNumber4Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjecttelephoneNumber5Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber5Normalized"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjecttelephoneNumber5Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjecttelephoneNumber6Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber6Normalized"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjecttelephoneNumber6Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectdepartment != null)
                {
                    transmitObjectObject["Department"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectdepartment);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjecttitle != null)
                {
                    transmitObjectObject["Title"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjecttitle);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectwebPage != null)
                {
                    transmitObjectObject["WebPage"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectwebPage);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectdoNotSendNewsletter != null)
                {
                    transmitObjectObject["DoNotSendNewsletter"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectdoNotSendNewsletter);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectprofilePicture != null)
                {
                    transmitObjectObject["ProfilePicture"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectprofilePicture);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectprofilePictureWidth != null)
                {
                    transmitObjectObject["ProfilePictureWidth"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectprofilePictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectprofilePictureHeight != null)
                {
                    transmitObjectObject["ProfilePictureHeight"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectprofilePictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectlastActivity != null)
                {
                    transmitObjectObject["LastActivity"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectlastActivity);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectnextStep != null)
                {
                    transmitObjectObject["NextStep"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectnextStep);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectcompaniesCompanyGuid != null)
                {
                    transmitObjectObject["Companies_CompanyGuid"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectcompaniesCompanyGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveContactWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(__workflow_saveContactWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    saveContactWrapper["transmitObject"] = transmitObjectObject;
                    saveContactWrapperpropCount++;
                }

                if (__workflow_saveContactWrapperdieOnItemConflict != null)
                {
                    saveContactWrapper["dieOnItemConflict"] = ExpressionConverter.ConvertO(__workflow_saveContactWrapperdieOnItemConflict);
                    saveContactWrapperpropCount++;
                }

                if (__workflow_saveContactWrapperignoredUserErrorMessages != null)
                {
                    saveContactWrapper["ignoredUserErrorMessages"] = ExpressionConverter.ConvertO(__workflow_saveContactWrapperignoredUserErrorMessages);
                    saveContactWrapperpropCount++;
                }

                if (saveContactWrapperpropCount > 0)
                {
                    callPayload.Body = saveContactWrapper;
                }

                return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveJournal(Expression<Func<string>> saveJournalWrappertransmitObjectcalendarEntryID = null, Expression<Func<string>> saveJournalWrappertransmitObjectcalendarORIGIN = null, Expression<Func<string>> saveJournalWrappertransmitObjectchangedField = null, Expression<Func<string>> saveJournalWrappertransmitObjecteventEnd = null, Expression<Func<string>> saveJournalWrappertransmitObjecteventStart = null, Expression<Func<string>> saveJournalWrappertransmitObjectfieldValue = null, Expression<Func<string>> saveJournalWrappertransmitObjectimportanceEn = null, Expression<Func<string>> saveJournalWrappertransmitObjectnote = null, Expression<Func<string>> saveJournalWrappertransmitObjectprevFieldValue = null, Expression<Func<string>> saveJournalWrappertransmitObjecttypeEn = null, Expression<Func<bool>> saveJournalWrappertransmitObjectisSystem = null, Expression<Func<string>> saveJournalWrappertransmitObjectphone = null, Expression<Func<string>> saveJournalWrappertransmitObjectphoneNormalized = null, Expression<Func<bool>> saveJournalWrappertransmitObjectisGdprRelevant = null, Expression<Func<string>> saveJournalWrappertransmitObjectpicture = null, Expression<Func<int>> saveJournalWrappertransmitObjectpictureWidth = null, Expression<Func<int>> saveJournalWrappertransmitObjectpictureHeight = null, Expression<Func<string>> saveJournalWrappertransmitObjectstateEn = null, Expression<Func<string>> saveJournalWrappertransmitObjectprevStateEn = null, Expression<Func<string>> saveJournalWrappertransmitObjectcompaniesCompanyGuid = null, Expression<Func<string>> saveJournalWrappertransmitObjectcontactsContactGuid = null, Expression<Func<string>> saveJournalWrappertransmitObjectleadsSuperiorItemGuid = null, Expression<Func<string>> saveJournalWrappertransmitObjectprojectsSuperiorItemGuid = null, Expression<Func<string>> saveJournalWrappertransmitObjectmarketingMarketingGuid = null, Expression<Func<bool>> saveJournalWrappertransmitObjectisPrivate = null, Expression<Func<string>> saveJournalWrappertransmitObjectitemCreated = null, Expression<Func<string>> saveJournalWrappertransmitObjectitemChanged = null, Expression<Func<string>> saveJournalWrappertransmitObjectfileAs = null, Expression<Func<string>> saveJournalWrappertransmitObjectownerGUID = null, Expression<Func<string>> saveJournalWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> saveJournalWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> saveJournalWrappertransmitObjectadditionalFields = null, Expression<Func<string>> saveJournalWrappertransmitObjectitemGUID = null, Expression<Func<int>> saveJournalWrappertransmitObjectitemVersion = null, Expression<Func<bool>> saveJournalWrapperdieOnItemConflict = null, Expression<Func<string[]>> saveJournalWrapperignoredUserErrorMessages = null)
        {
            var __workflow_saveJournalWrappertransmitObjectcalendarEntryID = WorkflowExpression.Compile(saveJournalWrappertransmitObjectcalendarEntryID, nameof(saveJournalWrappertransmitObjectcalendarEntryID), required: false);
            var __workflow_saveJournalWrappertransmitObjectcalendarORIGIN = WorkflowExpression.Compile(saveJournalWrappertransmitObjectcalendarORIGIN, nameof(saveJournalWrappertransmitObjectcalendarORIGIN), required: false);
            var __workflow_saveJournalWrappertransmitObjectchangedField = WorkflowExpression.Compile(saveJournalWrappertransmitObjectchangedField, nameof(saveJournalWrappertransmitObjectchangedField), required: false);
            var __workflow_saveJournalWrappertransmitObjecteventEnd = WorkflowExpression.Compile(saveJournalWrappertransmitObjecteventEnd, nameof(saveJournalWrappertransmitObjecteventEnd), required: false);
            var __workflow_saveJournalWrappertransmitObjecteventStart = WorkflowExpression.Compile(saveJournalWrappertransmitObjecteventStart, nameof(saveJournalWrappertransmitObjecteventStart), required: false);
            var __workflow_saveJournalWrappertransmitObjectfieldValue = WorkflowExpression.Compile(saveJournalWrappertransmitObjectfieldValue, nameof(saveJournalWrappertransmitObjectfieldValue), required: false);
            var __workflow_saveJournalWrappertransmitObjectimportanceEn = WorkflowExpression.Compile(saveJournalWrappertransmitObjectimportanceEn, nameof(saveJournalWrappertransmitObjectimportanceEn), required: false);
            var __workflow_saveJournalWrappertransmitObjectnote = WorkflowExpression.Compile(saveJournalWrappertransmitObjectnote, nameof(saveJournalWrappertransmitObjectnote), required: false);
            var __workflow_saveJournalWrappertransmitObjectprevFieldValue = WorkflowExpression.Compile(saveJournalWrappertransmitObjectprevFieldValue, nameof(saveJournalWrappertransmitObjectprevFieldValue), required: false);
            var __workflow_saveJournalWrappertransmitObjecttypeEn = WorkflowExpression.Compile(saveJournalWrappertransmitObjecttypeEn, nameof(saveJournalWrappertransmitObjecttypeEn), required: false);
            var __workflow_saveJournalWrappertransmitObjectisSystem = WorkflowExpression.Compile(saveJournalWrappertransmitObjectisSystem, nameof(saveJournalWrappertransmitObjectisSystem), required: false);
            var __workflow_saveJournalWrappertransmitObjectphone = WorkflowExpression.Compile(saveJournalWrappertransmitObjectphone, nameof(saveJournalWrappertransmitObjectphone), required: false);
            var __workflow_saveJournalWrappertransmitObjectphoneNormalized = WorkflowExpression.Compile(saveJournalWrappertransmitObjectphoneNormalized, nameof(saveJournalWrappertransmitObjectphoneNormalized), required: false);
            var __workflow_saveJournalWrappertransmitObjectisGdprRelevant = WorkflowExpression.Compile(saveJournalWrappertransmitObjectisGdprRelevant, nameof(saveJournalWrappertransmitObjectisGdprRelevant), required: false);
            var __workflow_saveJournalWrappertransmitObjectpicture = WorkflowExpression.Compile(saveJournalWrappertransmitObjectpicture, nameof(saveJournalWrappertransmitObjectpicture), required: false);
            var __workflow_saveJournalWrappertransmitObjectpictureWidth = WorkflowExpression.Compile(saveJournalWrappertransmitObjectpictureWidth, nameof(saveJournalWrappertransmitObjectpictureWidth), required: false);
            var __workflow_saveJournalWrappertransmitObjectpictureHeight = WorkflowExpression.Compile(saveJournalWrappertransmitObjectpictureHeight, nameof(saveJournalWrappertransmitObjectpictureHeight), required: false);
            var __workflow_saveJournalWrappertransmitObjectstateEn = WorkflowExpression.Compile(saveJournalWrappertransmitObjectstateEn, nameof(saveJournalWrappertransmitObjectstateEn), required: false);
            var __workflow_saveJournalWrappertransmitObjectprevStateEn = WorkflowExpression.Compile(saveJournalWrappertransmitObjectprevStateEn, nameof(saveJournalWrappertransmitObjectprevStateEn), required: false);
            var __workflow_saveJournalWrappertransmitObjectcompaniesCompanyGuid = WorkflowExpression.Compile(saveJournalWrappertransmitObjectcompaniesCompanyGuid, nameof(saveJournalWrappertransmitObjectcompaniesCompanyGuid), required: false);
            var __workflow_saveJournalWrappertransmitObjectcontactsContactGuid = WorkflowExpression.Compile(saveJournalWrappertransmitObjectcontactsContactGuid, nameof(saveJournalWrappertransmitObjectcontactsContactGuid), required: false);
            var __workflow_saveJournalWrappertransmitObjectleadsSuperiorItemGuid = WorkflowExpression.Compile(saveJournalWrappertransmitObjectleadsSuperiorItemGuid, nameof(saveJournalWrappertransmitObjectleadsSuperiorItemGuid), required: false);
            var __workflow_saveJournalWrappertransmitObjectprojectsSuperiorItemGuid = WorkflowExpression.Compile(saveJournalWrappertransmitObjectprojectsSuperiorItemGuid, nameof(saveJournalWrappertransmitObjectprojectsSuperiorItemGuid), required: false);
            var __workflow_saveJournalWrappertransmitObjectmarketingMarketingGuid = WorkflowExpression.Compile(saveJournalWrappertransmitObjectmarketingMarketingGuid, nameof(saveJournalWrappertransmitObjectmarketingMarketingGuid), required: false);
            var __workflow_saveJournalWrappertransmitObjectisPrivate = WorkflowExpression.Compile(saveJournalWrappertransmitObjectisPrivate, nameof(saveJournalWrappertransmitObjectisPrivate), required: false);
            var __workflow_saveJournalWrappertransmitObjectitemCreated = WorkflowExpression.Compile(saveJournalWrappertransmitObjectitemCreated, nameof(saveJournalWrappertransmitObjectitemCreated), required: false);
            var __workflow_saveJournalWrappertransmitObjectitemChanged = WorkflowExpression.Compile(saveJournalWrappertransmitObjectitemChanged, nameof(saveJournalWrappertransmitObjectitemChanged), required: false);
            var __workflow_saveJournalWrappertransmitObjectfileAs = WorkflowExpression.Compile(saveJournalWrappertransmitObjectfileAs, nameof(saveJournalWrappertransmitObjectfileAs), required: false);
            var __workflow_saveJournalWrappertransmitObjectownerGUID = WorkflowExpression.Compile(saveJournalWrappertransmitObjectownerGUID, nameof(saveJournalWrappertransmitObjectownerGUID), required: false);
            var __workflow_saveJournalWrappertransmitObjectcreatedByGUID = WorkflowExpression.Compile(saveJournalWrappertransmitObjectcreatedByGUID, nameof(saveJournalWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_saveJournalWrappertransmitObjectmodifiedByGUID = WorkflowExpression.Compile(saveJournalWrappertransmitObjectmodifiedByGUID, nameof(saveJournalWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_saveJournalWrappertransmitObjectadditionalFields = WorkflowExpression.Compile(saveJournalWrappertransmitObjectadditionalFields, nameof(saveJournalWrappertransmitObjectadditionalFields), required: false);
            var __workflow_saveJournalWrappertransmitObjectitemGUID = WorkflowExpression.Compile(saveJournalWrappertransmitObjectitemGUID, nameof(saveJournalWrappertransmitObjectitemGUID), required: false);
            var __workflow_saveJournalWrappertransmitObjectitemVersion = WorkflowExpression.Compile(saveJournalWrappertransmitObjectitemVersion, nameof(saveJournalWrappertransmitObjectitemVersion), required: false);
            var __workflow_saveJournalWrapperdieOnItemConflict = WorkflowExpression.Compile(saveJournalWrapperdieOnItemConflict, nameof(saveJournalWrapperdieOnItemConflict), required: false);
            var __workflow_saveJournalWrapperignoredUserErrorMessages = WorkflowExpression.Compile(saveJournalWrapperignoredUserErrorMessages, nameof(saveJournalWrapperignoredUserErrorMessages), required: false);
            return new DeferredBodyAction<EWayWcfServiceResponsesSaveResponse>(() =>
            {
                var apiCallPath = "/SaveJournal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var saveJournalWrapper = new JObject();
                var saveJournalWrapperpropCount = 0;
                var transmitObjectObject = new JObject();
                var transmitObjectObjectpropCount = 0;
                if (__workflow_saveJournalWrappertransmitObjectcalendarEntryID != null)
                {
                    transmitObjectObject["CalendarEntryID"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectcalendarEntryID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectcalendarORIGIN != null)
                {
                    transmitObjectObject["Calendar_ORIGIN"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectcalendarORIGIN);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectchangedField != null)
                {
                    transmitObjectObject["ChangedField"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectchangedField);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjecteventEnd != null)
                {
                    transmitObjectObject["EventEnd"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjecteventEnd);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjecteventStart != null)
                {
                    transmitObjectObject["EventStart"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjecteventStart);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectfieldValue != null)
                {
                    transmitObjectObject["FieldValue"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectfieldValue);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectimportanceEn != null)
                {
                    transmitObjectObject["ImportanceEn"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectimportanceEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectnote != null)
                {
                    transmitObjectObject["Note"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectnote);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectprevFieldValue != null)
                {
                    transmitObjectObject["PrevFieldValue"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectprevFieldValue);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectisSystem != null)
                {
                    transmitObjectObject["IsSystem"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectisSystem);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectphone != null)
                {
                    transmitObjectObject["Phone"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectphone);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectphoneNormalized != null)
                {
                    transmitObjectObject["PhoneNormalized"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectphoneNormalized);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectisGdprRelevant != null)
                {
                    transmitObjectObject["IsGdprRelevant"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectisGdprRelevant);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectpicture != null)
                {
                    transmitObjectObject["Picture"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectpicture);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectpictureWidth != null)
                {
                    transmitObjectObject["PictureWidth"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectpictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectpictureHeight != null)
                {
                    transmitObjectObject["PictureHeight"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectpictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectcompaniesCompanyGuid != null)
                {
                    transmitObjectObject["Companies_CompanyGuid"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectcompaniesCompanyGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectcontactsContactGuid != null)
                {
                    transmitObjectObject["Contacts_ContactGuid"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectcontactsContactGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectleadsSuperiorItemGuid != null)
                {
                    transmitObjectObject["Leads_SuperiorItemGuid"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectleadsSuperiorItemGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectprojectsSuperiorItemGuid != null)
                {
                    transmitObjectObject["Projects_SuperiorItemGuid"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectprojectsSuperiorItemGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectmarketingMarketingGuid != null)
                {
                    transmitObjectObject["Marketing_MarketingGuid"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectmarketingMarketingGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveJournalWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    saveJournalWrapper["transmitObject"] = transmitObjectObject;
                    saveJournalWrapperpropCount++;
                }

                if (__workflow_saveJournalWrapperdieOnItemConflict != null)
                {
                    saveJournalWrapper["dieOnItemConflict"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrapperdieOnItemConflict);
                    saveJournalWrapperpropCount++;
                }

                if (__workflow_saveJournalWrapperignoredUserErrorMessages != null)
                {
                    saveJournalWrapper["ignoredUserErrorMessages"] = ExpressionConverter.ConvertO(__workflow_saveJournalWrapperignoredUserErrorMessages);
                    saveJournalWrapperpropCount++;
                }

                if (saveJournalWrapperpropCount > 0)
                {
                    callPayload.Body = saveJournalWrapper;
                }

                return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveLead(Expression<Func<string>> saveLeadWrappertransmitObjectcity = null, Expression<Func<string>> saveLeadWrappertransmitObjectcontactPerson = null, Expression<Func<string>> saveLeadWrappertransmitObjectcurrencyEn = null, Expression<Func<string>> saveLeadWrappertransmitObjectcustomer = null, Expression<Func<string>> saveLeadWrappertransmitObjectemail = null, Expression<Func<string>> saveLeadWrappertransmitObjectestimatedEnd = null, Expression<Func<int>> saveLeadWrappertransmitObjecthID = null, Expression<Func<string>> saveLeadWrappertransmitObjectleadOriginEn = null, Expression<Func<string>> saveLeadWrappertransmitObjectnote = null, Expression<Func<string>> saveLeadWrappertransmitObjectphone = null, Expression<Func<string>> saveLeadWrappertransmitObjectphoneNormalized = null, Expression<Func<string>> saveLeadWrappertransmitObjectprevStateEn = null, Expression<Func<double>> saveLeadWrappertransmitObjectprice = null, Expression<Func<string>> saveLeadWrappertransmitObjectpriceChanged = null, Expression<Func<double>> saveLeadWrappertransmitObjectpriceDefaultCurrency = null, Expression<Func<double>> saveLeadWrappertransmitObjectprobability = null, Expression<Func<string>> saveLeadWrappertransmitObjectreceiveDate = null, Expression<Func<string>> saveLeadWrappertransmitObjectstateEn = null, Expression<Func<string>> saveLeadWrappertransmitObjectstreet = null, Expression<Func<string>> saveLeadWrappertransmitObjecttypeEn = null, Expression<Func<string>> saveLeadWrappertransmitObjectzip = null, Expression<Func<string>> saveLeadWrappertransmitObjectlastActivity = null, Expression<Func<string>> saveLeadWrappertransmitObjectnextStep = null, Expression<Func<double>> saveLeadWrappertransmitObjectestimatedValue = null, Expression<Func<string>> saveLeadWrappertransmitObjectcountryEn = null, Expression<Func<string>> saveLeadWrappertransmitObjectstate = null, Expression<Func<string>> saveLeadWrappertransmitObjectpOBox = null, Expression<Func<bool>> saveLeadWrappertransmitObjectemailOptOut = null, Expression<Func<string>> saveLeadWrappertransmitObjectpicture = null, Expression<Func<int>> saveLeadWrappertransmitObjectpictureWidth = null, Expression<Func<int>> saveLeadWrappertransmitObjectpictureHeight = null, Expression<Func<string>> saveLeadWrappertransmitObjectcompaniesCustomerGuid = null, Expression<Func<string>> saveLeadWrappertransmitObjectcontactsContactPersonGuid = null, Expression<Func<string>> saveLeadWrappertransmitObjectmarketingMarketingGuid = null, Expression<Func<bool>> saveLeadWrappertransmitObjectisPrivate = null, Expression<Func<string>> saveLeadWrappertransmitObjectitemCreated = null, Expression<Func<string>> saveLeadWrappertransmitObjectitemChanged = null, Expression<Func<string>> saveLeadWrappertransmitObjectfileAs = null, Expression<Func<string>> saveLeadWrappertransmitObjectownerGUID = null, Expression<Func<string>> saveLeadWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> saveLeadWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> saveLeadWrappertransmitObjectadditionalFields = null, Expression<Func<string>> saveLeadWrappertransmitObjectitemGUID = null, Expression<Func<int>> saveLeadWrappertransmitObjectitemVersion = null, Expression<Func<bool>> saveLeadWrapperdieOnItemConflict = null, Expression<Func<string[]>> saveLeadWrapperignoredUserErrorMessages = null)
        {
            var __workflow_saveLeadWrappertransmitObjectcity = WorkflowExpression.Compile(saveLeadWrappertransmitObjectcity, nameof(saveLeadWrappertransmitObjectcity), required: false);
            var __workflow_saveLeadWrappertransmitObjectcontactPerson = WorkflowExpression.Compile(saveLeadWrappertransmitObjectcontactPerson, nameof(saveLeadWrappertransmitObjectcontactPerson), required: false);
            var __workflow_saveLeadWrappertransmitObjectcurrencyEn = WorkflowExpression.Compile(saveLeadWrappertransmitObjectcurrencyEn, nameof(saveLeadWrappertransmitObjectcurrencyEn), required: false);
            var __workflow_saveLeadWrappertransmitObjectcustomer = WorkflowExpression.Compile(saveLeadWrappertransmitObjectcustomer, nameof(saveLeadWrappertransmitObjectcustomer), required: false);
            var __workflow_saveLeadWrappertransmitObjectemail = WorkflowExpression.Compile(saveLeadWrappertransmitObjectemail, nameof(saveLeadWrappertransmitObjectemail), required: false);
            var __workflow_saveLeadWrappertransmitObjectestimatedEnd = WorkflowExpression.Compile(saveLeadWrappertransmitObjectestimatedEnd, nameof(saveLeadWrappertransmitObjectestimatedEnd), required: false);
            var __workflow_saveLeadWrappertransmitObjecthID = WorkflowExpression.Compile(saveLeadWrappertransmitObjecthID, nameof(saveLeadWrappertransmitObjecthID), required: false);
            var __workflow_saveLeadWrappertransmitObjectleadOriginEn = WorkflowExpression.Compile(saveLeadWrappertransmitObjectleadOriginEn, nameof(saveLeadWrappertransmitObjectleadOriginEn), required: false);
            var __workflow_saveLeadWrappertransmitObjectnote = WorkflowExpression.Compile(saveLeadWrappertransmitObjectnote, nameof(saveLeadWrappertransmitObjectnote), required: false);
            var __workflow_saveLeadWrappertransmitObjectphone = WorkflowExpression.Compile(saveLeadWrappertransmitObjectphone, nameof(saveLeadWrappertransmitObjectphone), required: false);
            var __workflow_saveLeadWrappertransmitObjectphoneNormalized = WorkflowExpression.Compile(saveLeadWrappertransmitObjectphoneNormalized, nameof(saveLeadWrappertransmitObjectphoneNormalized), required: false);
            var __workflow_saveLeadWrappertransmitObjectprevStateEn = WorkflowExpression.Compile(saveLeadWrappertransmitObjectprevStateEn, nameof(saveLeadWrappertransmitObjectprevStateEn), required: false);
            var __workflow_saveLeadWrappertransmitObjectprice = WorkflowExpression.Compile(saveLeadWrappertransmitObjectprice, nameof(saveLeadWrappertransmitObjectprice), required: false);
            var __workflow_saveLeadWrappertransmitObjectpriceChanged = WorkflowExpression.Compile(saveLeadWrappertransmitObjectpriceChanged, nameof(saveLeadWrappertransmitObjectpriceChanged), required: false);
            var __workflow_saveLeadWrappertransmitObjectpriceDefaultCurrency = WorkflowExpression.Compile(saveLeadWrappertransmitObjectpriceDefaultCurrency, nameof(saveLeadWrappertransmitObjectpriceDefaultCurrency), required: false);
            var __workflow_saveLeadWrappertransmitObjectprobability = WorkflowExpression.Compile(saveLeadWrappertransmitObjectprobability, nameof(saveLeadWrappertransmitObjectprobability), required: false);
            var __workflow_saveLeadWrappertransmitObjectreceiveDate = WorkflowExpression.Compile(saveLeadWrappertransmitObjectreceiveDate, nameof(saveLeadWrappertransmitObjectreceiveDate), required: false);
            var __workflow_saveLeadWrappertransmitObjectstateEn = WorkflowExpression.Compile(saveLeadWrappertransmitObjectstateEn, nameof(saveLeadWrappertransmitObjectstateEn), required: false);
            var __workflow_saveLeadWrappertransmitObjectstreet = WorkflowExpression.Compile(saveLeadWrappertransmitObjectstreet, nameof(saveLeadWrappertransmitObjectstreet), required: false);
            var __workflow_saveLeadWrappertransmitObjecttypeEn = WorkflowExpression.Compile(saveLeadWrappertransmitObjecttypeEn, nameof(saveLeadWrappertransmitObjecttypeEn), required: false);
            var __workflow_saveLeadWrappertransmitObjectzip = WorkflowExpression.Compile(saveLeadWrappertransmitObjectzip, nameof(saveLeadWrappertransmitObjectzip), required: false);
            var __workflow_saveLeadWrappertransmitObjectlastActivity = WorkflowExpression.Compile(saveLeadWrappertransmitObjectlastActivity, nameof(saveLeadWrappertransmitObjectlastActivity), required: false);
            var __workflow_saveLeadWrappertransmitObjectnextStep = WorkflowExpression.Compile(saveLeadWrappertransmitObjectnextStep, nameof(saveLeadWrappertransmitObjectnextStep), required: false);
            var __workflow_saveLeadWrappertransmitObjectestimatedValue = WorkflowExpression.Compile(saveLeadWrappertransmitObjectestimatedValue, nameof(saveLeadWrappertransmitObjectestimatedValue), required: false);
            var __workflow_saveLeadWrappertransmitObjectcountryEn = WorkflowExpression.Compile(saveLeadWrappertransmitObjectcountryEn, nameof(saveLeadWrappertransmitObjectcountryEn), required: false);
            var __workflow_saveLeadWrappertransmitObjectstate = WorkflowExpression.Compile(saveLeadWrappertransmitObjectstate, nameof(saveLeadWrappertransmitObjectstate), required: false);
            var __workflow_saveLeadWrappertransmitObjectpOBox = WorkflowExpression.Compile(saveLeadWrappertransmitObjectpOBox, nameof(saveLeadWrappertransmitObjectpOBox), required: false);
            var __workflow_saveLeadWrappertransmitObjectemailOptOut = WorkflowExpression.Compile(saveLeadWrappertransmitObjectemailOptOut, nameof(saveLeadWrappertransmitObjectemailOptOut), required: false);
            var __workflow_saveLeadWrappertransmitObjectpicture = WorkflowExpression.Compile(saveLeadWrappertransmitObjectpicture, nameof(saveLeadWrappertransmitObjectpicture), required: false);
            var __workflow_saveLeadWrappertransmitObjectpictureWidth = WorkflowExpression.Compile(saveLeadWrappertransmitObjectpictureWidth, nameof(saveLeadWrappertransmitObjectpictureWidth), required: false);
            var __workflow_saveLeadWrappertransmitObjectpictureHeight = WorkflowExpression.Compile(saveLeadWrappertransmitObjectpictureHeight, nameof(saveLeadWrappertransmitObjectpictureHeight), required: false);
            var __workflow_saveLeadWrappertransmitObjectcompaniesCustomerGuid = WorkflowExpression.Compile(saveLeadWrappertransmitObjectcompaniesCustomerGuid, nameof(saveLeadWrappertransmitObjectcompaniesCustomerGuid), required: false);
            var __workflow_saveLeadWrappertransmitObjectcontactsContactPersonGuid = WorkflowExpression.Compile(saveLeadWrappertransmitObjectcontactsContactPersonGuid, nameof(saveLeadWrappertransmitObjectcontactsContactPersonGuid), required: false);
            var __workflow_saveLeadWrappertransmitObjectmarketingMarketingGuid = WorkflowExpression.Compile(saveLeadWrappertransmitObjectmarketingMarketingGuid, nameof(saveLeadWrappertransmitObjectmarketingMarketingGuid), required: false);
            var __workflow_saveLeadWrappertransmitObjectisPrivate = WorkflowExpression.Compile(saveLeadWrappertransmitObjectisPrivate, nameof(saveLeadWrappertransmitObjectisPrivate), required: false);
            var __workflow_saveLeadWrappertransmitObjectitemCreated = WorkflowExpression.Compile(saveLeadWrappertransmitObjectitemCreated, nameof(saveLeadWrappertransmitObjectitemCreated), required: false);
            var __workflow_saveLeadWrappertransmitObjectitemChanged = WorkflowExpression.Compile(saveLeadWrappertransmitObjectitemChanged, nameof(saveLeadWrappertransmitObjectitemChanged), required: false);
            var __workflow_saveLeadWrappertransmitObjectfileAs = WorkflowExpression.Compile(saveLeadWrappertransmitObjectfileAs, nameof(saveLeadWrappertransmitObjectfileAs), required: false);
            var __workflow_saveLeadWrappertransmitObjectownerGUID = WorkflowExpression.Compile(saveLeadWrappertransmitObjectownerGUID, nameof(saveLeadWrappertransmitObjectownerGUID), required: false);
            var __workflow_saveLeadWrappertransmitObjectcreatedByGUID = WorkflowExpression.Compile(saveLeadWrappertransmitObjectcreatedByGUID, nameof(saveLeadWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_saveLeadWrappertransmitObjectmodifiedByGUID = WorkflowExpression.Compile(saveLeadWrappertransmitObjectmodifiedByGUID, nameof(saveLeadWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_saveLeadWrappertransmitObjectadditionalFields = WorkflowExpression.Compile(saveLeadWrappertransmitObjectadditionalFields, nameof(saveLeadWrappertransmitObjectadditionalFields), required: false);
            var __workflow_saveLeadWrappertransmitObjectitemGUID = WorkflowExpression.Compile(saveLeadWrappertransmitObjectitemGUID, nameof(saveLeadWrappertransmitObjectitemGUID), required: false);
            var __workflow_saveLeadWrappertransmitObjectitemVersion = WorkflowExpression.Compile(saveLeadWrappertransmitObjectitemVersion, nameof(saveLeadWrappertransmitObjectitemVersion), required: false);
            var __workflow_saveLeadWrapperdieOnItemConflict = WorkflowExpression.Compile(saveLeadWrapperdieOnItemConflict, nameof(saveLeadWrapperdieOnItemConflict), required: false);
            var __workflow_saveLeadWrapperignoredUserErrorMessages = WorkflowExpression.Compile(saveLeadWrapperignoredUserErrorMessages, nameof(saveLeadWrapperignoredUserErrorMessages), required: false);
            return new DeferredBodyAction<EWayWcfServiceResponsesSaveResponse>(() =>
            {
                var apiCallPath = "/SaveLead";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var saveLeadWrapper = new JObject();
                var saveLeadWrapperpropCount = 0;
                var transmitObjectObject = new JObject();
                var transmitObjectObjectpropCount = 0;
                if (__workflow_saveLeadWrappertransmitObjectcity != null)
                {
                    transmitObjectObject["City"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectcity);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectcontactPerson != null)
                {
                    transmitObjectObject["ContactPerson"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectcontactPerson);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectcurrencyEn != null)
                {
                    transmitObjectObject["CurrencyEn"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectcurrencyEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectcustomer != null)
                {
                    transmitObjectObject["Customer"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectcustomer);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectemail != null)
                {
                    transmitObjectObject["Email"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectemail);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectestimatedEnd != null)
                {
                    transmitObjectObject["EstimatedEnd"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectestimatedEnd);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjecthID != null)
                {
                    transmitObjectObject["HID"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjecthID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectleadOriginEn != null)
                {
                    transmitObjectObject["LeadOriginEn"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectleadOriginEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectnote != null)
                {
                    transmitObjectObject["Note"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectnote);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectphone != null)
                {
                    transmitObjectObject["Phone"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectphone);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectphoneNormalized != null)
                {
                    transmitObjectObject["PhoneNormalized"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectphoneNormalized);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectprice != null)
                {
                    transmitObjectObject["Price"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectprice);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectpriceChanged != null)
                {
                    transmitObjectObject["PriceChanged"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectpriceChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectpriceDefaultCurrency != null)
                {
                    transmitObjectObject["PriceDefaultCurrency"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectpriceDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectprobability != null)
                {
                    transmitObjectObject["Probability"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectprobability);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectreceiveDate != null)
                {
                    transmitObjectObject["ReceiveDate"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectreceiveDate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectstreet != null)
                {
                    transmitObjectObject["Street"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectstreet);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectzip != null)
                {
                    transmitObjectObject["Zip"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectzip);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectlastActivity != null)
                {
                    transmitObjectObject["LastActivity"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectlastActivity);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectnextStep != null)
                {
                    transmitObjectObject["NextStep"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectnextStep);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectestimatedValue != null)
                {
                    transmitObjectObject["EstimatedValue"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectestimatedValue);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectcountryEn != null)
                {
                    transmitObjectObject["CountryEn"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectcountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectstate != null)
                {
                    transmitObjectObject["State"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectstate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectpOBox != null)
                {
                    transmitObjectObject["POBox"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectpOBox);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectemailOptOut != null)
                {
                    transmitObjectObject["EmailOptOut"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectemailOptOut);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectpicture != null)
                {
                    transmitObjectObject["Picture"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectpicture);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectpictureWidth != null)
                {
                    transmitObjectObject["PictureWidth"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectpictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectpictureHeight != null)
                {
                    transmitObjectObject["PictureHeight"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectpictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectcompaniesCustomerGuid != null)
                {
                    transmitObjectObject["Companies_CustomerGuid"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectcompaniesCustomerGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectcontactsContactPersonGuid != null)
                {
                    transmitObjectObject["Contacts_ContactPersonGuid"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectcontactsContactPersonGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectmarketingMarketingGuid != null)
                {
                    transmitObjectObject["Marketing_MarketingGuid"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectmarketingMarketingGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveLeadWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    saveLeadWrapper["transmitObject"] = transmitObjectObject;
                    saveLeadWrapperpropCount++;
                }

                if (__workflow_saveLeadWrapperdieOnItemConflict != null)
                {
                    saveLeadWrapper["dieOnItemConflict"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrapperdieOnItemConflict);
                    saveLeadWrapperpropCount++;
                }

                if (__workflow_saveLeadWrapperignoredUserErrorMessages != null)
                {
                    saveLeadWrapper["ignoredUserErrorMessages"] = ExpressionConverter.ConvertO(__workflow_saveLeadWrapperignoredUserErrorMessages);
                    saveLeadWrapperpropCount++;
                }

                if (saveLeadWrapperpropCount > 0)
                {
                    callPayload.Body = saveLeadWrapper;
                }

                return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveProject(Expression<Func<string>> saveProjectWrappertransmitObjectnote = null, Expression<Func<double>> saveProjectWrappertransmitObjectprice = null, Expression<Func<string>> saveProjectWrappertransmitObjectprojectEnd = null, Expression<Func<string>> saveProjectWrappertransmitObjectprojectName = null, Expression<Func<string>> saveProjectWrappertransmitObjecttypeEn = null, Expression<Func<string>> saveProjectWrappertransmitObjectstateEn = null, Expression<Func<double>> saveProjectWrappertransmitObjectpeopleExpenses = null, Expression<Func<string>> saveProjectWrappertransmitObjectprojectRealEnd = null, Expression<Func<double>> saveProjectWrappertransmitObjectestimatedPrice = null, Expression<Func<int>> saveProjectWrappertransmitObjecthID = null, Expression<Func<string>> saveProjectWrappertransmitObjectprojectOriginEn = null, Expression<Func<string>> saveProjectWrappertransmitObjectpaymentTypeEn = null, Expression<Func<double>> saveProjectWrappertransmitObjectotherExpenses = null, Expression<Func<double>> saveProjectWrappertransmitObjectmargin = null, Expression<Func<double>> saveProjectWrappertransmitObjectprofit = null, Expression<Func<int>> saveProjectWrappertransmitObjectpaymentMaturity = null, Expression<Func<string>> saveProjectWrappertransmitObjectinvoicePaymentDate = null, Expression<Func<string>> saveProjectWrappertransmitObjectinvoiceIssueDate = null, Expression<Func<double>> saveProjectWrappertransmitObjectestimatedMargin = null, Expression<Func<double>> saveProjectWrappertransmitObjectestimatedProfit = null, Expression<Func<double>> saveProjectWrappertransmitObjectestimatedPeopleExpenses = null, Expression<Func<double>> saveProjectWrappertransmitObjectestimatedOtherExpenses = null, Expression<Func<int>> saveProjectWrappertransmitObjectlicensesCount = null, Expression<Func<double>> saveProjectWrappertransmitObjectlicensePrice = null, Expression<Func<string>> saveProjectWrappertransmitObjectprevStateEn = null, Expression<Func<bool>> saveProjectWrappertransmitObjectshowInCaplan = null, Expression<Func<string>> saveProjectWrappertransmitObjectprojectStart = null, Expression<Func<int>> saveProjectWrappertransmitObjectestimatedWorkHours = null, Expression<Func<double>> saveProjectWrappertransmitObjecttotalWorkHours = null, Expression<Func<double>> saveProjectWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency = null, Expression<Func<double>> saveProjectWrappertransmitObjectestimatedOtherExpensesDefaultCurrency = null, Expression<Func<double>> saveProjectWrappertransmitObjectestimatedPriceDefaultCurrency = null, Expression<Func<double>> saveProjectWrappertransmitObjectpeopleExpensesDefaultCurrency = null, Expression<Func<double>> saveProjectWrappertransmitObjectotherExpensesDefaultCurrency = null, Expression<Func<double>> saveProjectWrappertransmitObjectpriceDefaultCurrency = null, Expression<Func<double>> saveProjectWrappertransmitObjectprofitDefaultCurrency = null, Expression<Func<double>> saveProjectWrappertransmitObjectestimatedProfitDefaultCurrency = null, Expression<Func<string>> saveProjectWrappertransmitObjectcurrencyEn = null, Expression<Func<string>> saveProjectWrappertransmitObjectestimatedPeopleExpensesChanged = null, Expression<Func<string>> saveProjectWrappertransmitObjectestimatedOtherExpensesChanged = null, Expression<Func<string>> saveProjectWrappertransmitObjectotherExpensesChanged = null, Expression<Func<string>> saveProjectWrappertransmitObjectestimatedPriceChanged = null, Expression<Func<string>> saveProjectWrappertransmitObjectpriceChanged = null, Expression<Func<string>> saveProjectWrappertransmitObjectlicensePriceChanged = null, Expression<Func<double>> saveProjectWrappertransmitObjectlicensePriceDefaultCurrency = null, Expression<Func<string>> saveProjectWrappertransmitObjectlastActivity = null, Expression<Func<string>> saveProjectWrappertransmitObjectnextStep = null, Expression<Func<string>> saveProjectWrappertransmitObjectpeopleExpensesChanged = null, Expression<Func<string>> saveProjectWrappertransmitObjectpicture = null, Expression<Func<int>> saveProjectWrappertransmitObjectpictureWidth = null, Expression<Func<int>> saveProjectWrappertransmitObjectpictureHeight = null, Expression<Func<string>> saveProjectWrappertransmitObjectcompaniesCustomerGuid = null, Expression<Func<string>> saveProjectWrappertransmitObjectcontactsContactPersonGuid = null, Expression<Func<string>> saveProjectWrappertransmitObjectleadsProjectOriginGuid = null, Expression<Func<string>> saveProjectWrappertransmitObjectprojectsSuperiorProjectGuid = null, Expression<Func<string>> saveProjectWrappertransmitObjectusersSupervisorGuid = null, Expression<Func<bool>> saveProjectWrappertransmitObjectisPrivate = null, Expression<Func<string>> saveProjectWrappertransmitObjectitemCreated = null, Expression<Func<string>> saveProjectWrappertransmitObjectitemChanged = null, Expression<Func<string>> saveProjectWrappertransmitObjectfileAs = null, Expression<Func<string>> saveProjectWrappertransmitObjectownerGUID = null, Expression<Func<string>> saveProjectWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> saveProjectWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> saveProjectWrappertransmitObjectadditionalFields = null, Expression<Func<string>> saveProjectWrappertransmitObjectitemGUID = null, Expression<Func<int>> saveProjectWrappertransmitObjectitemVersion = null, Expression<Func<bool>> saveProjectWrapperdieOnItemConflict = null, Expression<Func<string[]>> saveProjectWrapperignoredUserErrorMessages = null)
        {
            var __workflow_saveProjectWrappertransmitObjectnote = WorkflowExpression.Compile(saveProjectWrappertransmitObjectnote, nameof(saveProjectWrappertransmitObjectnote), required: false);
            var __workflow_saveProjectWrappertransmitObjectprice = WorkflowExpression.Compile(saveProjectWrappertransmitObjectprice, nameof(saveProjectWrappertransmitObjectprice), required: false);
            var __workflow_saveProjectWrappertransmitObjectprojectEnd = WorkflowExpression.Compile(saveProjectWrappertransmitObjectprojectEnd, nameof(saveProjectWrappertransmitObjectprojectEnd), required: false);
            var __workflow_saveProjectWrappertransmitObjectprojectName = WorkflowExpression.Compile(saveProjectWrappertransmitObjectprojectName, nameof(saveProjectWrappertransmitObjectprojectName), required: false);
            var __workflow_saveProjectWrappertransmitObjecttypeEn = WorkflowExpression.Compile(saveProjectWrappertransmitObjecttypeEn, nameof(saveProjectWrappertransmitObjecttypeEn), required: false);
            var __workflow_saveProjectWrappertransmitObjectstateEn = WorkflowExpression.Compile(saveProjectWrappertransmitObjectstateEn, nameof(saveProjectWrappertransmitObjectstateEn), required: false);
            var __workflow_saveProjectWrappertransmitObjectpeopleExpenses = WorkflowExpression.Compile(saveProjectWrappertransmitObjectpeopleExpenses, nameof(saveProjectWrappertransmitObjectpeopleExpenses), required: false);
            var __workflow_saveProjectWrappertransmitObjectprojectRealEnd = WorkflowExpression.Compile(saveProjectWrappertransmitObjectprojectRealEnd, nameof(saveProjectWrappertransmitObjectprojectRealEnd), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedPrice = WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedPrice, nameof(saveProjectWrappertransmitObjectestimatedPrice), required: false);
            var __workflow_saveProjectWrappertransmitObjecthID = WorkflowExpression.Compile(saveProjectWrappertransmitObjecthID, nameof(saveProjectWrappertransmitObjecthID), required: false);
            var __workflow_saveProjectWrappertransmitObjectprojectOriginEn = WorkflowExpression.Compile(saveProjectWrappertransmitObjectprojectOriginEn, nameof(saveProjectWrappertransmitObjectprojectOriginEn), required: false);
            var __workflow_saveProjectWrappertransmitObjectpaymentTypeEn = WorkflowExpression.Compile(saveProjectWrappertransmitObjectpaymentTypeEn, nameof(saveProjectWrappertransmitObjectpaymentTypeEn), required: false);
            var __workflow_saveProjectWrappertransmitObjectotherExpenses = WorkflowExpression.Compile(saveProjectWrappertransmitObjectotherExpenses, nameof(saveProjectWrappertransmitObjectotherExpenses), required: false);
            var __workflow_saveProjectWrappertransmitObjectmargin = WorkflowExpression.Compile(saveProjectWrappertransmitObjectmargin, nameof(saveProjectWrappertransmitObjectmargin), required: false);
            var __workflow_saveProjectWrappertransmitObjectprofit = WorkflowExpression.Compile(saveProjectWrappertransmitObjectprofit, nameof(saveProjectWrappertransmitObjectprofit), required: false);
            var __workflow_saveProjectWrappertransmitObjectpaymentMaturity = WorkflowExpression.Compile(saveProjectWrappertransmitObjectpaymentMaturity, nameof(saveProjectWrappertransmitObjectpaymentMaturity), required: false);
            var __workflow_saveProjectWrappertransmitObjectinvoicePaymentDate = WorkflowExpression.Compile(saveProjectWrappertransmitObjectinvoicePaymentDate, nameof(saveProjectWrappertransmitObjectinvoicePaymentDate), required: false);
            var __workflow_saveProjectWrappertransmitObjectinvoiceIssueDate = WorkflowExpression.Compile(saveProjectWrappertransmitObjectinvoiceIssueDate, nameof(saveProjectWrappertransmitObjectinvoiceIssueDate), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedMargin = WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedMargin, nameof(saveProjectWrappertransmitObjectestimatedMargin), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedProfit = WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedProfit, nameof(saveProjectWrappertransmitObjectestimatedProfit), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedPeopleExpenses = WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedPeopleExpenses, nameof(saveProjectWrappertransmitObjectestimatedPeopleExpenses), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedOtherExpenses = WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedOtherExpenses, nameof(saveProjectWrappertransmitObjectestimatedOtherExpenses), required: false);
            var __workflow_saveProjectWrappertransmitObjectlicensesCount = WorkflowExpression.Compile(saveProjectWrappertransmitObjectlicensesCount, nameof(saveProjectWrappertransmitObjectlicensesCount), required: false);
            var __workflow_saveProjectWrappertransmitObjectlicensePrice = WorkflowExpression.Compile(saveProjectWrappertransmitObjectlicensePrice, nameof(saveProjectWrappertransmitObjectlicensePrice), required: false);
            var __workflow_saveProjectWrappertransmitObjectprevStateEn = WorkflowExpression.Compile(saveProjectWrappertransmitObjectprevStateEn, nameof(saveProjectWrappertransmitObjectprevStateEn), required: false);
            var __workflow_saveProjectWrappertransmitObjectshowInCaplan = WorkflowExpression.Compile(saveProjectWrappertransmitObjectshowInCaplan, nameof(saveProjectWrappertransmitObjectshowInCaplan), required: false);
            var __workflow_saveProjectWrappertransmitObjectprojectStart = WorkflowExpression.Compile(saveProjectWrappertransmitObjectprojectStart, nameof(saveProjectWrappertransmitObjectprojectStart), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedWorkHours = WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedWorkHours, nameof(saveProjectWrappertransmitObjectestimatedWorkHours), required: false);
            var __workflow_saveProjectWrappertransmitObjecttotalWorkHours = WorkflowExpression.Compile(saveProjectWrappertransmitObjecttotalWorkHours, nameof(saveProjectWrappertransmitObjecttotalWorkHours), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency = WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency, nameof(saveProjectWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedOtherExpensesDefaultCurrency = WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedOtherExpensesDefaultCurrency, nameof(saveProjectWrappertransmitObjectestimatedOtherExpensesDefaultCurrency), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedPriceDefaultCurrency = WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedPriceDefaultCurrency, nameof(saveProjectWrappertransmitObjectestimatedPriceDefaultCurrency), required: false);
            var __workflow_saveProjectWrappertransmitObjectpeopleExpensesDefaultCurrency = WorkflowExpression.Compile(saveProjectWrappertransmitObjectpeopleExpensesDefaultCurrency, nameof(saveProjectWrappertransmitObjectpeopleExpensesDefaultCurrency), required: false);
            var __workflow_saveProjectWrappertransmitObjectotherExpensesDefaultCurrency = WorkflowExpression.Compile(saveProjectWrappertransmitObjectotherExpensesDefaultCurrency, nameof(saveProjectWrappertransmitObjectotherExpensesDefaultCurrency), required: false);
            var __workflow_saveProjectWrappertransmitObjectpriceDefaultCurrency = WorkflowExpression.Compile(saveProjectWrappertransmitObjectpriceDefaultCurrency, nameof(saveProjectWrappertransmitObjectpriceDefaultCurrency), required: false);
            var __workflow_saveProjectWrappertransmitObjectprofitDefaultCurrency = WorkflowExpression.Compile(saveProjectWrappertransmitObjectprofitDefaultCurrency, nameof(saveProjectWrappertransmitObjectprofitDefaultCurrency), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedProfitDefaultCurrency = WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedProfitDefaultCurrency, nameof(saveProjectWrappertransmitObjectestimatedProfitDefaultCurrency), required: false);
            var __workflow_saveProjectWrappertransmitObjectcurrencyEn = WorkflowExpression.Compile(saveProjectWrappertransmitObjectcurrencyEn, nameof(saveProjectWrappertransmitObjectcurrencyEn), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedPeopleExpensesChanged = WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedPeopleExpensesChanged, nameof(saveProjectWrappertransmitObjectestimatedPeopleExpensesChanged), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedOtherExpensesChanged = WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedOtherExpensesChanged, nameof(saveProjectWrappertransmitObjectestimatedOtherExpensesChanged), required: false);
            var __workflow_saveProjectWrappertransmitObjectotherExpensesChanged = WorkflowExpression.Compile(saveProjectWrappertransmitObjectotherExpensesChanged, nameof(saveProjectWrappertransmitObjectotherExpensesChanged), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedPriceChanged = WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedPriceChanged, nameof(saveProjectWrappertransmitObjectestimatedPriceChanged), required: false);
            var __workflow_saveProjectWrappertransmitObjectpriceChanged = WorkflowExpression.Compile(saveProjectWrappertransmitObjectpriceChanged, nameof(saveProjectWrappertransmitObjectpriceChanged), required: false);
            var __workflow_saveProjectWrappertransmitObjectlicensePriceChanged = WorkflowExpression.Compile(saveProjectWrappertransmitObjectlicensePriceChanged, nameof(saveProjectWrappertransmitObjectlicensePriceChanged), required: false);
            var __workflow_saveProjectWrappertransmitObjectlicensePriceDefaultCurrency = WorkflowExpression.Compile(saveProjectWrappertransmitObjectlicensePriceDefaultCurrency, nameof(saveProjectWrappertransmitObjectlicensePriceDefaultCurrency), required: false);
            var __workflow_saveProjectWrappertransmitObjectlastActivity = WorkflowExpression.Compile(saveProjectWrappertransmitObjectlastActivity, nameof(saveProjectWrappertransmitObjectlastActivity), required: false);
            var __workflow_saveProjectWrappertransmitObjectnextStep = WorkflowExpression.Compile(saveProjectWrappertransmitObjectnextStep, nameof(saveProjectWrappertransmitObjectnextStep), required: false);
            var __workflow_saveProjectWrappertransmitObjectpeopleExpensesChanged = WorkflowExpression.Compile(saveProjectWrappertransmitObjectpeopleExpensesChanged, nameof(saveProjectWrappertransmitObjectpeopleExpensesChanged), required: false);
            var __workflow_saveProjectWrappertransmitObjectpicture = WorkflowExpression.Compile(saveProjectWrappertransmitObjectpicture, nameof(saveProjectWrappertransmitObjectpicture), required: false);
            var __workflow_saveProjectWrappertransmitObjectpictureWidth = WorkflowExpression.Compile(saveProjectWrappertransmitObjectpictureWidth, nameof(saveProjectWrappertransmitObjectpictureWidth), required: false);
            var __workflow_saveProjectWrappertransmitObjectpictureHeight = WorkflowExpression.Compile(saveProjectWrappertransmitObjectpictureHeight, nameof(saveProjectWrappertransmitObjectpictureHeight), required: false);
            var __workflow_saveProjectWrappertransmitObjectcompaniesCustomerGuid = WorkflowExpression.Compile(saveProjectWrappertransmitObjectcompaniesCustomerGuid, nameof(saveProjectWrappertransmitObjectcompaniesCustomerGuid), required: false);
            var __workflow_saveProjectWrappertransmitObjectcontactsContactPersonGuid = WorkflowExpression.Compile(saveProjectWrappertransmitObjectcontactsContactPersonGuid, nameof(saveProjectWrappertransmitObjectcontactsContactPersonGuid), required: false);
            var __workflow_saveProjectWrappertransmitObjectleadsProjectOriginGuid = WorkflowExpression.Compile(saveProjectWrappertransmitObjectleadsProjectOriginGuid, nameof(saveProjectWrappertransmitObjectleadsProjectOriginGuid), required: false);
            var __workflow_saveProjectWrappertransmitObjectprojectsSuperiorProjectGuid = WorkflowExpression.Compile(saveProjectWrappertransmitObjectprojectsSuperiorProjectGuid, nameof(saveProjectWrappertransmitObjectprojectsSuperiorProjectGuid), required: false);
            var __workflow_saveProjectWrappertransmitObjectusersSupervisorGuid = WorkflowExpression.Compile(saveProjectWrappertransmitObjectusersSupervisorGuid, nameof(saveProjectWrappertransmitObjectusersSupervisorGuid), required: false);
            var __workflow_saveProjectWrappertransmitObjectisPrivate = WorkflowExpression.Compile(saveProjectWrappertransmitObjectisPrivate, nameof(saveProjectWrappertransmitObjectisPrivate), required: false);
            var __workflow_saveProjectWrappertransmitObjectitemCreated = WorkflowExpression.Compile(saveProjectWrappertransmitObjectitemCreated, nameof(saveProjectWrappertransmitObjectitemCreated), required: false);
            var __workflow_saveProjectWrappertransmitObjectitemChanged = WorkflowExpression.Compile(saveProjectWrappertransmitObjectitemChanged, nameof(saveProjectWrappertransmitObjectitemChanged), required: false);
            var __workflow_saveProjectWrappertransmitObjectfileAs = WorkflowExpression.Compile(saveProjectWrappertransmitObjectfileAs, nameof(saveProjectWrappertransmitObjectfileAs), required: false);
            var __workflow_saveProjectWrappertransmitObjectownerGUID = WorkflowExpression.Compile(saveProjectWrappertransmitObjectownerGUID, nameof(saveProjectWrappertransmitObjectownerGUID), required: false);
            var __workflow_saveProjectWrappertransmitObjectcreatedByGUID = WorkflowExpression.Compile(saveProjectWrappertransmitObjectcreatedByGUID, nameof(saveProjectWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_saveProjectWrappertransmitObjectmodifiedByGUID = WorkflowExpression.Compile(saveProjectWrappertransmitObjectmodifiedByGUID, nameof(saveProjectWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_saveProjectWrappertransmitObjectadditionalFields = WorkflowExpression.Compile(saveProjectWrappertransmitObjectadditionalFields, nameof(saveProjectWrappertransmitObjectadditionalFields), required: false);
            var __workflow_saveProjectWrappertransmitObjectitemGUID = WorkflowExpression.Compile(saveProjectWrappertransmitObjectitemGUID, nameof(saveProjectWrappertransmitObjectitemGUID), required: false);
            var __workflow_saveProjectWrappertransmitObjectitemVersion = WorkflowExpression.Compile(saveProjectWrappertransmitObjectitemVersion, nameof(saveProjectWrappertransmitObjectitemVersion), required: false);
            var __workflow_saveProjectWrapperdieOnItemConflict = WorkflowExpression.Compile(saveProjectWrapperdieOnItemConflict, nameof(saveProjectWrapperdieOnItemConflict), required: false);
            var __workflow_saveProjectWrapperignoredUserErrorMessages = WorkflowExpression.Compile(saveProjectWrapperignoredUserErrorMessages, nameof(saveProjectWrapperignoredUserErrorMessages), required: false);
            return new DeferredBodyAction<EWayWcfServiceResponsesSaveResponse>(() =>
            {
                var apiCallPath = "/SaveProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var saveProjectWrapper = new JObject();
                var saveProjectWrapperpropCount = 0;
                var transmitObjectObject = new JObject();
                var transmitObjectObjectpropCount = 0;
                if (__workflow_saveProjectWrappertransmitObjectnote != null)
                {
                    transmitObjectObject["Note"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectnote);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectprice != null)
                {
                    transmitObjectObject["Price"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectprice);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectprojectEnd != null)
                {
                    transmitObjectObject["ProjectEnd"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectprojectEnd);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectprojectName != null)
                {
                    transmitObjectObject["ProjectName"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectprojectName);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectpeopleExpenses != null)
                {
                    transmitObjectObject["PeopleExpenses"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectpeopleExpenses);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectprojectRealEnd != null)
                {
                    transmitObjectObject["ProjectRealEnd"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectprojectRealEnd);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectestimatedPrice != null)
                {
                    transmitObjectObject["EstimatedPrice"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectestimatedPrice);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjecthID != null)
                {
                    transmitObjectObject["HID"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjecthID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectprojectOriginEn != null)
                {
                    transmitObjectObject["ProjectOriginEn"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectprojectOriginEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectpaymentTypeEn != null)
                {
                    transmitObjectObject["PaymentTypeEn"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectpaymentTypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectotherExpenses != null)
                {
                    transmitObjectObject["OtherExpenses"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectotherExpenses);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectmargin != null)
                {
                    transmitObjectObject["Margin"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectmargin);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectprofit != null)
                {
                    transmitObjectObject["Profit"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectprofit);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectpaymentMaturity != null)
                {
                    transmitObjectObject["PaymentMaturity"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectpaymentMaturity);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectinvoicePaymentDate != null)
                {
                    transmitObjectObject["InvoicePaymentDate"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectinvoicePaymentDate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectinvoiceIssueDate != null)
                {
                    transmitObjectObject["InvoiceIssueDate"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectinvoiceIssueDate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectestimatedMargin != null)
                {
                    transmitObjectObject["EstimatedMargin"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectestimatedMargin);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectestimatedProfit != null)
                {
                    transmitObjectObject["EstimatedProfit"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectestimatedProfit);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectestimatedPeopleExpenses != null)
                {
                    transmitObjectObject["EstimatedPeopleExpenses"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectestimatedPeopleExpenses);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectestimatedOtherExpenses != null)
                {
                    transmitObjectObject["EstimatedOtherExpenses"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectestimatedOtherExpenses);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectlicensesCount != null)
                {
                    transmitObjectObject["LicensesCount"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectlicensesCount);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectlicensePrice != null)
                {
                    transmitObjectObject["LicensePrice"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectlicensePrice);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectshowInCaplan != null)
                {
                    transmitObjectObject["ShowInCaplan"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectshowInCaplan);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectprojectStart != null)
                {
                    transmitObjectObject["ProjectStart"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectprojectStart);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectestimatedWorkHours != null)
                {
                    transmitObjectObject["EstimatedWorkHours"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectestimatedWorkHours);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjecttotalWorkHours != null)
                {
                    transmitObjectObject["TotalWorkHours"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjecttotalWorkHours);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency != null)
                {
                    transmitObjectObject["EstimatedPeopleExpensesDefaultCurrency"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectestimatedOtherExpensesDefaultCurrency != null)
                {
                    transmitObjectObject["EstimatedOtherExpensesDefaultCurrency"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectestimatedOtherExpensesDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectestimatedPriceDefaultCurrency != null)
                {
                    transmitObjectObject["EstimatedPriceDefaultCurrency"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectestimatedPriceDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectpeopleExpensesDefaultCurrency != null)
                {
                    transmitObjectObject["PeopleExpensesDefaultCurrency"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectpeopleExpensesDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectotherExpensesDefaultCurrency != null)
                {
                    transmitObjectObject["OtherExpensesDefaultCurrency"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectotherExpensesDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectpriceDefaultCurrency != null)
                {
                    transmitObjectObject["PriceDefaultCurrency"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectpriceDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectprofitDefaultCurrency != null)
                {
                    transmitObjectObject["ProfitDefaultCurrency"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectprofitDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectestimatedProfitDefaultCurrency != null)
                {
                    transmitObjectObject["EstimatedProfitDefaultCurrency"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectestimatedProfitDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectcurrencyEn != null)
                {
                    transmitObjectObject["CurrencyEn"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectcurrencyEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectestimatedPeopleExpensesChanged != null)
                {
                    transmitObjectObject["EstimatedPeopleExpensesChanged"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectestimatedPeopleExpensesChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectestimatedOtherExpensesChanged != null)
                {
                    transmitObjectObject["EstimatedOtherExpensesChanged"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectestimatedOtherExpensesChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectotherExpensesChanged != null)
                {
                    transmitObjectObject["OtherExpensesChanged"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectotherExpensesChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectestimatedPriceChanged != null)
                {
                    transmitObjectObject["EstimatedPriceChanged"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectestimatedPriceChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectpriceChanged != null)
                {
                    transmitObjectObject["PriceChanged"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectpriceChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectlicensePriceChanged != null)
                {
                    transmitObjectObject["LicensePriceChanged"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectlicensePriceChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectlicensePriceDefaultCurrency != null)
                {
                    transmitObjectObject["LicensePriceDefaultCurrency"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectlicensePriceDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectlastActivity != null)
                {
                    transmitObjectObject["LastActivity"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectlastActivity);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectnextStep != null)
                {
                    transmitObjectObject["NextStep"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectnextStep);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectpeopleExpensesChanged != null)
                {
                    transmitObjectObject["PeopleExpensesChanged"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectpeopleExpensesChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectpicture != null)
                {
                    transmitObjectObject["Picture"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectpicture);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectpictureWidth != null)
                {
                    transmitObjectObject["PictureWidth"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectpictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectpictureHeight != null)
                {
                    transmitObjectObject["PictureHeight"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectpictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectcompaniesCustomerGuid != null)
                {
                    transmitObjectObject["Companies_CustomerGuid"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectcompaniesCustomerGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectcontactsContactPersonGuid != null)
                {
                    transmitObjectObject["Contacts_ContactPersonGuid"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectcontactsContactPersonGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectleadsProjectOriginGuid != null)
                {
                    transmitObjectObject["Leads_Project_OriginGuid"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectleadsProjectOriginGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectprojectsSuperiorProjectGuid != null)
                {
                    transmitObjectObject["Projects_SuperiorProjectGuid"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectprojectsSuperiorProjectGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectusersSupervisorGuid != null)
                {
                    transmitObjectObject["Users_SupervisorGuid"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectusersSupervisorGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveProjectWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    saveProjectWrapper["transmitObject"] = transmitObjectObject;
                    saveProjectWrapperpropCount++;
                }

                if (__workflow_saveProjectWrapperdieOnItemConflict != null)
                {
                    saveProjectWrapper["dieOnItemConflict"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrapperdieOnItemConflict);
                    saveProjectWrapperpropCount++;
                }

                if (__workflow_saveProjectWrapperignoredUserErrorMessages != null)
                {
                    saveProjectWrapper["ignoredUserErrorMessages"] = ExpressionConverter.ConvertO(__workflow_saveProjectWrapperignoredUserErrorMessages);
                    saveProjectWrapperpropCount++;
                }

                if (saveProjectWrapperpropCount > 0)
                {
                    callPayload.Body = saveProjectWrapper;
                }

                return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesBooleanResponse> SaveRelation(Expression<Func<string>> saveRelationWrappertransmitObjectitemGUID1 = null, Expression<Func<string>> saveRelationWrappertransmitObjectitemGUID2 = null, Expression<Func<saveRelationWrappertransmitObjectfolderName1Input>> saveRelationWrappertransmitObjectfolderName1 = null, Expression<Func<saveRelationWrappertransmitObjectfolderName2Input>> saveRelationWrappertransmitObjectfolderName2 = null)
        {
            var __workflow_saveRelationWrappertransmitObjectitemGUID1 = WorkflowExpression.Compile(saveRelationWrappertransmitObjectitemGUID1, nameof(saveRelationWrappertransmitObjectitemGUID1), required: false);
            var __workflow_saveRelationWrappertransmitObjectitemGUID2 = WorkflowExpression.Compile(saveRelationWrappertransmitObjectitemGUID2, nameof(saveRelationWrappertransmitObjectitemGUID2), required: false);
            var __workflow_saveRelationWrappertransmitObjectfolderName1 = WorkflowExpression.Compile(saveRelationWrappertransmitObjectfolderName1, nameof(saveRelationWrappertransmitObjectfolderName1), required: false);
            var __workflow_saveRelationWrappertransmitObjectfolderName2 = WorkflowExpression.Compile(saveRelationWrappertransmitObjectfolderName2, nameof(saveRelationWrappertransmitObjectfolderName2), required: false);
            return new DeferredBodyAction<EWayWcfServiceResponsesBooleanResponse>(() =>
            {
                var apiCallPath = "/SaveRelation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var saveRelationWrapper = new JObject();
                var saveRelationWrapperpropCount = 0;
                var transmitObjectObject = new JObject();
                var transmitObjectObjectpropCount = 0;
                if (__workflow_saveRelationWrappertransmitObjectitemGUID1 != null)
                {
                    transmitObjectObject["ItemGUID1"] = ExpressionConverter.ConvertO(__workflow_saveRelationWrappertransmitObjectitemGUID1);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveRelationWrappertransmitObjectitemGUID2 != null)
                {
                    transmitObjectObject["ItemGUID2"] = ExpressionConverter.ConvertO(__workflow_saveRelationWrappertransmitObjectitemGUID2);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveRelationWrappertransmitObjectfolderName1 != null)
                {
                    transmitObjectObject["FolderName1"] = ExpressionConverter.ConvertO(__workflow_saveRelationWrappertransmitObjectfolderName1);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveRelationWrappertransmitObjectfolderName2 != null)
                {
                    transmitObjectObject["FolderName2"] = ExpressionConverter.ConvertO(__workflow_saveRelationWrappertransmitObjectfolderName2);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesSaveResponse> SaveTask(Expression<Func<string>> saveTaskWrappertransmitObjectbody = null, Expression<Func<bool>> saveTaskWrappertransmitObjectisCompleted = null, Expression<Func<string>> saveTaskWrappertransmitObjectdueDate = null, Expression<Func<double>> saveTaskWrappertransmitObjectpercentCompleteDecimal = null, Expression<Func<string>> saveTaskWrappertransmitObjectprevStateEn = null, Expression<Func<string>> saveTaskWrappertransmitObjectstartDate = null, Expression<Func<string>> saveTaskWrappertransmitObjectstateEn = null, Expression<Func<string>> saveTaskWrappertransmitObjectsubject = null, Expression<Func<string>> saveTaskWrappertransmitObjecttypeEn = null, Expression<Func<int>> saveTaskWrappertransmitObjectlevel = null, Expression<Func<string>> saveTaskWrappertransmitObjectimportanceEn = null, Expression<Func<double>> saveTaskWrappertransmitObjectactualWorkHours = null, Expression<Func<double>> saveTaskWrappertransmitObjectestimatedWorkHours = null, Expression<Func<bool>> saveTaskWrappertransmitObjectisReminderSet = null, Expression<Func<string>> saveTaskWrappertransmitObjectreminderDate = null, Expression<Func<string>> saveTaskWrappertransmitObjectcompletedDate = null, Expression<Func<string>> saveTaskWrappertransmitObjectpicture = null, Expression<Func<int>> saveTaskWrappertransmitObjectpictureWidth = null, Expression<Func<int>> saveTaskWrappertransmitObjectpictureHeight = null, Expression<Func<string>> saveTaskWrappertransmitObjectleadsTaskParentGuid = null, Expression<Func<string>> saveTaskWrappertransmitObjectprojectsTaskParentGuid = null, Expression<Func<string>> saveTaskWrappertransmitObjecttasksTaskParentGuid = null, Expression<Func<string>> saveTaskWrappertransmitObjectmarketingTaskParentGuid = null, Expression<Func<string>> saveTaskWrappertransmitObjectcompaniesCompanyGuid = null, Expression<Func<string>> saveTaskWrappertransmitObjectcontactsContactGuid = null, Expression<Func<string>> saveTaskWrappertransmitObjectusersTaskDelegatorGuid = null, Expression<Func<string>> saveTaskWrappertransmitObjectusersTaskSolverGuid = null, Expression<Func<string>> saveTaskWrappertransmitObjecttasksTaskOriginGuid = null, Expression<Func<bool>> saveTaskWrappertransmitObjectisPrivate = null, Expression<Func<string>> saveTaskWrappertransmitObjectitemCreated = null, Expression<Func<string>> saveTaskWrappertransmitObjectitemChanged = null, Expression<Func<string>> saveTaskWrappertransmitObjectfileAs = null, Expression<Func<string>> saveTaskWrappertransmitObjectownerGUID = null, Expression<Func<string>> saveTaskWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> saveTaskWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> saveTaskWrappertransmitObjectadditionalFields = null, Expression<Func<string>> saveTaskWrappertransmitObjectitemGUID = null, Expression<Func<int>> saveTaskWrappertransmitObjectitemVersion = null, Expression<Func<bool>> saveTaskWrapperdieOnItemConflict = null, Expression<Func<string[]>> saveTaskWrapperignoredUserErrorMessages = null)
        {
            var __workflow_saveTaskWrappertransmitObjectbody = WorkflowExpression.Compile(saveTaskWrappertransmitObjectbody, nameof(saveTaskWrappertransmitObjectbody), required: false);
            var __workflow_saveTaskWrappertransmitObjectisCompleted = WorkflowExpression.Compile(saveTaskWrappertransmitObjectisCompleted, nameof(saveTaskWrappertransmitObjectisCompleted), required: false);
            var __workflow_saveTaskWrappertransmitObjectdueDate = WorkflowExpression.Compile(saveTaskWrappertransmitObjectdueDate, nameof(saveTaskWrappertransmitObjectdueDate), required: false);
            var __workflow_saveTaskWrappertransmitObjectpercentCompleteDecimal = WorkflowExpression.Compile(saveTaskWrappertransmitObjectpercentCompleteDecimal, nameof(saveTaskWrappertransmitObjectpercentCompleteDecimal), required: false);
            var __workflow_saveTaskWrappertransmitObjectprevStateEn = WorkflowExpression.Compile(saveTaskWrappertransmitObjectprevStateEn, nameof(saveTaskWrappertransmitObjectprevStateEn), required: false);
            var __workflow_saveTaskWrappertransmitObjectstartDate = WorkflowExpression.Compile(saveTaskWrappertransmitObjectstartDate, nameof(saveTaskWrappertransmitObjectstartDate), required: false);
            var __workflow_saveTaskWrappertransmitObjectstateEn = WorkflowExpression.Compile(saveTaskWrappertransmitObjectstateEn, nameof(saveTaskWrappertransmitObjectstateEn), required: false);
            var __workflow_saveTaskWrappertransmitObjectsubject = WorkflowExpression.Compile(saveTaskWrappertransmitObjectsubject, nameof(saveTaskWrappertransmitObjectsubject), required: false);
            var __workflow_saveTaskWrappertransmitObjecttypeEn = WorkflowExpression.Compile(saveTaskWrappertransmitObjecttypeEn, nameof(saveTaskWrappertransmitObjecttypeEn), required: false);
            var __workflow_saveTaskWrappertransmitObjectlevel = WorkflowExpression.Compile(saveTaskWrappertransmitObjectlevel, nameof(saveTaskWrappertransmitObjectlevel), required: false);
            var __workflow_saveTaskWrappertransmitObjectimportanceEn = WorkflowExpression.Compile(saveTaskWrappertransmitObjectimportanceEn, nameof(saveTaskWrappertransmitObjectimportanceEn), required: false);
            var __workflow_saveTaskWrappertransmitObjectactualWorkHours = WorkflowExpression.Compile(saveTaskWrappertransmitObjectactualWorkHours, nameof(saveTaskWrappertransmitObjectactualWorkHours), required: false);
            var __workflow_saveTaskWrappertransmitObjectestimatedWorkHours = WorkflowExpression.Compile(saveTaskWrappertransmitObjectestimatedWorkHours, nameof(saveTaskWrappertransmitObjectestimatedWorkHours), required: false);
            var __workflow_saveTaskWrappertransmitObjectisReminderSet = WorkflowExpression.Compile(saveTaskWrappertransmitObjectisReminderSet, nameof(saveTaskWrappertransmitObjectisReminderSet), required: false);
            var __workflow_saveTaskWrappertransmitObjectreminderDate = WorkflowExpression.Compile(saveTaskWrappertransmitObjectreminderDate, nameof(saveTaskWrappertransmitObjectreminderDate), required: false);
            var __workflow_saveTaskWrappertransmitObjectcompletedDate = WorkflowExpression.Compile(saveTaskWrappertransmitObjectcompletedDate, nameof(saveTaskWrappertransmitObjectcompletedDate), required: false);
            var __workflow_saveTaskWrappertransmitObjectpicture = WorkflowExpression.Compile(saveTaskWrappertransmitObjectpicture, nameof(saveTaskWrappertransmitObjectpicture), required: false);
            var __workflow_saveTaskWrappertransmitObjectpictureWidth = WorkflowExpression.Compile(saveTaskWrappertransmitObjectpictureWidth, nameof(saveTaskWrappertransmitObjectpictureWidth), required: false);
            var __workflow_saveTaskWrappertransmitObjectpictureHeight = WorkflowExpression.Compile(saveTaskWrappertransmitObjectpictureHeight, nameof(saveTaskWrappertransmitObjectpictureHeight), required: false);
            var __workflow_saveTaskWrappertransmitObjectleadsTaskParentGuid = WorkflowExpression.Compile(saveTaskWrappertransmitObjectleadsTaskParentGuid, nameof(saveTaskWrappertransmitObjectleadsTaskParentGuid), required: false);
            var __workflow_saveTaskWrappertransmitObjectprojectsTaskParentGuid = WorkflowExpression.Compile(saveTaskWrappertransmitObjectprojectsTaskParentGuid, nameof(saveTaskWrappertransmitObjectprojectsTaskParentGuid), required: false);
            var __workflow_saveTaskWrappertransmitObjecttasksTaskParentGuid = WorkflowExpression.Compile(saveTaskWrappertransmitObjecttasksTaskParentGuid, nameof(saveTaskWrappertransmitObjecttasksTaskParentGuid), required: false);
            var __workflow_saveTaskWrappertransmitObjectmarketingTaskParentGuid = WorkflowExpression.Compile(saveTaskWrappertransmitObjectmarketingTaskParentGuid, nameof(saveTaskWrappertransmitObjectmarketingTaskParentGuid), required: false);
            var __workflow_saveTaskWrappertransmitObjectcompaniesCompanyGuid = WorkflowExpression.Compile(saveTaskWrappertransmitObjectcompaniesCompanyGuid, nameof(saveTaskWrappertransmitObjectcompaniesCompanyGuid), required: false);
            var __workflow_saveTaskWrappertransmitObjectcontactsContactGuid = WorkflowExpression.Compile(saveTaskWrappertransmitObjectcontactsContactGuid, nameof(saveTaskWrappertransmitObjectcontactsContactGuid), required: false);
            var __workflow_saveTaskWrappertransmitObjectusersTaskDelegatorGuid = WorkflowExpression.Compile(saveTaskWrappertransmitObjectusersTaskDelegatorGuid, nameof(saveTaskWrappertransmitObjectusersTaskDelegatorGuid), required: false);
            var __workflow_saveTaskWrappertransmitObjectusersTaskSolverGuid = WorkflowExpression.Compile(saveTaskWrappertransmitObjectusersTaskSolverGuid, nameof(saveTaskWrappertransmitObjectusersTaskSolverGuid), required: false);
            var __workflow_saveTaskWrappertransmitObjecttasksTaskOriginGuid = WorkflowExpression.Compile(saveTaskWrappertransmitObjecttasksTaskOriginGuid, nameof(saveTaskWrappertransmitObjecttasksTaskOriginGuid), required: false);
            var __workflow_saveTaskWrappertransmitObjectisPrivate = WorkflowExpression.Compile(saveTaskWrappertransmitObjectisPrivate, nameof(saveTaskWrappertransmitObjectisPrivate), required: false);
            var __workflow_saveTaskWrappertransmitObjectitemCreated = WorkflowExpression.Compile(saveTaskWrappertransmitObjectitemCreated, nameof(saveTaskWrappertransmitObjectitemCreated), required: false);
            var __workflow_saveTaskWrappertransmitObjectitemChanged = WorkflowExpression.Compile(saveTaskWrappertransmitObjectitemChanged, nameof(saveTaskWrappertransmitObjectitemChanged), required: false);
            var __workflow_saveTaskWrappertransmitObjectfileAs = WorkflowExpression.Compile(saveTaskWrappertransmitObjectfileAs, nameof(saveTaskWrappertransmitObjectfileAs), required: false);
            var __workflow_saveTaskWrappertransmitObjectownerGUID = WorkflowExpression.Compile(saveTaskWrappertransmitObjectownerGUID, nameof(saveTaskWrappertransmitObjectownerGUID), required: false);
            var __workflow_saveTaskWrappertransmitObjectcreatedByGUID = WorkflowExpression.Compile(saveTaskWrappertransmitObjectcreatedByGUID, nameof(saveTaskWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_saveTaskWrappertransmitObjectmodifiedByGUID = WorkflowExpression.Compile(saveTaskWrappertransmitObjectmodifiedByGUID, nameof(saveTaskWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_saveTaskWrappertransmitObjectadditionalFields = WorkflowExpression.Compile(saveTaskWrappertransmitObjectadditionalFields, nameof(saveTaskWrappertransmitObjectadditionalFields), required: false);
            var __workflow_saveTaskWrappertransmitObjectitemGUID = WorkflowExpression.Compile(saveTaskWrappertransmitObjectitemGUID, nameof(saveTaskWrappertransmitObjectitemGUID), required: false);
            var __workflow_saveTaskWrappertransmitObjectitemVersion = WorkflowExpression.Compile(saveTaskWrappertransmitObjectitemVersion, nameof(saveTaskWrappertransmitObjectitemVersion), required: false);
            var __workflow_saveTaskWrapperdieOnItemConflict = WorkflowExpression.Compile(saveTaskWrapperdieOnItemConflict, nameof(saveTaskWrapperdieOnItemConflict), required: false);
            var __workflow_saveTaskWrapperignoredUserErrorMessages = WorkflowExpression.Compile(saveTaskWrapperignoredUserErrorMessages, nameof(saveTaskWrapperignoredUserErrorMessages), required: false);
            return new DeferredBodyAction<EWayWcfServiceResponsesSaveResponse>(() =>
            {
                var apiCallPath = "/SaveTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var saveTaskWrapper = new JObject();
                var saveTaskWrapperpropCount = 0;
                var transmitObjectObject = new JObject();
                var transmitObjectObjectpropCount = 0;
                if (__workflow_saveTaskWrappertransmitObjectbody != null)
                {
                    transmitObjectObject["Body"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectbody);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectisCompleted != null)
                {
                    transmitObjectObject["IsCompleted"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectisCompleted);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectdueDate != null)
                {
                    transmitObjectObject["DueDate"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectdueDate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectpercentCompleteDecimal != null)
                {
                    transmitObjectObject["PercentCompleteDecimal"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectpercentCompleteDecimal);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectstartDate != null)
                {
                    transmitObjectObject["StartDate"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectstartDate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectsubject != null)
                {
                    transmitObjectObject["Subject"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectsubject);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectlevel != null)
                {
                    transmitObjectObject["Level"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectlevel);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectimportanceEn != null)
                {
                    transmitObjectObject["ImportanceEn"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectimportanceEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectactualWorkHours != null)
                {
                    transmitObjectObject["ActualWorkHours"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectactualWorkHours);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectestimatedWorkHours != null)
                {
                    transmitObjectObject["EstimatedWorkHours"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectestimatedWorkHours);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectisReminderSet != null)
                {
                    transmitObjectObject["IsReminderSet"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectisReminderSet);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectreminderDate != null)
                {
                    transmitObjectObject["ReminderDate"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectreminderDate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectcompletedDate != null)
                {
                    transmitObjectObject["CompletedDate"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectcompletedDate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectpicture != null)
                {
                    transmitObjectObject["Picture"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectpicture);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectpictureWidth != null)
                {
                    transmitObjectObject["PictureWidth"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectpictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectpictureHeight != null)
                {
                    transmitObjectObject["PictureHeight"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectpictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectleadsTaskParentGuid != null)
                {
                    transmitObjectObject["Leads_TaskParentGuid"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectleadsTaskParentGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectprojectsTaskParentGuid != null)
                {
                    transmitObjectObject["Projects_TaskParentGuid"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectprojectsTaskParentGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjecttasksTaskParentGuid != null)
                {
                    transmitObjectObject["Tasks_TaskParentGuid"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjecttasksTaskParentGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectmarketingTaskParentGuid != null)
                {
                    transmitObjectObject["Marketing_TaskParentGuid"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectmarketingTaskParentGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectcompaniesCompanyGuid != null)
                {
                    transmitObjectObject["Companies_CompanyGuid"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectcompaniesCompanyGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectcontactsContactGuid != null)
                {
                    transmitObjectObject["Contacts_ContactGuid"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectcontactsContactGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectusersTaskDelegatorGuid != null)
                {
                    transmitObjectObject["Users_TaskDelegatorGuid"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectusersTaskDelegatorGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectusersTaskSolverGuid != null)
                {
                    transmitObjectObject["Users_TaskSolverGuid"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectusersTaskSolverGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjecttasksTaskOriginGuid != null)
                {
                    transmitObjectObject["Tasks_TaskOriginGuid"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjecttasksTaskOriginGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_saveTaskWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    saveTaskWrapper["transmitObject"] = transmitObjectObject;
                    saveTaskWrapperpropCount++;
                }

                if (__workflow_saveTaskWrapperdieOnItemConflict != null)
                {
                    saveTaskWrapper["dieOnItemConflict"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrapperdieOnItemConflict);
                    saveTaskWrapperpropCount++;
                }

                if (__workflow_saveTaskWrapperignoredUserErrorMessages != null)
                {
                    saveTaskWrapper["ignoredUserErrorMessages"] = ExpressionConverter.ConvertO(__workflow_saveTaskWrapperignoredUserErrorMessages);
                    saveTaskWrapperpropCount++;
                }

                if (saveTaskWrapperpropCount > 0)
                {
                    callPayload.Body = saveTaskWrapper;
                }

                return new ApiConnectionAction<EWayWcfServiceResponsesSaveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany> SearchCompanies(Expression<Func<string>> searchCompaniesWrappertransmitObjectaccountNumber = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress1POBox = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress1Street = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress1City = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress1State = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress1CountryEn = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress1PostalCode = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress2POBox = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress2Street = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress2City = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress2State = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress2CountryEn = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress2PostalCode = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress3POBox = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress3Street = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress3City = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress3State = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress3CountryEn = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectaddress3PostalCode = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectcompanyName = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectdepartment = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectemail = null, Expression<Func<int>> searchCompaniesWrappertransmitObjectemployeesCount = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectfax = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectfirstContactEn = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectiCQ = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectidentificationNumber = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectimportanceEn = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectlineOfBusiness = null, Expression<Func<bool>> searchCompaniesWrappertransmitObjectmailingListOther = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectmobile = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectmobileNormalized = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectmSN = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectnote = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectphone = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectphoneNormalized = null, Expression<Func<bool>> searchCompaniesWrappertransmitObjectpurchaser = null, Expression<Func<double>> searchCompaniesWrappertransmitObjectreversal = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectskype = null, Expression<Func<bool>> searchCompaniesWrappertransmitObjectsuppliers = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectvATNumber = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectwebPage = null, Expression<Func<double>> searchCompaniesWrappertransmitObjectadditionalDiscount = null, Expression<Func<int>> searchCompaniesWrappertransmitObjectiD = null, Expression<Func<bool>> searchCompaniesWrappertransmitObjectcompetitor = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectsalePriceGuid = null, Expression<Func<bool>> searchCompaniesWrappertransmitObjectnotificationByEmail = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectnotificationBy = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectlastActivity = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectnextStep = null, Expression<Func<bool>> searchCompaniesWrappertransmitObjectemailOptOut = null, Expression<Func<string>> searchCompaniesWrappertransmitObjecttypeEn = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectstateEn = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectprevStateEn = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectpicture = null, Expression<Func<int>> searchCompaniesWrappertransmitObjectpictureWidth = null, Expression<Func<int>> searchCompaniesWrappertransmitObjectpictureHeight = null, Expression<Func<bool>> searchCompaniesWrappertransmitObjectisPrivate = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectserverItemCreated = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectserverItemChanged = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectitemCreated = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectitemChanged = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectfileAs = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectownerGUID = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> searchCompaniesWrappertransmitObjectadditionalFields = null, Expression<Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]>> searchCompaniesWrappertransmitObjectrelations = null, Expression<Func<string>> searchCompaniesWrappertransmitObjectitemGUID = null, Expression<Func<int>> searchCompaniesWrappertransmitObjectitemVersion = null, Expression<Func<bool>> searchCompaniesWrapperincludeRelations = null, Expression<Func<string>> searchCompaniesWrapperrelationsFilterrelationType = null, Expression<Func<string>> searchCompaniesWrapperrelationsFilterforeignFolderName = null, Expression<Func<string>> searchCompaniesWrapperbinaryLogicalOperator = null)
        {
            var __workflow_searchCompaniesWrappertransmitObjectaccountNumber = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaccountNumber, nameof(searchCompaniesWrappertransmitObjectaccountNumber), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress1POBox = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress1POBox, nameof(searchCompaniesWrappertransmitObjectaddress1POBox), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress1Street = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress1Street, nameof(searchCompaniesWrappertransmitObjectaddress1Street), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress1City = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress1City, nameof(searchCompaniesWrappertransmitObjectaddress1City), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress1State = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress1State, nameof(searchCompaniesWrappertransmitObjectaddress1State), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress1CountryEn = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress1CountryEn, nameof(searchCompaniesWrappertransmitObjectaddress1CountryEn), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress1PostalCode = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress1PostalCode, nameof(searchCompaniesWrappertransmitObjectaddress1PostalCode), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress2POBox = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress2POBox, nameof(searchCompaniesWrappertransmitObjectaddress2POBox), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress2Street = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress2Street, nameof(searchCompaniesWrappertransmitObjectaddress2Street), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress2City = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress2City, nameof(searchCompaniesWrappertransmitObjectaddress2City), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress2State = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress2State, nameof(searchCompaniesWrappertransmitObjectaddress2State), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress2CountryEn = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress2CountryEn, nameof(searchCompaniesWrappertransmitObjectaddress2CountryEn), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress2PostalCode = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress2PostalCode, nameof(searchCompaniesWrappertransmitObjectaddress2PostalCode), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress3POBox = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress3POBox, nameof(searchCompaniesWrappertransmitObjectaddress3POBox), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress3Street = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress3Street, nameof(searchCompaniesWrappertransmitObjectaddress3Street), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress3City = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress3City, nameof(searchCompaniesWrappertransmitObjectaddress3City), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress3State = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress3State, nameof(searchCompaniesWrappertransmitObjectaddress3State), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress3CountryEn = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress3CountryEn, nameof(searchCompaniesWrappertransmitObjectaddress3CountryEn), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress3PostalCode = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress3PostalCode, nameof(searchCompaniesWrappertransmitObjectaddress3PostalCode), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectcompanyName = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectcompanyName, nameof(searchCompaniesWrappertransmitObjectcompanyName), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectdepartment = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectdepartment, nameof(searchCompaniesWrappertransmitObjectdepartment), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectemail = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectemail, nameof(searchCompaniesWrappertransmitObjectemail), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectemployeesCount = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectemployeesCount, nameof(searchCompaniesWrappertransmitObjectemployeesCount), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectfax = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectfax, nameof(searchCompaniesWrappertransmitObjectfax), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectfirstContactEn = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectfirstContactEn, nameof(searchCompaniesWrappertransmitObjectfirstContactEn), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectiCQ = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectiCQ, nameof(searchCompaniesWrappertransmitObjectiCQ), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectidentificationNumber = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectidentificationNumber, nameof(searchCompaniesWrappertransmitObjectidentificationNumber), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectimportanceEn = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectimportanceEn, nameof(searchCompaniesWrappertransmitObjectimportanceEn), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectlineOfBusiness = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectlineOfBusiness, nameof(searchCompaniesWrappertransmitObjectlineOfBusiness), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectmailingListOther = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectmailingListOther, nameof(searchCompaniesWrappertransmitObjectmailingListOther), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectmobile = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectmobile, nameof(searchCompaniesWrappertransmitObjectmobile), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectmobileNormalized = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectmobileNormalized, nameof(searchCompaniesWrappertransmitObjectmobileNormalized), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectmSN = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectmSN, nameof(searchCompaniesWrappertransmitObjectmSN), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectnote = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectnote, nameof(searchCompaniesWrappertransmitObjectnote), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectphone = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectphone, nameof(searchCompaniesWrappertransmitObjectphone), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectphoneNormalized = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectphoneNormalized, nameof(searchCompaniesWrappertransmitObjectphoneNormalized), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectpurchaser = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectpurchaser, nameof(searchCompaniesWrappertransmitObjectpurchaser), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectreversal = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectreversal, nameof(searchCompaniesWrappertransmitObjectreversal), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectskype = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectskype, nameof(searchCompaniesWrappertransmitObjectskype), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectsuppliers = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectsuppliers, nameof(searchCompaniesWrappertransmitObjectsuppliers), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectvATNumber = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectvATNumber, nameof(searchCompaniesWrappertransmitObjectvATNumber), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectwebPage = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectwebPage, nameof(searchCompaniesWrappertransmitObjectwebPage), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectadditionalDiscount = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectadditionalDiscount, nameof(searchCompaniesWrappertransmitObjectadditionalDiscount), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectiD = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectiD, nameof(searchCompaniesWrappertransmitObjectiD), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectcompetitor = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectcompetitor, nameof(searchCompaniesWrappertransmitObjectcompetitor), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectsalePriceGuid = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectsalePriceGuid, nameof(searchCompaniesWrappertransmitObjectsalePriceGuid), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectnotificationByEmail = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectnotificationByEmail, nameof(searchCompaniesWrappertransmitObjectnotificationByEmail), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectnotificationBy = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectnotificationBy, nameof(searchCompaniesWrappertransmitObjectnotificationBy), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectlastActivity = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectlastActivity, nameof(searchCompaniesWrappertransmitObjectlastActivity), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectnextStep = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectnextStep, nameof(searchCompaniesWrappertransmitObjectnextStep), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectemailOptOut = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectemailOptOut, nameof(searchCompaniesWrappertransmitObjectemailOptOut), required: false);
            var __workflow_searchCompaniesWrappertransmitObjecttypeEn = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjecttypeEn, nameof(searchCompaniesWrappertransmitObjecttypeEn), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectstateEn = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectstateEn, nameof(searchCompaniesWrappertransmitObjectstateEn), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectprevStateEn = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectprevStateEn, nameof(searchCompaniesWrappertransmitObjectprevStateEn), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectpicture = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectpicture, nameof(searchCompaniesWrappertransmitObjectpicture), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectpictureWidth = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectpictureWidth, nameof(searchCompaniesWrappertransmitObjectpictureWidth), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectpictureHeight = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectpictureHeight, nameof(searchCompaniesWrappertransmitObjectpictureHeight), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectisPrivate = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectisPrivate, nameof(searchCompaniesWrappertransmitObjectisPrivate), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectserverItemCreated = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectserverItemCreated, nameof(searchCompaniesWrappertransmitObjectserverItemCreated), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectserverItemChanged = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectserverItemChanged, nameof(searchCompaniesWrappertransmitObjectserverItemChanged), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectitemCreated = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectitemCreated, nameof(searchCompaniesWrappertransmitObjectitemCreated), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectitemChanged = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectitemChanged, nameof(searchCompaniesWrappertransmitObjectitemChanged), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectfileAs = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectfileAs, nameof(searchCompaniesWrappertransmitObjectfileAs), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectownerGUID = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectownerGUID, nameof(searchCompaniesWrappertransmitObjectownerGUID), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectcreatedByGUID = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectcreatedByGUID, nameof(searchCompaniesWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectmodifiedByGUID = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectmodifiedByGUID, nameof(searchCompaniesWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectadditionalFields = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectadditionalFields, nameof(searchCompaniesWrappertransmitObjectadditionalFields), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectrelations = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectrelations, nameof(searchCompaniesWrappertransmitObjectrelations), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectitemGUID = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectitemGUID, nameof(searchCompaniesWrappertransmitObjectitemGUID), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectitemVersion = WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectitemVersion, nameof(searchCompaniesWrappertransmitObjectitemVersion), required: false);
            var __workflow_searchCompaniesWrapperincludeRelations = WorkflowExpression.Compile(searchCompaniesWrapperincludeRelations, nameof(searchCompaniesWrapperincludeRelations), required: false);
            var __workflow_searchCompaniesWrapperrelationsFilterrelationType = WorkflowExpression.Compile(searchCompaniesWrapperrelationsFilterrelationType, nameof(searchCompaniesWrapperrelationsFilterrelationType), required: false);
            var __workflow_searchCompaniesWrapperrelationsFilterforeignFolderName = WorkflowExpression.Compile(searchCompaniesWrapperrelationsFilterforeignFolderName, nameof(searchCompaniesWrapperrelationsFilterforeignFolderName), required: false);
            var __workflow_searchCompaniesWrapperbinaryLogicalOperator = WorkflowExpression.Compile(searchCompaniesWrapperbinaryLogicalOperator, nameof(searchCompaniesWrapperbinaryLogicalOperator), required: false);
            return new DeferredBodyAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany>(() =>
            {
                var apiCallPath = "/SearchCompanies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var searchCompaniesWrapper = new JObject();
                var searchCompaniesWrapperpropCount = 0;
                var transmitObjectObject = new JObject();
                var transmitObjectObjectpropCount = 0;
                if (__workflow_searchCompaniesWrappertransmitObjectaccountNumber != null)
                {
                    transmitObjectObject["AccountNumber"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectaccountNumber);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectaddress1POBox != null)
                {
                    transmitObjectObject["Address1POBox"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectaddress1POBox);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectaddress1Street != null)
                {
                    transmitObjectObject["Address1Street"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectaddress1Street);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectaddress1City != null)
                {
                    transmitObjectObject["Address1City"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectaddress1City);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectaddress1State != null)
                {
                    transmitObjectObject["Address1State"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectaddress1State);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectaddress1CountryEn != null)
                {
                    transmitObjectObject["Address1CountryEn"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectaddress1CountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectaddress1PostalCode != null)
                {
                    transmitObjectObject["Address1PostalCode"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectaddress1PostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectaddress2POBox != null)
                {
                    transmitObjectObject["Address2POBox"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectaddress2POBox);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectaddress2Street != null)
                {
                    transmitObjectObject["Address2Street"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectaddress2Street);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectaddress2City != null)
                {
                    transmitObjectObject["Address2City"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectaddress2City);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectaddress2State != null)
                {
                    transmitObjectObject["Address2State"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectaddress2State);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectaddress2CountryEn != null)
                {
                    transmitObjectObject["Address2CountryEn"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectaddress2CountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectaddress2PostalCode != null)
                {
                    transmitObjectObject["Address2PostalCode"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectaddress2PostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectaddress3POBox != null)
                {
                    transmitObjectObject["Address3POBox"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectaddress3POBox);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectaddress3Street != null)
                {
                    transmitObjectObject["Address3Street"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectaddress3Street);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectaddress3City != null)
                {
                    transmitObjectObject["Address3City"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectaddress3City);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectaddress3State != null)
                {
                    transmitObjectObject["Address3State"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectaddress3State);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectaddress3CountryEn != null)
                {
                    transmitObjectObject["Address3CountryEn"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectaddress3CountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectaddress3PostalCode != null)
                {
                    transmitObjectObject["Address3PostalCode"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectaddress3PostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectcompanyName != null)
                {
                    transmitObjectObject["CompanyName"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectcompanyName);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectdepartment != null)
                {
                    transmitObjectObject["Department"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectdepartment);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectemail != null)
                {
                    transmitObjectObject["Email"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectemail);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectemployeesCount != null)
                {
                    transmitObjectObject["EmployeesCount"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectemployeesCount);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectfax != null)
                {
                    transmitObjectObject["Fax"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectfax);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectfirstContactEn != null)
                {
                    transmitObjectObject["FirstContactEn"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectfirstContactEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectiCQ != null)
                {
                    transmitObjectObject["ICQ"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectiCQ);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectidentificationNumber != null)
                {
                    transmitObjectObject["IdentificationNumber"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectidentificationNumber);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectimportanceEn != null)
                {
                    transmitObjectObject["ImportanceEn"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectimportanceEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectlineOfBusiness != null)
                {
                    transmitObjectObject["LineOfBusiness"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectlineOfBusiness);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectmailingListOther != null)
                {
                    transmitObjectObject["MailingListOther"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectmailingListOther);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectmobile != null)
                {
                    transmitObjectObject["Mobile"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectmobile);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectmobileNormalized != null)
                {
                    transmitObjectObject["MobileNormalized"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectmobileNormalized);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectmSN != null)
                {
                    transmitObjectObject["MSN"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectmSN);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectnote != null)
                {
                    transmitObjectObject["Note"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectnote);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectphone != null)
                {
                    transmitObjectObject["Phone"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectphone);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectphoneNormalized != null)
                {
                    transmitObjectObject["PhoneNormalized"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectphoneNormalized);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectpurchaser != null)
                {
                    transmitObjectObject["Purchaser"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectpurchaser);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectreversal != null)
                {
                    transmitObjectObject["Reversal"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectreversal);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectskype != null)
                {
                    transmitObjectObject["Skype"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectskype);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectsuppliers != null)
                {
                    transmitObjectObject["Suppliers"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectsuppliers);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectvATNumber != null)
                {
                    transmitObjectObject["VATNumber"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectvATNumber);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectwebPage != null)
                {
                    transmitObjectObject["WebPage"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectwebPage);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectadditionalDiscount != null)
                {
                    transmitObjectObject["AdditionalDiscount"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectadditionalDiscount);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectiD != null)
                {
                    transmitObjectObject["ID"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectiD);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectcompetitor != null)
                {
                    transmitObjectObject["Competitor"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectcompetitor);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectsalePriceGuid != null)
                {
                    transmitObjectObject["SalePriceGuid"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectsalePriceGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectnotificationByEmail != null)
                {
                    transmitObjectObject["NotificationByEmail"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectnotificationByEmail);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectnotificationBy != null)
                {
                    transmitObjectObject["NotificationBy"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectnotificationBy);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectlastActivity != null)
                {
                    transmitObjectObject["LastActivity"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectlastActivity);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectnextStep != null)
                {
                    transmitObjectObject["NextStep"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectnextStep);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectemailOptOut != null)
                {
                    transmitObjectObject["EmailOptOut"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectemailOptOut);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectpicture != null)
                {
                    transmitObjectObject["Picture"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectpicture);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectpictureWidth != null)
                {
                    transmitObjectObject["PictureWidth"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectpictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectpictureHeight != null)
                {
                    transmitObjectObject["PictureHeight"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectpictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectserverItemCreated != null)
                {
                    transmitObjectObject["Server_ItemCreated"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectserverItemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectserverItemChanged != null)
                {
                    transmitObjectObject["Server_ItemChanged"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectserverItemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectrelations != null)
                {
                    transmitObjectObject["Relations"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectrelations);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    searchCompaniesWrapper["transmitObject"] = transmitObjectObject;
                    searchCompaniesWrapperpropCount++;
                }

                if (__workflow_searchCompaniesWrapperincludeRelations != null)
                {
                    searchCompaniesWrapper["includeRelations"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrapperincludeRelations);
                    searchCompaniesWrapperpropCount++;
                }

                var relationsFilterObject = new JObject();
                var relationsFilterObjectpropCount = 0;
                if (__workflow_searchCompaniesWrapperrelationsFilterrelationType != null)
                {
                    relationsFilterObject["RelationType"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrapperrelationsFilterrelationType);
                    relationsFilterObjectpropCount++;
                }

                if (__workflow_searchCompaniesWrapperrelationsFilterforeignFolderName != null)
                {
                    relationsFilterObject["ForeignFolderName"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrapperrelationsFilterforeignFolderName);
                    relationsFilterObjectpropCount++;
                }

                if (relationsFilterObjectpropCount > 0)
                {
                    searchCompaniesWrapper["relationsFilter"] = relationsFilterObject;
                    searchCompaniesWrapperpropCount++;
                }

                if (__workflow_searchCompaniesWrapperbinaryLogicalOperator != null)
                {
                    searchCompaniesWrapper["binaryLogicalOperator"] = ExpressionConverter.ConvertO(__workflow_searchCompaniesWrapperbinaryLogicalOperator);
                    searchCompaniesWrapperpropCount++;
                }

                if (searchCompaniesWrapperpropCount > 0)
                {
                    callPayload.Body = searchCompaniesWrapper;
                }

                return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact> SearchContacts(Expression<Func<string>> searchContactsWrappertransmitObjectcompaniesCompanyGuid = null, Expression<Func<string>> searchContactsWrappertransmitObjectbusinessAddressStreet = null, Expression<Func<string>> searchContactsWrappertransmitObjectbusinessAddressCity = null, Expression<Func<string>> searchContactsWrappertransmitObjectbusinessAddressState = null, Expression<Func<string>> searchContactsWrappertransmitObjectbusinessAddressCountryEn = null, Expression<Func<string>> searchContactsWrappertransmitObjectbusinessAddressPOBox = null, Expression<Func<string>> searchContactsWrappertransmitObjectbusinessAddressPostalCode = null, Expression<Func<string>> searchContactsWrappertransmitObjecthomeAddressStreet = null, Expression<Func<string>> searchContactsWrappertransmitObjecthomeAddressCity = null, Expression<Func<string>> searchContactsWrappertransmitObjecthomeAddressState = null, Expression<Func<string>> searchContactsWrappertransmitObjecthomeAddressCountryEn = null, Expression<Func<string>> searchContactsWrappertransmitObjecthomeAddressPOBox = null, Expression<Func<string>> searchContactsWrappertransmitObjecthomeAddressPostalCode = null, Expression<Func<string>> searchContactsWrappertransmitObjectotherAddressStreet = null, Expression<Func<string>> searchContactsWrappertransmitObjectotherAddressCity = null, Expression<Func<string>> searchContactsWrappertransmitObjectotherAddressState = null, Expression<Func<string>> searchContactsWrappertransmitObjectotherAddressCountryEn = null, Expression<Func<string>> searchContactsWrappertransmitObjectotherAddressPOBox = null, Expression<Func<string>> searchContactsWrappertransmitObjectotherAddressPostalCode = null, Expression<Func<string>> searchContactsWrappertransmitObjectcompany = null, Expression<Func<string>> searchContactsWrappertransmitObjectemail1Address = null, Expression<Func<string>> searchContactsWrappertransmitObjectemail2Address = null, Expression<Func<string>> searchContactsWrappertransmitObjectemail3Address = null, Expression<Func<string>> searchContactsWrappertransmitObjectfirstName = null, Expression<Func<string>> searchContactsWrappertransmitObjectiCQ = null, Expression<Func<string>> searchContactsWrappertransmitObjectimportanceEn = null, Expression<Func<string>> searchContactsWrappertransmitObjectlastName = null, Expression<Func<string>> searchContactsWrappertransmitObjectmiddleName = null, Expression<Func<string>> searchContactsWrappertransmitObjectmSN = null, Expression<Func<string>> searchContactsWrappertransmitObjectnote = null, Expression<Func<string>> searchContactsWrappertransmitObjectprefixEn = null, Expression<Func<string>> searchContactsWrappertransmitObjectsuffixEn = null, Expression<Func<string>> searchContactsWrappertransmitObjectskype = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber1 = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber2 = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber3 = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber4 = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber5 = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber6 = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber1Normalized = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber2Normalized = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber3Normalized = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber4Normalized = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber5Normalized = null, Expression<Func<string>> searchContactsWrappertransmitObjecttelephoneNumber6Normalized = null, Expression<Func<string>> searchContactsWrappertransmitObjectdepartment = null, Expression<Func<string>> searchContactsWrappertransmitObjecttitle = null, Expression<Func<string>> searchContactsWrappertransmitObjectwebPage = null, Expression<Func<bool>> searchContactsWrappertransmitObjectdoNotSendNewsletter = null, Expression<Func<string>> searchContactsWrappertransmitObjectprofilePicture = null, Expression<Func<int>> searchContactsWrappertransmitObjectprofilePictureWidth = null, Expression<Func<int>> searchContactsWrappertransmitObjectprofilePictureHeight = null, Expression<Func<string>> searchContactsWrappertransmitObjectlastActivity = null, Expression<Func<string>> searchContactsWrappertransmitObjectnextStep = null, Expression<Func<string>> searchContactsWrappertransmitObjecttypeEn = null, Expression<Func<string>> searchContactsWrappertransmitObjectstateEn = null, Expression<Func<string>> searchContactsWrappertransmitObjectprevStateEn = null, Expression<Func<bool>> searchContactsWrappertransmitObjectisPrivate = null, Expression<Func<string>> searchContactsWrappertransmitObjectserverItemCreated = null, Expression<Func<string>> searchContactsWrappertransmitObjectserverItemChanged = null, Expression<Func<string>> searchContactsWrappertransmitObjectitemCreated = null, Expression<Func<string>> searchContactsWrappertransmitObjectitemChanged = null, Expression<Func<string>> searchContactsWrappertransmitObjectfileAs = null, Expression<Func<string>> searchContactsWrappertransmitObjectownerGUID = null, Expression<Func<string>> searchContactsWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> searchContactsWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> searchContactsWrappertransmitObjectadditionalFields = null, Expression<Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]>> searchContactsWrappertransmitObjectrelations = null, Expression<Func<string>> searchContactsWrappertransmitObjectitemGUID = null, Expression<Func<int>> searchContactsWrappertransmitObjectitemVersion = null, Expression<Func<bool>> searchContactsWrapperincludeRelations = null, Expression<Func<string>> searchContactsWrapperrelationsFilterrelationType = null, Expression<Func<string>> searchContactsWrapperrelationsFilterforeignFolderName = null, Expression<Func<bool>> searchContactsWrapperincludeProfilePictures = null, Expression<Func<string>> searchContactsWrapperbinaryLogicalOperator = null)
        {
            var __workflow_searchContactsWrappertransmitObjectcompaniesCompanyGuid = WorkflowExpression.Compile(searchContactsWrappertransmitObjectcompaniesCompanyGuid, nameof(searchContactsWrappertransmitObjectcompaniesCompanyGuid), required: false);
            var __workflow_searchContactsWrappertransmitObjectbusinessAddressStreet = WorkflowExpression.Compile(searchContactsWrappertransmitObjectbusinessAddressStreet, nameof(searchContactsWrappertransmitObjectbusinessAddressStreet), required: false);
            var __workflow_searchContactsWrappertransmitObjectbusinessAddressCity = WorkflowExpression.Compile(searchContactsWrappertransmitObjectbusinessAddressCity, nameof(searchContactsWrappertransmitObjectbusinessAddressCity), required: false);
            var __workflow_searchContactsWrappertransmitObjectbusinessAddressState = WorkflowExpression.Compile(searchContactsWrappertransmitObjectbusinessAddressState, nameof(searchContactsWrappertransmitObjectbusinessAddressState), required: false);
            var __workflow_searchContactsWrappertransmitObjectbusinessAddressCountryEn = WorkflowExpression.Compile(searchContactsWrappertransmitObjectbusinessAddressCountryEn, nameof(searchContactsWrappertransmitObjectbusinessAddressCountryEn), required: false);
            var __workflow_searchContactsWrappertransmitObjectbusinessAddressPOBox = WorkflowExpression.Compile(searchContactsWrappertransmitObjectbusinessAddressPOBox, nameof(searchContactsWrappertransmitObjectbusinessAddressPOBox), required: false);
            var __workflow_searchContactsWrappertransmitObjectbusinessAddressPostalCode = WorkflowExpression.Compile(searchContactsWrappertransmitObjectbusinessAddressPostalCode, nameof(searchContactsWrappertransmitObjectbusinessAddressPostalCode), required: false);
            var __workflow_searchContactsWrappertransmitObjecthomeAddressStreet = WorkflowExpression.Compile(searchContactsWrappertransmitObjecthomeAddressStreet, nameof(searchContactsWrappertransmitObjecthomeAddressStreet), required: false);
            var __workflow_searchContactsWrappertransmitObjecthomeAddressCity = WorkflowExpression.Compile(searchContactsWrappertransmitObjecthomeAddressCity, nameof(searchContactsWrappertransmitObjecthomeAddressCity), required: false);
            var __workflow_searchContactsWrappertransmitObjecthomeAddressState = WorkflowExpression.Compile(searchContactsWrappertransmitObjecthomeAddressState, nameof(searchContactsWrappertransmitObjecthomeAddressState), required: false);
            var __workflow_searchContactsWrappertransmitObjecthomeAddressCountryEn = WorkflowExpression.Compile(searchContactsWrappertransmitObjecthomeAddressCountryEn, nameof(searchContactsWrappertransmitObjecthomeAddressCountryEn), required: false);
            var __workflow_searchContactsWrappertransmitObjecthomeAddressPOBox = WorkflowExpression.Compile(searchContactsWrappertransmitObjecthomeAddressPOBox, nameof(searchContactsWrappertransmitObjecthomeAddressPOBox), required: false);
            var __workflow_searchContactsWrappertransmitObjecthomeAddressPostalCode = WorkflowExpression.Compile(searchContactsWrappertransmitObjecthomeAddressPostalCode, nameof(searchContactsWrappertransmitObjecthomeAddressPostalCode), required: false);
            var __workflow_searchContactsWrappertransmitObjectotherAddressStreet = WorkflowExpression.Compile(searchContactsWrappertransmitObjectotherAddressStreet, nameof(searchContactsWrappertransmitObjectotherAddressStreet), required: false);
            var __workflow_searchContactsWrappertransmitObjectotherAddressCity = WorkflowExpression.Compile(searchContactsWrappertransmitObjectotherAddressCity, nameof(searchContactsWrappertransmitObjectotherAddressCity), required: false);
            var __workflow_searchContactsWrappertransmitObjectotherAddressState = WorkflowExpression.Compile(searchContactsWrappertransmitObjectotherAddressState, nameof(searchContactsWrappertransmitObjectotherAddressState), required: false);
            var __workflow_searchContactsWrappertransmitObjectotherAddressCountryEn = WorkflowExpression.Compile(searchContactsWrappertransmitObjectotherAddressCountryEn, nameof(searchContactsWrappertransmitObjectotherAddressCountryEn), required: false);
            var __workflow_searchContactsWrappertransmitObjectotherAddressPOBox = WorkflowExpression.Compile(searchContactsWrappertransmitObjectotherAddressPOBox, nameof(searchContactsWrappertransmitObjectotherAddressPOBox), required: false);
            var __workflow_searchContactsWrappertransmitObjectotherAddressPostalCode = WorkflowExpression.Compile(searchContactsWrappertransmitObjectotherAddressPostalCode, nameof(searchContactsWrappertransmitObjectotherAddressPostalCode), required: false);
            var __workflow_searchContactsWrappertransmitObjectcompany = WorkflowExpression.Compile(searchContactsWrappertransmitObjectcompany, nameof(searchContactsWrappertransmitObjectcompany), required: false);
            var __workflow_searchContactsWrappertransmitObjectemail1Address = WorkflowExpression.Compile(searchContactsWrappertransmitObjectemail1Address, nameof(searchContactsWrappertransmitObjectemail1Address), required: false);
            var __workflow_searchContactsWrappertransmitObjectemail2Address = WorkflowExpression.Compile(searchContactsWrappertransmitObjectemail2Address, nameof(searchContactsWrappertransmitObjectemail2Address), required: false);
            var __workflow_searchContactsWrappertransmitObjectemail3Address = WorkflowExpression.Compile(searchContactsWrappertransmitObjectemail3Address, nameof(searchContactsWrappertransmitObjectemail3Address), required: false);
            var __workflow_searchContactsWrappertransmitObjectfirstName = WorkflowExpression.Compile(searchContactsWrappertransmitObjectfirstName, nameof(searchContactsWrappertransmitObjectfirstName), required: false);
            var __workflow_searchContactsWrappertransmitObjectiCQ = WorkflowExpression.Compile(searchContactsWrappertransmitObjectiCQ, nameof(searchContactsWrappertransmitObjectiCQ), required: false);
            var __workflow_searchContactsWrappertransmitObjectimportanceEn = WorkflowExpression.Compile(searchContactsWrappertransmitObjectimportanceEn, nameof(searchContactsWrappertransmitObjectimportanceEn), required: false);
            var __workflow_searchContactsWrappertransmitObjectlastName = WorkflowExpression.Compile(searchContactsWrappertransmitObjectlastName, nameof(searchContactsWrappertransmitObjectlastName), required: false);
            var __workflow_searchContactsWrappertransmitObjectmiddleName = WorkflowExpression.Compile(searchContactsWrappertransmitObjectmiddleName, nameof(searchContactsWrappertransmitObjectmiddleName), required: false);
            var __workflow_searchContactsWrappertransmitObjectmSN = WorkflowExpression.Compile(searchContactsWrappertransmitObjectmSN, nameof(searchContactsWrappertransmitObjectmSN), required: false);
            var __workflow_searchContactsWrappertransmitObjectnote = WorkflowExpression.Compile(searchContactsWrappertransmitObjectnote, nameof(searchContactsWrappertransmitObjectnote), required: false);
            var __workflow_searchContactsWrappertransmitObjectprefixEn = WorkflowExpression.Compile(searchContactsWrappertransmitObjectprefixEn, nameof(searchContactsWrappertransmitObjectprefixEn), required: false);
            var __workflow_searchContactsWrappertransmitObjectsuffixEn = WorkflowExpression.Compile(searchContactsWrappertransmitObjectsuffixEn, nameof(searchContactsWrappertransmitObjectsuffixEn), required: false);
            var __workflow_searchContactsWrappertransmitObjectskype = WorkflowExpression.Compile(searchContactsWrappertransmitObjectskype, nameof(searchContactsWrappertransmitObjectskype), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber1 = WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber1, nameof(searchContactsWrappertransmitObjecttelephoneNumber1), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber2 = WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber2, nameof(searchContactsWrappertransmitObjecttelephoneNumber2), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber3 = WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber3, nameof(searchContactsWrappertransmitObjecttelephoneNumber3), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber4 = WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber4, nameof(searchContactsWrappertransmitObjecttelephoneNumber4), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber5 = WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber5, nameof(searchContactsWrappertransmitObjecttelephoneNumber5), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber6 = WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber6, nameof(searchContactsWrappertransmitObjecttelephoneNumber6), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber1Normalized = WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber1Normalized, nameof(searchContactsWrappertransmitObjecttelephoneNumber1Normalized), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber2Normalized = WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber2Normalized, nameof(searchContactsWrappertransmitObjecttelephoneNumber2Normalized), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber3Normalized = WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber3Normalized, nameof(searchContactsWrappertransmitObjecttelephoneNumber3Normalized), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber4Normalized = WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber4Normalized, nameof(searchContactsWrappertransmitObjecttelephoneNumber4Normalized), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber5Normalized = WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber5Normalized, nameof(searchContactsWrappertransmitObjecttelephoneNumber5Normalized), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber6Normalized = WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber6Normalized, nameof(searchContactsWrappertransmitObjecttelephoneNumber6Normalized), required: false);
            var __workflow_searchContactsWrappertransmitObjectdepartment = WorkflowExpression.Compile(searchContactsWrappertransmitObjectdepartment, nameof(searchContactsWrappertransmitObjectdepartment), required: false);
            var __workflow_searchContactsWrappertransmitObjecttitle = WorkflowExpression.Compile(searchContactsWrappertransmitObjecttitle, nameof(searchContactsWrappertransmitObjecttitle), required: false);
            var __workflow_searchContactsWrappertransmitObjectwebPage = WorkflowExpression.Compile(searchContactsWrappertransmitObjectwebPage, nameof(searchContactsWrappertransmitObjectwebPage), required: false);
            var __workflow_searchContactsWrappertransmitObjectdoNotSendNewsletter = WorkflowExpression.Compile(searchContactsWrappertransmitObjectdoNotSendNewsletter, nameof(searchContactsWrappertransmitObjectdoNotSendNewsletter), required: false);
            var __workflow_searchContactsWrappertransmitObjectprofilePicture = WorkflowExpression.Compile(searchContactsWrappertransmitObjectprofilePicture, nameof(searchContactsWrappertransmitObjectprofilePicture), required: false);
            var __workflow_searchContactsWrappertransmitObjectprofilePictureWidth = WorkflowExpression.Compile(searchContactsWrappertransmitObjectprofilePictureWidth, nameof(searchContactsWrappertransmitObjectprofilePictureWidth), required: false);
            var __workflow_searchContactsWrappertransmitObjectprofilePictureHeight = WorkflowExpression.Compile(searchContactsWrappertransmitObjectprofilePictureHeight, nameof(searchContactsWrappertransmitObjectprofilePictureHeight), required: false);
            var __workflow_searchContactsWrappertransmitObjectlastActivity = WorkflowExpression.Compile(searchContactsWrappertransmitObjectlastActivity, nameof(searchContactsWrappertransmitObjectlastActivity), required: false);
            var __workflow_searchContactsWrappertransmitObjectnextStep = WorkflowExpression.Compile(searchContactsWrappertransmitObjectnextStep, nameof(searchContactsWrappertransmitObjectnextStep), required: false);
            var __workflow_searchContactsWrappertransmitObjecttypeEn = WorkflowExpression.Compile(searchContactsWrappertransmitObjecttypeEn, nameof(searchContactsWrappertransmitObjecttypeEn), required: false);
            var __workflow_searchContactsWrappertransmitObjectstateEn = WorkflowExpression.Compile(searchContactsWrappertransmitObjectstateEn, nameof(searchContactsWrappertransmitObjectstateEn), required: false);
            var __workflow_searchContactsWrappertransmitObjectprevStateEn = WorkflowExpression.Compile(searchContactsWrappertransmitObjectprevStateEn, nameof(searchContactsWrappertransmitObjectprevStateEn), required: false);
            var __workflow_searchContactsWrappertransmitObjectisPrivate = WorkflowExpression.Compile(searchContactsWrappertransmitObjectisPrivate, nameof(searchContactsWrappertransmitObjectisPrivate), required: false);
            var __workflow_searchContactsWrappertransmitObjectserverItemCreated = WorkflowExpression.Compile(searchContactsWrappertransmitObjectserverItemCreated, nameof(searchContactsWrappertransmitObjectserverItemCreated), required: false);
            var __workflow_searchContactsWrappertransmitObjectserverItemChanged = WorkflowExpression.Compile(searchContactsWrappertransmitObjectserverItemChanged, nameof(searchContactsWrappertransmitObjectserverItemChanged), required: false);
            var __workflow_searchContactsWrappertransmitObjectitemCreated = WorkflowExpression.Compile(searchContactsWrappertransmitObjectitemCreated, nameof(searchContactsWrappertransmitObjectitemCreated), required: false);
            var __workflow_searchContactsWrappertransmitObjectitemChanged = WorkflowExpression.Compile(searchContactsWrappertransmitObjectitemChanged, nameof(searchContactsWrappertransmitObjectitemChanged), required: false);
            var __workflow_searchContactsWrappertransmitObjectfileAs = WorkflowExpression.Compile(searchContactsWrappertransmitObjectfileAs, nameof(searchContactsWrappertransmitObjectfileAs), required: false);
            var __workflow_searchContactsWrappertransmitObjectownerGUID = WorkflowExpression.Compile(searchContactsWrappertransmitObjectownerGUID, nameof(searchContactsWrappertransmitObjectownerGUID), required: false);
            var __workflow_searchContactsWrappertransmitObjectcreatedByGUID = WorkflowExpression.Compile(searchContactsWrappertransmitObjectcreatedByGUID, nameof(searchContactsWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_searchContactsWrappertransmitObjectmodifiedByGUID = WorkflowExpression.Compile(searchContactsWrappertransmitObjectmodifiedByGUID, nameof(searchContactsWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_searchContactsWrappertransmitObjectadditionalFields = WorkflowExpression.Compile(searchContactsWrappertransmitObjectadditionalFields, nameof(searchContactsWrappertransmitObjectadditionalFields), required: false);
            var __workflow_searchContactsWrappertransmitObjectrelations = WorkflowExpression.Compile(searchContactsWrappertransmitObjectrelations, nameof(searchContactsWrappertransmitObjectrelations), required: false);
            var __workflow_searchContactsWrappertransmitObjectitemGUID = WorkflowExpression.Compile(searchContactsWrappertransmitObjectitemGUID, nameof(searchContactsWrappertransmitObjectitemGUID), required: false);
            var __workflow_searchContactsWrappertransmitObjectitemVersion = WorkflowExpression.Compile(searchContactsWrappertransmitObjectitemVersion, nameof(searchContactsWrappertransmitObjectitemVersion), required: false);
            var __workflow_searchContactsWrapperincludeRelations = WorkflowExpression.Compile(searchContactsWrapperincludeRelations, nameof(searchContactsWrapperincludeRelations), required: false);
            var __workflow_searchContactsWrapperrelationsFilterrelationType = WorkflowExpression.Compile(searchContactsWrapperrelationsFilterrelationType, nameof(searchContactsWrapperrelationsFilterrelationType), required: false);
            var __workflow_searchContactsWrapperrelationsFilterforeignFolderName = WorkflowExpression.Compile(searchContactsWrapperrelationsFilterforeignFolderName, nameof(searchContactsWrapperrelationsFilterforeignFolderName), required: false);
            var __workflow_searchContactsWrapperincludeProfilePictures = WorkflowExpression.Compile(searchContactsWrapperincludeProfilePictures, nameof(searchContactsWrapperincludeProfilePictures), required: false);
            var __workflow_searchContactsWrapperbinaryLogicalOperator = WorkflowExpression.Compile(searchContactsWrapperbinaryLogicalOperator, nameof(searchContactsWrapperbinaryLogicalOperator), required: false);
            return new DeferredBodyAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact>(() =>
            {
                var apiCallPath = "/SearchContacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var searchContactsWrapper = new JObject();
                var searchContactsWrapperpropCount = 0;
                var transmitObjectObject = new JObject();
                var transmitObjectObjectpropCount = 0;
                if (__workflow_searchContactsWrappertransmitObjectcompaniesCompanyGuid != null)
                {
                    transmitObjectObject["Companies_CompanyGuid"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectcompaniesCompanyGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectbusinessAddressStreet != null)
                {
                    transmitObjectObject["BusinessAddressStreet"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectbusinessAddressStreet);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectbusinessAddressCity != null)
                {
                    transmitObjectObject["BusinessAddressCity"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectbusinessAddressCity);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectbusinessAddressState != null)
                {
                    transmitObjectObject["BusinessAddressState"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectbusinessAddressState);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectbusinessAddressCountryEn != null)
                {
                    transmitObjectObject["BusinessAddressCountryEn"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectbusinessAddressCountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectbusinessAddressPOBox != null)
                {
                    transmitObjectObject["BusinessAddressPOBox"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectbusinessAddressPOBox);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectbusinessAddressPostalCode != null)
                {
                    transmitObjectObject["BusinessAddressPostalCode"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectbusinessAddressPostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjecthomeAddressStreet != null)
                {
                    transmitObjectObject["HomeAddressStreet"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjecthomeAddressStreet);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjecthomeAddressCity != null)
                {
                    transmitObjectObject["HomeAddressCity"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjecthomeAddressCity);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjecthomeAddressState != null)
                {
                    transmitObjectObject["HomeAddressState"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjecthomeAddressState);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjecthomeAddressCountryEn != null)
                {
                    transmitObjectObject["HomeAddressCountryEn"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjecthomeAddressCountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjecthomeAddressPOBox != null)
                {
                    transmitObjectObject["HomeAddressPOBox"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjecthomeAddressPOBox);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjecthomeAddressPostalCode != null)
                {
                    transmitObjectObject["HomeAddressPostalCode"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjecthomeAddressPostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectotherAddressStreet != null)
                {
                    transmitObjectObject["OtherAddressStreet"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectotherAddressStreet);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectotherAddressCity != null)
                {
                    transmitObjectObject["OtherAddressCity"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectotherAddressCity);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectotherAddressState != null)
                {
                    transmitObjectObject["OtherAddressState"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectotherAddressState);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectotherAddressCountryEn != null)
                {
                    transmitObjectObject["OtherAddressCountryEn"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectotherAddressCountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectotherAddressPOBox != null)
                {
                    transmitObjectObject["OtherAddressPOBox"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectotherAddressPOBox);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectotherAddressPostalCode != null)
                {
                    transmitObjectObject["OtherAddressPostalCode"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectotherAddressPostalCode);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectcompany != null)
                {
                    transmitObjectObject["Company"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectcompany);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectemail1Address != null)
                {
                    transmitObjectObject["Email1Address"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectemail1Address);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectemail2Address != null)
                {
                    transmitObjectObject["Email2Address"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectemail2Address);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectemail3Address != null)
                {
                    transmitObjectObject["Email3Address"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectemail3Address);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectfirstName != null)
                {
                    transmitObjectObject["FirstName"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectfirstName);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectiCQ != null)
                {
                    transmitObjectObject["ICQ"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectiCQ);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectimportanceEn != null)
                {
                    transmitObjectObject["ImportanceEn"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectimportanceEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectlastName != null)
                {
                    transmitObjectObject["LastName"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectlastName);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectmiddleName != null)
                {
                    transmitObjectObject["MiddleName"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectmiddleName);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectmSN != null)
                {
                    transmitObjectObject["MSN"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectmSN);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectnote != null)
                {
                    transmitObjectObject["Note"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectnote);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectprefixEn != null)
                {
                    transmitObjectObject["PrefixEn"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectprefixEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectsuffixEn != null)
                {
                    transmitObjectObject["SuffixEn"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectsuffixEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectskype != null)
                {
                    transmitObjectObject["Skype"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectskype);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjecttelephoneNumber1 != null)
                {
                    transmitObjectObject["TelephoneNumber1"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjecttelephoneNumber1);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjecttelephoneNumber2 != null)
                {
                    transmitObjectObject["TelephoneNumber2"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjecttelephoneNumber2);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjecttelephoneNumber3 != null)
                {
                    transmitObjectObject["TelephoneNumber3"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjecttelephoneNumber3);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjecttelephoneNumber4 != null)
                {
                    transmitObjectObject["TelephoneNumber4"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjecttelephoneNumber4);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjecttelephoneNumber5 != null)
                {
                    transmitObjectObject["TelephoneNumber5"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjecttelephoneNumber5);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjecttelephoneNumber6 != null)
                {
                    transmitObjectObject["TelephoneNumber6"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjecttelephoneNumber6);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjecttelephoneNumber1Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber1Normalized"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjecttelephoneNumber1Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjecttelephoneNumber2Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber2Normalized"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjecttelephoneNumber2Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjecttelephoneNumber3Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber3Normalized"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjecttelephoneNumber3Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjecttelephoneNumber4Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber4Normalized"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjecttelephoneNumber4Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjecttelephoneNumber5Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber5Normalized"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjecttelephoneNumber5Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjecttelephoneNumber6Normalized != null)
                {
                    transmitObjectObject["TelephoneNumber6Normalized"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjecttelephoneNumber6Normalized);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectdepartment != null)
                {
                    transmitObjectObject["Department"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectdepartment);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjecttitle != null)
                {
                    transmitObjectObject["Title"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjecttitle);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectwebPage != null)
                {
                    transmitObjectObject["WebPage"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectwebPage);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectdoNotSendNewsletter != null)
                {
                    transmitObjectObject["DoNotSendNewsletter"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectdoNotSendNewsletter);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectprofilePicture != null)
                {
                    transmitObjectObject["ProfilePicture"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectprofilePicture);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectprofilePictureWidth != null)
                {
                    transmitObjectObject["ProfilePictureWidth"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectprofilePictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectprofilePictureHeight != null)
                {
                    transmitObjectObject["ProfilePictureHeight"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectprofilePictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectlastActivity != null)
                {
                    transmitObjectObject["LastActivity"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectlastActivity);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectnextStep != null)
                {
                    transmitObjectObject["NextStep"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectnextStep);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectserverItemCreated != null)
                {
                    transmitObjectObject["Server_ItemCreated"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectserverItemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectserverItemChanged != null)
                {
                    transmitObjectObject["Server_ItemChanged"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectserverItemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectrelations != null)
                {
                    transmitObjectObject["Relations"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectrelations);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchContactsWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    searchContactsWrapper["transmitObject"] = transmitObjectObject;
                    searchContactsWrapperpropCount++;
                }

                if (__workflow_searchContactsWrapperincludeRelations != null)
                {
                    searchContactsWrapper["includeRelations"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrapperincludeRelations);
                    searchContactsWrapperpropCount++;
                }

                var relationsFilterObject = new JObject();
                var relationsFilterObjectpropCount = 0;
                if (__workflow_searchContactsWrapperrelationsFilterrelationType != null)
                {
                    relationsFilterObject["RelationType"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrapperrelationsFilterrelationType);
                    relationsFilterObjectpropCount++;
                }

                if (__workflow_searchContactsWrapperrelationsFilterforeignFolderName != null)
                {
                    relationsFilterObject["ForeignFolderName"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrapperrelationsFilterforeignFolderName);
                    relationsFilterObjectpropCount++;
                }

                if (relationsFilterObjectpropCount > 0)
                {
                    searchContactsWrapper["relationsFilter"] = relationsFilterObject;
                    searchContactsWrapperpropCount++;
                }

                if (__workflow_searchContactsWrapperincludeProfilePictures != null)
                {
                    searchContactsWrapper["includeProfilePictures"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrapperincludeProfilePictures);
                    searchContactsWrapperpropCount++;
                }

                if (__workflow_searchContactsWrapperbinaryLogicalOperator != null)
                {
                    searchContactsWrapper["binaryLogicalOperator"] = ExpressionConverter.ConvertO(__workflow_searchContactsWrapperbinaryLogicalOperator);
                    searchContactsWrapperpropCount++;
                }

                if (searchContactsWrapperpropCount > 0)
                {
                    callPayload.Body = searchContactsWrapper;
                }

                return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal> SearchJournals(Expression<Func<string>> searchJournalsWrappertransmitObjectmarketingSuperiorItemGuid = null, Expression<Func<string>> searchJournalsWrappertransmitObjectcompaniesCompanyGuid = null, Expression<Func<string>> searchJournalsWrappertransmitObjectcontactsContactGuid = null, Expression<Func<string>> searchJournalsWrappertransmitObjectleadsSuperiorItemGuid = null, Expression<Func<string>> searchJournalsWrappertransmitObjectprojectsSuperiorItemGuid = null, Expression<Func<string>> searchJournalsWrappertransmitObjectmarketingMarketingGuid = null, Expression<Func<string>> searchJournalsWrappertransmitObjectcalendarEntryID = null, Expression<Func<string>> searchJournalsWrappertransmitObjectcalendarORIGIN = null, Expression<Func<string>> searchJournalsWrappertransmitObjectchangedField = null, Expression<Func<string>> searchJournalsWrappertransmitObjecteventEnd = null, Expression<Func<string>> searchJournalsWrappertransmitObjecteventStart = null, Expression<Func<string>> searchJournalsWrappertransmitObjectfieldValue = null, Expression<Func<string>> searchJournalsWrappertransmitObjectimportanceEn = null, Expression<Func<string>> searchJournalsWrappertransmitObjectnote = null, Expression<Func<string>> searchJournalsWrappertransmitObjectprevFieldValue = null, Expression<Func<string>> searchJournalsWrappertransmitObjecttypeEn = null, Expression<Func<bool>> searchJournalsWrappertransmitObjectisSystem = null, Expression<Func<string>> searchJournalsWrappertransmitObjectphone = null, Expression<Func<string>> searchJournalsWrappertransmitObjectphoneNormalized = null, Expression<Func<bool>> searchJournalsWrappertransmitObjectisGdprRelevant = null, Expression<Func<string>> searchJournalsWrappertransmitObjectpicture = null, Expression<Func<int>> searchJournalsWrappertransmitObjectpictureWidth = null, Expression<Func<int>> searchJournalsWrappertransmitObjectpictureHeight = null, Expression<Func<string>> searchJournalsWrappertransmitObjectstateEn = null, Expression<Func<string>> searchJournalsWrappertransmitObjectprevStateEn = null, Expression<Func<bool>> searchJournalsWrappertransmitObjectisPrivate = null, Expression<Func<string>> searchJournalsWrappertransmitObjectserverItemCreated = null, Expression<Func<string>> searchJournalsWrappertransmitObjectserverItemChanged = null, Expression<Func<string>> searchJournalsWrappertransmitObjectitemCreated = null, Expression<Func<string>> searchJournalsWrappertransmitObjectitemChanged = null, Expression<Func<string>> searchJournalsWrappertransmitObjectfileAs = null, Expression<Func<string>> searchJournalsWrappertransmitObjectownerGUID = null, Expression<Func<string>> searchJournalsWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> searchJournalsWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> searchJournalsWrappertransmitObjectadditionalFields = null, Expression<Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]>> searchJournalsWrappertransmitObjectrelations = null, Expression<Func<string>> searchJournalsWrappertransmitObjectitemGUID = null, Expression<Func<int>> searchJournalsWrappertransmitObjectitemVersion = null, Expression<Func<bool>> searchJournalsWrapperincludeRelations = null, Expression<Func<string>> searchJournalsWrapperrelationsFilterrelationType = null, Expression<Func<string>> searchJournalsWrapperrelationsFilterforeignFolderName = null, Expression<Func<string>> searchJournalsWrapperbinaryLogicalOperator = null)
        {
            var __workflow_searchJournalsWrappertransmitObjectmarketingSuperiorItemGuid = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectmarketingSuperiorItemGuid, nameof(searchJournalsWrappertransmitObjectmarketingSuperiorItemGuid), required: false);
            var __workflow_searchJournalsWrappertransmitObjectcompaniesCompanyGuid = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectcompaniesCompanyGuid, nameof(searchJournalsWrappertransmitObjectcompaniesCompanyGuid), required: false);
            var __workflow_searchJournalsWrappertransmitObjectcontactsContactGuid = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectcontactsContactGuid, nameof(searchJournalsWrappertransmitObjectcontactsContactGuid), required: false);
            var __workflow_searchJournalsWrappertransmitObjectleadsSuperiorItemGuid = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectleadsSuperiorItemGuid, nameof(searchJournalsWrappertransmitObjectleadsSuperiorItemGuid), required: false);
            var __workflow_searchJournalsWrappertransmitObjectprojectsSuperiorItemGuid = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectprojectsSuperiorItemGuid, nameof(searchJournalsWrappertransmitObjectprojectsSuperiorItemGuid), required: false);
            var __workflow_searchJournalsWrappertransmitObjectmarketingMarketingGuid = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectmarketingMarketingGuid, nameof(searchJournalsWrappertransmitObjectmarketingMarketingGuid), required: false);
            var __workflow_searchJournalsWrappertransmitObjectcalendarEntryID = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectcalendarEntryID, nameof(searchJournalsWrappertransmitObjectcalendarEntryID), required: false);
            var __workflow_searchJournalsWrappertransmitObjectcalendarORIGIN = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectcalendarORIGIN, nameof(searchJournalsWrappertransmitObjectcalendarORIGIN), required: false);
            var __workflow_searchJournalsWrappertransmitObjectchangedField = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectchangedField, nameof(searchJournalsWrappertransmitObjectchangedField), required: false);
            var __workflow_searchJournalsWrappertransmitObjecteventEnd = WorkflowExpression.Compile(searchJournalsWrappertransmitObjecteventEnd, nameof(searchJournalsWrappertransmitObjecteventEnd), required: false);
            var __workflow_searchJournalsWrappertransmitObjecteventStart = WorkflowExpression.Compile(searchJournalsWrappertransmitObjecteventStart, nameof(searchJournalsWrappertransmitObjecteventStart), required: false);
            var __workflow_searchJournalsWrappertransmitObjectfieldValue = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectfieldValue, nameof(searchJournalsWrappertransmitObjectfieldValue), required: false);
            var __workflow_searchJournalsWrappertransmitObjectimportanceEn = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectimportanceEn, nameof(searchJournalsWrappertransmitObjectimportanceEn), required: false);
            var __workflow_searchJournalsWrappertransmitObjectnote = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectnote, nameof(searchJournalsWrappertransmitObjectnote), required: false);
            var __workflow_searchJournalsWrappertransmitObjectprevFieldValue = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectprevFieldValue, nameof(searchJournalsWrappertransmitObjectprevFieldValue), required: false);
            var __workflow_searchJournalsWrappertransmitObjecttypeEn = WorkflowExpression.Compile(searchJournalsWrappertransmitObjecttypeEn, nameof(searchJournalsWrappertransmitObjecttypeEn), required: false);
            var __workflow_searchJournalsWrappertransmitObjectisSystem = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectisSystem, nameof(searchJournalsWrappertransmitObjectisSystem), required: false);
            var __workflow_searchJournalsWrappertransmitObjectphone = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectphone, nameof(searchJournalsWrappertransmitObjectphone), required: false);
            var __workflow_searchJournalsWrappertransmitObjectphoneNormalized = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectphoneNormalized, nameof(searchJournalsWrappertransmitObjectphoneNormalized), required: false);
            var __workflow_searchJournalsWrappertransmitObjectisGdprRelevant = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectisGdprRelevant, nameof(searchJournalsWrappertransmitObjectisGdprRelevant), required: false);
            var __workflow_searchJournalsWrappertransmitObjectpicture = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectpicture, nameof(searchJournalsWrappertransmitObjectpicture), required: false);
            var __workflow_searchJournalsWrappertransmitObjectpictureWidth = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectpictureWidth, nameof(searchJournalsWrappertransmitObjectpictureWidth), required: false);
            var __workflow_searchJournalsWrappertransmitObjectpictureHeight = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectpictureHeight, nameof(searchJournalsWrappertransmitObjectpictureHeight), required: false);
            var __workflow_searchJournalsWrappertransmitObjectstateEn = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectstateEn, nameof(searchJournalsWrappertransmitObjectstateEn), required: false);
            var __workflow_searchJournalsWrappertransmitObjectprevStateEn = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectprevStateEn, nameof(searchJournalsWrappertransmitObjectprevStateEn), required: false);
            var __workflow_searchJournalsWrappertransmitObjectisPrivate = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectisPrivate, nameof(searchJournalsWrappertransmitObjectisPrivate), required: false);
            var __workflow_searchJournalsWrappertransmitObjectserverItemCreated = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectserverItemCreated, nameof(searchJournalsWrappertransmitObjectserverItemCreated), required: false);
            var __workflow_searchJournalsWrappertransmitObjectserverItemChanged = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectserverItemChanged, nameof(searchJournalsWrappertransmitObjectserverItemChanged), required: false);
            var __workflow_searchJournalsWrappertransmitObjectitemCreated = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectitemCreated, nameof(searchJournalsWrappertransmitObjectitemCreated), required: false);
            var __workflow_searchJournalsWrappertransmitObjectitemChanged = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectitemChanged, nameof(searchJournalsWrappertransmitObjectitemChanged), required: false);
            var __workflow_searchJournalsWrappertransmitObjectfileAs = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectfileAs, nameof(searchJournalsWrappertransmitObjectfileAs), required: false);
            var __workflow_searchJournalsWrappertransmitObjectownerGUID = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectownerGUID, nameof(searchJournalsWrappertransmitObjectownerGUID), required: false);
            var __workflow_searchJournalsWrappertransmitObjectcreatedByGUID = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectcreatedByGUID, nameof(searchJournalsWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_searchJournalsWrappertransmitObjectmodifiedByGUID = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectmodifiedByGUID, nameof(searchJournalsWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_searchJournalsWrappertransmitObjectadditionalFields = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectadditionalFields, nameof(searchJournalsWrappertransmitObjectadditionalFields), required: false);
            var __workflow_searchJournalsWrappertransmitObjectrelations = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectrelations, nameof(searchJournalsWrappertransmitObjectrelations), required: false);
            var __workflow_searchJournalsWrappertransmitObjectitemGUID = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectitemGUID, nameof(searchJournalsWrappertransmitObjectitemGUID), required: false);
            var __workflow_searchJournalsWrappertransmitObjectitemVersion = WorkflowExpression.Compile(searchJournalsWrappertransmitObjectitemVersion, nameof(searchJournalsWrappertransmitObjectitemVersion), required: false);
            var __workflow_searchJournalsWrapperincludeRelations = WorkflowExpression.Compile(searchJournalsWrapperincludeRelations, nameof(searchJournalsWrapperincludeRelations), required: false);
            var __workflow_searchJournalsWrapperrelationsFilterrelationType = WorkflowExpression.Compile(searchJournalsWrapperrelationsFilterrelationType, nameof(searchJournalsWrapperrelationsFilterrelationType), required: false);
            var __workflow_searchJournalsWrapperrelationsFilterforeignFolderName = WorkflowExpression.Compile(searchJournalsWrapperrelationsFilterforeignFolderName, nameof(searchJournalsWrapperrelationsFilterforeignFolderName), required: false);
            var __workflow_searchJournalsWrapperbinaryLogicalOperator = WorkflowExpression.Compile(searchJournalsWrapperbinaryLogicalOperator, nameof(searchJournalsWrapperbinaryLogicalOperator), required: false);
            return new DeferredBodyAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal>(() =>
            {
                var apiCallPath = "/SearchJournals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var searchJournalsWrapper = new JObject();
                var searchJournalsWrapperpropCount = 0;
                var transmitObjectObject = new JObject();
                var transmitObjectObjectpropCount = 0;
                if (__workflow_searchJournalsWrappertransmitObjectmarketingSuperiorItemGuid != null)
                {
                    transmitObjectObject["Marketing_SuperiorItemGuid"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectmarketingSuperiorItemGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectcompaniesCompanyGuid != null)
                {
                    transmitObjectObject["Companies_CompanyGuid"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectcompaniesCompanyGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectcontactsContactGuid != null)
                {
                    transmitObjectObject["Contacts_ContactGuid"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectcontactsContactGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectleadsSuperiorItemGuid != null)
                {
                    transmitObjectObject["Leads_SuperiorItemGuid"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectleadsSuperiorItemGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectprojectsSuperiorItemGuid != null)
                {
                    transmitObjectObject["Projects_SuperiorItemGuid"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectprojectsSuperiorItemGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectmarketingMarketingGuid != null)
                {
                    transmitObjectObject["Marketing_MarketingGuid"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectmarketingMarketingGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectcalendarEntryID != null)
                {
                    transmitObjectObject["CalendarEntryID"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectcalendarEntryID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectcalendarORIGIN != null)
                {
                    transmitObjectObject["Calendar_ORIGIN"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectcalendarORIGIN);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectchangedField != null)
                {
                    transmitObjectObject["ChangedField"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectchangedField);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjecteventEnd != null)
                {
                    transmitObjectObject["EventEnd"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjecteventEnd);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjecteventStart != null)
                {
                    transmitObjectObject["EventStart"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjecteventStart);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectfieldValue != null)
                {
                    transmitObjectObject["FieldValue"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectfieldValue);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectimportanceEn != null)
                {
                    transmitObjectObject["ImportanceEn"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectimportanceEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectnote != null)
                {
                    transmitObjectObject["Note"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectnote);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectprevFieldValue != null)
                {
                    transmitObjectObject["PrevFieldValue"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectprevFieldValue);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectisSystem != null)
                {
                    transmitObjectObject["IsSystem"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectisSystem);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectphone != null)
                {
                    transmitObjectObject["Phone"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectphone);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectphoneNormalized != null)
                {
                    transmitObjectObject["PhoneNormalized"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectphoneNormalized);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectisGdprRelevant != null)
                {
                    transmitObjectObject["IsGdprRelevant"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectisGdprRelevant);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectpicture != null)
                {
                    transmitObjectObject["Picture"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectpicture);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectpictureWidth != null)
                {
                    transmitObjectObject["PictureWidth"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectpictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectpictureHeight != null)
                {
                    transmitObjectObject["PictureHeight"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectpictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectserverItemCreated != null)
                {
                    transmitObjectObject["Server_ItemCreated"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectserverItemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectserverItemChanged != null)
                {
                    transmitObjectObject["Server_ItemChanged"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectserverItemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectrelations != null)
                {
                    transmitObjectObject["Relations"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectrelations);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchJournalsWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    searchJournalsWrapper["transmitObject"] = transmitObjectObject;
                    searchJournalsWrapperpropCount++;
                }

                if (__workflow_searchJournalsWrapperincludeRelations != null)
                {
                    searchJournalsWrapper["includeRelations"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrapperincludeRelations);
                    searchJournalsWrapperpropCount++;
                }

                var relationsFilterObject = new JObject();
                var relationsFilterObjectpropCount = 0;
                if (__workflow_searchJournalsWrapperrelationsFilterrelationType != null)
                {
                    relationsFilterObject["RelationType"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrapperrelationsFilterrelationType);
                    relationsFilterObjectpropCount++;
                }

                if (__workflow_searchJournalsWrapperrelationsFilterforeignFolderName != null)
                {
                    relationsFilterObject["ForeignFolderName"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrapperrelationsFilterforeignFolderName);
                    relationsFilterObjectpropCount++;
                }

                if (relationsFilterObjectpropCount > 0)
                {
                    searchJournalsWrapper["relationsFilter"] = relationsFilterObject;
                    searchJournalsWrapperpropCount++;
                }

                if (__workflow_searchJournalsWrapperbinaryLogicalOperator != null)
                {
                    searchJournalsWrapper["binaryLogicalOperator"] = ExpressionConverter.ConvertO(__workflow_searchJournalsWrapperbinaryLogicalOperator);
                    searchJournalsWrapperpropCount++;
                }

                if (searchJournalsWrapperpropCount > 0)
                {
                    callPayload.Body = searchJournalsWrapper;
                }

                return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead> SearchLeads(Expression<Func<string>> searchLeadsWrappertransmitObjectcompaniesCustomerGuid = null, Expression<Func<string>> searchLeadsWrappertransmitObjectcontactsContactPersonGuid = null, Expression<Func<string>> searchLeadsWrappertransmitObjectmarketingMarketingGuid = null, Expression<Func<string>> searchLeadsWrappertransmitObjectcity = null, Expression<Func<string>> searchLeadsWrappertransmitObjectcontactPerson = null, Expression<Func<string>> searchLeadsWrappertransmitObjectcurrencyEn = null, Expression<Func<string>> searchLeadsWrappertransmitObjectcustomer = null, Expression<Func<string>> searchLeadsWrappertransmitObjectemail = null, Expression<Func<string>> searchLeadsWrappertransmitObjectestimatedEnd = null, Expression<Func<int>> searchLeadsWrappertransmitObjecthID = null, Expression<Func<string>> searchLeadsWrappertransmitObjectleadOriginEn = null, Expression<Func<string>> searchLeadsWrappertransmitObjectnote = null, Expression<Func<string>> searchLeadsWrappertransmitObjectphone = null, Expression<Func<string>> searchLeadsWrappertransmitObjectphoneNormalized = null, Expression<Func<string>> searchLeadsWrappertransmitObjectprevStateEn = null, Expression<Func<double>> searchLeadsWrappertransmitObjectprice = null, Expression<Func<string>> searchLeadsWrappertransmitObjectpriceChanged = null, Expression<Func<double>> searchLeadsWrappertransmitObjectpriceDefaultCurrency = null, Expression<Func<double>> searchLeadsWrappertransmitObjectprobability = null, Expression<Func<string>> searchLeadsWrappertransmitObjectreceiveDate = null, Expression<Func<string>> searchLeadsWrappertransmitObjectstateEn = null, Expression<Func<string>> searchLeadsWrappertransmitObjectstreet = null, Expression<Func<string>> searchLeadsWrappertransmitObjecttypeEn = null, Expression<Func<string>> searchLeadsWrappertransmitObjectzip = null, Expression<Func<string>> searchLeadsWrappertransmitObjectlastActivity = null, Expression<Func<string>> searchLeadsWrappertransmitObjectnextStep = null, Expression<Func<double>> searchLeadsWrappertransmitObjectestimatedValue = null, Expression<Func<bool>> searchLeadsWrappertransmitObjectisCompleted = null, Expression<Func<bool>> searchLeadsWrappertransmitObjectisLost = null, Expression<Func<string>> searchLeadsWrappertransmitObjectcountryEn = null, Expression<Func<string>> searchLeadsWrappertransmitObjectstate = null, Expression<Func<string>> searchLeadsWrappertransmitObjectpOBox = null, Expression<Func<bool>> searchLeadsWrappertransmitObjectemailOptOut = null, Expression<Func<string>> searchLeadsWrappertransmitObjectpicture = null, Expression<Func<int>> searchLeadsWrappertransmitObjectpictureWidth = null, Expression<Func<int>> searchLeadsWrappertransmitObjectpictureHeight = null, Expression<Func<string>> searchLeadsWrappertransmitObjectcompletedDate = null, Expression<Func<string>> searchLeadsWrappertransmitObjectlostDate = null, Expression<Func<bool>> searchLeadsWrappertransmitObjectisPrivate = null, Expression<Func<string>> searchLeadsWrappertransmitObjectserverItemCreated = null, Expression<Func<string>> searchLeadsWrappertransmitObjectserverItemChanged = null, Expression<Func<string>> searchLeadsWrappertransmitObjectitemCreated = null, Expression<Func<string>> searchLeadsWrappertransmitObjectitemChanged = null, Expression<Func<string>> searchLeadsWrappertransmitObjectfileAs = null, Expression<Func<string>> searchLeadsWrappertransmitObjectownerGUID = null, Expression<Func<string>> searchLeadsWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> searchLeadsWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> searchLeadsWrappertransmitObjectadditionalFields = null, Expression<Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]>> searchLeadsWrappertransmitObjectrelations = null, Expression<Func<string>> searchLeadsWrappertransmitObjectitemGUID = null, Expression<Func<int>> searchLeadsWrappertransmitObjectitemVersion = null, Expression<Func<bool>> searchLeadsWrapperincludeRelations = null, Expression<Func<string>> searchLeadsWrapperrelationsFilterrelationType = null, Expression<Func<string>> searchLeadsWrapperrelationsFilterforeignFolderName = null, Expression<Func<string>> searchLeadsWrapperbinaryLogicalOperator = null)
        {
            var __workflow_searchLeadsWrappertransmitObjectcompaniesCustomerGuid = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectcompaniesCustomerGuid, nameof(searchLeadsWrappertransmitObjectcompaniesCustomerGuid), required: false);
            var __workflow_searchLeadsWrappertransmitObjectcontactsContactPersonGuid = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectcontactsContactPersonGuid, nameof(searchLeadsWrappertransmitObjectcontactsContactPersonGuid), required: false);
            var __workflow_searchLeadsWrappertransmitObjectmarketingMarketingGuid = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectmarketingMarketingGuid, nameof(searchLeadsWrappertransmitObjectmarketingMarketingGuid), required: false);
            var __workflow_searchLeadsWrappertransmitObjectcity = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectcity, nameof(searchLeadsWrappertransmitObjectcity), required: false);
            var __workflow_searchLeadsWrappertransmitObjectcontactPerson = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectcontactPerson, nameof(searchLeadsWrappertransmitObjectcontactPerson), required: false);
            var __workflow_searchLeadsWrappertransmitObjectcurrencyEn = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectcurrencyEn, nameof(searchLeadsWrappertransmitObjectcurrencyEn), required: false);
            var __workflow_searchLeadsWrappertransmitObjectcustomer = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectcustomer, nameof(searchLeadsWrappertransmitObjectcustomer), required: false);
            var __workflow_searchLeadsWrappertransmitObjectemail = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectemail, nameof(searchLeadsWrappertransmitObjectemail), required: false);
            var __workflow_searchLeadsWrappertransmitObjectestimatedEnd = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectestimatedEnd, nameof(searchLeadsWrappertransmitObjectestimatedEnd), required: false);
            var __workflow_searchLeadsWrappertransmitObjecthID = WorkflowExpression.Compile(searchLeadsWrappertransmitObjecthID, nameof(searchLeadsWrappertransmitObjecthID), required: false);
            var __workflow_searchLeadsWrappertransmitObjectleadOriginEn = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectleadOriginEn, nameof(searchLeadsWrappertransmitObjectleadOriginEn), required: false);
            var __workflow_searchLeadsWrappertransmitObjectnote = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectnote, nameof(searchLeadsWrappertransmitObjectnote), required: false);
            var __workflow_searchLeadsWrappertransmitObjectphone = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectphone, nameof(searchLeadsWrappertransmitObjectphone), required: false);
            var __workflow_searchLeadsWrappertransmitObjectphoneNormalized = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectphoneNormalized, nameof(searchLeadsWrappertransmitObjectphoneNormalized), required: false);
            var __workflow_searchLeadsWrappertransmitObjectprevStateEn = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectprevStateEn, nameof(searchLeadsWrappertransmitObjectprevStateEn), required: false);
            var __workflow_searchLeadsWrappertransmitObjectprice = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectprice, nameof(searchLeadsWrappertransmitObjectprice), required: false);
            var __workflow_searchLeadsWrappertransmitObjectpriceChanged = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectpriceChanged, nameof(searchLeadsWrappertransmitObjectpriceChanged), required: false);
            var __workflow_searchLeadsWrappertransmitObjectpriceDefaultCurrency = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectpriceDefaultCurrency, nameof(searchLeadsWrappertransmitObjectpriceDefaultCurrency), required: false);
            var __workflow_searchLeadsWrappertransmitObjectprobability = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectprobability, nameof(searchLeadsWrappertransmitObjectprobability), required: false);
            var __workflow_searchLeadsWrappertransmitObjectreceiveDate = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectreceiveDate, nameof(searchLeadsWrappertransmitObjectreceiveDate), required: false);
            var __workflow_searchLeadsWrappertransmitObjectstateEn = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectstateEn, nameof(searchLeadsWrappertransmitObjectstateEn), required: false);
            var __workflow_searchLeadsWrappertransmitObjectstreet = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectstreet, nameof(searchLeadsWrappertransmitObjectstreet), required: false);
            var __workflow_searchLeadsWrappertransmitObjecttypeEn = WorkflowExpression.Compile(searchLeadsWrappertransmitObjecttypeEn, nameof(searchLeadsWrappertransmitObjecttypeEn), required: false);
            var __workflow_searchLeadsWrappertransmitObjectzip = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectzip, nameof(searchLeadsWrappertransmitObjectzip), required: false);
            var __workflow_searchLeadsWrappertransmitObjectlastActivity = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectlastActivity, nameof(searchLeadsWrappertransmitObjectlastActivity), required: false);
            var __workflow_searchLeadsWrappertransmitObjectnextStep = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectnextStep, nameof(searchLeadsWrappertransmitObjectnextStep), required: false);
            var __workflow_searchLeadsWrappertransmitObjectestimatedValue = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectestimatedValue, nameof(searchLeadsWrappertransmitObjectestimatedValue), required: false);
            var __workflow_searchLeadsWrappertransmitObjectisCompleted = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectisCompleted, nameof(searchLeadsWrappertransmitObjectisCompleted), required: false);
            var __workflow_searchLeadsWrappertransmitObjectisLost = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectisLost, nameof(searchLeadsWrappertransmitObjectisLost), required: false);
            var __workflow_searchLeadsWrappertransmitObjectcountryEn = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectcountryEn, nameof(searchLeadsWrappertransmitObjectcountryEn), required: false);
            var __workflow_searchLeadsWrappertransmitObjectstate = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectstate, nameof(searchLeadsWrappertransmitObjectstate), required: false);
            var __workflow_searchLeadsWrappertransmitObjectpOBox = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectpOBox, nameof(searchLeadsWrappertransmitObjectpOBox), required: false);
            var __workflow_searchLeadsWrappertransmitObjectemailOptOut = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectemailOptOut, nameof(searchLeadsWrappertransmitObjectemailOptOut), required: false);
            var __workflow_searchLeadsWrappertransmitObjectpicture = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectpicture, nameof(searchLeadsWrappertransmitObjectpicture), required: false);
            var __workflow_searchLeadsWrappertransmitObjectpictureWidth = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectpictureWidth, nameof(searchLeadsWrappertransmitObjectpictureWidth), required: false);
            var __workflow_searchLeadsWrappertransmitObjectpictureHeight = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectpictureHeight, nameof(searchLeadsWrappertransmitObjectpictureHeight), required: false);
            var __workflow_searchLeadsWrappertransmitObjectcompletedDate = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectcompletedDate, nameof(searchLeadsWrappertransmitObjectcompletedDate), required: false);
            var __workflow_searchLeadsWrappertransmitObjectlostDate = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectlostDate, nameof(searchLeadsWrappertransmitObjectlostDate), required: false);
            var __workflow_searchLeadsWrappertransmitObjectisPrivate = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectisPrivate, nameof(searchLeadsWrappertransmitObjectisPrivate), required: false);
            var __workflow_searchLeadsWrappertransmitObjectserverItemCreated = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectserverItemCreated, nameof(searchLeadsWrappertransmitObjectserverItemCreated), required: false);
            var __workflow_searchLeadsWrappertransmitObjectserverItemChanged = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectserverItemChanged, nameof(searchLeadsWrappertransmitObjectserverItemChanged), required: false);
            var __workflow_searchLeadsWrappertransmitObjectitemCreated = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectitemCreated, nameof(searchLeadsWrappertransmitObjectitemCreated), required: false);
            var __workflow_searchLeadsWrappertransmitObjectitemChanged = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectitemChanged, nameof(searchLeadsWrappertransmitObjectitemChanged), required: false);
            var __workflow_searchLeadsWrappertransmitObjectfileAs = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectfileAs, nameof(searchLeadsWrappertransmitObjectfileAs), required: false);
            var __workflow_searchLeadsWrappertransmitObjectownerGUID = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectownerGUID, nameof(searchLeadsWrappertransmitObjectownerGUID), required: false);
            var __workflow_searchLeadsWrappertransmitObjectcreatedByGUID = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectcreatedByGUID, nameof(searchLeadsWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_searchLeadsWrappertransmitObjectmodifiedByGUID = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectmodifiedByGUID, nameof(searchLeadsWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_searchLeadsWrappertransmitObjectadditionalFields = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectadditionalFields, nameof(searchLeadsWrappertransmitObjectadditionalFields), required: false);
            var __workflow_searchLeadsWrappertransmitObjectrelations = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectrelations, nameof(searchLeadsWrappertransmitObjectrelations), required: false);
            var __workflow_searchLeadsWrappertransmitObjectitemGUID = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectitemGUID, nameof(searchLeadsWrappertransmitObjectitemGUID), required: false);
            var __workflow_searchLeadsWrappertransmitObjectitemVersion = WorkflowExpression.Compile(searchLeadsWrappertransmitObjectitemVersion, nameof(searchLeadsWrappertransmitObjectitemVersion), required: false);
            var __workflow_searchLeadsWrapperincludeRelations = WorkflowExpression.Compile(searchLeadsWrapperincludeRelations, nameof(searchLeadsWrapperincludeRelations), required: false);
            var __workflow_searchLeadsWrapperrelationsFilterrelationType = WorkflowExpression.Compile(searchLeadsWrapperrelationsFilterrelationType, nameof(searchLeadsWrapperrelationsFilterrelationType), required: false);
            var __workflow_searchLeadsWrapperrelationsFilterforeignFolderName = WorkflowExpression.Compile(searchLeadsWrapperrelationsFilterforeignFolderName, nameof(searchLeadsWrapperrelationsFilterforeignFolderName), required: false);
            var __workflow_searchLeadsWrapperbinaryLogicalOperator = WorkflowExpression.Compile(searchLeadsWrapperbinaryLogicalOperator, nameof(searchLeadsWrapperbinaryLogicalOperator), required: false);
            return new DeferredBodyAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead>(() =>
            {
                var apiCallPath = "/SearchLeads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var searchLeadsWrapper = new JObject();
                var searchLeadsWrapperpropCount = 0;
                var transmitObjectObject = new JObject();
                var transmitObjectObjectpropCount = 0;
                if (__workflow_searchLeadsWrappertransmitObjectcompaniesCustomerGuid != null)
                {
                    transmitObjectObject["Companies_CustomerGuid"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectcompaniesCustomerGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectcontactsContactPersonGuid != null)
                {
                    transmitObjectObject["Contacts_ContactPersonGuid"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectcontactsContactPersonGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectmarketingMarketingGuid != null)
                {
                    transmitObjectObject["Marketing_MarketingGuid"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectmarketingMarketingGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectcity != null)
                {
                    transmitObjectObject["City"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectcity);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectcontactPerson != null)
                {
                    transmitObjectObject["ContactPerson"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectcontactPerson);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectcurrencyEn != null)
                {
                    transmitObjectObject["CurrencyEn"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectcurrencyEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectcustomer != null)
                {
                    transmitObjectObject["Customer"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectcustomer);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectemail != null)
                {
                    transmitObjectObject["Email"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectemail);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectestimatedEnd != null)
                {
                    transmitObjectObject["EstimatedEnd"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectestimatedEnd);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjecthID != null)
                {
                    transmitObjectObject["HID"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjecthID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectleadOriginEn != null)
                {
                    transmitObjectObject["LeadOriginEn"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectleadOriginEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectnote != null)
                {
                    transmitObjectObject["Note"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectnote);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectphone != null)
                {
                    transmitObjectObject["Phone"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectphone);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectphoneNormalized != null)
                {
                    transmitObjectObject["PhoneNormalized"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectphoneNormalized);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectprice != null)
                {
                    transmitObjectObject["Price"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectprice);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectpriceChanged != null)
                {
                    transmitObjectObject["PriceChanged"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectpriceChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectpriceDefaultCurrency != null)
                {
                    transmitObjectObject["PriceDefaultCurrency"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectpriceDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectprobability != null)
                {
                    transmitObjectObject["Probability"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectprobability);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectreceiveDate != null)
                {
                    transmitObjectObject["ReceiveDate"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectreceiveDate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectstreet != null)
                {
                    transmitObjectObject["Street"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectstreet);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectzip != null)
                {
                    transmitObjectObject["Zip"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectzip);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectlastActivity != null)
                {
                    transmitObjectObject["LastActivity"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectlastActivity);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectnextStep != null)
                {
                    transmitObjectObject["NextStep"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectnextStep);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectestimatedValue != null)
                {
                    transmitObjectObject["EstimatedValue"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectestimatedValue);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectisCompleted != null)
                {
                    transmitObjectObject["IsCompleted"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectisCompleted);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectisLost != null)
                {
                    transmitObjectObject["IsLost"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectisLost);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectcountryEn != null)
                {
                    transmitObjectObject["CountryEn"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectcountryEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectstate != null)
                {
                    transmitObjectObject["State"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectstate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectpOBox != null)
                {
                    transmitObjectObject["POBox"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectpOBox);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectemailOptOut != null)
                {
                    transmitObjectObject["EmailOptOut"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectemailOptOut);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectpicture != null)
                {
                    transmitObjectObject["Picture"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectpicture);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectpictureWidth != null)
                {
                    transmitObjectObject["PictureWidth"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectpictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectpictureHeight != null)
                {
                    transmitObjectObject["PictureHeight"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectpictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectcompletedDate != null)
                {
                    transmitObjectObject["CompletedDate"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectcompletedDate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectlostDate != null)
                {
                    transmitObjectObject["LostDate"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectlostDate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectserverItemCreated != null)
                {
                    transmitObjectObject["Server_ItemCreated"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectserverItemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectserverItemChanged != null)
                {
                    transmitObjectObject["Server_ItemChanged"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectserverItemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectrelations != null)
                {
                    transmitObjectObject["Relations"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectrelations);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchLeadsWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    searchLeadsWrapper["transmitObject"] = transmitObjectObject;
                    searchLeadsWrapperpropCount++;
                }

                if (__workflow_searchLeadsWrapperincludeRelations != null)
                {
                    searchLeadsWrapper["includeRelations"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrapperincludeRelations);
                    searchLeadsWrapperpropCount++;
                }

                var relationsFilterObject = new JObject();
                var relationsFilterObjectpropCount = 0;
                if (__workflow_searchLeadsWrapperrelationsFilterrelationType != null)
                {
                    relationsFilterObject["RelationType"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrapperrelationsFilterrelationType);
                    relationsFilterObjectpropCount++;
                }

                if (__workflow_searchLeadsWrapperrelationsFilterforeignFolderName != null)
                {
                    relationsFilterObject["ForeignFolderName"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrapperrelationsFilterforeignFolderName);
                    relationsFilterObjectpropCount++;
                }

                if (relationsFilterObjectpropCount > 0)
                {
                    searchLeadsWrapper["relationsFilter"] = relationsFilterObject;
                    searchLeadsWrapperpropCount++;
                }

                if (__workflow_searchLeadsWrapperbinaryLogicalOperator != null)
                {
                    searchLeadsWrapper["binaryLogicalOperator"] = ExpressionConverter.ConvertO(__workflow_searchLeadsWrapperbinaryLogicalOperator);
                    searchLeadsWrapperpropCount++;
                }

                if (searchLeadsWrapperpropCount > 0)
                {
                    callPayload.Body = searchLeadsWrapper;
                }

                return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject> SearchProjects(Expression<Func<string>> searchProjectsWrappertransmitObjectcompaniesCustomerGuid = null, Expression<Func<string>> searchProjectsWrappertransmitObjectcontactsContactPersonGuid = null, Expression<Func<string>> searchProjectsWrappertransmitObjectleadsProjectOriginGuid = null, Expression<Func<string>> searchProjectsWrappertransmitObjectprojectsSuperiorProjectGuid = null, Expression<Func<string>> searchProjectsWrappertransmitObjectusersSupervisorGuid = null, Expression<Func<string>> searchProjectsWrappertransmitObjectnote = null, Expression<Func<double>> searchProjectsWrappertransmitObjectprice = null, Expression<Func<string>> searchProjectsWrappertransmitObjectprojectEnd = null, Expression<Func<string>> searchProjectsWrappertransmitObjectprojectName = null, Expression<Func<string>> searchProjectsWrappertransmitObjecttypeEn = null, Expression<Func<string>> searchProjectsWrappertransmitObjectstateEn = null, Expression<Func<double>> searchProjectsWrappertransmitObjectpeopleExpenses = null, Expression<Func<string>> searchProjectsWrappertransmitObjectprojectRealEnd = null, Expression<Func<double>> searchProjectsWrappertransmitObjectestimatedPrice = null, Expression<Func<int>> searchProjectsWrappertransmitObjecthID = null, Expression<Func<string>> searchProjectsWrappertransmitObjectprojectOriginEn = null, Expression<Func<string>> searchProjectsWrappertransmitObjectpaymentTypeEn = null, Expression<Func<double>> searchProjectsWrappertransmitObjectotherExpenses = null, Expression<Func<double>> searchProjectsWrappertransmitObjectmargin = null, Expression<Func<double>> searchProjectsWrappertransmitObjectprofit = null, Expression<Func<int>> searchProjectsWrappertransmitObjectpaymentMaturity = null, Expression<Func<string>> searchProjectsWrappertransmitObjectinvoicePaymentDate = null, Expression<Func<string>> searchProjectsWrappertransmitObjectinvoiceIssueDate = null, Expression<Func<double>> searchProjectsWrappertransmitObjectestimatedMargin = null, Expression<Func<double>> searchProjectsWrappertransmitObjectestimatedProfit = null, Expression<Func<double>> searchProjectsWrappertransmitObjectestimatedPeopleExpenses = null, Expression<Func<double>> searchProjectsWrappertransmitObjectestimatedOtherExpenses = null, Expression<Func<int>> searchProjectsWrappertransmitObjectlicensesCount = null, Expression<Func<double>> searchProjectsWrappertransmitObjectlicensePrice = null, Expression<Func<string>> searchProjectsWrappertransmitObjectprevStateEn = null, Expression<Func<bool>> searchProjectsWrappertransmitObjectshowInCaplan = null, Expression<Func<string>> searchProjectsWrappertransmitObjectprojectStart = null, Expression<Func<int>> searchProjectsWrappertransmitObjectestimatedWorkHours = null, Expression<Func<double>> searchProjectsWrappertransmitObjecttotalWorkHours = null, Expression<Func<double>> searchProjectsWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency = null, Expression<Func<double>> searchProjectsWrappertransmitObjectestimatedOtherExpensesDefaultCurrency = null, Expression<Func<double>> searchProjectsWrappertransmitObjectestimatedPriceDefaultCurrency = null, Expression<Func<double>> searchProjectsWrappertransmitObjectpeopleExpensesDefaultCurrency = null, Expression<Func<double>> searchProjectsWrappertransmitObjectotherExpensesDefaultCurrency = null, Expression<Func<double>> searchProjectsWrappertransmitObjectpriceDefaultCurrency = null, Expression<Func<double>> searchProjectsWrappertransmitObjectprofitDefaultCurrency = null, Expression<Func<double>> searchProjectsWrappertransmitObjectestimatedProfitDefaultCurrency = null, Expression<Func<string>> searchProjectsWrappertransmitObjectcurrencyEn = null, Expression<Func<string>> searchProjectsWrappertransmitObjectestimatedPeopleExpensesChanged = null, Expression<Func<string>> searchProjectsWrappertransmitObjectestimatedOtherExpensesChanged = null, Expression<Func<string>> searchProjectsWrappertransmitObjectotherExpensesChanged = null, Expression<Func<string>> searchProjectsWrappertransmitObjectestimatedPriceChanged = null, Expression<Func<string>> searchProjectsWrappertransmitObjectpriceChanged = null, Expression<Func<string>> searchProjectsWrappertransmitObjectlicensePriceChanged = null, Expression<Func<double>> searchProjectsWrappertransmitObjectlicensePriceDefaultCurrency = null, Expression<Func<string>> searchProjectsWrappertransmitObjectlastActivity = null, Expression<Func<string>> searchProjectsWrappertransmitObjectnextStep = null, Expression<Func<string>> searchProjectsWrappertransmitObjectcompletedDate = null, Expression<Func<bool>> searchProjectsWrappertransmitObjectisCompleted = null, Expression<Func<string>> searchProjectsWrappertransmitObjectlostDate = null, Expression<Func<bool>> searchProjectsWrappertransmitObjectisLost = null, Expression<Func<string>> searchProjectsWrappertransmitObjectpeopleExpensesChanged = null, Expression<Func<string>> searchProjectsWrappertransmitObjectpicture = null, Expression<Func<int>> searchProjectsWrappertransmitObjectpictureWidth = null, Expression<Func<int>> searchProjectsWrappertransmitObjectpictureHeight = null, Expression<Func<bool>> searchProjectsWrappertransmitObjectisPrivate = null, Expression<Func<string>> searchProjectsWrappertransmitObjectserverItemCreated = null, Expression<Func<string>> searchProjectsWrappertransmitObjectserverItemChanged = null, Expression<Func<string>> searchProjectsWrappertransmitObjectitemCreated = null, Expression<Func<string>> searchProjectsWrappertransmitObjectitemChanged = null, Expression<Func<string>> searchProjectsWrappertransmitObjectfileAs = null, Expression<Func<string>> searchProjectsWrappertransmitObjectownerGUID = null, Expression<Func<string>> searchProjectsWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> searchProjectsWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> searchProjectsWrappertransmitObjectadditionalFields = null, Expression<Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]>> searchProjectsWrappertransmitObjectrelations = null, Expression<Func<string>> searchProjectsWrappertransmitObjectitemGUID = null, Expression<Func<int>> searchProjectsWrappertransmitObjectitemVersion = null, Expression<Func<bool>> searchProjectsWrapperincludeRelations = null, Expression<Func<string>> searchProjectsWrapperrelationsFilterrelationType = null, Expression<Func<string>> searchProjectsWrapperrelationsFilterforeignFolderName = null, Expression<Func<string>> searchProjectsWrapperbinaryLogicalOperator = null)
        {
            var __workflow_searchProjectsWrappertransmitObjectcompaniesCustomerGuid = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectcompaniesCustomerGuid, nameof(searchProjectsWrappertransmitObjectcompaniesCustomerGuid), required: false);
            var __workflow_searchProjectsWrappertransmitObjectcontactsContactPersonGuid = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectcontactsContactPersonGuid, nameof(searchProjectsWrappertransmitObjectcontactsContactPersonGuid), required: false);
            var __workflow_searchProjectsWrappertransmitObjectleadsProjectOriginGuid = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectleadsProjectOriginGuid, nameof(searchProjectsWrappertransmitObjectleadsProjectOriginGuid), required: false);
            var __workflow_searchProjectsWrappertransmitObjectprojectsSuperiorProjectGuid = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectprojectsSuperiorProjectGuid, nameof(searchProjectsWrappertransmitObjectprojectsSuperiorProjectGuid), required: false);
            var __workflow_searchProjectsWrappertransmitObjectusersSupervisorGuid = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectusersSupervisorGuid, nameof(searchProjectsWrappertransmitObjectusersSupervisorGuid), required: false);
            var __workflow_searchProjectsWrappertransmitObjectnote = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectnote, nameof(searchProjectsWrappertransmitObjectnote), required: false);
            var __workflow_searchProjectsWrappertransmitObjectprice = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectprice, nameof(searchProjectsWrappertransmitObjectprice), required: false);
            var __workflow_searchProjectsWrappertransmitObjectprojectEnd = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectprojectEnd, nameof(searchProjectsWrappertransmitObjectprojectEnd), required: false);
            var __workflow_searchProjectsWrappertransmitObjectprojectName = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectprojectName, nameof(searchProjectsWrappertransmitObjectprojectName), required: false);
            var __workflow_searchProjectsWrappertransmitObjecttypeEn = WorkflowExpression.Compile(searchProjectsWrappertransmitObjecttypeEn, nameof(searchProjectsWrappertransmitObjecttypeEn), required: false);
            var __workflow_searchProjectsWrappertransmitObjectstateEn = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectstateEn, nameof(searchProjectsWrappertransmitObjectstateEn), required: false);
            var __workflow_searchProjectsWrappertransmitObjectpeopleExpenses = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectpeopleExpenses, nameof(searchProjectsWrappertransmitObjectpeopleExpenses), required: false);
            var __workflow_searchProjectsWrappertransmitObjectprojectRealEnd = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectprojectRealEnd, nameof(searchProjectsWrappertransmitObjectprojectRealEnd), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedPrice = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedPrice, nameof(searchProjectsWrappertransmitObjectestimatedPrice), required: false);
            var __workflow_searchProjectsWrappertransmitObjecthID = WorkflowExpression.Compile(searchProjectsWrappertransmitObjecthID, nameof(searchProjectsWrappertransmitObjecthID), required: false);
            var __workflow_searchProjectsWrappertransmitObjectprojectOriginEn = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectprojectOriginEn, nameof(searchProjectsWrappertransmitObjectprojectOriginEn), required: false);
            var __workflow_searchProjectsWrappertransmitObjectpaymentTypeEn = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectpaymentTypeEn, nameof(searchProjectsWrappertransmitObjectpaymentTypeEn), required: false);
            var __workflow_searchProjectsWrappertransmitObjectotherExpenses = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectotherExpenses, nameof(searchProjectsWrappertransmitObjectotherExpenses), required: false);
            var __workflow_searchProjectsWrappertransmitObjectmargin = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectmargin, nameof(searchProjectsWrappertransmitObjectmargin), required: false);
            var __workflow_searchProjectsWrappertransmitObjectprofit = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectprofit, nameof(searchProjectsWrappertransmitObjectprofit), required: false);
            var __workflow_searchProjectsWrappertransmitObjectpaymentMaturity = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectpaymentMaturity, nameof(searchProjectsWrappertransmitObjectpaymentMaturity), required: false);
            var __workflow_searchProjectsWrappertransmitObjectinvoicePaymentDate = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectinvoicePaymentDate, nameof(searchProjectsWrappertransmitObjectinvoicePaymentDate), required: false);
            var __workflow_searchProjectsWrappertransmitObjectinvoiceIssueDate = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectinvoiceIssueDate, nameof(searchProjectsWrappertransmitObjectinvoiceIssueDate), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedMargin = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedMargin, nameof(searchProjectsWrappertransmitObjectestimatedMargin), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedProfit = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedProfit, nameof(searchProjectsWrappertransmitObjectestimatedProfit), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedPeopleExpenses = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedPeopleExpenses, nameof(searchProjectsWrappertransmitObjectestimatedPeopleExpenses), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedOtherExpenses = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedOtherExpenses, nameof(searchProjectsWrappertransmitObjectestimatedOtherExpenses), required: false);
            var __workflow_searchProjectsWrappertransmitObjectlicensesCount = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectlicensesCount, nameof(searchProjectsWrappertransmitObjectlicensesCount), required: false);
            var __workflow_searchProjectsWrappertransmitObjectlicensePrice = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectlicensePrice, nameof(searchProjectsWrappertransmitObjectlicensePrice), required: false);
            var __workflow_searchProjectsWrappertransmitObjectprevStateEn = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectprevStateEn, nameof(searchProjectsWrappertransmitObjectprevStateEn), required: false);
            var __workflow_searchProjectsWrappertransmitObjectshowInCaplan = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectshowInCaplan, nameof(searchProjectsWrappertransmitObjectshowInCaplan), required: false);
            var __workflow_searchProjectsWrappertransmitObjectprojectStart = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectprojectStart, nameof(searchProjectsWrappertransmitObjectprojectStart), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedWorkHours = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedWorkHours, nameof(searchProjectsWrappertransmitObjectestimatedWorkHours), required: false);
            var __workflow_searchProjectsWrappertransmitObjecttotalWorkHours = WorkflowExpression.Compile(searchProjectsWrappertransmitObjecttotalWorkHours, nameof(searchProjectsWrappertransmitObjecttotalWorkHours), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency, nameof(searchProjectsWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedOtherExpensesDefaultCurrency = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedOtherExpensesDefaultCurrency, nameof(searchProjectsWrappertransmitObjectestimatedOtherExpensesDefaultCurrency), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedPriceDefaultCurrency = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedPriceDefaultCurrency, nameof(searchProjectsWrappertransmitObjectestimatedPriceDefaultCurrency), required: false);
            var __workflow_searchProjectsWrappertransmitObjectpeopleExpensesDefaultCurrency = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectpeopleExpensesDefaultCurrency, nameof(searchProjectsWrappertransmitObjectpeopleExpensesDefaultCurrency), required: false);
            var __workflow_searchProjectsWrappertransmitObjectotherExpensesDefaultCurrency = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectotherExpensesDefaultCurrency, nameof(searchProjectsWrappertransmitObjectotherExpensesDefaultCurrency), required: false);
            var __workflow_searchProjectsWrappertransmitObjectpriceDefaultCurrency = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectpriceDefaultCurrency, nameof(searchProjectsWrappertransmitObjectpriceDefaultCurrency), required: false);
            var __workflow_searchProjectsWrappertransmitObjectprofitDefaultCurrency = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectprofitDefaultCurrency, nameof(searchProjectsWrappertransmitObjectprofitDefaultCurrency), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedProfitDefaultCurrency = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedProfitDefaultCurrency, nameof(searchProjectsWrappertransmitObjectestimatedProfitDefaultCurrency), required: false);
            var __workflow_searchProjectsWrappertransmitObjectcurrencyEn = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectcurrencyEn, nameof(searchProjectsWrappertransmitObjectcurrencyEn), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedPeopleExpensesChanged = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedPeopleExpensesChanged, nameof(searchProjectsWrappertransmitObjectestimatedPeopleExpensesChanged), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedOtherExpensesChanged = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedOtherExpensesChanged, nameof(searchProjectsWrappertransmitObjectestimatedOtherExpensesChanged), required: false);
            var __workflow_searchProjectsWrappertransmitObjectotherExpensesChanged = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectotherExpensesChanged, nameof(searchProjectsWrappertransmitObjectotherExpensesChanged), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedPriceChanged = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedPriceChanged, nameof(searchProjectsWrappertransmitObjectestimatedPriceChanged), required: false);
            var __workflow_searchProjectsWrappertransmitObjectpriceChanged = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectpriceChanged, nameof(searchProjectsWrappertransmitObjectpriceChanged), required: false);
            var __workflow_searchProjectsWrappertransmitObjectlicensePriceChanged = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectlicensePriceChanged, nameof(searchProjectsWrappertransmitObjectlicensePriceChanged), required: false);
            var __workflow_searchProjectsWrappertransmitObjectlicensePriceDefaultCurrency = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectlicensePriceDefaultCurrency, nameof(searchProjectsWrappertransmitObjectlicensePriceDefaultCurrency), required: false);
            var __workflow_searchProjectsWrappertransmitObjectlastActivity = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectlastActivity, nameof(searchProjectsWrappertransmitObjectlastActivity), required: false);
            var __workflow_searchProjectsWrappertransmitObjectnextStep = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectnextStep, nameof(searchProjectsWrappertransmitObjectnextStep), required: false);
            var __workflow_searchProjectsWrappertransmitObjectcompletedDate = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectcompletedDate, nameof(searchProjectsWrappertransmitObjectcompletedDate), required: false);
            var __workflow_searchProjectsWrappertransmitObjectisCompleted = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectisCompleted, nameof(searchProjectsWrappertransmitObjectisCompleted), required: false);
            var __workflow_searchProjectsWrappertransmitObjectlostDate = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectlostDate, nameof(searchProjectsWrappertransmitObjectlostDate), required: false);
            var __workflow_searchProjectsWrappertransmitObjectisLost = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectisLost, nameof(searchProjectsWrappertransmitObjectisLost), required: false);
            var __workflow_searchProjectsWrappertransmitObjectpeopleExpensesChanged = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectpeopleExpensesChanged, nameof(searchProjectsWrappertransmitObjectpeopleExpensesChanged), required: false);
            var __workflow_searchProjectsWrappertransmitObjectpicture = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectpicture, nameof(searchProjectsWrappertransmitObjectpicture), required: false);
            var __workflow_searchProjectsWrappertransmitObjectpictureWidth = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectpictureWidth, nameof(searchProjectsWrappertransmitObjectpictureWidth), required: false);
            var __workflow_searchProjectsWrappertransmitObjectpictureHeight = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectpictureHeight, nameof(searchProjectsWrappertransmitObjectpictureHeight), required: false);
            var __workflow_searchProjectsWrappertransmitObjectisPrivate = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectisPrivate, nameof(searchProjectsWrappertransmitObjectisPrivate), required: false);
            var __workflow_searchProjectsWrappertransmitObjectserverItemCreated = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectserverItemCreated, nameof(searchProjectsWrappertransmitObjectserverItemCreated), required: false);
            var __workflow_searchProjectsWrappertransmitObjectserverItemChanged = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectserverItemChanged, nameof(searchProjectsWrappertransmitObjectserverItemChanged), required: false);
            var __workflow_searchProjectsWrappertransmitObjectitemCreated = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectitemCreated, nameof(searchProjectsWrappertransmitObjectitemCreated), required: false);
            var __workflow_searchProjectsWrappertransmitObjectitemChanged = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectitemChanged, nameof(searchProjectsWrappertransmitObjectitemChanged), required: false);
            var __workflow_searchProjectsWrappertransmitObjectfileAs = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectfileAs, nameof(searchProjectsWrappertransmitObjectfileAs), required: false);
            var __workflow_searchProjectsWrappertransmitObjectownerGUID = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectownerGUID, nameof(searchProjectsWrappertransmitObjectownerGUID), required: false);
            var __workflow_searchProjectsWrappertransmitObjectcreatedByGUID = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectcreatedByGUID, nameof(searchProjectsWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_searchProjectsWrappertransmitObjectmodifiedByGUID = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectmodifiedByGUID, nameof(searchProjectsWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_searchProjectsWrappertransmitObjectadditionalFields = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectadditionalFields, nameof(searchProjectsWrappertransmitObjectadditionalFields), required: false);
            var __workflow_searchProjectsWrappertransmitObjectrelations = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectrelations, nameof(searchProjectsWrappertransmitObjectrelations), required: false);
            var __workflow_searchProjectsWrappertransmitObjectitemGUID = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectitemGUID, nameof(searchProjectsWrappertransmitObjectitemGUID), required: false);
            var __workflow_searchProjectsWrappertransmitObjectitemVersion = WorkflowExpression.Compile(searchProjectsWrappertransmitObjectitemVersion, nameof(searchProjectsWrappertransmitObjectitemVersion), required: false);
            var __workflow_searchProjectsWrapperincludeRelations = WorkflowExpression.Compile(searchProjectsWrapperincludeRelations, nameof(searchProjectsWrapperincludeRelations), required: false);
            var __workflow_searchProjectsWrapperrelationsFilterrelationType = WorkflowExpression.Compile(searchProjectsWrapperrelationsFilterrelationType, nameof(searchProjectsWrapperrelationsFilterrelationType), required: false);
            var __workflow_searchProjectsWrapperrelationsFilterforeignFolderName = WorkflowExpression.Compile(searchProjectsWrapperrelationsFilterforeignFolderName, nameof(searchProjectsWrapperrelationsFilterforeignFolderName), required: false);
            var __workflow_searchProjectsWrapperbinaryLogicalOperator = WorkflowExpression.Compile(searchProjectsWrapperbinaryLogicalOperator, nameof(searchProjectsWrapperbinaryLogicalOperator), required: false);
            return new DeferredBodyAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject>(() =>
            {
                var apiCallPath = "/SearchProjects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var searchProjectsWrapper = new JObject();
                var searchProjectsWrapperpropCount = 0;
                var transmitObjectObject = new JObject();
                var transmitObjectObjectpropCount = 0;
                if (__workflow_searchProjectsWrappertransmitObjectcompaniesCustomerGuid != null)
                {
                    transmitObjectObject["Companies_CustomerGuid"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectcompaniesCustomerGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectcontactsContactPersonGuid != null)
                {
                    transmitObjectObject["Contacts_ContactPersonGuid"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectcontactsContactPersonGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectleadsProjectOriginGuid != null)
                {
                    transmitObjectObject["Leads_Project_OriginGuid"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectleadsProjectOriginGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectprojectsSuperiorProjectGuid != null)
                {
                    transmitObjectObject["Projects_SuperiorProjectGuid"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectprojectsSuperiorProjectGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectusersSupervisorGuid != null)
                {
                    transmitObjectObject["Users_SupervisorGuid"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectusersSupervisorGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectnote != null)
                {
                    transmitObjectObject["Note"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectnote);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectprice != null)
                {
                    transmitObjectObject["Price"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectprice);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectprojectEnd != null)
                {
                    transmitObjectObject["ProjectEnd"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectprojectEnd);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectprojectName != null)
                {
                    transmitObjectObject["ProjectName"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectprojectName);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectpeopleExpenses != null)
                {
                    transmitObjectObject["PeopleExpenses"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectpeopleExpenses);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectprojectRealEnd != null)
                {
                    transmitObjectObject["ProjectRealEnd"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectprojectRealEnd);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectestimatedPrice != null)
                {
                    transmitObjectObject["EstimatedPrice"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectestimatedPrice);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjecthID != null)
                {
                    transmitObjectObject["HID"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjecthID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectprojectOriginEn != null)
                {
                    transmitObjectObject["ProjectOriginEn"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectprojectOriginEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectpaymentTypeEn != null)
                {
                    transmitObjectObject["PaymentTypeEn"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectpaymentTypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectotherExpenses != null)
                {
                    transmitObjectObject["OtherExpenses"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectotherExpenses);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectmargin != null)
                {
                    transmitObjectObject["Margin"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectmargin);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectprofit != null)
                {
                    transmitObjectObject["Profit"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectprofit);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectpaymentMaturity != null)
                {
                    transmitObjectObject["PaymentMaturity"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectpaymentMaturity);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectinvoicePaymentDate != null)
                {
                    transmitObjectObject["InvoicePaymentDate"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectinvoicePaymentDate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectinvoiceIssueDate != null)
                {
                    transmitObjectObject["InvoiceIssueDate"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectinvoiceIssueDate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectestimatedMargin != null)
                {
                    transmitObjectObject["EstimatedMargin"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectestimatedMargin);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectestimatedProfit != null)
                {
                    transmitObjectObject["EstimatedProfit"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectestimatedProfit);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectestimatedPeopleExpenses != null)
                {
                    transmitObjectObject["EstimatedPeopleExpenses"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectestimatedPeopleExpenses);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectestimatedOtherExpenses != null)
                {
                    transmitObjectObject["EstimatedOtherExpenses"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectestimatedOtherExpenses);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectlicensesCount != null)
                {
                    transmitObjectObject["LicensesCount"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectlicensesCount);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectlicensePrice != null)
                {
                    transmitObjectObject["LicensePrice"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectlicensePrice);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectshowInCaplan != null)
                {
                    transmitObjectObject["ShowInCaplan"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectshowInCaplan);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectprojectStart != null)
                {
                    transmitObjectObject["ProjectStart"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectprojectStart);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectestimatedWorkHours != null)
                {
                    transmitObjectObject["EstimatedWorkHours"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectestimatedWorkHours);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjecttotalWorkHours != null)
                {
                    transmitObjectObject["TotalWorkHours"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjecttotalWorkHours);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency != null)
                {
                    transmitObjectObject["EstimatedPeopleExpensesDefaultCurrency"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectestimatedOtherExpensesDefaultCurrency != null)
                {
                    transmitObjectObject["EstimatedOtherExpensesDefaultCurrency"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectestimatedOtherExpensesDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectestimatedPriceDefaultCurrency != null)
                {
                    transmitObjectObject["EstimatedPriceDefaultCurrency"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectestimatedPriceDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectpeopleExpensesDefaultCurrency != null)
                {
                    transmitObjectObject["PeopleExpensesDefaultCurrency"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectpeopleExpensesDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectotherExpensesDefaultCurrency != null)
                {
                    transmitObjectObject["OtherExpensesDefaultCurrency"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectotherExpensesDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectpriceDefaultCurrency != null)
                {
                    transmitObjectObject["PriceDefaultCurrency"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectpriceDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectprofitDefaultCurrency != null)
                {
                    transmitObjectObject["ProfitDefaultCurrency"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectprofitDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectestimatedProfitDefaultCurrency != null)
                {
                    transmitObjectObject["EstimatedProfitDefaultCurrency"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectestimatedProfitDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectcurrencyEn != null)
                {
                    transmitObjectObject["CurrencyEn"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectcurrencyEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectestimatedPeopleExpensesChanged != null)
                {
                    transmitObjectObject["EstimatedPeopleExpensesChanged"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectestimatedPeopleExpensesChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectestimatedOtherExpensesChanged != null)
                {
                    transmitObjectObject["EstimatedOtherExpensesChanged"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectestimatedOtherExpensesChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectotherExpensesChanged != null)
                {
                    transmitObjectObject["OtherExpensesChanged"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectotherExpensesChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectestimatedPriceChanged != null)
                {
                    transmitObjectObject["EstimatedPriceChanged"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectestimatedPriceChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectpriceChanged != null)
                {
                    transmitObjectObject["PriceChanged"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectpriceChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectlicensePriceChanged != null)
                {
                    transmitObjectObject["LicensePriceChanged"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectlicensePriceChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectlicensePriceDefaultCurrency != null)
                {
                    transmitObjectObject["LicensePriceDefaultCurrency"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectlicensePriceDefaultCurrency);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectlastActivity != null)
                {
                    transmitObjectObject["LastActivity"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectlastActivity);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectnextStep != null)
                {
                    transmitObjectObject["NextStep"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectnextStep);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectcompletedDate != null)
                {
                    transmitObjectObject["CompletedDate"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectcompletedDate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectisCompleted != null)
                {
                    transmitObjectObject["IsCompleted"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectisCompleted);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectlostDate != null)
                {
                    transmitObjectObject["LostDate"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectlostDate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectisLost != null)
                {
                    transmitObjectObject["IsLost"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectisLost);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectpeopleExpensesChanged != null)
                {
                    transmitObjectObject["PeopleExpensesChanged"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectpeopleExpensesChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectpicture != null)
                {
                    transmitObjectObject["Picture"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectpicture);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectpictureWidth != null)
                {
                    transmitObjectObject["PictureWidth"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectpictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectpictureHeight != null)
                {
                    transmitObjectObject["PictureHeight"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectpictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectserverItemCreated != null)
                {
                    transmitObjectObject["Server_ItemCreated"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectserverItemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectserverItemChanged != null)
                {
                    transmitObjectObject["Server_ItemChanged"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectserverItemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectrelations != null)
                {
                    transmitObjectObject["Relations"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectrelations);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchProjectsWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    searchProjectsWrapper["transmitObject"] = transmitObjectObject;
                    searchProjectsWrapperpropCount++;
                }

                if (__workflow_searchProjectsWrapperincludeRelations != null)
                {
                    searchProjectsWrapper["includeRelations"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrapperincludeRelations);
                    searchProjectsWrapperpropCount++;
                }

                var relationsFilterObject = new JObject();
                var relationsFilterObjectpropCount = 0;
                if (__workflow_searchProjectsWrapperrelationsFilterrelationType != null)
                {
                    relationsFilterObject["RelationType"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrapperrelationsFilterrelationType);
                    relationsFilterObjectpropCount++;
                }

                if (__workflow_searchProjectsWrapperrelationsFilterforeignFolderName != null)
                {
                    relationsFilterObject["ForeignFolderName"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrapperrelationsFilterforeignFolderName);
                    relationsFilterObjectpropCount++;
                }

                if (relationsFilterObjectpropCount > 0)
                {
                    searchProjectsWrapper["relationsFilter"] = relationsFilterObject;
                    searchProjectsWrapperpropCount++;
                }

                if (__workflow_searchProjectsWrapperbinaryLogicalOperator != null)
                {
                    searchProjectsWrapper["binaryLogicalOperator"] = ExpressionConverter.ConvertO(__workflow_searchProjectsWrapperbinaryLogicalOperator);
                    searchProjectsWrapperpropCount++;
                }

                if (searchProjectsWrapperpropCount > 0)
                {
                    callPayload.Body = searchProjectsWrapper;
                }

                return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask> SearchTasks(Expression<Func<string>> searchTasksWrappertransmitObjectleadsTopLevelProjectGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjectleadsTaskParentGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjectprojectsTopLevelProjectGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjectprojectsTaskParentGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjecttasksTaskParentGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjectmarketingTopLevelProjectGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjectmarketingTaskParentGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjectcompaniesCompanyGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjectcontactsContactGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjectusersTaskDelegatorGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjectusersTaskSolverGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjecttasksTaskOriginGuid = null, Expression<Func<string>> searchTasksWrappertransmitObjectbody = null, Expression<Func<bool>> searchTasksWrappertransmitObjectisCompleted = null, Expression<Func<string>> searchTasksWrappertransmitObjectdueDate = null, Expression<Func<double>> searchTasksWrappertransmitObjectpercentCompleteDecimal = null, Expression<Func<string>> searchTasksWrappertransmitObjectprevStateEn = null, Expression<Func<string>> searchTasksWrappertransmitObjectstartDate = null, Expression<Func<string>> searchTasksWrappertransmitObjectstateEn = null, Expression<Func<string>> searchTasksWrappertransmitObjectsubject = null, Expression<Func<string>> searchTasksWrappertransmitObjecttypeEn = null, Expression<Func<int>> searchTasksWrappertransmitObjectlevel = null, Expression<Func<string>> searchTasksWrappertransmitObjectimportanceEn = null, Expression<Func<double>> searchTasksWrappertransmitObjectactualWorkHours = null, Expression<Func<double>> searchTasksWrappertransmitObjectestimatedWorkHours = null, Expression<Func<bool>> searchTasksWrappertransmitObjectisReminderSet = null, Expression<Func<string>> searchTasksWrappertransmitObjectreminderDate = null, Expression<Func<string>> searchTasksWrappertransmitObjectcompletedDate = null, Expression<Func<string>> searchTasksWrappertransmitObjectpicture = null, Expression<Func<int>> searchTasksWrappertransmitObjectpictureWidth = null, Expression<Func<int>> searchTasksWrappertransmitObjectpictureHeight = null, Expression<Func<bool>> searchTasksWrappertransmitObjectisPrivate = null, Expression<Func<string>> searchTasksWrappertransmitObjectserverItemCreated = null, Expression<Func<string>> searchTasksWrappertransmitObjectserverItemChanged = null, Expression<Func<string>> searchTasksWrappertransmitObjectitemCreated = null, Expression<Func<string>> searchTasksWrappertransmitObjectitemChanged = null, Expression<Func<string>> searchTasksWrappertransmitObjectfileAs = null, Expression<Func<string>> searchTasksWrappertransmitObjectownerGUID = null, Expression<Func<string>> searchTasksWrappertransmitObjectcreatedByGUID = null, Expression<Func<string>> searchTasksWrappertransmitObjectmodifiedByGUID = null, Expression<Func<object>> searchTasksWrappertransmitObjectadditionalFields = null, Expression<Func<EWayWcfServiceItemTypesInnerTypesBoundRelation[]>> searchTasksWrappertransmitObjectrelations = null, Expression<Func<string>> searchTasksWrappertransmitObjectitemGUID = null, Expression<Func<int>> searchTasksWrappertransmitObjectitemVersion = null, Expression<Func<bool>> searchTasksWrapperincludeRelations = null, Expression<Func<string>> searchTasksWrapperrelationsFilterrelationType = null, Expression<Func<string>> searchTasksWrapperrelationsFilterforeignFolderName = null, Expression<Func<string>> searchTasksWrapperbinaryLogicalOperator = null)
        {
            var __workflow_searchTasksWrappertransmitObjectleadsTopLevelProjectGuid = WorkflowExpression.Compile(searchTasksWrappertransmitObjectleadsTopLevelProjectGuid, nameof(searchTasksWrappertransmitObjectleadsTopLevelProjectGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjectleadsTaskParentGuid = WorkflowExpression.Compile(searchTasksWrappertransmitObjectleadsTaskParentGuid, nameof(searchTasksWrappertransmitObjectleadsTaskParentGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjectprojectsTopLevelProjectGuid = WorkflowExpression.Compile(searchTasksWrappertransmitObjectprojectsTopLevelProjectGuid, nameof(searchTasksWrappertransmitObjectprojectsTopLevelProjectGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjectprojectsTaskParentGuid = WorkflowExpression.Compile(searchTasksWrappertransmitObjectprojectsTaskParentGuid, nameof(searchTasksWrappertransmitObjectprojectsTaskParentGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjecttasksTaskParentGuid = WorkflowExpression.Compile(searchTasksWrappertransmitObjecttasksTaskParentGuid, nameof(searchTasksWrappertransmitObjecttasksTaskParentGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjectmarketingTopLevelProjectGuid = WorkflowExpression.Compile(searchTasksWrappertransmitObjectmarketingTopLevelProjectGuid, nameof(searchTasksWrappertransmitObjectmarketingTopLevelProjectGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjectmarketingTaskParentGuid = WorkflowExpression.Compile(searchTasksWrappertransmitObjectmarketingTaskParentGuid, nameof(searchTasksWrappertransmitObjectmarketingTaskParentGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjectcompaniesCompanyGuid = WorkflowExpression.Compile(searchTasksWrappertransmitObjectcompaniesCompanyGuid, nameof(searchTasksWrappertransmitObjectcompaniesCompanyGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjectcontactsContactGuid = WorkflowExpression.Compile(searchTasksWrappertransmitObjectcontactsContactGuid, nameof(searchTasksWrappertransmitObjectcontactsContactGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjectusersTaskDelegatorGuid = WorkflowExpression.Compile(searchTasksWrappertransmitObjectusersTaskDelegatorGuid, nameof(searchTasksWrappertransmitObjectusersTaskDelegatorGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjectusersTaskSolverGuid = WorkflowExpression.Compile(searchTasksWrappertransmitObjectusersTaskSolverGuid, nameof(searchTasksWrappertransmitObjectusersTaskSolverGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjecttasksTaskOriginGuid = WorkflowExpression.Compile(searchTasksWrappertransmitObjecttasksTaskOriginGuid, nameof(searchTasksWrappertransmitObjecttasksTaskOriginGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjectbody = WorkflowExpression.Compile(searchTasksWrappertransmitObjectbody, nameof(searchTasksWrappertransmitObjectbody), required: false);
            var __workflow_searchTasksWrappertransmitObjectisCompleted = WorkflowExpression.Compile(searchTasksWrappertransmitObjectisCompleted, nameof(searchTasksWrappertransmitObjectisCompleted), required: false);
            var __workflow_searchTasksWrappertransmitObjectdueDate = WorkflowExpression.Compile(searchTasksWrappertransmitObjectdueDate, nameof(searchTasksWrappertransmitObjectdueDate), required: false);
            var __workflow_searchTasksWrappertransmitObjectpercentCompleteDecimal = WorkflowExpression.Compile(searchTasksWrappertransmitObjectpercentCompleteDecimal, nameof(searchTasksWrappertransmitObjectpercentCompleteDecimal), required: false);
            var __workflow_searchTasksWrappertransmitObjectprevStateEn = WorkflowExpression.Compile(searchTasksWrappertransmitObjectprevStateEn, nameof(searchTasksWrappertransmitObjectprevStateEn), required: false);
            var __workflow_searchTasksWrappertransmitObjectstartDate = WorkflowExpression.Compile(searchTasksWrappertransmitObjectstartDate, nameof(searchTasksWrappertransmitObjectstartDate), required: false);
            var __workflow_searchTasksWrappertransmitObjectstateEn = WorkflowExpression.Compile(searchTasksWrappertransmitObjectstateEn, nameof(searchTasksWrappertransmitObjectstateEn), required: false);
            var __workflow_searchTasksWrappertransmitObjectsubject = WorkflowExpression.Compile(searchTasksWrappertransmitObjectsubject, nameof(searchTasksWrappertransmitObjectsubject), required: false);
            var __workflow_searchTasksWrappertransmitObjecttypeEn = WorkflowExpression.Compile(searchTasksWrappertransmitObjecttypeEn, nameof(searchTasksWrappertransmitObjecttypeEn), required: false);
            var __workflow_searchTasksWrappertransmitObjectlevel = WorkflowExpression.Compile(searchTasksWrappertransmitObjectlevel, nameof(searchTasksWrappertransmitObjectlevel), required: false);
            var __workflow_searchTasksWrappertransmitObjectimportanceEn = WorkflowExpression.Compile(searchTasksWrappertransmitObjectimportanceEn, nameof(searchTasksWrappertransmitObjectimportanceEn), required: false);
            var __workflow_searchTasksWrappertransmitObjectactualWorkHours = WorkflowExpression.Compile(searchTasksWrappertransmitObjectactualWorkHours, nameof(searchTasksWrappertransmitObjectactualWorkHours), required: false);
            var __workflow_searchTasksWrappertransmitObjectestimatedWorkHours = WorkflowExpression.Compile(searchTasksWrappertransmitObjectestimatedWorkHours, nameof(searchTasksWrappertransmitObjectestimatedWorkHours), required: false);
            var __workflow_searchTasksWrappertransmitObjectisReminderSet = WorkflowExpression.Compile(searchTasksWrappertransmitObjectisReminderSet, nameof(searchTasksWrappertransmitObjectisReminderSet), required: false);
            var __workflow_searchTasksWrappertransmitObjectreminderDate = WorkflowExpression.Compile(searchTasksWrappertransmitObjectreminderDate, nameof(searchTasksWrappertransmitObjectreminderDate), required: false);
            var __workflow_searchTasksWrappertransmitObjectcompletedDate = WorkflowExpression.Compile(searchTasksWrappertransmitObjectcompletedDate, nameof(searchTasksWrappertransmitObjectcompletedDate), required: false);
            var __workflow_searchTasksWrappertransmitObjectpicture = WorkflowExpression.Compile(searchTasksWrappertransmitObjectpicture, nameof(searchTasksWrappertransmitObjectpicture), required: false);
            var __workflow_searchTasksWrappertransmitObjectpictureWidth = WorkflowExpression.Compile(searchTasksWrappertransmitObjectpictureWidth, nameof(searchTasksWrappertransmitObjectpictureWidth), required: false);
            var __workflow_searchTasksWrappertransmitObjectpictureHeight = WorkflowExpression.Compile(searchTasksWrappertransmitObjectpictureHeight, nameof(searchTasksWrappertransmitObjectpictureHeight), required: false);
            var __workflow_searchTasksWrappertransmitObjectisPrivate = WorkflowExpression.Compile(searchTasksWrappertransmitObjectisPrivate, nameof(searchTasksWrappertransmitObjectisPrivate), required: false);
            var __workflow_searchTasksWrappertransmitObjectserverItemCreated = WorkflowExpression.Compile(searchTasksWrappertransmitObjectserverItemCreated, nameof(searchTasksWrappertransmitObjectserverItemCreated), required: false);
            var __workflow_searchTasksWrappertransmitObjectserverItemChanged = WorkflowExpression.Compile(searchTasksWrappertransmitObjectserverItemChanged, nameof(searchTasksWrappertransmitObjectserverItemChanged), required: false);
            var __workflow_searchTasksWrappertransmitObjectitemCreated = WorkflowExpression.Compile(searchTasksWrappertransmitObjectitemCreated, nameof(searchTasksWrappertransmitObjectitemCreated), required: false);
            var __workflow_searchTasksWrappertransmitObjectitemChanged = WorkflowExpression.Compile(searchTasksWrappertransmitObjectitemChanged, nameof(searchTasksWrappertransmitObjectitemChanged), required: false);
            var __workflow_searchTasksWrappertransmitObjectfileAs = WorkflowExpression.Compile(searchTasksWrappertransmitObjectfileAs, nameof(searchTasksWrappertransmitObjectfileAs), required: false);
            var __workflow_searchTasksWrappertransmitObjectownerGUID = WorkflowExpression.Compile(searchTasksWrappertransmitObjectownerGUID, nameof(searchTasksWrappertransmitObjectownerGUID), required: false);
            var __workflow_searchTasksWrappertransmitObjectcreatedByGUID = WorkflowExpression.Compile(searchTasksWrappertransmitObjectcreatedByGUID, nameof(searchTasksWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_searchTasksWrappertransmitObjectmodifiedByGUID = WorkflowExpression.Compile(searchTasksWrappertransmitObjectmodifiedByGUID, nameof(searchTasksWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_searchTasksWrappertransmitObjectadditionalFields = WorkflowExpression.Compile(searchTasksWrappertransmitObjectadditionalFields, nameof(searchTasksWrappertransmitObjectadditionalFields), required: false);
            var __workflow_searchTasksWrappertransmitObjectrelations = WorkflowExpression.Compile(searchTasksWrappertransmitObjectrelations, nameof(searchTasksWrappertransmitObjectrelations), required: false);
            var __workflow_searchTasksWrappertransmitObjectitemGUID = WorkflowExpression.Compile(searchTasksWrappertransmitObjectitemGUID, nameof(searchTasksWrappertransmitObjectitemGUID), required: false);
            var __workflow_searchTasksWrappertransmitObjectitemVersion = WorkflowExpression.Compile(searchTasksWrappertransmitObjectitemVersion, nameof(searchTasksWrappertransmitObjectitemVersion), required: false);
            var __workflow_searchTasksWrapperincludeRelations = WorkflowExpression.Compile(searchTasksWrapperincludeRelations, nameof(searchTasksWrapperincludeRelations), required: false);
            var __workflow_searchTasksWrapperrelationsFilterrelationType = WorkflowExpression.Compile(searchTasksWrapperrelationsFilterrelationType, nameof(searchTasksWrapperrelationsFilterrelationType), required: false);
            var __workflow_searchTasksWrapperrelationsFilterforeignFolderName = WorkflowExpression.Compile(searchTasksWrapperrelationsFilterforeignFolderName, nameof(searchTasksWrapperrelationsFilterforeignFolderName), required: false);
            var __workflow_searchTasksWrapperbinaryLogicalOperator = WorkflowExpression.Compile(searchTasksWrapperbinaryLogicalOperator, nameof(searchTasksWrapperbinaryLogicalOperator), required: false);
            return new DeferredBodyAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask>(() =>
            {
                var apiCallPath = "/SearchTasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var searchTasksWrapper = new JObject();
                var searchTasksWrapperpropCount = 0;
                var transmitObjectObject = new JObject();
                var transmitObjectObjectpropCount = 0;
                if (__workflow_searchTasksWrappertransmitObjectleadsTopLevelProjectGuid != null)
                {
                    transmitObjectObject["Leads_TopLevelProjectGuid"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectleadsTopLevelProjectGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectleadsTaskParentGuid != null)
                {
                    transmitObjectObject["Leads_TaskParentGuid"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectleadsTaskParentGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectprojectsTopLevelProjectGuid != null)
                {
                    transmitObjectObject["Projects_TopLevelProjectGuid"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectprojectsTopLevelProjectGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectprojectsTaskParentGuid != null)
                {
                    transmitObjectObject["Projects_TaskParentGuid"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectprojectsTaskParentGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjecttasksTaskParentGuid != null)
                {
                    transmitObjectObject["Tasks_TaskParentGuid"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjecttasksTaskParentGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectmarketingTopLevelProjectGuid != null)
                {
                    transmitObjectObject["Marketing_TopLevelProjectGuid"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectmarketingTopLevelProjectGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectmarketingTaskParentGuid != null)
                {
                    transmitObjectObject["Marketing_TaskParentGuid"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectmarketingTaskParentGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectcompaniesCompanyGuid != null)
                {
                    transmitObjectObject["Companies_CompanyGuid"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectcompaniesCompanyGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectcontactsContactGuid != null)
                {
                    transmitObjectObject["Contacts_ContactGuid"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectcontactsContactGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectusersTaskDelegatorGuid != null)
                {
                    transmitObjectObject["Users_TaskDelegatorGuid"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectusersTaskDelegatorGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectusersTaskSolverGuid != null)
                {
                    transmitObjectObject["Users_TaskSolverGuid"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectusersTaskSolverGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjecttasksTaskOriginGuid != null)
                {
                    transmitObjectObject["Tasks_TaskOriginGuid"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjecttasksTaskOriginGuid);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectbody != null)
                {
                    transmitObjectObject["Body"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectbody);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectisCompleted != null)
                {
                    transmitObjectObject["IsCompleted"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectisCompleted);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectdueDate != null)
                {
                    transmitObjectObject["DueDate"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectdueDate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectpercentCompleteDecimal != null)
                {
                    transmitObjectObject["PercentCompleteDecimal"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectpercentCompleteDecimal);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectprevStateEn != null)
                {
                    transmitObjectObject["PrevStateEn"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectprevStateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectstartDate != null)
                {
                    transmitObjectObject["StartDate"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectstartDate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectstateEn != null)
                {
                    transmitObjectObject["StateEn"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectstateEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectsubject != null)
                {
                    transmitObjectObject["Subject"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectsubject);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjecttypeEn != null)
                {
                    transmitObjectObject["TypeEn"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjecttypeEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectlevel != null)
                {
                    transmitObjectObject["Level"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectlevel);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectimportanceEn != null)
                {
                    transmitObjectObject["ImportanceEn"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectimportanceEn);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectactualWorkHours != null)
                {
                    transmitObjectObject["ActualWorkHours"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectactualWorkHours);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectestimatedWorkHours != null)
                {
                    transmitObjectObject["EstimatedWorkHours"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectestimatedWorkHours);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectisReminderSet != null)
                {
                    transmitObjectObject["IsReminderSet"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectisReminderSet);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectreminderDate != null)
                {
                    transmitObjectObject["ReminderDate"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectreminderDate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectcompletedDate != null)
                {
                    transmitObjectObject["CompletedDate"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectcompletedDate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectpicture != null)
                {
                    transmitObjectObject["Picture"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectpicture);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectpictureWidth != null)
                {
                    transmitObjectObject["PictureWidth"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectpictureWidth);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectpictureHeight != null)
                {
                    transmitObjectObject["PictureHeight"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectpictureHeight);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectisPrivate != null)
                {
                    transmitObjectObject["IsPrivate"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectisPrivate);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectserverItemCreated != null)
                {
                    transmitObjectObject["Server_ItemCreated"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectserverItemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectserverItemChanged != null)
                {
                    transmitObjectObject["Server_ItemChanged"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectserverItemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectitemCreated != null)
                {
                    transmitObjectObject["ItemCreated"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectitemCreated);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectitemChanged != null)
                {
                    transmitObjectObject["ItemChanged"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectitemChanged);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectfileAs != null)
                {
                    transmitObjectObject["FileAs"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectfileAs);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectownerGUID != null)
                {
                    transmitObjectObject["OwnerGUID"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectownerGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectcreatedByGUID != null)
                {
                    transmitObjectObject["CreatedByGUID"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectcreatedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectmodifiedByGUID != null)
                {
                    transmitObjectObject["ModifiedByGUID"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectmodifiedByGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectadditionalFields != null)
                {
                    transmitObjectObject["AdditionalFields"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectadditionalFields);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectrelations != null)
                {
                    transmitObjectObject["Relations"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectrelations);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectitemGUID != null)
                {
                    transmitObjectObject["ItemGUID"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectitemGUID);
                    transmitObjectObjectpropCount++;
                }

                if (__workflow_searchTasksWrappertransmitObjectitemVersion != null)
                {
                    transmitObjectObject["ItemVersion"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrappertransmitObjectitemVersion);
                    transmitObjectObjectpropCount++;
                }

                if (transmitObjectObjectpropCount > 0)
                {
                    searchTasksWrapper["transmitObject"] = transmitObjectObject;
                    searchTasksWrapperpropCount++;
                }

                if (__workflow_searchTasksWrapperincludeRelations != null)
                {
                    searchTasksWrapper["includeRelations"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrapperincludeRelations);
                    searchTasksWrapperpropCount++;
                }

                var relationsFilterObject = new JObject();
                var relationsFilterObjectpropCount = 0;
                if (__workflow_searchTasksWrapperrelationsFilterrelationType != null)
                {
                    relationsFilterObject["RelationType"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrapperrelationsFilterrelationType);
                    relationsFilterObjectpropCount++;
                }

                if (__workflow_searchTasksWrapperrelationsFilterforeignFolderName != null)
                {
                    relationsFilterObject["ForeignFolderName"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrapperrelationsFilterforeignFolderName);
                    relationsFilterObjectpropCount++;
                }

                if (relationsFilterObjectpropCount > 0)
                {
                    searchTasksWrapper["relationsFilter"] = relationsFilterObject;
                    searchTasksWrapperpropCount++;
                }

                if (__workflow_searchTasksWrapperbinaryLogicalOperator != null)
                {
                    searchTasksWrapper["binaryLogicalOperator"] = ExpressionConverter.ConvertO(__workflow_searchTasksWrapperbinaryLogicalOperator);
                    searchTasksWrapperpropCount++;
                }

                if (searchTasksWrapperpropCount > 0)
                {
                    callPayload.Body = searchTasksWrapper;
                }

                return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ewaycrm")]
        public IBodyWorkflowAction<EWayWcfServiceResponsesDataResponse1SystemGuid> UnlinkItems(Expression<Func<string>> unlinkItemsWrapperitemGuid = null, Expression<Func<unlinkItemsWrapperfolderNameInput>> unlinkItemsWrapperfolderName = null, Expression<Func<string[]>> unlinkItemsWrapperrelatedItemGuids = null, Expression<Func<unlinkItemsWrapperrelatedFolderNameInput>> unlinkItemsWrapperrelatedFolderName = null, Expression<Func<bool>> unlinkItemsWrapperskipUnlinkAvailabilityCheck = null)
        {
            var __workflow_unlinkItemsWrapperitemGuid = WorkflowExpression.Compile(unlinkItemsWrapperitemGuid, nameof(unlinkItemsWrapperitemGuid), required: false);
            var __workflow_unlinkItemsWrapperfolderName = WorkflowExpression.Compile(unlinkItemsWrapperfolderName, nameof(unlinkItemsWrapperfolderName), required: false);
            var __workflow_unlinkItemsWrapperrelatedItemGuids = WorkflowExpression.Compile(unlinkItemsWrapperrelatedItemGuids, nameof(unlinkItemsWrapperrelatedItemGuids), required: false);
            var __workflow_unlinkItemsWrapperrelatedFolderName = WorkflowExpression.Compile(unlinkItemsWrapperrelatedFolderName, nameof(unlinkItemsWrapperrelatedFolderName), required: false);
            var __workflow_unlinkItemsWrapperskipUnlinkAvailabilityCheck = WorkflowExpression.Compile(unlinkItemsWrapperskipUnlinkAvailabilityCheck, nameof(unlinkItemsWrapperskipUnlinkAvailabilityCheck), required: false);
            return new DeferredBodyAction<EWayWcfServiceResponsesDataResponse1SystemGuid>(() =>
            {
                var apiCallPath = "/UnlinkItems";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var unlinkItemsWrapper = new JObject();
                var unlinkItemsWrapperpropCount = 0;
                if (__workflow_unlinkItemsWrapperitemGuid != null)
                {
                    unlinkItemsWrapper["itemGuid"] = ExpressionConverter.ConvertO(__workflow_unlinkItemsWrapperitemGuid);
                    unlinkItemsWrapperpropCount++;
                }

                if (__workflow_unlinkItemsWrapperfolderName != null)
                {
                    unlinkItemsWrapper["folderName"] = ExpressionConverter.ConvertO(__workflow_unlinkItemsWrapperfolderName);
                    unlinkItemsWrapperpropCount++;
                }

                if (__workflow_unlinkItemsWrapperrelatedItemGuids != null)
                {
                    unlinkItemsWrapper["relatedItemGuids"] = ExpressionConverter.ConvertO(__workflow_unlinkItemsWrapperrelatedItemGuids);
                    unlinkItemsWrapperpropCount++;
                }

                if (__workflow_unlinkItemsWrapperrelatedFolderName != null)
                {
                    unlinkItemsWrapper["relatedFolderName"] = ExpressionConverter.ConvertO(__workflow_unlinkItemsWrapperrelatedFolderName);
                    unlinkItemsWrapperpropCount++;
                }

                if (__workflow_unlinkItemsWrapperskipUnlinkAvailabilityCheck != null)
                {
                    unlinkItemsWrapper["skipUnlinkAvailabilityCheck"] = ExpressionConverter.ConvertO(__workflow_unlinkItemsWrapperskipUnlinkAvailabilityCheck);
                    unlinkItemsWrapperpropCount++;
                }

                if (unlinkItemsWrapperpropCount > 0)
                {
                    callPayload.Body = unlinkItemsWrapper;
                }

                return new ApiConnectionAction<EWayWcfServiceResponsesDataResponse1SystemGuid>(callPayload);
            });
        }
    }

    public class EwaycrmTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal> NewOrUpdatedJournal(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/NewOrUpdatedJournal";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedJournal>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany> NewOrUpdatedCompanies(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/NewOrUpdatedCompanies";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedCompany>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact> NewOrUpdatedContacts(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/NewOrUpdatedContacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedContact>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead> NewOrUpdatedLeads(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/NewOrUpdatedLeads";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedLead>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject> NewOrUpdatedProjects(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/NewOrUpdatedProjects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedProject>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask> NewOrUpdatedTasks(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/NewOrUpdatedTasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<EWayWcfServiceResponsesDataResponse1EWayWcfServiceItemTypesGeneratedTask>(callPayload, recurrence: recurrence);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
