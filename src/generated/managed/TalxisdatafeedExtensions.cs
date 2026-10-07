//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Talxisdatafeed
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TalxisdatafeedActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        [WorkflowExpressionFactory(nameof(__BuildCompanyLogo))]
        public IWorkflowAction CompanyLogo([WorkflowExpression] Func<jurisdictionCodeInput> jurisdictionCode, [WorkflowExpression] Func<string> companyNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCompanyLogo(WorkflowExpression<jurisdictionCodeInput> jurisdictionCode, WorkflowExpression<string> companyNumber)
        {
            WorkflowExpression.Validate(jurisdictionCode, nameof(jurisdictionCode), required: true);
            WorkflowExpression.Validate(companyNumber, nameof(companyNumber), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/Companies/{0}/{1}/logo", ExpressionConverter.ConvertWithUrlEncoding(jurisdictionCode, 1), ExpressionConverter.ConvertWithUrlEncoding(companyNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        [WorkflowExpressionFactory(nameof(__BuildGetCompany))]
        public IBodyWorkflowAction<DataFeedModelEntitiesCompanyCompanyDetail> GetCompany([WorkflowExpression] Func<string> jurisdictionCode, [WorkflowExpression] Func<string> companyNumber, [WorkflowExpression] Func<string> language = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DataFeedModelEntitiesCompanyCompanyDetail> __BuildGetCompany(WorkflowExpression<string> jurisdictionCode, WorkflowExpression<string> companyNumber, WorkflowExpression<string> language = null)
        {
            WorkflowExpression.Validate(jurisdictionCode, nameof(jurisdictionCode), required: true);
            WorkflowExpression.Validate(companyNumber, nameof(companyNumber), required: true);
            WorkflowExpression.Validate(language, nameof(language), required: false);
            return new DeferredBodyAction<DataFeedModelEntitiesCompanyCompanyDetail>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/Companies/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(jurisdictionCode, 1), ExpressionConverter.ConvertWithUrlEncoding(companyNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(language);
                return new ApiConnectionAction<DataFeedModelEntitiesCompanyCompanyDetail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        [WorkflowExpressionFactory(nameof(__BuildGetCompanyFinace))]
        public IBodyWorkflowAction<DataFeedModelEntitiesCompanyCompanyFinance> GetCompanyFinace([WorkflowExpression] Func<jurisdictionCodeInput> jurisdictionCode, [WorkflowExpression] Func<string> companyNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DataFeedModelEntitiesCompanyCompanyFinance> __BuildGetCompanyFinace(WorkflowExpression<jurisdictionCodeInput> jurisdictionCode, WorkflowExpression<string> companyNumber)
        {
            WorkflowExpression.Validate(jurisdictionCode, nameof(jurisdictionCode), required: true);
            WorkflowExpression.Validate(companyNumber, nameof(companyNumber), required: true);
            return new DeferredBodyAction<DataFeedModelEntitiesCompanyCompanyFinance>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/Companies/{0}/{1}/finance", ExpressionConverter.ConvertWithUrlEncoding(jurisdictionCode, 1), ExpressionConverter.ConvertWithUrlEncoding(companyNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DataFeedModelEntitiesCompanyCompanyFinance>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        [WorkflowExpressionFactory(nameof(__BuildGetWeekOfYear))]
        public IBodyWorkflowAction<GetWeekOfYearResponse> GetWeekOfYear([WorkflowExpression] Func<string> time, [WorkflowExpression] Func<ruleInput> rule, [WorkflowExpression] Func<firstDayOfWeekInput> firstDayOfWeek)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetWeekOfYearResponse> __BuildGetWeekOfYear(WorkflowExpression<string> time, WorkflowExpression<ruleInput> rule, WorkflowExpression<firstDayOfWeekInput> firstDayOfWeek)
        {
            WorkflowExpression.Validate(time, nameof(time), required: true);
            WorkflowExpression.Validate(rule, nameof(rule), required: true);
            WorkflowExpression.Validate(firstDayOfWeek, nameof(firstDayOfWeek), required: true);
            return new DeferredBodyAction<GetWeekOfYearResponse>(() =>
            {
                var apiCallPath = "/v1.0/DateTime/GetWeekOfYear";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["time"] = ExpressionConverter.Convert(time);
                callPayload.Queries["rule"] = ExpressionConverter.Convert(rule);
                callPayload.Queries["firstDayOfWeek"] = ExpressionConverter.Convert(firstDayOfWeek);
                return new ApiConnectionAction<GetWeekOfYearResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        [WorkflowExpressionFactory(nameof(__BuildAddressGeocode))]
        public IBodyWorkflowAction<DataFeedModelEntitiesAddress[]> AddressGeocode([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<string> region = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DataFeedModelEntitiesAddress[]> __BuildAddressGeocode(WorkflowExpression<string> query, WorkflowExpression<string> language = null, WorkflowExpression<string> region = null)
        {
            WorkflowExpression.Validate(query, nameof(query), required: true);
            WorkflowExpression.Validate(language, nameof(language), required: false);
            WorkflowExpression.Validate(region, nameof(region), required: false);
            return new DeferredBodyAction<DataFeedModelEntitiesAddress[]>(() =>
            {
                var apiCallPath = "/v1.0/Geospatial/address/geocode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                if (language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(language);
                if (region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(region);
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
        [WorkflowExpressionFactory(nameof(__BuildGetSalutation))]
        public IBodyWorkflowAction<string> GetSalutation([WorkflowExpression] Func<languageInput> language, [WorkflowExpression] Func<string> surname, [WorkflowExpression] Func<genderInput> gender, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string> suffix = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetSalutation(WorkflowExpression<languageInput> language, WorkflowExpression<string> surname, WorkflowExpression<genderInput> gender, WorkflowExpression<string> title = null, WorkflowExpression<string> suffix = null)
        {
            WorkflowExpression.Validate(language, nameof(language), required: true);
            WorkflowExpression.Validate(surname, nameof(surname), required: true);
            WorkflowExpression.Validate(gender, nameof(gender), required: true);
            WorkflowExpression.Validate(title, nameof(title), required: false);
            WorkflowExpression.Validate(suffix, nameof(suffix), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/Salutations/{0}/", ExpressionConverter.ConvertWithUrlEncoding(language, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["surname"] = ExpressionConverter.Convert(surname);
                callPayload.Queries["gender"] = ExpressionConverter.Convert(gender);
                if (title != null)
                    callPayload.Queries["title"] = ExpressionConverter.Convert(title);
                if (suffix != null)
                    callPayload.Queries["suffix"] = ExpressionConverter.Convert(suffix);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        [WorkflowExpressionFactory(nameof(__BuildGetHolidays))]
        public IBodyWorkflowAction<DataFeedModelEntitiesHolidays[]> GetHolidays([WorkflowExpression] Func<string> countryIsoCode, [WorkflowExpression] Func<string> year)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "talxisdatafeed")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DataFeedModelEntitiesHolidays[]> __BuildGetHolidays(WorkflowExpression<string> countryIsoCode, WorkflowExpression<string> year)
        {
            WorkflowExpression.Validate(countryIsoCode, nameof(countryIsoCode), required: true);
            WorkflowExpression.Validate(year, nameof(year), required: true);
            return new DeferredBodyAction<DataFeedModelEntitiesHolidays[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/Holidays/countries/{0}/publicHolidays/{1}", ExpressionConverter.ConvertWithUrlEncoding(countryIsoCode, 1), ExpressionConverter.ConvertWithUrlEncoding(year, 1));
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