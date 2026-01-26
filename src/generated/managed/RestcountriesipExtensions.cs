//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Restcountriesip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RestcountriesipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "restcountriesip")]
        public IBodyWorkflowAction<ALLResponseItem[]> ALL()
        {
            var apiCallPath = "/all";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ALLResponseItem[]>(callPayload);
        }
    }

    public class RestcountriesipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ALLResponseItem
    {
        [JsonProperty("name")]
        public ALLResponseItemNameType Name { get; set; }

        [JsonProperty("tld")]
        public string[] Tld { get; set; }

        [JsonProperty("cca2")]
        public string Cca2 { get; set; }

        [JsonProperty("ccn3")]
        public string Ccn3 { get; set; }

        [JsonProperty("cca3")]
        public string Cca3 { get; set; }

        [JsonProperty("cioc")]
        public string Cioc { get; set; }

        [JsonProperty("independent")]
        public bool Independent { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("unMember")]
        public bool UnMember { get; set; }

        [JsonProperty("currencies")]
        public ALLResponseItemCurrenciesType Currencies { get; set; }

        [JsonProperty("idd")]
        public ALLResponseItemIddType Idd { get; set; }

        [JsonProperty("capital")]
        public string[] Capital { get; set; }

        [JsonProperty("altSpellings")]
        public string[] AltSpellings { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("subregion")]
        public string Subregion { get; set; }

        [JsonProperty("languages")]
        public ALLResponseItemLanguagesType Languages { get; set; }

        [JsonProperty("translations")]
        public ALLResponseItemTranslationsType Translations { get; set; }

        [JsonProperty("latlng")]
        public double[] Latlng { get; set; }

        [JsonProperty("landlocked")]
        public bool Landlocked { get; set; }

        [JsonProperty("borders")]
        public string[] Borders { get; set; }

        [JsonProperty("area")]
        public double Area { get; set; }

        [JsonProperty("demonyms")]
        public ALLResponseItemDemonymsType Demonyms { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("maps")]
        public ALLResponseItemMapsType Maps { get; set; }

        [JsonProperty("population")]
        public double Population { get; set; }

        [JsonProperty("gini")]
        public ALLResponseItemGiniType Gini { get; set; }

        [JsonProperty("fifa")]
        public string Fifa { get; set; }

        [JsonProperty("car")]
        public ALLResponseItemCarType Car { get; set; }

        [JsonProperty("timezones")]
        public string[] Timezones { get; set; }

        [JsonProperty("continents")]
        public string[] Continents { get; set; }

        [JsonProperty("flags")]
        public ALLResponseItemFlagsType Flags { get; set; }

        [JsonProperty("coatOfArms")]
        public ALLResponseItemCoatOfArmsType CoatOfArms { get; set; }

        [JsonProperty("startOfWeek")]
        public string StartOfWeek { get; set; }

        [JsonProperty("capitalInfo")]
        public ALLResponseItemCapitalInfoType CapitalInfo { get; set; }

        [JsonProperty("postalCode")]
        public ALLResponseItemPostalCodeType PostalCode { get; set; }
    }

    public class ALLResponseItemNameType
    {
        [JsonProperty("common")]
        public string Common { get; set; }

        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("nativeName")]
        public ALLResponseItemNameTypeNativeNameType NativeName { get; set; }
    }

    public class ALLResponseItemNameTypeNativeNameType
    {
        [JsonProperty("ara")]
        public ALLResponseItemNameTypeNativeNameTypeAraType Ara { get; set; }

        [JsonProperty("sin")]
        public ALLResponseItemNameTypeNativeNameTypeSinType Sin { get; set; }

        [JsonProperty("tam")]
        public ALLResponseItemNameTypeNativeNameTypeTamType Tam { get; set; }

        [JsonProperty("pol")]
        public ALLResponseItemNameTypeNativeNameTypePolType Pol { get; set; }
    }

    public class ALLResponseItemNameTypeNativeNameTypeAraType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemNameTypeNativeNameTypeSinType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemNameTypeNativeNameTypeTamType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemNameTypeNativeNameTypePolType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemCurrenciesType
    {
        public ALLResponseItemCurrenciesTypeMRUType MRU { get; set; }
        public ALLResponseItemCurrenciesTypeLKRType LKR { get; set; }
        public ALLResponseItemCurrenciesTypePLNType PLN { get; set; }
    }

    public class ALLResponseItemCurrenciesTypeMRUType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }

    public class ALLResponseItemCurrenciesTypeLKRType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }

    public class ALLResponseItemCurrenciesTypePLNType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }

    public class ALLResponseItemIddType
    {
        [JsonProperty("root")]
        public string Root { get; set; }

        [JsonProperty("suffixes")]
        public string[] Suffixes { get; set; }
    }

    public class ALLResponseItemLanguagesType
    {
        [JsonProperty("ara")]
        public string Ara { get; set; }

        [JsonProperty("sin")]
        public string Sin { get; set; }

        [JsonProperty("tam")]
        public string Tam { get; set; }

        [JsonProperty("pol")]
        public string Pol { get; set; }
    }

    public class ALLResponseItemTranslationsType
    {
        [JsonProperty("ara")]
        public ALLResponseItemTranslationsTypeAraType Ara { get; set; }

        [JsonProperty("ces")]
        public ALLResponseItemTranslationsTypeCesType Ces { get; set; }

        [JsonProperty("cym")]
        public ALLResponseItemTranslationsTypeCymType Cym { get; set; }

        [JsonProperty("deu")]
        public ALLResponseItemTranslationsTypeDeuType Deu { get; set; }

        [JsonProperty("est")]
        public ALLResponseItemTranslationsTypeEstType Est { get; set; }

        [JsonProperty("fin")]
        public ALLResponseItemTranslationsTypeFinType Fin { get; set; }

        [JsonProperty("fra")]
        public ALLResponseItemTranslationsTypeFraType Fra { get; set; }

        [JsonProperty("hrv")]
        public ALLResponseItemTranslationsTypeHrvType Hrv { get; set; }

        [JsonProperty("hun")]
        public ALLResponseItemTranslationsTypeHunType Hun { get; set; }

        [JsonProperty("ita")]
        public ALLResponseItemTranslationsTypeItaType Ita { get; set; }

        [JsonProperty("jpn")]
        public ALLResponseItemTranslationsTypeJpnType Jpn { get; set; }

        [JsonProperty("kor")]
        public ALLResponseItemTranslationsTypeKorType Kor { get; set; }

        [JsonProperty("nld")]
        public ALLResponseItemTranslationsTypeNldType Nld { get; set; }

        [JsonProperty("per")]
        public ALLResponseItemTranslationsTypePerType Per { get; set; }

        [JsonProperty("pol")]
        public ALLResponseItemTranslationsTypePolType Pol { get; set; }

        [JsonProperty("por")]
        public ALLResponseItemTranslationsTypePorType Por { get; set; }

        [JsonProperty("rus")]
        public ALLResponseItemTranslationsTypeRusType Rus { get; set; }

        [JsonProperty("slk")]
        public ALLResponseItemTranslationsTypeSlkType Slk { get; set; }

        [JsonProperty("spa")]
        public ALLResponseItemTranslationsTypeSpaType Spa { get; set; }

        [JsonProperty("swe")]
        public ALLResponseItemTranslationsTypeSweType Swe { get; set; }

        [JsonProperty("urd")]
        public ALLResponseItemTranslationsTypeUrdType Urd { get; set; }

        [JsonProperty("zho")]
        public ALLResponseItemTranslationsTypeZhoType Zho { get; set; }
    }

    public class ALLResponseItemTranslationsTypeAraType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemTranslationsTypeCesType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemTranslationsTypeCymType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemTranslationsTypeDeuType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemTranslationsTypeEstType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemTranslationsTypeFinType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemTranslationsTypeFraType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemTranslationsTypeHrvType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemTranslationsTypeHunType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemTranslationsTypeItaType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemTranslationsTypeJpnType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemTranslationsTypeKorType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemTranslationsTypeNldType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemTranslationsTypePerType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemTranslationsTypePolType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemTranslationsTypePorType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemTranslationsTypeRusType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemTranslationsTypeSlkType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemTranslationsTypeSpaType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemTranslationsTypeSweType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemTranslationsTypeUrdType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemTranslationsTypeZhoType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class ALLResponseItemDemonymsType
    {
        [JsonProperty("eng")]
        public ALLResponseItemDemonymsTypeEngType Eng { get; set; }

        [JsonProperty("fra")]
        public ALLResponseItemDemonymsTypeFraType Fra { get; set; }
    }

    public class ALLResponseItemDemonymsTypeEngType
    {
        [JsonProperty("f")]
        public string F { get; set; }

        [JsonProperty("m")]
        public string M { get; set; }
    }

    public class ALLResponseItemDemonymsTypeFraType
    {
        [JsonProperty("f")]
        public string F { get; set; }

        [JsonProperty("m")]
        public string M { get; set; }
    }

    public class ALLResponseItemMapsType
    {
        [JsonProperty("googleMaps")]
        public string GoogleMaps { get; set; }

        [JsonProperty("openStreetMaps")]
        public string OpenStreetMaps { get; set; }
    }

    public class ALLResponseItemGiniType
    {
        [JsonProperty("2014")]
        public double _2014 { get; set; }

        [JsonProperty("2016")]
        public double _2016 { get; set; }

        [JsonProperty("2018")]
        public double _2018 { get; set; }
    }

    public class ALLResponseItemCarType
    {
        [JsonProperty("signs")]
        public string[] Signs { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }
    }

    public class ALLResponseItemFlagsType
    {
        [JsonProperty("png")]
        public string Png { get; set; }

        [JsonProperty("svg")]
        public string Svg { get; set; }
    }

    public class ALLResponseItemCoatOfArmsType
    {
        [JsonProperty("png")]
        public string Png { get; set; }

        [JsonProperty("svg")]
        public string Svg { get; set; }
    }

    public class ALLResponseItemCapitalInfoType
    {
        [JsonProperty("latlng")]
        public double[] Latlng { get; set; }
    }

    public class ALLResponseItemPostalCodeType
    {
        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("regex")]
        public string Regex { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Restcountriesip;

    public partial class WorkflowManagedActions
    {
        public RestcountriesipActions Restcountriesip(string connectionId) => new RestcountriesipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RestcountriesipTriggers Restcountriesip(string connectionId) => new RestcountriesipTriggers(connectionId);
    }
}