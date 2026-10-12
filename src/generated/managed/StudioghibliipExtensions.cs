//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Studioghibliip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StudioghibliipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "studioghibliip")]
        [WorkflowExpressionFactory(nameof(__BuildGetFilms))]
        public IBodyWorkflowAction<Films[]> GetFilms([WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Films[]> __BuildGetFilms(WorkflowExpression<string> fields = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Films[]>(() =>
            {
                var apiCallPath = "/films";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<Films[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "studioghibliip")]
        [WorkflowExpressionFactory(nameof(__BuildGetFilm))]
        public IBodyWorkflowAction<Films[]> GetFilm([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> fields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Films[]> __BuildGetFilm(WorkflowExpression<string> id, WorkflowExpression<string> fields = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            return new DeferredBodyAction<Films[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/films/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                return new ApiConnectionAction<Films[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "studioghibliip")]
        [WorkflowExpressionFactory(nameof(__BuildGetPeople))]
        public IBodyWorkflowAction<People[]> GetPeople([WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<People[]> __BuildGetPeople(WorkflowExpression<string> fields = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<People[]>(() =>
            {
                var apiCallPath = "/people";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<People[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "studioghibliip")]
        [WorkflowExpressionFactory(nameof(__BuildGetPerson))]
        public IBodyWorkflowAction<People[]> GetPerson([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> fields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<People[]> __BuildGetPerson(WorkflowExpression<string> id, WorkflowExpression<string> fields = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            return new DeferredBodyAction<People[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/people/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                return new ApiConnectionAction<People[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "studioghibliip")]
        [WorkflowExpressionFactory(nameof(__BuildGetLocations))]
        public IBodyWorkflowAction<Locations[]> GetLocations([WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Locations[]> __BuildGetLocations(WorkflowExpression<string> fields = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Locations[]>(() =>
            {
                var apiCallPath = "/locations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<Locations[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "studioghibliip")]
        [WorkflowExpressionFactory(nameof(__BuildGetLocation))]
        public IBodyWorkflowAction<Locations[]> GetLocation([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> fields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Locations[]> __BuildGetLocation(WorkflowExpression<string> id, WorkflowExpression<string> fields = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            return new DeferredBodyAction<Locations[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/locations/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                return new ApiConnectionAction<Locations[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "studioghibliip")]
        [WorkflowExpressionFactory(nameof(__BuildGetSpecies))]
        public IBodyWorkflowAction<Species[]> GetSpecies([WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Species[]> __BuildGetSpecies(WorkflowExpression<string> fields = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Species[]>(() =>
            {
                var apiCallPath = "/species";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<Species[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "studioghibliip")]
        [WorkflowExpressionFactory(nameof(__BuildGetASpecies))]
        public IBodyWorkflowAction<Species[]> GetASpecies([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> fields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Species[]> __BuildGetASpecies(WorkflowExpression<string> id, WorkflowExpression<string> fields = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            return new DeferredBodyAction<Species[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/species/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                return new ApiConnectionAction<Species[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "studioghibliip")]
        [WorkflowExpressionFactory(nameof(__BuildGetVehicles))]
        public IBodyWorkflowAction<Vehicles[]> GetVehicles([WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Vehicles[]> __BuildGetVehicles(WorkflowExpression<string> fields = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Vehicles[]>(() =>
            {
                var apiCallPath = "/vehicles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<Vehicles[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "studioghibliip")]
        [WorkflowExpressionFactory(nameof(__BuildGetVehicle))]
        public IBodyWorkflowAction<Vehicles[]> GetVehicle([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> fields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Vehicles[]> __BuildGetVehicle(WorkflowExpression<string> id, WorkflowExpression<string> fields = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            return new DeferredBodyAction<Vehicles[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/vehicles/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                return new ApiConnectionAction<Vehicles[]>(callPayload);
            });
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