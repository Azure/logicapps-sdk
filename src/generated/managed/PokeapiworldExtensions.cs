//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pokeapiworld
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PokeapiworldActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapiworld")]
        public IBodyWorkflowAction<ListResults> ListMachines(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/api/v2/machine/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ListResults>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapiworld")]
        public IBodyWorkflowAction<GetMachineResponse> GetMachine(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/v2/machine/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetMachineResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapiworld")]
        public IBodyWorkflowAction<ListResults> ListLocations(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/api/v2/location/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ListResults>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapiworld")]
        public IBodyWorkflowAction<GetLocationResponse> GetLocation(Expression<Func<string>> idOrName)
        {
            var apiCallPath = String.Format("/api/v2/location/{0}/", ExpressionConverter.ConvertWithUrlEncoding(idOrName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetLocationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapiworld")]
        public IBodyWorkflowAction<ListResults> ListLocationAreas(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/api/v2/location-area/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ListResults>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapiworld")]
        public IBodyWorkflowAction<GetLocationAreaResponse> GetLocationArea(Expression<Func<string>> idOrName)
        {
            var apiCallPath = String.Format("/api/v2/location-area/{0}/", ExpressionConverter.ConvertWithUrlEncoding(idOrName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetLocationAreaResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapiworld")]
        public IBodyWorkflowAction<ListResults> ListRegions(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/api/v2/region/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ListResults>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapiworld")]
        public IBodyWorkflowAction<GetRegionResponse> GetRegion(Expression<Func<string>> idOrName)
        {
            var apiCallPath = String.Format("/api/v2/region/{0}/", ExpressionConverter.ConvertWithUrlEncoding(idOrName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRegionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapiworld")]
        public IBodyWorkflowAction<ListResults> ListEncounterMethods(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/api/v2/encounter-method/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ListResults>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapiworld")]
        public IBodyWorkflowAction<GetEncounterResponse> GetEncounter(Expression<Func<string>> idOrName)
        {
            var apiCallPath = String.Format("/api/v2/encounter-method/{0}/", ExpressionConverter.ConvertWithUrlEncoding(idOrName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetEncounterResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapiworld")]
        public IBodyWorkflowAction<ListResults> ListEncounterConditions(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/api/v2/encounter-condition/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ListResults>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapiworld")]
        public IBodyWorkflowAction<GetEncounterConditionResponse> GetEncounterCondition(Expression<Func<string>> idOrName)
        {
            var apiCallPath = String.Format("/api/v2/encounter-condition/{0}/", ExpressionConverter.ConvertWithUrlEncoding(idOrName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetEncounterConditionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapiworld")]
        public IBodyWorkflowAction<ListResults> ListEncounterConditionValues(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/api/v2/encounter-condition-value/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ListResults>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapiworld")]
        public IBodyWorkflowAction<GetEncounterConditionValueResponse> GetEncounterConditionValue(Expression<Func<string>> idOrName)
        {
            var apiCallPath = String.Format("/api/v2/encounter-condition-value/{0}/", ExpressionConverter.ConvertWithUrlEncoding(idOrName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetEncounterConditionValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapiworld")]
        public IBodyWorkflowAction<ListResults> ListBerries(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/api/v2/berry/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ListResults>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapiworld")]
        public IBodyWorkflowAction<GetBerryResponse> GetBerry(Expression<Func<string>> idOrName)
        {
            var apiCallPath = String.Format("/api/v2/berry/{0}/", ExpressionConverter.ConvertWithUrlEncoding(idOrName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetBerryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapiworld")]
        public IBodyWorkflowAction<ListResults> ListItems(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/api/v2/item/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ListResults>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapiworld")]
        public IBodyWorkflowAction<GetItemResponse> GetItem(Expression<Func<string>> idOrName)
        {
            var apiCallPath = String.Format("/api/v2/item/{0}/", ExpressionConverter.ConvertWithUrlEncoding(idOrName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetItemResponse>(callPayload);
        }
    }

    public class PokeapiworldTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListResults
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public ListResultsResultsTypeItem[] Results { get; set; }
    }

    public class ListResultsResultsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetMachineResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("item")]
        public GetMachineResponseItemType Item { get; set; }

        [JsonProperty("move")]
        public GetMachineResponseMoveType Move { get; set; }

        [JsonProperty("version_group")]
        public VersionGroupType VersionGroup { get; set; }
    }

    public class GetMachineResponseItemType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetMachineResponseMoveType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class VersionGroupType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class GetLocationResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region")]
        public GetLocationResponseRegionType Region { get; set; }

        [JsonProperty("names")]
        public NamesTypeItem[] Names { get; set; }

        [JsonProperty("game_indices")]
        public GameIndexTypeItem[] GameIndices { get; set; }

        [JsonProperty("areas")]
        public GetLocationResponseAreasTypeItem[] Areas { get; set; }
    }

    public class GetLocationResponseRegionType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class NamesTypeItem
    {
        [JsonProperty("language")]
        public LanguageType Language { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class LanguageType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("official")]
        public bool Official { get; set; }

        [JsonProperty("iso639")]
        public string Iso639 { get; set; }

        [JsonProperty("iso3166")]
        public string Iso3166 { get; set; }
    }

    public class GameIndexTypeItem
    {
        [JsonProperty("game_index")]
        public int GameIndex { get; set; }

        [JsonProperty("generation")]
        public GameIndexTypeItemGenerationType Generation { get; set; }
    }

    public class GameIndexTypeItemGenerationType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetLocationResponseAreasTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetLocationAreaResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("game_index")]
        public int GameIndex { get; set; }

        [JsonProperty("encounter_method_rates")]
        public GetLocationAreaResponseEncounterMethodRatesTypeItem[] EncounterMethodRates { get; set; }

        [JsonProperty("location")]
        public GetLocationAreaResponseLocationType Location { get; set; }

        [JsonProperty("names")]
        public NamesTypeItem[] Names { get; set; }

        [JsonProperty("pokemon_encounters")]
        public GetLocationAreaResponsePokemonEncountersTypeItem[] PokemonEncounters { get; set; }
    }

    public class GetLocationAreaResponseEncounterMethodRatesTypeItem
    {
        [JsonProperty("encounter_method")]
        public GetLocationAreaResponseEncounterMethodRatesTypeItemEncounterMethodType EncounterMethod { get; set; }

        [JsonProperty("version_details")]
        public GetLocationAreaResponseEncounterMethodRatesTypeItemVersionDetailsTypeItem[] VersionDetails { get; set; }
    }

    public class GetLocationAreaResponseEncounterMethodRatesTypeItemEncounterMethodType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetLocationAreaResponseEncounterMethodRatesTypeItemVersionDetailsTypeItem
    {
        [JsonProperty("rate")]
        public int Rate { get; set; }

        [JsonProperty("version")]
        public GetLocationAreaResponseEncounterMethodRatesTypeItemVersionDetailsTypeItemVersionType Version { get; set; }
    }

    public class GetLocationAreaResponseEncounterMethodRatesTypeItemVersionDetailsTypeItemVersionType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetLocationAreaResponseLocationType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetLocationAreaResponsePokemonEncountersTypeItem
    {
        [JsonProperty("pokemon")]
        public GetLocationAreaResponsePokemonEncountersTypeItemPokemonType Pokemon { get; set; }

        [JsonProperty("version_details")]
        public GetLocationAreaResponsePokemonEncountersTypeItemVersionDetailsTypeItem[] VersionDetails { get; set; }
    }

    public class GetLocationAreaResponsePokemonEncountersTypeItemPokemonType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetLocationAreaResponsePokemonEncountersTypeItemVersionDetailsTypeItem
    {
        [JsonProperty("version")]
        public GetLocationAreaResponsePokemonEncountersTypeItemVersionDetailsTypeItemVersionType Version { get; set; }

        [JsonProperty("max_chance")]
        public int MaxChance { get; set; }

        [JsonProperty("encounter_details")]
        public GetLocationAreaResponsePokemonEncountersTypeItemVersionDetailsTypeItemEncounterDetailsTypeItem[] EncounterDetails { get; set; }
    }

    public class GetLocationAreaResponsePokemonEncountersTypeItemVersionDetailsTypeItemVersionType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetLocationAreaResponsePokemonEncountersTypeItemVersionDetailsTypeItemEncounterDetailsTypeItem
    {
        [JsonProperty("min_level")]
        public int MinLevel { get; set; }

        [JsonProperty("max_level")]
        public int MaxLevel { get; set; }

        [JsonProperty("condition_values")]
        public JToken[] ConditionValues { get; set; }

        [JsonProperty("chance")]
        public int Chance { get; set; }

        [JsonProperty("method")]
        public GetLocationAreaResponsePokemonEncountersTypeItemVersionDetailsTypeItemEncounterDetailsTypeItemMethodType Method { get; set; }
    }

    public class GetLocationAreaResponsePokemonEncountersTypeItemVersionDetailsTypeItemEncounterDetailsTypeItemMethodType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetRegionResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("locations")]
        public GetRegionResponseLocationsTypeItem[] Locations { get; set; }

        [JsonProperty("main_generation")]
        public GetRegionResponseMainGenerationType MainGeneration { get; set; }

        [JsonProperty("names")]
        public NamesTypeItem[] Names { get; set; }

        [JsonProperty("pokedexes")]
        public GetRegionResponsePokedexesTypeItem[] Pokedexes { get; set; }

        [JsonProperty("version_groups")]
        public VersionGroupType VersionGroups { get; set; }
    }

    public class GetRegionResponseLocationsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetRegionResponseMainGenerationType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetRegionResponsePokedexesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetEncounterResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("names")]
        public NamesTypeItem[] Names { get; set; }
    }

    public class GetEncounterConditionResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("values")]
        public GetEncounterConditionResponseValuesTypeItem[] Values { get; set; }

        [JsonProperty("names")]
        public NamesTypeItem[] Names { get; set; }
    }

    public class GetEncounterConditionResponseValuesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetEncounterConditionValueResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("condition")]
        public GetEncounterConditionValueResponseConditionType Condition { get; set; }

        [JsonProperty("names")]
        public NamesTypeItem[] Names { get; set; }
    }

    public class GetEncounterConditionValueResponseConditionType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetBerryResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("growth_time")]
        public int GrowthTime { get; set; }

        [JsonProperty("max_harvest")]
        public int MaxHarvest { get; set; }

        [JsonProperty("natural_gift_power")]
        public int NaturalGiftPower { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("smoothness")]
        public int Smoothness { get; set; }

        [JsonProperty("soil_dryness")]
        public int SoilDryness { get; set; }

        [JsonProperty("firmness")]
        public GetBerryResponseFirmnessType Firmness { get; set; }

        [JsonProperty("flavors")]
        public GetBerryResponseFlavorsTypeItem[] Flavors { get; set; }

        [JsonProperty("item")]
        public GetBerryResponseItemType Item { get; set; }

        [JsonProperty("natural_gift_type")]
        public GetBerryResponseNaturalGiftTypeType NaturalGiftType { get; set; }
    }

    public class GetBerryResponseFirmnessType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetBerryResponseFlavorsTypeItem
    {
        [JsonProperty("potency")]
        public int Potency { get; set; }

        [JsonProperty("flavor")]
        public GetBerryResponseFlavorsTypeItemFlavorType Flavor { get; set; }
    }

    public class GetBerryResponseFlavorsTypeItemFlavorType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetBerryResponseItemType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetBerryResponseNaturalGiftTypeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetItemResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("fling_power")]
        public int FlingPower { get; set; }

        [JsonProperty("fling_effect")]
        public GetItemResponseFlingEffectType FlingEffect { get; set; }

        [JsonProperty("attributes")]
        public GetItemResponseAttributesTypeItem[] Attributes { get; set; }

        [JsonProperty("category")]
        public GetItemResponseCategoryType Category { get; set; }

        [JsonProperty("effect_entries")]
        public GetItemResponseEffectEntriesTypeItem[] EffectEntries { get; set; }

        [JsonProperty("flavor_text_entries")]
        public GetItemResponseFlavorTextEntriesTypeItem[] FlavorTextEntries { get; set; }

        [JsonProperty("game_indices")]
        public GameIndexTypeItem[] GameIndices { get; set; }

        [JsonProperty("names")]
        public NamesTypeItem[] Names { get; set; }

        [JsonProperty("sprites")]
        public GetItemResponseSpritesType Sprites { get; set; }

        [JsonProperty("held_by_pokemon")]
        public GetItemResponseHeldByPokemonTypeItem[] HeldByPokemon { get; set; }

        [JsonProperty("baby_trigger_for")]
        public GetItemResponseBabyTriggerForType BabyTriggerFor { get; set; }
    }

    public class GetItemResponseFlingEffectType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetItemResponseAttributesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetItemResponseCategoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetItemResponseEffectEntriesTypeItem
    {
        [JsonProperty("effect")]
        public string Effect { get; set; }

        [JsonProperty("short_effect")]
        public string ShortEffect { get; set; }

        [JsonProperty("language")]
        public LanguageType Language { get; set; }
    }

    public class GetItemResponseFlavorTextEntriesTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("version_group")]
        public VersionGroupType VersionGroup { get; set; }

        [JsonProperty("language")]
        public LanguageType Language { get; set; }
    }

    public class GetItemResponseSpritesType
    {
        [JsonProperty("default")]
        public string Default { get; set; }
    }

    public class GetItemResponseHeldByPokemonTypeItem
    {
        [JsonProperty("pokemon")]
        public GetItemResponseHeldByPokemonTypeItemPokemonType Pokemon { get; set; }

        [JsonProperty("version_details")]
        public GetItemResponseHeldByPokemonTypeItemVersionDetailsTypeItem[] VersionDetails { get; set; }
    }

    public class GetItemResponseHeldByPokemonTypeItemPokemonType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetItemResponseHeldByPokemonTypeItemVersionDetailsTypeItem
    {
        [JsonProperty("rarity")]
        public int Rarity { get; set; }

        [JsonProperty("version")]
        public GetItemResponseHeldByPokemonTypeItemVersionDetailsTypeItemVersionType Version { get; set; }
    }

    public class GetItemResponseHeldByPokemonTypeItemVersionDetailsTypeItemVersionType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetItemResponseBabyTriggerForType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pokeapiworld;

    public partial class WorkflowManagedActions
    {
        public PokeapiworldActions Pokeapiworld(string connectionId) => new PokeapiworldActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PokeapiworldTriggers Pokeapiworld(string connectionId) => new PokeapiworldTriggers(connectionId);
    }
}