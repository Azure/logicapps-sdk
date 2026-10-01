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
        public IBodyWorkflowAction<GetPricesOutput> PricingGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Account/Prices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetPricesOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalInt> BalanceGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Account/Balance";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobalInt>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> CaseSingular([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<caseTypeInput> caseType, [WorkflowExpression] Func<languageInput> language)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Case";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["CaseType"] = SourceExpressionConverter.Convert(caseType);
                callPayload.Queries["Language"] = SourceExpressionConverter.Convert(language);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ClassifyGetResponse> ClassifyGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<categoriesInput> categories, [WorkflowExpression] Func<languageInput> language = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Classify";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["Categories"] = SourceExpressionConverter.Convert(categories);
                callPayload.Queries["Language"] = Convert.ToString("English");
                if (language != null)
                    callPayload.Queries["Language"] = SourceExpressionConverter.Convert(language);
                return callPayload;
            }

            return new ApiConnectionAction<ClassifyGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalFloat> CompareGet([WorkflowExpression] Func<string> input1, [WorkflowExpression] Func<string> input2, [WorkflowExpression] Func<comparisonAlgorithmInput> comparisonAlgorithm)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Compare";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input1"] = SourceExpressionConverter.ConvertO(input1);
                callPayload.Queries["Input2"] = SourceExpressionConverter.ConvertO(input2);
                callPayload.Queries["ComparisonAlgorithm"] = SourceExpressionConverter.Convert(comparisonAlgorithm);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobalFloat>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<CongruenceResultSingle> EmailCongruenceGet([WorkflowExpression] Func<string> email, [WorkflowExpression] Func<string> firstName, [WorkflowExpression] Func<string> lastName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Congruence/Email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Email"] = SourceExpressionConverter.ConvertO(email);
                callPayload.Queries["FirstName"] = SourceExpressionConverter.ConvertO(firstName);
                callPayload.Queries["LastName"] = SourceExpressionConverter.ConvertO(lastName);
                return callPayload;
            }

            return new ApiConnectionAction<CongruenceResultSingle>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<CongruenceResultSingle> CountryCongruenceGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> country, [WorkflowExpression] Func<actionTypeInput> actionType)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Congruence/Country";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["Country"] = SourceExpressionConverter.ConvertO(country);
                callPayload.Queries["ActionType"] = SourceExpressionConverter.Convert(actionType);
                return callPayload;
            }

            return new ApiConnectionAction<CongruenceResultSingle>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<CongruenceResultSingle> SalutationCongruenceGet([WorkflowExpression] Func<string> salutation, [WorkflowExpression] Func<string> firstName, [WorkflowExpression] Func<languageInput> language)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Congruence/Salutation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Salutation"] = SourceExpressionConverter.ConvertO(salutation);
                callPayload.Queries["FirstName"] = SourceExpressionConverter.ConvertO(firstName);
                callPayload.Queries["Language"] = SourceExpressionConverter.Convert(language);
                return callPayload;
            }

            return new ApiConnectionAction<CongruenceResultSingle>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DeriveGenderGetResponse> DeriveGenderGet([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Derive/Gender";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DeriveGenderGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DeriveCityGetResponse> DeriveCityGet([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Derive/CountryFromCity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DeriveCityGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DerivePostCodeGetResponse> DerivePostCodeGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Derive/FromPostalCode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["CountryIdentifier"] = SourceExpressionConverter.ConvertO(countryIdentifier);
                return callPayload;
            }

            return new ApiConnectionAction<DerivePostCodeGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DeriveEmailGetResponse> DeriveEmailGet([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Derive/EmailType";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DeriveEmailGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DeriveISOGetResponse> DeriveISOGet([WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> url = null, [WorkflowExpression] Func<string> phone = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<int> threshold = null, [WorkflowExpression] Func<bool> onlyReturnBest = null, [WorkflowExpression] Func<bool> defaultToCountry = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DeriveISO";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (email != null)
                    callPayload.Queries["Email"] = SourceExpressionConverter.ConvertO(email);
                if (url != null)
                    callPayload.Queries["Url"] = SourceExpressionConverter.ConvertO(url);
                if (phone != null)
                    callPayload.Queries["Phone"] = SourceExpressionConverter.ConvertO(phone);
                if (country != null)
                    callPayload.Queries["Country"] = SourceExpressionConverter.ConvertO(country);
                if (city != null)
                    callPayload.Queries["City"] = SourceExpressionConverter.ConvertO(city);
                callPayload.Queries["Threshold"] = Convert.ToString(70);
                if (threshold != null)
                    callPayload.Queries["Threshold"] = SourceExpressionConverter.ConvertO(threshold);
                callPayload.Queries["OnlyReturnBest"] = Convert.ToString(false);
                if (onlyReturnBest != null)
                    callPayload.Queries["OnlyReturnBest"] = SourceExpressionConverter.ConvertO(onlyReturnBest);
                callPayload.Queries["DefaultToCountry"] = Convert.ToString(false);
                if (defaultToCountry != null)
                    callPayload.Queries["DefaultToCountry"] = SourceExpressionConverter.ConvertO(defaultToCountry);
                return callPayload;
            }

            return new ApiConnectionAction<DeriveISOGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> FormatEmailGet([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Format/Email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> FormatPostCodeGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Format/PostCode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["CountryIdentifier"] = SourceExpressionConverter.ConvertO(countryIdentifier);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> FormatE164Get([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Format/TelephoneE164";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["CountryIdentifier"] = SourceExpressionConverter.ConvertO(countryIdentifier);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> FormatInternationalGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Format/TelephoneInternational";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["CountryIdentifier"] = SourceExpressionConverter.ConvertO(countryIdentifier);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> FormatNationalGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Format/TelephoneNational";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["CountryIdentifier"] = SourceExpressionConverter.ConvertO(countryIdentifier);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> FormatRFC3966Get([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Format/TelephoneRFC3966";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["CountryIdentifier"] = SourceExpressionConverter.ConvertO(countryIdentifier);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> FormatURLGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> uRLPrefix)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Format/UrlAddress";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["URLPrefix"] = SourceExpressionConverter.ConvertO(uRLPrefix);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<GeneratePatternResponse> GeneratePattern([WorkflowExpression] Func<inputInputItem[]> input = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Generate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(input);
                return callPayload;
            }

            return new ApiConnectionAction<GeneratePatternResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> GenerateTokenGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<generateAlgorithmTypeInput> generateAlgorithmType, [WorkflowExpression] Func<languageInput> language = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GenerateToken";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["generateAlgorithmType"] = SourceExpressionConverter.Convert(generateAlgorithmType);
                callPayload.Queries["Language"] = Convert.ToString("English");
                if (language != null)
                    callPayload.Queries["Language"] = SourceExpressionConverter.Convert(language);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ParsePhoneGetResponse> ParsePhoneGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Parse/PhoneNumber";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["CountryIdentifier"] = SourceExpressionConverter.ConvertO(countryIdentifier);
                return callPayload;
            }

            return new ApiConnectionAction<ParsePhoneGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ParseEmailGetResponse> ParseEmailGet([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Parse/Email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<ParseEmailGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ParseURLGetResponse> ParseURLGet([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Parse/URL";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<ParseURLGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ScoringResponse> Scoring([WorkflowExpression] Func<inputInputItem2[]> input = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Scoring";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(input);
                return callPayload;
            }

            return new ApiConnectionAction<ScoringResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> TransformGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<entityTypeInput> entityType, [WorkflowExpression] Func<operationTypeInput> operationType, [WorkflowExpression] Func<languageInput> language = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Transform";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["EntityType"] = SourceExpressionConverter.Convert(entityType);
                callPayload.Queries["OperationType"] = SourceExpressionConverter.Convert(operationType);
                callPayload.Queries["Language"] = Convert.ToString("English");
                if (language != null)
                    callPayload.Queries["Language"] = SourceExpressionConverter.Convert(language);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SequenceTransformResponse> SequenceTransform([WorkflowExpression] Func<inputInputItem22[]> input = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SequenceTransform";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(input);
                return callPayload;
            }

            return new ApiConnectionAction<SequenceTransformResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> ValidateEmailGet([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Validate/Email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobalBool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> ValidatePostCodeGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Validate/PostCode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["CountryIdentifier"] = SourceExpressionConverter.ConvertO(countryIdentifier);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobalBool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> ValidateURLGet([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Validate/UrlAddress";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobalBool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> ValidatePhoneGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Validate/Telephone";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["CountryIdentifier"] = SourceExpressionConverter.ConvertO(countryIdentifier);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobalBool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> ValidateDateTimeGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> dateTimeFormat)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Validate/DateTime";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["DateTimeFormat"] = SourceExpressionConverter.ConvertO(dateTimeFormat);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobalBool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ValidatePlusEmailGetResponse> ValidatePlusEmailGet([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ValidatePlus/Email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<ValidatePlusEmailGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ValidatePlusPostCodeGetResponse> ValidatePlusPostCodeGet([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ValidatePlus/PostCode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["CountryIdentifier"] = SourceExpressionConverter.ConvertO(countryIdentifier);
                return callPayload;
            }

            return new ApiConnectionAction<ValidatePlusPostCodeGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<ValidatePlusURLGetResponse> ValidatePlusURLGet([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ValidatePlus/UrlAddress";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<ValidatePlusURLGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<VerifyAddressGetResponse> VerifyAddressGet([WorkflowExpression] Func<providerInput> provider, [WorkflowExpression] Func<string> countryIdentifier, [WorkflowExpression] Func<bool> geocode, [WorkflowExpression] Func<string> line1 = null, [WorkflowExpression] Func<string> line2 = null, [WorkflowExpression] Func<string> line3 = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> state = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Verify/Address/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (line1 != null)
                    callPayload.Queries["Line1"] = SourceExpressionConverter.ConvertO(line1);
                if (line2 != null)
                    callPayload.Queries["Line2"] = SourceExpressionConverter.ConvertO(line2);
                if (line3 != null)
                    callPayload.Queries["Line3"] = SourceExpressionConverter.ConvertO(line3);
                if (postalCode != null)
                    callPayload.Queries["PostalCode"] = SourceExpressionConverter.ConvertO(postalCode);
                if (city != null)
                    callPayload.Queries["City"] = SourceExpressionConverter.ConvertO(city);
                if (state != null)
                    callPayload.Queries["State"] = SourceExpressionConverter.ConvertO(state);
                callPayload.Queries["CountryIdentifier"] = SourceExpressionConverter.ConvertO(countryIdentifier);
                callPayload.Queries["Geocode"] = SourceExpressionConverter.ConvertO(geocode);
                return callPayload;
            }

            return new ApiConnectionAction<VerifyAddressGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SearchAddressFindResponse> SearchAddressFind([WorkflowExpression] Func<providerInput> provider, [WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> countryIdentifier)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Search/Address/Find/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                callPayload.Queries["CountryIdentifier"] = SourceExpressionConverter.ConvertO(countryIdentifier);
                return callPayload;
            }

            return new ApiConnectionAction<SearchAddressFindResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SearchAddressRetrieveResponse> SearchAddressRetrieve([WorkflowExpression] Func<providerInput> provider, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> countryIdentifier)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Search/Address/Retrieve/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Id"] = SourceExpressionConverter.ConvertO(id);
                callPayload.Queries["CountryIdentifier"] = SourceExpressionConverter.ConvertO(countryIdentifier);
                return callPayload;
            }

            return new ApiConnectionAction<SearchAddressRetrieveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SuppressDeceasedResponse> SuppressDeceased([WorkflowExpression] Func<providerInput> provider, [WorkflowExpression] Func<string> lastName, [WorkflowExpression] Func<string> postcode, [WorkflowExpression] Func<string> countryIdentifier, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> line1 = null, [WorkflowExpression] Func<string> line2 = null, [WorkflowExpression] Func<string> line3 = null, [WorkflowExpression] Func<string> town = null, [WorkflowExpression] Func<string> county = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Suppress/Address/Deceased/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (title != null)
                    callPayload.Queries["Title"] = SourceExpressionConverter.ConvertO(title);
                if (firstName != null)
                    callPayload.Queries["FirstName"] = SourceExpressionConverter.ConvertO(firstName);
                callPayload.Queries["LastName"] = SourceExpressionConverter.ConvertO(lastName);
                if (line1 != null)
                    callPayload.Queries["Line1"] = SourceExpressionConverter.ConvertO(line1);
                if (line2 != null)
                    callPayload.Queries["Line2"] = SourceExpressionConverter.ConvertO(line2);
                if (line3 != null)
                    callPayload.Queries["Line3"] = SourceExpressionConverter.ConvertO(line3);
                if (town != null)
                    callPayload.Queries["Town"] = SourceExpressionConverter.ConvertO(town);
                if (county != null)
                    callPayload.Queries["County"] = SourceExpressionConverter.ConvertO(county);
                callPayload.Queries["Postcode"] = SourceExpressionConverter.ConvertO(postcode);
                callPayload.Queries["CountryIdentifier"] = SourceExpressionConverter.ConvertO(countryIdentifier);
                return callPayload;
            }

            return new ApiConnectionAction<SuppressDeceasedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SuppressGoneAwayResponse> SuppressGoneAway([WorkflowExpression] Func<providerInput> provider, [WorkflowExpression] Func<string> lastName, [WorkflowExpression] Func<string> postcode, [WorkflowExpression] Func<string> iSO2, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> line1 = null, [WorkflowExpression] Func<string> line2 = null, [WorkflowExpression] Func<string> line3 = null, [WorkflowExpression] Func<string> town = null, [WorkflowExpression] Func<string> county = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Suppress/Address/GoneAway/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (title != null)
                    callPayload.Queries["Title"] = SourceExpressionConverter.ConvertO(title);
                if (firstName != null)
                    callPayload.Queries["FirstName"] = SourceExpressionConverter.ConvertO(firstName);
                callPayload.Queries["LastName"] = SourceExpressionConverter.ConvertO(lastName);
                if (line1 != null)
                    callPayload.Queries["Line1"] = SourceExpressionConverter.ConvertO(line1);
                if (line2 != null)
                    callPayload.Queries["Line2"] = SourceExpressionConverter.ConvertO(line2);
                if (line3 != null)
                    callPayload.Queries["Line3"] = SourceExpressionConverter.ConvertO(line3);
                if (town != null)
                    callPayload.Queries["Town"] = SourceExpressionConverter.ConvertO(town);
                if (county != null)
                    callPayload.Queries["County"] = SourceExpressionConverter.ConvertO(county);
                callPayload.Queries["Postcode"] = SourceExpressionConverter.ConvertO(postcode);
                callPayload.Queries["ISO2"] = SourceExpressionConverter.ConvertO(iSO2);
                return callPayload;
            }

            return new ApiConnectionAction<SuppressGoneAwayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SuppressRelocatedResponse> SuppressRelocated([WorkflowExpression] Func<providerInput> provider, [WorkflowExpression] Func<string> lastName, [WorkflowExpression] Func<string> postcode, [WorkflowExpression] Func<string> iSO2, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> line1 = null, [WorkflowExpression] Func<string> line2 = null, [WorkflowExpression] Func<string> line3 = null, [WorkflowExpression] Func<string> town = null, [WorkflowExpression] Func<string> county = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Suppress/Address/Relocated/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (title != null)
                    callPayload.Queries["Title"] = SourceExpressionConverter.ConvertO(title);
                if (firstName != null)
                    callPayload.Queries["FirstName"] = SourceExpressionConverter.ConvertO(firstName);
                callPayload.Queries["LastName"] = SourceExpressionConverter.ConvertO(lastName);
                if (line1 != null)
                    callPayload.Queries["Line1"] = SourceExpressionConverter.ConvertO(line1);
                if (line2 != null)
                    callPayload.Queries["Line2"] = SourceExpressionConverter.ConvertO(line2);
                if (line3 != null)
                    callPayload.Queries["Line3"] = SourceExpressionConverter.ConvertO(line3);
                if (town != null)
                    callPayload.Queries["Town"] = SourceExpressionConverter.ConvertO(town);
                if (county != null)
                    callPayload.Queries["County"] = SourceExpressionConverter.ConvertO(county);
                callPayload.Queries["Postcode"] = SourceExpressionConverter.ConvertO(postcode);
                callPayload.Queries["ISO2"] = SourceExpressionConverter.ConvertO(iSO2);
                return callPayload;
            }

            return new ApiConnectionAction<SuppressRelocatedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SuppressPhonePersonalResponse> SuppressPhonePersonal([WorkflowExpression] Func<providerInput> provider, [WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Suppress/Phone/Personal/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["CountryIdentifier"] = SourceExpressionConverter.ConvertO(countryIdentifier);
                return callPayload;
            }

            return new ApiConnectionAction<SuppressPhonePersonalResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<SuppressPhoneCorporateResponse> SuppressPhoneCorporate([WorkflowExpression] Func<providerInput> provider, [WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> countryIdentifier)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Suppress/Phone/Corporate/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["CountryIdentifier"] = SourceExpressionConverter.ConvertO(countryIdentifier);
                return callPayload;
            }

            return new ApiConnectionAction<SuppressPhoneCorporateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<AuthenticateEmailGetResponse> AuthenticateEmailGet([WorkflowExpression] Func<providerInput> provider, [WorkflowExpression] Func<string> email)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Authenticate/Email/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Email"] = SourceExpressionConverter.ConvertO(email);
                return callPayload;
            }

            return new ApiConnectionAction<AuthenticateEmailGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<AuthenticatePhoneGetResponse> AuthenticatePhoneGet([WorkflowExpression] Func<providerInput> provider, [WorkflowExpression] Func<string> phone, [WorkflowExpression] Func<string> countryIdentifier)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Authenticate/Phone/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Phone"] = SourceExpressionConverter.ConvertO(phone);
                callPayload.Queries["CountryIdentifier"] = SourceExpressionConverter.ConvertO(countryIdentifier);
                return callPayload;
            }

            return new ApiConnectionAction<AuthenticatePhoneGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsAllUpper([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/IsAllUpper";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobalBool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsAllLower([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/IsAllLower";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobalBool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsMixedCase([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/IsMixedCase";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobalBool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsAlphaNumeric([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/IsAlphaNumeric";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobalBool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsNumeric([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/IsNumeric";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobalBool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsISO4217([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/IsISO4217CurrencyCode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobalBool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsISO2([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/IsISO2Code";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobalBool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtIsISO3([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/IsISO3Code";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobalBool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtRemoveLeading([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> valToRemove, [WorkflowExpression] Func<bool> leaveOneAtStart)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/RemoveLeading";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["ValToRemove"] = SourceExpressionConverter.ConvertO(valToRemove);
                callPayload.Queries["LeaveOneAtStart"] = SourceExpressionConverter.ConvertO(leaveOneAtStart);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtRemoveChars([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<characterTypeInput> characterType)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/RemoveCharacters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["characterType"] = SourceExpressionConverter.Convert(characterType);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtRemoveSingleWords([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/RemoveSingleCharacterWords";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtReplaceRepeatingText([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> repeatingValue, [WorkflowExpression] Func<string> replacement)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/ReplaceAdjacentRepeatingText";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["RepeatingValue"] = SourceExpressionConverter.ConvertO(repeatingValue);
                callPayload.Queries["Replacement"] = SourceExpressionConverter.ConvertO(replacement);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtReplaceEndsWith([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> stringToReplace, [WorkflowExpression] Func<string> replacement)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/ReplaceIfEndsWith";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["stringToReplace"] = SourceExpressionConverter.ConvertO(stringToReplace);
                callPayload.Queries["replacement"] = SourceExpressionConverter.ConvertO(replacement);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtReplaceStartsWith([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> stringToReplace, [WorkflowExpression] Func<string> replacement)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/ReplaceIfStartsWith";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["stringToReplace"] = SourceExpressionConverter.ConvertO(stringToReplace);
                callPayload.Queries["replacement"] = SourceExpressionConverter.ConvertO(replacement);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtStringToBinary([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/StringToBinary";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtBinaryToString([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/BinaryToString";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtStringToHex([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/StringToHex";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtHexToString([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/HexToString";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtReverse([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/Reverse";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtNormWhiteSpace([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/NormalizeWhiteSpace";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtNormPhone([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/NormalizeAlphaNumericPhone";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtCollapseRepeatedChars([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<bool> collapseNumerics, [WorkflowExpression] Func<int> maximumRepeat = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/CollapseAdjacentRepeatedCharacters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["collapseNumerics"] = SourceExpressionConverter.ConvertO(collapseNumerics);
                if (maximumRepeat != null)
                    callPayload.Queries["maximumRepeat"] = SourceExpressionConverter.ConvertO(maximumRepeat);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtCollapseRepeatedType([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<int> maximumRepeat, [WorkflowExpression] Func<typeInput> type)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/CollapseAdjacentRepeatedType";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["MaximumRepeat"] = SourceExpressionConverter.ConvertO(maximumRepeat);
                callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtRemoveStopWords([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/FilterStopWords";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtRetainChars([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> replacement, [WorkflowExpression] Func<string> charactersToRetain)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/RetainCharacters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["replacement"] = SourceExpressionConverter.ConvertO(replacement);
                callPayload.Queries["charactersToRetain"] = SourceExpressionConverter.ConvertO(charactersToRetain);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtExtractChars([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<int> extractLength, [WorkflowExpression] Func<extractFromInput> extractFrom)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/ExtractCharacters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["extractLength"] = SourceExpressionConverter.ConvertO(extractLength);
                callPayload.Queries["extractFrom"] = SourceExpressionConverter.Convert(extractFrom);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtExtractWords([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<int> extractLength, [WorkflowExpression] Func<extractFromInput> extractFrom)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/ExtractWords";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["extractLength"] = SourceExpressionConverter.ConvertO(extractLength);
                callPayload.Queries["extractFrom"] = SourceExpressionConverter.Convert(extractFrom);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtRemoveHTML([WorkflowExpression] Func<string> input)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/RemoveHTML";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtEndsWith([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> checkfor)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/EndsWith";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["checkfor"] = SourceExpressionConverter.ConvertO(checkfor);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobalBool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtStartsWith([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> checkfor)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/StartsWith";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["checkfor"] = SourceExpressionConverter.ConvertO(checkfor);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobalBool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtEnsureEndsWith([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> checkFor)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/EnsureEndsWith";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["checkFor"] = SourceExpressionConverter.ConvertO(checkFor);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtEnsureStartEndsWith([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> checkFor)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/EnsureStartsAndEndsWith";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["checkFor"] = SourceExpressionConverter.ConvertO(checkFor);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobal> StringExtEnsureStartsWith([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<string> checkFor)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/EnsureStartsWith";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["checkFor"] = SourceExpressionConverter.ConvertO(checkFor);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtStartWithType([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<typeInput> type)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/StartsWithType";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobalBool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<DQGlobalBool> StringExtEndsWithType([WorkflowExpression] Func<string> input, [WorkflowExpression] Func<typeInput> type)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StringExtension/EndsWithType";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Input"] = SourceExpressionConverter.ConvertO(input);
                callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                return callPayload;
            }

            return new ApiConnectionAction<DQGlobalBool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dqondemand")]
        public IBodyWorkflowAction<GetUsageV2> UsageGet([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<summariseByInput> summariseBy = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Account/Usage/v2.0";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["StartDate"] = SourceExpressionConverter.ConvertO(startDate);
                callPayload.Queries["EndDate"] = SourceExpressionConverter.ConvertO(endDate);
                if (summariseBy != null)
                    callPayload.Queries["SummariseBy"] = SourceExpressionConverter.Convert(summariseBy);
                return callPayload;
            }

            return new ApiConnectionAction<GetUsageV2>(BuildSourceInput);
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