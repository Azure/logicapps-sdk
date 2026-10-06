//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotcrmv2
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Hubspotcrmv2Actions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchiveABatchOfCompaniesById))]
        public IBodyWorkflowAction<string> ArchiveABatchOfCompaniesById([WorkflowExpression] Func<bodyinputsInputItem[]> bodyinputs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchiveABatchOfCompaniesById(WorkflowExpression<bodyinputsInputItem[]> bodyinputs = null)
        {
            WorkflowExpression.Validate(bodyinputs, nameof(bodyinputs), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/companies/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildList))]
        public IBodyWorkflowAction<ListResponse> List([WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListResponse> __BuildList(WorkflowExpression<string> limit = null, WorkflowExpression<string> after = null, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredBodyAction<ListResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/companies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction<ListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildCreate))]
        public IBodyWorkflowAction<CreateResponse> Create([WorkflowExpression] Func<bodyassociationsInputItem[]> bodyassociations = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateResponse> __BuildCreate(WorkflowExpression<bodyassociationsInputItem[]> bodyassociations = null)
        {
            WorkflowExpression.Validate(bodyassociations, nameof(bodyassociations), required: false);
            return new DeferredBodyAction<CreateResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/companies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassociations != null)
                {
                    body["associations"] = ExpressionConverter.ConvertO(bodyassociations);
                    bodypropCount++;
                }

                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildRead))]
        public IBodyWorkflowAction<ReadResponse> Read([WorkflowExpression] Func<string> companyId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadResponse> __BuildRead(WorkflowExpression<string> companyId, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(companyId, nameof(companyId), required: true);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<ReadResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/companies/{0}", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                return new ApiConnectionAction<ReadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchive))]
        public IBodyWorkflowAction<string> Archive([WorkflowExpression] Func<string> companyId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchive(WorkflowExpression<string> companyId)
        {
            WorkflowExpression.Validate(companyId, nameof(companyId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/companies/{0}", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildUpdate))]
        public IBodyWorkflowAction<UpdateResponse> Update([WorkflowExpression] Func<string> companyId, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateResponse> __BuildUpdate(WorkflowExpression<string> companyId, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(companyId, nameof(companyId), required: true);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<UpdateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/companies/{0}", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildMergeTwoCompaniesWithSameType))]
        public IBodyWorkflowAction<MergeTwoCompaniesWithSameTypeResponse> MergeTwoCompaniesWithSameType([WorkflowExpression] Func<string> bodyobjectIdToMerge = null, [WorkflowExpression] Func<string> bodyprimaryObjectId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MergeTwoCompaniesWithSameTypeResponse> __BuildMergeTwoCompaniesWithSameType(WorkflowExpression<string> bodyobjectIdToMerge = null, WorkflowExpression<string> bodyprimaryObjectId = null)
        {
            WorkflowExpression.Validate(bodyobjectIdToMerge, nameof(bodyobjectIdToMerge), required: false);
            WorkflowExpression.Validate(bodyprimaryObjectId, nameof(bodyprimaryObjectId), required: false);
            return new DeferredBodyAction<MergeTwoCompaniesWithSameTypeResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/companies/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectIdToMerge != null)
                {
                    body["objectIdToMerge"] = ExpressionConverter.ConvertO(bodyobjectIdToMerge);
                    bodypropCount++;
                }

                if (bodyprimaryObjectId != null)
                {
                    body["primaryObjectId"] = ExpressionConverter.ConvertO(bodyprimaryObjectId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MergeTwoCompaniesWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildGdprDelete))]
        public IBodyWorkflowAction<string> GdprDelete([WorkflowExpression] Func<string> bodyobjectId = null, [WorkflowExpression] Func<string> bodyidProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGdprDelete(WorkflowExpression<string> bodyobjectId = null, WorkflowExpression<string> bodyidProperty = null)
        {
            WorkflowExpression.Validate(bodyobjectId, nameof(bodyobjectId), required: false);
            WorkflowExpression.Validate(bodyidProperty, nameof(bodyidProperty), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/companies/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectId != null)
                {
                    body["objectId"] = ExpressionConverter.ConvertO(bodyobjectId);
                    bodypropCount++;
                }

                if (bodyidProperty != null)
                {
                    body["idProperty"] = ExpressionConverter.ConvertO(bodyidProperty);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildPostCrmV3ObjectsCompaniesSearch))]
        public IBodyWorkflowAction<PostCrmV3ObjectsCompaniesSearchResponse> PostCrmV3ObjectsCompaniesSearch([WorkflowExpression] Func<string> bodyafter = null, [WorkflowExpression] Func<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, [WorkflowExpression] Func<string> bodylimit = null, [WorkflowExpression] Func<string[]> bodyproperties = null, [WorkflowExpression] Func<string[]> bodysorts = null, [WorkflowExpression] Func<string> bodyquery = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostCrmV3ObjectsCompaniesSearchResponse> __BuildPostCrmV3ObjectsCompaniesSearch(WorkflowExpression<string> bodyafter = null, WorkflowExpression<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, WorkflowExpression<string> bodylimit = null, WorkflowExpression<string[]> bodyproperties = null, WorkflowExpression<string[]> bodysorts = null, WorkflowExpression<string> bodyquery = null)
        {
            WorkflowExpression.Validate(bodyafter, nameof(bodyafter), required: false);
            WorkflowExpression.Validate(bodyfilterGroups, nameof(bodyfilterGroups), required: false);
            WorkflowExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            WorkflowExpression.Validate(bodyproperties, nameof(bodyproperties), required: false);
            WorkflowExpression.Validate(bodysorts, nameof(bodysorts), required: false);
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            return new DeferredBodyAction<PostCrmV3ObjectsCompaniesSearchResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/companies/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyafter != null)
                {
                    body["after"] = ExpressionConverter.ConvertO(bodyafter);
                    bodypropCount++;
                }

                if (bodyfilterGroups != null)
                {
                    body["filterGroups"] = ExpressionConverter.ConvertO(bodyfilterGroups);
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(bodylimit);
                    bodypropCount++;
                }

                if (bodyproperties != null)
                {
                    body["properties"] = ExpressionConverter.ConvertO(bodyproperties);
                    bodypropCount++;
                }

                if (bodysorts != null)
                {
                    body["sorts"] = ExpressionConverter.ConvertO(bodysorts);
                    bodypropCount++;
                }

                if (bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(bodyquery);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostCrmV3ObjectsCompaniesSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchiveABatchOfContactsById))]
        public IBodyWorkflowAction<string> ArchiveABatchOfContactsById([WorkflowExpression] Func<bodyinputsInputItem[]> bodyinputs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchiveABatchOfContactsById(WorkflowExpression<bodyinputsInputItem[]> bodyinputs = null)
        {
            WorkflowExpression.Validate(bodyinputs, nameof(bodyinputs), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/contacts/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildList16))]
        public IBodyWorkflowAction<List16Response> List16([WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<List16Response> __BuildList16(WorkflowExpression<string> limit = null, WorkflowExpression<string> after = null, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List16Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction<List16Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildCreate17))]
        public IBodyWorkflowAction<Create17Response> Create17([WorkflowExpression] Func<bodyassociationsInputItem[]> bodyassociations = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Create17Response> __BuildCreate17(WorkflowExpression<bodyassociationsInputItem[]> bodyassociations = null)
        {
            WorkflowExpression.Validate(bodyassociations, nameof(bodyassociations), required: false);
            return new DeferredBodyAction<Create17Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassociations != null)
                {
                    body["associations"] = ExpressionConverter.ConvertO(bodyassociations);
                    bodypropCount++;
                }

                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Create17Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildRead18))]
        public IBodyWorkflowAction<Read18Response> Read18([WorkflowExpression] Func<string> contactId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Read18Response> __BuildRead18(WorkflowExpression<string> contactId, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(contactId, nameof(contactId), required: true);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Read18Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction<Read18Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchive19))]
        public IBodyWorkflowAction<string> Archive19([WorkflowExpression] Func<string> contactId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchive19(WorkflowExpression<string> contactId)
        {
            WorkflowExpression.Validate(contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildUpdate20))]
        public IBodyWorkflowAction<Update20Response> Update20([WorkflowExpression] Func<string> contactId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Update20Response> __BuildUpdate20(WorkflowExpression<string> contactId)
        {
            WorkflowExpression.Validate(contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<Update20Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Update20Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildMergeTwoContactsWithSameType))]
        public IBodyWorkflowAction<MergeTwoContactsWithSameTypeResponse> MergeTwoContactsWithSameType([WorkflowExpression] Func<string> bodyobjectIdToMerge = null, [WorkflowExpression] Func<string> bodyprimaryObjectId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MergeTwoContactsWithSameTypeResponse> __BuildMergeTwoContactsWithSameType(WorkflowExpression<string> bodyobjectIdToMerge = null, WorkflowExpression<string> bodyprimaryObjectId = null)
        {
            WorkflowExpression.Validate(bodyobjectIdToMerge, nameof(bodyobjectIdToMerge), required: false);
            WorkflowExpression.Validate(bodyprimaryObjectId, nameof(bodyprimaryObjectId), required: false);
            return new DeferredBodyAction<MergeTwoContactsWithSameTypeResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/contacts/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectIdToMerge != null)
                {
                    body["objectIdToMerge"] = ExpressionConverter.ConvertO(bodyobjectIdToMerge);
                    bodypropCount++;
                }

                if (bodyprimaryObjectId != null)
                {
                    body["primaryObjectId"] = ExpressionConverter.ConvertO(bodyprimaryObjectId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MergeTwoContactsWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildGdprDelete22))]
        public IBodyWorkflowAction<string> GdprDelete22([WorkflowExpression] Func<string> bodyobjectId = null, [WorkflowExpression] Func<string> bodyidProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGdprDelete22(WorkflowExpression<string> bodyobjectId = null, WorkflowExpression<string> bodyidProperty = null)
        {
            WorkflowExpression.Validate(bodyobjectId, nameof(bodyobjectId), required: false);
            WorkflowExpression.Validate(bodyidProperty, nameof(bodyidProperty), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/contacts/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectId != null)
                {
                    body["objectId"] = ExpressionConverter.ConvertO(bodyobjectId);
                    bodypropCount++;
                }

                if (bodyidProperty != null)
                {
                    body["idProperty"] = ExpressionConverter.ConvertO(bodyidProperty);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildPostCrmV3ObjectsContactsSearch))]
        public IBodyWorkflowAction<PostCrmV3ObjectsContactsSearchResponse> PostCrmV3ObjectsContactsSearch([WorkflowExpression] Func<string> bodyafter = null, [WorkflowExpression] Func<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, [WorkflowExpression] Func<string> bodylimit = null, [WorkflowExpression] Func<string[]> bodyproperties = null, [WorkflowExpression] Func<string[]> bodysorts = null, [WorkflowExpression] Func<string> bodyquery = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostCrmV3ObjectsContactsSearchResponse> __BuildPostCrmV3ObjectsContactsSearch(WorkflowExpression<string> bodyafter = null, WorkflowExpression<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, WorkflowExpression<string> bodylimit = null, WorkflowExpression<string[]> bodyproperties = null, WorkflowExpression<string[]> bodysorts = null, WorkflowExpression<string> bodyquery = null)
        {
            WorkflowExpression.Validate(bodyafter, nameof(bodyafter), required: false);
            WorkflowExpression.Validate(bodyfilterGroups, nameof(bodyfilterGroups), required: false);
            WorkflowExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            WorkflowExpression.Validate(bodyproperties, nameof(bodyproperties), required: false);
            WorkflowExpression.Validate(bodysorts, nameof(bodysorts), required: false);
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            return new DeferredBodyAction<PostCrmV3ObjectsContactsSearchResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/contacts/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyafter != null)
                {
                    body["after"] = ExpressionConverter.ConvertO(bodyafter);
                    bodypropCount++;
                }

                if (bodyfilterGroups != null)
                {
                    body["filterGroups"] = ExpressionConverter.ConvertO(bodyfilterGroups);
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(bodylimit);
                    bodypropCount++;
                }

                if (bodyproperties != null)
                {
                    body["properties"] = ExpressionConverter.ConvertO(bodyproperties);
                    bodypropCount++;
                }

                if (bodysorts != null)
                {
                    body["sorts"] = ExpressionConverter.ConvertO(bodysorts);
                    bodypropCount++;
                }

                if (bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(bodyquery);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostCrmV3ObjectsContactsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchiveABatchOfDealsById))]
        public IBodyWorkflowAction<string> ArchiveABatchOfDealsById([WorkflowExpression] Func<bodyinputsInputItem[]> bodyinputs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchiveABatchOfDealsById(WorkflowExpression<bodyinputsInputItem[]> bodyinputs = null)
        {
            WorkflowExpression.Validate(bodyinputs, nameof(bodyinputs), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/deals/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildList28))]
        public IBodyWorkflowAction<List28Response> List28([WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<List28Response> __BuildList28(WorkflowExpression<string> limit = null, WorkflowExpression<string> after = null, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List28Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/deals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction<List28Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildCreate29))]
        public IBodyWorkflowAction<Create29Response> Create29([WorkflowExpression] Func<bodyassociationsInputItem[]> bodyassociations = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Create29Response> __BuildCreate29(WorkflowExpression<bodyassociationsInputItem[]> bodyassociations = null)
        {
            WorkflowExpression.Validate(bodyassociations, nameof(bodyassociations), required: false);
            return new DeferredBodyAction<Create29Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/deals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassociations != null)
                {
                    body["associations"] = ExpressionConverter.ConvertO(bodyassociations);
                    bodypropCount++;
                }

                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Create29Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildRead30))]
        public IBodyWorkflowAction<Read30Response> Read30([WorkflowExpression] Func<string> dealId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Read30Response> __BuildRead30(WorkflowExpression<string> dealId, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(dealId, nameof(dealId), required: true);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Read30Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/deals/{0}", ExpressionConverter.ConvertWithUrlEncoding(dealId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                return new ApiConnectionAction<Read30Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchive31))]
        public IBodyWorkflowAction<string> Archive31([WorkflowExpression] Func<string> dealId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchive31(WorkflowExpression<string> dealId)
        {
            WorkflowExpression.Validate(dealId, nameof(dealId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/deals/{0}", ExpressionConverter.ConvertWithUrlEncoding(dealId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildUpdate32))]
        public IBodyWorkflowAction<Update32Response> Update32([WorkflowExpression] Func<string> dealId, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Update32Response> __BuildUpdate32(WorkflowExpression<string> dealId, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(dealId, nameof(dealId), required: true);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Update32Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/deals/{0}", ExpressionConverter.ConvertWithUrlEncoding(dealId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Update32Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildMergeTwoDealsWithSameType))]
        public IBodyWorkflowAction<MergeTwoDealsWithSameTypeResponse> MergeTwoDealsWithSameType([WorkflowExpression] Func<string> bodyobjectIdToMerge = null, [WorkflowExpression] Func<string> bodyprimaryObjectId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MergeTwoDealsWithSameTypeResponse> __BuildMergeTwoDealsWithSameType(WorkflowExpression<string> bodyobjectIdToMerge = null, WorkflowExpression<string> bodyprimaryObjectId = null)
        {
            WorkflowExpression.Validate(bodyobjectIdToMerge, nameof(bodyobjectIdToMerge), required: false);
            WorkflowExpression.Validate(bodyprimaryObjectId, nameof(bodyprimaryObjectId), required: false);
            return new DeferredBodyAction<MergeTwoDealsWithSameTypeResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/deals/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectIdToMerge != null)
                {
                    body["objectIdToMerge"] = ExpressionConverter.ConvertO(bodyobjectIdToMerge);
                    bodypropCount++;
                }

                if (bodyprimaryObjectId != null)
                {
                    body["primaryObjectId"] = ExpressionConverter.ConvertO(bodyprimaryObjectId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MergeTwoDealsWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildGdprDelete34))]
        public IBodyWorkflowAction<string> GdprDelete34([WorkflowExpression] Func<string> bodyobjectId = null, [WorkflowExpression] Func<string> bodyidProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGdprDelete34(WorkflowExpression<string> bodyobjectId = null, WorkflowExpression<string> bodyidProperty = null)
        {
            WorkflowExpression.Validate(bodyobjectId, nameof(bodyobjectId), required: false);
            WorkflowExpression.Validate(bodyidProperty, nameof(bodyidProperty), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/deals/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectId != null)
                {
                    body["objectId"] = ExpressionConverter.ConvertO(bodyobjectId);
                    bodypropCount++;
                }

                if (bodyidProperty != null)
                {
                    body["idProperty"] = ExpressionConverter.ConvertO(bodyidProperty);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildPostCrmV3ObjectsDealsSearch))]
        public IBodyWorkflowAction<PostCrmV3ObjectsDealsSearchResponse> PostCrmV3ObjectsDealsSearch([WorkflowExpression] Func<string> bodyafter = null, [WorkflowExpression] Func<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, [WorkflowExpression] Func<string> bodylimit = null, [WorkflowExpression] Func<string[]> bodyproperties = null, [WorkflowExpression] Func<string[]> bodysorts = null, [WorkflowExpression] Func<string> bodyquery = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostCrmV3ObjectsDealsSearchResponse> __BuildPostCrmV3ObjectsDealsSearch(WorkflowExpression<string> bodyafter = null, WorkflowExpression<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, WorkflowExpression<string> bodylimit = null, WorkflowExpression<string[]> bodyproperties = null, WorkflowExpression<string[]> bodysorts = null, WorkflowExpression<string> bodyquery = null)
        {
            WorkflowExpression.Validate(bodyafter, nameof(bodyafter), required: false);
            WorkflowExpression.Validate(bodyfilterGroups, nameof(bodyfilterGroups), required: false);
            WorkflowExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            WorkflowExpression.Validate(bodyproperties, nameof(bodyproperties), required: false);
            WorkflowExpression.Validate(bodysorts, nameof(bodysorts), required: false);
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            return new DeferredBodyAction<PostCrmV3ObjectsDealsSearchResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/deals/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyafter != null)
                {
                    body["after"] = ExpressionConverter.ConvertO(bodyafter);
                    bodypropCount++;
                }

                if (bodyfilterGroups != null)
                {
                    body["filterGroups"] = ExpressionConverter.ConvertO(bodyfilterGroups);
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(bodylimit);
                    bodypropCount++;
                }

                if (bodyproperties != null)
                {
                    body["properties"] = ExpressionConverter.ConvertO(bodyproperties);
                    bodypropCount++;
                }

                if (bodysorts != null)
                {
                    body["sorts"] = ExpressionConverter.ConvertO(bodysorts);
                    bodypropCount++;
                }

                if (bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(bodyquery);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostCrmV3ObjectsDealsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchiveABatchOfFeesById))]
        public IBodyWorkflowAction<string> ArchiveABatchOfFeesById([WorkflowExpression] Func<bodyinputsInputItem[]> bodyinputs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchiveABatchOfFeesById(WorkflowExpression<bodyinputsInputItem[]> bodyinputs = null)
        {
            WorkflowExpression.Validate(bodyinputs, nameof(bodyinputs), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/fees/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildRead40))]
        public IBodyWorkflowAction<Read40Response> Read40([WorkflowExpression] Func<string> feeId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Read40Response> __BuildRead40(WorkflowExpression<string> feeId, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(feeId, nameof(feeId), required: true);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Read40Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/fees/{0}", ExpressionConverter.ConvertWithUrlEncoding(feeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                return new ApiConnectionAction<Read40Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchive41))]
        public IBodyWorkflowAction<string> Archive41([WorkflowExpression] Func<string> feeId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchive41(WorkflowExpression<string> feeId)
        {
            WorkflowExpression.Validate(feeId, nameof(feeId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/fees/{0}", ExpressionConverter.ConvertWithUrlEncoding(feeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildUpdate42))]
        public IBodyWorkflowAction<Update42Response> Update42([WorkflowExpression] Func<string> feeId, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Update42Response> __BuildUpdate42(WorkflowExpression<string> feeId, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(feeId, nameof(feeId), required: true);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Update42Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/fees/{0}", ExpressionConverter.ConvertWithUrlEncoding(feeId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Update42Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildList43))]
        public IBodyWorkflowAction<List43Response> List43([WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<List43Response> __BuildList43(WorkflowExpression<string> limit = null, WorkflowExpression<string> after = null, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List43Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/fees";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction<List43Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildCreate44))]
        public IBodyWorkflowAction<Create44Response> Create44([WorkflowExpression] Func<bodyassociationsInputItem[]> bodyassociations = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Create44Response> __BuildCreate44(WorkflowExpression<bodyassociationsInputItem[]> bodyassociations = null)
        {
            WorkflowExpression.Validate(bodyassociations, nameof(bodyassociations), required: false);
            return new DeferredBodyAction<Create44Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/fees";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassociations != null)
                {
                    body["associations"] = ExpressionConverter.ConvertO(bodyassociations);
                    bodypropCount++;
                }

                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Create44Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildMergeTwoFeesWithSameType))]
        public IBodyWorkflowAction<MergeTwoFeesWithSameTypeResponse> MergeTwoFeesWithSameType([WorkflowExpression] Func<string> bodyobjectIdToMerge = null, [WorkflowExpression] Func<string> bodyprimaryObjectId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MergeTwoFeesWithSameTypeResponse> __BuildMergeTwoFeesWithSameType(WorkflowExpression<string> bodyobjectIdToMerge = null, WorkflowExpression<string> bodyprimaryObjectId = null)
        {
            WorkflowExpression.Validate(bodyobjectIdToMerge, nameof(bodyobjectIdToMerge), required: false);
            WorkflowExpression.Validate(bodyprimaryObjectId, nameof(bodyprimaryObjectId), required: false);
            return new DeferredBodyAction<MergeTwoFeesWithSameTypeResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/fees/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectIdToMerge != null)
                {
                    body["objectIdToMerge"] = ExpressionConverter.ConvertO(bodyobjectIdToMerge);
                    bodypropCount++;
                }

                if (bodyprimaryObjectId != null)
                {
                    body["primaryObjectId"] = ExpressionConverter.ConvertO(bodyprimaryObjectId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MergeTwoFeesWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildGdprDelete46))]
        public IBodyWorkflowAction<string> GdprDelete46([WorkflowExpression] Func<string> bodyobjectId = null, [WorkflowExpression] Func<string> bodyidProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGdprDelete46(WorkflowExpression<string> bodyobjectId = null, WorkflowExpression<string> bodyidProperty = null)
        {
            WorkflowExpression.Validate(bodyobjectId, nameof(bodyobjectId), required: false);
            WorkflowExpression.Validate(bodyidProperty, nameof(bodyidProperty), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/fees/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectId != null)
                {
                    body["objectId"] = ExpressionConverter.ConvertO(bodyobjectId);
                    bodypropCount++;
                }

                if (bodyidProperty != null)
                {
                    body["idProperty"] = ExpressionConverter.ConvertO(bodyidProperty);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildPostCrmV3ObjectsFeesSearch))]
        public IBodyWorkflowAction<PostCrmV3ObjectsFeesSearchResponse> PostCrmV3ObjectsFeesSearch([WorkflowExpression] Func<string> bodyafter = null, [WorkflowExpression] Func<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, [WorkflowExpression] Func<string> bodylimit = null, [WorkflowExpression] Func<string[]> bodyproperties = null, [WorkflowExpression] Func<string[]> bodysorts = null, [WorkflowExpression] Func<string> bodyquery = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostCrmV3ObjectsFeesSearchResponse> __BuildPostCrmV3ObjectsFeesSearch(WorkflowExpression<string> bodyafter = null, WorkflowExpression<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, WorkflowExpression<string> bodylimit = null, WorkflowExpression<string[]> bodyproperties = null, WorkflowExpression<string[]> bodysorts = null, WorkflowExpression<string> bodyquery = null)
        {
            WorkflowExpression.Validate(bodyafter, nameof(bodyafter), required: false);
            WorkflowExpression.Validate(bodyfilterGroups, nameof(bodyfilterGroups), required: false);
            WorkflowExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            WorkflowExpression.Validate(bodyproperties, nameof(bodyproperties), required: false);
            WorkflowExpression.Validate(bodysorts, nameof(bodysorts), required: false);
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            return new DeferredBodyAction<PostCrmV3ObjectsFeesSearchResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/fees/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyafter != null)
                {
                    body["after"] = ExpressionConverter.ConvertO(bodyafter);
                    bodypropCount++;
                }

                if (bodyfilterGroups != null)
                {
                    body["filterGroups"] = ExpressionConverter.ConvertO(bodyfilterGroups);
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(bodylimit);
                    bodypropCount++;
                }

                if (bodyproperties != null)
                {
                    body["properties"] = ExpressionConverter.ConvertO(bodyproperties);
                    bodypropCount++;
                }

                if (bodysorts != null)
                {
                    body["sorts"] = ExpressionConverter.ConvertO(bodysorts);
                    bodypropCount++;
                }

                if (bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(bodyquery);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostCrmV3ObjectsFeesSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchiveABatchOfGoalTargetsById))]
        public IBodyWorkflowAction<string> ArchiveABatchOfGoalTargetsById([WorkflowExpression] Func<bodyinputsInputItem[]> bodyinputs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchiveABatchOfGoalTargetsById(WorkflowExpression<bodyinputsInputItem[]> bodyinputs = null)
        {
            WorkflowExpression.Validate(bodyinputs, nameof(bodyinputs), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/goal_targets/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildRead52))]
        public IBodyWorkflowAction<Read52Response> Read52([WorkflowExpression] Func<string> goalTargetId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Read52Response> __BuildRead52(WorkflowExpression<string> goalTargetId, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(goalTargetId, nameof(goalTargetId), required: true);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Read52Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/goal_targets/{0}", ExpressionConverter.ConvertWithUrlEncoding(goalTargetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                return new ApiConnectionAction<Read52Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchive53))]
        public IBodyWorkflowAction<string> Archive53([WorkflowExpression] Func<string> goalTargetId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchive53(WorkflowExpression<string> goalTargetId)
        {
            WorkflowExpression.Validate(goalTargetId, nameof(goalTargetId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/goal_targets/{0}", ExpressionConverter.ConvertWithUrlEncoding(goalTargetId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildUpdate54))]
        public IBodyWorkflowAction<Update54Response> Update54([WorkflowExpression] Func<string> goalTargetId, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Update54Response> __BuildUpdate54(WorkflowExpression<string> goalTargetId, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(goalTargetId, nameof(goalTargetId), required: true);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Update54Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/goal_targets/{0}", ExpressionConverter.ConvertWithUrlEncoding(goalTargetId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Update54Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildList55))]
        public IBodyWorkflowAction<List55Response> List55([WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<List55Response> __BuildList55(WorkflowExpression<string> limit = null, WorkflowExpression<string> after = null, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List55Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/goal_targets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction<List55Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildCreate56))]
        public IBodyWorkflowAction<Create56Response> Create56([WorkflowExpression] Func<bodyassociationsInputItem[]> bodyassociations = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Create56Response> __BuildCreate56(WorkflowExpression<bodyassociationsInputItem[]> bodyassociations = null)
        {
            WorkflowExpression.Validate(bodyassociations, nameof(bodyassociations), required: false);
            return new DeferredBodyAction<Create56Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/goal_targets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassociations != null)
                {
                    body["associations"] = ExpressionConverter.ConvertO(bodyassociations);
                    bodypropCount++;
                }

                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Create56Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildMergeTwoGoalTargetsWithSameType))]
        public IBodyWorkflowAction<MergeTwoGoalTargetsWithSameTypeResponse> MergeTwoGoalTargetsWithSameType([WorkflowExpression] Func<string> bodyobjectIdToMerge = null, [WorkflowExpression] Func<string> bodyprimaryObjectId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MergeTwoGoalTargetsWithSameTypeResponse> __BuildMergeTwoGoalTargetsWithSameType(WorkflowExpression<string> bodyobjectIdToMerge = null, WorkflowExpression<string> bodyprimaryObjectId = null)
        {
            WorkflowExpression.Validate(bodyobjectIdToMerge, nameof(bodyobjectIdToMerge), required: false);
            WorkflowExpression.Validate(bodyprimaryObjectId, nameof(bodyprimaryObjectId), required: false);
            return new DeferredBodyAction<MergeTwoGoalTargetsWithSameTypeResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/goal_targets/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectIdToMerge != null)
                {
                    body["objectIdToMerge"] = ExpressionConverter.ConvertO(bodyobjectIdToMerge);
                    bodypropCount++;
                }

                if (bodyprimaryObjectId != null)
                {
                    body["primaryObjectId"] = ExpressionConverter.ConvertO(bodyprimaryObjectId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MergeTwoGoalTargetsWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildGdprDelete58))]
        public IBodyWorkflowAction<string> GdprDelete58([WorkflowExpression] Func<string> bodyobjectId = null, [WorkflowExpression] Func<string> bodyidProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGdprDelete58(WorkflowExpression<string> bodyobjectId = null, WorkflowExpression<string> bodyidProperty = null)
        {
            WorkflowExpression.Validate(bodyobjectId, nameof(bodyobjectId), required: false);
            WorkflowExpression.Validate(bodyidProperty, nameof(bodyidProperty), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/goal_targets/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectId != null)
                {
                    body["objectId"] = ExpressionConverter.ConvertO(bodyobjectId);
                    bodypropCount++;
                }

                if (bodyidProperty != null)
                {
                    body["idProperty"] = ExpressionConverter.ConvertO(bodyidProperty);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildPostCrmV3ObjectsGoalTargetsSearch))]
        public IBodyWorkflowAction<PostCrmV3ObjectsGoalTargetsSearchResponse> PostCrmV3ObjectsGoalTargetsSearch([WorkflowExpression] Func<string> bodyafter = null, [WorkflowExpression] Func<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, [WorkflowExpression] Func<string> bodylimit = null, [WorkflowExpression] Func<string[]> bodyproperties = null, [WorkflowExpression] Func<string[]> bodysorts = null, [WorkflowExpression] Func<string> bodyquery = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostCrmV3ObjectsGoalTargetsSearchResponse> __BuildPostCrmV3ObjectsGoalTargetsSearch(WorkflowExpression<string> bodyafter = null, WorkflowExpression<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, WorkflowExpression<string> bodylimit = null, WorkflowExpression<string[]> bodyproperties = null, WorkflowExpression<string[]> bodysorts = null, WorkflowExpression<string> bodyquery = null)
        {
            WorkflowExpression.Validate(bodyafter, nameof(bodyafter), required: false);
            WorkflowExpression.Validate(bodyfilterGroups, nameof(bodyfilterGroups), required: false);
            WorkflowExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            WorkflowExpression.Validate(bodyproperties, nameof(bodyproperties), required: false);
            WorkflowExpression.Validate(bodysorts, nameof(bodysorts), required: false);
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            return new DeferredBodyAction<PostCrmV3ObjectsGoalTargetsSearchResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/goal_targets/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyafter != null)
                {
                    body["after"] = ExpressionConverter.ConvertO(bodyafter);
                    bodypropCount++;
                }

                if (bodyfilterGroups != null)
                {
                    body["filterGroups"] = ExpressionConverter.ConvertO(bodyfilterGroups);
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(bodylimit);
                    bodypropCount++;
                }

                if (bodyproperties != null)
                {
                    body["properties"] = ExpressionConverter.ConvertO(bodyproperties);
                    bodypropCount++;
                }

                if (bodysorts != null)
                {
                    body["sorts"] = ExpressionConverter.ConvertO(bodysorts);
                    bodypropCount++;
                }

                if (bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(bodyquery);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostCrmV3ObjectsGoalTargetsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchiveABatchOfLineItemsById))]
        public IBodyWorkflowAction<string> ArchiveABatchOfLineItemsById([WorkflowExpression] Func<bodyinputsInputItem[]> bodyinputs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchiveABatchOfLineItemsById(WorkflowExpression<bodyinputsInputItem[]> bodyinputs = null)
        {
            WorkflowExpression.Validate(bodyinputs, nameof(bodyinputs), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/line_items/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildList64))]
        public IBodyWorkflowAction<List64Response> List64([WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<List64Response> __BuildList64(WorkflowExpression<string> limit = null, WorkflowExpression<string> after = null, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List64Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/line_items";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction<List64Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildCreate65))]
        public IBodyWorkflowAction<Create65Response> Create65([WorkflowExpression] Func<bodyassociationsInputItem[]> bodyassociations = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Create65Response> __BuildCreate65(WorkflowExpression<bodyassociationsInputItem[]> bodyassociations = null)
        {
            WorkflowExpression.Validate(bodyassociations, nameof(bodyassociations), required: false);
            return new DeferredBodyAction<Create65Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/line_items";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassociations != null)
                {
                    body["associations"] = ExpressionConverter.ConvertO(bodyassociations);
                    bodypropCount++;
                }

                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Create65Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildRead66))]
        public IBodyWorkflowAction<Read66Response> Read66([WorkflowExpression] Func<string> lineItemId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Read66Response> __BuildRead66(WorkflowExpression<string> lineItemId, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(lineItemId, nameof(lineItemId), required: true);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Read66Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/line_items/{0}", ExpressionConverter.ConvertWithUrlEncoding(lineItemId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                return new ApiConnectionAction<Read66Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchive67))]
        public IBodyWorkflowAction<string> Archive67([WorkflowExpression] Func<string> lineItemId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchive67(WorkflowExpression<string> lineItemId)
        {
            WorkflowExpression.Validate(lineItemId, nameof(lineItemId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/line_items/{0}", ExpressionConverter.ConvertWithUrlEncoding(lineItemId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildUpdate68))]
        public IBodyWorkflowAction<Update68Response> Update68([WorkflowExpression] Func<string> lineItemId, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Update68Response> __BuildUpdate68(WorkflowExpression<string> lineItemId, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(lineItemId, nameof(lineItemId), required: true);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Update68Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/line_items/{0}", ExpressionConverter.ConvertWithUrlEncoding(lineItemId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Update68Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildMergeTwoLineItemsWithSameType))]
        public IBodyWorkflowAction<MergeTwoLineItemsWithSameTypeResponse> MergeTwoLineItemsWithSameType([WorkflowExpression] Func<string> bodyobjectIdToMerge = null, [WorkflowExpression] Func<string> bodyprimaryObjectId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MergeTwoLineItemsWithSameTypeResponse> __BuildMergeTwoLineItemsWithSameType(WorkflowExpression<string> bodyobjectIdToMerge = null, WorkflowExpression<string> bodyprimaryObjectId = null)
        {
            WorkflowExpression.Validate(bodyobjectIdToMerge, nameof(bodyobjectIdToMerge), required: false);
            WorkflowExpression.Validate(bodyprimaryObjectId, nameof(bodyprimaryObjectId), required: false);
            return new DeferredBodyAction<MergeTwoLineItemsWithSameTypeResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/line_items/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectIdToMerge != null)
                {
                    body["objectIdToMerge"] = ExpressionConverter.ConvertO(bodyobjectIdToMerge);
                    bodypropCount++;
                }

                if (bodyprimaryObjectId != null)
                {
                    body["primaryObjectId"] = ExpressionConverter.ConvertO(bodyprimaryObjectId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MergeTwoLineItemsWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildGdprDelete70))]
        public IBodyWorkflowAction<string> GdprDelete70([WorkflowExpression] Func<string> bodyobjectId = null, [WorkflowExpression] Func<string> bodyidProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGdprDelete70(WorkflowExpression<string> bodyobjectId = null, WorkflowExpression<string> bodyidProperty = null)
        {
            WorkflowExpression.Validate(bodyobjectId, nameof(bodyobjectId), required: false);
            WorkflowExpression.Validate(bodyidProperty, nameof(bodyidProperty), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/line_items/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectId != null)
                {
                    body["objectId"] = ExpressionConverter.ConvertO(bodyobjectId);
                    bodypropCount++;
                }

                if (bodyidProperty != null)
                {
                    body["idProperty"] = ExpressionConverter.ConvertO(bodyidProperty);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildPostCrmV3ObjectsLineItemsSearch))]
        public IBodyWorkflowAction<PostCrmV3ObjectsLineItemsSearchResponse> PostCrmV3ObjectsLineItemsSearch([WorkflowExpression] Func<string> bodyafter = null, [WorkflowExpression] Func<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, [WorkflowExpression] Func<string> bodylimit = null, [WorkflowExpression] Func<string[]> bodyproperties = null, [WorkflowExpression] Func<string[]> bodysorts = null, [WorkflowExpression] Func<string> bodyquery = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostCrmV3ObjectsLineItemsSearchResponse> __BuildPostCrmV3ObjectsLineItemsSearch(WorkflowExpression<string> bodyafter = null, WorkflowExpression<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, WorkflowExpression<string> bodylimit = null, WorkflowExpression<string[]> bodyproperties = null, WorkflowExpression<string[]> bodysorts = null, WorkflowExpression<string> bodyquery = null)
        {
            WorkflowExpression.Validate(bodyafter, nameof(bodyafter), required: false);
            WorkflowExpression.Validate(bodyfilterGroups, nameof(bodyfilterGroups), required: false);
            WorkflowExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            WorkflowExpression.Validate(bodyproperties, nameof(bodyproperties), required: false);
            WorkflowExpression.Validate(bodysorts, nameof(bodysorts), required: false);
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            return new DeferredBodyAction<PostCrmV3ObjectsLineItemsSearchResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/line_items/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyafter != null)
                {
                    body["after"] = ExpressionConverter.ConvertO(bodyafter);
                    bodypropCount++;
                }

                if (bodyfilterGroups != null)
                {
                    body["filterGroups"] = ExpressionConverter.ConvertO(bodyfilterGroups);
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(bodylimit);
                    bodypropCount++;
                }

                if (bodyproperties != null)
                {
                    body["properties"] = ExpressionConverter.ConvertO(bodyproperties);
                    bodypropCount++;
                }

                if (bodysorts != null)
                {
                    body["sorts"] = ExpressionConverter.ConvertO(bodysorts);
                    bodypropCount++;
                }

                if (bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(bodyquery);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostCrmV3ObjectsLineItemsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetAPageOfOwners))]
        public IBodyWorkflowAction<GetAPageOfOwnersResponse> GetAPageOfOwners([WorkflowExpression] Func<string> email, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAPageOfOwnersResponse> __BuildGetAPageOfOwners(WorkflowExpression<string> email, WorkflowExpression<string> after = null, WorkflowExpression<string> limit = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(email, nameof(email), required: true);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredBodyAction<GetAPageOfOwnersResponse>(() =>
            {
                var apiCallPath = "/crm/v3/owners/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = ExpressionConverter.Convert(email);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction<GetAPageOfOwnersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildReadAnOwnerByGivenidOruserid))]
        public IBodyWorkflowAction<ReadAnOwnerByGivenidOruseridResponse> ReadAnOwnerByGivenidOruserid([WorkflowExpression] Func<string> ownerId, [WorkflowExpression] Func<string> idProperty = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadAnOwnerByGivenidOruseridResponse> __BuildReadAnOwnerByGivenidOruserid(WorkflowExpression<string> ownerId, WorkflowExpression<string> idProperty = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(ownerId, nameof(ownerId), required: true);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredBodyAction<ReadAnOwnerByGivenidOruseridResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/owners/{0}", ExpressionConverter.ConvertWithUrlEncoding(ownerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction<ReadAnOwnerByGivenidOruseridResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchiveABatchOfProductsById))]
        public IBodyWorkflowAction<string> ArchiveABatchOfProductsById([WorkflowExpression] Func<bodyinputsInputItem[]> bodyinputs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchiveABatchOfProductsById(WorkflowExpression<bodyinputsInputItem[]> bodyinputs = null)
        {
            WorkflowExpression.Validate(bodyinputs, nameof(bodyinputs), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/products/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildList78))]
        public IBodyWorkflowAction<List78Response> List78([WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<List78Response> __BuildList78(WorkflowExpression<string> limit = null, WorkflowExpression<string> after = null, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List78Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/products";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction<List78Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildCreate79))]
        public IBodyWorkflowAction<Create79Response> Create79([WorkflowExpression] Func<bodyassociationsInputItem[]> bodyassociations = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Create79Response> __BuildCreate79(WorkflowExpression<bodyassociationsInputItem[]> bodyassociations = null)
        {
            WorkflowExpression.Validate(bodyassociations, nameof(bodyassociations), required: false);
            return new DeferredBodyAction<Create79Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/products";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassociations != null)
                {
                    body["associations"] = ExpressionConverter.ConvertO(bodyassociations);
                    bodypropCount++;
                }

                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Create79Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildRead80))]
        public IBodyWorkflowAction<Read80Response> Read80([WorkflowExpression] Func<string> productId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Read80Response> __BuildRead80(WorkflowExpression<string> productId, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(productId, nameof(productId), required: true);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Read80Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/products/{0}", ExpressionConverter.ConvertWithUrlEncoding(productId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                return new ApiConnectionAction<Read80Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchive81))]
        public IBodyWorkflowAction<string> Archive81([WorkflowExpression] Func<string> productId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchive81(WorkflowExpression<string> productId)
        {
            WorkflowExpression.Validate(productId, nameof(productId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/products/{0}", ExpressionConverter.ConvertWithUrlEncoding(productId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildUpdate82))]
        public IBodyWorkflowAction<Update82Response> Update82([WorkflowExpression] Func<string> productId, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Update82Response> __BuildUpdate82(WorkflowExpression<string> productId, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(productId, nameof(productId), required: true);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Update82Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/products/{0}", ExpressionConverter.ConvertWithUrlEncoding(productId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Update82Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildMergeTwoProductsWithSameType))]
        public IBodyWorkflowAction<MergeTwoProductsWithSameTypeResponse> MergeTwoProductsWithSameType([WorkflowExpression] Func<string> bodyobjectIdToMerge = null, [WorkflowExpression] Func<string> bodyprimaryObjectId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MergeTwoProductsWithSameTypeResponse> __BuildMergeTwoProductsWithSameType(WorkflowExpression<string> bodyobjectIdToMerge = null, WorkflowExpression<string> bodyprimaryObjectId = null)
        {
            WorkflowExpression.Validate(bodyobjectIdToMerge, nameof(bodyobjectIdToMerge), required: false);
            WorkflowExpression.Validate(bodyprimaryObjectId, nameof(bodyprimaryObjectId), required: false);
            return new DeferredBodyAction<MergeTwoProductsWithSameTypeResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/products/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectIdToMerge != null)
                {
                    body["objectIdToMerge"] = ExpressionConverter.ConvertO(bodyobjectIdToMerge);
                    bodypropCount++;
                }

                if (bodyprimaryObjectId != null)
                {
                    body["primaryObjectId"] = ExpressionConverter.ConvertO(bodyprimaryObjectId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MergeTwoProductsWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildGdprDelete84))]
        public IBodyWorkflowAction<string> GdprDelete84([WorkflowExpression] Func<string> bodyobjectId = null, [WorkflowExpression] Func<string> bodyidProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGdprDelete84(WorkflowExpression<string> bodyobjectId = null, WorkflowExpression<string> bodyidProperty = null)
        {
            WorkflowExpression.Validate(bodyobjectId, nameof(bodyobjectId), required: false);
            WorkflowExpression.Validate(bodyidProperty, nameof(bodyidProperty), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/products/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectId != null)
                {
                    body["objectId"] = ExpressionConverter.ConvertO(bodyobjectId);
                    bodypropCount++;
                }

                if (bodyidProperty != null)
                {
                    body["idProperty"] = ExpressionConverter.ConvertO(bodyidProperty);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildPostCrmV3ObjectsProductsSearch))]
        public IBodyWorkflowAction<PostCrmV3ObjectsProductsSearchResponse> PostCrmV3ObjectsProductsSearch([WorkflowExpression] Func<string> bodyafter = null, [WorkflowExpression] Func<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, [WorkflowExpression] Func<string> bodylimit = null, [WorkflowExpression] Func<string[]> bodyproperties = null, [WorkflowExpression] Func<string[]> bodysorts = null, [WorkflowExpression] Func<string> bodyquery = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostCrmV3ObjectsProductsSearchResponse> __BuildPostCrmV3ObjectsProductsSearch(WorkflowExpression<string> bodyafter = null, WorkflowExpression<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, WorkflowExpression<string> bodylimit = null, WorkflowExpression<string[]> bodyproperties = null, WorkflowExpression<string[]> bodysorts = null, WorkflowExpression<string> bodyquery = null)
        {
            WorkflowExpression.Validate(bodyafter, nameof(bodyafter), required: false);
            WorkflowExpression.Validate(bodyfilterGroups, nameof(bodyfilterGroups), required: false);
            WorkflowExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            WorkflowExpression.Validate(bodyproperties, nameof(bodyproperties), required: false);
            WorkflowExpression.Validate(bodysorts, nameof(bodysorts), required: false);
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            return new DeferredBodyAction<PostCrmV3ObjectsProductsSearchResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/products/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyafter != null)
                {
                    body["after"] = ExpressionConverter.ConvertO(bodyafter);
                    bodypropCount++;
                }

                if (bodyfilterGroups != null)
                {
                    body["filterGroups"] = ExpressionConverter.ConvertO(bodyfilterGroups);
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(bodylimit);
                    bodypropCount++;
                }

                if (bodyproperties != null)
                {
                    body["properties"] = ExpressionConverter.ConvertO(bodyproperties);
                    bodypropCount++;
                }

                if (bodysorts != null)
                {
                    body["sorts"] = ExpressionConverter.ConvertO(bodysorts);
                    bodypropCount++;
                }

                if (bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(bodyquery);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostCrmV3ObjectsProductsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchiveABatchOfObjectsById))]
        public IBodyWorkflowAction<string> ArchiveABatchOfObjectsById([WorkflowExpression] Func<string> objectType, [WorkflowExpression] Func<bodyinputsInputItem[]> bodyinputs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchiveABatchOfObjectsById(WorkflowExpression<string> objectType, WorkflowExpression<bodyinputsInputItem[]> bodyinputs = null)
        {
            WorkflowExpression.Validate(objectType, nameof(objectType), required: true);
            WorkflowExpression.Validate(bodyinputs, nameof(bodyinputs), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/{0}/batch/archive", ExpressionConverter.ConvertWithUrlEncoding(objectType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildReadObject))]
        public IBodyWorkflowAction<ReadObjectResponse> ReadObject([WorkflowExpression] Func<string> objectType, [WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadObjectResponse> __BuildReadObject(WorkflowExpression<string> objectType, WorkflowExpression<string> objectId, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(objectType, nameof(objectType), required: true);
            WorkflowExpression.Validate(objectId, nameof(objectId), required: true);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<ReadObjectResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(objectType, 1), ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                return new ApiConnectionAction<ReadObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchiveObjectId))]
        public IBodyWorkflowAction<string> ArchiveObjectId([WorkflowExpression] Func<string> objectType, [WorkflowExpression] Func<string> objectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchiveObjectId(WorkflowExpression<string> objectType, WorkflowExpression<string> objectId)
        {
            WorkflowExpression.Validate(objectType, nameof(objectType), required: true);
            WorkflowExpression.Validate(objectId, nameof(objectId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(objectType, 1), ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateObjectId))]
        public IBodyWorkflowAction<UpdateObjectIdResponse> UpdateObjectId([WorkflowExpression] Func<string> objectType, [WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateObjectIdResponse> __BuildUpdateObjectId(WorkflowExpression<string> objectType, WorkflowExpression<string> objectId, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(objectType, nameof(objectType), required: true);
            WorkflowExpression.Validate(objectId, nameof(objectId), required: true);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<UpdateObjectIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(objectType, 1), ExpressionConverter.ConvertWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateObjectIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildListObject))]
        public IBodyWorkflowAction<ListObjectResponse> ListObject([WorkflowExpression] Func<string> objectType, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListObjectResponse> __BuildListObject(WorkflowExpression<string> objectType, WorkflowExpression<string> limit = null, WorkflowExpression<string> after = null, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(objectType, nameof(objectType), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredBodyAction<ListObjectResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/{0}", ExpressionConverter.ConvertWithUrlEncoding(objectType, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction<ListObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildCreateObjectId))]
        public IBodyWorkflowAction<CreateObjectIdResponse> CreateObjectId([WorkflowExpression] Func<string> objectType, [WorkflowExpression] Func<bodyassociationsInputItem[]> bodyassociations = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateObjectIdResponse> __BuildCreateObjectId(WorkflowExpression<string> objectType, WorkflowExpression<bodyassociationsInputItem[]> bodyassociations = null)
        {
            WorkflowExpression.Validate(objectType, nameof(objectType), required: true);
            WorkflowExpression.Validate(bodyassociations, nameof(bodyassociations), required: false);
            return new DeferredBodyAction<CreateObjectIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/{0}", ExpressionConverter.ConvertWithUrlEncoding(objectType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassociations != null)
                {
                    body["associations"] = ExpressionConverter.ConvertO(bodyassociations);
                    bodypropCount++;
                }

                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateObjectIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildMergeTwoObjectsWithSameType))]
        public IBodyWorkflowAction<MergeTwoObjectsWithSameTypeResponse> MergeTwoObjectsWithSameType([WorkflowExpression] Func<string> objectType, [WorkflowExpression] Func<string> bodyobjectIdToMerge = null, [WorkflowExpression] Func<string> bodyprimaryObjectId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MergeTwoObjectsWithSameTypeResponse> __BuildMergeTwoObjectsWithSameType(WorkflowExpression<string> objectType, WorkflowExpression<string> bodyobjectIdToMerge = null, WorkflowExpression<string> bodyprimaryObjectId = null)
        {
            WorkflowExpression.Validate(objectType, nameof(objectType), required: true);
            WorkflowExpression.Validate(bodyobjectIdToMerge, nameof(bodyobjectIdToMerge), required: false);
            WorkflowExpression.Validate(bodyprimaryObjectId, nameof(bodyprimaryObjectId), required: false);
            return new DeferredBodyAction<MergeTwoObjectsWithSameTypeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/{0}/merge", ExpressionConverter.ConvertWithUrlEncoding(objectType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectIdToMerge != null)
                {
                    body["objectIdToMerge"] = ExpressionConverter.ConvertO(bodyobjectIdToMerge);
                    bodypropCount++;
                }

                if (bodyprimaryObjectId != null)
                {
                    body["primaryObjectId"] = ExpressionConverter.ConvertO(bodyprimaryObjectId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MergeTwoObjectsWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildGdprDeleteObjectType))]
        public IBodyWorkflowAction<string> GdprDeleteObjectType([WorkflowExpression] Func<string> objectType, [WorkflowExpression] Func<string> bodyobjectId = null, [WorkflowExpression] Func<string> bodyidProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGdprDeleteObjectType(WorkflowExpression<string> objectType, WorkflowExpression<string> bodyobjectId = null, WorkflowExpression<string> bodyidProperty = null)
        {
            WorkflowExpression.Validate(objectType, nameof(objectType), required: true);
            WorkflowExpression.Validate(bodyobjectId, nameof(bodyobjectId), required: false);
            WorkflowExpression.Validate(bodyidProperty, nameof(bodyidProperty), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/{0}/gdpr-delete", ExpressionConverter.ConvertWithUrlEncoding(objectType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectId != null)
                {
                    body["objectId"] = ExpressionConverter.ConvertO(bodyobjectId);
                    bodypropCount++;
                }

                if (bodyidProperty != null)
                {
                    body["idProperty"] = ExpressionConverter.ConvertO(bodyidProperty);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildPostCrmV3ObjectsObjectTypeSearch))]
        public IBodyWorkflowAction<PostCrmV3ObjectsObjectTypeSearchResponse> PostCrmV3ObjectsObjectTypeSearch([WorkflowExpression] Func<string> objectType, [WorkflowExpression] Func<string> bodyafter = null, [WorkflowExpression] Func<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, [WorkflowExpression] Func<string> bodylimit = null, [WorkflowExpression] Func<string[]> bodyproperties = null, [WorkflowExpression] Func<string[]> bodysorts = null, [WorkflowExpression] Func<string> bodyquery = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostCrmV3ObjectsObjectTypeSearchResponse> __BuildPostCrmV3ObjectsObjectTypeSearch(WorkflowExpression<string> objectType, WorkflowExpression<string> bodyafter = null, WorkflowExpression<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, WorkflowExpression<string> bodylimit = null, WorkflowExpression<string[]> bodyproperties = null, WorkflowExpression<string[]> bodysorts = null, WorkflowExpression<string> bodyquery = null)
        {
            WorkflowExpression.Validate(objectType, nameof(objectType), required: true);
            WorkflowExpression.Validate(bodyafter, nameof(bodyafter), required: false);
            WorkflowExpression.Validate(bodyfilterGroups, nameof(bodyfilterGroups), required: false);
            WorkflowExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            WorkflowExpression.Validate(bodyproperties, nameof(bodyproperties), required: false);
            WorkflowExpression.Validate(bodysorts, nameof(bodysorts), required: false);
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            return new DeferredBodyAction<PostCrmV3ObjectsObjectTypeSearchResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/{0}/search", ExpressionConverter.ConvertWithUrlEncoding(objectType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyafter != null)
                {
                    body["after"] = ExpressionConverter.ConvertO(bodyafter);
                    bodypropCount++;
                }

                if (bodyfilterGroups != null)
                {
                    body["filterGroups"] = ExpressionConverter.ConvertO(bodyfilterGroups);
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(bodylimit);
                    bodypropCount++;
                }

                if (bodyproperties != null)
                {
                    body["properties"] = ExpressionConverter.ConvertO(bodyproperties);
                    bodypropCount++;
                }

                if (bodysorts != null)
                {
                    body["sorts"] = ExpressionConverter.ConvertO(bodysorts);
                    bodypropCount++;
                }

                if (bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(bodyquery);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostCrmV3ObjectsObjectTypeSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchiveABatchOfDiscountsById))]
        public IBodyWorkflowAction<string> ArchiveABatchOfDiscountsById([WorkflowExpression] Func<bodyinputsInputItem[]> bodyinputs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchiveABatchOfDiscountsById(WorkflowExpression<bodyinputsInputItem[]> bodyinputs = null)
        {
            WorkflowExpression.Validate(bodyinputs, nameof(bodyinputs), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/discounts/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildRead16))]
        public IBodyWorkflowAction<Read16Response> Read16([WorkflowExpression] Func<string> discountId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Read16Response> __BuildRead16(WorkflowExpression<string> discountId, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(discountId, nameof(discountId), required: true);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Read16Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/discounts/{0}", ExpressionConverter.ConvertWithUrlEncoding(discountId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                return new ApiConnectionAction<Read16Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchive17))]
        public IBodyWorkflowAction<string> Archive17([WorkflowExpression] Func<string> discountId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchive17(WorkflowExpression<string> discountId)
        {
            WorkflowExpression.Validate(discountId, nameof(discountId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/discounts/{0}", ExpressionConverter.ConvertWithUrlEncoding(discountId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildUpdate18))]
        public IBodyWorkflowAction<Update18Response> Update18([WorkflowExpression] Func<string> discountId, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Update18Response> __BuildUpdate18(WorkflowExpression<string> discountId, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(discountId, nameof(discountId), required: true);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Update18Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/discounts/{0}", ExpressionConverter.ConvertWithUrlEncoding(discountId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Update18Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildList19))]
        public IBodyWorkflowAction<List19Response> List19([WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<List19Response> __BuildList19(WorkflowExpression<string> limit = null, WorkflowExpression<string> after = null, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List19Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/discounts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction<List19Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildCreate20))]
        public IBodyWorkflowAction<Create20Response> Create20([WorkflowExpression] Func<bodyassociationsInputItem[]> bodyassociations = null, [WorkflowExpression] Func<string> bodypropertiesnostrudcf = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Create20Response> __BuildCreate20(WorkflowExpression<bodyassociationsInputItem[]> bodyassociations = null, WorkflowExpression<string> bodypropertiesnostrudcf = null)
        {
            WorkflowExpression.Validate(bodyassociations, nameof(bodyassociations), required: false);
            WorkflowExpression.Validate(bodypropertiesnostrudcf, nameof(bodypropertiesnostrudcf), required: false);
            return new DeferredBodyAction<Create20Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/discounts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassociations != null)
                {
                    body["associations"] = ExpressionConverter.ConvertO(bodyassociations);
                    bodypropCount++;
                }

                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (bodypropertiesnostrudcf != null)
                {
                    propertiesObject["nostrudcf"] = ExpressionConverter.ConvertO(bodypropertiesnostrudcf);
                    propertiesObjectpropCount++;
                }

                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Create20Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildMergeTwoDiscountsWithSameType))]
        public IBodyWorkflowAction<MergeTwoDiscountsWithSameTypeResponse> MergeTwoDiscountsWithSameType([WorkflowExpression] Func<string> bodyobjectIdToMerge = null, [WorkflowExpression] Func<string> bodyprimaryObjectId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MergeTwoDiscountsWithSameTypeResponse> __BuildMergeTwoDiscountsWithSameType(WorkflowExpression<string> bodyobjectIdToMerge = null, WorkflowExpression<string> bodyprimaryObjectId = null)
        {
            WorkflowExpression.Validate(bodyobjectIdToMerge, nameof(bodyobjectIdToMerge), required: false);
            WorkflowExpression.Validate(bodyprimaryObjectId, nameof(bodyprimaryObjectId), required: false);
            return new DeferredBodyAction<MergeTwoDiscountsWithSameTypeResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/discounts/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectIdToMerge != null)
                {
                    body["objectIdToMerge"] = ExpressionConverter.ConvertO(bodyobjectIdToMerge);
                    bodypropCount++;
                }

                if (bodyprimaryObjectId != null)
                {
                    body["primaryObjectId"] = ExpressionConverter.ConvertO(bodyprimaryObjectId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MergeTwoDiscountsWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildGdprDeleteDiscounts))]
        public IBodyWorkflowAction<string> GdprDeleteDiscounts([WorkflowExpression] Func<string> bodyobjectId = null, [WorkflowExpression] Func<string> bodyidProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGdprDeleteDiscounts(WorkflowExpression<string> bodyobjectId = null, WorkflowExpression<string> bodyidProperty = null)
        {
            WorkflowExpression.Validate(bodyobjectId, nameof(bodyobjectId), required: false);
            WorkflowExpression.Validate(bodyidProperty, nameof(bodyidProperty), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/discounts/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectId != null)
                {
                    body["objectId"] = ExpressionConverter.ConvertO(bodyobjectId);
                    bodypropCount++;
                }

                if (bodyidProperty != null)
                {
                    body["idProperty"] = ExpressionConverter.ConvertO(bodyidProperty);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildPostCrmV3ObjectsDiscountsSearch))]
        public IBodyWorkflowAction<PostCrmV3ObjectsDiscountsSearchResponse> PostCrmV3ObjectsDiscountsSearch([WorkflowExpression] Func<string> bodyafter = null, [WorkflowExpression] Func<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, [WorkflowExpression] Func<string> bodylimit = null, [WorkflowExpression] Func<string[]> bodyproperties = null, [WorkflowExpression] Func<string[]> bodysorts = null, [WorkflowExpression] Func<string> bodyquery = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostCrmV3ObjectsDiscountsSearchResponse> __BuildPostCrmV3ObjectsDiscountsSearch(WorkflowExpression<string> bodyafter = null, WorkflowExpression<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, WorkflowExpression<string> bodylimit = null, WorkflowExpression<string[]> bodyproperties = null, WorkflowExpression<string[]> bodysorts = null, WorkflowExpression<string> bodyquery = null)
        {
            WorkflowExpression.Validate(bodyafter, nameof(bodyafter), required: false);
            WorkflowExpression.Validate(bodyfilterGroups, nameof(bodyfilterGroups), required: false);
            WorkflowExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            WorkflowExpression.Validate(bodyproperties, nameof(bodyproperties), required: false);
            WorkflowExpression.Validate(bodysorts, nameof(bodysorts), required: false);
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            return new DeferredBodyAction<PostCrmV3ObjectsDiscountsSearchResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/discounts/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyafter != null)
                {
                    body["after"] = ExpressionConverter.ConvertO(bodyafter);
                    bodypropCount++;
                }

                if (bodyfilterGroups != null)
                {
                    body["filterGroups"] = ExpressionConverter.ConvertO(bodyfilterGroups);
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(bodylimit);
                    bodypropCount++;
                }

                if (bodyproperties != null)
                {
                    body["properties"] = ExpressionConverter.ConvertO(bodyproperties);
                    bodypropCount++;
                }

                if (bodysorts != null)
                {
                    body["sorts"] = ExpressionConverter.ConvertO(bodysorts);
                    bodypropCount++;
                }

                if (bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(bodyquery);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostCrmV3ObjectsDiscountsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchiveABatchOfFeedbackSubmissionsById))]
        public IBodyWorkflowAction<string> ArchiveABatchOfFeedbackSubmissionsById([WorkflowExpression] Func<bodyinputsInputItem[]> bodyinputs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchiveABatchOfFeedbackSubmissionsById(WorkflowExpression<bodyinputsInputItem[]> bodyinputs = null)
        {
            WorkflowExpression.Validate(bodyinputs, nameof(bodyinputs), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/feedback_submissions/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildRead28))]
        public IBodyWorkflowAction<Read28Response> Read28([WorkflowExpression] Func<string> feedbackSubmissionId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Read28Response> __BuildRead28(WorkflowExpression<string> feedbackSubmissionId, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(feedbackSubmissionId, nameof(feedbackSubmissionId), required: true);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Read28Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/feedback_submissions/{0}", ExpressionConverter.ConvertWithUrlEncoding(feedbackSubmissionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                return new ApiConnectionAction<Read28Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchive29))]
        public IBodyWorkflowAction<string> Archive29([WorkflowExpression] Func<string> feedbackSubmissionId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchive29(WorkflowExpression<string> feedbackSubmissionId)
        {
            WorkflowExpression.Validate(feedbackSubmissionId, nameof(feedbackSubmissionId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/feedback_submissions/{0}", ExpressionConverter.ConvertWithUrlEncoding(feedbackSubmissionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildUpdate30))]
        public IBodyWorkflowAction<Update30Response> Update30([WorkflowExpression] Func<string> feedbackSubmissionId, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Update30Response> __BuildUpdate30(WorkflowExpression<string> feedbackSubmissionId, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(feedbackSubmissionId, nameof(feedbackSubmissionId), required: true);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Update30Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/feedback_submissions/{0}", ExpressionConverter.ConvertWithUrlEncoding(feedbackSubmissionId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Update30Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildList31))]
        public IBodyWorkflowAction<List31Response> List31([WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<List31Response> __BuildList31(WorkflowExpression<string> limit = null, WorkflowExpression<string> after = null, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List31Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/feedback_submissions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction<List31Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildCreate32))]
        public IBodyWorkflowAction<Create32Response> Create32([WorkflowExpression] Func<bodyassociationsInputItem[]> bodyassociations = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Create32Response> __BuildCreate32(WorkflowExpression<bodyassociationsInputItem[]> bodyassociations = null)
        {
            WorkflowExpression.Validate(bodyassociations, nameof(bodyassociations), required: false);
            return new DeferredBodyAction<Create32Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/feedback_submissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassociations != null)
                {
                    body["associations"] = ExpressionConverter.ConvertO(bodyassociations);
                    bodypropCount++;
                }

                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Create32Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildMergeTwoFeedbackSubmissionsWithSameType))]
        public IBodyWorkflowAction<MergeTwoFeedbackSubmissionsWithSameTypeResponse> MergeTwoFeedbackSubmissionsWithSameType([WorkflowExpression] Func<string> bodyobjectIdToMerge = null, [WorkflowExpression] Func<string> bodyprimaryObjectId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MergeTwoFeedbackSubmissionsWithSameTypeResponse> __BuildMergeTwoFeedbackSubmissionsWithSameType(WorkflowExpression<string> bodyobjectIdToMerge = null, WorkflowExpression<string> bodyprimaryObjectId = null)
        {
            WorkflowExpression.Validate(bodyobjectIdToMerge, nameof(bodyobjectIdToMerge), required: false);
            WorkflowExpression.Validate(bodyprimaryObjectId, nameof(bodyprimaryObjectId), required: false);
            return new DeferredBodyAction<MergeTwoFeedbackSubmissionsWithSameTypeResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/feedback_submissions/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectIdToMerge != null)
                {
                    body["objectIdToMerge"] = ExpressionConverter.ConvertO(bodyobjectIdToMerge);
                    bodypropCount++;
                }

                if (bodyprimaryObjectId != null)
                {
                    body["primaryObjectId"] = ExpressionConverter.ConvertO(bodyprimaryObjectId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MergeTwoFeedbackSubmissionsWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildGdprDeleteFeedback))]
        public IBodyWorkflowAction<string> GdprDeleteFeedback([WorkflowExpression] Func<string> bodyobjectId = null, [WorkflowExpression] Func<string> bodyidProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGdprDeleteFeedback(WorkflowExpression<string> bodyobjectId = null, WorkflowExpression<string> bodyidProperty = null)
        {
            WorkflowExpression.Validate(bodyobjectId, nameof(bodyobjectId), required: false);
            WorkflowExpression.Validate(bodyidProperty, nameof(bodyidProperty), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/feedback_submissions/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectId != null)
                {
                    body["objectId"] = ExpressionConverter.ConvertO(bodyobjectId);
                    bodypropCount++;
                }

                if (bodyidProperty != null)
                {
                    body["idProperty"] = ExpressionConverter.ConvertO(bodyidProperty);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildPostCrmV3ObjectsFeedbackSubmissionsSearch))]
        public IBodyWorkflowAction<PostCrmV3ObjectsFeedbackSubmissionsSearchResponse> PostCrmV3ObjectsFeedbackSubmissionsSearch([WorkflowExpression] Func<string> bodyafter = null, [WorkflowExpression] Func<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, [WorkflowExpression] Func<string> bodylimit = null, [WorkflowExpression] Func<string[]> bodyproperties = null, [WorkflowExpression] Func<string[]> bodysorts = null, [WorkflowExpression] Func<string> bodyquery = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostCrmV3ObjectsFeedbackSubmissionsSearchResponse> __BuildPostCrmV3ObjectsFeedbackSubmissionsSearch(WorkflowExpression<string> bodyafter = null, WorkflowExpression<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, WorkflowExpression<string> bodylimit = null, WorkflowExpression<string[]> bodyproperties = null, WorkflowExpression<string[]> bodysorts = null, WorkflowExpression<string> bodyquery = null)
        {
            WorkflowExpression.Validate(bodyafter, nameof(bodyafter), required: false);
            WorkflowExpression.Validate(bodyfilterGroups, nameof(bodyfilterGroups), required: false);
            WorkflowExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            WorkflowExpression.Validate(bodyproperties, nameof(bodyproperties), required: false);
            WorkflowExpression.Validate(bodysorts, nameof(bodysorts), required: false);
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            return new DeferredBodyAction<PostCrmV3ObjectsFeedbackSubmissionsSearchResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/feedback_submissions/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyafter != null)
                {
                    body["after"] = ExpressionConverter.ConvertO(bodyafter);
                    bodypropCount++;
                }

                if (bodyfilterGroups != null)
                {
                    body["filterGroups"] = ExpressionConverter.ConvertO(bodyfilterGroups);
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(bodylimit);
                    bodypropCount++;
                }

                if (bodyproperties != null)
                {
                    body["properties"] = ExpressionConverter.ConvertO(bodyproperties);
                    bodypropCount++;
                }

                if (bodysorts != null)
                {
                    body["sorts"] = ExpressionConverter.ConvertO(bodysorts);
                    bodypropCount++;
                }

                if (bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(bodyquery);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostCrmV3ObjectsFeedbackSubmissionsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchiveABatchOfQuotesById))]
        public IBodyWorkflowAction<string> ArchiveABatchOfQuotesById([WorkflowExpression] Func<bodyinputsInputItem[]> bodyinputs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchiveABatchOfQuotesById(WorkflowExpression<bodyinputsInputItem[]> bodyinputs = null)
        {
            WorkflowExpression.Validate(bodyinputs, nameof(bodyinputs), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/quotes/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildList40))]
        public IBodyWorkflowAction<List40Response> List40([WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<List40Response> __BuildList40(WorkflowExpression<string> limit = null, WorkflowExpression<string> after = null, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List40Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/quotes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction<List40Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildCreate41))]
        public IBodyWorkflowAction<Create41Response> Create41([WorkflowExpression] Func<bodyassociationsInputItem[]> bodyassociations = null, [WorkflowExpression] Func<string> bodypropertieselit26 = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Create41Response> __BuildCreate41(WorkflowExpression<bodyassociationsInputItem[]> bodyassociations = null, WorkflowExpression<string> bodypropertieselit26 = null)
        {
            WorkflowExpression.Validate(bodyassociations, nameof(bodyassociations), required: false);
            WorkflowExpression.Validate(bodypropertieselit26, nameof(bodypropertieselit26), required: false);
            return new DeferredBodyAction<Create41Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/quotes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassociations != null)
                {
                    body["associations"] = ExpressionConverter.ConvertO(bodyassociations);
                    bodypropCount++;
                }

                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (bodypropertieselit26 != null)
                {
                    propertiesObject["elit_26"] = ExpressionConverter.ConvertO(bodypropertieselit26);
                    propertiesObjectpropCount++;
                }

                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Create41Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildRead42))]
        public IBodyWorkflowAction<Read42Response> Read42([WorkflowExpression] Func<string> quoteId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Read42Response> __BuildRead42(WorkflowExpression<string> quoteId, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(quoteId, nameof(quoteId), required: true);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Read42Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/quotes/{0}", ExpressionConverter.ConvertWithUrlEncoding(quoteId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                return new ApiConnectionAction<Read42Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchive43))]
        public IBodyWorkflowAction<string> Archive43([WorkflowExpression] Func<string> quoteId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchive43(WorkflowExpression<string> quoteId)
        {
            WorkflowExpression.Validate(quoteId, nameof(quoteId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/quotes/{0}", ExpressionConverter.ConvertWithUrlEncoding(quoteId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildUpdate44))]
        public IBodyWorkflowAction<Update44Response> Update44([WorkflowExpression] Func<string> quoteId, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Update44Response> __BuildUpdate44(WorkflowExpression<string> quoteId, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(quoteId, nameof(quoteId), required: true);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Update44Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/quotes/{0}", ExpressionConverter.ConvertWithUrlEncoding(quoteId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Update44Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildMergeTwoQuotesWithSameType))]
        public IBodyWorkflowAction<MergeTwoQuotesWithSameTypeResponse> MergeTwoQuotesWithSameType([WorkflowExpression] Func<string> bodyobjectIdToMerge = null, [WorkflowExpression] Func<string> bodyprimaryObjectId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MergeTwoQuotesWithSameTypeResponse> __BuildMergeTwoQuotesWithSameType(WorkflowExpression<string> bodyobjectIdToMerge = null, WorkflowExpression<string> bodyprimaryObjectId = null)
        {
            WorkflowExpression.Validate(bodyobjectIdToMerge, nameof(bodyobjectIdToMerge), required: false);
            WorkflowExpression.Validate(bodyprimaryObjectId, nameof(bodyprimaryObjectId), required: false);
            return new DeferredBodyAction<MergeTwoQuotesWithSameTypeResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/quotes/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectIdToMerge != null)
                {
                    body["objectIdToMerge"] = ExpressionConverter.ConvertO(bodyobjectIdToMerge);
                    bodypropCount++;
                }

                if (bodyprimaryObjectId != null)
                {
                    body["primaryObjectId"] = ExpressionConverter.ConvertO(bodyprimaryObjectId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MergeTwoQuotesWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildGdprDeleteQuotes))]
        public IBodyWorkflowAction<string> GdprDeleteQuotes([WorkflowExpression] Func<string> bodyobjectId = null, [WorkflowExpression] Func<string> bodyidProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGdprDeleteQuotes(WorkflowExpression<string> bodyobjectId = null, WorkflowExpression<string> bodyidProperty = null)
        {
            WorkflowExpression.Validate(bodyobjectId, nameof(bodyobjectId), required: false);
            WorkflowExpression.Validate(bodyidProperty, nameof(bodyidProperty), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/quotes/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectId != null)
                {
                    body["objectId"] = ExpressionConverter.ConvertO(bodyobjectId);
                    bodypropCount++;
                }

                if (bodyidProperty != null)
                {
                    body["idProperty"] = ExpressionConverter.ConvertO(bodyidProperty);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildPostCrmV3ObjectsQuotesSearch))]
        public IBodyWorkflowAction<PostCrmV3ObjectsQuotesSearchResponse> PostCrmV3ObjectsQuotesSearch([WorkflowExpression] Func<string> bodyafter = null, [WorkflowExpression] Func<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, [WorkflowExpression] Func<string> bodylimit = null, [WorkflowExpression] Func<string[]> bodyproperties = null, [WorkflowExpression] Func<string[]> bodysorts = null, [WorkflowExpression] Func<string> bodyquery = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostCrmV3ObjectsQuotesSearchResponse> __BuildPostCrmV3ObjectsQuotesSearch(WorkflowExpression<string> bodyafter = null, WorkflowExpression<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, WorkflowExpression<string> bodylimit = null, WorkflowExpression<string[]> bodyproperties = null, WorkflowExpression<string[]> bodysorts = null, WorkflowExpression<string> bodyquery = null)
        {
            WorkflowExpression.Validate(bodyafter, nameof(bodyafter), required: false);
            WorkflowExpression.Validate(bodyfilterGroups, nameof(bodyfilterGroups), required: false);
            WorkflowExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            WorkflowExpression.Validate(bodyproperties, nameof(bodyproperties), required: false);
            WorkflowExpression.Validate(bodysorts, nameof(bodysorts), required: false);
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            return new DeferredBodyAction<PostCrmV3ObjectsQuotesSearchResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/quotes/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyafter != null)
                {
                    body["after"] = ExpressionConverter.ConvertO(bodyafter);
                    bodypropCount++;
                }

                if (bodyfilterGroups != null)
                {
                    body["filterGroups"] = ExpressionConverter.ConvertO(bodyfilterGroups);
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(bodylimit);
                    bodypropCount++;
                }

                if (bodyproperties != null)
                {
                    body["properties"] = ExpressionConverter.ConvertO(bodyproperties);
                    bodypropCount++;
                }

                if (bodysorts != null)
                {
                    body["sorts"] = ExpressionConverter.ConvertO(bodysorts);
                    bodypropCount++;
                }

                if (bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(bodyquery);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostCrmV3ObjectsQuotesSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchiveABatchOfTaxesById))]
        public IBodyWorkflowAction<string> ArchiveABatchOfTaxesById([WorkflowExpression] Func<bodyinputsInputItem[]> bodyinputs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchiveABatchOfTaxesById(WorkflowExpression<bodyinputsInputItem[]> bodyinputs = null)
        {
            WorkflowExpression.Validate(bodyinputs, nameof(bodyinputs), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/taxes/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildList52))]
        public IBodyWorkflowAction<List52Response> List52([WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<List52Response> __BuildList52(WorkflowExpression<string> limit = null, WorkflowExpression<string> after = null, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List52Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/taxes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction<List52Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildCreate53))]
        public IBodyWorkflowAction<Create53Response> Create53([WorkflowExpression] Func<bodyassociationsInputItem[]> bodyassociations = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Create53Response> __BuildCreate53(WorkflowExpression<bodyassociationsInputItem[]> bodyassociations = null)
        {
            WorkflowExpression.Validate(bodyassociations, nameof(bodyassociations), required: false);
            return new DeferredBodyAction<Create53Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/taxes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassociations != null)
                {
                    body["associations"] = ExpressionConverter.ConvertO(bodyassociations);
                    bodypropCount++;
                }

                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Create53Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildRead54))]
        public IBodyWorkflowAction<Read54Response> Read54([WorkflowExpression] Func<string> taxId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Read54Response> __BuildRead54(WorkflowExpression<string> taxId, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(taxId, nameof(taxId), required: true);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Read54Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/taxes/{0}", ExpressionConverter.ConvertWithUrlEncoding(taxId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                return new ApiConnectionAction<Read54Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchive55))]
        public IBodyWorkflowAction<string> Archive55([WorkflowExpression] Func<string> taxId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchive55(WorkflowExpression<string> taxId)
        {
            WorkflowExpression.Validate(taxId, nameof(taxId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/taxes/{0}", ExpressionConverter.ConvertWithUrlEncoding(taxId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildUpdate56))]
        public IBodyWorkflowAction<Update56Response> Update56([WorkflowExpression] Func<string> taxId, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Update56Response> __BuildUpdate56(WorkflowExpression<string> taxId, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(taxId, nameof(taxId), required: true);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Update56Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/taxes/{0}", ExpressionConverter.ConvertWithUrlEncoding(taxId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Update56Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildMergeTwoTaxesWithSameType))]
        public IBodyWorkflowAction<MergeTwoTaxesWithSameTypeResponse> MergeTwoTaxesWithSameType([WorkflowExpression] Func<string> bodyobjectIdToMerge = null, [WorkflowExpression] Func<string> bodyprimaryObjectId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MergeTwoTaxesWithSameTypeResponse> __BuildMergeTwoTaxesWithSameType(WorkflowExpression<string> bodyobjectIdToMerge = null, WorkflowExpression<string> bodyprimaryObjectId = null)
        {
            WorkflowExpression.Validate(bodyobjectIdToMerge, nameof(bodyobjectIdToMerge), required: false);
            WorkflowExpression.Validate(bodyprimaryObjectId, nameof(bodyprimaryObjectId), required: false);
            return new DeferredBodyAction<MergeTwoTaxesWithSameTypeResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/taxes/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectIdToMerge != null)
                {
                    body["objectIdToMerge"] = ExpressionConverter.ConvertO(bodyobjectIdToMerge);
                    bodypropCount++;
                }

                if (bodyprimaryObjectId != null)
                {
                    body["primaryObjectId"] = ExpressionConverter.ConvertO(bodyprimaryObjectId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MergeTwoTaxesWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildGdprDeleteTaxes))]
        public IBodyWorkflowAction<string> GdprDeleteTaxes([WorkflowExpression] Func<string> bodyobjectId = null, [WorkflowExpression] Func<string> bodyidProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGdprDeleteTaxes(WorkflowExpression<string> bodyobjectId = null, WorkflowExpression<string> bodyidProperty = null)
        {
            WorkflowExpression.Validate(bodyobjectId, nameof(bodyobjectId), required: false);
            WorkflowExpression.Validate(bodyidProperty, nameof(bodyidProperty), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/taxes/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectId != null)
                {
                    body["objectId"] = ExpressionConverter.ConvertO(bodyobjectId);
                    bodypropCount++;
                }

                if (bodyidProperty != null)
                {
                    body["idProperty"] = ExpressionConverter.ConvertO(bodyidProperty);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildPostCrmV3ObjectsTaxesSearch))]
        public IBodyWorkflowAction<PostCrmV3ObjectsTaxesSearchResponse> PostCrmV3ObjectsTaxesSearch([WorkflowExpression] Func<string> bodyafter = null, [WorkflowExpression] Func<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, [WorkflowExpression] Func<string> bodylimit = null, [WorkflowExpression] Func<string[]> bodyproperties = null, [WorkflowExpression] Func<string[]> bodysorts = null, [WorkflowExpression] Func<string> bodyquery = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostCrmV3ObjectsTaxesSearchResponse> __BuildPostCrmV3ObjectsTaxesSearch(WorkflowExpression<string> bodyafter = null, WorkflowExpression<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, WorkflowExpression<string> bodylimit = null, WorkflowExpression<string[]> bodyproperties = null, WorkflowExpression<string[]> bodysorts = null, WorkflowExpression<string> bodyquery = null)
        {
            WorkflowExpression.Validate(bodyafter, nameof(bodyafter), required: false);
            WorkflowExpression.Validate(bodyfilterGroups, nameof(bodyfilterGroups), required: false);
            WorkflowExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            WorkflowExpression.Validate(bodyproperties, nameof(bodyproperties), required: false);
            WorkflowExpression.Validate(bodysorts, nameof(bodysorts), required: false);
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            return new DeferredBodyAction<PostCrmV3ObjectsTaxesSearchResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/taxes/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyafter != null)
                {
                    body["after"] = ExpressionConverter.ConvertO(bodyafter);
                    bodypropCount++;
                }

                if (bodyfilterGroups != null)
                {
                    body["filterGroups"] = ExpressionConverter.ConvertO(bodyfilterGroups);
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(bodylimit);
                    bodypropCount++;
                }

                if (bodyproperties != null)
                {
                    body["properties"] = ExpressionConverter.ConvertO(bodyproperties);
                    bodypropCount++;
                }

                if (bodysorts != null)
                {
                    body["sorts"] = ExpressionConverter.ConvertO(bodysorts);
                    bodypropCount++;
                }

                if (bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(bodyquery);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostCrmV3ObjectsTaxesSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchiveABatchOfTicketsById))]
        public IBodyWorkflowAction<string> ArchiveABatchOfTicketsById([WorkflowExpression] Func<bodyinputsInputItem[]> bodyinputs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchiveABatchOfTicketsById(WorkflowExpression<bodyinputsInputItem[]> bodyinputs = null)
        {
            WorkflowExpression.Validate(bodyinputs, nameof(bodyinputs), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/tickets/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildRead64))]
        public IBodyWorkflowAction<Read64Response> Read64([WorkflowExpression] Func<string> ticketId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Read64Response> __BuildRead64(WorkflowExpression<string> ticketId, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(ticketId, nameof(ticketId), required: true);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Read64Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/tickets/{0}", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                return new ApiConnectionAction<Read64Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildArchive65))]
        public IBodyWorkflowAction<string> Archive65([WorkflowExpression] Func<string> ticketId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildArchive65(WorkflowExpression<string> ticketId)
        {
            WorkflowExpression.Validate(ticketId, nameof(ticketId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/tickets/{0}", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildUpdate66))]
        public IBodyWorkflowAction<Update66Response> Update66([WorkflowExpression] Func<string> ticketId, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Update66Response> __BuildUpdate66(WorkflowExpression<string> ticketId, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(ticketId, nameof(ticketId), required: true);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredBodyAction<Update66Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/tickets/{0}", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Update66Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildList67))]
        public IBodyWorkflowAction<List67Response> List67([WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertiesWithHistory = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<List67Response> __BuildList67(WorkflowExpression<string> limit = null, WorkflowExpression<string> after = null, WorkflowExpression<string> properties = null, WorkflowExpression<string> propertiesWithHistory = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(propertiesWithHistory, nameof(propertiesWithHistory), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredBodyAction<List67Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/tickets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (propertiesWithHistory != null)
                    callPayload.Queries["propertiesWithHistory"] = ExpressionConverter.Convert(propertiesWithHistory);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction<List67Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildCreate68))]
        public IBodyWorkflowAction<Create68Response> Create68([WorkflowExpression] Func<bodyassociationsInputItem[]> bodyassociations = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Create68Response> __BuildCreate68(WorkflowExpression<bodyassociationsInputItem[]> bodyassociations = null)
        {
            WorkflowExpression.Validate(bodyassociations, nameof(bodyassociations), required: false);
            return new DeferredBodyAction<Create68Response>(() =>
            {
                var apiCallPath = "/crm/v3/objects/tickets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassociations != null)
                {
                    body["associations"] = ExpressionConverter.ConvertO(bodyassociations);
                    bodypropCount++;
                }

                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Create68Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildMergeTwoTicketsWithSameType))]
        public IBodyWorkflowAction<MergeTwoTicketsWithSameTypeResponse> MergeTwoTicketsWithSameType([WorkflowExpression] Func<string> bodyobjectIdToMerge = null, [WorkflowExpression] Func<string> bodyprimaryObjectId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MergeTwoTicketsWithSameTypeResponse> __BuildMergeTwoTicketsWithSameType(WorkflowExpression<string> bodyobjectIdToMerge = null, WorkflowExpression<string> bodyprimaryObjectId = null)
        {
            WorkflowExpression.Validate(bodyobjectIdToMerge, nameof(bodyobjectIdToMerge), required: false);
            WorkflowExpression.Validate(bodyprimaryObjectId, nameof(bodyprimaryObjectId), required: false);
            return new DeferredBodyAction<MergeTwoTicketsWithSameTypeResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/tickets/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectIdToMerge != null)
                {
                    body["objectIdToMerge"] = ExpressionConverter.ConvertO(bodyobjectIdToMerge);
                    bodypropCount++;
                }

                if (bodyprimaryObjectId != null)
                {
                    body["primaryObjectId"] = ExpressionConverter.ConvertO(bodyprimaryObjectId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MergeTwoTicketsWithSameTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildGdprDeleteTickets))]
        public IBodyWorkflowAction<string> GdprDeleteTickets([WorkflowExpression] Func<string> bodyobjectId = null, [WorkflowExpression] Func<string> bodyidProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGdprDeleteTickets(WorkflowExpression<string> bodyobjectId = null, WorkflowExpression<string> bodyidProperty = null)
        {
            WorkflowExpression.Validate(bodyobjectId, nameof(bodyobjectId), required: false);
            WorkflowExpression.Validate(bodyidProperty, nameof(bodyidProperty), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/crm/v3/objects/tickets/gdpr-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectId != null)
                {
                    body["objectId"] = ExpressionConverter.ConvertO(bodyobjectId);
                    bodypropCount++;
                }

                if (bodyidProperty != null)
                {
                    body["idProperty"] = ExpressionConverter.ConvertO(bodyidProperty);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildPostCrmV3ObjectsTicketsSearch))]
        public IBodyWorkflowAction<PostCrmV3ObjectsTicketsSearchResponse> PostCrmV3ObjectsTicketsSearch([WorkflowExpression] Func<string> bodyafter = null, [WorkflowExpression] Func<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, [WorkflowExpression] Func<string> bodylimit = null, [WorkflowExpression] Func<string[]> bodyproperties = null, [WorkflowExpression] Func<string[]> bodysorts = null, [WorkflowExpression] Func<string> bodyquery = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostCrmV3ObjectsTicketsSearchResponse> __BuildPostCrmV3ObjectsTicketsSearch(WorkflowExpression<string> bodyafter = null, WorkflowExpression<bodyfilterGroupsInputItem[]> bodyfilterGroups = null, WorkflowExpression<string> bodylimit = null, WorkflowExpression<string[]> bodyproperties = null, WorkflowExpression<string[]> bodysorts = null, WorkflowExpression<string> bodyquery = null)
        {
            WorkflowExpression.Validate(bodyafter, nameof(bodyafter), required: false);
            WorkflowExpression.Validate(bodyfilterGroups, nameof(bodyfilterGroups), required: false);
            WorkflowExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            WorkflowExpression.Validate(bodyproperties, nameof(bodyproperties), required: false);
            WorkflowExpression.Validate(bodysorts, nameof(bodysorts), required: false);
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            return new DeferredBodyAction<PostCrmV3ObjectsTicketsSearchResponse>(() =>
            {
                var apiCallPath = "/crm/v3/objects/tickets/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyafter != null)
                {
                    body["after"] = ExpressionConverter.ConvertO(bodyafter);
                    bodypropCount++;
                }

                if (bodyfilterGroups != null)
                {
                    body["filterGroups"] = ExpressionConverter.ConvertO(bodyfilterGroups);
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(bodylimit);
                    bodypropCount++;
                }

                if (bodyproperties != null)
                {
                    body["properties"] = ExpressionConverter.ConvertO(bodyproperties);
                    bodypropCount++;
                }

                if (bodysorts != null)
                {
                    body["sorts"] = ExpressionConverter.ConvertO(bodysorts);
                    bodypropCount++;
                }

                if (bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(bodyquery);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostCrmV3ObjectsTicketsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildListAssociationTypes))]
        public IBodyWorkflowAction<ListAssociationTypesResponse> ListAssociationTypes([WorkflowExpression] Func<string> fromObjectType, [WorkflowExpression] Func<string> toObjectType)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListAssociationTypesResponse> __BuildListAssociationTypes(WorkflowExpression<string> fromObjectType, WorkflowExpression<string> toObjectType)
        {
            WorkflowExpression.Validate(fromObjectType, nameof(fromObjectType), required: true);
            WorkflowExpression.Validate(toObjectType, nameof(toObjectType), required: true);
            return new DeferredBodyAction<ListAssociationTypesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/associations/{0}/{1}/types", ExpressionConverter.ConvertWithUrlEncoding(fromObjectType, 1), ExpressionConverter.ConvertWithUrlEncoding(toObjectType, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListAssociationTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteSpecificLabels))]
        public IBodyWorkflowAction<string> DeleteSpecificLabels([WorkflowExpression] Func<string> fromObjectType, [WorkflowExpression] Func<string> toObjectType, [WorkflowExpression] Func<bodyinputsInputItem2[]> bodyinputs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDeleteSpecificLabels(WorkflowExpression<string> fromObjectType, WorkflowExpression<string> toObjectType, WorkflowExpression<bodyinputsInputItem2[]> bodyinputs = null)
        {
            WorkflowExpression.Validate(fromObjectType, nameof(fromObjectType), required: true);
            WorkflowExpression.Validate(toObjectType, nameof(toObjectType), required: true);
            WorkflowExpression.Validate(bodyinputs, nameof(bodyinputs), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v4/associations/{0}/{1}/batch/labels/archive", ExpressionConverter.ConvertWithUrlEncoding(fromObjectType, 1), ExpressionConverter.ConvertWithUrlEncoding(toObjectType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildDelete))]
        public IBodyWorkflowAction<string> Delete([WorkflowExpression] Func<string> fromObjectType, [WorkflowExpression] Func<string> toObjectType, [WorkflowExpression] Func<bodyinputsInputItem22[]> bodyinputs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDelete(WorkflowExpression<string> fromObjectType, WorkflowExpression<string> toObjectType, WorkflowExpression<bodyinputsInputItem22[]> bodyinputs = null)
        {
            WorkflowExpression.Validate(fromObjectType, nameof(fromObjectType), required: true);
            WorkflowExpression.Validate(toObjectType, nameof(toObjectType), required: true);
            WorkflowExpression.Validate(bodyinputs, nameof(bodyinputs), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v4/associations/{0}/{1}/batch/archive", ExpressionConverter.ConvertWithUrlEncoding(fromObjectType, 1), ExpressionConverter.ConvertWithUrlEncoding(toObjectType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildCreateDefaultAssociations))]
        public IBodyWorkflowAction<CreateDefaultAssociationsResponse> CreateDefaultAssociations([WorkflowExpression] Func<string> fromObjectType, [WorkflowExpression] Func<string> toObjectType, [WorkflowExpression] Func<bodyinputsInputItem222[]> bodyinputs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateDefaultAssociationsResponse> __BuildCreateDefaultAssociations(WorkflowExpression<string> fromObjectType, WorkflowExpression<string> toObjectType, WorkflowExpression<bodyinputsInputItem222[]> bodyinputs = null)
        {
            WorkflowExpression.Validate(fromObjectType, nameof(fromObjectType), required: true);
            WorkflowExpression.Validate(toObjectType, nameof(toObjectType), required: true);
            WorkflowExpression.Validate(bodyinputs, nameof(bodyinputs), required: false);
            return new DeferredBodyAction<CreateDefaultAssociationsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v4/associations/{0}/{1}/batch/associate/default", ExpressionConverter.ConvertWithUrlEncoding(fromObjectType, 1), ExpressionConverter.ConvertWithUrlEncoding(toObjectType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinputs != null)
                {
                    body["inputs"] = ExpressionConverter.ConvertO(bodyinputs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateDefaultAssociationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildDelete6))]
        public IBodyWorkflowAction<string> Delete6([WorkflowExpression] Func<string> objectType, [WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> toObjectType, [WorkflowExpression] Func<string> toObjectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDelete6(WorkflowExpression<string> objectType, WorkflowExpression<string> objectId, WorkflowExpression<string> toObjectType, WorkflowExpression<string> toObjectId)
        {
            WorkflowExpression.Validate(objectType, nameof(objectType), required: true);
            WorkflowExpression.Validate(objectId, nameof(objectId), required: true);
            WorkflowExpression.Validate(toObjectType, nameof(toObjectType), required: true);
            WorkflowExpression.Validate(toObjectId, nameof(toObjectId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v4/objects/{0}/{1}/associations/{2}/{3}", ExpressionConverter.ConvertWithUrlEncoding(objectType, 1), ExpressionConverter.ConvertWithUrlEncoding(objectId, 1), ExpressionConverter.ConvertWithUrlEncoding(toObjectType, 1), ExpressionConverter.ConvertWithUrlEncoding(toObjectId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildCreate7))]
        public IBodyWorkflowAction<Create7Response> Create7([WorkflowExpression] Func<string> objectType, [WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> toObjectType, [WorkflowExpression] Func<string> toObjectId, [WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Create7Response> __BuildCreate7(WorkflowExpression<string> objectType, WorkflowExpression<string> objectId, WorkflowExpression<string> toObjectType, WorkflowExpression<string> toObjectId, WorkflowExpression<bodyInputItem[]> body = null)
        {
            WorkflowExpression.Validate(objectType, nameof(objectType), required: true);
            WorkflowExpression.Validate(objectId, nameof(objectId), required: true);
            WorkflowExpression.Validate(toObjectType, nameof(toObjectType), required: true);
            WorkflowExpression.Validate(toObjectId, nameof(toObjectId), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<Create7Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v4/objects/{0}/{1}/associations/{2}/{3}", ExpressionConverter.ConvertWithUrlEncoding(objectType, 1), ExpressionConverter.ConvertWithUrlEncoding(objectId, 1), ExpressionConverter.ConvertWithUrlEncoding(toObjectType, 1), ExpressionConverter.ConvertWithUrlEncoding(toObjectId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<Create7Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildCreateDefault))]
        public IBodyWorkflowAction<CreateDefaultResponse> CreateDefault([WorkflowExpression] Func<string> fromObjectType, [WorkflowExpression] Func<string> fromObjectId, [WorkflowExpression] Func<string> toObjectType, [WorkflowExpression] Func<string> toObjectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateDefaultResponse> __BuildCreateDefault(WorkflowExpression<string> fromObjectType, WorkflowExpression<string> fromObjectId, WorkflowExpression<string> toObjectType, WorkflowExpression<string> toObjectId)
        {
            WorkflowExpression.Validate(fromObjectType, nameof(fromObjectType), required: true);
            WorkflowExpression.Validate(fromObjectId, nameof(fromObjectId), required: true);
            WorkflowExpression.Validate(toObjectType, nameof(toObjectType), required: true);
            WorkflowExpression.Validate(toObjectId, nameof(toObjectId), required: true);
            return new DeferredBodyAction<CreateDefaultResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v4/objects/{0}/{1}/associations/default/{2}/{3}", ExpressionConverter.ConvertWithUrlEncoding(fromObjectType, 1), ExpressionConverter.ConvertWithUrlEncoding(fromObjectId, 1), ExpressionConverter.ConvertWithUrlEncoding(toObjectType, 1), ExpressionConverter.ConvertWithUrlEncoding(toObjectId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CreateDefaultResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildListAssociations))]
        public IBodyWorkflowAction<ListAssociationsResponse> ListAssociations([WorkflowExpression] Func<string> objectType, [WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<string> toObjectType, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListAssociationsResponse> __BuildListAssociations(WorkflowExpression<string> objectType, WorkflowExpression<string> objectId, WorkflowExpression<string> toObjectType, WorkflowExpression<string> after = null, WorkflowExpression<string> limit = null)
        {
            WorkflowExpression.Validate(objectType, nameof(objectType), required: true);
            WorkflowExpression.Validate(objectId, nameof(objectId), required: true);
            WorkflowExpression.Validate(toObjectType, nameof(toObjectType), required: true);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<ListAssociationsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v4/objects/{0}/{1}/associations/{2}", ExpressionConverter.ConvertWithUrlEncoding(objectType, 1), ExpressionConverter.ConvertWithUrlEncoding(objectId, 1), ExpressionConverter.ConvertWithUrlEncoding(toObjectType, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<ListAssociationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllCards))]
        public IBodyWorkflowAction<GetAllCardsResponse> GetAllCards([WorkflowExpression] Func<string> appId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllCardsResponse> __BuildGetAllCards(WorkflowExpression<string> appId)
        {
            WorkflowExpression.Validate(appId, nameof(appId), required: true);
            return new DeferredBodyAction<GetAllCardsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/extensions/cards-dev/{0}", ExpressionConverter.ConvertWithUrlEncoding(appId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAllCardsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildCreateANewCard))]
        public IBodyWorkflowAction<CreateANewCardResponse> CreateANewCard([WorkflowExpression] Func<string> appId, [WorkflowExpression] Func<string[]> bodyactionsbaseUrls = null, [WorkflowExpression] Func<bodydisplaypropertiesInputItem[]> bodydisplayproperties = null, [WorkflowExpression] Func<bodyfetchobjectTypesInputItem[]> bodyfetchobjectTypes = null, [WorkflowExpression] Func<string> bodyfetchtargetUrl = null, [WorkflowExpression] Func<string> bodyfetchcardType = null, [WorkflowExpression] Func<string> bodyfetchserverlessFunction = null, [WorkflowExpression] Func<string> bodytitle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateANewCardResponse> __BuildCreateANewCard(WorkflowExpression<string> appId, WorkflowExpression<string[]> bodyactionsbaseUrls = null, WorkflowExpression<bodydisplaypropertiesInputItem[]> bodydisplayproperties = null, WorkflowExpression<bodyfetchobjectTypesInputItem[]> bodyfetchobjectTypes = null, WorkflowExpression<string> bodyfetchtargetUrl = null, WorkflowExpression<string> bodyfetchcardType = null, WorkflowExpression<string> bodyfetchserverlessFunction = null, WorkflowExpression<string> bodytitle = null)
        {
            WorkflowExpression.Validate(appId, nameof(appId), required: true);
            WorkflowExpression.Validate(bodyactionsbaseUrls, nameof(bodyactionsbaseUrls), required: false);
            WorkflowExpression.Validate(bodydisplayproperties, nameof(bodydisplayproperties), required: false);
            WorkflowExpression.Validate(bodyfetchobjectTypes, nameof(bodyfetchobjectTypes), required: false);
            WorkflowExpression.Validate(bodyfetchtargetUrl, nameof(bodyfetchtargetUrl), required: false);
            WorkflowExpression.Validate(bodyfetchcardType, nameof(bodyfetchcardType), required: false);
            WorkflowExpression.Validate(bodyfetchserverlessFunction, nameof(bodyfetchserverlessFunction), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<CreateANewCardResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/extensions/cards-dev/{0}", ExpressionConverter.ConvertWithUrlEncoding(appId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var actionsObject = new JObject();
                var actionsObjectpropCount = 0;
                if (bodyactionsbaseUrls != null)
                {
                    actionsObject["baseUrls"] = ExpressionConverter.ConvertO(bodyactionsbaseUrls);
                    actionsObjectpropCount++;
                }

                if (actionsObjectpropCount > 0)
                {
                    body["actions"] = actionsObject;
                    bodypropCount++;
                }

                var displayObject = new JObject();
                var displayObjectpropCount = 0;
                if (bodydisplayproperties != null)
                {
                    displayObject["properties"] = ExpressionConverter.ConvertO(bodydisplayproperties);
                    displayObjectpropCount++;
                }

                if (displayObjectpropCount > 0)
                {
                    body["display"] = displayObject;
                    bodypropCount++;
                }

                var fetchObject = new JObject();
                var fetchObjectpropCount = 0;
                if (bodyfetchobjectTypes != null)
                {
                    fetchObject["objectTypes"] = ExpressionConverter.ConvertO(bodyfetchobjectTypes);
                    fetchObjectpropCount++;
                }

                if (bodyfetchtargetUrl != null)
                {
                    fetchObject["targetUrl"] = ExpressionConverter.ConvertO(bodyfetchtargetUrl);
                    fetchObjectpropCount++;
                }

                if (bodyfetchcardType != null)
                {
                    fetchObject["cardType"] = ExpressionConverter.ConvertO(bodyfetchcardType);
                    fetchObjectpropCount++;
                }

                if (bodyfetchserverlessFunction != null)
                {
                    fetchObject["serverlessFunction"] = ExpressionConverter.ConvertO(bodyfetchserverlessFunction);
                    fetchObjectpropCount++;
                }

                if (fetchObjectpropCount > 0)
                {
                    body["fetch"] = fetchObject;
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateANewCardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetACard))]
        public IBodyWorkflowAction<GetACardResponse> GetACard([WorkflowExpression] Func<string> appId, [WorkflowExpression] Func<string> cardId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetACardResponse> __BuildGetACard(WorkflowExpression<string> appId, WorkflowExpression<string> cardId)
        {
            WorkflowExpression.Validate(appId, nameof(appId), required: true);
            WorkflowExpression.Validate(cardId, nameof(cardId), required: true);
            return new DeferredBodyAction<GetACardResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/extensions/cards-dev/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(appId, 1), ExpressionConverter.ConvertWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetACardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteACard))]
        public IBodyWorkflowAction<string> DeleteACard([WorkflowExpression] Func<string> appId, [WorkflowExpression] Func<string> cardId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDeleteACard(WorkflowExpression<string> appId, WorkflowExpression<string> cardId)
        {
            WorkflowExpression.Validate(appId, nameof(appId), required: true);
            WorkflowExpression.Validate(cardId, nameof(cardId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/extensions/cards-dev/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(appId, 1), ExpressionConverter.ConvertWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateACard))]
        public IBodyWorkflowAction<UpdateACardResponse> UpdateACard([WorkflowExpression] Func<string> appId, [WorkflowExpression] Func<string> cardId, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<bodyfetchobjectTypesInputItem[]> bodyfetchobjectTypes = null, [WorkflowExpression] Func<string> bodyfetchcardType = null, [WorkflowExpression] Func<string> bodyfetchtargetUrl = null, [WorkflowExpression] Func<string> bodyfetchserverlessFunction = null, [WorkflowExpression] Func<bodydisplaypropertiesInputItem[]> bodydisplayproperties = null, [WorkflowExpression] Func<string[]> bodyactionsbaseUrls = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateACardResponse> __BuildUpdateACard(WorkflowExpression<string> appId, WorkflowExpression<string> cardId, WorkflowExpression<string> bodytitle = null, WorkflowExpression<bodyfetchobjectTypesInputItem[]> bodyfetchobjectTypes = null, WorkflowExpression<string> bodyfetchcardType = null, WorkflowExpression<string> bodyfetchtargetUrl = null, WorkflowExpression<string> bodyfetchserverlessFunction = null, WorkflowExpression<bodydisplaypropertiesInputItem[]> bodydisplayproperties = null, WorkflowExpression<string[]> bodyactionsbaseUrls = null)
        {
            WorkflowExpression.Validate(appId, nameof(appId), required: true);
            WorkflowExpression.Validate(cardId, nameof(cardId), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyfetchobjectTypes, nameof(bodyfetchobjectTypes), required: false);
            WorkflowExpression.Validate(bodyfetchcardType, nameof(bodyfetchcardType), required: false);
            WorkflowExpression.Validate(bodyfetchtargetUrl, nameof(bodyfetchtargetUrl), required: false);
            WorkflowExpression.Validate(bodyfetchserverlessFunction, nameof(bodyfetchserverlessFunction), required: false);
            WorkflowExpression.Validate(bodydisplayproperties, nameof(bodydisplayproperties), required: false);
            WorkflowExpression.Validate(bodyactionsbaseUrls, nameof(bodyactionsbaseUrls), required: false);
            return new DeferredBodyAction<UpdateACardResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/extensions/cards-dev/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(appId, 1), ExpressionConverter.ConvertWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                var fetchObject = new JObject();
                var fetchObjectpropCount = 0;
                if (bodyfetchobjectTypes != null)
                {
                    fetchObject["objectTypes"] = ExpressionConverter.ConvertO(bodyfetchobjectTypes);
                    fetchObjectpropCount++;
                }

                if (bodyfetchcardType != null)
                {
                    fetchObject["cardType"] = ExpressionConverter.ConvertO(bodyfetchcardType);
                    fetchObjectpropCount++;
                }

                if (bodyfetchtargetUrl != null)
                {
                    fetchObject["targetUrl"] = ExpressionConverter.ConvertO(bodyfetchtargetUrl);
                    fetchObjectpropCount++;
                }

                if (bodyfetchserverlessFunction != null)
                {
                    fetchObject["serverlessFunction"] = ExpressionConverter.ConvertO(bodyfetchserverlessFunction);
                    fetchObjectpropCount++;
                }

                if (fetchObjectpropCount > 0)
                {
                    body["fetch"] = fetchObject;
                    bodypropCount++;
                }

                var displayObject = new JObject();
                var displayObjectpropCount = 0;
                if (bodydisplayproperties != null)
                {
                    displayObject["properties"] = ExpressionConverter.ConvertO(bodydisplayproperties);
                    displayObjectpropCount++;
                }

                if (displayObjectpropCount > 0)
                {
                    body["display"] = displayObject;
                    bodypropCount++;
                }

                var actionsObject = new JObject();
                var actionsObjectpropCount = 0;
                if (bodyactionsbaseUrls != null)
                {
                    actionsObject["baseUrls"] = ExpressionConverter.ConvertO(bodyactionsbaseUrls);
                    actionsObjectpropCount++;
                }

                if (actionsObjectpropCount > 0)
                {
                    body["actions"] = actionsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateACardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<GetSampleCardDetailResponseResponse> GetSampleCardDetailResponse()
        {
            var apiCallPath = "/crm/v3/extensions/cards-dev/sample-response";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetSampleCardDetailResponseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetCrmV3ExportsExportAsyncTasksTaskIdStatus))]
        public IBodyWorkflowAction<GetCrmV3ExportsExportAsyncTasksTaskIdStatusResponse> GetCrmV3ExportsExportAsyncTasksTaskIdStatus([WorkflowExpression] Func<string> taskId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCrmV3ExportsExportAsyncTasksTaskIdStatusResponse> __BuildGetCrmV3ExportsExportAsyncTasksTaskIdStatus(WorkflowExpression<string> taskId)
        {
            WorkflowExpression.Validate(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<GetCrmV3ExportsExportAsyncTasksTaskIdStatusResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/exports/export/async/tasks/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCrmV3ExportsExportAsyncTasksTaskIdStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildStartAnExport))]
        public IBodyWorkflowAction<StartAnExportResponse> StartAnExport([WorkflowExpression] Func<string> bodyexportName = null, [WorkflowExpression] Func<string> bodyexportType = null, [WorkflowExpression] Func<string> bodyformat = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string[]> bodyobjectProperties = null, [WorkflowExpression] Func<string> bodyobjectType = null, [WorkflowExpression] Func<string> bodyassociatedObjectType = null, [WorkflowExpression] Func<bodypublicCrmSearchRequestfiltersInputItem[]> bodypublicCrmSearchRequestfilters = null, [WorkflowExpression] Func<string> bodypublicCrmSearchRequestquery = null, [WorkflowExpression] Func<string[]> bodypublicCrmSearchRequestsorts = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StartAnExportResponse> __BuildStartAnExport(WorkflowExpression<string> bodyexportName = null, WorkflowExpression<string> bodyexportType = null, WorkflowExpression<string> bodyformat = null, WorkflowExpression<string> bodylanguage = null, WorkflowExpression<string[]> bodyobjectProperties = null, WorkflowExpression<string> bodyobjectType = null, WorkflowExpression<string> bodyassociatedObjectType = null, WorkflowExpression<bodypublicCrmSearchRequestfiltersInputItem[]> bodypublicCrmSearchRequestfilters = null, WorkflowExpression<string> bodypublicCrmSearchRequestquery = null, WorkflowExpression<string[]> bodypublicCrmSearchRequestsorts = null)
        {
            WorkflowExpression.Validate(bodyexportName, nameof(bodyexportName), required: false);
            WorkflowExpression.Validate(bodyexportType, nameof(bodyexportType), required: false);
            WorkflowExpression.Validate(bodyformat, nameof(bodyformat), required: false);
            WorkflowExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            WorkflowExpression.Validate(bodyobjectProperties, nameof(bodyobjectProperties), required: false);
            WorkflowExpression.Validate(bodyobjectType, nameof(bodyobjectType), required: false);
            WorkflowExpression.Validate(bodyassociatedObjectType, nameof(bodyassociatedObjectType), required: false);
            WorkflowExpression.Validate(bodypublicCrmSearchRequestfilters, nameof(bodypublicCrmSearchRequestfilters), required: false);
            WorkflowExpression.Validate(bodypublicCrmSearchRequestquery, nameof(bodypublicCrmSearchRequestquery), required: false);
            WorkflowExpression.Validate(bodypublicCrmSearchRequestsorts, nameof(bodypublicCrmSearchRequestsorts), required: false);
            return new DeferredBodyAction<StartAnExportResponse>(() =>
            {
                var apiCallPath = "/crm/v3/exports/export/async";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyexportName != null)
                {
                    body["exportName"] = ExpressionConverter.ConvertO(bodyexportName);
                    bodypropCount++;
                }

                if (bodyexportType != null)
                {
                    body["exportType"] = ExpressionConverter.ConvertO(bodyexportType);
                    bodypropCount++;
                }

                if (bodyformat != null)
                {
                    body["format"] = ExpressionConverter.ConvertO(bodyformat);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                    bodypropCount++;
                }

                if (bodyobjectProperties != null)
                {
                    body["objectProperties"] = ExpressionConverter.ConvertO(bodyobjectProperties);
                    bodypropCount++;
                }

                if (bodyobjectType != null)
                {
                    body["objectType"] = ExpressionConverter.ConvertO(bodyobjectType);
                    bodypropCount++;
                }

                if (bodyassociatedObjectType != null)
                {
                    body["associatedObjectType"] = ExpressionConverter.ConvertO(bodyassociatedObjectType);
                    bodypropCount++;
                }

                var publicCrmSearchRequestObject = new JObject();
                var publicCrmSearchRequestObjectpropCount = 0;
                if (bodypublicCrmSearchRequestfilters != null)
                {
                    publicCrmSearchRequestObject["filters"] = ExpressionConverter.ConvertO(bodypublicCrmSearchRequestfilters);
                    publicCrmSearchRequestObjectpropCount++;
                }

                if (bodypublicCrmSearchRequestquery != null)
                {
                    publicCrmSearchRequestObject["query"] = ExpressionConverter.ConvertO(bodypublicCrmSearchRequestquery);
                    publicCrmSearchRequestObjectpropCount++;
                }

                if (bodypublicCrmSearchRequestsorts != null)
                {
                    publicCrmSearchRequestObject["sorts"] = ExpressionConverter.ConvertO(bodypublicCrmSearchRequestsorts);
                    publicCrmSearchRequestObjectpropCount++;
                }

                if (publicCrmSearchRequestObjectpropCount > 0)
                {
                    body["publicCrmSearchRequest"] = publicCrmSearchRequestObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StartAnExportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetTheInformationOnAnyImport))]
        public IBodyWorkflowAction<GetTheInformationOnAnyImportResponse> GetTheInformationOnAnyImport([WorkflowExpression] Func<string> importId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTheInformationOnAnyImportResponse> __BuildGetTheInformationOnAnyImport(WorkflowExpression<string> importId)
        {
            WorkflowExpression.Validate(importId, nameof(importId), required: true);
            return new DeferredBodyAction<GetTheInformationOnAnyImportResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/imports/{0}", ExpressionConverter.ConvertWithUrlEncoding(importId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTheInformationOnAnyImportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildCancelAnActiveImport))]
        public IBodyWorkflowAction<CancelAnActiveImportResponse> CancelAnActiveImport([WorkflowExpression] Func<string> importId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CancelAnActiveImportResponse> __BuildCancelAnActiveImport(WorkflowExpression<string> importId)
        {
            WorkflowExpression.Validate(importId, nameof(importId), required: true);
            return new DeferredBodyAction<CancelAnActiveImportResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/imports/{0}/cancel", ExpressionConverter.ConvertWithUrlEncoding(importId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CancelAnActiveImportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetActiveImports))]
        public IBodyWorkflowAction<GetActiveImportsResponse> GetActiveImports([WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> before = null, [WorkflowExpression] Func<string> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetActiveImportsResponse> __BuildGetActiveImports(WorkflowExpression<string> after = null, WorkflowExpression<string> before = null, WorkflowExpression<string> limit = null)
        {
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(before, nameof(before), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<GetActiveImportsResponse>(() =>
            {
                var apiCallPath = "/crm/v3/imports/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(before);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<GetActiveImportsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildStartANewImport))]
        public IBodyWorkflowAction<StartANewImportResponse> StartANewImport([WorkflowExpression] Func<string> contentType)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StartANewImportResponse> __BuildStartANewImport(WorkflowExpression<string> contentType)
        {
            WorkflowExpression.Validate(contentType, nameof(contentType), required: true);
            return new DeferredBodyAction<StartANewImportResponse>(() =>
            {
                var apiCallPath = "/crm/v3/imports/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                return new ApiConnectionAction<StartANewImportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildGetCrmV3ImportsImportIdErrorsGetErrors))]
        public IBodyWorkflowAction<GetCrmV3ImportsImportIdErrorsGetErrorsResponse> GetCrmV3ImportsImportIdErrorsGetErrors([WorkflowExpression] Func<string> importId, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCrmV3ImportsImportIdErrorsGetErrorsResponse> __BuildGetCrmV3ImportsImportIdErrorsGetErrors(WorkflowExpression<string> importId, WorkflowExpression<string> after = null, WorkflowExpression<string> limit = null)
        {
            WorkflowExpression.Validate(importId, nameof(importId), required: true);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<GetCrmV3ImportsImportIdErrorsGetErrorsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/imports/{0}/errors", ExpressionConverter.ConvertWithUrlEncoding(importId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<GetCrmV3ImportsImportIdErrorsGetErrorsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildAddAndOrRemoveRecordsFromAList))]
        public IBodyWorkflowAction<AddAndOrRemoveRecordsFromAListResponse> AddAndOrRemoveRecordsFromAList([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string[]> bodyrecordIdsToAdd = null, [WorkflowExpression] Func<string[]> bodyrecordIdsToRemove = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddAndOrRemoveRecordsFromAListResponse> __BuildAddAndOrRemoveRecordsFromAList(WorkflowExpression<string> listId, WorkflowExpression<string[]> bodyrecordIdsToAdd = null, WorkflowExpression<string[]> bodyrecordIdsToRemove = null)
        {
            WorkflowExpression.Validate(listId, nameof(listId), required: true);
            WorkflowExpression.Validate(bodyrecordIdsToAdd, nameof(bodyrecordIdsToAdd), required: false);
            WorkflowExpression.Validate(bodyrecordIdsToRemove, nameof(bodyrecordIdsToRemove), required: false);
            return new DeferredBodyAction<AddAndOrRemoveRecordsFromAListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/lists/{0}/memberships/add-and-remove", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrecordIdsToAdd != null)
                {
                    body["recordIdsToAdd"] = ExpressionConverter.ConvertO(bodyrecordIdsToAdd);
                    bodypropCount++;
                }

                if (bodyrecordIdsToRemove != null)
                {
                    body["recordIdsToRemove"] = ExpressionConverter.ConvertO(bodyrecordIdsToRemove);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddAndOrRemoveRecordsFromAListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildAddRecordsToAList))]
        public IBodyWorkflowAction<AddRecordsToAListResponse> AddRecordsToAList([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string[]> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddRecordsToAListResponse> __BuildAddRecordsToAList(WorkflowExpression<string> listId, WorkflowExpression<string[]> body = null)
        {
            WorkflowExpression.Validate(listId, nameof(listId), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<AddRecordsToAListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/lists/{0}/memberships/add", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<AddRecordsToAListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildAddAllRecordsFromASourceListToADestinationList))]
        public IBodyWorkflowAction<string> AddAllRecordsFromASourceListToADestinationList([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> sourceListId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAddAllRecordsFromASourceListToADestinationList(WorkflowExpression<string> listId, WorkflowExpression<string> sourceListId)
        {
            WorkflowExpression.Validate(listId, nameof(listId), required: true);
            WorkflowExpression.Validate(sourceListId, nameof(sourceListId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/lists/{0}/memberships/add-from/{1}", ExpressionConverter.ConvertWithUrlEncoding(listId, 1), ExpressionConverter.ConvertWithUrlEncoding(sourceListId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildFetchListMembershipsOrderedById))]
        public IBodyWorkflowAction<FetchListMembershipsOrderedByIdResponse> FetchListMembershipsOrderedById([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> before = null, [WorkflowExpression] Func<string> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FetchListMembershipsOrderedByIdResponse> __BuildFetchListMembershipsOrderedById(WorkflowExpression<string> listId, WorkflowExpression<string> after = null, WorkflowExpression<string> before = null, WorkflowExpression<string> limit = null)
        {
            WorkflowExpression.Validate(listId, nameof(listId), required: true);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(before, nameof(before), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<FetchListMembershipsOrderedByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/lists/{0}/memberships", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(before);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<FetchListMembershipsOrderedByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteAllRecordsFromAList))]
        public IBodyWorkflowAction<string> DeleteAllRecordsFromAList([WorkflowExpression] Func<string> listId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDeleteAllRecordsFromAList(WorkflowExpression<string> listId)
        {
            WorkflowExpression.Validate(listId, nameof(listId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/lists/{0}/memberships", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveRecordsFromAList))]
        public IBodyWorkflowAction<RemoveRecordsFromAListResponse> RemoveRecordsFromAList([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string[]> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RemoveRecordsFromAListResponse> __BuildRemoveRecordsFromAList(WorkflowExpression<string> listId, WorkflowExpression<string[]> body = null)
        {
            WorkflowExpression.Validate(listId, nameof(listId), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<RemoveRecordsFromAListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/lists/{0}/memberships/remove", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<RemoveRecordsFromAListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [WorkflowExpressionFactory(nameof(__BuildSearchLists))]
        public IBodyWorkflowAction<SearchListsResponse> SearchLists([WorkflowExpression] Func<string[]> bodyadditionalProperties = null, [WorkflowExpression] Func<string> bodyoffset = null, [WorkflowExpression] Func<string> bodyquery = null, [WorkflowExpression] Func<string> bodycount = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchListsResponse> __BuildSearchLists(WorkflowExpression<string[]> bodyadditionalProperties = null, WorkflowExpression<string> bodyoffset = null, WorkflowExpression<string> bodyquery = null, WorkflowExpression<string> bodycount = null)
        {
            WorkflowExpression.Validate(bodyadditionalProperties, nameof(bodyadditionalProperties), required: false);
            WorkflowExpression.Validate(bodyoffset, nameof(bodyoffset), required: false);
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            WorkflowExpression.Validate(bodycount, nameof(bodycount), required: false);
            return new DeferredBodyAction<SearchListsResponse>(() =>
            {
                var apiCallPath = "/crm/v3/lists/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyadditionalProperties != null)
                {
                    body["additionalProperties"] = ExpressionConverter.ConvertO(bodyadditionalProperties);
                    bodypropCount++;
                }

                if (bodyoffset != null)
                {
                    body["offset"] = ExpressionConverter.ConvertO(bodyoffset);
                    bodypropCount++;
                }

                if (bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(bodyquery);
                    bodypropCount++;
                }

                if (bodycount != null)
                {
                    body["count"] = ExpressionConverter.ConvertO(bodycount);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SearchListsResponse>(callPayload);
            });
        }
    }

    public class Hubspotcrmv2Triggers([ConnectionName] string connectionId)
    {
    }

    public class bodyinputsInputItem
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

    public class bodyassociationsInputItem
    {
        [JsonProperty("to")]
        public bodyassociationsInputItemToType To { get; set; }

        [JsonProperty("types")]
        public bodyassociationsInputItemTypesTypeItem[] Types { get; set; }
    }

    public class bodyassociationsInputItemToType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class bodyassociationsInputItemTypesTypeItem
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

    public class bodyfilterGroupsInputItem
    {
        [JsonProperty("filters")]
        public bodyfilterGroupsInputItemFiltersTypeItem[] Filters { get; set; }
    }

    public class bodyfilterGroupsInputItemFiltersTypeItem
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

    public class bodyinputsInputItem2
    {
        [JsonProperty("from")]
        public bodyinputsInputItemFromType From { get; set; }

        [JsonProperty("to")]
        public bodyinputsInputItemToType To { get; set; }

        [JsonProperty("types")]
        public bodyinputsInputItemTypesTypeItem[] Types { get; set; }
    }

    public class bodyinputsInputItemFromType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class bodyinputsInputItemToType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class bodyinputsInputItemTypesTypeItem
    {
        [JsonProperty("associationCategory")]
        public string AssociationCategory { get; set; }

        [JsonProperty("associationTypeId")]
        public string AssociationTypeId { get; set; }
    }

    public class bodyinputsInputItem22
    {
        [JsonProperty("from")]
        public bodyinputsInputItemFromType From { get; set; }

        [JsonProperty("to")]
        public bodyinputsInputItemToTypeItem[] To { get; set; }
    }

    public class bodyinputsInputItemToTypeItem
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

    public class bodyinputsInputItem222
    {
        [JsonProperty("from")]
        public bodyinputsInputItemFromType From { get; set; }

        [JsonProperty("to")]
        public bodyinputsInputItemToType To { get; set; }
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

    public class bodydisplaypropertiesInputItem
    {
        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("options")]
        public bodydisplaypropertiesInputItemOptionsTypeItem[] Options { get; set; }
    }

    public class bodydisplaypropertiesInputItemOptionsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class bodyfetchobjectTypesInputItem
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

    public class bodypublicCrmSearchRequestfiltersInputItem
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