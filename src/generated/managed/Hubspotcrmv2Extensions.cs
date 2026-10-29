//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotcrmv2
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Hubspotcrmv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ArchiveABatchOfCompaniesById(Expression<Func<ArchiveABatchOfCompaniesByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/companies/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<ListResponse, ApiConnectionActionConfiguration> List(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<ListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/companies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<ListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<CreateResponse, ApiConnectionActionConfiguration> Create(Expression<Func<CreateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/companies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<ReadResponse, ApiConnectionActionConfiguration> Read(Expression<Func<string>> companyId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<ReadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/companies/{0}", __workflow_companyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                return new ApiConnectionAction<ReadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Archive(Expression<Func<string>> companyId)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/companies/{0}", __workflow_companyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<UpdateResponse, ApiConnectionActionConfiguration> Update(Expression<Func<string>> companyId, Expression<Func<UpdateInput>> body, Expression<Func<string>> idProperty = null)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<UpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/companies/{0}", __workflow_companyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoCompaniesWithSameTypeResponse, ApiConnectionActionConfiguration> MergeTwoCompaniesWithSameType(Expression<Func<MergeTwoCompaniesWithSameTypeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MergeTwoCompaniesWithSameTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/companies/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MergeTwoCompaniesWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GdprDelete(Expression<Func<GdprDeleteInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/companies/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsCompaniesSearchResponse, ApiConnectionActionConfiguration> PostCrmV3ObjectsCompaniesSearch(Expression<Func<PostCrmV3ObjectsCompaniesSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostCrmV3ObjectsCompaniesSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/companies/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostCrmV3ObjectsCompaniesSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ArchiveABatchOfContactsById(Expression<Func<ArchiveABatchOfContactsByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/contacts/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List16Response, ApiConnectionActionConfiguration> List16(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List16Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<List16Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create17Response, ApiConnectionActionConfiguration> Create17(Expression<Func<Create17Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Create17Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Create17Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read18Response, ApiConnectionActionConfiguration> Read18(Expression<Func<string>> contactId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Read18Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<Read18Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Archive19(Expression<Func<string>> contactId)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update20Response, ApiConnectionActionConfiguration> Update20(Expression<Func<string>> contactId, Expression<Func<Update20Input>> body)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Update20Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Update20Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoContactsWithSameTypeResponse, ApiConnectionActionConfiguration> MergeTwoContactsWithSameType(Expression<Func<MergeTwoContactsWithSameTypeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MergeTwoContactsWithSameTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/contacts/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MergeTwoContactsWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GdprDelete22(Expression<Func<GdprDelete22Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/contacts/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsContactsSearchResponse, ApiConnectionActionConfiguration> PostCrmV3ObjectsContactsSearch(Expression<Func<PostCrmV3ObjectsContactsSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostCrmV3ObjectsContactsSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/contacts/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostCrmV3ObjectsContactsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ArchiveABatchOfDealsById(Expression<Func<ArchiveABatchOfDealsByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/deals/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List28Response, ApiConnectionActionConfiguration> List28(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List28Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/deals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<List28Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create29Response, ApiConnectionActionConfiguration> Create29(Expression<Func<Create29Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Create29Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/deals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Create29Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read30Response, ApiConnectionActionConfiguration> Read30(Expression<Func<string>> dealId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var __workflow_dealId = WorkflowExpression.Compile(dealId, nameof(dealId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Read30Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/deals/{0}", __workflow_dealId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                return new ApiConnectionAction<Read30Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Archive31(Expression<Func<string>> dealId)
        {
            var __workflow_dealId = WorkflowExpression.Compile(dealId, nameof(dealId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/deals/{0}", __workflow_dealId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update32Response, ApiConnectionActionConfiguration> Update32(Expression<Func<string>> dealId, Expression<Func<Update32Input>> body, Expression<Func<string>> idProperty = null)
        {
            var __workflow_dealId = WorkflowExpression.Compile(dealId, nameof(dealId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Update32Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/deals/{0}", __workflow_dealId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Update32Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoDealsWithSameTypeResponse, ApiConnectionActionConfiguration> MergeTwoDealsWithSameType(Expression<Func<MergeTwoDealsWithSameTypeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MergeTwoDealsWithSameTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/deals/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MergeTwoDealsWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GdprDelete34(Expression<Func<GdprDelete34Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/deals/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsDealsSearchResponse, ApiConnectionActionConfiguration> PostCrmV3ObjectsDealsSearch(Expression<Func<PostCrmV3ObjectsDealsSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostCrmV3ObjectsDealsSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/deals/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostCrmV3ObjectsDealsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ArchiveABatchOfFeesById(Expression<Func<ArchiveABatchOfFeesByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/fees/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read40Response, ApiConnectionActionConfiguration> Read40(Expression<Func<string>> feeId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var __workflow_feeId = WorkflowExpression.Compile(feeId, nameof(feeId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Read40Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/fees/{0}", __workflow_feeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                return new ApiConnectionAction<Read40Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Archive41(Expression<Func<string>> feeId)
        {
            var __workflow_feeId = WorkflowExpression.Compile(feeId, nameof(feeId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/fees/{0}", __workflow_feeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update42Response, ApiConnectionActionConfiguration> Update42(Expression<Func<string>> feeId, Expression<Func<Update42Input>> body, Expression<Func<string>> idProperty = null)
        {
            var __workflow_feeId = WorkflowExpression.Compile(feeId, nameof(feeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Update42Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/fees/{0}", __workflow_feeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Update42Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List43Response, ApiConnectionActionConfiguration> List43(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List43Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/fees";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<List43Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create44Response, ApiConnectionActionConfiguration> Create44(Expression<Func<Create44Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Create44Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/fees";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Create44Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoFeesWithSameTypeResponse, ApiConnectionActionConfiguration> MergeTwoFeesWithSameType(Expression<Func<MergeTwoFeesWithSameTypeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MergeTwoFeesWithSameTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/fees/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MergeTwoFeesWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GdprDelete46(Expression<Func<GdprDelete46Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/fees/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsFeesSearchResponse, ApiConnectionActionConfiguration> PostCrmV3ObjectsFeesSearch(Expression<Func<PostCrmV3ObjectsFeesSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostCrmV3ObjectsFeesSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/fees/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostCrmV3ObjectsFeesSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ArchiveABatchOfGoalTargetsById(Expression<Func<ArchiveABatchOfGoalTargetsByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/goal_targets/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read52Response, ApiConnectionActionConfiguration> Read52(Expression<Func<string>> goalTargetId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var __workflow_goalTargetId = WorkflowExpression.Compile(goalTargetId, nameof(goalTargetId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Read52Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/goal_targets/{0}", __workflow_goalTargetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                return new ApiConnectionAction<Read52Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Archive53(Expression<Func<string>> goalTargetId)
        {
            var __workflow_goalTargetId = WorkflowExpression.Compile(goalTargetId, nameof(goalTargetId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/goal_targets/{0}", __workflow_goalTargetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update54Response, ApiConnectionActionConfiguration> Update54(Expression<Func<string>> goalTargetId, Expression<Func<Update54Input>> body, Expression<Func<string>> idProperty = null)
        {
            var __workflow_goalTargetId = WorkflowExpression.Compile(goalTargetId, nameof(goalTargetId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Update54Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/goal_targets/{0}", __workflow_goalTargetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Update54Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List55Response, ApiConnectionActionConfiguration> List55(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List55Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/goal_targets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<List55Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create56Response, ApiConnectionActionConfiguration> Create56(Expression<Func<Create56Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Create56Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/goal_targets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Create56Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoGoalTargetsWithSameTypeResponse, ApiConnectionActionConfiguration> MergeTwoGoalTargetsWithSameType(Expression<Func<MergeTwoGoalTargetsWithSameTypeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MergeTwoGoalTargetsWithSameTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/goal_targets/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MergeTwoGoalTargetsWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GdprDelete58(Expression<Func<GdprDelete58Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/goal_targets/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsGoalTargetsSearchResponse, ApiConnectionActionConfiguration> PostCrmV3ObjectsGoalTargetsSearch(Expression<Func<PostCrmV3ObjectsGoalTargetsSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostCrmV3ObjectsGoalTargetsSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/goal_targets/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostCrmV3ObjectsGoalTargetsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ArchiveABatchOfLineItemsById(Expression<Func<ArchiveABatchOfLineItemsByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/line_items/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List64Response, ApiConnectionActionConfiguration> List64(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List64Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/line_items";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<List64Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create65Response, ApiConnectionActionConfiguration> Create65(Expression<Func<Create65Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Create65Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/line_items";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Create65Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read66Response, ApiConnectionActionConfiguration> Read66(Expression<Func<string>> lineItemId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var __workflow_lineItemId = WorkflowExpression.Compile(lineItemId, nameof(lineItemId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Read66Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/line_items/{0}", __workflow_lineItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                return new ApiConnectionAction<Read66Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Archive67(Expression<Func<string>> lineItemId)
        {
            var __workflow_lineItemId = WorkflowExpression.Compile(lineItemId, nameof(lineItemId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/line_items/{0}", __workflow_lineItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update68Response, ApiConnectionActionConfiguration> Update68(Expression<Func<string>> lineItemId, Expression<Func<Update68Input>> body, Expression<Func<string>> idProperty = null)
        {
            var __workflow_lineItemId = WorkflowExpression.Compile(lineItemId, nameof(lineItemId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Update68Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/line_items/{0}", __workflow_lineItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Update68Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoLineItemsWithSameTypeResponse, ApiConnectionActionConfiguration> MergeTwoLineItemsWithSameType(Expression<Func<MergeTwoLineItemsWithSameTypeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MergeTwoLineItemsWithSameTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/line_items/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MergeTwoLineItemsWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GdprDelete70(Expression<Func<GdprDelete70Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/line_items/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsLineItemsSearchResponse, ApiConnectionActionConfiguration> PostCrmV3ObjectsLineItemsSearch(Expression<Func<PostCrmV3ObjectsLineItemsSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostCrmV3ObjectsLineItemsSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/line_items/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostCrmV3ObjectsLineItemsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<GetAPageOfOwnersResponse, ApiConnectionActionConfiguration> GetAPageOfOwners(Expression<Func<string>> email, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<GetAPageOfOwnersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/owners/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<GetAPageOfOwnersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<ReadAnOwnerByGivenidOruseridResponse, ApiConnectionActionConfiguration> ReadAnOwnerByGivenidOruserid(Expression<Func<string>> ownerId, Expression<Func<string>> idProperty = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_ownerId = WorkflowExpression.Compile(ownerId, nameof(ownerId), required: true);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<ReadAnOwnerByGivenidOruseridResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/owners/{0}", __workflow_ownerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<ReadAnOwnerByGivenidOruseridResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ArchiveABatchOfProductsById(Expression<Func<ArchiveABatchOfProductsByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/products/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List78Response, ApiConnectionActionConfiguration> List78(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List78Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/products";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<List78Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create79Response, ApiConnectionActionConfiguration> Create79(Expression<Func<Create79Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Create79Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/products";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Create79Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read80Response, ApiConnectionActionConfiguration> Read80(Expression<Func<string>> productId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var __workflow_productId = WorkflowExpression.Compile(productId, nameof(productId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Read80Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/products/{0}", __workflow_productId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                return new ApiConnectionAction<Read80Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Archive81(Expression<Func<string>> productId)
        {
            var __workflow_productId = WorkflowExpression.Compile(productId, nameof(productId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/products/{0}", __workflow_productId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update82Response, ApiConnectionActionConfiguration> Update82(Expression<Func<string>> productId, Expression<Func<Update82Input>> body, Expression<Func<string>> idProperty = null)
        {
            var __workflow_productId = WorkflowExpression.Compile(productId, nameof(productId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Update82Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/products/{0}", __workflow_productId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Update82Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoProductsWithSameTypeResponse, ApiConnectionActionConfiguration> MergeTwoProductsWithSameType(Expression<Func<MergeTwoProductsWithSameTypeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MergeTwoProductsWithSameTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/products/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MergeTwoProductsWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GdprDelete84(Expression<Func<GdprDelete84Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/products/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsProductsSearchResponse, ApiConnectionActionConfiguration> PostCrmV3ObjectsProductsSearch(Expression<Func<PostCrmV3ObjectsProductsSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostCrmV3ObjectsProductsSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/products/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostCrmV3ObjectsProductsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ArchiveABatchOfObjectsById(Expression<Func<string>> objectType, Expression<Func<ArchiveABatchOfObjectsByIdInput>> body)
        {
            var __workflow_objectType = WorkflowExpression.Compile(objectType, nameof(objectType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/{0}/batch/archive", __workflow_objectType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<ReadObjectResponse, ApiConnectionActionConfiguration> ReadObject(Expression<Func<string>> objectType, Expression<Func<string>> objectId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var __workflow_objectType = WorkflowExpression.Compile(objectType, nameof(objectType), required: true);
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<ReadObjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/{0}/{1}", __workflow_objectType.WithUrlEncoding(1), __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                return new ApiConnectionAction<ReadObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ArchiveObjectId(Expression<Func<string>> objectType, Expression<Func<string>> objectId)
        {
            var __workflow_objectType = WorkflowExpression.Compile(objectType, nameof(objectType), required: true);
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/{0}/{1}", __workflow_objectType.WithUrlEncoding(1), __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<UpdateObjectIdResponse, ApiConnectionActionConfiguration> UpdateObjectId(Expression<Func<string>> objectType, Expression<Func<string>> objectId, Expression<Func<UpdateObjectIdInput>> body, Expression<Func<string>> idProperty = null)
        {
            var __workflow_objectType = WorkflowExpression.Compile(objectType, nameof(objectType), required: true);
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<UpdateObjectIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/{0}/{1}", __workflow_objectType.WithUrlEncoding(1), __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateObjectIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<ListObjectResponse, ApiConnectionActionConfiguration> ListObject(Expression<Func<string>> objectType, Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectType = WorkflowExpression.Compile(objectType, nameof(objectType), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<ListObjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/{0}", __workflow_objectType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<ListObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<CreateObjectIdResponse, ApiConnectionActionConfiguration> CreateObjectId(Expression<Func<string>> objectType, Expression<Func<CreateObjectIdInput>> body)
        {
            var __workflow_objectType = WorkflowExpression.Compile(objectType, nameof(objectType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateObjectIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/{0}", __workflow_objectType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateObjectIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoObjectsWithSameTypeResponse, ApiConnectionActionConfiguration> MergeTwoObjectsWithSameType(Expression<Func<string>> objectType, Expression<Func<MergeTwoObjectsWithSameTypeInput>> body)
        {
            var __workflow_objectType = WorkflowExpression.Compile(objectType, nameof(objectType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MergeTwoObjectsWithSameTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/{0}/merge", __workflow_objectType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MergeTwoObjectsWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GdprDeleteObjectType(Expression<Func<string>> objectType, Expression<Func<GdprDeleteObjectTypeInput>> body)
        {
            var __workflow_objectType = WorkflowExpression.Compile(objectType, nameof(objectType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/{0}/gdpr-delete", __workflow_objectType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsObjectTypeSearchResponse, ApiConnectionActionConfiguration> PostCrmV3ObjectsObjectTypeSearch(Expression<Func<string>> objectType, Expression<Func<PostCrmV3ObjectsObjectTypeSearchInput>> body)
        {
            var __workflow_objectType = WorkflowExpression.Compile(objectType, nameof(objectType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostCrmV3ObjectsObjectTypeSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/{0}/search", __workflow_objectType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostCrmV3ObjectsObjectTypeSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ArchiveABatchOfDiscountsById(Expression<Func<ArchiveABatchOfDiscountsByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/discounts/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read16Response, ApiConnectionActionConfiguration> Read16(Expression<Func<string>> discountId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var __workflow_discountId = WorkflowExpression.Compile(discountId, nameof(discountId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Read16Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/discounts/{0}", __workflow_discountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                return new ApiConnectionAction<Read16Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Archive17(Expression<Func<string>> discountId)
        {
            var __workflow_discountId = WorkflowExpression.Compile(discountId, nameof(discountId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/discounts/{0}", __workflow_discountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update18Response, ApiConnectionActionConfiguration> Update18(Expression<Func<string>> discountId, Expression<Func<Update18Input>> body, Expression<Func<string>> idProperty = null)
        {
            var __workflow_discountId = WorkflowExpression.Compile(discountId, nameof(discountId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Update18Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/discounts/{0}", __workflow_discountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Update18Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List19Response, ApiConnectionActionConfiguration> List19(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List19Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/discounts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<List19Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create20Response, ApiConnectionActionConfiguration> Create20(Expression<Func<Create20Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Create20Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/discounts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Create20Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoDiscountsWithSameTypeResponse, ApiConnectionActionConfiguration> MergeTwoDiscountsWithSameType(Expression<Func<MergeTwoDiscountsWithSameTypeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MergeTwoDiscountsWithSameTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/discounts/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MergeTwoDiscountsWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GdprDeleteDiscounts(Expression<Func<GdprDeleteDiscountsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/discounts/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsDiscountsSearchResponse, ApiConnectionActionConfiguration> PostCrmV3ObjectsDiscountsSearch(Expression<Func<PostCrmV3ObjectsDiscountsSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostCrmV3ObjectsDiscountsSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/discounts/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostCrmV3ObjectsDiscountsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ArchiveABatchOfFeedbackSubmissionsById(Expression<Func<ArchiveABatchOfFeedbackSubmissionsByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/feedback_submissions/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read28Response, ApiConnectionActionConfiguration> Read28(Expression<Func<string>> feedbackSubmissionId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var __workflow_feedbackSubmissionId = WorkflowExpression.Compile(feedbackSubmissionId, nameof(feedbackSubmissionId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Read28Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/feedback_submissions/{0}", __workflow_feedbackSubmissionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                return new ApiConnectionAction<Read28Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Archive29(Expression<Func<string>> feedbackSubmissionId)
        {
            var __workflow_feedbackSubmissionId = WorkflowExpression.Compile(feedbackSubmissionId, nameof(feedbackSubmissionId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/feedback_submissions/{0}", __workflow_feedbackSubmissionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update30Response, ApiConnectionActionConfiguration> Update30(Expression<Func<string>> feedbackSubmissionId, Expression<Func<Update30Input>> body, Expression<Func<string>> idProperty = null)
        {
            var __workflow_feedbackSubmissionId = WorkflowExpression.Compile(feedbackSubmissionId, nameof(feedbackSubmissionId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Update30Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/feedback_submissions/{0}", __workflow_feedbackSubmissionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Update30Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List31Response, ApiConnectionActionConfiguration> List31(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List31Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/feedback_submissions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<List31Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create32Response, ApiConnectionActionConfiguration> Create32(Expression<Func<Create32Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Create32Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/feedback_submissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Create32Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoFeedbackSubmissionsWithSameTypeResponse, ApiConnectionActionConfiguration> MergeTwoFeedbackSubmissionsWithSameType(Expression<Func<MergeTwoFeedbackSubmissionsWithSameTypeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MergeTwoFeedbackSubmissionsWithSameTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/feedback_submissions/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MergeTwoFeedbackSubmissionsWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GdprDeleteFeedback(Expression<Func<GdprDeleteFeedbackInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/feedback_submissions/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsFeedbackSubmissionsSearchResponse, ApiConnectionActionConfiguration> PostCrmV3ObjectsFeedbackSubmissionsSearch(Expression<Func<PostCrmV3ObjectsFeedbackSubmissionsSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostCrmV3ObjectsFeedbackSubmissionsSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/feedback_submissions/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostCrmV3ObjectsFeedbackSubmissionsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ArchiveABatchOfQuotesById(Expression<Func<ArchiveABatchOfQuotesByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/quotes/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List40Response, ApiConnectionActionConfiguration> List40(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List40Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/quotes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<List40Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create41Response, ApiConnectionActionConfiguration> Create41(Expression<Func<Create41Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Create41Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/quotes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Create41Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read42Response, ApiConnectionActionConfiguration> Read42(Expression<Func<string>> quoteId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var __workflow_quoteId = WorkflowExpression.Compile(quoteId, nameof(quoteId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Read42Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/quotes/{0}", __workflow_quoteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                return new ApiConnectionAction<Read42Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Archive43(Expression<Func<string>> quoteId)
        {
            var __workflow_quoteId = WorkflowExpression.Compile(quoteId, nameof(quoteId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/quotes/{0}", __workflow_quoteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update44Response, ApiConnectionActionConfiguration> Update44(Expression<Func<string>> quoteId, Expression<Func<Update44Input>> body, Expression<Func<string>> idProperty = null)
        {
            var __workflow_quoteId = WorkflowExpression.Compile(quoteId, nameof(quoteId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Update44Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/quotes/{0}", __workflow_quoteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Update44Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoQuotesWithSameTypeResponse, ApiConnectionActionConfiguration> MergeTwoQuotesWithSameType(Expression<Func<MergeTwoQuotesWithSameTypeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MergeTwoQuotesWithSameTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/quotes/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MergeTwoQuotesWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GdprDeleteQuotes(Expression<Func<GdprDeleteQuotesInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/quotes/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsQuotesSearchResponse, ApiConnectionActionConfiguration> PostCrmV3ObjectsQuotesSearch(Expression<Func<PostCrmV3ObjectsQuotesSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostCrmV3ObjectsQuotesSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/quotes/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostCrmV3ObjectsQuotesSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ArchiveABatchOfTaxesById(Expression<Func<ArchiveABatchOfTaxesByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/taxes/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List52Response, ApiConnectionActionConfiguration> List52(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List52Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/taxes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<List52Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create53Response, ApiConnectionActionConfiguration> Create53(Expression<Func<Create53Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Create53Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/taxes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Create53Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read54Response, ApiConnectionActionConfiguration> Read54(Expression<Func<string>> taxId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var __workflow_taxId = WorkflowExpression.Compile(taxId, nameof(taxId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Read54Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/taxes/{0}", __workflow_taxId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                return new ApiConnectionAction<Read54Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Archive55(Expression<Func<string>> taxId)
        {
            var __workflow_taxId = WorkflowExpression.Compile(taxId, nameof(taxId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/taxes/{0}", __workflow_taxId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update56Response, ApiConnectionActionConfiguration> Update56(Expression<Func<string>> taxId, Expression<Func<Update56Input>> body, Expression<Func<string>> idProperty = null)
        {
            var __workflow_taxId = WorkflowExpression.Compile(taxId, nameof(taxId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Update56Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/taxes/{0}", __workflow_taxId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Update56Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoTaxesWithSameTypeResponse, ApiConnectionActionConfiguration> MergeTwoTaxesWithSameType(Expression<Func<MergeTwoTaxesWithSameTypeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MergeTwoTaxesWithSameTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/taxes/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MergeTwoTaxesWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GdprDeleteTaxes(Expression<Func<GdprDeleteTaxesInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/taxes/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsTaxesSearchResponse, ApiConnectionActionConfiguration> PostCrmV3ObjectsTaxesSearch(Expression<Func<PostCrmV3ObjectsTaxesSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostCrmV3ObjectsTaxesSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/taxes/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostCrmV3ObjectsTaxesSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ArchiveABatchOfTicketsById(Expression<Func<ArchiveABatchOfTicketsByIdInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/tickets/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read64Response, ApiConnectionActionConfiguration> Read64(Expression<Func<string>> ticketId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var __workflow_ticketId = WorkflowExpression.Compile(ticketId, nameof(ticketId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Read64Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/tickets/{0}", __workflow_ticketId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                return new ApiConnectionAction<Read64Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Archive65(Expression<Func<string>> ticketId)
        {
            var __workflow_ticketId = WorkflowExpression.Compile(ticketId, nameof(ticketId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/tickets/{0}", __workflow_ticketId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update66Response, ApiConnectionActionConfiguration> Update66(Expression<Func<string>> ticketId, Expression<Func<Update66Input>> body, Expression<Func<string>> idProperty = null)
        {
            var __workflow_ticketId = WorkflowExpression.Compile(ticketId, nameof(ticketId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Update66Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/tickets/{0}", __workflow_ticketId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Update66Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List67Response, ApiConnectionActionConfiguration> List67(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertiesWithHistory = WorkflowExpression.Compile(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List67Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/tickets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(__workflow_propertiesWithHistory);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<List67Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create68Response, ApiConnectionActionConfiguration> Create68(Expression<Func<Create68Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Create68Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/tickets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Create68Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoTicketsWithSameTypeResponse, ApiConnectionActionConfiguration> MergeTwoTicketsWithSameType(Expression<Func<MergeTwoTicketsWithSameTypeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MergeTwoTicketsWithSameTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/tickets/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MergeTwoTicketsWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GdprDeleteTickets(Expression<Func<GdprDeleteTicketsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/tickets/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsTicketsSearchResponse, ApiConnectionActionConfiguration> PostCrmV3ObjectsTicketsSearch(Expression<Func<PostCrmV3ObjectsTicketsSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostCrmV3ObjectsTicketsSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/tickets/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostCrmV3ObjectsTicketsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<ListAssociationTypesResponse, ApiConnectionActionConfiguration> ListAssociationTypes(Expression<Func<string>> fromObjectType, Expression<Func<string>> toObjectType)
        {
            var __workflow_fromObjectType = WorkflowExpression.Compile(fromObjectType, nameof(fromObjectType), required: true);
            var __workflow_toObjectType = WorkflowExpression.Compile(toObjectType, nameof(toObjectType), required: true);
            return new DeferredBodyAction<ListAssociationTypesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/associations/{0}/{1}/types", __workflow_fromObjectType.WithUrlEncoding(1), __workflow_toObjectType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListAssociationTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeleteSpecificLabels(Expression<Func<string>> fromObjectType, Expression<Func<string>> toObjectType, Expression<Func<DeleteSpecificLabelsInput>> body)
        {
            var __workflow_fromObjectType = WorkflowExpression.Compile(fromObjectType, nameof(fromObjectType), required: true);
            var __workflow_toObjectType = WorkflowExpression.Compile(toObjectType, nameof(toObjectType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v4/associations/{0}/{1}/batch/labels/archive", __workflow_fromObjectType.WithUrlEncoding(1), __workflow_toObjectType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Delete(Expression<Func<string>> fromObjectType, Expression<Func<string>> toObjectType, Expression<Func<DeleteInput>> body)
        {
            var __workflow_fromObjectType = WorkflowExpression.Compile(fromObjectType, nameof(fromObjectType), required: true);
            var __workflow_toObjectType = WorkflowExpression.Compile(toObjectType, nameof(toObjectType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v4/associations/{0}/{1}/batch/archive", __workflow_fromObjectType.WithUrlEncoding(1), __workflow_toObjectType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<CreateDefaultAssociationsResponse, ApiConnectionActionConfiguration> CreateDefaultAssociations(Expression<Func<string>> fromObjectType, Expression<Func<string>> toObjectType, Expression<Func<CreateDefaultAssociationsInput>> body)
        {
            var __workflow_fromObjectType = WorkflowExpression.Compile(fromObjectType, nameof(fromObjectType), required: true);
            var __workflow_toObjectType = WorkflowExpression.Compile(toObjectType, nameof(toObjectType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateDefaultAssociationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v4/associations/{0}/{1}/batch/associate/default", __workflow_fromObjectType.WithUrlEncoding(1), __workflow_toObjectType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateDefaultAssociationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Delete6(Expression<Func<string>> objectType, Expression<Func<string>> objectId, Expression<Func<string>> toObjectType, Expression<Func<string>> toObjectId)
        {
            var __workflow_objectType = WorkflowExpression.Compile(objectType, nameof(objectType), required: true);
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_toObjectType = WorkflowExpression.Compile(toObjectType, nameof(toObjectType), required: true);
            var __workflow_toObjectId = WorkflowExpression.Compile(toObjectId, nameof(toObjectId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v4/objects/{0}/{1}/associations/{2}/{3}", __workflow_objectType.WithUrlEncoding(1), __workflow_objectId.WithUrlEncoding(1), __workflow_toObjectType.WithUrlEncoding(1), __workflow_toObjectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create7Response, ApiConnectionActionConfiguration> Create7(Expression<Func<string>> objectType, Expression<Func<string>> objectId, Expression<Func<string>> toObjectType, Expression<Func<string>> toObjectId, Expression<Func<bodyInputItem[]>> body)
        {
            var __workflow_objectType = WorkflowExpression.Compile(objectType, nameof(objectType), required: true);
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_toObjectType = WorkflowExpression.Compile(toObjectType, nameof(toObjectType), required: true);
            var __workflow_toObjectId = WorkflowExpression.Compile(toObjectId, nameof(toObjectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Create7Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v4/objects/{0}/{1}/associations/{2}/{3}", __workflow_objectType.WithUrlEncoding(1), __workflow_objectId.WithUrlEncoding(1), __workflow_toObjectType.WithUrlEncoding(1), __workflow_toObjectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Create7Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<CreateDefaultResponse, ApiConnectionActionConfiguration> CreateDefault(Expression<Func<string>> fromObjectType, Expression<Func<string>> fromObjectId, Expression<Func<string>> toObjectType, Expression<Func<string>> toObjectId)
        {
            var __workflow_fromObjectType = WorkflowExpression.Compile(fromObjectType, nameof(fromObjectType), required: true);
            var __workflow_fromObjectId = WorkflowExpression.Compile(fromObjectId, nameof(fromObjectId), required: true);
            var __workflow_toObjectType = WorkflowExpression.Compile(toObjectType, nameof(toObjectType), required: true);
            var __workflow_toObjectId = WorkflowExpression.Compile(toObjectId, nameof(toObjectId), required: true);
            return new DeferredBodyAction<CreateDefaultResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v4/objects/{0}/{1}/associations/default/{2}/{3}", __workflow_fromObjectType.WithUrlEncoding(1), __workflow_fromObjectId.WithUrlEncoding(1), __workflow_toObjectType.WithUrlEncoding(1), __workflow_toObjectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CreateDefaultResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<ListAssociationsResponse, ApiConnectionActionConfiguration> ListAssociations(Expression<Func<string>> objectType, Expression<Func<string>> objectId, Expression<Func<string>> toObjectType, Expression<Func<string>> after = null, Expression<Func<string>> limit = null)
        {
            var __workflow_objectType = WorkflowExpression.Compile(objectType, nameof(objectType), required: true);
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_toObjectType = WorkflowExpression.Compile(toObjectType, nameof(toObjectType), required: true);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<ListAssociationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v4/objects/{0}/{1}/associations/{2}", __workflow_objectType.WithUrlEncoding(1), __workflow_objectId.WithUrlEncoding(1), __workflow_toObjectType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<ListAssociationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<GetAllCardsResponse, ApiConnectionActionConfiguration> GetAllCards(Expression<Func<string>> appId)
        {
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            return new DeferredBodyAction<GetAllCardsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/extensions/cards-dev/{0}", __workflow_appId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAllCardsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<CreateANewCardResponse, ApiConnectionActionConfiguration> CreateANewCard(Expression<Func<string>> appId, Expression<Func<CreateANewCardInput>> body)
        {
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateANewCardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/extensions/cards-dev/{0}", __workflow_appId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateANewCardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<GetACardResponse, ApiConnectionActionConfiguration> GetACard(Expression<Func<string>> appId, Expression<Func<string>> cardId)
        {
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            return new DeferredBodyAction<GetACardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/extensions/cards-dev/{0}/{1}", __workflow_appId.WithUrlEncoding(1), __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetACardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeleteACard(Expression<Func<string>> appId, Expression<Func<string>> cardId)
        {
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/extensions/cards-dev/{0}/{1}", __workflow_appId.WithUrlEncoding(1), __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<UpdateACardResponse, ApiConnectionActionConfiguration> UpdateACard(Expression<Func<string>> appId, Expression<Func<string>> cardId, Expression<Func<UpdateACardInput>> body)
        {
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateACardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/extensions/cards-dev/{0}/{1}", __workflow_appId.WithUrlEncoding(1), __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateACardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<GetSampleCardDetailResponseResponse, ApiConnectionActionConfiguration> GetSampleCardDetailResponse()
        {
            return new DeferredBodyAction<GetSampleCardDetailResponseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/extensions/cards-dev/sample-response";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSampleCardDetailResponseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<GetCrmV3ExportsExportAsyncTasksTaskIdStatusResponse, ApiConnectionActionConfiguration> GetCrmV3ExportsExportAsyncTasksTaskIdStatus(Expression<Func<string>> taskId)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<GetCrmV3ExportsExportAsyncTasksTaskIdStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/exports/export/async/tasks/{0}/status", __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCrmV3ExportsExportAsyncTasksTaskIdStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<StartAnExportResponse, ApiConnectionActionConfiguration> StartAnExport(Expression<Func<StartAnExportInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StartAnExportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/exports/export/async";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StartAnExportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<GetTheInformationOnAnyImportResponse, ApiConnectionActionConfiguration> GetTheInformationOnAnyImport(Expression<Func<string>> importId)
        {
            var __workflow_importId = WorkflowExpression.Compile(importId, nameof(importId), required: true);
            return new DeferredBodyAction<GetTheInformationOnAnyImportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/imports/{0}", __workflow_importId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTheInformationOnAnyImportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<CancelAnActiveImportResponse, ApiConnectionActionConfiguration> CancelAnActiveImport(Expression<Func<string>> importId)
        {
            var __workflow_importId = WorkflowExpression.Compile(importId, nameof(importId), required: true);
            return new DeferredBodyAction<CancelAnActiveImportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/imports/{0}/cancel", __workflow_importId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CancelAnActiveImportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<GetActiveImportsResponse, ApiConnectionActionConfiguration> GetActiveImports(Expression<Func<string>> after = null, Expression<Func<string>> before = null, Expression<Func<string>> limit = null)
        {
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<GetActiveImportsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/imports/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<GetActiveImportsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<StartANewImportResponse, ApiConnectionActionConfiguration> StartANewImport(Expression<Func<string>> contentType)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            return new DeferredBodyAction<StartANewImportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/imports/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                return new ApiConnectionAction<StartANewImportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<GetCrmV3ImportsImportIdErrorsGetErrorsResponse, ApiConnectionActionConfiguration> GetCrmV3ImportsImportIdErrorsGetErrors(Expression<Func<string>> importId, Expression<Func<string>> after = null, Expression<Func<string>> limit = null)
        {
            var __workflow_importId = WorkflowExpression.Compile(importId, nameof(importId), required: true);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<GetCrmV3ImportsImportIdErrorsGetErrorsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/imports/{0}/errors", __workflow_importId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<GetCrmV3ImportsImportIdErrorsGetErrorsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<AddAndOrRemoveRecordsFromAListResponse, ApiConnectionActionConfiguration> AddAndOrRemoveRecordsFromAList(Expression<Func<string>> listId, Expression<Func<AddAndOrRemoveRecordsFromAListInput>> body)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddAndOrRemoveRecordsFromAListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/lists/{0}/memberships/add-and-remove", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddAndOrRemoveRecordsFromAListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<AddRecordsToAListResponse, ApiConnectionActionConfiguration> AddRecordsToAList(Expression<Func<string>> listId, Expression<Func<string[]>> body)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddRecordsToAListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/lists/{0}/memberships/add", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddRecordsToAListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddAllRecordsFromASourceListToADestinationList(Expression<Func<string>> listId, Expression<Func<string>> sourceListId)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_sourceListId = WorkflowExpression.Compile(sourceListId, nameof(sourceListId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/lists/{0}/memberships/add-from/{1}", __workflow_listId.WithUrlEncoding(1), __workflow_sourceListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<FetchListMembershipsOrderedByIdResponse, ApiConnectionActionConfiguration> FetchListMembershipsOrderedById(Expression<Func<string>> listId, Expression<Func<string>> after = null, Expression<Func<string>> before = null, Expression<Func<string>> limit = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<FetchListMembershipsOrderedByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/lists/{0}/memberships", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<FetchListMembershipsOrderedByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeleteAllRecordsFromAList(Expression<Func<string>> listId)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/lists/{0}/memberships", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<RemoveRecordsFromAListResponse, ApiConnectionActionConfiguration> RemoveRecordsFromAList(Expression<Func<string>> listId, Expression<Func<string[]>> body)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<RemoveRecordsFromAListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/lists/{0}/memberships/remove", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RemoveRecordsFromAListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<SearchListsResponse, ApiConnectionActionConfiguration> SearchLists(Expression<Func<SearchListsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SearchListsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/lists/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SearchListsResponse>(callPayload);
            });
        }
    }

    public class Hubspotcrmv2Triggers([ConnectionName] string connectionId)
    {
    }

    public class ArchiveABatchOfCompaniesByIdInput
    {
        [JsonProperty("inputs")]
        public ArchiveABatchOfCompaniesByIdInputInputsTypeItem[] Inputs { get; set; }
    }

    public class ArchiveABatchOfCompaniesByIdInputInputsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListResponse
    {
        [JsonProperty("results")]
        public ListResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("paging")]
        public ListResponsePagingType Paging { get; set; }
    }

    public class ListResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class ListResponsePagingType
    {
        [JsonProperty("next")]
        public ListResponsePagingTypeNextType Next { get; set; }
    }

    public class ListResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class CreateResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class CreateInput
    {
        [JsonProperty("associations")]
        public CreateInputAssociationsTypeItem[] Associations { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class CreateInputAssociationsTypeItem
    {
        [JsonProperty("to")]
        public CreateInputAssociationsTypeItemToType To { get; set; }

        [JsonProperty("types")]
        public CreateInputAssociationsTypeItemTypesTypeItem[] Types { get; set; }
    }

    public class CreateInputAssociationsTypeItemToType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateInputAssociationsTypeItemTypesTypeItem
    {
        [JsonProperty("associationCategory")]
        public string AssociationCategory { get; set; }

        [JsonProperty("associationTypeId")]
        public string AssociationTypeId { get; set; }
    }

    public class ReadResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class UpdateResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class UpdateInput
    {
        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class MergeTwoCompaniesWithSameTypeResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class MergeTwoCompaniesWithSameTypeInput
    {
        [JsonProperty("objectIdToMerge")]
        public string ObjectIdToMerge { get; set; }

        [JsonProperty("primaryObjectId")]
        public string PrimaryObjectId { get; set; }
    }

    public class GdprDeleteInput
    {
        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("idProperty")]
        public string IdProperty { get; set; }
    }

    public class PostCrmV3ObjectsCompaniesSearchResponse
    {
        [JsonProperty("results")]
        public PostCrmV3ObjectsCompaniesSearchResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("paging")]
        public PostCrmV3ObjectsCompaniesSearchResponsePagingType Paging { get; set; }
    }

    public class PostCrmV3ObjectsCompaniesSearchResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class PostCrmV3ObjectsCompaniesSearchResponsePagingType
    {
        [JsonProperty("next")]
        public PostCrmV3ObjectsCompaniesSearchResponsePagingTypeNextType Next { get; set; }
    }

    public class PostCrmV3ObjectsCompaniesSearchResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class PostCrmV3ObjectsCompaniesSearchInput
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("filterGroups")]
        public PostCrmV3ObjectsCompaniesSearchInputFilterGroupsTypeItem[] FilterGroups { get; set; }

        [JsonProperty("limit")]
        public string Limit { get; set; }

        [JsonProperty("properties")]
        public string[] Properties { get; set; }

        [JsonProperty("sorts")]
        public string[] Sorts { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
    }

    public class PostCrmV3ObjectsCompaniesSearchInputFilterGroupsTypeItem
    {
        [JsonProperty("filters")]
        public PostCrmV3ObjectsCompaniesSearchInputFilterGroupsTypeItemFiltersTypeItem[] Filters { get; set; }
    }

    public class PostCrmV3ObjectsCompaniesSearchInputFilterGroupsTypeItemFiltersTypeItem
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("highValue")]
        public string HighValue { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class ArchiveABatchOfContactsByIdInput
    {
        [JsonProperty("inputs")]
        public ArchiveABatchOfContactsByIdInputInputsTypeItem[] Inputs { get; set; }
    }

    public class ArchiveABatchOfContactsByIdInputInputsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class List16Response
    {
        [JsonProperty("results")]
        public List16ResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("paging")]
        public List16ResponsePagingType Paging { get; set; }
    }

    public class List16ResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class List16ResponsePagingType
    {
        [JsonProperty("next")]
        public List16ResponsePagingTypeNextType Next { get; set; }
    }

    public class List16ResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Create17Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Create17Input
    {
        [JsonProperty("associations")]
        public Create17InputAssociationsTypeItem[] Associations { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class Create17InputAssociationsTypeItem
    {
        [JsonProperty("to")]
        public Create17InputAssociationsTypeItemToType To { get; set; }

        [JsonProperty("types")]
        public Create17InputAssociationsTypeItemTypesTypeItem[] Types { get; set; }
    }

    public class Create17InputAssociationsTypeItemToType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Create17InputAssociationsTypeItemTypesTypeItem
    {
        [JsonProperty("associationCategory")]
        public string AssociationCategory { get; set; }

        [JsonProperty("associationTypeId")]
        public string AssociationTypeId { get; set; }
    }

    public class Read18Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public Read18ResponseAssociationsType Associations { get; set; }
    }

    public class Read18ResponseAssociationsType
    {
        [JsonProperty("etc")]
        public Read18ResponseAssociationsTypeEtcType Etc { get; set; }
    }

    public class Read18ResponseAssociationsTypeEtcType
    {
        [JsonProperty("results")]
        public Read18ResponseAssociationsTypeEtcTypeResultsTypeItem[] Results { get; set; }

        [JsonProperty("paging")]
        public Read18ResponseAssociationsTypeEtcTypePagingType Paging { get; set; }
    }

    public class Read18ResponseAssociationsTypeEtcTypeResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class Read18ResponseAssociationsTypeEtcTypePagingType
    {
        [JsonProperty("next")]
        public Read18ResponseAssociationsTypeEtcTypePagingTypeNextType Next { get; set; }

        [JsonProperty("prev")]
        public Read18ResponseAssociationsTypeEtcTypePagingTypePrevType Prev { get; set; }
    }

    public class Read18ResponseAssociationsTypeEtcTypePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Read18ResponseAssociationsTypeEtcTypePagingTypePrevType
    {
        [JsonProperty("before")]
        public string Before { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Update20Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Update20Input
    {
        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class MergeTwoContactsWithSameTypeResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class MergeTwoContactsWithSameTypeInput
    {
        [JsonProperty("objectIdToMerge")]
        public string ObjectIdToMerge { get; set; }

        [JsonProperty("primaryObjectId")]
        public string PrimaryObjectId { get; set; }
    }

    public class GdprDelete22Input
    {
        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("idProperty")]
        public string IdProperty { get; set; }
    }

    public class PostCrmV3ObjectsContactsSearchResponse
    {
        [JsonProperty("results")]
        public PostCrmV3ObjectsContactsSearchResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("paging")]
        public PostCrmV3ObjectsContactsSearchResponsePagingType Paging { get; set; }
    }

    public class PostCrmV3ObjectsContactsSearchResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class PostCrmV3ObjectsContactsSearchResponsePagingType
    {
        [JsonProperty("next")]
        public PostCrmV3ObjectsContactsSearchResponsePagingTypeNextType Next { get; set; }
    }

    public class PostCrmV3ObjectsContactsSearchResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class PostCrmV3ObjectsContactsSearchInput
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("filterGroups")]
        public PostCrmV3ObjectsContactsSearchInputFilterGroupsTypeItem[] FilterGroups { get; set; }

        [JsonProperty("limit")]
        public string Limit { get; set; }

        [JsonProperty("properties")]
        public string[] Properties { get; set; }

        [JsonProperty("sorts")]
        public string[] Sorts { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
    }

    public class PostCrmV3ObjectsContactsSearchInputFilterGroupsTypeItem
    {
        [JsonProperty("filters")]
        public PostCrmV3ObjectsContactsSearchInputFilterGroupsTypeItemFiltersTypeItem[] Filters { get; set; }
    }

    public class PostCrmV3ObjectsContactsSearchInputFilterGroupsTypeItemFiltersTypeItem
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("highValue")]
        public string HighValue { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class ArchiveABatchOfDealsByIdInput
    {
        [JsonProperty("inputs")]
        public ArchiveABatchOfDealsByIdInputInputsTypeItem[] Inputs { get; set; }
    }

    public class ArchiveABatchOfDealsByIdInputInputsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class List28Response
    {
        [JsonProperty("results")]
        public List28ResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("paging")]
        public List28ResponsePagingType Paging { get; set; }
    }

    public class List28ResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class List28ResponsePagingType
    {
        [JsonProperty("next")]
        public List28ResponsePagingTypeNextType Next { get; set; }
    }

    public class List28ResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Create29Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Create29Input
    {
        [JsonProperty("associations")]
        public Create29InputAssociationsTypeItem[] Associations { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class Create29InputAssociationsTypeItem
    {
        [JsonProperty("to")]
        public Create29InputAssociationsTypeItemToType To { get; set; }

        [JsonProperty("types")]
        public Create29InputAssociationsTypeItemTypesTypeItem[] Types { get; set; }
    }

    public class Create29InputAssociationsTypeItemToType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Create29InputAssociationsTypeItemTypesTypeItem
    {
        [JsonProperty("associationCategory")]
        public string AssociationCategory { get; set; }

        [JsonProperty("associationTypeId")]
        public string AssociationTypeId { get; set; }
    }

    public class Read30Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class Update32Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Update32Input
    {
        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class MergeTwoDealsWithSameTypeResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class MergeTwoDealsWithSameTypeInput
    {
        [JsonProperty("objectIdToMerge")]
        public string ObjectIdToMerge { get; set; }

        [JsonProperty("primaryObjectId")]
        public string PrimaryObjectId { get; set; }
    }

    public class GdprDelete34Input
    {
        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("idProperty")]
        public string IdProperty { get; set; }
    }

    public class PostCrmV3ObjectsDealsSearchResponse
    {
        [JsonProperty("results")]
        public PostCrmV3ObjectsDealsSearchResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("paging")]
        public PostCrmV3ObjectsDealsSearchResponsePagingType Paging { get; set; }
    }

    public class PostCrmV3ObjectsDealsSearchResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class PostCrmV3ObjectsDealsSearchResponsePagingType
    {
        [JsonProperty("next")]
        public PostCrmV3ObjectsDealsSearchResponsePagingTypeNextType Next { get; set; }
    }

    public class PostCrmV3ObjectsDealsSearchResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class PostCrmV3ObjectsDealsSearchInput
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("filterGroups")]
        public PostCrmV3ObjectsDealsSearchInputFilterGroupsTypeItem[] FilterGroups { get; set; }

        [JsonProperty("limit")]
        public string Limit { get; set; }

        [JsonProperty("properties")]
        public string[] Properties { get; set; }

        [JsonProperty("sorts")]
        public string[] Sorts { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
    }

    public class PostCrmV3ObjectsDealsSearchInputFilterGroupsTypeItem
    {
        [JsonProperty("filters")]
        public PostCrmV3ObjectsDealsSearchInputFilterGroupsTypeItemFiltersTypeItem[] Filters { get; set; }
    }

    public class PostCrmV3ObjectsDealsSearchInputFilterGroupsTypeItemFiltersTypeItem
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("highValue")]
        public string HighValue { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class ArchiveABatchOfFeesByIdInput
    {
        [JsonProperty("inputs")]
        public ArchiveABatchOfFeesByIdInputInputsTypeItem[] Inputs { get; set; }
    }

    public class ArchiveABatchOfFeesByIdInputInputsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Read40Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class Update42Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Update42Input
    {
        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class List43Response
    {
        [JsonProperty("results")]
        public List43ResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("paging")]
        public List43ResponsePagingType Paging { get; set; }
    }

    public class List43ResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class List43ResponsePagingType
    {
        [JsonProperty("next")]
        public List43ResponsePagingTypeNextType Next { get; set; }
    }

    public class List43ResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Create44Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Create44Input
    {
        [JsonProperty("associations")]
        public Create44InputAssociationsTypeItem[] Associations { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class Create44InputAssociationsTypeItem
    {
        [JsonProperty("to")]
        public Create44InputAssociationsTypeItemToType To { get; set; }

        [JsonProperty("types")]
        public Create44InputAssociationsTypeItemTypesTypeItem[] Types { get; set; }
    }

    public class Create44InputAssociationsTypeItemToType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Create44InputAssociationsTypeItemTypesTypeItem
    {
        [JsonProperty("associationCategory")]
        public string AssociationCategory { get; set; }

        [JsonProperty("associationTypeId")]
        public string AssociationTypeId { get; set; }
    }

    public class MergeTwoFeesWithSameTypeResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class MergeTwoFeesWithSameTypeInput
    {
        [JsonProperty("objectIdToMerge")]
        public string ObjectIdToMerge { get; set; }

        [JsonProperty("primaryObjectId")]
        public string PrimaryObjectId { get; set; }
    }

    public class GdprDelete46Input
    {
        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("idProperty")]
        public string IdProperty { get; set; }
    }

    public class PostCrmV3ObjectsFeesSearchResponse
    {
        [JsonProperty("results")]
        public PostCrmV3ObjectsFeesSearchResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("paging")]
        public PostCrmV3ObjectsFeesSearchResponsePagingType Paging { get; set; }
    }

    public class PostCrmV3ObjectsFeesSearchResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class PostCrmV3ObjectsFeesSearchResponsePagingType
    {
        [JsonProperty("next")]
        public PostCrmV3ObjectsFeesSearchResponsePagingTypeNextType Next { get; set; }
    }

    public class PostCrmV3ObjectsFeesSearchResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class PostCrmV3ObjectsFeesSearchInput
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("filterGroups")]
        public PostCrmV3ObjectsFeesSearchInputFilterGroupsTypeItem[] FilterGroups { get; set; }

        [JsonProperty("limit")]
        public string Limit { get; set; }

        [JsonProperty("properties")]
        public string[] Properties { get; set; }

        [JsonProperty("sorts")]
        public string[] Sorts { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
    }

    public class PostCrmV3ObjectsFeesSearchInputFilterGroupsTypeItem
    {
        [JsonProperty("filters")]
        public PostCrmV3ObjectsFeesSearchInputFilterGroupsTypeItemFiltersTypeItem[] Filters { get; set; }
    }

    public class PostCrmV3ObjectsFeesSearchInputFilterGroupsTypeItemFiltersTypeItem
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("highValue")]
        public string HighValue { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class ArchiveABatchOfGoalTargetsByIdInput
    {
        [JsonProperty("inputs")]
        public ArchiveABatchOfGoalTargetsByIdInputInputsTypeItem[] Inputs { get; set; }
    }

    public class ArchiveABatchOfGoalTargetsByIdInputInputsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Read52Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class Update54Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Update54Input
    {
        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class List55Response
    {
        [JsonProperty("results")]
        public List55ResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("paging")]
        public List55ResponsePagingType Paging { get; set; }
    }

    public class List55ResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class List55ResponsePagingType
    {
        [JsonProperty("next")]
        public List55ResponsePagingTypeNextType Next { get; set; }
    }

    public class List55ResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Create56Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Create56Input
    {
        [JsonProperty("associations")]
        public Create56InputAssociationsTypeItem[] Associations { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class Create56InputAssociationsTypeItem
    {
        [JsonProperty("to")]
        public Create56InputAssociationsTypeItemToType To { get; set; }

        [JsonProperty("types")]
        public Create56InputAssociationsTypeItemTypesTypeItem[] Types { get; set; }
    }

    public class Create56InputAssociationsTypeItemToType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Create56InputAssociationsTypeItemTypesTypeItem
    {
        [JsonProperty("associationCategory")]
        public string AssociationCategory { get; set; }

        [JsonProperty("associationTypeId")]
        public string AssociationTypeId { get; set; }
    }

    public class MergeTwoGoalTargetsWithSameTypeResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class MergeTwoGoalTargetsWithSameTypeInput
    {
        [JsonProperty("objectIdToMerge")]
        public string ObjectIdToMerge { get; set; }

        [JsonProperty("primaryObjectId")]
        public string PrimaryObjectId { get; set; }
    }

    public class GdprDelete58Input
    {
        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("idProperty")]
        public string IdProperty { get; set; }
    }

    public class PostCrmV3ObjectsGoalTargetsSearchResponse
    {
        [JsonProperty("results")]
        public PostCrmV3ObjectsGoalTargetsSearchResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("paging")]
        public PostCrmV3ObjectsGoalTargetsSearchResponsePagingType Paging { get; set; }
    }

    public class PostCrmV3ObjectsGoalTargetsSearchResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class PostCrmV3ObjectsGoalTargetsSearchResponsePagingType
    {
        [JsonProperty("next")]
        public PostCrmV3ObjectsGoalTargetsSearchResponsePagingTypeNextType Next { get; set; }
    }

    public class PostCrmV3ObjectsGoalTargetsSearchResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class PostCrmV3ObjectsGoalTargetsSearchInput
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("filterGroups")]
        public PostCrmV3ObjectsGoalTargetsSearchInputFilterGroupsTypeItem[] FilterGroups { get; set; }

        [JsonProperty("limit")]
        public string Limit { get; set; }

        [JsonProperty("properties")]
        public string[] Properties { get; set; }

        [JsonProperty("sorts")]
        public string[] Sorts { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
    }

    public class PostCrmV3ObjectsGoalTargetsSearchInputFilterGroupsTypeItem
    {
        [JsonProperty("filters")]
        public PostCrmV3ObjectsGoalTargetsSearchInputFilterGroupsTypeItemFiltersTypeItem[] Filters { get; set; }
    }

    public class PostCrmV3ObjectsGoalTargetsSearchInputFilterGroupsTypeItemFiltersTypeItem
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("highValue")]
        public string HighValue { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class ArchiveABatchOfLineItemsByIdInput
    {
        [JsonProperty("inputs")]
        public ArchiveABatchOfLineItemsByIdInputInputsTypeItem[] Inputs { get; set; }
    }

    public class ArchiveABatchOfLineItemsByIdInputInputsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class List64Response
    {
        [JsonProperty("results")]
        public List64ResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("paging")]
        public List64ResponsePagingType Paging { get; set; }
    }

    public class List64ResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class List64ResponsePagingType
    {
        [JsonProperty("next")]
        public List64ResponsePagingTypeNextType Next { get; set; }
    }

    public class List64ResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Create65Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Create65Input
    {
        [JsonProperty("associations")]
        public Create65InputAssociationsTypeItem[] Associations { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class Create65InputAssociationsTypeItem
    {
        [JsonProperty("to")]
        public Create65InputAssociationsTypeItemToType To { get; set; }

        [JsonProperty("types")]
        public Create65InputAssociationsTypeItemTypesTypeItem[] Types { get; set; }
    }

    public class Create65InputAssociationsTypeItemToType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Create65InputAssociationsTypeItemTypesTypeItem
    {
        [JsonProperty("associationCategory")]
        public string AssociationCategory { get; set; }

        [JsonProperty("associationTypeId")]
        public string AssociationTypeId { get; set; }
    }

    public class Read66Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class Update68Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Update68Input
    {
        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class MergeTwoLineItemsWithSameTypeResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class MergeTwoLineItemsWithSameTypeInput
    {
        [JsonProperty("objectIdToMerge")]
        public string ObjectIdToMerge { get; set; }

        [JsonProperty("primaryObjectId")]
        public string PrimaryObjectId { get; set; }
    }

    public class GdprDelete70Input
    {
        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("idProperty")]
        public string IdProperty { get; set; }
    }

    public class PostCrmV3ObjectsLineItemsSearchResponse
    {
        [JsonProperty("results")]
        public PostCrmV3ObjectsLineItemsSearchResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("paging")]
        public PostCrmV3ObjectsLineItemsSearchResponsePagingType Paging { get; set; }
    }

    public class PostCrmV3ObjectsLineItemsSearchResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class PostCrmV3ObjectsLineItemsSearchResponsePagingType
    {
        [JsonProperty("next")]
        public PostCrmV3ObjectsLineItemsSearchResponsePagingTypeNextType Next { get; set; }
    }

    public class PostCrmV3ObjectsLineItemsSearchResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class PostCrmV3ObjectsLineItemsSearchInput
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("filterGroups")]
        public PostCrmV3ObjectsLineItemsSearchInputFilterGroupsTypeItem[] FilterGroups { get; set; }

        [JsonProperty("limit")]
        public string Limit { get; set; }

        [JsonProperty("properties")]
        public string[] Properties { get; set; }

        [JsonProperty("sorts")]
        public string[] Sorts { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
    }

    public class PostCrmV3ObjectsLineItemsSearchInputFilterGroupsTypeItem
    {
        [JsonProperty("filters")]
        public PostCrmV3ObjectsLineItemsSearchInputFilterGroupsTypeItemFiltersTypeItem[] Filters { get; set; }
    }

    public class PostCrmV3ObjectsLineItemsSearchInputFilterGroupsTypeItemFiltersTypeItem
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("highValue")]
        public string HighValue { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class GetAPageOfOwnersResponse
    {
        [JsonProperty("results")]
        public GetAPageOfOwnersResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("paging")]
        public GetAPageOfOwnersResponsePagingType Paging { get; set; }
    }

    public class GetAPageOfOwnersResponseResultsTypeItem
    {
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("teams")]
        public GetAPageOfOwnersResponseResultsTypeItemTeamsTypeItem[] Teams { get; set; }
    }

    public class GetAPageOfOwnersResponseResultsTypeItemTeamsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("primary")]
        public string Primary { get; set; }
    }

    public class GetAPageOfOwnersResponsePagingType
    {
        [JsonProperty("next")]
        public GetAPageOfOwnersResponsePagingTypeNextType Next { get; set; }
    }

    public class GetAPageOfOwnersResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class ReadAnOwnerByGivenidOruseridResponse
    {
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("teams")]
        public ReadAnOwnerByGivenidOruseridResponseTeamsTypeItem[] Teams { get; set; }
    }

    public class ReadAnOwnerByGivenidOruseridResponseTeamsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("primary")]
        public string Primary { get; set; }
    }

    public class ArchiveABatchOfProductsByIdInput
    {
        [JsonProperty("inputs")]
        public ArchiveABatchOfProductsByIdInputInputsTypeItem[] Inputs { get; set; }
    }

    public class ArchiveABatchOfProductsByIdInputInputsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class List78Response
    {
        [JsonProperty("results")]
        public List78ResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("paging")]
        public List78ResponsePagingType Paging { get; set; }
    }

    public class List78ResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class List78ResponsePagingType
    {
        [JsonProperty("next")]
        public List78ResponsePagingTypeNextType Next { get; set; }
    }

    public class List78ResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Create79Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Create79Input
    {
        [JsonProperty("associations")]
        public Create79InputAssociationsTypeItem[] Associations { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class Create79InputAssociationsTypeItem
    {
        [JsonProperty("to")]
        public Create79InputAssociationsTypeItemToType To { get; set; }

        [JsonProperty("types")]
        public Create79InputAssociationsTypeItemTypesTypeItem[] Types { get; set; }
    }

    public class Create79InputAssociationsTypeItemToType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Create79InputAssociationsTypeItemTypesTypeItem
    {
        [JsonProperty("associationCategory")]
        public string AssociationCategory { get; set; }

        [JsonProperty("associationTypeId")]
        public string AssociationTypeId { get; set; }
    }

    public class Read80Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class Update82Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Update82Input
    {
        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class MergeTwoProductsWithSameTypeResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class MergeTwoProductsWithSameTypeInput
    {
        [JsonProperty("objectIdToMerge")]
        public string ObjectIdToMerge { get; set; }

        [JsonProperty("primaryObjectId")]
        public string PrimaryObjectId { get; set; }
    }

    public class GdprDelete84Input
    {
        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("idProperty")]
        public string IdProperty { get; set; }
    }

    public class PostCrmV3ObjectsProductsSearchResponse
    {
        [JsonProperty("results")]
        public PostCrmV3ObjectsProductsSearchResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("paging")]
        public PostCrmV3ObjectsProductsSearchResponsePagingType Paging { get; set; }
    }

    public class PostCrmV3ObjectsProductsSearchResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class PostCrmV3ObjectsProductsSearchResponsePagingType
    {
        [JsonProperty("next")]
        public PostCrmV3ObjectsProductsSearchResponsePagingTypeNextType Next { get; set; }
    }

    public class PostCrmV3ObjectsProductsSearchResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class PostCrmV3ObjectsProductsSearchInput
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("filterGroups")]
        public PostCrmV3ObjectsProductsSearchInputFilterGroupsTypeItem[] FilterGroups { get; set; }

        [JsonProperty("limit")]
        public string Limit { get; set; }

        [JsonProperty("properties")]
        public string[] Properties { get; set; }

        [JsonProperty("sorts")]
        public string[] Sorts { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
    }

    public class PostCrmV3ObjectsProductsSearchInputFilterGroupsTypeItem
    {
        [JsonProperty("filters")]
        public PostCrmV3ObjectsProductsSearchInputFilterGroupsTypeItemFiltersTypeItem[] Filters { get; set; }
    }

    public class PostCrmV3ObjectsProductsSearchInputFilterGroupsTypeItemFiltersTypeItem
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("highValue")]
        public string HighValue { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class ArchiveABatchOfObjectsByIdInput
    {
        [JsonProperty("inputs")]
        public ArchiveABatchOfObjectsByIdInputInputsTypeItem[] Inputs { get; set; }
    }

    public class ArchiveABatchOfObjectsByIdInputInputsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ReadObjectResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class UpdateObjectIdResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class UpdateObjectIdInput
    {
        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class ListObjectResponse
    {
        [JsonProperty("results")]
        public ListObjectResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("paging")]
        public ListObjectResponsePagingType Paging { get; set; }
    }

    public class ListObjectResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class ListObjectResponsePagingType
    {
        [JsonProperty("next")]
        public ListObjectResponsePagingTypeNextType Next { get; set; }
    }

    public class ListObjectResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class CreateObjectIdResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class CreateObjectIdInput
    {
        [JsonProperty("associations")]
        public CreateObjectIdInputAssociationsTypeItem[] Associations { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class CreateObjectIdInputAssociationsTypeItem
    {
        [JsonProperty("to")]
        public CreateObjectIdInputAssociationsTypeItemToType To { get; set; }

        [JsonProperty("types")]
        public CreateObjectIdInputAssociationsTypeItemTypesTypeItem[] Types { get; set; }
    }

    public class CreateObjectIdInputAssociationsTypeItemToType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateObjectIdInputAssociationsTypeItemTypesTypeItem
    {
        [JsonProperty("associationCategory")]
        public string AssociationCategory { get; set; }

        [JsonProperty("associationTypeId")]
        public string AssociationTypeId { get; set; }
    }

    public class MergeTwoObjectsWithSameTypeResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class MergeTwoObjectsWithSameTypeInput
    {
        [JsonProperty("objectIdToMerge")]
        public string ObjectIdToMerge { get; set; }

        [JsonProperty("primaryObjectId")]
        public string PrimaryObjectId { get; set; }
    }

    public class GdprDeleteObjectTypeInput
    {
        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("idProperty")]
        public string IdProperty { get; set; }
    }

    public class PostCrmV3ObjectsObjectTypeSearchResponse
    {
        [JsonProperty("results")]
        public PostCrmV3ObjectsObjectTypeSearchResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("paging")]
        public PostCrmV3ObjectsObjectTypeSearchResponsePagingType Paging { get; set; }
    }

    public class PostCrmV3ObjectsObjectTypeSearchResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class PostCrmV3ObjectsObjectTypeSearchResponsePagingType
    {
        [JsonProperty("next")]
        public PostCrmV3ObjectsObjectTypeSearchResponsePagingTypeNextType Next { get; set; }
    }

    public class PostCrmV3ObjectsObjectTypeSearchResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class PostCrmV3ObjectsObjectTypeSearchInput
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("filterGroups")]
        public PostCrmV3ObjectsObjectTypeSearchInputFilterGroupsTypeItem[] FilterGroups { get; set; }

        [JsonProperty("limit")]
        public string Limit { get; set; }

        [JsonProperty("properties")]
        public string[] Properties { get; set; }

        [JsonProperty("sorts")]
        public string[] Sorts { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
    }

    public class PostCrmV3ObjectsObjectTypeSearchInputFilterGroupsTypeItem
    {
        [JsonProperty("filters")]
        public PostCrmV3ObjectsObjectTypeSearchInputFilterGroupsTypeItemFiltersTypeItem[] Filters { get; set; }
    }

    public class PostCrmV3ObjectsObjectTypeSearchInputFilterGroupsTypeItemFiltersTypeItem
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("highValue")]
        public string HighValue { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class ArchiveABatchOfDiscountsByIdInput
    {
        [JsonProperty("inputs")]
        public ArchiveABatchOfDiscountsByIdInputInputsTypeItem[] Inputs { get; set; }
    }

    public class ArchiveABatchOfDiscountsByIdInputInputsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Read16Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class Update18Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Update18Input
    {
        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class List19Response
    {
        [JsonProperty("results")]
        public List19ResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("paging")]
        public List19ResponsePagingType Paging { get; set; }
    }

    public class List19ResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class List19ResponsePagingType
    {
        [JsonProperty("next")]
        public List19ResponsePagingTypeNextType Next { get; set; }
    }

    public class List19ResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Create20Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Create20Input
    {
        [JsonProperty("associations")]
        public Create20InputAssociationsTypeItem[] Associations { get; set; }

        [JsonProperty("properties")]
        public Create20InputPropertiesType Properties { get; set; }
    }

    public class Create20InputAssociationsTypeItem
    {
        [JsonProperty("to")]
        public Create20InputAssociationsTypeItemToType To { get; set; }

        [JsonProperty("types")]
        public Create20InputAssociationsTypeItemTypesTypeItem[] Types { get; set; }
    }

    public class Create20InputAssociationsTypeItemToType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Create20InputAssociationsTypeItemTypesTypeItem
    {
        [JsonProperty("associationCategory")]
        public string AssociationCategory { get; set; }

        [JsonProperty("associationTypeId")]
        public string AssociationTypeId { get; set; }
    }

    public class Create20InputPropertiesType
    {
        [JsonProperty("nostrudcf")]
        public string Nostrudcf { get; set; }
    }

    public class MergeTwoDiscountsWithSameTypeResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class MergeTwoDiscountsWithSameTypeInput
    {
        [JsonProperty("objectIdToMerge")]
        public string ObjectIdToMerge { get; set; }

        [JsonProperty("primaryObjectId")]
        public string PrimaryObjectId { get; set; }
    }

    public class GdprDeleteDiscountsInput
    {
        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("idProperty")]
        public string IdProperty { get; set; }
    }

    public class PostCrmV3ObjectsDiscountsSearchResponse
    {
        [JsonProperty("results")]
        public PostCrmV3ObjectsDiscountsSearchResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("paging")]
        public PostCrmV3ObjectsDiscountsSearchResponsePagingType Paging { get; set; }
    }

    public class PostCrmV3ObjectsDiscountsSearchResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class PostCrmV3ObjectsDiscountsSearchResponsePagingType
    {
        [JsonProperty("next")]
        public PostCrmV3ObjectsDiscountsSearchResponsePagingTypeNextType Next { get; set; }
    }

    public class PostCrmV3ObjectsDiscountsSearchResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class PostCrmV3ObjectsDiscountsSearchInput
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("filterGroups")]
        public PostCrmV3ObjectsDiscountsSearchInputFilterGroupsTypeItem[] FilterGroups { get; set; }

        [JsonProperty("limit")]
        public string Limit { get; set; }

        [JsonProperty("properties")]
        public string[] Properties { get; set; }

        [JsonProperty("sorts")]
        public string[] Sorts { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
    }

    public class PostCrmV3ObjectsDiscountsSearchInputFilterGroupsTypeItem
    {
        [JsonProperty("filters")]
        public PostCrmV3ObjectsDiscountsSearchInputFilterGroupsTypeItemFiltersTypeItem[] Filters { get; set; }
    }

    public class PostCrmV3ObjectsDiscountsSearchInputFilterGroupsTypeItemFiltersTypeItem
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("highValue")]
        public string HighValue { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class ArchiveABatchOfFeedbackSubmissionsByIdInput
    {
        [JsonProperty("inputs")]
        public ArchiveABatchOfFeedbackSubmissionsByIdInputInputsTypeItem[] Inputs { get; set; }
    }

    public class ArchiveABatchOfFeedbackSubmissionsByIdInputInputsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Read28Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class Update30Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Update30Input
    {
        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class List31Response
    {
        [JsonProperty("results")]
        public List31ResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("paging")]
        public List31ResponsePagingType Paging { get; set; }
    }

    public class List31ResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class List31ResponsePagingType
    {
        [JsonProperty("next")]
        public List31ResponsePagingTypeNextType Next { get; set; }
    }

    public class List31ResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Create32Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Create32Input
    {
        [JsonProperty("associations")]
        public Create32InputAssociationsTypeItem[] Associations { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class Create32InputAssociationsTypeItem
    {
        [JsonProperty("to")]
        public Create32InputAssociationsTypeItemToType To { get; set; }

        [JsonProperty("types")]
        public Create32InputAssociationsTypeItemTypesTypeItem[] Types { get; set; }
    }

    public class Create32InputAssociationsTypeItemToType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Create32InputAssociationsTypeItemTypesTypeItem
    {
        [JsonProperty("associationCategory")]
        public string AssociationCategory { get; set; }

        [JsonProperty("associationTypeId")]
        public string AssociationTypeId { get; set; }
    }

    public class MergeTwoFeedbackSubmissionsWithSameTypeResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class MergeTwoFeedbackSubmissionsWithSameTypeInput
    {
        [JsonProperty("objectIdToMerge")]
        public string ObjectIdToMerge { get; set; }

        [JsonProperty("primaryObjectId")]
        public string PrimaryObjectId { get; set; }
    }

    public class GdprDeleteFeedbackInput
    {
        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("idProperty")]
        public string IdProperty { get; set; }
    }

    public class PostCrmV3ObjectsFeedbackSubmissionsSearchResponse
    {
        [JsonProperty("results")]
        public PostCrmV3ObjectsFeedbackSubmissionsSearchResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("paging")]
        public PostCrmV3ObjectsFeedbackSubmissionsSearchResponsePagingType Paging { get; set; }
    }

    public class PostCrmV3ObjectsFeedbackSubmissionsSearchResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class PostCrmV3ObjectsFeedbackSubmissionsSearchResponsePagingType
    {
        [JsonProperty("next")]
        public PostCrmV3ObjectsFeedbackSubmissionsSearchResponsePagingTypeNextType Next { get; set; }
    }

    public class PostCrmV3ObjectsFeedbackSubmissionsSearchResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class PostCrmV3ObjectsFeedbackSubmissionsSearchInput
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("filterGroups")]
        public PostCrmV3ObjectsFeedbackSubmissionsSearchInputFilterGroupsTypeItem[] FilterGroups { get; set; }

        [JsonProperty("limit")]
        public string Limit { get; set; }

        [JsonProperty("properties")]
        public string[] Properties { get; set; }

        [JsonProperty("sorts")]
        public string[] Sorts { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
    }

    public class PostCrmV3ObjectsFeedbackSubmissionsSearchInputFilterGroupsTypeItem
    {
        [JsonProperty("filters")]
        public PostCrmV3ObjectsFeedbackSubmissionsSearchInputFilterGroupsTypeItemFiltersTypeItem[] Filters { get; set; }
    }

    public class PostCrmV3ObjectsFeedbackSubmissionsSearchInputFilterGroupsTypeItemFiltersTypeItem
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("highValue")]
        public string HighValue { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class ArchiveABatchOfQuotesByIdInput
    {
        [JsonProperty("inputs")]
        public ArchiveABatchOfQuotesByIdInputInputsTypeItem[] Inputs { get; set; }
    }

    public class ArchiveABatchOfQuotesByIdInputInputsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class List40Response
    {
        [JsonProperty("results")]
        public List40ResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("paging")]
        public List40ResponsePagingType Paging { get; set; }
    }

    public class List40ResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class List40ResponsePagingType
    {
        [JsonProperty("next")]
        public List40ResponsePagingTypeNextType Next { get; set; }
    }

    public class List40ResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Create41Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Create41Input
    {
        [JsonProperty("associations")]
        public Create41InputAssociationsTypeItem[] Associations { get; set; }

        [JsonProperty("properties")]
        public Create41InputPropertiesType Properties { get; set; }
    }

    public class Create41InputAssociationsTypeItem
    {
        [JsonProperty("to")]
        public Create41InputAssociationsTypeItemToType To { get; set; }

        [JsonProperty("types")]
        public Create41InputAssociationsTypeItemTypesTypeItem[] Types { get; set; }
    }

    public class Create41InputAssociationsTypeItemToType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Create41InputAssociationsTypeItemTypesTypeItem
    {
        [JsonProperty("associationCategory")]
        public string AssociationCategory { get; set; }

        [JsonProperty("associationTypeId")]
        public string AssociationTypeId { get; set; }
    }

    public class Create41InputPropertiesType
    {
        [JsonProperty("elit_26")]
        public string Elit26 { get; set; }
    }

    public class Read42Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class Update44Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Update44Input
    {
        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class MergeTwoQuotesWithSameTypeResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class MergeTwoQuotesWithSameTypeInput
    {
        [JsonProperty("objectIdToMerge")]
        public string ObjectIdToMerge { get; set; }

        [JsonProperty("primaryObjectId")]
        public string PrimaryObjectId { get; set; }
    }

    public class GdprDeleteQuotesInput
    {
        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("idProperty")]
        public string IdProperty { get; set; }
    }

    public class PostCrmV3ObjectsQuotesSearchResponse
    {
        [JsonProperty("results")]
        public PostCrmV3ObjectsQuotesSearchResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("paging")]
        public PostCrmV3ObjectsQuotesSearchResponsePagingType Paging { get; set; }
    }

    public class PostCrmV3ObjectsQuotesSearchResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class PostCrmV3ObjectsQuotesSearchResponsePagingType
    {
        [JsonProperty("next")]
        public PostCrmV3ObjectsQuotesSearchResponsePagingTypeNextType Next { get; set; }
    }

    public class PostCrmV3ObjectsQuotesSearchResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class PostCrmV3ObjectsQuotesSearchInput
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("filterGroups")]
        public PostCrmV3ObjectsQuotesSearchInputFilterGroupsTypeItem[] FilterGroups { get; set; }

        [JsonProperty("limit")]
        public string Limit { get; set; }

        [JsonProperty("properties")]
        public string[] Properties { get; set; }

        [JsonProperty("sorts")]
        public string[] Sorts { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
    }

    public class PostCrmV3ObjectsQuotesSearchInputFilterGroupsTypeItem
    {
        [JsonProperty("filters")]
        public PostCrmV3ObjectsQuotesSearchInputFilterGroupsTypeItemFiltersTypeItem[] Filters { get; set; }
    }

    public class PostCrmV3ObjectsQuotesSearchInputFilterGroupsTypeItemFiltersTypeItem
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("highValue")]
        public string HighValue { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class ArchiveABatchOfTaxesByIdInput
    {
        [JsonProperty("inputs")]
        public ArchiveABatchOfTaxesByIdInputInputsTypeItem[] Inputs { get; set; }
    }

    public class ArchiveABatchOfTaxesByIdInputInputsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class List52Response
    {
        [JsonProperty("results")]
        public List52ResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("paging")]
        public List52ResponsePagingType Paging { get; set; }
    }

    public class List52ResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class List52ResponsePagingType
    {
        [JsonProperty("next")]
        public List52ResponsePagingTypeNextType Next { get; set; }
    }

    public class List52ResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Create53Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Create53Input
    {
        [JsonProperty("associations")]
        public Create53InputAssociationsTypeItem[] Associations { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class Create53InputAssociationsTypeItem
    {
        [JsonProperty("to")]
        public Create53InputAssociationsTypeItemToType To { get; set; }

        [JsonProperty("types")]
        public Create53InputAssociationsTypeItemTypesTypeItem[] Types { get; set; }
    }

    public class Create53InputAssociationsTypeItemToType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Create53InputAssociationsTypeItemTypesTypeItem
    {
        [JsonProperty("associationCategory")]
        public string AssociationCategory { get; set; }

        [JsonProperty("associationTypeId")]
        public string AssociationTypeId { get; set; }
    }

    public class Read54Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class Update56Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Update56Input
    {
        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class MergeTwoTaxesWithSameTypeResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class MergeTwoTaxesWithSameTypeInput
    {
        [JsonProperty("objectIdToMerge")]
        public string ObjectIdToMerge { get; set; }

        [JsonProperty("primaryObjectId")]
        public string PrimaryObjectId { get; set; }
    }

    public class GdprDeleteTaxesInput
    {
        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("idProperty")]
        public string IdProperty { get; set; }
    }

    public class PostCrmV3ObjectsTaxesSearchResponse
    {
        [JsonProperty("results")]
        public PostCrmV3ObjectsTaxesSearchResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("paging")]
        public PostCrmV3ObjectsTaxesSearchResponsePagingType Paging { get; set; }
    }

    public class PostCrmV3ObjectsTaxesSearchResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class PostCrmV3ObjectsTaxesSearchResponsePagingType
    {
        [JsonProperty("next")]
        public PostCrmV3ObjectsTaxesSearchResponsePagingTypeNextType Next { get; set; }
    }

    public class PostCrmV3ObjectsTaxesSearchResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class PostCrmV3ObjectsTaxesSearchInput
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("filterGroups")]
        public PostCrmV3ObjectsTaxesSearchInputFilterGroupsTypeItem[] FilterGroups { get; set; }

        [JsonProperty("limit")]
        public string Limit { get; set; }

        [JsonProperty("properties")]
        public string[] Properties { get; set; }

        [JsonProperty("sorts")]
        public string[] Sorts { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
    }

    public class PostCrmV3ObjectsTaxesSearchInputFilterGroupsTypeItem
    {
        [JsonProperty("filters")]
        public PostCrmV3ObjectsTaxesSearchInputFilterGroupsTypeItemFiltersTypeItem[] Filters { get; set; }
    }

    public class PostCrmV3ObjectsTaxesSearchInputFilterGroupsTypeItemFiltersTypeItem
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("highValue")]
        public string HighValue { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class ArchiveABatchOfTicketsByIdInput
    {
        [JsonProperty("inputs")]
        public ArchiveABatchOfTicketsByIdInputInputsTypeItem[] Inputs { get; set; }
    }

    public class ArchiveABatchOfTicketsByIdInputInputsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Read64Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class Update66Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Update66Input
    {
        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class List67Response
    {
        [JsonProperty("results")]
        public List67ResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("paging")]
        public List67ResponsePagingType Paging { get; set; }
    }

    public class List67ResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("associations")]
        public JToken Associations { get; set; }
    }

    public class List67ResponsePagingType
    {
        [JsonProperty("next")]
        public List67ResponsePagingTypeNextType Next { get; set; }
    }

    public class List67ResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Create68Response
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class Create68Input
    {
        [JsonProperty("associations")]
        public Create68InputAssociationsTypeItem[] Associations { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class Create68InputAssociationsTypeItem
    {
        [JsonProperty("to")]
        public Create68InputAssociationsTypeItemToType To { get; set; }

        [JsonProperty("types")]
        public Create68InputAssociationsTypeItemTypesTypeItem[] Types { get; set; }
    }

    public class Create68InputAssociationsTypeItemToType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Create68InputAssociationsTypeItemTypesTypeItem
    {
        [JsonProperty("associationCategory")]
        public string AssociationCategory { get; set; }

        [JsonProperty("associationTypeId")]
        public string AssociationTypeId { get; set; }
    }

    public class MergeTwoTicketsWithSameTypeResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class MergeTwoTicketsWithSameTypeInput
    {
        [JsonProperty("objectIdToMerge")]
        public string ObjectIdToMerge { get; set; }

        [JsonProperty("primaryObjectId")]
        public string PrimaryObjectId { get; set; }
    }

    public class GdprDeleteTicketsInput
    {
        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("idProperty")]
        public string IdProperty { get; set; }
    }

    public class PostCrmV3ObjectsTicketsSearchResponse
    {
        [JsonProperty("results")]
        public PostCrmV3ObjectsTicketsSearchResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("paging")]
        public PostCrmV3ObjectsTicketsSearchResponsePagingType Paging { get; set; }
    }

    public class PostCrmV3ObjectsTicketsSearchResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("propertiesWithHistory")]
        public JToken PropertiesWithHistory { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }
    }

    public class PostCrmV3ObjectsTicketsSearchResponsePagingType
    {
        [JsonProperty("next")]
        public PostCrmV3ObjectsTicketsSearchResponsePagingTypeNextType Next { get; set; }
    }

    public class PostCrmV3ObjectsTicketsSearchResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class PostCrmV3ObjectsTicketsSearchInput
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("filterGroups")]
        public PostCrmV3ObjectsTicketsSearchInputFilterGroupsTypeItem[] FilterGroups { get; set; }

        [JsonProperty("limit")]
        public string Limit { get; set; }

        [JsonProperty("properties")]
        public string[] Properties { get; set; }

        [JsonProperty("sorts")]
        public string[] Sorts { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
    }

    public class PostCrmV3ObjectsTicketsSearchInputFilterGroupsTypeItem
    {
        [JsonProperty("filters")]
        public PostCrmV3ObjectsTicketsSearchInputFilterGroupsTypeItemFiltersTypeItem[] Filters { get; set; }
    }

    public class PostCrmV3ObjectsTicketsSearchInputFilterGroupsTypeItemFiltersTypeItem
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("highValue")]
        public string HighValue { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class ListAssociationTypesResponse
    {
        [JsonProperty("results")]
        public ListAssociationTypesResponseResultsTypeItem[] Results { get; set; }
    }

    public class ListAssociationTypesResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DeleteSpecificLabelsInput
    {
        [JsonProperty("inputs")]
        public DeleteSpecificLabelsInputInputsTypeItem[] Inputs { get; set; }
    }

    public class DeleteSpecificLabelsInputInputsTypeItem
    {
        [JsonProperty("from")]
        public DeleteSpecificLabelsInputInputsTypeItemFromType From { get; set; }

        [JsonProperty("to")]
        public DeleteSpecificLabelsInputInputsTypeItemToType To { get; set; }

        [JsonProperty("types")]
        public DeleteSpecificLabelsInputInputsTypeItemTypesTypeItem[] Types { get; set; }
    }

    public class DeleteSpecificLabelsInputInputsTypeItemFromType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class DeleteSpecificLabelsInputInputsTypeItemToType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class DeleteSpecificLabelsInputInputsTypeItemTypesTypeItem
    {
        [JsonProperty("associationCategory")]
        public string AssociationCategory { get; set; }

        [JsonProperty("associationTypeId")]
        public string AssociationTypeId { get; set; }
    }

    public class DeleteInput
    {
        [JsonProperty("inputs")]
        public DeleteInputInputsTypeItem[] Inputs { get; set; }
    }

    public class DeleteInputInputsTypeItem
    {
        [JsonProperty("from")]
        public DeleteInputInputsTypeItemFromType From { get; set; }

        [JsonProperty("to")]
        public DeleteInputInputsTypeItemToTypeItem[] To { get; set; }
    }

    public class DeleteInputInputsTypeItemFromType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class DeleteInputInputsTypeItemToTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateDefaultAssociationsResponse
    {
        [JsonProperty("completedAt")]
        public string CompletedAt { get; set; }

        [JsonProperty("results")]
        public CreateDefaultAssociationsResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("startedAt")]
        public string StartedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("numErrors")]
        public int NumErrors { get; set; }

        [JsonProperty("requestedAt")]
        public string RequestedAt { get; set; }

        [JsonProperty("links")]
        public JToken Links { get; set; }

        [JsonProperty("errors")]
        public CreateDefaultAssociationsResponseErrorsTypeItem[] Errors { get; set; }
    }

    public class CreateDefaultAssociationsResponseResultsTypeItem
    {
        [JsonProperty("associationSpec")]
        public CreateDefaultAssociationsResponseResultsTypeItemAssociationSpecType AssociationSpec { get; set; }

        [JsonProperty("from")]
        public CreateDefaultAssociationsResponseResultsTypeItemFromType From { get; set; }

        [JsonProperty("to")]
        public CreateDefaultAssociationsResponseResultsTypeItemToType To { get; set; }
    }

    public class CreateDefaultAssociationsResponseResultsTypeItemAssociationSpecType
    {
        [JsonProperty("associationCategory")]
        public string AssociationCategory { get; set; }

        [JsonProperty("associationTypeId")]
        public string AssociationTypeId { get; set; }
    }

    public class CreateDefaultAssociationsResponseResultsTypeItemFromType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateDefaultAssociationsResponseResultsTypeItemToType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateDefaultAssociationsResponseErrorsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("context")]
        public JToken Context { get; set; }

        [JsonProperty("errors")]
        public CreateDefaultAssociationsResponseErrorsTypeItemErrorsTypeItem[] Errors { get; set; }

        [JsonProperty("links")]
        public JToken Links { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subCategory")]
        public JToken SubCategory { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateDefaultAssociationsResponseErrorsTypeItemErrorsTypeItem
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("subCategory")]
        public string SubCategory { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("in")]
        public string In { get; set; }

        [JsonProperty("context")]
        public JToken Context { get; set; }
    }

    public class CreateDefaultAssociationsInput
    {
        [JsonProperty("inputs")]
        public CreateDefaultAssociationsInputInputsTypeItem[] Inputs { get; set; }
    }

    public class CreateDefaultAssociationsInputInputsTypeItem
    {
        [JsonProperty("from")]
        public CreateDefaultAssociationsInputInputsTypeItemFromType From { get; set; }

        [JsonProperty("to")]
        public CreateDefaultAssociationsInputInputsTypeItemToType To { get; set; }
    }

    public class CreateDefaultAssociationsInputInputsTypeItemFromType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateDefaultAssociationsInputInputsTypeItemToType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Create7Response
    {
        [JsonProperty("fromObjectId")]
        public string FromObjectId { get; set; }

        [JsonProperty("fromObjectTypeId")]
        public string FromObjectTypeId { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }

        [JsonProperty("toObjectId")]
        public string ToObjectId { get; set; }

        [JsonProperty("toObjectTypeId")]
        public string ToObjectTypeId { get; set; }
    }

    public class bodyInputItem
    {
        [JsonProperty("associationCategory")]
        public string AssociationCategory { get; set; }

        [JsonProperty("associationTypeId")]
        public string AssociationTypeId { get; set; }
    }

    public class CreateDefaultResponse
    {
        [JsonProperty("completedAt")]
        public string CompletedAt { get; set; }

        [JsonProperty("results")]
        public CreateDefaultResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("startedAt")]
        public string StartedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("numErrors")]
        public int NumErrors { get; set; }

        [JsonProperty("requestedAt")]
        public string RequestedAt { get; set; }

        [JsonProperty("links")]
        public JToken Links { get; set; }

        [JsonProperty("errors")]
        public CreateDefaultResponseErrorsTypeItem[] Errors { get; set; }
    }

    public class CreateDefaultResponseResultsTypeItem
    {
        [JsonProperty("associationSpec")]
        public CreateDefaultResponseResultsTypeItemAssociationSpecType AssociationSpec { get; set; }

        [JsonProperty("from")]
        public CreateDefaultResponseResultsTypeItemFromType From { get; set; }

        [JsonProperty("to")]
        public CreateDefaultResponseResultsTypeItemToType To { get; set; }
    }

    public class CreateDefaultResponseResultsTypeItemAssociationSpecType
    {
        [JsonProperty("associationCategory")]
        public string AssociationCategory { get; set; }

        [JsonProperty("associationTypeId")]
        public string AssociationTypeId { get; set; }
    }

    public class CreateDefaultResponseResultsTypeItemFromType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateDefaultResponseResultsTypeItemToType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateDefaultResponseErrorsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("context")]
        public JToken Context { get; set; }

        [JsonProperty("errors")]
        public CreateDefaultResponseErrorsTypeItemErrorsTypeItem[] Errors { get; set; }

        [JsonProperty("links")]
        public JToken Links { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subCategory")]
        public JToken SubCategory { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateDefaultResponseErrorsTypeItemErrorsTypeItem
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("subCategory")]
        public string SubCategory { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("in")]
        public string In { get; set; }

        [JsonProperty("context")]
        public JToken Context { get; set; }
    }

    public class ListAssociationsResponse
    {
        [JsonProperty("results")]
        public ListAssociationsResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("paging")]
        public ListAssociationsResponsePagingType Paging { get; set; }
    }

    public class ListAssociationsResponseResultsTypeItem
    {
        [JsonProperty("associationTypes")]
        public ListAssociationsResponseResultsTypeItemAssociationTypesTypeItem[] AssociationTypes { get; set; }

        [JsonProperty("toObjectId")]
        public string ToObjectId { get; set; }
    }

    public class ListAssociationsResponseResultsTypeItemAssociationTypesTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("typeId")]
        public string TypeId { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class ListAssociationsResponsePagingType
    {
        [JsonProperty("next")]
        public ListAssociationsResponsePagingTypeNextType Next { get; set; }
    }

    public class ListAssociationsResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class GetAllCardsResponse
    {
        [JsonProperty("results")]
        public GetAllCardsResponseResultsTypeItem[] Results { get; set; }
    }

    public class GetAllCardsResponseResultsTypeItem
    {
        [JsonProperty("actions")]
        public GetAllCardsResponseResultsTypeItemActionsType Actions { get; set; }

        [JsonProperty("auditHistory")]
        public GetAllCardsResponseResultsTypeItemAuditHistoryTypeItem[] AuditHistory { get; set; }

        [JsonProperty("display")]
        public GetAllCardsResponseResultsTypeItemDisplayType Display { get; set; }

        [JsonProperty("fetch")]
        public GetAllCardsResponseResultsTypeItemFetchType Fetch { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class GetAllCardsResponseResultsTypeItemActionsType
    {
        [JsonProperty("baseUrls")]
        public string[] BaseUrls { get; set; }
    }

    public class GetAllCardsResponseResultsTypeItemAuditHistoryTypeItem
    {
        [JsonProperty("actionType")]
        public string ActionType { get; set; }

        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        [JsonProperty("authSource")]
        public string AuthSource { get; set; }

        [JsonProperty("changedAt")]
        public string ChangedAt { get; set; }

        [JsonProperty("initiatingUserId")]
        public string InitiatingUserId { get; set; }

        [JsonProperty("objectTypeId")]
        public string ObjectTypeId { get; set; }
    }

    public class GetAllCardsResponseResultsTypeItemDisplayType
    {
        [JsonProperty("properties")]
        public GetAllCardsResponseResultsTypeItemDisplayTypePropertiesTypeItem[] Properties { get; set; }
    }

    public class GetAllCardsResponseResultsTypeItemDisplayTypePropertiesTypeItem
    {
        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("options")]
        public GetAllCardsResponseResultsTypeItemDisplayTypePropertiesTypeItemOptionsTypeItem[] Options { get; set; }
    }

    public class GetAllCardsResponseResultsTypeItemDisplayTypePropertiesTypeItemOptionsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetAllCardsResponseResultsTypeItemFetchType
    {
        [JsonProperty("objectTypes")]
        public GetAllCardsResponseResultsTypeItemFetchTypeObjectTypesTypeItem[] ObjectTypes { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }
    }

    public class GetAllCardsResponseResultsTypeItemFetchTypeObjectTypesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("propertiesToSend")]
        public string[] PropertiesToSend { get; set; }
    }

    public class CreateANewCardResponse
    {
        [JsonProperty("actions")]
        public CreateANewCardResponseActionsType Actions { get; set; }

        [JsonProperty("auditHistory")]
        public CreateANewCardResponseAuditHistoryTypeItem[] AuditHistory { get; set; }

        [JsonProperty("display")]
        public CreateANewCardResponseDisplayType Display { get; set; }

        [JsonProperty("fetch")]
        public CreateANewCardResponseFetchType Fetch { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class CreateANewCardResponseActionsType
    {
        [JsonProperty("baseUrls")]
        public string[] BaseUrls { get; set; }
    }

    public class CreateANewCardResponseAuditHistoryTypeItem
    {
        [JsonProperty("actionType")]
        public string ActionType { get; set; }

        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        [JsonProperty("authSource")]
        public string AuthSource { get; set; }

        [JsonProperty("changedAt")]
        public string ChangedAt { get; set; }

        [JsonProperty("initiatingUserId")]
        public string InitiatingUserId { get; set; }

        [JsonProperty("objectTypeId")]
        public string ObjectTypeId { get; set; }
    }

    public class CreateANewCardResponseDisplayType
    {
        [JsonProperty("properties")]
        public CreateANewCardResponseDisplayTypePropertiesTypeItem[] Properties { get; set; }
    }

    public class CreateANewCardResponseDisplayTypePropertiesTypeItem
    {
        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("options")]
        public CreateANewCardResponseDisplayTypePropertiesTypeItemOptionsTypeItem[] Options { get; set; }
    }

    public class CreateANewCardResponseDisplayTypePropertiesTypeItemOptionsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class CreateANewCardResponseFetchType
    {
        [JsonProperty("objectTypes")]
        public CreateANewCardResponseFetchTypeObjectTypesTypeItem[] ObjectTypes { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }
    }

    public class CreateANewCardResponseFetchTypeObjectTypesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("propertiesToSend")]
        public string[] PropertiesToSend { get; set; }
    }

    public class CreateANewCardInput
    {
        [JsonProperty("actions")]
        public CreateANewCardInputActionsType Actions { get; set; }

        [JsonProperty("display")]
        public CreateANewCardInputDisplayType Display { get; set; }

        [JsonProperty("fetch")]
        public CreateANewCardInputFetchType Fetch { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class CreateANewCardInputActionsType
    {
        [JsonProperty("baseUrls")]
        public string[] BaseUrls { get; set; }
    }

    public class CreateANewCardInputDisplayType
    {
        [JsonProperty("properties")]
        public CreateANewCardInputDisplayTypePropertiesTypeItem[] Properties { get; set; }
    }

    public class CreateANewCardInputDisplayTypePropertiesTypeItem
    {
        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("options")]
        public CreateANewCardInputDisplayTypePropertiesTypeItemOptionsTypeItem[] Options { get; set; }
    }

    public class CreateANewCardInputDisplayTypePropertiesTypeItemOptionsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class CreateANewCardInputFetchType
    {
        [JsonProperty("objectTypes")]
        public CreateANewCardInputFetchTypeObjectTypesTypeItem[] ObjectTypes { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("cardType")]
        public string CardType { get; set; }

        [JsonProperty("serverlessFunction")]
        public string ServerlessFunction { get; set; }
    }

    public class CreateANewCardInputFetchTypeObjectTypesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("propertiesToSend")]
        public string[] PropertiesToSend { get; set; }
    }

    public class GetACardResponse
    {
        [JsonProperty("actions")]
        public GetACardResponseActionsType Actions { get; set; }

        [JsonProperty("auditHistory")]
        public GetACardResponseAuditHistoryTypeItem[] AuditHistory { get; set; }

        [JsonProperty("display")]
        public GetACardResponseDisplayType Display { get; set; }

        [JsonProperty("fetch")]
        public GetACardResponseFetchType Fetch { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class GetACardResponseActionsType
    {
        [JsonProperty("baseUrls")]
        public string[] BaseUrls { get; set; }
    }

    public class GetACardResponseAuditHistoryTypeItem
    {
        [JsonProperty("actionType")]
        public string ActionType { get; set; }

        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        [JsonProperty("authSource")]
        public string AuthSource { get; set; }

        [JsonProperty("changedAt")]
        public string ChangedAt { get; set; }

        [JsonProperty("initiatingUserId")]
        public string InitiatingUserId { get; set; }

        [JsonProperty("objectTypeId")]
        public string ObjectTypeId { get; set; }
    }

    public class GetACardResponseDisplayType
    {
        [JsonProperty("properties")]
        public GetACardResponseDisplayTypePropertiesTypeItem[] Properties { get; set; }
    }

    public class GetACardResponseDisplayTypePropertiesTypeItem
    {
        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("options")]
        public GetACardResponseDisplayTypePropertiesTypeItemOptionsTypeItem[] Options { get; set; }
    }

    public class GetACardResponseDisplayTypePropertiesTypeItemOptionsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetACardResponseFetchType
    {
        [JsonProperty("objectTypes")]
        public GetACardResponseFetchTypeObjectTypesTypeItem[] ObjectTypes { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }
    }

    public class GetACardResponseFetchTypeObjectTypesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("propertiesToSend")]
        public string[] PropertiesToSend { get; set; }
    }

    public class UpdateACardResponse
    {
        [JsonProperty("actions")]
        public UpdateACardResponseActionsType Actions { get; set; }

        [JsonProperty("auditHistory")]
        public UpdateACardResponseAuditHistoryTypeItem[] AuditHistory { get; set; }

        [JsonProperty("display")]
        public UpdateACardResponseDisplayType Display { get; set; }

        [JsonProperty("fetch")]
        public UpdateACardResponseFetchType Fetch { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class UpdateACardResponseActionsType
    {
        [JsonProperty("baseUrls")]
        public string[] BaseUrls { get; set; }
    }

    public class UpdateACardResponseAuditHistoryTypeItem
    {
        [JsonProperty("actionType")]
        public string ActionType { get; set; }

        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        [JsonProperty("authSource")]
        public string AuthSource { get; set; }

        [JsonProperty("changedAt")]
        public string ChangedAt { get; set; }

        [JsonProperty("initiatingUserId")]
        public string InitiatingUserId { get; set; }

        [JsonProperty("objectTypeId")]
        public string ObjectTypeId { get; set; }
    }

    public class UpdateACardResponseDisplayType
    {
        [JsonProperty("properties")]
        public UpdateACardResponseDisplayTypePropertiesTypeItem[] Properties { get; set; }
    }

    public class UpdateACardResponseDisplayTypePropertiesTypeItem
    {
        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("options")]
        public UpdateACardResponseDisplayTypePropertiesTypeItemOptionsTypeItem[] Options { get; set; }
    }

    public class UpdateACardResponseDisplayTypePropertiesTypeItemOptionsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UpdateACardResponseFetchType
    {
        [JsonProperty("objectTypes")]
        public UpdateACardResponseFetchTypeObjectTypesTypeItem[] ObjectTypes { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }
    }

    public class UpdateACardResponseFetchTypeObjectTypesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("propertiesToSend")]
        public string[] PropertiesToSend { get; set; }
    }

    public class UpdateACardInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("fetch")]
        public UpdateACardInputFetchType Fetch { get; set; }

        [JsonProperty("display")]
        public UpdateACardInputDisplayType Display { get; set; }

        [JsonProperty("actions")]
        public UpdateACardInputActionsType Actions { get; set; }
    }

    public class UpdateACardInputFetchType
    {
        [JsonProperty("objectTypes")]
        public UpdateACardInputFetchTypeObjectTypesTypeItem[] ObjectTypes { get; set; }

        [JsonProperty("cardType")]
        public string CardType { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("serverlessFunction")]
        public string ServerlessFunction { get; set; }
    }

    public class UpdateACardInputFetchTypeObjectTypesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("propertiesToSend")]
        public string[] PropertiesToSend { get; set; }
    }

    public class UpdateACardInputDisplayType
    {
        [JsonProperty("properties")]
        public UpdateACardInputDisplayTypePropertiesTypeItem[] Properties { get; set; }
    }

    public class UpdateACardInputDisplayTypePropertiesTypeItem
    {
        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("options")]
        public UpdateACardInputDisplayTypePropertiesTypeItemOptionsTypeItem[] Options { get; set; }
    }

    public class UpdateACardInputDisplayTypePropertiesTypeItemOptionsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UpdateACardInputActionsType
    {
        [JsonProperty("baseUrls")]
        public string[] BaseUrls { get; set; }
    }

    public class GetSampleCardDetailResponseResponse
    {
        [JsonProperty("totalCount")]
        public string TotalCount { get; set; }

        [JsonProperty("allItemsLinkUrl")]
        public string AllItemsLinkUrl { get; set; }

        [JsonProperty("cardLabel")]
        public string CardLabel { get; set; }

        [JsonProperty("topLevelActions")]
        public GetSampleCardDetailResponseResponseTopLevelActionsType TopLevelActions { get; set; }

        [JsonProperty("sections")]
        public GetSampleCardDetailResponseResponseSectionsTypeItem[] Sections { get; set; }

        [JsonProperty("responseVersion")]
        public string ResponseVersion { get; set; }
    }

    public class GetSampleCardDetailResponseResponseTopLevelActionsType
    {
        [JsonProperty("secondary")]
        public GetSampleCardDetailResponseResponseTopLevelActionsTypeSecondaryTypeItem[] Secondary { get; set; }

        [JsonProperty("settings")]
        public GetSampleCardDetailResponseResponseTopLevelActionsTypeSettingsType Settings { get; set; }

        [JsonProperty("primary")]
        public GetSampleCardDetailResponseResponseTopLevelActionsTypePrimaryType Primary { get; set; }
    }

    public class GetSampleCardDetailResponseResponseTopLevelActionsTypeSecondaryTypeItem
    {
        [JsonProperty("httpMethod")]
        public string HttpMethod { get; set; }

        [JsonProperty("propertyNamesIncluded")]
        public string[] PropertyNamesIncluded { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("confirmation")]
        public GetSampleCardDetailResponseResponseTopLevelActionsTypeSecondaryTypeItemConfirmationType Confirmation { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class GetSampleCardDetailResponseResponseTopLevelActionsTypeSecondaryTypeItemConfirmationType
    {
        [JsonProperty("cancelButtonLabel")]
        public string CancelButtonLabel { get; set; }

        [JsonProperty("confirmButtonLabel")]
        public string ConfirmButtonLabel { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }
    }

    public class GetSampleCardDetailResponseResponseTopLevelActionsTypeSettingsType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("propertyNamesIncluded")]
        public string[] PropertyNamesIncluded { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class GetSampleCardDetailResponseResponseTopLevelActionsTypePrimaryType
    {
        [JsonProperty("httpMethod")]
        public string HttpMethod { get; set; }

        [JsonProperty("propertyNamesIncluded")]
        public string[] PropertyNamesIncluded { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("confirmation")]
        public GetSampleCardDetailResponseResponseTopLevelActionsTypePrimaryTypeConfirmationType Confirmation { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class GetSampleCardDetailResponseResponseTopLevelActionsTypePrimaryTypeConfirmationType
    {
        [JsonProperty("cancelButtonLabel")]
        public string CancelButtonLabel { get; set; }

        [JsonProperty("confirmButtonLabel")]
        public string ConfirmButtonLabel { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }
    }

    public class GetSampleCardDetailResponseResponseSectionsTypeItem
    {
        [JsonProperty("actions")]
        public GetSampleCardDetailResponseResponseSectionsTypeItemActionsTypeItem[] Actions { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("tokens")]
        public GetSampleCardDetailResponseResponseSectionsTypeItemTokensTypeItem[] Tokens { get; set; }

        [JsonProperty("linkUrl")]
        public string LinkUrl { get; set; }
    }

    public class GetSampleCardDetailResponseResponseSectionsTypeItemActionsTypeItem
    {
        [JsonProperty("httpMethod")]
        public string HttpMethod { get; set; }

        [JsonProperty("propertyNamesIncluded")]
        public string[] PropertyNamesIncluded { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("confirmation")]
        public GetSampleCardDetailResponseResponseSectionsTypeItemActionsTypeItemConfirmationType Confirmation { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class GetSampleCardDetailResponseResponseSectionsTypeItemActionsTypeItemConfirmationType
    {
        [JsonProperty("cancelButtonLabel")]
        public string CancelButtonLabel { get; set; }

        [JsonProperty("confirmButtonLabel")]
        public string ConfirmButtonLabel { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }
    }

    public class GetSampleCardDetailResponseResponseSectionsTypeItemTokensTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }
    }

    public class GetCrmV3ExportsExportAsyncTasksTaskIdStatusResponse
    {
        [JsonProperty("completedAt")]
        public string CompletedAt { get; set; }

        [JsonProperty("startedAt")]
        public string StartedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("numErrors")]
        public int NumErrors { get; set; }

        [JsonProperty("errors")]
        public GetCrmV3ExportsExportAsyncTasksTaskIdStatusResponseErrorsTypeItem[] Errors { get; set; }

        [JsonProperty("requestedAt")]
        public string RequestedAt { get; set; }

        [JsonProperty("links")]
        public JToken Links { get; set; }
    }

    public class GetCrmV3ExportsExportAsyncTasksTaskIdStatusResponseErrorsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("context")]
        public JToken Context { get; set; }

        [JsonProperty("errors")]
        public GetCrmV3ExportsExportAsyncTasksTaskIdStatusResponseErrorsTypeItemErrorsTypeItem[] Errors { get; set; }

        [JsonProperty("links")]
        public JToken Links { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("subCategory")]
        public JToken SubCategory { get; set; }
    }

    public class GetCrmV3ExportsExportAsyncTasksTaskIdStatusResponseErrorsTypeItemErrorsTypeItem
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("in")]
        public string In { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("subCategory")]
        public string SubCategory { get; set; }

        [JsonProperty("context")]
        public JToken Context { get; set; }
    }

    public class StartAnExportResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("links")]
        public JToken Links { get; set; }
    }

    public class StartAnExportInput
    {
        [JsonProperty("exportName")]
        public string ExportName { get; set; }

        [JsonProperty("exportType")]
        public string ExportType { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("objectProperties")]
        public string[] ObjectProperties { get; set; }

        [JsonProperty("objectType")]
        public string ObjectType { get; set; }

        [JsonProperty("associatedObjectType")]
        public string AssociatedObjectType { get; set; }

        [JsonProperty("publicCrmSearchRequest")]
        public StartAnExportInputPublicCrmSearchRequestType PublicCrmSearchRequest { get; set; }
    }

    public class StartAnExportInputPublicCrmSearchRequestType
    {
        [JsonProperty("filters")]
        public StartAnExportInputPublicCrmSearchRequestTypeFiltersTypeItem[] Filters { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("sorts")]
        public string[] Sorts { get; set; }
    }

    public class StartAnExportInputPublicCrmSearchRequestTypeFiltersTypeItem
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("highValue")]
        public string HighValue { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class GetTheInformationOnAnyImportResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("metadata")]
        public GetTheInformationOnAnyImportResponseMetadataType Metadata { get; set; }

        [JsonProperty("optOutImport")]
        public string OptOutImport { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("importTemplate")]
        public GetTheInformationOnAnyImportResponseImportTemplateType ImportTemplate { get; set; }

        [JsonProperty("importRequestJson")]
        public JToken ImportRequestJson { get; set; }

        [JsonProperty("importSource")]
        public string ImportSource { get; set; }

        [JsonProperty("importName")]
        public string ImportName { get; set; }
    }

    public class GetTheInformationOnAnyImportResponseMetadataType
    {
        [JsonProperty("counters")]
        public JToken Counters { get; set; }

        [JsonProperty("fileIds")]
        public string[] FileIds { get; set; }

        [JsonProperty("objectLists")]
        public GetTheInformationOnAnyImportResponseMetadataTypeObjectListsTypeItem[] ObjectLists { get; set; }
    }

    public class GetTheInformationOnAnyImportResponseMetadataTypeObjectListsTypeItem
    {
        [JsonProperty("listId")]
        public string ListId { get; set; }

        [JsonProperty("objectType")]
        public string ObjectType { get; set; }
    }

    public class GetTheInformationOnAnyImportResponseImportTemplateType
    {
        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("templateType")]
        public string TemplateType { get; set; }
    }

    public class CancelAnActiveImportResponse
    {
        [JsonProperty("completedAt")]
        public string CompletedAt { get; set; }

        [JsonProperty("startedAt")]
        public string StartedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("requestedAt")]
        public string RequestedAt { get; set; }

        [JsonProperty("links")]
        public JToken Links { get; set; }
    }

    public class GetActiveImportsResponse
    {
        [JsonProperty("results")]
        public GetActiveImportsResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("paging")]
        public GetActiveImportsResponsePagingType Paging { get; set; }
    }

    public class GetActiveImportsResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("metadata")]
        public GetActiveImportsResponseResultsTypeItemMetadataType Metadata { get; set; }

        [JsonProperty("optOutImport")]
        public string OptOutImport { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("importTemplate")]
        public GetActiveImportsResponseResultsTypeItemImportTemplateType ImportTemplate { get; set; }

        [JsonProperty("importRequestJson")]
        public JToken ImportRequestJson { get; set; }

        [JsonProperty("importSource")]
        public string ImportSource { get; set; }

        [JsonProperty("importName")]
        public string ImportName { get; set; }
    }

    public class GetActiveImportsResponseResultsTypeItemMetadataType
    {
        [JsonProperty("counters")]
        public JToken Counters { get; set; }

        [JsonProperty("fileIds")]
        public string[] FileIds { get; set; }

        [JsonProperty("objectLists")]
        public GetActiveImportsResponseResultsTypeItemMetadataTypeObjectListsTypeItem[] ObjectLists { get; set; }
    }

    public class GetActiveImportsResponseResultsTypeItemMetadataTypeObjectListsTypeItem
    {
        [JsonProperty("listId")]
        public string ListId { get; set; }

        [JsonProperty("objectType")]
        public string ObjectType { get; set; }
    }

    public class GetActiveImportsResponseResultsTypeItemImportTemplateType
    {
        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("templateType")]
        public string TemplateType { get; set; }
    }

    public class GetActiveImportsResponsePagingType
    {
        [JsonProperty("next")]
        public GetActiveImportsResponsePagingTypeNextType Next { get; set; }

        [JsonProperty("prev")]
        public GetActiveImportsResponsePagingTypePrevType Prev { get; set; }
    }

    public class GetActiveImportsResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class GetActiveImportsResponsePagingTypePrevType
    {
        [JsonProperty("before")]
        public string Before { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class StartANewImportResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("metadata")]
        public StartANewImportResponseMetadataType Metadata { get; set; }

        [JsonProperty("optOutImport")]
        public string OptOutImport { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("importTemplate")]
        public StartANewImportResponseImportTemplateType ImportTemplate { get; set; }

        [JsonProperty("importRequestJson")]
        public JToken ImportRequestJson { get; set; }

        [JsonProperty("importSource")]
        public string ImportSource { get; set; }

        [JsonProperty("importName")]
        public string ImportName { get; set; }
    }

    public class StartANewImportResponseMetadataType
    {
        [JsonProperty("counters")]
        public JToken Counters { get; set; }

        [JsonProperty("fileIds")]
        public string[] FileIds { get; set; }

        [JsonProperty("objectLists")]
        public StartANewImportResponseMetadataTypeObjectListsTypeItem[] ObjectLists { get; set; }
    }

    public class StartANewImportResponseMetadataTypeObjectListsTypeItem
    {
        [JsonProperty("listId")]
        public string ListId { get; set; }

        [JsonProperty("objectType")]
        public string ObjectType { get; set; }
    }

    public class StartANewImportResponseImportTemplateType
    {
        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("templateType")]
        public string TemplateType { get; set; }
    }

    public class GetCrmV3ImportsImportIdErrorsGetErrorsResponse
    {
        [JsonProperty("results")]
        public GetCrmV3ImportsImportIdErrorsGetErrorsResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("paging")]
        public GetCrmV3ImportsImportIdErrorsGetErrorsResponsePagingType Paging { get; set; }
    }

    public class GetCrmV3ImportsImportIdErrorsGetErrorsResponseResultsTypeItem
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("errorType")]
        public string ErrorType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sourceData")]
        public GetCrmV3ImportsImportIdErrorsGetErrorsResponseResultsTypeItemSourceDataType SourceData { get; set; }

        [JsonProperty("objectType")]
        public string ObjectType { get; set; }

        [JsonProperty("invalidValue")]
        public string InvalidValue { get; set; }

        [JsonProperty("extraContext")]
        public string ExtraContext { get; set; }

        [JsonProperty("objectTypeId")]
        public string ObjectTypeId { get; set; }

        [JsonProperty("knownColumnNumber")]
        public string KnownColumnNumber { get; set; }
    }

    public class GetCrmV3ImportsImportIdErrorsGetErrorsResponseResultsTypeItemSourceDataType
    {
        [JsonProperty("fileId")]
        public string FileId { get; set; }

        [JsonProperty("lineNumber")]
        public string LineNumber { get; set; }

        [JsonProperty("rowData")]
        public string[] RowData { get; set; }

        [JsonProperty("pageName")]
        public string PageName { get; set; }
    }

    public class GetCrmV3ImportsImportIdErrorsGetErrorsResponsePagingType
    {
        [JsonProperty("next")]
        public GetCrmV3ImportsImportIdErrorsGetErrorsResponsePagingTypeNextType Next { get; set; }
    }

    public class GetCrmV3ImportsImportIdErrorsGetErrorsResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class AddAndOrRemoveRecordsFromAListResponse
    {
        [JsonProperty("recordIdsMissing")]
        public string[] RecordIdsMissing { get; set; }

        [JsonProperty("recordIdsRemoved")]
        public string[] RecordIdsRemoved { get; set; }

        [JsonProperty("recordsIdsAdded")]
        public string[] RecordsIdsAdded { get; set; }
    }

    public class AddAndOrRemoveRecordsFromAListInput
    {
        [JsonProperty("recordIdsToAdd")]
        public string[] RecordIdsToAdd { get; set; }

        [JsonProperty("recordIdsToRemove")]
        public string[] RecordIdsToRemove { get; set; }
    }

    public class AddRecordsToAListResponse
    {
        [JsonProperty("recordIdsMissing")]
        public string[] RecordIdsMissing { get; set; }

        [JsonProperty("recordIdsRemoved")]
        public string[] RecordIdsRemoved { get; set; }

        [JsonProperty("recordsIdsAdded")]
        public string[] RecordsIdsAdded { get; set; }
    }

    public class FetchListMembershipsOrderedByIdResponse
    {
        [JsonProperty("results")]
        public string[] Results { get; set; }

        [JsonProperty("paging")]
        public FetchListMembershipsOrderedByIdResponsePagingType Paging { get; set; }
    }

    public class FetchListMembershipsOrderedByIdResponsePagingType
    {
        [JsonProperty("next")]
        public FetchListMembershipsOrderedByIdResponsePagingTypeNextType Next { get; set; }

        [JsonProperty("prev")]
        public FetchListMembershipsOrderedByIdResponsePagingTypePrevType Prev { get; set; }
    }

    public class FetchListMembershipsOrderedByIdResponsePagingTypeNextType
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class FetchListMembershipsOrderedByIdResponsePagingTypePrevType
    {
        [JsonProperty("before")]
        public string Before { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class RemoveRecordsFromAListResponse
    {
        [JsonProperty("recordIdsMissing")]
        public string[] RecordIdsMissing { get; set; }

        [JsonProperty("recordIdsRemoved")]
        public string[] RecordIdsRemoved { get; set; }

        [JsonProperty("recordsIdsAdded")]
        public string[] RecordsIdsAdded { get; set; }
    }

    public class SearchListsResponse
    {
        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }

        [JsonProperty("lists")]
        public SearchListsResponseListsTypeItem[] Lists { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }
    }

    public class SearchListsResponseListsTypeItem
    {
        [JsonProperty("additionalProperties")]
        public JToken AdditionalProperties { get; set; }

        [JsonProperty("listId")]
        public string ListId { get; set; }

        [JsonProperty("listVersion")]
        public string ListVersion { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("objectTypeId")]
        public string ObjectTypeId { get; set; }

        [JsonProperty("processingStatus")]
        public string ProcessingStatus { get; set; }

        [JsonProperty("processingType")]
        public string ProcessingType { get; set; }

        [JsonProperty("updatedById")]
        public string UpdatedById { get; set; }

        [JsonProperty("filtersUpdatedAt")]
        public string FiltersUpdatedAt { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class SearchListsInput
    {
        [JsonProperty("additionalProperties")]
        public string[] AdditionalProperties { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotcrmv2;

    public partial class WorkflowManagedActions
    {
        public Hubspotcrmv2Actions Hubspotcrmv2(string connectionId) => new Hubspotcrmv2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Hubspotcrmv2Triggers Hubspotcrmv2(string connectionId) => new Hubspotcrmv2Triggers(connectionId);
    }
}