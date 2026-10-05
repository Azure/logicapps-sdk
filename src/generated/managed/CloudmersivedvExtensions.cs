//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivedv
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivedvActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        [WorkflowExpressionFactory(nameof(__BuildAddressParseString))]
        public IBodyWorkflowAction<ParseAddressResponse> AddressParseString([WorkflowExpression] Func<string> inputaddressString = null, [WorkflowExpression] Func<string> inputcapitalizationMode = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ParseAddressResponse> __BuildAddressParseString(WorkflowValue<string> inputaddressString = null, WorkflowValue<string> inputcapitalizationMode = null)
        {
            WorkflowValue.Validate(inputaddressString, nameof(inputaddressString), required: false);
            WorkflowValue.Validate(inputcapitalizationMode, nameof(inputcapitalizationMode), required: false);
            return new DeferredBodyAction<ParseAddressResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        [WorkflowExpressionFactory(nameof(__BuildDomainCheck))]
        public IBodyWorkflowAction<CheckResponse> DomainCheck([WorkflowExpression] Func<string> domain = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CheckResponse> __BuildDomainCheck(WorkflowValue<string> domain = null)
        {
            WorkflowValue.Validate(domain, nameof(domain), required: false);
            return new DeferredBodyAction<CheckResponse>(() =>
            {
                var apiCallPath = "/validate/domain/check";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(domain);
                return new ApiConnectionAction<CheckResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        [WorkflowExpressionFactory(nameof(__BuildDomainUrlFull))]
        public IBodyWorkflowAction<ValidateUrlResponseFull> DomainUrlFull([WorkflowExpression] Func<string> requestuRL = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidateUrlResponseFull> __BuildDomainUrlFull(WorkflowValue<string> requestuRL = null)
        {
            WorkflowValue.Validate(requestuRL, nameof(requestuRL), required: false);
            return new DeferredBodyAction<ValidateUrlResponseFull>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        [WorkflowExpressionFactory(nameof(__BuildDomainUrlSyntaxOnly))]
        public IBodyWorkflowAction<ValidateUrlResponseSyntaxOnly> DomainUrlSyntaxOnly([WorkflowExpression] Func<string> requestuRL = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidateUrlResponseSyntaxOnly> __BuildDomainUrlSyntaxOnly(WorkflowValue<string> requestuRL = null)
        {
            WorkflowValue.Validate(requestuRL, nameof(requestuRL), required: false);
            return new DeferredBodyAction<ValidateUrlResponseSyntaxOnly>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        [WorkflowExpressionFactory(nameof(__BuildDomain))]
        public IBodyWorkflowAction<WhoisResponse> Domain([WorkflowExpression] Func<string> domain = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WhoisResponse> __BuildDomain(WorkflowValue<string> domain = null)
        {
            WorkflowValue.Validate(domain, nameof(domain), required: false);
            return new DeferredBodyAction<WhoisResponse>(() =>
            {
                var apiCallPath = "/validate/domain/whois";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(domain);
                return new ApiConnectionAction<WhoisResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        [WorkflowExpressionFactory(nameof(__BuildEmailFullValidation))]
        public IBodyWorkflowAction<FullEmailValidationResponse> EmailFullValidation([WorkflowExpression] Func<string> email = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FullEmailValidationResponse> __BuildEmailFullValidation(WorkflowValue<string> email = null)
        {
            WorkflowValue.Validate(email, nameof(email), required: false);
            return new DeferredBodyAction<FullEmailValidationResponse>(() =>
            {
                var apiCallPath = "/validate/email/address/full";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(email);
                return new ApiConnectionAction<FullEmailValidationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        [WorkflowExpressionFactory(nameof(__BuildIPAddress))]
        public IBodyWorkflowAction<GeolocateResponse> IPAddress([WorkflowExpression] Func<string> value = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GeolocateResponse> __BuildIPAddress(WorkflowValue<string> value = null)
        {
            WorkflowValue.Validate(value, nameof(value), required: false);
            return new DeferredBodyAction<GeolocateResponse>(() =>
            {
                var apiCallPath = "/validate/ip/geolocate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(value);
                return new ApiConnectionAction<GeolocateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        [WorkflowExpressionFactory(nameof(__BuildNameValidateFirstName))]
        public IBodyWorkflowAction<FirstNameValidationResponse> NameValidateFirstName([WorkflowExpression] Func<string> inputfirstName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FirstNameValidationResponse> __BuildNameValidateFirstName(WorkflowValue<string> inputfirstName = null)
        {
            WorkflowValue.Validate(inputfirstName, nameof(inputfirstName), required: false);
            return new DeferredBodyAction<FirstNameValidationResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        [WorkflowExpressionFactory(nameof(__BuildNameValidateFullName))]
        public IBodyWorkflowAction<FullNameValidationResponse> NameValidateFullName([WorkflowExpression] Func<string> inputfullNameString = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FullNameValidationResponse> __BuildNameValidateFullName(WorkflowValue<string> inputfullNameString = null)
        {
            WorkflowValue.Validate(inputfullNameString, nameof(inputfullNameString), required: false);
            return new DeferredBodyAction<FullNameValidationResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        [WorkflowExpressionFactory(nameof(__BuildNameGetGender))]
        public IBodyWorkflowAction<GetGenderResponse> NameGetGender([WorkflowExpression] Func<string> inputcountryCode = null, [WorkflowExpression] Func<string> inputfirstName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetGenderResponse> __BuildNameGetGender(WorkflowValue<string> inputcountryCode = null, WorkflowValue<string> inputfirstName = null)
        {
            WorkflowValue.Validate(inputcountryCode, nameof(inputcountryCode), required: false);
            WorkflowValue.Validate(inputfirstName, nameof(inputfirstName), required: false);
            return new DeferredBodyAction<GetGenderResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        [WorkflowExpressionFactory(nameof(__BuildNameIdentifier))]
        public IBodyWorkflowAction<ValidateIdentifierResponse> NameIdentifier([WorkflowExpression] Func<bool> inputallowHyphens = null, [WorkflowExpression] Func<bool> inputallowNumbers = null, [WorkflowExpression] Func<bool> inputallowPeriods = null, [WorkflowExpression] Func<bool> inputallowUnderscore = null, [WorkflowExpression] Func<bool> inputallowWhitespace = null, [WorkflowExpression] Func<string> inputinput = null, [WorkflowExpression] Func<int> inputmaxLength = null, [WorkflowExpression] Func<int> inputminLength = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidateIdentifierResponse> __BuildNameIdentifier(WorkflowValue<bool> inputallowHyphens = null, WorkflowValue<bool> inputallowNumbers = null, WorkflowValue<bool> inputallowPeriods = null, WorkflowValue<bool> inputallowUnderscore = null, WorkflowValue<bool> inputallowWhitespace = null, WorkflowValue<string> inputinput = null, WorkflowValue<int> inputmaxLength = null, WorkflowValue<int> inputminLength = null)
        {
            WorkflowValue.Validate(inputallowHyphens, nameof(inputallowHyphens), required: false);
            WorkflowValue.Validate(inputallowNumbers, nameof(inputallowNumbers), required: false);
            WorkflowValue.Validate(inputallowPeriods, nameof(inputallowPeriods), required: false);
            WorkflowValue.Validate(inputallowUnderscore, nameof(inputallowUnderscore), required: false);
            WorkflowValue.Validate(inputallowWhitespace, nameof(inputallowWhitespace), required: false);
            WorkflowValue.Validate(inputinput, nameof(inputinput), required: false);
            WorkflowValue.Validate(inputmaxLength, nameof(inputmaxLength), required: false);
            WorkflowValue.Validate(inputminLength, nameof(inputminLength), required: false);
            return new DeferredBodyAction<ValidateIdentifierResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        [WorkflowExpressionFactory(nameof(__BuildNameValidateLastName))]
        public IBodyWorkflowAction<LastNameValidationResponse> NameValidateLastName([WorkflowExpression] Func<string> inputlastName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LastNameValidationResponse> __BuildNameValidateLastName(WorkflowValue<string> inputlastName = null)
        {
            WorkflowValue.Validate(inputlastName, nameof(inputlastName), required: false);
            return new DeferredBodyAction<LastNameValidationResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        [WorkflowExpressionFactory(nameof(__BuildPhoneNumberSyntaxOnly))]
        public IBodyWorkflowAction<PhoneNumberValidationResponse> PhoneNumberSyntaxOnly([WorkflowExpression] Func<string> valuedefaultCountryCode = null, [WorkflowExpression] Func<string> valuephoneNumber = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PhoneNumberValidationResponse> __BuildPhoneNumberSyntaxOnly(WorkflowValue<string> valuedefaultCountryCode = null, WorkflowValue<string> valuephoneNumber = null)
        {
            WorkflowValue.Validate(valuedefaultCountryCode, nameof(valuedefaultCountryCode), required: false);
            WorkflowValue.Validate(valuephoneNumber, nameof(valuephoneNumber), required: false);
            return new DeferredBodyAction<PhoneNumberValidationResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        [WorkflowExpressionFactory(nameof(__BuildUserAgentParse))]
        public IBodyWorkflowAction<UserAgentValidateResponse> UserAgentParse([WorkflowExpression] Func<string> requestuserAgentString = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserAgentValidateResponse> __BuildUserAgentParse(WorkflowValue<string> requestuserAgentString = null)
        {
            WorkflowValue.Validate(requestuserAgentString, nameof(requestuserAgentString), required: false);
            return new DeferredBodyAction<UserAgentValidateResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivedv")]
        [WorkflowExpressionFactory(nameof(__BuildVatVatLookup))]
        public IBodyWorkflowAction<VatLookupResponse> VatVatLookup([WorkflowExpression] Func<string> inputvatCode = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VatLookupResponse> __BuildVatVatLookup(WorkflowValue<string> inputvatCode = null)
        {
            WorkflowValue.Validate(inputvatCode, nameof(inputvatCode), required: false);
            return new DeferredBodyAction<VatLookupResponse>(() =>
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
