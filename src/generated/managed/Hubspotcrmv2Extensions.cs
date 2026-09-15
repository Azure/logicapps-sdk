//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotcrmv2
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Hubspotcrmv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> ArchiveABatchOfCompaniesById(Expression<Func<bodyinputsInputItem[]>> bodyinputs = null)
        {
            var apiCallPath = "/crm/v3/objects/companies/batch/archive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputs != null)
            {
                body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<ListResponse> List(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/crm/v3/objects/companies";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction<ListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<CreateResponse> Create(Expression<Func<bodyassociationsInputItem[]>> bodyassociations = null)
        {
            var apiCallPath = "/crm/v3/objects/companies";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassociations != null)
            {
                body["associations"] = CSharpExpressionConverter.ConvertToken(bodyassociations);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<ReadResponse> Read(Expression<Func<string>> companyId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/companies/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(companyId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
            return new ApiConnectionAction<ReadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> Archive(Expression<Func<string>> companyId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/companies/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(companyId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<UpdateResponse> Update(Expression<Func<string>> companyId, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/companies/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(companyId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoCompaniesWithSameTypeResponse> MergeTwoCompaniesWithSameType(Expression<Func<string>> bodyobjectIdToMerge = null, Expression<Func<string>> bodyprimaryObjectId = null)
        {
            var apiCallPath = "/crm/v3/objects/companies/merge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectIdToMerge != null)
            {
                body["objectIdToMerge"] = CSharpExpressionConverter.ConvertToken(bodyobjectIdToMerge);
                bodypropCount++;
            }

            if (bodyprimaryObjectId != null)
            {
                body["primaryObjectId"] = CSharpExpressionConverter.ConvertToken(bodyprimaryObjectId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MergeTwoCompaniesWithSameTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> GdprDelete(Expression<Func<string>> bodyobjectId = null, Expression<Func<string>> bodyidProperty = null)
        {
            var apiCallPath = "/crm/v3/objects/companies/gdpr-delete";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectId != null)
            {
                body["objectId"] = CSharpExpressionConverter.ConvertToken(bodyobjectId);
                bodypropCount++;
            }

            if (bodyidProperty != null)
            {
                body["idProperty"] = CSharpExpressionConverter.ConvertToken(bodyidProperty);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsCompaniesSearchResponse> PostCrmV3ObjectsCompaniesSearch(Expression<Func<string>> bodyafter = null, Expression<Func<bodyfilterGroupsInputItem[]>> bodyfilterGroups = null, Expression<Func<string>> bodylimit = null, Expression<Func<string[]>> bodyproperties = null, Expression<Func<string[]>> bodysorts = null, Expression<Func<string>> bodyquery = null)
        {
            var apiCallPath = "/crm/v3/objects/companies/search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyafter != null)
            {
                body["after"] = CSharpExpressionConverter.ConvertToken(bodyafter);
                bodypropCount++;
            }

            if (bodyfilterGroups != null)
            {
                body["filterGroups"] = CSharpExpressionConverter.ConvertToken(bodyfilterGroups);
                bodypropCount++;
            }

            if (bodylimit != null)
            {
                body["limit"] = CSharpExpressionConverter.ConvertToken(bodylimit);
                bodypropCount++;
            }

            if (bodyproperties != null)
            {
                body["properties"] = CSharpExpressionConverter.ConvertToken(bodyproperties);
                bodypropCount++;
            }

            if (bodysorts != null)
            {
                body["sorts"] = CSharpExpressionConverter.ConvertToken(bodysorts);
                bodypropCount++;
            }

            if (bodyquery != null)
            {
                body["query"] = CSharpExpressionConverter.ConvertToken(bodyquery);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostCrmV3ObjectsCompaniesSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> ArchiveABatchOfContactsById(Expression<Func<bodyinputsInputItem[]>> bodyinputs = null)
        {
            var apiCallPath = "/crm/v3/objects/contacts/batch/archive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputs != null)
            {
                body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List16Response> List16(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/crm/v3/objects/contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction<List16Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create17Response> Create17(Expression<Func<bodyassociationsInputItem[]>> bodyassociations = null)
        {
            var apiCallPath = "/crm/v3/objects/contacts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassociations != null)
            {
                body["associations"] = CSharpExpressionConverter.ConvertToken(bodyassociations);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read18Response> Read18(Expression<Func<string>> contactId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/contacts/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction<Read18Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> Archive19(Expression<Func<string>> contactId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/contacts/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update20Response> Update20(Expression<Func<string>> contactId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/contacts/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoContactsWithSameTypeResponse> MergeTwoContactsWithSameType(Expression<Func<string>> bodyobjectIdToMerge = null, Expression<Func<string>> bodyprimaryObjectId = null)
        {
            var apiCallPath = "/crm/v3/objects/contacts/merge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectIdToMerge != null)
            {
                body["objectIdToMerge"] = CSharpExpressionConverter.ConvertToken(bodyobjectIdToMerge);
                bodypropCount++;
            }

            if (bodyprimaryObjectId != null)
            {
                body["primaryObjectId"] = CSharpExpressionConverter.ConvertToken(bodyprimaryObjectId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MergeTwoContactsWithSameTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> GdprDelete22(Expression<Func<string>> bodyobjectId = null, Expression<Func<string>> bodyidProperty = null)
        {
            var apiCallPath = "/crm/v3/objects/contacts/gdpr-delete";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectId != null)
            {
                body["objectId"] = CSharpExpressionConverter.ConvertToken(bodyobjectId);
                bodypropCount++;
            }

            if (bodyidProperty != null)
            {
                body["idProperty"] = CSharpExpressionConverter.ConvertToken(bodyidProperty);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsContactsSearchResponse> PostCrmV3ObjectsContactsSearch(Expression<Func<string>> bodyafter = null, Expression<Func<bodyfilterGroupsInputItem[]>> bodyfilterGroups = null, Expression<Func<string>> bodylimit = null, Expression<Func<string[]>> bodyproperties = null, Expression<Func<string[]>> bodysorts = null, Expression<Func<string>> bodyquery = null)
        {
            var apiCallPath = "/crm/v3/objects/contacts/search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyafter != null)
            {
                body["after"] = CSharpExpressionConverter.ConvertToken(bodyafter);
                bodypropCount++;
            }

            if (bodyfilterGroups != null)
            {
                body["filterGroups"] = CSharpExpressionConverter.ConvertToken(bodyfilterGroups);
                bodypropCount++;
            }

            if (bodylimit != null)
            {
                body["limit"] = CSharpExpressionConverter.ConvertToken(bodylimit);
                bodypropCount++;
            }

            if (bodyproperties != null)
            {
                body["properties"] = CSharpExpressionConverter.ConvertToken(bodyproperties);
                bodypropCount++;
            }

            if (bodysorts != null)
            {
                body["sorts"] = CSharpExpressionConverter.ConvertToken(bodysorts);
                bodypropCount++;
            }

            if (bodyquery != null)
            {
                body["query"] = CSharpExpressionConverter.ConvertToken(bodyquery);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostCrmV3ObjectsContactsSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> ArchiveABatchOfDealsById(Expression<Func<bodyinputsInputItem[]>> bodyinputs = null)
        {
            var apiCallPath = "/crm/v3/objects/deals/batch/archive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputs != null)
            {
                body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List28Response> List28(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/crm/v3/objects/deals";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction<List28Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create29Response> Create29(Expression<Func<bodyassociationsInputItem[]>> bodyassociations = null)
        {
            var apiCallPath = "/crm/v3/objects/deals";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassociations != null)
            {
                body["associations"] = CSharpExpressionConverter.ConvertToken(bodyassociations);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read30Response> Read30(Expression<Func<string>> dealId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/deals/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dealId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
            return new ApiConnectionAction<Read30Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> Archive31(Expression<Func<string>> dealId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/deals/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dealId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update32Response> Update32(Expression<Func<string>> dealId, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/deals/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dealId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoDealsWithSameTypeResponse> MergeTwoDealsWithSameType(Expression<Func<string>> bodyobjectIdToMerge = null, Expression<Func<string>> bodyprimaryObjectId = null)
        {
            var apiCallPath = "/crm/v3/objects/deals/merge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectIdToMerge != null)
            {
                body["objectIdToMerge"] = CSharpExpressionConverter.ConvertToken(bodyobjectIdToMerge);
                bodypropCount++;
            }

            if (bodyprimaryObjectId != null)
            {
                body["primaryObjectId"] = CSharpExpressionConverter.ConvertToken(bodyprimaryObjectId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MergeTwoDealsWithSameTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> GdprDelete34(Expression<Func<string>> bodyobjectId = null, Expression<Func<string>> bodyidProperty = null)
        {
            var apiCallPath = "/crm/v3/objects/deals/gdpr-delete";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectId != null)
            {
                body["objectId"] = CSharpExpressionConverter.ConvertToken(bodyobjectId);
                bodypropCount++;
            }

            if (bodyidProperty != null)
            {
                body["idProperty"] = CSharpExpressionConverter.ConvertToken(bodyidProperty);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsDealsSearchResponse> PostCrmV3ObjectsDealsSearch(Expression<Func<string>> bodyafter = null, Expression<Func<bodyfilterGroupsInputItem[]>> bodyfilterGroups = null, Expression<Func<string>> bodylimit = null, Expression<Func<string[]>> bodyproperties = null, Expression<Func<string[]>> bodysorts = null, Expression<Func<string>> bodyquery = null)
        {
            var apiCallPath = "/crm/v3/objects/deals/search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyafter != null)
            {
                body["after"] = CSharpExpressionConverter.ConvertToken(bodyafter);
                bodypropCount++;
            }

            if (bodyfilterGroups != null)
            {
                body["filterGroups"] = CSharpExpressionConverter.ConvertToken(bodyfilterGroups);
                bodypropCount++;
            }

            if (bodylimit != null)
            {
                body["limit"] = CSharpExpressionConverter.ConvertToken(bodylimit);
                bodypropCount++;
            }

            if (bodyproperties != null)
            {
                body["properties"] = CSharpExpressionConverter.ConvertToken(bodyproperties);
                bodypropCount++;
            }

            if (bodysorts != null)
            {
                body["sorts"] = CSharpExpressionConverter.ConvertToken(bodysorts);
                bodypropCount++;
            }

            if (bodyquery != null)
            {
                body["query"] = CSharpExpressionConverter.ConvertToken(bodyquery);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostCrmV3ObjectsDealsSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> ArchiveABatchOfFeesById(Expression<Func<bodyinputsInputItem[]>> bodyinputs = null)
        {
            var apiCallPath = "/crm/v3/objects/fees/batch/archive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputs != null)
            {
                body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read40Response> Read40(Expression<Func<string>> feeId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/fees/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(feeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
            return new ApiConnectionAction<Read40Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> Archive41(Expression<Func<string>> feeId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/fees/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(feeId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update42Response> Update42(Expression<Func<string>> feeId, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/fees/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(feeId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List43Response> List43(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/crm/v3/objects/fees";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction<List43Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create44Response> Create44(Expression<Func<bodyassociationsInputItem[]>> bodyassociations = null)
        {
            var apiCallPath = "/crm/v3/objects/fees";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassociations != null)
            {
                body["associations"] = CSharpExpressionConverter.ConvertToken(bodyassociations);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoFeesWithSameTypeResponse> MergeTwoFeesWithSameType(Expression<Func<string>> bodyobjectIdToMerge = null, Expression<Func<string>> bodyprimaryObjectId = null)
        {
            var apiCallPath = "/crm/v3/objects/fees/merge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectIdToMerge != null)
            {
                body["objectIdToMerge"] = CSharpExpressionConverter.ConvertToken(bodyobjectIdToMerge);
                bodypropCount++;
            }

            if (bodyprimaryObjectId != null)
            {
                body["primaryObjectId"] = CSharpExpressionConverter.ConvertToken(bodyprimaryObjectId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MergeTwoFeesWithSameTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> GdprDelete46(Expression<Func<string>> bodyobjectId = null, Expression<Func<string>> bodyidProperty = null)
        {
            var apiCallPath = "/crm/v3/objects/fees/gdpr-delete";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectId != null)
            {
                body["objectId"] = CSharpExpressionConverter.ConvertToken(bodyobjectId);
                bodypropCount++;
            }

            if (bodyidProperty != null)
            {
                body["idProperty"] = CSharpExpressionConverter.ConvertToken(bodyidProperty);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsFeesSearchResponse> PostCrmV3ObjectsFeesSearch(Expression<Func<string>> bodyafter = null, Expression<Func<bodyfilterGroupsInputItem[]>> bodyfilterGroups = null, Expression<Func<string>> bodylimit = null, Expression<Func<string[]>> bodyproperties = null, Expression<Func<string[]>> bodysorts = null, Expression<Func<string>> bodyquery = null)
        {
            var apiCallPath = "/crm/v3/objects/fees/search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyafter != null)
            {
                body["after"] = CSharpExpressionConverter.ConvertToken(bodyafter);
                bodypropCount++;
            }

            if (bodyfilterGroups != null)
            {
                body["filterGroups"] = CSharpExpressionConverter.ConvertToken(bodyfilterGroups);
                bodypropCount++;
            }

            if (bodylimit != null)
            {
                body["limit"] = CSharpExpressionConverter.ConvertToken(bodylimit);
                bodypropCount++;
            }

            if (bodyproperties != null)
            {
                body["properties"] = CSharpExpressionConverter.ConvertToken(bodyproperties);
                bodypropCount++;
            }

            if (bodysorts != null)
            {
                body["sorts"] = CSharpExpressionConverter.ConvertToken(bodysorts);
                bodypropCount++;
            }

            if (bodyquery != null)
            {
                body["query"] = CSharpExpressionConverter.ConvertToken(bodyquery);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostCrmV3ObjectsFeesSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> ArchiveABatchOfGoalTargetsById(Expression<Func<bodyinputsInputItem[]>> bodyinputs = null)
        {
            var apiCallPath = "/crm/v3/objects/goal_targets/batch/archive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputs != null)
            {
                body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read52Response> Read52(Expression<Func<string>> goalTargetId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/goal_targets/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalTargetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
            return new ApiConnectionAction<Read52Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> Archive53(Expression<Func<string>> goalTargetId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/goal_targets/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalTargetId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update54Response> Update54(Expression<Func<string>> goalTargetId, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/goal_targets/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(goalTargetId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List55Response> List55(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/crm/v3/objects/goal_targets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction<List55Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create56Response> Create56(Expression<Func<bodyassociationsInputItem[]>> bodyassociations = null)
        {
            var apiCallPath = "/crm/v3/objects/goal_targets";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassociations != null)
            {
                body["associations"] = CSharpExpressionConverter.ConvertToken(bodyassociations);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoGoalTargetsWithSameTypeResponse> MergeTwoGoalTargetsWithSameType(Expression<Func<string>> bodyobjectIdToMerge = null, Expression<Func<string>> bodyprimaryObjectId = null)
        {
            var apiCallPath = "/crm/v3/objects/goal_targets/merge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectIdToMerge != null)
            {
                body["objectIdToMerge"] = CSharpExpressionConverter.ConvertToken(bodyobjectIdToMerge);
                bodypropCount++;
            }

            if (bodyprimaryObjectId != null)
            {
                body["primaryObjectId"] = CSharpExpressionConverter.ConvertToken(bodyprimaryObjectId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MergeTwoGoalTargetsWithSameTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> GdprDelete58(Expression<Func<string>> bodyobjectId = null, Expression<Func<string>> bodyidProperty = null)
        {
            var apiCallPath = "/crm/v3/objects/goal_targets/gdpr-delete";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectId != null)
            {
                body["objectId"] = CSharpExpressionConverter.ConvertToken(bodyobjectId);
                bodypropCount++;
            }

            if (bodyidProperty != null)
            {
                body["idProperty"] = CSharpExpressionConverter.ConvertToken(bodyidProperty);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsGoalTargetsSearchResponse> PostCrmV3ObjectsGoalTargetsSearch(Expression<Func<string>> bodyafter = null, Expression<Func<bodyfilterGroupsInputItem[]>> bodyfilterGroups = null, Expression<Func<string>> bodylimit = null, Expression<Func<string[]>> bodyproperties = null, Expression<Func<string[]>> bodysorts = null, Expression<Func<string>> bodyquery = null)
        {
            var apiCallPath = "/crm/v3/objects/goal_targets/search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyafter != null)
            {
                body["after"] = CSharpExpressionConverter.ConvertToken(bodyafter);
                bodypropCount++;
            }

            if (bodyfilterGroups != null)
            {
                body["filterGroups"] = CSharpExpressionConverter.ConvertToken(bodyfilterGroups);
                bodypropCount++;
            }

            if (bodylimit != null)
            {
                body["limit"] = CSharpExpressionConverter.ConvertToken(bodylimit);
                bodypropCount++;
            }

            if (bodyproperties != null)
            {
                body["properties"] = CSharpExpressionConverter.ConvertToken(bodyproperties);
                bodypropCount++;
            }

            if (bodysorts != null)
            {
                body["sorts"] = CSharpExpressionConverter.ConvertToken(bodysorts);
                bodypropCount++;
            }

            if (bodyquery != null)
            {
                body["query"] = CSharpExpressionConverter.ConvertToken(bodyquery);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostCrmV3ObjectsGoalTargetsSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> ArchiveABatchOfLineItemsById(Expression<Func<bodyinputsInputItem[]>> bodyinputs = null)
        {
            var apiCallPath = "/crm/v3/objects/line_items/batch/archive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputs != null)
            {
                body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List64Response> List64(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/crm/v3/objects/line_items";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction<List64Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create65Response> Create65(Expression<Func<bodyassociationsInputItem[]>> bodyassociations = null)
        {
            var apiCallPath = "/crm/v3/objects/line_items";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassociations != null)
            {
                body["associations"] = CSharpExpressionConverter.ConvertToken(bodyassociations);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read66Response> Read66(Expression<Func<string>> lineItemId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/line_items/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(lineItemId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
            return new ApiConnectionAction<Read66Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> Archive67(Expression<Func<string>> lineItemId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/line_items/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(lineItemId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update68Response> Update68(Expression<Func<string>> lineItemId, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/line_items/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(lineItemId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoLineItemsWithSameTypeResponse> MergeTwoLineItemsWithSameType(Expression<Func<string>> bodyobjectIdToMerge = null, Expression<Func<string>> bodyprimaryObjectId = null)
        {
            var apiCallPath = "/crm/v3/objects/line_items/merge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectIdToMerge != null)
            {
                body["objectIdToMerge"] = CSharpExpressionConverter.ConvertToken(bodyobjectIdToMerge);
                bodypropCount++;
            }

            if (bodyprimaryObjectId != null)
            {
                body["primaryObjectId"] = CSharpExpressionConverter.ConvertToken(bodyprimaryObjectId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MergeTwoLineItemsWithSameTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> GdprDelete70(Expression<Func<string>> bodyobjectId = null, Expression<Func<string>> bodyidProperty = null)
        {
            var apiCallPath = "/crm/v3/objects/line_items/gdpr-delete";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectId != null)
            {
                body["objectId"] = CSharpExpressionConverter.ConvertToken(bodyobjectId);
                bodypropCount++;
            }

            if (bodyidProperty != null)
            {
                body["idProperty"] = CSharpExpressionConverter.ConvertToken(bodyidProperty);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsLineItemsSearchResponse> PostCrmV3ObjectsLineItemsSearch(Expression<Func<string>> bodyafter = null, Expression<Func<bodyfilterGroupsInputItem[]>> bodyfilterGroups = null, Expression<Func<string>> bodylimit = null, Expression<Func<string[]>> bodyproperties = null, Expression<Func<string[]>> bodysorts = null, Expression<Func<string>> bodyquery = null)
        {
            var apiCallPath = "/crm/v3/objects/line_items/search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyafter != null)
            {
                body["after"] = CSharpExpressionConverter.ConvertToken(bodyafter);
                bodypropCount++;
            }

            if (bodyfilterGroups != null)
            {
                body["filterGroups"] = CSharpExpressionConverter.ConvertToken(bodyfilterGroups);
                bodypropCount++;
            }

            if (bodylimit != null)
            {
                body["limit"] = CSharpExpressionConverter.ConvertToken(bodylimit);
                bodypropCount++;
            }

            if (bodyproperties != null)
            {
                body["properties"] = CSharpExpressionConverter.ConvertToken(bodyproperties);
                bodypropCount++;
            }

            if (bodysorts != null)
            {
                body["sorts"] = CSharpExpressionConverter.ConvertToken(bodysorts);
                bodypropCount++;
            }

            if (bodyquery != null)
            {
                body["query"] = CSharpExpressionConverter.ConvertToken(bodyquery);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostCrmV3ObjectsLineItemsSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<GetAPageOfOwnersResponse> GetAPageOfOwners(Expression<Func<string>> email, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/crm/v3/owners/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["email"] = CSharpExpressionConverter.ConvertO(email);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction<GetAPageOfOwnersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<ReadAnOwnerByGivenidOruseridResponse> ReadAnOwnerByGivenidOruserid(Expression<Func<string>> ownerId, Expression<Func<string>> idProperty = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/owners/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(ownerId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction<ReadAnOwnerByGivenidOruseridResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> ArchiveABatchOfProductsById(Expression<Func<bodyinputsInputItem[]>> bodyinputs = null)
        {
            var apiCallPath = "/crm/v3/objects/products/batch/archive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputs != null)
            {
                body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List78Response> List78(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/crm/v3/objects/products";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction<List78Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create79Response> Create79(Expression<Func<bodyassociationsInputItem[]>> bodyassociations = null)
        {
            var apiCallPath = "/crm/v3/objects/products";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassociations != null)
            {
                body["associations"] = CSharpExpressionConverter.ConvertToken(bodyassociations);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read80Response> Read80(Expression<Func<string>> productId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/products/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(productId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
            return new ApiConnectionAction<Read80Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> Archive81(Expression<Func<string>> productId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/products/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(productId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update82Response> Update82(Expression<Func<string>> productId, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/products/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(productId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoProductsWithSameTypeResponse> MergeTwoProductsWithSameType(Expression<Func<string>> bodyobjectIdToMerge = null, Expression<Func<string>> bodyprimaryObjectId = null)
        {
            var apiCallPath = "/crm/v3/objects/products/merge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectIdToMerge != null)
            {
                body["objectIdToMerge"] = CSharpExpressionConverter.ConvertToken(bodyobjectIdToMerge);
                bodypropCount++;
            }

            if (bodyprimaryObjectId != null)
            {
                body["primaryObjectId"] = CSharpExpressionConverter.ConvertToken(bodyprimaryObjectId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MergeTwoProductsWithSameTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> GdprDelete84(Expression<Func<string>> bodyobjectId = null, Expression<Func<string>> bodyidProperty = null)
        {
            var apiCallPath = "/crm/v3/objects/products/gdpr-delete";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectId != null)
            {
                body["objectId"] = CSharpExpressionConverter.ConvertToken(bodyobjectId);
                bodypropCount++;
            }

            if (bodyidProperty != null)
            {
                body["idProperty"] = CSharpExpressionConverter.ConvertToken(bodyidProperty);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsProductsSearchResponse> PostCrmV3ObjectsProductsSearch(Expression<Func<string>> bodyafter = null, Expression<Func<bodyfilterGroupsInputItem[]>> bodyfilterGroups = null, Expression<Func<string>> bodylimit = null, Expression<Func<string[]>> bodyproperties = null, Expression<Func<string[]>> bodysorts = null, Expression<Func<string>> bodyquery = null)
        {
            var apiCallPath = "/crm/v3/objects/products/search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyafter != null)
            {
                body["after"] = CSharpExpressionConverter.ConvertToken(bodyafter);
                bodypropCount++;
            }

            if (bodyfilterGroups != null)
            {
                body["filterGroups"] = CSharpExpressionConverter.ConvertToken(bodyfilterGroups);
                bodypropCount++;
            }

            if (bodylimit != null)
            {
                body["limit"] = CSharpExpressionConverter.ConvertToken(bodylimit);
                bodypropCount++;
            }

            if (bodyproperties != null)
            {
                body["properties"] = CSharpExpressionConverter.ConvertToken(bodyproperties);
                bodypropCount++;
            }

            if (bodysorts != null)
            {
                body["sorts"] = CSharpExpressionConverter.ConvertToken(bodysorts);
                bodypropCount++;
            }

            if (bodyquery != null)
            {
                body["query"] = CSharpExpressionConverter.ConvertToken(bodyquery);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostCrmV3ObjectsProductsSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> ArchiveABatchOfObjectsById(Expression<Func<string>> objectType, Expression<Func<bodyinputsInputItem[]>> bodyinputs = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/{0}/batch/archive", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputs != null)
            {
                body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<ReadObjectResponse> ReadObject(Expression<Func<string>> objectType, Expression<Func<string>> objectId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
            return new ApiConnectionAction<ReadObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> ArchiveObjectId(Expression<Func<string>> objectType, Expression<Func<string>> objectId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<UpdateObjectIdResponse> UpdateObjectId(Expression<Func<string>> objectType, Expression<Func<string>> objectId, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<ListObjectResponse> ListObject(Expression<Func<string>> objectType, Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectType, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction<ListObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<CreateObjectIdResponse> CreateObjectId(Expression<Func<string>> objectType, Expression<Func<bodyassociationsInputItem[]>> bodyassociations = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassociations != null)
            {
                body["associations"] = CSharpExpressionConverter.ConvertToken(bodyassociations);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoObjectsWithSameTypeResponse> MergeTwoObjectsWithSameType(Expression<Func<string>> objectType, Expression<Func<string>> bodyobjectIdToMerge = null, Expression<Func<string>> bodyprimaryObjectId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/{0}/merge", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectIdToMerge != null)
            {
                body["objectIdToMerge"] = CSharpExpressionConverter.ConvertToken(bodyobjectIdToMerge);
                bodypropCount++;
            }

            if (bodyprimaryObjectId != null)
            {
                body["primaryObjectId"] = CSharpExpressionConverter.ConvertToken(bodyprimaryObjectId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MergeTwoObjectsWithSameTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> GdprDeleteObjectType(Expression<Func<string>> objectType, Expression<Func<string>> bodyobjectId = null, Expression<Func<string>> bodyidProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/{0}/gdpr-delete", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectId != null)
            {
                body["objectId"] = CSharpExpressionConverter.ConvertToken(bodyobjectId);
                bodypropCount++;
            }

            if (bodyidProperty != null)
            {
                body["idProperty"] = CSharpExpressionConverter.ConvertToken(bodyidProperty);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsObjectTypeSearchResponse> PostCrmV3ObjectsObjectTypeSearch(Expression<Func<string>> objectType, Expression<Func<string>> bodyafter = null, Expression<Func<bodyfilterGroupsInputItem[]>> bodyfilterGroups = null, Expression<Func<string>> bodylimit = null, Expression<Func<string[]>> bodyproperties = null, Expression<Func<string[]>> bodysorts = null, Expression<Func<string>> bodyquery = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/{0}/search", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyafter != null)
            {
                body["after"] = CSharpExpressionConverter.ConvertToken(bodyafter);
                bodypropCount++;
            }

            if (bodyfilterGroups != null)
            {
                body["filterGroups"] = CSharpExpressionConverter.ConvertToken(bodyfilterGroups);
                bodypropCount++;
            }

            if (bodylimit != null)
            {
                body["limit"] = CSharpExpressionConverter.ConvertToken(bodylimit);
                bodypropCount++;
            }

            if (bodyproperties != null)
            {
                body["properties"] = CSharpExpressionConverter.ConvertToken(bodyproperties);
                bodypropCount++;
            }

            if (bodysorts != null)
            {
                body["sorts"] = CSharpExpressionConverter.ConvertToken(bodysorts);
                bodypropCount++;
            }

            if (bodyquery != null)
            {
                body["query"] = CSharpExpressionConverter.ConvertToken(bodyquery);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostCrmV3ObjectsObjectTypeSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> ArchiveABatchOfDiscountsById(Expression<Func<bodyinputsInputItem[]>> bodyinputs = null)
        {
            var apiCallPath = "/crm/v3/objects/discounts/batch/archive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputs != null)
            {
                body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read16Response> Read16(Expression<Func<string>> discountId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/discounts/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(discountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
            return new ApiConnectionAction<Read16Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> Archive17(Expression<Func<string>> discountId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/discounts/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(discountId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update18Response> Update18(Expression<Func<string>> discountId, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/discounts/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(discountId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List19Response> List19(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/crm/v3/objects/discounts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction<List19Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create20Response> Create20(Expression<Func<bodyassociationsInputItem[]>> bodyassociations = null, Expression<Func<string>> bodypropertiesnostrudcf = null)
        {
            var apiCallPath = "/crm/v3/objects/discounts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassociations != null)
            {
                body["associations"] = CSharpExpressionConverter.ConvertToken(bodyassociations);
                bodypropCount++;
            }

            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (bodypropertiesnostrudcf != null)
            {
                propertiesObject["nostrudcf"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnostrudcf);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoDiscountsWithSameTypeResponse> MergeTwoDiscountsWithSameType(Expression<Func<string>> bodyobjectIdToMerge = null, Expression<Func<string>> bodyprimaryObjectId = null)
        {
            var apiCallPath = "/crm/v3/objects/discounts/merge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectIdToMerge != null)
            {
                body["objectIdToMerge"] = CSharpExpressionConverter.ConvertToken(bodyobjectIdToMerge);
                bodypropCount++;
            }

            if (bodyprimaryObjectId != null)
            {
                body["primaryObjectId"] = CSharpExpressionConverter.ConvertToken(bodyprimaryObjectId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MergeTwoDiscountsWithSameTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> GdprDeleteDiscounts(Expression<Func<string>> bodyobjectId = null, Expression<Func<string>> bodyidProperty = null)
        {
            var apiCallPath = "/crm/v3/objects/discounts/gdpr-delete";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectId != null)
            {
                body["objectId"] = CSharpExpressionConverter.ConvertToken(bodyobjectId);
                bodypropCount++;
            }

            if (bodyidProperty != null)
            {
                body["idProperty"] = CSharpExpressionConverter.ConvertToken(bodyidProperty);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsDiscountsSearchResponse> PostCrmV3ObjectsDiscountsSearch(Expression<Func<string>> bodyafter = null, Expression<Func<bodyfilterGroupsInputItem[]>> bodyfilterGroups = null, Expression<Func<string>> bodylimit = null, Expression<Func<string[]>> bodyproperties = null, Expression<Func<string[]>> bodysorts = null, Expression<Func<string>> bodyquery = null)
        {
            var apiCallPath = "/crm/v3/objects/discounts/search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyafter != null)
            {
                body["after"] = CSharpExpressionConverter.ConvertToken(bodyafter);
                bodypropCount++;
            }

            if (bodyfilterGroups != null)
            {
                body["filterGroups"] = CSharpExpressionConverter.ConvertToken(bodyfilterGroups);
                bodypropCount++;
            }

            if (bodylimit != null)
            {
                body["limit"] = CSharpExpressionConverter.ConvertToken(bodylimit);
                bodypropCount++;
            }

            if (bodyproperties != null)
            {
                body["properties"] = CSharpExpressionConverter.ConvertToken(bodyproperties);
                bodypropCount++;
            }

            if (bodysorts != null)
            {
                body["sorts"] = CSharpExpressionConverter.ConvertToken(bodysorts);
                bodypropCount++;
            }

            if (bodyquery != null)
            {
                body["query"] = CSharpExpressionConverter.ConvertToken(bodyquery);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostCrmV3ObjectsDiscountsSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> ArchiveABatchOfFeedbackSubmissionsById(Expression<Func<bodyinputsInputItem[]>> bodyinputs = null)
        {
            var apiCallPath = "/crm/v3/objects/feedback_submissions/batch/archive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputs != null)
            {
                body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read28Response> Read28(Expression<Func<string>> feedbackSubmissionId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/feedback_submissions/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(feedbackSubmissionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
            return new ApiConnectionAction<Read28Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> Archive29(Expression<Func<string>> feedbackSubmissionId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/feedback_submissions/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(feedbackSubmissionId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update30Response> Update30(Expression<Func<string>> feedbackSubmissionId, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/feedback_submissions/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(feedbackSubmissionId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List31Response> List31(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/crm/v3/objects/feedback_submissions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction<List31Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create32Response> Create32(Expression<Func<bodyassociationsInputItem[]>> bodyassociations = null)
        {
            var apiCallPath = "/crm/v3/objects/feedback_submissions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassociations != null)
            {
                body["associations"] = CSharpExpressionConverter.ConvertToken(bodyassociations);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoFeedbackSubmissionsWithSameTypeResponse> MergeTwoFeedbackSubmissionsWithSameType(Expression<Func<string>> bodyobjectIdToMerge = null, Expression<Func<string>> bodyprimaryObjectId = null)
        {
            var apiCallPath = "/crm/v3/objects/feedback_submissions/merge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectIdToMerge != null)
            {
                body["objectIdToMerge"] = CSharpExpressionConverter.ConvertToken(bodyobjectIdToMerge);
                bodypropCount++;
            }

            if (bodyprimaryObjectId != null)
            {
                body["primaryObjectId"] = CSharpExpressionConverter.ConvertToken(bodyprimaryObjectId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MergeTwoFeedbackSubmissionsWithSameTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> GdprDeleteFeedback(Expression<Func<string>> bodyobjectId = null, Expression<Func<string>> bodyidProperty = null)
        {
            var apiCallPath = "/crm/v3/objects/feedback_submissions/gdpr-delete";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectId != null)
            {
                body["objectId"] = CSharpExpressionConverter.ConvertToken(bodyobjectId);
                bodypropCount++;
            }

            if (bodyidProperty != null)
            {
                body["idProperty"] = CSharpExpressionConverter.ConvertToken(bodyidProperty);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsFeedbackSubmissionsSearchResponse> PostCrmV3ObjectsFeedbackSubmissionsSearch(Expression<Func<string>> bodyafter = null, Expression<Func<bodyfilterGroupsInputItem[]>> bodyfilterGroups = null, Expression<Func<string>> bodylimit = null, Expression<Func<string[]>> bodyproperties = null, Expression<Func<string[]>> bodysorts = null, Expression<Func<string>> bodyquery = null)
        {
            var apiCallPath = "/crm/v3/objects/feedback_submissions/search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyafter != null)
            {
                body["after"] = CSharpExpressionConverter.ConvertToken(bodyafter);
                bodypropCount++;
            }

            if (bodyfilterGroups != null)
            {
                body["filterGroups"] = CSharpExpressionConverter.ConvertToken(bodyfilterGroups);
                bodypropCount++;
            }

            if (bodylimit != null)
            {
                body["limit"] = CSharpExpressionConverter.ConvertToken(bodylimit);
                bodypropCount++;
            }

            if (bodyproperties != null)
            {
                body["properties"] = CSharpExpressionConverter.ConvertToken(bodyproperties);
                bodypropCount++;
            }

            if (bodysorts != null)
            {
                body["sorts"] = CSharpExpressionConverter.ConvertToken(bodysorts);
                bodypropCount++;
            }

            if (bodyquery != null)
            {
                body["query"] = CSharpExpressionConverter.ConvertToken(bodyquery);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostCrmV3ObjectsFeedbackSubmissionsSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> ArchiveABatchOfQuotesById(Expression<Func<bodyinputsInputItem[]>> bodyinputs = null)
        {
            var apiCallPath = "/crm/v3/objects/quotes/batch/archive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputs != null)
            {
                body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List40Response> List40(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/crm/v3/objects/quotes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction<List40Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create41Response> Create41(Expression<Func<bodyassociationsInputItem[]>> bodyassociations = null, Expression<Func<string>> bodypropertieselit26 = null)
        {
            var apiCallPath = "/crm/v3/objects/quotes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassociations != null)
            {
                body["associations"] = CSharpExpressionConverter.ConvertToken(bodyassociations);
                bodypropCount++;
            }

            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (bodypropertieselit26 != null)
            {
                propertiesObject["elit_26"] = CSharpExpressionConverter.ConvertToken(bodypropertieselit26);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read42Response> Read42(Expression<Func<string>> quoteId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/quotes/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(quoteId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
            return new ApiConnectionAction<Read42Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> Archive43(Expression<Func<string>> quoteId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/quotes/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(quoteId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update44Response> Update44(Expression<Func<string>> quoteId, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/quotes/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(quoteId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoQuotesWithSameTypeResponse> MergeTwoQuotesWithSameType(Expression<Func<string>> bodyobjectIdToMerge = null, Expression<Func<string>> bodyprimaryObjectId = null)
        {
            var apiCallPath = "/crm/v3/objects/quotes/merge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectIdToMerge != null)
            {
                body["objectIdToMerge"] = CSharpExpressionConverter.ConvertToken(bodyobjectIdToMerge);
                bodypropCount++;
            }

            if (bodyprimaryObjectId != null)
            {
                body["primaryObjectId"] = CSharpExpressionConverter.ConvertToken(bodyprimaryObjectId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MergeTwoQuotesWithSameTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> GdprDeleteQuotes(Expression<Func<string>> bodyobjectId = null, Expression<Func<string>> bodyidProperty = null)
        {
            var apiCallPath = "/crm/v3/objects/quotes/gdpr-delete";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectId != null)
            {
                body["objectId"] = CSharpExpressionConverter.ConvertToken(bodyobjectId);
                bodypropCount++;
            }

            if (bodyidProperty != null)
            {
                body["idProperty"] = CSharpExpressionConverter.ConvertToken(bodyidProperty);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsQuotesSearchResponse> PostCrmV3ObjectsQuotesSearch(Expression<Func<string>> bodyafter = null, Expression<Func<bodyfilterGroupsInputItem[]>> bodyfilterGroups = null, Expression<Func<string>> bodylimit = null, Expression<Func<string[]>> bodyproperties = null, Expression<Func<string[]>> bodysorts = null, Expression<Func<string>> bodyquery = null)
        {
            var apiCallPath = "/crm/v3/objects/quotes/search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyafter != null)
            {
                body["after"] = CSharpExpressionConverter.ConvertToken(bodyafter);
                bodypropCount++;
            }

            if (bodyfilterGroups != null)
            {
                body["filterGroups"] = CSharpExpressionConverter.ConvertToken(bodyfilterGroups);
                bodypropCount++;
            }

            if (bodylimit != null)
            {
                body["limit"] = CSharpExpressionConverter.ConvertToken(bodylimit);
                bodypropCount++;
            }

            if (bodyproperties != null)
            {
                body["properties"] = CSharpExpressionConverter.ConvertToken(bodyproperties);
                bodypropCount++;
            }

            if (bodysorts != null)
            {
                body["sorts"] = CSharpExpressionConverter.ConvertToken(bodysorts);
                bodypropCount++;
            }

            if (bodyquery != null)
            {
                body["query"] = CSharpExpressionConverter.ConvertToken(bodyquery);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostCrmV3ObjectsQuotesSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> ArchiveABatchOfTaxesById(Expression<Func<bodyinputsInputItem[]>> bodyinputs = null)
        {
            var apiCallPath = "/crm/v3/objects/taxes/batch/archive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputs != null)
            {
                body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List52Response> List52(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/crm/v3/objects/taxes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction<List52Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create53Response> Create53(Expression<Func<bodyassociationsInputItem[]>> bodyassociations = null)
        {
            var apiCallPath = "/crm/v3/objects/taxes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassociations != null)
            {
                body["associations"] = CSharpExpressionConverter.ConvertToken(bodyassociations);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read54Response> Read54(Expression<Func<string>> taxId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/taxes/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(taxId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
            return new ApiConnectionAction<Read54Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> Archive55(Expression<Func<string>> taxId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/taxes/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(taxId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update56Response> Update56(Expression<Func<string>> taxId, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/taxes/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(taxId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoTaxesWithSameTypeResponse> MergeTwoTaxesWithSameType(Expression<Func<string>> bodyobjectIdToMerge = null, Expression<Func<string>> bodyprimaryObjectId = null)
        {
            var apiCallPath = "/crm/v3/objects/taxes/merge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectIdToMerge != null)
            {
                body["objectIdToMerge"] = CSharpExpressionConverter.ConvertToken(bodyobjectIdToMerge);
                bodypropCount++;
            }

            if (bodyprimaryObjectId != null)
            {
                body["primaryObjectId"] = CSharpExpressionConverter.ConvertToken(bodyprimaryObjectId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MergeTwoTaxesWithSameTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> GdprDeleteTaxes(Expression<Func<string>> bodyobjectId = null, Expression<Func<string>> bodyidProperty = null)
        {
            var apiCallPath = "/crm/v3/objects/taxes/gdpr-delete";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectId != null)
            {
                body["objectId"] = CSharpExpressionConverter.ConvertToken(bodyobjectId);
                bodypropCount++;
            }

            if (bodyidProperty != null)
            {
                body["idProperty"] = CSharpExpressionConverter.ConvertToken(bodyidProperty);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsTaxesSearchResponse> PostCrmV3ObjectsTaxesSearch(Expression<Func<string>> bodyafter = null, Expression<Func<bodyfilterGroupsInputItem[]>> bodyfilterGroups = null, Expression<Func<string>> bodylimit = null, Expression<Func<string[]>> bodyproperties = null, Expression<Func<string[]>> bodysorts = null, Expression<Func<string>> bodyquery = null)
        {
            var apiCallPath = "/crm/v3/objects/taxes/search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyafter != null)
            {
                body["after"] = CSharpExpressionConverter.ConvertToken(bodyafter);
                bodypropCount++;
            }

            if (bodyfilterGroups != null)
            {
                body["filterGroups"] = CSharpExpressionConverter.ConvertToken(bodyfilterGroups);
                bodypropCount++;
            }

            if (bodylimit != null)
            {
                body["limit"] = CSharpExpressionConverter.ConvertToken(bodylimit);
                bodypropCount++;
            }

            if (bodyproperties != null)
            {
                body["properties"] = CSharpExpressionConverter.ConvertToken(bodyproperties);
                bodypropCount++;
            }

            if (bodysorts != null)
            {
                body["sorts"] = CSharpExpressionConverter.ConvertToken(bodysorts);
                bodypropCount++;
            }

            if (bodyquery != null)
            {
                body["query"] = CSharpExpressionConverter.ConvertToken(bodyquery);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostCrmV3ObjectsTaxesSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> ArchiveABatchOfTicketsById(Expression<Func<bodyinputsInputItem[]>> bodyinputs = null)
        {
            var apiCallPath = "/crm/v3/objects/tickets/batch/archive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputs != null)
            {
                body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Read64Response> Read64(Expression<Func<string>> ticketId, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/tickets/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
            return new ApiConnectionAction<Read64Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> Archive65(Expression<Func<string>> ticketId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/tickets/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Update66Response> Update66(Expression<Func<string>> ticketId, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/tickets/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<List67Response> List67(Expression<Func<string>> limit = null, Expression<Func<string>> after = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertiesWithHistory = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/crm/v3/objects/tickets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (propertiesWithHistory != null)
                callPayload.Queries["propertiesWithHistory"] = CSharpExpressionConverter.ConvertO(propertiesWithHistory);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction<List67Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create68Response> Create68(Expression<Func<bodyassociationsInputItem[]>> bodyassociations = null)
        {
            var apiCallPath = "/crm/v3/objects/tickets";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassociations != null)
            {
                body["associations"] = CSharpExpressionConverter.ConvertToken(bodyassociations);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<MergeTwoTicketsWithSameTypeResponse> MergeTwoTicketsWithSameType(Expression<Func<string>> bodyobjectIdToMerge = null, Expression<Func<string>> bodyprimaryObjectId = null)
        {
            var apiCallPath = "/crm/v3/objects/tickets/merge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectIdToMerge != null)
            {
                body["objectIdToMerge"] = CSharpExpressionConverter.ConvertToken(bodyobjectIdToMerge);
                bodypropCount++;
            }

            if (bodyprimaryObjectId != null)
            {
                body["primaryObjectId"] = CSharpExpressionConverter.ConvertToken(bodyprimaryObjectId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MergeTwoTicketsWithSameTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> GdprDeleteTickets(Expression<Func<string>> bodyobjectId = null, Expression<Func<string>> bodyidProperty = null)
        {
            var apiCallPath = "/crm/v3/objects/tickets/gdpr-delete";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjectId != null)
            {
                body["objectId"] = CSharpExpressionConverter.ConvertToken(bodyobjectId);
                bodypropCount++;
            }

            if (bodyidProperty != null)
            {
                body["idProperty"] = CSharpExpressionConverter.ConvertToken(bodyidProperty);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<PostCrmV3ObjectsTicketsSearchResponse> PostCrmV3ObjectsTicketsSearch(Expression<Func<string>> bodyafter = null, Expression<Func<bodyfilterGroupsInputItem[]>> bodyfilterGroups = null, Expression<Func<string>> bodylimit = null, Expression<Func<string[]>> bodyproperties = null, Expression<Func<string[]>> bodysorts = null, Expression<Func<string>> bodyquery = null)
        {
            var apiCallPath = "/crm/v3/objects/tickets/search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyafter != null)
            {
                body["after"] = CSharpExpressionConverter.ConvertToken(bodyafter);
                bodypropCount++;
            }

            if (bodyfilterGroups != null)
            {
                body["filterGroups"] = CSharpExpressionConverter.ConvertToken(bodyfilterGroups);
                bodypropCount++;
            }

            if (bodylimit != null)
            {
                body["limit"] = CSharpExpressionConverter.ConvertToken(bodylimit);
                bodypropCount++;
            }

            if (bodyproperties != null)
            {
                body["properties"] = CSharpExpressionConverter.ConvertToken(bodyproperties);
                bodypropCount++;
            }

            if (bodysorts != null)
            {
                body["sorts"] = CSharpExpressionConverter.ConvertToken(bodysorts);
                bodypropCount++;
            }

            if (bodyquery != null)
            {
                body["query"] = CSharpExpressionConverter.ConvertToken(bodyquery);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostCrmV3ObjectsTicketsSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<ListAssociationTypesResponse> ListAssociationTypes(Expression<Func<string>> fromObjectType, Expression<Func<string>> toObjectType)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/associations/{0}/{1}/types", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fromObjectType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(toObjectType, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListAssociationTypesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> DeleteSpecificLabels(Expression<Func<string>> fromObjectType, Expression<Func<string>> toObjectType, Expression<Func<bodyinputsInputItem2[]>> bodyinputs = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v4/associations/{0}/{1}/batch/labels/archive", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fromObjectType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(toObjectType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputs != null)
            {
                body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> Delete(Expression<Func<string>> fromObjectType, Expression<Func<string>> toObjectType, Expression<Func<bodyinputsInputItem22[]>> bodyinputs = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v4/associations/{0}/{1}/batch/archive", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fromObjectType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(toObjectType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputs != null)
            {
                body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<CreateDefaultAssociationsResponse> CreateDefaultAssociations(Expression<Func<string>> fromObjectType, Expression<Func<string>> toObjectType, Expression<Func<bodyinputsInputItem222[]>> bodyinputs = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v4/associations/{0}/{1}/batch/associate/default", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fromObjectType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(toObjectType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinputs != null)
            {
                body["inputs"] = CSharpExpressionConverter.ConvertToken(bodyinputs);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateDefaultAssociationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> Delete6(Expression<Func<string>> objectType, Expression<Func<string>> objectId, Expression<Func<string>> toObjectType, Expression<Func<string>> toObjectId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v4/objects/{0}/{1}/associations/{2}/{3}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(toObjectType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(toObjectId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<Create7Response> Create7(Expression<Func<string>> objectType, Expression<Func<string>> objectId, Expression<Func<string>> toObjectType, Expression<Func<string>> toObjectId, Expression<Func<bodyInputItem[]>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v4/objects/{0}/{1}/associations/{2}/{3}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(toObjectType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(toObjectId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<Create7Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<CreateDefaultResponse> CreateDefault(Expression<Func<string>> fromObjectType, Expression<Func<string>> fromObjectId, Expression<Func<string>> toObjectType, Expression<Func<string>> toObjectId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v4/objects/{0}/{1}/associations/default/{2}/{3}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fromObjectType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fromObjectId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(toObjectType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(toObjectId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CreateDefaultResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<ListAssociationsResponse> ListAssociations(Expression<Func<string>> objectType, Expression<Func<string>> objectId, Expression<Func<string>> toObjectType, Expression<Func<string>> after = null, Expression<Func<string>> limit = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v4/objects/{0}/{1}/associations/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(toObjectType, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            return new ApiConnectionAction<ListAssociationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<GetAllCardsResponse> GetAllCards(Expression<Func<string>> appId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/extensions/cards-dev/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(appId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllCardsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<CreateANewCardResponse> CreateANewCard(Expression<Func<string>> appId, Expression<Func<string[]>> bodyactionsbaseUrls = null, Expression<Func<bodydisplaypropertiesInputItem[]>> bodydisplayproperties = null, Expression<Func<bodyfetchobjectTypesInputItem[]>> bodyfetchobjectTypes = null, Expression<Func<string>> bodyfetchtargetUrl = null, Expression<Func<string>> bodyfetchcardType = null, Expression<Func<string>> bodyfetchserverlessFunction = null, Expression<Func<string>> bodytitle = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/extensions/cards-dev/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(appId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var actionsObject = new JObject();
            var actionsObjectpropCount = 0;
            if (bodyactionsbaseUrls != null)
            {
                actionsObject["baseUrls"] = CSharpExpressionConverter.ConvertToken(bodyactionsbaseUrls);
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
                displayObject["properties"] = CSharpExpressionConverter.ConvertToken(bodydisplayproperties);
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
                fetchObject["objectTypes"] = CSharpExpressionConverter.ConvertToken(bodyfetchobjectTypes);
                fetchObjectpropCount++;
            }

            if (bodyfetchtargetUrl != null)
            {
                fetchObject["targetUrl"] = CSharpExpressionConverter.ConvertToken(bodyfetchtargetUrl);
                fetchObjectpropCount++;
            }

            if (bodyfetchcardType != null)
            {
                fetchObject["cardType"] = CSharpExpressionConverter.ConvertToken(bodyfetchcardType);
                fetchObjectpropCount++;
            }

            if (bodyfetchserverlessFunction != null)
            {
                fetchObject["serverlessFunction"] = CSharpExpressionConverter.ConvertToken(bodyfetchserverlessFunction);
                fetchObjectpropCount++;
            }

            if (fetchObjectpropCount > 0)
            {
                body["fetch"] = fetchObject;
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateANewCardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<GetACardResponse> GetACard(Expression<Func<string>> appId, Expression<Func<string>> cardId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/extensions/cards-dev/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(appId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetACardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> DeleteACard(Expression<Func<string>> appId, Expression<Func<string>> cardId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/extensions/cards-dev/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(appId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<UpdateACardResponse> UpdateACard(Expression<Func<string>> appId, Expression<Func<string>> cardId, Expression<Func<string>> bodytitle = null, Expression<Func<bodyfetchobjectTypesInputItem[]>> bodyfetchobjectTypes = null, Expression<Func<string>> bodyfetchcardType = null, Expression<Func<string>> bodyfetchtargetUrl = null, Expression<Func<string>> bodyfetchserverlessFunction = null, Expression<Func<bodydisplaypropertiesInputItem[]>> bodydisplayproperties = null, Expression<Func<string[]>> bodyactionsbaseUrls = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/extensions/cards-dev/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(appId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            var fetchObject = new JObject();
            var fetchObjectpropCount = 0;
            if (bodyfetchobjectTypes != null)
            {
                fetchObject["objectTypes"] = CSharpExpressionConverter.ConvertToken(bodyfetchobjectTypes);
                fetchObjectpropCount++;
            }

            if (bodyfetchcardType != null)
            {
                fetchObject["cardType"] = CSharpExpressionConverter.ConvertToken(bodyfetchcardType);
                fetchObjectpropCount++;
            }

            if (bodyfetchtargetUrl != null)
            {
                fetchObject["targetUrl"] = CSharpExpressionConverter.ConvertToken(bodyfetchtargetUrl);
                fetchObjectpropCount++;
            }

            if (bodyfetchserverlessFunction != null)
            {
                fetchObject["serverlessFunction"] = CSharpExpressionConverter.ConvertToken(bodyfetchserverlessFunction);
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
                displayObject["properties"] = CSharpExpressionConverter.ConvertToken(bodydisplayproperties);
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
                actionsObject["baseUrls"] = CSharpExpressionConverter.ConvertToken(bodyactionsbaseUrls);
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
        public IBodyWorkflowAction<GetCrmV3ExportsExportAsyncTasksTaskIdStatusResponse> GetCrmV3ExportsExportAsyncTasksTaskIdStatus(Expression<Func<string>> taskId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/exports/export/async/tasks/{0}/status", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCrmV3ExportsExportAsyncTasksTaskIdStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<StartAnExportResponse> StartAnExport(Expression<Func<string>> bodyexportName = null, Expression<Func<string>> bodyexportType = null, Expression<Func<string>> bodyformat = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string[]>> bodyobjectProperties = null, Expression<Func<string>> bodyobjectType = null, Expression<Func<string>> bodyassociatedObjectType = null, Expression<Func<bodypublicCrmSearchRequestfiltersInputItem[]>> bodypublicCrmSearchRequestfilters = null, Expression<Func<string>> bodypublicCrmSearchRequestquery = null, Expression<Func<string[]>> bodypublicCrmSearchRequestsorts = null)
        {
            var apiCallPath = "/crm/v3/exports/export/async";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyexportName != null)
            {
                body["exportName"] = CSharpExpressionConverter.ConvertToken(bodyexportName);
                bodypropCount++;
            }

            if (bodyexportType != null)
            {
                body["exportType"] = CSharpExpressionConverter.ConvertToken(bodyexportType);
                bodypropCount++;
            }

            if (bodyformat != null)
            {
                body["format"] = CSharpExpressionConverter.ConvertToken(bodyformat);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["language"] = CSharpExpressionConverter.ConvertToken(bodylanguage);
                bodypropCount++;
            }

            if (bodyobjectProperties != null)
            {
                body["objectProperties"] = CSharpExpressionConverter.ConvertToken(bodyobjectProperties);
                bodypropCount++;
            }

            if (bodyobjectType != null)
            {
                body["objectType"] = CSharpExpressionConverter.ConvertToken(bodyobjectType);
                bodypropCount++;
            }

            if (bodyassociatedObjectType != null)
            {
                body["associatedObjectType"] = CSharpExpressionConverter.ConvertToken(bodyassociatedObjectType);
                bodypropCount++;
            }

            var publicCrmSearchRequestObject = new JObject();
            var publicCrmSearchRequestObjectpropCount = 0;
            if (bodypublicCrmSearchRequestfilters != null)
            {
                publicCrmSearchRequestObject["filters"] = CSharpExpressionConverter.ConvertToken(bodypublicCrmSearchRequestfilters);
                publicCrmSearchRequestObjectpropCount++;
            }

            if (bodypublicCrmSearchRequestquery != null)
            {
                publicCrmSearchRequestObject["query"] = CSharpExpressionConverter.ConvertToken(bodypublicCrmSearchRequestquery);
                publicCrmSearchRequestObjectpropCount++;
            }

            if (bodypublicCrmSearchRequestsorts != null)
            {
                publicCrmSearchRequestObject["sorts"] = CSharpExpressionConverter.ConvertToken(bodypublicCrmSearchRequestsorts);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<GetTheInformationOnAnyImportResponse> GetTheInformationOnAnyImport(Expression<Func<string>> importId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/imports/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(importId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTheInformationOnAnyImportResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<CancelAnActiveImportResponse> CancelAnActiveImport(Expression<Func<string>> importId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/imports/{0}/cancel", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(importId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CancelAnActiveImportResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<GetActiveImportsResponse> GetActiveImports(Expression<Func<string>> after = null, Expression<Func<string>> before = null, Expression<Func<string>> limit = null)
        {
            var apiCallPath = "/crm/v3/imports/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (before != null)
                callPayload.Queries["before"] = CSharpExpressionConverter.ConvertO(before);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            return new ApiConnectionAction<GetActiveImportsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<StartANewImportResponse> StartANewImport(Expression<Func<string>> contentType)
        {
            var apiCallPath = "/crm/v3/imports/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            return new ApiConnectionAction<StartANewImportResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<GetCrmV3ImportsImportIdErrorsGetErrorsResponse> GetCrmV3ImportsImportIdErrorsGetErrors(Expression<Func<string>> importId, Expression<Func<string>> after = null, Expression<Func<string>> limit = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/imports/{0}/errors", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(importId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            return new ApiConnectionAction<GetCrmV3ImportsImportIdErrorsGetErrorsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<AddAndOrRemoveRecordsFromAListResponse> AddAndOrRemoveRecordsFromAList(Expression<Func<string>> listId, Expression<Func<string[]>> bodyrecordIdsToAdd = null, Expression<Func<string[]>> bodyrecordIdsToRemove = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/lists/{0}/memberships/add-and-remove", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyrecordIdsToAdd != null)
            {
                body["recordIdsToAdd"] = CSharpExpressionConverter.ConvertToken(bodyrecordIdsToAdd);
                bodypropCount++;
            }

            if (bodyrecordIdsToRemove != null)
            {
                body["recordIdsToRemove"] = CSharpExpressionConverter.ConvertToken(bodyrecordIdsToRemove);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddAndOrRemoveRecordsFromAListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<AddRecordsToAListResponse> AddRecordsToAList(Expression<Func<string>> listId, Expression<Func<string[]>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/lists/{0}/memberships/add", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<AddRecordsToAListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> AddAllRecordsFromASourceListToADestinationList(Expression<Func<string>> listId, Expression<Func<string>> sourceListId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/lists/{0}/memberships/add-from/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sourceListId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<FetchListMembershipsOrderedByIdResponse> FetchListMembershipsOrderedById(Expression<Func<string>> listId, Expression<Func<string>> after = null, Expression<Func<string>> before = null, Expression<Func<string>> limit = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/lists/{0}/memberships", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            if (before != null)
                callPayload.Queries["before"] = CSharpExpressionConverter.ConvertO(before);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            return new ApiConnectionAction<FetchListMembershipsOrderedByIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<string> DeleteAllRecordsFromAList(Expression<Func<string>> listId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/lists/{0}/memberships", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<RemoveRecordsFromAListResponse> RemoveRecordsFromAList(Expression<Func<string>> listId, Expression<Func<string[]>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/lists/{0}/memberships/remove", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<RemoveRecordsFromAListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrmv2")]
        public IBodyWorkflowAction<SearchListsResponse> SearchLists(Expression<Func<string[]>> bodyadditionalProperties = null, Expression<Func<string>> bodyoffset = null, Expression<Func<string>> bodyquery = null, Expression<Func<string>> bodycount = null)
        {
            var apiCallPath = "/crm/v3/lists/search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyadditionalProperties != null)
            {
                body["additionalProperties"] = CSharpExpressionConverter.ConvertToken(bodyadditionalProperties);
                bodypropCount++;
            }

            if (bodyoffset != null)
            {
                body["offset"] = CSharpExpressionConverter.ConvertToken(bodyoffset);
                bodypropCount++;
            }

            if (bodyquery != null)
            {
                body["query"] = CSharpExpressionConverter.ConvertToken(bodyquery);
                bodypropCount++;
            }

            if (bodycount != null)
            {
                body["count"] = CSharpExpressionConverter.ConvertToken(bodycount);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SearchListsResponse>(callPayload);
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