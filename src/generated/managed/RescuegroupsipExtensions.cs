//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rescuegroupsip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RescuegroupsipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        [WorkflowExpressionFactory(nameof(__BuildBreed))]
        public IBodyWorkflowAction<BreedResponse> Breed([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BreedResponse> __BuildBreed(WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<BreedResponse>(() =>
            {
                var apiCallPath = "/public/animals/breeds/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<BreedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        [WorkflowExpressionFactory(nameof(__BuildBreedID))]
        public IBodyWorkflowAction<BreedIDResponse> BreedID([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BreedIDResponse> __BuildBreedID(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<BreedIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/public/animals/breeds/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BreedIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        [WorkflowExpressionFactory(nameof(__BuildBreedSpecies))]
        public IBodyWorkflowAction<BreedSpeciesResponse> BreedSpecies([WorkflowExpression] Func<string> species, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BreedSpeciesResponse> __BuildBreedSpecies(WorkflowExpression<string> species, WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(species, nameof(species), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<BreedSpeciesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/public/animals/breeds/search/{0}/", ExpressionConverter.ConvertWithUrlEncoding(species, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<BreedSpeciesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        [WorkflowExpressionFactory(nameof(__BuildBreedSpeciesID))]
        public IBodyWorkflowAction<BreedSpeciesIDResponse> BreedSpeciesID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BreedSpeciesIDResponse> __BuildBreedSpeciesID(WorkflowExpression<string> id, WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<BreedSpeciesIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/public/animals/species/{0}/breeds/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<BreedSpeciesIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        [WorkflowExpressionFactory(nameof(__BuildOrganization))]
        public IBodyWorkflowAction<OrganizationResponse> Organization([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OrganizationResponse> __BuildOrganization(WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<OrganizationResponse>(() =>
            {
                var apiCallPath = "/public/orgs/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<OrganizationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        [WorkflowExpressionFactory(nameof(__BuildOrganizationID))]
        public IBodyWorkflowAction<OrganizationIDResponse> OrganizationID([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OrganizationIDResponse> __BuildOrganizationID(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<OrganizationIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/public/orgs/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OrganizationIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        [WorkflowExpressionFactory(nameof(__BuildAnimal))]
        public IBodyWorkflowAction<AnimalResponse> Animal([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AnimalResponse> __BuildAnimal(WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<AnimalResponse>(() =>
            {
                var apiCallPath = "/public/animals/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<AnimalResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        [WorkflowExpressionFactory(nameof(__BuildAnimalStatus))]
        public IBodyWorkflowAction<AnimalStatusResponse> AnimalStatus([WorkflowExpression] Func<string> status, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AnimalStatusResponse> __BuildAnimalStatus(WorkflowExpression<string> status, WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(status, nameof(status), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<AnimalStatusResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/public/animals/search/{0}/", ExpressionConverter.ConvertWithUrlEncoding(status, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<AnimalStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        [WorkflowExpressionFactory(nameof(__BuildAnimalID))]
        public IBodyWorkflowAction<AnimalIDResponse> AnimalID([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AnimalIDResponse> __BuildAnimalID(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<AnimalIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/public/animals/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AnimalIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        [WorkflowExpressionFactory(nameof(__BuildOrganizationAnimal))]
        public IBodyWorkflowAction<OrganizationAnimalResponse> OrganizationAnimal([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OrganizationAnimalResponse> __BuildOrganizationAnimal(WorkflowExpression<string> id, WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<OrganizationAnimalResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/public/orgs/{0}/animals/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<OrganizationAnimalResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        [WorkflowExpressionFactory(nameof(__BuildOrganizationAnimalStatus))]
        public IBodyWorkflowAction<OrganizationAnimalStatusResponse> OrganizationAnimalStatus([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> status, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OrganizationAnimalStatusResponse> __BuildOrganizationAnimalStatus(WorkflowExpression<string> id, WorkflowExpression<string> status, WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(status, nameof(status), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<OrganizationAnimalStatusResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/public/orgs/{0}/animals/search/{1}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(status, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<OrganizationAnimalStatusResponse>(callPayload);
            });
        }
    }

    public class RescuegroupsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class BreedResponse
    {
        [JsonProperty("meta")]
        public BreedResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public BreedResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("included")]
        public BreedResponseIncludedTypeItem[] Included { get; set; }

        [JsonProperty("links")]
        public BreedResponseLinksType Links { get; set; }
    }

    public class BreedResponseMetaType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("countReturned")]
        public int CountReturned { get; set; }

        [JsonProperty("pageReturned")]
        public int PageReturned { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }

    public class BreedResponseDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public BreedResponseDataTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("relationships")]
        public BreedResponseDataTypeItemRelationshipsType Relationships { get; set; }
    }

    public class BreedResponseDataTypeItemAttributesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class BreedResponseDataTypeItemRelationshipsType
    {
        [JsonProperty("species")]
        public BreedResponseDataTypeItemRelationshipsTypeSpeciesType Species { get; set; }
    }

    public class BreedResponseDataTypeItemRelationshipsTypeSpeciesType
    {
        [JsonProperty("data")]
        public BreedResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public BreedResponseDataTypeItemRelationshipsTypeSpeciesTypeLinksType Links { get; set; }
    }

    public class BreedResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("links")]
        public BreedResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItemLinksType Links { get; set; }
    }

    public class BreedResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItemLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class BreedResponseDataTypeItemRelationshipsTypeSpeciesTypeLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class BreedResponseIncludedTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public BreedResponseIncludedTypeItemAttributesType Attributes { get; set; }
    }

    public class BreedResponseIncludedTypeItemAttributesType
    {
        [JsonProperty("singular")]
        public string Singular { get; set; }

        [JsonProperty("plural")]
        public string Plural { get; set; }

        [JsonProperty("youngSingular")]
        public string YoungSingular { get; set; }

        [JsonProperty("youngPlural")]
        public string YoungPlural { get; set; }
    }

    public class BreedResponseLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class BreedIDResponse
    {
        [JsonProperty("meta")]
        public BreedIDResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public BreedIDResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("included")]
        public BreedIDResponseIncludedTypeItem[] Included { get; set; }

        [JsonProperty("links")]
        public BreedIDResponseLinksType Links { get; set; }
    }

    public class BreedIDResponseMetaType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("countReturned")]
        public int CountReturned { get; set; }

        [JsonProperty("pageReturned")]
        public int PageReturned { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }

    public class BreedIDResponseDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public BreedIDResponseDataTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("relationships")]
        public BreedIDResponseDataTypeItemRelationshipsType Relationships { get; set; }
    }

    public class BreedIDResponseDataTypeItemAttributesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class BreedIDResponseDataTypeItemRelationshipsType
    {
        [JsonProperty("species")]
        public BreedIDResponseDataTypeItemRelationshipsTypeSpeciesType Species { get; set; }
    }

    public class BreedIDResponseDataTypeItemRelationshipsTypeSpeciesType
    {
        [JsonProperty("data")]
        public BreedIDResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public BreedIDResponseDataTypeItemRelationshipsTypeSpeciesTypeLinksType Links { get; set; }
    }

    public class BreedIDResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("links")]
        public BreedIDResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItemLinksType Links { get; set; }
    }

    public class BreedIDResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItemLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class BreedIDResponseDataTypeItemRelationshipsTypeSpeciesTypeLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class BreedIDResponseIncludedTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public BreedIDResponseIncludedTypeItemAttributesType Attributes { get; set; }
    }

    public class BreedIDResponseIncludedTypeItemAttributesType
    {
        [JsonProperty("singular")]
        public string Singular { get; set; }

        [JsonProperty("plural")]
        public string Plural { get; set; }

        [JsonProperty("youngSingular")]
        public string YoungSingular { get; set; }

        [JsonProperty("youngPlural")]
        public string YoungPlural { get; set; }
    }

    public class BreedIDResponseLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }
    }

    public class BreedSpeciesResponse
    {
        [JsonProperty("meta")]
        public BreedSpeciesResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public BreedSpeciesResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("included")]
        public BreedSpeciesResponseIncludedTypeItem[] Included { get; set; }

        [JsonProperty("links")]
        public BreedSpeciesResponseLinksType Links { get; set; }
    }

    public class BreedSpeciesResponseMetaType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("countReturned")]
        public int CountReturned { get; set; }

        [JsonProperty("pageReturned")]
        public int PageReturned { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }

    public class BreedSpeciesResponseDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public BreedSpeciesResponseDataTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("relationships")]
        public BreedSpeciesResponseDataTypeItemRelationshipsType Relationships { get; set; }
    }

    public class BreedSpeciesResponseDataTypeItemAttributesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class BreedSpeciesResponseDataTypeItemRelationshipsType
    {
        [JsonProperty("species")]
        public BreedSpeciesResponseDataTypeItemRelationshipsTypeSpeciesType Species { get; set; }
    }

    public class BreedSpeciesResponseDataTypeItemRelationshipsTypeSpeciesType
    {
        [JsonProperty("data")]
        public BreedSpeciesResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public BreedSpeciesResponseDataTypeItemRelationshipsTypeSpeciesTypeLinksType Links { get; set; }
    }

    public class BreedSpeciesResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("links")]
        public BreedSpeciesResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItemLinksType Links { get; set; }
    }

    public class BreedSpeciesResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItemLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class BreedSpeciesResponseDataTypeItemRelationshipsTypeSpeciesTypeLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class BreedSpeciesResponseIncludedTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public BreedSpeciesResponseIncludedTypeItemAttributesType Attributes { get; set; }
    }

    public class BreedSpeciesResponseIncludedTypeItemAttributesType
    {
        [JsonProperty("singular")]
        public string Singular { get; set; }

        [JsonProperty("plural")]
        public string Plural { get; set; }

        [JsonProperty("youngSingular")]
        public string YoungSingular { get; set; }

        [JsonProperty("youngPlural")]
        public string YoungPlural { get; set; }
    }

    public class BreedSpeciesResponseLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class BreedSpeciesIDResponse
    {
        [JsonProperty("meta")]
        public BreedSpeciesIDResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public BreedSpeciesIDResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("included")]
        public BreedSpeciesIDResponseIncludedTypeItem[] Included { get; set; }

        [JsonProperty("links")]
        public BreedSpeciesIDResponseLinksType Links { get; set; }
    }

    public class BreedSpeciesIDResponseMetaType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("countReturned")]
        public int CountReturned { get; set; }

        [JsonProperty("pageReturned")]
        public int PageReturned { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }

    public class BreedSpeciesIDResponseDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public BreedSpeciesIDResponseDataTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("relationships")]
        public BreedSpeciesIDResponseDataTypeItemRelationshipsType Relationships { get; set; }
    }

    public class BreedSpeciesIDResponseDataTypeItemAttributesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class BreedSpeciesIDResponseDataTypeItemRelationshipsType
    {
        [JsonProperty("species")]
        public BreedSpeciesIDResponseDataTypeItemRelationshipsTypeSpeciesType Species { get; set; }
    }

    public class BreedSpeciesIDResponseDataTypeItemRelationshipsTypeSpeciesType
    {
        [JsonProperty("data")]
        public BreedSpeciesIDResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public BreedSpeciesIDResponseDataTypeItemRelationshipsTypeSpeciesTypeLinksType Links { get; set; }
    }

    public class BreedSpeciesIDResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("links")]
        public BreedSpeciesIDResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItemLinksType Links { get; set; }
    }

    public class BreedSpeciesIDResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItemLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class BreedSpeciesIDResponseDataTypeItemRelationshipsTypeSpeciesTypeLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class BreedSpeciesIDResponseIncludedTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public BreedSpeciesIDResponseIncludedTypeItemAttributesType Attributes { get; set; }
    }

    public class BreedSpeciesIDResponseIncludedTypeItemAttributesType
    {
        [JsonProperty("singular")]
        public string Singular { get; set; }

        [JsonProperty("plural")]
        public string Plural { get; set; }

        [JsonProperty("youngSingular")]
        public string YoungSingular { get; set; }

        [JsonProperty("youngPlural")]
        public string YoungPlural { get; set; }
    }

    public class BreedSpeciesIDResponseLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }
    }

    public class OrganizationResponse
    {
        [JsonProperty("meta")]
        public OrganizationResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public OrganizationResponseDataTypeItem[] Data { get; set; }
    }

    public class OrganizationResponseMetaType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("countReturned")]
        public int CountReturned { get; set; }

        [JsonProperty("pageReturned")]
        public int PageReturned { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }

    public class OrganizationResponseDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public OrganizationResponseDataTypeItemAttributesType Attributes { get; set; }
    }

    public class OrganizationResponseDataTypeItemAttributesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalcode")]
        public string Postalcode { get; set; }

        [JsonProperty("postalcodePlus4")]
        public string PostalcodePlus4 { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("facebookUrl")]
        public string FacebookUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("isCommonapplicationAccepted")]
        public bool IsCommonapplicationAccepted { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("coordinates")]
        public string Coordinates { get; set; }

        [JsonProperty("citystate")]
        public string Citystate { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("serveAreas")]
        public string ServeAreas { get; set; }

        [JsonProperty("services")]
        public string Services { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("adoptionProcess")]
        public string AdoptionProcess { get; set; }

        [JsonProperty("adoptionUrl")]
        public string AdoptionUrl { get; set; }

        [JsonProperty("donationUrl")]
        public string DonationUrl { get; set; }

        [JsonProperty("sponsorshipUrl")]
        public string SponsorshipUrl { get; set; }
    }

    public class OrganizationIDResponse
    {
        [JsonProperty("meta")]
        public OrganizationIDResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public OrganizationIDResponseDataTypeItem[] Data { get; set; }
    }

    public class OrganizationIDResponseMetaType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("countReturned")]
        public int CountReturned { get; set; }

        [JsonProperty("pageReturned")]
        public int PageReturned { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }

    public class OrganizationIDResponseDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public OrganizationIDResponseDataTypeItemAttributesType Attributes { get; set; }
    }

    public class OrganizationIDResponseDataTypeItemAttributesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalcode")]
        public string Postalcode { get; set; }

        [JsonProperty("postalcodePlus4")]
        public string PostalcodePlus4 { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("facebookUrl")]
        public string FacebookUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("isCommonapplicationAccepted")]
        public bool IsCommonapplicationAccepted { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("coordinates")]
        public string Coordinates { get; set; }

        [JsonProperty("citystate")]
        public string Citystate { get; set; }
    }

    public class AnimalResponse
    {
        [JsonProperty("meta")]
        public AnimalResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public AnimalResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("included")]
        public AnimalResponseIncludedTypeItem[] Included { get; set; }
    }

    public class AnimalResponseMetaType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("countReturned")]
        public int CountReturned { get; set; }

        [JsonProperty("pageReturned")]
        public int PageReturned { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }

    public class AnimalResponseDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public AnimalResponseDataTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("relationships")]
        public AnimalResponseDataTypeItemRelationshipsType Relationships { get; set; }
    }

    public class AnimalResponseDataTypeItemAttributesType
    {
        [JsonProperty("adoptedDate")]
        public string AdoptedDate { get; set; }

        [JsonProperty("isAdoptionPending")]
        public bool IsAdoptionPending { get; set; }

        [JsonProperty("ageGroup")]
        public string AgeGroup { get; set; }

        [JsonProperty("ageString")]
        public string AgeString { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("isBirthDateExact")]
        public bool IsBirthDateExact { get; set; }

        [JsonProperty("breedString")]
        public string BreedString { get; set; }

        [JsonProperty("breedPrimary")]
        public string BreedPrimary { get; set; }

        [JsonProperty("breedPrimaryId")]
        public int BreedPrimaryId { get; set; }

        [JsonProperty("breedSecondary")]
        public string BreedSecondary { get; set; }

        [JsonProperty("breedSecondaryId")]
        public int BreedSecondaryId { get; set; }

        [JsonProperty("colorDetails")]
        public string ColorDetails { get; set; }

        [JsonProperty("isCourtesyListing")]
        public bool IsCourtesyListing { get; set; }

        [JsonProperty("descriptionHtml")]
        public string DescriptionHtml { get; set; }

        [JsonProperty("descriptionText")]
        public string DescriptionText { get; set; }

        [JsonProperty("isNeedingFoster")]
        public bool IsNeedingFoster { get; set; }

        [JsonProperty("isFound")]
        public bool IsFound { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pictureCount")]
        public int PictureCount { get; set; }

        [JsonProperty("pictureThumbnailUrl")]
        public string PictureThumbnailUrl { get; set; }

        [JsonProperty("searchString")]
        public string SearchString { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("sizeUOM")]
        public string SizeUOM { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("isSponsorable")]
        public bool IsSponsorable { get; set; }

        [JsonProperty("trackerimageUrl")]
        public string TrackerimageUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("videoCount")]
        public int VideoCount { get; set; }

        [JsonProperty("videoUrlCount")]
        public int VideoUrlCount { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("activityLevel")]
        public string ActivityLevel { get; set; }

        [JsonProperty("adoptionFeeString")]
        public string AdoptionFeeString { get; set; }

        [JsonProperty("isBreedMixed")]
        public bool IsBreedMixed { get; set; }

        [JsonProperty("isCatsOk")]
        public bool IsCatsOk { get; set; }

        [JsonProperty("coatLength")]
        public string CoatLength { get; set; }

        [JsonProperty("isCurrentVaccinations")]
        public bool IsCurrentVaccinations { get; set; }

        [JsonProperty("isDogsOk")]
        public bool IsDogsOk { get; set; }

        [JsonProperty("isKidsOk")]
        public bool IsKidsOk { get; set; }

        [JsonProperty("newPeopleReaction")]
        public string NewPeopleReaction { get; set; }

        [JsonProperty("ownerExperience")]
        public string OwnerExperience { get; set; }

        [JsonProperty("sizeCurrent")]
        public double SizeCurrent { get; set; }

        [JsonProperty("sizeGroup")]
        public string SizeGroup { get; set; }

        [JsonProperty("sizePotential")]
        public int SizePotential { get; set; }

        [JsonProperty("isSpecialNeeds")]
        public bool IsSpecialNeeds { get; set; }

        [JsonProperty("availableDate")]
        public string AvailableDate { get; set; }

        [JsonProperty("isHousetrained")]
        public bool IsHousetrained { get; set; }

        [JsonProperty("rescueId")]
        public string RescueId { get; set; }

        [JsonProperty("adultSexesOk")]
        public string AdultSexesOk { get; set; }

        [JsonProperty("energyLevel")]
        public string EnergyLevel { get; set; }

        [JsonProperty("fenceNeeds")]
        public string FenceNeeds { get; set; }

        [JsonProperty("groomingNeeds")]
        public string GroomingNeeds { get; set; }

        [JsonProperty("obedienceTraining")]
        public string ObedienceTraining { get; set; }

        [JsonProperty("qualities")]
        public string[] Qualities { get; set; }

        [JsonProperty("vocalLevel")]
        public string VocalLevel { get; set; }

        [JsonProperty("isYardRequired")]
        public bool IsYardRequired { get; set; }

        [JsonProperty("specialNeedsDetails")]
        public string SpecialNeedsDetails { get; set; }

        [JsonProperty("exerciseNeeds")]
        public string ExerciseNeeds { get; set; }

        [JsonProperty("indoorOutdoor")]
        public string IndoorOutdoor { get; set; }

        [JsonProperty("sheddingLevel")]
        public string SheddingLevel { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("isDeclawed")]
        public bool IsDeclawed { get; set; }

        [JsonProperty("earType")]
        public string EarType { get; set; }

        [JsonProperty("eyeColor")]
        public string EyeColor { get; set; }

        [JsonProperty("tailType")]
        public string TailType { get; set; }

        [JsonProperty("killReason")]
        public string KillReason { get; set; }
    }

    public class AnimalResponseDataTypeItemRelationshipsType
    {
        [JsonProperty("breeds")]
        public AnimalResponseDataTypeItemRelationshipsTypeBreedsType Breeds { get; set; }

        [JsonProperty("species")]
        public AnimalResponseDataTypeItemRelationshipsTypeSpeciesType Species { get; set; }

        [JsonProperty("statuses")]
        public AnimalResponseDataTypeItemRelationshipsTypeStatusesType Statuses { get; set; }

        [JsonProperty("locations")]
        public AnimalResponseDataTypeItemRelationshipsTypeLocationsType Locations { get; set; }

        [JsonProperty("orgs")]
        public AnimalResponseDataTypeItemRelationshipsTypeOrgsType Orgs { get; set; }

        [JsonProperty("pictures")]
        public AnimalResponseDataTypeItemRelationshipsTypePicturesType Pictures { get; set; }

        [JsonProperty("colors")]
        public AnimalResponseDataTypeItemRelationshipsTypeColorsType Colors { get; set; }

        [JsonProperty("videourls")]
        public AnimalResponseDataTypeItemRelationshipsTypeVideourlsType Videourls { get; set; }
    }

    public class AnimalResponseDataTypeItemRelationshipsTypeBreedsType
    {
        [JsonProperty("data")]
        public AnimalResponseDataTypeItemRelationshipsTypeBreedsTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalResponseDataTypeItemRelationshipsTypeBreedsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalResponseDataTypeItemRelationshipsTypeSpeciesType
    {
        [JsonProperty("data")]
        public AnimalResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalResponseDataTypeItemRelationshipsTypeStatusesType
    {
        [JsonProperty("data")]
        public AnimalResponseDataTypeItemRelationshipsTypeStatusesTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalResponseDataTypeItemRelationshipsTypeStatusesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalResponseDataTypeItemRelationshipsTypeLocationsType
    {
        [JsonProperty("data")]
        public AnimalResponseDataTypeItemRelationshipsTypeLocationsTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalResponseDataTypeItemRelationshipsTypeLocationsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalResponseDataTypeItemRelationshipsTypeOrgsType
    {
        [JsonProperty("data")]
        public AnimalResponseDataTypeItemRelationshipsTypeOrgsTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalResponseDataTypeItemRelationshipsTypeOrgsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalResponseDataTypeItemRelationshipsTypePicturesType
    {
        [JsonProperty("data")]
        public AnimalResponseDataTypeItemRelationshipsTypePicturesTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalResponseDataTypeItemRelationshipsTypePicturesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalResponseDataTypeItemRelationshipsTypeColorsType
    {
        [JsonProperty("data")]
        public AnimalResponseDataTypeItemRelationshipsTypeColorsTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalResponseDataTypeItemRelationshipsTypeColorsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalResponseDataTypeItemRelationshipsTypeVideourlsType
    {
        [JsonProperty("data")]
        public AnimalResponseDataTypeItemRelationshipsTypeVideourlsTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalResponseDataTypeItemRelationshipsTypeVideourlsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalResponseIncludedTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public AnimalResponseIncludedTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("links")]
        public AnimalResponseIncludedTypeItemLinksType Links { get; set; }
    }

    public class AnimalResponseIncludedTypeItemAttributesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("singular")]
        public string Singular { get; set; }

        [JsonProperty("plural")]
        public string Plural { get; set; }

        [JsonProperty("youngSingular")]
        public string YoungSingular { get; set; }

        [JsonProperty("youngPlural")]
        public string YoungPlural { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("citystate")]
        public string Citystate { get; set; }

        [JsonProperty("postalcode")]
        public string Postalcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("coordinates")]
        public string Coordinates { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("facebookUrl")]
        public string FacebookUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("original")]
        public AnimalResponseIncludedTypeItemAttributesTypeOriginalType Original { get; set; }

        [JsonProperty("large")]
        public AnimalResponseIncludedTypeItemAttributesTypeLargeType Large { get; set; }

        [JsonProperty("small")]
        public AnimalResponseIncludedTypeItemAttributesTypeSmallType Small { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("services")]
        public string Services { get; set; }

        [JsonProperty("adoptionProcess")]
        public string AdoptionProcess { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("adoptionUrl")]
        public string AdoptionUrl { get; set; }

        [JsonProperty("donationUrl")]
        public string DonationUrl { get; set; }

        [JsonProperty("videoId")]
        public string VideoId { get; set; }

        [JsonProperty("urlThumbnail")]
        public string UrlThumbnail { get; set; }
    }

    public class AnimalResponseIncludedTypeItemAttributesTypeOriginalType
    {
        [JsonProperty("filesize")]
        public int Filesize { get; set; }

        [JsonProperty("resolutionX")]
        public int ResolutionX { get; set; }

        [JsonProperty("resolutionY")]
        public int ResolutionY { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AnimalResponseIncludedTypeItemAttributesTypeLargeType
    {
        [JsonProperty("filesize")]
        public int Filesize { get; set; }

        [JsonProperty("resolutionX")]
        public int ResolutionX { get; set; }

        [JsonProperty("resolutionY")]
        public int ResolutionY { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AnimalResponseIncludedTypeItemAttributesTypeSmallType
    {
        [JsonProperty("filesize")]
        public int Filesize { get; set; }

        [JsonProperty("resolutionX")]
        public int ResolutionX { get; set; }

        [JsonProperty("resolutionY")]
        public int ResolutionY { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AnimalResponseIncludedTypeItemLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class AnimalStatusResponse
    {
        [JsonProperty("meta")]
        public AnimalStatusResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public AnimalStatusResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("included")]
        public AnimalStatusResponseIncludedTypeItem[] Included { get; set; }
    }

    public class AnimalStatusResponseMetaType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("countReturned")]
        public int CountReturned { get; set; }

        [JsonProperty("pageReturned")]
        public int PageReturned { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }

    public class AnimalStatusResponseDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public AnimalStatusResponseDataTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("relationships")]
        public AnimalStatusResponseDataTypeItemRelationshipsType Relationships { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemAttributesType
    {
        [JsonProperty("isAdoptionPending")]
        public bool IsAdoptionPending { get; set; }

        [JsonProperty("ageGroup")]
        public string AgeGroup { get; set; }

        [JsonProperty("ageString")]
        public string AgeString { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("isBirthDateExact")]
        public bool IsBirthDateExact { get; set; }

        [JsonProperty("breedString")]
        public string BreedString { get; set; }

        [JsonProperty("breedPrimary")]
        public string BreedPrimary { get; set; }

        [JsonProperty("breedPrimaryId")]
        public int BreedPrimaryId { get; set; }

        [JsonProperty("breedSecondary")]
        public string BreedSecondary { get; set; }

        [JsonProperty("breedSecondaryId")]
        public int BreedSecondaryId { get; set; }

        [JsonProperty("coatLength")]
        public string CoatLength { get; set; }

        [JsonProperty("isCourtesyListing")]
        public bool IsCourtesyListing { get; set; }

        [JsonProperty("descriptionHtml")]
        public string DescriptionHtml { get; set; }

        [JsonProperty("descriptionText")]
        public string DescriptionText { get; set; }

        [JsonProperty("isNeedingFoster")]
        public bool IsNeedingFoster { get; set; }

        [JsonProperty("isFound")]
        public bool IsFound { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pictureCount")]
        public int PictureCount { get; set; }

        [JsonProperty("pictureThumbnailUrl")]
        public string PictureThumbnailUrl { get; set; }

        [JsonProperty("rescueId")]
        public string RescueId { get; set; }

        [JsonProperty("searchString")]
        public string SearchString { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("sizeCurrent")]
        public double SizeCurrent { get; set; }

        [JsonProperty("sizeUOM")]
        public string SizeUOM { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("isSponsorable")]
        public bool IsSponsorable { get; set; }

        [JsonProperty("trackerimageUrl")]
        public string TrackerimageUrl { get; set; }

        [JsonProperty("videoCount")]
        public int VideoCount { get; set; }

        [JsonProperty("videoUrlCount")]
        public int VideoUrlCount { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("isBreedMixed")]
        public bool IsBreedMixed { get; set; }

        [JsonProperty("isCatsOk")]
        public bool IsCatsOk { get; set; }

        [JsonProperty("isCurrentVaccinations")]
        public bool IsCurrentVaccinations { get; set; }

        [JsonProperty("isDeclawed")]
        public bool IsDeclawed { get; set; }

        [JsonProperty("isDogsOk")]
        public bool IsDogsOk { get; set; }

        [JsonProperty("isHousetrained")]
        public bool IsHousetrained { get; set; }

        [JsonProperty("isKidsOk")]
        public bool IsKidsOk { get; set; }

        [JsonProperty("sizeGroup")]
        public string SizeGroup { get; set; }

        [JsonProperty("activityLevel")]
        public string ActivityLevel { get; set; }

        [JsonProperty("energyLevel")]
        public string EnergyLevel { get; set; }

        [JsonProperty("indoorOutdoor")]
        public string IndoorOutdoor { get; set; }

        [JsonProperty("newPeopleReaction")]
        public string NewPeopleReaction { get; set; }

        [JsonProperty("adoptionFeeString")]
        public string AdoptionFeeString { get; set; }

        [JsonProperty("adultSexesOk")]
        public string AdultSexesOk { get; set; }

        [JsonProperty("exerciseNeeds")]
        public string ExerciseNeeds { get; set; }

        [JsonProperty("fenceNeeds")]
        public string FenceNeeds { get; set; }

        [JsonProperty("groomingNeeds")]
        public string GroomingNeeds { get; set; }

        [JsonProperty("obedienceTraining")]
        public string ObedienceTraining { get; set; }

        [JsonProperty("ownerExperience")]
        public string OwnerExperience { get; set; }

        [JsonProperty("sheddingLevel")]
        public string SheddingLevel { get; set; }

        [JsonProperty("isSpecialNeeds")]
        public bool IsSpecialNeeds { get; set; }

        [JsonProperty("vocalLevel")]
        public string VocalLevel { get; set; }

        [JsonProperty("isYardRequired")]
        public bool IsYardRequired { get; set; }

        [JsonProperty("colorDetails")]
        public string ColorDetails { get; set; }

        [JsonProperty("eyeColor")]
        public string EyeColor { get; set; }

        [JsonProperty("killReason")]
        public string KillReason { get; set; }

        [JsonProperty("qualities")]
        public string[] Qualities { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("sponsorshipMinimum")]
        public string SponsorshipMinimum { get; set; }

        [JsonProperty("sponsors")]
        public string Sponsors { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("foundDate")]
        public string FoundDate { get; set; }

        [JsonProperty("availableDate")]
        public string AvailableDate { get; set; }

        [JsonProperty("adoptedDate")]
        public string AdoptedDate { get; set; }

        [JsonProperty("sizePotential")]
        public int SizePotential { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsType
    {
        [JsonProperty("breeds")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypeBreedsType Breeds { get; set; }

        [JsonProperty("colors")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypeColorsType Colors { get; set; }

        [JsonProperty("patterns")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypePatternsType Patterns { get; set; }

        [JsonProperty("species")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypeSpeciesType Species { get; set; }

        [JsonProperty("statuses")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypeStatusesType Statuses { get; set; }

        [JsonProperty("locations")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypeLocationsType Locations { get; set; }

        [JsonProperty("orgs")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypeOrgsType Orgs { get; set; }

        [JsonProperty("pictures")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypePicturesType Pictures { get; set; }

        [JsonProperty("fosters")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypeFostersType Fosters { get; set; }

        [JsonProperty("videos")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypeVideosType Videos { get; set; }

        [JsonProperty("videourls")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypeVideourlsType Videourls { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypeBreedsType
    {
        [JsonProperty("data")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypeBreedsTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypeBreedsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypeColorsType
    {
        [JsonProperty("data")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypeColorsTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypeColorsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypePatternsType
    {
        [JsonProperty("data")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypePatternsTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypePatternsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypeSpeciesType
    {
        [JsonProperty("data")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypeStatusesType
    {
        [JsonProperty("data")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypeStatusesTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypeStatusesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypeLocationsType
    {
        [JsonProperty("data")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypeLocationsTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypeLocationsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypeOrgsType
    {
        [JsonProperty("data")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypeOrgsTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypeOrgsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypePicturesType
    {
        [JsonProperty("data")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypePicturesTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypePicturesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypeFostersType
    {
        [JsonProperty("data")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypeFostersTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypeFostersTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypeVideosType
    {
        [JsonProperty("data")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypeVideosTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypeVideosTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypeVideourlsType
    {
        [JsonProperty("data")]
        public AnimalStatusResponseDataTypeItemRelationshipsTypeVideourlsTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalStatusResponseDataTypeItemRelationshipsTypeVideourlsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalStatusResponseIncludedTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public AnimalStatusResponseIncludedTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("links")]
        public AnimalStatusResponseIncludedTypeItemLinksType Links { get; set; }
    }

    public class AnimalStatusResponseIncludedTypeItemAttributesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("singular")]
        public string Singular { get; set; }

        [JsonProperty("plural")]
        public string Plural { get; set; }

        [JsonProperty("youngSingular")]
        public string YoungSingular { get; set; }

        [JsonProperty("youngPlural")]
        public string YoungPlural { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("citystate")]
        public string Citystate { get; set; }

        [JsonProperty("postalcode")]
        public string Postalcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("coordinates")]
        public string Coordinates { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("facebookUrl")]
        public string FacebookUrl { get; set; }

        [JsonProperty("adoptionProcess")]
        public string AdoptionProcess { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("services")]
        public string Services { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("original")]
        public AnimalStatusResponseIncludedTypeItemAttributesTypeOriginalType Original { get; set; }

        [JsonProperty("large")]
        public AnimalStatusResponseIncludedTypeItemAttributesTypeLargeType Large { get; set; }

        [JsonProperty("small")]
        public AnimalStatusResponseIncludedTypeItemAttributesTypeSmallType Small { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("fullname")]
        public string Fullname { get; set; }

        [JsonProperty("adoptionUrl")]
        public string AdoptionUrl { get; set; }

        [JsonProperty("donationUrl")]
        public string DonationUrl { get; set; }

        [JsonProperty("sponsorshipUrl")]
        public string SponsorshipUrl { get; set; }

        [JsonProperty("fileSize")]
        public int FileSize { get; set; }

        [JsonProperty("videoId")]
        public string VideoId { get; set; }

        [JsonProperty("urlThumbnail")]
        public string UrlThumbnail { get; set; }
    }

    public class AnimalStatusResponseIncludedTypeItemAttributesTypeOriginalType
    {
        [JsonProperty("filesize")]
        public int Filesize { get; set; }

        [JsonProperty("resolutionX")]
        public int ResolutionX { get; set; }

        [JsonProperty("resolutionY")]
        public int ResolutionY { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AnimalStatusResponseIncludedTypeItemAttributesTypeLargeType
    {
        [JsonProperty("filesize")]
        public int Filesize { get; set; }

        [JsonProperty("resolutionX")]
        public int ResolutionX { get; set; }

        [JsonProperty("resolutionY")]
        public int ResolutionY { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AnimalStatusResponseIncludedTypeItemAttributesTypeSmallType
    {
        [JsonProperty("filesize")]
        public int Filesize { get; set; }

        [JsonProperty("resolutionX")]
        public int ResolutionX { get; set; }

        [JsonProperty("resolutionY")]
        public int ResolutionY { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AnimalStatusResponseIncludedTypeItemLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class AnimalIDResponse
    {
        [JsonProperty("meta")]
        public AnimalIDResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public AnimalIDResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("included")]
        public AnimalIDResponseIncludedTypeItem[] Included { get; set; }
    }

    public class AnimalIDResponseMetaType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("countReturned")]
        public int CountReturned { get; set; }

        [JsonProperty("pageReturned")]
        public int PageReturned { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }

    public class AnimalIDResponseDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public AnimalIDResponseDataTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("relationships")]
        public AnimalIDResponseDataTypeItemRelationshipsType Relationships { get; set; }
    }

    public class AnimalIDResponseDataTypeItemAttributesType
    {
        [JsonProperty("isAdoptionPending")]
        public bool IsAdoptionPending { get; set; }

        [JsonProperty("ageGroup")]
        public string AgeGroup { get; set; }

        [JsonProperty("ageString")]
        public string AgeString { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("isBirthDateExact")]
        public bool IsBirthDateExact { get; set; }

        [JsonProperty("breedString")]
        public string BreedString { get; set; }

        [JsonProperty("breedPrimary")]
        public string BreedPrimary { get; set; }

        [JsonProperty("breedPrimaryId")]
        public int BreedPrimaryId { get; set; }

        [JsonProperty("breedSecondary")]
        public string BreedSecondary { get; set; }

        [JsonProperty("breedSecondaryId")]
        public int BreedSecondaryId { get; set; }

        [JsonProperty("coatLength")]
        public string CoatLength { get; set; }

        [JsonProperty("isCourtesyListing")]
        public bool IsCourtesyListing { get; set; }

        [JsonProperty("descriptionHtml")]
        public string DescriptionHtml { get; set; }

        [JsonProperty("descriptionText")]
        public string DescriptionText { get; set; }

        [JsonProperty("isNeedingFoster")]
        public bool IsNeedingFoster { get; set; }

        [JsonProperty("isFound")]
        public bool IsFound { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pictureCount")]
        public int PictureCount { get; set; }

        [JsonProperty("pictureThumbnailUrl")]
        public string PictureThumbnailUrl { get; set; }

        [JsonProperty("rescueId")]
        public string RescueId { get; set; }

        [JsonProperty("searchString")]
        public string SearchString { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("sizeCurrent")]
        public double SizeCurrent { get; set; }

        [JsonProperty("sizeUOM")]
        public string SizeUOM { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("isSponsorable")]
        public bool IsSponsorable { get; set; }

        [JsonProperty("trackerimageUrl")]
        public string TrackerimageUrl { get; set; }

        [JsonProperty("videoCount")]
        public int VideoCount { get; set; }

        [JsonProperty("videoUrlCount")]
        public int VideoUrlCount { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class AnimalIDResponseDataTypeItemRelationshipsType
    {
        [JsonProperty("breeds")]
        public AnimalIDResponseDataTypeItemRelationshipsTypeBreedsType Breeds { get; set; }

        [JsonProperty("colors")]
        public AnimalIDResponseDataTypeItemRelationshipsTypeColorsType Colors { get; set; }

        [JsonProperty("patterns")]
        public AnimalIDResponseDataTypeItemRelationshipsTypePatternsType Patterns { get; set; }

        [JsonProperty("species")]
        public AnimalIDResponseDataTypeItemRelationshipsTypeSpeciesType Species { get; set; }

        [JsonProperty("statuses")]
        public AnimalIDResponseDataTypeItemRelationshipsTypeStatusesType Statuses { get; set; }

        [JsonProperty("locations")]
        public AnimalIDResponseDataTypeItemRelationshipsTypeLocationsType Locations { get; set; }

        [JsonProperty("orgs")]
        public AnimalIDResponseDataTypeItemRelationshipsTypeOrgsType Orgs { get; set; }

        [JsonProperty("pictures")]
        public AnimalIDResponseDataTypeItemRelationshipsTypePicturesType Pictures { get; set; }
    }

    public class AnimalIDResponseDataTypeItemRelationshipsTypeBreedsType
    {
        [JsonProperty("data")]
        public AnimalIDResponseDataTypeItemRelationshipsTypeBreedsTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalIDResponseDataTypeItemRelationshipsTypeBreedsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalIDResponseDataTypeItemRelationshipsTypeColorsType
    {
        [JsonProperty("data")]
        public AnimalIDResponseDataTypeItemRelationshipsTypeColorsTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalIDResponseDataTypeItemRelationshipsTypeColorsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalIDResponseDataTypeItemRelationshipsTypePatternsType
    {
        [JsonProperty("data")]
        public AnimalIDResponseDataTypeItemRelationshipsTypePatternsTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalIDResponseDataTypeItemRelationshipsTypePatternsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalIDResponseDataTypeItemRelationshipsTypeSpeciesType
    {
        [JsonProperty("data")]
        public AnimalIDResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalIDResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalIDResponseDataTypeItemRelationshipsTypeStatusesType
    {
        [JsonProperty("data")]
        public AnimalIDResponseDataTypeItemRelationshipsTypeStatusesTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalIDResponseDataTypeItemRelationshipsTypeStatusesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalIDResponseDataTypeItemRelationshipsTypeLocationsType
    {
        [JsonProperty("data")]
        public AnimalIDResponseDataTypeItemRelationshipsTypeLocationsTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalIDResponseDataTypeItemRelationshipsTypeLocationsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalIDResponseDataTypeItemRelationshipsTypeOrgsType
    {
        [JsonProperty("data")]
        public AnimalIDResponseDataTypeItemRelationshipsTypeOrgsTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalIDResponseDataTypeItemRelationshipsTypeOrgsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalIDResponseDataTypeItemRelationshipsTypePicturesType
    {
        [JsonProperty("data")]
        public AnimalIDResponseDataTypeItemRelationshipsTypePicturesTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalIDResponseDataTypeItemRelationshipsTypePicturesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalIDResponseIncludedTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public AnimalIDResponseIncludedTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("links")]
        public AnimalIDResponseIncludedTypeItemLinksType Links { get; set; }
    }

    public class AnimalIDResponseIncludedTypeItemAttributesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("singular")]
        public string Singular { get; set; }

        [JsonProperty("plural")]
        public string Plural { get; set; }

        [JsonProperty("youngSingular")]
        public string YoungSingular { get; set; }

        [JsonProperty("youngPlural")]
        public string YoungPlural { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("citystate")]
        public string Citystate { get; set; }

        [JsonProperty("postalcode")]
        public string Postalcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("coordinates")]
        public string Coordinates { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("facebookUrl")]
        public string FacebookUrl { get; set; }

        [JsonProperty("adoptionProcess")]
        public string AdoptionProcess { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("services")]
        public string Services { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("original")]
        public AnimalIDResponseIncludedTypeItemAttributesTypeOriginalType Original { get; set; }

        [JsonProperty("large")]
        public AnimalIDResponseIncludedTypeItemAttributesTypeLargeType Large { get; set; }

        [JsonProperty("small")]
        public AnimalIDResponseIncludedTypeItemAttributesTypeSmallType Small { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class AnimalIDResponseIncludedTypeItemAttributesTypeOriginalType
    {
        [JsonProperty("filesize")]
        public int Filesize { get; set; }

        [JsonProperty("resolutionX")]
        public int ResolutionX { get; set; }

        [JsonProperty("resolutionY")]
        public int ResolutionY { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AnimalIDResponseIncludedTypeItemAttributesTypeLargeType
    {
        [JsonProperty("filesize")]
        public int Filesize { get; set; }

        [JsonProperty("resolutionX")]
        public int ResolutionX { get; set; }

        [JsonProperty("resolutionY")]
        public int ResolutionY { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AnimalIDResponseIncludedTypeItemAttributesTypeSmallType
    {
        [JsonProperty("filesize")]
        public int Filesize { get; set; }

        [JsonProperty("resolutionX")]
        public int ResolutionX { get; set; }

        [JsonProperty("resolutionY")]
        public int ResolutionY { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AnimalIDResponseIncludedTypeItemLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class OrganizationAnimalResponse
    {
        [JsonProperty("meta")]
        public OrganizationAnimalResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public OrganizationAnimalResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("included")]
        public OrganizationAnimalResponseIncludedTypeItem[] Included { get; set; }
    }

    public class OrganizationAnimalResponseMetaType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("countReturned")]
        public int CountReturned { get; set; }

        [JsonProperty("pageReturned")]
        public int PageReturned { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }

    public class OrganizationAnimalResponseDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public OrganizationAnimalResponseDataTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("relationships")]
        public OrganizationAnimalResponseDataTypeItemRelationshipsType Relationships { get; set; }
    }

    public class OrganizationAnimalResponseDataTypeItemAttributesType
    {
        [JsonProperty("activityLevel")]
        public string ActivityLevel { get; set; }

        [JsonProperty("isAdoptionPending")]
        public bool IsAdoptionPending { get; set; }

        [JsonProperty("ageString")]
        public string AgeString { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("isBirthDateExact")]
        public bool IsBirthDateExact { get; set; }

        [JsonProperty("breedString")]
        public string BreedString { get; set; }

        [JsonProperty("breedPrimary")]
        public string BreedPrimary { get; set; }

        [JsonProperty("breedPrimaryId")]
        public int BreedPrimaryId { get; set; }

        [JsonProperty("isBreedMixed")]
        public bool IsBreedMixed { get; set; }

        [JsonProperty("isCatsOk")]
        public bool IsCatsOk { get; set; }

        [JsonProperty("coatLength")]
        public string CoatLength { get; set; }

        [JsonProperty("colorDetails")]
        public string ColorDetails { get; set; }

        [JsonProperty("isCourtesyListing")]
        public bool IsCourtesyListing { get; set; }

        [JsonProperty("isCurrentVaccinations")]
        public bool IsCurrentVaccinations { get; set; }

        [JsonProperty("isDeclawed")]
        public bool IsDeclawed { get; set; }

        [JsonProperty("descriptionHtml")]
        public string DescriptionHtml { get; set; }

        [JsonProperty("descriptionText")]
        public string DescriptionText { get; set; }

        [JsonProperty("isNeedingFoster")]
        public bool IsNeedingFoster { get; set; }

        [JsonProperty("isFound")]
        public bool IsFound { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("indoorOutdoor")]
        public string IndoorOutdoor { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("newPeopleReaction")]
        public string NewPeopleReaction { get; set; }

        [JsonProperty("ownerExperience")]
        public string OwnerExperience { get; set; }

        [JsonProperty("pictureCount")]
        public int PictureCount { get; set; }

        [JsonProperty("pictureThumbnailUrl")]
        public string PictureThumbnailUrl { get; set; }

        [JsonProperty("searchString")]
        public string SearchString { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("sizeGroup")]
        public string SizeGroup { get; set; }

        [JsonProperty("sizeUOM")]
        public string SizeUOM { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("isSpecialNeeds")]
        public bool IsSpecialNeeds { get; set; }

        [JsonProperty("isSponsorable")]
        public bool IsSponsorable { get; set; }

        [JsonProperty("trackerimageUrl")]
        public string TrackerimageUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("videoCount")]
        public int VideoCount { get; set; }

        [JsonProperty("videoUrlCount")]
        public int VideoUrlCount { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("ageGroup")]
        public string AgeGroup { get; set; }

        [JsonProperty("breedSecondary")]
        public string BreedSecondary { get; set; }

        [JsonProperty("breedSecondaryId")]
        public int BreedSecondaryId { get; set; }

        [JsonProperty("isKidsOk")]
        public bool IsKidsOk { get; set; }

        [JsonProperty("isDogsOk")]
        public bool IsDogsOk { get; set; }

        [JsonProperty("adoptedDate")]
        public string AdoptedDate { get; set; }

        [JsonProperty("sizeCurrent")]
        public double SizeCurrent { get; set; }
    }

    public class OrganizationAnimalResponseDataTypeItemRelationshipsType
    {
        [JsonProperty("breeds")]
        public OrganizationAnimalResponseDataTypeItemRelationshipsTypeBreedsType Breeds { get; set; }

        [JsonProperty("colors")]
        public OrganizationAnimalResponseDataTypeItemRelationshipsTypeColorsType Colors { get; set; }

        [JsonProperty("species")]
        public OrganizationAnimalResponseDataTypeItemRelationshipsTypeSpeciesType Species { get; set; }

        [JsonProperty("statuses")]
        public OrganizationAnimalResponseDataTypeItemRelationshipsTypeStatusesType Statuses { get; set; }

        [JsonProperty("locations")]
        public OrganizationAnimalResponseDataTypeItemRelationshipsTypeLocationsType Locations { get; set; }

        [JsonProperty("orgs")]
        public OrganizationAnimalResponseDataTypeItemRelationshipsTypeOrgsType Orgs { get; set; }

        [JsonProperty("pictures")]
        public OrganizationAnimalResponseDataTypeItemRelationshipsTypePicturesType Pictures { get; set; }

        [JsonProperty("patterns")]
        public OrganizationAnimalResponseDataTypeItemRelationshipsTypePatternsType Patterns { get; set; }
    }

    public class OrganizationAnimalResponseDataTypeItemRelationshipsTypeBreedsType
    {
        [JsonProperty("data")]
        public OrganizationAnimalResponseDataTypeItemRelationshipsTypeBreedsTypeDataTypeItem[] Data { get; set; }
    }

    public class OrganizationAnimalResponseDataTypeItemRelationshipsTypeBreedsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class OrganizationAnimalResponseDataTypeItemRelationshipsTypeColorsType
    {
        [JsonProperty("data")]
        public OrganizationAnimalResponseDataTypeItemRelationshipsTypeColorsTypeDataTypeItem[] Data { get; set; }
    }

    public class OrganizationAnimalResponseDataTypeItemRelationshipsTypeColorsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class OrganizationAnimalResponseDataTypeItemRelationshipsTypeSpeciesType
    {
        [JsonProperty("data")]
        public OrganizationAnimalResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem[] Data { get; set; }
    }

    public class OrganizationAnimalResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class OrganizationAnimalResponseDataTypeItemRelationshipsTypeStatusesType
    {
        [JsonProperty("data")]
        public OrganizationAnimalResponseDataTypeItemRelationshipsTypeStatusesTypeDataTypeItem[] Data { get; set; }
    }

    public class OrganizationAnimalResponseDataTypeItemRelationshipsTypeStatusesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class OrganizationAnimalResponseDataTypeItemRelationshipsTypeLocationsType
    {
        [JsonProperty("data")]
        public OrganizationAnimalResponseDataTypeItemRelationshipsTypeLocationsTypeDataTypeItem[] Data { get; set; }
    }

    public class OrganizationAnimalResponseDataTypeItemRelationshipsTypeLocationsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class OrganizationAnimalResponseDataTypeItemRelationshipsTypeOrgsType
    {
        [JsonProperty("data")]
        public OrganizationAnimalResponseDataTypeItemRelationshipsTypeOrgsTypeDataTypeItem[] Data { get; set; }
    }

    public class OrganizationAnimalResponseDataTypeItemRelationshipsTypeOrgsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class OrganizationAnimalResponseDataTypeItemRelationshipsTypePicturesType
    {
        [JsonProperty("data")]
        public OrganizationAnimalResponseDataTypeItemRelationshipsTypePicturesTypeDataTypeItem[] Data { get; set; }
    }

    public class OrganizationAnimalResponseDataTypeItemRelationshipsTypePicturesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class OrganizationAnimalResponseDataTypeItemRelationshipsTypePatternsType
    {
        [JsonProperty("data")]
        public OrganizationAnimalResponseDataTypeItemRelationshipsTypePatternsTypeDataTypeItem[] Data { get; set; }
    }

    public class OrganizationAnimalResponseDataTypeItemRelationshipsTypePatternsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class OrganizationAnimalResponseIncludedTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public OrganizationAnimalResponseIncludedTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("links")]
        public OrganizationAnimalResponseIncludedTypeItemLinksType Links { get; set; }
    }

    public class OrganizationAnimalResponseIncludedTypeItemAttributesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("singular")]
        public string Singular { get; set; }

        [JsonProperty("plural")]
        public string Plural { get; set; }

        [JsonProperty("youngSingular")]
        public string YoungSingular { get; set; }

        [JsonProperty("youngPlural")]
        public string YoungPlural { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("citystate")]
        public string Citystate { get; set; }

        [JsonProperty("postalcode")]
        public string Postalcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("coordinates")]
        public string Coordinates { get; set; }

        [JsonProperty("postalcodePlus4")]
        public string PostalcodePlus4 { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("facebookUrl")]
        public string FacebookUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("original")]
        public OrganizationAnimalResponseIncludedTypeItemAttributesTypeOriginalType Original { get; set; }

        [JsonProperty("large")]
        public OrganizationAnimalResponseIncludedTypeItemAttributesTypeLargeType Large { get; set; }

        [JsonProperty("small")]
        public OrganizationAnimalResponseIncludedTypeItemAttributesTypeSmallType Small { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class OrganizationAnimalResponseIncludedTypeItemAttributesTypeOriginalType
    {
        [JsonProperty("filesize")]
        public int Filesize { get; set; }

        [JsonProperty("resolutionX")]
        public int ResolutionX { get; set; }

        [JsonProperty("resolutionY")]
        public int ResolutionY { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class OrganizationAnimalResponseIncludedTypeItemAttributesTypeLargeType
    {
        [JsonProperty("filesize")]
        public int Filesize { get; set; }

        [JsonProperty("resolutionX")]
        public int ResolutionX { get; set; }

        [JsonProperty("resolutionY")]
        public int ResolutionY { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class OrganizationAnimalResponseIncludedTypeItemAttributesTypeSmallType
    {
        [JsonProperty("filesize")]
        public int Filesize { get; set; }

        [JsonProperty("resolutionX")]
        public int ResolutionX { get; set; }

        [JsonProperty("resolutionY")]
        public int ResolutionY { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class OrganizationAnimalResponseIncludedTypeItemLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class OrganizationAnimalStatusResponse
    {
        [JsonProperty("meta")]
        public OrganizationAnimalStatusResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public OrganizationAnimalStatusResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("included")]
        public OrganizationAnimalStatusResponseIncludedTypeItem[] Included { get; set; }
    }

    public class OrganizationAnimalStatusResponseMetaType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("countReturned")]
        public int CountReturned { get; set; }

        [JsonProperty("pageReturned")]
        public int PageReturned { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }

    public class OrganizationAnimalStatusResponseDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public OrganizationAnimalStatusResponseDataTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("relationships")]
        public OrganizationAnimalStatusResponseDataTypeItemRelationshipsType Relationships { get; set; }
    }

    public class OrganizationAnimalStatusResponseDataTypeItemAttributesType
    {
        [JsonProperty("activityLevel")]
        public string ActivityLevel { get; set; }

        [JsonProperty("isAdoptionPending")]
        public bool IsAdoptionPending { get; set; }

        [JsonProperty("ageGroup")]
        public string AgeGroup { get; set; }

        [JsonProperty("ageString")]
        public string AgeString { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("isBirthDateExact")]
        public bool IsBirthDateExact { get; set; }

        [JsonProperty("breedString")]
        public string BreedString { get; set; }

        [JsonProperty("breedPrimary")]
        public string BreedPrimary { get; set; }

        [JsonProperty("breedPrimaryId")]
        public int BreedPrimaryId { get; set; }

        [JsonProperty("isBreedMixed")]
        public bool IsBreedMixed { get; set; }

        [JsonProperty("coatLength")]
        public string CoatLength { get; set; }

        [JsonProperty("colorDetails")]
        public string ColorDetails { get; set; }

        [JsonProperty("isCourtesyListing")]
        public bool IsCourtesyListing { get; set; }

        [JsonProperty("isCurrentVaccinations")]
        public bool IsCurrentVaccinations { get; set; }

        [JsonProperty("descriptionHtml")]
        public string DescriptionHtml { get; set; }

        [JsonProperty("descriptionText")]
        public string DescriptionText { get; set; }

        [JsonProperty("isNeedingFoster")]
        public bool IsNeedingFoster { get; set; }

        [JsonProperty("isFound")]
        public bool IsFound { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("indoorOutdoor")]
        public string IndoorOutdoor { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pictureCount")]
        public int PictureCount { get; set; }

        [JsonProperty("pictureThumbnailUrl")]
        public string PictureThumbnailUrl { get; set; }

        [JsonProperty("searchString")]
        public string SearchString { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("sizeGroup")]
        public string SizeGroup { get; set; }

        [JsonProperty("sizeUOM")]
        public string SizeUOM { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("isSpecialNeeds")]
        public bool IsSpecialNeeds { get; set; }

        [JsonProperty("isSponsorable")]
        public bool IsSponsorable { get; set; }

        [JsonProperty("trackerimageUrl")]
        public string TrackerimageUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("videoCount")]
        public int VideoCount { get; set; }

        [JsonProperty("videoUrlCount")]
        public int VideoUrlCount { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class OrganizationAnimalStatusResponseDataTypeItemRelationshipsType
    {
        [JsonProperty("breeds")]
        public OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeBreedsType Breeds { get; set; }

        [JsonProperty("colors")]
        public OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeColorsType Colors { get; set; }

        [JsonProperty("patterns")]
        public OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypePatternsType Patterns { get; set; }

        [JsonProperty("species")]
        public OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeSpeciesType Species { get; set; }

        [JsonProperty("statuses")]
        public OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeStatusesType Statuses { get; set; }

        [JsonProperty("locations")]
        public OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeLocationsType Locations { get; set; }

        [JsonProperty("orgs")]
        public OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeOrgsType Orgs { get; set; }

        [JsonProperty("pictures")]
        public OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypePicturesType Pictures { get; set; }
    }

    public class OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeBreedsType
    {
        [JsonProperty("data")]
        public OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeBreedsTypeDataTypeItem[] Data { get; set; }
    }

    public class OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeBreedsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeColorsType
    {
        [JsonProperty("data")]
        public OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeColorsTypeDataTypeItem[] Data { get; set; }
    }

    public class OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeColorsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypePatternsType
    {
        [JsonProperty("data")]
        public OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypePatternsTypeDataTypeItem[] Data { get; set; }
    }

    public class OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypePatternsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeSpeciesType
    {
        [JsonProperty("data")]
        public OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem[] Data { get; set; }
    }

    public class OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeStatusesType
    {
        [JsonProperty("data")]
        public OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeStatusesTypeDataTypeItem[] Data { get; set; }
    }

    public class OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeStatusesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeLocationsType
    {
        [JsonProperty("data")]
        public OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeLocationsTypeDataTypeItem[] Data { get; set; }
    }

    public class OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeLocationsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeOrgsType
    {
        [JsonProperty("data")]
        public OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeOrgsTypeDataTypeItem[] Data { get; set; }
    }

    public class OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypeOrgsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypePicturesType
    {
        [JsonProperty("data")]
        public OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypePicturesTypeDataTypeItem[] Data { get; set; }
    }

    public class OrganizationAnimalStatusResponseDataTypeItemRelationshipsTypePicturesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class OrganizationAnimalStatusResponseIncludedTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public OrganizationAnimalStatusResponseIncludedTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("links")]
        public OrganizationAnimalStatusResponseIncludedTypeItemLinksType Links { get; set; }
    }

    public class OrganizationAnimalStatusResponseIncludedTypeItemAttributesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("singular")]
        public string Singular { get; set; }

        [JsonProperty("plural")]
        public string Plural { get; set; }

        [JsonProperty("youngSingular")]
        public string YoungSingular { get; set; }

        [JsonProperty("youngPlural")]
        public string YoungPlural { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("citystate")]
        public string Citystate { get; set; }

        [JsonProperty("postalcode")]
        public string Postalcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("coordinates")]
        public string Coordinates { get; set; }

        [JsonProperty("postalcodePlus4")]
        public string PostalcodePlus4 { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("facebookUrl")]
        public string FacebookUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("original")]
        public OrganizationAnimalStatusResponseIncludedTypeItemAttributesTypeOriginalType Original { get; set; }

        [JsonProperty("large")]
        public OrganizationAnimalStatusResponseIncludedTypeItemAttributesTypeLargeType Large { get; set; }

        [JsonProperty("small")]
        public OrganizationAnimalStatusResponseIncludedTypeItemAttributesTypeSmallType Small { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class OrganizationAnimalStatusResponseIncludedTypeItemAttributesTypeOriginalType
    {
        [JsonProperty("filesize")]
        public int Filesize { get; set; }

        [JsonProperty("resolutionX")]
        public int ResolutionX { get; set; }

        [JsonProperty("resolutionY")]
        public int ResolutionY { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class OrganizationAnimalStatusResponseIncludedTypeItemAttributesTypeLargeType
    {
        [JsonProperty("filesize")]
        public int Filesize { get; set; }

        [JsonProperty("resolutionX")]
        public int ResolutionX { get; set; }

        [JsonProperty("resolutionY")]
        public int ResolutionY { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class OrganizationAnimalStatusResponseIncludedTypeItemAttributesTypeSmallType
    {
        [JsonProperty("filesize")]
        public int Filesize { get; set; }

        [JsonProperty("resolutionX")]
        public int ResolutionX { get; set; }

        [JsonProperty("resolutionY")]
        public int ResolutionY { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class OrganizationAnimalStatusResponseIncludedTypeItemLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Rescuegroupsip;

    public partial class WorkflowManagedActions
    {
        public RescuegroupsipActions Rescuegroupsip(string connectionId) => new RescuegroupsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RescuegroupsipTriggers Rescuegroupsip(string connectionId) => new RescuegroupsipTriggers(connectionId);
    }
}