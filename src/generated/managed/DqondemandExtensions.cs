//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dqondemand
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DqondemandActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<GetPricesOutput, ApiConnectionActionConfiguration> PricingGet()
        {
            return new DeferredBodyAction<GetPricesOutput, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Account/Prices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPricesOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalInt, ApiConnectionActionConfiguration> BalanceGet()
        {
            return new DeferredBodyAction<DQGlobalInt, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Account/Balance";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DQGlobalInt>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> CaseSingular(Expression<Func<string>> input, Expression<Func<CaseTypeInput>> caseType, Expression<Func<LanguageInput>> language)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_caseType = WorkflowExpression.Compile(caseType, nameof(caseType), required: true);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<ClassifyGetResponse, ApiConnectionActionConfiguration> ClassifyGet(Expression<Func<string>> input, Expression<Func<CategoriesInput>> categories, Expression<Func<LanguageInput>> language = null)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_categories = WorkflowExpression.Compile(categories, nameof(categories), required: true);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: false);
            return new DeferredBodyAction<ClassifyGetResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobalFloat, ApiConnectionActionConfiguration> CompareGet(Expression<Func<string>> input1, Expression<Func<string>> input2, Expression<Func<ComparisonAlgorithmInput>> comparisonAlgorithm)
        {
            var __workflow_input1 = WorkflowExpression.Compile(input1, nameof(input1), required: true);
            var __workflow_input2 = WorkflowExpression.Compile(input2, nameof(input2), required: true);
            var __workflow_comparisonAlgorithm = WorkflowExpression.Compile(comparisonAlgorithm, nameof(comparisonAlgorithm), required: true);
            return new DeferredBodyAction<DQGlobalFloat, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<CongruenceResultSingle, ApiConnectionActionConfiguration> EmailCongruenceGet(Expression<Func<string>> email, Expression<Func<string>> firstName, Expression<Func<string>> lastName)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: true);
            var __workflow_lastName = WorkflowExpression.Compile(lastName, nameof(lastName), required: true);
            return new DeferredBodyAction<CongruenceResultSingle, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<CongruenceResultSingle, ApiConnectionActionConfiguration> CountryCongruenceGet(Expression<Func<string>> input, Expression<Func<string>> country, Expression<Func<ActionTypeInput>> actionType)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: true);
            var __workflow_actionType = WorkflowExpression.Compile(actionType, nameof(actionType), required: true);
            return new DeferredBodyAction<CongruenceResultSingle, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<CongruenceResultSingle, ApiConnectionActionConfiguration> SalutationCongruenceGet(Expression<Func<string>> salutation, Expression<Func<string>> firstName, Expression<Func<LanguageInput>> language)
        {
            var __workflow_salutation = WorkflowExpression.Compile(salutation, nameof(salutation), required: true);
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: true);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: true);
            return new DeferredBodyAction<CongruenceResultSingle, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DeriveGenderGetResponse, ApiConnectionActionConfiguration> DeriveGenderGet(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DeriveGenderGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Derive/Gender";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DeriveGenderGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DeriveCityGetResponse, ApiConnectionActionConfiguration> DeriveCityGet(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DeriveCityGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Derive/CountryFromCity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DeriveCityGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DerivePostCodeGetResponse, ApiConnectionActionConfiguration> DerivePostCodeGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_countryIdentifier = WorkflowExpression.Compile(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DerivePostCodeGetResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DeriveEmailGetResponse, ApiConnectionActionConfiguration> DeriveEmailGet(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DeriveEmailGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Derive/EmailType";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DeriveEmailGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DeriveIsoGetResponse, ApiConnectionActionConfiguration> DeriveIsoGet(Expression<Func<string>> email = null, Expression<Func<string>> url = null, Expression<Func<string>> phone = null, Expression<Func<string>> country = null, Expression<Func<string>> city = null, Expression<Func<int>> threshold = null, Expression<Func<bool>> onlyReturnBest = null, Expression<Func<bool>> defaultToCountry = null)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_url = WorkflowExpression.Compile(url, nameof(url), required: false);
            var __workflow_phone = WorkflowExpression.Compile(phone, nameof(phone), required: false);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: false);
            var __workflow_city = WorkflowExpression.Compile(city, nameof(city), required: false);
            var __workflow_threshold = WorkflowExpression.Compile(threshold, nameof(threshold), required: false);
            var __workflow_onlyReturnBest = WorkflowExpression.Compile(onlyReturnBest, nameof(onlyReturnBest), required: false);
            var __workflow_defaultToCountry = WorkflowExpression.Compile(defaultToCountry, nameof(defaultToCountry), required: false);
            return new DeferredBodyAction<DeriveIsoGetResponse, ApiConnectionActionConfiguration>(() =>
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
                return new ApiConnectionAction<DeriveIsoGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> FormatEmailGet(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Format/Email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> FormatPostCodeGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_countryIdentifier = WorkflowExpression.Compile(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> FormatE164Get(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_countryIdentifier = WorkflowExpression.Compile(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> FormatInternationalGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_countryIdentifier = WorkflowExpression.Compile(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> FormatNationalGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_countryIdentifier = WorkflowExpression.Compile(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> FormatRfc3966Get(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_countryIdentifier = WorkflowExpression.Compile(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> FormatUrlGet(Expression<Func<string>> input, Expression<Func<string>> urlPrefix)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_urlPrefix = WorkflowExpression.Compile(urlPrefix, nameof(urlPrefix), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Format/UrlAddress";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["URLPrefix"] = ExpressionConverter.Convert(__workflow_urlPrefix);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<GeneratePatternResponse, ApiConnectionActionConfiguration> GeneratePattern(Expression<Func<GeneratePatternInputInputItem[]>> input = null)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: false);
            return new DeferredBodyAction<GeneratePatternResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Generate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_input != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<GeneratePatternResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> GenerateTokenGet(Expression<Func<string>> input, Expression<Func<GenerateAlgorithmTypeInput>> generateAlgorithmType, Expression<Func<LanguageInput>> language = null)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_generateAlgorithmType = WorkflowExpression.Compile(generateAlgorithmType, nameof(generateAlgorithmType), required: true);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: false);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<ParsePhoneGetResponse, ApiConnectionActionConfiguration> ParsePhoneGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_countryIdentifier = WorkflowExpression.Compile(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<ParsePhoneGetResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<ParseEmailGetResponse, ApiConnectionActionConfiguration> ParseEmailGet(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<ParseEmailGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Parse/Email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<ParseEmailGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ParseUrlGetResponse, ApiConnectionActionConfiguration> ParseUrlGet(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<ParseUrlGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Parse/URL";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<ParseUrlGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ScoringResponse, ApiConnectionActionConfiguration> Scoring(Expression<Func<ScoringInputInputItem[]>> input = null)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: false);
            return new DeferredBodyAction<ScoringResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Scoring";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_input != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<ScoringResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> TransformGet(Expression<Func<string>> input, Expression<Func<EntityTypeInput>> entityType, Expression<Func<OperationTypeInput>> operationType, Expression<Func<LanguageInput>> language = null)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_entityType = WorkflowExpression.Compile(entityType, nameof(entityType), required: true);
            var __workflow_operationType = WorkflowExpression.Compile(operationType, nameof(operationType), required: true);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: false);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SequenceTransformResponse, ApiConnectionActionConfiguration> SequenceTransform(Expression<Func<SequenceTransformInputInputItem[]>> input = null)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: false);
            return new DeferredBodyAction<SequenceTransformResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SequenceTransform";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_input != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<SequenceTransformResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool, ApiConnectionActionConfiguration> ValidateEmailGet(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Validate/Email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool, ApiConnectionActionConfiguration> ValidatePostCodeGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_countryIdentifier = WorkflowExpression.Compile(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DQGlobalBool, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobalBool, ApiConnectionActionConfiguration> ValidateUrlGet(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Validate/UrlAddress";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool, ApiConnectionActionConfiguration> ValidatePhoneGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_countryIdentifier = WorkflowExpression.Compile(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<DQGlobalBool, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobalBool, ApiConnectionActionConfiguration> ValidateDateTimeGet(Expression<Func<string>> input, Expression<Func<string>> dateTimeFormat)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_dateTimeFormat = WorkflowExpression.Compile(dateTimeFormat, nameof(dateTimeFormat), required: true);
            return new DeferredBodyAction<DQGlobalBool, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<ValidatePlusEmailGetResponse, ApiConnectionActionConfiguration> ValidatePlusEmailGet(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<ValidatePlusEmailGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ValidatePlus/Email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<ValidatePlusEmailGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ValidatePlusPostCodeGetResponse, ApiConnectionActionConfiguration> ValidatePlusPostCodeGet(Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_countryIdentifier = WorkflowExpression.Compile(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<ValidatePlusPostCodeGetResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<ValidatePlusUrlGetResponse, ApiConnectionActionConfiguration> ValidatePlusUrlGet(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<ValidatePlusUrlGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ValidatePlus/UrlAddress";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<ValidatePlusUrlGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<VerifyAddressGetResponse, ApiConnectionActionConfiguration> VerifyAddressGet(Expression<Func<VerifyAddressGetProviderInput>> provider, Expression<Func<string>> countryIdentifier, Expression<Func<bool>> geocode, Expression<Func<string>> line1 = null, Expression<Func<string>> line2 = null, Expression<Func<string>> line3 = null, Expression<Func<string>> postalCode = null, Expression<Func<string>> city = null, Expression<Func<string>> state = null)
        {
            var __workflow_provider = WorkflowExpression.Compile(provider, nameof(provider), required: true);
            var __workflow_countryIdentifier = WorkflowExpression.Compile(countryIdentifier, nameof(countryIdentifier), required: true);
            var __workflow_geocode = WorkflowExpression.Compile(geocode, nameof(geocode), required: true);
            var __workflow_line1 = WorkflowExpression.Compile(line1, nameof(line1), required: false);
            var __workflow_line2 = WorkflowExpression.Compile(line2, nameof(line2), required: false);
            var __workflow_line3 = WorkflowExpression.Compile(line3, nameof(line3), required: false);
            var __workflow_postalCode = WorkflowExpression.Compile(postalCode, nameof(postalCode), required: false);
            var __workflow_city = WorkflowExpression.Compile(city, nameof(city), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            return new DeferredBodyAction<VerifyAddressGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Verify/Address/{0}", __workflow_provider.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<SearchAddressFindResponse, ApiConnectionActionConfiguration> SearchAddressFind(Expression<Func<SearchAddressFindProviderInput>> provider, Expression<Func<string>> query, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_provider = WorkflowExpression.Compile(provider, nameof(provider), required: true);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            var __workflow_countryIdentifier = WorkflowExpression.Compile(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<SearchAddressFindResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Search/Address/Find/{0}", __workflow_provider.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                return new ApiConnectionAction<SearchAddressFindResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SearchAddressRetrieveResponse, ApiConnectionActionConfiguration> SearchAddressRetrieve(Expression<Func<SearchAddressFindProviderInput>> provider, Expression<Func<string>> id, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_provider = WorkflowExpression.Compile(provider, nameof(provider), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_countryIdentifier = WorkflowExpression.Compile(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<SearchAddressRetrieveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Search/Address/Retrieve/{0}", __workflow_provider.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                return new ApiConnectionAction<SearchAddressRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SuppressDeceasedResponse, ApiConnectionActionConfiguration> SuppressDeceased(Expression<Func<SuppressDeceasedProviderInput>> provider, Expression<Func<string>> lastName, Expression<Func<string>> postcode, Expression<Func<string>> countryIdentifier, Expression<Func<string>> title = null, Expression<Func<string>> firstName = null, Expression<Func<string>> line1 = null, Expression<Func<string>> line2 = null, Expression<Func<string>> line3 = null, Expression<Func<string>> town = null, Expression<Func<string>> county = null)
        {
            var __workflow_provider = WorkflowExpression.Compile(provider, nameof(provider), required: true);
            var __workflow_lastName = WorkflowExpression.Compile(lastName, nameof(lastName), required: true);
            var __workflow_postcode = WorkflowExpression.Compile(postcode, nameof(postcode), required: true);
            var __workflow_countryIdentifier = WorkflowExpression.Compile(countryIdentifier, nameof(countryIdentifier), required: true);
            var __workflow_title = WorkflowExpression.Compile(title, nameof(title), required: false);
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: false);
            var __workflow_line1 = WorkflowExpression.Compile(line1, nameof(line1), required: false);
            var __workflow_line2 = WorkflowExpression.Compile(line2, nameof(line2), required: false);
            var __workflow_line3 = WorkflowExpression.Compile(line3, nameof(line3), required: false);
            var __workflow_town = WorkflowExpression.Compile(town, nameof(town), required: false);
            var __workflow_county = WorkflowExpression.Compile(county, nameof(county), required: false);
            return new DeferredBodyAction<SuppressDeceasedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Suppress/Address/Deceased/{0}", __workflow_provider.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<SuppressGoneAwayResponse, ApiConnectionActionConfiguration> SuppressGoneAway(Expression<Func<SuppressDeceasedProviderInput>> provider, Expression<Func<string>> lastName, Expression<Func<string>> postcode, Expression<Func<string>> iso2, Expression<Func<string>> title = null, Expression<Func<string>> firstName = null, Expression<Func<string>> line1 = null, Expression<Func<string>> line2 = null, Expression<Func<string>> line3 = null, Expression<Func<string>> town = null, Expression<Func<string>> county = null)
        {
            var __workflow_provider = WorkflowExpression.Compile(provider, nameof(provider), required: true);
            var __workflow_lastName = WorkflowExpression.Compile(lastName, nameof(lastName), required: true);
            var __workflow_postcode = WorkflowExpression.Compile(postcode, nameof(postcode), required: true);
            var __workflow_iso2 = WorkflowExpression.Compile(iso2, nameof(iso2), required: true);
            var __workflow_title = WorkflowExpression.Compile(title, nameof(title), required: false);
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: false);
            var __workflow_line1 = WorkflowExpression.Compile(line1, nameof(line1), required: false);
            var __workflow_line2 = WorkflowExpression.Compile(line2, nameof(line2), required: false);
            var __workflow_line3 = WorkflowExpression.Compile(line3, nameof(line3), required: false);
            var __workflow_town = WorkflowExpression.Compile(town, nameof(town), required: false);
            var __workflow_county = WorkflowExpression.Compile(county, nameof(county), required: false);
            return new DeferredBodyAction<SuppressGoneAwayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Suppress/Address/GoneAway/{0}", __workflow_provider.WithUrlEncoding(1)));
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
                callPayload.Queries["ISO2"] = ExpressionConverter.Convert(__workflow_iso2);
                return new ApiConnectionAction<SuppressGoneAwayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SuppressRelocatedResponse, ApiConnectionActionConfiguration> SuppressRelocated(Expression<Func<SuppressDeceasedProviderInput>> provider, Expression<Func<string>> lastName, Expression<Func<string>> postcode, Expression<Func<string>> iso2, Expression<Func<string>> title = null, Expression<Func<string>> firstName = null, Expression<Func<string>> line1 = null, Expression<Func<string>> line2 = null, Expression<Func<string>> line3 = null, Expression<Func<string>> town = null, Expression<Func<string>> county = null)
        {
            var __workflow_provider = WorkflowExpression.Compile(provider, nameof(provider), required: true);
            var __workflow_lastName = WorkflowExpression.Compile(lastName, nameof(lastName), required: true);
            var __workflow_postcode = WorkflowExpression.Compile(postcode, nameof(postcode), required: true);
            var __workflow_iso2 = WorkflowExpression.Compile(iso2, nameof(iso2), required: true);
            var __workflow_title = WorkflowExpression.Compile(title, nameof(title), required: false);
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: false);
            var __workflow_line1 = WorkflowExpression.Compile(line1, nameof(line1), required: false);
            var __workflow_line2 = WorkflowExpression.Compile(line2, nameof(line2), required: false);
            var __workflow_line3 = WorkflowExpression.Compile(line3, nameof(line3), required: false);
            var __workflow_town = WorkflowExpression.Compile(town, nameof(town), required: false);
            var __workflow_county = WorkflowExpression.Compile(county, nameof(county), required: false);
            return new DeferredBodyAction<SuppressRelocatedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Suppress/Address/Relocated/{0}", __workflow_provider.WithUrlEncoding(1)));
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
                callPayload.Queries["ISO2"] = ExpressionConverter.Convert(__workflow_iso2);
                return new ApiConnectionAction<SuppressRelocatedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SuppressPhonePersonalResponse, ApiConnectionActionConfiguration> SuppressPhonePersonal(Expression<Func<SuppressPhoneCorporateProviderInput>> provider, Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_provider = WorkflowExpression.Compile(provider, nameof(provider), required: true);
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_countryIdentifier = WorkflowExpression.Compile(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<SuppressPhonePersonalResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Suppress/Phone/Personal/{0}", __workflow_provider.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                return new ApiConnectionAction<SuppressPhonePersonalResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SuppressPhoneCorporateResponse, ApiConnectionActionConfiguration> SuppressPhoneCorporate(Expression<Func<SuppressPhoneCorporateProviderInput>> provider, Expression<Func<string>> input, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_provider = WorkflowExpression.Compile(provider, nameof(provider), required: true);
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_countryIdentifier = WorkflowExpression.Compile(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<SuppressPhoneCorporateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Suppress/Phone/Corporate/{0}", __workflow_provider.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                return new ApiConnectionAction<SuppressPhoneCorporateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<AuthenticateEmailGetResponse, ApiConnectionActionConfiguration> AuthenticateEmailGet(Expression<Func<AuthenticateEmailGetProviderInput>> provider, Expression<Func<string>> email)
        {
            var __workflow_provider = WorkflowExpression.Compile(provider, nameof(provider), required: true);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            return new DeferredBodyAction<AuthenticateEmailGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Authenticate/Email/{0}", __workflow_provider.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Email"] = ExpressionConverter.Convert(__workflow_email);
                return new ApiConnectionAction<AuthenticateEmailGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<AuthenticatePhoneGetResponse, ApiConnectionActionConfiguration> AuthenticatePhoneGet(Expression<Func<AuthenticatePhoneGetProviderInput>> provider, Expression<Func<string>> phone, Expression<Func<string>> countryIdentifier)
        {
            var __workflow_provider = WorkflowExpression.Compile(provider, nameof(provider), required: true);
            var __workflow_phone = WorkflowExpression.Compile(phone, nameof(phone), required: true);
            var __workflow_countryIdentifier = WorkflowExpression.Compile(countryIdentifier, nameof(countryIdentifier), required: true);
            return new DeferredBodyAction<AuthenticatePhoneGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Authenticate/Phone/{0}", __workflow_provider.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Phone"] = ExpressionConverter.Convert(__workflow_phone);
                callPayload.Queries["CountryIdentifier"] = ExpressionConverter.Convert(__workflow_countryIdentifier);
                return new ApiConnectionAction<AuthenticatePhoneGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool, ApiConnectionActionConfiguration> StringExtIsAllUpper(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/StringExtension/IsAllUpper";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool, ApiConnectionActionConfiguration> StringExtIsAllLower(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/StringExtension/IsAllLower";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool, ApiConnectionActionConfiguration> StringExtIsMixedCase(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/StringExtension/IsMixedCase";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool, ApiConnectionActionConfiguration> StringExtIsAlphaNumeric(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/StringExtension/IsAlphaNumeric";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool, ApiConnectionActionConfiguration> StringExtIsNumeric(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/StringExtension/IsNumeric";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool, ApiConnectionActionConfiguration> StringExtIsIso4217(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/StringExtension/IsISO4217CurrencyCode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool, ApiConnectionActionConfiguration> StringExtIsIso2(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/StringExtension/IsISO2Code";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool, ApiConnectionActionConfiguration> StringExtIsIso3(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobalBool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/StringExtension/IsISO3Code";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtRemoveLeading(Expression<Func<string>> input, Expression<Func<string>> valToRemove, Expression<Func<bool>> leaveOneAtStart)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_valToRemove = WorkflowExpression.Compile(valToRemove, nameof(valToRemove), required: true);
            var __workflow_leaveOneAtStart = WorkflowExpression.Compile(leaveOneAtStart, nameof(leaveOneAtStart), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtRemoveChars(Expression<Func<string>> input, Expression<Func<CharacterTypeInput>> characterType)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_characterType = WorkflowExpression.Compile(characterType, nameof(characterType), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtRemoveSingleWords(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/StringExtension/RemoveSingleCharacterWords";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtReplaceRepeatingText(Expression<Func<string>> input, Expression<Func<string>> repeatingValue, Expression<Func<string>> replacement)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_repeatingValue = WorkflowExpression.Compile(repeatingValue, nameof(repeatingValue), required: true);
            var __workflow_replacement = WorkflowExpression.Compile(replacement, nameof(replacement), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtReplaceEndsWith(Expression<Func<string>> input, Expression<Func<string>> stringToReplace, Expression<Func<string>> replacement)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_stringToReplace = WorkflowExpression.Compile(stringToReplace, nameof(stringToReplace), required: true);
            var __workflow_replacement = WorkflowExpression.Compile(replacement, nameof(replacement), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtReplaceStartsWith(Expression<Func<string>> input, Expression<Func<string>> stringToReplace, Expression<Func<string>> replacement)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_stringToReplace = WorkflowExpression.Compile(stringToReplace, nameof(stringToReplace), required: true);
            var __workflow_replacement = WorkflowExpression.Compile(replacement, nameof(replacement), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtStringToBinary(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/StringExtension/StringToBinary";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtBinaryToString(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/StringExtension/BinaryToString";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtStringToHex(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/StringExtension/StringToHex";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtHexToString(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/StringExtension/HexToString";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtReverse(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/StringExtension/Reverse";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtNormWhiteSpace(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/StringExtension/NormalizeWhiteSpace";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtNormPhone(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/StringExtension/NormalizeAlphaNumericPhone";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtCollapseRepeatedChars(Expression<Func<string>> input, Expression<Func<bool>> collapseNumerics, Expression<Func<int>> maximumRepeat = null)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_collapseNumerics = WorkflowExpression.Compile(collapseNumerics, nameof(collapseNumerics), required: true);
            var __workflow_maximumRepeat = WorkflowExpression.Compile(maximumRepeat, nameof(maximumRepeat), required: false);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtCollapseRepeatedType(Expression<Func<string>> input, Expression<Func<int>> maximumRepeat, Expression<Func<TypeInput>> type)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_maximumRepeat = WorkflowExpression.Compile(maximumRepeat, nameof(maximumRepeat), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtRemoveStopWords(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/StringExtension/FilterStopWords";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtRetainChars(Expression<Func<string>> input, Expression<Func<string>> replacement, Expression<Func<string>> charactersToRetain)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_replacement = WorkflowExpression.Compile(replacement, nameof(replacement), required: true);
            var __workflow_charactersToRetain = WorkflowExpression.Compile(charactersToRetain, nameof(charactersToRetain), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtExtractChars(Expression<Func<string>> input, Expression<Func<int>> extractLength, Expression<Func<ExtractFromInput>> extractFrom)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_extractLength = WorkflowExpression.Compile(extractLength, nameof(extractLength), required: true);
            var __workflow_extractFrom = WorkflowExpression.Compile(extractFrom, nameof(extractFrom), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtExtractWords(Expression<Func<string>> input, Expression<Func<int>> extractLength, Expression<Func<ExtractFromInput>> extractFrom)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_extractLength = WorkflowExpression.Compile(extractLength, nameof(extractLength), required: true);
            var __workflow_extractFrom = WorkflowExpression.Compile(extractFrom, nameof(extractFrom), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtRemoveHtml(Expression<Func<string>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/StringExtension/RemoveHTML";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                return new ApiConnectionAction<DQGlobal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool, ApiConnectionActionConfiguration> StringExtEndsWith(Expression<Func<string>> input, Expression<Func<string>> checkfor)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_checkfor = WorkflowExpression.Compile(checkfor, nameof(checkfor), required: true);
            return new DeferredBodyAction<DQGlobalBool, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobalBool, ApiConnectionActionConfiguration> StringExtStartsWith(Expression<Func<string>> input, Expression<Func<string>> checkfor)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_checkfor = WorkflowExpression.Compile(checkfor, nameof(checkfor), required: true);
            return new DeferredBodyAction<DQGlobalBool, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtEnsureEndsWith(Expression<Func<string>> input, Expression<Func<string>> checkFor)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_checkFor = WorkflowExpression.Compile(checkFor, nameof(checkFor), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtEnsureStartEndsWith(Expression<Func<string>> input, Expression<Func<string>> checkFor)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_checkFor = WorkflowExpression.Compile(checkFor, nameof(checkFor), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobal, ApiConnectionActionConfiguration> StringExtEnsureStartsWith(Expression<Func<string>> input, Expression<Func<string>> checkFor)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_checkFor = WorkflowExpression.Compile(checkFor, nameof(checkFor), required: true);
            return new DeferredBodyAction<DQGlobal, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobalBool, ApiConnectionActionConfiguration> StringExtStartWithType(Expression<Func<string>> input, Expression<Func<TypeInput>> type)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            return new DeferredBodyAction<DQGlobalBool, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DQGlobalBool, ApiConnectionActionConfiguration> StringExtEndsWithType(Expression<Func<string>> input, Expression<Func<TypeInput>> type)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            return new DeferredBodyAction<DQGlobalBool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/StringExtension/EndsWithType";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = ExpressionConverter.Convert(__workflow_input);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<DQGlobalBool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<GetUsageV2, ApiConnectionActionConfiguration> UsageGet(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<SummariseByInput>> summariseBy = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: true);
            var __workflow_summariseBy = WorkflowExpression.Compile(summariseBy, nameof(summariseBy), required: false);
            return new DeferredBodyAction<GetUsageV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Account/Usage/v2.0";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["StartDate"] = ExpressionConverter.Convert(__workflow_startDate);
                callPayload.Queries["EndDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_summariseBy != null)
                    callPayload.Queries["SummariseBy"] = ExpressionConverter.Convert(__workflow_summariseBy);
                return new ApiConnectionAction<GetUsageV2>(callPayload);
            });
        }
    }

    public class DqondemandTriggers([ConnectionName] string connectionId)
    {
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
    public enum CaseTypeInput
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
    public enum LanguageInput
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
    public enum CategoriesInput
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
    public enum ComparisonAlgorithmInput
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
    public enum ActionTypeInput
    {
        CountryToEmail,
        CountryToPhone,
        [EnumMember(Value = "CountryToURL")]
        CountryToUrl
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
        public string Iso2 { get; set; }

        [JsonProperty("iSO3")]
        public string Iso3 { get; set; }

        [JsonProperty("iDD")]
        public string Idd { get; set; }
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

    public class DeriveIsoGetResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public DeriveIsoGetResponseDataTypeItem[] Data { get; set; }
    }

    public class DeriveIsoGetResponseDataTypeItem
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

    public class GeneratePatternInputInputItem
    {
        public GeneratePatternInputInputItem(string input, GenerateSettings patternSettings)
        {
            this.Input = input;
            this.PatternSettings = patternSettings;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Input { get; set; }

        [JsonProperty("PatternSetting", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateSettings PatternSettings { get; set; }

        [JsonProperty("UID")]
        public string Uid { get; set; }
    }

    public class GenerateSettings
    {
        public GenerateSettings(GenerateSettingsExcludeFromTokenTypeItem[] excludeFromToken, GenerateLetterSettings letterSettings, GenerateNumberSettings numberSettings)
        {
            this.ExcludeFromToken = excludeFromToken;
            this.LetterSettings = letterSettings;
            this.NumberSettings = numberSettings;
        }

        [JsonProperty("DoNotTokenize", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateSettingsExcludeFromTokenTypeItem[] ExcludeFromToken { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateLetterSettings LetterSettings { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateNumberSettings NumberSettings { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateSymbolSettings SymbolSettings { get; set; } = new GenerateSymbolSettings();

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateWhiteSpaceSettings WhiteSpaceSettings { get; set; } = new GenerateWhiteSpaceSettings();

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateNonPrintingSettings NonPrintingSettings { get; set; } = new GenerateNonPrintingSettings();
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
        public GenerateLetterSettings(GenerateLetterSettingsExcludeTypeItem[] exclude, GenerateLetterSettingsCollapseTypeItem[] collapse)
        {
            this.Exclude = exclude;
            this.Collapse = collapse;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CaseSensitive { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool LetterCategories { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateLetterSettingsExcludeTypeItem[] Exclude { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
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
        public GenerateNumberSettings(GenerateNumberSettingsExcludeTypeItem[] exclude, GenerateNumberSettingsCollapseTypeItem[] collapse)
        {
            this.Exclude = exclude;
            this.Collapse = collapse;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool NumberCategories { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateNumberSettingsExcludeTypeItem[] Exclude { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
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
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Exclude { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Collapse { get; set; } = false;
    }

    public class GenerateWhiteSpaceSettings
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Exclude { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Collapse { get; set; } = false;
    }

    public class GenerateNonPrintingSettings
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Exclude { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Collapse { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerateAlgorithmTypeInput
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
        FixedLine,
        [EnumMember(Value = "MOBILE")]
        Mobile,
        [EnumMember(Value = "FIXED_LINE_OR_MOBILE")]
        FixedLineOrMobile,
        [EnumMember(Value = "TOLL_FREE")]
        TollFree,
        [EnumMember(Value = "PREMIUM_RATE")]
        PremiumRate,
        [EnumMember(Value = "SHARED_COST")]
        SharedCost,
        [EnumMember(Value = "VOIP")]
        Voip,
        [EnumMember(Value = "PERSONAL_NUMBER")]
        PersonalNumber,
        [EnumMember(Value = "PAGER")]
        Pager,
        [EnumMember(Value = "UAN")]
        Uan,
        [EnumMember(Value = "VOICEMAIL")]
        Voicemail,
        [EnumMember(Value = "UNKNOWN")]
        Unknown
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

    public class ParseUrlGetResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ParseUrlGetResponseDataType Data { get; set; }
    }

    public class ParseUrlGetResponseDataType
    {
        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("hostNameType")]
        public ParseUrlGetResponseDataTypeHostNameTypeType HostNameType { get; set; }

        [JsonProperty("pathAndQuery")]
        public string PathAndQuery { get; set; }

        [JsonProperty("port")]
        public string Port { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParseUrlGetResponseDataTypeHostNameTypeType
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
        public string GroupFieldId { get; set; }

        [JsonProperty("groupPercentageScore")]
        public double GroupPercentageScore { get; set; }

        [JsonProperty("warnings")]
        public string[] Warnings { get; set; }
    }

    public class ScoringInputInputItem
    {
        public ScoringInputInputItem(bool isDatum, string recordId, string recordSource, InputInputItemGroupFieldsTypeItem[] groupFields)
        {
            this.IsDatum = isDatum;
            this.RecordId = recordId;
            this.RecordSource = recordSource;
            this.GroupFields = groupFields;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsDatum { get; set; }

        [JsonProperty("UniqueId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecordId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecordSource { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public InputInputItemGroupFieldsTypeItem[] GroupFields { get; set; }
    }

    public class InputInputItemGroupFieldsTypeItem
    {
        public InputInputItemGroupFieldsTypeItem(string groupName, InputInputItemGroupFieldsTypeItemSettingsType settings, InputInputItemGroupFieldsTypeItemValuesTypeItem[] values)
        {
            this.GroupName = groupName;
            this.Settings = settings;
            this.Values = values;
        }

        [JsonProperty("GroupFieldId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public InputInputItemGroupFieldsTypeItemSettingsType Settings { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public InputInputItemGroupFieldsTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class InputInputItemGroupFieldsTypeItemSettingsType
    {
        public InputInputItemGroupFieldsTypeItemSettingsType(InputInputItemGroupFieldsTypeItemSettingsTypeScoringTypeType scoringType, InputInputItemGroupFieldsTypeItemSettingsTypeScoringMethodType scoringMethod, InputInputItemGroupFieldsTypeItemSettingsTypeComparisonAlgorithmType comparisonAlgorithm, bool caseSensitive, InputInputItemGroupFieldsTypeItemSettingsTypeAlphaSequenceType alphaSequence, bool replaceDoubleSpaceWithSingleSpace, bool removeAllWhiteSpace, bool trimString, bool includePunctuation, bool includeSymbols, bool includeNonPrinting, bool includeNumbers, bool includeLetters, bool applyWeighting, bool includePreTransformedDataForScoring, bool includeTokenForScoring, bool includeTransformsDataForScoring, bool autoPopulateTransformedValueWhenEmpty, bool autoPopulateTokenWhenEmpty)
        {
            this.ScoringType = scoringType;
            this.ScoringMethod = scoringMethod;
            this.ComparisonAlgorithm = comparisonAlgorithm;
            this.CaseSensitive = caseSensitive;
            this.AlphaSequence = alphaSequence;
            this.ReplaceDoubleSpaceWithSingleSpace = replaceDoubleSpaceWithSingleSpace;
            this.RemoveAllWhiteSpace = removeAllWhiteSpace;
            this.TrimString = trimString;
            this.IncludePunctuation = includePunctuation;
            this.IncludeSymbols = includeSymbols;
            this.IncludeNonPrinting = includeNonPrinting;
            this.IncludeNumbers = includeNumbers;
            this.IncludeLetters = includeLetters;
            this.ApplyWeighting = applyWeighting;
            this.IncludePreTransformedDataForScoring = includePreTransformedDataForScoring;
            this.IncludeTokenForScoring = includeTokenForScoring;
            this.IncludeTransformsDataForScoring = includeTransformsDataForScoring;
            this.AutoPopulateTransformedValueWhenEmpty = autoPopulateTransformedValueWhenEmpty;
            this.AutoPopulateTokenWhenEmpty = autoPopulateTokenWhenEmpty;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public InputInputItemGroupFieldsTypeItemSettingsTypeScoringTypeType ScoringType { get; set; }

        [JsonProperty("ScoreMethod", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputInputItemGroupFieldsTypeItemSettingsTypeScoringMethodType ScoringMethod { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public InputInputItemGroupFieldsTypeItemSettingsTypeComparisonAlgorithmType ComparisonAlgorithm { get; set; }

        [JsonProperty("IsNullToNullScored", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NullVsNullMatch { get; set; } = false;

        [JsonProperty("IsNullToValueScored", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NullVsValueMatch { get; set; } = false;

        [JsonProperty("IsCaseSensitiveScore", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CaseSensitive { get; set; }

        [JsonProperty("AlphaSequenceParameter", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputInputItemGroupFieldsTypeItemSettingsTypeAlphaSequenceType AlphaSequence { get; set; }

        [JsonProperty("IsReplaceDoubleSpaceWithSingle", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ReplaceDoubleSpaceWithSingleSpace { get; set; }

        [JsonProperty("IsRemoveAllWhiteSpaces", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RemoveAllWhiteSpace { get; set; }

        [JsonProperty("IsTrimString", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool TrimString { get; set; }

        [JsonProperty("IsIncludePunctuation", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludePunctuation { get; set; }

        [JsonProperty("IsIncludeSymbols", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeSymbols { get; set; }

        [JsonProperty("IsIncludeNonPrinting", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeNonPrinting { get; set; }

        [JsonProperty("IsIncludeNumbers", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeNumbers { get; set; }

        [JsonProperty("IsIncludeAlphaChars", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeLetters { get; set; }

        [JsonProperty("IsWeightingFactorUsed", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ApplyWeighting { get; set; }

        [JsonProperty("IsIncludeOriginalDataForScoring", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludePreTransformedDataForScoring { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeTokenForScoring { get; set; }

        [JsonProperty("IncludeTransformedDataForScoring", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeTransformsDataForScoring { get; set; }

        [JsonProperty("AutoPopulateEmptyTransformed", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool AutoPopulateTransformedValueWhenEmpty { get; set; }

        [JsonProperty("AutoPopulateEmptyToken", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool AutoPopulateTokenWhenEmpty { get; set; }

        [JsonProperty("Weighting", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? GroupWeighting { get; set; } = 100;
        public int? PostalCodeNChars { get; set; }
        public int? PositiveValidRange { get; set; }
        public int? NegativeValidRange { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public InputInputItemGroupFieldsTypeItemSettingsTypeDateFormatType? DateFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Dqondemand.InputInputItemGroupFieldsTypeItemSettingsTypeDateFormatType.Ddmmyyyy;
        public InputInputItemGroupFieldsTypeItemSettingsTypeInterScoreSettingsType InterScoreSettings { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputInputItemGroupFieldsTypeItemSettingsTypeScoringTypeType
    {
        InterScore,
        IntraScore
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputInputItemGroupFieldsTypeItemSettingsTypeScoringMethodType
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
    public enum InputInputItemGroupFieldsTypeItemSettingsTypeComparisonAlgorithmType
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
    public enum InputInputItemGroupFieldsTypeItemSettingsTypeAlphaSequenceType
    {
        AscCharacters,
        DescCharacters,
        AscWords,
        DescWords,
        None
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputInputItemGroupFieldsTypeItemSettingsTypeDateFormatType
    {
        [EnumMember(Value = "DDMMYYYY")]
        Ddmmyyyy,
        [EnumMember(Value = "MMDDYYYY")]
        Mmddyyyy
    }

    public class InputInputItemGroupFieldsTypeItemSettingsTypeInterScoreSettingsType
    {
        [JsonProperty("InterScoreMethodType")]
        public InputInputItemGroupFieldsTypeItemSettingsTypeInterScoreSettingsTypeScoringMethodType? ScoringMethod { get; set; }

        [JsonProperty("ThresholdValue")]
        public int? Threshold { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputInputItemGroupFieldsTypeItemSettingsTypeInterScoreSettingsTypeScoringMethodType
    {
        AnyMatch,
        AllMatch
    }

    public class InputInputItemGroupFieldsTypeItemValuesTypeItem
    {
        public InputInputItemGroupFieldsTypeItemValuesTypeItem(string value)
        {
            this.Value = value;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }
        public string TransformedValue { get; set; }

        [JsonProperty("Token")]
        public string TokenValue { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntityTypeInput
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
    public enum OperationTypeInput
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

    public class SequenceTransformInputInputItem
    {
        public SequenceTransformInputInputItem(string input, InputInputItemSettingsTypeItem[] settings)
        {
            this.Input = input;
            this.Settings = settings;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Input { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public InputInputItemSettingsTypeItem[] Settings { get; set; }

        [JsonProperty("UID")]
        public string RecordId { get; set; }
    }

    public class InputInputItemSettingsTypeItem
    {
        public InputInputItemSettingsTypeItem(InputInputItemSettingsTypeItemCategoryType category)
        {
            this.Category = category;
        }

        [JsonProperty("EntityType", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputInputItemSettingsTypeItemCategoryType Category { get; set; }

        [JsonProperty("OperationType", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputInputItemSettingsTypeItemActionType Action { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Dqondemand.InputInputItemSettingsTypeItemActionType.Abbreviate;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public InputInputItemSettingsTypeItemLanguageType Language { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Dqondemand.InputInputItemSettingsTypeItemLanguageType.English;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputInputItemSettingsTypeItemCategoryType
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
    public enum InputInputItemSettingsTypeItemActionType
    {
        Elaborate,
        Abbreviate,
        Normalize,
        Exclude,
        Transliterate
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputInputItemSettingsTypeItemLanguageType
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

    public class ValidatePlusUrlGetResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public ValidatePlusUrlGetResponseDataType Data { get; set; }
    }

    public class ValidatePlusUrlGetResponseDataType
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
        [EnumMember(Value = "VERIFIED")]
        Verified,
        [EnumMember(Value = "SUSPECT")]
        Suspect,
        [EnumMember(Value = "UNVERIFIED")]
        Unverified
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum VerifyAddressGetProviderInput
    {
        Default,
        Loqate,
        Sagacity
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SearchAddressFindProviderInput
    {
        Default,
        Loqate,
        Fetchify,
        GetAddressIO,
        [EnumMember(Value = "AFD")]
        Afd
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SuppressDeceasedProviderInput
    {
        Default,
        Sagacity
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SuppressPhoneCorporateProviderInput
    {
        Default,
        [EnumMember(Value = "TPSChecker")]
        TpsChecker,
        Sagacity
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AuthenticateEmailGetProviderInput
    {
        Default,
        TextMagic,
        Loqate,
        Fetchify,
        Gamalogic,
        [EnumMember(Value = "AFD")]
        Afd,
        Webbula
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
        [EnumMember(Value = "VOIP")]
        Voip,
        Unknown
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AuthenticatePhoneGetProviderInput
    {
        Default,
        TextMagic,
        Loqate,
        Fetchify,
        [EnumMember(Value = "AFD")]
        Afd
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CharacterTypeInput
    {
        Digit,
        Letter,
        LetterOrDigit,
        Punctuation,
        [EnumMember(Value = "Whitespace")]
        WhiteSpace,
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
    public enum TypeInput
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
        [EnumMember(Value = "Whitespace")]
        WhiteSpace,
        Symbol,
        NonPrinting
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExtractFromInput
    {
        Start,
        End
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SummariseByInput
    {
        Day,
        Month,
        Year,
        Quarter
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