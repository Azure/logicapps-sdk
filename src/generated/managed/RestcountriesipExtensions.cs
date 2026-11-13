//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Restcountriesip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RestcountriesipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "restcountriesip")]
        public IBodyWorkflowAction<AllResponseItem[], ApiConnectionActionConfiguration> All()
        {
            return new DeferredBodyAction<AllResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/all";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AllResponseItem[]>(callPayload);
            });
        }
    }

    public class RestcountriesipTriggers([ConnectionName] string connectionId)
    {
    }

    public class AllResponseItem
    {
        [JsonProperty("name")]
        public AllResponseItemNameType Name { get; set; }

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
        public AllResponseItemCurrenciesType Currencies { get; set; }

        [JsonProperty("idd")]
        public AllResponseItemIddType Idd { get; set; }

        [JsonProperty("capital")]
        public string[] Capital { get; set; }

        [JsonProperty("altSpellings")]
        public string[] AltSpellings { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("subregion")]
        public string Subregion { get; set; }

        [JsonProperty("languages")]
        public AllResponseItemLanguagesType Languages { get; set; }

        [JsonProperty("translations")]
        public AllResponseItemTranslationsType Translations { get; set; }

        [JsonProperty("latlng")]
        public double[] Latlng { get; set; }

        [JsonProperty("landlocked")]
        public bool Landlocked { get; set; }

        [JsonProperty("borders")]
        public string[] Borders { get; set; }

        [JsonProperty("area")]
        public double Area { get; set; }

        [JsonProperty("demonyms")]
        public AllResponseItemDemonymsType Demonyms { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("maps")]
        public AllResponseItemMapsType Maps { get; set; }

        [JsonProperty("population")]
        public double Population { get; set; }

        [JsonProperty("gini")]
        public AllResponseItemGiniType Gini { get; set; }

        [JsonProperty("fifa")]
        public string Fifa { get; set; }

        [JsonProperty("car")]
        public AllResponseItemCarType Car { get; set; }

        [JsonProperty("timezones")]
        public string[] Timezones { get; set; }

        [JsonProperty("continents")]
        public string[] Continents { get; set; }

        [JsonProperty("flags")]
        public AllResponseItemFlagsType Flags { get; set; }

        [JsonProperty("coatOfArms")]
        public AllResponseItemCoatOfArmsType CoatOfArms { get; set; }

        [JsonProperty("startOfWeek")]
        public string StartOfWeek { get; set; }

        [JsonProperty("capitalInfo")]
        public AllResponseItemCapitalInfoType CapitalInfo { get; set; }

        [JsonProperty("postalCode")]
        public AllResponseItemPostalCodeType PostalCode { get; set; }
    }

    public class AllResponseItemNameType
    {
        [JsonProperty("common")]
        public string Common { get; set; }

        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("nativeName")]
        public AllResponseItemNameTypeNativeNameType NativeName { get; set; }
    }

    public class AllResponseItemNameTypeNativeNameType
    {
        [JsonProperty("ara")]
        public AllResponseItemNameTypeNativeNameTypeAraType Ara { get; set; }

        [JsonProperty("sin")]
        public AllResponseItemNameTypeNativeNameTypeSinType Sin { get; set; }

        [JsonProperty("tam")]
        public AllResponseItemNameTypeNativeNameTypeTamType Tam { get; set; }

        [JsonProperty("pol")]
        public AllResponseItemNameTypeNativeNameTypePolType Pol { get; set; }
    }

    public class AllResponseItemNameTypeNativeNameTypeAraType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemNameTypeNativeNameTypeSinType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemNameTypeNativeNameTypeTamType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemNameTypeNativeNameTypePolType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemCurrenciesType
    {
        [JsonProperty("MRU")]
        public AllResponseItemCurrenciesTypeMruType Mru { get; set; }

        [JsonProperty("LKR")]
        public AllResponseItemCurrenciesTypeLkrType Lkr { get; set; }

        [JsonProperty("PLN")]
        public AllResponseItemCurrenciesTypePlnType Pln { get; set; }
    }

    public class AllResponseItemCurrenciesTypeMruType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }

    public class AllResponseItemCurrenciesTypeLkrType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }

    public class AllResponseItemCurrenciesTypePlnType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }

    public class AllResponseItemIddType
    {
        [JsonProperty("root")]
        public string Root { get; set; }

        [JsonProperty("suffixes")]
        public string[] Suffixes { get; set; }
    }

    public class AllResponseItemLanguagesType
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

    public class AllResponseItemTranslationsType
    {
        [JsonProperty("ara")]
        public AllResponseItemTranslationsTypeAraType Ara { get; set; }

        [JsonProperty("ces")]
        public AllResponseItemTranslationsTypeCesType Ces { get; set; }

        [JsonProperty("cym")]
        public AllResponseItemTranslationsTypeCymType Cym { get; set; }

        [JsonProperty("deu")]
        public AllResponseItemTranslationsTypeDeuType Deu { get; set; }

        [JsonProperty("est")]
        public AllResponseItemTranslationsTypeEstType Est { get; set; }

        [JsonProperty("fin")]
        public AllResponseItemTranslationsTypeFinType Fin { get; set; }

        [JsonProperty("fra")]
        public AllResponseItemTranslationsTypeFraType Fra { get; set; }

        [JsonProperty("hrv")]
        public AllResponseItemTranslationsTypeHrvType Hrv { get; set; }

        [JsonProperty("hun")]
        public AllResponseItemTranslationsTypeHunType Hun { get; set; }

        [JsonProperty("ita")]
        public AllResponseItemTranslationsTypeItaType Ita { get; set; }

        [JsonProperty("jpn")]
        public AllResponseItemTranslationsTypeJpnType Jpn { get; set; }

        [JsonProperty("kor")]
        public AllResponseItemTranslationsTypeKorType Kor { get; set; }

        [JsonProperty("nld")]
        public AllResponseItemTranslationsTypeNldType Nld { get; set; }

        [JsonProperty("per")]
        public AllResponseItemTranslationsTypePerType Per { get; set; }

        [JsonProperty("pol")]
        public AllResponseItemTranslationsTypePolType Pol { get; set; }

        [JsonProperty("por")]
        public AllResponseItemTranslationsTypePorType Por { get; set; }

        [JsonProperty("rus")]
        public AllResponseItemTranslationsTypeRusType Rus { get; set; }

        [JsonProperty("slk")]
        public AllResponseItemTranslationsTypeSlkType Slk { get; set; }

        [JsonProperty("spa")]
        public AllResponseItemTranslationsTypeSpaType Spa { get; set; }

        [JsonProperty("swe")]
        public AllResponseItemTranslationsTypeSweType Swe { get; set; }

        [JsonProperty("urd")]
        public AllResponseItemTranslationsTypeUrdType Urd { get; set; }

        [JsonProperty("zho")]
        public AllResponseItemTranslationsTypeZhoType Zho { get; set; }
    }

    public class AllResponseItemTranslationsTypeAraType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemTranslationsTypeCesType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemTranslationsTypeCymType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemTranslationsTypeDeuType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemTranslationsTypeEstType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemTranslationsTypeFinType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemTranslationsTypeFraType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemTranslationsTypeHrvType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemTranslationsTypeHunType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemTranslationsTypeItaType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemTranslationsTypeJpnType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemTranslationsTypeKorType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemTranslationsTypeNldType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemTranslationsTypePerType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemTranslationsTypePolType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemTranslationsTypePorType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemTranslationsTypeRusType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemTranslationsTypeSlkType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemTranslationsTypeSpaType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemTranslationsTypeSweType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemTranslationsTypeUrdType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemTranslationsTypeZhoType
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class AllResponseItemDemonymsType
    {
        [JsonProperty("eng")]
        public AllResponseItemDemonymsTypeEngType Eng { get; set; }

        [JsonProperty("fra")]
        public AllResponseItemDemonymsTypeFraType Fra { get; set; }
    }

    public class AllResponseItemDemonymsTypeEngType
    {
        [JsonProperty("f")]
        public string F { get; set; }

        [JsonProperty("m")]
        public string M { get; set; }
    }

    public class AllResponseItemDemonymsTypeFraType
    {
        [JsonProperty("f")]
        public string F { get; set; }

        [JsonProperty("m")]
        public string M { get; set; }
    }

    public class AllResponseItemMapsType
    {
        [JsonProperty("googleMaps")]
        public string GoogleMaps { get; set; }

        [JsonProperty("openStreetMaps")]
        public string OpenStreetMaps { get; set; }
    }

    public class AllResponseItemGiniType
    {
        [JsonProperty("2014")]
        public double _2014 { get; set; }

        [JsonProperty("2016")]
        public double _2016 { get; set; }

        [JsonProperty("2018")]
        public double _2018 { get; set; }
    }

    public class AllResponseItemCarType
    {
        [JsonProperty("signs")]
        public string[] Signs { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }
    }

    public class AllResponseItemFlagsType
    {
        [JsonProperty("png")]
        public string Png { get; set; }

        [JsonProperty("svg")]
        public string Svg { get; set; }
    }

    public class AllResponseItemCoatOfArmsType
    {
        [JsonProperty("png")]
        public string Png { get; set; }

        [JsonProperty("svg")]
        public string Svg { get; set; }
    }

    public class AllResponseItemCapitalInfoType
    {
        [JsonProperty("latlng")]
        public double[] Latlng { get; set; }
    }

    public class AllResponseItemPostalCodeType
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