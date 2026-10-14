//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Talxisdatafeed
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class TalxisdatafeedActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        public IWorkflowAction CompanyLogo(Expression<Func<jurisdictionCodeInput>> jurisdictionCode, Expression<Func<string>> companyNumber)
        {
            var __workflow_jurisdictionCode = jurisdictionCode == null ? null : WorkflowExpression.Compile(jurisdictionCode);
            WorkflowExpression.Validate(__workflow_jurisdictionCode, nameof(jurisdictionCode), required: true);
            var __workflow_companyNumber = companyNumber == null ? null : WorkflowExpression.Compile(companyNumber);
            WorkflowExpression.Validate(__workflow_companyNumber, nameof(companyNumber), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/Companies/{0}/{1}/logo", ExpressionConverter.ConvertWithUrlEncoding(__workflow_jurisdictionCode, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_companyNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        public IBodyWorkflowAction<DataFeedModelEntitiesCompanyCompanyDetail> GetCompany(Expression<Func<string>> jurisdictionCode, Expression<Func<string>> companyNumber, Expression<Func<string>> language = null)
        {
            var __workflow_jurisdictionCode = jurisdictionCode == null ? null : WorkflowExpression.Compile(jurisdictionCode);
            WorkflowExpression.Validate(__workflow_jurisdictionCode, nameof(jurisdictionCode), required: true);
            var __workflow_companyNumber = companyNumber == null ? null : WorkflowExpression.Compile(companyNumber);
            WorkflowExpression.Validate(__workflow_companyNumber, nameof(companyNumber), required: true);
            var __workflow_language = language == null ? null : WorkflowExpression.Compile(language);
            WorkflowExpression.Validate(__workflow_language, nameof(language), required: false);
            return new DeferredBodyAction<DataFeedModelEntitiesCompanyCompanyDetail>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/Companies/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_jurisdictionCode, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_companyNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                return new ApiConnectionAction<DataFeedModelEntitiesCompanyCompanyDetail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        public IBodyWorkflowAction<DataFeedModelEntitiesCompanyCompanyFinance> GetCompanyFinace(Expression<Func<jurisdictionCodeInput>> jurisdictionCode, Expression<Func<string>> companyNumber)
        {
            var __workflow_jurisdictionCode = jurisdictionCode == null ? null : WorkflowExpression.Compile(jurisdictionCode);
            WorkflowExpression.Validate(__workflow_jurisdictionCode, nameof(jurisdictionCode), required: true);
            var __workflow_companyNumber = companyNumber == null ? null : WorkflowExpression.Compile(companyNumber);
            WorkflowExpression.Validate(__workflow_companyNumber, nameof(companyNumber), required: true);
            return new DeferredBodyAction<DataFeedModelEntitiesCompanyCompanyFinance>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/Companies/{0}/{1}/finance", ExpressionConverter.ConvertWithUrlEncoding(__workflow_jurisdictionCode, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_companyNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DataFeedModelEntitiesCompanyCompanyFinance>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        public IBodyWorkflowAction<GetWeekOfYearResponse> GetWeekOfYear(Expression<Func<string>> time, Expression<Func<ruleInput>> rule, Expression<Func<firstDayOfWeekInput>> firstDayOfWeek)
        {
            var __workflow_time = time == null ? null : WorkflowExpression.Compile(time);
            WorkflowExpression.Validate(__workflow_time, nameof(time), required: true);
            var __workflow_rule = rule == null ? null : WorkflowExpression.Compile(rule);
            WorkflowExpression.Validate(__workflow_rule, nameof(rule), required: true);
            var __workflow_firstDayOfWeek = firstDayOfWeek == null ? null : WorkflowExpression.Compile(firstDayOfWeek);
            WorkflowExpression.Validate(__workflow_firstDayOfWeek, nameof(firstDayOfWeek), required: true);
            return new DeferredBodyAction<GetWeekOfYearResponse>(() =>
            {
                var apiCallPath = "/v1.0/DateTime/GetWeekOfYear";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["time"] = ExpressionConverter.Convert(__workflow_time);
                callPayload.Queries["rule"] = ExpressionConverter.Convert(__workflow_rule);
                callPayload.Queries["firstDayOfWeek"] = ExpressionConverter.Convert(__workflow_firstDayOfWeek);
                return new ApiConnectionAction<GetWeekOfYearResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        public IBodyWorkflowAction<DataFeedModelEntitiesAddress[]> AddressGeocode(Expression<Func<string>> query, Expression<Func<string>> language = null, Expression<Func<string>> region = null)
        {
            var __workflow_query = query == null ? null : WorkflowExpression.Compile(query);
            WorkflowExpression.Validate(__workflow_query, nameof(query), required: true);
            var __workflow_language = language == null ? null : WorkflowExpression.Compile(language);
            WorkflowExpression.Validate(__workflow_language, nameof(language), required: false);
            var __workflow_region = region == null ? null : WorkflowExpression.Compile(region);
            WorkflowExpression.Validate(__workflow_region, nameof(region), required: false);
            return new DeferredBodyAction<DataFeedModelEntitiesAddress[]>(() =>
            {
                var apiCallPath = "/v1.0/Geospatial/address/geocode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                if (__workflow_region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                return new ApiConnectionAction<DataFeedModelEntitiesAddress[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        public IBodyWorkflowAction<GoogleMapsKeyResponse> GoogleMapsKey()
        {
            var apiCallPath = "/v1.0/Maps/google/key";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GoogleMapsKeyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        public IBodyWorkflowAction<string> GetSalutation(Expression<Func<languageInput>> language, Expression<Func<string>> surname, Expression<Func<genderInput>> gender, Expression<Func<string>> title = null, Expression<Func<string>> suffix = null)
        {
            var __workflow_language = language == null ? null : WorkflowExpression.Compile(language);
            WorkflowExpression.Validate(__workflow_language, nameof(language), required: true);
            var __workflow_surname = surname == null ? null : WorkflowExpression.Compile(surname);
            WorkflowExpression.Validate(__workflow_surname, nameof(surname), required: true);
            var __workflow_gender = gender == null ? null : WorkflowExpression.Compile(gender);
            WorkflowExpression.Validate(__workflow_gender, nameof(gender), required: true);
            var __workflow_title = title == null ? null : WorkflowExpression.Compile(title);
            WorkflowExpression.Validate(__workflow_title, nameof(title), required: false);
            var __workflow_suffix = suffix == null ? null : WorkflowExpression.Compile(suffix);
            WorkflowExpression.Validate(__workflow_suffix, nameof(suffix), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/Salutations/{0}/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_language, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["surname"] = ExpressionConverter.Convert(__workflow_surname);
                callPayload.Queries["gender"] = ExpressionConverter.Convert(__workflow_gender);
                if (__workflow_title != null)
                    callPayload.Queries["title"] = ExpressionConverter.Convert(__workflow_title);
                if (__workflow_suffix != null)
                    callPayload.Queries["suffix"] = ExpressionConverter.Convert(__workflow_suffix);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        public IBodyWorkflowAction<DataFeedModelEntitiesHolidays[]> GetHolidays(Expression<Func<string>> countryIsoCode, Expression<Func<string>> year)
        {
            var __workflow_countryIsoCode = countryIsoCode == null ? null : WorkflowExpression.Compile(countryIsoCode);
            WorkflowExpression.Validate(__workflow_countryIsoCode, nameof(countryIsoCode), required: true);
            var __workflow_year = year == null ? null : WorkflowExpression.Compile(year);
            WorkflowExpression.Validate(__workflow_year, nameof(year), required: true);
            return new DeferredBodyAction<DataFeedModelEntitiesHolidays[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/Holidays/countries/{0}/publicHolidays/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_countryIsoCode, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_year, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DataFeedModelEntitiesHolidays[]>(callPayload);
            });
        }
    }

    public class TalxisdatafeedTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum jurisdictionCodeInput
    {
        CZ,
        SK,
        DE
    }

    public class DataFeedModelEntitiesCompanyCompanyDetail
    {
        [JsonProperty("companyNumber")]
        public string CompanyNumber { get; set; }

        [JsonProperty("currentStatus")]
        public string CurrentStatus { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("registeredAddress")]
        public DataFeedModelEntitiesAddress RegisteredAddress { get; set; }

        [JsonProperty("companyType")]
        public string CompanyType { get; set; }

        [JsonProperty("dissolutionDate")]
        public string DissolutionDate { get; set; }

        [JsonProperty("incorporationDate")]
        public string IncorporationDate { get; set; }

        [JsonProperty("reliableVATPayer")]
        public bool ReliableVATPayer { get; set; }

        [JsonProperty("registeredAddressFull")]
        public string RegisteredAddressFull { get; set; }

        [JsonProperty("jurisdictionCode")]
        public string JurisdictionCode { get; set; }

        [JsonProperty("registryUrl")]
        public string RegistryUrl { get; set; }

        [JsonProperty("filings")]
        public DataFeedModelEntitiesFiling[] Filings { get; set; }

        [JsonProperty("data")]
        public DataFeedModelEntitiesDatum[] Data { get; set; }

        [JsonProperty("bankAccounts")]
        public DataFeedModelEntitiesBankAccount[] BankAccounts { get; set; }
    }

    public class DataFeedModelEntitiesAddress
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("subLocality")]
        public string SubLocality { get; set; }

        [JsonProperty("formattedPostalCode")]
        public string FormattedPostalCode { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("streetNumber")]
        public string StreetNumber { get; set; }

        [JsonProperty("administrativeArea")]
        public string AdministrativeArea { get; set; }
    }

    public class DataFeedModelEntitiesFiling
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class DataFeedModelEntitiesDatum
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }
    }

    public class DataFeedModelEntitiesBankAccount
    {
        [JsonProperty("accountCode")]
        public string AccountCode { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("accountType")]
        public string AccountType { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }
    }

    public class DataFeedModelEntitiesCompanyCompanyFinance
    {
        [JsonProperty("revenue")]
        public DataFeedModelEntitiesCompanyCompanyFinanceRevenueType Revenue { get; set; }

        [JsonProperty("court")]
        public string Court { get; set; }

        [JsonProperty("owners")]
        public DataFeedModelEntitiesOwners[] Owners { get; set; }

        [JsonProperty("dateEstablished")]
        public string DateEstablished { get; set; }

        [JsonProperty("riskIndicator")]
        public double RiskIndicator { get; set; }

        [JsonProperty("legalForm")]
        public DataFeedModelEntitiesCompanyCompanyFinanceLegalFormType LegalForm { get; set; }
    }

    public class DataFeedModelEntitiesCompanyCompanyFinanceRevenueType
    {
        [JsonProperty("average")]
        public double Average { get; set; }

        [JsonProperty("upperBound")]
        public double UpperBound { get; set; }

        [JsonProperty("lowerBound")]
        public double LowerBound { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class DataFeedModelEntitiesOwners
    {
        [JsonProperty("dateofbirth")]
        public string Dateofbirth { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("share")]
        public double Share { get; set; }

        [JsonProperty("registeredaddress")]
        public DataFeedModelEntitiesRegisteredAddress Registeredaddress { get; set; }
    }

    public class DataFeedModelEntitiesRegisteredAddress
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("streetName")]
        public string StreetName { get; set; }

        [JsonProperty("orientationNumber")]
        public string OrientationNumber { get; set; }

        [JsonProperty("cityPart")]
        public string CityPart { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("admcode")]
        public string Admcode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("streetNumber")]
        public string StreetNumber { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("cityDistrict")]
        public string CityDistrict { get; set; }
    }

    public class DataFeedModelEntitiesCompanyCompanyFinanceLegalFormType
    {
        public string Text { get; set; }
    }

    public class GetWeekOfYearResponse
    {
        [JsonProperty("weekNumber")]
        public int WeekNumber { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ruleInput
    {
        FirstDay,
        FirstFullWeek,
        FirstFourDayWeek
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum firstDayOfWeekInput
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public class GoogleMapsKeyResponse
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("expiresOn")]
        public string ExpiresOn { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum languageInput
    {
        CS,
        SK
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum genderInput
    {
        [EnumMember(Value = "male")]
        Male,
        [EnumMember(Value = "female")]
        Female
    }

    public class DataFeedModelEntitiesHolidays
    {
        [JsonProperty("global")]
        public bool Global { get; set; }

        [JsonProperty("fixed")]
        public bool Fixed { get; set; }

        [JsonProperty("types")]
        public DataFeedModelEntitiesHolidaysTypesType Types { get; set; }

        [JsonProperty("launchYear")]
        public int LaunchYear { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("localName")]
        public string LocalName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("counties")]
        public string[] Counties { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DataFeedModelEntitiesHolidaysTypesType
    {
        Public,
        Bank,
        School,
        Authorities,
        Optional,
        Observance
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Talxisdatafeed;

    public partial class WorkflowManagedActions
    {
        public TalxisdatafeedActions Talxisdatafeed(string connectionId) => new TalxisdatafeedActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TalxisdatafeedTriggers Talxisdatafeed(string connectionId) => new TalxisdatafeedTriggers(connectionId);
    }
}
