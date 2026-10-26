//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudcrmconstitu
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudcrmconstituActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentAddress, ApiConnectionActionConfiguration> CreateConstituentAddress(Expression<Func<CreateConstituentAddressInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConmgCreatedConstituentAddress, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-conmg/addresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConmgCreatedConstituentAddress>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteConstituentAddress(Expression<Func<string>> constituentAddressId)
        {
            var __workflow_constituentAddressId = WorkflowExpression.Compile(constituentAddressId, nameof(constituentAddressId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/addresses/{0}", __workflow_constituentAddressId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentAddress(Expression<Func<string>> constituentAddressId, Expression<Func<EditConstituentAddressInput>> body)
        {
            var __workflow_constituentAddressId = WorkflowExpression.Compile(constituentAddressId, nameof(constituentAddressId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/addresses/{0}", __workflow_constituentAddressId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentAlternateLookupId, ApiConnectionActionConfiguration> CreateConstituentAlternateLookupId(Expression<Func<CreateConstituentAlternateLookupIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConmgCreatedConstituentAlternateLookupId, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-conmg/alternatelookupids";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConmgCreatedConstituentAlternateLookupId>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteConstituentAlternateLookupId(Expression<Func<string>> alternateLookupId)
        {
            var __workflow_alternateLookupId = WorkflowExpression.Compile(alternateLookupId, nameof(alternateLookupId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/alternatelookupids/{0}", __workflow_alternateLookupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentAlternateLookupId(Expression<Func<string>> alternateLookupId, Expression<Func<EditConstituentAlternateLookupIdInput>> body)
        {
            var __workflow_alternateLookupId = WorkflowExpression.Compile(alternateLookupId, nameof(alternateLookupId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/alternatelookupids/{0}", __workflow_alternateLookupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentAppealResponse, ApiConnectionActionConfiguration> CreateConstituentAppealResponse(Expression<Func<CreateConstituentAppealResponseInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConmgCreatedConstituentAppealResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-conmg/constituentappealresponses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConmgCreatedConstituentAppealResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentAppeal, ApiConnectionActionConfiguration> CreateConstituentAppeal(Expression<Func<CreateConstituentAppealInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConmgCreatedConstituentAppeal, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-conmg/constituentappeals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConmgCreatedConstituentAppeal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteConstituentAppeal(Expression<Func<string>> constituentAppealId)
        {
            var __workflow_constituentAppealId = WorkflowExpression.Compile(constituentAppealId, nameof(constituentAppealId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituentappeals/{0}", __workflow_constituentAppealId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentAppeal(Expression<Func<string>> constituentAppealId, Expression<Func<EditConstituentAppealInput>> body)
        {
            var __workflow_constituentAppealId = WorkflowExpression.Compile(constituentAppealId, nameof(constituentAppealId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituentappeals/{0}", __workflow_constituentAppealId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgConstituentAppealCollection, ApiConnectionActionConfiguration> ListConstituentAppeals(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgConstituentAppealCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituentappeals/{0}/appeals", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgConstituentAppealCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteConstituentAttribute(Expression<Func<string>> constituentAttributeId)
        {
            var __workflow_constituentAttributeId = WorkflowExpression.Compile(constituentAttributeId, nameof(constituentAttributeId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituentattributes/{0}", __workflow_constituentAttributeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentCorrespondence, ApiConnectionActionConfiguration> CreateConstituentCorrespondence(Expression<Func<CreateConstituentCorrespondenceInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConmgCreatedConstituentCorrespondence, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-conmg/constituentcorrespondencecodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConmgCreatedConstituentCorrespondence>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteConstituentCorrespondence(Expression<Func<string>> constituentCorrespondenceId)
        {
            var __workflow_constituentCorrespondenceId = WorkflowExpression.Compile(constituentCorrespondenceId, nameof(constituentCorrespondenceId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituentcorrespondencecodes/{0}", __workflow_constituentCorrespondenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentCorrespondence(Expression<Func<string>> constituentCorrespondenceId, Expression<Func<EditConstituentCorrespondenceInput>> body)
        {
            var __workflow_constituentCorrespondenceId = WorkflowExpression.Compile(constituentCorrespondenceId, nameof(constituentCorrespondenceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituentcorrespondencecodes/{0}", __workflow_constituentCorrespondenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentNote, ApiConnectionActionConfiguration> CreateConstituentNote(Expression<Func<CreateConstituentNoteInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConmgCreatedConstituentNote, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-conmg/constituentnotes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConmgCreatedConstituentNote>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteConstituentNote(Expression<Func<string>> constituentNoteId)
        {
            var __workflow_constituentNoteId = WorkflowExpression.Compile(constituentNoteId, nameof(constituentNoteId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituentnotes/{0}", __workflow_constituentNoteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentNote(Expression<Func<string>> constituentNoteId, Expression<Func<EditConstituentNoteInput>> body)
        {
            var __workflow_constituentNoteId = WorkflowExpression.Compile(constituentNoteId, nameof(constituentNoteId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituentnotes/{0}", __workflow_constituentNoteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgConstituentSearchResultCollection, ApiConnectionActionConfiguration> SearchConstituent(Expression<Func<string>> keyName = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lookupId = null, Expression<Func<string>> emailAddress = null, Expression<Func<string>> phoneNumber = null, Expression<Func<string>> country = null, Expression<Func<string>> addressBlock = null, Expression<Func<string>> city = null, Expression<Func<string>> state = null, Expression<Func<string>> postCode = null, Expression<Func<int>> classof = null, Expression<Func<bool>> exactMatchOnly = null, Expression<Func<string>> middleName = null, Expression<Func<string>> constituency = null, Expression<Func<string>> sourcecode = null, Expression<Func<bool>> includeIndividuals = null, Expression<Func<bool>> includeOrganizations = null, Expression<Func<bool>> includeGroups = null, Expression<Func<bool>> excludeHouseholds = null, Expression<Func<bool>> checkNickname = null, Expression<Func<bool>> checkAliases = null, Expression<Func<bool>> checkAlternateLookupIds = null, Expression<Func<bool>> onlyPrimaryAddress = null, Expression<Func<bool>> includeDeceased = null, Expression<Func<bool>> includeInactive = null, Expression<Func<bool>> fuzzySearchOnName = null, Expression<Func<int>> limit = null)
        {
            var __workflow_keyName = WorkflowExpression.Compile(keyName, nameof(keyName), required: false);
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: false);
            var __workflow_lookupId = WorkflowExpression.Compile(lookupId, nameof(lookupId), required: false);
            var __workflow_emailAddress = WorkflowExpression.Compile(emailAddress, nameof(emailAddress), required: false);
            var __workflow_phoneNumber = WorkflowExpression.Compile(phoneNumber, nameof(phoneNumber), required: false);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: false);
            var __workflow_addressBlock = WorkflowExpression.Compile(addressBlock, nameof(addressBlock), required: false);
            var __workflow_city = WorkflowExpression.Compile(city, nameof(city), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            var __workflow_postCode = WorkflowExpression.Compile(postCode, nameof(postCode), required: false);
            var __workflow_classof = WorkflowExpression.Compile(classof, nameof(classof), required: false);
            var __workflow_exactMatchOnly = WorkflowExpression.Compile(exactMatchOnly, nameof(exactMatchOnly), required: false);
            var __workflow_middleName = WorkflowExpression.Compile(middleName, nameof(middleName), required: false);
            var __workflow_constituency = WorkflowExpression.Compile(constituency, nameof(constituency), required: false);
            var __workflow_sourcecode = WorkflowExpression.Compile(sourcecode, nameof(sourcecode), required: false);
            var __workflow_includeIndividuals = WorkflowExpression.Compile(includeIndividuals, nameof(includeIndividuals), required: false);
            var __workflow_includeOrganizations = WorkflowExpression.Compile(includeOrganizations, nameof(includeOrganizations), required: false);
            var __workflow_includeGroups = WorkflowExpression.Compile(includeGroups, nameof(includeGroups), required: false);
            var __workflow_excludeHouseholds = WorkflowExpression.Compile(excludeHouseholds, nameof(excludeHouseholds), required: false);
            var __workflow_checkNickname = WorkflowExpression.Compile(checkNickname, nameof(checkNickname), required: false);
            var __workflow_checkAliases = WorkflowExpression.Compile(checkAliases, nameof(checkAliases), required: false);
            var __workflow_checkAlternateLookupIds = WorkflowExpression.Compile(checkAlternateLookupIds, nameof(checkAlternateLookupIds), required: false);
            var __workflow_onlyPrimaryAddress = WorkflowExpression.Compile(onlyPrimaryAddress, nameof(onlyPrimaryAddress), required: false);
            var __workflow_includeDeceased = WorkflowExpression.Compile(includeDeceased, nameof(includeDeceased), required: false);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            var __workflow_fuzzySearchOnName = WorkflowExpression.Compile(fuzzySearchOnName, nameof(fuzzySearchOnName), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<ConmgConstituentSearchResultCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-conmg/constituents/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_keyName != null)
                    callPayload.Queries["key_name"] = ExpressionConverter.Convert(__workflow_keyName);
                if (__workflow_firstName != null)
                    callPayload.Queries["first_name"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_lookupId != null)
                    callPayload.Queries["lookup_id"] = ExpressionConverter.Convert(__workflow_lookupId);
                if (__workflow_emailAddress != null)
                    callPayload.Queries["email_address"] = ExpressionConverter.Convert(__workflow_emailAddress);
                if (__workflow_phoneNumber != null)
                    callPayload.Queries["phone_number"] = ExpressionConverter.Convert(__workflow_phoneNumber);
                if (__workflow_country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                if (__workflow_addressBlock != null)
                    callPayload.Queries["address_block"] = ExpressionConverter.Convert(__workflow_addressBlock);
                if (__workflow_city != null)
                    callPayload.Queries["city"] = ExpressionConverter.Convert(__workflow_city);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_postCode != null)
                    callPayload.Queries["post_code"] = ExpressionConverter.Convert(__workflow_postCode);
                if (__workflow_classof != null)
                    callPayload.Queries["classof"] = ExpressionConverter.Convert(__workflow_classof);
                if (__workflow_exactMatchOnly != null)
                    callPayload.Queries["exact_match_only"] = ExpressionConverter.Convert(__workflow_exactMatchOnly);
                if (__workflow_middleName != null)
                    callPayload.Queries["middle_name"] = ExpressionConverter.Convert(__workflow_middleName);
                if (__workflow_constituency != null)
                    callPayload.Queries["constituency"] = ExpressionConverter.Convert(__workflow_constituency);
                if (__workflow_sourcecode != null)
                    callPayload.Queries["sourcecode"] = ExpressionConverter.Convert(__workflow_sourcecode);
                if (__workflow_includeIndividuals != null)
                    callPayload.Queries["include_individuals"] = ExpressionConverter.Convert(__workflow_includeIndividuals);
                if (__workflow_includeOrganizations != null)
                    callPayload.Queries["include_organizations"] = ExpressionConverter.Convert(__workflow_includeOrganizations);
                if (__workflow_includeGroups != null)
                    callPayload.Queries["include_groups"] = ExpressionConverter.Convert(__workflow_includeGroups);
                if (__workflow_excludeHouseholds != null)
                    callPayload.Queries["exclude_households"] = ExpressionConverter.Convert(__workflow_excludeHouseholds);
                if (__workflow_checkNickname != null)
                    callPayload.Queries["check_nickname"] = ExpressionConverter.Convert(__workflow_checkNickname);
                if (__workflow_checkAliases != null)
                    callPayload.Queries["check_aliases"] = ExpressionConverter.Convert(__workflow_checkAliases);
                if (__workflow_checkAlternateLookupIds != null)
                    callPayload.Queries["check_alternate_lookup_ids"] = ExpressionConverter.Convert(__workflow_checkAlternateLookupIds);
                if (__workflow_onlyPrimaryAddress != null)
                    callPayload.Queries["only_primary_address"] = ExpressionConverter.Convert(__workflow_onlyPrimaryAddress);
                if (__workflow_includeDeceased != null)
                    callPayload.Queries["include_deceased"] = ExpressionConverter.Convert(__workflow_includeDeceased);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                if (__workflow_fuzzySearchOnName != null)
                    callPayload.Queries["fuzzy_search_on_name"] = ExpressionConverter.Convert(__workflow_fuzzySearchOnName);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<ConmgConstituentSearchResultCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteConstituent(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgAddressCollection, ApiConnectionActionConfiguration> ListConstituentAddresses(Expression<Func<string>> constituentId, Expression<Func<bool>> includeFormer = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeFormer = WorkflowExpression.Compile(includeFormer, nameof(includeFormer), required: false);
            return new DeferredBodyAction<ConmgAddressCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/addresses", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeFormer != null)
                    callPayload.Queries["include_former"] = ExpressionConverter.Convert(__workflow_includeFormer);
                return new ApiConnectionAction<ConmgAddressCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgAlternateLookupIdCollection, ApiConnectionActionConfiguration> ListConstituentAlternateLookupIDs(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgAlternateLookupIdCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/alternatelookupids", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgAlternateLookupIdCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgAttributeCollection, ApiConnectionActionConfiguration> ListConstituentAttributes(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgAttributeCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/constituentattributelist", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgAttributeCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgConstituentPrimaryContactInfo, ApiConnectionActionConfiguration> GetConstituentPrimaryContactInfo(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgConstituentPrimaryContactInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/contactview", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgConstituentPrimaryContactInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgEducationCollection, ApiConnectionActionConfiguration> ListConstituentEducations(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgEducationCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/educationalhistories", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgEducationCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgEmailAddressCollection, ApiConnectionActionConfiguration> ListConstituentEmailAddresses(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgEmailAddressCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/emailaddresses", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgEmailAddressCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgPhoneCollection, ApiConnectionActionConfiguration> ListConstituentPhones(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgPhoneCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/phones", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgPhoneCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgConstituentProfilePicture, ApiConnectionActionConfiguration> GetConstituentProfilePicture(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgConstituentProfilePicture, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/profilepicture", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgConstituentProfilePicture>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgEmploymentHistoryCollection, ApiConnectionActionConfiguration> ListConstituentEmploymentHistory(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            return new DeferredBodyAction<ConmgEmploymentHistoryCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/relationshipjobsinfo", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                return new ApiConnectionAction<ConmgEmploymentHistoryCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgSolicitCodeCollection, ApiConnectionActionConfiguration> ListConstituentSolicitCodes(Expression<Func<string>> constituentId, Expression<Func<bool>> showExpired = null, Expression<Func<dateRangeInput>> dateRange = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_showExpired = WorkflowExpression.Compile(showExpired, nameof(showExpired), required: false);
            var __workflow_dateRange = WorkflowExpression.Compile(dateRange, nameof(dateRange), required: false);
            return new DeferredBodyAction<ConmgSolicitCodeCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/solicitcodes", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_showExpired != null)
                    callPayload.Queries["show_expired"] = ExpressionConverter.Convert(__workflow_showExpired);
                if (__workflow_dateRange != null)
                    callPayload.Queries["date_range"] = ExpressionConverter.Convert(__workflow_dateRange);
                return new ApiConnectionAction<ConmgSolicitCodeCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgTributeCollection, ApiConnectionActionConfiguration> ListConstituentTributes(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgTributeCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/tributes", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgTributeCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgConstituentSummaryProfile, ApiConnectionActionConfiguration> GetConstituentSummaryProfile(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgConstituentSummaryProfile, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/view", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgConstituentSummaryProfile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentEducation, ApiConnectionActionConfiguration> CreateConstituentEducation(Expression<Func<CreateConstituentEducationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConmgCreatedConstituentEducation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-conmg/educationalhistories";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConmgCreatedConstituentEducation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteConstituentEducation(Expression<Func<string>> educationalHistoryId)
        {
            var __workflow_educationalHistoryId = WorkflowExpression.Compile(educationalHistoryId, nameof(educationalHistoryId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/educationalhistories/{0}", __workflow_educationalHistoryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentEducation(Expression<Func<string>> educationalHistoryId, Expression<Func<EditConstituentEducationInput>> body)
        {
            var __workflow_educationalHistoryId = WorkflowExpression.Compile(educationalHistoryId, nameof(educationalHistoryId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/educationalhistories/{0}", __workflow_educationalHistoryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentEmailAddress, ApiConnectionActionConfiguration> CreateConstituentEmailAddress(Expression<Func<CreateConstituentEmailAddressInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConmgCreatedConstituentEmailAddress, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-conmg/emailaddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConmgCreatedConstituentEmailAddress>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteConstituentEmailAddress(Expression<Func<string>> emailAddressId)
        {
            var __workflow_emailAddressId = WorkflowExpression.Compile(emailAddressId, nameof(emailAddressId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/emailaddresses/{0}", __workflow_emailAddressId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentEmailAddress(Expression<Func<string>> emailAddressId, Expression<Func<EditConstituentEmailAddressInput>> body)
        {
            var __workflow_emailAddressId = WorkflowExpression.Compile(emailAddressId, nameof(emailAddressId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/emailaddresses/{0}", __workflow_emailAddressId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedFundraiserConstituency, ApiConnectionActionConfiguration> CreateFundraiserConstituency(Expression<Func<CreateFundraiserConstituencyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConmgCreatedFundraiserConstituency, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-conmg/fundraisers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConmgCreatedFundraiserConstituency>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteFundraiserConstituency(Expression<Func<string>> fundraiserConstituencyId)
        {
            var __workflow_fundraiserConstituencyId = WorkflowExpression.Compile(fundraiserConstituencyId, nameof(fundraiserConstituencyId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/fundraisers/{0}", __workflow_fundraiserConstituencyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditFundraiserConstituency(Expression<Func<string>> fundraiserConstituencyId, Expression<Func<EditFundraiserConstituencyInput>> body)
        {
            var __workflow_fundraiserConstituencyId = WorkflowExpression.Compile(fundraiserConstituencyId, nameof(fundraiserConstituencyId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/fundraisers/{0}", __workflow_fundraiserConstituencyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedIndividualConstituent, ApiConnectionActionConfiguration> CreateIndividualConstituent(Expression<Func<CreateIndividualConstituentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConmgCreatedIndividualConstituent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-conmg/individuals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConmgCreatedIndividualConstituent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgIndividualConstituent, ApiConnectionActionConfiguration> GetIndividualConstituent(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgIndividualConstituent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/individuals/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgIndividualConstituent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditIndividualConstituent(Expression<Func<string>> constituentId, Expression<Func<EditIndividualConstituentInput>> body)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/individuals/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentInteraction, ApiConnectionActionConfiguration> CreateConstituentInteraction(Expression<Func<CreateConstituentInteractionInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConmgCreatedConstituentInteraction, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-conmg/interactions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConmgCreatedConstituentInteraction>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgConstituentInteraction, ApiConnectionActionConfiguration> GetConstituentInteraction(Expression<Func<string>> constituentInteractionId)
        {
            var __workflow_constituentInteractionId = WorkflowExpression.Compile(constituentInteractionId, nameof(constituentInteractionId), required: true);
            return new DeferredBodyAction<ConmgConstituentInteraction, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/interactions/{0}", __workflow_constituentInteractionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgConstituentInteraction>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteConstituentInteraction(Expression<Func<string>> constituentInteractionId)
        {
            var __workflow_constituentInteractionId = WorkflowExpression.Compile(constituentInteractionId, nameof(constituentInteractionId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/interactions/{0}", __workflow_constituentInteractionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentInteraction(Expression<Func<string>> constituentInteractionId, Expression<Func<EditConstituentInteractionInput>> body)
        {
            var __workflow_constituentInteractionId = WorkflowExpression.Compile(constituentInteractionId, nameof(constituentInteractionId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/interactions/{0}", __workflow_constituentInteractionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgMergedConstituent, ApiConnectionActionConfiguration> MergeTwoConstituents(Expression<Func<MergeTwoConstituentsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConmgMergedConstituent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-conmg/mergetwoconstituents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConmgMergedConstituent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedOrganizationConstituent, ApiConnectionActionConfiguration> CreateOrganizationConstituent(Expression<Func<CreateOrganizationConstituentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConmgCreatedOrganizationConstituent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-conmg/organizations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConmgCreatedOrganizationConstituent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgOrganizationConstituent, ApiConnectionActionConfiguration> GetOrganizationConstituent(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgOrganizationConstituent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/organizations/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgOrganizationConstituent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditOrganizationConstituent(Expression<Func<string>> constituentId, Expression<Func<EditOrganizationConstituentInput>> body)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/organizations/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentPhone, ApiConnectionActionConfiguration> CreateConstituentPhone(Expression<Func<CreateConstituentPhoneInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConmgCreatedConstituentPhone, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-conmg/phones";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConmgCreatedConstituentPhone>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteConstituentPhone(Expression<Func<string>> constituentPhoneId)
        {
            var __workflow_constituentPhoneId = WorkflowExpression.Compile(constituentPhoneId, nameof(constituentPhoneId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/phones/{0}", __workflow_constituentPhoneId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentPhone(Expression<Func<string>> constituentPhoneId, Expression<Func<EditConstituentPhoneInput>> body)
        {
            var __workflow_constituentPhoneId = WorkflowExpression.Compile(constituentPhoneId, nameof(constituentPhoneId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/phones/{0}", __workflow_constituentPhoneId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentEmploymentHistory, ApiConnectionActionConfiguration> CreateConstituentEmploymentHistory(Expression<Func<CreateConstituentEmploymentHistoryInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConmgCreatedConstituentEmploymentHistory, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-conmg/relationshipjobsinfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConmgCreatedConstituentEmploymentHistory>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteConstituentEmploymentHistory(Expression<Func<string>> relationshipJobInfoId)
        {
            var __workflow_relationshipJobInfoId = WorkflowExpression.Compile(relationshipJobInfoId, nameof(relationshipJobInfoId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/relationshipjobsinfo/{0}", __workflow_relationshipJobInfoId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentEmploymentHistory(Expression<Func<string>> relationshipJobInfoId, Expression<Func<EditConstituentEmploymentHistoryInput>> body)
        {
            var __workflow_relationshipJobInfoId = WorkflowExpression.Compile(relationshipJobInfoId, nameof(relationshipJobInfoId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/relationshipjobsinfo/{0}", __workflow_relationshipJobInfoId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentSolicitCode, ApiConnectionActionConfiguration> CreateConstituentSolicitCode(Expression<Func<CreateConstituentSolicitCodeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConmgCreatedConstituentSolicitCode, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-conmg/solicitcodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConmgCreatedConstituentSolicitCode>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteConstituentSolicitCode(Expression<Func<string>> constituentSolicitCodeId)
        {
            var __workflow_constituentSolicitCodeId = WorkflowExpression.Compile(constituentSolicitCodeId, nameof(constituentSolicitCodeId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/solicitcodes/{0}", __workflow_constituentSolicitCodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentSolicitCode(Expression<Func<string>> constituentSolicitCodeId, Expression<Func<EditConstituentSolicitCodeInput>> body)
        {
            var __workflow_constituentSolicitCodeId = WorkflowExpression.Compile(constituentSolicitCodeId, nameof(constituentSolicitCodeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/solicitcodes/{0}", __workflow_constituentSolicitCodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class BlackbaudcrmconstituTriggers([ConnectionName] string connectionId)
    {
    }

    public class ConmgCreatedConstituentAddress
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentAddressInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("country", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Country { get; set; }

        [JsonProperty("address_type")]
        public string Type { get; set; }

        [JsonProperty("address_block")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postcode")]
        public string PostalCode { get; set; }

        [JsonProperty("primary")]
        public bool? Primary { get; set; }

        [JsonProperty("do_not_mail")]
        public bool? DoNotMail { get; set; }

        [JsonProperty("do_not_mail_reason")]
        public string DoNotMailReason { get; set; }

        [JsonProperty("confidential")]
        public bool? IsConfidential { get; set; }

        [JsonProperty("start_date")]
        public CreateConstituentAddressInputSeasonalStartType SeasonalStart { get; set; }

        [JsonProperty("end_date")]
        public CreateConstituentAddressInputSeasonalEndType SeasonalEnd { get; set; }

        [JsonProperty("historical_start_date")]
        public string HistoricalStartDate { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("dpc")]
        public string DPC { get; set; }

        [JsonProperty("cart")]
        public string CART { get; set; }

        [JsonProperty("lot")]
        public string LOT { get; set; }

        [JsonProperty("congressional_district")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("state_house_district")]
        public string StateHouseDistrict { get; set; }

        [JsonProperty("state_senate_district")]
        public string StateSenateDistrict { get; set; }

        [JsonProperty("local_precinct")]
        public string LocalPrecinct { get; set; }

        [JsonProperty("origin")]
        public CreateConstituentAddressInputOriginType? Origin { get; set; }

        [JsonProperty("info_source")]
        public string InformationSource { get; set; }

        [JsonProperty("info_source_comments")]
        public string InfoSourceComments { get; set; }

        [JsonProperty("recent_move")]
        public bool? RecentlyMoved { get; set; }

        [JsonProperty("old_address")]
        public string OldAddress { get; set; }

        [JsonProperty("omit_from_validation")]
        public bool? OmitFromValidation { get; set; }

        [JsonProperty("update_matching_spouse_addresses")]
        public bool? CopyToSpouse { get; set; }

        [JsonProperty("update_matching_household_addresses")]
        public bool? CopyToHousehold { get; set; }
    }

    public class CreateConstituentAddressInputSeasonalStartType
    {
        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    public class CreateConstituentAddressInputSeasonalEndType
    {
        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateConstituentAddressInputOriginType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "web forms")]
        WebForms
    }

    public class EditConstituentAddressInput
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_type")]
        public string Type { get; set; }

        [JsonProperty("address_block")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postcode")]
        public string PostalCode { get; set; }

        [JsonProperty("primary")]
        public bool? Primary { get; set; }

        [JsonProperty("do_not_mail")]
        public bool? DoNotMail { get; set; }

        [JsonProperty("do_not_mail_reason")]
        public string DoNotMailReason { get; set; }

        [JsonProperty("confidential")]
        public bool? IsConfidential { get; set; }

        [JsonProperty("start_date")]
        public EditConstituentAddressInputSeasonalStartType SeasonalStart { get; set; }

        [JsonProperty("end_date")]
        public EditConstituentAddressInputSeasonalEndType SeasonalEnd { get; set; }

        [JsonProperty("historical_start_date")]
        public string HistoricalStartDate { get; set; }

        [JsonProperty("historical_end_date")]
        public string HistoricalEndDate { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("dpc")]
        public string DPC { get; set; }

        [JsonProperty("cart")]
        public string CART { get; set; }

        [JsonProperty("lot")]
        public string LOT { get; set; }

        [JsonProperty("congressional_district")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("state_house_district")]
        public string StateHouseDistrict { get; set; }

        [JsonProperty("state_senate_district")]
        public string StateSenateDistrict { get; set; }

        [JsonProperty("local_precinct")]
        public string LocalPrecinct { get; set; }

        [JsonProperty("info_source")]
        public string InformationSource { get; set; }

        [JsonProperty("info_source_comments")]
        public string InfoSourceComments { get; set; }

        [JsonProperty("omit_from_validation")]
        public bool? OmitFromValidation { get; set; }

        [JsonProperty("update_contacts")]
        public bool? UpdateContacts { get; set; }

        [JsonProperty("update_matching_household_addresses")]
        public bool? CopyToHousehold { get; set; }
    }

    public class EditConstituentAddressInputSeasonalStartType
    {
        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    public class EditConstituentAddressInputSeasonalEndType
    {
        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    public class ConmgCreatedConstituentAlternateLookupId
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentAlternateLookupIdInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("alternate_lookup_id_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("alternate_lookup_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AlternateLookupId { get; set; }
    }

    public class EditConstituentAlternateLookupIdInput
    {
        [JsonProperty("alternate_lookup_id_type")]
        public string Type { get; set; }

        [JsonProperty("alternate_lookup_id")]
        public string AlternateLookupId { get; set; }
    }

    public class ConmgCreatedConstituentAppealResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentAppealResponseInput
    {
        [JsonProperty("constituent_appeal_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentAppealId { get; set; }

        [JsonProperty("response_category", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Category { get; set; }

        [JsonProperty("response", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Response { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class ConmgCreatedConstituentAppeal
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentAppealInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("appeal_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AppealId { get; set; }

        [JsonProperty("mkt_segmentation")]
        public string Mailing { get; set; }

        [JsonProperty("date_sent")]
        public string DateSent { get; set; }

        [JsonProperty("mkt_package_id")]
        public string Package { get; set; }

        [JsonProperty("source_code")]
        public string SourceCode { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class EditConstituentAppealInput
    {
        [JsonProperty("appeal_id")]
        public string AppealId { get; set; }

        [JsonProperty("mkt_segmentation")]
        public string Mailing { get; set; }

        [JsonProperty("date_sent")]
        public string DateSent { get; set; }

        [JsonProperty("mkt_package_id")]
        public string Package { get; set; }

        [JsonProperty("source_code")]
        public string SourceCode { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class ConmgConstituentAppealCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgConstituentAppeal[] Value { get; set; }
    }

    public class ConmgConstituentAppeal
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealId { get; set; }

        [JsonProperty("appeal")]
        public string AppealName { get; set; }

        [JsonProperty("description")]
        public string AppealDescription { get; set; }

        [JsonProperty("mkt_segmentation_id")]
        public string MailingId { get; set; }

        [JsonProperty("mailing")]
        public string MailingName { get; set; }

        [JsonProperty("mailing_family_type_code")]
        public int MailingFamilyTypeCode { get; set; }

        [JsonProperty("date_sent")]
        public string DateSent { get; set; }

        [JsonProperty("package")]
        public string PackageName { get; set; }

        [JsonProperty("source_code")]
        public string SourceCode { get; set; }

        [JsonProperty("mkt_segmentation_segment_id")]
        public string SegmentId { get; set; }

        [JsonProperty("segment")]
        public string Segment { get; set; }

        [JsonProperty("finder_number")]
        public int FinderNumber { get; set; }

        [JsonProperty("test_segment")]
        public string TestSegment { get; set; }

        [JsonProperty("letter")]
        public string Letter { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("has_responses")]
        public bool HasResponses { get; set; }

        [JsonProperty("appeal_mailing")]
        public bool AppealMailing { get; set; }

        [JsonProperty("time_frame_text")]
        public string TimeFrame { get; set; }

        [JsonProperty("time_frame_group_sort")]
        public string TimeFrameGroupSort { get; set; }
    }

    public class ConmgCreatedConstituentCorrespondence
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentCorrespondenceInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("correspondence_code", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CorrespondenceCode { get; set; }

        [JsonProperty("date_sent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DateSent { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class EditConstituentCorrespondenceInput
    {
        [JsonProperty("correspondence_code")]
        public string CorrespondenceCode { get; set; }

        [JsonProperty("date_sent")]
        public string DateSent { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class ConmgCreatedConstituentNote
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentNoteInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("note_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("date_entered", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Date { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("author_id")]
        public string AuthorId { get; set; }

        [JsonProperty("text_note")]
        public string Note { get; set; }

        [JsonProperty("html_note")]
        public string HTML { get; set; }
    }

    public class EditConstituentNoteInput
    {
        [JsonProperty("note_type")]
        public string Type { get; set; }

        [JsonProperty("date_entered")]
        public string Date { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("author_id")]
        public string AuthorId { get; set; }

        [JsonProperty("text_note")]
        public string Note { get; set; }

        [JsonProperty("html_note")]
        public string HTML { get; set; }
    }

    public class ConmgConstituentSearchResultCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgConstituentSearchResult[] Value { get; set; }
    }

    public class ConmgConstituentSearchResult
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("suffixcodeid")]
        public string SuffixCodeId { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("sort_constituent_name")]
        public string SortName { get; set; }

        [JsonProperty("country_id")]
        public string CountryId { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("post_code")]
        public string Postcode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("classof")]
        public int ClassOf { get; set; }

        [JsonProperty("gives_anonymously")]
        public bool GivesAnonymously { get; set; }

        [JsonProperty("organization")]
        public bool IsOrganization { get; set; }

        [JsonProperty("group")]
        public bool IsGroup { get; set; }

        [JsonProperty("household")]
        public bool IsHousehold { get; set; }

        [JsonProperty("prospectmanager")]
        public string ProspectManager { get; set; }
    }

    public class ConmgAddressCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgAddress[] Value { get; set; }
    }

    public class ConmgAddress
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("contact_info")]
        public string Address { get; set; }

        [JsonProperty("primary")]
        public string IsPrimary { get; set; }

        [JsonProperty("confidential")]
        public bool IsConfidential { get; set; }

        [JsonProperty("former")]
        public bool IsFormer { get; set; }

        [JsonProperty("do_not_contact")]
        public string DoNotContact { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("geocoded")]
        public bool Geocoded { get; set; }

        [JsonProperty("pending_geocode")]
        public bool PendingGeocode { get; set; }

        [JsonProperty("invalid_geocode")]
        public bool InvalidGeocode { get; set; }

        [JsonProperty("map_context_id")]
        public string MapContextId { get; set; }
    }

    public class ConmgAlternateLookupIdCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgAlternateLookupId[] Value { get; set; }
    }

    public class ConmgAlternateLookupId
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("alternate_lookup_id")]
        public string AlternateLookupId { get; set; }
    }

    public class ConmgAttributeCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgAttribute[] Value { get; set; }
    }

    public class ConmgAttribute
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("attribute_category_id")]
        public string CategoryId { get; set; }

        [JsonProperty("attribute_group")]
        public string Group { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class ConmgConstituentPrimaryContactInfo
    {
        [JsonProperty("address_type_label")]
        public string AddressType { get; set; }

        [JsonProperty("address_type_id")]
        public string AddressTypeId { get; set; }

        [JsonProperty("country_id")]
        public string PrimaryAddressCountryId { get; set; }

        [JsonProperty("address")]
        public string PrimaryAddress { get; set; }

        [JsonProperty("city")]
        public string PrimaryAddressCity { get; set; }

        [JsonProperty("state_id")]
        public string PrimaryAddressStateId { get; set; }

        [JsonProperty("post_code")]
        public string PrimaryAddressPostalCode { get; set; }

        [JsonProperty("confidential")]
        public bool IsAddressConfidential { get; set; }

        [JsonProperty("do_not_mail")]
        public bool DoNotMail { get; set; }

        [JsonProperty("do_not_mail_reason_code_id")]
        public string DoNotMailReasonId { get; set; }

        [JsonProperty("phone_type_label")]
        public string PrimaryPhoneType { get; set; }

        [JsonProperty("phone_type_id")]
        public string PrimaryPhoneTypeId { get; set; }

        [JsonProperty("phone")]
        public string PrimaryPhoneNumber { get; set; }

        [JsonProperty("phone_is_confidential")]
        public bool IsPhoneConfidential { get; set; }

        [JsonProperty("do_not_call")]
        public bool DoNotCall { get; set; }

        [JsonProperty("do_not_call_reason_code_id")]
        public string DoNotCallReasonId { get; set; }

        [JsonProperty("email_type_label")]
        public string PrimaryEmailAddressType { get; set; }

        [JsonProperty("email_type_id")]
        public string PrimaryEmailAddressTypeId { get; set; }

        [JsonProperty("email")]
        public string PrimaryEmailAddress { get; set; }

        [JsonProperty("do_not_email")]
        public bool DoNotEmail { get; set; }

        [JsonProperty("web_address")]
        public string Website { get; set; }
    }

    public class ConmgEducationCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgEducation[] Value { get; set; }
    }

    public class ConmgEducation
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string EducationalInstitution { get; set; }

        [JsonProperty("education_history_status")]
        public string Status { get; set; }

        [JsonProperty("primary_record")]
        public bool Primary { get; set; }

        [JsonProperty("program")]
        public string Program { get; set; }

        [JsonProperty("degree")]
        public string Degree { get; set; }

        [JsonProperty("class_of")]
        public int ClassOf { get; set; }

        [JsonProperty("affiliated")]
        public bool Afflilated { get; set; }

        [JsonProperty("start_date")]
        public ConmgEducationFromType From { get; set; }

        [JsonProperty("end_date")]
        public ConmgEducationToType To { get; set; }
    }

    public class ConmgEducationFromType
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }
    }

    public class ConmgEducationToType
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }
    }

    public class ConmgEmailAddressCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgEmailAddress[] Value { get; set; }
    }

    public class ConmgEmailAddress
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string EmailType { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("info_source")]
        public string InfoSource { get; set; }

        [JsonProperty("info_source_comments")]
        public string InfoSourceComments { get; set; }
    }

    public class ConmgPhoneCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgPhone[] Value { get; set; }
    }

    public class ConmgPhone
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("phone_number")]
        public string Number { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("donotcall")]
        public bool DoNotCall { get; set; }

        [JsonProperty("info_source")]
        public string InfoSource { get; set; }

        [JsonProperty("info_source_comments")]
        public string InfoSourceComments { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("start_time")]
        public ConmgPhoneCallAfterType CallAfter { get; set; }

        [JsonProperty("end_time")]
        public ConmgPhoneCallBeforeType CallBefore { get; set; }
    }

    public class ConmgPhoneCallAfterType
    {
        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }
    }

    public class ConmgPhoneCallBeforeType
    {
        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }
    }

    public class ConmgConstituentProfilePicture
    {
        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("key_name")]
        public string KeyName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("nick_name")]
        public string Nickname { get; set; }

        [JsonProperty("maiden_name")]
        public string MaidenName { get; set; }

        [JsonProperty("gives_anonymously")]
        public bool GivesAnonymously { get; set; }
    }

    public class ConmgEmploymentHistoryCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgEmploymentHistory[] Value { get; set; }
    }

    public class ConmgEmploymentHistory
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Relationship { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("job_schedule")]
        public string CareerLevel { get; set; }

        [JsonProperty("job_category")]
        public string Category { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("job_department")]
        public string Department { get; set; }

        [JsonProperty("job_division")]
        public string Division { get; set; }

        [JsonProperty("job_responsibility")]
        public string Responsibilities { get; set; }

        [JsonProperty("private_record")]
        public bool IsPrivate { get; set; }
    }

    public class ConmgSolicitCodeCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgSolicitCode[] Value { get; set; }
    }

    public class ConmgSolicitCode
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string SolicitCode { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum dateRangeInput
    {
        [EnumMember(Value = "All dates")]
        AllDates,
        [EnumMember(Value = "Last 30 days")]
        Last30Days,
        [EnumMember(Value = "Last 60 days")]
        Last60Days,
        [EnumMember(Value = "Last 90 days")]
        Last90Days,
        [EnumMember(Value = "Last 6 months")]
        Last6Months,
        [EnumMember(Value = "Last year")]
        LastYear,
        [EnumMember(Value = "Last 2 years")]
        Last2Years
    }

    public class ConmgTributeCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgTribute[] Value { get; set; }
    }

    public class ConmgTribute
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tribute_type")]
        public string TributeType { get; set; }

        [JsonProperty("tribute_text")]
        public string TributeText { get; set; }

        [JsonProperty("tributee")]
        public bool IsTributee { get; set; }

        [JsonProperty("acknowledgee")]
        public bool IsAcknowledgee { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("date_created")]
        public string DateCreated { get; set; }
    }

    public class ConmgConstituentSummaryProfile
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("constituent_profile")]
        public bool IsAConstituentProfile { get; set; }

        [JsonProperty("organization")]
        public bool IsOrganization { get; set; }

        [JsonProperty("top_parent")]
        public string ParentOrganization { get; set; }

        [JsonProperty("top_parent_id")]
        public string ParentOrganizationId { get; set; }

        [JsonProperty("group")]
        public bool IsGroup { get; set; }

        [JsonProperty("dissolved")]
        public bool IsGroupDissolved { get; set; }

        [JsonProperty("group_type")]
        public string GroupType { get; set; }

        [JsonProperty("group_member_count")]
        public int NumberOfGroupMembers { get; set; }

        [JsonProperty("committee_member")]
        public bool IsCommitteeMember { get; set; }

        [JsonProperty("household")]
        public bool IsHousehold { get; set; }

        [JsonProperty("household_id")]
        public string HouseholdId { get; set; }

        [JsonProperty("household_text")]
        public string HouseholdText { get; set; }

        [JsonProperty("inactive")]
        public bool IsInactive { get; set; }

        [JsonProperty("constituent_inactivity_reason")]
        public string InactivityReason { get; set; }

        [JsonProperty("deceased")]
        public bool IsDeceased { get; set; }

        [JsonProperty("deceaseddate")]
        public ConmgConstituentSummaryProfileSourceDateType SourceDate { get; set; }

        [JsonProperty("spouse_deceased")]
        public bool IsSpouseDeceased { get; set; }

        [JsonProperty("gives_anonymously")]
        public bool GivesAnonymously { get; set; }

        [JsonProperty("declarations_on_file")]
        public bool DeclarationsOnFile { get; set; }

        [JsonProperty("wealthpoint_update_pending")]
        public bool WealthPointUpdatePending { get; set; }

        [JsonProperty("picture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("primary_business")]
        public string PrimaryBusiness { get; set; }

        [JsonProperty("primary_business_id")]
        public string PrimaryBusinessId { get; set; }

        [JsonProperty("primary_education")]
        public string PrimaryEducation { get; set; }

        [JsonProperty("primary_education_id")]
        public string PrimaryEducationId { get; set; }

        [JsonProperty("education_attribute_defined")]
        public bool EducationAttributesDefined { get; set; }

        [JsonProperty("related_constituent")]
        public string RelatedConstituent { get; set; }

        [JsonProperty("related_constituent_id")]
        public string RelatedConstituentId { get; set; }

        [JsonProperty("solicit_code_count")]
        public int SolicitCodeCount { get; set; }

        [JsonProperty("address_id")]
        public string PrimaryAddressId { get; set; }

        [JsonProperty("address")]
        public string PrimaryAddress { get; set; }

        [JsonProperty("address_is_confidential")]
        public bool IsAddressConfidential { get; set; }

        [JsonProperty("do_not_mail")]
        public bool DoNotMail { get; set; }

        [JsonProperty("phone_number_id")]
        public string PrimaryPhoneId { get; set; }

        [JsonProperty("phone_type")]
        public string PrimaryPhoneType { get; set; }

        [JsonProperty("phone_number")]
        public string PrimaryPhoneNumber { get; set; }

        [JsonProperty("phone_is_confidential")]
        public bool IsPhoneConfidential { get; set; }

        [JsonProperty("do_not_phone")]
        public bool DoNotCall { get; set; }

        [JsonProperty("email_address_id")]
        public string PrimaryEmailAddressId { get; set; }

        [JsonProperty("email_address")]
        public string PrimaryEmailAddress { get; set; }

        [JsonProperty("do_not_email")]
        public bool DoNotEmail { get; set; }

        [JsonProperty("web_address")]
        public string Website { get; set; }

        [JsonProperty("registrant_status_text")]
        public string RegistrantStatusText { get; set; }

        [JsonProperty("vendor_status_text")]
        public string VendorStatusText { get; set; }

        [JsonProperty("alumnus_status_text")]
        public string AlumnusStatusText { get; set; }

        [JsonProperty("alumnus_enrollment_id")]
        public string AlumnusEnrollmentId { get; set; }

        [JsonProperty("current_enrollment_id")]
        public string CurrentEnrollmentId { get; set; }

        [JsonProperty("current_enrollment_id_2")]
        public string CurrentEnrollmentID2 { get; set; }

        [JsonProperty("current_enrollment_id_3")]
        public string CurrentEnrollmentID3 { get; set; }

        [JsonProperty("student_enrollment_id")]
        public string StudentEnrollmentId { get; set; }

        [JsonProperty("current_school")]
        public string CurrentSchool { get; set; }

        [JsonProperty("current_school_2")]
        public string CurrentSchool2 { get; set; }

        [JsonProperty("current_school_3")]
        public string CurrentSchool3 { get; set; }

        [JsonProperty("lifecycle_stage")]
        public string LifecycleStage { get; set; }

        [JsonProperty("lifecycle_stage_as_of")]
        public string LifecycleStageAsOf { get; set; }

        [JsonProperty("planned_giver_stage")]
        public string PlannedGiverStage { get; set; }

        [JsonProperty("planned_giver_stage_as_of")]
        public string PlannedGiverStageAsOf { get; set; }

        [JsonProperty("donor_state")]
        public string DonorState { get; set; }

        [JsonProperty("donor_state_code")]
        public int DonorStateCode { get; set; }

        [JsonProperty("sponsor_type_code")]
        public int SponsorTypeCode { get; set; }

        [JsonProperty("last_revenue_date")]
        public string LastRevenueDate { get; set; }

        [JsonProperty("alumnus_constituency_text")]
        public string AlumnusConstituencyText { get; set; }

        [JsonProperty("advocate_constituency_text")]
        public string AdvocateConstituencyText { get; set; }

        [JsonProperty("bank_constituency_text")]
        public string BankConstituencyText { get; set; }

        [JsonProperty("board_member_constituency_text")]
        public string BoardMemberConstituencyText { get; set; }

        [JsonProperty("committee_constituency_text")]
        public string CommitteeConstituencyText { get; set; }

        [JsonProperty("committee_member_constituency_text")]
        public string CommitteeMemberConstituencyText { get; set; }

        [JsonProperty("community_member_constituency_text")]
        public string CommunityMemberConstituencyText { get; set; }

        [JsonProperty("donor_constituency_text")]
        public string DonorConstituencyText { get; set; }

        [JsonProperty("faculty_constituency_text")]
        public string FacultyConstituencyText { get; set; }

        [JsonProperty("fundraiser_constituency_text")]
        public string FundraiserConstituencyText { get; set; }

        [JsonProperty("fundraising_group_constituency_text")]
        public string FundraisingGroupConstituencyText { get; set; }

        [JsonProperty("grantor_constituency_text")]
        public string GrantorConstituencyText { get; set; }

        [JsonProperty("loyal_donor_constituency_text")]
        public string LoyalDonorConstituencyText { get; set; }

        [JsonProperty("major_donor_constituency_text")]
        public string MajorDonorConstituencyText { get; set; }

        [JsonProperty("matchfinder_constituency_text")]
        public string MatchFinderConstituencyText { get; set; }

        [JsonProperty("matchfinder_online_record_id")]
        public int MatchFinderOnlineRecordId { get; set; }

        [JsonProperty("member_constituency_text")]
        public string MemberConstituencyText { get; set; }

        [JsonProperty("nfg_constituency_text")]
        public string NFGConstituencyText { get; set; }

        [JsonProperty("patron_constituency_text")]
        public string PatronConstituencyText { get; set; }

        [JsonProperty("plannedgiverconstituencytext")]
        public string PlannedGiverConstituencyText { get; set; }

        [JsonProperty("prospect_constituency_text")]
        public string ProspectConstituencyText { get; set; }

        [JsonProperty("recognition_constituency_text")]
        public string RecognitionConstituencyText { get; set; }

        [JsonProperty("relation_constituency_text")]
        public string RelationConstituencyText { get; set; }

        [JsonProperty("sponsor_constituency_text")]
        public string SponsorConstituencyText { get; set; }

        [JsonProperty("staff_constituency_text")]
        public string StaffConstituencyText { get; set; }

        [JsonProperty("student_constituency_text")]
        public string StudentConstituencyText { get; set; }

        [JsonProperty("student_relation_constituency_text")]
        public string StudentRelationConstituencyText { get; set; }

        [JsonProperty("user_defined_constituency_text")]
        public string UserDefinedConstituencyText { get; set; }

        [JsonProperty("volunteer_constituency_text")]
        public string VolunteerConstituencyText { get; set; }

        [JsonProperty("constituencies_display_order")]
        public ConmgConstituencyDisplayOrder[] ConstituenciesDisplayOrder { get; set; }

        [JsonProperty("user_defined_constituencies")]
        public ConmgUserDefinedConstituency[] UserDefinedConstituencies { get; set; }

        [JsonProperty("student_relation_constituencies")]
        public ConmgStudentRelationConstituency[] StudentRelationConstituencies { get; set; }

        [JsonProperty("social_media_accounts")]
        public ConmgConstituentSocialMediaAccount[] SocialMediaAccounts { get; set; }
    }

    public class ConmgConstituentSummaryProfileSourceDateType
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }
    }

    public class ConmgConstituencyDisplayOrder
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("system")]
        public bool IsSystem { get; set; }
    }

    public class ConmgUserDefinedConstituency
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sequence")]
        public string Sequence { get; set; }
    }

    public class ConmgStudentRelationConstituency
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sequence")]
        public string Sequence { get; set; }
    }

    public class ConmgConstituentSocialMediaAccount
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("social_media_service_id")]
        public string ServiceId { get; set; }

        [JsonProperty("social_media_service_name")]
        public string ServiceName { get; set; }

        [JsonProperty("social_media_service_icon")]
        public string Icon { get; set; }

        [JsonProperty("social_media_account_type_code_id")]
        public string AccountTypeId { get; set; }

        [JsonProperty("social_media_account_type")]
        public string AccountType { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("info_source_code_id")]
        public string InfoSourceCodeId { get; set; }

        [JsonProperty("info_source")]
        public string InfoSource { get; set; }

        [JsonProperty("do_not_contact")]
        public bool DoNotContact { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    public class ConmgCreatedConstituentEducation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentEducationInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("educational_institution_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EducationalInstitution { get; set; }

        [JsonProperty("educational_history_status", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Status { get; set; }

        [JsonProperty("primary_record")]
        public bool? Primary { get; set; }

        [JsonProperty("educational_program")]
        public string Program { get; set; }

        [JsonProperty("educational_degree")]
        public string Degree { get; set; }

        [JsonProperty("educational_award")]
        public string HonorAwarded { get; set; }

        [JsonProperty("educational_source")]
        public string Source { get; set; }

        [JsonProperty("educational_source_date")]
        public CreateConstituentEducationInputSourceDateType SourceDate { get; set; }

        [JsonProperty("comment")]
        public string Comments { get; set; }

        [JsonProperty("date_graduated")]
        public CreateConstituentEducationInputDateGraduatedType DateGraduated { get; set; }

        [JsonProperty("class_year")]
        public int? ClassOf { get; set; }

        [JsonProperty("preferred_class_year")]
        public int? PreferredClassOf { get; set; }

        [JsonProperty("affiliated")]
        public bool? Affiliated { get; set; }

        [JsonProperty("start_date")]
        public CreateConstituentEducationInputFromType From { get; set; }

        [JsonProperty("date_left")]
        public CreateConstituentEducationInputToType To { get; set; }

        [JsonProperty("educational_history_reason")]
        public string Reason { get; set; }

        [JsonProperty("educational_history_level")]
        public string Level { get; set; }
    }

    public class CreateConstituentEducationInputSourceDateType
    {
        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    public class CreateConstituentEducationInputDateGraduatedType
    {
        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    public class CreateConstituentEducationInputFromType
    {
        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    public class CreateConstituentEducationInputToType
    {
        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    public class EditConstituentEducationInput
    {
        [JsonProperty("educational_institution_id")]
        public string EducationalInstitution { get; set; }

        [JsonProperty("educational_history_status")]
        public string Status { get; set; }

        [JsonProperty("primary_record")]
        public bool? Primary { get; set; }

        [JsonProperty("educational_program")]
        public string Program { get; set; }

        [JsonProperty("educational_degree")]
        public string Degree { get; set; }

        [JsonProperty("educational_award")]
        public string HonorAwarded { get; set; }

        [JsonProperty("educational_source")]
        public string Source { get; set; }

        [JsonProperty("educational_source_date")]
        public EditConstituentEducationInputSourceDateType SourceDate { get; set; }

        [JsonProperty("comment")]
        public string Comments { get; set; }

        [JsonProperty("date_graduated")]
        public EditConstituentEducationInputDateGraduatedType DateGraduated { get; set; }

        [JsonProperty("class_year")]
        public int? ClassOf { get; set; }

        [JsonProperty("preferred_class_year")]
        public int? PreferredClassOf { get; set; }

        [JsonProperty("affiliated")]
        public bool? Affiliated { get; set; }

        [JsonProperty("start_date")]
        public EditConstituentEducationInputFromType From { get; set; }

        [JsonProperty("date_left")]
        public EditConstituentEducationInputToType To { get; set; }

        [JsonProperty("educational_history_reason")]
        public string Reason { get; set; }

        [JsonProperty("educational_history_level")]
        public string Level { get; set; }
    }

    public class EditConstituentEducationInputSourceDateType
    {
        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    public class EditConstituentEducationInputDateGraduatedType
    {
        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    public class EditConstituentEducationInputFromType
    {
        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    public class EditConstituentEducationInputToType
    {
        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    public class ConmgCreatedConstituentEmailAddress
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentEmailAddressInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("email_address_type")]
        public string Type { get; set; }

        [JsonProperty("email_address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmailAddress { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("primary")]
        public bool? Primary { get; set; }

        [JsonProperty("do_not_email")]
        public bool? DoNotEmail { get; set; }

        [JsonProperty("donotemailreason")]
        public string DoNotEmailReason { get; set; }

        [JsonProperty("emailisconfidential")]
        public bool? IsConfidential { get; set; }

        [JsonProperty("origin")]
        public CreateConstituentEmailAddressInputOriginType? Origin { get; set; }

        [JsonProperty("info_source")]
        public string InformationSource { get; set; }

        [JsonProperty("info_source_comments")]
        public string InfoSourceComments { get; set; }

        [JsonProperty("update_matching_spouse_email_address")]
        public bool? CopyToSpouse { get; set; }

        [JsonProperty("update_matching_household_email_address")]
        public bool? CopyToHousehold { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateConstituentEmailAddressInputOriginType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "web forms")]
        WebForms
    }

    public class EditConstituentEmailAddressInput
    {
        [JsonProperty("email_address_type")]
        public string Type { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("primary")]
        public bool? Primary { get; set; }

        [JsonProperty("do_not_email")]
        public bool? DoNotEmail { get; set; }

        [JsonProperty("donotemailreason")]
        public string DoNotEmailReason { get; set; }

        [JsonProperty("emailisconfidential")]
        public bool? IsConfidential { get; set; }

        [JsonProperty("info_source")]
        public string InformationSource { get; set; }

        [JsonProperty("info_source_comments")]
        public string InfoSourceComments { get; set; }

        [JsonProperty("update_matching_spouse_email_address")]
        public bool? CopyToSpouse { get; set; }

        [JsonProperty("update_matching_household_email_address")]
        public bool? CopyToHousehold { get; set; }
    }

    public class ConmgCreatedFundraiserConstituency
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateFundraiserConstituencyInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("date_from")]
        public string DateFrom { get; set; }

        [JsonProperty("date_to")]
        public string DateTo { get; set; }
    }

    public class EditFundraiserConstituencyInput
    {
        [JsonProperty("date_from")]
        public string DateFrom { get; set; }

        [JsonProperty("date_to")]
        public string DateTo { get; set; }
    }

    public class ConmgCreatedIndividualConstituent
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateIndividualConstituentInput
    {
        [JsonProperty("last_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("address_type")]
        public string AddressType { get; set; }

        [JsonProperty("address_country")]
        public string Country { get; set; }

        [JsonProperty("address_block")]
        public string Address { get; set; }

        [JsonProperty("address_city")]
        public string City { get; set; }

        [JsonProperty("address_state")]
        public string State { get; set; }

        [JsonProperty("address_post_code")]
        public string PostalCode { get; set; }

        [JsonProperty("address_do_not_mail")]
        public bool? DoNotSendMail { get; set; }

        [JsonProperty("address_do_not_mail_reason")]
        public string DoNotMailReason { get; set; }

        [JsonProperty("address_dpc")]
        public string DPC { get; set; }

        [JsonProperty("address_cart")]
        public string CART { get; set; }

        [JsonProperty("address_lot")]
        public string LOT { get; set; }

        [JsonProperty("address_county")]
        public string County { get; set; }

        [JsonProperty("address_congressional_district")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("phone_type")]
        public string PhoneType { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("email_address_type")]
        public string EmailType { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("title_2")]
        public string Title2 { get; set; }

        [JsonProperty("suffix_2")]
        public string Suffix2 { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("maiden_name")]
        public string MaidenName { get; set; }

        [JsonProperty("marital_status")]
        public string MaritalStatus { get; set; }

        [JsonProperty("birth_date")]
        public CreateIndividualConstituentInputBirthdateType Birthdate { get; set; }

        [JsonProperty("gender_code")]
        public string Gender { get; set; }
    }

    public class CreateIndividualConstituentInputBirthdateType
    {
        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    public class ConmgIndividualConstituent
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("maiden_name")]
        public string MaidenName { get; set; }

        [JsonProperty("marital_status")]
        public string MaritalStatus { get; set; }

        [JsonProperty("birth_date")]
        public ConmgIndividualConstituentSourceDateType SourceDate { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("gender_code")]
        public string Gender { get; set; }

        [JsonProperty("web_address")]
        public string Website { get; set; }

        [JsonProperty("title_2")]
        public string Title2 { get; set; }

        [JsonProperty("suffix_2")]
        public string Suffix2 { get; set; }

        [JsonProperty("gives_anonymously")]
        public bool GivesAnonymously { get; set; }

        [JsonProperty("deceased")]
        public bool Deceased { get; set; }

        [JsonProperty("picture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("picture_thumbnail")]
        public string ProfilePictureThumbnail { get; set; }
    }

    public class ConmgIndividualConstituentSourceDateType
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }
    }

    public class EditIndividualConstituentInput
    {
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("title_2")]
        public string Title2 { get; set; }

        [JsonProperty("suffix_2")]
        public string Suffix2 { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("maiden_name")]
        public string MaidenName { get; set; }

        [JsonProperty("marital_status")]
        public string MaritalStatus { get; set; }

        [JsonProperty("birth_date")]
        public EditIndividualConstituentInputBirthdateType Birthdate { get; set; }

        [JsonProperty("gender_code")]
        public string Gender { get; set; }

        [JsonProperty("web_address")]
        public string Website { get; set; }

        [JsonProperty("gives_anonymously")]
        public bool? GivesAnonymously { get; set; }

        [JsonProperty("deceased")]
        public bool? Deceased { get; set; }

        [JsonProperty("picture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("picture_thumbnail")]
        public string ProfileThumbnail { get; set; }
    }

    public class EditIndividualConstituentInputBirthdateType
    {
        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    public class ConmgCreatedConstituentInteraction
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentInteractionInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("objective", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Summary { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateConstituentInteractionInputStatusType Status { get; set; }

        [JsonProperty("interaction_category")]
        public string Category { get; set; }

        [JsonProperty("interaction_subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("expected_date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ExpectedDate { get; set; }

        [JsonProperty("expected_start_time")]
        public CreateConstituentInteractionInputExpectedStartType ExpectedStart { get; set; }

        [JsonProperty("expected_end_time")]
        public CreateConstituentInteractionInputExpectedEndType ExpectedEnd { get; set; }

        [JsonProperty("actual_date")]
        public string ActualDate { get; set; }

        [JsonProperty("actual_start_time")]
        public CreateConstituentInteractionInputActualStartType ActualStart { get; set; }

        [JsonProperty("actual_end_time")]
        public CreateConstituentInteractionInputActualEndType ActualEnd { get; set; }

        [JsonProperty("time_zone_entry")]
        public string TimeZone { get; set; }

        [JsonProperty("is_all_day_event")]
        public bool? AllDayEvent { get; set; }

        [JsonProperty("fundraiser_id")]
        public string OwnerId { get; set; }

        [JsonProperty("interaction_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactMethod { get; set; }

        [JsonProperty("event_id")]
        public string EventId { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("other_location")]
        public string OtherLocation { get; set; }

        [JsonProperty("comment")]
        public string Comments { get; set; }

        [JsonProperty("participants")]
        public ConmgNewConstituentInteractionParticipant[] Participants { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateConstituentInteractionInputStatusType
    {
        Pending,
        Completed,
        Canceled,
        Declined
    }

    public class CreateConstituentInteractionInputExpectedStartType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class CreateConstituentInteractionInputExpectedEndType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class CreateConstituentInteractionInputActualStartType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class CreateConstituentInteractionInputActualEndType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class ConmgNewConstituentInteractionParticipant
    {
        [JsonProperty("constituent_id")]
        public string ConstitId { get; set; }
    }

    public class ConmgConstituentInteraction
    {
        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("constituent_name")]
        public string ConstituentName { get; set; }

        [JsonProperty("objective")]
        public string Summary { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("interaction_category")]
        public string Category { get; set; }

        [JsonProperty("interaction_subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("expected_date")]
        public string ExpectedDate { get; set; }

        [JsonProperty("expected_start_time")]
        public ConmgConstituentInteractionExpectedStartType ExpectedStart { get; set; }

        [JsonProperty("expected_end_time")]
        public ConmgConstituentInteractionExpectedEndType ExpectedEnd { get; set; }

        [JsonProperty("actual_date")]
        public string ActualDate { get; set; }

        [JsonProperty("actual_start_time")]
        public ConmgConstituentInteractionActualStartType ActualStart { get; set; }

        [JsonProperty("actual_end_time")]
        public ConmgConstituentInteractionActualEndType ActualEnd { get; set; }

        [JsonProperty("time_zone_entry")]
        public string TimeZone { get; set; }

        [JsonProperty("all_day_event")]
        public bool AllDayEvent { get; set; }

        [JsonProperty("fundraiser_id")]
        public string OwnerId { get; set; }

        [JsonProperty("interaction_type")]
        public string ContactMethod { get; set; }

        [JsonProperty("event_id")]
        public string EventId { get; set; }

        [JsonProperty("comment")]
        public string Comments { get; set; }

        [JsonProperty("participants")]
        public ConmgConstituentInteractionParticipant[] Participants { get; set; }
    }

    public class ConmgConstituentInteractionExpectedStartType
    {
        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }
    }

    public class ConmgConstituentInteractionExpectedEndType
    {
        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }
    }

    public class ConmgConstituentInteractionActualStartType
    {
        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }
    }

    public class ConmgConstituentInteractionActualEndType
    {
        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }
    }

    public class ConmgConstituentInteractionParticipant
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }
    }

    public class EditConstituentInteractionInput
    {
        [JsonProperty("objective")]
        public string Summary { get; set; }

        [JsonProperty("status")]
        public EditConstituentInteractionInputStatusType? Status { get; set; }

        [JsonProperty("interaction_category")]
        public string Category { get; set; }

        [JsonProperty("interaction_subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("expected_date")]
        public string ExpectedDate { get; set; }

        [JsonProperty("expected_start_time")]
        public EditConstituentInteractionInputExpectedStartType ExpectedStart { get; set; }

        [JsonProperty("expected_end_time")]
        public EditConstituentInteractionInputExpectedEndType ExpectedEnd { get; set; }

        [JsonProperty("actual_date")]
        public string ActualDate { get; set; }

        [JsonProperty("actual_start_time")]
        public EditConstituentInteractionInputActualStartType ActualStart { get; set; }

        [JsonProperty("actual_end_time")]
        public EditConstituentInteractionInputActualEndType ActualEnd { get; set; }

        [JsonProperty("time_zone_entry")]
        public string TimeZone { get; set; }

        [JsonProperty("all_day_event")]
        public bool? AllDayEvent { get; set; }

        [JsonProperty("fundraiser_id")]
        public string OwnerId { get; set; }

        [JsonProperty("interaction_type")]
        public string ContactMethod { get; set; }

        [JsonProperty("event_id")]
        public string EventId { get; set; }

        [JsonProperty("comment")]
        public string Comments { get; set; }

        [JsonProperty("participants")]
        public ConmgUpdateConstituentInteractionParticipant[] Participants { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EditConstituentInteractionInputStatusType
    {
        Pending,
        Completed,
        Canceled,
        Declined
    }

    public class EditConstituentInteractionInputExpectedStartType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class EditConstituentInteractionInputExpectedEndType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class EditConstituentInteractionInputActualStartType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class EditConstituentInteractionInputActualEndType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class ConmgUpdateConstituentInteractionParticipant
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }
    }

    public class ConmgMergedConstituent
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class MergeTwoConstituentsInput
    {
        [JsonProperty("source_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceConstituentId { get; set; }

        [JsonProperty("target_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetConstituentId { get; set; }

        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Configuration { get; set; }

        [JsonProperty("delete_source", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool DeleteSource { get; set; }

        [JsonProperty("delete_source_constituent", DefaultValueHandling = DefaultValueHandling.Include)]
        public MergeTwoConstituentsInputDeleteActionType DeleteAction { get; set; }

        [JsonProperty("constituent_inactivity_reason_code")]
        public string InactiveReason { get; set; }

        [JsonProperty("constituent_inactivity_details")]
        public string InactivityDetails { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MergeTwoConstituentsInputDeleteActionType
    {
        [EnumMember(Value = "delete source constituent")]
        DeleteSourceConstituent,
        [EnumMember(Value = "mark source constituent inactive")]
        MarkSourceConstituentInactive
    }

    public class ConmgCreatedOrganizationConstituent
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateOrganizationConstituentInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("num_employees")]
        public int? NoOfEmployees { get; set; }

        [JsonProperty("num_subsidiaries")]
        public int? NoOfSubsidiaryOrgs { get; set; }

        [JsonProperty("parent_corp_id")]
        public string ParentOrg { get; set; }

        [JsonProperty("address_type")]
        public string AddressType { get; set; }

        [JsonProperty("address_country")]
        public string Country { get; set; }

        [JsonProperty("address_block")]
        public string Address { get; set; }

        [JsonProperty("address_city")]
        public string City { get; set; }

        [JsonProperty("address_state")]
        public string State { get; set; }

        [JsonProperty("address_postcode")]
        public string PostalCode { get; set; }

        [JsonProperty("address_do_not_mail")]
        public bool? DoNotSendMail { get; set; }

        [JsonProperty("address_do_not_mail_reason")]
        public string DoNotMailReason { get; set; }

        [JsonProperty("dpc")]
        public string DPC { get; set; }

        [JsonProperty("cart")]
        public string CART { get; set; }

        [JsonProperty("lot")]
        public string LOT { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("congressional_district")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("phone_type")]
        public string PhoneType { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("email_address_type")]
        public string EmailType { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("web_address")]
        public string WebAddress { get; set; }

        [JsonProperty("is_primary")]
        public bool? IsPrimaryOrganization { get; set; }

        [JsonProperty("info_source")]
        public string InformationSource { get; set; }

        [JsonProperty("picture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("picture_thumbnail")]
        public string ProfileThumbnail { get; set; }
    }

    public class ConmgOrganizationConstituent
    {
        [JsonProperty("organization_name")]
        public string Name { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("parent_corp_id")]
        public string ParentCorporation { get; set; }

        [JsonProperty("num_employees")]
        public int NumberOfEmployees { get; set; }

        [JsonProperty("num_subsidiaries")]
        public int NumberOfSubsidiaries { get; set; }

        [JsonProperty("web_address")]
        public string Website { get; set; }

        [JsonProperty("is_primary")]
        public bool IsAPrimaryOrganization { get; set; }

        [JsonProperty("picture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("picture_thumbnail")]
        public string ProfilePictureThumbnail { get; set; }

        [JsonProperty("primary_address_id")]
        public string PrimaryAddressId { get; set; }

        [JsonProperty("address_type")]
        public string PrimaryAddressType { get; set; }

        [JsonProperty("address_country")]
        public string PrimaryAddressCountry { get; set; }

        [JsonProperty("address_block")]
        public string PrimaryAddressBlock { get; set; }

        [JsonProperty("address_city")]
        public string PrimaryAddressCity { get; set; }

        [JsonProperty("address_state")]
        public string PrimaryAddressState { get; set; }

        [JsonProperty("address_postcode")]
        public string PrimaryAddressPostalCode { get; set; }

        [JsonProperty("address_do_not_mail")]
        public bool DoNotMail { get; set; }

        [JsonProperty("address_do_not_mail_reason")]
        public string DoNotMailReason { get; set; }

        [JsonProperty("primary_phone_id")]
        public string PrimaryPhoneId { get; set; }

        [JsonProperty("phone_type")]
        public string PrimaryPhoneType { get; set; }

        [JsonProperty("phone_number")]
        public string PrimaryPhoneNumber { get; set; }

        [JsonProperty("primary_email_address_id")]
        public string PrimaryEmailAddressId { get; set; }

        [JsonProperty("email_address_type")]
        public string PrimaryEmailAddressType { get; set; }

        [JsonProperty("email_address")]
        public string PrimaryEmailAddress { get; set; }
    }

    public class EditOrganizationConstituentInput
    {
        [JsonProperty("organization_name")]
        public string Name { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("num_employees")]
        public int? NoOfEmployees { get; set; }

        [JsonProperty("num_subsidiaries")]
        public int? NoOfSubsidiaryOrgs { get; set; }

        [JsonProperty("parent_corp_id")]
        public string ParentOrg { get; set; }

        [JsonProperty("web_address")]
        public string WebAddress { get; set; }

        [JsonProperty("is_primary")]
        public bool? IsPrimaryOrganization { get; set; }

        [JsonProperty("picture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("picture_thumbnail")]
        public string ProfileThumbnail { get; set; }
    }

    public class ConmgCreatedConstituentPhone
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentPhoneInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("phone_type")]
        public string Type { get; set; }

        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Number { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("start_time")]
        public CreateConstituentPhoneInputCallAfterType CallAfter { get; set; }

        [JsonProperty("end_time")]
        public CreateConstituentPhoneInputCallBeforeType CallBefore { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("primary")]
        public bool? Primary { get; set; }

        [JsonProperty("do_not_call")]
        public bool? DoNotCall { get; set; }

        [JsonProperty("do_not_call_reason")]
        public string DoNotCallReason { get; set; }

        [JsonProperty("donottext")]
        public bool? DoNotText { get; set; }

        [JsonProperty("confidential")]
        public bool? IsConfidential { get; set; }

        [JsonProperty("seasonal_start_date")]
        public CreateConstituentPhoneInputSeasonalStartType SeasonalStart { get; set; }

        [JsonProperty("seasonal_end_date")]
        public CreateConstituentPhoneInputSeasonalEndType SeasonalEnd { get; set; }

        [JsonProperty("origin")]
        public CreateConstituentPhoneInputOriginType? Origin { get; set; }

        [JsonProperty("info_source")]
        public string InformationSource { get; set; }

        [JsonProperty("info_source_comments")]
        public string InfoSourceComments { get; set; }

        [JsonProperty("update_matching_spouse_phone")]
        public bool? CopyToSpouse { get; set; }

        [JsonProperty("update_matching_household_phone")]
        public bool? CopyToHousehold { get; set; }
    }

    public class CreateConstituentPhoneInputCallAfterType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class CreateConstituentPhoneInputCallBeforeType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class CreateConstituentPhoneInputSeasonalStartType
    {
        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    public class CreateConstituentPhoneInputSeasonalEndType
    {
        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateConstituentPhoneInputOriginType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "web forms")]
        WebForms
    }

    public class EditConstituentPhoneInput
    {
        [JsonProperty("phone_type")]
        public string Type { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("start_time")]
        public EditConstituentPhoneInputCallAfterType CallAfter { get; set; }

        [JsonProperty("end_time")]
        public EditConstituentPhoneInputCallBeforeType CallBefore { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("primary")]
        public bool? Primary { get; set; }

        [JsonProperty("do_not_call")]
        public bool? DoNotCall { get; set; }

        [JsonProperty("do_not_call_reason")]
        public string DoNotCallReason { get; set; }

        [JsonProperty("donottext")]
        public bool? DoNotText { get; set; }

        [JsonProperty("confidential")]
        public bool? IsConfidential { get; set; }

        [JsonProperty("seasonal_start_date")]
        public EditConstituentPhoneInputSeasonalStartType SeasonalStart { get; set; }

        [JsonProperty("seasonal_end_date")]
        public EditConstituentPhoneInputSeasonalEndType SeasonalEnd { get; set; }

        [JsonProperty("info_source")]
        public string InformationSource { get; set; }

        [JsonProperty("info_source_comments")]
        public string InfoSourceComments { get; set; }

        [JsonProperty("update_matching_spouse_phone")]
        public bool? CopyToSpouse { get; set; }

        [JsonProperty("update_matching_household_phone")]
        public bool? CopyToHousehold { get; set; }
    }

    public class EditConstituentPhoneInputCallAfterType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class EditConstituentPhoneInputCallBeforeType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class EditConstituentPhoneInputSeasonalStartType
    {
        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    public class EditConstituentPhoneInputSeasonalEndType
    {
        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    public class ConmgCreatedConstituentEmploymentHistory
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentEmploymentHistoryInput
    {
        [JsonProperty("context_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("relationship", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Relationship { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("career_level")]
        public string CareerLevel { get; set; }

        [JsonProperty("job_category")]
        public string Category { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("sync_end_date_to_relationship")]
        public bool? SyncEndDate { get; set; }

        [JsonProperty("job_department")]
        public string Department { get; set; }

        [JsonProperty("job_division")]
        public string Division { get; set; }

        [JsonProperty("job_schedule")]
        public string CareerLevel2 { get; set; }

        [JsonProperty("job_responsibility")]
        public string Responsibilities { get; set; }

        [JsonProperty("private_record")]
        public bool? IsPrivate { get; set; }
    }

    public class EditConstituentEmploymentHistoryInput
    {
        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("career_level")]
        public string CareerLevel { get; set; }

        [JsonProperty("job_category")]
        public string Category { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("sync_end_date_to_relationship")]
        public bool? SyncEndDate { get; set; }

        [JsonProperty("job_department")]
        public string Department { get; set; }

        [JsonProperty("job_division")]
        public string Division { get; set; }

        [JsonProperty("job_schedule")]
        public string CareerLevel2 { get; set; }

        [JsonProperty("job_responsibility")]
        public string Responsibilities { get; set; }

        [JsonProperty("private_record")]
        public bool? IsPrivate { get; set; }
    }

    public class ConmgCreatedConstituentSolicitCode
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentSolicitCodeInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("solicit_code", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SolicitCode { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class EditConstituentSolicitCodeInput
    {
        [JsonProperty("solicit_code")]
        public string SolicitCode { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudcrmconstitu;

    public partial class WorkflowManagedActions
    {
        public BlackbaudcrmconstituActions Blackbaudcrmconstitu(string connectionId) => new BlackbaudcrmconstituActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudcrmconstituTriggers Blackbaudcrmconstitu(string connectionId) => new BlackbaudcrmconstituTriggers(connectionId);
    }
}