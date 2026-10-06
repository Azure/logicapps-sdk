//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Influenzandcovid19ip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Influenzandcovid19ipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetCOVID19totalsforallUSStatesResponseItem[]> GetCOVID19totalsforallUSStates([WorkflowExpression] Func<sortInput> sort = null, [WorkflowExpression] Func<bool> yesterday = null, [WorkflowExpression] Func<bool> allowNull = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/covid-19/states";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.Convert(sort);
                if (yesterday != null)
                    callPayload.Queries["yesterday"] = SourceExpressionConverter.ConvertO(yesterday);
                if (allowNull != null)
                    callPayload.Queries["allowNull"] = SourceExpressionConverter.ConvertO(allowNull);
                return callPayload;
            }

            return new ApiConnectionAction<GetCOVID19totalsforallUSStatesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetCOVID19totalsforspecificUSStatesResponse> GetCOVID19totalsforspecificUSStates([WorkflowExpression] Func<statesInput> states, [WorkflowExpression] Func<string> yesterday = null, [WorkflowExpression] Func<string> allowNull = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/covid-19/states/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(states, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (yesterday != null)
                    callPayload.Queries["yesterday"] = SourceExpressionConverter.ConvertO(yesterday);
                if (allowNull != null)
                    callPayload.Queries["allowNull"] = SourceExpressionConverter.ConvertO(allowNull);
                return callPayload;
            }

            return new ApiConnectionAction<GetCOVID19totalsforspecificUSStatesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetCOVID19totalsforallcontinentsResponseItem[]> GetCOVID19totalsforallcontinents([WorkflowExpression] Func<bool> yesterday = null, [WorkflowExpression] Func<bool> twoDaysAgo = null, [WorkflowExpression] Func<sortInput> sort = null, [WorkflowExpression] Func<bool> allowNull = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/covid-19/continents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (yesterday != null)
                    callPayload.Queries["yesterday"] = SourceExpressionConverter.ConvertO(yesterday);
                if (twoDaysAgo != null)
                    callPayload.Queries["twoDaysAgo"] = SourceExpressionConverter.ConvertO(twoDaysAgo);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.Convert(sort);
                if (allowNull != null)
                    callPayload.Queries["allowNull"] = SourceExpressionConverter.ConvertO(allowNull);
                return callPayload;
            }

            return new ApiConnectionAction<GetCOVID19totalsforallcontinentsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetCOVID19totalsforaspecificcontinentResponse> GetCOVID19totalsforaspecificcontinent([WorkflowExpression] Func<continentInput> continent, [WorkflowExpression] Func<string> yesterday = null, [WorkflowExpression] Func<string> twoDaysAgo = null, [WorkflowExpression] Func<string> strict = null, [WorkflowExpression] Func<string> allowNull = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/covid-19/continents/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(continent, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (yesterday != null)
                    callPayload.Queries["yesterday"] = SourceExpressionConverter.ConvertO(yesterday);
                if (twoDaysAgo != null)
                    callPayload.Queries["twoDaysAgo"] = SourceExpressionConverter.ConvertO(twoDaysAgo);
                if (strict != null)
                    callPayload.Queries["strict"] = SourceExpressionConverter.ConvertO(strict);
                if (allowNull != null)
                    callPayload.Queries["allowNull"] = SourceExpressionConverter.ConvertO(allowNull);
                return callPayload;
            }

            return new ApiConnectionAction<GetCOVID19totalsforaspecificcontinentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetCOVID19totalsforallcountriesResponseItem[]> GetCOVID19totalsforallcountries([WorkflowExpression] Func<string> yesterday = null, [WorkflowExpression] Func<string> twoDaysAgo = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> allowNull = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/covid-19/countries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (yesterday != null)
                    callPayload.Queries["yesterday"] = SourceExpressionConverter.ConvertO(yesterday);
                if (twoDaysAgo != null)
                    callPayload.Queries["twoDaysAgo"] = SourceExpressionConverter.ConvertO(twoDaysAgo);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (allowNull != null)
                    callPayload.Queries["allowNull"] = SourceExpressionConverter.ConvertO(allowNull);
                return callPayload;
            }

            return new ApiConnectionAction<GetCOVID19totalsforallcountriesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetCOVID19totalsforaspecificcountryResponse> GetCOVID19totalsforaspecificcountry([WorkflowExpression] Func<countryInput> country, [WorkflowExpression] Func<string> yesterday = null, [WorkflowExpression] Func<string> twoDaysAgo = null, [WorkflowExpression] Func<string> strict = null, [WorkflowExpression] Func<string> allowNull = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/covid-19/countries/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(country, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (yesterday != null)
                    callPayload.Queries["yesterday"] = SourceExpressionConverter.ConvertO(yesterday);
                if (twoDaysAgo != null)
                    callPayload.Queries["twoDaysAgo"] = SourceExpressionConverter.ConvertO(twoDaysAgo);
                if (strict != null)
                    callPayload.Queries["strict"] = SourceExpressionConverter.ConvertO(strict);
                if (allowNull != null)
                    callPayload.Queries["allowNull"] = SourceExpressionConverter.ConvertO(allowNull);
                return callPayload;
            }

            return new ApiConnectionAction<GetCOVID19totalsforaspecificcountryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetCOVID19totalsforallUScountiesResponseItem[]> GetCOVID19totalsforallUScounties()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/covid-19/jhucsse/counties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCOVID19totalsforallUScountiesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetCOVID19totalsforaspecificcountyResponseItem[]> GetCOVID19totalsforaspecificcounty([WorkflowExpression] Func<countyInput> county)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/covid-19/jhucsse/counties/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(county, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCOVID19totalsforaspecificcountyResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetCOVID19totalsforallcountriesandtheirprovincesResponseItem[]> GetCOVID19totalsforallcountriesandtheirprovinces()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/covid-19/jhucsse";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCOVID19totalsforallcountriesandtheirprovincesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetCOVID19timeseriesdataforaspecificcountryResponse> GetCOVID19timeseriesdataforaspecificcountry([WorkflowExpression] Func<countryInput> country, [WorkflowExpression] Func<string> lastdays = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/covid-19/historical/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(country, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastdays != null)
                    callPayload.Queries["lastdays"] = SourceExpressionConverter.ConvertO(lastdays);
                return callPayload;
            }

            return new ApiConnectionAction<GetCOVID19timeseriesdataforaspecificcountryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetCOVID19timeseriesdataforallcountiesinaspecifiedUSstateResponseItem[]> GetCOVID19timeseriesdataforallcountiesinaspecifiedUSstate([WorkflowExpression] Func<stateInput> state, [WorkflowExpression] Func<string> lastdays = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/covid-19/historical/usacounties/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(state, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastdays != null)
                    callPayload.Queries["lastdays"] = SourceExpressionConverter.ConvertO(lastdays);
                return callPayload;
            }

            return new ApiConnectionAction<GetCOVID19timeseriesdataforallcountiesinaspecifiedUSstateResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetCOVID19timeseriesdataforallcountriesandtheirprovincesResponseItem[]> GetCOVID19timeseriesdataforallcountriesandtheirprovinces([WorkflowExpression] Func<string> lastdays = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/covid-19/historical";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastdays != null)
                    callPayload.Queries["lastdays"] = SourceExpressionConverter.ConvertO(lastdays);
                return callPayload;
            }

            return new ApiConnectionAction<GetCOVID19timeseriesdataforallcountriesandtheirprovincesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetglobalaccumulatedCOVID19timeseriesdataResponse> GetglobalaccumulatedCOVID19timeseriesdata([WorkflowExpression] Func<string> lastdays = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/covid-19/historical/all";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastdays != null)
                    callPayload.Queries["lastdays"] = SourceExpressionConverter.ConvertO(lastdays);
                return callPayload;
            }

            return new ApiConnectionAction<GetglobalaccumulatedCOVID19timeseriesdataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetCOVID19timeseriesdataforallavailableUScountiesbeganResponseItem[]> GetCOVID19timeseriesdataforallavailableUScountiesbegan([WorkflowExpression] Func<int> lastdays = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/covid-19/nyt/counties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastdays != null)
                    callPayload.Queries["lastdays"] = SourceExpressionConverter.ConvertO(lastdays);
                return callPayload;
            }

            return new ApiConnectionAction<GetCOVID19timeseriesdataforallavailableUScountiesbeganResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetCOVID19timeseriesdataforsincethepandemicbeganResponseItem[]> GetCOVID19timeseriesdataforsincethepandemicbegan([WorkflowExpression] Func<countyInput> county, [WorkflowExpression] Func<string> lastdays = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/covid-19/nyt/counties/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(county, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastdays != null)
                    callPayload.Queries["lastdays"] = SourceExpressionConverter.ConvertO(lastdays);
                return callPayload;
            }

            return new ApiConnectionAction<GetCOVID19timeseriesdataforsincethepandemicbeganResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetCOVID19timeseriesdataforentireUSResponseItem[]> GetCOVID19timeseriesdataforentireUS()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/covid-19/nyt/usa";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCOVID19timeseriesdataforentireUSResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<string[]> Getalistofsupportedcountriesforgovernmentspecificdata()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/covid-19/gov/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetCOVID19governmentreporteddataforaspecificcountryResponseItem[]> GetCOVID19governmentreporteddataforaspecificcountry([WorkflowExpression] Func<countryInput> country, [WorkflowExpression] Func<string> allowNull = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/covid-19/gov/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(country, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (allowNull != null)
                    callPayload.Queries["allowNull"] = SourceExpressionConverter.ConvertO(allowNull);
                return callPayload;
            }

            return new ApiConnectionAction<GetCOVID19governmentreporteddataforaspecificcountryResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetCOVID19vaccinedosesforallcountriesResponseItem[]> GetCOVID19vaccinedosesforallcountries([WorkflowExpression] Func<string> lastdays = null, [WorkflowExpression] Func<string> fullData = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/covid-19/vaccine/coverage/countries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastdays != null)
                    callPayload.Queries["lastdays"] = SourceExpressionConverter.ConvertO(lastdays);
                if (fullData != null)
                    callPayload.Queries["fullData"] = SourceExpressionConverter.ConvertO(fullData);
                return callPayload;
            }

            return new ApiConnectionAction<GetCOVID19vaccinedosesforallcountriesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetCOVID19vaccinedoseforasinglecountryResponse> GetCOVID19vaccinedoseforasinglecountry([WorkflowExpression] Func<countryInput> country, [WorkflowExpression] Func<string> lastdays = null, [WorkflowExpression] Func<string> fullData = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/covid-19/vaccine/coverage/countries/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(country, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastdays != null)
                    callPayload.Queries["lastdays"] = SourceExpressionConverter.ConvertO(lastdays);
                if (fullData != null)
                    callPayload.Queries["fullData"] = SourceExpressionConverter.ConvertO(fullData);
                return callPayload;
            }

            return new ApiConnectionAction<GetCOVID19vaccinedoseforasinglecountryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetCOVID19vaccinedosesforallstatesResponseItem[]> GetCOVID19vaccinedosesforallstates([WorkflowExpression] Func<string> lastdays = null, [WorkflowExpression] Func<string> fullData = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/covid-19/vaccine/coverage/states";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastdays != null)
                    callPayload.Queries["lastdays"] = SourceExpressionConverter.ConvertO(lastdays);
                if (fullData != null)
                    callPayload.Queries["fullData"] = SourceExpressionConverter.ConvertO(fullData);
                return callPayload;
            }

            return new ApiConnectionAction<GetCOVID19vaccinedosesforallstatesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetCOVID19vaccinedoseforastateResponse> GetCOVID19vaccinedoseforastate([WorkflowExpression] Func<stateInput> state, [WorkflowExpression] Func<string> lastdays = null, [WorkflowExpression] Func<string> fullData = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/covid-19/vaccine/coverage/states/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(state, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastdays != null)
                    callPayload.Queries["lastdays"] = SourceExpressionConverter.ConvertO(lastdays);
                if (fullData != null)
                    callPayload.Queries["fullData"] = SourceExpressionConverter.ConvertO(fullData);
                return callPayload;
            }

            return new ApiConnectionAction<GetCOVID19vaccinedoseforastateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GettotalglobalCOVID19vaccinedosesResponse> GettotalglobalCOVID19vaccinedoses([WorkflowExpression] Func<string> lastdays = null, [WorkflowExpression] Func<string> fullData = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/covid-19/vaccine/coverage";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lastdays != null)
                    callPayload.Queries["lastdays"] = SourceExpressionConverter.ConvertO(lastdays);
                if (fullData != null)
                    callPayload.Queries["fullData"] = SourceExpressionConverter.ConvertO(fullData);
                return callPayload;
            }

            return new ApiConnectionAction<GettotalglobalCOVID19vaccinedosesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetvaccinetrialdatafromRAPSbyJeffCravenatResponse> GetvaccinetrialdatafromRAPSbyJeffCravenat()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/covid-19/vaccine";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetvaccinetrialdatafromRAPSbyJeffCravenatResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<string[]> GetalistofsupportedcountriesforECDCspecificdata()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/covid-19/variants/countries/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetglobalCOVID19totalsfortodayyesterdayandtwodaysagoResponse> GetglobalCOVID19totalsfortodayyesterdayandtwodaysago([WorkflowExpression] Func<string> yesterday = null, [WorkflowExpression] Func<string> twoDaysAgo = null, [WorkflowExpression] Func<string> allowNull = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/covid-19/all";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (yesterday != null)
                    callPayload.Queries["yesterday"] = SourceExpressionConverter.ConvertO(yesterday);
                if (twoDaysAgo != null)
                    callPayload.Queries["twoDaysAgo"] = SourceExpressionConverter.ConvertO(twoDaysAgo);
                if (allowNull != null)
                    callPayload.Queries["allowNull"] = SourceExpressionConverter.ConvertO(allowNull);
                return callPayload;
            }

            return new ApiConnectionAction<GetglobalCOVID19totalsfortodayyesterdayandtwodaysagoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GettherapeuticstrialdatafromRAPSbyJeffResponse> GettherapeuticstrialdatafromRAPSbyJeff()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/covid-19/therapeutics";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GettherapeuticstrialdatafromRAPSbyJeffResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetInfluenzalikeillnessfromtheUSCenterforDiseaseControlResponse> GetInfluenzalikeillnessfromtheUSCenterforDiseaseControl()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/influenza/cdc/ILINet";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetInfluenzalikeillnessfromtheUSCenterforDiseaseControlResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetInfluenzareportdatareportedbyUSclinicallabsResponse> GetInfluenzareportdatareportedbyUSclinicallabs()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/influenza/cdc/USCL";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetInfluenzareportdatareportedbyUSclinicallabsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "influenzandcovid19ip")]
        public IBodyWorkflowAction<GetInfluenzareportdatareportedbyUSpublichealthlabsResponse> GetInfluenzareportdatareportedbyUSpublichealthlabs()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/influenza/cdc/USPHL";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetInfluenzareportdatareportedbyUSpublichealthlabsResponse>(BuildSourceInput);
        }
    }

    public class Influenzandcovid19ipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetCOVID19totalsforallUSStatesResponseItem
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("cases")]
        public int Cases { get; set; }

        [JsonProperty("todayCases")]
        public int TodayCases { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("todayDeaths")]
        public int TodayDeaths { get; set; }

        [JsonProperty("recovered")]
        public int Recovered { get; set; }

        [JsonProperty("active")]
        public int Active { get; set; }

        [JsonProperty("casesPerOneMillion")]
        public int CasesPerOneMillion { get; set; }

        [JsonProperty("deathsPerOneMillion")]
        public int DeathsPerOneMillion { get; set; }

        [JsonProperty("tests")]
        public int Tests { get; set; }

        [JsonProperty("testsPerOneMillion")]
        public int TestsPerOneMillion { get; set; }

        [JsonProperty("population")]
        public int Population { get; set; }
    }

    public enum sortInput
    {
        [EnumMember(Value = "cases")]
        Cases,
        [EnumMember(Value = "todayCases")]
        TodayCases,
        [EnumMember(Value = "deaths")]
        Deaths,
        [EnumMember(Value = "recovered")]
        Recovered,
        [EnumMember(Value = "active")]
        Active
    }

    public class GetCOVID19totalsforspecificUSStatesResponse
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("cases")]
        public int Cases { get; set; }

        [JsonProperty("todayCases")]
        public int TodayCases { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("todayDeaths")]
        public int TodayDeaths { get; set; }

        [JsonProperty("recovered")]
        public int Recovered { get; set; }

        [JsonProperty("active")]
        public int Active { get; set; }

        [JsonProperty("casesPerOneMillion")]
        public int CasesPerOneMillion { get; set; }

        [JsonProperty("deathsPerOneMillion")]
        public int DeathsPerOneMillion { get; set; }

        [JsonProperty("tests")]
        public int Tests { get; set; }

        [JsonProperty("testsPerOneMillion")]
        public int TestsPerOneMillion { get; set; }

        [JsonProperty("population")]
        public int Population { get; set; }
    }

    public enum statesInput
    {
        [EnumMember(Value = "alabama")]
        Alabama,
        [EnumMember(Value = "alaska")]
        Alaska,
        [EnumMember(Value = "american samoa")]
        AmericanSamoa,
        [EnumMember(Value = "arizona")]
        Arizona,
        [EnumMember(Value = "arkansas")]
        Arkansas,
        [EnumMember(Value = "california")]
        California,
        [EnumMember(Value = "colorado")]
        Colorado,
        [EnumMember(Value = "connecticut")]
        Connecticut,
        [EnumMember(Value = "delaware")]
        Delaware,
        [EnumMember(Value = "diamond princess")]
        DiamondPrincess,
        [EnumMember(Value = "district of columbia")]
        DistrictOfColumbia,
        [EnumMember(Value = "florida")]
        Florida,
        [EnumMember(Value = "georgia")]
        Georgia,
        [EnumMember(Value = "grand princess")]
        GrandPrincess,
        [EnumMember(Value = "guam")]
        Guam,
        [EnumMember(Value = "hawaii")]
        Hawaii,
        [EnumMember(Value = "idaho")]
        Idaho,
        [EnumMember(Value = "illinois")]
        Illinois,
        [EnumMember(Value = "indiana")]
        Indiana,
        [EnumMember(Value = "iowa")]
        Iowa,
        [EnumMember(Value = "kansas")]
        Kansas,
        [EnumMember(Value = "kentucky")]
        Kentucky,
        [EnumMember(Value = "louisiana")]
        Louisiana,
        [EnumMember(Value = "maine")]
        Maine,
        [EnumMember(Value = "maryland")]
        Maryland,
        [EnumMember(Value = "massachusetts")]
        Massachusetts,
        [EnumMember(Value = "michigan")]
        Michigan,
        [EnumMember(Value = "minnesota")]
        Minnesota,
        [EnumMember(Value = "mississippi")]
        Mississippi,
        [EnumMember(Value = "missouri")]
        Missouri,
        [EnumMember(Value = "montana")]
        Montana,
        [EnumMember(Value = "nebraska")]
        Nebraska,
        [EnumMember(Value = "nevada")]
        Nevada,
        [EnumMember(Value = "new hampshire")]
        NewHampshire,
        [EnumMember(Value = "new jersey")]
        NewJersey,
        [EnumMember(Value = "new mexico")]
        NewMexico,
        [EnumMember(Value = "new york")]
        NewYork,
        [EnumMember(Value = "north carolina")]
        NorthCarolina,
        [EnumMember(Value = "north dakota")]
        NorthDakota,
        [EnumMember(Value = "northern mariana islands")]
        NorthernMarianaIslands,
        [EnumMember(Value = "ohio")]
        Ohio,
        [EnumMember(Value = "oklahoma")]
        Oklahoma,
        [EnumMember(Value = "oregon")]
        Oregon,
        [EnumMember(Value = "pennsylvania")]
        Pennsylvania,
        [EnumMember(Value = "puerto rico")]
        PuertoRico,
        [EnumMember(Value = "rhode island")]
        RhodeIsland,
        [EnumMember(Value = "south carolina")]
        SouthCarolina,
        [EnumMember(Value = "south dakota")]
        SouthDakota,
        [EnumMember(Value = "tennessee")]
        Tennessee,
        [EnumMember(Value = "texas")]
        Texas,
        [EnumMember(Value = "utah")]
        Utah,
        [EnumMember(Value = "vermont")]
        Vermont,
        [EnumMember(Value = "virgin islands")]
        VirginIslands,
        [EnumMember(Value = "virginia")]
        Virginia,
        [EnumMember(Value = "washington")]
        Washington,
        [EnumMember(Value = "west virginia")]
        WestVirginia,
        [EnumMember(Value = "wisconsin")]
        Wisconsin,
        [EnumMember(Value = "wyoming")]
        Wyoming
    }

    public class GetCOVID19totalsforallcontinentsResponseItem
    {
        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("cases")]
        public int Cases { get; set; }

        [JsonProperty("todayCases")]
        public int TodayCases { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("todayDeaths")]
        public int TodayDeaths { get; set; }

        [JsonProperty("recovered")]
        public int Recovered { get; set; }

        [JsonProperty("todayRecovered")]
        public int TodayRecovered { get; set; }

        [JsonProperty("active")]
        public int Active { get; set; }

        [JsonProperty("critical")]
        public int Critical { get; set; }

        [JsonProperty("casesPerOneMillion")]
        public double CasesPerOneMillion { get; set; }

        [JsonProperty("deathsPerOneMillion")]
        public double DeathsPerOneMillion { get; set; }

        [JsonProperty("tests")]
        public int Tests { get; set; }

        [JsonProperty("testsPerOneMillion")]
        public double TestsPerOneMillion { get; set; }

        [JsonProperty("population")]
        public int Population { get; set; }

        [JsonProperty("continent")]
        public string Continent { get; set; }

        [JsonProperty("activePerOneMillion")]
        public double ActivePerOneMillion { get; set; }

        [JsonProperty("recoveredPerOneMillion")]
        public double RecoveredPerOneMillion { get; set; }

        [JsonProperty("criticalPerOneMillion")]
        public double CriticalPerOneMillion { get; set; }

        [JsonProperty("continentInfo")]
        public GetCOVID19totalsforallcontinentsResponseItemContinentInfoType ContinentInfo { get; set; }

        [JsonProperty("countries")]
        public string[] Countries { get; set; }
    }

    public class GetCOVID19totalsforallcontinentsResponseItemContinentInfoType
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("long")]
        public double Long { get; set; }
    }

    public class GetCOVID19totalsforaspecificcontinentResponse
    {
        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("cases")]
        public int Cases { get; set; }

        [JsonProperty("todayCases")]
        public int TodayCases { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("todayDeaths")]
        public int TodayDeaths { get; set; }

        [JsonProperty("recovered")]
        public int Recovered { get; set; }

        [JsonProperty("todayRecovered")]
        public int TodayRecovered { get; set; }

        [JsonProperty("active")]
        public int Active { get; set; }

        [JsonProperty("critical")]
        public int Critical { get; set; }

        [JsonProperty("casesPerOneMillion")]
        public double CasesPerOneMillion { get; set; }

        [JsonProperty("deathsPerOneMillion")]
        public double DeathsPerOneMillion { get; set; }

        [JsonProperty("tests")]
        public int Tests { get; set; }

        [JsonProperty("testsPerOneMillion")]
        public double TestsPerOneMillion { get; set; }

        [JsonProperty("population")]
        public int Population { get; set; }

        [JsonProperty("continent")]
        public string Continent { get; set; }

        [JsonProperty("activePerOneMillion")]
        public double ActivePerOneMillion { get; set; }

        [JsonProperty("recoveredPerOneMillion")]
        public double RecoveredPerOneMillion { get; set; }

        [JsonProperty("criticalPerOneMillion")]
        public double CriticalPerOneMillion { get; set; }

        [JsonProperty("continentInfo")]
        public GetCOVID19totalsforaspecificcontinentResponseContinentInfoType ContinentInfo { get; set; }

        [JsonProperty("countries")]
        public string[] Countries { get; set; }
    }

    public class GetCOVID19totalsforaspecificcontinentResponseContinentInfoType
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("long")]
        public double Long { get; set; }
    }

    public enum continentInput
    {
        [EnumMember(Value = "North America")]
        NorthAmerica,
        Asia,
        Europe,
        [EnumMember(Value = "South America")]
        SouthAmerica,
        [EnumMember(Value = "Australia-Oceania")]
        AustraliaOceania,
        Africa
    }

    public class GetCOVID19totalsforallcountriesResponseItem
    {
        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryInfo")]
        public GetCOVID19totalsforallcountriesResponseItemCountryInfoType CountryInfo { get; set; }

        [JsonProperty("cases")]
        public int Cases { get; set; }

        [JsonProperty("todayCases")]
        public int TodayCases { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("todayDeaths")]
        public int TodayDeaths { get; set; }

        [JsonProperty("recovered")]
        public int Recovered { get; set; }

        [JsonProperty("todayRecovered")]
        public int TodayRecovered { get; set; }

        [JsonProperty("active")]
        public int Active { get; set; }

        [JsonProperty("critical")]
        public int Critical { get; set; }

        [JsonProperty("casesPerOneMillion")]
        public int CasesPerOneMillion { get; set; }

        [JsonProperty("deathsPerOneMillion")]
        public int DeathsPerOneMillion { get; set; }

        [JsonProperty("tests")]
        public int Tests { get; set; }

        [JsonProperty("testsPerOneMillion")]
        public int TestsPerOneMillion { get; set; }

        [JsonProperty("population")]
        public int Population { get; set; }

        [JsonProperty("continent")]
        public string Continent { get; set; }

        [JsonProperty("oneCasePerPeople")]
        public int OneCasePerPeople { get; set; }

        [JsonProperty("oneDeathPerPeople")]
        public int OneDeathPerPeople { get; set; }

        [JsonProperty("oneTestPerPeople")]
        public int OneTestPerPeople { get; set; }

        [JsonProperty("activePerOneMillion")]
        public double ActivePerOneMillion { get; set; }

        [JsonProperty("recoveredPerOneMillion")]
        public double RecoveredPerOneMillion { get; set; }

        [JsonProperty("criticalPerOneMillion")]
        public double CriticalPerOneMillion { get; set; }
    }

    public class GetCOVID19totalsforallcountriesResponseItemCountryInfoType
    {
        [JsonProperty("_id")]
        public int Id { get; set; }

        [JsonProperty("iso2")]
        public string Iso2 { get; set; }

        [JsonProperty("iso3")]
        public string Iso3 { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("long")]
        public double Long { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }
    }

    public class GetCOVID19totalsforaspecificcountryResponse
    {
        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryInfo")]
        public GetCOVID19totalsforaspecificcountryResponseCountryInfoType CountryInfo { get; set; }

        [JsonProperty("cases")]
        public int Cases { get; set; }

        [JsonProperty("todayCases")]
        public int TodayCases { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("todayDeaths")]
        public int TodayDeaths { get; set; }

        [JsonProperty("recovered")]
        public int Recovered { get; set; }

        [JsonProperty("todayRecovered")]
        public int TodayRecovered { get; set; }

        [JsonProperty("active")]
        public int Active { get; set; }

        [JsonProperty("critical")]
        public int Critical { get; set; }

        [JsonProperty("casesPerOneMillion")]
        public int CasesPerOneMillion { get; set; }

        [JsonProperty("deathsPerOneMillion")]
        public int DeathsPerOneMillion { get; set; }

        [JsonProperty("tests")]
        public int Tests { get; set; }

        [JsonProperty("testsPerOneMillion")]
        public int TestsPerOneMillion { get; set; }

        [JsonProperty("population")]
        public int Population { get; set; }

        [JsonProperty("continent")]
        public string Continent { get; set; }

        [JsonProperty("oneCasePerPeople")]
        public int OneCasePerPeople { get; set; }

        [JsonProperty("oneDeathPerPeople")]
        public int OneDeathPerPeople { get; set; }

        [JsonProperty("oneTestPerPeople")]
        public int OneTestPerPeople { get; set; }

        [JsonProperty("activePerOneMillion")]
        public double ActivePerOneMillion { get; set; }

        [JsonProperty("recoveredPerOneMillion")]
        public double RecoveredPerOneMillion { get; set; }

        [JsonProperty("criticalPerOneMillion")]
        public int CriticalPerOneMillion { get; set; }
    }

    public class GetCOVID19totalsforaspecificcountryResponseCountryInfoType
    {
        [JsonProperty("_id")]
        public int Id { get; set; }

        [JsonProperty("iso2")]
        public string Iso2 { get; set; }

        [JsonProperty("iso3")]
        public string Iso3 { get; set; }

        [JsonProperty("lat")]
        public int Lat { get; set; }

        [JsonProperty("long")]
        public int Long { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }
    }

    public enum countryInput
    {
        Afghanistan,
        Albania,
        Algeria,
        Andorra,
        Angola,
        Anguilla,
        [EnumMember(Value = "Antigua and Barbuda")]
        AntiguaAndBarbuda,
        Argentina,
        Armenia,
        Aruba,
        Australia,
        Austria,
        Azerbaijan,
        Bahamas,
        Bahrain,
        Bangladesh,
        Barbados,
        Belarus,
        Belgium,
        Belize,
        Benin,
        Bermuda,
        Bhutan,
        Bolivia,
        [EnumMember(Value = "Caribbean Netherlands")]
        CaribbeanNetherlands,
        Bosnia,
        Botswana,
        Brazil,
        [EnumMember(Value = "British Virgin Islands")]
        BritishVirginIslands,
        Brunei,
        Bulgaria,
        [EnumMember(Value = "Burkina Faso")]
        BurkinaFaso,
        Burundi,
        Cambodia,
        Cameroon,
        Canada,
        [EnumMember(Value = "Cabo Verde")]
        CaboVerde,
        [EnumMember(Value = "Cayman Islands")]
        CaymanIslands,
        [EnumMember(Value = "Central African Republic")]
        CentralAfricanRepublic,
        Chad,
        Chile,
        China,
        Colombia,
        Comoros,
        Congo,
        [EnumMember(Value = "Cook Islands")]
        CookIslands,
        [EnumMember(Value = "Costa Rica")]
        CostaRica,
        [EnumMember(Value = "Côte d'Ivoire")]
        CôteDIvoire,
        Croatia,
        Cuba,
        Curaçao,
        Cyprus,
        Czechia,
        DRC,
        Denmark,
        Djibouti,
        Dominica,
        [EnumMember(Value = "Dominican Republic")]
        DominicanRepublic,
        Ecuador,
        Egypt,
        [EnumMember(Value = "El Salvador")]
        ElSalvador,
        [EnumMember(Value = "Equatorial Guinea")]
        EquatorialGuinea,
        Estonia,
        Swaziland,
        Ethiopia,
        [EnumMember(Value = "Faroe Islands")]
        FaroeIslands,
        [EnumMember(Value = "Falkland Islands (Malvinas)")]
        FalklandIslandsMalvinas,
        Fiji,
        Finland,
        France,
        [EnumMember(Value = "French Polynesia")]
        FrenchPolynesia,
        Gabon,
        Gambia,
        Georgia,
        Germany,
        Ghana,
        Gibraltar,
        Greece,
        Greenland,
        Grenada,
        Guatemala,
        Guernsey,
        Guinea,
        [EnumMember(Value = "Guinea-Bissau")]
        GuineaBissau,
        Guyana,
        Haiti,
        Honduras,
        [EnumMember(Value = "Hong Kong")]
        HongKong,
        Hungary,
        Iceland,
        India,
        Indonesia,
        Iran,
        Iraq,
        Ireland,
        [EnumMember(Value = "Isle of Man")]
        IsleOfMan,
        Israel,
        Italy,
        Jamaica,
        Japan,
        [EnumMember(Value = "Channel Islands")]
        ChannelIslands,
        Jordan,
        Kazakhstan,
        Kenya,
        Kiribati,
        Kuwait,
        Kyrgyzstan,
        [EnumMember(Value = "Lao People's Democratic Republic")]
        LaoPeopleSDemocraticRepublic,
        Latvia,
        Lebanon,
        Lesotho,
        Liberia,
        [EnumMember(Value = "Libyan Arab Jamahiriya")]
        LibyanArabJamahiriya,
        Liechtenstein,
        Lithuania,
        Luxembourg,
        Macao,
        Madagascar,
        Malawi,
        Malaysia,
        Maldives,
        Mali,
        Malta,
        Mauritania,
        Mauritius,
        Mexico,
        Moldova,
        Monaco,
        Mongolia,
        Montenegro,
        Montserrat,
        Morocco,
        Mozambique,
        Myanmar,
        Namibia,
        Nauru,
        Nepal,
        Netherlands,
        [EnumMember(Value = "New Caledonia")]
        NewCaledonia,
        [EnumMember(Value = "New Zealand")]
        NewZealand,
        Nicaragua,
        Niger,
        Nigeria,
        Niue,
        Macedonia,
        Norway,
        Oman,
        Pakistan,
        Palestine,
        Panama,
        [EnumMember(Value = "Papua New Guinea")]
        PapuaNewGuinea,
        Paraguay,
        Peru,
        Philippines,
        Pitcairn,
        Poland,
        Portugal,
        Qatar,
        Romania,
        Russia,
        Rwanda,
        [EnumMember(Value = "Saint Helena")]
        SaintHelena,
        [EnumMember(Value = "Saint Kitts and Nevis")]
        SaintKittsAndNevis,
        [EnumMember(Value = "Saint Lucia")]
        SaintLucia,
        [EnumMember(Value = "Saint Vincent and the Grenadines")]
        SaintVincentAndTheGrenadines,
        Samoa,
        [EnumMember(Value = "San Marino")]
        SanMarino,
        [EnumMember(Value = "Sao Tome and Principe")]
        SaoTomeAndPrincipe,
        [EnumMember(Value = "Saudi Arabia")]
        SaudiArabia,
        Senegal,
        Serbia,
        Seychelles,
        [EnumMember(Value = "Sierra Leone")]
        SierraLeone,
        Singapore,
        [EnumMember(Value = "Sint Maarten")]
        SintMaarten,
        Slovakia,
        Slovenia,
        [EnumMember(Value = "Solomon Islands")]
        SolomonIslands,
        Somalia,
        [EnumMember(Value = "South Africa")]
        SouthAfrica,
        [EnumMember(Value = "S. Korea")]
        SKorea,
        [EnumMember(Value = "South Sudan")]
        SouthSudan,
        Spain,
        [EnumMember(Value = "Sri Lanka")]
        SriLanka,
        Sudan,
        Suriname,
        Sweden,
        Switzerland,
        [EnumMember(Value = "Syrian Arab Republic")]
        SyrianArabRepublic,
        Taiwan,
        Tajikistan,
        Tanzania,
        Thailand,
        [EnumMember(Value = "Timor-Leste")]
        TimorLeste,
        Togo,
        Tokelau,
        Tonga,
        [EnumMember(Value = "Trinidad and Tobago")]
        TrinidadAndTobago,
        Tunisia,
        Türkiye,
        Turkmenistan,
        [EnumMember(Value = "Turks and Caicos Islands")]
        TurksAndCaicosIslands,
        Tuvalu,
        Uganda,
        Ukraine,
        UAE,
        UK,
        USA,
        Uruguay,
        Uzbekistan,
        Vanuatu,
        Venezuela,
        Vietnam,
        [EnumMember(Value = "Wallis and Futuna")]
        WallisAndFutuna,
        Yemen,
        Zambia,
        Zimbabwe
    }

    public class GetCOVID19totalsforallUScountiesResponseItem
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("stats")]
        public GetCOVID19totalsforallUScountiesResponseItemStatsType Stats { get; set; }

        [JsonProperty("coordinates")]
        public GetCOVID19totalsforallUScountiesResponseItemCoordinatesType Coordinates { get; set; }
    }

    public class GetCOVID19totalsforallUScountiesResponseItemStatsType
    {
        [JsonProperty("confirmed")]
        public int Confirmed { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("recovered")]
        public string Recovered { get; set; }
    }

    public class GetCOVID19totalsforallUScountiesResponseItemCoordinatesType
    {
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    public class GetCOVID19totalsforaspecificcountyResponseItem
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("stats")]
        public GetCOVID19totalsforaspecificcountyResponseItemStatsType Stats { get; set; }

        [JsonProperty("coordinates")]
        public GetCOVID19totalsforaspecificcountyResponseItemCoordinatesType Coordinates { get; set; }
    }

    public class GetCOVID19totalsforaspecificcountyResponseItemStatsType
    {
        [JsonProperty("confirmed")]
        public int Confirmed { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("recovered")]
        public string Recovered { get; set; }
    }

    public class GetCOVID19totalsforaspecificcountyResponseItemCoordinatesType
    {
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    public enum countyInput
    {
        Abbeville,
        Acadia,
        Accomack,
        Ada,
        Adair,
        Adams,
        Addison,
        Aiken,
        Aitkin,
        Alachua,
        Alamance,
        Alameda,
        Alamosa,
        Albany,
        Albemarle,
        Alcona,
        Alcorn,
        [EnumMember(Value = "Aleutians East")]
        AleutiansEast,
        [EnumMember(Value = "Aleutians West")]
        AleutiansWest,
        Alexander,
        Alexandria,
        Alfalfa,
        Alger,
        Allamakee,
        Allegan,
        Allegany,
        Allen,
        Allendale,
        Alpena,
        Alpine,
        Amador,
        Amelia,
        Amherst,
        Amite,
        Anchorage,
        Anderson,
        Andrew,
        Androscoggin,
        Angelina,
        [EnumMember(Value = "Anne Arundel")]
        AnneArundel,
        Anoka,
        Anson,
        Antelope,
        Antrim,
        Apache,
        Appanoose,
        Bonner,
        Bonneville,
        Boone,
        Borden,
        Bosque,
        Bossier,
        Botetourt,
        Bottineau,
        Boulder,
        Boundary,
        Bourbon,
        Bowie,
        Bowman,
        [EnumMember(Value = "Box Butte")]
        BoxButte,
        [EnumMember(Value = "Box Elder")]
        BoxElder,
        Boyd,
        Boyle,
        Bracken,
        Bradford,
        Bradley,
        Branch,
        Brantley,
        Braxton,
        Brazoria,
        Brazos,
        Breathitt,
        Breckinridge,
        Bremer,
        Brevard,
        Brewster,
        Briscoe,
        [EnumMember(Value = "Bristol Bay")]
        BristolBay,
        Bristol,
        Broadwater,
        Bronx,
        Brooke,
        Brookings,
        Brooks,
        Broome,
        Broomfield,
        Broward,
        Brown,
        Brule,
        Brunswick,
        Bryan,
        Buchanan,
        Buckingham,
        Bucks,
        [EnumMember(Value = "Buena Vista")]
        BuenaVista,
        Buffalo,
        Bullitt,
        Bulloch,
        Bullock,
        Buncombe,
        Bureau,
        Burke,
        Burleigh,
        Burleson,
        Burlington,
        Burnet,
        Burt,
        Butler,
        Butte,
        Butts,
        Cabarrus,
        Cabell,
        Cache,
        Caddo,
        Calaveras,
        Calcasieu,
        Caldwell,
        Caledonia,
        Calhoun,
        Callahan,
        Callaway,
        Calumet,
        Calvert,
        Camas,
        Cambria,
        Cannon,
        Caribou,
        Carroll,
        [EnumMember(Value = "Carson City")]
        CarsonCity,
        Carson,
        Carter,
        Carteret,
        Carver,
        Cascade,
        Casey,
        Cass,
        Cassia,
        Castro,
        Caswell,
        Catahoula,
        Catawba,
        Catoosa,
        Catron,
        Cattaraugus,
        Cavalier,
        Cayuga,
        Cecil,
        Cedar,
        Centre,
        [EnumMember(Value = "Cerro Gordo")]
        CerroGordo,
        Chaffee,
        Chambers,
        Champaign,
        Chariton,
        [EnumMember(Value = "Charles City")]
        CharlesCity,
        [EnumMember(Value = "Charles Mix")]
        CharlesMix,
        Charles,
        Charleston,
        Charlevoix,
        Charlotte,
        Charlottesville,
        Charlton,
        Chase,
        Chatham,
        Chattahoochee,
        Chattooga,
        Chautauqua,
        Chaves,
        Cheatham,
        Cheboygan,
        Chelan,
        Chemung,
        Chenango,
        Cherokee,
        Cherry,
        Chesapeake,
        Cheshire,
        Chester,
        Chesterfield,
        Cheyenne,
        Chickasaw,
        Chicot,
        Childress,
        Chilton,
        Chippewa,
        Chisago,
        Chittenden,
        Choctaw,
        Chouteau,
        Chowan,
        Christian,
        Chugach,
        Churchill,
        Cibola,
        Cimarron,
        Citrus,
        Clackamas,
        Clallam,
        Clare,
        Clarendon,
        Clarion,
        Clark,
        Clarke,
        Clatsop,
        Clay,
        Clayton,
        [EnumMember(Value = "Clear Creek")]
        ClearCreek,
        Clearfield,
        Clearwater,
        Cleburne,
        Clermont,
        Cleveland,
        Clinch,
        Cloud,
        Coahoma,
        Coal,
        Cobb,
        Cochise,
        Cochran,
        Cocke,
        Coconino,
        Codington,
        Coffee,
        Coke,
        Colbert,
        Cole,
        Coleman,
        Coles,
        Colfax,
        Colleton,
        Collier,
        Collin,
        Collingsworth,
        [EnumMember(Value = "Colonial Heights")]
        ColonialHeights,
        Colorado,
        Colquitt,
        Columbia,
        Columbiana,
        Columbus,
        Colusa,
        Comal,
        Comanche,
        Concho,
        Concordia,
        Conecuh,
        Conejos,
        [EnumMember(Value = "Contra Costa")]
        ContraCosta,
        Converse,
        Conway,
        Cook,
        Cooke,
        Cooper,
        Coos,
        Coosa,
        Copiah,
        [EnumMember(Value = "Copper River")]
        CopperRiver,
        Corson,
        Cortland,
        Coryell,
        Coshocton,
        Costilla,
        Cottle,
        Cotton,
        Cottonwood,
        Covington,
        Coweta,
        Cowley,
        Cowlitz,
        Craig,
        Craighead,
        Crane,
        Craven,
        Crawford,
        Creek,
        Crenshaw,
        Crisp,
        Crittenden,
        Crockett,
        Crook,
        Crosby,
        Cross,
        [EnumMember(Value = "Crow Wing")]
        CrowWing,
        Crowley,
        Culberson,
        Cullman,
        Culpeper,
        Cumberland,
        Cuming,
        Currituck,
        Curry,
        Custer,
        Cuyahoga,
        Dade,
        Daggett,
        Dakota,
        Dale,
        Dallam,
        Dallas,
        Dane,
        Daniels,
        Danville,
        Dare,
        Darke,
        Darlington,
        Dauphin,
        Davidson,
        Davie,
        Daviess,
        Davis,
        Dawes,
        Dawson,
        Day,
        [EnumMember(Value = "De Baca")]
        DeBaca,
        [EnumMember(Value = "De Soto")]
        DeSoto,
        [EnumMember(Value = "De Witt")]
        DeWitt,
        [EnumMember(Value = "Deaf Smith")]
        DeafSmith,
        Dearborn,
        Decatur,
        [EnumMember(Value = "Deer Lodge")]
        DeerLodge,
        Defiance,
        DeKalb,
        [EnumMember(Value = "Del Norte")]
        DelNorte,
        Delaware,
        Delta,
        Denali,
        Dent,
        Denton,
        Denver,
        [EnumMember(Value = "Des Moines")]
        DesMoines,
        Deschutes,
        Desha,
        [EnumMember(Value = "DeSoto")]
        DeSoto2,
        Deuel,
        Dewey,
        [EnumMember(Value = "DeWitt")]
        DeWitt2,
        Dickens,
        Dickenson,
        Dickey,
        Dickinson,
        Dickson,
        Dillingham,
        Dillon,
        Dimmit,
        Dinwiddie,
        [EnumMember(Value = "District of Columbia")]
        DistrictOfColumbia,
        Divide,
        Dixie,
        Dixon,
        Doddridge,
        Dodge,
        Dolores,
        Doniphan,
        Donley,
        Dooly,
        Door,
        Dorchester,
        Dougherty,
        Douglas,
        Drew,
        Dubois,
        Dubuque,
        Duchesne,
        Dukes,
        Dundy,
        Dunklin,
        Dunn,
        DuPage,
        Duplin,
        Durham,
        Dutchess,
        Duval,
        Dyer,
        Eagle,
        Early,
        [EnumMember(Value = "East Baton Rouge")]
        EastBatonRouge,
        [EnumMember(Value = "East Carroll")]
        EastCarroll,
        [EnumMember(Value = "East Feliciana")]
        EastFeliciana,
        Eastland,
        Eaton,
        [EnumMember(Value = "Eau Claire")]
        EauClaire,
        Echols,
        Ector,
        Eddy,
        Edgar,
        Edgecombe,
        Edgefield,
        Edmonson,
        Edmunds,
        Edwards,
        Effingham,
        [EnumMember(Value = "El Dorado")]
        ElDorado,
        [EnumMember(Value = "El Paso")]
        ElPaso,
        Elbert,
        Elk,
        Elkhart,
        Elko,
        Elliott,
        Ellis,
        Ellsworth,
        Elmore,
        Emanuel,
        Emery,
        Emmet,
        Emmons,
        Emporia,
        Erath,
        Erie,
        Escambia,
        Esmeralda,
        Essex,
        Estill,
        Etowah,
        Eureka,
        Evangeline,
        Evans,
        [EnumMember(Value = "Fairbanks North Star")]
        FairbanksNorthStar,
        Fairfax,
        Fairfield,
        [EnumMember(Value = "Fall River")]
        FallRiver,
        Fallon,
        [EnumMember(Value = "Falls Church")]
        FallsChurch,
        Falls,
        Fannin,
        Faribault,
        Faulk,
        Faulkner,
        Fayette,
        Fentress,
        Fergus,
        Ferry,
        Fillmore,
        Finney,
        Fisher,
        Flagler,
        Flathead,
        Fleming,
        Florence,
        Floyd,
        Fluvanna,
        Foard,
        [EnumMember(Value = "Fond du Lac")]
        FondDuLac,
        Ford,
        Forest,
        Forsyth,
        [EnumMember(Value = "Fort Bend")]
        FortBend,
        Foster,
        Fountain,
        Franklin,
        Frederick,
        Fredericksburg,
        Freeborn,
        Freestone,
        Fremont,
        Fresno,
        Frio,
        Frontier,
        Fulton,
        Furnas,
        Gadsden,
        Gage,
        Gaines,
        Galax,
        Gallatin,
        Gallia,
        Galveston,
        Garden,
        Garfield,
        Garrett,
        Garvin,
        Garza,
        Gasconade,
        Gaston,
        Gates,
        Geary,
        Geauga,
        Gem,
        Genesee,
        Geneva,
        Gentry,
        George,
        Georgetown,
        Gibson,
        Gila,
        Gilchrist,
        Giles,
        Gillespie,
        Gilliam,
        Gilmer,
        Gilpin,
        Glacier,
        Glades,
        Gladwin,
        Glascock,
        Glenn,
        Gloucester,
        Glynn,
        Gogebic,
        [EnumMember(Value = "Golden Valley")]
        GoldenValley,
        Goliad,
        Gonzales,
        Goochland,
        Goodhue,
        Gooding,
        Gordon,
        Goshen,
        Gosper,
        Gove,
        Grady,
        Grafton,
        Graham,
        Grainger,
        [EnumMember(Value = "Grand Forks")]
        GrandForks,
        [EnumMember(Value = "Grand Isle")]
        GrandIsle,
        [EnumMember(Value = "Grand Traverse")]
        GrandTraverse,
        Grand,
        Granite,
        Grant,
        Granville,
        Gratiot,
        Graves,
        Gray,
        [EnumMember(Value = "Grays Harbor")]
        GraysHarbor,
        Grayson,
        Greeley,
        [EnumMember(Value = "Green Lake")]
        GreenLake,
        Green,
        Greenbrier,
        Greene,
        Greenlee,
        Greensville,
        Greenup,
        Greenville,
        Greenwood,
        Greer,
        Gregg,
        Gregory,
        Grenada,
        Griggs,
        Grimes,
        Grundy,
        Guadalupe,
        Guernsey,
        Guilford,
        Gulf,
        Gunnison,
        Guthrie,
        Gwinnett,
        Haakon,
        Habersham,
        Haines,
        Hale,
        Halifax,
        Hall,
        Hamblen,
        Hamilton,
        Hamlin,
        Hampden,
        Hampshire,
        Hampton,
        Hancock,
        Hand,
        Hanover,
        Hansford,
        Hanson,
        Haralson,
        Hardee,
        Hardeman,
        Hardin,
        Harding,
        Hardy,
        Harford,
        Harlan,
        Harmon,
        Harnett,
        Harney,
        Harper,
        Harris,
        Harrison,
        Harrisonburg,
        Hart,
        Hartford,
        Hartley,
        Harvey,
        Haskell,
        Hawaii,
        Hawkins,
        Hayes,
        Hays,
        Haywood,
        Heard,
        Hemphill,
        Hempstead,
        Henderson,
        Hendricks,
        Hendry,
        Hennepin,
        Henrico,
        Henry,
        Herkimer,
        Hernando,
        Hertford,
        Hettinger,
        Hickman,
        Hickory,
        Hidalgo,
        Highland,
        Highlands,
        Hill,
        Hillsborough,
        Hillsdale,
        Hinds,
        Hinsdale,
        Hitchcock,
        Hocking,
        Hockley,
        Hodgeman,
        Hoke,
        Holmes,
        Holt,
        Honolulu,
        [EnumMember(Value = "Hood River")]
        HoodRiver,
        Hood,
        Hooker,
        [EnumMember(Value = "Hoonah-Angoon")]
        HoonahAngoon,
        Hopewell,
        Hopkins,
        Horry,
        [EnumMember(Value = "Hot Spring")]
        HotSpring,
        Houghton,
        Houston,
        Howard,
        Howell,
        Hubbard,
        Hudson,
        Hudspeth,
        Huerfano,
        Hughes,
        Humboldt,
        Humphreys,
        Hunt,
        Hunterdon,
        Huntingdon,
        Huron,
        Hutchinson,
        Hyde,
        Iberia,
        Iberville,
        Ida,
        Idaho,
        Imperial,
        Independence,
        [EnumMember(Value = "Indian River")]
        IndianRiver,
        Indiana,
        Ingham,
        Inyo,
        Ionia,
        Iosco,
        Iowa,
        Iredell,
        Irion,
        Iron,
        Iroquois,
        Irwin,
        Isabella,
        Isanti,
        Island,
        [EnumMember(Value = "Isle of Wight")]
        IsleOfWight,
        Issaquena,
        Itasca,
        Itawamba,
        Izard,
        Jack,
        Jackson,
        [EnumMember(Value = "James City")]
        JamesCity,
        Jasper,
        Jay,
        [EnumMember(Value = "Jeff Davis")]
        JeffDavis,
        [EnumMember(Value = "Jefferson Davis")]
        JeffersonDavis,
        Jefferson,
        Jenkins,
        Jennings,
        Jerauld,
        Jerome,
        Jersey,
        Jessamine,
        Jewell,
        [EnumMember(Value = "Jim Hogg")]
        JimHogg,
        [EnumMember(Value = "Jim Wells")]
        JimWells,
        [EnumMember(Value = "Jo Daviess")]
        JoDaviess,
        Johnson,
        Johnston,
        Jones,
        Josephine,
        Juab,
        [EnumMember(Value = "Judith Basin")]
        JudithBasin,
        Juneau,
        Juniata,
        Kalamazoo,
        Kalawao,
        Kalkaska,
        Kanabec,
        Kanawha,
        Kandiyohi,
        Kane,
        Kankakee,
        Karnes,
        Kauai,
        Kaufman,
        Kay,
        Kearney,
        Kearny,
        Keith,
        Kemper,
        [EnumMember(Value = "Kenai Peninsula")]
        KenaiPeninsula,
        Kendall,
        Kenedy,
        Kennebec,
        Kenosha,
        Kent,
        Kenton,
        Keokuk,
        Kern,
        Kerr,
        Kershaw,
        [EnumMember(Value = "Ketchikan Gateway")]
        KetchikanGateway,
        Kewaunee,
        Keweenaw,
        [EnumMember(Value = "Keya Paha")]
        KeyaPaha,
        Kidder,
        Kimball,
        Kimble,
        [EnumMember(Value = "King and Queen")]
        KingAndQueen,
        [EnumMember(Value = "King George")]
        KingGeorge,
        [EnumMember(Value = "King William")]
        KingWilliam,
        King,
        Kingfisher,
        Kingman,
        Kings,
        Kingsbury,
        Kinney,
        Kiowa,
        [EnumMember(Value = "Kit Carson")]
        KitCarson,
        Kitsap,
        Kittitas,
        Kittson,
        Klamath,
        Kleberg,
        Klickitat,
        Knott,
        Knox,
        [EnumMember(Value = "Kodiak Island")]
        KodiakIsland,
        Koochiching,
        Kootenai,
        Kosciusko,
        Kossuth,
        Kusilvak,
        [EnumMember(Value = "La Crosse")]
        LaCrosse,
        [EnumMember(Value = "La Paz")]
        LaPaz,
        [EnumMember(Value = "La Plata")]
        LaPlata,
        [EnumMember(Value = "La Salle")]
        LaSalle,
        Labette,
        [EnumMember(Value = "Lac qui Parle")]
        LacQuiParle,
        Lackawanna,
        Laclede,
        Lafayette,
        Lafourche,
        LaGrange,
        [EnumMember(Value = "Lake and Peninsula")]
        LakeAndPeninsula,
        [EnumMember(Value = "Lake of the Woods")]
        LakeOfTheWoods,
        Lake,
        Lamar,
        Lamb,
        Lamoille,
        LaMoure,
        Lampasas,
        Lancaster,
        Lander,
        Lane,
        Langlade,
        Lanier,
        Lapeer,
        LaPorte,
        Laramie,
        Larimer,
        Larue,
        [EnumMember(Value = "Las Animas")]
        LasAnimas,
        [EnumMember(Value = "LaSalle")]
        LaSalle2,
        Lassen,
        Latah,
        Latimer,
        Lauderdale,
        Laurel,
        Laurens,
        Lavaca,
        Lawrence,
        [EnumMember(Value = "Le Flore")]
        LeFlore,
        [EnumMember(Value = "Le Sueur")]
        LeSueur,
        Lea,
        Leake,
        Leavenworth,
        Lebanon,
        Lee,
        Leelanau,
        Leflore,
        Lehigh,
        Lemhi,
        Lenawee,
        Lenoir,
        Leon,
        Leslie,
        Letcher,
        Levy,
        [EnumMember(Value = "Lewis and Clark")]
        LewisAndClark,
        Lewis,
        Lexington,
        Liberty,
        Licking,
        Limestone,
        Lincoln,
        Linn,
        Lipscomb,
        Litchfield,
        [EnumMember(Value = "Little River")]
        LittleRiver,
        [EnumMember(Value = "Live Oak")]
        LiveOak,
        Livingston,
        Llano,
        Logan,
        Long,
        Lonoke,
        Lorain,
        [EnumMember(Value = "Los Alamos")]
        LosAlamos,
        [EnumMember(Value = "Los Angeles")]
        LosAngeles,
        Loudon,
        Loudoun,
        Louisa,
        Loup,
        Love,
        Loving,
        Lowndes,
        Lubbock,
        Lucas,
        Luce,
        Lumpkin,
        Luna,
        Lunenburg,
        Luzerne,
        Lycoming,
        Lyman,
        Lynchburg,
        Lynn,
        Mackinac,
        Macomb,
        Macon,
        Macoupin,
        Madera,
        Madison,
        Magoffin,
        Mahaska,
        Mahnomen,
        Mahoning,
        Major,
        Malheur,
        [EnumMember(Value = "Manassas Park")]
        ManassasPark,
        Manassas,
        Manatee,
        Manistee,
        Manitowoc,
        Marathon,
        Marengo,
        Maricopa,
        Maries,
        Marin,
        Marinette,
        Marion,
        Mariposa,
        Marlboro,
        Marquette,
        Marshall,
        Martin,
        Martinsville,
        Mason,
        Massac,
        Matagorda,
        [EnumMember(Value = "Matanuska-Susitna")]
        MatanuskaSusitna,
        Mathews,
        Maui,
        Maury,
        Maverick,
        Mayes,
        McClain,
        McCone,
        McCook,
        McCormick,
        McCracken,
        McCreary,
        McCulloch,
        McCurtain,
        McDonald,
        McDonough,
        McDowell,
        McDuffie,
        McHenry,
        McIntosh,
        McKean,
        McKenzie,
        McKinley,
        McLean,
        McLennan,
        McLeod,
        McMinn,
        McMullen,
        McNairy,
        McPherson,
        Meade,
        Meagher,
        Mecklenburg,
        Mecosta,
        Medina,
        Meeker,
        Meigs,
        Mellette,
        Menard,
        Mendocino,
        Menifee,
        Menominee,
        Merced,
        Mercer,
        Meriwether,
        Merrick,
        Merrimack,
        Mesa,
        Metcalfe,
        Miami,
        [EnumMember(Value = "Miami-Dade")]
        MiamiDade,
        Middlesex,
        Midland,
        Mifflin,
        Milam,
        Millard,
        [EnumMember(Value = "Mille Lacs")]
        MilleLacs,
        Miller,
        Mills,
        Milwaukee,
        Miner,
        Mingo,
        Minidoka,
        Minnehaha,
        Missaukee,
        Mississippi,
        Missoula,
        Mitchell,
        Mobile,
        Modoc,
        Moffat,
        Mohave,
        Moniteau,
        Monmouth,
        Mono,
        Monona,
        Monongalia,
        Monroe,
        Montague,
        Montcalm,
        Monterey,
        Montezuma,
        Montgomery,
        Montmorency,
        Montour,
        Montrose,
        Moody,
        Moore,
        Mora,
        Morehouse,
        Morgan,
        Morrill,
        Morris,
        Morrison,
        Morrow,
        Morton,
        Motley,
        Moultrie,
        Mountrail,
        Mower,
        Muhlenberg,
        Multnomah,
        Murray,
        Muscatine,
        Muscogee,
        Muskegon,
        Muskingum,
        Muskogee,
        Musselshell,
        Nacogdoches,
        Nance,
        Nantucket,
        Napa,
        Nash,
        Nassau,
        Natchitoches,
        Natrona,
        Navajo,
        Navarro,
        Nelson,
        Nemaha,
        Neosho,
        Neshoba,
        Ness,
        Nevada,
        [EnumMember(Value = "New Castle")]
        NewCastle,
        [EnumMember(Value = "New Hanover")]
        NewHanover,
        [EnumMember(Value = "New Haven")]
        NewHaven,
        [EnumMember(Value = "New Kent")]
        NewKent,
        [EnumMember(Value = "New London")]
        NewLondon,
        [EnumMember(Value = "New Madrid")]
        NewMadrid,
        [EnumMember(Value = "New York")]
        NewYork,
        Newaygo,
        Newberry,
        [EnumMember(Value = "Newport News")]
        NewportNews,
        Newport,
        Newton,
        [EnumMember(Value = "Nez Perce")]
        NezPerce,
        Niagara,
        Nicholas,
        Nicollet,
        Niobrara,
        Noble,
        Nodaway,
        Nolan,
        Nome,
        Norfolk,
        Norman,
        [EnumMember(Value = "North Slope")]
        NorthSlope,
        Northampton,
        Northumberland,
        [EnumMember(Value = "Northwest Arctic")]
        NorthwestArctic,
        Norton,
        Nottoway,
        Nowata,
        Noxubee,
        Nuckolls,
        Nueces,
        Nye,
        Oakland,
        Obion,
        [EnumMember(Value = "O'Brien")]
        OBrien,
        Ocean,
        Oceana,
        Ochiltree,
        Oconto,
        Ogemaw,
        [EnumMember(Value = "Oglala Lakota")]
        OglalaLakota,
        Ogle,
        Oglethorpe,
        Ohio,
        Okaloosa,
        Okanogan,
        Okeechobee,
        Okfuskee,
        Oklahoma,
        Okmulgee,
        Oktibbeha,
        Oldham,
        Oliver,
        Olmsted,
        Oneida,
        Onondaga,
        Onslow,
        Ontario,
        Ontonagon,
        Orange,
        Orangeburg,
        Oregon,
        Orleans,
        Osage,
        Osborne,
        Osceola,
        Oscoda,
        Oswego,
        Otero,
        Otsego,
        Ottawa,
        [EnumMember(Value = "Otter Tail")]
        OtterTail,
        Ouachita,
        Ouray,
        Outagamie,
        Overton,
        Owen,
        Owsley,
        Owyhee,
        Oxford,
        Ozark,
        Ozaukee,
        Pacific,
        Page,
        [EnumMember(Value = "Palm Beach")]
        PalmBeach,
        [EnumMember(Value = "Palo Alto")]
        PaloAlto,
        [EnumMember(Value = "Palo Pinto")]
        PaloPinto,
        Pamlico,
        Panola,
        Park,
        Parke,
        Parker,
        Parmer,
        Pasco,
        Pasquotank,
        Passaic,
        Patrick,
        Paulding,
        Pawnee,
        Payette,
        Payne,
        Peach,
        [EnumMember(Value = "Pearl River")]
        PearlRiver,
        Pecos,
        Pembina,
        Pemiscot,
        [EnumMember(Value = "Pend Oreille")]
        PendOreille,
        Pender,
        Pendleton,
        Pennington,
        Penobscot,
        Peoria,
        Pepin,
        Perkins,
        Perquimans,
        Perry,
        Pershing,
        Person,
        Petersburg,
        Petroleum,
        Pettis,
        Phelps,
        Philadelphia,
        Phillips,
        Piatt,
        Pickaway,
        Pickens,
        Pickett,
        Pierce,
        Pike,
        Pima,
        Pinal,
        Pine,
        Pinellas,
        Pipestone,
        Piscataquis,
        Pitkin,
        Pitt,
        Pittsburg,
        Pittsylvania,
        Piute,
        Placer,
        Plaquemines,
        Platte,
        Pleasants,
        Plumas,
        Plymouth,
        Pocahontas,
        Poinsett,
        [EnumMember(Value = "Pointe Coupee")]
        PointeCoupee,
        Polk,
        Pondera,
        Pontotoc,
        Pope,
        Poquoson,
        Portage,
        Porter,
        Portsmouth,
        Posey,
        Pottawatomie,
        Potter,
        [EnumMember(Value = "Powder River")]
        PowderRiver,
        Powell,
        Power,
        Poweshiek,
        Powhatan,
        Prairie,
        Pratt,
        Preble,
        Prentiss,
        Presidio,
        [EnumMember(Value = "Presque Isle")]
        PresqueIsle,
        Preston,
        Price,
        [EnumMember(Value = "Prince Edward")]
        PrinceEdward,
        [EnumMember(Value = "Prince George")]
        PrinceGeorge,
        [EnumMember(Value = "Prince George's")]
        PrinceGeorgeS,
        [EnumMember(Value = "Prince of Wales-Hyder")]
        PrinceOfWalesHyder,
        [EnumMember(Value = "Prince William")]
        PrinceWilliam,
        Providence,
        Prowers,
        Pueblo,
        Pulaski,
        Pushmataha,
        Putnam,
        Quay,
        [EnumMember(Value = "Queen Anne's")]
        QueenAnneS,
        Queens,
        Quitman,
        Rabun,
        Racine,
        Radford,
        Rains,
        Raleigh,
        Ralls,
        Ramsey,
        Randall,
        Randolph,
        Rankin,
        Ransom,
        Rapides,
        Rappahannock,
        Ravalli,
        Rawlins,
        Ray,
        Reagan,
        Real,
        [EnumMember(Value = "Red Lake")]
        RedLake,
        [EnumMember(Value = "Red River")]
        RedRiver,
        [EnumMember(Value = "Red Willow")]
        RedWillow,
        Redwood,
        Reeves,
        Refugio,
        Reno,
        Rensselaer,
        Renville,
        Reynolds,
        Rhea,
        Rich,
        Richardson,
        Richland,
        Richmond,
        Riley,
        Ringgold,
        [EnumMember(Value = "Rio Arriba")]
        RioArriba,
        [EnumMember(Value = "Rio Blanco")]
        RioBlanco,
        [EnumMember(Value = "Rio Grande")]
        RioGrande,
        Ripley,
        Ritchie,
        Riverside,
        Roane,
        Roanoke,
        Roberts,
        Robertson,
        Robeson,
        [EnumMember(Value = "Rock Island")]
        RockIsland,
        Rock,
        Rockbridge,
        Rockcastle,
        Rockdale,
        Rockingham,
        Rockland,
        Rockwall,
        [EnumMember(Value = "Roger Mills")]
        RogerMills,
        Rogers,
        Rolette,
        Rooks,
        Roosevelt,
        Roscommon,
        Roseau,
        Rosebud,
        Ross,
        Routt,
        Rowan,
        Runnels,
        Rush,
        Rusk,
        Russell,
        Rutherford,
        Rutland,
        Sabine,
        Sac,
        Sacramento,
        Sagadahoc,
        Saginaw,
        Saguache,
        Salem,
        Saline,
        [EnumMember(Value = "Salt Lake")]
        SaltLake,
        Saluda,
        Sampson,
        [EnumMember(Value = "San Augustine")]
        SanAugustine,
        [EnumMember(Value = "San Benito")]
        SanBenito,
        [EnumMember(Value = "San Bernardino")]
        SanBernardino,
        [EnumMember(Value = "San Diego")]
        SanDiego,
        [EnumMember(Value = "San Francisco")]
        SanFrancisco,
        [EnumMember(Value = "San Jacinto")]
        SanJacinto,
        [EnumMember(Value = "San Joaquin")]
        SanJoaquin,
        [EnumMember(Value = "San Juan")]
        SanJuan,
        [EnumMember(Value = "San Luis Obispo")]
        SanLuisObispo,
        [EnumMember(Value = "San Mateo")]
        SanMateo,
        [EnumMember(Value = "San Miguel")]
        SanMiguel,
        [EnumMember(Value = "San Patricio")]
        SanPatricio,
        [EnumMember(Value = "San Saba")]
        SanSaba,
        Sanborn,
        Sanders,
        Sandoval,
        Sandusky,
        Sangamon,
        Sanilac,
        Sanpete,
        [EnumMember(Value = "Santa Barbara")]
        SantaBarbara,
        [EnumMember(Value = "Santa Clara")]
        SantaClara,
        [EnumMember(Value = "Santa Cruz")]
        SantaCruz,
        [EnumMember(Value = "Santa Fe")]
        SantaFe,
        [EnumMember(Value = "Santa Rosa")]
        SantaRosa,
        Sarasota,
        Saratoga,
        Sargent,
        Sarpy,
        Sauk,
        Saunders,
        Sawyer,
        Schenectady,
        Schleicher,
        Schley,
        Schoharie,
        Schoolcraft,
        Schuyler,
        Schuylkill,
        Scioto,
        Scotland,
        Scott,
        [EnumMember(Value = "Scotts Bluff")]
        ScottsBluff,
        Screven,
        Scurry,
        Searcy,
        Sebastian,
        Sedgwick,
        Seminole,
        Seneca,
        Sequatchie,
        Sequoyah,
        Sevier,
        Seward,
        Shackelford,
        Shannon,
        Sharkey,
        Sharp,
        Shasta,
        Shawano,
        Shawnee,
        Sheboygan,
        Shelby,
        Shenandoah,
        Sherburne,
        Sheridan,
        Sherman,
        Shiawassee,
        Shoshone,
        Sibley,
        Sierra,
        [EnumMember(Value = "Silver Bow")]
        SilverBow,
        Simpson,
        Sioux,
        Siskiyou,
        Sitka,
        Skagit,
        Skagway,
        Skamania,
        Slope,
        Smith,
        Smyth,
        Snohomish,
        Snyder,
        Socorro,
        Solano,
        Somerset,
        Somervell,
        Sonoma,
        Southampton,
        [EnumMember(Value = "Southeast Fairbanks")]
        SoutheastFairbanks,
        Spalding,
        Spartanburg,
        Spencer,
        Spink,
        Spokane,
        Spotsylvania,
        [EnumMember(Value = "St. Bernard")]
        StBernard,
        [EnumMember(Value = "St. Charles")]
        StCharles,
        [EnumMember(Value = "St. Clair")]
        StClair,
        [EnumMember(Value = "St. Croix")]
        StCroix,
        [EnumMember(Value = "St. Francis")]
        StFrancis,
        [EnumMember(Value = "St. Francois")]
        StFrancois,
        [EnumMember(Value = "St. Helena")]
        StHelena,
        [EnumMember(Value = "St. James")]
        StJames,
        [EnumMember(Value = "St. John the Baptist")]
        StJohnTheBaptist,
        [EnumMember(Value = "St. Johns")]
        StJohns,
        [EnumMember(Value = "St. Joseph")]
        StJoseph,
        [EnumMember(Value = "St. Landry")]
        StLandry,
        [EnumMember(Value = "St. Lawrence")]
        StLawrence,
        [EnumMember(Value = "St. Louis")]
        StLouis,
        [EnumMember(Value = "St. Lucie")]
        StLucie,
        [EnumMember(Value = "St. Martin")]
        StMartin,
        [EnumMember(Value = "St. Mary")]
        StMary,
        [EnumMember(Value = "St. Mary's")]
        StMaryS,
        [EnumMember(Value = "St. Tammany")]
        StTammany,
        Stafford,
        Stanislaus,
        Stanley,
        Stanly,
        Stanton,
        Stark,
        Starke,
        Starr,
        Staunton,
        [EnumMember(Value = "Ste. Genevieve")]
        SteGenevieve,
        Stearns,
        Steele,
        Stephens,
        Stephenson,
        Sterling,
        Steuben,
        Stevens,
        Stewart,
        Stillwater,
        Stoddard,
        Stokes,
        Stone,
        Stonewall,
        Storey,
        Story,
        Strafford,
        Stutsman,
        Sublette,
        Suffolk,
        Sullivan,
        Sully,
        Summers,
        Summit,
        Sumner,
        Sumter,
        Sunflower,
        Surry,
        Susquehanna,
        Sussex,
        Sutter,
        Sutton,
        Suwannee,
        Swain,
        [EnumMember(Value = "Sweet Grass")]
        SweetGrass,
        Sweetwater,
        Swift,
        Swisher,
        Switzerland,
        Talbot,
        Taliaferro,
        Talladega,
        Tallahatchie,
        Tallapoosa,
        Tama,
        Taney,
        Tangipahoa,
        Taos,
        Tarrant,
        Tate,
        Tattnall,
        Taylor,
        Tazewell,
        Tehama,
        Telfair,
        Teller,
        Tensas,
        Terrebonne,
        Terrell,
        Terry,
        Teton,
        Texas,
        Thayer,
        Thomas,
        Throckmorton,
        Thurston,
        Tift,
        Tillamook,
        Tillman,
        Tioga,
        Tippah,
        Tippecanoe,
        Tipton,
        Tishomingo,
        Titus,
        Todd,
        Tolland,
        [EnumMember(Value = "Tom Green")]
        TomGreen,
        Tompkins,
        Tooele,
        Toole,
        Toombs,
        Torrance,
        Towner,
        Towns,
        Traill,
        Transylvania,
        Traverse,
        Travis,
        Treasure,
        Trego,
        Trempealeau,
        Treutlen,
        Trigg,
        Trimble,
        Trinity,
        Tripp,
        Troup,
        Trousdale,
        Trumbull,
        Tucker,
        Tulare,
        Tulsa,
        Tunica,
        Tuolumne,
        Turner,
        Tuscaloosa,
        Tuscarawas,
        Tuscola,
        Twiggs,
        [EnumMember(Value = "Twin Falls")]
        TwinFalls,
        Tyler,
        Tyrrell,
        Uinta,
        Uintah,
        Ulster,
        Umatilla,
        Unicoi,
        Union,
        Upshur,
        Upson,
        Upton,
        Utah,
        Uvalde,
        [EnumMember(Value = "Val Verde")]
        ValVerde,
        Valencia,
        Valley,
        [EnumMember(Value = "Van Buren")]
        VanBuren,
        [EnumMember(Value = "Van Wert")]
        VanWert,
        [EnumMember(Value = "Van Zandt")]
        VanZandt,
        Vance,
        Vanderburgh,
        Venango,
        Ventura,
        Vermilion,
        Vernon,
        Victoria,
        Vigo,
        Vilas,
        Vinton,
        [EnumMember(Value = "Virginia Beach")]
        VirginiaBeach,
        Volusia,
        Wabash,
        Wabasha,
        Wabaunsee,
        Wadena,
        Wagoner,
        Wahkiakum,
        Wake,
        Wakulla,
        Waldo,
        Walker,
        [EnumMember(Value = "Walla Walla")]
        WallaWalla,
        Wallace,
        Waller,
        Wallowa,
        Walsh,
        Walthall,
        Walton,
        Walworth,
        Wapello,
        Ward,
        Ware,
        Warren,
        Warrick,
        Wasatch,
        Wasco,
        Waseca,
        Washakie,
        Washburn,
        Washington,
        Washita,
        Washoe,
        Washtenaw,
        Watauga,
        Watonwan,
        Waukesha,
        Waupaca,
        Waushara,
        Wayne,
        Waynesboro,
        Weakley,
        Webb,
        Weber,
        Webster,
        Weld,
        Wells,
        [EnumMember(Value = "West Baton Rouge")]
        WestBatonRouge,
        [EnumMember(Value = "West Carroll")]
        WestCarroll,
        [EnumMember(Value = "West Feliciana")]
        WestFeliciana,
        Westchester,
        Westmoreland,
        Weston,
        Wetzel,
        Wexford,
        Wharton,
        Whatcom,
        Wheatland,
        Wheeler,
        [EnumMember(Value = "White Pine")]
        WhitePine,
        White,
        Whiteside,
        Whitfield,
        Whitley,
        Whitman,
        Wibaux,
        Wichita,
        Wicomico,
        Wilbarger,
        Wilcox,
        Wilkes,
        Wilkin,
        Wilkinson,
        Will,
        Willacy,
        Williams,
        Williamsburg,
        Williamson,
        Wilson,
        Winchester,
        Windham,
        Windsor,
        Winkler,
        Winn,
        Winnebago,
        Winneshiek,
        Winona,
        Winston,
        Wirt,
        Wise,
        Wolfe,
        Wood,
        Woodbury,
        Woodford,
        Woodruff,
        Woods,
        Woodson,
        Woodward,
        Worcester,
        Worth,
        Wrangell,
        Wright,
        Wyandot,
        Wyandotte,
        Wyoming,
        Wythe,
        Yadkin,
        Yakima,
        Yakutat,
        Yalobusha,
        Yamhill,
        Yancey,
        Yankton,
        Yates,
        Yavapai,
        Yazoo,
        Yell,
        [EnumMember(Value = "Yellow Medicine")]
        YellowMedicine,
        Yellowstone,
        Yoakum,
        Yolo,
        York,
        Young,
        Yuba,
        [EnumMember(Value = "Yukon-Koyukuk")]
        YukonKoyukuk,
        Yuma,
        Zapata,
        Zavala,
        Ziebach
    }

    public class GetCOVID19totalsforallcountriesandtheirprovincesResponseItem
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("stats")]
        public GetCOVID19totalsforallcountriesandtheirprovincesResponseItemStatsType Stats { get; set; }

        [JsonProperty("coordinates")]
        public GetCOVID19totalsforallcountriesandtheirprovincesResponseItemCoordinatesType Coordinates { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }
    }

    public class GetCOVID19totalsforallcountriesandtheirprovincesResponseItemStatsType
    {
        [JsonProperty("confirmed")]
        public int Confirmed { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("recovered")]
        public int Recovered { get; set; }
    }

    public class GetCOVID19totalsforallcountriesandtheirprovincesResponseItemCoordinatesType
    {
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    public class GetCOVID19timeseriesdataforaspecificcountryResponse
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("province")]
        public string[] Province { get; set; }

        [JsonProperty("timeline")]
        public GetCOVID19timeseriesdataforaspecificcountryResponseTimelineType Timeline { get; set; }
    }

    public class GetCOVID19timeseriesdataforaspecificcountryResponseTimelineType
    {
        [JsonProperty("cases")]
        public GetCOVID19timeseriesdataforaspecificcountryResponseTimelineTypeCasesType Cases { get; set; }

        [JsonProperty("deaths")]
        public GetCOVID19timeseriesdataforaspecificcountryResponseTimelineTypeDeathsType Deaths { get; set; }

        [JsonProperty("recovered")]
        public GetCOVID19timeseriesdataforaspecificcountryResponseTimelineTypeRecoveredType Recovered { get; set; }
    }

    public class GetCOVID19timeseriesdataforaspecificcountryResponseTimelineTypeCasesType
    {
        [JsonProperty("day-month-year")]
        public int DayMonthYear { get; set; }
    }

    public class GetCOVID19timeseriesdataforaspecificcountryResponseTimelineTypeDeathsType
    {
        [JsonProperty("day-month-year")]
        public int DayMonthYear { get; set; }
    }

    public class GetCOVID19timeseriesdataforaspecificcountryResponseTimelineTypeRecoveredType
    {
        [JsonProperty("day-month-year")]
        public int DayMonthYear { get; set; }
    }

    public class GetCOVID19timeseriesdataforallcountiesinaspecifiedUSstateResponseItem
    {
        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("timeline")]
        public GetCOVID19timeseriesdataforallcountiesinaspecifiedUSstateResponseItemTimelineType Timeline { get; set; }
    }

    public class GetCOVID19timeseriesdataforallcountiesinaspecifiedUSstateResponseItemTimelineType
    {
        [JsonProperty("cases")]
        public GetCOVID19timeseriesdataforallcountiesinaspecifiedUSstateResponseItemTimelineTypeCasesType Cases { get; set; }

        [JsonProperty("deaths")]
        public GetCOVID19timeseriesdataforallcountiesinaspecifiedUSstateResponseItemTimelineTypeDeathsType Deaths { get; set; }
    }

    public class GetCOVID19timeseriesdataforallcountiesinaspecifiedUSstateResponseItemTimelineTypeCasesType
    {
        [JsonProperty("day-month-year")]
        public int DayMonthYear { get; set; }
    }

    public class GetCOVID19timeseriesdataforallcountiesinaspecifiedUSstateResponseItemTimelineTypeDeathsType
    {
        [JsonProperty("day-month-year")]
        public int DayMonthYear { get; set; }
    }

    public enum stateInput
    {
        Alabama,
        Alaska,
        [EnumMember(Value = "American Samoa")]
        AmericanSamoa,
        Arizona,
        Arkansas,
        [EnumMember(Value = "Bureau of Prisons")]
        BureauOfPrisons,
        California,
        Colorado,
        Connecticut,
        Delaware,
        [EnumMember(Value = "Dept of Defense")]
        DeptOfDefense,
        [EnumMember(Value = "District of Columbia")]
        DistrictOfColumbia,
        [EnumMember(Value = "Federated States of Micronesia")]
        FederatedStatesOfMicronesia,
        Florida,
        Georgia,
        Guam,
        Hawaii,
        Idaho,
        Illinois,
        [EnumMember(Value = "Indian Health Svc")]
        IndianHealthSvc,
        Indiana,
        Iowa,
        Kansas,
        Kentucky,
        [EnumMember(Value = "Long Term Care")]
        LongTermCare,
        Louisiana,
        Maine,
        [EnumMember(Value = "Marshall Islands")]
        MarshallIslands,
        Maryland,
        Massachusetts,
        Michigan,
        Minnesota,
        Mississippi,
        Missouri,
        Montana,
        Nebraska,
        Nevada,
        [EnumMember(Value = "New Hampshire")]
        NewHampshire,
        [EnumMember(Value = "New Jersey")]
        NewJersey,
        [EnumMember(Value = "New Mexico")]
        NewMexico,
        [EnumMember(Value = "New York State")]
        NewYorkState,
        [EnumMember(Value = "North Carolina")]
        NorthCarolina,
        [EnumMember(Value = "North Dakota")]
        NorthDakota,
        [EnumMember(Value = "Northern Mariana Islands")]
        NorthernMarianaIslands,
        Ohio,
        Oklahoma,
        Oregon,
        Pennsylvania,
        [EnumMember(Value = "Puerto Rico")]
        PuertoRico,
        [EnumMember(Value = "Republic of Palau")]
        RepublicOfPalau,
        [EnumMember(Value = "Rhode Island")]
        RhodeIsland,
        [EnumMember(Value = "South Carolina")]
        SouthCarolina,
        [EnumMember(Value = "South Dakota")]
        SouthDakota,
        Tennessee,
        Texas,
        [EnumMember(Value = "United States")]
        UnitedStates,
        Utah,
        Vermont,
        [EnumMember(Value = "Veterans Health")]
        VeteransHealth,
        [EnumMember(Value = "Virgin Islands")]
        VirginIslands,
        Virginia,
        Washington,
        [EnumMember(Value = "West Virginia")]
        WestVirginia,
        Wisconsin,
        Wyoming
    }

    public class GetCOVID19timeseriesdataforallcountriesandtheirprovincesResponseItem
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("timeline")]
        public GetCOVID19timeseriesdataforallcountriesandtheirprovincesResponseItemTimelineType Timeline { get; set; }
    }

    public class GetCOVID19timeseriesdataforallcountriesandtheirprovincesResponseItemTimelineType
    {
        [JsonProperty("day-month-year")]
        public int DayMonthYear { get; set; }
    }

    public class GetglobalaccumulatedCOVID19timeseriesdataResponse
    {
        [JsonProperty("cases")]
        public GetglobalaccumulatedCOVID19timeseriesdataResponseCasesType Cases { get; set; }

        [JsonProperty("deaths")]
        public GetglobalaccumulatedCOVID19timeseriesdataResponseDeathsType Deaths { get; set; }

        [JsonProperty("recovered")]
        public GetglobalaccumulatedCOVID19timeseriesdataResponseRecoveredType Recovered { get; set; }
    }

    public class GetglobalaccumulatedCOVID19timeseriesdataResponseCasesType
    {
        [JsonProperty("day-month-year")]
        public int DayMonthYear { get; set; }
    }

    public class GetglobalaccumulatedCOVID19timeseriesdataResponseDeathsType
    {
        [JsonProperty("day-month-year")]
        public int DayMonthYear { get; set; }
    }

    public class GetglobalaccumulatedCOVID19timeseriesdataResponseRecoveredType
    {
        [JsonProperty("day-month-year")]
        public int DayMonthYear { get; set; }
    }

    public class GetCOVID19timeseriesdataforallavailableUScountiesbeganResponseItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("fips")]
        public string Fips { get; set; }

        [JsonProperty("cases")]
        public int Cases { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }
    }

    public class GetCOVID19timeseriesdataforsincethepandemicbeganResponseItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("fips")]
        public string Fips { get; set; }

        [JsonProperty("cases")]
        public int Cases { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }
    }

    public class GetCOVID19timeseriesdataforentireUSResponseItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("cases")]
        public int Cases { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }
    }

    public class GetCOVID19governmentreporteddataforaspecificcountryResponseItem
    {
        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("todayCases")]
        public int TodayCases { get; set; }

        [JsonProperty("todayTests")]
        public int TodayTests { get; set; }

        [JsonProperty("todayRecovered")]
        public int TodayRecovered { get; set; }

        [JsonProperty("todayDeaths")]
        public int TodayDeaths { get; set; }

        [JsonProperty("cases")]
        public int Cases { get; set; }

        [JsonProperty("active")]
        public int Active { get; set; }

        [JsonProperty("tests")]
        public int Tests { get; set; }

        [JsonProperty("recovered")]
        public int Recovered { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }
    }

    public class GetCOVID19vaccinedosesforallcountriesResponseItem
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("timeline")]
        public GetCOVID19vaccinedosesforallcountriesResponseItemTimelineType Timeline { get; set; }
    }

    public class GetCOVID19vaccinedosesforallcountriesResponseItemTimelineType
    {
        [JsonProperty("day-month-year")]
        public int DayMonthYear { get; set; }
    }

    public class GetCOVID19vaccinedoseforasinglecountryResponse
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("timeline")]
        public GetCOVID19vaccinedoseforasinglecountryResponseTimelineType Timeline { get; set; }
    }

    public class GetCOVID19vaccinedoseforasinglecountryResponseTimelineType
    {
        [JsonProperty("day-month-year")]
        public int DayMonthYear { get; set; }
    }

    public class GetCOVID19vaccinedosesforallstatesResponseItem
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("timeline")]
        public GetCOVID19vaccinedosesforallstatesResponseItemTimelineType Timeline { get; set; }
    }

    public class GetCOVID19vaccinedosesforallstatesResponseItemTimelineType
    {
        [JsonProperty("day-month-year")]
        public int DayMonthYear { get; set; }
    }

    public class GetCOVID19vaccinedoseforastateResponse
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("timeline")]
        public GetCOVID19vaccinedoseforastateResponseTimelineType Timeline { get; set; }
    }

    public class GetCOVID19vaccinedoseforastateResponseTimelineType
    {
        [JsonProperty("day-month-year")]
        public int DayMonthYear { get; set; }
    }

    public class GettotalglobalCOVID19vaccinedosesResponse
    {
        [JsonProperty("day-month-year")]
        public int DayMonthYear { get; set; }
    }

    public class GetvaccinetrialdatafromRAPSbyJeffCravenatResponse
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("totalCandidates")]
        public string TotalCandidates { get; set; }

        [JsonProperty("phases")]
        public GetvaccinetrialdatafromRAPSbyJeffCravenatResponsePhasesTypeItem[] Phases { get; set; }

        [JsonProperty("data")]
        public GetvaccinetrialdatafromRAPSbyJeffCravenatResponseDataTypeItem[] Data { get; set; }
    }

    public class GetvaccinetrialdatafromRAPSbyJeffCravenatResponsePhasesTypeItem
    {
        [JsonProperty("phase")]
        public string Phase { get; set; }

        [JsonProperty("candidates")]
        public string Candidates { get; set; }
    }

    public class GetvaccinetrialdatafromRAPSbyJeffCravenatResponseDataTypeItem
    {
        [JsonProperty("candidate")]
        public string Candidate { get; set; }

        [JsonProperty("mechanism")]
        public string Mechanism { get; set; }

        [JsonProperty("sponsors")]
        public string[] Sponsors { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("trialPhase")]
        public string TrialPhase { get; set; }

        [JsonProperty("institutions")]
        public string[] Institutions { get; set; }
    }

    public class GetglobalCOVID19totalsfortodayyesterdayandtwodaysagoResponse
    {
        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("cases")]
        public int Cases { get; set; }

        [JsonProperty("todayCases")]
        public int TodayCases { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("todayDeaths")]
        public int TodayDeaths { get; set; }

        [JsonProperty("recovered")]
        public int Recovered { get; set; }

        [JsonProperty("todayRecovered")]
        public int TodayRecovered { get; set; }

        [JsonProperty("active")]
        public int Active { get; set; }

        [JsonProperty("critical")]
        public int Critical { get; set; }

        [JsonProperty("casesPerOneMillion")]
        public int CasesPerOneMillion { get; set; }

        [JsonProperty("deathsPerOneMillion")]
        public double DeathsPerOneMillion { get; set; }

        [JsonProperty("tests")]
        public int Tests { get; set; }

        [JsonProperty("testsPerOneMillion")]
        public double TestsPerOneMillion { get; set; }

        [JsonProperty("population")]
        public int Population { get; set; }

        [JsonProperty("oneCasePerPeople")]
        public int OneCasePerPeople { get; set; }

        [JsonProperty("oneDeathPerPeople")]
        public int OneDeathPerPeople { get; set; }

        [JsonProperty("oneTestPerPeople")]
        public int OneTestPerPeople { get; set; }

        [JsonProperty("activePerOneMillion")]
        public double ActivePerOneMillion { get; set; }

        [JsonProperty("recoveredPerOneMillion")]
        public double RecoveredPerOneMillion { get; set; }

        [JsonProperty("criticalPerOneMillion")]
        public double CriticalPerOneMillion { get; set; }

        [JsonProperty("affectedCountries")]
        public int AffectedCountries { get; set; }
    }

    public class GettherapeuticstrialdatafromRAPSbyJeffResponse
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("totalCandidates")]
        public string TotalCandidates { get; set; }

        [JsonProperty("phases")]
        public GettherapeuticstrialdatafromRAPSbyJeffResponsePhasesTypeItem[] Phases { get; set; }

        [JsonProperty("data")]
        public GettherapeuticstrialdatafromRAPSbyJeffResponseDataTypeItem[] Data { get; set; }
    }

    public class GettherapeuticstrialdatafromRAPSbyJeffResponsePhasesTypeItem
    {
        [JsonProperty("phase")]
        public string Phase { get; set; }

        [JsonProperty("candidates")]
        public string Candidates { get; set; }
    }

    public class GettherapeuticstrialdatafromRAPSbyJeffResponseDataTypeItem
    {
        [JsonProperty("medicationClass")]
        public string MedicationClass { get; set; }

        [JsonProperty("tradeName")]
        public string[] TradeName { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("developerResearcher")]
        public string[] DeveloperResearcher { get; set; }

        [JsonProperty("sponsors")]
        public string[] Sponsors { get; set; }

        [JsonProperty("trialPhase")]
        public string TrialPhase { get; set; }

        [JsonProperty("lastUpdate")]
        public string LastUpdate { get; set; }
    }

    public class GetInfluenzalikeillnessfromtheUSCenterforDiseaseControlResponse
    {
        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("data")]
        public GetInfluenzalikeillnessfromtheUSCenterforDiseaseControlResponseDataTypeItem[] Data { get; set; }
    }

    public class GetInfluenzalikeillnessfromtheUSCenterforDiseaseControlResponseDataTypeItem
    {
        [JsonProperty("week")]
        public string Week { get; set; }

        [JsonProperty("age 0-4")]
        public int Age04 { get; set; }

        [JsonProperty("age 5-24")]
        public int Age524 { get; set; }

        [JsonProperty("age 25-49")]
        public int Age2549 { get; set; }

        [JsonProperty("age 50-64")]
        public int Age5064 { get; set; }

        [JsonProperty("age 64+")]
        public int Age64 { get; set; }

        [JsonProperty("totalILI")]
        public int TotalILI { get; set; }

        [JsonProperty("totalPatients")]
        public int TotalPatients { get; set; }

        [JsonProperty("percentUnweightedILI")]
        public double PercentUnweightedILI { get; set; }

        [JsonProperty("percentWeightedILI")]
        public double PercentWeightedILI { get; set; }
    }

    public class GetInfluenzareportdatareportedbyUSclinicallabsResponse
    {
        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("data")]
        public GetInfluenzareportdatareportedbyUSclinicallabsResponseDataTypeItem[] Data { get; set; }
    }

    public class GetInfluenzareportdatareportedbyUSclinicallabsResponseDataTypeItem
    {
        [JsonProperty("week")]
        public string Week { get; set; }

        [JsonProperty("totalA")]
        public int TotalA { get; set; }

        [JsonProperty("totalB")]
        public int TotalB { get; set; }

        [JsonProperty("percentPositiveA")]
        public double PercentPositiveA { get; set; }

        [JsonProperty("percentPositiveB")]
        public double PercentPositiveB { get; set; }

        [JsonProperty("totalTests")]
        public int TotalTests { get; set; }

        [JsonProperty("percentPositive")]
        public double PercentPositive { get; set; }
    }

    public class GetInfluenzareportdatareportedbyUSpublichealthlabsResponse
    {
        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("data")]
        public GetInfluenzareportdatareportedbyUSpublichealthlabsResponseDataTypeItem[] Data { get; set; }
    }

    public class GetInfluenzareportdatareportedbyUSpublichealthlabsResponseDataTypeItem
    {
        [JsonProperty("week")]
        public string Week { get; set; }

        [JsonProperty("A(H3N2v)")]
        public int AH3N2v { get; set; }

        [JsonProperty("A(H1N1)")]
        public int AH1N1 { get; set; }

        [JsonProperty("A(H3)")]
        public int AH3 { get; set; }

        [JsonProperty("A(unable to sub-type)")]
        public int AUnableToSubType { get; set; }

        [JsonProperty("A(Subtyping not performed)")]
        public int ASubtypingNotPerformed { get; set; }
        public int B { get; set; }
        public int BVIC { get; set; }
        public int BYAM { get; set; }

        [JsonProperty("totalTests")]
        public int TotalTests { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Influenzandcovid19ip;

    public partial class WorkflowManagedActions
    {
        public Influenzandcovid19ipActions Influenzandcovid19ip(string connectionId) => new Influenzandcovid19ipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Influenzandcovid19ipTriggers Influenzandcovid19ip(string connectionId) => new Influenzandcovid19ipTriggers(connectionId);
    }
}