//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Studioghibliip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StudioghibliipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "studioghibliip")]
        public IBodyWorkflowAction<Films[]> GetFilms(Expression<Func<string>> fields = null, Expression<Func<int>> limit = null)
        {
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Films[]>(() =>
            {
                var apiCallPath = "/films";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<Films[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "studioghibliip")]
        public IBodyWorkflowAction<Films[]> GetFilm(Expression<Func<string>> id, Expression<Func<string>> fields = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<Films[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/films/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<Films[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "studioghibliip")]
        public IBodyWorkflowAction<People[]> GetPeople(Expression<Func<string>> fields = null, Expression<Func<int>> limit = null)
        {
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<People[]>(() =>
            {
                var apiCallPath = "/people";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<People[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "studioghibliip")]
        public IBodyWorkflowAction<People[]> GetPerson(Expression<Func<string>> id, Expression<Func<string>> fields = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<People[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/people/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<People[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "studioghibliip")]
        public IBodyWorkflowAction<Locations[]> GetLocations(Expression<Func<string>> fields = null, Expression<Func<int>> limit = null)
        {
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Locations[]>(() =>
            {
                var apiCallPath = "/locations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<Locations[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "studioghibliip")]
        public IBodyWorkflowAction<Locations[]> GetLocation(Expression<Func<string>> id, Expression<Func<string>> fields = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<Locations[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/locations/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<Locations[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "studioghibliip")]
        public IBodyWorkflowAction<Species[]> GetSpecies(Expression<Func<string>> fields = null, Expression<Func<int>> limit = null)
        {
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Species[]>(() =>
            {
                var apiCallPath = "/species";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<Species[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "studioghibliip")]
        public IBodyWorkflowAction<Species[]> GetASpecies(Expression<Func<string>> id, Expression<Func<string>> fields = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<Species[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/species/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<Species[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "studioghibliip")]
        public IBodyWorkflowAction<Vehicles[]> GetVehicles(Expression<Func<string>> fields = null, Expression<Func<int>> limit = null)
        {
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Vehicles[]>(() =>
            {
                var apiCallPath = "/vehicles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<Vehicles[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "studioghibliip")]
        public IBodyWorkflowAction<Vehicles[]> GetVehicle(Expression<Func<string>> id, Expression<Func<string>> fields = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<Vehicles[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/vehicles/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<Vehicles[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class StudioghibliipTriggers([ConnectionName] string connectionId)
    {
    }

    public class Films
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }

        [JsonProperty("original_title_romanised")]
        public string OriginalTitleRomanised { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("director")]
        public string Director { get; set; }

        [JsonProperty("producer")]
        public string Producer { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("running_time")]
        public string RunningTime { get; set; }

        [JsonProperty("rt_score")]
        public string RtScore { get; set; }

        [JsonProperty("people")]
        public string[] People { get; set; }

        [JsonProperty("species")]
        public string[] Species { get; set; }

        [JsonProperty("locations")]
        public string[] Locations { get; set; }

        [JsonProperty("vehicles")]
        public string[] Vehicles { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class People
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("eye_color")]
        public string EyeColor { get; set; }

        [JsonProperty("hair_color")]
        public string HairColor { get; set; }

        [JsonProperty("films")]
        public string[] Films { get; set; }

        [JsonProperty("species")]
        public string Species { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Locations
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("climate")]
        public string Climate { get; set; }

        [JsonProperty("terrain")]
        public string Terrain { get; set; }

        [JsonProperty("surface_water")]
        public string SurfaceWater { get; set; }

        [JsonProperty("residents")]
        public string[] Residents { get; set; }

        [JsonProperty("films")]
        public string[] Films { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Species
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("eye_color")]
        public string EyeColor { get; set; }

        [JsonProperty("hair_color")]
        public string HairColor { get; set; }

        [JsonProperty("people")]
        public string[] People { get; set; }

        [JsonProperty("films")]
        public string[] Films { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Vehicles
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("vehicle_class")]
        public string VehicleClass { get; set; }

        [JsonProperty("length")]
        public string Length { get; set; }

        [JsonProperty("pilot")]
        public string Pilot { get; set; }

        [JsonProperty("films")]
        public string[] Films { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Studioghibliip;

    public partial class WorkflowManagedActions
    {
        public StudioghibliipActions Studioghibliip(string connectionId) => new StudioghibliipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public StudioghibliipTriggers Studioghibliip(string connectionId) => new StudioghibliipTriggers(connectionId);
    }
}
