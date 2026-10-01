//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rescuegroupsip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RescuegroupsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        public IBodyWorkflowAction<BreedResponse> Breed([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public/animals/breeds/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<BreedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        public IBodyWorkflowAction<BreedIdResponse> BreedId([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/animals/breeds/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BreedIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        public IBodyWorkflowAction<BreedSpeciesResponse> BreedSpecies([WorkflowExpression] Func<string> species, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/animals/breeds/search/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(species, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<BreedSpeciesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        public IBodyWorkflowAction<BreedSpeciesIdResponse> BreedSpeciesId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/animals/species/{0}/breeds/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<BreedSpeciesIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        public IBodyWorkflowAction<OrganizationResponse> Organization([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public/orgs/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<OrganizationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        public IBodyWorkflowAction<OrganizationIdResponse> OrganizationId([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/orgs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<OrganizationIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        public IBodyWorkflowAction<AnimalResponse> Animal([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public/animals/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<AnimalResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        public IBodyWorkflowAction<AnimalStatusResponse> AnimalStatus([WorkflowExpression] Func<string> status, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/animals/search/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(status, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<AnimalStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        public IBodyWorkflowAction<AnimalIdResponse> AnimalId([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/animals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AnimalIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        public IBodyWorkflowAction<OrganizationAnimalResponse> OrganizationAnimal([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/orgs/{0}/animals/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<OrganizationAnimalResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescuegroupsip")]
        public IBodyWorkflowAction<OrganizationAnimalStatusResponse> OrganizationAnimalStatus([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> status, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/orgs/{0}/animals/search/{1}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(status, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<OrganizationAnimalStatusResponse>(BuildSourceInput);
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

    public class BreedIdResponse
    {
        [JsonProperty("meta")]
        public BreedIdResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public BreedIdResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("included")]
        public BreedIdResponseIncludedTypeItem[] Included { get; set; }

        [JsonProperty("links")]
        public BreedIdResponseLinksType Links { get; set; }
    }

    public class BreedIdResponseMetaType
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

    public class BreedIdResponseDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public BreedIdResponseDataTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("relationships")]
        public BreedIdResponseDataTypeItemRelationshipsType Relationships { get; set; }
    }

    public class BreedIdResponseDataTypeItemAttributesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class BreedIdResponseDataTypeItemRelationshipsType
    {
        [JsonProperty("species")]
        public BreedIdResponseDataTypeItemRelationshipsTypeSpeciesType Species { get; set; }
    }

    public class BreedIdResponseDataTypeItemRelationshipsTypeSpeciesType
    {
        [JsonProperty("data")]
        public BreedIdResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public BreedIdResponseDataTypeItemRelationshipsTypeSpeciesTypeLinksType Links { get; set; }
    }

    public class BreedIdResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("links")]
        public BreedIdResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItemLinksType Links { get; set; }
    }

    public class BreedIdResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItemLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class BreedIdResponseDataTypeItemRelationshipsTypeSpeciesTypeLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class BreedIdResponseIncludedTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public BreedIdResponseIncludedTypeItemAttributesType Attributes { get; set; }
    }

    public class BreedIdResponseIncludedTypeItemAttributesType
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

    public class BreedIdResponseLinksType
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

    public class BreedSpeciesIdResponse
    {
        [JsonProperty("meta")]
        public BreedSpeciesIdResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public BreedSpeciesIdResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("included")]
        public BreedSpeciesIdResponseIncludedTypeItem[] Included { get; set; }

        [JsonProperty("links")]
        public BreedSpeciesIdResponseLinksType Links { get; set; }
    }

    public class BreedSpeciesIdResponseMetaType
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

    public class BreedSpeciesIdResponseDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public BreedSpeciesIdResponseDataTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("relationships")]
        public BreedSpeciesIdResponseDataTypeItemRelationshipsType Relationships { get; set; }
    }

    public class BreedSpeciesIdResponseDataTypeItemAttributesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class BreedSpeciesIdResponseDataTypeItemRelationshipsType
    {
        [JsonProperty("species")]
        public BreedSpeciesIdResponseDataTypeItemRelationshipsTypeSpeciesType Species { get; set; }
    }

    public class BreedSpeciesIdResponseDataTypeItemRelationshipsTypeSpeciesType
    {
        [JsonProperty("data")]
        public BreedSpeciesIdResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public BreedSpeciesIdResponseDataTypeItemRelationshipsTypeSpeciesTypeLinksType Links { get; set; }
    }

    public class BreedSpeciesIdResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("links")]
        public BreedSpeciesIdResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItemLinksType Links { get; set; }
    }

    public class BreedSpeciesIdResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItemLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class BreedSpeciesIdResponseDataTypeItemRelationshipsTypeSpeciesTypeLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class BreedSpeciesIdResponseIncludedTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public BreedSpeciesIdResponseIncludedTypeItemAttributesType Attributes { get; set; }
    }

    public class BreedSpeciesIdResponseIncludedTypeItemAttributesType
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

    public class BreedSpeciesIdResponseLinksType
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

    public class OrganizationIdResponse
    {
        [JsonProperty("meta")]
        public OrganizationIdResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public OrganizationIdResponseDataTypeItem[] Data { get; set; }
    }

    public class OrganizationIdResponseMetaType
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

    public class OrganizationIdResponseDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public OrganizationIdResponseDataTypeItemAttributesType Attributes { get; set; }
    }

    public class OrganizationIdResponseDataTypeItemAttributesType
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

    public class AnimalIdResponse
    {
        [JsonProperty("meta")]
        public AnimalIdResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public AnimalIdResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("included")]
        public AnimalIdResponseIncludedTypeItem[] Included { get; set; }
    }

    public class AnimalIdResponseMetaType
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

    public class AnimalIdResponseDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public AnimalIdResponseDataTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("relationships")]
        public AnimalIdResponseDataTypeItemRelationshipsType Relationships { get; set; }
    }

    public class AnimalIdResponseDataTypeItemAttributesType
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

    public class AnimalIdResponseDataTypeItemRelationshipsType
    {
        [JsonProperty("breeds")]
        public AnimalIdResponseDataTypeItemRelationshipsTypeBreedsType Breeds { get; set; }

        [JsonProperty("colors")]
        public AnimalIdResponseDataTypeItemRelationshipsTypeColorsType Colors { get; set; }

        [JsonProperty("patterns")]
        public AnimalIdResponseDataTypeItemRelationshipsTypePatternsType Patterns { get; set; }

        [JsonProperty("species")]
        public AnimalIdResponseDataTypeItemRelationshipsTypeSpeciesType Species { get; set; }

        [JsonProperty("statuses")]
        public AnimalIdResponseDataTypeItemRelationshipsTypeStatusesType Statuses { get; set; }

        [JsonProperty("locations")]
        public AnimalIdResponseDataTypeItemRelationshipsTypeLocationsType Locations { get; set; }

        [JsonProperty("orgs")]
        public AnimalIdResponseDataTypeItemRelationshipsTypeOrgsType Orgs { get; set; }

        [JsonProperty("pictures")]
        public AnimalIdResponseDataTypeItemRelationshipsTypePicturesType Pictures { get; set; }
    }

    public class AnimalIdResponseDataTypeItemRelationshipsTypeBreedsType
    {
        [JsonProperty("data")]
        public AnimalIdResponseDataTypeItemRelationshipsTypeBreedsTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalIdResponseDataTypeItemRelationshipsTypeBreedsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalIdResponseDataTypeItemRelationshipsTypeColorsType
    {
        [JsonProperty("data")]
        public AnimalIdResponseDataTypeItemRelationshipsTypeColorsTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalIdResponseDataTypeItemRelationshipsTypeColorsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalIdResponseDataTypeItemRelationshipsTypePatternsType
    {
        [JsonProperty("data")]
        public AnimalIdResponseDataTypeItemRelationshipsTypePatternsTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalIdResponseDataTypeItemRelationshipsTypePatternsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalIdResponseDataTypeItemRelationshipsTypeSpeciesType
    {
        [JsonProperty("data")]
        public AnimalIdResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalIdResponseDataTypeItemRelationshipsTypeSpeciesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalIdResponseDataTypeItemRelationshipsTypeStatusesType
    {
        [JsonProperty("data")]
        public AnimalIdResponseDataTypeItemRelationshipsTypeStatusesTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalIdResponseDataTypeItemRelationshipsTypeStatusesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalIdResponseDataTypeItemRelationshipsTypeLocationsType
    {
        [JsonProperty("data")]
        public AnimalIdResponseDataTypeItemRelationshipsTypeLocationsTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalIdResponseDataTypeItemRelationshipsTypeLocationsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalIdResponseDataTypeItemRelationshipsTypeOrgsType
    {
        [JsonProperty("data")]
        public AnimalIdResponseDataTypeItemRelationshipsTypeOrgsTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalIdResponseDataTypeItemRelationshipsTypeOrgsTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalIdResponseDataTypeItemRelationshipsTypePicturesType
    {
        [JsonProperty("data")]
        public AnimalIdResponseDataTypeItemRelationshipsTypePicturesTypeDataTypeItem[] Data { get; set; }
    }

    public class AnimalIdResponseDataTypeItemRelationshipsTypePicturesTypeDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AnimalIdResponseIncludedTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public AnimalIdResponseIncludedTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("links")]
        public AnimalIdResponseIncludedTypeItemLinksType Links { get; set; }
    }

    public class AnimalIdResponseIncludedTypeItemAttributesType
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
        public AnimalIdResponseIncludedTypeItemAttributesTypeOriginalType Original { get; set; }

        [JsonProperty("large")]
        public AnimalIdResponseIncludedTypeItemAttributesTypeLargeType Large { get; set; }

        [JsonProperty("small")]
        public AnimalIdResponseIncludedTypeItemAttributesTypeSmallType Small { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class AnimalIdResponseIncludedTypeItemAttributesTypeOriginalType
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

    public class AnimalIdResponseIncludedTypeItemAttributesTypeLargeType
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

    public class AnimalIdResponseIncludedTypeItemAttributesTypeSmallType
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

    public class AnimalIdResponseIncludedTypeItemLinksType
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