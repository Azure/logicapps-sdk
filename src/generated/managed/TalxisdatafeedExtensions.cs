//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Talxisdatafeed
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TalxisdatafeedActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        public IWorkflowAction CompanyLogo(Expression<Func<jurisdictionCodeInput>> jurisdictionCode, Expression<Func<string>> companyNumber)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/Companies/{0}/{1}/logo", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(jurisdictionCode, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(companyNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        public IBodyWorkflowAction<DataFeedModelEntitiesCompanyCompanyDetail> GetCompany(Expression<Func<string>> jurisdictionCode, Expression<Func<string>> companyNumber, Expression<Func<string>> language = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/Companies/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(jurisdictionCode, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(companyNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (language != null)
                callPayload.Queries["language"] = CSharpExpressionConverter.ConvertO(language);
            return new ApiConnectionAction<DataFeedModelEntitiesCompanyCompanyDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        public IBodyWorkflowAction<DataFeedModelEntitiesCompanyCompanyFinance> GetCompanyFinace(Expression<Func<jurisdictionCodeInput>> jurisdictionCode, Expression<Func<string>> companyNumber)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/Companies/{0}/{1}/finance", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(jurisdictionCode, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(companyNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DataFeedModelEntitiesCompanyCompanyFinance>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        public IBodyWorkflowAction<GetWeekOfYearResponse> GetWeekOfYear(Expression<Func<string>> time, Expression<Func<ruleInput>> rule, Expression<Func<firstDayOfWeekInput>> firstDayOfWeek)
        {
            var apiCallPath = "/v1.0/DateTime/GetWeekOfYear";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["time"] = CSharpExpressionConverter.ConvertO(time);
            callPayload.Queries["rule"] = CSharpExpressionConverter.Convert(rule);
            callPayload.Queries["firstDayOfWeek"] = CSharpExpressionConverter.Convert(firstDayOfWeek);
            return new ApiConnectionAction<GetWeekOfYearResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        public IBodyWorkflowAction<DataFeedModelEntitiesAddress[]> AddressGeocode(Expression<Func<string>> query, Expression<Func<string>> language = null, Expression<Func<string>> region = null)
        {
            var apiCallPath = "/v1.0/Geospatial/address/geocode";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["query"] = CSharpExpressionConverter.ConvertO(query);
            if (language != null)
                callPayload.Queries["language"] = CSharpExpressionConverter.ConvertO(language);
            if (region != null)
                callPayload.Queries["region"] = CSharpExpressionConverter.ConvertO(region);
            return new ApiConnectionAction<DataFeedModelEntitiesAddress[]>(callPayload);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/Salutations/{0}/", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(language, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["surname"] = CSharpExpressionConverter.ConvertO(surname);
            callPayload.Queries["gender"] = CSharpExpressionConverter.Convert(gender);
            if (title != null)
                callPayload.Queries["title"] = CSharpExpressionConverter.ConvertO(title);
            if (suffix != null)
                callPayload.Queries["suffix"] = CSharpExpressionConverter.ConvertO(suffix);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        public IBodyWorkflowAction<DataFeedModelEntitiesHolidays[]> GetHolidays(Expression<Func<string>> countryIsoCode, Expression<Func<string>> year)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/Holidays/countries/{0}/publicHolidays/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(countryIsoCode, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(year, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DataFeedModelEntitiesHolidays[]>(callPayload);
        }
    }

    public class TalxisdatafeedTriggers([ConnectionName] string connectionId)
    {
    }

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

    public enum ruleInput
    {
        FirstDay,
        FirstFullWeek,
        FirstFourDayWeek
    }

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

    public enum languageInput
    {
        CS,
        SK
    }

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