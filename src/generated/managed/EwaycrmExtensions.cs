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
            var __workflow_deleteCompanyWrapperitemGuid = deleteCompanyWrapperitemGuid == null ? null : WorkflowExpression.Compile(deleteCompanyWrapperitemGuid);
            WorkflowExpression.Validate(__workflow_deleteCompanyWrapperitemGuid, nameof(deleteCompanyWrapperitemGuid), required: false);
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
            var __workflow_deleteContactWrapperitemGuid = deleteContactWrapperitemGuid == null ? null : WorkflowExpression.Compile(deleteContactWrapperitemGuid);
            WorkflowExpression.Validate(__workflow_deleteContactWrapperitemGuid, nameof(deleteContactWrapperitemGuid), required: false);
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
            var __workflow_deleteJournalWrapperitemGuid = deleteJournalWrapperitemGuid == null ? null : WorkflowExpression.Compile(deleteJournalWrapperitemGuid);
            WorkflowExpression.Validate(__workflow_deleteJournalWrapperitemGuid, nameof(deleteJournalWrapperitemGuid), required: false);
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
            var __workflow_deleteLeadWrapperitemGuid = deleteLeadWrapperitemGuid == null ? null : WorkflowExpression.Compile(deleteLeadWrapperitemGuid);
            WorkflowExpression.Validate(__workflow_deleteLeadWrapperitemGuid, nameof(deleteLeadWrapperitemGuid), required: false);
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
            var __workflow_deleteProjectWrapperitemGuid = deleteProjectWrapperitemGuid == null ? null : WorkflowExpression.Compile(deleteProjectWrapperitemGuid);
            WorkflowExpression.Validate(__workflow_deleteProjectWrapperitemGuid, nameof(deleteProjectWrapperitemGuid), required: false);
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
            var __workflow_deleteTaskWrapperitemGuid = deleteTaskWrapperitemGuid == null ? null : WorkflowExpression.Compile(deleteTaskWrapperitemGuid);
            WorkflowExpression.Validate(__workflow_deleteTaskWrapperitemGuid, nameof(deleteTaskWrapperitemGuid), required: false);
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
            var __workflow_saveCompanyWrappertransmitObjectaccountNumber = saveCompanyWrappertransmitObjectaccountNumber == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaccountNumber);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectaccountNumber, nameof(saveCompanyWrappertransmitObjectaccountNumber), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress1POBox = saveCompanyWrappertransmitObjectaddress1POBox == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress1POBox);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectaddress1POBox, nameof(saveCompanyWrappertransmitObjectaddress1POBox), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress1Street = saveCompanyWrappertransmitObjectaddress1Street == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress1Street);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectaddress1Street, nameof(saveCompanyWrappertransmitObjectaddress1Street), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress1City = saveCompanyWrappertransmitObjectaddress1City == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress1City);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectaddress1City, nameof(saveCompanyWrappertransmitObjectaddress1City), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress1State = saveCompanyWrappertransmitObjectaddress1State == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress1State);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectaddress1State, nameof(saveCompanyWrappertransmitObjectaddress1State), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress1CountryEn = saveCompanyWrappertransmitObjectaddress1CountryEn == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress1CountryEn);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectaddress1CountryEn, nameof(saveCompanyWrappertransmitObjectaddress1CountryEn), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress1PostalCode = saveCompanyWrappertransmitObjectaddress1PostalCode == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress1PostalCode);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectaddress1PostalCode, nameof(saveCompanyWrappertransmitObjectaddress1PostalCode), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress2POBox = saveCompanyWrappertransmitObjectaddress2POBox == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress2POBox);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectaddress2POBox, nameof(saveCompanyWrappertransmitObjectaddress2POBox), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress2Street = saveCompanyWrappertransmitObjectaddress2Street == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress2Street);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectaddress2Street, nameof(saveCompanyWrappertransmitObjectaddress2Street), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress2City = saveCompanyWrappertransmitObjectaddress2City == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress2City);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectaddress2City, nameof(saveCompanyWrappertransmitObjectaddress2City), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress2State = saveCompanyWrappertransmitObjectaddress2State == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress2State);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectaddress2State, nameof(saveCompanyWrappertransmitObjectaddress2State), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress2CountryEn = saveCompanyWrappertransmitObjectaddress2CountryEn == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress2CountryEn);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectaddress2CountryEn, nameof(saveCompanyWrappertransmitObjectaddress2CountryEn), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress2PostalCode = saveCompanyWrappertransmitObjectaddress2PostalCode == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress2PostalCode);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectaddress2PostalCode, nameof(saveCompanyWrappertransmitObjectaddress2PostalCode), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress3POBox = saveCompanyWrappertransmitObjectaddress3POBox == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress3POBox);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectaddress3POBox, nameof(saveCompanyWrappertransmitObjectaddress3POBox), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress3Street = saveCompanyWrappertransmitObjectaddress3Street == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress3Street);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectaddress3Street, nameof(saveCompanyWrappertransmitObjectaddress3Street), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress3City = saveCompanyWrappertransmitObjectaddress3City == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress3City);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectaddress3City, nameof(saveCompanyWrappertransmitObjectaddress3City), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress3State = saveCompanyWrappertransmitObjectaddress3State == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress3State);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectaddress3State, nameof(saveCompanyWrappertransmitObjectaddress3State), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress3CountryEn = saveCompanyWrappertransmitObjectaddress3CountryEn == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress3CountryEn);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectaddress3CountryEn, nameof(saveCompanyWrappertransmitObjectaddress3CountryEn), required: false);
            var __workflow_saveCompanyWrappertransmitObjectaddress3PostalCode = saveCompanyWrappertransmitObjectaddress3PostalCode == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectaddress3PostalCode);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectaddress3PostalCode, nameof(saveCompanyWrappertransmitObjectaddress3PostalCode), required: false);
            var __workflow_saveCompanyWrappertransmitObjectcompanyName = saveCompanyWrappertransmitObjectcompanyName == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectcompanyName);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectcompanyName, nameof(saveCompanyWrappertransmitObjectcompanyName), required: false);
            var __workflow_saveCompanyWrappertransmitObjectdepartment = saveCompanyWrappertransmitObjectdepartment == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectdepartment);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectdepartment, nameof(saveCompanyWrappertransmitObjectdepartment), required: false);
            var __workflow_saveCompanyWrappertransmitObjectemail = saveCompanyWrappertransmitObjectemail == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectemail);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectemail, nameof(saveCompanyWrappertransmitObjectemail), required: false);
            var __workflow_saveCompanyWrappertransmitObjectemployeesCount = saveCompanyWrappertransmitObjectemployeesCount == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectemployeesCount);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectemployeesCount, nameof(saveCompanyWrappertransmitObjectemployeesCount), required: false);
            var __workflow_saveCompanyWrappertransmitObjectfax = saveCompanyWrappertransmitObjectfax == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectfax);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectfax, nameof(saveCompanyWrappertransmitObjectfax), required: false);
            var __workflow_saveCompanyWrappertransmitObjectfirstContactEn = saveCompanyWrappertransmitObjectfirstContactEn == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectfirstContactEn);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectfirstContactEn, nameof(saveCompanyWrappertransmitObjectfirstContactEn), required: false);
            var __workflow_saveCompanyWrappertransmitObjectiCQ = saveCompanyWrappertransmitObjectiCQ == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectiCQ);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectiCQ, nameof(saveCompanyWrappertransmitObjectiCQ), required: false);
            var __workflow_saveCompanyWrappertransmitObjectidentificationNumber = saveCompanyWrappertransmitObjectidentificationNumber == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectidentificationNumber);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectidentificationNumber, nameof(saveCompanyWrappertransmitObjectidentificationNumber), required: false);
            var __workflow_saveCompanyWrappertransmitObjectimportanceEn = saveCompanyWrappertransmitObjectimportanceEn == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectimportanceEn);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectimportanceEn, nameof(saveCompanyWrappertransmitObjectimportanceEn), required: false);
            var __workflow_saveCompanyWrappertransmitObjectlineOfBusiness = saveCompanyWrappertransmitObjectlineOfBusiness == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectlineOfBusiness);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectlineOfBusiness, nameof(saveCompanyWrappertransmitObjectlineOfBusiness), required: false);
            var __workflow_saveCompanyWrappertransmitObjectmailingListOther = saveCompanyWrappertransmitObjectmailingListOther == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectmailingListOther);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectmailingListOther, nameof(saveCompanyWrappertransmitObjectmailingListOther), required: false);
            var __workflow_saveCompanyWrappertransmitObjectmobile = saveCompanyWrappertransmitObjectmobile == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectmobile);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectmobile, nameof(saveCompanyWrappertransmitObjectmobile), required: false);
            var __workflow_saveCompanyWrappertransmitObjectmobileNormalized = saveCompanyWrappertransmitObjectmobileNormalized == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectmobileNormalized);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectmobileNormalized, nameof(saveCompanyWrappertransmitObjectmobileNormalized), required: false);
            var __workflow_saveCompanyWrappertransmitObjectmSN = saveCompanyWrappertransmitObjectmSN == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectmSN);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectmSN, nameof(saveCompanyWrappertransmitObjectmSN), required: false);
            var __workflow_saveCompanyWrappertransmitObjectnote = saveCompanyWrappertransmitObjectnote == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectnote);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectnote, nameof(saveCompanyWrappertransmitObjectnote), required: false);
            var __workflow_saveCompanyWrappertransmitObjectphone = saveCompanyWrappertransmitObjectphone == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectphone);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectphone, nameof(saveCompanyWrappertransmitObjectphone), required: false);
            var __workflow_saveCompanyWrappertransmitObjectphoneNormalized = saveCompanyWrappertransmitObjectphoneNormalized == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectphoneNormalized);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectphoneNormalized, nameof(saveCompanyWrappertransmitObjectphoneNormalized), required: false);
            var __workflow_saveCompanyWrappertransmitObjectpurchaser = saveCompanyWrappertransmitObjectpurchaser == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectpurchaser);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectpurchaser, nameof(saveCompanyWrappertransmitObjectpurchaser), required: false);
            var __workflow_saveCompanyWrappertransmitObjectreversal = saveCompanyWrappertransmitObjectreversal == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectreversal);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectreversal, nameof(saveCompanyWrappertransmitObjectreversal), required: false);
            var __workflow_saveCompanyWrappertransmitObjectskype = saveCompanyWrappertransmitObjectskype == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectskype);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectskype, nameof(saveCompanyWrappertransmitObjectskype), required: false);
            var __workflow_saveCompanyWrappertransmitObjectsuppliers = saveCompanyWrappertransmitObjectsuppliers == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectsuppliers);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectsuppliers, nameof(saveCompanyWrappertransmitObjectsuppliers), required: false);
            var __workflow_saveCompanyWrappertransmitObjectvATNumber = saveCompanyWrappertransmitObjectvATNumber == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectvATNumber);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectvATNumber, nameof(saveCompanyWrappertransmitObjectvATNumber), required: false);
            var __workflow_saveCompanyWrappertransmitObjectwebPage = saveCompanyWrappertransmitObjectwebPage == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectwebPage);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectwebPage, nameof(saveCompanyWrappertransmitObjectwebPage), required: false);
            var __workflow_saveCompanyWrappertransmitObjectadditionalDiscount = saveCompanyWrappertransmitObjectadditionalDiscount == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectadditionalDiscount);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectadditionalDiscount, nameof(saveCompanyWrappertransmitObjectadditionalDiscount), required: false);
            var __workflow_saveCompanyWrappertransmitObjectiD = saveCompanyWrappertransmitObjectiD == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectiD);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectiD, nameof(saveCompanyWrappertransmitObjectiD), required: false);
            var __workflow_saveCompanyWrappertransmitObjectcompetitor = saveCompanyWrappertransmitObjectcompetitor == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectcompetitor);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectcompetitor, nameof(saveCompanyWrappertransmitObjectcompetitor), required: false);
            var __workflow_saveCompanyWrappertransmitObjectsalePriceGuid = saveCompanyWrappertransmitObjectsalePriceGuid == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectsalePriceGuid);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectsalePriceGuid, nameof(saveCompanyWrappertransmitObjectsalePriceGuid), required: false);
            var __workflow_saveCompanyWrappertransmitObjectnotificationByEmail = saveCompanyWrappertransmitObjectnotificationByEmail == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectnotificationByEmail);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectnotificationByEmail, nameof(saveCompanyWrappertransmitObjectnotificationByEmail), required: false);
            var __workflow_saveCompanyWrappertransmitObjectnotificationBy = saveCompanyWrappertransmitObjectnotificationBy == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectnotificationBy);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectnotificationBy, nameof(saveCompanyWrappertransmitObjectnotificationBy), required: false);
            var __workflow_saveCompanyWrappertransmitObjectlastActivity = saveCompanyWrappertransmitObjectlastActivity == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectlastActivity);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectlastActivity, nameof(saveCompanyWrappertransmitObjectlastActivity), required: false);
            var __workflow_saveCompanyWrappertransmitObjectnextStep = saveCompanyWrappertransmitObjectnextStep == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectnextStep);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectnextStep, nameof(saveCompanyWrappertransmitObjectnextStep), required: false);
            var __workflow_saveCompanyWrappertransmitObjectemailOptOut = saveCompanyWrappertransmitObjectemailOptOut == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectemailOptOut);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectemailOptOut, nameof(saveCompanyWrappertransmitObjectemailOptOut), required: false);
            var __workflow_saveCompanyWrappertransmitObjecttypeEn = saveCompanyWrappertransmitObjecttypeEn == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjecttypeEn);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjecttypeEn, nameof(saveCompanyWrappertransmitObjecttypeEn), required: false);
            var __workflow_saveCompanyWrappertransmitObjectstateEn = saveCompanyWrappertransmitObjectstateEn == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectstateEn);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectstateEn, nameof(saveCompanyWrappertransmitObjectstateEn), required: false);
            var __workflow_saveCompanyWrappertransmitObjectprevStateEn = saveCompanyWrappertransmitObjectprevStateEn == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectprevStateEn);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectprevStateEn, nameof(saveCompanyWrappertransmitObjectprevStateEn), required: false);
            var __workflow_saveCompanyWrappertransmitObjectpicture = saveCompanyWrappertransmitObjectpicture == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectpicture);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectpicture, nameof(saveCompanyWrappertransmitObjectpicture), required: false);
            var __workflow_saveCompanyWrappertransmitObjectpictureWidth = saveCompanyWrappertransmitObjectpictureWidth == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectpictureWidth);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectpictureWidth, nameof(saveCompanyWrappertransmitObjectpictureWidth), required: false);
            var __workflow_saveCompanyWrappertransmitObjectpictureHeight = saveCompanyWrappertransmitObjectpictureHeight == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectpictureHeight);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectpictureHeight, nameof(saveCompanyWrappertransmitObjectpictureHeight), required: false);
            var __workflow_saveCompanyWrappertransmitObjectisPrivate = saveCompanyWrappertransmitObjectisPrivate == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectisPrivate);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectisPrivate, nameof(saveCompanyWrappertransmitObjectisPrivate), required: false);
            var __workflow_saveCompanyWrappertransmitObjectitemCreated = saveCompanyWrappertransmitObjectitemCreated == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectitemCreated);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectitemCreated, nameof(saveCompanyWrappertransmitObjectitemCreated), required: false);
            var __workflow_saveCompanyWrappertransmitObjectitemChanged = saveCompanyWrappertransmitObjectitemChanged == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectitemChanged);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectitemChanged, nameof(saveCompanyWrappertransmitObjectitemChanged), required: false);
            var __workflow_saveCompanyWrappertransmitObjectfileAs = saveCompanyWrappertransmitObjectfileAs == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectfileAs);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectfileAs, nameof(saveCompanyWrappertransmitObjectfileAs), required: false);
            var __workflow_saveCompanyWrappertransmitObjectownerGUID = saveCompanyWrappertransmitObjectownerGUID == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectownerGUID);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectownerGUID, nameof(saveCompanyWrappertransmitObjectownerGUID), required: false);
            var __workflow_saveCompanyWrappertransmitObjectcreatedByGUID = saveCompanyWrappertransmitObjectcreatedByGUID == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectcreatedByGUID);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectcreatedByGUID, nameof(saveCompanyWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_saveCompanyWrappertransmitObjectmodifiedByGUID = saveCompanyWrappertransmitObjectmodifiedByGUID == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectmodifiedByGUID);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectmodifiedByGUID, nameof(saveCompanyWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_saveCompanyWrappertransmitObjectadditionalFields = saveCompanyWrappertransmitObjectadditionalFields == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectadditionalFields);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectadditionalFields, nameof(saveCompanyWrappertransmitObjectadditionalFields), required: false);
            var __workflow_saveCompanyWrappertransmitObjectitemGUID = saveCompanyWrappertransmitObjectitemGUID == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectitemGUID);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectitemGUID, nameof(saveCompanyWrappertransmitObjectitemGUID), required: false);
            var __workflow_saveCompanyWrappertransmitObjectitemVersion = saveCompanyWrappertransmitObjectitemVersion == null ? null : WorkflowExpression.Compile(saveCompanyWrappertransmitObjectitemVersion);
            WorkflowExpression.Validate(__workflow_saveCompanyWrappertransmitObjectitemVersion, nameof(saveCompanyWrappertransmitObjectitemVersion), required: false);
            var __workflow_saveCompanyWrapperdieOnItemConflict = saveCompanyWrapperdieOnItemConflict == null ? null : WorkflowExpression.Compile(saveCompanyWrapperdieOnItemConflict);
            WorkflowExpression.Validate(__workflow_saveCompanyWrapperdieOnItemConflict, nameof(saveCompanyWrapperdieOnItemConflict), required: false);
            var __workflow_saveCompanyWrapperignoredUserErrorMessages = saveCompanyWrapperignoredUserErrorMessages == null ? null : WorkflowExpression.Compile(saveCompanyWrapperignoredUserErrorMessages);
            WorkflowExpression.Validate(__workflow_saveCompanyWrapperignoredUserErrorMessages, nameof(saveCompanyWrapperignoredUserErrorMessages), required: false);
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
            var __workflow_saveContactWrappertransmitObjectbusinessAddressStreet = saveContactWrappertransmitObjectbusinessAddressStreet == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectbusinessAddressStreet);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectbusinessAddressStreet, nameof(saveContactWrappertransmitObjectbusinessAddressStreet), required: false);
            var __workflow_saveContactWrappertransmitObjectbusinessAddressCity = saveContactWrappertransmitObjectbusinessAddressCity == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectbusinessAddressCity);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectbusinessAddressCity, nameof(saveContactWrappertransmitObjectbusinessAddressCity), required: false);
            var __workflow_saveContactWrappertransmitObjectbusinessAddressState = saveContactWrappertransmitObjectbusinessAddressState == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectbusinessAddressState);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectbusinessAddressState, nameof(saveContactWrappertransmitObjectbusinessAddressState), required: false);
            var __workflow_saveContactWrappertransmitObjectbusinessAddressCountryEn = saveContactWrappertransmitObjectbusinessAddressCountryEn == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectbusinessAddressCountryEn);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectbusinessAddressCountryEn, nameof(saveContactWrappertransmitObjectbusinessAddressCountryEn), required: false);
            var __workflow_saveContactWrappertransmitObjectbusinessAddressPOBox = saveContactWrappertransmitObjectbusinessAddressPOBox == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectbusinessAddressPOBox);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectbusinessAddressPOBox, nameof(saveContactWrappertransmitObjectbusinessAddressPOBox), required: false);
            var __workflow_saveContactWrappertransmitObjectbusinessAddressPostalCode = saveContactWrappertransmitObjectbusinessAddressPostalCode == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectbusinessAddressPostalCode);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectbusinessAddressPostalCode, nameof(saveContactWrappertransmitObjectbusinessAddressPostalCode), required: false);
            var __workflow_saveContactWrappertransmitObjecthomeAddressStreet = saveContactWrappertransmitObjecthomeAddressStreet == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjecthomeAddressStreet);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjecthomeAddressStreet, nameof(saveContactWrappertransmitObjecthomeAddressStreet), required: false);
            var __workflow_saveContactWrappertransmitObjecthomeAddressCity = saveContactWrappertransmitObjecthomeAddressCity == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjecthomeAddressCity);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjecthomeAddressCity, nameof(saveContactWrappertransmitObjecthomeAddressCity), required: false);
            var __workflow_saveContactWrappertransmitObjecthomeAddressState = saveContactWrappertransmitObjecthomeAddressState == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjecthomeAddressState);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjecthomeAddressState, nameof(saveContactWrappertransmitObjecthomeAddressState), required: false);
            var __workflow_saveContactWrappertransmitObjecthomeAddressCountryEn = saveContactWrappertransmitObjecthomeAddressCountryEn == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjecthomeAddressCountryEn);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjecthomeAddressCountryEn, nameof(saveContactWrappertransmitObjecthomeAddressCountryEn), required: false);
            var __workflow_saveContactWrappertransmitObjecthomeAddressPOBox = saveContactWrappertransmitObjecthomeAddressPOBox == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjecthomeAddressPOBox);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjecthomeAddressPOBox, nameof(saveContactWrappertransmitObjecthomeAddressPOBox), required: false);
            var __workflow_saveContactWrappertransmitObjecthomeAddressPostalCode = saveContactWrappertransmitObjecthomeAddressPostalCode == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjecthomeAddressPostalCode);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjecthomeAddressPostalCode, nameof(saveContactWrappertransmitObjecthomeAddressPostalCode), required: false);
            var __workflow_saveContactWrappertransmitObjectotherAddressStreet = saveContactWrappertransmitObjectotherAddressStreet == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectotherAddressStreet);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectotherAddressStreet, nameof(saveContactWrappertransmitObjectotherAddressStreet), required: false);
            var __workflow_saveContactWrappertransmitObjectotherAddressCity = saveContactWrappertransmitObjectotherAddressCity == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectotherAddressCity);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectotherAddressCity, nameof(saveContactWrappertransmitObjectotherAddressCity), required: false);
            var __workflow_saveContactWrappertransmitObjectotherAddressState = saveContactWrappertransmitObjectotherAddressState == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectotherAddressState);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectotherAddressState, nameof(saveContactWrappertransmitObjectotherAddressState), required: false);
            var __workflow_saveContactWrappertransmitObjectotherAddressCountryEn = saveContactWrappertransmitObjectotherAddressCountryEn == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectotherAddressCountryEn);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectotherAddressCountryEn, nameof(saveContactWrappertransmitObjectotherAddressCountryEn), required: false);
            var __workflow_saveContactWrappertransmitObjectotherAddressPOBox = saveContactWrappertransmitObjectotherAddressPOBox == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectotherAddressPOBox);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectotherAddressPOBox, nameof(saveContactWrappertransmitObjectotherAddressPOBox), required: false);
            var __workflow_saveContactWrappertransmitObjectotherAddressPostalCode = saveContactWrappertransmitObjectotherAddressPostalCode == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectotherAddressPostalCode);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectotherAddressPostalCode, nameof(saveContactWrappertransmitObjectotherAddressPostalCode), required: false);
            var __workflow_saveContactWrappertransmitObjectcompany = saveContactWrappertransmitObjectcompany == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectcompany);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectcompany, nameof(saveContactWrappertransmitObjectcompany), required: false);
            var __workflow_saveContactWrappertransmitObjectemail1Address = saveContactWrappertransmitObjectemail1Address == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectemail1Address);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectemail1Address, nameof(saveContactWrappertransmitObjectemail1Address), required: false);
            var __workflow_saveContactWrappertransmitObjectemail2Address = saveContactWrappertransmitObjectemail2Address == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectemail2Address);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectemail2Address, nameof(saveContactWrappertransmitObjectemail2Address), required: false);
            var __workflow_saveContactWrappertransmitObjectemail3Address = saveContactWrappertransmitObjectemail3Address == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectemail3Address);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectemail3Address, nameof(saveContactWrappertransmitObjectemail3Address), required: false);
            var __workflow_saveContactWrappertransmitObjectfirstName = saveContactWrappertransmitObjectfirstName == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectfirstName);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectfirstName, nameof(saveContactWrappertransmitObjectfirstName), required: false);
            var __workflow_saveContactWrappertransmitObjectiCQ = saveContactWrappertransmitObjectiCQ == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectiCQ);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectiCQ, nameof(saveContactWrappertransmitObjectiCQ), required: false);
            var __workflow_saveContactWrappertransmitObjectimportanceEn = saveContactWrappertransmitObjectimportanceEn == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectimportanceEn);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectimportanceEn, nameof(saveContactWrappertransmitObjectimportanceEn), required: false);
            var __workflow_saveContactWrappertransmitObjectlastName = saveContactWrappertransmitObjectlastName == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectlastName);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectlastName, nameof(saveContactWrappertransmitObjectlastName), required: false);
            var __workflow_saveContactWrappertransmitObjectmiddleName = saveContactWrappertransmitObjectmiddleName == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectmiddleName);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectmiddleName, nameof(saveContactWrappertransmitObjectmiddleName), required: false);
            var __workflow_saveContactWrappertransmitObjectmSN = saveContactWrappertransmitObjectmSN == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectmSN);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectmSN, nameof(saveContactWrappertransmitObjectmSN), required: false);
            var __workflow_saveContactWrappertransmitObjectnote = saveContactWrappertransmitObjectnote == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectnote);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectnote, nameof(saveContactWrappertransmitObjectnote), required: false);
            var __workflow_saveContactWrappertransmitObjectprefixEn = saveContactWrappertransmitObjectprefixEn == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectprefixEn);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectprefixEn, nameof(saveContactWrappertransmitObjectprefixEn), required: false);
            var __workflow_saveContactWrappertransmitObjectsuffixEn = saveContactWrappertransmitObjectsuffixEn == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectsuffixEn);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectsuffixEn, nameof(saveContactWrappertransmitObjectsuffixEn), required: false);
            var __workflow_saveContactWrappertransmitObjectskype = saveContactWrappertransmitObjectskype == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectskype);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectskype, nameof(saveContactWrappertransmitObjectskype), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber1 = saveContactWrappertransmitObjecttelephoneNumber1 == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber1);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjecttelephoneNumber1, nameof(saveContactWrappertransmitObjecttelephoneNumber1), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber2 = saveContactWrappertransmitObjecttelephoneNumber2 == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber2);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjecttelephoneNumber2, nameof(saveContactWrappertransmitObjecttelephoneNumber2), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber3 = saveContactWrappertransmitObjecttelephoneNumber3 == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber3);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjecttelephoneNumber3, nameof(saveContactWrappertransmitObjecttelephoneNumber3), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber4 = saveContactWrappertransmitObjecttelephoneNumber4 == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber4);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjecttelephoneNumber4, nameof(saveContactWrappertransmitObjecttelephoneNumber4), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber5 = saveContactWrappertransmitObjecttelephoneNumber5 == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber5);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjecttelephoneNumber5, nameof(saveContactWrappertransmitObjecttelephoneNumber5), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber6 = saveContactWrappertransmitObjecttelephoneNumber6 == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber6);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjecttelephoneNumber6, nameof(saveContactWrappertransmitObjecttelephoneNumber6), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber1Normalized = saveContactWrappertransmitObjecttelephoneNumber1Normalized == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber1Normalized);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjecttelephoneNumber1Normalized, nameof(saveContactWrappertransmitObjecttelephoneNumber1Normalized), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber2Normalized = saveContactWrappertransmitObjecttelephoneNumber2Normalized == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber2Normalized);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjecttelephoneNumber2Normalized, nameof(saveContactWrappertransmitObjecttelephoneNumber2Normalized), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber3Normalized = saveContactWrappertransmitObjecttelephoneNumber3Normalized == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber3Normalized);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjecttelephoneNumber3Normalized, nameof(saveContactWrappertransmitObjecttelephoneNumber3Normalized), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber4Normalized = saveContactWrappertransmitObjecttelephoneNumber4Normalized == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber4Normalized);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjecttelephoneNumber4Normalized, nameof(saveContactWrappertransmitObjecttelephoneNumber4Normalized), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber5Normalized = saveContactWrappertransmitObjecttelephoneNumber5Normalized == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber5Normalized);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjecttelephoneNumber5Normalized, nameof(saveContactWrappertransmitObjecttelephoneNumber5Normalized), required: false);
            var __workflow_saveContactWrappertransmitObjecttelephoneNumber6Normalized = saveContactWrappertransmitObjecttelephoneNumber6Normalized == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjecttelephoneNumber6Normalized);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjecttelephoneNumber6Normalized, nameof(saveContactWrappertransmitObjecttelephoneNumber6Normalized), required: false);
            var __workflow_saveContactWrappertransmitObjectdepartment = saveContactWrappertransmitObjectdepartment == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectdepartment);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectdepartment, nameof(saveContactWrappertransmitObjectdepartment), required: false);
            var __workflow_saveContactWrappertransmitObjecttitle = saveContactWrappertransmitObjecttitle == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjecttitle);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjecttitle, nameof(saveContactWrappertransmitObjecttitle), required: false);
            var __workflow_saveContactWrappertransmitObjectwebPage = saveContactWrappertransmitObjectwebPage == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectwebPage);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectwebPage, nameof(saveContactWrappertransmitObjectwebPage), required: false);
            var __workflow_saveContactWrappertransmitObjectdoNotSendNewsletter = saveContactWrappertransmitObjectdoNotSendNewsletter == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectdoNotSendNewsletter);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectdoNotSendNewsletter, nameof(saveContactWrappertransmitObjectdoNotSendNewsletter), required: false);
            var __workflow_saveContactWrappertransmitObjectprofilePicture = saveContactWrappertransmitObjectprofilePicture == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectprofilePicture);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectprofilePicture, nameof(saveContactWrappertransmitObjectprofilePicture), required: false);
            var __workflow_saveContactWrappertransmitObjectprofilePictureWidth = saveContactWrappertransmitObjectprofilePictureWidth == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectprofilePictureWidth);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectprofilePictureWidth, nameof(saveContactWrappertransmitObjectprofilePictureWidth), required: false);
            var __workflow_saveContactWrappertransmitObjectprofilePictureHeight = saveContactWrappertransmitObjectprofilePictureHeight == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectprofilePictureHeight);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectprofilePictureHeight, nameof(saveContactWrappertransmitObjectprofilePictureHeight), required: false);
            var __workflow_saveContactWrappertransmitObjectlastActivity = saveContactWrappertransmitObjectlastActivity == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectlastActivity);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectlastActivity, nameof(saveContactWrappertransmitObjectlastActivity), required: false);
            var __workflow_saveContactWrappertransmitObjectnextStep = saveContactWrappertransmitObjectnextStep == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectnextStep);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectnextStep, nameof(saveContactWrappertransmitObjectnextStep), required: false);
            var __workflow_saveContactWrappertransmitObjecttypeEn = saveContactWrappertransmitObjecttypeEn == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjecttypeEn);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjecttypeEn, nameof(saveContactWrappertransmitObjecttypeEn), required: false);
            var __workflow_saveContactWrappertransmitObjectstateEn = saveContactWrappertransmitObjectstateEn == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectstateEn);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectstateEn, nameof(saveContactWrappertransmitObjectstateEn), required: false);
            var __workflow_saveContactWrappertransmitObjectprevStateEn = saveContactWrappertransmitObjectprevStateEn == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectprevStateEn);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectprevStateEn, nameof(saveContactWrappertransmitObjectprevStateEn), required: false);
            var __workflow_saveContactWrappertransmitObjectcompaniesCompanyGuid = saveContactWrappertransmitObjectcompaniesCompanyGuid == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectcompaniesCompanyGuid);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectcompaniesCompanyGuid, nameof(saveContactWrappertransmitObjectcompaniesCompanyGuid), required: false);
            var __workflow_saveContactWrappertransmitObjectisPrivate = saveContactWrappertransmitObjectisPrivate == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectisPrivate);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectisPrivate, nameof(saveContactWrappertransmitObjectisPrivate), required: false);
            var __workflow_saveContactWrappertransmitObjectitemCreated = saveContactWrappertransmitObjectitemCreated == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectitemCreated);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectitemCreated, nameof(saveContactWrappertransmitObjectitemCreated), required: false);
            var __workflow_saveContactWrappertransmitObjectitemChanged = saveContactWrappertransmitObjectitemChanged == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectitemChanged);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectitemChanged, nameof(saveContactWrappertransmitObjectitemChanged), required: false);
            var __workflow_saveContactWrappertransmitObjectfileAs = saveContactWrappertransmitObjectfileAs == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectfileAs);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectfileAs, nameof(saveContactWrappertransmitObjectfileAs), required: false);
            var __workflow_saveContactWrappertransmitObjectownerGUID = saveContactWrappertransmitObjectownerGUID == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectownerGUID);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectownerGUID, nameof(saveContactWrappertransmitObjectownerGUID), required: false);
            var __workflow_saveContactWrappertransmitObjectcreatedByGUID = saveContactWrappertransmitObjectcreatedByGUID == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectcreatedByGUID);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectcreatedByGUID, nameof(saveContactWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_saveContactWrappertransmitObjectmodifiedByGUID = saveContactWrappertransmitObjectmodifiedByGUID == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectmodifiedByGUID);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectmodifiedByGUID, nameof(saveContactWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_saveContactWrappertransmitObjectadditionalFields = saveContactWrappertransmitObjectadditionalFields == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectadditionalFields);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectadditionalFields, nameof(saveContactWrappertransmitObjectadditionalFields), required: false);
            var __workflow_saveContactWrappertransmitObjectitemGUID = saveContactWrappertransmitObjectitemGUID == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectitemGUID);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectitemGUID, nameof(saveContactWrappertransmitObjectitemGUID), required: false);
            var __workflow_saveContactWrappertransmitObjectitemVersion = saveContactWrappertransmitObjectitemVersion == null ? null : WorkflowExpression.Compile(saveContactWrappertransmitObjectitemVersion);
            WorkflowExpression.Validate(__workflow_saveContactWrappertransmitObjectitemVersion, nameof(saveContactWrappertransmitObjectitemVersion), required: false);
            var __workflow_saveContactWrapperdieOnItemConflict = saveContactWrapperdieOnItemConflict == null ? null : WorkflowExpression.Compile(saveContactWrapperdieOnItemConflict);
            WorkflowExpression.Validate(__workflow_saveContactWrapperdieOnItemConflict, nameof(saveContactWrapperdieOnItemConflict), required: false);
            var __workflow_saveContactWrapperignoredUserErrorMessages = saveContactWrapperignoredUserErrorMessages == null ? null : WorkflowExpression.Compile(saveContactWrapperignoredUserErrorMessages);
            WorkflowExpression.Validate(__workflow_saveContactWrapperignoredUserErrorMessages, nameof(saveContactWrapperignoredUserErrorMessages), required: false);
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
            var __workflow_saveJournalWrappertransmitObjectcalendarEntryID = saveJournalWrappertransmitObjectcalendarEntryID == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectcalendarEntryID);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectcalendarEntryID, nameof(saveJournalWrappertransmitObjectcalendarEntryID), required: false);
            var __workflow_saveJournalWrappertransmitObjectcalendarORIGIN = saveJournalWrappertransmitObjectcalendarORIGIN == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectcalendarORIGIN);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectcalendarORIGIN, nameof(saveJournalWrappertransmitObjectcalendarORIGIN), required: false);
            var __workflow_saveJournalWrappertransmitObjectchangedField = saveJournalWrappertransmitObjectchangedField == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectchangedField);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectchangedField, nameof(saveJournalWrappertransmitObjectchangedField), required: false);
            var __workflow_saveJournalWrappertransmitObjecteventEnd = saveJournalWrappertransmitObjecteventEnd == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjecteventEnd);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjecteventEnd, nameof(saveJournalWrappertransmitObjecteventEnd), required: false);
            var __workflow_saveJournalWrappertransmitObjecteventStart = saveJournalWrappertransmitObjecteventStart == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjecteventStart);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjecteventStart, nameof(saveJournalWrappertransmitObjecteventStart), required: false);
            var __workflow_saveJournalWrappertransmitObjectfieldValue = saveJournalWrappertransmitObjectfieldValue == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectfieldValue);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectfieldValue, nameof(saveJournalWrappertransmitObjectfieldValue), required: false);
            var __workflow_saveJournalWrappertransmitObjectimportanceEn = saveJournalWrappertransmitObjectimportanceEn == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectimportanceEn);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectimportanceEn, nameof(saveJournalWrappertransmitObjectimportanceEn), required: false);
            var __workflow_saveJournalWrappertransmitObjectnote = saveJournalWrappertransmitObjectnote == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectnote);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectnote, nameof(saveJournalWrappertransmitObjectnote), required: false);
            var __workflow_saveJournalWrappertransmitObjectprevFieldValue = saveJournalWrappertransmitObjectprevFieldValue == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectprevFieldValue);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectprevFieldValue, nameof(saveJournalWrappertransmitObjectprevFieldValue), required: false);
            var __workflow_saveJournalWrappertransmitObjecttypeEn = saveJournalWrappertransmitObjecttypeEn == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjecttypeEn);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjecttypeEn, nameof(saveJournalWrappertransmitObjecttypeEn), required: false);
            var __workflow_saveJournalWrappertransmitObjectisSystem = saveJournalWrappertransmitObjectisSystem == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectisSystem);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectisSystem, nameof(saveJournalWrappertransmitObjectisSystem), required: false);
            var __workflow_saveJournalWrappertransmitObjectphone = saveJournalWrappertransmitObjectphone == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectphone);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectphone, nameof(saveJournalWrappertransmitObjectphone), required: false);
            var __workflow_saveJournalWrappertransmitObjectphoneNormalized = saveJournalWrappertransmitObjectphoneNormalized == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectphoneNormalized);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectphoneNormalized, nameof(saveJournalWrappertransmitObjectphoneNormalized), required: false);
            var __workflow_saveJournalWrappertransmitObjectisGdprRelevant = saveJournalWrappertransmitObjectisGdprRelevant == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectisGdprRelevant);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectisGdprRelevant, nameof(saveJournalWrappertransmitObjectisGdprRelevant), required: false);
            var __workflow_saveJournalWrappertransmitObjectpicture = saveJournalWrappertransmitObjectpicture == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectpicture);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectpicture, nameof(saveJournalWrappertransmitObjectpicture), required: false);
            var __workflow_saveJournalWrappertransmitObjectpictureWidth = saveJournalWrappertransmitObjectpictureWidth == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectpictureWidth);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectpictureWidth, nameof(saveJournalWrappertransmitObjectpictureWidth), required: false);
            var __workflow_saveJournalWrappertransmitObjectpictureHeight = saveJournalWrappertransmitObjectpictureHeight == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectpictureHeight);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectpictureHeight, nameof(saveJournalWrappertransmitObjectpictureHeight), required: false);
            var __workflow_saveJournalWrappertransmitObjectstateEn = saveJournalWrappertransmitObjectstateEn == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectstateEn);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectstateEn, nameof(saveJournalWrappertransmitObjectstateEn), required: false);
            var __workflow_saveJournalWrappertransmitObjectprevStateEn = saveJournalWrappertransmitObjectprevStateEn == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectprevStateEn);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectprevStateEn, nameof(saveJournalWrappertransmitObjectprevStateEn), required: false);
            var __workflow_saveJournalWrappertransmitObjectcompaniesCompanyGuid = saveJournalWrappertransmitObjectcompaniesCompanyGuid == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectcompaniesCompanyGuid);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectcompaniesCompanyGuid, nameof(saveJournalWrappertransmitObjectcompaniesCompanyGuid), required: false);
            var __workflow_saveJournalWrappertransmitObjectcontactsContactGuid = saveJournalWrappertransmitObjectcontactsContactGuid == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectcontactsContactGuid);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectcontactsContactGuid, nameof(saveJournalWrappertransmitObjectcontactsContactGuid), required: false);
            var __workflow_saveJournalWrappertransmitObjectleadsSuperiorItemGuid = saveJournalWrappertransmitObjectleadsSuperiorItemGuid == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectleadsSuperiorItemGuid);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectleadsSuperiorItemGuid, nameof(saveJournalWrappertransmitObjectleadsSuperiorItemGuid), required: false);
            var __workflow_saveJournalWrappertransmitObjectprojectsSuperiorItemGuid = saveJournalWrappertransmitObjectprojectsSuperiorItemGuid == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectprojectsSuperiorItemGuid);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectprojectsSuperiorItemGuid, nameof(saveJournalWrappertransmitObjectprojectsSuperiorItemGuid), required: false);
            var __workflow_saveJournalWrappertransmitObjectmarketingMarketingGuid = saveJournalWrappertransmitObjectmarketingMarketingGuid == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectmarketingMarketingGuid);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectmarketingMarketingGuid, nameof(saveJournalWrappertransmitObjectmarketingMarketingGuid), required: false);
            var __workflow_saveJournalWrappertransmitObjectisPrivate = saveJournalWrappertransmitObjectisPrivate == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectisPrivate);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectisPrivate, nameof(saveJournalWrappertransmitObjectisPrivate), required: false);
            var __workflow_saveJournalWrappertransmitObjectitemCreated = saveJournalWrappertransmitObjectitemCreated == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectitemCreated);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectitemCreated, nameof(saveJournalWrappertransmitObjectitemCreated), required: false);
            var __workflow_saveJournalWrappertransmitObjectitemChanged = saveJournalWrappertransmitObjectitemChanged == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectitemChanged);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectitemChanged, nameof(saveJournalWrappertransmitObjectitemChanged), required: false);
            var __workflow_saveJournalWrappertransmitObjectfileAs = saveJournalWrappertransmitObjectfileAs == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectfileAs);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectfileAs, nameof(saveJournalWrappertransmitObjectfileAs), required: false);
            var __workflow_saveJournalWrappertransmitObjectownerGUID = saveJournalWrappertransmitObjectownerGUID == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectownerGUID);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectownerGUID, nameof(saveJournalWrappertransmitObjectownerGUID), required: false);
            var __workflow_saveJournalWrappertransmitObjectcreatedByGUID = saveJournalWrappertransmitObjectcreatedByGUID == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectcreatedByGUID);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectcreatedByGUID, nameof(saveJournalWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_saveJournalWrappertransmitObjectmodifiedByGUID = saveJournalWrappertransmitObjectmodifiedByGUID == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectmodifiedByGUID);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectmodifiedByGUID, nameof(saveJournalWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_saveJournalWrappertransmitObjectadditionalFields = saveJournalWrappertransmitObjectadditionalFields == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectadditionalFields);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectadditionalFields, nameof(saveJournalWrappertransmitObjectadditionalFields), required: false);
            var __workflow_saveJournalWrappertransmitObjectitemGUID = saveJournalWrappertransmitObjectitemGUID == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectitemGUID);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectitemGUID, nameof(saveJournalWrappertransmitObjectitemGUID), required: false);
            var __workflow_saveJournalWrappertransmitObjectitemVersion = saveJournalWrappertransmitObjectitemVersion == null ? null : WorkflowExpression.Compile(saveJournalWrappertransmitObjectitemVersion);
            WorkflowExpression.Validate(__workflow_saveJournalWrappertransmitObjectitemVersion, nameof(saveJournalWrappertransmitObjectitemVersion), required: false);
            var __workflow_saveJournalWrapperdieOnItemConflict = saveJournalWrapperdieOnItemConflict == null ? null : WorkflowExpression.Compile(saveJournalWrapperdieOnItemConflict);
            WorkflowExpression.Validate(__workflow_saveJournalWrapperdieOnItemConflict, nameof(saveJournalWrapperdieOnItemConflict), required: false);
            var __workflow_saveJournalWrapperignoredUserErrorMessages = saveJournalWrapperignoredUserErrorMessages == null ? null : WorkflowExpression.Compile(saveJournalWrapperignoredUserErrorMessages);
            WorkflowExpression.Validate(__workflow_saveJournalWrapperignoredUserErrorMessages, nameof(saveJournalWrapperignoredUserErrorMessages), required: false);
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
            var __workflow_saveLeadWrappertransmitObjectcity = saveLeadWrappertransmitObjectcity == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectcity);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectcity, nameof(saveLeadWrappertransmitObjectcity), required: false);
            var __workflow_saveLeadWrappertransmitObjectcontactPerson = saveLeadWrappertransmitObjectcontactPerson == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectcontactPerson);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectcontactPerson, nameof(saveLeadWrappertransmitObjectcontactPerson), required: false);
            var __workflow_saveLeadWrappertransmitObjectcurrencyEn = saveLeadWrappertransmitObjectcurrencyEn == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectcurrencyEn);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectcurrencyEn, nameof(saveLeadWrappertransmitObjectcurrencyEn), required: false);
            var __workflow_saveLeadWrappertransmitObjectcustomer = saveLeadWrappertransmitObjectcustomer == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectcustomer);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectcustomer, nameof(saveLeadWrappertransmitObjectcustomer), required: false);
            var __workflow_saveLeadWrappertransmitObjectemail = saveLeadWrappertransmitObjectemail == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectemail);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectemail, nameof(saveLeadWrappertransmitObjectemail), required: false);
            var __workflow_saveLeadWrappertransmitObjectestimatedEnd = saveLeadWrappertransmitObjectestimatedEnd == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectestimatedEnd);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectestimatedEnd, nameof(saveLeadWrappertransmitObjectestimatedEnd), required: false);
            var __workflow_saveLeadWrappertransmitObjecthID = saveLeadWrappertransmitObjecthID == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjecthID);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjecthID, nameof(saveLeadWrappertransmitObjecthID), required: false);
            var __workflow_saveLeadWrappertransmitObjectleadOriginEn = saveLeadWrappertransmitObjectleadOriginEn == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectleadOriginEn);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectleadOriginEn, nameof(saveLeadWrappertransmitObjectleadOriginEn), required: false);
            var __workflow_saveLeadWrappertransmitObjectnote = saveLeadWrappertransmitObjectnote == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectnote);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectnote, nameof(saveLeadWrappertransmitObjectnote), required: false);
            var __workflow_saveLeadWrappertransmitObjectphone = saveLeadWrappertransmitObjectphone == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectphone);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectphone, nameof(saveLeadWrappertransmitObjectphone), required: false);
            var __workflow_saveLeadWrappertransmitObjectphoneNormalized = saveLeadWrappertransmitObjectphoneNormalized == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectphoneNormalized);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectphoneNormalized, nameof(saveLeadWrappertransmitObjectphoneNormalized), required: false);
            var __workflow_saveLeadWrappertransmitObjectprevStateEn = saveLeadWrappertransmitObjectprevStateEn == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectprevStateEn);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectprevStateEn, nameof(saveLeadWrappertransmitObjectprevStateEn), required: false);
            var __workflow_saveLeadWrappertransmitObjectprice = saveLeadWrappertransmitObjectprice == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectprice);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectprice, nameof(saveLeadWrappertransmitObjectprice), required: false);
            var __workflow_saveLeadWrappertransmitObjectpriceChanged = saveLeadWrappertransmitObjectpriceChanged == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectpriceChanged);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectpriceChanged, nameof(saveLeadWrappertransmitObjectpriceChanged), required: false);
            var __workflow_saveLeadWrappertransmitObjectpriceDefaultCurrency = saveLeadWrappertransmitObjectpriceDefaultCurrency == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectpriceDefaultCurrency);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectpriceDefaultCurrency, nameof(saveLeadWrappertransmitObjectpriceDefaultCurrency), required: false);
            var __workflow_saveLeadWrappertransmitObjectprobability = saveLeadWrappertransmitObjectprobability == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectprobability);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectprobability, nameof(saveLeadWrappertransmitObjectprobability), required: false);
            var __workflow_saveLeadWrappertransmitObjectreceiveDate = saveLeadWrappertransmitObjectreceiveDate == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectreceiveDate);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectreceiveDate, nameof(saveLeadWrappertransmitObjectreceiveDate), required: false);
            var __workflow_saveLeadWrappertransmitObjectstateEn = saveLeadWrappertransmitObjectstateEn == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectstateEn);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectstateEn, nameof(saveLeadWrappertransmitObjectstateEn), required: false);
            var __workflow_saveLeadWrappertransmitObjectstreet = saveLeadWrappertransmitObjectstreet == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectstreet);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectstreet, nameof(saveLeadWrappertransmitObjectstreet), required: false);
            var __workflow_saveLeadWrappertransmitObjecttypeEn = saveLeadWrappertransmitObjecttypeEn == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjecttypeEn);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjecttypeEn, nameof(saveLeadWrappertransmitObjecttypeEn), required: false);
            var __workflow_saveLeadWrappertransmitObjectzip = saveLeadWrappertransmitObjectzip == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectzip);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectzip, nameof(saveLeadWrappertransmitObjectzip), required: false);
            var __workflow_saveLeadWrappertransmitObjectlastActivity = saveLeadWrappertransmitObjectlastActivity == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectlastActivity);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectlastActivity, nameof(saveLeadWrappertransmitObjectlastActivity), required: false);
            var __workflow_saveLeadWrappertransmitObjectnextStep = saveLeadWrappertransmitObjectnextStep == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectnextStep);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectnextStep, nameof(saveLeadWrappertransmitObjectnextStep), required: false);
            var __workflow_saveLeadWrappertransmitObjectestimatedValue = saveLeadWrappertransmitObjectestimatedValue == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectestimatedValue);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectestimatedValue, nameof(saveLeadWrappertransmitObjectestimatedValue), required: false);
            var __workflow_saveLeadWrappertransmitObjectcountryEn = saveLeadWrappertransmitObjectcountryEn == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectcountryEn);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectcountryEn, nameof(saveLeadWrappertransmitObjectcountryEn), required: false);
            var __workflow_saveLeadWrappertransmitObjectstate = saveLeadWrappertransmitObjectstate == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectstate);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectstate, nameof(saveLeadWrappertransmitObjectstate), required: false);
            var __workflow_saveLeadWrappertransmitObjectpOBox = saveLeadWrappertransmitObjectpOBox == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectpOBox);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectpOBox, nameof(saveLeadWrappertransmitObjectpOBox), required: false);
            var __workflow_saveLeadWrappertransmitObjectemailOptOut = saveLeadWrappertransmitObjectemailOptOut == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectemailOptOut);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectemailOptOut, nameof(saveLeadWrappertransmitObjectemailOptOut), required: false);
            var __workflow_saveLeadWrappertransmitObjectpicture = saveLeadWrappertransmitObjectpicture == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectpicture);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectpicture, nameof(saveLeadWrappertransmitObjectpicture), required: false);
            var __workflow_saveLeadWrappertransmitObjectpictureWidth = saveLeadWrappertransmitObjectpictureWidth == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectpictureWidth);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectpictureWidth, nameof(saveLeadWrappertransmitObjectpictureWidth), required: false);
            var __workflow_saveLeadWrappertransmitObjectpictureHeight = saveLeadWrappertransmitObjectpictureHeight == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectpictureHeight);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectpictureHeight, nameof(saveLeadWrappertransmitObjectpictureHeight), required: false);
            var __workflow_saveLeadWrappertransmitObjectcompaniesCustomerGuid = saveLeadWrappertransmitObjectcompaniesCustomerGuid == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectcompaniesCustomerGuid);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectcompaniesCustomerGuid, nameof(saveLeadWrappertransmitObjectcompaniesCustomerGuid), required: false);
            var __workflow_saveLeadWrappertransmitObjectcontactsContactPersonGuid = saveLeadWrappertransmitObjectcontactsContactPersonGuid == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectcontactsContactPersonGuid);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectcontactsContactPersonGuid, nameof(saveLeadWrappertransmitObjectcontactsContactPersonGuid), required: false);
            var __workflow_saveLeadWrappertransmitObjectmarketingMarketingGuid = saveLeadWrappertransmitObjectmarketingMarketingGuid == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectmarketingMarketingGuid);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectmarketingMarketingGuid, nameof(saveLeadWrappertransmitObjectmarketingMarketingGuid), required: false);
            var __workflow_saveLeadWrappertransmitObjectisPrivate = saveLeadWrappertransmitObjectisPrivate == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectisPrivate);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectisPrivate, nameof(saveLeadWrappertransmitObjectisPrivate), required: false);
            var __workflow_saveLeadWrappertransmitObjectitemCreated = saveLeadWrappertransmitObjectitemCreated == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectitemCreated);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectitemCreated, nameof(saveLeadWrappertransmitObjectitemCreated), required: false);
            var __workflow_saveLeadWrappertransmitObjectitemChanged = saveLeadWrappertransmitObjectitemChanged == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectitemChanged);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectitemChanged, nameof(saveLeadWrappertransmitObjectitemChanged), required: false);
            var __workflow_saveLeadWrappertransmitObjectfileAs = saveLeadWrappertransmitObjectfileAs == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectfileAs);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectfileAs, nameof(saveLeadWrappertransmitObjectfileAs), required: false);
            var __workflow_saveLeadWrappertransmitObjectownerGUID = saveLeadWrappertransmitObjectownerGUID == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectownerGUID);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectownerGUID, nameof(saveLeadWrappertransmitObjectownerGUID), required: false);
            var __workflow_saveLeadWrappertransmitObjectcreatedByGUID = saveLeadWrappertransmitObjectcreatedByGUID == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectcreatedByGUID);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectcreatedByGUID, nameof(saveLeadWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_saveLeadWrappertransmitObjectmodifiedByGUID = saveLeadWrappertransmitObjectmodifiedByGUID == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectmodifiedByGUID);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectmodifiedByGUID, nameof(saveLeadWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_saveLeadWrappertransmitObjectadditionalFields = saveLeadWrappertransmitObjectadditionalFields == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectadditionalFields);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectadditionalFields, nameof(saveLeadWrappertransmitObjectadditionalFields), required: false);
            var __workflow_saveLeadWrappertransmitObjectitemGUID = saveLeadWrappertransmitObjectitemGUID == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectitemGUID);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectitemGUID, nameof(saveLeadWrappertransmitObjectitemGUID), required: false);
            var __workflow_saveLeadWrappertransmitObjectitemVersion = saveLeadWrappertransmitObjectitemVersion == null ? null : WorkflowExpression.Compile(saveLeadWrappertransmitObjectitemVersion);
            WorkflowExpression.Validate(__workflow_saveLeadWrappertransmitObjectitemVersion, nameof(saveLeadWrappertransmitObjectitemVersion), required: false);
            var __workflow_saveLeadWrapperdieOnItemConflict = saveLeadWrapperdieOnItemConflict == null ? null : WorkflowExpression.Compile(saveLeadWrapperdieOnItemConflict);
            WorkflowExpression.Validate(__workflow_saveLeadWrapperdieOnItemConflict, nameof(saveLeadWrapperdieOnItemConflict), required: false);
            var __workflow_saveLeadWrapperignoredUserErrorMessages = saveLeadWrapperignoredUserErrorMessages == null ? null : WorkflowExpression.Compile(saveLeadWrapperignoredUserErrorMessages);
            WorkflowExpression.Validate(__workflow_saveLeadWrapperignoredUserErrorMessages, nameof(saveLeadWrapperignoredUserErrorMessages), required: false);
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
            var __workflow_saveProjectWrappertransmitObjectnote = saveProjectWrappertransmitObjectnote == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectnote);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectnote, nameof(saveProjectWrappertransmitObjectnote), required: false);
            var __workflow_saveProjectWrappertransmitObjectprice = saveProjectWrappertransmitObjectprice == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectprice);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectprice, nameof(saveProjectWrappertransmitObjectprice), required: false);
            var __workflow_saveProjectWrappertransmitObjectprojectEnd = saveProjectWrappertransmitObjectprojectEnd == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectprojectEnd);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectprojectEnd, nameof(saveProjectWrappertransmitObjectprojectEnd), required: false);
            var __workflow_saveProjectWrappertransmitObjectprojectName = saveProjectWrappertransmitObjectprojectName == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectprojectName);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectprojectName, nameof(saveProjectWrappertransmitObjectprojectName), required: false);
            var __workflow_saveProjectWrappertransmitObjecttypeEn = saveProjectWrappertransmitObjecttypeEn == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjecttypeEn);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjecttypeEn, nameof(saveProjectWrappertransmitObjecttypeEn), required: false);
            var __workflow_saveProjectWrappertransmitObjectstateEn = saveProjectWrappertransmitObjectstateEn == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectstateEn);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectstateEn, nameof(saveProjectWrappertransmitObjectstateEn), required: false);
            var __workflow_saveProjectWrappertransmitObjectpeopleExpenses = saveProjectWrappertransmitObjectpeopleExpenses == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectpeopleExpenses);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectpeopleExpenses, nameof(saveProjectWrappertransmitObjectpeopleExpenses), required: false);
            var __workflow_saveProjectWrappertransmitObjectprojectRealEnd = saveProjectWrappertransmitObjectprojectRealEnd == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectprojectRealEnd);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectprojectRealEnd, nameof(saveProjectWrappertransmitObjectprojectRealEnd), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedPrice = saveProjectWrappertransmitObjectestimatedPrice == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedPrice);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectestimatedPrice, nameof(saveProjectWrappertransmitObjectestimatedPrice), required: false);
            var __workflow_saveProjectWrappertransmitObjecthID = saveProjectWrappertransmitObjecthID == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjecthID);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjecthID, nameof(saveProjectWrappertransmitObjecthID), required: false);
            var __workflow_saveProjectWrappertransmitObjectprojectOriginEn = saveProjectWrappertransmitObjectprojectOriginEn == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectprojectOriginEn);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectprojectOriginEn, nameof(saveProjectWrappertransmitObjectprojectOriginEn), required: false);
            var __workflow_saveProjectWrappertransmitObjectpaymentTypeEn = saveProjectWrappertransmitObjectpaymentTypeEn == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectpaymentTypeEn);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectpaymentTypeEn, nameof(saveProjectWrappertransmitObjectpaymentTypeEn), required: false);
            var __workflow_saveProjectWrappertransmitObjectotherExpenses = saveProjectWrappertransmitObjectotherExpenses == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectotherExpenses);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectotherExpenses, nameof(saveProjectWrappertransmitObjectotherExpenses), required: false);
            var __workflow_saveProjectWrappertransmitObjectmargin = saveProjectWrappertransmitObjectmargin == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectmargin);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectmargin, nameof(saveProjectWrappertransmitObjectmargin), required: false);
            var __workflow_saveProjectWrappertransmitObjectprofit = saveProjectWrappertransmitObjectprofit == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectprofit);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectprofit, nameof(saveProjectWrappertransmitObjectprofit), required: false);
            var __workflow_saveProjectWrappertransmitObjectpaymentMaturity = saveProjectWrappertransmitObjectpaymentMaturity == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectpaymentMaturity);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectpaymentMaturity, nameof(saveProjectWrappertransmitObjectpaymentMaturity), required: false);
            var __workflow_saveProjectWrappertransmitObjectinvoicePaymentDate = saveProjectWrappertransmitObjectinvoicePaymentDate == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectinvoicePaymentDate);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectinvoicePaymentDate, nameof(saveProjectWrappertransmitObjectinvoicePaymentDate), required: false);
            var __workflow_saveProjectWrappertransmitObjectinvoiceIssueDate = saveProjectWrappertransmitObjectinvoiceIssueDate == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectinvoiceIssueDate);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectinvoiceIssueDate, nameof(saveProjectWrappertransmitObjectinvoiceIssueDate), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedMargin = saveProjectWrappertransmitObjectestimatedMargin == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedMargin);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectestimatedMargin, nameof(saveProjectWrappertransmitObjectestimatedMargin), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedProfit = saveProjectWrappertransmitObjectestimatedProfit == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedProfit);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectestimatedProfit, nameof(saveProjectWrappertransmitObjectestimatedProfit), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedPeopleExpenses = saveProjectWrappertransmitObjectestimatedPeopleExpenses == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedPeopleExpenses);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectestimatedPeopleExpenses, nameof(saveProjectWrappertransmitObjectestimatedPeopleExpenses), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedOtherExpenses = saveProjectWrappertransmitObjectestimatedOtherExpenses == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedOtherExpenses);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectestimatedOtherExpenses, nameof(saveProjectWrappertransmitObjectestimatedOtherExpenses), required: false);
            var __workflow_saveProjectWrappertransmitObjectlicensesCount = saveProjectWrappertransmitObjectlicensesCount == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectlicensesCount);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectlicensesCount, nameof(saveProjectWrappertransmitObjectlicensesCount), required: false);
            var __workflow_saveProjectWrappertransmitObjectlicensePrice = saveProjectWrappertransmitObjectlicensePrice == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectlicensePrice);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectlicensePrice, nameof(saveProjectWrappertransmitObjectlicensePrice), required: false);
            var __workflow_saveProjectWrappertransmitObjectprevStateEn = saveProjectWrappertransmitObjectprevStateEn == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectprevStateEn);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectprevStateEn, nameof(saveProjectWrappertransmitObjectprevStateEn), required: false);
            var __workflow_saveProjectWrappertransmitObjectshowInCaplan = saveProjectWrappertransmitObjectshowInCaplan == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectshowInCaplan);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectshowInCaplan, nameof(saveProjectWrappertransmitObjectshowInCaplan), required: false);
            var __workflow_saveProjectWrappertransmitObjectprojectStart = saveProjectWrappertransmitObjectprojectStart == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectprojectStart);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectprojectStart, nameof(saveProjectWrappertransmitObjectprojectStart), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedWorkHours = saveProjectWrappertransmitObjectestimatedWorkHours == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedWorkHours);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectestimatedWorkHours, nameof(saveProjectWrappertransmitObjectestimatedWorkHours), required: false);
            var __workflow_saveProjectWrappertransmitObjecttotalWorkHours = saveProjectWrappertransmitObjecttotalWorkHours == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjecttotalWorkHours);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjecttotalWorkHours, nameof(saveProjectWrappertransmitObjecttotalWorkHours), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency = saveProjectWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency, nameof(saveProjectWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedOtherExpensesDefaultCurrency = saveProjectWrappertransmitObjectestimatedOtherExpensesDefaultCurrency == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedOtherExpensesDefaultCurrency);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectestimatedOtherExpensesDefaultCurrency, nameof(saveProjectWrappertransmitObjectestimatedOtherExpensesDefaultCurrency), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedPriceDefaultCurrency = saveProjectWrappertransmitObjectestimatedPriceDefaultCurrency == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedPriceDefaultCurrency);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectestimatedPriceDefaultCurrency, nameof(saveProjectWrappertransmitObjectestimatedPriceDefaultCurrency), required: false);
            var __workflow_saveProjectWrappertransmitObjectpeopleExpensesDefaultCurrency = saveProjectWrappertransmitObjectpeopleExpensesDefaultCurrency == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectpeopleExpensesDefaultCurrency);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectpeopleExpensesDefaultCurrency, nameof(saveProjectWrappertransmitObjectpeopleExpensesDefaultCurrency), required: false);
            var __workflow_saveProjectWrappertransmitObjectotherExpensesDefaultCurrency = saveProjectWrappertransmitObjectotherExpensesDefaultCurrency == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectotherExpensesDefaultCurrency);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectotherExpensesDefaultCurrency, nameof(saveProjectWrappertransmitObjectotherExpensesDefaultCurrency), required: false);
            var __workflow_saveProjectWrappertransmitObjectpriceDefaultCurrency = saveProjectWrappertransmitObjectpriceDefaultCurrency == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectpriceDefaultCurrency);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectpriceDefaultCurrency, nameof(saveProjectWrappertransmitObjectpriceDefaultCurrency), required: false);
            var __workflow_saveProjectWrappertransmitObjectprofitDefaultCurrency = saveProjectWrappertransmitObjectprofitDefaultCurrency == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectprofitDefaultCurrency);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectprofitDefaultCurrency, nameof(saveProjectWrappertransmitObjectprofitDefaultCurrency), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedProfitDefaultCurrency = saveProjectWrappertransmitObjectestimatedProfitDefaultCurrency == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedProfitDefaultCurrency);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectestimatedProfitDefaultCurrency, nameof(saveProjectWrappertransmitObjectestimatedProfitDefaultCurrency), required: false);
            var __workflow_saveProjectWrappertransmitObjectcurrencyEn = saveProjectWrappertransmitObjectcurrencyEn == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectcurrencyEn);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectcurrencyEn, nameof(saveProjectWrappertransmitObjectcurrencyEn), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedPeopleExpensesChanged = saveProjectWrappertransmitObjectestimatedPeopleExpensesChanged == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedPeopleExpensesChanged);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectestimatedPeopleExpensesChanged, nameof(saveProjectWrappertransmitObjectestimatedPeopleExpensesChanged), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedOtherExpensesChanged = saveProjectWrappertransmitObjectestimatedOtherExpensesChanged == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedOtherExpensesChanged);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectestimatedOtherExpensesChanged, nameof(saveProjectWrappertransmitObjectestimatedOtherExpensesChanged), required: false);
            var __workflow_saveProjectWrappertransmitObjectotherExpensesChanged = saveProjectWrappertransmitObjectotherExpensesChanged == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectotherExpensesChanged);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectotherExpensesChanged, nameof(saveProjectWrappertransmitObjectotherExpensesChanged), required: false);
            var __workflow_saveProjectWrappertransmitObjectestimatedPriceChanged = saveProjectWrappertransmitObjectestimatedPriceChanged == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectestimatedPriceChanged);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectestimatedPriceChanged, nameof(saveProjectWrappertransmitObjectestimatedPriceChanged), required: false);
            var __workflow_saveProjectWrappertransmitObjectpriceChanged = saveProjectWrappertransmitObjectpriceChanged == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectpriceChanged);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectpriceChanged, nameof(saveProjectWrappertransmitObjectpriceChanged), required: false);
            var __workflow_saveProjectWrappertransmitObjectlicensePriceChanged = saveProjectWrappertransmitObjectlicensePriceChanged == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectlicensePriceChanged);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectlicensePriceChanged, nameof(saveProjectWrappertransmitObjectlicensePriceChanged), required: false);
            var __workflow_saveProjectWrappertransmitObjectlicensePriceDefaultCurrency = saveProjectWrappertransmitObjectlicensePriceDefaultCurrency == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectlicensePriceDefaultCurrency);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectlicensePriceDefaultCurrency, nameof(saveProjectWrappertransmitObjectlicensePriceDefaultCurrency), required: false);
            var __workflow_saveProjectWrappertransmitObjectlastActivity = saveProjectWrappertransmitObjectlastActivity == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectlastActivity);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectlastActivity, nameof(saveProjectWrappertransmitObjectlastActivity), required: false);
            var __workflow_saveProjectWrappertransmitObjectnextStep = saveProjectWrappertransmitObjectnextStep == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectnextStep);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectnextStep, nameof(saveProjectWrappertransmitObjectnextStep), required: false);
            var __workflow_saveProjectWrappertransmitObjectpeopleExpensesChanged = saveProjectWrappertransmitObjectpeopleExpensesChanged == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectpeopleExpensesChanged);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectpeopleExpensesChanged, nameof(saveProjectWrappertransmitObjectpeopleExpensesChanged), required: false);
            var __workflow_saveProjectWrappertransmitObjectpicture = saveProjectWrappertransmitObjectpicture == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectpicture);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectpicture, nameof(saveProjectWrappertransmitObjectpicture), required: false);
            var __workflow_saveProjectWrappertransmitObjectpictureWidth = saveProjectWrappertransmitObjectpictureWidth == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectpictureWidth);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectpictureWidth, nameof(saveProjectWrappertransmitObjectpictureWidth), required: false);
            var __workflow_saveProjectWrappertransmitObjectpictureHeight = saveProjectWrappertransmitObjectpictureHeight == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectpictureHeight);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectpictureHeight, nameof(saveProjectWrappertransmitObjectpictureHeight), required: false);
            var __workflow_saveProjectWrappertransmitObjectcompaniesCustomerGuid = saveProjectWrappertransmitObjectcompaniesCustomerGuid == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectcompaniesCustomerGuid);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectcompaniesCustomerGuid, nameof(saveProjectWrappertransmitObjectcompaniesCustomerGuid), required: false);
            var __workflow_saveProjectWrappertransmitObjectcontactsContactPersonGuid = saveProjectWrappertransmitObjectcontactsContactPersonGuid == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectcontactsContactPersonGuid);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectcontactsContactPersonGuid, nameof(saveProjectWrappertransmitObjectcontactsContactPersonGuid), required: false);
            var __workflow_saveProjectWrappertransmitObjectleadsProjectOriginGuid = saveProjectWrappertransmitObjectleadsProjectOriginGuid == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectleadsProjectOriginGuid);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectleadsProjectOriginGuid, nameof(saveProjectWrappertransmitObjectleadsProjectOriginGuid), required: false);
            var __workflow_saveProjectWrappertransmitObjectprojectsSuperiorProjectGuid = saveProjectWrappertransmitObjectprojectsSuperiorProjectGuid == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectprojectsSuperiorProjectGuid);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectprojectsSuperiorProjectGuid, nameof(saveProjectWrappertransmitObjectprojectsSuperiorProjectGuid), required: false);
            var __workflow_saveProjectWrappertransmitObjectusersSupervisorGuid = saveProjectWrappertransmitObjectusersSupervisorGuid == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectusersSupervisorGuid);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectusersSupervisorGuid, nameof(saveProjectWrappertransmitObjectusersSupervisorGuid), required: false);
            var __workflow_saveProjectWrappertransmitObjectisPrivate = saveProjectWrappertransmitObjectisPrivate == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectisPrivate);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectisPrivate, nameof(saveProjectWrappertransmitObjectisPrivate), required: false);
            var __workflow_saveProjectWrappertransmitObjectitemCreated = saveProjectWrappertransmitObjectitemCreated == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectitemCreated);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectitemCreated, nameof(saveProjectWrappertransmitObjectitemCreated), required: false);
            var __workflow_saveProjectWrappertransmitObjectitemChanged = saveProjectWrappertransmitObjectitemChanged == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectitemChanged);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectitemChanged, nameof(saveProjectWrappertransmitObjectitemChanged), required: false);
            var __workflow_saveProjectWrappertransmitObjectfileAs = saveProjectWrappertransmitObjectfileAs == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectfileAs);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectfileAs, nameof(saveProjectWrappertransmitObjectfileAs), required: false);
            var __workflow_saveProjectWrappertransmitObjectownerGUID = saveProjectWrappertransmitObjectownerGUID == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectownerGUID);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectownerGUID, nameof(saveProjectWrappertransmitObjectownerGUID), required: false);
            var __workflow_saveProjectWrappertransmitObjectcreatedByGUID = saveProjectWrappertransmitObjectcreatedByGUID == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectcreatedByGUID);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectcreatedByGUID, nameof(saveProjectWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_saveProjectWrappertransmitObjectmodifiedByGUID = saveProjectWrappertransmitObjectmodifiedByGUID == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectmodifiedByGUID);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectmodifiedByGUID, nameof(saveProjectWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_saveProjectWrappertransmitObjectadditionalFields = saveProjectWrappertransmitObjectadditionalFields == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectadditionalFields);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectadditionalFields, nameof(saveProjectWrappertransmitObjectadditionalFields), required: false);
            var __workflow_saveProjectWrappertransmitObjectitemGUID = saveProjectWrappertransmitObjectitemGUID == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectitemGUID);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectitemGUID, nameof(saveProjectWrappertransmitObjectitemGUID), required: false);
            var __workflow_saveProjectWrappertransmitObjectitemVersion = saveProjectWrappertransmitObjectitemVersion == null ? null : WorkflowExpression.Compile(saveProjectWrappertransmitObjectitemVersion);
            WorkflowExpression.Validate(__workflow_saveProjectWrappertransmitObjectitemVersion, nameof(saveProjectWrappertransmitObjectitemVersion), required: false);
            var __workflow_saveProjectWrapperdieOnItemConflict = saveProjectWrapperdieOnItemConflict == null ? null : WorkflowExpression.Compile(saveProjectWrapperdieOnItemConflict);
            WorkflowExpression.Validate(__workflow_saveProjectWrapperdieOnItemConflict, nameof(saveProjectWrapperdieOnItemConflict), required: false);
            var __workflow_saveProjectWrapperignoredUserErrorMessages = saveProjectWrapperignoredUserErrorMessages == null ? null : WorkflowExpression.Compile(saveProjectWrapperignoredUserErrorMessages);
            WorkflowExpression.Validate(__workflow_saveProjectWrapperignoredUserErrorMessages, nameof(saveProjectWrapperignoredUserErrorMessages), required: false);
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
            var __workflow_saveRelationWrappertransmitObjectitemGUID1 = saveRelationWrappertransmitObjectitemGUID1 == null ? null : WorkflowExpression.Compile(saveRelationWrappertransmitObjectitemGUID1);
            WorkflowExpression.Validate(__workflow_saveRelationWrappertransmitObjectitemGUID1, nameof(saveRelationWrappertransmitObjectitemGUID1), required: false);
            var __workflow_saveRelationWrappertransmitObjectitemGUID2 = saveRelationWrappertransmitObjectitemGUID2 == null ? null : WorkflowExpression.Compile(saveRelationWrappertransmitObjectitemGUID2);
            WorkflowExpression.Validate(__workflow_saveRelationWrappertransmitObjectitemGUID2, nameof(saveRelationWrappertransmitObjectitemGUID2), required: false);
            var __workflow_saveRelationWrappertransmitObjectfolderName1 = saveRelationWrappertransmitObjectfolderName1 == null ? null : WorkflowExpression.Compile(saveRelationWrappertransmitObjectfolderName1);
            WorkflowExpression.Validate(__workflow_saveRelationWrappertransmitObjectfolderName1, nameof(saveRelationWrappertransmitObjectfolderName1), required: false);
            var __workflow_saveRelationWrappertransmitObjectfolderName2 = saveRelationWrappertransmitObjectfolderName2 == null ? null : WorkflowExpression.Compile(saveRelationWrappertransmitObjectfolderName2);
            WorkflowExpression.Validate(__workflow_saveRelationWrappertransmitObjectfolderName2, nameof(saveRelationWrappertransmitObjectfolderName2), required: false);
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
            var __workflow_saveTaskWrappertransmitObjectbody = saveTaskWrappertransmitObjectbody == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectbody);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectbody, nameof(saveTaskWrappertransmitObjectbody), required: false);
            var __workflow_saveTaskWrappertransmitObjectisCompleted = saveTaskWrappertransmitObjectisCompleted == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectisCompleted);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectisCompleted, nameof(saveTaskWrappertransmitObjectisCompleted), required: false);
            var __workflow_saveTaskWrappertransmitObjectdueDate = saveTaskWrappertransmitObjectdueDate == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectdueDate);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectdueDate, nameof(saveTaskWrappertransmitObjectdueDate), required: false);
            var __workflow_saveTaskWrappertransmitObjectpercentCompleteDecimal = saveTaskWrappertransmitObjectpercentCompleteDecimal == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectpercentCompleteDecimal);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectpercentCompleteDecimal, nameof(saveTaskWrappertransmitObjectpercentCompleteDecimal), required: false);
            var __workflow_saveTaskWrappertransmitObjectprevStateEn = saveTaskWrappertransmitObjectprevStateEn == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectprevStateEn);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectprevStateEn, nameof(saveTaskWrappertransmitObjectprevStateEn), required: false);
            var __workflow_saveTaskWrappertransmitObjectstartDate = saveTaskWrappertransmitObjectstartDate == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectstartDate);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectstartDate, nameof(saveTaskWrappertransmitObjectstartDate), required: false);
            var __workflow_saveTaskWrappertransmitObjectstateEn = saveTaskWrappertransmitObjectstateEn == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectstateEn);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectstateEn, nameof(saveTaskWrappertransmitObjectstateEn), required: false);
            var __workflow_saveTaskWrappertransmitObjectsubject = saveTaskWrappertransmitObjectsubject == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectsubject);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectsubject, nameof(saveTaskWrappertransmitObjectsubject), required: false);
            var __workflow_saveTaskWrappertransmitObjecttypeEn = saveTaskWrappertransmitObjecttypeEn == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjecttypeEn);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjecttypeEn, nameof(saveTaskWrappertransmitObjecttypeEn), required: false);
            var __workflow_saveTaskWrappertransmitObjectlevel = saveTaskWrappertransmitObjectlevel == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectlevel);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectlevel, nameof(saveTaskWrappertransmitObjectlevel), required: false);
            var __workflow_saveTaskWrappertransmitObjectimportanceEn = saveTaskWrappertransmitObjectimportanceEn == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectimportanceEn);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectimportanceEn, nameof(saveTaskWrappertransmitObjectimportanceEn), required: false);
            var __workflow_saveTaskWrappertransmitObjectactualWorkHours = saveTaskWrappertransmitObjectactualWorkHours == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectactualWorkHours);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectactualWorkHours, nameof(saveTaskWrappertransmitObjectactualWorkHours), required: false);
            var __workflow_saveTaskWrappertransmitObjectestimatedWorkHours = saveTaskWrappertransmitObjectestimatedWorkHours == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectestimatedWorkHours);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectestimatedWorkHours, nameof(saveTaskWrappertransmitObjectestimatedWorkHours), required: false);
            var __workflow_saveTaskWrappertransmitObjectisReminderSet = saveTaskWrappertransmitObjectisReminderSet == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectisReminderSet);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectisReminderSet, nameof(saveTaskWrappertransmitObjectisReminderSet), required: false);
            var __workflow_saveTaskWrappertransmitObjectreminderDate = saveTaskWrappertransmitObjectreminderDate == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectreminderDate);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectreminderDate, nameof(saveTaskWrappertransmitObjectreminderDate), required: false);
            var __workflow_saveTaskWrappertransmitObjectcompletedDate = saveTaskWrappertransmitObjectcompletedDate == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectcompletedDate);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectcompletedDate, nameof(saveTaskWrappertransmitObjectcompletedDate), required: false);
            var __workflow_saveTaskWrappertransmitObjectpicture = saveTaskWrappertransmitObjectpicture == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectpicture);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectpicture, nameof(saveTaskWrappertransmitObjectpicture), required: false);
            var __workflow_saveTaskWrappertransmitObjectpictureWidth = saveTaskWrappertransmitObjectpictureWidth == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectpictureWidth);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectpictureWidth, nameof(saveTaskWrappertransmitObjectpictureWidth), required: false);
            var __workflow_saveTaskWrappertransmitObjectpictureHeight = saveTaskWrappertransmitObjectpictureHeight == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectpictureHeight);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectpictureHeight, nameof(saveTaskWrappertransmitObjectpictureHeight), required: false);
            var __workflow_saveTaskWrappertransmitObjectleadsTaskParentGuid = saveTaskWrappertransmitObjectleadsTaskParentGuid == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectleadsTaskParentGuid);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectleadsTaskParentGuid, nameof(saveTaskWrappertransmitObjectleadsTaskParentGuid), required: false);
            var __workflow_saveTaskWrappertransmitObjectprojectsTaskParentGuid = saveTaskWrappertransmitObjectprojectsTaskParentGuid == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectprojectsTaskParentGuid);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectprojectsTaskParentGuid, nameof(saveTaskWrappertransmitObjectprojectsTaskParentGuid), required: false);
            var __workflow_saveTaskWrappertransmitObjecttasksTaskParentGuid = saveTaskWrappertransmitObjecttasksTaskParentGuid == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjecttasksTaskParentGuid);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjecttasksTaskParentGuid, nameof(saveTaskWrappertransmitObjecttasksTaskParentGuid), required: false);
            var __workflow_saveTaskWrappertransmitObjectmarketingTaskParentGuid = saveTaskWrappertransmitObjectmarketingTaskParentGuid == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectmarketingTaskParentGuid);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectmarketingTaskParentGuid, nameof(saveTaskWrappertransmitObjectmarketingTaskParentGuid), required: false);
            var __workflow_saveTaskWrappertransmitObjectcompaniesCompanyGuid = saveTaskWrappertransmitObjectcompaniesCompanyGuid == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectcompaniesCompanyGuid);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectcompaniesCompanyGuid, nameof(saveTaskWrappertransmitObjectcompaniesCompanyGuid), required: false);
            var __workflow_saveTaskWrappertransmitObjectcontactsContactGuid = saveTaskWrappertransmitObjectcontactsContactGuid == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectcontactsContactGuid);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectcontactsContactGuid, nameof(saveTaskWrappertransmitObjectcontactsContactGuid), required: false);
            var __workflow_saveTaskWrappertransmitObjectusersTaskDelegatorGuid = saveTaskWrappertransmitObjectusersTaskDelegatorGuid == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectusersTaskDelegatorGuid);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectusersTaskDelegatorGuid, nameof(saveTaskWrappertransmitObjectusersTaskDelegatorGuid), required: false);
            var __workflow_saveTaskWrappertransmitObjectusersTaskSolverGuid = saveTaskWrappertransmitObjectusersTaskSolverGuid == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectusersTaskSolverGuid);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectusersTaskSolverGuid, nameof(saveTaskWrappertransmitObjectusersTaskSolverGuid), required: false);
            var __workflow_saveTaskWrappertransmitObjecttasksTaskOriginGuid = saveTaskWrappertransmitObjecttasksTaskOriginGuid == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjecttasksTaskOriginGuid);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjecttasksTaskOriginGuid, nameof(saveTaskWrappertransmitObjecttasksTaskOriginGuid), required: false);
            var __workflow_saveTaskWrappertransmitObjectisPrivate = saveTaskWrappertransmitObjectisPrivate == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectisPrivate);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectisPrivate, nameof(saveTaskWrappertransmitObjectisPrivate), required: false);
            var __workflow_saveTaskWrappertransmitObjectitemCreated = saveTaskWrappertransmitObjectitemCreated == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectitemCreated);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectitemCreated, nameof(saveTaskWrappertransmitObjectitemCreated), required: false);
            var __workflow_saveTaskWrappertransmitObjectitemChanged = saveTaskWrappertransmitObjectitemChanged == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectitemChanged);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectitemChanged, nameof(saveTaskWrappertransmitObjectitemChanged), required: false);
            var __workflow_saveTaskWrappertransmitObjectfileAs = saveTaskWrappertransmitObjectfileAs == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectfileAs);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectfileAs, nameof(saveTaskWrappertransmitObjectfileAs), required: false);
            var __workflow_saveTaskWrappertransmitObjectownerGUID = saveTaskWrappertransmitObjectownerGUID == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectownerGUID);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectownerGUID, nameof(saveTaskWrappertransmitObjectownerGUID), required: false);
            var __workflow_saveTaskWrappertransmitObjectcreatedByGUID = saveTaskWrappertransmitObjectcreatedByGUID == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectcreatedByGUID);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectcreatedByGUID, nameof(saveTaskWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_saveTaskWrappertransmitObjectmodifiedByGUID = saveTaskWrappertransmitObjectmodifiedByGUID == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectmodifiedByGUID);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectmodifiedByGUID, nameof(saveTaskWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_saveTaskWrappertransmitObjectadditionalFields = saveTaskWrappertransmitObjectadditionalFields == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectadditionalFields);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectadditionalFields, nameof(saveTaskWrappertransmitObjectadditionalFields), required: false);
            var __workflow_saveTaskWrappertransmitObjectitemGUID = saveTaskWrappertransmitObjectitemGUID == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectitemGUID);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectitemGUID, nameof(saveTaskWrappertransmitObjectitemGUID), required: false);
            var __workflow_saveTaskWrappertransmitObjectitemVersion = saveTaskWrappertransmitObjectitemVersion == null ? null : WorkflowExpression.Compile(saveTaskWrappertransmitObjectitemVersion);
            WorkflowExpression.Validate(__workflow_saveTaskWrappertransmitObjectitemVersion, nameof(saveTaskWrappertransmitObjectitemVersion), required: false);
            var __workflow_saveTaskWrapperdieOnItemConflict = saveTaskWrapperdieOnItemConflict == null ? null : WorkflowExpression.Compile(saveTaskWrapperdieOnItemConflict);
            WorkflowExpression.Validate(__workflow_saveTaskWrapperdieOnItemConflict, nameof(saveTaskWrapperdieOnItemConflict), required: false);
            var __workflow_saveTaskWrapperignoredUserErrorMessages = saveTaskWrapperignoredUserErrorMessages == null ? null : WorkflowExpression.Compile(saveTaskWrapperignoredUserErrorMessages);
            WorkflowExpression.Validate(__workflow_saveTaskWrapperignoredUserErrorMessages, nameof(saveTaskWrapperignoredUserErrorMessages), required: false);
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
            var __workflow_searchCompaniesWrappertransmitObjectaccountNumber = searchCompaniesWrappertransmitObjectaccountNumber == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaccountNumber);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectaccountNumber, nameof(searchCompaniesWrappertransmitObjectaccountNumber), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress1POBox = searchCompaniesWrappertransmitObjectaddress1POBox == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress1POBox);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectaddress1POBox, nameof(searchCompaniesWrappertransmitObjectaddress1POBox), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress1Street = searchCompaniesWrappertransmitObjectaddress1Street == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress1Street);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectaddress1Street, nameof(searchCompaniesWrappertransmitObjectaddress1Street), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress1City = searchCompaniesWrappertransmitObjectaddress1City == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress1City);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectaddress1City, nameof(searchCompaniesWrappertransmitObjectaddress1City), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress1State = searchCompaniesWrappertransmitObjectaddress1State == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress1State);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectaddress1State, nameof(searchCompaniesWrappertransmitObjectaddress1State), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress1CountryEn = searchCompaniesWrappertransmitObjectaddress1CountryEn == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress1CountryEn);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectaddress1CountryEn, nameof(searchCompaniesWrappertransmitObjectaddress1CountryEn), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress1PostalCode = searchCompaniesWrappertransmitObjectaddress1PostalCode == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress1PostalCode);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectaddress1PostalCode, nameof(searchCompaniesWrappertransmitObjectaddress1PostalCode), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress2POBox = searchCompaniesWrappertransmitObjectaddress2POBox == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress2POBox);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectaddress2POBox, nameof(searchCompaniesWrappertransmitObjectaddress2POBox), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress2Street = searchCompaniesWrappertransmitObjectaddress2Street == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress2Street);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectaddress2Street, nameof(searchCompaniesWrappertransmitObjectaddress2Street), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress2City = searchCompaniesWrappertransmitObjectaddress2City == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress2City);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectaddress2City, nameof(searchCompaniesWrappertransmitObjectaddress2City), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress2State = searchCompaniesWrappertransmitObjectaddress2State == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress2State);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectaddress2State, nameof(searchCompaniesWrappertransmitObjectaddress2State), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress2CountryEn = searchCompaniesWrappertransmitObjectaddress2CountryEn == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress2CountryEn);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectaddress2CountryEn, nameof(searchCompaniesWrappertransmitObjectaddress2CountryEn), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress2PostalCode = searchCompaniesWrappertransmitObjectaddress2PostalCode == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress2PostalCode);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectaddress2PostalCode, nameof(searchCompaniesWrappertransmitObjectaddress2PostalCode), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress3POBox = searchCompaniesWrappertransmitObjectaddress3POBox == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress3POBox);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectaddress3POBox, nameof(searchCompaniesWrappertransmitObjectaddress3POBox), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress3Street = searchCompaniesWrappertransmitObjectaddress3Street == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress3Street);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectaddress3Street, nameof(searchCompaniesWrappertransmitObjectaddress3Street), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress3City = searchCompaniesWrappertransmitObjectaddress3City == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress3City);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectaddress3City, nameof(searchCompaniesWrappertransmitObjectaddress3City), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress3State = searchCompaniesWrappertransmitObjectaddress3State == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress3State);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectaddress3State, nameof(searchCompaniesWrappertransmitObjectaddress3State), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress3CountryEn = searchCompaniesWrappertransmitObjectaddress3CountryEn == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress3CountryEn);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectaddress3CountryEn, nameof(searchCompaniesWrappertransmitObjectaddress3CountryEn), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectaddress3PostalCode = searchCompaniesWrappertransmitObjectaddress3PostalCode == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectaddress3PostalCode);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectaddress3PostalCode, nameof(searchCompaniesWrappertransmitObjectaddress3PostalCode), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectcompanyName = searchCompaniesWrappertransmitObjectcompanyName == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectcompanyName);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectcompanyName, nameof(searchCompaniesWrappertransmitObjectcompanyName), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectdepartment = searchCompaniesWrappertransmitObjectdepartment == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectdepartment);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectdepartment, nameof(searchCompaniesWrappertransmitObjectdepartment), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectemail = searchCompaniesWrappertransmitObjectemail == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectemail);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectemail, nameof(searchCompaniesWrappertransmitObjectemail), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectemployeesCount = searchCompaniesWrappertransmitObjectemployeesCount == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectemployeesCount);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectemployeesCount, nameof(searchCompaniesWrappertransmitObjectemployeesCount), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectfax = searchCompaniesWrappertransmitObjectfax == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectfax);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectfax, nameof(searchCompaniesWrappertransmitObjectfax), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectfirstContactEn = searchCompaniesWrappertransmitObjectfirstContactEn == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectfirstContactEn);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectfirstContactEn, nameof(searchCompaniesWrappertransmitObjectfirstContactEn), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectiCQ = searchCompaniesWrappertransmitObjectiCQ == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectiCQ);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectiCQ, nameof(searchCompaniesWrappertransmitObjectiCQ), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectidentificationNumber = searchCompaniesWrappertransmitObjectidentificationNumber == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectidentificationNumber);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectidentificationNumber, nameof(searchCompaniesWrappertransmitObjectidentificationNumber), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectimportanceEn = searchCompaniesWrappertransmitObjectimportanceEn == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectimportanceEn);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectimportanceEn, nameof(searchCompaniesWrappertransmitObjectimportanceEn), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectlineOfBusiness = searchCompaniesWrappertransmitObjectlineOfBusiness == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectlineOfBusiness);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectlineOfBusiness, nameof(searchCompaniesWrappertransmitObjectlineOfBusiness), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectmailingListOther = searchCompaniesWrappertransmitObjectmailingListOther == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectmailingListOther);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectmailingListOther, nameof(searchCompaniesWrappertransmitObjectmailingListOther), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectmobile = searchCompaniesWrappertransmitObjectmobile == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectmobile);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectmobile, nameof(searchCompaniesWrappertransmitObjectmobile), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectmobileNormalized = searchCompaniesWrappertransmitObjectmobileNormalized == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectmobileNormalized);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectmobileNormalized, nameof(searchCompaniesWrappertransmitObjectmobileNormalized), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectmSN = searchCompaniesWrappertransmitObjectmSN == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectmSN);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectmSN, nameof(searchCompaniesWrappertransmitObjectmSN), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectnote = searchCompaniesWrappertransmitObjectnote == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectnote);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectnote, nameof(searchCompaniesWrappertransmitObjectnote), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectphone = searchCompaniesWrappertransmitObjectphone == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectphone);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectphone, nameof(searchCompaniesWrappertransmitObjectphone), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectphoneNormalized = searchCompaniesWrappertransmitObjectphoneNormalized == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectphoneNormalized);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectphoneNormalized, nameof(searchCompaniesWrappertransmitObjectphoneNormalized), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectpurchaser = searchCompaniesWrappertransmitObjectpurchaser == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectpurchaser);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectpurchaser, nameof(searchCompaniesWrappertransmitObjectpurchaser), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectreversal = searchCompaniesWrappertransmitObjectreversal == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectreversal);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectreversal, nameof(searchCompaniesWrappertransmitObjectreversal), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectskype = searchCompaniesWrappertransmitObjectskype == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectskype);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectskype, nameof(searchCompaniesWrappertransmitObjectskype), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectsuppliers = searchCompaniesWrappertransmitObjectsuppliers == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectsuppliers);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectsuppliers, nameof(searchCompaniesWrappertransmitObjectsuppliers), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectvATNumber = searchCompaniesWrappertransmitObjectvATNumber == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectvATNumber);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectvATNumber, nameof(searchCompaniesWrappertransmitObjectvATNumber), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectwebPage = searchCompaniesWrappertransmitObjectwebPage == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectwebPage);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectwebPage, nameof(searchCompaniesWrappertransmitObjectwebPage), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectadditionalDiscount = searchCompaniesWrappertransmitObjectadditionalDiscount == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectadditionalDiscount);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectadditionalDiscount, nameof(searchCompaniesWrappertransmitObjectadditionalDiscount), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectiD = searchCompaniesWrappertransmitObjectiD == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectiD);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectiD, nameof(searchCompaniesWrappertransmitObjectiD), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectcompetitor = searchCompaniesWrappertransmitObjectcompetitor == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectcompetitor);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectcompetitor, nameof(searchCompaniesWrappertransmitObjectcompetitor), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectsalePriceGuid = searchCompaniesWrappertransmitObjectsalePriceGuid == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectsalePriceGuid);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectsalePriceGuid, nameof(searchCompaniesWrappertransmitObjectsalePriceGuid), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectnotificationByEmail = searchCompaniesWrappertransmitObjectnotificationByEmail == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectnotificationByEmail);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectnotificationByEmail, nameof(searchCompaniesWrappertransmitObjectnotificationByEmail), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectnotificationBy = searchCompaniesWrappertransmitObjectnotificationBy == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectnotificationBy);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectnotificationBy, nameof(searchCompaniesWrappertransmitObjectnotificationBy), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectlastActivity = searchCompaniesWrappertransmitObjectlastActivity == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectlastActivity);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectlastActivity, nameof(searchCompaniesWrappertransmitObjectlastActivity), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectnextStep = searchCompaniesWrappertransmitObjectnextStep == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectnextStep);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectnextStep, nameof(searchCompaniesWrappertransmitObjectnextStep), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectemailOptOut = searchCompaniesWrappertransmitObjectemailOptOut == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectemailOptOut);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectemailOptOut, nameof(searchCompaniesWrappertransmitObjectemailOptOut), required: false);
            var __workflow_searchCompaniesWrappertransmitObjecttypeEn = searchCompaniesWrappertransmitObjecttypeEn == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjecttypeEn);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjecttypeEn, nameof(searchCompaniesWrappertransmitObjecttypeEn), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectstateEn = searchCompaniesWrappertransmitObjectstateEn == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectstateEn);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectstateEn, nameof(searchCompaniesWrappertransmitObjectstateEn), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectprevStateEn = searchCompaniesWrappertransmitObjectprevStateEn == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectprevStateEn);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectprevStateEn, nameof(searchCompaniesWrappertransmitObjectprevStateEn), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectpicture = searchCompaniesWrappertransmitObjectpicture == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectpicture);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectpicture, nameof(searchCompaniesWrappertransmitObjectpicture), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectpictureWidth = searchCompaniesWrappertransmitObjectpictureWidth == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectpictureWidth);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectpictureWidth, nameof(searchCompaniesWrappertransmitObjectpictureWidth), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectpictureHeight = searchCompaniesWrappertransmitObjectpictureHeight == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectpictureHeight);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectpictureHeight, nameof(searchCompaniesWrappertransmitObjectpictureHeight), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectisPrivate = searchCompaniesWrappertransmitObjectisPrivate == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectisPrivate);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectisPrivate, nameof(searchCompaniesWrappertransmitObjectisPrivate), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectserverItemCreated = searchCompaniesWrappertransmitObjectserverItemCreated == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectserverItemCreated);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectserverItemCreated, nameof(searchCompaniesWrappertransmitObjectserverItemCreated), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectserverItemChanged = searchCompaniesWrappertransmitObjectserverItemChanged == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectserverItemChanged);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectserverItemChanged, nameof(searchCompaniesWrappertransmitObjectserverItemChanged), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectitemCreated = searchCompaniesWrappertransmitObjectitemCreated == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectitemCreated);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectitemCreated, nameof(searchCompaniesWrappertransmitObjectitemCreated), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectitemChanged = searchCompaniesWrappertransmitObjectitemChanged == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectitemChanged);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectitemChanged, nameof(searchCompaniesWrappertransmitObjectitemChanged), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectfileAs = searchCompaniesWrappertransmitObjectfileAs == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectfileAs);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectfileAs, nameof(searchCompaniesWrappertransmitObjectfileAs), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectownerGUID = searchCompaniesWrappertransmitObjectownerGUID == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectownerGUID);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectownerGUID, nameof(searchCompaniesWrappertransmitObjectownerGUID), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectcreatedByGUID = searchCompaniesWrappertransmitObjectcreatedByGUID == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectcreatedByGUID);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectcreatedByGUID, nameof(searchCompaniesWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectmodifiedByGUID = searchCompaniesWrappertransmitObjectmodifiedByGUID == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectmodifiedByGUID);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectmodifiedByGUID, nameof(searchCompaniesWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectadditionalFields = searchCompaniesWrappertransmitObjectadditionalFields == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectadditionalFields);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectadditionalFields, nameof(searchCompaniesWrappertransmitObjectadditionalFields), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectrelations = searchCompaniesWrappertransmitObjectrelations == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectrelations);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectrelations, nameof(searchCompaniesWrappertransmitObjectrelations), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectitemGUID = searchCompaniesWrappertransmitObjectitemGUID == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectitemGUID);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectitemGUID, nameof(searchCompaniesWrappertransmitObjectitemGUID), required: false);
            var __workflow_searchCompaniesWrappertransmitObjectitemVersion = searchCompaniesWrappertransmitObjectitemVersion == null ? null : WorkflowExpression.Compile(searchCompaniesWrappertransmitObjectitemVersion);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrappertransmitObjectitemVersion, nameof(searchCompaniesWrappertransmitObjectitemVersion), required: false);
            var __workflow_searchCompaniesWrapperincludeRelations = searchCompaniesWrapperincludeRelations == null ? null : WorkflowExpression.Compile(searchCompaniesWrapperincludeRelations);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrapperincludeRelations, nameof(searchCompaniesWrapperincludeRelations), required: false);
            var __workflow_searchCompaniesWrapperrelationsFilterrelationType = searchCompaniesWrapperrelationsFilterrelationType == null ? null : WorkflowExpression.Compile(searchCompaniesWrapperrelationsFilterrelationType);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrapperrelationsFilterrelationType, nameof(searchCompaniesWrapperrelationsFilterrelationType), required: false);
            var __workflow_searchCompaniesWrapperrelationsFilterforeignFolderName = searchCompaniesWrapperrelationsFilterforeignFolderName == null ? null : WorkflowExpression.Compile(searchCompaniesWrapperrelationsFilterforeignFolderName);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrapperrelationsFilterforeignFolderName, nameof(searchCompaniesWrapperrelationsFilterforeignFolderName), required: false);
            var __workflow_searchCompaniesWrapperbinaryLogicalOperator = searchCompaniesWrapperbinaryLogicalOperator == null ? null : WorkflowExpression.Compile(searchCompaniesWrapperbinaryLogicalOperator);
            WorkflowExpression.Validate(__workflow_searchCompaniesWrapperbinaryLogicalOperator, nameof(searchCompaniesWrapperbinaryLogicalOperator), required: false);
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
            var __workflow_searchContactsWrappertransmitObjectcompaniesCompanyGuid = searchContactsWrappertransmitObjectcompaniesCompanyGuid == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectcompaniesCompanyGuid);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectcompaniesCompanyGuid, nameof(searchContactsWrappertransmitObjectcompaniesCompanyGuid), required: false);
            var __workflow_searchContactsWrappertransmitObjectbusinessAddressStreet = searchContactsWrappertransmitObjectbusinessAddressStreet == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectbusinessAddressStreet);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectbusinessAddressStreet, nameof(searchContactsWrappertransmitObjectbusinessAddressStreet), required: false);
            var __workflow_searchContactsWrappertransmitObjectbusinessAddressCity = searchContactsWrappertransmitObjectbusinessAddressCity == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectbusinessAddressCity);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectbusinessAddressCity, nameof(searchContactsWrappertransmitObjectbusinessAddressCity), required: false);
            var __workflow_searchContactsWrappertransmitObjectbusinessAddressState = searchContactsWrappertransmitObjectbusinessAddressState == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectbusinessAddressState);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectbusinessAddressState, nameof(searchContactsWrappertransmitObjectbusinessAddressState), required: false);
            var __workflow_searchContactsWrappertransmitObjectbusinessAddressCountryEn = searchContactsWrappertransmitObjectbusinessAddressCountryEn == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectbusinessAddressCountryEn);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectbusinessAddressCountryEn, nameof(searchContactsWrappertransmitObjectbusinessAddressCountryEn), required: false);
            var __workflow_searchContactsWrappertransmitObjectbusinessAddressPOBox = searchContactsWrappertransmitObjectbusinessAddressPOBox == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectbusinessAddressPOBox);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectbusinessAddressPOBox, nameof(searchContactsWrappertransmitObjectbusinessAddressPOBox), required: false);
            var __workflow_searchContactsWrappertransmitObjectbusinessAddressPostalCode = searchContactsWrappertransmitObjectbusinessAddressPostalCode == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectbusinessAddressPostalCode);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectbusinessAddressPostalCode, nameof(searchContactsWrappertransmitObjectbusinessAddressPostalCode), required: false);
            var __workflow_searchContactsWrappertransmitObjecthomeAddressStreet = searchContactsWrappertransmitObjecthomeAddressStreet == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjecthomeAddressStreet);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjecthomeAddressStreet, nameof(searchContactsWrappertransmitObjecthomeAddressStreet), required: false);
            var __workflow_searchContactsWrappertransmitObjecthomeAddressCity = searchContactsWrappertransmitObjecthomeAddressCity == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjecthomeAddressCity);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjecthomeAddressCity, nameof(searchContactsWrappertransmitObjecthomeAddressCity), required: false);
            var __workflow_searchContactsWrappertransmitObjecthomeAddressState = searchContactsWrappertransmitObjecthomeAddressState == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjecthomeAddressState);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjecthomeAddressState, nameof(searchContactsWrappertransmitObjecthomeAddressState), required: false);
            var __workflow_searchContactsWrappertransmitObjecthomeAddressCountryEn = searchContactsWrappertransmitObjecthomeAddressCountryEn == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjecthomeAddressCountryEn);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjecthomeAddressCountryEn, nameof(searchContactsWrappertransmitObjecthomeAddressCountryEn), required: false);
            var __workflow_searchContactsWrappertransmitObjecthomeAddressPOBox = searchContactsWrappertransmitObjecthomeAddressPOBox == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjecthomeAddressPOBox);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjecthomeAddressPOBox, nameof(searchContactsWrappertransmitObjecthomeAddressPOBox), required: false);
            var __workflow_searchContactsWrappertransmitObjecthomeAddressPostalCode = searchContactsWrappertransmitObjecthomeAddressPostalCode == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjecthomeAddressPostalCode);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjecthomeAddressPostalCode, nameof(searchContactsWrappertransmitObjecthomeAddressPostalCode), required: false);
            var __workflow_searchContactsWrappertransmitObjectotherAddressStreet = searchContactsWrappertransmitObjectotherAddressStreet == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectotherAddressStreet);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectotherAddressStreet, nameof(searchContactsWrappertransmitObjectotherAddressStreet), required: false);
            var __workflow_searchContactsWrappertransmitObjectotherAddressCity = searchContactsWrappertransmitObjectotherAddressCity == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectotherAddressCity);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectotherAddressCity, nameof(searchContactsWrappertransmitObjectotherAddressCity), required: false);
            var __workflow_searchContactsWrappertransmitObjectotherAddressState = searchContactsWrappertransmitObjectotherAddressState == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectotherAddressState);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectotherAddressState, nameof(searchContactsWrappertransmitObjectotherAddressState), required: false);
            var __workflow_searchContactsWrappertransmitObjectotherAddressCountryEn = searchContactsWrappertransmitObjectotherAddressCountryEn == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectotherAddressCountryEn);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectotherAddressCountryEn, nameof(searchContactsWrappertransmitObjectotherAddressCountryEn), required: false);
            var __workflow_searchContactsWrappertransmitObjectotherAddressPOBox = searchContactsWrappertransmitObjectotherAddressPOBox == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectotherAddressPOBox);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectotherAddressPOBox, nameof(searchContactsWrappertransmitObjectotherAddressPOBox), required: false);
            var __workflow_searchContactsWrappertransmitObjectotherAddressPostalCode = searchContactsWrappertransmitObjectotherAddressPostalCode == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectotherAddressPostalCode);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectotherAddressPostalCode, nameof(searchContactsWrappertransmitObjectotherAddressPostalCode), required: false);
            var __workflow_searchContactsWrappertransmitObjectcompany = searchContactsWrappertransmitObjectcompany == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectcompany);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectcompany, nameof(searchContactsWrappertransmitObjectcompany), required: false);
            var __workflow_searchContactsWrappertransmitObjectemail1Address = searchContactsWrappertransmitObjectemail1Address == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectemail1Address);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectemail1Address, nameof(searchContactsWrappertransmitObjectemail1Address), required: false);
            var __workflow_searchContactsWrappertransmitObjectemail2Address = searchContactsWrappertransmitObjectemail2Address == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectemail2Address);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectemail2Address, nameof(searchContactsWrappertransmitObjectemail2Address), required: false);
            var __workflow_searchContactsWrappertransmitObjectemail3Address = searchContactsWrappertransmitObjectemail3Address == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectemail3Address);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectemail3Address, nameof(searchContactsWrappertransmitObjectemail3Address), required: false);
            var __workflow_searchContactsWrappertransmitObjectfirstName = searchContactsWrappertransmitObjectfirstName == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectfirstName);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectfirstName, nameof(searchContactsWrappertransmitObjectfirstName), required: false);
            var __workflow_searchContactsWrappertransmitObjectiCQ = searchContactsWrappertransmitObjectiCQ == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectiCQ);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectiCQ, nameof(searchContactsWrappertransmitObjectiCQ), required: false);
            var __workflow_searchContactsWrappertransmitObjectimportanceEn = searchContactsWrappertransmitObjectimportanceEn == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectimportanceEn);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectimportanceEn, nameof(searchContactsWrappertransmitObjectimportanceEn), required: false);
            var __workflow_searchContactsWrappertransmitObjectlastName = searchContactsWrappertransmitObjectlastName == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectlastName);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectlastName, nameof(searchContactsWrappertransmitObjectlastName), required: false);
            var __workflow_searchContactsWrappertransmitObjectmiddleName = searchContactsWrappertransmitObjectmiddleName == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectmiddleName);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectmiddleName, nameof(searchContactsWrappertransmitObjectmiddleName), required: false);
            var __workflow_searchContactsWrappertransmitObjectmSN = searchContactsWrappertransmitObjectmSN == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectmSN);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectmSN, nameof(searchContactsWrappertransmitObjectmSN), required: false);
            var __workflow_searchContactsWrappertransmitObjectnote = searchContactsWrappertransmitObjectnote == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectnote);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectnote, nameof(searchContactsWrappertransmitObjectnote), required: false);
            var __workflow_searchContactsWrappertransmitObjectprefixEn = searchContactsWrappertransmitObjectprefixEn == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectprefixEn);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectprefixEn, nameof(searchContactsWrappertransmitObjectprefixEn), required: false);
            var __workflow_searchContactsWrappertransmitObjectsuffixEn = searchContactsWrappertransmitObjectsuffixEn == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectsuffixEn);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectsuffixEn, nameof(searchContactsWrappertransmitObjectsuffixEn), required: false);
            var __workflow_searchContactsWrappertransmitObjectskype = searchContactsWrappertransmitObjectskype == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectskype);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectskype, nameof(searchContactsWrappertransmitObjectskype), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber1 = searchContactsWrappertransmitObjecttelephoneNumber1 == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber1);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjecttelephoneNumber1, nameof(searchContactsWrappertransmitObjecttelephoneNumber1), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber2 = searchContactsWrappertransmitObjecttelephoneNumber2 == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber2);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjecttelephoneNumber2, nameof(searchContactsWrappertransmitObjecttelephoneNumber2), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber3 = searchContactsWrappertransmitObjecttelephoneNumber3 == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber3);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjecttelephoneNumber3, nameof(searchContactsWrappertransmitObjecttelephoneNumber3), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber4 = searchContactsWrappertransmitObjecttelephoneNumber4 == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber4);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjecttelephoneNumber4, nameof(searchContactsWrappertransmitObjecttelephoneNumber4), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber5 = searchContactsWrappertransmitObjecttelephoneNumber5 == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber5);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjecttelephoneNumber5, nameof(searchContactsWrappertransmitObjecttelephoneNumber5), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber6 = searchContactsWrappertransmitObjecttelephoneNumber6 == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber6);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjecttelephoneNumber6, nameof(searchContactsWrappertransmitObjecttelephoneNumber6), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber1Normalized = searchContactsWrappertransmitObjecttelephoneNumber1Normalized == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber1Normalized);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjecttelephoneNumber1Normalized, nameof(searchContactsWrappertransmitObjecttelephoneNumber1Normalized), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber2Normalized = searchContactsWrappertransmitObjecttelephoneNumber2Normalized == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber2Normalized);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjecttelephoneNumber2Normalized, nameof(searchContactsWrappertransmitObjecttelephoneNumber2Normalized), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber3Normalized = searchContactsWrappertransmitObjecttelephoneNumber3Normalized == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber3Normalized);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjecttelephoneNumber3Normalized, nameof(searchContactsWrappertransmitObjecttelephoneNumber3Normalized), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber4Normalized = searchContactsWrappertransmitObjecttelephoneNumber4Normalized == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber4Normalized);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjecttelephoneNumber4Normalized, nameof(searchContactsWrappertransmitObjecttelephoneNumber4Normalized), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber5Normalized = searchContactsWrappertransmitObjecttelephoneNumber5Normalized == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber5Normalized);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjecttelephoneNumber5Normalized, nameof(searchContactsWrappertransmitObjecttelephoneNumber5Normalized), required: false);
            var __workflow_searchContactsWrappertransmitObjecttelephoneNumber6Normalized = searchContactsWrappertransmitObjecttelephoneNumber6Normalized == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjecttelephoneNumber6Normalized);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjecttelephoneNumber6Normalized, nameof(searchContactsWrappertransmitObjecttelephoneNumber6Normalized), required: false);
            var __workflow_searchContactsWrappertransmitObjectdepartment = searchContactsWrappertransmitObjectdepartment == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectdepartment);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectdepartment, nameof(searchContactsWrappertransmitObjectdepartment), required: false);
            var __workflow_searchContactsWrappertransmitObjecttitle = searchContactsWrappertransmitObjecttitle == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjecttitle);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjecttitle, nameof(searchContactsWrappertransmitObjecttitle), required: false);
            var __workflow_searchContactsWrappertransmitObjectwebPage = searchContactsWrappertransmitObjectwebPage == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectwebPage);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectwebPage, nameof(searchContactsWrappertransmitObjectwebPage), required: false);
            var __workflow_searchContactsWrappertransmitObjectdoNotSendNewsletter = searchContactsWrappertransmitObjectdoNotSendNewsletter == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectdoNotSendNewsletter);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectdoNotSendNewsletter, nameof(searchContactsWrappertransmitObjectdoNotSendNewsletter), required: false);
            var __workflow_searchContactsWrappertransmitObjectprofilePicture = searchContactsWrappertransmitObjectprofilePicture == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectprofilePicture);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectprofilePicture, nameof(searchContactsWrappertransmitObjectprofilePicture), required: false);
            var __workflow_searchContactsWrappertransmitObjectprofilePictureWidth = searchContactsWrappertransmitObjectprofilePictureWidth == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectprofilePictureWidth);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectprofilePictureWidth, nameof(searchContactsWrappertransmitObjectprofilePictureWidth), required: false);
            var __workflow_searchContactsWrappertransmitObjectprofilePictureHeight = searchContactsWrappertransmitObjectprofilePictureHeight == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectprofilePictureHeight);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectprofilePictureHeight, nameof(searchContactsWrappertransmitObjectprofilePictureHeight), required: false);
            var __workflow_searchContactsWrappertransmitObjectlastActivity = searchContactsWrappertransmitObjectlastActivity == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectlastActivity);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectlastActivity, nameof(searchContactsWrappertransmitObjectlastActivity), required: false);
            var __workflow_searchContactsWrappertransmitObjectnextStep = searchContactsWrappertransmitObjectnextStep == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectnextStep);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectnextStep, nameof(searchContactsWrappertransmitObjectnextStep), required: false);
            var __workflow_searchContactsWrappertransmitObjecttypeEn = searchContactsWrappertransmitObjecttypeEn == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjecttypeEn);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjecttypeEn, nameof(searchContactsWrappertransmitObjecttypeEn), required: false);
            var __workflow_searchContactsWrappertransmitObjectstateEn = searchContactsWrappertransmitObjectstateEn == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectstateEn);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectstateEn, nameof(searchContactsWrappertransmitObjectstateEn), required: false);
            var __workflow_searchContactsWrappertransmitObjectprevStateEn = searchContactsWrappertransmitObjectprevStateEn == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectprevStateEn);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectprevStateEn, nameof(searchContactsWrappertransmitObjectprevStateEn), required: false);
            var __workflow_searchContactsWrappertransmitObjectisPrivate = searchContactsWrappertransmitObjectisPrivate == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectisPrivate);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectisPrivate, nameof(searchContactsWrappertransmitObjectisPrivate), required: false);
            var __workflow_searchContactsWrappertransmitObjectserverItemCreated = searchContactsWrappertransmitObjectserverItemCreated == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectserverItemCreated);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectserverItemCreated, nameof(searchContactsWrappertransmitObjectserverItemCreated), required: false);
            var __workflow_searchContactsWrappertransmitObjectserverItemChanged = searchContactsWrappertransmitObjectserverItemChanged == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectserverItemChanged);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectserverItemChanged, nameof(searchContactsWrappertransmitObjectserverItemChanged), required: false);
            var __workflow_searchContactsWrappertransmitObjectitemCreated = searchContactsWrappertransmitObjectitemCreated == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectitemCreated);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectitemCreated, nameof(searchContactsWrappertransmitObjectitemCreated), required: false);
            var __workflow_searchContactsWrappertransmitObjectitemChanged = searchContactsWrappertransmitObjectitemChanged == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectitemChanged);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectitemChanged, nameof(searchContactsWrappertransmitObjectitemChanged), required: false);
            var __workflow_searchContactsWrappertransmitObjectfileAs = searchContactsWrappertransmitObjectfileAs == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectfileAs);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectfileAs, nameof(searchContactsWrappertransmitObjectfileAs), required: false);
            var __workflow_searchContactsWrappertransmitObjectownerGUID = searchContactsWrappertransmitObjectownerGUID == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectownerGUID);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectownerGUID, nameof(searchContactsWrappertransmitObjectownerGUID), required: false);
            var __workflow_searchContactsWrappertransmitObjectcreatedByGUID = searchContactsWrappertransmitObjectcreatedByGUID == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectcreatedByGUID);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectcreatedByGUID, nameof(searchContactsWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_searchContactsWrappertransmitObjectmodifiedByGUID = searchContactsWrappertransmitObjectmodifiedByGUID == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectmodifiedByGUID);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectmodifiedByGUID, nameof(searchContactsWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_searchContactsWrappertransmitObjectadditionalFields = searchContactsWrappertransmitObjectadditionalFields == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectadditionalFields);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectadditionalFields, nameof(searchContactsWrappertransmitObjectadditionalFields), required: false);
            var __workflow_searchContactsWrappertransmitObjectrelations = searchContactsWrappertransmitObjectrelations == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectrelations);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectrelations, nameof(searchContactsWrappertransmitObjectrelations), required: false);
            var __workflow_searchContactsWrappertransmitObjectitemGUID = searchContactsWrappertransmitObjectitemGUID == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectitemGUID);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectitemGUID, nameof(searchContactsWrappertransmitObjectitemGUID), required: false);
            var __workflow_searchContactsWrappertransmitObjectitemVersion = searchContactsWrappertransmitObjectitemVersion == null ? null : WorkflowExpression.Compile(searchContactsWrappertransmitObjectitemVersion);
            WorkflowExpression.Validate(__workflow_searchContactsWrappertransmitObjectitemVersion, nameof(searchContactsWrappertransmitObjectitemVersion), required: false);
            var __workflow_searchContactsWrapperincludeRelations = searchContactsWrapperincludeRelations == null ? null : WorkflowExpression.Compile(searchContactsWrapperincludeRelations);
            WorkflowExpression.Validate(__workflow_searchContactsWrapperincludeRelations, nameof(searchContactsWrapperincludeRelations), required: false);
            var __workflow_searchContactsWrapperrelationsFilterrelationType = searchContactsWrapperrelationsFilterrelationType == null ? null : WorkflowExpression.Compile(searchContactsWrapperrelationsFilterrelationType);
            WorkflowExpression.Validate(__workflow_searchContactsWrapperrelationsFilterrelationType, nameof(searchContactsWrapperrelationsFilterrelationType), required: false);
            var __workflow_searchContactsWrapperrelationsFilterforeignFolderName = searchContactsWrapperrelationsFilterforeignFolderName == null ? null : WorkflowExpression.Compile(searchContactsWrapperrelationsFilterforeignFolderName);
            WorkflowExpression.Validate(__workflow_searchContactsWrapperrelationsFilterforeignFolderName, nameof(searchContactsWrapperrelationsFilterforeignFolderName), required: false);
            var __workflow_searchContactsWrapperincludeProfilePictures = searchContactsWrapperincludeProfilePictures == null ? null : WorkflowExpression.Compile(searchContactsWrapperincludeProfilePictures);
            WorkflowExpression.Validate(__workflow_searchContactsWrapperincludeProfilePictures, nameof(searchContactsWrapperincludeProfilePictures), required: false);
            var __workflow_searchContactsWrapperbinaryLogicalOperator = searchContactsWrapperbinaryLogicalOperator == null ? null : WorkflowExpression.Compile(searchContactsWrapperbinaryLogicalOperator);
            WorkflowExpression.Validate(__workflow_searchContactsWrapperbinaryLogicalOperator, nameof(searchContactsWrapperbinaryLogicalOperator), required: false);
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
            var __workflow_searchJournalsWrappertransmitObjectmarketingSuperiorItemGuid = searchJournalsWrappertransmitObjectmarketingSuperiorItemGuid == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectmarketingSuperiorItemGuid);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectmarketingSuperiorItemGuid, nameof(searchJournalsWrappertransmitObjectmarketingSuperiorItemGuid), required: false);
            var __workflow_searchJournalsWrappertransmitObjectcompaniesCompanyGuid = searchJournalsWrappertransmitObjectcompaniesCompanyGuid == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectcompaniesCompanyGuid);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectcompaniesCompanyGuid, nameof(searchJournalsWrappertransmitObjectcompaniesCompanyGuid), required: false);
            var __workflow_searchJournalsWrappertransmitObjectcontactsContactGuid = searchJournalsWrappertransmitObjectcontactsContactGuid == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectcontactsContactGuid);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectcontactsContactGuid, nameof(searchJournalsWrappertransmitObjectcontactsContactGuid), required: false);
            var __workflow_searchJournalsWrappertransmitObjectleadsSuperiorItemGuid = searchJournalsWrappertransmitObjectleadsSuperiorItemGuid == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectleadsSuperiorItemGuid);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectleadsSuperiorItemGuid, nameof(searchJournalsWrappertransmitObjectleadsSuperiorItemGuid), required: false);
            var __workflow_searchJournalsWrappertransmitObjectprojectsSuperiorItemGuid = searchJournalsWrappertransmitObjectprojectsSuperiorItemGuid == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectprojectsSuperiorItemGuid);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectprojectsSuperiorItemGuid, nameof(searchJournalsWrappertransmitObjectprojectsSuperiorItemGuid), required: false);
            var __workflow_searchJournalsWrappertransmitObjectmarketingMarketingGuid = searchJournalsWrappertransmitObjectmarketingMarketingGuid == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectmarketingMarketingGuid);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectmarketingMarketingGuid, nameof(searchJournalsWrappertransmitObjectmarketingMarketingGuid), required: false);
            var __workflow_searchJournalsWrappertransmitObjectcalendarEntryID = searchJournalsWrappertransmitObjectcalendarEntryID == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectcalendarEntryID);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectcalendarEntryID, nameof(searchJournalsWrappertransmitObjectcalendarEntryID), required: false);
            var __workflow_searchJournalsWrappertransmitObjectcalendarORIGIN = searchJournalsWrappertransmitObjectcalendarORIGIN == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectcalendarORIGIN);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectcalendarORIGIN, nameof(searchJournalsWrappertransmitObjectcalendarORIGIN), required: false);
            var __workflow_searchJournalsWrappertransmitObjectchangedField = searchJournalsWrappertransmitObjectchangedField == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectchangedField);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectchangedField, nameof(searchJournalsWrappertransmitObjectchangedField), required: false);
            var __workflow_searchJournalsWrappertransmitObjecteventEnd = searchJournalsWrappertransmitObjecteventEnd == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjecteventEnd);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjecteventEnd, nameof(searchJournalsWrappertransmitObjecteventEnd), required: false);
            var __workflow_searchJournalsWrappertransmitObjecteventStart = searchJournalsWrappertransmitObjecteventStart == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjecteventStart);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjecteventStart, nameof(searchJournalsWrappertransmitObjecteventStart), required: false);
            var __workflow_searchJournalsWrappertransmitObjectfieldValue = searchJournalsWrappertransmitObjectfieldValue == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectfieldValue);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectfieldValue, nameof(searchJournalsWrappertransmitObjectfieldValue), required: false);
            var __workflow_searchJournalsWrappertransmitObjectimportanceEn = searchJournalsWrappertransmitObjectimportanceEn == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectimportanceEn);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectimportanceEn, nameof(searchJournalsWrappertransmitObjectimportanceEn), required: false);
            var __workflow_searchJournalsWrappertransmitObjectnote = searchJournalsWrappertransmitObjectnote == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectnote);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectnote, nameof(searchJournalsWrappertransmitObjectnote), required: false);
            var __workflow_searchJournalsWrappertransmitObjectprevFieldValue = searchJournalsWrappertransmitObjectprevFieldValue == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectprevFieldValue);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectprevFieldValue, nameof(searchJournalsWrappertransmitObjectprevFieldValue), required: false);
            var __workflow_searchJournalsWrappertransmitObjecttypeEn = searchJournalsWrappertransmitObjecttypeEn == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjecttypeEn);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjecttypeEn, nameof(searchJournalsWrappertransmitObjecttypeEn), required: false);
            var __workflow_searchJournalsWrappertransmitObjectisSystem = searchJournalsWrappertransmitObjectisSystem == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectisSystem);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectisSystem, nameof(searchJournalsWrappertransmitObjectisSystem), required: false);
            var __workflow_searchJournalsWrappertransmitObjectphone = searchJournalsWrappertransmitObjectphone == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectphone);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectphone, nameof(searchJournalsWrappertransmitObjectphone), required: false);
            var __workflow_searchJournalsWrappertransmitObjectphoneNormalized = searchJournalsWrappertransmitObjectphoneNormalized == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectphoneNormalized);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectphoneNormalized, nameof(searchJournalsWrappertransmitObjectphoneNormalized), required: false);
            var __workflow_searchJournalsWrappertransmitObjectisGdprRelevant = searchJournalsWrappertransmitObjectisGdprRelevant == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectisGdprRelevant);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectisGdprRelevant, nameof(searchJournalsWrappertransmitObjectisGdprRelevant), required: false);
            var __workflow_searchJournalsWrappertransmitObjectpicture = searchJournalsWrappertransmitObjectpicture == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectpicture);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectpicture, nameof(searchJournalsWrappertransmitObjectpicture), required: false);
            var __workflow_searchJournalsWrappertransmitObjectpictureWidth = searchJournalsWrappertransmitObjectpictureWidth == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectpictureWidth);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectpictureWidth, nameof(searchJournalsWrappertransmitObjectpictureWidth), required: false);
            var __workflow_searchJournalsWrappertransmitObjectpictureHeight = searchJournalsWrappertransmitObjectpictureHeight == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectpictureHeight);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectpictureHeight, nameof(searchJournalsWrappertransmitObjectpictureHeight), required: false);
            var __workflow_searchJournalsWrappertransmitObjectstateEn = searchJournalsWrappertransmitObjectstateEn == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectstateEn);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectstateEn, nameof(searchJournalsWrappertransmitObjectstateEn), required: false);
            var __workflow_searchJournalsWrappertransmitObjectprevStateEn = searchJournalsWrappertransmitObjectprevStateEn == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectprevStateEn);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectprevStateEn, nameof(searchJournalsWrappertransmitObjectprevStateEn), required: false);
            var __workflow_searchJournalsWrappertransmitObjectisPrivate = searchJournalsWrappertransmitObjectisPrivate == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectisPrivate);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectisPrivate, nameof(searchJournalsWrappertransmitObjectisPrivate), required: false);
            var __workflow_searchJournalsWrappertransmitObjectserverItemCreated = searchJournalsWrappertransmitObjectserverItemCreated == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectserverItemCreated);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectserverItemCreated, nameof(searchJournalsWrappertransmitObjectserverItemCreated), required: false);
            var __workflow_searchJournalsWrappertransmitObjectserverItemChanged = searchJournalsWrappertransmitObjectserverItemChanged == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectserverItemChanged);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectserverItemChanged, nameof(searchJournalsWrappertransmitObjectserverItemChanged), required: false);
            var __workflow_searchJournalsWrappertransmitObjectitemCreated = searchJournalsWrappertransmitObjectitemCreated == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectitemCreated);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectitemCreated, nameof(searchJournalsWrappertransmitObjectitemCreated), required: false);
            var __workflow_searchJournalsWrappertransmitObjectitemChanged = searchJournalsWrappertransmitObjectitemChanged == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectitemChanged);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectitemChanged, nameof(searchJournalsWrappertransmitObjectitemChanged), required: false);
            var __workflow_searchJournalsWrappertransmitObjectfileAs = searchJournalsWrappertransmitObjectfileAs == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectfileAs);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectfileAs, nameof(searchJournalsWrappertransmitObjectfileAs), required: false);
            var __workflow_searchJournalsWrappertransmitObjectownerGUID = searchJournalsWrappertransmitObjectownerGUID == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectownerGUID);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectownerGUID, nameof(searchJournalsWrappertransmitObjectownerGUID), required: false);
            var __workflow_searchJournalsWrappertransmitObjectcreatedByGUID = searchJournalsWrappertransmitObjectcreatedByGUID == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectcreatedByGUID);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectcreatedByGUID, nameof(searchJournalsWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_searchJournalsWrappertransmitObjectmodifiedByGUID = searchJournalsWrappertransmitObjectmodifiedByGUID == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectmodifiedByGUID);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectmodifiedByGUID, nameof(searchJournalsWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_searchJournalsWrappertransmitObjectadditionalFields = searchJournalsWrappertransmitObjectadditionalFields == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectadditionalFields);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectadditionalFields, nameof(searchJournalsWrappertransmitObjectadditionalFields), required: false);
            var __workflow_searchJournalsWrappertransmitObjectrelations = searchJournalsWrappertransmitObjectrelations == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectrelations);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectrelations, nameof(searchJournalsWrappertransmitObjectrelations), required: false);
            var __workflow_searchJournalsWrappertransmitObjectitemGUID = searchJournalsWrappertransmitObjectitemGUID == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectitemGUID);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectitemGUID, nameof(searchJournalsWrappertransmitObjectitemGUID), required: false);
            var __workflow_searchJournalsWrappertransmitObjectitemVersion = searchJournalsWrappertransmitObjectitemVersion == null ? null : WorkflowExpression.Compile(searchJournalsWrappertransmitObjectitemVersion);
            WorkflowExpression.Validate(__workflow_searchJournalsWrappertransmitObjectitemVersion, nameof(searchJournalsWrappertransmitObjectitemVersion), required: false);
            var __workflow_searchJournalsWrapperincludeRelations = searchJournalsWrapperincludeRelations == null ? null : WorkflowExpression.Compile(searchJournalsWrapperincludeRelations);
            WorkflowExpression.Validate(__workflow_searchJournalsWrapperincludeRelations, nameof(searchJournalsWrapperincludeRelations), required: false);
            var __workflow_searchJournalsWrapperrelationsFilterrelationType = searchJournalsWrapperrelationsFilterrelationType == null ? null : WorkflowExpression.Compile(searchJournalsWrapperrelationsFilterrelationType);
            WorkflowExpression.Validate(__workflow_searchJournalsWrapperrelationsFilterrelationType, nameof(searchJournalsWrapperrelationsFilterrelationType), required: false);
            var __workflow_searchJournalsWrapperrelationsFilterforeignFolderName = searchJournalsWrapperrelationsFilterforeignFolderName == null ? null : WorkflowExpression.Compile(searchJournalsWrapperrelationsFilterforeignFolderName);
            WorkflowExpression.Validate(__workflow_searchJournalsWrapperrelationsFilterforeignFolderName, nameof(searchJournalsWrapperrelationsFilterforeignFolderName), required: false);
            var __workflow_searchJournalsWrapperbinaryLogicalOperator = searchJournalsWrapperbinaryLogicalOperator == null ? null : WorkflowExpression.Compile(searchJournalsWrapperbinaryLogicalOperator);
            WorkflowExpression.Validate(__workflow_searchJournalsWrapperbinaryLogicalOperator, nameof(searchJournalsWrapperbinaryLogicalOperator), required: false);
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
            var __workflow_searchLeadsWrappertransmitObjectcompaniesCustomerGuid = searchLeadsWrappertransmitObjectcompaniesCustomerGuid == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectcompaniesCustomerGuid);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectcompaniesCustomerGuid, nameof(searchLeadsWrappertransmitObjectcompaniesCustomerGuid), required: false);
            var __workflow_searchLeadsWrappertransmitObjectcontactsContactPersonGuid = searchLeadsWrappertransmitObjectcontactsContactPersonGuid == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectcontactsContactPersonGuid);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectcontactsContactPersonGuid, nameof(searchLeadsWrappertransmitObjectcontactsContactPersonGuid), required: false);
            var __workflow_searchLeadsWrappertransmitObjectmarketingMarketingGuid = searchLeadsWrappertransmitObjectmarketingMarketingGuid == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectmarketingMarketingGuid);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectmarketingMarketingGuid, nameof(searchLeadsWrappertransmitObjectmarketingMarketingGuid), required: false);
            var __workflow_searchLeadsWrappertransmitObjectcity = searchLeadsWrappertransmitObjectcity == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectcity);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectcity, nameof(searchLeadsWrappertransmitObjectcity), required: false);
            var __workflow_searchLeadsWrappertransmitObjectcontactPerson = searchLeadsWrappertransmitObjectcontactPerson == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectcontactPerson);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectcontactPerson, nameof(searchLeadsWrappertransmitObjectcontactPerson), required: false);
            var __workflow_searchLeadsWrappertransmitObjectcurrencyEn = searchLeadsWrappertransmitObjectcurrencyEn == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectcurrencyEn);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectcurrencyEn, nameof(searchLeadsWrappertransmitObjectcurrencyEn), required: false);
            var __workflow_searchLeadsWrappertransmitObjectcustomer = searchLeadsWrappertransmitObjectcustomer == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectcustomer);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectcustomer, nameof(searchLeadsWrappertransmitObjectcustomer), required: false);
            var __workflow_searchLeadsWrappertransmitObjectemail = searchLeadsWrappertransmitObjectemail == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectemail);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectemail, nameof(searchLeadsWrappertransmitObjectemail), required: false);
            var __workflow_searchLeadsWrappertransmitObjectestimatedEnd = searchLeadsWrappertransmitObjectestimatedEnd == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectestimatedEnd);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectestimatedEnd, nameof(searchLeadsWrappertransmitObjectestimatedEnd), required: false);
            var __workflow_searchLeadsWrappertransmitObjecthID = searchLeadsWrappertransmitObjecthID == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjecthID);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjecthID, nameof(searchLeadsWrappertransmitObjecthID), required: false);
            var __workflow_searchLeadsWrappertransmitObjectleadOriginEn = searchLeadsWrappertransmitObjectleadOriginEn == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectleadOriginEn);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectleadOriginEn, nameof(searchLeadsWrappertransmitObjectleadOriginEn), required: false);
            var __workflow_searchLeadsWrappertransmitObjectnote = searchLeadsWrappertransmitObjectnote == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectnote);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectnote, nameof(searchLeadsWrappertransmitObjectnote), required: false);
            var __workflow_searchLeadsWrappertransmitObjectphone = searchLeadsWrappertransmitObjectphone == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectphone);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectphone, nameof(searchLeadsWrappertransmitObjectphone), required: false);
            var __workflow_searchLeadsWrappertransmitObjectphoneNormalized = searchLeadsWrappertransmitObjectphoneNormalized == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectphoneNormalized);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectphoneNormalized, nameof(searchLeadsWrappertransmitObjectphoneNormalized), required: false);
            var __workflow_searchLeadsWrappertransmitObjectprevStateEn = searchLeadsWrappertransmitObjectprevStateEn == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectprevStateEn);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectprevStateEn, nameof(searchLeadsWrappertransmitObjectprevStateEn), required: false);
            var __workflow_searchLeadsWrappertransmitObjectprice = searchLeadsWrappertransmitObjectprice == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectprice);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectprice, nameof(searchLeadsWrappertransmitObjectprice), required: false);
            var __workflow_searchLeadsWrappertransmitObjectpriceChanged = searchLeadsWrappertransmitObjectpriceChanged == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectpriceChanged);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectpriceChanged, nameof(searchLeadsWrappertransmitObjectpriceChanged), required: false);
            var __workflow_searchLeadsWrappertransmitObjectpriceDefaultCurrency = searchLeadsWrappertransmitObjectpriceDefaultCurrency == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectpriceDefaultCurrency);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectpriceDefaultCurrency, nameof(searchLeadsWrappertransmitObjectpriceDefaultCurrency), required: false);
            var __workflow_searchLeadsWrappertransmitObjectprobability = searchLeadsWrappertransmitObjectprobability == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectprobability);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectprobability, nameof(searchLeadsWrappertransmitObjectprobability), required: false);
            var __workflow_searchLeadsWrappertransmitObjectreceiveDate = searchLeadsWrappertransmitObjectreceiveDate == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectreceiveDate);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectreceiveDate, nameof(searchLeadsWrappertransmitObjectreceiveDate), required: false);
            var __workflow_searchLeadsWrappertransmitObjectstateEn = searchLeadsWrappertransmitObjectstateEn == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectstateEn);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectstateEn, nameof(searchLeadsWrappertransmitObjectstateEn), required: false);
            var __workflow_searchLeadsWrappertransmitObjectstreet = searchLeadsWrappertransmitObjectstreet == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectstreet);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectstreet, nameof(searchLeadsWrappertransmitObjectstreet), required: false);
            var __workflow_searchLeadsWrappertransmitObjecttypeEn = searchLeadsWrappertransmitObjecttypeEn == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjecttypeEn);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjecttypeEn, nameof(searchLeadsWrappertransmitObjecttypeEn), required: false);
            var __workflow_searchLeadsWrappertransmitObjectzip = searchLeadsWrappertransmitObjectzip == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectzip);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectzip, nameof(searchLeadsWrappertransmitObjectzip), required: false);
            var __workflow_searchLeadsWrappertransmitObjectlastActivity = searchLeadsWrappertransmitObjectlastActivity == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectlastActivity);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectlastActivity, nameof(searchLeadsWrappertransmitObjectlastActivity), required: false);
            var __workflow_searchLeadsWrappertransmitObjectnextStep = searchLeadsWrappertransmitObjectnextStep == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectnextStep);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectnextStep, nameof(searchLeadsWrappertransmitObjectnextStep), required: false);
            var __workflow_searchLeadsWrappertransmitObjectestimatedValue = searchLeadsWrappertransmitObjectestimatedValue == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectestimatedValue);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectestimatedValue, nameof(searchLeadsWrappertransmitObjectestimatedValue), required: false);
            var __workflow_searchLeadsWrappertransmitObjectisCompleted = searchLeadsWrappertransmitObjectisCompleted == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectisCompleted);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectisCompleted, nameof(searchLeadsWrappertransmitObjectisCompleted), required: false);
            var __workflow_searchLeadsWrappertransmitObjectisLost = searchLeadsWrappertransmitObjectisLost == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectisLost);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectisLost, nameof(searchLeadsWrappertransmitObjectisLost), required: false);
            var __workflow_searchLeadsWrappertransmitObjectcountryEn = searchLeadsWrappertransmitObjectcountryEn == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectcountryEn);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectcountryEn, nameof(searchLeadsWrappertransmitObjectcountryEn), required: false);
            var __workflow_searchLeadsWrappertransmitObjectstate = searchLeadsWrappertransmitObjectstate == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectstate);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectstate, nameof(searchLeadsWrappertransmitObjectstate), required: false);
            var __workflow_searchLeadsWrappertransmitObjectpOBox = searchLeadsWrappertransmitObjectpOBox == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectpOBox);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectpOBox, nameof(searchLeadsWrappertransmitObjectpOBox), required: false);
            var __workflow_searchLeadsWrappertransmitObjectemailOptOut = searchLeadsWrappertransmitObjectemailOptOut == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectemailOptOut);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectemailOptOut, nameof(searchLeadsWrappertransmitObjectemailOptOut), required: false);
            var __workflow_searchLeadsWrappertransmitObjectpicture = searchLeadsWrappertransmitObjectpicture == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectpicture);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectpicture, nameof(searchLeadsWrappertransmitObjectpicture), required: false);
            var __workflow_searchLeadsWrappertransmitObjectpictureWidth = searchLeadsWrappertransmitObjectpictureWidth == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectpictureWidth);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectpictureWidth, nameof(searchLeadsWrappertransmitObjectpictureWidth), required: false);
            var __workflow_searchLeadsWrappertransmitObjectpictureHeight = searchLeadsWrappertransmitObjectpictureHeight == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectpictureHeight);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectpictureHeight, nameof(searchLeadsWrappertransmitObjectpictureHeight), required: false);
            var __workflow_searchLeadsWrappertransmitObjectcompletedDate = searchLeadsWrappertransmitObjectcompletedDate == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectcompletedDate);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectcompletedDate, nameof(searchLeadsWrappertransmitObjectcompletedDate), required: false);
            var __workflow_searchLeadsWrappertransmitObjectlostDate = searchLeadsWrappertransmitObjectlostDate == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectlostDate);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectlostDate, nameof(searchLeadsWrappertransmitObjectlostDate), required: false);
            var __workflow_searchLeadsWrappertransmitObjectisPrivate = searchLeadsWrappertransmitObjectisPrivate == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectisPrivate);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectisPrivate, nameof(searchLeadsWrappertransmitObjectisPrivate), required: false);
            var __workflow_searchLeadsWrappertransmitObjectserverItemCreated = searchLeadsWrappertransmitObjectserverItemCreated == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectserverItemCreated);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectserverItemCreated, nameof(searchLeadsWrappertransmitObjectserverItemCreated), required: false);
            var __workflow_searchLeadsWrappertransmitObjectserverItemChanged = searchLeadsWrappertransmitObjectserverItemChanged == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectserverItemChanged);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectserverItemChanged, nameof(searchLeadsWrappertransmitObjectserverItemChanged), required: false);
            var __workflow_searchLeadsWrappertransmitObjectitemCreated = searchLeadsWrappertransmitObjectitemCreated == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectitemCreated);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectitemCreated, nameof(searchLeadsWrappertransmitObjectitemCreated), required: false);
            var __workflow_searchLeadsWrappertransmitObjectitemChanged = searchLeadsWrappertransmitObjectitemChanged == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectitemChanged);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectitemChanged, nameof(searchLeadsWrappertransmitObjectitemChanged), required: false);
            var __workflow_searchLeadsWrappertransmitObjectfileAs = searchLeadsWrappertransmitObjectfileAs == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectfileAs);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectfileAs, nameof(searchLeadsWrappertransmitObjectfileAs), required: false);
            var __workflow_searchLeadsWrappertransmitObjectownerGUID = searchLeadsWrappertransmitObjectownerGUID == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectownerGUID);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectownerGUID, nameof(searchLeadsWrappertransmitObjectownerGUID), required: false);
            var __workflow_searchLeadsWrappertransmitObjectcreatedByGUID = searchLeadsWrappertransmitObjectcreatedByGUID == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectcreatedByGUID);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectcreatedByGUID, nameof(searchLeadsWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_searchLeadsWrappertransmitObjectmodifiedByGUID = searchLeadsWrappertransmitObjectmodifiedByGUID == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectmodifiedByGUID);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectmodifiedByGUID, nameof(searchLeadsWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_searchLeadsWrappertransmitObjectadditionalFields = searchLeadsWrappertransmitObjectadditionalFields == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectadditionalFields);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectadditionalFields, nameof(searchLeadsWrappertransmitObjectadditionalFields), required: false);
            var __workflow_searchLeadsWrappertransmitObjectrelations = searchLeadsWrappertransmitObjectrelations == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectrelations);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectrelations, nameof(searchLeadsWrappertransmitObjectrelations), required: false);
            var __workflow_searchLeadsWrappertransmitObjectitemGUID = searchLeadsWrappertransmitObjectitemGUID == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectitemGUID);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectitemGUID, nameof(searchLeadsWrappertransmitObjectitemGUID), required: false);
            var __workflow_searchLeadsWrappertransmitObjectitemVersion = searchLeadsWrappertransmitObjectitemVersion == null ? null : WorkflowExpression.Compile(searchLeadsWrappertransmitObjectitemVersion);
            WorkflowExpression.Validate(__workflow_searchLeadsWrappertransmitObjectitemVersion, nameof(searchLeadsWrappertransmitObjectitemVersion), required: false);
            var __workflow_searchLeadsWrapperincludeRelations = searchLeadsWrapperincludeRelations == null ? null : WorkflowExpression.Compile(searchLeadsWrapperincludeRelations);
            WorkflowExpression.Validate(__workflow_searchLeadsWrapperincludeRelations, nameof(searchLeadsWrapperincludeRelations), required: false);
            var __workflow_searchLeadsWrapperrelationsFilterrelationType = searchLeadsWrapperrelationsFilterrelationType == null ? null : WorkflowExpression.Compile(searchLeadsWrapperrelationsFilterrelationType);
            WorkflowExpression.Validate(__workflow_searchLeadsWrapperrelationsFilterrelationType, nameof(searchLeadsWrapperrelationsFilterrelationType), required: false);
            var __workflow_searchLeadsWrapperrelationsFilterforeignFolderName = searchLeadsWrapperrelationsFilterforeignFolderName == null ? null : WorkflowExpression.Compile(searchLeadsWrapperrelationsFilterforeignFolderName);
            WorkflowExpression.Validate(__workflow_searchLeadsWrapperrelationsFilterforeignFolderName, nameof(searchLeadsWrapperrelationsFilterforeignFolderName), required: false);
            var __workflow_searchLeadsWrapperbinaryLogicalOperator = searchLeadsWrapperbinaryLogicalOperator == null ? null : WorkflowExpression.Compile(searchLeadsWrapperbinaryLogicalOperator);
            WorkflowExpression.Validate(__workflow_searchLeadsWrapperbinaryLogicalOperator, nameof(searchLeadsWrapperbinaryLogicalOperator), required: false);
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
            var __workflow_searchProjectsWrappertransmitObjectcompaniesCustomerGuid = searchProjectsWrappertransmitObjectcompaniesCustomerGuid == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectcompaniesCustomerGuid);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectcompaniesCustomerGuid, nameof(searchProjectsWrappertransmitObjectcompaniesCustomerGuid), required: false);
            var __workflow_searchProjectsWrappertransmitObjectcontactsContactPersonGuid = searchProjectsWrappertransmitObjectcontactsContactPersonGuid == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectcontactsContactPersonGuid);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectcontactsContactPersonGuid, nameof(searchProjectsWrappertransmitObjectcontactsContactPersonGuid), required: false);
            var __workflow_searchProjectsWrappertransmitObjectleadsProjectOriginGuid = searchProjectsWrappertransmitObjectleadsProjectOriginGuid == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectleadsProjectOriginGuid);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectleadsProjectOriginGuid, nameof(searchProjectsWrappertransmitObjectleadsProjectOriginGuid), required: false);
            var __workflow_searchProjectsWrappertransmitObjectprojectsSuperiorProjectGuid = searchProjectsWrappertransmitObjectprojectsSuperiorProjectGuid == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectprojectsSuperiorProjectGuid);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectprojectsSuperiorProjectGuid, nameof(searchProjectsWrappertransmitObjectprojectsSuperiorProjectGuid), required: false);
            var __workflow_searchProjectsWrappertransmitObjectusersSupervisorGuid = searchProjectsWrappertransmitObjectusersSupervisorGuid == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectusersSupervisorGuid);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectusersSupervisorGuid, nameof(searchProjectsWrappertransmitObjectusersSupervisorGuid), required: false);
            var __workflow_searchProjectsWrappertransmitObjectnote = searchProjectsWrappertransmitObjectnote == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectnote);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectnote, nameof(searchProjectsWrappertransmitObjectnote), required: false);
            var __workflow_searchProjectsWrappertransmitObjectprice = searchProjectsWrappertransmitObjectprice == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectprice);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectprice, nameof(searchProjectsWrappertransmitObjectprice), required: false);
            var __workflow_searchProjectsWrappertransmitObjectprojectEnd = searchProjectsWrappertransmitObjectprojectEnd == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectprojectEnd);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectprojectEnd, nameof(searchProjectsWrappertransmitObjectprojectEnd), required: false);
            var __workflow_searchProjectsWrappertransmitObjectprojectName = searchProjectsWrappertransmitObjectprojectName == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectprojectName);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectprojectName, nameof(searchProjectsWrappertransmitObjectprojectName), required: false);
            var __workflow_searchProjectsWrappertransmitObjecttypeEn = searchProjectsWrappertransmitObjecttypeEn == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjecttypeEn);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjecttypeEn, nameof(searchProjectsWrappertransmitObjecttypeEn), required: false);
            var __workflow_searchProjectsWrappertransmitObjectstateEn = searchProjectsWrappertransmitObjectstateEn == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectstateEn);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectstateEn, nameof(searchProjectsWrappertransmitObjectstateEn), required: false);
            var __workflow_searchProjectsWrappertransmitObjectpeopleExpenses = searchProjectsWrappertransmitObjectpeopleExpenses == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectpeopleExpenses);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectpeopleExpenses, nameof(searchProjectsWrappertransmitObjectpeopleExpenses), required: false);
            var __workflow_searchProjectsWrappertransmitObjectprojectRealEnd = searchProjectsWrappertransmitObjectprojectRealEnd == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectprojectRealEnd);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectprojectRealEnd, nameof(searchProjectsWrappertransmitObjectprojectRealEnd), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedPrice = searchProjectsWrappertransmitObjectestimatedPrice == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedPrice);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectestimatedPrice, nameof(searchProjectsWrappertransmitObjectestimatedPrice), required: false);
            var __workflow_searchProjectsWrappertransmitObjecthID = searchProjectsWrappertransmitObjecthID == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjecthID);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjecthID, nameof(searchProjectsWrappertransmitObjecthID), required: false);
            var __workflow_searchProjectsWrappertransmitObjectprojectOriginEn = searchProjectsWrappertransmitObjectprojectOriginEn == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectprojectOriginEn);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectprojectOriginEn, nameof(searchProjectsWrappertransmitObjectprojectOriginEn), required: false);
            var __workflow_searchProjectsWrappertransmitObjectpaymentTypeEn = searchProjectsWrappertransmitObjectpaymentTypeEn == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectpaymentTypeEn);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectpaymentTypeEn, nameof(searchProjectsWrappertransmitObjectpaymentTypeEn), required: false);
            var __workflow_searchProjectsWrappertransmitObjectotherExpenses = searchProjectsWrappertransmitObjectotherExpenses == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectotherExpenses);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectotherExpenses, nameof(searchProjectsWrappertransmitObjectotherExpenses), required: false);
            var __workflow_searchProjectsWrappertransmitObjectmargin = searchProjectsWrappertransmitObjectmargin == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectmargin);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectmargin, nameof(searchProjectsWrappertransmitObjectmargin), required: false);
            var __workflow_searchProjectsWrappertransmitObjectprofit = searchProjectsWrappertransmitObjectprofit == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectprofit);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectprofit, nameof(searchProjectsWrappertransmitObjectprofit), required: false);
            var __workflow_searchProjectsWrappertransmitObjectpaymentMaturity = searchProjectsWrappertransmitObjectpaymentMaturity == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectpaymentMaturity);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectpaymentMaturity, nameof(searchProjectsWrappertransmitObjectpaymentMaturity), required: false);
            var __workflow_searchProjectsWrappertransmitObjectinvoicePaymentDate = searchProjectsWrappertransmitObjectinvoicePaymentDate == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectinvoicePaymentDate);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectinvoicePaymentDate, nameof(searchProjectsWrappertransmitObjectinvoicePaymentDate), required: false);
            var __workflow_searchProjectsWrappertransmitObjectinvoiceIssueDate = searchProjectsWrappertransmitObjectinvoiceIssueDate == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectinvoiceIssueDate);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectinvoiceIssueDate, nameof(searchProjectsWrappertransmitObjectinvoiceIssueDate), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedMargin = searchProjectsWrappertransmitObjectestimatedMargin == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedMargin);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectestimatedMargin, nameof(searchProjectsWrappertransmitObjectestimatedMargin), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedProfit = searchProjectsWrappertransmitObjectestimatedProfit == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedProfit);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectestimatedProfit, nameof(searchProjectsWrappertransmitObjectestimatedProfit), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedPeopleExpenses = searchProjectsWrappertransmitObjectestimatedPeopleExpenses == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedPeopleExpenses);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectestimatedPeopleExpenses, nameof(searchProjectsWrappertransmitObjectestimatedPeopleExpenses), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedOtherExpenses = searchProjectsWrappertransmitObjectestimatedOtherExpenses == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedOtherExpenses);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectestimatedOtherExpenses, nameof(searchProjectsWrappertransmitObjectestimatedOtherExpenses), required: false);
            var __workflow_searchProjectsWrappertransmitObjectlicensesCount = searchProjectsWrappertransmitObjectlicensesCount == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectlicensesCount);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectlicensesCount, nameof(searchProjectsWrappertransmitObjectlicensesCount), required: false);
            var __workflow_searchProjectsWrappertransmitObjectlicensePrice = searchProjectsWrappertransmitObjectlicensePrice == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectlicensePrice);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectlicensePrice, nameof(searchProjectsWrappertransmitObjectlicensePrice), required: false);
            var __workflow_searchProjectsWrappertransmitObjectprevStateEn = searchProjectsWrappertransmitObjectprevStateEn == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectprevStateEn);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectprevStateEn, nameof(searchProjectsWrappertransmitObjectprevStateEn), required: false);
            var __workflow_searchProjectsWrappertransmitObjectshowInCaplan = searchProjectsWrappertransmitObjectshowInCaplan == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectshowInCaplan);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectshowInCaplan, nameof(searchProjectsWrappertransmitObjectshowInCaplan), required: false);
            var __workflow_searchProjectsWrappertransmitObjectprojectStart = searchProjectsWrappertransmitObjectprojectStart == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectprojectStart);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectprojectStart, nameof(searchProjectsWrappertransmitObjectprojectStart), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedWorkHours = searchProjectsWrappertransmitObjectestimatedWorkHours == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedWorkHours);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectestimatedWorkHours, nameof(searchProjectsWrappertransmitObjectestimatedWorkHours), required: false);
            var __workflow_searchProjectsWrappertransmitObjecttotalWorkHours = searchProjectsWrappertransmitObjecttotalWorkHours == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjecttotalWorkHours);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjecttotalWorkHours, nameof(searchProjectsWrappertransmitObjecttotalWorkHours), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency = searchProjectsWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency, nameof(searchProjectsWrappertransmitObjectestimatedPeopleExpensesDefaultCurrency), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedOtherExpensesDefaultCurrency = searchProjectsWrappertransmitObjectestimatedOtherExpensesDefaultCurrency == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedOtherExpensesDefaultCurrency);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectestimatedOtherExpensesDefaultCurrency, nameof(searchProjectsWrappertransmitObjectestimatedOtherExpensesDefaultCurrency), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedPriceDefaultCurrency = searchProjectsWrappertransmitObjectestimatedPriceDefaultCurrency == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedPriceDefaultCurrency);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectestimatedPriceDefaultCurrency, nameof(searchProjectsWrappertransmitObjectestimatedPriceDefaultCurrency), required: false);
            var __workflow_searchProjectsWrappertransmitObjectpeopleExpensesDefaultCurrency = searchProjectsWrappertransmitObjectpeopleExpensesDefaultCurrency == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectpeopleExpensesDefaultCurrency);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectpeopleExpensesDefaultCurrency, nameof(searchProjectsWrappertransmitObjectpeopleExpensesDefaultCurrency), required: false);
            var __workflow_searchProjectsWrappertransmitObjectotherExpensesDefaultCurrency = searchProjectsWrappertransmitObjectotherExpensesDefaultCurrency == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectotherExpensesDefaultCurrency);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectotherExpensesDefaultCurrency, nameof(searchProjectsWrappertransmitObjectotherExpensesDefaultCurrency), required: false);
            var __workflow_searchProjectsWrappertransmitObjectpriceDefaultCurrency = searchProjectsWrappertransmitObjectpriceDefaultCurrency == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectpriceDefaultCurrency);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectpriceDefaultCurrency, nameof(searchProjectsWrappertransmitObjectpriceDefaultCurrency), required: false);
            var __workflow_searchProjectsWrappertransmitObjectprofitDefaultCurrency = searchProjectsWrappertransmitObjectprofitDefaultCurrency == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectprofitDefaultCurrency);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectprofitDefaultCurrency, nameof(searchProjectsWrappertransmitObjectprofitDefaultCurrency), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedProfitDefaultCurrency = searchProjectsWrappertransmitObjectestimatedProfitDefaultCurrency == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedProfitDefaultCurrency);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectestimatedProfitDefaultCurrency, nameof(searchProjectsWrappertransmitObjectestimatedProfitDefaultCurrency), required: false);
            var __workflow_searchProjectsWrappertransmitObjectcurrencyEn = searchProjectsWrappertransmitObjectcurrencyEn == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectcurrencyEn);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectcurrencyEn, nameof(searchProjectsWrappertransmitObjectcurrencyEn), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedPeopleExpensesChanged = searchProjectsWrappertransmitObjectestimatedPeopleExpensesChanged == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedPeopleExpensesChanged);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectestimatedPeopleExpensesChanged, nameof(searchProjectsWrappertransmitObjectestimatedPeopleExpensesChanged), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedOtherExpensesChanged = searchProjectsWrappertransmitObjectestimatedOtherExpensesChanged == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedOtherExpensesChanged);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectestimatedOtherExpensesChanged, nameof(searchProjectsWrappertransmitObjectestimatedOtherExpensesChanged), required: false);
            var __workflow_searchProjectsWrappertransmitObjectotherExpensesChanged = searchProjectsWrappertransmitObjectotherExpensesChanged == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectotherExpensesChanged);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectotherExpensesChanged, nameof(searchProjectsWrappertransmitObjectotherExpensesChanged), required: false);
            var __workflow_searchProjectsWrappertransmitObjectestimatedPriceChanged = searchProjectsWrappertransmitObjectestimatedPriceChanged == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectestimatedPriceChanged);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectestimatedPriceChanged, nameof(searchProjectsWrappertransmitObjectestimatedPriceChanged), required: false);
            var __workflow_searchProjectsWrappertransmitObjectpriceChanged = searchProjectsWrappertransmitObjectpriceChanged == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectpriceChanged);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectpriceChanged, nameof(searchProjectsWrappertransmitObjectpriceChanged), required: false);
            var __workflow_searchProjectsWrappertransmitObjectlicensePriceChanged = searchProjectsWrappertransmitObjectlicensePriceChanged == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectlicensePriceChanged);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectlicensePriceChanged, nameof(searchProjectsWrappertransmitObjectlicensePriceChanged), required: false);
            var __workflow_searchProjectsWrappertransmitObjectlicensePriceDefaultCurrency = searchProjectsWrappertransmitObjectlicensePriceDefaultCurrency == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectlicensePriceDefaultCurrency);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectlicensePriceDefaultCurrency, nameof(searchProjectsWrappertransmitObjectlicensePriceDefaultCurrency), required: false);
            var __workflow_searchProjectsWrappertransmitObjectlastActivity = searchProjectsWrappertransmitObjectlastActivity == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectlastActivity);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectlastActivity, nameof(searchProjectsWrappertransmitObjectlastActivity), required: false);
            var __workflow_searchProjectsWrappertransmitObjectnextStep = searchProjectsWrappertransmitObjectnextStep == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectnextStep);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectnextStep, nameof(searchProjectsWrappertransmitObjectnextStep), required: false);
            var __workflow_searchProjectsWrappertransmitObjectcompletedDate = searchProjectsWrappertransmitObjectcompletedDate == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectcompletedDate);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectcompletedDate, nameof(searchProjectsWrappertransmitObjectcompletedDate), required: false);
            var __workflow_searchProjectsWrappertransmitObjectisCompleted = searchProjectsWrappertransmitObjectisCompleted == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectisCompleted);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectisCompleted, nameof(searchProjectsWrappertransmitObjectisCompleted), required: false);
            var __workflow_searchProjectsWrappertransmitObjectlostDate = searchProjectsWrappertransmitObjectlostDate == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectlostDate);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectlostDate, nameof(searchProjectsWrappertransmitObjectlostDate), required: false);
            var __workflow_searchProjectsWrappertransmitObjectisLost = searchProjectsWrappertransmitObjectisLost == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectisLost);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectisLost, nameof(searchProjectsWrappertransmitObjectisLost), required: false);
            var __workflow_searchProjectsWrappertransmitObjectpeopleExpensesChanged = searchProjectsWrappertransmitObjectpeopleExpensesChanged == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectpeopleExpensesChanged);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectpeopleExpensesChanged, nameof(searchProjectsWrappertransmitObjectpeopleExpensesChanged), required: false);
            var __workflow_searchProjectsWrappertransmitObjectpicture = searchProjectsWrappertransmitObjectpicture == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectpicture);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectpicture, nameof(searchProjectsWrappertransmitObjectpicture), required: false);
            var __workflow_searchProjectsWrappertransmitObjectpictureWidth = searchProjectsWrappertransmitObjectpictureWidth == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectpictureWidth);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectpictureWidth, nameof(searchProjectsWrappertransmitObjectpictureWidth), required: false);
            var __workflow_searchProjectsWrappertransmitObjectpictureHeight = searchProjectsWrappertransmitObjectpictureHeight == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectpictureHeight);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectpictureHeight, nameof(searchProjectsWrappertransmitObjectpictureHeight), required: false);
            var __workflow_searchProjectsWrappertransmitObjectisPrivate = searchProjectsWrappertransmitObjectisPrivate == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectisPrivate);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectisPrivate, nameof(searchProjectsWrappertransmitObjectisPrivate), required: false);
            var __workflow_searchProjectsWrappertransmitObjectserverItemCreated = searchProjectsWrappertransmitObjectserverItemCreated == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectserverItemCreated);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectserverItemCreated, nameof(searchProjectsWrappertransmitObjectserverItemCreated), required: false);
            var __workflow_searchProjectsWrappertransmitObjectserverItemChanged = searchProjectsWrappertransmitObjectserverItemChanged == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectserverItemChanged);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectserverItemChanged, nameof(searchProjectsWrappertransmitObjectserverItemChanged), required: false);
            var __workflow_searchProjectsWrappertransmitObjectitemCreated = searchProjectsWrappertransmitObjectitemCreated == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectitemCreated);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectitemCreated, nameof(searchProjectsWrappertransmitObjectitemCreated), required: false);
            var __workflow_searchProjectsWrappertransmitObjectitemChanged = searchProjectsWrappertransmitObjectitemChanged == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectitemChanged);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectitemChanged, nameof(searchProjectsWrappertransmitObjectitemChanged), required: false);
            var __workflow_searchProjectsWrappertransmitObjectfileAs = searchProjectsWrappertransmitObjectfileAs == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectfileAs);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectfileAs, nameof(searchProjectsWrappertransmitObjectfileAs), required: false);
            var __workflow_searchProjectsWrappertransmitObjectownerGUID = searchProjectsWrappertransmitObjectownerGUID == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectownerGUID);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectownerGUID, nameof(searchProjectsWrappertransmitObjectownerGUID), required: false);
            var __workflow_searchProjectsWrappertransmitObjectcreatedByGUID = searchProjectsWrappertransmitObjectcreatedByGUID == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectcreatedByGUID);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectcreatedByGUID, nameof(searchProjectsWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_searchProjectsWrappertransmitObjectmodifiedByGUID = searchProjectsWrappertransmitObjectmodifiedByGUID == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectmodifiedByGUID);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectmodifiedByGUID, nameof(searchProjectsWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_searchProjectsWrappertransmitObjectadditionalFields = searchProjectsWrappertransmitObjectadditionalFields == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectadditionalFields);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectadditionalFields, nameof(searchProjectsWrappertransmitObjectadditionalFields), required: false);
            var __workflow_searchProjectsWrappertransmitObjectrelations = searchProjectsWrappertransmitObjectrelations == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectrelations);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectrelations, nameof(searchProjectsWrappertransmitObjectrelations), required: false);
            var __workflow_searchProjectsWrappertransmitObjectitemGUID = searchProjectsWrappertransmitObjectitemGUID == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectitemGUID);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectitemGUID, nameof(searchProjectsWrappertransmitObjectitemGUID), required: false);
            var __workflow_searchProjectsWrappertransmitObjectitemVersion = searchProjectsWrappertransmitObjectitemVersion == null ? null : WorkflowExpression.Compile(searchProjectsWrappertransmitObjectitemVersion);
            WorkflowExpression.Validate(__workflow_searchProjectsWrappertransmitObjectitemVersion, nameof(searchProjectsWrappertransmitObjectitemVersion), required: false);
            var __workflow_searchProjectsWrapperincludeRelations = searchProjectsWrapperincludeRelations == null ? null : WorkflowExpression.Compile(searchProjectsWrapperincludeRelations);
            WorkflowExpression.Validate(__workflow_searchProjectsWrapperincludeRelations, nameof(searchProjectsWrapperincludeRelations), required: false);
            var __workflow_searchProjectsWrapperrelationsFilterrelationType = searchProjectsWrapperrelationsFilterrelationType == null ? null : WorkflowExpression.Compile(searchProjectsWrapperrelationsFilterrelationType);
            WorkflowExpression.Validate(__workflow_searchProjectsWrapperrelationsFilterrelationType, nameof(searchProjectsWrapperrelationsFilterrelationType), required: false);
            var __workflow_searchProjectsWrapperrelationsFilterforeignFolderName = searchProjectsWrapperrelationsFilterforeignFolderName == null ? null : WorkflowExpression.Compile(searchProjectsWrapperrelationsFilterforeignFolderName);
            WorkflowExpression.Validate(__workflow_searchProjectsWrapperrelationsFilterforeignFolderName, nameof(searchProjectsWrapperrelationsFilterforeignFolderName), required: false);
            var __workflow_searchProjectsWrapperbinaryLogicalOperator = searchProjectsWrapperbinaryLogicalOperator == null ? null : WorkflowExpression.Compile(searchProjectsWrapperbinaryLogicalOperator);
            WorkflowExpression.Validate(__workflow_searchProjectsWrapperbinaryLogicalOperator, nameof(searchProjectsWrapperbinaryLogicalOperator), required: false);
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
            var __workflow_searchTasksWrappertransmitObjectleadsTopLevelProjectGuid = searchTasksWrappertransmitObjectleadsTopLevelProjectGuid == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectleadsTopLevelProjectGuid);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectleadsTopLevelProjectGuid, nameof(searchTasksWrappertransmitObjectleadsTopLevelProjectGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjectleadsTaskParentGuid = searchTasksWrappertransmitObjectleadsTaskParentGuid == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectleadsTaskParentGuid);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectleadsTaskParentGuid, nameof(searchTasksWrappertransmitObjectleadsTaskParentGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjectprojectsTopLevelProjectGuid = searchTasksWrappertransmitObjectprojectsTopLevelProjectGuid == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectprojectsTopLevelProjectGuid);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectprojectsTopLevelProjectGuid, nameof(searchTasksWrappertransmitObjectprojectsTopLevelProjectGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjectprojectsTaskParentGuid = searchTasksWrappertransmitObjectprojectsTaskParentGuid == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectprojectsTaskParentGuid);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectprojectsTaskParentGuid, nameof(searchTasksWrappertransmitObjectprojectsTaskParentGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjecttasksTaskParentGuid = searchTasksWrappertransmitObjecttasksTaskParentGuid == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjecttasksTaskParentGuid);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjecttasksTaskParentGuid, nameof(searchTasksWrappertransmitObjecttasksTaskParentGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjectmarketingTopLevelProjectGuid = searchTasksWrappertransmitObjectmarketingTopLevelProjectGuid == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectmarketingTopLevelProjectGuid);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectmarketingTopLevelProjectGuid, nameof(searchTasksWrappertransmitObjectmarketingTopLevelProjectGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjectmarketingTaskParentGuid = searchTasksWrappertransmitObjectmarketingTaskParentGuid == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectmarketingTaskParentGuid);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectmarketingTaskParentGuid, nameof(searchTasksWrappertransmitObjectmarketingTaskParentGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjectcompaniesCompanyGuid = searchTasksWrappertransmitObjectcompaniesCompanyGuid == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectcompaniesCompanyGuid);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectcompaniesCompanyGuid, nameof(searchTasksWrappertransmitObjectcompaniesCompanyGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjectcontactsContactGuid = searchTasksWrappertransmitObjectcontactsContactGuid == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectcontactsContactGuid);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectcontactsContactGuid, nameof(searchTasksWrappertransmitObjectcontactsContactGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjectusersTaskDelegatorGuid = searchTasksWrappertransmitObjectusersTaskDelegatorGuid == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectusersTaskDelegatorGuid);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectusersTaskDelegatorGuid, nameof(searchTasksWrappertransmitObjectusersTaskDelegatorGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjectusersTaskSolverGuid = searchTasksWrappertransmitObjectusersTaskSolverGuid == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectusersTaskSolverGuid);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectusersTaskSolverGuid, nameof(searchTasksWrappertransmitObjectusersTaskSolverGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjecttasksTaskOriginGuid = searchTasksWrappertransmitObjecttasksTaskOriginGuid == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjecttasksTaskOriginGuid);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjecttasksTaskOriginGuid, nameof(searchTasksWrappertransmitObjecttasksTaskOriginGuid), required: false);
            var __workflow_searchTasksWrappertransmitObjectbody = searchTasksWrappertransmitObjectbody == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectbody);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectbody, nameof(searchTasksWrappertransmitObjectbody), required: false);
            var __workflow_searchTasksWrappertransmitObjectisCompleted = searchTasksWrappertransmitObjectisCompleted == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectisCompleted);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectisCompleted, nameof(searchTasksWrappertransmitObjectisCompleted), required: false);
            var __workflow_searchTasksWrappertransmitObjectdueDate = searchTasksWrappertransmitObjectdueDate == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectdueDate);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectdueDate, nameof(searchTasksWrappertransmitObjectdueDate), required: false);
            var __workflow_searchTasksWrappertransmitObjectpercentCompleteDecimal = searchTasksWrappertransmitObjectpercentCompleteDecimal == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectpercentCompleteDecimal);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectpercentCompleteDecimal, nameof(searchTasksWrappertransmitObjectpercentCompleteDecimal), required: false);
            var __workflow_searchTasksWrappertransmitObjectprevStateEn = searchTasksWrappertransmitObjectprevStateEn == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectprevStateEn);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectprevStateEn, nameof(searchTasksWrappertransmitObjectprevStateEn), required: false);
            var __workflow_searchTasksWrappertransmitObjectstartDate = searchTasksWrappertransmitObjectstartDate == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectstartDate);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectstartDate, nameof(searchTasksWrappertransmitObjectstartDate), required: false);
            var __workflow_searchTasksWrappertransmitObjectstateEn = searchTasksWrappertransmitObjectstateEn == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectstateEn);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectstateEn, nameof(searchTasksWrappertransmitObjectstateEn), required: false);
            var __workflow_searchTasksWrappertransmitObjectsubject = searchTasksWrappertransmitObjectsubject == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectsubject);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectsubject, nameof(searchTasksWrappertransmitObjectsubject), required: false);
            var __workflow_searchTasksWrappertransmitObjecttypeEn = searchTasksWrappertransmitObjecttypeEn == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjecttypeEn);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjecttypeEn, nameof(searchTasksWrappertransmitObjecttypeEn), required: false);
            var __workflow_searchTasksWrappertransmitObjectlevel = searchTasksWrappertransmitObjectlevel == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectlevel);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectlevel, nameof(searchTasksWrappertransmitObjectlevel), required: false);
            var __workflow_searchTasksWrappertransmitObjectimportanceEn = searchTasksWrappertransmitObjectimportanceEn == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectimportanceEn);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectimportanceEn, nameof(searchTasksWrappertransmitObjectimportanceEn), required: false);
            var __workflow_searchTasksWrappertransmitObjectactualWorkHours = searchTasksWrappertransmitObjectactualWorkHours == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectactualWorkHours);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectactualWorkHours, nameof(searchTasksWrappertransmitObjectactualWorkHours), required: false);
            var __workflow_searchTasksWrappertransmitObjectestimatedWorkHours = searchTasksWrappertransmitObjectestimatedWorkHours == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectestimatedWorkHours);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectestimatedWorkHours, nameof(searchTasksWrappertransmitObjectestimatedWorkHours), required: false);
            var __workflow_searchTasksWrappertransmitObjectisReminderSet = searchTasksWrappertransmitObjectisReminderSet == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectisReminderSet);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectisReminderSet, nameof(searchTasksWrappertransmitObjectisReminderSet), required: false);
            var __workflow_searchTasksWrappertransmitObjectreminderDate = searchTasksWrappertransmitObjectreminderDate == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectreminderDate);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectreminderDate, nameof(searchTasksWrappertransmitObjectreminderDate), required: false);
            var __workflow_searchTasksWrappertransmitObjectcompletedDate = searchTasksWrappertransmitObjectcompletedDate == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectcompletedDate);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectcompletedDate, nameof(searchTasksWrappertransmitObjectcompletedDate), required: false);
            var __workflow_searchTasksWrappertransmitObjectpicture = searchTasksWrappertransmitObjectpicture == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectpicture);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectpicture, nameof(searchTasksWrappertransmitObjectpicture), required: false);
            var __workflow_searchTasksWrappertransmitObjectpictureWidth = searchTasksWrappertransmitObjectpictureWidth == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectpictureWidth);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectpictureWidth, nameof(searchTasksWrappertransmitObjectpictureWidth), required: false);
            var __workflow_searchTasksWrappertransmitObjectpictureHeight = searchTasksWrappertransmitObjectpictureHeight == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectpictureHeight);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectpictureHeight, nameof(searchTasksWrappertransmitObjectpictureHeight), required: false);
            var __workflow_searchTasksWrappertransmitObjectisPrivate = searchTasksWrappertransmitObjectisPrivate == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectisPrivate);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectisPrivate, nameof(searchTasksWrappertransmitObjectisPrivate), required: false);
            var __workflow_searchTasksWrappertransmitObjectserverItemCreated = searchTasksWrappertransmitObjectserverItemCreated == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectserverItemCreated);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectserverItemCreated, nameof(searchTasksWrappertransmitObjectserverItemCreated), required: false);
            var __workflow_searchTasksWrappertransmitObjectserverItemChanged = searchTasksWrappertransmitObjectserverItemChanged == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectserverItemChanged);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectserverItemChanged, nameof(searchTasksWrappertransmitObjectserverItemChanged), required: false);
            var __workflow_searchTasksWrappertransmitObjectitemCreated = searchTasksWrappertransmitObjectitemCreated == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectitemCreated);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectitemCreated, nameof(searchTasksWrappertransmitObjectitemCreated), required: false);
            var __workflow_searchTasksWrappertransmitObjectitemChanged = searchTasksWrappertransmitObjectitemChanged == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectitemChanged);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectitemChanged, nameof(searchTasksWrappertransmitObjectitemChanged), required: false);
            var __workflow_searchTasksWrappertransmitObjectfileAs = searchTasksWrappertransmitObjectfileAs == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectfileAs);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectfileAs, nameof(searchTasksWrappertransmitObjectfileAs), required: false);
            var __workflow_searchTasksWrappertransmitObjectownerGUID = searchTasksWrappertransmitObjectownerGUID == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectownerGUID);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectownerGUID, nameof(searchTasksWrappertransmitObjectownerGUID), required: false);
            var __workflow_searchTasksWrappertransmitObjectcreatedByGUID = searchTasksWrappertransmitObjectcreatedByGUID == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectcreatedByGUID);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectcreatedByGUID, nameof(searchTasksWrappertransmitObjectcreatedByGUID), required: false);
            var __workflow_searchTasksWrappertransmitObjectmodifiedByGUID = searchTasksWrappertransmitObjectmodifiedByGUID == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectmodifiedByGUID);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectmodifiedByGUID, nameof(searchTasksWrappertransmitObjectmodifiedByGUID), required: false);
            var __workflow_searchTasksWrappertransmitObjectadditionalFields = searchTasksWrappertransmitObjectadditionalFields == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectadditionalFields);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectadditionalFields, nameof(searchTasksWrappertransmitObjectadditionalFields), required: false);
            var __workflow_searchTasksWrappertransmitObjectrelations = searchTasksWrappertransmitObjectrelations == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectrelations);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectrelations, nameof(searchTasksWrappertransmitObjectrelations), required: false);
            var __workflow_searchTasksWrappertransmitObjectitemGUID = searchTasksWrappertransmitObjectitemGUID == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectitemGUID);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectitemGUID, nameof(searchTasksWrappertransmitObjectitemGUID), required: false);
            var __workflow_searchTasksWrappertransmitObjectitemVersion = searchTasksWrappertransmitObjectitemVersion == null ? null : WorkflowExpression.Compile(searchTasksWrappertransmitObjectitemVersion);
            WorkflowExpression.Validate(__workflow_searchTasksWrappertransmitObjectitemVersion, nameof(searchTasksWrappertransmitObjectitemVersion), required: false);
            var __workflow_searchTasksWrapperincludeRelations = searchTasksWrapperincludeRelations == null ? null : WorkflowExpression.Compile(searchTasksWrapperincludeRelations);
            WorkflowExpression.Validate(__workflow_searchTasksWrapperincludeRelations, nameof(searchTasksWrapperincludeRelations), required: false);
            var __workflow_searchTasksWrapperrelationsFilterrelationType = searchTasksWrapperrelationsFilterrelationType == null ? null : WorkflowExpression.Compile(searchTasksWrapperrelationsFilterrelationType);
            WorkflowExpression.Validate(__workflow_searchTasksWrapperrelationsFilterrelationType, nameof(searchTasksWrapperrelationsFilterrelationType), required: false);
            var __workflow_searchTasksWrapperrelationsFilterforeignFolderName = searchTasksWrapperrelationsFilterforeignFolderName == null ? null : WorkflowExpression.Compile(searchTasksWrapperrelationsFilterforeignFolderName);
            WorkflowExpression.Validate(__workflow_searchTasksWrapperrelationsFilterforeignFolderName, nameof(searchTasksWrapperrelationsFilterforeignFolderName), required: false);
            var __workflow_searchTasksWrapperbinaryLogicalOperator = searchTasksWrapperbinaryLogicalOperator == null ? null : WorkflowExpression.Compile(searchTasksWrapperbinaryLogicalOperator);
            WorkflowExpression.Validate(__workflow_searchTasksWrapperbinaryLogicalOperator, nameof(searchTasksWrapperbinaryLogicalOperator), required: false);
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
            var __workflow_unlinkItemsWrapperitemGuid = unlinkItemsWrapperitemGuid == null ? null : WorkflowExpression.Compile(unlinkItemsWrapperitemGuid);
            WorkflowExpression.Validate(__workflow_unlinkItemsWrapperitemGuid, nameof(unlinkItemsWrapperitemGuid), required: false);
            var __workflow_unlinkItemsWrapperfolderName = unlinkItemsWrapperfolderName == null ? null : WorkflowExpression.Compile(unlinkItemsWrapperfolderName);
            WorkflowExpression.Validate(__workflow_unlinkItemsWrapperfolderName, nameof(unlinkItemsWrapperfolderName), required: false);
            var __workflow_unlinkItemsWrapperrelatedItemGuids = unlinkItemsWrapperrelatedItemGuids == null ? null : WorkflowExpression.Compile(unlinkItemsWrapperrelatedItemGuids);
            WorkflowExpression.Validate(__workflow_unlinkItemsWrapperrelatedItemGuids, nameof(unlinkItemsWrapperrelatedItemGuids), required: false);
            var __workflow_unlinkItemsWrapperrelatedFolderName = unlinkItemsWrapperrelatedFolderName == null ? null : WorkflowExpression.Compile(unlinkItemsWrapperrelatedFolderName);
            WorkflowExpression.Validate(__workflow_unlinkItemsWrapperrelatedFolderName, nameof(unlinkItemsWrapperrelatedFolderName), required: false);
            var __workflow_unlinkItemsWrapperskipUnlinkAvailabilityCheck = unlinkItemsWrapperskipUnlinkAvailabilityCheck == null ? null : WorkflowExpression.Compile(unlinkItemsWrapperskipUnlinkAvailabilityCheck);
            WorkflowExpression.Validate(__workflow_unlinkItemsWrapperskipUnlinkAvailabilityCheck, nameof(unlinkItemsWrapperskipUnlinkAvailabilityCheck), required: false);
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
