//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dqondemand
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DqondemandActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<GetUsage> UsageGet(Expression<Func<string>> startDate, Expression<Func<string>> endDate)
        {
            var apiCallPath = "/Account/Usage";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["StartDate"] = ExpressionConverter.Convert(startDate);
            callPayload.Queries["EndDate"] = ExpressionConverter.Convert(endDate);
            return new ApiConnectionAction<GetUsage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<GetUsageV2> UsageGetV2(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<summariseByInput>> summariseBy = null)
        {
            var apiCallPath = "/Account/Usage/v2.0";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["StartDate"] = ExpressionConverter.Convert(startDate);
            callPayload.Queries["EndDate"] = ExpressionConverter.Convert(endDate);
            if (summariseBy != null)
                callPayload.Queries["SummariseBy"] = ExpressionConverter.Convert(summariseBy);
            return new ApiConnectionAction<GetUsageV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<GetPricesOutput> PricingGet()
        {
            var apiCallPath = "/Account/Prices";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetPricesOutput>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalInt> BalanceGet()
        {
            var apiCallPath = "/Account/Balance";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DQGlobalInt>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> CaseSingular(Expression<Func<string>> input, Expression<Func<caseTypeInput>> caseType, Expression<Func<languageInput>> language)
        {
            var apiCallPath = "/Case";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["CaseType"] = ExpressionConverter.Convert(caseType);
            callPayload.Queries["Language"] = ExpressionConverter.Convert(language);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ClassifyGetResponse> ClassifyGet(Expression<Func<string>> input, Expression<Func<categoriesInput>> categories, Expression<Func<languageInput>> language = null)
        {
            var apiCallPath = "/Classify";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["Categories"] = ExpressionConverter.Convert(categories);
            callPayload.Queries["Language"] = Convert.ToString("English");
            if (language != null)
                callPayload.Queries["Language"] = ExpressionConverter.Convert(language);
            return new ApiConnectionAction<ClassifyGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalFloat> CompareGet(Expression<Func<string>> input1, Expression<Func<string>> input2, Expression<Func<comparisonAlgorithmInput>> comparisonAlgorithm)
        {
            var apiCallPath = "/Compare";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input1"] = ExpressionConverter.Convert(input1);
            callPayload.Queries["Input2"] = ExpressionConverter.Convert(input2);
            callPayload.Queries["ComparisonAlgorithm"] = ExpressionConverter.Convert(comparisonAlgorithm);
            return new ApiConnectionAction<DQGlobalFloat>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<CongruenceResultSingle> EmailCongruenceGet(Expression<Func<string>> email, Expression<Func<string>> firstName, Expression<Func<string>> lastName)
        {
            var apiCallPath = "/Congruence/Email";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Email"] = ExpressionConverter.Convert(email);
            callPayload.Queries["FirstName"] = ExpressionConverter.Convert(firstName);
            callPayload.Queries["LastName"] = ExpressionConverter.Convert(lastName);
            return new ApiConnectionAction<CongruenceResultSingle>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<CongruenceResultSingle> CountryCongruenceGet(Expression<Func<string>> input, Expression<Func<string>> country, Expression<Func<actionTypeInput>> actionType)
        {
            var apiCallPath = "/Congruence/Country";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["Country"] = ExpressionConverter.Convert(country);
            callPayload.Queries["ActionType"] = ExpressionConverter.Convert(actionType);
            return new ApiConnectionAction<CongruenceResultSingle>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<CongruenceResultSingle> SalutationCongruenceGet(Expression<Func<string>> salutation, Expression<Func<string>> firstName, Expression<Func<languageInput>> language)
        {
            var apiCallPath = "/Congruence/Salutation";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Salutation"] = ExpressionConverter.Convert(salutation);
            callPayload.Queries["FirstName"] = ExpressionConverter.Convert(firstName);
            callPayload.Queries["Language"] = ExpressionConverter.Convert(language);
            return new ApiConnectionAction<CongruenceResultSingle>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DeriveGenderGetResponse> DeriveGenderGet(Expression<Func<string>> input)
        {
            var apiCallPath = "/Derive/Gender";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DeriveGenderGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DeriveCityGetResponse> DeriveCityGet(Expression<Func<string>> input)
        {
            var apiCallPath = "/Derive/CountryFromCity";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DeriveCityGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DerivePostCodeGetResponse> DerivePostCodeGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var apiCallPath = "/Derive/FromPostalCode";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
            return new ApiConnectionAction<DerivePostCodeGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DeriveEmailGetResponse> DeriveEmailGet(Expression<Func<string>> input)
        {
            var apiCallPath = "/Derive/EmailType";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DeriveEmailGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DeriveISOGetResponse> DeriveISOGet(Expression<Func<string>> email = null, Expression<Func<string>> url = null, Expression<Func<string>> phone = null, Expression<Func<string>> country = null, Expression<Func<string>> city = null, Expression<Func<int>> threshold = null, Expression<Func<bool>> onlyReturnBest = null, Expression<Func<bool>> defaultToCountry = null)
        {
            var apiCallPath = "/DeriveISO";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (email != null)
                callPayload.Queries["Email"] = ExpressionConverter.Convert(email);
            if (url != null)
                callPayload.Queries["Url"] = ExpressionConverter.Convert(url);
            if (phone != null)
                callPayload.Queries["Phone"] = ExpressionConverter.Convert(phone);
            if (country != null)
                callPayload.Queries["Country"] = ExpressionConverter.Convert(country);
            if (city != null)
                callPayload.Queries["City"] = ExpressionConverter.Convert(city);
            callPayload.Queries["Threshold"] = Convert.ToString(70);
            if (threshold != null)
                callPayload.Queries["Threshold"] = ExpressionConverter.Convert(threshold);
            callPayload.Queries["OnlyReturnBest"] = Convert.ToString(false);
            if (onlyReturnBest != null)
                callPayload.Queries["OnlyReturnBest"] = ExpressionConverter.Convert(onlyReturnBest);
            callPayload.Queries["DefaultToCountry"] = Convert.ToString(false);
            if (defaultToCountry != null)
                callPayload.Queries["DefaultToCountry"] = ExpressionConverter.Convert(defaultToCountry);
            return new ApiConnectionAction<DeriveISOGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> FormatEmailGet(Expression<Func<string>> input)
        {
            var apiCallPath = "/Format/Email";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> FormatPostCodeGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var apiCallPath = "/Format/PostCode";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> FormatE164Get(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var apiCallPath = "/Format/TelephoneE164";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> FormatInternationalGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var apiCallPath = "/Format/TelephoneInternational";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> FormatNationalGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var apiCallPath = "/Format/TelephoneNational";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> FormatRFC3966Get(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var apiCallPath = "/Format/TelephoneRFC3966";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> FormatURLGet(Expression<Func<string>> input, Expression<Func<string>> uRLPrefix)
        {
            var apiCallPath = "/Format/UrlAddress";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["URLPrefix"] = ExpressionConverter.Convert(uRLPrefix);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<GeneratePatternResponse> GeneratePattern(Expression<Func<inputInputItem[]>> input = null)
        {
            var apiCallPath = "/Generate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(input);
            return new ApiConnectionAction<GeneratePatternResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> GenerateTokenGet(Expression<Func<string>> input, Expression<Func<generateAlgorithmTypeInput>> generateAlgorithmType, Expression<Func<languageInput>> language = null)
        {
            var apiCallPath = "/GenerateToken";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["generateAlgorithmType"] = ExpressionConverter.Convert(generateAlgorithmType);
            callPayload.Queries["Language"] = Convert.ToString("English");
            if (language != null)
                callPayload.Queries["Language"] = ExpressionConverter.Convert(language);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ParsePhoneGetResponse> ParsePhoneGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var apiCallPath = "/Parse/PhoneNumber";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
            return new ApiConnectionAction<ParsePhoneGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ParseEmailGetResponse> ParseEmailGet(Expression<Func<string>> input)
        {
            var apiCallPath = "/Parse/Email";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<ParseEmailGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ParseURLGetResponse> ParseURLGet(Expression<Func<string>> input)
        {
            var apiCallPath = "/Parse/URL";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<ParseURLGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> TransformGet(Expression<Func<string>> input, Expression<Func<entityTypeInput>> entityType, Expression<Func<operationTypeInput>> operationType, Expression<Func<languageInput>> language = null)
        {
            var apiCallPath = "/Transform";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["EntityType"] = ExpressionConverter.Convert(entityType);
            callPayload.Queries["OperationType"] = ExpressionConverter.Convert(operationType);
            callPayload.Queries["Language"] = Convert.ToString("English");
            if (language != null)
                callPayload.Queries["Language"] = ExpressionConverter.Convert(language);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SequenceTransformResponse> SequenceTransform(Expression<Func<inputInputItem2[]>> input = null)
        {
            var apiCallPath = "/SequenceTransform";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(input);
            return new ApiConnectionAction<SequenceTransformResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> ValidateEmailGet(Expression<Func<string>> input)
        {
            var apiCallPath = "/Validate/Email";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DQGlobalBool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> ValidatePostCodeGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var apiCallPath = "/Validate/PostCode";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
            return new ApiConnectionAction<DQGlobalBool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> ValidateURLGet(Expression<Func<string>> input)
        {
            var apiCallPath = "/Validate/UrlAddress";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DQGlobalBool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> ValidatePhoneGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var apiCallPath = "/Validate/Telephone";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
            return new ApiConnectionAction<DQGlobalBool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> ValidateDateTimeGet(Expression<Func<string>> input, Expression<Func<string>> dateTimeFormat)
        {
            var apiCallPath = "/Validate/DateTime";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["DateTimeFormat"] = ExpressionConverter.Convert(dateTimeFormat);
            return new ApiConnectionAction<DQGlobalBool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ValidatePlusEmailGetResponse> ValidatePlusEmailGet(Expression<Func<string>> input)
        {
            var apiCallPath = "/ValidatePlus/Email";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<ValidatePlusEmailGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ValidatePlusPostCodeGetResponse> ValidatePlusPostCodeGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var apiCallPath = "/ValidatePlus/PostCode";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
            return new ApiConnectionAction<ValidatePlusPostCodeGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ValidatePlusURLGetResponse> ValidatePlusURLGet(Expression<Func<string>> input)
        {
            var apiCallPath = "/ValidatePlus/UrlAddress";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<ValidatePlusURLGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<VerifyAddressGetResponse> VerifyAddressGet(Expression<Func<providerInput>> provider, Expression<Func<string>> countryIdentifier, Expression<Func<bool>> geocode, Expression<Func<string>> line1 = null, Expression<Func<string>> line2 = null, Expression<Func<string>> line3 = null, Expression<Func<string>> postalCode = null, Expression<Func<string>> city = null, Expression<Func<string>> state = null)
        {
            var apiCallPath = String.Format("/Verify/Address/{0}", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (line1 != null)
                callPayload.Queries["Line1"] = ExpressionConverter.Convert(line1);
            if (line2 != null)
                callPayload.Queries["Line2"] = ExpressionConverter.Convert(line2);
            if (line3 != null)
                callPayload.Queries["Line3"] = ExpressionConverter.Convert(line3);
            if (postalCode != null)
                callPayload.Queries["PostalCode"] = ExpressionConverter.Convert(postalCode);
            if (city != null)
                callPayload.Queries["City"] = ExpressionConverter.Convert(city);
            if (state != null)
                callPayload.Queries["State"] = ExpressionConverter.Convert(state);
            callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
            callPayload.Queries["Geocode"] = ExpressionConverter.Convert(geocode);
            return new ApiConnectionAction<VerifyAddressGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SearchAddressFindResponse> SearchAddressFind(Expression<Func<providerInput>> provider, Expression<Func<string>> query, Expression<Func<string>> countryIdentifier)
        {
            var apiCallPath = String.Format("/Search/Address/Find/{0}", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["query"] = ExpressionConverter.Convert(query);
            callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
            return new ApiConnectionAction<SearchAddressFindResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SearchAddressRetrieveResponse> SearchAddressRetrieve(Expression<Func<providerInput>> provider, Expression<Func<string>> id, Expression<Func<string>> countryIdentifier)
        {
            var apiCallPath = String.Format("/Search/Address/Retrieve/{0}", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
            callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
            return new ApiConnectionAction<SearchAddressRetrieveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SuppressDeceasedResponse> SuppressDeceased(Expression<Func<providerInput>> provider, Expression<Func<string>> lastName, Expression<Func<string>> postcode, Expression<Func<string>> countryIdentifier, Expression<Func<string>> title = null, Expression<Func<string>> firstName = null, Expression<Func<string>> line1 = null, Expression<Func<string>> line2 = null, Expression<Func<string>> line3 = null, Expression<Func<string>> town = null, Expression<Func<string>> county = null)
        {
            var apiCallPath = String.Format("/Suppress/Address/Deceased/{0}", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (title != null)
                callPayload.Queries["Title"] = ExpressionConverter.Convert(title);
            if (firstName != null)
                callPayload.Queries["FirstName"] = ExpressionConverter.Convert(firstName);
            callPayload.Queries["LastName"] = ExpressionConverter.Convert(lastName);
            if (line1 != null)
                callPayload.Queries["Line1"] = ExpressionConverter.Convert(line1);
            if (line2 != null)
                callPayload.Queries["Line2"] = ExpressionConverter.Convert(line2);
            if (line3 != null)
                callPayload.Queries["Line3"] = ExpressionConverter.Convert(line3);
            if (town != null)
                callPayload.Queries["Town"] = ExpressionConverter.Convert(town);
            if (county != null)
                callPayload.Queries["County"] = ExpressionConverter.Convert(county);
            callPayload.Queries["Postcode"] = ExpressionConverter.Convert(postcode);
            callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
            return new ApiConnectionAction<SuppressDeceasedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SuppressGoneAwayResponse> SuppressGoneAway(Expression<Func<providerInput>> provider, Expression<Func<string>> lastName, Expression<Func<string>> postcode, Expression<Func<string>> iSO2, Expression<Func<string>> title = null, Expression<Func<string>> firstName = null, Expression<Func<string>> line1 = null, Expression<Func<string>> line2 = null, Expression<Func<string>> line3 = null, Expression<Func<string>> town = null, Expression<Func<string>> county = null)
        {
            var apiCallPath = String.Format("/Suppress/Address/GoneAway/{0}", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (title != null)
                callPayload.Queries["Title"] = ExpressionConverter.Convert(title);
            if (firstName != null)
                callPayload.Queries["FirstName"] = ExpressionConverter.Convert(firstName);
            callPayload.Queries["LastName"] = ExpressionConverter.Convert(lastName);
            if (line1 != null)
                callPayload.Queries["Line1"] = ExpressionConverter.Convert(line1);
            if (line2 != null)
                callPayload.Queries["Line2"] = ExpressionConverter.Convert(line2);
            if (line3 != null)
                callPayload.Queries["Line3"] = ExpressionConverter.Convert(line3);
            if (town != null)
                callPayload.Queries["Town"] = ExpressionConverter.Convert(town);
            if (county != null)
                callPayload.Queries["County"] = ExpressionConverter.Convert(county);
            callPayload.Queries["Postcode"] = ExpressionConverter.Convert(postcode);
            callPayload.Queries["ISO2"] = ExpressionConverter.Convert(iSO2);
            return new ApiConnectionAction<SuppressGoneAwayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SuppressRelocatedResponse> SuppressRelocated(Expression<Func<providerInput>> provider, Expression<Func<string>> lastName, Expression<Func<string>> postcode, Expression<Func<string>> iSO2, Expression<Func<string>> title = null, Expression<Func<string>> firstName = null, Expression<Func<string>> line1 = null, Expression<Func<string>> line2 = null, Expression<Func<string>> line3 = null, Expression<Func<string>> town = null, Expression<Func<string>> county = null)
        {
            var apiCallPath = String.Format("/Suppress/Address/Relocated/{0}", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (title != null)
                callPayload.Queries["Title"] = ExpressionConverter.Convert(title);
            if (firstName != null)
                callPayload.Queries["FirstName"] = ExpressionConverter.Convert(firstName);
            callPayload.Queries["LastName"] = ExpressionConverter.Convert(lastName);
            if (line1 != null)
                callPayload.Queries["Line1"] = ExpressionConverter.Convert(line1);
            if (line2 != null)
                callPayload.Queries["Line2"] = ExpressionConverter.Convert(line2);
            if (line3 != null)
                callPayload.Queries["Line3"] = ExpressionConverter.Convert(line3);
            if (town != null)
                callPayload.Queries["Town"] = ExpressionConverter.Convert(town);
            if (county != null)
                callPayload.Queries["County"] = ExpressionConverter.Convert(county);
            callPayload.Queries["Postcode"] = ExpressionConverter.Convert(postcode);
            callPayload.Queries["ISO2"] = ExpressionConverter.Convert(iSO2);
            return new ApiConnectionAction<SuppressRelocatedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SuppressPhonePersonalResponse> SuppressPhonePersonal(Expression<Func<providerInput>> provider, Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var apiCallPath = String.Format("/Suppress/Phone/Personal/{0}", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
            return new ApiConnectionAction<SuppressPhonePersonalResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SuppressPhoneCorporateResponse> SuppressPhoneCorporate(Expression<Func<providerInput>> provider, Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var apiCallPath = String.Format("/Suppress/Phone/Corporate/{0}", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
            return new ApiConnectionAction<SuppressPhoneCorporateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<AuthenticateEmailGetResponse> AuthenticateEmailGet(Expression<Func<providerInput>> provider, Expression<Func<string>> email)
        {
            var apiCallPath = String.Format("/Authenticate/Email/{0}", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Email"] = ExpressionConverter.Convert(email);
            return new ApiConnectionAction<AuthenticateEmailGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<AuthenticatePhoneGetResponse> AuthenticatePhoneGet(Expression<Func<providerInput>> provider, Expression<Func<string>> phone, Expression<Func<string>> countryIdentifier)
        {
            var apiCallPath = String.Format("/Authenticate/Phone/{0}", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Phone"] = ExpressionConverter.Convert(phone);
            callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
            return new ApiConnectionAction<AuthenticatePhoneGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsAllUpper(Expression<Func<string>> input)
        {
            var apiCallPath = "/StringExtension/IsAllUpper";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DQGlobalBool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsAllLower(Expression<Func<string>> input)
        {
            var apiCallPath = "/StringExtension/IsAllLower";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DQGlobalBool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsMixedCase(Expression<Func<string>> input)
        {
            var apiCallPath = "/StringExtension/IsMixedCase";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DQGlobalBool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsAlphaNumeric(Expression<Func<string>> input)
        {
            var apiCallPath = "/StringExtension/IsAlphaNumeric";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DQGlobalBool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsNumeric(Expression<Func<string>> input)
        {
            var apiCallPath = "/StringExtension/IsNumeric";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DQGlobalBool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsISO4217(Expression<Func<string>> input)
        {
            var apiCallPath = "/StringExtension/IsISO4217CurrencyCode";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DQGlobalBool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsISO2(Expression<Func<string>> input)
        {
            var apiCallPath = "/StringExtension/IsISO2Code";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DQGlobalBool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsISO3(Expression<Func<string>> input)
        {
            var apiCallPath = "/StringExtension/IsISO3Code";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DQGlobalBool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtRemoveLeading(Expression<Func<string>> input, Expression<Func<string>> valToRemove, Expression<Func<bool>> leaveOneAtStart)
        {
            var apiCallPath = "/StringExtension/RemoveLeading";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["ValToRemove"] = ExpressionConverter.Convert(valToRemove);
            callPayload.Queries["LeaveOneAtStart"] = ExpressionConverter.Convert(leaveOneAtStart);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtRemoveChars(Expression<Func<string>> input, Expression<Func<characterTypeInput>> characterType)
        {
            var apiCallPath = "/StringExtension/RemoveCharacters";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["characterType"] = ExpressionConverter.Convert(characterType);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtRemoveSingleWords(Expression<Func<string>> input)
        {
            var apiCallPath = "/StringExtension/RemoveSingleCharacterWords";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtReplaceRepeatingText(Expression<Func<string>> input, Expression<Func<string>> repeatingValue, Expression<Func<string>> replacement)
        {
            var apiCallPath = "/StringExtension/ReplaceAdjacentRepeatingText";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["RepeatingValue"] = ExpressionConverter.Convert(repeatingValue);
            callPayload.Queries["Replacement"] = ExpressionConverter.Convert(replacement);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtReplaceEndsWith(Expression<Func<string>> input, Expression<Func<string>> stringToReplace, Expression<Func<string>> replacement)
        {
            var apiCallPath = "/StringExtension/ReplaceIfEndsWith";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["stringToReplace"] = ExpressionConverter.Convert(stringToReplace);
            callPayload.Queries["replacement"] = ExpressionConverter.Convert(replacement);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtReplaceStartsWith(Expression<Func<string>> input, Expression<Func<string>> stringToReplace, Expression<Func<string>> replacement)
        {
            var apiCallPath = "/StringExtension/ReplaceIfStartsWith";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["stringToReplace"] = ExpressionConverter.Convert(stringToReplace);
            callPayload.Queries["replacement"] = ExpressionConverter.Convert(replacement);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtStringToBinary(Expression<Func<string>> input)
        {
            var apiCallPath = "/StringExtension/StringToBinary";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtBinaryToString(Expression<Func<string>> input)
        {
            var apiCallPath = "/StringExtension/BinaryToString";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtStringToHex(Expression<Func<string>> input)
        {
            var apiCallPath = "/StringExtension/StringToHex";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtHexToString(Expression<Func<string>> input)
        {
            var apiCallPath = "/StringExtension/HexToString";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtReverse(Expression<Func<string>> input)
        {
            var apiCallPath = "/StringExtension/Reverse";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtNormWhiteSpace(Expression<Func<string>> input)
        {
            var apiCallPath = "/StringExtension/NormalizeWhiteSpace";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtNormPhone(Expression<Func<string>> input)
        {
            var apiCallPath = "/StringExtension/NormalizeAlphaNumericPhone";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtCollapseRepeatedChars(Expression<Func<string>> input, Expression<Func<bool>> collapseNumerics, Expression<Func<int>> maximumRepeat = null)
        {
            var apiCallPath = "/StringExtension/CollapseAdjacentRepeatedCharacters";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["collapseNumerics"] = ExpressionConverter.Convert(collapseNumerics);
            if (maximumRepeat != null)
                callPayload.Queries["maximumRepeat"] = ExpressionConverter.Convert(maximumRepeat);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtCollapseRepeatedType(Expression<Func<string>> input, Expression<Func<int>> maximumRepeat, Expression<Func<typeInput>> type)
        {
            var apiCallPath = "/StringExtension/CollapseAdjacentRepeatedType";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["MaximumRepeat"] = ExpressionConverter.Convert(maximumRepeat);
            callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtRemoveStopWords(Expression<Func<string>> input)
        {
            var apiCallPath = "/StringExtension/FilterStopWords";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtRetainChars(Expression<Func<string>> input, Expression<Func<string>> replacement, Expression<Func<string>> charactersToRetain)
        {
            var apiCallPath = "/StringExtension/RetainCharacters";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["replacement"] = ExpressionConverter.Convert(replacement);
            callPayload.Queries["charactersToRetain"] = ExpressionConverter.Convert(charactersToRetain);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtExtractChars(Expression<Func<string>> input, Expression<Func<int>> extractLength, Expression<Func<extractFromInput>> extractFrom)
        {
            var apiCallPath = "/StringExtension/ExtractCharacters";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["extractLength"] = ExpressionConverter.Convert(extractLength);
            callPayload.Queries["extractFrom"] = ExpressionConverter.Convert(extractFrom);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtExtractWords(Expression<Func<string>> input, Expression<Func<int>> extractLength, Expression<Func<extractFromInput>> extractFrom)
        {
            var apiCallPath = "/StringExtension/ExtractWords";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["extractLength"] = ExpressionConverter.Convert(extractLength);
            callPayload.Queries["extractFrom"] = ExpressionConverter.Convert(extractFrom);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtRemoveHTML(Expression<Func<string>> input)
        {
            var apiCallPath = "/StringExtension/RemoveHTML";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtEndsWith(Expression<Func<string>> input, Expression<Func<string>> checkfor)
        {
            var apiCallPath = "/StringExtension/EndsWith";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["checkfor"] = ExpressionConverter.Convert(checkfor);
            return new ApiConnectionAction<DQGlobalBool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtStartsWith(Expression<Func<string>> input, Expression<Func<string>> checkfor)
        {
            var apiCallPath = "/StringExtension/StartsWith";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["checkfor"] = ExpressionConverter.Convert(checkfor);
            return new ApiConnectionAction<DQGlobalBool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtEnsureEndsWith(Expression<Func<string>> input, Expression<Func<string>> checkFor)
        {
            var apiCallPath = "/StringExtension/EnsureEndsWith";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["checkFor"] = ExpressionConverter.Convert(checkFor);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtEnsureStartEndsWith(Expression<Func<string>> input, Expression<Func<string>> checkFor)
        {
            var apiCallPath = "/StringExtension/EnsureStartsAndEndsWith";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["checkFor"] = ExpressionConverter.Convert(checkFor);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtEnsureStartsWith(Expression<Func<string>> input, Expression<Func<string>> checkFor)
        {
            var apiCallPath = "/StringExtension/EnsureStartsWith";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["checkFor"] = ExpressionConverter.Convert(checkFor);
            return new ApiConnectionAction<DQGlobal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtStartWithType(Expression<Func<string>> input, Expression<Func<typeInput>> type)
        {
            var apiCallPath = "/StringExtension/StartsWithType";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            return new ApiConnectionAction<DQGlobalBool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtEndsWithType(Expression<Func<string>> input, Expression<Func<typeInput>> type)
        {
            var apiCallPath = "/StringExtension/EndsWithType";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
            callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            return new ApiConnectionAction<DQGlobalBool>(callPayload);
        }
    }

    public class DqondemandTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetUsage
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetUsageDataType Data { get; set; }
    }

    public class GetUsageDataType
    {
        public GetUsageDataTypeFilterCriteriaType FilterCriteria { get; set; }
        public GetUsageDataTypeResultsTypeItem[] Results { get; set; }
    }

    public class GetUsageDataTypeFilterCriteriaType
    {
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class GetUsageDataTypeResultsTypeItem
    {
        [JsonProperty("providerName")]
        public string ProviderName { get; set; }

        [JsonProperty("usage")]
        public GetUsageDataTypeResultsTypeItemUsageTypeItem[] Usage { get; set; }
    }

    public class GetUsageDataTypeResultsTypeItemUsageTypeItem
    {
        [JsonProperty("functionName")]
        public string FunctionName { get; set; }

        [JsonProperty("creditsUsed")]
        public int CreditsUsed { get; set; }
    }

    public class GetUsageV2
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetUsageV2DataType Data { get; set; }
    }

    public class GetUsageV2DataType
    {
        public GetUsageV2DataTypeFilterCriteriaType FilterCriteria { get; set; }
        public GetUsageV2DataTypeResultsTypeItem[] Results { get; set; }
        public GetUsageV2DataTypeSummaryTypeItem[] Summary { get; set; }
    }

    public class GetUsageV2DataTypeFilterCriteriaType
    {
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class GetUsageV2DataTypeResultsTypeItem
    {
        [JsonProperty("providerName")]
        public string ProviderName { get; set; }

        [JsonProperty("usage")]
        public GetUsageV2DataTypeResultsTypeItemUsageTypeItem[] Usage { get; set; }
    }

    public class GetUsageV2DataTypeResultsTypeItemUsageTypeItem
    {
        [JsonProperty("functionName")]
        public string FunctionName { get; set; }

        [JsonProperty("creditsUsed")]
        public int CreditsUsed { get; set; }

        [JsonProperty("creditsUsedBy")]
        public GetUsageV2DataTypeResultsTypeItemUsageTypeItemCreditsUsedByTypeItem[] CreditsUsedBy { get; set; }
    }

    public class GetUsageV2DataTypeResultsTypeItemUsageTypeItemCreditsUsedByTypeItem
    {
        [JsonProperty("applicationName")]
        public string ApplicationName { get; set; }

        [JsonProperty("creditsUsed")]
        public int CreditsUsed { get; set; }
    }

    public class GetUsageV2DataTypeSummaryTypeItem
    {
        [JsonProperty("periodStart")]
        public string PeriodStart { get; set; }

        [JsonProperty("periodEnd")]
        public string PeriodEnd { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("creditsUsed")]
        public int CreditsUsed { get; set; }

        [JsonProperty("creditsUsedBy")]
        public GetUsageV2DataTypeSummaryTypeItemCreditsUsedByTypeItem[] CreditsUsedBy { get; set; }
    }

    public class GetUsageV2DataTypeSummaryTypeItemCreditsUsedByTypeItem
    {
        [JsonProperty("applicationName")]
        public string ApplicationName { get; set; }

        [JsonProperty("creditsUsed")]
        public int CreditsUsed { get; set; }
    }

    public enum summariseByInput
    {
        Day,
        Month,
        Year,
        Quarter
    }

    public class GetPricesOutput
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetPricesOutputDataTypeItem[] Data { get; set; }
    }

    public class GetPricesOutputDataTypeItem
    {
        [JsonProperty("providerName")]
        public string ProviderName { get; set; }

        [JsonProperty("functions")]
        public GetPricesOutputDataTypeItemFunctionsTypeItem[] Functions { get; set; }
    }

    public class GetPricesOutputDataTypeItemFunctionsTypeItem
    {
        [JsonProperty("functionName")]
        public string FunctionName { get; set; }

        [JsonProperty("creditCost")]
        public int CreditCost { get; set; }

        [JsonProperty("functionDescription")]
        public string FunctionDescription { get; set; }
    }

    public class DQGlobalInt
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public int Data { get; set; }
    }

    public class DQGlobal
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public enum caseTypeInput
    {
        [EnumMember(Value = "ProperCase_FamilyName")]
        ProperCaseFamilyName,
        [EnumMember(Value = "ProperCase_Address")]
        ProperCaseAddress,
        UpperCase,
        LowerCase,
        TitleCase
    }

    public enum languageInput
    {
        English,
        Spanish,
        French,
        Italian,
        German
    }

    public class ClassifyGetResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ClassifyResponse Data { get; set; }
    }

    public class ClassifyResponse
    {
        [JsonProperty("addresses")]
        public string[] Addresses { get; set; }

        [JsonProperty("numbers")]
        public string[] Numbers { get; set; }

        [JsonProperty("givenNames")]
        public string[] GivenNames { get; set; }

        [JsonProperty("businesses")]
        public string[] Businesses { get; set; }

        [JsonProperty("businessJobTitles")]
        public string[] BusinessJobTitles { get; set; }

        [JsonProperty("dates")]
        public string[] Dates { get; set; }

        [JsonProperty("miscellaneous")]
        public string[] Miscellaneous { get; set; }

        [JsonProperty("weightsAndMeasures")]
        public string[] WeightsAndMeasures { get; set; }

        [JsonProperty("qualifications")]
        public string[] Qualifications { get; set; }

        [JsonProperty("salutations")]
        public string[] Salutations { get; set; }

        [JsonProperty("countries")]
        public string[] Countries { get; set; }

        [JsonProperty("familyNames")]
        public string[] FamilyNames { get; set; }

        [JsonProperty("salacious")]
        public string[] Salacious { get; set; }
    }

    public enum categoriesInput
    {
        All,
        Addresses,
        Numbers,
        GivenNames,
        Businesses,
        BusinessJobTitles,
        Dates,
        Miscellaneous,
        WeightsAndMeasures,
        Qualifications,
        Salutations,
        Countries,
        FamilyNames,
        Salacious
    }

    public class DQGlobalFloat
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public double Data { get; set; }
    }

    public enum comparisonAlgorithmInput
    {
        JaroWinkler,
        Jaro,
        LevenshteinPercentage,
        LevenshteinChangeCount,
        MongeElkan,
        NeedlemanWunsch,
        Sift3,
        SmithWatermanGotoh,
        HammingPercentage,
        HammingChangeCount
    }

    public class CongruenceResultSingle
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public CongruenceResultSingleDataType Data { get; set; }
    }

    public class CongruenceResultSingleDataType
    {
        [JsonProperty("congruenceString")]
        public string CongruenceString { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public enum actionTypeInput
    {
        CountryToEmail,
        CountryToPhone,
        CountryToURL
    }

    public class DeriveGenderGetResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public DeriveGenderGetResponseDataType Data { get; set; }
    }

    public class DeriveGenderGetResponseDataType
    {
        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("resultCode")]
        public int ResultCode { get; set; }
    }

    public class DeriveCityGetResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public DeriveCityGetResponseDataTypeItem[] Data { get; set; }
    }

    public class DeriveCityGetResponseDataTypeItem
    {
        [JsonProperty("countryName")]
        public string CountryName { get; set; }

        [JsonProperty("iSO2")]
        public string ISO2 { get; set; }

        [JsonProperty("iSO3")]
        public string ISO3 { get; set; }

        [JsonProperty("iDD")]
        public string IDD { get; set; }
    }

    public class DerivePostCodeGetResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public DerivePostCodeGetResponseDataType Data { get; set; }
    }

    public class DerivePostCodeGetResponseDataType
    {
        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    public class DeriveEmailGetResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public DeriveEmailGetResponseDataType Data { get; set; }
    }

    public class DeriveEmailGetResponseDataType
    {
        [JsonProperty("domainType")]
        public string DomainType { get; set; }

        [JsonProperty("mailBoxType")]
        public string MailBoxType { get; set; }
    }

    public class DeriveISOGetResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public DeriveISOGetResponseDataTypeItem[] Data { get; set; }
    }

    public class DeriveISOGetResponseDataTypeItem
    {
        [JsonProperty("countryName")]
        public string CountryName { get; set; }

        [JsonProperty("congruentToGivenCountry")]
        public bool CongruentToGivenCountry { get; set; }

        [JsonProperty("matchCertainty")]
        public int MatchCertainty { get; set; }

        [JsonProperty("isO2")]
        public string IsO2 { get; set; }

        [JsonProperty("isO3")]
        public string IsO3 { get; set; }

        [JsonProperty("diallingCode")]
        public string DiallingCode { get; set; }
    }

    public class GeneratePatternResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GeneratePatternResponseDataTypeItem[] Data { get; set; }
    }

    public class GeneratePatternResponseDataTypeItem
    {
        [JsonProperty("input")]
        public string Input { get; set; }

        [JsonProperty("output")]
        public string Output { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class inputInputItem
    {
        public string Input { get; set; }
        public GenerateSettings PatternSetting { get; set; }
        public string UID { get; set; }
    }

    public class GenerateSettings
    {
        [JsonProperty("DoNotTokenize")]
        public GenerateSettingsExcludeFromTokenTypeItem[] ExcludeFromToken { get; set; }
        public GenerateLetterSettings LetterSettings { get; set; }
        public GenerateNumberSettings NumberSettings { get; set; }
        public GenerateSymbolSettings SymbolSettings { get; set; }
        public GenerateWhiteSpaceSettings WhiteSpaceSettings { get; set; }
        public GenerateNonPrintingSettings NonPrintingSettings { get; set; }
    }

    public enum GenerateSettingsExcludeFromTokenTypeItem
    {
        WhiteSpace,
        Numbers,
        Punctuation,
        Symbol,
        NonPrinting,
        Letters
    }

    public class GenerateLetterSettings
    {
        public bool CaseSensitive { get; set; }
        public bool LetterCategories { get; set; }
        public GenerateLetterSettingsExcludeTypeItem[] Exclude { get; set; }
        public GenerateLetterSettingsCollapseTypeItem[] Collapse { get; set; }
    }

    public enum GenerateLetterSettingsExcludeTypeItem
    {
        Vowels,
        Consonants
    }

    public enum GenerateLetterSettingsCollapseTypeItem
    {
        Vowels,
        Consonants
    }

    public class GenerateNumberSettings
    {
        public bool NumberCategories { get; set; }
        public GenerateNumberSettingsExcludeTypeItem[] Exclude { get; set; }
        public GenerateNumberSettingsCollapseTypeItem[] Collapse { get; set; }
    }

    public enum GenerateNumberSettingsExcludeTypeItem
    {
        Odd,
        Even
    }

    public enum GenerateNumberSettingsCollapseTypeItem
    {
        Odd,
        Even
    }

    public class GenerateSymbolSettings
    {
        public bool Exclude { get; set; }
        public bool Collapse { get; set; }
    }

    public class GenerateWhiteSpaceSettings
    {
        public bool Exclude { get; set; }
        public bool Collapse { get; set; }
    }

    public class GenerateNonPrintingSettings
    {
        public bool Exclude { get; set; }
        public bool Collapse { get; set; }
    }

    public enum generateAlgorithmTypeInput
    {
        DQFonetix,
        DQMetaphone,
        DQSoundex,
        Soundex,
        Metaphone,
        DoubleMetaphone,
        Caverphone,
        Caverphone2,
        Nysiis
    }

    public class ParsePhoneGetResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ParsePhoneGetResponseDataType Data { get; set; }
    }

    public class ParsePhoneGetResponseDataType
    {
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("nationalNumber")]
        public string NationalNumber { get; set; }

        [JsonProperty("numberType")]
        public ParsePhoneGetResponseDataTypeNumberTypeType NumberType { get; set; }
    }

    public enum ParsePhoneGetResponseDataTypeNumberTypeType
    {
        [EnumMember(Value = "FIXED_LINE")]
        FIXEDLINE,
        MOBILE,
        [EnumMember(Value = "FIXED_LINE_OR_MOBILE")]
        FIXEDLINEORMOBILE,
        [EnumMember(Value = "TOLL_FREE")]
        TOLLFREE,
        [EnumMember(Value = "PREMIUM_RATE")]
        PREMIUMRATE,
        [EnumMember(Value = "SHARED_COST")]
        SHAREDCOST,
        VOIP,
        [EnumMember(Value = "PERSONAL_NUMBER")]
        PERSONALNUMBER,
        PAGER,
        UAN,
        VOICEMAIL,
        UNKNOWN
    }

    public class ParseEmailGetResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ParseEmailGetResponseDataType Data { get; set; }
    }

    public class ParseEmailGetResponseDataType
    {
        [JsonProperty("mailbox")]
        public string Mailbox { get; set; }

        [JsonProperty("localPart")]
        public string LocalPart { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("tld")]
        public string Tld { get; set; }
    }

    public class ParseURLGetResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ParseURLGetResponseDataType Data { get; set; }
    }

    public class ParseURLGetResponseDataType
    {
        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("hostNameType")]
        public ParseURLGetResponseDataTypeHostNameTypeType HostNameType { get; set; }

        [JsonProperty("pathAndQuery")]
        public string PathAndQuery { get; set; }

        [JsonProperty("port")]
        public string Port { get; set; }
    }

    public enum ParseURLGetResponseDataTypeHostNameTypeType
    {
        Unknown,
        Basic,
        Dns,
        IPv4,
        IPv6
    }

    public enum entityTypeInput
    {
        Addresses,
        Numbers,
        GivenNames,
        Businesses,
        BusinessJobTitles,
        Dates,
        Miscellaneous,
        WeightsAndMeasures,
        Qualifications,
        Salutations,
        Countries,
        FamilyNames,
        Salacious
    }

    public enum operationTypeInput
    {
        Elaborate,
        Abbreviate,
        Normalize,
        Exclude,
        Transliterate
    }

    public class SequenceTransformResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public SequenceTransformResponseDataTypeItem[] Data { get; set; }
    }

    public class SequenceTransformResponseDataTypeItem
    {
        [JsonProperty("input")]
        public string Input { get; set; }

        [JsonProperty("output")]
        public string Output { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class inputInputItem2
    {
        public string Input { get; set; }
        public inputInputItemSettingsTypeItem[] Settings { get; set; }

        [JsonProperty("UID")]
        public string RecordId { get; set; }
    }

    public class inputInputItemSettingsTypeItem
    {
        [JsonProperty("EntityType")]
        public inputInputItemSettingsTypeItemCategoryType Category { get; set; }

        [JsonProperty("OperationType")]
        public inputInputItemSettingsTypeItemActionType Action { get; set; }
        public inputInputItemSettingsTypeItemLanguageType Language { get; set; }
    }

    public enum inputInputItemSettingsTypeItemCategoryType
    {
        Addresses,
        Numbers,
        GivenNames,
        Businesses,
        BusinessJobTitles,
        Dates,
        Miscellaneous,
        WeightsAndMeasures,
        Qualifications,
        Salutations,
        Countries,
        FamilyNames,
        Salacious
    }

    public enum inputInputItemSettingsTypeItemActionType
    {
        Elaborate,
        Abbreviate,
        Normalize,
        Exclude,
        Transliterate
    }

    public enum inputInputItemSettingsTypeItemLanguageType
    {
        English,
        Spanish,
        French,
        Italian,
        German
    }

    public class DQGlobalBool
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public bool Data { get; set; }
    }

    public class ValidatePlusEmailGetResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ValidatePlusEmailGetResponseDataType Data { get; set; }
    }

    public class ValidatePlusEmailGetResponseDataType
    {
        [JsonProperty("isValid")]
        public bool IsValid { get; set; }

        [JsonProperty("messages")]
        public string[] Messages { get; set; }
    }

    public class ValidatePlusPostCodeGetResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ValidatePlusPostCodeGetResponseDataType Data { get; set; }
    }

    public class ValidatePlusPostCodeGetResponseDataType
    {
        [JsonProperty("isValid")]
        public bool IsValid { get; set; }

        [JsonProperty("messages")]
        public string[] Messages { get; set; }
    }

    public class ValidatePlusURLGetResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ValidatePlusURLGetResponseDataType Data { get; set; }
    }

    public class ValidatePlusURLGetResponseDataType
    {
        [JsonProperty("isValid")]
        public bool IsValid { get; set; }

        [JsonProperty("messages")]
        public string[] Messages { get; set; }
    }

    public class VerifyAddressGetResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public VerifyAddressGetResponseDataType Data { get; set; }
    }

    public class VerifyAddressGetResponseDataType
    {
        [JsonProperty("dqLine1")]
        public string DqLine1 { get; set; }

        [JsonProperty("dqLine2")]
        public string DqLine2 { get; set; }

        [JsonProperty("dqLine3")]
        public string DqLine3 { get; set; }

        [JsonProperty("dqLine4")]
        public string DqLine4 { get; set; }

        [JsonProperty("dqCity")]
        public string DqCity { get; set; }

        [JsonProperty("dqCounty_District")]
        public string DqCountyDistrict { get; set; }

        [JsonProperty("dqState_Province")]
        public string DqStateProvince { get; set; }

        [JsonProperty("dqziP_PostalCode")]
        public string DqziPPostalCode { get; set; }

        [JsonProperty("dqCountry")]
        public string DqCountry { get; set; }

        [JsonProperty("dqisO3")]
        public string DqisO3 { get; set; }

        [JsonProperty("dqisO2")]
        public string DqisO2 { get; set; }

        [JsonProperty("dqLatitude")]
        public string DqLatitude { get; set; }

        [JsonProperty("dqLongitude")]
        public string DqLongitude { get; set; }

        [JsonProperty("status")]
        public VerifyAddressGetResponseDataTypeStatusType Status { get; set; }

        [JsonProperty("additionalInfo")]
        public JToken AdditionalInfo { get; set; }
    }

    public enum VerifyAddressGetResponseDataTypeStatusType
    {
        VERIFIED,
        SUSPECT,
        UNVERIFIED
    }

    public enum providerInput
    {
        Default,
        TextMagic,
        Loqate,
        Fetchify,
        AFD
    }

    public class SearchAddressFindResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public SearchAddressFindResponseDataTypeItem[] Data { get; set; }
    }

    public class SearchAddressFindResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("subLabel")]
        public string SubLabel { get; set; }

        [JsonProperty("additionalInfo")]
        public JToken AdditionalInfo { get; set; }
    }

    public class SearchAddressRetrieveResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public SearchAddressRetrieveResponseDataTypeItem[] Data { get; set; }
    }

    public class SearchAddressRetrieveResponseDataTypeItem
    {
        [JsonProperty("dqLine1")]
        public string DqLine1 { get; set; }

        [JsonProperty("dqLine2")]
        public string DqLine2 { get; set; }

        [JsonProperty("dqLine3")]
        public string DqLine3 { get; set; }

        [JsonProperty("dqLine4")]
        public string DqLine4 { get; set; }

        [JsonProperty("dqCity")]
        public string DqCity { get; set; }

        [JsonProperty("dqCounty_District")]
        public string DqCountyDistrict { get; set; }

        [JsonProperty("dqState_Province")]
        public string DqStateProvince { get; set; }

        [JsonProperty("dqziP_PostalCode")]
        public string DqziPPostalCode { get; set; }

        [JsonProperty("dqCountry")]
        public string DqCountry { get; set; }

        [JsonProperty("dqisO3")]
        public string DqisO3 { get; set; }

        [JsonProperty("dqisO2")]
        public string DqisO2 { get; set; }

        [JsonProperty("additionalInfo")]
        public JToken AdditionalInfo { get; set; }
    }

    public class SuppressDeceasedResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public SuppressDeceasedResponseDataType Data { get; set; }
    }

    public class SuppressDeceasedResponseDataType
    {
        [JsonProperty("status")]
        public SuppressDeceasedResponseDataTypeStatusType Status { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("additionalInfo")]
        public JToken AdditionalInfo { get; set; }
    }

    public enum SuppressDeceasedResponseDataTypeStatusType
    {
        Suppressed,
        Suspect,
        NotFound
    }

    public class SuppressGoneAwayResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public SuppressGoneAwayResponseDataType Data { get; set; }
    }

    public class SuppressGoneAwayResponseDataType
    {
        [JsonProperty("status")]
        public SuppressGoneAwayResponseDataTypeStatusType Status { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("additionalInfo")]
        public JToken AdditionalInfo { get; set; }
    }

    public enum SuppressGoneAwayResponseDataTypeStatusType
    {
        Suppressed,
        Suspect,
        NotFound
    }

    public class SuppressRelocatedResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public SuppressRelocatedResponseDataType Data { get; set; }
    }

    public class SuppressRelocatedResponseDataType
    {
        [JsonProperty("status")]
        public SuppressRelocatedResponseDataTypeStatusType Status { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("newAddress")]
        public SuppressRelocatedResponseDataTypeNewAddressType NewAddress { get; set; }

        [JsonProperty("additionalInfo")]
        public JToken AdditionalInfo { get; set; }
    }

    public enum SuppressRelocatedResponseDataTypeStatusType
    {
        Suppressed,
        Suspect,
        NotFound
    }

    public class SuppressRelocatedResponseDataTypeNewAddressType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("forename")]
        public string Forename { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("moveDate")]
        public string MoveDate { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("town")]
        public string Town { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }
    }

    public class SuppressPhonePersonalResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public SuppressPhonePersonalResponseDataType Data { get; set; }
    }

    public class SuppressPhonePersonalResponseDataType
    {
        [JsonProperty("result")]
        public bool Result { get; set; }

        [JsonProperty("additionalInfo")]
        public JToken AdditionalInfo { get; set; }
    }

    public class SuppressPhoneCorporateResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public SuppressPhoneCorporateResponseDataType Data { get; set; }
    }

    public class SuppressPhoneCorporateResponseDataType
    {
        [JsonProperty("result")]
        public bool Result { get; set; }

        [JsonProperty("additionalInfo")]
        public JToken AdditionalInfo { get; set; }
    }

    public class AuthenticateEmailGetResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public AuthenticateEmailGetResponseDataType Data { get; set; }
    }

    public class AuthenticateEmailGetResponseDataType
    {
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("domainPart")]
        public string DomainPart { get; set; }

        [JsonProperty("isCorporate")]
        public bool IsCorporate { get; set; }

        [JsonProperty("isDisposable")]
        public bool IsDisposable { get; set; }

        [JsonProperty("isRoleBased")]
        public bool IsRoleBased { get; set; }

        [JsonProperty("localPart")]
        public string LocalPart { get; set; }

        [JsonProperty("result")]
        public bool Result { get; set; }

        [JsonProperty("additionalInfo")]
        public JToken AdditionalInfo { get; set; }
    }

    public class AuthenticatePhoneGetResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public AuthenticatePhoneGetResponseDataType Data { get; set; }
    }

    public class AuthenticatePhoneGetResponseDataType
    {
        [JsonProperty("numberType")]
        public AuthenticatePhoneGetResponseDataTypeNumberTypeType NumberType { get; set; }

        [JsonProperty("isO2")]
        public string IsO2 { get; set; }

        [JsonProperty("isO3")]
        public string IsO3 { get; set; }

        [JsonProperty("dialingCode")]
        public string DialingCode { get; set; }

        [JsonProperty("nationalFormat")]
        public string NationalFormat { get; set; }

        [JsonProperty("result")]
        public bool Result { get; set; }

        [JsonProperty("additionalInfo")]
        public JToken AdditionalInfo { get; set; }
    }

    public enum AuthenticatePhoneGetResponseDataTypeNumberTypeType
    {
        Mobile,
        Landline,
        VOIP,
        Unknown
    }

    public enum characterTypeInput
    {
        Digit,
        Letter,
        LetterOrDigit,
        Punctuation,
        Whitespace,
        Upper,
        Lower,
        Symbol,
        UpperCaseVowel,
        LowerCaseVowel,
        UpperCaseConsonant,
        LowerCaseConsonant,
        OddDigit,
        EvenDigit,
        NonPrinting
    }

    public enum typeInput
    {
        Letter,
        LowerCaseLetter,
        UpperCaseLetter,
        UpperCaseVowel,
        LowerCaseVowel,
        UpperCaseConsonant,
        LowerCaseConsonant,
        LetterOrNumber,
        Number,
        Punctuation,
        Whitespace,
        Symbol,
        NonPrinting
    }

    public enum extractFromInput
    {
        Start,
        End
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dqondemand;

    public partial class WorkflowManagedActions
    {
        public DqondemandActions Dqondemand(string connectionId) => new DqondemandActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DqondemandTriggers Dqondemand(string connectionId) => new DqondemandTriggers(connectionId);
    }
}