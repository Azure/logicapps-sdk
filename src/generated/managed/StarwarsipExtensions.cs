//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Starwarsip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StarwarsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starwarsip")]
        public IBodyWorkflowAction<GetSpeciesResponse> GetSpecies(Expression<Func<string>> search = null, Expression<Func<int>> page = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<GetSpeciesResponse>(() =>
            {
                var apiCallPath = "/species";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<GetSpeciesResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starwarsip")]
        public IBodyWorkflowAction<Starship[]> GetStarships(Expression<Func<string>> search = null, Expression<Func<int>> page = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<Starship[]>(() =>
            {
                var apiCallPath = "/starships";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<Starship[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starwarsip")]
        public IBodyWorkflowAction<GetFilmsResponse> GetFilms(Expression<Func<string>> search = null, Expression<Func<int>> page = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<GetFilmsResponse>(() =>
            {
                var apiCallPath = "/films";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<GetFilmsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starwarsip")]
        public IBodyWorkflowAction<Film> GetFilmById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Film>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/films/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Film>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starwarsip")]
        public IBodyWorkflowAction<GetPlanetsResponse> GetPlanets(Expression<Func<string>> search = null, Expression<Func<int>> page = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<GetPlanetsResponse>(() =>
            {
                var apiCallPath = "/planets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<GetPlanetsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starwarsip")]
        public IBodyWorkflowAction<Person> GetPeople(Expression<Func<string>> search = null, Expression<Func<int>> page = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<Person>(() =>
            {
                var apiCallPath = "/people";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<Person>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starwarsip")]
        public IBodyWorkflowAction<Person> GetPersonById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Person>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/people/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Person>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starwarsip")]
        public IBodyWorkflowAction<Planet> GetPlanetById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Planet>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/planets/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Planet>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starwarsip")]
        public IBodyWorkflowAction<Species> GetSpeciesById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Species>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/species/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Species>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starwarsip")]
        public IBodyWorkflowAction<Starship> GetStarShipById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Starship>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/starships/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Starship>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class StarwarsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetSpeciesResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public Species[] Results { get; set; }
    }

    public class Species
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("average_height")]
        public string AverageHeight { get; set; }

        [JsonProperty("skin_colors")]
        public string SkinColors { get; set; }

        [JsonProperty("hair_colors")]
        public string HairColors { get; set; }

        [JsonProperty("eye_colors")]
        public string EyeColors { get; set; }

        [JsonProperty("average_lifespan")]
        public string AverageLifespan { get; set; }

        [JsonProperty("homeworld")]
        public string Homeworld { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("people")]
        public string[] People { get; set; }

        [JsonProperty("films")]
        public string[] Films { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("edited")]
        public string Edited { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Starship
    {
        public string MGLT { get; set; }

        [JsonProperty("cargo_capacity")]
        public string CargoCapacity { get; set; }

        [JsonProperty("consumables")]
        public string Consumables { get; set; }

        [JsonProperty("cost_in_credits")]
        public string CostInCredits { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("crew")]
        public string Crew { get; set; }

        [JsonProperty("edited")]
        public string Edited { get; set; }

        [JsonProperty("hyperdrive_rating")]
        public string HyperdriveRating { get; set; }

        [JsonProperty("length")]
        public string Length { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("max_atmosphering_speed")]
        public string MaxAtmospheringSpeed { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("passengers")]
        public string Passengers { get; set; }

        [JsonProperty("films")]
        public string[] Films { get; set; }

        [JsonProperty("pilots")]
        public string[] Pilots { get; set; }

        [JsonProperty("starship_class")]
        public string StarshipClass { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetFilmsResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public Film[] Results { get; set; }
    }

    public class Film
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("episode_id")]
        public int EpisodeId { get; set; }

        [JsonProperty("opening_crawl")]
        public string OpeningCrawl { get; set; }

        [JsonProperty("director")]
        public string Director { get; set; }

        [JsonProperty("producer")]
        public string Producer { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("characters")]
        public string[] Characters { get; set; }

        [JsonProperty("planets")]
        public string[] Planets { get; set; }

        [JsonProperty("starships")]
        public string[] Starships { get; set; }

        [JsonProperty("vehicles")]
        public string[] Vehicles { get; set; }

        [JsonProperty("species")]
        public string[] Species { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("edited")]
        public string Edited { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetPlanetsResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public Planet[] Results { get; set; }
    }

    public class Planet
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rotation_period")]
        public string RotationPeriod { get; set; }

        [JsonProperty("orbital_period")]
        public string OrbitalPeriod { get; set; }

        [JsonProperty("diameter")]
        public string Diameter { get; set; }

        [JsonProperty("climate")]
        public string Climate { get; set; }

        [JsonProperty("gravity")]
        public string Gravity { get; set; }

        [JsonProperty("terrain")]
        public string Terrain { get; set; }

        [JsonProperty("surface_water")]
        public string SurfaceWater { get; set; }

        [JsonProperty("population")]
        public string Population { get; set; }

        [JsonProperty("residents")]
        public string[] Residents { get; set; }

        [JsonProperty("films")]
        public string[] Films { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("edited")]
        public string Edited { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Person
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("mass")]
        public string Mass { get; set; }

        [JsonProperty("hair_color")]
        public string HairColor { get; set; }

        [JsonProperty("skin_color")]
        public string SkinColor { get; set; }

        [JsonProperty("eye_color")]
        public string EyeColor { get; set; }

        [JsonProperty("birth_year")]
        public string BirthYear { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("homeworld")]
        public string Homeworld { get; set; }

        [JsonProperty("films")]
        public string[] Films { get; set; }

        [JsonProperty("species")]
        public string[] Species { get; set; }

        [JsonProperty("vehicles")]
        public string[] Vehicles { get; set; }

        [JsonProperty("starships")]
        public string[] Starships { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("edited")]
        public string Edited { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Starwarsip;

    public partial class WorkflowManagedActions
    {
        public StarwarsipActions Starwarsip(string connectionId) => new StarwarsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public StarwarsipTriggers Starwarsip(string connectionId) => new StarwarsipTriggers(connectionId);
    }
}
