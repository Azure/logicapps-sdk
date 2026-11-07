//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Data8
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Data8Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsUsableNameResponse, ApiConnectionActionConfiguration> IsUsableName(Expression<Func<IsUsableNameBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<IsUsableNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SalaciousName/IsUnusableName.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IsUsableNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsCallableTPSResponse, ApiConnectionActionConfiguration> IsCallableTPS(Expression<Func<IsCallableCTPSBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<IsCallableTPSResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/TPS/IsCallable.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IsCallableTPSResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsCallableCTPSResponse, ApiConnectionActionConfiguration> IsCallableCTPS(Expression<Func<IsCallableCTPSBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<IsCallableCTPSResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CTPS/IsCallable.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IsCallableCTPSResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsValidBankAccountResponse, ApiConnectionActionConfiguration> IsValidBankAccount(Expression<Func<IsValidBankAccountBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<IsValidBankAccountResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BankAccountValidation/IsValid.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IsValidBankAccountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsValidEmailResponse, ApiConnectionActionConfiguration> IsValidEmail(Expression<Func<IsValidEmailBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<IsValidEmailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EmailValidation/IsValid.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IsValidEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsValidTelephoneResponse, ApiConnectionActionConfiguration> IsValidTelephone(Expression<Func<IsValidTelephoneBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<IsValidTelephoneResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/InternationalTelephoneValidation/IsValid.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IsValidTelephoneResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<CleanAddressResponse, ApiConnectionActionConfiguration> CleanAddress(Expression<Func<CleanAddressBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CleanAddressResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Postcoder/CleanAddress.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CleanAddressResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<GetFullAddressResponse, ApiConnectionActionConfiguration> GetFullAddress(Expression<Func<GetFullAddressBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetFullAddressResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AddressCapture/GetFullAddress.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetFullAddressResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsDeceasedResponse, ApiConnectionActionConfiguration> IsDeceased(Expression<Func<IsDeceasedBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IsDeceasedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Deceased/IsDeceased.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IsDeceasedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<SearchPredictiveAddressResponse, ApiConnectionActionConfiguration> SearchPredictiveAddress(Expression<Func<SearchPredictiveAddressBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SearchPredictiveAddressResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PredictiveAddress/Search.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SearchPredictiveAddressResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<DrilldownPredictiveAddressResponse, ApiConnectionActionConfiguration> DrilldownPredictiveAddress(Expression<Func<DrilldownPredictiveAddressBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DrilldownPredictiveAddressResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PredictiveAddress/DrillDown.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DrilldownPredictiveAddressResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<RetrievePredictiveAddressResponse, ApiConnectionActionConfiguration> RetrievePredictiveAddress(Expression<Func<RetrievePredictiveAddressBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<RetrievePredictiveAddressResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PredictiveAddress/Retrieve.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RetrievePredictiveAddressResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<CleanseEmailResponse, ApiConnectionActionConfiguration> CleanseEmail(Expression<Func<CleanseEmailBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CleanseEmailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EmailValidation/CleanseSimple.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CleanseEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsValidPhoneResponse, ApiConnectionActionConfiguration> IsValidPhone(Expression<Func<IsValidPhoneBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<IsValidPhoneResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PhoneValidation/IsValid.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IsValidPhoneResponse>(callPayload);
            });
        }
    }

    public class Data8Triggers([ConnectionName] string connectionId)
    {
    }

    public class IsUsableNameResponse
    {
        public IsUsableNameResponseStatusType Status { get; set; }
        public IsUsableNameResponseResultType Result { get; set; }
    }

    public class IsUsableNameResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IsUsableNameResponseResultType
    {
        [EnumMember(Value = "")]
        None,
        IncompleteName,
        RandomName,
        SalaciousName
    }

    public class IsUsableNameBodyInput
    {
        [JsonProperty("name")]
        public BodyInputNameType Name { get; set; }
    }

    public class BodyInputNameType
    {
        public string Title { get; set; }
        public string Forename { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
    }

    public class IsCallableTPSResponse
    {
        public IsCallableTPSResponseStatusType Status { get; set; }
        public bool Callable { get; set; }
        public string TelephoneNumber { get; set; }
    }

    public class IsCallableTPSResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class IsCallableCTPSBodyInput
    {
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Number { get; set; }
    }

    public class IsCallableCTPSResponse
    {
        public IsCallableCTPSResponseStatusType Status { get; set; }
        public bool Callable { get; set; }
        public string TelephoneNumber { get; set; }
    }

    public class IsCallableCTPSResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class IsValidBankAccountResponse
    {
        public IsValidBankAccountResponseStatusType Status { get; set; }
        public string Valid { get; set; }
        public string SortCode { get; set; }
        public string AccountNumber { get; set; }
        public string BICCode { get; set; }
        public string IBAN { get; set; }
        public string BranchName { get; set; }
        public string ShortBankName { get; set; }
        public string FullBankName { get; set; }
        public IsValidBankAccountResponseAddressType Address { get; set; }
        public bool AcceptsBACSPayments { get; set; }
        public bool AcceptsDirectDebitTransactions { get; set; }
        public bool AcceptsDirectCreditTransactions { get; set; }
        public bool AcceptsUnpaidChequeClaimTransactions { get; set; }
        public bool AcceptsBuildingSocietyCreditTransactions { get; set; }
        public bool AcceptsDividendInterestPaymentTransactions { get; set; }
        public bool AcceptsDirectDebitInstructionTransactions { get; set; }
        public bool AcceptsCHAPSPayments { get; set; }
        public bool AcceptsCheques { get; set; }
        public bool AcceptsFasterPayments { get; set; }
    }

    public class IsValidBankAccountResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class IsValidBankAccountResponseAddressType
    {
        public IsValidBankAccountResponseAddressTypeAddressType Address { get; set; }
    }

    public class IsValidBankAccountResponseAddressTypeAddressType
    {
        public string[] Lines { get; set; }
    }

    public class IsValidBankAccountBodyInput
    {
        [JsonProperty("sortCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SortCode { get; set; }

        [JsonProperty("bankAccountNumber")]
        public string BankAccountNumber { get; set; }
    }

    public class IsValidEmailResponse
    {
        public IsValidEmailResponseStatusType Status { get; set; }
        public string Result { get; set; }
    }

    public class IsValidEmailResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class IsValidEmailBodyInput
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("level", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputLevelType Level { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Data8.BodyInputLevelType.Server;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputLevelType
    {
        Syntax,
        MX,
        Server,
        Address
    }

    public class IsValidTelephoneResponse
    {
        public IsValidTelephoneResponseStatusType Status { get; set; }
        public IsValidTelephoneResponseResultType Result { get; set; }
    }

    public class IsValidTelephoneResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class IsValidTelephoneResponseResultType
    {
        public string TelephoneNumber { get; set; }
        public string ValidationResult { get; set; }
        public string ValidationLevel { get; set; }
        public string NumberType { get; set; }
        public string Location { get; set; }
        public string Provider { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
    }

    public class IsValidTelephoneBodyInput
    {
        [JsonProperty("telephoneNumber", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TelephoneNumber { get; set; }

        [JsonProperty("defaultCountry", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DefaultCountry { get; set; }

        [JsonProperty("options")]
        public IsValidTelephoneBodyInputOptionsType Options { get; set; }
    }

    public class IsValidTelephoneBodyInputOptionsType
    {
        public bool? UseLineValidation { get; set; }
        public bool? UseMobileValidation { get; set; }
    }

    public class CleanAddressResponse
    {
        public CleanAddressResponseStatusType Status { get; set; }
        public CleanAddressResponseResultType Result { get; set; }
        public string MatchLevel { get; set; }
        public string CountryName { get; set; }
    }

    public class CleanAddressResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class CleanAddressResponseResultType
    {
        public CleanAddressResponseResultTypeAddressType Address { get; set; }
    }

    public class CleanAddressResponseResultTypeAddressType
    {
        public string[] Lines { get; set; }
    }

    public class CleanAddressBodyInput
    {
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputAddressType Address { get; set; }

        [JsonProperty("options")]
        public CleanAddressBodyInputOptionsType Options { get; set; }
    }

    public class BodyInputAddressType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Lines { get; set; }
    }

    public class CleanAddressBodyInputOptionsType
    {
        public string DefaultCountryCode { get; set; }
        public bool? DetectCountry { get; set; }
        public string Country { get; set; }
        public bool? IncludeCountry { get; set; }
    }

    public class GetFullAddressResponse
    {
        public GetFullAddressResponseStatusType Status { get; set; }
        public int ResultCount { get; set; }
        public GetFullAddressResponseResultsTypeItem[] Results { get; set; }
    }

    public class GetFullAddressResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class GetFullAddressResponseResultsTypeItem
    {
        public GetFullAddressResponseResultsTypeItemAddressType Address { get; set; }
        public GetFullAddressResponseResultsTypeItemRawAddressType RawAddress { get; set; }
    }

    public class GetFullAddressResponseResultsTypeItemAddressType
    {
        public string[] Lines { get; set; }
    }

    public class GetFullAddressResponseResultsTypeItemRawAddressType
    {
        public string Organisation { get; set; }
        public string Department { get; set; }
        public int AddressKey { get; set; }
        public int OrganisationKey { get; set; }
        public string PostcodeType { get; set; }
        public int BuildingNumber { get; set; }
        public string SubBuildingName { get; set; }
        public string BuildingName { get; set; }
        public string DependentThoroughfareName { get; set; }
        public string DependentThoroughfareDesc { get; set; }
        public string ThoroughfareName { get; set; }
        public string ThoroughfareDesc { get; set; }
        public string DoubleDependentLocality { get; set; }
        public string DependentLocality { get; set; }
        public string Locality { get; set; }
        public string Postcode { get; set; }
        public string Dps { get; set; }
        public string PoBox { get; set; }
        public string PostalCounty { get; set; }
        public string TraditionalCounty { get; set; }
        public string AdministrativeCounty { get; set; }
        public string CountryISO2 { get; set; }
        public string UniqueReference { get; set; }
        public GetFullAddressResponseResultsTypeItemRawAddressTypeLocationType Location { get; set; }
    }

    public class GetFullAddressResponseResultsTypeItemRawAddressTypeLocationType
    {
        public int Easting { get; set; }
        public int Northing { get; set; }
        public string GridReference { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string CountyCode { get; set; }
        public string County { get; set; }
        public string DistrictCode { get; set; }
        public string District { get; set; }
        public string WardCode { get; set; }
        public string Ward { get; set; }
        public string Country { get; set; }
    }

    public class GetFullAddressBodyInput
    {
        [JsonProperty("licence", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputLicenceType Licence { get; set; }

        [JsonProperty("postcode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Postcode { get; set; }

        [JsonProperty("building")]
        public string Building { get; set; }

        [JsonProperty("options", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetFullAddressBodyInputOptionsType Options { get; set; } = new GetFullAddressBodyInputOptionsType();
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputLicenceType
    {
        InternalUserFull,
        InternalUserFullArea,
        SmallUserFull,
        WebClickFull,
        WebServerFull,
        Lookup,
        InternalServerFull,
        FreeTrial
    }

    public class GetFullAddressBodyInputOptionsType
    {
        public bool? FixTownCounty { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxLines { get; set; } = 6;
        public int? MaxLineLength { get; set; }
        public bool? NormalizeCase { get; set; }
        public bool? NormalizeTownCase { get; set; }
        public bool? ExcludeCounty { get; set; }
        public bool? UseAnyAvailableCounty { get; set; }
        public bool? UnwantedPunctuation { get; set; }
        public bool? FixBuilding { get; set; }
        public bool? IncludeUDPRN { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeLocation { get; set; } = true;
        public bool? ReturnResultCount { get; set; }
        public bool? IncludeNYB { get; set; }
        public bool? IncludeMR { get; set; }
        public BodyInputOptionsTypeFormatterType? Formatter { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputOptionsTypeFormatterType
    {
        DefaultFormatter,
        PAFStandardFormatter,
        NoOrganisationFormatter
    }

    public class IsDeceasedResponse
    {
        public IsDeceasedResponseStatusType Status { get; set; }
        public bool Result { get; set; }
    }

    public class IsDeceasedResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class IsDeceasedBodyInput
    {
        [JsonProperty("record", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRecordType Record { get; set; }

        [JsonProperty("marketing", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Marketing { get; set; } = true;

        [JsonProperty("options", DefaultValueHandling = DefaultValueHandling.Include)]
        public IsDeceasedBodyInputOptionsType Options { get; set; } = new IsDeceasedBodyInputOptionsType();
    }

    public class BodyInputRecordType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRecordTypeNameType Name { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRecordTypeAddressType Address { get; set; }
    }

    public class BodyInputRecordTypeNameType
    {
        public string Title { get; set; }
        public string Forename { get; set; }
        public string MiddleName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Surname { get; set; }
    }

    public class BodyInputRecordTypeAddressType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Lines { get; set; }
    }

    public class IsDeceasedBodyInputOptionsType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputOptionsTypeMatchLevelType? MatchLevel { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Data8.BodyInputOptionsTypeMatchLevelType.I;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputOptionsTypeMatchLevelType
    {
        S,
        I,
        F
    }

    public class SearchPredictiveAddressResponse
    {
        public SearchPredictiveAddressResponseStatusType Status { get; set; }
        public SearchPredictiveAddressResponseResultsTypeItem[] Results { get; set; }
        public int Count { get; set; }

        [JsonProperty("SessionID")]
        public string SessionId { get; set; }
    }

    public class SearchPredictiveAddressResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class SearchPredictiveAddressResponseResultsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("container")]
        public bool Container { get; set; }

        [JsonProperty("items")]
        public int Items { get; set; }
    }

    public class SearchPredictiveAddressBodyInput
    {
        [JsonProperty("country", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Country { get; set; }

        [JsonProperty("search", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Search { get; set; }

        [JsonProperty("telephoneNumber")]
        public string TelephoneNumber { get; set; }

        [JsonProperty("session")]
        public string Session { get; set; }

        [JsonProperty("options")]
        public DrilldownPredictiveAddressBodyInputOptionsType Options { get; set; }
    }

    public class DrilldownPredictiveAddressBodyInputOptionsType
    {
        public bool? IncludeMR { get; set; }
        public bool? IncludeNYB { get; set; }
    }

    public class DrilldownPredictiveAddressResponse
    {
        public DrilldownPredictiveAddressResponseStatusType Status { get; set; }
        public DrilldownPredictiveAddressResponseResultsTypeItem[] Results { get; set; }
        public int Count { get; set; }

        [JsonProperty("SessionID")]
        public string SessionId { get; set; }
    }

    public class DrilldownPredictiveAddressResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class DrilldownPredictiveAddressResponseResultsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("container")]
        public bool Container { get; set; }

        [JsonProperty("items")]
        public int Items { get; set; }
    }

    public class DrilldownPredictiveAddressBodyInput
    {
        [JsonProperty("country", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Country { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("options")]
        public DrilldownPredictiveAddressBodyInputOptionsType Options { get; set; }
    }

    public class RetrievePredictiveAddressResponse
    {
        public RetrievePredictiveAddressResponseStatusType Status { get; set; }
        public RetrievePredictiveAddressResponseResultType Result { get; set; }
    }

    public class RetrievePredictiveAddressResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class RetrievePredictiveAddressResponseResultType
    {
        public RetrievePredictiveAddressResponseResultTypeAddressType Address { get; set; }
        public RetrievePredictiveAddressResponseResultTypeRawAddressType RawAddress { get; set; }
    }

    public class RetrievePredictiveAddressResponseResultTypeAddressType
    {
        public string[] Lines { get; set; }
    }

    public class RetrievePredictiveAddressResponseResultTypeRawAddressType
    {
        public string Organisation { get; set; }
        public string Department { get; set; }
        public int AddressKey { get; set; }
        public int OrganisationKey { get; set; }
        public string PostcodeType { get; set; }
        public int BuildingNumber { get; set; }
        public string SubBuildingName { get; set; }
        public string BuildingName { get; set; }
        public string DependentThoroughfareName { get; set; }
        public string DependentThoroughfareDesc { get; set; }
        public string ThoroughfareName { get; set; }
        public string ThoroughfareDesc { get; set; }
        public string DoubleDependentLocality { get; set; }
        public string DependentLocality { get; set; }
        public string Locality { get; set; }
        public string Postcode { get; set; }
        public string Dps { get; set; }
        public string PoBox { get; set; }
        public string PostalCounty { get; set; }
        public string TraditionalCounty { get; set; }
        public string AdministrativeCounty { get; set; }
        public string CountryISO2 { get; set; }
        public string UniqueReference { get; set; }
        public RetrievePredictiveAddressResponseResultTypeRawAddressTypeLocationType Location { get; set; }
        public string AdditionalData { get; set; }
    }

    public class RetrievePredictiveAddressResponseResultTypeRawAddressTypeLocationType
    {
        public int Easting { get; set; }
        public int Northing { get; set; }
        public string GridReference { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string CountyCode { get; set; }
        public string County { get; set; }
        public string DistrictCode { get; set; }
        public string District { get; set; }
        public string WardCode { get; set; }
        public string Ward { get; set; }
        public string Country { get; set; }
    }

    public class RetrievePredictiveAddressBodyInput
    {
        [JsonProperty("country", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Country { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("options", DefaultValueHandling = DefaultValueHandling.Include)]
        public RetrievePredictiveAddressBodyInputOptionsType Options { get; set; } = new RetrievePredictiveAddressBodyInputOptionsType();
    }

    public class RetrievePredictiveAddressBodyInputOptionsType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxLineLength { get; set; } = 100;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxLines { get; set; } = 5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FixTownCounty { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FixPostcode { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FixBuilding { get; set; } = false;
        public string UnwantedPunctuation { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputOptionsTypeFormatterType? Formatter { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Data8.BodyInputOptionsTypeFormatterType.DefaultFormatter;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeUDPRN { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeUPRN { get; set; } = false;
    }

    public class CleanseEmailResponse
    {
        public CleanseEmailResponseStatusType Status { get; set; }
        public string Result { get; set; }
        public bool OriginalValid { get; set; }
        public string EmailType { get; set; }
        public string SuggestedEmailAddress { get; set; }
        public string Comment { get; set; }
        public string Salutation { get; set; }
        public string StructureUsed { get; set; }
        public string ParsedName { get; set; }
    }

    public class CleanseEmailResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public int CreditsRemaining { get; set; }
    }

    public class CleanseEmailBodyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputLevelType Level { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Data8.BodyInputLevelType.Server;
        public string Title { get; set; }
        public string Forename { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
    }

    public class IsValidPhoneResponse
    {
        public IsValidPhoneResponseStatusType Status { get; set; }
        public IsValidPhoneResponseResultType Result { get; set; }
    }

    public class IsValidPhoneResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class IsValidPhoneResponseResultType
    {
        public string TelephoneNumber { get; set; }
        public string ValidationResult { get; set; }
        public string ValidationLevel { get; set; }
        public string NumberType { get; set; }
        public string Location { get; set; }
        public string Provider { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
    }

    public class IsValidPhoneBodyInput
    {
        [JsonProperty("telephoneNumber", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TelephoneNumber { get; set; }

        [JsonProperty("defaultCountry", DefaultValueHandling = DefaultValueHandling.Include)]
        public int DefaultCountry { get; set; } = 1;
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Data8;

    public partial class WorkflowManagedActions
    {
        public Data8Actions Data8(string connectionId) => new Data8Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Data8Triggers Data8(string connectionId) => new Data8Triggers(connectionId);
    }
}