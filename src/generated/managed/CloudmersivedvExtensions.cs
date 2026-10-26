//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivedv
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivedvActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<ParseAddressResponse, ApiConnectionActionConfiguration> AddressParseString(Expression<Func<AddressParseStringInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<ParseAddressResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/validate/address/parse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<ParseAddressResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<CheckResponse, ApiConnectionActionConfiguration> DomainCheck(Expression<Func<string>> domain)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: true);
            return new DeferredBodyAction<CheckResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/validate/domain/check";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_domain);
                return new ApiConnectionAction<CheckResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<ValidateUrlResponseFull, ApiConnectionActionConfiguration> DomainUrlFull(Expression<Func<DomainUrlFullInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<ValidateUrlResponseFull, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/validate/domain/url/full";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<ValidateUrlResponseFull>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<ValidateUrlResponseSyntaxOnly, ApiConnectionActionConfiguration> DomainUrlSyntaxOnly(Expression<Func<DomainUrlSyntaxOnlyInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<ValidateUrlResponseSyntaxOnly, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/validate/domain/url/syntax-only";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<ValidateUrlResponseSyntaxOnly>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<WhoisResponse, ApiConnectionActionConfiguration> Domain(Expression<Func<string>> domain)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: true);
            return new DeferredBodyAction<WhoisResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/validate/domain/whois";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_domain);
                return new ApiConnectionAction<WhoisResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<FullEmailValidationResponse, ApiConnectionActionConfiguration> EmailFullValidation(Expression<Func<string>> email)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            return new DeferredBodyAction<FullEmailValidationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/validate/email/address/full";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_email);
                return new ApiConnectionAction<FullEmailValidationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<GeolocateResponse, ApiConnectionActionConfiguration> IPAddress(Expression<Func<string>> value)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            return new DeferredBodyAction<GeolocateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/validate/ip/geolocate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_value);
                return new ApiConnectionAction<GeolocateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<FirstNameValidationResponse, ApiConnectionActionConfiguration> NameValidateFirstName(Expression<Func<NameValidateFirstNameInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<FirstNameValidationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/validate/name/first";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<FirstNameValidationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<FullNameValidationResponse, ApiConnectionActionConfiguration> NameValidateFullName(Expression<Func<NameValidateFullNameInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<FullNameValidationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/validate/name/full-name";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<FullNameValidationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<GetGenderResponse, ApiConnectionActionConfiguration> NameGetGender(Expression<Func<NameGetGenderInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<GetGenderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/validate/name/get-gender";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<GetGenderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<ValidateIdentifierResponse, ApiConnectionActionConfiguration> NameIdentifier(Expression<Func<NameIdentifierInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<ValidateIdentifierResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/validate/name/identifier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<ValidateIdentifierResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<LastNameValidationResponse, ApiConnectionActionConfiguration> NameValidateLastName(Expression<Func<NameValidateLastNameInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<LastNameValidationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/validate/name/last";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<LastNameValidationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<PhoneNumberValidationResponse, ApiConnectionActionConfiguration> PhoneNumberSyntaxOnly(Expression<Func<PhoneNumberSyntaxOnlyInput>> value)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            return new DeferredBodyAction<PhoneNumberValidationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/validate/phonenumber/basic";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_value);
                return new ApiConnectionAction<PhoneNumberValidationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<UserAgentValidateResponse, ApiConnectionActionConfiguration> UserAgentParse(Expression<Func<UserAgentParseInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<UserAgentValidateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/validate/useragent/parse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<UserAgentValidateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<VatLookupResponse, ApiConnectionActionConfiguration> VatVatLookup(Expression<Func<VatVatLookupInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<VatLookupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/validate/vat/lookup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<VatLookupResponse>(callPayload);
            });
        }
    }

    public class CloudmersivedvTriggers([ConnectionName] string connectionId)
    {
    }

    public class ParseAddressResponse
    {
        public string Building { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string StateOrProvince { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public bool Successful { get; set; }
    }

    public class AddressParseStringInput
    {
        public string AddressString { get; set; }
        public string CapitalizationMode { get; set; }
    }

    public class CheckResponse
    {
        public bool ValidDomain { get; set; }
    }

    public class ValidateUrlResponseFull
    {
        public bool ValidURL { get; set; }

        [JsonProperty("Valid_Domain")]
        public bool ValidDomain { get; set; }

        [JsonProperty("Valid_Endpoint")]
        public bool ValidEndpoint { get; set; }

        [JsonProperty("Valid_Syntax")]
        public bool ValidSyntax { get; set; }
        public string WellFormedURL { get; set; }
    }

    public class DomainUrlFullInput
    {
        public string URL { get; set; }
    }

    public class ValidateUrlResponseSyntaxOnly
    {
        public bool ValidURL { get; set; }
        public string WellFormedURL { get; set; }
    }

    public class DomainUrlSyntaxOnlyInput
    {
        public string URL { get; set; }
    }

    public class WhoisResponse
    {
        public string CreatedDt { get; set; }
        public string RawTextRecord { get; set; }
        public bool ValidDomain { get; set; }
        public string WhoisServer { get; set; }
    }

    public class FullEmailValidationResponse
    {
        public string Domain { get; set; }
        public bool IsCatchallDomain { get; set; }
        public bool IsDisposable { get; set; }
        public bool IsFreeEmailProvider { get; set; }
        public string MailServerUsedForValidation { get; set; }
        public bool ValidAddress { get; set; }

        [JsonProperty("Valid_Domain")]
        public bool ValidDomain { get; set; }

        [JsonProperty("Valid_SMTP")]
        public bool ValidSMTP { get; set; }

        [JsonProperty("Valid_Syntax")]
        public bool ValidSyntax { get; set; }
    }

    public class GeolocateResponse
    {
        public string City { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public string TimezoneStandardName { get; set; }
        public string ZipCode { get; set; }
    }

    public class FirstNameValidationResponse
    {
        public bool Successful { get; set; }
        public string ValidationResult { get; set; }
    }

    public class NameValidateFirstNameInput
    {
        public string FirstName { get; set; }
    }

    public class FullNameValidationResponse
    {
        public string DisplayName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string NickName { get; set; }
        public bool Successful { get; set; }
        public string Suffix { get; set; }
        public string Title { get; set; }

        [JsonProperty("ValidationResult_FirstName")]
        public string ValidationResultFirstName { get; set; }

        [JsonProperty("ValidationResult_LastName")]
        public string ValidationResultLastName { get; set; }
    }

    public class NameValidateFullNameInput
    {
        public string FullNameString { get; set; }
    }

    public class GetGenderResponse
    {
        public string Gender { get; set; }
        public bool Successful { get; set; }
    }

    public class NameGetGenderInput
    {
        public string CountryCode { get; set; }
        public string FirstName { get; set; }
    }

    public class ValidateIdentifierResponse
    {
        public string Error { get; set; }
        public bool ValidIdentifier { get; set; }
    }

    public class NameIdentifierInput
    {
        public bool? AllowHyphens { get; set; }
        public bool? AllowNumbers { get; set; }
        public bool? AllowPeriods { get; set; }
        public bool? AllowUnderscore { get; set; }
        public bool? AllowWhitespace { get; set; }
        public string Input { get; set; }
        public int? MaxLength { get; set; }
        public int? MinLength { get; set; }
    }

    public class LastNameValidationResponse
    {
        public bool Successful { get; set; }
        public string ValidationResult { get; set; }
    }

    public class NameValidateLastNameInput
    {
        public string LastName { get; set; }
    }

    public class PhoneNumberValidationResponse
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string E164Format { get; set; }
        public string InternationalFormat { get; set; }
        public bool IsValid { get; set; }
        public string NationalFormat { get; set; }
        public string PhoneNumberType { get; set; }
        public bool Successful { get; set; }
    }

    public class PhoneNumberSyntaxOnlyInput
    {
        public string DefaultCountryCode { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class UserAgentValidateResponse
    {
        public string BotName { get; set; }
        public string BotURL { get; set; }
        public string BrowserEngineName { get; set; }
        public string BrowserEngineVersion { get; set; }
        public string BrowserName { get; set; }
        public string BrowserVersion { get; set; }
        public string DeviceBrandName { get; set; }
        public string DeviceModel { get; set; }
        public string DeviceType { get; set; }
        public bool IsBot { get; set; }
        public string OperatingSystem { get; set; }
        public string OperatingSystemCPUPlatform { get; set; }
        public string OperatingSystemVersion { get; set; }
        public bool Successful { get; set; }
    }

    public class UserAgentParseInput
    {
        public string UserAgentString { get; set; }
    }

    public class VatLookupResponse
    {
        public string BusinessAddress { get; set; }
        public string BusinessName { get; set; }
        public string CountryCode { get; set; }
        public bool IsValid { get; set; }
        public string VatNumber { get; set; }
    }

    public class VatVatLookupInput
    {
        public string VatCode { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivedv;

    public partial class WorkflowManagedActions
    {
        public CloudmersivedvActions Cloudmersivedv(string connectionId) => new CloudmersivedvActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CloudmersivedvTriggers Cloudmersivedv(string connectionId) => new CloudmersivedvTriggers(connectionId);
    }
}