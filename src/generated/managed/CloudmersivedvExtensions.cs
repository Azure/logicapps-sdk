//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivedv
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivedvActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<ParseAddressResponse> AddressParseString(Expression<Func<string>> inputaddressString = null, Expression<Func<string>> inputcapitalizationMode = null)
        {
            var apiCallPath = "/validate/address/parse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputaddressString != null)
            {
                input["AddressString"] = ExpressionConverter.ConvertO(inputaddressString);
                inputpropCount++;
            }

            if (inputcapitalizationMode != null)
            {
                input["CapitalizationMode"] = ExpressionConverter.ConvertO(inputcapitalizationMode);
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<ParseAddressResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<CheckResponse> DomainCheck(Expression<Func<string>> domain = null)
        {
            var apiCallPath = "/validate/domain/check";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(domain);
            return new ApiConnectionAction<CheckResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<ValidateUrlResponseFull> DomainUrlFull(Expression<Func<string>> requestuRL = null)
        {
            var apiCallPath = "/validate/domain/url/full";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestuRL != null)
            {
                request["URL"] = ExpressionConverter.ConvertO(requestuRL);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<ValidateUrlResponseFull>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<ValidateUrlResponseSyntaxOnly> DomainUrlSyntaxOnly(Expression<Func<string>> requestuRL = null)
        {
            var apiCallPath = "/validate/domain/url/syntax-only";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestuRL != null)
            {
                request["URL"] = ExpressionConverter.ConvertO(requestuRL);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<ValidateUrlResponseSyntaxOnly>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<WhoisResponse> DomainPost(Expression<Func<string>> domain = null)
        {
            var apiCallPath = "/validate/domain/whois";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(domain);
            return new ApiConnectionAction<WhoisResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<FullEmailValidationResponse> EmailFullValidation(Expression<Func<string>> email = null)
        {
            var apiCallPath = "/validate/email/address/full";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(email);
            return new ApiConnectionAction<FullEmailValidationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<GeolocateResponse> IPAddressPost(Expression<Func<string>> value = null)
        {
            var apiCallPath = "/validate/ip/geolocate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(value);
            return new ApiConnectionAction<GeolocateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<FirstNameValidationResponse> NameValidateFirstName(Expression<Func<string>> inputfirstName = null)
        {
            var apiCallPath = "/validate/name/first";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputfirstName != null)
            {
                input["FirstName"] = ExpressionConverter.ConvertO(inputfirstName);
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<FirstNameValidationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<FullNameValidationResponse> NameValidateFullName(Expression<Func<string>> inputfullNameString = null)
        {
            var apiCallPath = "/validate/name/full-name";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputfullNameString != null)
            {
                input["FullNameString"] = ExpressionConverter.ConvertO(inputfullNameString);
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<FullNameValidationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<GetGenderResponse> NameGetGender(Expression<Func<string>> inputcountryCode = null, Expression<Func<string>> inputfirstName = null)
        {
            var apiCallPath = "/validate/name/get-gender";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputcountryCode != null)
            {
                input["CountryCode"] = ExpressionConverter.ConvertO(inputcountryCode);
                inputpropCount++;
            }

            if (inputfirstName != null)
            {
                input["FirstName"] = ExpressionConverter.ConvertO(inputfirstName);
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<GetGenderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<ValidateIdentifierResponse> NameIdentifier(Expression<Func<bool>> inputallowHyphens = null, Expression<Func<bool>> inputallowNumbers = null, Expression<Func<bool>> inputallowPeriods = null, Expression<Func<bool>> inputallowUnderscore = null, Expression<Func<bool>> inputallowWhitespace = null, Expression<Func<string>> inputinput = null, Expression<Func<int>> inputmaxLength = null, Expression<Func<int>> inputminLength = null)
        {
            var apiCallPath = "/validate/name/identifier";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputallowHyphens != null)
            {
                input["AllowHyphens"] = ExpressionConverter.ConvertO(inputallowHyphens);
                inputpropCount++;
            }

            if (inputallowNumbers != null)
            {
                input["AllowNumbers"] = ExpressionConverter.ConvertO(inputallowNumbers);
                inputpropCount++;
            }

            if (inputallowPeriods != null)
            {
                input["AllowPeriods"] = ExpressionConverter.ConvertO(inputallowPeriods);
                inputpropCount++;
            }

            if (inputallowUnderscore != null)
            {
                input["AllowUnderscore"] = ExpressionConverter.ConvertO(inputallowUnderscore);
                inputpropCount++;
            }

            if (inputallowWhitespace != null)
            {
                input["AllowWhitespace"] = ExpressionConverter.ConvertO(inputallowWhitespace);
                inputpropCount++;
            }

            if (inputinput != null)
            {
                input["Input"] = ExpressionConverter.ConvertO(inputinput);
                inputpropCount++;
            }

            if (inputmaxLength != null)
            {
                input["MaxLength"] = ExpressionConverter.ConvertO(inputmaxLength);
                inputpropCount++;
            }

            if (inputminLength != null)
            {
                input["MinLength"] = ExpressionConverter.ConvertO(inputminLength);
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<ValidateIdentifierResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<LastNameValidationResponse> NameValidateLastName(Expression<Func<string>> inputlastName = null)
        {
            var apiCallPath = "/validate/name/last";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputlastName != null)
            {
                input["LastName"] = ExpressionConverter.ConvertO(inputlastName);
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<LastNameValidationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<PhoneNumberValidationResponse> PhoneNumberSyntaxOnly(Expression<Func<string>> valuedefaultCountryCode = null, Expression<Func<string>> valuephoneNumber = null)
        {
            var apiCallPath = "/validate/phonenumber/basic";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var value = new JObject();
            var valuepropCount = 0;
            if (valuedefaultCountryCode != null)
            {
                value["DefaultCountryCode"] = ExpressionConverter.ConvertO(valuedefaultCountryCode);
                valuepropCount++;
            }

            if (valuephoneNumber != null)
            {
                value["PhoneNumber"] = ExpressionConverter.ConvertO(valuephoneNumber);
                valuepropCount++;
            }

            if (valuepropCount > 0)
            {
                callPayload.Body = value;
            }

            return new ApiConnectionAction<PhoneNumberValidationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<UserAgentValidateResponse> UserAgentParse(Expression<Func<string>> requestuserAgentString = null)
        {
            var apiCallPath = "/validate/useragent/parse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestuserAgentString != null)
            {
                request["UserAgentString"] = ExpressionConverter.ConvertO(requestuserAgentString);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<UserAgentValidateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<VatLookupResponse> VatVatLookup(Expression<Func<string>> inputvatCode = null)
        {
            var apiCallPath = "/validate/vat/lookup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputvatCode != null)
            {
                input["VatCode"] = ExpressionConverter.ConvertO(inputvatCode);
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<VatLookupResponse>(callPayload);
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

    public class ValidateUrlResponseSyntaxOnly
    {
        public bool ValidURL { get; set; }
        public string WellFormedURL { get; set; }
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

    public class GetGenderResponse
    {
        public string Gender { get; set; }
        public bool Successful { get; set; }
    }

    public class ValidateIdentifierResponse
    {
        public string Error { get; set; }
        public bool ValidIdentifier { get; set; }
    }

    public class LastNameValidationResponse
    {
        public bool Successful { get; set; }
        public string ValidationResult { get; set; }
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

    public class VatLookupResponse
    {
        public string BusinessAddress { get; set; }
        public string BusinessName { get; set; }
        public string CountryCode { get; set; }
        public bool IsValid { get; set; }
        public string VatNumber { get; set; }
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