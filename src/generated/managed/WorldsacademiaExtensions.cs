//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Worldsacademia
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorldsacademiaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        public IBodyWorkflowAction<GetAllContinentsAndTheirMetadataResponseItem[]> GetAllContinentsAndTheirMetadata()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/continentsdata";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllContinentsAndTheirMetadataResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        public IBodyWorkflowAction<string[]> GetAListContinents()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/continents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        public IBodyWorkflowAction<string[]> GetAListCountriesInAContinent([WorkflowExpression] Func<string> continentName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/continent/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(continentName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        public IBodyWorkflowAction<int> GetTheNumberOfUniversitiesAvailable()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/sch/count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<int>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        public IBodyWorkflowAction<string[]> GetAListOfCountriesWithUniversities()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/sch/countries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        public IBodyWorkflowAction<string[]> GetAListOfCountriesCodesWithUniversities()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/sch/countriescodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        public IBodyWorkflowAction<GetAllUniversitiesInACountryViaCountryNameResponseItem[]> GetAllUniversitiesInACountryViaCountryName([WorkflowExpression] Func<string> countryName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/sch/country/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(countryName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllUniversitiesInACountryViaCountryNameResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        public IBodyWorkflowAction<GetAllUniversitiesInACountryViaCountryCodeResponseItem[]> GetAllUniversitiesInACountryViaCountryCode([WorkflowExpression] Func<string> countryCode)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/sch/countrycode/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(countryCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllUniversitiesInACountryViaCountryCodeResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        public IBodyWorkflowAction<GetAllUniversityDetailsResponse> GetAllUniversityDetails([WorkflowExpression] Func<string> universityName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/sch/university/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(universityName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllUniversityDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        public IBodyWorkflowAction<GetAllUniversitiesAndTheirMetadataResponseItem[]> GetAllUniversitiesAndTheirMetadata()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/sch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllUniversitiesAndTheirMetadataResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "worldsacademia")]
        public IBodyWorkflowAction<string[]> GetAListOfAllUniversities()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/schlist";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
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