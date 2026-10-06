//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Worldsacademia
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorldsacademiaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        public IBodyWorkflowAction<GetAllContinentsAndTheirMetadataResponseItem[]> GetAllContinentsAndTheirMetadata()
        {
            var apiCallPath = "/api/v1/continentsdata";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllContinentsAndTheirMetadataResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        public IBodyWorkflowAction<string[]> GetAListContinents()
        {
            var apiCallPath = "/api/v1/continents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        [WorkflowExpressionFactory(nameof(__BuildGetAListCountriesInAContinent))]
        public IBodyWorkflowAction<string[]> GetAListCountriesInAContinent([WorkflowExpression] Func<string> continentName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string[]> __BuildGetAListCountriesInAContinent(WorkflowExpression<string> continentName)
        {
            WorkflowExpression.Validate(continentName, nameof(continentName), required: true);
            return new DeferredBodyAction<string[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/continent/{0}", ExpressionConverter.ConvertWithUrlEncoding(continentName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        public IBodyWorkflowAction<int> GetTheNumberOfUniversitiesAvailable()
        {
            var apiCallPath = "/api/v1/sch/count";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<int>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        public IBodyWorkflowAction<string[]> GetAListOfCountriesWithUniversities()
        {
            var apiCallPath = "/api/v1/sch/countries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        public IBodyWorkflowAction<string[]> GetAListOfCountriesCodesWithUniversities()
        {
            var apiCallPath = "/api/v1/sch/countriescodes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllUniversitiesInACountryViaCountryName))]
        public IBodyWorkflowAction<GetAllUniversitiesInACountryViaCountryNameResponseItem[]> GetAllUniversitiesInACountryViaCountryName([WorkflowExpression] Func<string> countryName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllUniversitiesInACountryViaCountryNameResponseItem[]> __BuildGetAllUniversitiesInACountryViaCountryName(WorkflowExpression<string> countryName)
        {
            WorkflowExpression.Validate(countryName, nameof(countryName), required: true);
            return new DeferredBodyAction<GetAllUniversitiesInACountryViaCountryNameResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/sch/country/{0}", ExpressionConverter.ConvertWithUrlEncoding(countryName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAllUniversitiesInACountryViaCountryNameResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllUniversitiesInACountryViaCountryCode))]
        public IBodyWorkflowAction<GetAllUniversitiesInACountryViaCountryCodeResponseItem[]> GetAllUniversitiesInACountryViaCountryCode([WorkflowExpression] Func<string> countryCode)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllUniversitiesInACountryViaCountryCodeResponseItem[]> __BuildGetAllUniversitiesInACountryViaCountryCode(WorkflowExpression<string> countryCode)
        {
            WorkflowExpression.Validate(countryCode, nameof(countryCode), required: true);
            return new DeferredBodyAction<GetAllUniversitiesInACountryViaCountryCodeResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/sch/countrycode/{0}", ExpressionConverter.ConvertWithUrlEncoding(countryCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAllUniversitiesInACountryViaCountryCodeResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllUniversityDetails))]
        public IBodyWorkflowAction<GetAllUniversityDetailsResponse> GetAllUniversityDetails([WorkflowExpression] Func<string> universityName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllUniversityDetailsResponse> __BuildGetAllUniversityDetails(WorkflowExpression<string> universityName)
        {
            WorkflowExpression.Validate(universityName, nameof(universityName), required: true);
            return new DeferredBodyAction<GetAllUniversityDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/sch/university/{0}", ExpressionConverter.ConvertWithUrlEncoding(universityName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAllUniversityDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        public IBodyWorkflowAction<GetAllUniversitiesAndTheirMetadataResponseItem[]> GetAllUniversitiesAndTheirMetadata()
        {
            var apiCallPath = "/api/v1/sch";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllUniversitiesAndTheirMetadataResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        public IBodyWorkflowAction<string[]> GetAListOfAllUniversities()
        {
            var apiCallPath = "/api/v1/schlist";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }
    }

    public class WorldsacademiaTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetAllContinentsAndTheirMetadataResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("countries")]
        public string[] Countries { get; set; }
    }

    public class GetAllUniversitiesInACountryViaCountryNameResponseItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("alpha_two_code")]
        public string AlphaTwoCode { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("web_pages")]
        public string[] WebPages { get; set; }
    }

    public class GetAllUniversitiesInACountryViaCountryCodeResponseItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("alpha_two_code")]
        public string AlphaTwoCode { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("web_pages")]
        public string[] WebPages { get; set; }
    }

    public class GetAllUniversityDetailsResponse
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("alpha_two_code")]
        public string AlphaTwoCode { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("web_pages")]
        public string[] WebPages { get; set; }
    }

    public class GetAllUniversitiesAndTheirMetadataResponseItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("alpha_two_code")]
        public string AlphaTwoCode { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("web_pages")]
        public string[] WebPages { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Worldsacademia;

    public partial class WorkflowManagedActions
    {
        public WorldsacademiaActions Worldsacademia(string connectionId) => new WorldsacademiaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WorldsacademiaTriggers Worldsacademia(string connectionId) => new WorldsacademiaTriggers(connectionId);
    }
}