//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivedv
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class CloudmersivedvActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<ParseAddressResponse> AddressParseString(Expression<Func<string>> inputaddressString = null, Expression<Func<string>> inputcapitalizationMode = null)
        {
            var __workflow_inputaddressString = inputaddressString == null ? null : WorkflowExpression.Compile(inputaddressString);
            WorkflowExpression.Validate(__workflow_inputaddressString, nameof(inputaddressString), required: false);
            var __workflow_inputcapitalizationMode = inputcapitalizationMode == null ? null : WorkflowExpression.Compile(inputcapitalizationMode);
            WorkflowExpression.Validate(__workflow_inputcapitalizationMode, nameof(inputcapitalizationMode), required: false);
            return new DeferredBodyAction<ParseAddressResponse>(() =>
            {
                var apiCallPath = "/validate/address/parse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputaddressString != null)
                {
                    input["AddressString"] = ExpressionConverter.ConvertO(__workflow_inputaddressString);
                    inputpropCount++;
                }

                if (__workflow_inputcapitalizationMode != null)
                {
                    input["CapitalizationMode"] = ExpressionConverter.ConvertO(__workflow_inputcapitalizationMode);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<ParseAddressResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<CheckResponse> DomainCheck(Expression<Func<string>> domain = null)
        {
            var __workflow_domain = domain == null ? null : WorkflowExpression.Compile(domain);
            WorkflowExpression.Validate(__workflow_domain, nameof(domain), required: false);
            return new DeferredBodyAction<CheckResponse>(() =>
            {
                var apiCallPath = "/validate/domain/check";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_domain);
                return new ApiConnectionAction<CheckResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<ValidateUrlResponseFull> DomainUrlFull(Expression<Func<string>> requestuRL = null)
        {
            var __workflow_requestuRL = requestuRL == null ? null : WorkflowExpression.Compile(requestuRL);
            WorkflowExpression.Validate(__workflow_requestuRL, nameof(requestuRL), required: false);
            return new DeferredBodyAction<ValidateUrlResponseFull>(() =>
            {
                var apiCallPath = "/validate/domain/url/full";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestuRL != null)
                {
                    request["URL"] = ExpressionConverter.ConvertO(__workflow_requestuRL);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<ValidateUrlResponseFull>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<ValidateUrlResponseSyntaxOnly> DomainUrlSyntaxOnly(Expression<Func<string>> requestuRL = null)
        {
            var __workflow_requestuRL = requestuRL == null ? null : WorkflowExpression.Compile(requestuRL);
            WorkflowExpression.Validate(__workflow_requestuRL, nameof(requestuRL), required: false);
            return new DeferredBodyAction<ValidateUrlResponseSyntaxOnly>(() =>
            {
                var apiCallPath = "/validate/domain/url/syntax-only";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestuRL != null)
                {
                    request["URL"] = ExpressionConverter.ConvertO(__workflow_requestuRL);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<ValidateUrlResponseSyntaxOnly>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<WhoisResponse> Domain(Expression<Func<string>> domain = null)
        {
            var __workflow_domain = domain == null ? null : WorkflowExpression.Compile(domain);
            WorkflowExpression.Validate(__workflow_domain, nameof(domain), required: false);
            return new DeferredBodyAction<WhoisResponse>(() =>
            {
                var apiCallPath = "/validate/domain/whois";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_domain);
                return new ApiConnectionAction<WhoisResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<FullEmailValidationResponse> EmailFullValidation(Expression<Func<string>> email = null)
        {
            var __workflow_email = email == null ? null : WorkflowExpression.Compile(email);
            WorkflowExpression.Validate(__workflow_email, nameof(email), required: false);
            return new DeferredBodyAction<FullEmailValidationResponse>(() =>
            {
                var apiCallPath = "/validate/email/address/full";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_email);
                return new ApiConnectionAction<FullEmailValidationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<GeolocateResponse> IPAddress(Expression<Func<string>> value = null)
        {
            var __workflow_value = value == null ? null : WorkflowExpression.Compile(value);
            WorkflowExpression.Validate(__workflow_value, nameof(value), required: false);
            return new DeferredBodyAction<GeolocateResponse>(() =>
            {
                var apiCallPath = "/validate/ip/geolocate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_value);
                return new ApiConnectionAction<GeolocateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<FirstNameValidationResponse> NameValidateFirstName(Expression<Func<string>> inputfirstName = null)
        {
            var __workflow_inputfirstName = inputfirstName == null ? null : WorkflowExpression.Compile(inputfirstName);
            WorkflowExpression.Validate(__workflow_inputfirstName, nameof(inputfirstName), required: false);
            return new DeferredBodyAction<FirstNameValidationResponse>(() =>
            {
                var apiCallPath = "/validate/name/first";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputfirstName != null)
                {
                    input["FirstName"] = ExpressionConverter.ConvertO(__workflow_inputfirstName);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<FirstNameValidationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<FullNameValidationResponse> NameValidateFullName(Expression<Func<string>> inputfullNameString = null)
        {
            var __workflow_inputfullNameString = inputfullNameString == null ? null : WorkflowExpression.Compile(inputfullNameString);
            WorkflowExpression.Validate(__workflow_inputfullNameString, nameof(inputfullNameString), required: false);
            return new DeferredBodyAction<FullNameValidationResponse>(() =>
            {
                var apiCallPath = "/validate/name/full-name";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputfullNameString != null)
                {
                    input["FullNameString"] = ExpressionConverter.ConvertO(__workflow_inputfullNameString);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<FullNameValidationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<GetGenderResponse> NameGetGender(Expression<Func<string>> inputcountryCode = null, Expression<Func<string>> inputfirstName = null)
        {
            var __workflow_inputcountryCode = inputcountryCode == null ? null : WorkflowExpression.Compile(inputcountryCode);
            WorkflowExpression.Validate(__workflow_inputcountryCode, nameof(inputcountryCode), required: false);
            var __workflow_inputfirstName = inputfirstName == null ? null : WorkflowExpression.Compile(inputfirstName);
            WorkflowExpression.Validate(__workflow_inputfirstName, nameof(inputfirstName), required: false);
            return new DeferredBodyAction<GetGenderResponse>(() =>
            {
                var apiCallPath = "/validate/name/get-gender";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputcountryCode != null)
                {
                    input["CountryCode"] = ExpressionConverter.ConvertO(__workflow_inputcountryCode);
                    inputpropCount++;
                }

                if (__workflow_inputfirstName != null)
                {
                    input["FirstName"] = ExpressionConverter.ConvertO(__workflow_inputfirstName);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<GetGenderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<ValidateIdentifierResponse> NameIdentifier(Expression<Func<bool>> inputallowHyphens = null, Expression<Func<bool>> inputallowNumbers = null, Expression<Func<bool>> inputallowPeriods = null, Expression<Func<bool>> inputallowUnderscore = null, Expression<Func<bool>> inputallowWhitespace = null, Expression<Func<string>> inputinput = null, Expression<Func<int>> inputmaxLength = null, Expression<Func<int>> inputminLength = null)
        {
            var __workflow_inputallowHyphens = inputallowHyphens == null ? null : WorkflowExpression.Compile(inputallowHyphens);
            WorkflowExpression.Validate(__workflow_inputallowHyphens, nameof(inputallowHyphens), required: false);
            var __workflow_inputallowNumbers = inputallowNumbers == null ? null : WorkflowExpression.Compile(inputallowNumbers);
            WorkflowExpression.Validate(__workflow_inputallowNumbers, nameof(inputallowNumbers), required: false);
            var __workflow_inputallowPeriods = inputallowPeriods == null ? null : WorkflowExpression.Compile(inputallowPeriods);
            WorkflowExpression.Validate(__workflow_inputallowPeriods, nameof(inputallowPeriods), required: false);
            var __workflow_inputallowUnderscore = inputallowUnderscore == null ? null : WorkflowExpression.Compile(inputallowUnderscore);
            WorkflowExpression.Validate(__workflow_inputallowUnderscore, nameof(inputallowUnderscore), required: false);
            var __workflow_inputallowWhitespace = inputallowWhitespace == null ? null : WorkflowExpression.Compile(inputallowWhitespace);
            WorkflowExpression.Validate(__workflow_inputallowWhitespace, nameof(inputallowWhitespace), required: false);
            var __workflow_inputinput = inputinput == null ? null : WorkflowExpression.Compile(inputinput);
            WorkflowExpression.Validate(__workflow_inputinput, nameof(inputinput), required: false);
            var __workflow_inputmaxLength = inputmaxLength == null ? null : WorkflowExpression.Compile(inputmaxLength);
            WorkflowExpression.Validate(__workflow_inputmaxLength, nameof(inputmaxLength), required: false);
            var __workflow_inputminLength = inputminLength == null ? null : WorkflowExpression.Compile(inputminLength);
            WorkflowExpression.Validate(__workflow_inputminLength, nameof(inputminLength), required: false);
            return new DeferredBodyAction<ValidateIdentifierResponse>(() =>
            {
                var apiCallPath = "/validate/name/identifier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputallowHyphens != null)
                {
                    input["AllowHyphens"] = ExpressionConverter.ConvertO(__workflow_inputallowHyphens);
                    inputpropCount++;
                }

                if (__workflow_inputallowNumbers != null)
                {
                    input["AllowNumbers"] = ExpressionConverter.ConvertO(__workflow_inputallowNumbers);
                    inputpropCount++;
                }

                if (__workflow_inputallowPeriods != null)
                {
                    input["AllowPeriods"] = ExpressionConverter.ConvertO(__workflow_inputallowPeriods);
                    inputpropCount++;
                }

                if (__workflow_inputallowUnderscore != null)
                {
                    input["AllowUnderscore"] = ExpressionConverter.ConvertO(__workflow_inputallowUnderscore);
                    inputpropCount++;
                }

                if (__workflow_inputallowWhitespace != null)
                {
                    input["AllowWhitespace"] = ExpressionConverter.ConvertO(__workflow_inputallowWhitespace);
                    inputpropCount++;
                }

                if (__workflow_inputinput != null)
                {
                    input["Input"] = ExpressionConverter.ConvertO(__workflow_inputinput);
                    inputpropCount++;
                }

                if (__workflow_inputmaxLength != null)
                {
                    input["MaxLength"] = ExpressionConverter.ConvertO(__workflow_inputmaxLength);
                    inputpropCount++;
                }

                if (__workflow_inputminLength != null)
                {
                    input["MinLength"] = ExpressionConverter.ConvertO(__workflow_inputminLength);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<ValidateIdentifierResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<LastNameValidationResponse> NameValidateLastName(Expression<Func<string>> inputlastName = null)
        {
            var __workflow_inputlastName = inputlastName == null ? null : WorkflowExpression.Compile(inputlastName);
            WorkflowExpression.Validate(__workflow_inputlastName, nameof(inputlastName), required: false);
            return new DeferredBodyAction<LastNameValidationResponse>(() =>
            {
                var apiCallPath = "/validate/name/last";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputlastName != null)
                {
                    input["LastName"] = ExpressionConverter.ConvertO(__workflow_inputlastName);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<LastNameValidationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<PhoneNumberValidationResponse> PhoneNumberSyntaxOnly(Expression<Func<string>> valuedefaultCountryCode = null, Expression<Func<string>> valuephoneNumber = null)
        {
            var __workflow_valuedefaultCountryCode = valuedefaultCountryCode == null ? null : WorkflowExpression.Compile(valuedefaultCountryCode);
            WorkflowExpression.Validate(__workflow_valuedefaultCountryCode, nameof(valuedefaultCountryCode), required: false);
            var __workflow_valuephoneNumber = valuephoneNumber == null ? null : WorkflowExpression.Compile(valuephoneNumber);
            WorkflowExpression.Validate(__workflow_valuephoneNumber, nameof(valuephoneNumber), required: false);
            return new DeferredBodyAction<PhoneNumberValidationResponse>(() =>
            {
                var apiCallPath = "/validate/phonenumber/basic";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var value = new JObject();
                var valuepropCount = 0;
                if (__workflow_valuedefaultCountryCode != null)
                {
                    value["DefaultCountryCode"] = ExpressionConverter.ConvertO(__workflow_valuedefaultCountryCode);
                    valuepropCount++;
                }

                if (__workflow_valuephoneNumber != null)
                {
                    value["PhoneNumber"] = ExpressionConverter.ConvertO(__workflow_valuephoneNumber);
                    valuepropCount++;
                }

                if (valuepropCount > 0)
                {
                    callPayload.Body = value;
                }

                return new ApiConnectionAction<PhoneNumberValidationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<UserAgentValidateResponse> UserAgentParse(Expression<Func<string>> requestuserAgentString = null)
        {
            var __workflow_requestuserAgentString = requestuserAgentString == null ? null : WorkflowExpression.Compile(requestuserAgentString);
            WorkflowExpression.Validate(__workflow_requestuserAgentString, nameof(requestuserAgentString), required: false);
            return new DeferredBodyAction<UserAgentValidateResponse>(() =>
            {
                var apiCallPath = "/validate/useragent/parse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestuserAgentString != null)
                {
                    request["UserAgentString"] = ExpressionConverter.ConvertO(__workflow_requestuserAgentString);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<UserAgentValidateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        public IBodyWorkflowAction<VatLookupResponse> VatVatLookup(Expression<Func<string>> inputvatCode = null)
        {
            var __workflow_inputvatCode = inputvatCode == null ? null : WorkflowExpression.Compile(inputvatCode);
            WorkflowExpression.Validate(__workflow_inputvatCode, nameof(inputvatCode), required: false);
            return new DeferredBodyAction<VatLookupResponse>(() =>
            {
                var apiCallPath = "/validate/vat/lookup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputvatCode != null)
                {
                    input["VatCode"] = ExpressionConverter.ConvertO(__workflow_inputvatCode);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

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
