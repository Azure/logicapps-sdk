//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dqondemand
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DqondemandActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildUsageGet))]
        public IBodyWorkflowAction<GetUsage> UsageGet([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetUsage> __BuildUsageGet(WorkflowValue<string> startDate, WorkflowValue<string> endDate)
        {
            WorkflowValue.Validate(startDate, nameof(startDate), required: true);
            WorkflowValue.Validate(endDate, nameof(endDate), required: true);
            return new DeferredBodyAction<GetUsage>(() =>
            {
                var apiCallPath = "/Account/Usage";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["StartDate"] = ExpressionConverter.Convert(startDate);
                callPayload.Queries["EndDate"] = ExpressionConverter.Convert(endDate);
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
        [WorkflowExpressionFactory(nameof(__BuildCaseSingular))]
        public IBodyWorkflowAction<DQGlobal> CaseSingular([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<caseTypeInput> caseType, [WorkflowExpression] Func<languageInput> language)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildCaseSingular(WorkflowValue<string> input, WorkflowValue<caseTypeInput> caseType, WorkflowValue<languageInput> language)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(caseType, nameof(caseType), required: true);
            WorkflowValue.Validate(language, nameof(language), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/Case";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["CaseType"] = ExpressionConverter.Convert(caseType);
                callPayload.Queries["Language"] = ExpressionConverter.Convert(language);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildClassifyGet))]
        public IBodyWorkflowAction<ClassifyGetResponse> ClassifyGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<categoriesInput> categories, [WorkflowExpression] Func<languageInput> language = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ClassifyGetResponse> __BuildClassifyGet(WorkflowValue<string> input, WorkflowValue<categoriesInput> categories, WorkflowValue<languageInput> language = null)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(categories, nameof(categories), required: true);
            WorkflowValue.Validate(language, nameof(language), required: false);
            return new DeferredBodyAction<ClassifyGetResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildCompareGet))]
        public IBodyWorkflowAction<DQGlobalFloat> CompareGet([WorkflowExpression] Func<string> input1, [WorkflowExpression] Func<string> input2, [WorkflowExpression] Func<comparisonAlgorithmInput> comparisonAlgorithm)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobalFloat> __BuildCompareGet(WorkflowValue<string> input1, WorkflowValue<string> input2, WorkflowValue<comparisonAlgorithmInput> comparisonAlgorithm)
        {
            WorkflowValue.Validate(input1, nameof(input1), required: true);
            WorkflowValue.Validate(input2, nameof(input2), required: true);
            WorkflowValue.Validate(comparisonAlgorithm, nameof(comparisonAlgorithm), required: true);
            return new DeferredBodyAction<DQGlobalFloat>(() =>
            {
                var apiCallPath = "/Compare";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input1"] = ExpressionConverter.Convert(input1);
                callPayload.Queries["Input2"] = ExpressionConverter.Convert(input2);
                callPayload.Queries["ComparisonAlgorithm"] = ExpressionConverter.Convert(comparisonAlgorithm);
                return new ApiConnectionAction<DQGlobalFloat>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildEmailCongruenceGet))]
        public IBodyWorkflowAction<CongruenceResultSingle> EmailCongruenceGet([WorkflowExpression] Func<string> email, [WorkflowExpression] Func<string> firstName, [WorkflowExpression] Func<string> lastName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CongruenceResultSingle> __BuildEmailCongruenceGet(WorkflowValue<string> email, WorkflowValue<string> firstName, WorkflowValue<string> lastName)
        {
            WorkflowValue.Validate(email, nameof(email), required: true);
            WorkflowValue.Validate(firstName, nameof(firstName), required: true);
            WorkflowValue.Validate(lastName, nameof(lastName), required: true);
            return new DeferredBodyAction<CongruenceResultSingle>(() =>
            {
                var apiCallPath = "/Congruence/Email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Email"] = ExpressionConverter.Convert(email);
                callPayload.Queries["FirstName"] = ExpressionConverter.Convert(firstName);
                callPayload.Queries["LastName"] = ExpressionConverter.Convert(lastName);
                return new ApiConnectionAction<CongruenceResultSingle>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildCountryCongruenceGet))]
        public IBodyWorkflowAction<CongruenceResultSingle> CountryCongruenceGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> country, [WorkflowExpression] Func<actionTypeInput> actionType)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CongruenceResultSingle> __BuildCountryCongruenceGet(WorkflowValue<string> input, WorkflowValue<string> country, WorkflowValue<actionTypeInput> actionType)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(country, nameof(country), required: true);
            WorkflowValue.Validate(actionType, nameof(actionType), required: true);
            return new DeferredBodyAction<CongruenceResultSingle>(() =>
            {
                var apiCallPath = "/Congruence/Country";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["Country"] = ExpressionConverter.Convert(country);
                callPayload.Queries["ActionType"] = ExpressionConverter.Convert(actionType);
                return new ApiConnectionAction<CongruenceResultSingle>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildSalutationCongruenceGet))]
        public IBodyWorkflowAction<CongruenceResultSingle> SalutationCongruenceGet([WorkflowExpression] Func<string> salutation, [WorkflowExpression] Func<string> firstName, [WorkflowExpression] Func<languageInput> language)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CongruenceResultSingle> __BuildSalutationCongruenceGet(WorkflowValue<string> salutation, WorkflowValue<string> firstName, WorkflowValue<languageInput> language)
        {
            WorkflowValue.Validate(salutation, nameof(salutation), required: true);
            WorkflowValue.Validate(firstName, nameof(firstName), required: true);
            WorkflowValue.Validate(language, nameof(language), required: true);
            return new DeferredBodyAction<CongruenceResultSingle>(() =>
            {
                var apiCallPath = "/Congruence/Salutation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Salutation"] = ExpressionConverter.Convert(salutation);
                callPayload.Queries["FirstName"] = ExpressionConverter.Convert(firstName);
                callPayload.Queries["Language"] = ExpressionConverter.Convert(language);
                return new ApiConnectionAction<CongruenceResultSingle>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildDeriveGenderGet))]
        public IBodyWorkflowAction<DeriveGenderGetResponse> DeriveGenderGet([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeriveGenderGetResponse> __BuildDeriveGenderGet(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DeriveGenderGetResponse>(() =>
            {
                var apiCallPath = "/Derive/Gender";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DeriveGenderGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildDeriveCityGet))]
        public IBodyWorkflowAction<DeriveCityGetResponse> DeriveCityGet([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeriveCityGetResponse> __BuildDeriveCityGet(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DeriveCityGetResponse>(() =>
            {
                var apiCallPath = "/Derive/CountryFromCity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DeriveCityGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildDerivePostCodeGet))]
        public IBodyWorkflowAction<DerivePostCodeGetResponse> DerivePostCodeGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DerivePostCodeGetResponse> __BuildDerivePostCodeGet(WorkflowValue<string> input, WorkflowValue<string> countryIdentifier)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DerivePostCodeGetResponse>(() =>
            {
                var apiCallPath = "/Derive/FromPostalCode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
                return new ApiConnectionAction<DerivePostCodeGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildDeriveEmailGet))]
        public IBodyWorkflowAction<DeriveEmailGetResponse> DeriveEmailGet([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeriveEmailGetResponse> __BuildDeriveEmailGet(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DeriveEmailGetResponse>(() =>
            {
                var apiCallPath = "/Derive/EmailType";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DeriveEmailGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildDeriveISOGet))]
        public IBodyWorkflowAction<DeriveISOGetResponse> DeriveISOGet([WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> url = null, [WorkflowExpression] Func<string> phone = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<int> threshold = null, [WorkflowExpression] Func<bool> onlyReturnBest = null, [WorkflowExpression] Func<bool> defaultToCountry = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeriveISOGetResponse> __BuildDeriveISOGet(WorkflowValue<string> email = null, WorkflowValue<string> url = null, WorkflowValue<string> phone = null, WorkflowValue<string> country = null, WorkflowValue<string> city = null, WorkflowValue<int> threshold = null, WorkflowValue<bool> onlyReturnBest = null, WorkflowValue<bool> defaultToCountry = null)
        {
            WorkflowValue.Validate(email, nameof(email), required: false);
            WorkflowValue.Validate(url, nameof(url), required: false);
            WorkflowValue.Validate(phone, nameof(phone), required: false);
            WorkflowValue.Validate(country, nameof(country), required: false);
            WorkflowValue.Validate(city, nameof(city), required: false);
            WorkflowValue.Validate(threshold, nameof(threshold), required: false);
            WorkflowValue.Validate(onlyReturnBest, nameof(onlyReturnBest), required: false);
            WorkflowValue.Validate(defaultToCountry, nameof(defaultToCountry), required: false);
            return new DeferredBodyAction<DeriveISOGetResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildFormatEmailGet))]
        public IBodyWorkflowAction<DQGlobal> FormatEmailGet([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildFormatEmailGet(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/Format/Email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildFormatPostCodeGet))]
        public IBodyWorkflowAction<DQGlobal> FormatPostCodeGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildFormatPostCodeGet(WorkflowValue<string> input, WorkflowValue<string> countryIdentifier)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/Format/PostCode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildFormatE164Get))]
        public IBodyWorkflowAction<DQGlobal> FormatE164Get([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildFormatE164Get(WorkflowValue<string> input, WorkflowValue<string> countryIdentifier)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/Format/TelephoneE164";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildFormatInternationalGet))]
        public IBodyWorkflowAction<DQGlobal> FormatInternationalGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildFormatInternationalGet(WorkflowValue<string> input, WorkflowValue<string> countryIdentifier)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/Format/TelephoneInternational";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildFormatNationalGet))]
        public IBodyWorkflowAction<DQGlobal> FormatNationalGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildFormatNationalGet(WorkflowValue<string> input, WorkflowValue<string> countryIdentifier)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/Format/TelephoneNational";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildFormatRFC3966Get))]
        public IBodyWorkflowAction<DQGlobal> FormatRFC3966Get([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildFormatRFC3966Get(WorkflowValue<string> input, WorkflowValue<string> countryIdentifier)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/Format/TelephoneRFC3966";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildFormatURLGet))]
        public IBodyWorkflowAction<DQGlobal> FormatURLGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> uRLPrefix)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildFormatURLGet(WorkflowValue<string> input, WorkflowValue<string> uRLPrefix)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(uRLPrefix, nameof(uRLPrefix), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/Format/UrlAddress";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["URLPrefix"] = ExpressionConverter.Convert(uRLPrefix);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildGeneratePattern))]
        public IBodyWorkflowAction<GeneratePatternResponse> GeneratePattern([WorkflowExpression] Func<inputInputItem[]> input = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GeneratePatternResponse> __BuildGeneratePattern(WorkflowValue<inputInputItem[]> input = null)
        {
            WorkflowValue.Validate(input, nameof(input), required: false);
            return new DeferredBodyAction<GeneratePatternResponse>(() =>
            {
                var apiCallPath = "/Generate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(input);
                return new ApiConnectionAction<GeneratePatternResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateTokenGet))]
        public IBodyWorkflowAction<DQGlobal> GenerateTokenGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<generateAlgorithmTypeInput> generateAlgorithmType, [WorkflowExpression] Func<languageInput> language = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildGenerateTokenGet(WorkflowValue<string> input, WorkflowValue<generateAlgorithmTypeInput> generateAlgorithmType, WorkflowValue<languageInput> language = null)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(generateAlgorithmType, nameof(generateAlgorithmType), required: true);
            WorkflowValue.Validate(language, nameof(language), required: false);
            return new DeferredBodyAction<DQGlobal>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildParsePhoneGet))]
        public IBodyWorkflowAction<ParsePhoneGetResponse> ParsePhoneGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ParsePhoneGetResponse> __BuildParsePhoneGet(WorkflowValue<string> input, WorkflowValue<string> countryIdentifier)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<ParsePhoneGetResponse>(() =>
            {
                var apiCallPath = "/Parse/PhoneNumber";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
                return new ApiConnectionAction<ParsePhoneGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildParseEmailGet))]
        public IBodyWorkflowAction<ParseEmailGetResponse> ParseEmailGet([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ParseEmailGetResponse> __BuildParseEmailGet(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<ParseEmailGetResponse>(() =>
            {
                var apiCallPath = "/Parse/Email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<ParseEmailGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildParseURLGet))]
        public IBodyWorkflowAction<ParseURLGetResponse> ParseURLGet([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ParseURLGetResponse> __BuildParseURLGet(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<ParseURLGetResponse>(() =>
            {
                var apiCallPath = "/Parse/URL";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<ParseURLGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildScoring))]
        public IBodyWorkflowAction<ScoringResponse> Scoring([WorkflowExpression] Func<inputInputItem2[]> input = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ScoringResponse> __BuildScoring(WorkflowValue<inputInputItem2[]> input = null)
        {
            WorkflowValue.Validate(input, nameof(input), required: false);
            return new DeferredBodyAction<ScoringResponse>(() =>
            {
                var apiCallPath = "/Scoring";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(input);
                return new ApiConnectionAction<ScoringResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildTransformGet))]
        public IBodyWorkflowAction<DQGlobal> TransformGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<entityTypeInput> entityType, [WorkflowExpression] Func<operationTypeInput> operationType, [WorkflowExpression] Func<languageInput> language = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildTransformGet(WorkflowValue<string> input, WorkflowValue<entityTypeInput> entityType, WorkflowValue<operationTypeInput> operationType, WorkflowValue<languageInput> language = null)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(entityType, nameof(entityType), required: true);
            WorkflowValue.Validate(operationType, nameof(operationType), required: true);
            WorkflowValue.Validate(language, nameof(language), required: false);
            return new DeferredBodyAction<DQGlobal>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildSequenceTransform))]
        public IBodyWorkflowAction<SequenceTransformResponse> SequenceTransform([WorkflowExpression] Func<inputInputItem22[]> input = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SequenceTransformResponse> __BuildSequenceTransform(WorkflowValue<inputInputItem22[]> input = null)
        {
            WorkflowValue.Validate(input, nameof(input), required: false);
            return new DeferredBodyAction<SequenceTransformResponse>(() =>
            {
                var apiCallPath = "/SequenceTransform";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(input);
                return new ApiConnectionAction<SequenceTransformResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildValidateEmailGet))]
        public IBodyWorkflowAction<DQGlobalBool> ValidateEmailGet([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobalBool> __BuildValidateEmailGet(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/Validate/Email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildValidatePostCodeGet))]
        public IBodyWorkflowAction<DQGlobalBool> ValidatePostCodeGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobalBool> __BuildValidatePostCodeGet(WorkflowValue<string> input, WorkflowValue<string> countryIdentifier)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/Validate/PostCode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildValidateURLGet))]
        public IBodyWorkflowAction<DQGlobalBool> ValidateURLGet([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobalBool> __BuildValidateURLGet(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/Validate/UrlAddress";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildValidatePhoneGet))]
        public IBodyWorkflowAction<DQGlobalBool> ValidatePhoneGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobalBool> __BuildValidatePhoneGet(WorkflowValue<string> input, WorkflowValue<string> countryIdentifier)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/Validate/Telephone";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildValidateDateTimeGet))]
        public IBodyWorkflowAction<DQGlobalBool> ValidateDateTimeGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> dateTimeFormat)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobalBool> __BuildValidateDateTimeGet(WorkflowValue<string> input, WorkflowValue<string> dateTimeFormat)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(dateTimeFormat, nameof(dateTimeFormat), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/Validate/DateTime";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["DateTimeFormat"] = ExpressionConverter.Convert(dateTimeFormat);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildValidatePlusEmailGet))]
        public IBodyWorkflowAction<ValidatePlusEmailGetResponse> ValidatePlusEmailGet([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidatePlusEmailGetResponse> __BuildValidatePlusEmailGet(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<ValidatePlusEmailGetResponse>(() =>
            {
                var apiCallPath = "/ValidatePlus/Email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<ValidatePlusEmailGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildValidatePlusPostCodeGet))]
        public IBodyWorkflowAction<ValidatePlusPostCodeGetResponse> ValidatePlusPostCodeGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidatePlusPostCodeGetResponse> __BuildValidatePlusPostCodeGet(WorkflowValue<string> input, WorkflowValue<string> countryIdentifier)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<ValidatePlusPostCodeGetResponse>(() =>
            {
                var apiCallPath = "/ValidatePlus/PostCode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
                return new ApiConnectionAction<ValidatePlusPostCodeGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildValidatePlusURLGet))]
        public IBodyWorkflowAction<ValidatePlusURLGetResponse> ValidatePlusURLGet([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidatePlusURLGetResponse> __BuildValidatePlusURLGet(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<ValidatePlusURLGetResponse>(() =>
            {
                var apiCallPath = "/ValidatePlus/UrlAddress";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<ValidatePlusURLGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildVerifyAddressGet))]
        public IBodyWorkflowAction<VerifyAddressGetResponse> VerifyAddressGet([WorkflowExpression] Func<providerInput> provider, [WorkflowExpression] Func<string> countryIdentifier, [WorkflowExpression] Func<bool> geocode, [WorkflowExpression] Func<string> line1 = null, [WorkflowExpression] Func<string> line2 = null, [WorkflowExpression] Func<string> line3 = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> state = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VerifyAddressGetResponse> __BuildVerifyAddressGet(WorkflowValue<providerInput> provider, WorkflowValue<string> countryIdentifier, WorkflowValue<bool> geocode, WorkflowValue<string> line1 = null, WorkflowValue<string> line2 = null, WorkflowValue<string> line3 = null, WorkflowValue<string> postalCode = null, WorkflowValue<string> city = null, WorkflowValue<string> state = null)
        {
            WorkflowValue.Validate(provider, nameof(provider), required: true);
            WorkflowValue.Validate(countryIdentifier, nameof(countryIdentifier), required: true);
            WorkflowValue.Validate(geocode, nameof(geocode), required: true);
            WorkflowValue.Validate(line1, nameof(line1), required: false);
            WorkflowValue.Validate(line2, nameof(line2), required: false);
            WorkflowValue.Validate(line3, nameof(line3), required: false);
            WorkflowValue.Validate(postalCode, nameof(postalCode), required: false);
            WorkflowValue.Validate(city, nameof(city), required: false);
            WorkflowValue.Validate(state, nameof(state), required: false);
            return new DeferredBodyAction<VerifyAddressGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Verify/Address/{0}", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildSearchAddressFind))]
        public IBodyWorkflowAction<SearchAddressFindResponse> SearchAddressFind([WorkflowExpression] Func<providerInput> provider, [WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> countryIdentifier)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchAddressFindResponse> __BuildSearchAddressFind(WorkflowValue<providerInput> provider, WorkflowValue<string> query, WorkflowValue<string> countryIdentifier)
        {
            WorkflowValue.Validate(provider, nameof(provider), required: true);
            WorkflowValue.Validate(query, nameof(query), required: true);
            WorkflowValue.Validate(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<SearchAddressFindResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Search/Address/Find/{0}", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
                return new ApiConnectionAction<SearchAddressFindResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildSearchAddressRetrieve))]
        public IBodyWorkflowAction<SearchAddressRetrieveResponse> SearchAddressRetrieve([WorkflowExpression] Func<providerInput> provider, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> countryIdentifier)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchAddressRetrieveResponse> __BuildSearchAddressRetrieve(WorkflowValue<providerInput> provider, WorkflowValue<string> id, WorkflowValue<string> countryIdentifier)
        {
            WorkflowValue.Validate(provider, nameof(provider), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<SearchAddressRetrieveResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Search/Address/Retrieve/{0}", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
                return new ApiConnectionAction<SearchAddressRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildSuppressDeceased))]
        public IBodyWorkflowAction<SuppressDeceasedResponse> SuppressDeceased([WorkflowExpression] Func<providerInput> provider, [WorkflowExpression] Func<string> lastName, [WorkflowExpression] Func<string> postcode, [WorkflowExpression] Func<string> countryIdentifier, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> line1 = null, [WorkflowExpression] Func<string> line2 = null, [WorkflowExpression] Func<string> line3 = null, [WorkflowExpression] Func<string> town = null, [WorkflowExpression] Func<string> county = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SuppressDeceasedResponse> __BuildSuppressDeceased(WorkflowValue<providerInput> provider, WorkflowValue<string> lastName, WorkflowValue<string> postcode, WorkflowValue<string> countryIdentifier, WorkflowValue<string> title = null, WorkflowValue<string> firstName = null, WorkflowValue<string> line1 = null, WorkflowValue<string> line2 = null, WorkflowValue<string> line3 = null, WorkflowValue<string> town = null, WorkflowValue<string> county = null)
        {
            WorkflowValue.Validate(provider, nameof(provider), required: true);
            WorkflowValue.Validate(lastName, nameof(lastName), required: true);
            WorkflowValue.Validate(postcode, nameof(postcode), required: true);
            WorkflowValue.Validate(countryIdentifier, nameof(countryIdentifier), required: true);
            WorkflowValue.Validate(title, nameof(title), required: false);
            WorkflowValue.Validate(firstName, nameof(firstName), required: false);
            WorkflowValue.Validate(line1, nameof(line1), required: false);
            WorkflowValue.Validate(line2, nameof(line2), required: false);
            WorkflowValue.Validate(line3, nameof(line3), required: false);
            WorkflowValue.Validate(town, nameof(town), required: false);
            WorkflowValue.Validate(county, nameof(county), required: false);
            return new DeferredBodyAction<SuppressDeceasedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Suppress/Address/Deceased/{0}", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildSuppressGoneAway))]
        public IBodyWorkflowAction<SuppressGoneAwayResponse> SuppressGoneAway([WorkflowExpression] Func<providerInput> provider, [WorkflowExpression] Func<string> lastName, [WorkflowExpression] Func<string> postcode, [WorkflowExpression] Func<string> iSO2, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> line1 = null, [WorkflowExpression] Func<string> line2 = null, [WorkflowExpression] Func<string> line3 = null, [WorkflowExpression] Func<string> town = null, [WorkflowExpression] Func<string> county = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SuppressGoneAwayResponse> __BuildSuppressGoneAway(WorkflowValue<providerInput> provider, WorkflowValue<string> lastName, WorkflowValue<string> postcode, WorkflowValue<string> iSO2, WorkflowValue<string> title = null, WorkflowValue<string> firstName = null, WorkflowValue<string> line1 = null, WorkflowValue<string> line2 = null, WorkflowValue<string> line3 = null, WorkflowValue<string> town = null, WorkflowValue<string> county = null)
        {
            WorkflowValue.Validate(provider, nameof(provider), required: true);
            WorkflowValue.Validate(lastName, nameof(lastName), required: true);
            WorkflowValue.Validate(postcode, nameof(postcode), required: true);
            WorkflowValue.Validate(iSO2, nameof(iSO2), required: true);
            WorkflowValue.Validate(title, nameof(title), required: false);
            WorkflowValue.Validate(firstName, nameof(firstName), required: false);
            WorkflowValue.Validate(line1, nameof(line1), required: false);
            WorkflowValue.Validate(line2, nameof(line2), required: false);
            WorkflowValue.Validate(line3, nameof(line3), required: false);
            WorkflowValue.Validate(town, nameof(town), required: false);
            WorkflowValue.Validate(county, nameof(county), required: false);
            return new DeferredBodyAction<SuppressGoneAwayResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Suppress/Address/GoneAway/{0}", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildSuppressRelocated))]
        public IBodyWorkflowAction<SuppressRelocatedResponse> SuppressRelocated([WorkflowExpression] Func<providerInput> provider, [WorkflowExpression] Func<string> lastName, [WorkflowExpression] Func<string> postcode, [WorkflowExpression] Func<string> iSO2, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> line1 = null, [WorkflowExpression] Func<string> line2 = null, [WorkflowExpression] Func<string> line3 = null, [WorkflowExpression] Func<string> town = null, [WorkflowExpression] Func<string> county = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SuppressRelocatedResponse> __BuildSuppressRelocated(WorkflowValue<providerInput> provider, WorkflowValue<string> lastName, WorkflowValue<string> postcode, WorkflowValue<string> iSO2, WorkflowValue<string> title = null, WorkflowValue<string> firstName = null, WorkflowValue<string> line1 = null, WorkflowValue<string> line2 = null, WorkflowValue<string> line3 = null, WorkflowValue<string> town = null, WorkflowValue<string> county = null)
        {
            WorkflowValue.Validate(provider, nameof(provider), required: true);
            WorkflowValue.Validate(lastName, nameof(lastName), required: true);
            WorkflowValue.Validate(postcode, nameof(postcode), required: true);
            WorkflowValue.Validate(iSO2, nameof(iSO2), required: true);
            WorkflowValue.Validate(title, nameof(title), required: false);
            WorkflowValue.Validate(firstName, nameof(firstName), required: false);
            WorkflowValue.Validate(line1, nameof(line1), required: false);
            WorkflowValue.Validate(line2, nameof(line2), required: false);
            WorkflowValue.Validate(line3, nameof(line3), required: false);
            WorkflowValue.Validate(town, nameof(town), required: false);
            WorkflowValue.Validate(county, nameof(county), required: false);
            return new DeferredBodyAction<SuppressRelocatedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Suppress/Address/Relocated/{0}", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildSuppressPhonePersonal))]
        public IBodyWorkflowAction<SuppressPhonePersonalResponse> SuppressPhonePersonal([WorkflowExpression] Func<providerInput> provider, [WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SuppressPhonePersonalResponse> __BuildSuppressPhonePersonal(WorkflowValue<providerInput> provider, WorkflowValue<string> input, WorkflowValue<string> countryIdentifier)
        {
            WorkflowValue.Validate(provider, nameof(provider), required: true);
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<SuppressPhonePersonalResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Suppress/Phone/Personal/{0}", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
                return new ApiConnectionAction<SuppressPhonePersonalResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildSuppressPhoneCorporate))]
        public IBodyWorkflowAction<SuppressPhoneCorporateResponse> SuppressPhoneCorporate([WorkflowExpression] Func<providerInput> provider, [WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SuppressPhoneCorporateResponse> __BuildSuppressPhoneCorporate(WorkflowValue<providerInput> provider, WorkflowValue<string> input, WorkflowValue<string> countryIdentifier)
        {
            WorkflowValue.Validate(provider, nameof(provider), required: true);
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<SuppressPhoneCorporateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Suppress/Phone/Corporate/{0}", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
                return new ApiConnectionAction<SuppressPhoneCorporateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildAuthenticateEmailGet))]
        public IBodyWorkflowAction<AuthenticateEmailGetResponse> AuthenticateEmailGet([WorkflowExpression] Func<providerInput> provider, [WorkflowExpression] Func<string> email)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AuthenticateEmailGetResponse> __BuildAuthenticateEmailGet(WorkflowValue<providerInput> provider, WorkflowValue<string> email)
        {
            WorkflowValue.Validate(provider, nameof(provider), required: true);
            WorkflowValue.Validate(email, nameof(email), required: true);
            return new DeferredBodyAction<AuthenticateEmailGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Authenticate/Email/{0}", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Email"] = ExpressionConverter.Convert(email);
                return new ApiConnectionAction<AuthenticateEmailGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildAuthenticatePhoneGet))]
        public IBodyWorkflowAction<AuthenticatePhoneGetResponse> AuthenticatePhoneGet([WorkflowExpression] Func<providerInput> provider, [WorkflowExpression] Func<string> phone, [WorkflowExpression] Func<string> countryIdentifier)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AuthenticatePhoneGetResponse> __BuildAuthenticatePhoneGet(WorkflowValue<providerInput> provider, WorkflowValue<string> phone, WorkflowValue<string> countryIdentifier)
        {
            WorkflowValue.Validate(provider, nameof(provider), required: true);
            WorkflowValue.Validate(phone, nameof(phone), required: true);
            WorkflowValue.Validate(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<AuthenticatePhoneGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Authenticate/Phone/{0}", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Phone"] = ExpressionConverter.Convert(phone);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(countryIdentifier);
                return new ApiConnectionAction<AuthenticatePhoneGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtIsAllUpper))]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsAllUpper([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobalBool> __BuildStringExtIsAllUpper(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/IsAllUpper";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtIsAllLower))]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsAllLower([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobalBool> __BuildStringExtIsAllLower(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/IsAllLower";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtIsMixedCase))]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsMixedCase([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobalBool> __BuildStringExtIsMixedCase(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/IsMixedCase";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtIsAlphaNumeric))]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsAlphaNumeric([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobalBool> __BuildStringExtIsAlphaNumeric(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/IsAlphaNumeric";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtIsNumeric))]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsNumeric([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobalBool> __BuildStringExtIsNumeric(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/IsNumeric";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtIsISO4217))]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsISO4217([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobalBool> __BuildStringExtIsISO4217(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/IsISO4217CurrencyCode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtIsISO2))]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsISO2([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobalBool> __BuildStringExtIsISO2(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/IsISO2Code";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtIsISO3))]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsISO3([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobalBool> __BuildStringExtIsISO3(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/IsISO3Code";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtRemoveLeading))]
        public IBodyWorkflowAction<DQGlobal> StringExtRemoveLeading([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> valToRemove, [WorkflowExpression] Func<bool> leaveOneAtStart)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtRemoveLeading(WorkflowValue<string> input, WorkflowValue<string> valToRemove, WorkflowValue<bool> leaveOneAtStart)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(valToRemove, nameof(valToRemove), required: true);
            WorkflowValue.Validate(leaveOneAtStart, nameof(leaveOneAtStart), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/RemoveLeading";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["ValToRemove"] = ExpressionConverter.Convert(valToRemove);
                callPayload.Queries["LeaveOneAtStart"] = ExpressionConverter.Convert(leaveOneAtStart);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtRemoveChars))]
        public IBodyWorkflowAction<DQGlobal> StringExtRemoveChars([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<characterTypeInput> characterType)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtRemoveChars(WorkflowValue<string> input, WorkflowValue<characterTypeInput> characterType)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(characterType, nameof(characterType), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/RemoveCharacters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["characterType"] = ExpressionConverter.Convert(characterType);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtRemoveSingleWords))]
        public IBodyWorkflowAction<DQGlobal> StringExtRemoveSingleWords([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtRemoveSingleWords(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/RemoveSingleCharacterWords";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtReplaceRepeatingText))]
        public IBodyWorkflowAction<DQGlobal> StringExtReplaceRepeatingText([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> repeatingValue, [WorkflowExpression] Func<string> replacement)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtReplaceRepeatingText(WorkflowValue<string> input, WorkflowValue<string> repeatingValue, WorkflowValue<string> replacement)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(repeatingValue, nameof(repeatingValue), required: true);
            WorkflowValue.Validate(replacement, nameof(replacement), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/ReplaceAdjacentRepeatingText";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["RepeatingValue"] = ExpressionConverter.Convert(repeatingValue);
                callPayload.Queries["Replacement"] = ExpressionConverter.Convert(replacement);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtReplaceEndsWith))]
        public IBodyWorkflowAction<DQGlobal> StringExtReplaceEndsWith([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> stringToReplace, [WorkflowExpression] Func<string> replacement)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtReplaceEndsWith(WorkflowValue<string> input, WorkflowValue<string> stringToReplace, WorkflowValue<string> replacement)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(stringToReplace, nameof(stringToReplace), required: true);
            WorkflowValue.Validate(replacement, nameof(replacement), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/ReplaceIfEndsWith";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["stringToReplace"] = ExpressionConverter.Convert(stringToReplace);
                callPayload.Queries["replacement"] = ExpressionConverter.Convert(replacement);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtReplaceStartsWith))]
        public IBodyWorkflowAction<DQGlobal> StringExtReplaceStartsWith([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> stringToReplace, [WorkflowExpression] Func<string> replacement)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtReplaceStartsWith(WorkflowValue<string> input, WorkflowValue<string> stringToReplace, WorkflowValue<string> replacement)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(stringToReplace, nameof(stringToReplace), required: true);
            WorkflowValue.Validate(replacement, nameof(replacement), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/ReplaceIfStartsWith";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["stringToReplace"] = ExpressionConverter.Convert(stringToReplace);
                callPayload.Queries["replacement"] = ExpressionConverter.Convert(replacement);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtStringToBinary))]
        public IBodyWorkflowAction<DQGlobal> StringExtStringToBinary([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtStringToBinary(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/StringToBinary";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtBinaryToString))]
        public IBodyWorkflowAction<DQGlobal> StringExtBinaryToString([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtBinaryToString(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/BinaryToString";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtStringToHex))]
        public IBodyWorkflowAction<DQGlobal> StringExtStringToHex([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtStringToHex(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/StringToHex";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtHexToString))]
        public IBodyWorkflowAction<DQGlobal> StringExtHexToString([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtHexToString(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/HexToString";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtReverse))]
        public IBodyWorkflowAction<DQGlobal> StringExtReverse([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtReverse(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/Reverse";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtNormWhiteSpace))]
        public IBodyWorkflowAction<DQGlobal> StringExtNormWhiteSpace([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtNormWhiteSpace(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/NormalizeWhiteSpace";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtNormPhone))]
        public IBodyWorkflowAction<DQGlobal> StringExtNormPhone([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtNormPhone(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/NormalizeAlphaNumericPhone";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtCollapseRepeatedChars))]
        public IBodyWorkflowAction<DQGlobal> StringExtCollapseRepeatedChars([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<bool> collapseNumerics, [WorkflowExpression] Func<int> maximumRepeat = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtCollapseRepeatedChars(WorkflowValue<string> input, WorkflowValue<bool> collapseNumerics, WorkflowValue<int> maximumRepeat = null)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(collapseNumerics, nameof(collapseNumerics), required: true);
            WorkflowValue.Validate(maximumRepeat, nameof(maximumRepeat), required: false);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/CollapseAdjacentRepeatedCharacters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["collapseNumerics"] = ExpressionConverter.Convert(collapseNumerics);
                if (maximumRepeat != null)
                    callPayload.Queries["maximumRepeat"] = ExpressionConverter.Convert(maximumRepeat);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtCollapseRepeatedType))]
        public IBodyWorkflowAction<DQGlobal> StringExtCollapseRepeatedType([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<int> maximumRepeat, [WorkflowExpression] Func<typeInput> type)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtCollapseRepeatedType(WorkflowValue<string> input, WorkflowValue<int> maximumRepeat, WorkflowValue<typeInput> type)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(maximumRepeat, nameof(maximumRepeat), required: true);
            WorkflowValue.Validate(type, nameof(type), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/CollapseAdjacentRepeatedType";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["MaximumRepeat"] = ExpressionConverter.Convert(maximumRepeat);
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtRemoveStopWords))]
        public IBodyWorkflowAction<DQGlobal> StringExtRemoveStopWords([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtRemoveStopWords(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/FilterStopWords";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtRetainChars))]
        public IBodyWorkflowAction<DQGlobal> StringExtRetainChars([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> replacement, [WorkflowExpression] Func<string> charactersToRetain)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtRetainChars(WorkflowValue<string> input, WorkflowValue<string> replacement, WorkflowValue<string> charactersToRetain)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(replacement, nameof(replacement), required: true);
            WorkflowValue.Validate(charactersToRetain, nameof(charactersToRetain), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/RetainCharacters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["replacement"] = ExpressionConverter.Convert(replacement);
                callPayload.Queries["charactersToRetain"] = ExpressionConverter.Convert(charactersToRetain);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtExtractChars))]
        public IBodyWorkflowAction<DQGlobal> StringExtExtractChars([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<int> extractLength, [WorkflowExpression] Func<extractFromInput> extractFrom)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtExtractChars(WorkflowValue<string> input, WorkflowValue<int> extractLength, WorkflowValue<extractFromInput> extractFrom)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(extractLength, nameof(extractLength), required: true);
            WorkflowValue.Validate(extractFrom, nameof(extractFrom), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/ExtractCharacters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["extractLength"] = ExpressionConverter.Convert(extractLength);
                callPayload.Queries["extractFrom"] = ExpressionConverter.Convert(extractFrom);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtExtractWords))]
        public IBodyWorkflowAction<DQGlobal> StringExtExtractWords([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<int> extractLength, [WorkflowExpression] Func<extractFromInput> extractFrom)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtExtractWords(WorkflowValue<string> input, WorkflowValue<int> extractLength, WorkflowValue<extractFromInput> extractFrom)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(extractLength, nameof(extractLength), required: true);
            WorkflowValue.Validate(extractFrom, nameof(extractFrom), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/ExtractWords";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["extractLength"] = ExpressionConverter.Convert(extractLength);
                callPayload.Queries["extractFrom"] = ExpressionConverter.Convert(extractFrom);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtRemoveHTML))]
        public IBodyWorkflowAction<DQGlobal> StringExtRemoveHTML([WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtRemoveHTML(WorkflowValue<string> input)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/RemoveHTML";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtEndsWith))]
        public IBodyWorkflowAction<DQGlobalBool> StringExtEndsWith([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> checkfor)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobalBool> __BuildStringExtEndsWith(WorkflowValue<string> input, WorkflowValue<string> checkfor)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(checkfor, nameof(checkfor), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/EndsWith";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["checkfor"] = ExpressionConverter.Convert(checkfor);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtStartsWith))]
        public IBodyWorkflowAction<DQGlobalBool> StringExtStartsWith([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> checkfor)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobalBool> __BuildStringExtStartsWith(WorkflowValue<string> input, WorkflowValue<string> checkfor)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(checkfor, nameof(checkfor), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/StartsWith";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["checkfor"] = ExpressionConverter.Convert(checkfor);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtEnsureEndsWith))]
        public IBodyWorkflowAction<DQGlobal> StringExtEnsureEndsWith([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> checkFor)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtEnsureEndsWith(WorkflowValue<string> input, WorkflowValue<string> checkFor)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(checkFor, nameof(checkFor), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/EnsureEndsWith";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["checkFor"] = ExpressionConverter.Convert(checkFor);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtEnsureStartEndsWith))]
        public IBodyWorkflowAction<DQGlobal> StringExtEnsureStartEndsWith([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> checkFor)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtEnsureStartEndsWith(WorkflowValue<string> input, WorkflowValue<string> checkFor)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(checkFor, nameof(checkFor), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/EnsureStartsAndEndsWith";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["checkFor"] = ExpressionConverter.Convert(checkFor);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtEnsureStartsWith))]
        public IBodyWorkflowAction<DQGlobal> StringExtEnsureStartsWith([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> checkFor)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobal> __BuildStringExtEnsureStartsWith(WorkflowValue<string> input, WorkflowValue<string> checkFor)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(checkFor, nameof(checkFor), required: true);
            return new DeferredBodyAction<DQGlobal>(() =>
            {
                var apiCallPath = "/StringExtension/EnsureStartsWith";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["checkFor"] = ExpressionConverter.Convert(checkFor);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtStartWithType))]
        public IBodyWorkflowAction<DQGlobalBool> StringExtStartWithType([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<typeInput> type)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobalBool> __BuildStringExtStartWithType(WorkflowValue<string> input, WorkflowValue<typeInput> type)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(type, nameof(type), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/StartsWithType";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        [WorkflowExpressionFactory(nameof(__BuildStringExtEndsWithType))]
        public IBodyWorkflowAction<DQGlobalBool> StringExtEndsWithType([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<typeInput> type)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DQGlobalBool> __BuildStringExtEndsWithType(WorkflowValue<string> input, WorkflowValue<typeInput> type)
        {
            WorkflowValue.Validate(input, nameof(input), required: true);
            WorkflowValue.Validate(type, nameof(type), required: true);
            return new DeferredBodyAction<DQGlobalBool>(() =>
            {
                var apiCallPath = "/StringExtension/EndsWithType";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(input);
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
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

    public enum inputInputItemGroupFieldsTypeItemSettingsTypeScoringTypeType
    {
        InterScore,
        IntraScore
    }

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

    public enum inputInputItemGroupFieldsTypeItemSettingsTypeAlphaSequenceType
    {
        AscCharacters,
        DescCharacters,
        AscWords,
        DescWords,
        None
    }

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
