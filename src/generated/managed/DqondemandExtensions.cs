//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dqondemand
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class DqondemandActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<GetUsage> UsageGet(Expression<Func<string>> startDate, Expression<Func<string>> endDate)
        {
            var __workflow_startDate = startDate == null ? null : WorkflowExpression.Compile(startDate);
            WorkflowExpression.Validate(__workflow_startDate, nameof(startDate), required: true);
            var __workflow_endDate = endDate == null ? null : WorkflowExpression.Compile(endDate);
            WorkflowExpression.Validate(__workflow_endDate, nameof(endDate), required: true);
            return new DeferredBodyAction<GetUsage>(() =>
            {
                var apiCallPath = "/Account/Usage";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["StartDate"] = ExpressionConverter.Convert(__workflow_startDate);
                callPayload.Queries["EndDate"] = ExpressionConverter.Convert(__workflow_endDate);
                return new ApiConnectionAction<GetUsage>(callPayload);
            });
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
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_caseType = caseType == null ? null : WorkflowExpression.Compile(caseType);
            WorkflowExpression.Validate(__workflow_caseType, nameof(caseType), required: true);
            var __workflow_language = language == null ? null : WorkflowExpression.Compile(language);
            WorkflowExpression.Validate(__workflow_language, nameof(language), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/Case";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["CaseType"] = ExpressionConverter.Convert(__workflow_caseType);
                callPayload.Queries["Language"] = ExpressionConverter.Convert(__workflow_language);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ClassifyGetResponse> ClassifyGet(Expression<Func<string>> input, Expression<Func<categoriesInput>> categories, Expression<Func<languageInput>> language = null)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_categories = categories == null ? null : WorkflowExpression.Compile(categories);
            WorkflowExpression.Validate(__workflow_categories, nameof(categories), required: true);
            var __workflow_language = language == null ? null : WorkflowExpression.Compile(language);
            WorkflowExpression.Validate(__workflow_language, nameof(language), required: false);
            return new DeferredBodyAction<ClassifyGetResponse>(() =>
            {
                var apiCallPath = "/Classify";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["Categories"] = ExpressionConverter.Convert(__workflow_categories);
                callPayload.Queries["Language"] = Convert.ToString("English");
                if (__workflow_language != null)
                    callPayload.Queries["Language"] = ExpressionConverter.Convert(__workflow_language);
                return new ApiConnectionAction<ClassifyGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalFloat> CompareGet(Expression<Func<string>> input1, Expression<Func<string>> input2, Expression<Func<comparisonAlgorithmInput>> comparisonAlgorithm)
        {
            var __workflow_input1 = input1 == null ? null : WorkflowExpression.Compile(input1);
            WorkflowExpression.Validate(__workflow_input1, nameof(input1), required: true);
            var __workflow_input2 = input2 == null ? null : WorkflowExpression.Compile(input2);
            WorkflowExpression.Validate(__workflow_input2, nameof(input2), required: true);
            var __workflow_comparisonAlgorithm = comparisonAlgorithm == null ? null : WorkflowExpression.Compile(comparisonAlgorithm);
            WorkflowExpression.Validate(__workflow_comparisonAlgorithm, nameof(comparisonAlgorithm), required: true);
            return new DeferredBodyAction<DQGlobalFloat>(() =>
            {
                var apiCallPath = "/Compare";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input1"] = ExpressionConverter.Convert(__workflow_input1);
                callPayload.Queries["Input2"] = ExpressionConverter.Convert(__workflow_input2);
                callPayload.Queries["ComparisonAlgorithm"] = ExpressionConverter.Convert(__workflow_comparisonAlgorithm);
                return new ApiConnectionAction<DQGlobalFloat>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<CongruenceResultSingle> EmailCongruenceGet(Expression<Func<string>> email, Expression<Func<string>> firstName, Expression<Func<string>> lastName)
        {
            var __workflow_email = email == null ? null : WorkflowExpression.Compile(email);
            WorkflowExpression.Validate(__workflow_email, nameof(email), required: true);
            var __workflow_firstName = firstName == null ? null : WorkflowExpression.Compile(firstName);
            WorkflowExpression.Validate(__workflow_firstName, nameof(firstName), required: true);
            var __workflow_lastName = lastName == null ? null : WorkflowExpression.Compile(lastName);
            WorkflowExpression.Validate(__workflow_lastName, nameof(lastName), required: true);
            return new DeferredBodyAction<CongruenceResultSingle>(() =>
            {
                var apiCallPath = "/Congruence/Email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Email"] = ExpressionConverter.Convert(__workflow_email);
                callPayload.Queries["FirstName"] = ExpressionConverter.Convert(__workflow_firstName);
                callPayload.Queries["LastName"] = ExpressionConverter.Convert(__workflow_lastName);
                return new ApiConnectionAction<CongruenceResultSingle>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<CongruenceResultSingle> CountryCongruenceGet(Expression<Func<string>> input, Expression<Func<string>> country, Expression<Func<actionTypeInput>> actionType)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_country = country == null ? null : WorkflowExpression.Compile(country);
            WorkflowExpression.Validate(__workflow_country, nameof(country), required: true);
            var __workflow_actionType = actionType == null ? null : WorkflowExpression.Compile(actionType);
            WorkflowExpression.Validate(__workflow_actionType, nameof(actionType), required: true);
            return new DeferredBodyAction<CongruenceResultSingle>(() =>
            {
                var apiCallPath = "/Congruence/Country";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["Country"] = ExpressionConverter.Convert(__workflow_country);
                callPayload.Queries["ActionType"] = ExpressionConverter.Convert(__workflow_actionType);
                return new ApiConnectionAction<CongruenceResultSingle>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<CongruenceResultSingle> SalutationCongruenceGet(Expression<Func<string>> salutation, Expression<Func<string>> firstName, Expression<Func<languageInput>> language)
        {
            var __workflow_salutation = salutation == null ? null : WorkflowExpression.Compile(salutation);
            WorkflowExpression.Validate(__workflow_salutation, nameof(salutation), required: true);
            var __workflow_firstName = firstName == null ? null : WorkflowExpression.Compile(firstName);
            WorkflowExpression.Validate(__workflow_firstName, nameof(firstName), required: true);
            var __workflow_language = language == null ? null : WorkflowExpression.Compile(language);
            WorkflowExpression.Validate(__workflow_language, nameof(language), required: true);
            return new DeferredBodyAction<CongruenceResultSingle>(() =>
            {
                var apiCallPath = "/Congruence/Salutation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Salutation"] = ExpressionConverter.Convert(__workflow_salutation);
                callPayload.Queries["FirstName"] = ExpressionConverter.Convert(__workflow_firstName);
                callPayload.Queries["Language"] = ExpressionConverter.Convert(__workflow_language);
                return new ApiConnectionAction<CongruenceResultSingle>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DeriveGenderGetResponse> DeriveGenderGet(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DeriveGenderGetResponse>(() =>
            {
                var apiCallPath = "/Derive/Gender";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DeriveGenderGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DeriveCityGetResponse> DeriveCityGet(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DeriveCityGetResponse>(() =>
            {
                var apiCallPath = "/Derive/CountryFromCity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DeriveCityGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DerivePostCodeGetResponse> DerivePostCodeGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_countryIdentifier = countryIdentifier == null ? null : WorkflowExpression.Compile(countryIdentifier);
            WorkflowExpression.Validate(__workflow_countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DerivePostCodeGetResponse>(() =>
            {
                var apiCallPath = "/Derive/FromPostalCode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                return new ApiConnectionAction<DerivePostCodeGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DeriveEmailGetResponse> DeriveEmailGet(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DeriveEmailGetResponse>(() =>
            {
                var apiCallPath = "/Derive/EmailType";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DeriveEmailGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DeriveISOGetResponse> DeriveISOGet(Expression<Func<string>> email = null, Expression<Func<string>> url = null, Expression<Func<string>> phone = null, Expression<Func<string>> country = null, Expression<Func<string>> city = null, Expression<Func<int>> threshold = null, Expression<Func<bool>> onlyReturnBest = null, Expression<Func<bool>> defaultToCountry = null)
        {
            var __workflow_email = email == null ? null : WorkflowExpression.Compile(email);
            WorkflowExpression.Validate(__workflow_email, nameof(email), required: false);
            var __workflow_url = url == null ? null : WorkflowExpression.Compile(url);
            WorkflowExpression.Validate(__workflow_url, nameof(url), required: false);
            var __workflow_phone = phone == null ? null : WorkflowExpression.Compile(phone);
            WorkflowExpression.Validate(__workflow_phone, nameof(phone), required: false);
            var __workflow_country = country == null ? null : WorkflowExpression.Compile(country);
            WorkflowExpression.Validate(__workflow_country, nameof(country), required: false);
            var __workflow_city = city == null ? null : WorkflowExpression.Compile(city);
            WorkflowExpression.Validate(__workflow_city, nameof(city), required: false);
            var __workflow_threshold = threshold == null ? null : WorkflowExpression.Compile(threshold);
            WorkflowExpression.Validate(__workflow_threshold, nameof(threshold), required: false);
            var __workflow_onlyReturnBest = onlyReturnBest == null ? null : WorkflowExpression.Compile(onlyReturnBest);
            WorkflowExpression.Validate(__workflow_onlyReturnBest, nameof(onlyReturnBest), required: false);
            var __workflow_defaultToCountry = defaultToCountry == null ? null : WorkflowExpression.Compile(defaultToCountry);
            WorkflowExpression.Validate(__workflow_defaultToCountry, nameof(defaultToCountry), required: false);
            return new DeferredBodyAction<DeriveISOGetResponse>(() =>
            {
                var apiCallPath = "/DeriveISO";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_email != null)
                    callPayload.Queries["Email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_url != null)
                    callPayload.Queries["Url"] = ExpressionConverter.Convert(__workflow_url);
                if (__workflow_phone != null)
                    callPayload.Queries["Phone"] = ExpressionConverter.Convert(__workflow_phone);
                if (__workflow_country != null)
                    callPayload.Queries["Country"] = ExpressionConverter.Convert(__workflow_country);
                if (__workflow_city != null)
                    callPayload.Queries["City"] = ExpressionConverter.Convert(__workflow_city);
                callPayload.Queries["Threshold"] = Convert.ToString(70);
                if (__workflow_threshold != null)
                    callPayload.Queries["Threshold"] = ExpressionConverter.Convert(__workflow_threshold);
                callPayload.Queries["OnlyReturnBest"] = Convert.ToString(false);
                if (__workflow_onlyReturnBest != null)
                    callPayload.Queries["OnlyReturnBest"] = ExpressionConverter.Convert(__workflow_onlyReturnBest);
                callPayload.Queries["DefaultToCountry"] = Convert.ToString(false);
                if (__workflow_defaultToCountry != null)
                    callPayload.Queries["DefaultToCountry"] = ExpressionConverter.Convert(__workflow_defaultToCountry);
                return new ApiConnectionAction<DeriveISOGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> FormatEmailGet(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/Format/Email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> FormatPostCodeGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_countryIdentifier = countryIdentifier == null ? null : WorkflowExpression.Compile(countryIdentifier);
            WorkflowExpression.Validate(__workflow_countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/Format/PostCode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> FormatE164Get(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_countryIdentifier = countryIdentifier == null ? null : WorkflowExpression.Compile(countryIdentifier);
            WorkflowExpression.Validate(__workflow_countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/Format/TelephoneE164";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> FormatInternationalGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_countryIdentifier = countryIdentifier == null ? null : WorkflowExpression.Compile(countryIdentifier);
            WorkflowExpression.Validate(__workflow_countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/Format/TelephoneInternational";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> FormatNationalGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_countryIdentifier = countryIdentifier == null ? null : WorkflowExpression.Compile(countryIdentifier);
            WorkflowExpression.Validate(__workflow_countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/Format/TelephoneNational";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> FormatRFC3966Get(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_countryIdentifier = countryIdentifier == null ? null : WorkflowExpression.Compile(countryIdentifier);
            WorkflowExpression.Validate(__workflow_countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/Format/TelephoneRFC3966";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> FormatURLGet(Expression<Func<string>> input, Expression<Func<string>> uRLPrefix)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_uRLPrefix = uRLPrefix == null ? null : WorkflowExpression.Compile(uRLPrefix);
            WorkflowExpression.Validate(__workflow_uRLPrefix, nameof(uRLPrefix), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/Format/UrlAddress";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["URLPrefix"] = ExpressionConverter.Convert(__workflow_uRLPrefix);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<GeneratePatternResponse> GeneratePattern(Expression<Func<inputInputItem[]>> input = null)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: false);
            return new DeferredBodyAction<GeneratePatternResponse>(() =>
            {
                var apiCallPath = "/Generate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<GeneratePatternResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> GenerateTokenGet(Expression<Func<string>> input, Expression<Func<generateAlgorithmTypeInput>> generateAlgorithmType, Expression<Func<languageInput>> language = null)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_generateAlgorithmType = generateAlgorithmType == null ? null : WorkflowExpression.Compile(generateAlgorithmType);
            WorkflowExpression.Validate(__workflow_generateAlgorithmType, nameof(generateAlgorithmType), required: true);
            var __workflow_language = language == null ? null : WorkflowExpression.Compile(language);
            WorkflowExpression.Validate(__workflow_language, nameof(language), required: false);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/GenerateToken";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["generateAlgorithmType"] = ExpressionConverter.Convert(__workflow_generateAlgorithmType);
                callPayload.Queries["Language"] = Convert.ToString("English");
                if (__workflow_language != null)
                    callPayload.Queries["Language"] = ExpressionConverter.Convert(__workflow_language);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ParsePhoneGetResponse> ParsePhoneGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_countryIdentifier = countryIdentifier == null ? null : WorkflowExpression.Compile(countryIdentifier);
            WorkflowExpression.Validate(__workflow_countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<ParsePhoneGetResponse>(() =>
            {
                var apiCallPath = "/Parse/PhoneNumber";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                return new ApiConnectionAction<ParsePhoneGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ParseEmailGetResponse> ParseEmailGet(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<ParseEmailGetResponse>(() =>
            {
                var apiCallPath = "/Parse/Email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<ParseEmailGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ParseURLGetResponse> ParseURLGet(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<ParseURLGetResponse>(() =>
            {
                var apiCallPath = "/Parse/URL";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<ParseURLGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ScoringResponse> Scoring(Expression<Func<inputInputItem2[]>> input = null)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: false);
            return new DeferredBodyAction<ScoringResponse>(() =>
            {
                var apiCallPath = "/Scoring";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<ScoringResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> TransformGet(Expression<Func<string>> input, Expression<Func<entityTypeInput>> entityType, Expression<Func<operationTypeInput>> operationType, Expression<Func<languageInput>> language = null)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_entityType = entityType == null ? null : WorkflowExpression.Compile(entityType);
            WorkflowExpression.Validate(__workflow_entityType, nameof(entityType), required: true);
            var __workflow_operationType = operationType == null ? null : WorkflowExpression.Compile(operationType);
            WorkflowExpression.Validate(__workflow_operationType, nameof(operationType), required: true);
            var __workflow_language = language == null ? null : WorkflowExpression.Compile(language);
            WorkflowExpression.Validate(__workflow_language, nameof(language), required: false);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/Transform";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["EntityType"] = ExpressionConverter.Convert(__workflow_entityType);
                callPayload.Queries["OperationType"] = ExpressionConverter.Convert(__workflow_operationType);
                callPayload.Queries["Language"] = Convert.ToString("English");
                if (__workflow_language != null)
                    callPayload.Queries["Language"] = ExpressionConverter.Convert(__workflow_language);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SequenceTransformResponse> SequenceTransform(Expression<Func<inputInputItem22[]>> input = null)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: false);
            return new DeferredBodyAction<SequenceTransformResponse>(() =>
            {
                var apiCallPath = "/SequenceTransform";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<SequenceTransformResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> ValidateEmailGet(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/Validate/Email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> ValidatePostCodeGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_countryIdentifier = countryIdentifier == null ? null : WorkflowExpression.Compile(countryIdentifier);
            WorkflowExpression.Validate(__workflow_countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/Validate/PostCode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> ValidateURLGet(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/Validate/UrlAddress";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> ValidatePhoneGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_countryIdentifier = countryIdentifier == null ? null : WorkflowExpression.Compile(countryIdentifier);
            WorkflowExpression.Validate(__workflow_countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/Validate/Telephone";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> ValidateDateTimeGet(Expression<Func<string>> input, Expression<Func<string>> dateTimeFormat)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_dateTimeFormat = dateTimeFormat == null ? null : WorkflowExpression.Compile(dateTimeFormat);
            WorkflowExpression.Validate(__workflow_dateTimeFormat, nameof(dateTimeFormat), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/Validate/DateTime";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["DateTimeFormat"] = ExpressionConverter.Convert(__workflow_dateTimeFormat);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ValidatePlusEmailGetResponse> ValidatePlusEmailGet(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<ValidatePlusEmailGetResponse>(() =>
            {
                var apiCallPath = "/ValidatePlus/Email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<ValidatePlusEmailGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ValidatePlusPostCodeGetResponse> ValidatePlusPostCodeGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_countryIdentifier = countryIdentifier == null ? null : WorkflowExpression.Compile(countryIdentifier);
            WorkflowExpression.Validate(__workflow_countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<ValidatePlusPostCodeGetResponse>(() =>
            {
                var apiCallPath = "/ValidatePlus/PostCode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                return new ApiConnectionAction<ValidatePlusPostCodeGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ValidatePlusURLGetResponse> ValidatePlusURLGet(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<ValidatePlusURLGetResponse>(() =>
            {
                var apiCallPath = "/ValidatePlus/UrlAddress";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<ValidatePlusURLGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<VerifyAddressGetResponse> VerifyAddressGet(Expression<Func<providerInput>> provider, Expression<Func<string>> countryIdentifier, Expression<Func<bool>> geocode, Expression<Func<string>> line1 = null, Expression<Func<string>> line2 = null, Expression<Func<string>> line3 = null, Expression<Func<string>> postalCode = null, Expression<Func<string>> city = null, Expression<Func<string>> state = null)
        {
            var __workflow_provider = provider == null ? null : WorkflowExpression.Compile(provider);
            WorkflowExpression.Validate(__workflow_provider, nameof(provider), required: true);
            var __workflow_countryIdentifier = countryIdentifier == null ? null : WorkflowExpression.Compile(countryIdentifier);
            WorkflowExpression.Validate(__workflow_countryIdentifier, nameof(countryIdentifier), required: true);
            var __workflow_geocode = geocode == null ? null : WorkflowExpression.Compile(geocode);
            WorkflowExpression.Validate(__workflow_geocode, nameof(geocode), required: true);
            var __workflow_line1 = line1 == null ? null : WorkflowExpression.Compile(line1);
            WorkflowExpression.Validate(__workflow_line1, nameof(line1), required: false);
            var __workflow_line2 = line2 == null ? null : WorkflowExpression.Compile(line2);
            WorkflowExpression.Validate(__workflow_line2, nameof(line2), required: false);
            var __workflow_line3 = line3 == null ? null : WorkflowExpression.Compile(line3);
            WorkflowExpression.Validate(__workflow_line3, nameof(line3), required: false);
            var __workflow_postalCode = postalCode == null ? null : WorkflowExpression.Compile(postalCode);
            WorkflowExpression.Validate(__workflow_postalCode, nameof(postalCode), required: false);
            var __workflow_city = city == null ? null : WorkflowExpression.Compile(city);
            WorkflowExpression.Validate(__workflow_city, nameof(city), required: false);
            var __workflow_state = state == null ? null : WorkflowExpression.Compile(state);
            WorkflowExpression.Validate(__workflow_state, nameof(state), required: false);
            return new DeferredBodyAction<VerifyAddressGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Verify/Address/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_line1 != null)
                    callPayload.Queries["Line1"] = ExpressionConverter.Convert(__workflow_line1);
                if (__workflow_line2 != null)
                    callPayload.Queries["Line2"] = ExpressionConverter.Convert(__workflow_line2);
                if (__workflow_line3 != null)
                    callPayload.Queries["Line3"] = ExpressionConverter.Convert(__workflow_line3);
                if (__workflow_postalCode != null)
                    callPayload.Queries["PostalCode"] = ExpressionConverter.Convert(__workflow_postalCode);
                if (__workflow_city != null)
                    callPayload.Queries["City"] = ExpressionConverter.Convert(__workflow_city);
                if (__workflow_state != null)
                    callPayload.Queries["State"] = ExpressionConverter.Convert(__workflow_state);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                callPayload.Queries["Geocode"] = ExpressionConverter.Convert(__workflow_geocode);
                return new ApiConnectionAction<VerifyAddressGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SearchAddressFindResponse> SearchAddressFind(Expression<Func<providerInput>> provider, Expression<Func<string>> query, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_provider = provider == null ? null : WorkflowExpression.Compile(provider);
            WorkflowExpression.Validate(__workflow_provider, nameof(provider), required: true);
            var __workflow_query = query == null ? null : WorkflowExpression.Compile(query);
            WorkflowExpression.Validate(__workflow_query, nameof(query), required: true);
            var __workflow_countryIdentifier = countryIdentifier == null ? null : WorkflowExpression.Compile(countryIdentifier);
            WorkflowExpression.Validate(__workflow_countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<SearchAddressFindResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Search/Address/Find/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                return new ApiConnectionAction<SearchAddressFindResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SearchAddressRetrieveResponse> SearchAddressRetrieve(Expression<Func<providerInput>> provider, Expression<Func<string>> id, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_provider = provider == null ? null : WorkflowExpression.Compile(provider);
            WorkflowExpression.Validate(__workflow_provider, nameof(provider), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_countryIdentifier = countryIdentifier == null ? null : WorkflowExpression.Compile(countryIdentifier);
            WorkflowExpression.Validate(__workflow_countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<SearchAddressRetrieveResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Search/Address/Retrieve/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                return new ApiConnectionAction<SearchAddressRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SuppressDeceasedResponse> SuppressDeceased(Expression<Func<providerInput>> provider, Expression<Func<string>> lastName, Expression<Func<string>> postcode, Expression<Func<string>> countryIdentifier, Expression<Func<string>> title = null, Expression<Func<string>> firstName = null, Expression<Func<string>> line1 = null, Expression<Func<string>> line2 = null, Expression<Func<string>> line3 = null, Expression<Func<string>> town = null, Expression<Func<string>> county = null)
        {
            var __workflow_provider = provider == null ? null : WorkflowExpression.Compile(provider);
            WorkflowExpression.Validate(__workflow_provider, nameof(provider), required: true);
            var __workflow_lastName = lastName == null ? null : WorkflowExpression.Compile(lastName);
            WorkflowExpression.Validate(__workflow_lastName, nameof(lastName), required: true);
            var __workflow_postcode = postcode == null ? null : WorkflowExpression.Compile(postcode);
            WorkflowExpression.Validate(__workflow_postcode, nameof(postcode), required: true);
            var __workflow_countryIdentifier = countryIdentifier == null ? null : WorkflowExpression.Compile(countryIdentifier);
            WorkflowExpression.Validate(__workflow_countryIdentifier, nameof(countryIdentifier), required: true);
            var __workflow_title = title == null ? null : WorkflowExpression.Compile(title);
            WorkflowExpression.Validate(__workflow_title, nameof(title), required: false);
            var __workflow_firstName = firstName == null ? null : WorkflowExpression.Compile(firstName);
            WorkflowExpression.Validate(__workflow_firstName, nameof(firstName), required: false);
            var __workflow_line1 = line1 == null ? null : WorkflowExpression.Compile(line1);
            WorkflowExpression.Validate(__workflow_line1, nameof(line1), required: false);
            var __workflow_line2 = line2 == null ? null : WorkflowExpression.Compile(line2);
            WorkflowExpression.Validate(__workflow_line2, nameof(line2), required: false);
            var __workflow_line3 = line3 == null ? null : WorkflowExpression.Compile(line3);
            WorkflowExpression.Validate(__workflow_line3, nameof(line3), required: false);
            var __workflow_town = town == null ? null : WorkflowExpression.Compile(town);
            WorkflowExpression.Validate(__workflow_town, nameof(town), required: false);
            var __workflow_county = county == null ? null : WorkflowExpression.Compile(county);
            WorkflowExpression.Validate(__workflow_county, nameof(county), required: false);
            return new DeferredBodyAction<SuppressDeceasedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Suppress/Address/Deceased/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_title != null)
                    callPayload.Queries["Title"] = ExpressionConverter.Convert(__workflow_title);
                if (__workflow_firstName != null)
                    callPayload.Queries["FirstName"] = ExpressionConverter.Convert(__workflow_firstName);
                callPayload.Queries["LastName"] = ExpressionConverter.Convert(__workflow_lastName);
                if (__workflow_line1 != null)
                    callPayload.Queries["Line1"] = ExpressionConverter.Convert(__workflow_line1);
                if (__workflow_line2 != null)
                    callPayload.Queries["Line2"] = ExpressionConverter.Convert(__workflow_line2);
                if (__workflow_line3 != null)
                    callPayload.Queries["Line3"] = ExpressionConverter.Convert(__workflow_line3);
                if (__workflow_town != null)
                    callPayload.Queries["Town"] = ExpressionConverter.Convert(__workflow_town);
                if (__workflow_county != null)
                    callPayload.Queries["County"] = ExpressionConverter.Convert(__workflow_county);
                callPayload.Queries["Postcode"] = ExpressionConverter.Convert(__workflow_postcode);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                return new ApiConnectionAction<SuppressDeceasedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SuppressGoneAwayResponse> SuppressGoneAway(Expression<Func<providerInput>> provider, Expression<Func<string>> lastName, Expression<Func<string>> postcode, Expression<Func<string>> iSO2, Expression<Func<string>> title = null, Expression<Func<string>> firstName = null, Expression<Func<string>> line1 = null, Expression<Func<string>> line2 = null, Expression<Func<string>> line3 = null, Expression<Func<string>> town = null, Expression<Func<string>> county = null)
        {
            var __workflow_provider = provider == null ? null : WorkflowExpression.Compile(provider);
            WorkflowExpression.Validate(__workflow_provider, nameof(provider), required: true);
            var __workflow_lastName = lastName == null ? null : WorkflowExpression.Compile(lastName);
            WorkflowExpression.Validate(__workflow_lastName, nameof(lastName), required: true);
            var __workflow_postcode = postcode == null ? null : WorkflowExpression.Compile(postcode);
            WorkflowExpression.Validate(__workflow_postcode, nameof(postcode), required: true);
            var __workflow_iSO2 = iSO2 == null ? null : WorkflowExpression.Compile(iSO2);
            WorkflowExpression.Validate(__workflow_iSO2, nameof(iSO2), required: true);
            var __workflow_title = title == null ? null : WorkflowExpression.Compile(title);
            WorkflowExpression.Validate(__workflow_title, nameof(title), required: false);
            var __workflow_firstName = firstName == null ? null : WorkflowExpression.Compile(firstName);
            WorkflowExpression.Validate(__workflow_firstName, nameof(firstName), required: false);
            var __workflow_line1 = line1 == null ? null : WorkflowExpression.Compile(line1);
            WorkflowExpression.Validate(__workflow_line1, nameof(line1), required: false);
            var __workflow_line2 = line2 == null ? null : WorkflowExpression.Compile(line2);
            WorkflowExpression.Validate(__workflow_line2, nameof(line2), required: false);
            var __workflow_line3 = line3 == null ? null : WorkflowExpression.Compile(line3);
            WorkflowExpression.Validate(__workflow_line3, nameof(line3), required: false);
            var __workflow_town = town == null ? null : WorkflowExpression.Compile(town);
            WorkflowExpression.Validate(__workflow_town, nameof(town), required: false);
            var __workflow_county = county == null ? null : WorkflowExpression.Compile(county);
            WorkflowExpression.Validate(__workflow_county, nameof(county), required: false);
            return new DeferredBodyAction<SuppressGoneAwayResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Suppress/Address/GoneAway/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_title != null)
                    callPayload.Queries["Title"] = ExpressionConverter.Convert(__workflow_title);
                if (__workflow_firstName != null)
                    callPayload.Queries["FirstName"] = ExpressionConverter.Convert(__workflow_firstName);
                callPayload.Queries["LastName"] = ExpressionConverter.Convert(__workflow_lastName);
                if (__workflow_line1 != null)
                    callPayload.Queries["Line1"] = ExpressionConverter.Convert(__workflow_line1);
                if (__workflow_line2 != null)
                    callPayload.Queries["Line2"] = ExpressionConverter.Convert(__workflow_line2);
                if (__workflow_line3 != null)
                    callPayload.Queries["Line3"] = ExpressionConverter.Convert(__workflow_line3);
                if (__workflow_town != null)
                    callPayload.Queries["Town"] = ExpressionConverter.Convert(__workflow_town);
                if (__workflow_county != null)
                    callPayload.Queries["County"] = ExpressionConverter.Convert(__workflow_county);
                callPayload.Queries["Postcode"] = ExpressionConverter.Convert(__workflow_postcode);
                callPayload.Queries["ISO2"] = ExpressionConverter.Convert(__workflow_iSO2);
                return new ApiConnectionAction<SuppressGoneAwayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SuppressRelocatedResponse> SuppressRelocated(Expression<Func<providerInput>> provider, Expression<Func<string>> lastName, Expression<Func<string>> postcode, Expression<Func<string>> iSO2, Expression<Func<string>> title = null, Expression<Func<string>> firstName = null, Expression<Func<string>> line1 = null, Expression<Func<string>> line2 = null, Expression<Func<string>> line3 = null, Expression<Func<string>> town = null, Expression<Func<string>> county = null)
        {
            var __workflow_provider = provider == null ? null : WorkflowExpression.Compile(provider);
            WorkflowExpression.Validate(__workflow_provider, nameof(provider), required: true);
            var __workflow_lastName = lastName == null ? null : WorkflowExpression.Compile(lastName);
            WorkflowExpression.Validate(__workflow_lastName, nameof(lastName), required: true);
            var __workflow_postcode = postcode == null ? null : WorkflowExpression.Compile(postcode);
            WorkflowExpression.Validate(__workflow_postcode, nameof(postcode), required: true);
            var __workflow_iSO2 = iSO2 == null ? null : WorkflowExpression.Compile(iSO2);
            WorkflowExpression.Validate(__workflow_iSO2, nameof(iSO2), required: true);
            var __workflow_title = title == null ? null : WorkflowExpression.Compile(title);
            WorkflowExpression.Validate(__workflow_title, nameof(title), required: false);
            var __workflow_firstName = firstName == null ? null : WorkflowExpression.Compile(firstName);
            WorkflowExpression.Validate(__workflow_firstName, nameof(firstName), required: false);
            var __workflow_line1 = line1 == null ? null : WorkflowExpression.Compile(line1);
            WorkflowExpression.Validate(__workflow_line1, nameof(line1), required: false);
            var __workflow_line2 = line2 == null ? null : WorkflowExpression.Compile(line2);
            WorkflowExpression.Validate(__workflow_line2, nameof(line2), required: false);
            var __workflow_line3 = line3 == null ? null : WorkflowExpression.Compile(line3);
            WorkflowExpression.Validate(__workflow_line3, nameof(line3), required: false);
            var __workflow_town = town == null ? null : WorkflowExpression.Compile(town);
            WorkflowExpression.Validate(__workflow_town, nameof(town), required: false);
            var __workflow_county = county == null ? null : WorkflowExpression.Compile(county);
            WorkflowExpression.Validate(__workflow_county, nameof(county), required: false);
            return new DeferredBodyAction<SuppressRelocatedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Suppress/Address/Relocated/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_title != null)
                    callPayload.Queries["Title"] = ExpressionConverter.Convert(__workflow_title);
                if (__workflow_firstName != null)
                    callPayload.Queries["FirstName"] = ExpressionConverter.Convert(__workflow_firstName);
                callPayload.Queries["LastName"] = ExpressionConverter.Convert(__workflow_lastName);
                if (__workflow_line1 != null)
                    callPayload.Queries["Line1"] = ExpressionConverter.Convert(__workflow_line1);
                if (__workflow_line2 != null)
                    callPayload.Queries["Line2"] = ExpressionConverter.Convert(__workflow_line2);
                if (__workflow_line3 != null)
                    callPayload.Queries["Line3"] = ExpressionConverter.Convert(__workflow_line3);
                if (__workflow_town != null)
                    callPayload.Queries["Town"] = ExpressionConverter.Convert(__workflow_town);
                if (__workflow_county != null)
                    callPayload.Queries["County"] = ExpressionConverter.Convert(__workflow_county);
                callPayload.Queries["Postcode"] = ExpressionConverter.Convert(__workflow_postcode);
                callPayload.Queries["ISO2"] = ExpressionConverter.Convert(__workflow_iSO2);
                return new ApiConnectionAction<SuppressRelocatedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SuppressPhonePersonalResponse> SuppressPhonePersonal(Expression<Func<providerInput>> provider, Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_provider = provider == null ? null : WorkflowExpression.Compile(provider);
            WorkflowExpression.Validate(__workflow_provider, nameof(provider), required: true);
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_countryIdentifier = countryIdentifier == null ? null : WorkflowExpression.Compile(countryIdentifier);
            WorkflowExpression.Validate(__workflow_countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<SuppressPhonePersonalResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Suppress/Phone/Personal/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                return new ApiConnectionAction<SuppressPhonePersonalResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SuppressPhoneCorporateResponse> SuppressPhoneCorporate(Expression<Func<providerInput>> provider, Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_provider = provider == null ? null : WorkflowExpression.Compile(provider);
            WorkflowExpression.Validate(__workflow_provider, nameof(provider), required: true);
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_countryIdentifier = countryIdentifier == null ? null : WorkflowExpression.Compile(countryIdentifier);
            WorkflowExpression.Validate(__workflow_countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<SuppressPhoneCorporateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Suppress/Phone/Corporate/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                return new ApiConnectionAction<SuppressPhoneCorporateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<AuthenticateEmailGetResponse> AuthenticateEmailGet(Expression<Func<providerInput>> provider, Expression<Func<string>> email)
        {
            var __workflow_provider = provider == null ? null : WorkflowExpression.Compile(provider);
            WorkflowExpression.Validate(__workflow_provider, nameof(provider), required: true);
            var __workflow_email = email == null ? null : WorkflowExpression.Compile(email);
            WorkflowExpression.Validate(__workflow_email, nameof(email), required: true);
            return new DeferredBodyAction<AuthenticateEmailGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Authenticate/Email/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Email"] = ExpressionConverter.Convert(__workflow_email);
                return new ApiConnectionAction<AuthenticateEmailGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<AuthenticatePhoneGetResponse> AuthenticatePhoneGet(Expression<Func<providerInput>> provider, Expression<Func<string>> phone, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_provider = provider == null ? null : WorkflowExpression.Compile(provider);
            WorkflowExpression.Validate(__workflow_provider, nameof(provider), required: true);
            var __workflow_phone = phone == null ? null : WorkflowExpression.Compile(phone);
            WorkflowExpression.Validate(__workflow_phone, nameof(phone), required: true);
            var __workflow_countryIdentifier = countryIdentifier == null ? null : WorkflowExpression.Compile(countryIdentifier);
            WorkflowExpression.Validate(__workflow_countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<AuthenticatePhoneGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Authenticate/Phone/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Phone"] = ExpressionConverter.Convert(__workflow_phone);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                return new ApiConnectionAction<AuthenticatePhoneGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsAllUpper(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/IsAllUpper";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsAllLower(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/IsAllLower";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsMixedCase(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/IsMixedCase";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsAlphaNumeric(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/IsAlphaNumeric";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsNumeric(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/IsNumeric";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsISO4217(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/IsISO4217CurrencyCode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsISO2(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/IsISO2Code";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsISO3(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/IsISO3Code";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtRemoveLeading(Expression<Func<string>> input, Expression<Func<string>> valToRemove, Expression<Func<bool>> leaveOneAtStart)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_valToRemove = valToRemove == null ? null : WorkflowExpression.Compile(valToRemove);
            WorkflowExpression.Validate(__workflow_valToRemove, nameof(valToRemove), required: true);
            var __workflow_leaveOneAtStart = leaveOneAtStart == null ? null : WorkflowExpression.Compile(leaveOneAtStart);
            WorkflowExpression.Validate(__workflow_leaveOneAtStart, nameof(leaveOneAtStart), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/RemoveLeading";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["ValToRemove"] = ExpressionConverter.Convert(__workflow_valToRemove);
                callPayload.Queries["LeaveOneAtStart"] = ExpressionConverter.Convert(__workflow_leaveOneAtStart);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtRemoveChars(Expression<Func<string>> input, Expression<Func<characterTypeInput>> characterType)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_characterType = characterType == null ? null : WorkflowExpression.Compile(characterType);
            WorkflowExpression.Validate(__workflow_characterType, nameof(characterType), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/RemoveCharacters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["characterType"] = ExpressionConverter.Convert(__workflow_characterType);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtRemoveSingleWords(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/RemoveSingleCharacterWords";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtReplaceRepeatingText(Expression<Func<string>> input, Expression<Func<string>> repeatingValue, Expression<Func<string>> replacement)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_repeatingValue = repeatingValue == null ? null : WorkflowExpression.Compile(repeatingValue);
            WorkflowExpression.Validate(__workflow_repeatingValue, nameof(repeatingValue), required: true);
            var __workflow_replacement = replacement == null ? null : WorkflowExpression.Compile(replacement);
            WorkflowExpression.Validate(__workflow_replacement, nameof(replacement), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/ReplaceAdjacentRepeatingText";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["RepeatingValue"] = ExpressionConverter.Convert(__workflow_repeatingValue);
                callPayload.Queries["Replacement"] = ExpressionConverter.Convert(__workflow_replacement);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtReplaceEndsWith(Expression<Func<string>> input, Expression<Func<string>> stringToReplace, Expression<Func<string>> replacement)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_stringToReplace = stringToReplace == null ? null : WorkflowExpression.Compile(stringToReplace);
            WorkflowExpression.Validate(__workflow_stringToReplace, nameof(stringToReplace), required: true);
            var __workflow_replacement = replacement == null ? null : WorkflowExpression.Compile(replacement);
            WorkflowExpression.Validate(__workflow_replacement, nameof(replacement), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/ReplaceIfEndsWith";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["stringToReplace"] = ExpressionConverter.Convert(__workflow_stringToReplace);
                callPayload.Queries["replacement"] = ExpressionConverter.Convert(__workflow_replacement);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtReplaceStartsWith(Expression<Func<string>> input, Expression<Func<string>> stringToReplace, Expression<Func<string>> replacement)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_stringToReplace = stringToReplace == null ? null : WorkflowExpression.Compile(stringToReplace);
            WorkflowExpression.Validate(__workflow_stringToReplace, nameof(stringToReplace), required: true);
            var __workflow_replacement = replacement == null ? null : WorkflowExpression.Compile(replacement);
            WorkflowExpression.Validate(__workflow_replacement, nameof(replacement), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/ReplaceIfStartsWith";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["stringToReplace"] = ExpressionConverter.Convert(__workflow_stringToReplace);
                callPayload.Queries["replacement"] = ExpressionConverter.Convert(__workflow_replacement);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtStringToBinary(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/StringToBinary";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtBinaryToString(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/BinaryToString";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtStringToHex(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/StringToHex";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtHexToString(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/HexToString";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtReverse(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/Reverse";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtNormWhiteSpace(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/NormalizeWhiteSpace";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtNormPhone(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/NormalizeAlphaNumericPhone";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtCollapseRepeatedChars(Expression<Func<string>> input, Expression<Func<bool>> collapseNumerics, Expression<Func<int>> maximumRepeat = null)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_collapseNumerics = collapseNumerics == null ? null : WorkflowExpression.Compile(collapseNumerics);
            WorkflowExpression.Validate(__workflow_collapseNumerics, nameof(collapseNumerics), required: true);
            var __workflow_maximumRepeat = maximumRepeat == null ? null : WorkflowExpression.Compile(maximumRepeat);
            WorkflowExpression.Validate(__workflow_maximumRepeat, nameof(maximumRepeat), required: false);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/CollapseAdjacentRepeatedCharacters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["collapseNumerics"] = ExpressionConverter.Convert(__workflow_collapseNumerics);
                if (__workflow_maximumRepeat != null)
                    callPayload.Queries["maximumRepeat"] = ExpressionConverter.Convert(__workflow_maximumRepeat);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtCollapseRepeatedType(Expression<Func<string>> input, Expression<Func<int>> maximumRepeat, Expression<Func<typeInput>> type)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_maximumRepeat = maximumRepeat == null ? null : WorkflowExpression.Compile(maximumRepeat);
            WorkflowExpression.Validate(__workflow_maximumRepeat, nameof(maximumRepeat), required: true);
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/CollapseAdjacentRepeatedType";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["MaximumRepeat"] = ExpressionConverter.Convert(__workflow_maximumRepeat);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtRemoveStopWords(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/FilterStopWords";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtRetainChars(Expression<Func<string>> input, Expression<Func<string>> replacement, Expression<Func<string>> charactersToRetain)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_replacement = replacement == null ? null : WorkflowExpression.Compile(replacement);
            WorkflowExpression.Validate(__workflow_replacement, nameof(replacement), required: true);
            var __workflow_charactersToRetain = charactersToRetain == null ? null : WorkflowExpression.Compile(charactersToRetain);
            WorkflowExpression.Validate(__workflow_charactersToRetain, nameof(charactersToRetain), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/RetainCharacters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["replacement"] = ExpressionConverter.Convert(__workflow_replacement);
                callPayload.Queries["charactersToRetain"] = ExpressionConverter.Convert(__workflow_charactersToRetain);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtExtractChars(Expression<Func<string>> input, Expression<Func<int>> extractLength, Expression<Func<extractFromInput>> extractFrom)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_extractLength = extractLength == null ? null : WorkflowExpression.Compile(extractLength);
            WorkflowExpression.Validate(__workflow_extractLength, nameof(extractLength), required: true);
            var __workflow_extractFrom = extractFrom == null ? null : WorkflowExpression.Compile(extractFrom);
            WorkflowExpression.Validate(__workflow_extractFrom, nameof(extractFrom), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/ExtractCharacters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["extractLength"] = ExpressionConverter.Convert(__workflow_extractLength);
                callPayload.Queries["extractFrom"] = ExpressionConverter.Convert(__workflow_extractFrom);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtExtractWords(Expression<Func<string>> input, Expression<Func<int>> extractLength, Expression<Func<extractFromInput>> extractFrom)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_extractLength = extractLength == null ? null : WorkflowExpression.Compile(extractLength);
            WorkflowExpression.Validate(__workflow_extractLength, nameof(extractLength), required: true);
            var __workflow_extractFrom = extractFrom == null ? null : WorkflowExpression.Compile(extractFrom);
            WorkflowExpression.Validate(__workflow_extractFrom, nameof(extractFrom), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/ExtractWords";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["extractLength"] = ExpressionConverter.Convert(__workflow_extractLength);
                callPayload.Queries["extractFrom"] = ExpressionConverter.Convert(__workflow_extractFrom);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtRemoveHTML(Expression<Func<string>> input)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/RemoveHTML";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtEndsWith(Expression<Func<string>> input, Expression<Func<string>> checkfor)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_checkfor = checkfor == null ? null : WorkflowExpression.Compile(checkfor);
            WorkflowExpression.Validate(__workflow_checkfor, nameof(checkfor), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/EndsWith";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["checkfor"] = ExpressionConverter.Convert(__workflow_checkfor);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtStartsWith(Expression<Func<string>> input, Expression<Func<string>> checkfor)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_checkfor = checkfor == null ? null : WorkflowExpression.Compile(checkfor);
            WorkflowExpression.Validate(__workflow_checkfor, nameof(checkfor), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/StartsWith";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["checkfor"] = ExpressionConverter.Convert(__workflow_checkfor);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtEnsureEndsWith(Expression<Func<string>> input, Expression<Func<string>> checkFor)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_checkFor = checkFor == null ? null : WorkflowExpression.Compile(checkFor);
            WorkflowExpression.Validate(__workflow_checkFor, nameof(checkFor), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/EnsureEndsWith";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["checkFor"] = ExpressionConverter.Convert(__workflow_checkFor);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtEnsureStartEndsWith(Expression<Func<string>> input, Expression<Func<string>> checkFor)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_checkFor = checkFor == null ? null : WorkflowExpression.Compile(checkFor);
            WorkflowExpression.Validate(__workflow_checkFor, nameof(checkFor), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/EnsureStartsAndEndsWith";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["checkFor"] = ExpressionConverter.Convert(__workflow_checkFor);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtEnsureStartsWith(Expression<Func<string>> input, Expression<Func<string>> checkFor)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_checkFor = checkFor == null ? null : WorkflowExpression.Compile(checkFor);
            WorkflowExpression.Validate(__workflow_checkFor, nameof(checkFor), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/EnsureStartsWith";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["checkFor"] = ExpressionConverter.Convert(__workflow_checkFor);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtStartWithType(Expression<Func<string>> input, Expression<Func<typeInput>> type)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/StartsWithType";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtEndsWithType(Expression<Func<string>> input, Expression<Func<typeInput>> type)
        {
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/EndsWithType";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerateLetterSettingsExcludeTypeItem
    {
        Vowels,
        Consonants
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerateNumberSettingsExcludeTypeItem
    {
        Odd,
        Even
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParseURLGetResponseDataTypeHostNameTypeType
    {
        Unknown,
        Basic,
        Dns,
        IPv4,
        IPv6
    }

    public class ScoringResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ScoringResponseDataTypeItem[] Data { get; set; }
    }

    public class ScoringResponseDataTypeItem
    {
        [JsonProperty("datumRecordSource")]
        public string DatumRecordSource { get; set; }

        [JsonProperty("datumUniqueId")]
        public string DatumUniqueId { get; set; }

        [JsonProperty("secondaryRecordSource")]
        public string SecondaryRecordSource { get; set; }

        [JsonProperty("secondaryUniqueId")]
        public string SecondaryUniqueId { get; set; }

        [JsonProperty("percentageScore")]
        public double PercentageScore { get; set; }

        [JsonProperty("groupOutput")]
        public ScoringResponseDataTypeItemGroupOutputTypeItem[] GroupOutput { get; set; }
    }

    public class ScoringResponseDataTypeItemGroupOutputTypeItem
    {
        [JsonProperty("groupFieldID")]
        public string GroupFieldID { get; set; }

        [JsonProperty("groupPercentageScore")]
        public double GroupPercentageScore { get; set; }

        [JsonProperty("warnings")]
        public string[] Warnings { get; set; }
    }

    public class inputInputItem2
    {
        public bool IsDatum { get; set; }

        [JsonProperty("UniqueId")]
        public string RecordId { get; set; }
        public string RecordSource { get; set; }
        public inputInputItemGroupFieldsTypeItem[] GroupFields { get; set; }
    }

    public class inputInputItemGroupFieldsTypeItem
    {
        [JsonProperty("GroupFieldId")]
        public string GroupName { get; set; }
        public inputInputItemGroupFieldsTypeItemSettingsType Settings { get; set; }
        public inputInputItemGroupFieldsTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class inputInputItemGroupFieldsTypeItemSettingsType
    {
        public inputInputItemGroupFieldsTypeItemSettingsTypeScoringTypeType ScoringType { get; set; }

        [JsonProperty("ScoreMethod")]
        public inputInputItemGroupFieldsTypeItemSettingsTypeScoringMethodType ScoringMethod { get; set; }
        public inputInputItemGroupFieldsTypeItemSettingsTypeComparisonAlgorithmType ComparisonAlgorithm { get; set; }

        [JsonProperty("IsNullToNullScored")]
        public bool NullVsNullMatch { get; set; }

        [JsonProperty("IsNullToValueScored")]
        public bool NullVsValueMatch { get; set; }

        [JsonProperty("IsCaseSensitiveScore")]
        public bool CaseSensitive { get; set; }

        [JsonProperty("AlphaSequenceParameter")]
        public inputInputItemGroupFieldsTypeItemSettingsTypeAlphaSequenceType AlphaSequence { get; set; }

        [JsonProperty("IsReplaceDoubleSpaceWithSingle")]
        public bool ReplaceDoubleSpaceWithSingleSpace { get; set; }

        [JsonProperty("IsRemoveAllWhiteSpaces")]
        public bool RemoveAllWhitespace { get; set; }

        [JsonProperty("IsTrimString")]
        public bool TrimString { get; set; }

        [JsonProperty("IsIncludePunctuation")]
        public bool IncludePunctuation { get; set; }

        [JsonProperty("IsIncludeSymbols")]
        public bool IncludeSymbols { get; set; }

        [JsonProperty("IsIncludeNonPrinting")]
        public bool IncludeNonPrinting { get; set; }

        [JsonProperty("IsIncludeNumbers")]
        public bool IncludeNumbers { get; set; }

        [JsonProperty("IsIncludeAlphaChars")]
        public bool IncludeLetters { get; set; }

        [JsonProperty("IsWeightingFactorUsed")]
        public bool ApplyWeighting { get; set; }

        [JsonProperty("IsIncludeOriginalDataForScoring")]
        public bool IncludePreTransformedDataForScoring { get; set; }
        public bool IncludeTokenForScoring { get; set; }

        [JsonProperty("IncludeTransformedDataForScoring")]
        public bool IncludeTransformsDataForScoring { get; set; }

        [JsonProperty("AutoPopulateEmptyTransformed")]
        public bool AutoPopulateTransformedValueWhenEmpty { get; set; }

        [JsonProperty("AutoPopulateEmptyToken")]
        public bool AutoPopulateTokenWhenEmpty { get; set; }

        [JsonProperty("Weighting")]
        public int GroupWeighting { get; set; }
        public int PostalCodeNChars { get; set; }
        public int PositiveValidRange { get; set; }
        public int NegativeValidRange { get; set; }
        public inputInputItemGroupFieldsTypeItemSettingsTypeDateFormatType DateFormat { get; set; }
        public inputInputItemGroupFieldsTypeItemSettingsTypeInterScoreSettingsType InterScoreSettings { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputInputItemGroupFieldsTypeItemSettingsTypeScoringTypeType
    {
        InterScore,
        IntraScore
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputInputItemGroupFieldsTypeItemSettingsTypeScoringMethodType
    {
        EditDistanceScore,
        ExactMatch,
        EmailScore,
        EmailScoreAsPerDomain,
        EmailScoreAsPerUserName,
        PostalCodeWholeInput,
        PostalCodeLeftN,
        PostalCodeRightN,
        PostalCodeAsZip,
        PostalCodeAsZip4,
        AddressLine1PremiseBinary,
        AddressLine1PremiseProportional,
        AddressLine1Street,
        AddressLine1WholeInput,
        DateBinary,
        DateProportional
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputInputItemGroupFieldsTypeItemSettingsTypeComparisonAlgorithmType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputInputItemGroupFieldsTypeItemSettingsTypeAlphaSequenceType
    {
        AscCharacters,
        DescCharacters,
        AscWords,
        DescWords,
        None
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputInputItemGroupFieldsTypeItemSettingsTypeDateFormatType
    {
        DDMMYYYY,
        MMDDYYYY
    }

    public class inputInputItemGroupFieldsTypeItemSettingsTypeInterScoreSettingsType
    {
        [JsonProperty("InterScoreMethodType")]
        public inputInputItemGroupFieldsTypeItemSettingsTypeInterScoreSettingsTypeScoringMethodType ScoringMethod { get; set; }

        [JsonProperty("ThresholdValue")]
        public int Threshold { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputInputItemGroupFieldsTypeItemSettingsTypeInterScoreSettingsTypeScoringMethodType
    {
        AnyMatch,
        AllMatch
    }

    public class inputInputItemGroupFieldsTypeItemValuesTypeItem
    {
        public string Value { get; set; }
        public string TransformedValue { get; set; }

        [JsonProperty("Token")]
        public string TokenValue { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class inputInputItem22
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputInputItemSettingsTypeItemActionType
    {
        Elaborate,
        Abbreviate,
        Normalize,
        Exclude,
        Transliterate
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum VerifyAddressGetResponseDataTypeStatusType
    {
        VERIFIED,
        SUSPECT,
        UNVERIFIED
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AuthenticatePhoneGetResponseDataTypeNumberTypeType
    {
        Mobile,
        Landline,
        VOIP,
        Unknown
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
