//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudconstituent
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudconstituentActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<CommPrefApiCreatedConstituentConsent, ApiConnectionActionConfiguration> CreateConstituentConsent(Expression<Func<CreateConstituentConsentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CommPrefApiCreatedConstituentConsent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/commpref/v1/consent/consents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CommPrefApiCreatedConstituentConsent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<CommPrefApiConstituentConsentReadCollection, ApiConnectionActionConfiguration> ListConstituentConsents(Expression<Func<string>> constituentId, Expression<Func<bool>> mostRecentOnly = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_mostRecentOnly = WorkflowExpression.Compile(mostRecentOnly, nameof(mostRecentOnly), required: false);
            return new DeferredBodyAction<CommPrefApiConstituentConsentReadCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/commpref/v1/constituents/{0}/consents", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mostRecentOnly != null)
                    callPayload.Queries["most_recent_only"] = ExpressionConverter.Convert(__workflow_mostRecentOnly);
                return new ApiConnectionAction<CommPrefApiConstituentConsentReadCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<CommPrefApiConstituentSolicitCodeReadCollection, ApiConnectionActionConfiguration> ListConstituentSolicitCodes(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<CommPrefApiConstituentSolicitCodeReadCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/commpref/v1/constituents/{0}/constituentsolicitcodes", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CommPrefApiConstituentSolicitCodeReadCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<CommPrefApiCreatedConstituentSolicitCode, ApiConnectionActionConfiguration> CreateConstituentSolicitCode(Expression<Func<CreateConstituentSolicitCodeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CommPrefApiCreatedConstituentSolicitCode, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/commpref/v1/constituentsolicitcodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CommPrefApiCreatedConstituentSolicitCode>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentSolicitCode(Expression<Func<string>> constituentSolicitCodeId, Expression<Func<EditConstituentSolicitCodeInput>> body)
        {
            var __workflow_constituentSolicitCodeId = WorkflowExpression.Compile(constituentSolicitCodeId, nameof(constituentSolicitCodeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/commpref/v1/constituentsolicitcodes/{0}", __workflow_constituentSolicitCodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentAddress, ApiConnectionActionConfiguration> CreateConstituentAddress(Expression<Func<CreateConstituentAddressInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentAddress, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/addresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConstituentApiCreatedConstituentAddress>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentAddress(Expression<Func<string>> addressId, Expression<Func<EditConstituentAddressInput>> body)
        {
            var __workflow_addressId = WorkflowExpression.Compile(addressId, nameof(addressId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/addresses/{0}", __workflow_addressId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentAlias, ApiConnectionActionConfiguration> CreateConstituentAlias(Expression<Func<CreateConstituentAliasInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentAlias, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/aliases";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConstituentApiCreatedConstituentAlias>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentAlias(Expression<Func<string>> aliasId, Expression<Func<EditConstituentAliasInput>> body)
        {
            var __workflow_aliasId = WorkflowExpression.Compile(aliasId, nameof(aliasId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/aliases/{0}", __workflow_aliasId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentCode, ApiConnectionActionConfiguration> CreateConstituentCode(Expression<Func<CreateConstituentCodeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentCode, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/constituentcodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConstituentApiCreatedConstituentCode>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteConstituentCode(Expression<Func<string>> constituentCodeId)
        {
            var __workflow_constituentCodeId = WorkflowExpression.Compile(constituentCodeId, nameof(constituentCodeId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituentcodes/{0}", __workflow_constituentCodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentCode(Expression<Func<string>> constituentCodeId, Expression<Func<EditConstituentCodeInput>> body)
        {
            var __workflow_constituentCodeId = WorkflowExpression.Compile(constituentCodeId, nameof(constituentCodeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituentcodes/{0}", __workflow_constituentCodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentRead, ApiConnectionActionConfiguration> ListConstituents(Expression<Func<string>> listId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> constituentCode = null, Expression<Func<string>> constituentId = null, Expression<Func<string>> customFieldCategory = null, Expression<Func<string>> fundraiserStatus = null, Expression<Func<bool>> includeDeceased = null, Expression<Func<bool>> includeInactive = null, Expression<Func<string>> postalCode = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null, Expression<Func<string>> sort = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_constituentCode = WorkflowExpression.Compile(constituentCode, nameof(constituentCode), required: false);
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: false);
            var __workflow_customFieldCategory = WorkflowExpression.Compile(customFieldCategory, nameof(customFieldCategory), required: false);
            var __workflow_fundraiserStatus = WorkflowExpression.Compile(fundraiserStatus, nameof(fundraiserStatus), required: false);
            var __workflow_includeDeceased = WorkflowExpression.Compile(includeDeceased, nameof(includeDeceased), required: false);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            var __workflow_postalCode = WorkflowExpression.Compile(postalCode, nameof(postalCode), required: false);
            var __workflow_dateAdded = WorkflowExpression.Compile(dateAdded, nameof(dateAdded), required: false);
            var __workflow_lastModified = WorkflowExpression.Compile(lastModified, nameof(lastModified), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfConstituentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/constituents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_listId != null)
                    callPayload.Queries["list_id"] = ExpressionConverter.Convert(__workflow_listId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_constituentCode != null)
                    callPayload.Queries["constituent_code"] = ExpressionConverter.Convert(__workflow_constituentCode);
                if (__workflow_constituentId != null)
                    callPayload.Queries["constituent_id"] = ExpressionConverter.Convert(__workflow_constituentId);
                if (__workflow_customFieldCategory != null)
                    callPayload.Queries["custom_field_category"] = ExpressionConverter.Convert(__workflow_customFieldCategory);
                if (__workflow_fundraiserStatus != null)
                    callPayload.Queries["fundraiser_status"] = ExpressionConverter.Convert(__workflow_fundraiserStatus);
                if (__workflow_includeDeceased != null)
                    callPayload.Queries["include_deceased"] = ExpressionConverter.Convert(__workflow_includeDeceased);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                if (__workflow_postalCode != null)
                    callPayload.Queries["postal_code"] = ExpressionConverter.Convert(__workflow_postalCode);
                if (__workflow_dateAdded != null)
                    callPayload.Queries["date_added"] = ExpressionConverter.Convert(__workflow_dateAdded);
                if (__workflow_lastModified != null)
                    callPayload.Queries["last_modified"] = ExpressionConverter.Convert(__workflow_lastModified);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiConstituentRead, ApiConnectionActionConfiguration> GetConstituent(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiConstituentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiConstituentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituent(Expression<Func<string>> constituentId, Expression<Func<EditConstituentInput>> body)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfAddressRead, ApiConnectionActionConfiguration> ListConstituentAddresses(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfAddressRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/addresses", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfAddressRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfAliasRead, ApiConnectionActionConfiguration> ListConstituentAliases(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfAliasRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/aliases", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfAliasRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentAttachmentRead, ApiConnectionActionConfiguration> ListConstituentAttachments(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfConstituentAttachmentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/attachments", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentAttachmentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentCodeRead, ApiConnectionActionConfiguration> ListConstituentCodes(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfConstituentCodeRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/constituentcodes", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentCodeRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentCustomFieldRead, ApiConnectionActionConfiguration> ListConstituentCustomFields(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfConstituentCustomFieldRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/customfields", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentCustomFieldRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfEducationRead, ApiConnectionActionConfiguration> ListConstituentEducations(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfEducationRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/educations", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfEducationRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfEmailAddressRead, ApiConnectionActionConfiguration> ListConstituentEmailAddresses(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfEmailAddressRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/emailaddresses", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfEmailAddressRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfFundraiserAssignmentRead, ApiConnectionActionConfiguration> ListConstituentFundraiserAssignments(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfFundraiserAssignmentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/fundraiserassignments", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfFundraiserAssignmentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfMembershipRead, ApiConnectionActionConfiguration> ListConstituentMemberships(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfMembershipRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/memberships", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfMembershipRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiNameFormatSummaryRead, ApiConnectionActionConfiguration> GetConstituentNameFormatSummary(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiNameFormatSummaryRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/nameformats/summary", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiNameFormatSummaryRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfNoteRead, ApiConnectionActionConfiguration> ListConstituentNotes(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfNoteRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/notes", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfNoteRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfOnlinePresenceRead, ApiConnectionActionConfiguration> ListConstituentOnlinePresences(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfOnlinePresenceRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/onlinepresences", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfOnlinePresenceRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfPhoneRead, ApiConnectionActionConfiguration> ListConstituentPhones(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfPhoneRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/phones", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfPhoneRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiProfilePictureRead, ApiConnectionActionConfiguration> GetConstituentProfilePicture(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiProfilePictureRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/profilepicture", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiProfilePictureRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentProfilePicture(Expression<Func<string>> constituentId, Expression<Func<EditConstituentProfilePictureInput>> body)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/profilepicture", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfRelationshipRead, ApiConnectionActionConfiguration> ListConstituentRelationships(Expression<Func<string>> constituentId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfRelationshipRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/relationships", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfRelationshipRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiConvertedConstituent, ApiConnectionActionConfiguration> ConvertToConstituent(Expression<Func<string>> nonConstituentId, Expression<Func<ConvertToConstituentInput>> body)
        {
            var __workflow_nonConstituentId = WorkflowExpression.Compile(nonConstituentId, nameof(nonConstituentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConstituentApiConvertedConstituent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/convert/{0}", __workflow_nonConstituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConstituentApiConvertedConstituent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentAttachment, ApiConnectionActionConfiguration> CreateConstituentAttachment(Expression<Func<CreateConstituentAttachmentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentAttachment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/constituents/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConstituentApiCreatedConstituentAttachment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentAttachment(Expression<Func<string>> attachmentId, Expression<Func<EditConstituentAttachmentInput>> body)
        {
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/attachments/{0}", __workflow_attachmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentCustomField, ApiConnectionActionConfiguration> CreateConstituentCustomField(Expression<Func<CreateConstituentCustomFieldInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentCustomField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/constituents/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConstituentApiCreatedConstituentCustomField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentCustomField(Expression<Func<string>> customFieldId, Expression<Func<EditConstituentCustomFieldInput>> body)
        {
            var __workflow_customFieldId = WorkflowExpression.Compile(customFieldId, nameof(customFieldId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/customfields/{0}", __workflow_customFieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiDuplicateSearchResultCollection, ApiConnectionActionConfiguration> GetDuplicateSearchResults(Expression<Func<string>> lastOrgName, Expression<Func<string>> firstName = null, Expression<Func<string>> middleName = null, Expression<Func<string>> suffix = null, Expression<Func<string>> addressBlock = null, Expression<Func<string>> city = null, Expression<Func<string>> state = null, Expression<Func<string>> postCode = null, Expression<Func<string[]>> email = null, Expression<Func<string[]>> phone = null, Expression<Func<bool>> searchIndividuals = null, Expression<Func<bool>> searchAliases = null, Expression<Func<bool>> searchContacts = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_lastOrgName = WorkflowExpression.Compile(lastOrgName, nameof(lastOrgName), required: true);
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: false);
            var __workflow_middleName = WorkflowExpression.Compile(middleName, nameof(middleName), required: false);
            var __workflow_suffix = WorkflowExpression.Compile(suffix, nameof(suffix), required: false);
            var __workflow_addressBlock = WorkflowExpression.Compile(addressBlock, nameof(addressBlock), required: false);
            var __workflow_city = WorkflowExpression.Compile(city, nameof(city), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            var __workflow_postCode = WorkflowExpression.Compile(postCode, nameof(postCode), required: false);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_phone = WorkflowExpression.Compile(phone, nameof(phone), required: false);
            var __workflow_searchIndividuals = WorkflowExpression.Compile(searchIndividuals, nameof(searchIndividuals), required: false);
            var __workflow_searchAliases = WorkflowExpression.Compile(searchAliases, nameof(searchAliases), required: false);
            var __workflow_searchContacts = WorkflowExpression.Compile(searchContacts, nameof(searchContacts), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConstituentApiDuplicateSearchResultCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/constituents/duplicatesearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["last_org_name"] = ExpressionConverter.Convert(__workflow_lastOrgName);
                if (__workflow_firstName != null)
                    callPayload.Queries["first_name"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_middleName != null)
                    callPayload.Queries["middle_name"] = ExpressionConverter.Convert(__workflow_middleName);
                if (__workflow_suffix != null)
                    callPayload.Queries["suffix"] = ExpressionConverter.Convert(__workflow_suffix);
                if (__workflow_addressBlock != null)
                    callPayload.Queries["address_block"] = ExpressionConverter.Convert(__workflow_addressBlock);
                if (__workflow_city != null)
                    callPayload.Queries["city"] = ExpressionConverter.Convert(__workflow_city);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_postCode != null)
                    callPayload.Queries["post_code"] = ExpressionConverter.Convert(__workflow_postCode);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_phone != null)
                    callPayload.Queries["phone"] = ExpressionConverter.Convert(__workflow_phone);
                callPayload.Queries["search_individuals"] = Convert.ToString(true);
                if (__workflow_searchIndividuals != null)
                    callPayload.Queries["search_individuals"] = ExpressionConverter.Convert(__workflow_searchIndividuals);
                callPayload.Queries["search_aliases"] = Convert.ToString(false);
                if (__workflow_searchAliases != null)
                    callPayload.Queries["search_aliases"] = ExpressionConverter.Convert(__workflow_searchAliases);
                callPayload.Queries["search_contacts"] = Convert.ToString(false);
                if (__workflow_searchContacts != null)
                    callPayload.Queries["search_contacts"] = ExpressionConverter.Convert(__workflow_searchContacts);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConstituentApiDuplicateSearchResultCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfSearchResultRead, ApiConnectionActionConfiguration> SearchConstituent(Expression<Func<string>> searchText, Expression<Func<string>> fundraiserStatus = null, Expression<Func<bool>> includeInactive = null, Expression<Func<searchFieldInput>> searchField = null, Expression<Func<bool>> strictSearch = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: true);
            var __workflow_fundraiserStatus = WorkflowExpression.Compile(fundraiserStatus, nameof(fundraiserStatus), required: false);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            var __workflow_searchField = WorkflowExpression.Compile(searchField, nameof(searchField), required: false);
            var __workflow_strictSearch = WorkflowExpression.Compile(strictSearch, nameof(strictSearch), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfSearchResultRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/constituents/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["search_text"] = ExpressionConverter.Convert(__workflow_searchText);
                if (__workflow_fundraiserStatus != null)
                    callPayload.Queries["fundraiser_status"] = ExpressionConverter.Convert(__workflow_fundraiserStatus);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                if (__workflow_searchField != null)
                    callPayload.Queries["search_field"] = ExpressionConverter.Convert(__workflow_searchField);
                if (__workflow_strictSearch != null)
                    callPayload.Queries["strict_search"] = ExpressionConverter.Convert(__workflow_strictSearch);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfSearchResultRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentEducation, ApiConnectionActionConfiguration> CreateConstituentEducation(Expression<Func<CreateConstituentEducationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentEducation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/educations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConstituentApiCreatedConstituentEducation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentEducation(Expression<Func<string>> educationId, Expression<Func<EditConstituentEducationInput>> body)
        {
            var __workflow_educationId = WorkflowExpression.Compile(educationId, nameof(educationId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/educations/{0}", __workflow_educationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentEmailAddress, ApiConnectionActionConfiguration> CreateConstituentEmailAddress(Expression<Func<CreateConstituentEmailAddressInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentEmailAddress, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/emailaddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConstituentApiCreatedConstituentEmailAddress>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentEmailAddress(Expression<Func<string>> emailAddressId, Expression<Func<EditConstituentEmailAddressInput>> body)
        {
            var __workflow_emailAddressId = WorkflowExpression.Compile(emailAddressId, nameof(emailAddressId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/emailaddresses/{0}", __workflow_emailAddressId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedNameFormat, ApiConnectionActionConfiguration> CreateConstituentNameFormat(Expression<Func<CreateConstituentNameFormatInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConstituentApiCreatedNameFormat, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/nameformats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConstituentApiCreatedNameFormat>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentNameFormat(Expression<Func<string>> nameFormatId, Expression<Func<EditConstituentNameFormatInput>> body)
        {
            var __workflow_nameFormatId = WorkflowExpression.Compile(nameFormatId, nameof(nameFormatId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/nameformats/{0}", __workflow_nameFormatId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentNote, ApiConnectionActionConfiguration> CreateConstituentNote(Expression<Func<CreateConstituentNoteInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentNote, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/notes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConstituentApiCreatedConstituentNote>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentNote(Expression<Func<string>> noteId, Expression<Func<EditConstituentNoteInput>> body)
        {
            var __workflow_noteId = WorkflowExpression.Compile(noteId, nameof(noteId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/notes/{0}", __workflow_noteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentOnlinePresence, ApiConnectionActionConfiguration> CreateConstituentOnlinePresence(Expression<Func<CreateConstituentOnlinePresenceInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentOnlinePresence, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/onlinepresences";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConstituentApiCreatedConstituentOnlinePresence>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentOnlinePresence(Expression<Func<string>> onlinePresenceId, Expression<Func<EditConstituentOnlinePresenceInput>> body)
        {
            var __workflow_onlinePresenceId = WorkflowExpression.Compile(onlinePresenceId, nameof(onlinePresenceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/onlinepresences/{0}", __workflow_onlinePresenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentPhone, ApiConnectionActionConfiguration> CreateConstituentPhone(Expression<Func<CreateConstituentPhoneInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentPhone, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/phones";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConstituentApiCreatedConstituentPhone>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentPhone(Expression<Func<string>> phoneId, Expression<Func<EditConstituentPhoneInput>> body)
        {
            var __workflow_phoneId = WorkflowExpression.Compile(phoneId, nameof(phoneId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/phones/{0}", __workflow_phoneId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedNameFormat, ApiConnectionActionConfiguration> CreateConstituentPrimaryNameFormat(Expression<Func<CreateConstituentPrimaryNameFormatInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConstituentApiCreatedNameFormat, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/primarynameformats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConstituentApiCreatedNameFormat>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentPrimaryNameFormat(Expression<Func<string>> primaryNameFormatId, Expression<Func<EditConstituentPrimaryNameFormatInput>> body)
        {
            var __workflow_primaryNameFormatId = WorkflowExpression.Compile(primaryNameFormatId, nameof(primaryNameFormatId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/primarynameformats/{0}", __workflow_primaryNameFormatId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentRelationship(Expression<Func<string>> relationshipId, Expression<Func<EditConstituentRelationshipInput>> body)
        {
            var __workflow_relationshipId = WorkflowExpression.Compile(relationshipId, nameof(relationshipId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/relationships/{0}", __workflow_relationshipId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedIndividualConstituent, ApiConnectionActionConfiguration> CreateIndividualConstituent(Expression<Func<CreateIndividualConstituentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConstituentApiCreatedIndividualConstituent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/virtual/individuals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConstituentApiCreatedIndividualConstituent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedIndividualRelationship, ApiConnectionActionConfiguration> CreateIndividualRelationship(Expression<Func<CreateIndividualRelationshipInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConstituentApiCreatedIndividualRelationship, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/virtual/individualrelationships";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConstituentApiCreatedIndividualRelationship>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedOrganizationConstituent, ApiConnectionActionConfiguration> CreateOrganizationConstituent(Expression<Func<CreateOrganizationConstituentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConstituentApiCreatedOrganizationConstituent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/virtual/organizations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConstituentApiCreatedOrganizationConstituent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedOrganizationRelationship, ApiConnectionActionConfiguration> CreateOrganizationRelationship(Expression<Func<CreateOrganizationRelationshipInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConstituentApiCreatedOrganizationRelationship, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/virtual/organizationrelationships";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConstituentApiCreatedOrganizationRelationship>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<FundraisingApiCreatedFundraiserAssignment, ApiConnectionActionConfiguration> CreateFundraiserAssignment(Expression<Func<CreateFundraiserAssignmentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FundraisingApiCreatedFundraiserAssignment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fundraising/v1/fundraisers/assignments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FundraisingApiCreatedFundraiserAssignment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfFundraiserAssignmentRead, ApiConnectionActionConfiguration> ListFundraiserAssignments(Expression<Func<string>> fundraiserId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_fundraiserId = WorkflowExpression.Compile(fundraiserId, nameof(fundraiserId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<FundraisingApiApiCollectionOfFundraiserAssignmentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fundraising/v1/fundraisers/{0}/assignments", __workflow_fundraiserId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<FundraisingApiApiCollectionOfFundraiserAssignmentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiConstituentIdMap, ApiConnectionActionConfiguration> GetConstituentIdFromLookupId(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<NXTDataIntegrationApiConstituentIdMap, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/constituentidmap/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<NXTDataIntegrationApiConstituentIdMap>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiConstituentSearchResultCollection, ApiConnectionActionConfiguration> SearchConstituentEnhanced(Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> lookupId = null, Expression<Func<string>> email = null, Expression<Func<string>> phoneNumber = null, Expression<Func<int>> limit = null, Expression<Func<string>> addressLines = null, Expression<Func<string>> city = null, Expression<Func<string>> state = null, Expression<Func<string>> postCode = null, Expression<Func<bool>> includeAlias = null, Expression<Func<string>> aliasType = null, Expression<Func<bool>> includeMaidenName = null)
        {
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: false);
            var __workflow_lastName = WorkflowExpression.Compile(lastName, nameof(lastName), required: false);
            var __workflow_lookupId = WorkflowExpression.Compile(lookupId, nameof(lookupId), required: false);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_phoneNumber = WorkflowExpression.Compile(phoneNumber, nameof(phoneNumber), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_addressLines = WorkflowExpression.Compile(addressLines, nameof(addressLines), required: false);
            var __workflow_city = WorkflowExpression.Compile(city, nameof(city), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            var __workflow_postCode = WorkflowExpression.Compile(postCode, nameof(postCode), required: false);
            var __workflow_includeAlias = WorkflowExpression.Compile(includeAlias, nameof(includeAlias), required: false);
            var __workflow_aliasType = WorkflowExpression.Compile(aliasType, nameof(aliasType), required: false);
            var __workflow_includeMaidenName = WorkflowExpression.Compile(includeMaidenName, nameof(includeMaidenName), required: false);
            return new DeferredBodyAction<NXTDataIntegrationApiConstituentSearchResultCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nxt-data-integration/v1/re/constituents/customsearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_firstName != null)
                    callPayload.Queries["first_name"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_lastName != null)
                    callPayload.Queries["last_name"] = ExpressionConverter.Convert(__workflow_lastName);
                if (__workflow_lookupId != null)
                    callPayload.Queries["lookup_id"] = ExpressionConverter.Convert(__workflow_lookupId);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_phoneNumber != null)
                    callPayload.Queries["phone_number"] = ExpressionConverter.Convert(__workflow_phoneNumber);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_addressLines != null)
                    callPayload.Queries["address_lines"] = ExpressionConverter.Convert(__workflow_addressLines);
                if (__workflow_city != null)
                    callPayload.Queries["city"] = ExpressionConverter.Convert(__workflow_city);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_postCode != null)
                    callPayload.Queries["post_code"] = ExpressionConverter.Convert(__workflow_postCode);
                if (__workflow_includeAlias != null)
                    callPayload.Queries["include_alias"] = ExpressionConverter.Convert(__workflow_includeAlias);
                if (__workflow_aliasType != null)
                    callPayload.Queries["alias_type"] = ExpressionConverter.Convert(__workflow_aliasType);
                if (__workflow_includeMaidenName != null)
                    callPayload.Queries["include_maiden_name"] = ExpressionConverter.Convert(__workflow_includeMaidenName);
                return new ApiConnectionAction<NXTDataIntegrationApiConstituentSearchResultCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedConstituentTribute, ApiConnectionActionConfiguration> CreateConstituentTribute(Expression<Func<CreateConstituentTributeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<NXTDataIntegrationApiCreatedConstituentTribute, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nxt-data-integration/v1/re/tribute";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<NXTDataIntegrationApiCreatedConstituentTribute>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiTribute, ApiConnectionActionConfiguration> GetConstituentTribute(Expression<Func<string>> tributeId)
        {
            var __workflow_tributeId = WorkflowExpression.Compile(tributeId, nameof(tributeId), required: true);
            return new DeferredBodyAction<NXTDataIntegrationApiTribute, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/tribute/{0}", __workflow_tributeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<NXTDataIntegrationApiTribute>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedTributeAcknowledgee, ApiConnectionActionConfiguration> CreateTributeAcknowledgee(Expression<Func<CreateTributeAcknowledgeeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<NXTDataIntegrationApiCreatedTributeAcknowledgee, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nxt-data-integration/v1/re/tribute/acknowledgee";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<NXTDataIntegrationApiCreatedTributeAcknowledgee>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiTributeCollection, ApiConnectionActionConfiguration> ListConstituentTributes(Expression<Func<int>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<NXTDataIntegrationApiTributeCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/tribute/constituent/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<NXTDataIntegrationApiTributeCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiTributeAcknowledgeeCollection, ApiConnectionActionConfiguration> ListTributeAcknowledgees(Expression<Func<int>> tributeId)
        {
            var __workflow_tributeId = WorkflowExpression.Compile(tributeId, nameof(tributeId), required: true);
            return new DeferredBodyAction<NXTDataIntegrationApiTributeAcknowledgeeCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/tribute/{0}/acknowledgees", __workflow_tributeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<NXTDataIntegrationApiTributeAcknowledgeeCollection>(callPayload);
            });
        }
    }

    public class BlackbaudconstituentTriggers([ConnectionName] string connectionId)
    {
    }

    public class CommPrefApiCreatedConstituentConsent
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentConsentInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Channel { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("constituent_consent_response", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateConstituentConsentInputResponseType Response { get; set; }

        [JsonProperty("consent_date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Date { get; set; }

        [JsonProperty("consent_statement")]
        public string ConsentStatement { get; set; }

        [JsonProperty("privacy_notice")]
        public string PrivacyNotice { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateConstituentConsentInputResponseType
    {
        OptIn,
        OptOut,
        NoResponse
    }

    public class CommPrefApiConstituentConsentReadCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public CommPrefApiConstituentConsentRead[] Value { get; set; }
    }

    public class CommPrefApiConstituentConsentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("constituent_consent_response")]
        public CommPrefApiConstituentConsentReadResponseType Response { get; set; }

        [JsonProperty("consent_date")]
        public string Date { get; set; }

        [JsonProperty("consent_statement")]
        public string ConsentStatement { get; set; }

        [JsonProperty("privacy_notice")]
        public string PrivacyNotice { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("user_name")]
        public string AddedBy { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CommPrefApiConstituentConsentReadResponseType
    {
        OptIn,
        OptOut,
        NoResponse
    }

    public class CommPrefApiConstituentSolicitCodeReadCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public CommPrefApiConstituentSolicitCodeRead[] Value { get; set; }
    }

    public class CommPrefApiConstituentSolicitCodeRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("solicit_code")]
        public string SolicitCode { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }

    public class CommPrefApiCreatedConstituentSolicitCode
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
    }

    public class EditConstituentSolicitCodeInput
    {
        [JsonProperty("solicit_code")]
        public string SolicitCode { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }

    public class ConstituentApiCreatedConstituentAddress
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentAddressInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AddressType { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_lines")]
        public string AddressLines { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("information_source")]
        public string InformationSource { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("cart")]
        public string CART { get; set; }

        [JsonProperty("lot")]
        public string LOT { get; set; }

        [JsonProperty("dpc")]
        public string DPC { get; set; }

        [JsonProperty("start")]
        public string ValidFrom { get; set; }

        [JsonProperty("end")]
        public string ValidTo { get; set; }

        [JsonProperty("preferred")]
        public bool? Primary { get; set; }

        [JsonProperty("do_not_mail")]
        public bool? DoNotMail { get; set; }

        [JsonProperty("seasonal_start")]
        public CreateConstituentAddressInputSeasonalStartType SeasonalStart { get; set; }

        [JsonProperty("seasonal_end")]
        public CreateConstituentAddressInputSeasonalEndType SeasonalEnd { get; set; }
    }

    public class CreateConstituentAddressInputSeasonalStartType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class CreateConstituentAddressInputSeasonalEndType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class EditConstituentAddressInput
    {
        [JsonProperty("type")]
        public string AddressType { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_lines")]
        public string AddressLines { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("information_source")]
        public string InformationSource { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("cart")]
        public string CART { get; set; }

        [JsonProperty("lot")]
        public string LOT { get; set; }

        [JsonProperty("dpc")]
        public string DPC { get; set; }

        [JsonProperty("start")]
        public string ValidFrom { get; set; }

        [JsonProperty("end")]
        public string ValidTo { get; set; }

        [JsonProperty("preferred")]
        public bool? Primary { get; set; }

        [JsonProperty("do_not_mail")]
        public bool? DoNotMail { get; set; }

        [JsonProperty("seasonal_start")]
        public EditConstituentAddressInputSeasonalStartType SeasonalStart { get; set; }

        [JsonProperty("seasonal_end")]
        public EditConstituentAddressInputSeasonalEndType SeasonalEnd { get; set; }
    }

    public class EditConstituentAddressInputSeasonalStartType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class EditConstituentAddressInputSeasonalEndType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class ConstituentApiCreatedConstituentAlias
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentAliasInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Alias { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class EditConstituentAliasInput
    {
        [JsonProperty("name")]
        public string Alias { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ConstituentApiCreatedConstituentCode
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentCodeInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentCode { get; set; }

        [JsonProperty("start")]
        public CreateConstituentCodeInputStartType Start { get; set; }

        [JsonProperty("end")]
        public CreateConstituentCodeInputEndType End { get; set; }

        [JsonProperty("sequence")]
        public int? Sequence { get; set; }
    }

    public class CreateConstituentCodeInputStartType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class CreateConstituentCodeInputEndType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class EditConstituentCodeInput
    {
        [JsonProperty("start")]
        public EditConstituentCodeInputStartType Start { get; set; }

        [JsonProperty("end")]
        public EditConstituentCodeInputEndType End { get; set; }

        [JsonProperty("sequence")]
        public int? Sequence { get; set; }
    }

    public class EditConstituentCodeInputStartType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class EditConstituentCodeInputEndType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfConstituentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public ConstituentApiConstituentReadTypeType Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first")]
        public string FirstName { get; set; }

        [JsonProperty("last")]
        public string LastName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("preferred_name")]
        public string PreferredName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("email")]
        public ConstituentApiConstituentReadPrimaryEmailType PrimaryEmail { get; set; }

        [JsonProperty("phone")]
        public ConstituentApiConstituentReadPrimaryPhoneType PrimaryPhone { get; set; }

        [JsonProperty("online_presence")]
        public ConstituentApiConstituentReadPrimaryOnlinePresenceType PrimaryOnlinePresence { get; set; }

        [JsonProperty("address")]
        public ConstituentApiConstituentReadPreferredAddressType PreferredAddress { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("middle")]
        public string MiddleName { get; set; }

        [JsonProperty("former_name")]
        public string FormerName { get; set; }

        [JsonProperty("title_2")]
        public string Title2 { get; set; }

        [JsonProperty("suffix_2")]
        public string Suffix2 { get; set; }

        [JsonProperty("marital_status")]
        public string MaritalStaus { get; set; }

        [JsonProperty("gives_anonymously")]
        public bool GivesAnonymously { get; set; }

        [JsonProperty("requests_no_email")]
        public bool RequestsNoEmail { get; set; }

        [JsonProperty("is_solicitor")]
        public bool IsASolicitor { get; set; }

        [JsonProperty("no_valid_address")]
        public bool NoValidAddresses { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("birthdate")]
        public ConstituentApiConstituentReadBirthdateType Birthdate { get; set; }

        [JsonProperty("birthplace")]
        public string Birthplace { get; set; }

        [JsonProperty("ethnicity")]
        public string Ethnicity { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("income")]
        public string Income { get; set; }

        [JsonProperty("receipt_type")]
        public ConstituentApiConstituentReadReceiptTypeType ReceiptType { get; set; }

        [JsonProperty("religion")]
        public string Religion { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("num_employees")]
        public int NumberOfEmployees { get; set; }

        [JsonProperty("matches_gifts")]
        public bool MatchesGifts { get; set; }

        [JsonProperty("matching_gift_factor")]
        public double MatchingGiftFactor { get; set; }

        [JsonProperty("matching_gift_per_gift_min")]
        public ConstituentApiConstituentReadMinMatchPerGiftType MinMatchPerGift { get; set; }

        [JsonProperty("matching_gift_per_gift_max")]
        public ConstituentApiConstituentReadMaxMatchPerGiftType MaxMatchPerGift { get; set; }

        [JsonProperty("matching_gift_total_min")]
        public ConstituentApiConstituentReadMinMatchPerConstitType MinMatchPerConstit { get; set; }

        [JsonProperty("matching_gift_total_max")]
        public ConstituentApiConstituentReadMaxMatchPerConstitType MaxMatchPerConstit { get; set; }

        [JsonProperty("matching_gift_notes")]
        public string MatchingGiftNotes { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("deceased")]
        public bool Deceased { get; set; }

        [JsonProperty("deceased_date")]
        public ConstituentApiConstituentReadDeceasedDateType DeceasedDate { get; set; }

        [JsonProperty("fundraiser_status")]
        public ConstituentApiConstituentReadFundraiserStatusType FundraiserStatus { get; set; }

        [JsonProperty("is_memorial")]
        public bool IsMemorial { get; set; }

        [JsonProperty("spouse")]
        public ConstituentApiConstituentReadSpouseType Spouse { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiConstituentReadTypeType
    {
        Individual,
        Organization
    }

    public class ConstituentApiConstituentReadPrimaryEmailType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("do_not_email")]
        public bool DoNotEmail { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPrimaryPhoneType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("do_not_call")]
        public bool DoNotCall { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPrimaryOnlinePresenceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Link { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPreferredAddressType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_lines")]
        public string Lines { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("formatted_address")]
        public string Formatted { get; set; }

        [JsonProperty("start")]
        public string ValidFrom { get; set; }

        [JsonProperty("end")]
        public string ValidTo { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("do_not_mail")]
        public bool DoNotMail { get; set; }

        [JsonProperty("seasonal_start")]
        public ConstituentApiConstituentReadPreferredAddressTypeSeasonalStartType SeasonalStart { get; set; }

        [JsonProperty("seasonal_end")]
        public ConstituentApiConstituentReadPreferredAddressTypeSeasonalEndType SeasonalEnd { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPreferredAddressTypeSeasonalStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConstituentReadPreferredAddressTypeSeasonalEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConstituentReadBirthdateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiConstituentReadReceiptTypeType
    {
        [EnumMember(Value = "One receipt per gift")]
        OneReceiptPerGift,
        [EnumMember(Value = "Consolidated receipts")]
        ConsolidatedReceipts
    }

    public class ConstituentApiConstituentReadMinMatchPerGiftType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiConstituentReadMaxMatchPerGiftType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiConstituentReadMinMatchPerConstitType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiConstituentReadMaxMatchPerConstitType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiConstituentReadDeceasedDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiConstituentReadFundraiserStatusType
    {
        Active,
        Inactive,
        None
    }

    public class ConstituentApiConstituentReadSpouseType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("first")]
        public string FirstName { get; set; }

        [JsonProperty("last")]
        public string LastName { get; set; }

        [JsonProperty("is_head_of_household")]
        public bool IsHeadOfHousehold { get; set; }
    }

    public class EditConstituentInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first")]
        public string FirstName { get; set; }

        [JsonProperty("last")]
        public string LastName { get; set; }

        [JsonProperty("name")]
        public string OrganizationName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("preferred_name")]
        public string PreferredName { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("middle")]
        public string MiddleName { get; set; }

        [JsonProperty("former_name")]
        public string FormerName { get; set; }

        [JsonProperty("title_2")]
        public string Title2 { get; set; }

        [JsonProperty("suffix_2")]
        public string Suffix2 { get; set; }

        [JsonProperty("marital_status")]
        public string MaritalStatus { get; set; }

        [JsonProperty("gives_anonymously")]
        public bool? GivesAnonymously { get; set; }

        [JsonProperty("requests_no_email")]
        public bool? RequestsNoEmail { get; set; }

        [JsonProperty("is_solicitor")]
        public bool? IsASolicitor { get; set; }

        [JsonProperty("no_valid_address")]
        public bool? NoValidAddresses { get; set; }

        [JsonProperty("inactive")]
        public bool? Inactive { get; set; }

        [JsonProperty("birthdate")]
        public EditConstituentInputBirthdateType Birthdate { get; set; }

        [JsonProperty("birthplace")]
        public string Birthplace { get; set; }

        [JsonProperty("ethnicity")]
        public string Ethnicity { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("income")]
        public string Income { get; set; }

        [JsonProperty("receipt_type")]
        public EditConstituentInputReceiptTypeType? ReceiptType { get; set; }

        [JsonProperty("religion")]
        public string Religion { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("num_employees")]
        public int? NumberOfEmployees { get; set; }

        [JsonProperty("matches_gifts")]
        public bool? MatchesGifts { get; set; }

        [JsonProperty("matching_gift_factor")]
        public double? MatchingGiftFactor { get; set; }

        [JsonProperty("matching_gift_per_gift_min")]
        public EditConstituentInputMatchingGiftPerGiftMinType MatchingGiftPerGiftMin { get; set; }

        [JsonProperty("matching_gift_per_gift_max")]
        public EditConstituentInputMatchingGiftPerGiftMaxType MatchingGiftPerGiftMax { get; set; }

        [JsonProperty("matching_gift_total_min")]
        public EditConstituentInputMatchingGiftTotalMinType MatchingGiftTotalMin { get; set; }

        [JsonProperty("matching_gift_total_max")]
        public EditConstituentInputMatchingGiftTotalMaxType MatchingGiftTotalMax { get; set; }

        [JsonProperty("matching_gift_notes")]
        public string MatchingGiftNotes { get; set; }

        [JsonProperty("deceased")]
        public bool? Deceased { get; set; }

        [JsonProperty("deceased_date")]
        public EditConstituentInputDeceasedDateType DeceasedDate { get; set; }

        [JsonProperty("is_memorial")]
        public bool? IsMemorial { get; set; }
    }

    public class EditConstituentInputBirthdateType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EditConstituentInputReceiptTypeType
    {
        [EnumMember(Value = "One receipt per gift")]
        OneReceiptPerGift,
        [EnumMember(Value = "Consolidated receipts")]
        ConsolidatedReceipts
    }

    public class EditConstituentInputMatchingGiftPerGiftMinType
    {
        [JsonProperty("value")]
        public double? MinMatchPerGift { get; set; }
    }

    public class EditConstituentInputMatchingGiftPerGiftMaxType
    {
        [JsonProperty("value")]
        public double? MaxMatchPerGift { get; set; }
    }

    public class EditConstituentInputMatchingGiftTotalMinType
    {
        [JsonProperty("value")]
        public double? MinMatchPerConstit { get; set; }
    }

    public class EditConstituentInputMatchingGiftTotalMaxType
    {
        [JsonProperty("value")]
        public double? MaxMatchPerConstit { get; set; }
    }

    public class EditConstituentInputDeceasedDateType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfAddressRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiAddressRead[] Value { get; set; }
    }

    public class ConstituentApiAddressRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_lines")]
        public string AddressLines { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }

        [JsonProperty("information_source")]
        public string InformationSource { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("cart")]
        public string CART { get; set; }

        [JsonProperty("lot")]
        public string LOT { get; set; }

        [JsonProperty("dpc")]
        public string DPC { get; set; }

        [JsonProperty("start")]
        public string ValidFrom { get; set; }

        [JsonProperty("end")]
        public string ValidTo { get; set; }

        [JsonProperty("preferred")]
        public bool Primary { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("do_not_mail")]
        public bool DoNotMail { get; set; }

        [JsonProperty("seasonal_start")]
        public ConstituentApiAddressReadSeasonalStartType SeasonalStart { get; set; }

        [JsonProperty("seasonal_end")]
        public ConstituentApiAddressReadSeasonalEndType SeasonalEnd { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiAddressReadSeasonalStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiAddressReadSeasonalEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfAliasRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiAliasRead[] Value { get; set; }
    }

    public class ConstituentApiAliasRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Alias { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ConstituentApiApiCollectionOfConstituentAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentAttachmentRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentAttachmentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public ConstituentApiConstituentAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailId { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiConstituentAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class ConstituentApiApiCollectionOfConstituentCodeRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentCodeRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentCodeRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("description")]
        public string ConstituentCode { get; set; }

        [JsonProperty("start")]
        public ConstituentApiConstituentCodeReadStartType Start { get; set; }

        [JsonProperty("end")]
        public ConstituentApiConstituentCodeReadEndType End { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentCodeReadStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConstituentCodeReadEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfConstituentCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentCustomFieldRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentCustomFieldRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public ConstituentApiConstituentCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("text_value")]
        public string TextValue { get; set; }

        [JsonProperty("number_value")]
        public int NumberValue { get; set; }

        [JsonProperty("date_value")]
        public string DateValue { get; set; }

        [JsonProperty("currency_value")]
        public double CurrencyValue { get; set; }

        [JsonProperty("boolean_value")]
        public bool BooleanValue { get; set; }

        [JsonProperty("codetableentry_value")]
        public string TableEntryValue { get; set; }

        [JsonProperty("constituentid_value")]
        public string ConstituentIdValue { get; set; }

        [JsonProperty("fuzzydate_value")]
        public ConstituentApiConstituentCustomFieldReadFuzzyDateValueType FuzzyDateValue { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiConstituentCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class ConstituentApiConstituentCustomFieldReadFuzzyDateValueType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfEducationRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiEducationRead[] Value { get; set; }
    }

    public class ConstituentApiEducationRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("school")]
        public string School { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("class_of")]
        public string ClassOf { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("date_entered")]
        public ConstituentApiEducationReadDateEnteredType DateEntered { get; set; }

        [JsonProperty("date_left")]
        public ConstituentApiEducationReadDateLeftType DateLeft { get; set; }

        [JsonProperty("date_graduated")]
        public ConstituentApiEducationReadDateGraduatedType DateGraduated { get; set; }

        [JsonProperty("degree")]
        public string Degree { get; set; }

        [JsonProperty("gpa")]
        public double GPA { get; set; }

        [JsonProperty("majors")]
        public string[] Majors { get; set; }

        [JsonProperty("minors")]
        public string[] Minors { get; set; }

        [JsonProperty("primary")]
        public bool IsPrimaryEducation { get; set; }

        [JsonProperty("campus")]
        public string Campus { get; set; }

        [JsonProperty("social_organization")]
        public string SocialOrganization { get; set; }

        [JsonProperty("known_name")]
        public string KnownName { get; set; }

        [JsonProperty("class_of_degree")]
        public string ClassOfDegree { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("faculty")]
        public string Faculty { get; set; }

        [JsonProperty("registration_number")]
        public string RegistrationNumber { get; set; }

        [JsonProperty("subject_of_study")]
        public string SubjectOfStudy { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiEducationReadDateEnteredType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiEducationReadDateLeftType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiEducationReadDateGraduatedType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfEmailAddressRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiEmailAddressRead[] Value { get; set; }
    }

    public class ConstituentApiEmailAddressRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public string EmailType { get; set; }

        [JsonProperty("address")]
        public string EmailAddress { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("do_not_email")]
        public bool DoNotEmail { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiApiCollectionOfFundraiserAssignmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiFundraiserAssignmentRead[] Value { get; set; }
    }

    public class ConstituentApiFundraiserAssignmentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("fundraiser_id")]
        public string FundraiserId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount")]
        public ConstituentApiFundraiserAssignmentReadAmountType Amount { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("fund_id")]
        public string FundId { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealId { get; set; }

        [JsonProperty("start")]
        public string StartDate { get; set; }

        [JsonProperty("end")]
        public string EndDate { get; set; }
    }

    public class ConstituentApiFundraiserAssignmentReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiApiCollectionOfMembershipRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiMembershipRead[] Value { get; set; }
    }

    public class ConstituentApiMembershipRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("program")]
        public string Program { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("standing")]
        public ConstituentApiMembershipReadStandingType Standing { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("joined")]
        public string Joined { get; set; }

        [JsonProperty("dues")]
        public ConstituentApiMembershipReadDuesType Dues { get; set; }

        [JsonProperty("members")]
        public ConstituentApiMembershipMemberRead[] Members { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiMembershipReadStandingType
    {
        New,
        Active,
        Lapsed,
        Dropped
    }

    public class ConstituentApiMembershipReadDuesType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiMembershipMemberRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("primary")]
        public bool IsPrimaryMember { get; set; }
    }

    public class ConstituentApiNameFormatSummaryRead
    {
        [JsonProperty("primary_addressee")]
        public ConstituentApiNameFormatSummaryReadPrimaryAddresseeType PrimaryAddressee { get; set; }

        [JsonProperty("primary_salutation")]
        public ConstituentApiNameFormatSummaryReadPrimarySalutationType PrimarySalutation { get; set; }

        [JsonProperty("additional_name_formats")]
        public ConstituentApiNameFormatRead[] AdditionalNameFormats { get; set; }
    }

    public class ConstituentApiNameFormatSummaryReadPrimaryAddresseeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary_type")]
        public ConstituentApiNameFormatSummaryReadPrimaryAddresseeTypeTypeType Type { get; set; }

        [JsonProperty("custom_format")]
        public bool CustomFormat { get; set; }

        [JsonProperty("configuration_id")]
        public string ConfigurationId { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiNameFormatSummaryReadPrimaryAddresseeTypeTypeType
    {
        Addressee,
        Salutation
    }

    public class ConstituentApiNameFormatSummaryReadPrimarySalutationType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary_type")]
        public ConstituentApiNameFormatSummaryReadPrimarySalutationTypeTypeType Type { get; set; }

        [JsonProperty("custom_format")]
        public bool CustomFormat { get; set; }

        [JsonProperty("configuration_id")]
        public string ConfigurationId { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiNameFormatSummaryReadPrimarySalutationTypeTypeType
    {
        Addressee,
        Salutation
    }

    public class ConstituentApiNameFormatRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("custom_format")]
        public bool CustomFormat { get; set; }

        [JsonProperty("configuration_id")]
        public string ConfigurationId { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }
    }

    public class ConstituentApiApiCollectionOfNoteRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiNoteRead[] Value { get; set; }
    }

    public class ConstituentApiNoteRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public ConstituentApiNoteReadDateType Date { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("text")]
        public string Note { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiNoteReadDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfOnlinePresenceRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiOnlinePresenceRead[] Value { get; set; }
    }

    public class ConstituentApiOnlinePresenceRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Link { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiApiCollectionOfPhoneRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiPhoneRead[] Value { get; set; }
    }

    public class ConstituentApiPhoneRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("do_not_call")]
        public bool DoNotCall { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiProfilePictureRead
    {
        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }
    }

    public class EditConstituentProfilePictureInput
    {
        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("document_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty("thumbnail_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ThumbnailId { get; set; }
    }

    public class ConstituentApiApiCollectionOfRelationshipRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiRelationshipRead[] Value { get; set; }
    }

    public class ConstituentApiRelationshipRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("relation_id")]
        public string RelationId { get; set; }

        [JsonProperty("reciprocal_relationship_id")]
        public string ReciprocalRelationshipId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("reciprocal_type")]
        public string ReciprocalType { get; set; }

        [JsonProperty("start")]
        public ConstituentApiRelationshipReadStartType Start { get; set; }

        [JsonProperty("end")]
        public ConstituentApiRelationshipReadEndType End { get; set; }

        [JsonProperty("is_spouse")]
        public bool IsSpouse { get; set; }

        [JsonProperty("is_constituent_head_of_household")]
        public bool IsConstituentHeadOfHousehold { get; set; }

        [JsonProperty("is_spouse_head_of_household")]
        public bool IsSpouseHeadOfHousehold { get; set; }

        [JsonProperty("comment")]
        public string Notes { get; set; }

        [JsonProperty("is_organization_contact")]
        public bool IsContact { get; set; }

        [JsonProperty("is_primary_business")]
        public bool IsPrimaryBusiness { get; set; }

        [JsonProperty("organization_contact_type")]
        public string ContactType { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiRelationshipReadStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiRelationshipReadEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConvertedConstituent
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConvertToConstituentInput
    {
    }

    public class ConstituentApiCreatedConstituentAttachment
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentAttachmentInput
    {
        [JsonProperty("parent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateConstituentAttachmentInputTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailId { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateConstituentAttachmentInputTypeType
    {
        Link,
        Physical
    }

    public class EditConstituentAttachmentInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class ConstituentApiCreatedConstituentCustomField
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentCustomFieldInput
    {
        [JsonProperty("parent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Category { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class EditConstituentCustomFieldInput
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class ConstituentApiDuplicateSearchResultCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiDuplicateSearchResult[] Value { get; set; }
    }

    public class ConstituentApiDuplicateSearchResult
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("formatted_address")]
        public string Address { get; set; }

        [JsonProperty("deceased")]
        public bool Deceased { get; set; }

        [JsonProperty("is_constituent")]
        public bool IsAConstituent { get; set; }

        [JsonProperty("constituent_id")]
        public string LookupId { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }
    }

    public class ConstituentApiApiCollectionOfSearchResultRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiSearchResultRead[] Value { get; set; }
    }

    public class ConstituentApiSearchResultRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("deceased")]
        public bool Deceased { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fundraiser_status")]
        public string FundraiserStatus { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum searchFieldInput
    {
        [EnumMember(Value = "lookup_id")]
        LookupId,
        [EnumMember(Value = "email_address")]
        EmailAddress
    }

    public class ConstituentApiCreatedConstituentEducation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentEducationInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("school", DefaultValueHandling = DefaultValueHandling.Include)]
        public string School { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("class_of")]
        public string ClassOf { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("date_entered")]
        public CreateConstituentEducationInputDateEnteredType DateEntered { get; set; }

        [JsonProperty("date_left")]
        public CreateConstituentEducationInputDateLeftType DateLeft { get; set; }

        [JsonProperty("date_graduated")]
        public CreateConstituentEducationInputDateGraduatedType DateGraduated { get; set; }

        [JsonProperty("degree")]
        public string Degree { get; set; }

        [JsonProperty("gpa")]
        public double? GPA { get; set; }

        [JsonProperty("subject_of_study")]
        public string SubjectOfStudy { get; set; }

        [JsonProperty("primary")]
        public bool? Primary { get; set; }

        [JsonProperty("majors")]
        public string[] Majors { get; set; }

        [JsonProperty("minors")]
        public string[] Minors { get; set; }

        [JsonProperty("campus")]
        public string Campus { get; set; }

        [JsonProperty("social_organization")]
        public string SocialOrganization { get; set; }

        [JsonProperty("known_name")]
        public string KnownName { get; set; }

        [JsonProperty("class_of_degree")]
        public string ClassOfDegree { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("faculty")]
        public string Faculty { get; set; }

        [JsonProperty("registration_number")]
        public string RegistrationNumber { get; set; }
    }

    public class CreateConstituentEducationInputDateEnteredType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class CreateConstituentEducationInputDateLeftType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class CreateConstituentEducationInputDateGraduatedType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class EditConstituentEducationInput
    {
        [JsonProperty("school")]
        public string School { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("class_of")]
        public string ClassOf { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("date_entered")]
        public EditConstituentEducationInputDateEnteredType DateEntered { get; set; }

        [JsonProperty("date_left")]
        public EditConstituentEducationInputDateLeftType DateLeft { get; set; }

        [JsonProperty("date_graduated")]
        public EditConstituentEducationInputDateGraduatedType DateGraduated { get; set; }

        [JsonProperty("degree")]
        public string Degree { get; set; }

        [JsonProperty("gpa")]
        public double? GPA { get; set; }

        [JsonProperty("subject_of_study")]
        public string SubjectOfStudy { get; set; }

        [JsonProperty("primary")]
        public bool? Primary { get; set; }

        [JsonProperty("majors")]
        public string[] Majors { get; set; }

        [JsonProperty("minors")]
        public string[] Minors { get; set; }

        [JsonProperty("campus")]
        public string Campus { get; set; }

        [JsonProperty("social_organization")]
        public string SocialOrganization { get; set; }

        [JsonProperty("known_name")]
        public string KnownName { get; set; }

        [JsonProperty("class_of_degree")]
        public string ClassOfDegree { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("faculty")]
        public string Faculty { get; set; }

        [JsonProperty("registration_number")]
        public string RegistrationNumber { get; set; }
    }

    public class EditConstituentEducationInputDateEnteredType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class EditConstituentEducationInputDateLeftType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class EditConstituentEducationInputDateGraduatedType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class ConstituentApiCreatedConstituentEmailAddress
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentEmailAddressInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmailType { get; set; }

        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmailAddress { get; set; }

        [JsonProperty("primary")]
        public bool? Primary { get; set; }

        [JsonProperty("do_not_email")]
        public bool? DoNotEmail { get; set; }

        [JsonProperty("inactive")]
        public bool? Inactive { get; set; }
    }

    public class EditConstituentEmailAddressInput
    {
        [JsonProperty("type")]
        public string EmailType { get; set; }

        [JsonProperty("address")]
        public string EmailAddress { get; set; }

        [JsonProperty("primary")]
        public bool? Primary { get; set; }

        [JsonProperty("do_not_email")]
        public bool? DoNotEmail { get; set; }

        [JsonProperty("inactive")]
        public bool? Inactive { get; set; }
    }

    public class ConstituentApiCreatedNameFormat
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentNameFormatInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("custom_format")]
        public bool? CustomNameFormat { get; set; }

        [JsonProperty("configuration_id")]
        public string Format { get; set; }

        [JsonProperty("formatted_name")]
        public string CustomName { get; set; }
    }

    public class EditConstituentNameFormatInput
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("custom_format")]
        public bool? CustomNameFormat { get; set; }

        [JsonProperty("configuration_id")]
        public string Format { get; set; }

        [JsonProperty("formatted_name")]
        public string CustomName { get; set; }
    }

    public class ConstituentApiCreatedConstituentNote
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentNoteInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("date", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateConstituentNoteInputDateType Date { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("text")]
        public string Note { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }
    }

    public class CreateConstituentNoteInputDateType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class EditConstituentNoteInput
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public EditConstituentNoteInputDateType Date { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("text")]
        public string Note { get; set; }
    }

    public class EditConstituentNoteInputDateType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class ConstituentApiCreatedConstituentOnlinePresence
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentOnlinePresenceInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Link { get; set; }

        [JsonProperty("primary")]
        public bool? Primary { get; set; }

        [JsonProperty("inactive")]
        public bool? Inactive { get; set; }
    }

    public class EditConstituentOnlinePresenceInput
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Link { get; set; }

        [JsonProperty("primary")]
        public bool? Primary { get; set; }

        [JsonProperty("inactive")]
        public bool? Inactive { get; set; }
    }

    public class ConstituentApiCreatedConstituentPhone
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentPhoneInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Number { get; set; }

        [JsonProperty("primary")]
        public bool? Primary { get; set; }

        [JsonProperty("do_not_call")]
        public bool? DoNotCall { get; set; }

        [JsonProperty("inactive")]
        public bool? Inactive { get; set; }
    }

    public class EditConstituentPhoneInput
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("primary")]
        public bool? Primary { get; set; }

        [JsonProperty("do_not_call")]
        public bool? DoNotCall { get; set; }

        [JsonProperty("inactive")]
        public bool? Inactive { get; set; }
    }

    public class CreateConstituentPrimaryNameFormatInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("primary_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateConstituentPrimaryNameFormatInputTypeType Type { get; set; }

        [JsonProperty("custom_format")]
        public bool? CustomNameFormat { get; set; }

        [JsonProperty("configuration_id")]
        public string Format { get; set; }

        [JsonProperty("formatted_name")]
        public string CustomName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateConstituentPrimaryNameFormatInputTypeType
    {
        Addressee,
        Salutation
    }

    public class EditConstituentPrimaryNameFormatInput
    {
        [JsonProperty("custom_format")]
        public bool? CustomNameFormat { get; set; }

        [JsonProperty("configuration_id")]
        public string Format { get; set; }

        [JsonProperty("formatted_name")]
        public string CustomName { get; set; }
    }

    public class EditConstituentRelationshipInput
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("reciprocal_type")]
        public string ReciprocalType { get; set; }

        [JsonProperty("start")]
        public EditConstituentRelationshipInputStartType Start { get; set; }

        [JsonProperty("end")]
        public EditConstituentRelationshipInputEndType End { get; set; }

        [JsonProperty("is_spouse")]
        public bool? IsSpouse { get; set; }

        [JsonProperty("is_constituent_head_of_household")]
        public bool? IsConstituentHeadOfHousehold { get; set; }

        [JsonProperty("is_spouse_head_of_household")]
        public bool? IsSpouseHeadOfHousehold { get; set; }

        [JsonProperty("comment")]
        public string Notes { get; set; }

        [JsonProperty("is_organization_contact")]
        public bool? IsContact { get; set; }

        [JsonProperty("is_primary_business")]
        public bool? IsPrimaryBusiness { get; set; }

        [JsonProperty("organization_contact_type")]
        public string ContactType { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }
    }

    public class EditConstituentRelationshipInputStartType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class EditConstituentRelationshipInputEndType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class ConstituentApiCreatedIndividualConstituent
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateIndividualConstituentInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateIndividualConstituentInputTypeType Type { get; set; } = CreateIndividualConstituentInputTypeType.Individual;

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first")]
        public string FirstName { get; set; }

        [JsonProperty("last", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("address")]
        public CreateIndividualConstituentInputAddressType Address { get; set; }

        [JsonProperty("phone")]
        public CreateIndividualConstituentInputPhoneType Phone { get; set; }

        [JsonProperty("email")]
        public CreateIndividualConstituentInputEmailType Email { get; set; }

        [JsonProperty("online_presence")]
        public CreateIndividualConstituentInputOnlinePresenceType OnlinePresence { get; set; }

        [JsonProperty("preferred_name")]
        public string PreferredName { get; set; }

        [JsonProperty("middle")]
        public string MiddleName { get; set; }

        [JsonProperty("former_name")]
        public string FormerName { get; set; }

        [JsonProperty("title_2")]
        public string Title2 { get; set; }

        [JsonProperty("suffix_2")]
        public string Suffix2 { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("marital_status")]
        public string MaritalStatus { get; set; }

        [JsonProperty("gives_anonymously")]
        public bool? GivesAnonymously { get; set; }

        [JsonProperty("requests_no_email")]
        public bool? RequestsNoEmail { get; set; }

        [JsonProperty("is_solicitor")]
        public bool? IsASolicitor { get; set; }

        [JsonProperty("no_valid_address")]
        public bool? NoValidAddresses { get; set; }

        [JsonProperty("birthdate")]
        public CreateIndividualConstituentInputBirthdateType Birthdate { get; set; }

        [JsonProperty("birthplace")]
        public string Birthplace { get; set; }

        [JsonProperty("ethnicity")]
        public string Ethnicity { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("income")]
        public string Income { get; set; }

        [JsonProperty("receipt_type")]
        public CreateIndividualConstituentInputReceiptTypeType? ReceiptType { get; set; }

        [JsonProperty("religion")]
        public string Religion { get; set; }

        [JsonProperty("primary_addressee")]
        public CreateIndividualConstituentInputPrimaryAddresseeType PrimaryAddressee { get; set; }

        [JsonProperty("primary_salutation")]
        public CreateIndividualConstituentInputPrimarySalutationType PrimarySalutation { get; set; }

        [JsonProperty("is_memorial")]
        public bool? IsMemorial { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateIndividualConstituentInputTypeType
    {
        Individual
    }

    public class CreateIndividualConstituentInputAddressType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_lines")]
        public string Lines { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class CreateIndividualConstituentInputPhoneType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Number { get; set; }

        [JsonProperty("primary")]
        public bool? IsPrimary { get; set; }
    }

    public class CreateIndividualConstituentInputEmailType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Address { get; set; }

        [JsonProperty("primary")]
        public bool? IsPrimary { get; set; }
    }

    public class CreateIndividualConstituentInputOnlinePresenceType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Address { get; set; }

        [JsonProperty("primary")]
        public bool? IsPrimary { get; set; }
    }

    public class CreateIndividualConstituentInputBirthdateType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateIndividualConstituentInputReceiptTypeType
    {
        [EnumMember(Value = "One receipt per gift")]
        OneReceiptPerGift,
        [EnumMember(Value = "Consolidated receipts")]
        ConsolidatedReceipts
    }

    public class CreateIndividualConstituentInputPrimaryAddresseeType
    {
        [JsonProperty("custom_format")]
        public bool? CustomAddressee { get; set; }

        [JsonProperty("configuration_id")]
        public string AddresseeFormat { get; set; }

        [JsonProperty("formatted_name")]
        public string AddresseeCustomName { get; set; }
    }

    public class CreateIndividualConstituentInputPrimarySalutationType
    {
        [JsonProperty("custom_format")]
        public bool? CustomSalutation { get; set; }

        [JsonProperty("configuration_id")]
        public string SalutationFormat { get; set; }

        [JsonProperty("formatted_name")]
        public string SalutationCustomName { get; set; }
    }

    public class ConstituentApiCreatedIndividualRelationship
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateIndividualRelationshipInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("relation_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RelationId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("reciprocal_type")]
        public string ReciprocalType { get; set; }

        [JsonProperty("start")]
        public CreateIndividualRelationshipInputStartType Start { get; set; }

        [JsonProperty("end")]
        public CreateIndividualRelationshipInputEndType End { get; set; }

        [JsonProperty("is_spouse")]
        public bool? IsSpouse { get; set; }

        [JsonProperty("is_constituent_head_of_household")]
        public bool? IsConstituentHeadOfHousehold { get; set; }

        [JsonProperty("is_spouse_head_of_household")]
        public bool? IsSpouseHeadOfHousehold { get; set; }

        [JsonProperty("comment")]
        public string Notes { get; set; }
    }

    public class CreateIndividualRelationshipInputStartType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class CreateIndividualRelationshipInputEndType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class ConstituentApiCreatedOrganizationConstituent
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateOrganizationConstituentInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateOrganizationConstituentInputTypeType Type { get; set; } = CreateOrganizationConstituentInputTypeType.Organization;

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("address")]
        public CreateOrganizationConstituentInputAddressType Address { get; set; }

        [JsonProperty("phone")]
        public CreateOrganizationConstituentInputPhoneType Phone { get; set; }

        [JsonProperty("email")]
        public CreateOrganizationConstituentInputEmailType Email { get; set; }

        [JsonProperty("online_presence")]
        public CreateOrganizationConstituentInputOnlinePresenceType OnlinePresence { get; set; }

        [JsonProperty("gives_anonymously")]
        public bool? GivesAnonymously { get; set; }

        [JsonProperty("requests_no_email")]
        public bool? RequestsNoEmail { get; set; }

        [JsonProperty("is_solicitor")]
        public bool? IsASolicitor { get; set; }

        [JsonProperty("no_valid_address")]
        public bool? NoValidAddresses { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("income")]
        public string Income { get; set; }

        [JsonProperty("receipt_type")]
        public CreateOrganizationConstituentInputReceiptTypeType? ReceiptType { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("num_employees")]
        public int? NumberOfEmployees { get; set; }

        [JsonProperty("matches_gifts")]
        public bool? MatchesGifts { get; set; }

        [JsonProperty("matching_gift_factor")]
        public double? MatchingGiftFactor { get; set; }

        [JsonProperty("matching_gift_per_gift_min")]
        public CreateOrganizationConstituentInputMatchingGiftPerGiftMinType MatchingGiftPerGiftMin { get; set; }

        [JsonProperty("matching_gift_per_gift_max")]
        public CreateOrganizationConstituentInputMatchingGiftPerGiftMaxType MatchingGiftPerGiftMax { get; set; }

        [JsonProperty("matching_gift_total_min")]
        public CreateOrganizationConstituentInputMatchingGiftTotalMinType MatchingGiftTotalMin { get; set; }

        [JsonProperty("matching_gift_total_max")]
        public CreateOrganizationConstituentInputMatchingGiftTotalMaxType MatchingGiftTotalMax { get; set; }

        [JsonProperty("matching_gift_notes")]
        public string MatchingGiftNotes { get; set; }

        [JsonProperty("is_memorial")]
        public bool? IsMemorial { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOrganizationConstituentInputTypeType
    {
        Organization
    }

    public class CreateOrganizationConstituentInputAddressType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_lines")]
        public string Lines { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class CreateOrganizationConstituentInputPhoneType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Number { get; set; }

        [JsonProperty("primary")]
        public bool? IsPrimary { get; set; }
    }

    public class CreateOrganizationConstituentInputEmailType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Address { get; set; }

        [JsonProperty("primary")]
        public bool? IsPrimary { get; set; }
    }

    public class CreateOrganizationConstituentInputOnlinePresenceType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Address { get; set; }

        [JsonProperty("primary")]
        public bool? IsPrimary { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOrganizationConstituentInputReceiptTypeType
    {
        [EnumMember(Value = "One receipt per gift")]
        OneReceiptPerGift,
        [EnumMember(Value = "Consolidated receipts")]
        ConsolidatedReceipts
    }

    public class CreateOrganizationConstituentInputMatchingGiftPerGiftMinType
    {
        [JsonProperty("value")]
        public double? MinMatchPerGift { get; set; }
    }

    public class CreateOrganizationConstituentInputMatchingGiftPerGiftMaxType
    {
        [JsonProperty("value")]
        public double? MaxMatchPerGift { get; set; }
    }

    public class CreateOrganizationConstituentInputMatchingGiftTotalMinType
    {
        [JsonProperty("value")]
        public double? MinMatchPerConstit { get; set; }
    }

    public class CreateOrganizationConstituentInputMatchingGiftTotalMaxType
    {
        [JsonProperty("value")]
        public double? MaxMatchPerConstit { get; set; }
    }

    public class ConstituentApiCreatedOrganizationRelationship
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateOrganizationRelationshipInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("relation_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RelationId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("reciprocal_type")]
        public string ReciprocalType { get; set; }

        [JsonProperty("start")]
        public CreateOrganizationRelationshipInputStartType Start { get; set; }

        [JsonProperty("end")]
        public CreateOrganizationRelationshipInputEndType End { get; set; }

        [JsonProperty("is_organization_contact")]
        public bool? IsContact { get; set; }

        [JsonProperty("organization_contact_type")]
        public string ContactType { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("is_primary_business")]
        public bool? IsPrimaryBusiness { get; set; }

        [JsonProperty("comment")]
        public string Notes { get; set; }
    }

    public class CreateOrganizationRelationshipInputStartType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class CreateOrganizationRelationshipInputEndType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class FundraisingApiCreatedFundraiserAssignment
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateFundraiserAssignmentInput
    {
        [JsonProperty("fundraiser_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FundraiserId { get; set; }

        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("start")]
        public string AssignmentStarts { get; set; }

        [JsonProperty("end")]
        public string AssignmentEnds { get; set; }

        [JsonProperty("amount")]
        public CreateFundraiserAssignmentInputAmountType Amount { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("fund_id")]
        public string FundId { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealId { get; set; }
    }

    public class CreateFundraiserAssignmentInputAmountType
    {
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Amount { get; set; }
    }

    public class FundraisingApiApiCollectionOfFundraiserAssignmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiFundraiserAssignmentRead[] Value { get; set; }
    }

    public class FundraisingApiFundraiserAssignmentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("start")]
        public string AssignmentStarts { get; set; }

        [JsonProperty("end")]
        public string AssignmentEnds { get; set; }

        [JsonProperty("amount")]
        public FundraisingApiFundraiserAssignmentReadAmountType Amount { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("fund_id")]
        public string FundId { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealId { get; set; }
    }

    public class FundraisingApiFundraiserAssignmentReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class NXTDataIntegrationApiConstituentIdMap
    {
        [JsonProperty("system_record_id")]
        public int Id { get; set; }
    }

    public class NXTDataIntegrationApiConstituentSearchResultCollection
    {
        [JsonProperty("results")]
        public NXTDataIntegrationApiConstituentSearchResult[] Results { get; set; }
    }

    public class NXTDataIntegrationApiConstituentSearchResult
    {
        [JsonProperty("record_id")]
        public int Id { get; set; }

        [JsonProperty("constituent_id")]
        public string LookupId { get; set; }

        [JsonProperty("key_indicator")]
        public string KeyIndicator { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("preferred_name")]
        public string PreferredName { get; set; }

        [JsonProperty("maiden_name")]
        public string FormerName { get; set; }

        [JsonProperty("title1")]
        public string Title1 { get; set; }

        [JsonProperty("suffix1")]
        public string Suffix1 { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birth_date")]
        public NXTDataIntegrationApiConstituentSearchResultBirthdateType Birthdate { get; set; }

        [JsonProperty("spouse_first_name")]
        public string SpouseFirstName { get; set; }

        [JsonProperty("spouse_last_name")]
        public string SpouseLastName { get; set; }

        [JsonProperty("org_name")]
        public string OrganizationName { get; set; }

        [JsonProperty("address_block")]
        public string AddressBlock { get; set; }

        [JsonProperty("address_city_state")]
        public string CityAndState { get; set; }

        [JsonProperty("address_post_code")]
        public string PostalCode { get; set; }

        [JsonProperty("primary_email")]
        public string PrimaryEmailAddress { get; set; }

        [JsonProperty("primary_phone")]
        public string PrimaryPhoneNumber { get; set; }

        [JsonProperty("matched_alias")]
        public string MatchedAlias { get; set; }

        [JsonProperty("matched_email")]
        public string MatchedEmail { get; set; }

        [JsonProperty("matched_phone")]
        public string MatchedPhone { get; set; }

        [JsonProperty("is_constituent")]
        public bool IsAConstituent { get; set; }

        [JsonProperty("is_deceased")]
        public bool IsDeceased { get; set; }

        [JsonProperty("is_inactive")]
        public bool IsInactive { get; set; }
    }

    public class NXTDataIntegrationApiConstituentSearchResultBirthdateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class NXTDataIntegrationApiCreatedConstituentTribute
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateConstituentTributeInput
    {
        [JsonProperty("constituent_record_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ConstituentId { get; set; }

        [JsonProperty("tribute_type_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int TributeType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start_date")]
        public CreateConstituentTributeInputStartType Start { get; set; }

        [JsonProperty("end_date")]
        public CreateConstituentTributeInputEndType End { get; set; }

        [JsonProperty("default_fund_id")]
        public int? DefaultFundId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("is_active")]
        public bool? Active { get; set; }
    }

    public class CreateConstituentTributeInputStartType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class CreateConstituentTributeInputEndType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class NXTDataIntegrationApiTribute
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("constituent_record_id")]
        public int ConstituentId { get; set; }

        [JsonProperty("tribute_type_name")]
        public string TributeType { get; set; }

        [JsonProperty("tribute_type_id")]
        public int TributeTypeId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start_date")]
        public NXTDataIntegrationApiTributeStartType Start { get; set; }

        [JsonProperty("end_date")]
        public NXTDataIntegrationApiTributeEndType End { get; set; }

        [JsonProperty("default_fund_id")]
        public int DefaultFundId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("is_active")]
        public bool Active { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class NXTDataIntegrationApiTributeStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class NXTDataIntegrationApiTributeEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class NXTDataIntegrationApiCreatedTributeAcknowledgee
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateTributeAcknowledgeeInput
    {
        [JsonProperty("tribute_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int TributeId { get; set; }

        [JsonProperty("relationship_id")]
        public int? RelationshipId { get; set; }

        [JsonProperty("letter_id")]
        public int? LetterId { get; set; }
    }

    public class NXTDataIntegrationApiTributeCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public NXTDataIntegrationApiTribute[] Value { get; set; }
    }

    public class NXTDataIntegrationApiTributeAcknowledgeeCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public NXTDataIntegrationApiTributeAcknowledgee[] Value { get; set; }
    }

    public class NXTDataIntegrationApiTributeAcknowledgee
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("tribute_id")]
        public int TributeId { get; set; }

        [JsonProperty("relationships_id")]
        public int RelationshipId { get; set; }

        [JsonProperty("letter")]
        public int LetterId { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudconstituent;

    public partial class WorkflowManagedActions
    {
        public BlackbaudconstituentActions Blackbaudconstituent(string connectionId) => new BlackbaudconstituentActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudconstituentTriggers Blackbaudconstituent(string connectionId) => new BlackbaudconstituentTriggers(connectionId);
    }
}