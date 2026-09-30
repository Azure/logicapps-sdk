//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pokeapicore
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PokeapicoreActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapicore")]
        public IBodyWorkflowAction<ListResults> ListAbilities([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            var apiCallPath = "/api/v2/ability/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ListResults>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapicore")]
        public IBodyWorkflowAction<GetAbilityResponse> GetAbility([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> idOrName)
        {
            var apiCallPath = String.Format("/api/v2/ability/{0}/", ExpressionConverter.ConvertWithUrlEncoding(idOrName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAbilityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapicore")]
        public IBodyWorkflowAction<ListResults> ListCharacteristics([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            var apiCallPath = "/api/v2/characteristic/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ListResults>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapicore")]
        public IBodyWorkflowAction<GetCharacteristicsResponse> GetCharacteristics([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/api/v2/characteristic/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCharacteristicsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapicore")]
        public IBodyWorkflowAction<ListResults> ListGenders([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            var apiCallPath = "/api/v2/gender/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ListResults>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapicore")]
        public IBodyWorkflowAction<ListResults> ListGrowthRates([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            var apiCallPath = "/api/v2/growth-rate/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ListResults>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapicore")]
        public IBodyWorkflowAction<GetGenderResponse> GetGender([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> idOrName)
        {
            var apiCallPath = String.Format("/api/v2/gender/{0}/", ExpressionConverter.ConvertWithUrlEncoding(idOrName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetGenderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapicore")]
        public IBodyWorkflowAction<GetGrowthRatesResponse> GetGrowthRates([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> idOrName)
        {
            var apiCallPath = String.Format("/api/v2/growth-rate/{0}/", ExpressionConverter.ConvertWithUrlEncoding(idOrName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetGrowthRatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapicore")]
        public IBodyWorkflowAction<ListResults> ListPokemon([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            var apiCallPath = "/api/v2/pokemon/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ListResults>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapicore")]
        public IBodyWorkflowAction<GetPokemonResponse> GetPokemon([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> idOrName)
        {
            var apiCallPath = String.Format("/api/v2/pokemon/{0}/", ExpressionConverter.ConvertWithUrlEncoding(idOrName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetPokemonResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapicore")]
        public IBodyWorkflowAction<ListResults> ListTypes([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            var apiCallPath = "/api/v2/type/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ListResults>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapicore")]
        public IBodyWorkflowAction<GetTypeResponse> GetType([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> idOrName)
        {
            var apiCallPath = String.Format("/api/v2/type/{0}/", ExpressionConverter.ConvertWithUrlEncoding(idOrName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapicore")]
        public IBodyWorkflowAction<ListResults> ListEvolutionChains([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            var apiCallPath = "/api/v2/evolution-chain/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ListResults>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapicore")]
        public IBodyWorkflowAction<GetEvolutionChainResponse> GetEvolutionChain([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/api/v2/evolution-chain/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetEvolutionChainResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapicore")]
        public IBodyWorkflowAction<ListResults> ListEvolutionTriggers([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            var apiCallPath = "/api/v2/evolution-trigger/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ListResults>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pokeapicore")]
        public IBodyWorkflowAction<GetEvolutionTriggerResponse> GetEvolutionTrigger([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> idOrName)
        {
            var apiCallPath = String.Format("/api/v2/evolution-trigger/{0}/", ExpressionConverter.ConvertWithUrlEncoding(idOrName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetEvolutionTriggerResponse>(callPayload);
        }
    }

    public class PokeapicoreTriggers([ConnectionName] string connectionId)
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

    public class GetAbilityResponse
    {
        [JsonProperty("effect_changes")]
        public JToken[] EffectChanges { get; set; }

        [JsonProperty("effect_entries")]
        public GetAbilityResponseEffectEntriesTypeItem[] EffectEntries { get; set; }

        [JsonProperty("flavor_text_entries")]
        public GetAbilityResponseFlavorTextEntriesTypeItem[] FlavorTextEntries { get; set; }

        [JsonProperty("generation")]
        public GetAbilityResponseGenerationType Generation { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_main_series")]
        public bool IsMainSeries { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public NamesTypeItem[] Names { get; set; }

        [JsonProperty("pokemon")]
        public GetAbilityResponsePokemonTypeItem[] Pokemon { get; set; }
    }

    public class GetAbilityResponseEffectEntriesTypeItem
    {
        [JsonProperty("effect")]
        public string Effect { get; set; }

        [JsonProperty("language")]
        public LanguageType Language { get; set; }

        [JsonProperty("short_effect")]
        public string ShortEffect { get; set; }
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

    public class GetAbilityResponseFlavorTextEntriesTypeItem
    {
        [JsonProperty("flavor_text")]
        public string FlavorText { get; set; }

        [JsonProperty("language")]
        public LanguageType Language { get; set; }

        [JsonProperty("version_group")]
        public VersionGroupType VersionGroup { get; set; }
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

    public class GetAbilityResponseGenerationType
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

    public class GetAbilityResponsePokemonTypeItem
    {
        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("pokemon")]
        public GetAbilityResponsePokemonTypeItemPokemonType Pokemon { get; set; }

        [JsonProperty("slot")]
        public int Slot { get; set; }
    }

    public class GetAbilityResponsePokemonTypeItemPokemonType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetCharacteristicsResponse
    {
        [JsonProperty("descriptions")]
        public DescriptionTypeItem[] Descriptions { get; set; }

        [JsonProperty("gene_modulo")]
        public int GeneModulo { get; set; }

        [JsonProperty("highest_stat")]
        public GetCharacteristicsResponseHighestStatType HighestStat { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("possible_values")]
        public JToken[] PossibleValues { get; set; }
    }

    public class DescriptionTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("language")]
        public LanguageType Language { get; set; }
    }

    public class GetCharacteristicsResponseHighestStatType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetGenderResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pokemon_species_details")]
        public GetGenderResponsePokemonSpeciesDetailsTypeItem[] PokemonSpeciesDetails { get; set; }

        [JsonProperty("required_for_evolution")]
        public GetGenderResponseRequiredForEvolutionTypeItem[] RequiredForEvolution { get; set; }
    }

    public class GetGenderResponsePokemonSpeciesDetailsTypeItem
    {
        [JsonProperty("pokemon_species")]
        public GetGenderResponsePokemonSpeciesDetailsTypeItemPokemonSpeciesType PokemonSpecies { get; set; }

        [JsonProperty("rate")]
        public int Rate { get; set; }
    }

    public class GetGenderResponsePokemonSpeciesDetailsTypeItemPokemonSpeciesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetGenderResponseRequiredForEvolutionTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetGrowthRatesResponse
    {
        [JsonProperty("descriptions")]
        public DescriptionTypeItem[] Descriptions { get; set; }

        [JsonProperty("formula")]
        public string Formula { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("levels")]
        public GetGrowthRatesResponseLevelsTypeItem[] Levels { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pokemon_species")]
        public GetGrowthRatesResponsePokemonSpeciesTypeItem[] PokemonSpecies { get; set; }
    }

    public class GetGrowthRatesResponseLevelsTypeItem
    {
        [JsonProperty("experience")]
        public int Experience { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }
    }

    public class GetGrowthRatesResponsePokemonSpeciesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetPokemonResponse
    {
        [JsonProperty("abilities")]
        public PokemonAbilityType[] Abilities { get; set; }

        [JsonProperty("base_experience")]
        public int BaseExperience { get; set; }

        [JsonProperty("cries")]
        public GetPokemonResponseCriesType Cries { get; set; }

        [JsonProperty("forms")]
        public GetPokemonResponseFormsTypeItem[] Forms { get; set; }

        [JsonProperty("game_indices")]
        public GetPokemonResponseGameIndicesTypeItem[] GameIndices { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("held_items")]
        public JToken[] HeldItems { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("location_area_encounters")]
        public string LocationAreaEncounters { get; set; }

        [JsonProperty("moves")]
        public GetPokemonResponseMovesTypeItem[] Moves { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("past_abilities")]
        public GetPokemonResponsePastAbilitiesTypeItem[] PastAbilities { get; set; }

        [JsonProperty("past_types")]
        public PokemonTypeType[] PastTypes { get; set; }

        [JsonProperty("species")]
        public GetPokemonResponseSpeciesType Species { get; set; }

        [JsonProperty("sprites")]
        public GetPokemonResponseSpritesType Sprites { get; set; }

        [JsonProperty("stats")]
        public GetPokemonResponseStatsTypeItem[] Stats { get; set; }

        [JsonProperty("types")]
        public PokemonTypeType[] Types { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }
    }

    public class PokemonAbilityType
    {
        [JsonProperty("ability")]
        public PokemonAbilityTypeAbilityType Ability { get; set; }

        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("slot")]
        public int Slot { get; set; }
    }

    public class PokemonAbilityTypeAbilityType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetPokemonResponseCriesType
    {
        [JsonProperty("latest")]
        public string Latest { get; set; }

        [JsonProperty("legacy")]
        public string Legacy { get; set; }
    }

    public class GetPokemonResponseFormsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetPokemonResponseGameIndicesTypeItem
    {
        [JsonProperty("game_index")]
        public int GameIndex { get; set; }

        [JsonProperty("version")]
        public GetPokemonResponseGameIndicesTypeItemVersionType Version { get; set; }
    }

    public class GetPokemonResponseGameIndicesTypeItemVersionType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetPokemonResponseMovesTypeItem
    {
        [JsonProperty("move")]
        public GetPokemonResponseMovesTypeItemMoveType Move { get; set; }

        [JsonProperty("version_group_details")]
        public GetPokemonResponseMovesTypeItemVersionGroupDetailsTypeItem[] VersionGroupDetails { get; set; }
    }

    public class GetPokemonResponseMovesTypeItemMoveType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetPokemonResponseMovesTypeItemVersionGroupDetailsTypeItem
    {
        [JsonProperty("level_learned_at")]
        public int LevelLearnedAt { get; set; }

        [JsonProperty("move_learn_method")]
        public GetPokemonResponseMovesTypeItemVersionGroupDetailsTypeItemMoveLearnMethodType MoveLearnMethod { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("version_group")]
        public GetPokemonResponseMovesTypeItemVersionGroupDetailsTypeItemVersionGroupType VersionGroup { get; set; }
    }

    public class GetPokemonResponseMovesTypeItemVersionGroupDetailsTypeItemMoveLearnMethodType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetPokemonResponseMovesTypeItemVersionGroupDetailsTypeItemVersionGroupType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetPokemonResponsePastAbilitiesTypeItem
    {
        [JsonProperty("abilities")]
        public PokemonAbilityType[] Abilities { get; set; }

        [JsonProperty("generation")]
        public GetPokemonResponsePastAbilitiesTypeItemGenerationType Generation { get; set; }
    }

    public class GetPokemonResponsePastAbilitiesTypeItemGenerationType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PokemonTypeType
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("type")]
        public PokemonTypeTypeTypeType Type { get; set; }
    }

    public class PokemonTypeTypeTypeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetPokemonResponseSpeciesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetPokemonResponseSpritesType
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_female")]
        public string BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public string BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public string FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public string FrontShinyFemale { get; set; }
    }

    public class GetPokemonResponseStatsTypeItem
    {
        [JsonProperty("base_stat")]
        public int BaseStat { get; set; }

        [JsonProperty("effort")]
        public int Effort { get; set; }

        [JsonProperty("stat")]
        public GetPokemonResponseStatsTypeItemStatType Stat { get; set; }
    }

    public class GetPokemonResponseStatsTypeItemStatType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetTypeResponse
    {
        [JsonProperty("damage_relations")]
        public GetTypeResponseDamageRelationsType DamageRelations { get; set; }

        [JsonProperty("game_indices")]
        public GetTypeResponseGameIndicesTypeItem[] GameIndices { get; set; }

        [JsonProperty("generation")]
        public JToken Generation { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("move_damage_class")]
        public JToken MoveDamageClass { get; set; }

        [JsonProperty("moves")]
        public JToken[] Moves { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public NamesTypeItem[] Names { get; set; }

        [JsonProperty("past_damage_relations")]
        public JToken[] PastDamageRelations { get; set; }

        [JsonProperty("pokemon")]
        public GetTypeResponsePokemonTypeItem[] Pokemon { get; set; }
    }

    public class GetTypeResponseDamageRelationsType
    {
        [JsonProperty("double_damage_from")]
        public JToken[] DoubleDamageFrom { get; set; }

        [JsonProperty("double_damage_to")]
        public JToken[] DoubleDamageTo { get; set; }

        [JsonProperty("half_damage_from")]
        public JToken[] HalfDamageFrom { get; set; }

        [JsonProperty("half_damage_to")]
        public JToken[] HalfDamageTo { get; set; }

        [JsonProperty("no_damage_from")]
        public JToken[] NoDamageFrom { get; set; }

        [JsonProperty("no_damage_to")]
        public JToken[] NoDamageTo { get; set; }
    }

    public class GetTypeResponseGameIndicesTypeItem
    {
        [JsonProperty("game_index")]
        public int GameIndex { get; set; }

        [JsonProperty("generation")]
        public JToken Generation { get; set; }
    }

    public class GetTypeResponsePokemonTypeItem
    {
        [JsonProperty("pokemon")]
        public JToken Pokemon { get; set; }

        [JsonProperty("slot")]
        public int Slot { get; set; }
    }

    public class GetEvolutionChainResponse
    {
        [JsonProperty("baby_trigger_item")]
        public JToken BabyTriggerItem { get; set; }

        [JsonProperty("chain")]
        public ChainLinkType Chain { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class ChainLinkType
    {
        [JsonProperty("is_baby")]
        public bool IsBaby { get; set; }

        [JsonProperty("species")]
        public ChainLinkTypeSpeciesType Species { get; set; }

        [JsonProperty("evolves_to")]
        public ChainLinkType[] EvolvesTo { get; set; }

        [JsonProperty("evolution_details")]
        public JToken[] EvolutionDetails { get; set; }
    }

    public class ChainLinkTypeSpeciesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetEvolutionTriggerResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public NamesTypeItem[] Names { get; set; }

        [JsonProperty("pokemon_species")]
        public GetEvolutionTriggerResponsePokemonSpeciesTypeItem[] PokemonSpecies { get; set; }
    }

    public class GetEvolutionTriggerResponsePokemonSpeciesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pokeapicore;

    public partial class WorkflowManagedActions
    {
        public PokeapicoreActions Pokeapicore(string connectionId) => new PokeapicoreActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PokeapicoreTriggers Pokeapicore(string connectionId) => new PokeapicoreTriggers(connectionId);
    }
}