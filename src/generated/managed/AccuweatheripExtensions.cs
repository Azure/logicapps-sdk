//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Accuweatherip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AccuweatheripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<AdminAreasResponseItem[]> AdminAreas([WorkflowExpression] Func<string> countryCode, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(countryCode, nameof(countryCode), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/locations/v1/adminareas/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(countryCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<AdminAreasResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<CountryListResponseItem[]> CountryList([WorkflowExpression] Func<string> regionCode, [WorkflowExpression] Func<string> language = null)
        {
            SourceExpression.Validate(regionCode, nameof(regionCode), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/locations/v1/countries/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                return callPayload;
            }

            return new ApiConnectionAction<CountryListResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<RegionListResponseItem[]> RegionList([WorkflowExpression] Func<string> language = null)
        {
            SourceExpression.Validate(language, nameof(language), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/locations/v1/regions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                return callPayload;
            }

            return new ApiConnectionAction<RegionListResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<TopCitiesListResponseItem[]> TopCitiesList([WorkflowExpression] Func<groupInput> group, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<bool> details = null)
        {
            SourceExpression.Validate(group, nameof(group), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(details, nameof(details), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/locations/v1/topcities/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(group, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                if (details != null)
                    callPayload.Queries["details"] = SourceExpressionConverter.ConvertO(details);
                return callPayload;
            }

            return new ApiConnectionAction<TopCitiesListResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<AutocompleteCitiesResponseItem[]> AutocompleteCities([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> language = null)
        {
            SourceExpression.Validate(q, nameof(q), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/locations/v1/cities/autocomplete";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                return callPayload;
            }

            return new ApiConnectionAction<AutocompleteCitiesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<GeopositionSearchResponse> GeopositionSearch([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<bool> details = null, [WorkflowExpression] Func<bool> toplevel = null)
        {
            SourceExpression.Validate(q, nameof(q), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(details, nameof(details), required: false);
            SourceExpression.Validate(toplevel, nameof(toplevel), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/locations/v1/cities/geoposition/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                if (details != null)
                    callPayload.Queries["details"] = SourceExpressionConverter.ConvertO(details);
                if (toplevel != null)
                    callPayload.Queries["toplevel"] = SourceExpressionConverter.ConvertO(toplevel);
                return callPayload;
            }

            return new ApiConnectionAction<GeopositionSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<DailyForcastsResponse> DailyForcasts([WorkflowExpression] Func<durationInput> duration, [WorkflowExpression] Func<int> locationKey, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<bool> details = null, [WorkflowExpression] Func<bool> metric = null)
        {
            SourceExpression.Validate(duration, nameof(duration), required: true);
            SourceExpression.Validate(locationKey, nameof(locationKey), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(details, nameof(details), required: false);
            SourceExpression.Validate(metric, nameof(metric), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/forecasts/v1/daily/{0}day/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(duration, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(locationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                if (details != null)
                    callPayload.Queries["details"] = SourceExpressionConverter.ConvertO(details);
                if (metric != null)
                    callPayload.Queries["metric"] = SourceExpressionConverter.ConvertO(metric);
                return callPayload;
            }

            return new ApiConnectionAction<DailyForcastsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<HourlyForcastsResponseItem[]> HourlyForcasts([WorkflowExpression] Func<durationInput> duration, [WorkflowExpression] Func<int> locationKey, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<bool> details = null, [WorkflowExpression] Func<bool> metric = null)
        {
            SourceExpression.Validate(duration, nameof(duration), required: true);
            SourceExpression.Validate(locationKey, nameof(locationKey), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(details, nameof(details), required: false);
            SourceExpression.Validate(metric, nameof(metric), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/forecasts/v1/hourly/{0}hour/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(duration, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(locationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                if (details != null)
                    callPayload.Queries["details"] = SourceExpressionConverter.ConvertO(details);
                if (metric != null)
                    callPayload.Queries["metric"] = SourceExpressionConverter.ConvertO(metric);
                return callPayload;
            }

            return new ApiConnectionAction<HourlyForcastsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<CurrentConditionsResponseItem[]> CurrentConditions([WorkflowExpression] Func<string> locationKey, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<bool> details = null)
        {
            SourceExpression.Validate(locationKey, nameof(locationKey), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(details, nameof(details), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/currentconditions/v1/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                if (details != null)
                    callPayload.Queries["details"] = SourceExpressionConverter.ConvertO(details);
                return callPayload;
            }

            return new ApiConnectionAction<CurrentConditionsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<CurrentConditionsTopCitiesResponseItem[]> CurrentConditionsTopCities([WorkflowExpression] Func<groupInput> group, [WorkflowExpression] Func<string> language = null)
        {
            SourceExpression.Validate(group, nameof(group), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/currentconditions/v1/topcities/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(group, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                return callPayload;
            }

            return new ApiConnectionAction<CurrentConditionsTopCitiesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<HistoricalCurrentConditions24HResponseItem[]> HistoricalCurrentConditions24H([WorkflowExpression] Func<int> locationKey, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<bool> details = null)
        {
            SourceExpression.Validate(locationKey, nameof(locationKey), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(details, nameof(details), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/currentconditions/v1/{0}/historical/24", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(locationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                if (details != null)
                    callPayload.Queries["details"] = SourceExpressionConverter.ConvertO(details);
                return callPayload;
            }

            return new ApiConnectionAction<HistoricalCurrentConditions24HResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<HistoricalCurrentConditions6HResponseItem[]> HistoricalCurrentConditions6H([WorkflowExpression] Func<int> locationKey, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<bool> details = null)
        {
            SourceExpression.Validate(locationKey, nameof(locationKey), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(details, nameof(details), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/currentconditions/v1/{0}/historical", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(locationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                if (details != null)
                    callPayload.Queries["details"] = SourceExpressionConverter.ConvertO(details);
                return callPayload;
            }

            return new ApiConnectionAction<HistoricalCurrentConditions6HResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<DailyIndexValuesByGroupOfIndiciesResponseItem[]> DailyIndexValuesByGroupOfIndicies([WorkflowExpression] Func<durationInput> duration, [WorkflowExpression] Func<int> locationKey, [WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<bool> details = null)
        {
            SourceExpression.Validate(duration, nameof(duration), required: true);
            SourceExpression.Validate(locationKey, nameof(locationKey), required: true);
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(details, nameof(details), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/indices/v1/daily/{0}day/{1}/groups/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(duration, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(locationKey, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                if (details != null)
                    callPayload.Queries["details"] = SourceExpressionConverter.ConvertO(details);
                return callPayload;
            }

            return new ApiConnectionAction<DailyIndexValuesByGroupOfIndiciesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<DailyIndexValuesBySpecificIndexResponseItem[]> DailyIndexValuesBySpecificIndex([WorkflowExpression] Func<durationInput> duration, [WorkflowExpression] Func<int> locationKey, [WorkflowExpression] Func<int> indexId, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<bool> details = null)
        {
            SourceExpression.Validate(duration, nameof(duration), required: true);
            SourceExpression.Validate(locationKey, nameof(locationKey), required: true);
            SourceExpression.Validate(indexId, nameof(indexId), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(details, nameof(details), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/indices/v1/daily/{0}day/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(duration, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(locationKey, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(indexId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                if (details != null)
                    callPayload.Queries["details"] = SourceExpressionConverter.ConvertO(details);
                return callPayload;
            }

            return new ApiConnectionAction<DailyIndexValuesBySpecificIndexResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<DailyIndexValuesForAllIndicesResponseItem[]> DailyIndexValuesForAllIndices([WorkflowExpression] Func<int> locationKey, [WorkflowExpression] Func<durationInput> duration, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<bool> details = null)
        {
            SourceExpression.Validate(locationKey, nameof(locationKey), required: true);
            SourceExpression.Validate(duration, nameof(duration), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(details, nameof(details), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/indices/v1/daily/{0}day/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(duration, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(locationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                if (details != null)
                    callPayload.Queries["details"] = SourceExpressionConverter.ConvertO(details);
                return callPayload;
            }

            return new ApiConnectionAction<DailyIndexValuesForAllIndicesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<ListDailyIndicesResponseItem[]> ListDailyIndices()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/indices/v1/daily";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListDailyIndicesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<ListIndexGroupsResponseItem[]> ListIndexGroups()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/indices/v1/daily/groups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListIndexGroupsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<ListOfIndiciesInAGroupByGroupIdResponseItem[]> ListOfIndiciesInAGroupByGroupId([WorkflowExpression] Func<int> groupId, [WorkflowExpression] Func<string> language = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/indices/v1/daily/groups/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                return callPayload;
            }

            return new ApiConnectionAction<ListOfIndiciesInAGroupByGroupIdResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<SearchLocationKeyResponse> SearchLocationKey([WorkflowExpression] Func<string> locationKey, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<bool> details = null)
        {
            SourceExpression.Validate(locationKey, nameof(locationKey), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(details, nameof(details), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/locations/v1/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["language"] = Convert.ToString("en-us");
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                callPayload.Queries["details"] = Convert.ToString(false);
                if (details != null)
                    callPayload.Queries["details"] = SourceExpressionConverter.ConvertO(details);
                return callPayload;
            }

            return new ApiConnectionAction<SearchLocationKeyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<SearchLocationIPResponse> SearchLocationIP([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<bool> details = null)
        {
            SourceExpression.Validate(q, nameof(q), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(details, nameof(details), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/locations/v1/cities/ipaddress";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                callPayload.Queries["language"] = Convert.ToString("en-us");
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                callPayload.Queries["details"] = Convert.ToString(false);
                if (details != null)
                    callPayload.Queries["details"] = SourceExpressionConverter.ConvertO(details);
                return callPayload;
            }

            return new ApiConnectionAction<SearchLocationIPResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<AlarmOneResponseItem[]> AlarmOne([WorkflowExpression] Func<string> locationKey, [WorkflowExpression] Func<string> language = null)
        {
            SourceExpression.Validate(locationKey, nameof(locationKey), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alarms/v1/1day/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                return callPayload;
            }

            return new ApiConnectionAction<AlarmOneResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<AlarmFiveResponseItem[]> AlarmFive([WorkflowExpression] Func<string> locationKey, [WorkflowExpression] Func<string> language = null)
        {
            SourceExpression.Validate(locationKey, nameof(locationKey), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alarms/v1/5day/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                return callPayload;
            }

            return new ApiConnectionAction<AlarmFiveResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<AlarmTenResponseItem[]> AlarmTen([WorkflowExpression] Func<string> locationKey, [WorkflowExpression] Func<string> language = null)
        {
            SourceExpression.Validate(locationKey, nameof(locationKey), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alarms/v1/10day/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                return callPayload;
            }

            return new ApiConnectionAction<AlarmTenResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<AlarmFifteenResponseItem[]> AlarmFifteen([WorkflowExpression] Func<string> locationKey, [WorkflowExpression] Func<string> language = null)
        {
            SourceExpression.Validate(locationKey, nameof(locationKey), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alarms/v1/15day/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                return callPayload;
            }

            return new ApiConnectionAction<AlarmFifteenResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<LanguageListResponseItem[]> LanguageList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/translations/v1/languages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LanguageListResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<LanguageGroupsResponseItem[]> LanguageGroups()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/translations/v1/groups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LanguageGroupsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<LanguageTranslationsGroupResponseItem[]> LanguageTranslationsGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> language = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/translations/v1/groups/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                return callPayload;
            }

            return new ApiConnectionAction<LanguageTranslationsGroupResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<AlertLocationResponseItem[]> AlertLocation([WorkflowExpression] Func<string> locationKey, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<bool> details = null)
        {
            SourceExpression.Validate(locationKey, nameof(locationKey), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(details, nameof(details), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alerts/v1/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                if (details != null)
                    callPayload.Queries["details"] = SourceExpressionConverter.ConvertO(details);
                return callPayload;
            }

            return new ApiConnectionAction<AlertLocationResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "accuweatherip")]
        public IBodyWorkflowAction<ImageryResponseItem[]> Imagery([WorkflowExpression] Func<string> resolution, [WorkflowExpression] Func<string> locationKey, [WorkflowExpression] Func<string> language = null)
        {
            SourceExpression.Validate(resolution, nameof(resolution), required: true);
            SourceExpression.Validate(locationKey, nameof(locationKey), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/imagery/v1/maps/radsat/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resolution, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                return callPayload;
            }

            return new ApiConnectionAction<ImageryResponseItem[]>(BuildSourceInput);
        }
    }

    public class AccuweatheripTriggers([ConnectionName] string connectionId)
    {
    }

    public class AdminAreasResponseItem
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
        public int Level { get; set; }
        public string LocalizedType { get; set; }
        public string EnglishType { get; set; }
        public string CountryID { get; set; }
    }

    public class CountryListResponseItem
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
    }

    public class RegionListResponseItem
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
    }

    public class TopCitiesListResponseItem
    {
        public int Version { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public int Rank { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
        public string PrimaryPostalCode { get; set; }
        public TopCitiesListResponseItemRegionType Region { get; set; }
        public TopCitiesListResponseItemCountryType Country { get; set; }
        public TopCitiesListResponseItemAdministrativeAreaType AdministrativeArea { get; set; }
        public TopCitiesListResponseItemTimeZoneType TimeZone { get; set; }
        public TopCitiesListResponseItemGeoPositionType GeoPosition { get; set; }
        public bool IsAlias { get; set; }
        public string[] SupplementalAdminAreas { get; set; }
        public string[] DataSets { get; set; }
        public TopCitiesListResponseItemDetailsType Details { get; set; }
    }

    public class TopCitiesListResponseItemRegionType
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
    }

    public class TopCitiesListResponseItemCountryType
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
    }

    public class TopCitiesListResponseItemAdministrativeAreaType
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
        public int Level { get; set; }
        public string LocalizedType { get; set; }
        public string EnglishType { get; set; }
        public string CountryID { get; set; }
    }

    public class TopCitiesListResponseItemTimeZoneType
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public double GmtOffset { get; set; }
        public bool IsDaylightSaving { get; set; }
        public string NextOffsetChange { get; set; }
    }

    public class TopCitiesListResponseItemGeoPositionType
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public TopCitiesListResponseItemGeoPositionTypeElevationType Elevation { get; set; }
    }

    public class TopCitiesListResponseItemGeoPositionTypeElevationType
    {
        public TopCitiesListResponseItemGeoPositionTypeElevationTypeMetricType Metric { get; set; }
        public TopCitiesListResponseItemGeoPositionTypeElevationTypeImperialType Imperial { get; set; }
    }

    public class TopCitiesListResponseItemGeoPositionTypeElevationTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class TopCitiesListResponseItemGeoPositionTypeElevationTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class TopCitiesListResponseItemDetailsType
    {
        public string Key { get; set; }
        public string StationCode { get; set; }
        public double StationGmtOffset { get; set; }
        public string BandMap { get; set; }
        public string Climo { get; set; }
        public string LocalRadar { get; set; }
        public string MediaRegion { get; set; }
        public string Metar { get; set; }
        public string NXMetro { get; set; }
        public string NXState { get; set; }
        public int Population { get; set; }
        public string PrimaryWarningCountyCode { get; set; }
        public string PrimaryWarningZoneCode { get; set; }
        public string Satellite { get; set; }
        public string Synoptic { get; set; }
        public string MarineStation { get; set; }
        public double MarineStationGMTOffset { get; set; }
        public string VideoCode { get; set; }
        public string LocationStem { get; set; }
        public string PartnerID { get; set; }
        public TopCitiesListResponseItemDetailsTypeSourcesTypeItem[] Sources { get; set; }
        public string CanonicalPostalCode { get; set; }
        public string CanonicalLocationKey { get; set; }
    }

    public class TopCitiesListResponseItemDetailsTypeSourcesTypeItem
    {
        public string DataType { get; set; }
        public string Source { get; set; }
        public int SourceId { get; set; }
        public string PartnerSourceUrl { get; set; }
    }

    public enum groupInput
    {
        _50 = 50,
        _100 = 100,
        _150 = 150
    }

    public class AutocompleteCitiesResponseItem
    {
        public int Version { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public int Rank { get; set; }
        public string LocalizedName { get; set; }
        public AutocompleteCitiesResponseItemCountryType Country { get; set; }
        public AutocompleteCitiesResponseItemAdministrativeAreaType AdministrativeArea { get; set; }
    }

    public class AutocompleteCitiesResponseItemCountryType
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }
    }

    public class AutocompleteCitiesResponseItemAdministrativeAreaType
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }
    }

    public class GeopositionSearchResponse
    {
        public int Version { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public int Rank { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
        public string PrimaryPostalCode { get; set; }
        public GeopositionSearchResponseRegionType Region { get; set; }
        public GeopositionSearchResponseCountryType Country { get; set; }
        public GeopositionSearchResponseAdministrativeAreaType AdministrativeArea { get; set; }
        public GeopositionSearchResponseTimeZoneType TimeZone { get; set; }
        public GeopositionSearchResponseGeoPositionType GeoPosition { get; set; }
        public bool IsAlias { get; set; }
        public GeopositionSearchResponseParentCityType ParentCity { get; set; }
        public GeopositionSearchResponseSupplementalAdminAreasTypeItem[] SupplementalAdminAreas { get; set; }
        public string[] DataSets { get; set; }
        public GeopositionSearchResponseDetailsType Details { get; set; }
    }

    public class GeopositionSearchResponseRegionType
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
    }

    public class GeopositionSearchResponseCountryType
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
    }

    public class GeopositionSearchResponseAdministrativeAreaType
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
        public int Level { get; set; }
        public string LocalizedType { get; set; }
        public string EnglishType { get; set; }
        public string CountryID { get; set; }
    }

    public class GeopositionSearchResponseTimeZoneType
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public double GmtOffset { get; set; }
        public bool IsDaylightSaving { get; set; }
        public string NextOffsetChange { get; set; }
    }

    public class GeopositionSearchResponseGeoPositionType
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public GeopositionSearchResponseGeoPositionTypeElevationType Elevation { get; set; }
    }

    public class GeopositionSearchResponseGeoPositionTypeElevationType
    {
        public GeopositionSearchResponseGeoPositionTypeElevationTypeMetricType Metric { get; set; }
        public GeopositionSearchResponseGeoPositionTypeElevationTypeImperialType Imperial { get; set; }
    }

    public class GeopositionSearchResponseGeoPositionTypeElevationTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class GeopositionSearchResponseGeoPositionTypeElevationTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class GeopositionSearchResponseParentCityType
    {
        public string Key { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
    }

    public class GeopositionSearchResponseSupplementalAdminAreasTypeItem
    {
        public int Level { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
    }

    public class GeopositionSearchResponseDetailsType
    {
        public string Key { get; set; }
        public string StationCode { get; set; }
        public double StationGmtOffset { get; set; }
        public string BandMap { get; set; }
        public string Climo { get; set; }
        public string LocalRadar { get; set; }
        public string MediaRegion { get; set; }
        public string Metar { get; set; }
        public string NXMetro { get; set; }
        public string NXState { get; set; }
        public int Population { get; set; }
        public string PrimaryWarningCountyCode { get; set; }
        public string PrimaryWarningZoneCode { get; set; }
        public string Satellite { get; set; }
        public string Synoptic { get; set; }
        public string MarineStation { get; set; }
        public double MarineStationGMTOffset { get; set; }
        public string VideoCode { get; set; }
        public string LocationStem { get; set; }
        public GeopositionSearchResponseDetailsTypeDMAType DMA { get; set; }
        public string PartnerID { get; set; }
        public GeopositionSearchResponseDetailsTypeSourcesTypeItem[] Sources { get; set; }
        public string CanonicalPostalCode { get; set; }
        public string CanonicalLocationKey { get; set; }
    }

    public class GeopositionSearchResponseDetailsTypeDMAType
    {
        public string ID { get; set; }
        public string EnglishName { get; set; }
    }

    public class GeopositionSearchResponseDetailsTypeSourcesTypeItem
    {
        public string DataType { get; set; }
        public string Source { get; set; }
        public int SourceId { get; set; }
    }

    public class DailyForcastsResponse
    {
        public DailyForcastsResponseHeadlineType Headline { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItem[] DailyForecasts { get; set; }
    }

    public class DailyForcastsResponseHeadlineType
    {
        public string EffectiveDate { get; set; }
        public int EffectiveEpochDate { get; set; }
        public int Severity { get; set; }
        public string Text { get; set; }
        public string Category { get; set; }
        public string EndDate { get; set; }
        public int EndEpochDate { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItem
    {
        public string Date { get; set; }
        public int EpochDate { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemSunType Sun { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemMoonType Moon { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemTemperatureType Temperature { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemRealFeelTemperatureType RealFeelTemperature { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemRealFeelTemperatureShadeType RealFeelTemperatureShade { get; set; }
        public double HoursOfSun { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemDegreeDaySummaryType DegreeDaySummary { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemAirAndPollenTypeItem[] AirAndPollen { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemDayType Day { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemNightType Night { get; set; }
        public string[] Sources { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemSunType
    {
        public string Rise { get; set; }
        public int EpochRise { get; set; }
        public string Set { get; set; }
        public int EpochSet { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemMoonType
    {
        public string Rise { get; set; }
        public int EpochRise { get; set; }
        public string Set { get; set; }
        public int EpochSet { get; set; }
        public string Phase { get; set; }
        public int Age { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemTemperatureType
    {
        public DailyForcastsResponseDailyForecastsTypeItemTemperatureTypeMinimumType Minimum { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemTemperatureTypeMaximumType Maximum { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemTemperatureTypeMinimumType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemTemperatureTypeMaximumType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemRealFeelTemperatureType
    {
        public DailyForcastsResponseDailyForecastsTypeItemRealFeelTemperatureTypeMinimumType Minimum { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemRealFeelTemperatureTypeMaximumType Maximum { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemRealFeelTemperatureTypeMinimumType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemRealFeelTemperatureTypeMaximumType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemRealFeelTemperatureShadeType
    {
        public DailyForcastsResponseDailyForecastsTypeItemRealFeelTemperatureShadeTypeMinimumType Minimum { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemRealFeelTemperatureShadeTypeMaximumType Maximum { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemRealFeelTemperatureShadeTypeMinimumType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemRealFeelTemperatureShadeTypeMaximumType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemDegreeDaySummaryType
    {
        public DailyForcastsResponseDailyForecastsTypeItemDegreeDaySummaryTypeHeatingType Heating { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemDegreeDaySummaryTypeCoolingType Cooling { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemDegreeDaySummaryTypeHeatingType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemDegreeDaySummaryTypeCoolingType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemAirAndPollenTypeItem
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public string Category { get; set; }
        public int CategoryValue { get; set; }
        public string Type { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemDayType
    {
        public int Icon { get; set; }
        public string IconPhrase { get; set; }
        public bool HasPrecipitation { get; set; }
        public string ShortPhrase { get; set; }
        public string LongPhrase { get; set; }
        public int PrecipitationProbability { get; set; }
        public int ThunderstormProbability { get; set; }
        public int RainProbability { get; set; }
        public int SnowProbability { get; set; }
        public int IceProbability { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemDayTypeWindType Wind { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemDayTypeWindGustType WindGust { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemDayTypeTotalLiquidType TotalLiquid { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemDayTypeRainType Rain { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemDayTypeSnowType Snow { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemDayTypeIceType Ice { get; set; }
        public double HoursOfPrecipitation { get; set; }
        public double HoursOfRain { get; set; }
        public double HoursOfSnow { get; set; }
        public double HoursOfIce { get; set; }
        public double CloudCover { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemDayTypeEvapotranspirationType Evapotranspiration { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemDayTypeSolarIrradianceType SolarIrradiance { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemDayTypeWindType
    {
        public DailyForcastsResponseDailyForecastsTypeItemDayTypeWindTypeSpeedType Speed { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemDayTypeWindTypeDirectionType Direction { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemDayTypeWindTypeSpeedType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemDayTypeWindTypeDirectionType
    {
        public int Degrees { get; set; }
        public string Localized { get; set; }
        public string English { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemDayTypeWindGustType
    {
        public DailyForcastsResponseDailyForecastsTypeItemDayTypeWindGustTypeSpeedType Speed { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemDayTypeWindGustTypeDirectionType Direction { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemDayTypeWindGustTypeSpeedType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemDayTypeWindGustTypeDirectionType
    {
        public int Degrees { get; set; }
        public string Localized { get; set; }
        public string English { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemDayTypeTotalLiquidType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemDayTypeRainType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemDayTypeSnowType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemDayTypeIceType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemDayTypeEvapotranspirationType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemDayTypeSolarIrradianceType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemNightType
    {
        public int Icon { get; set; }
        public string IconPhrase { get; set; }
        public bool HasPrecipitation { get; set; }
        public string ShortPhrase { get; set; }
        public string LongPhrase { get; set; }
        public int PrecipitationProbability { get; set; }
        public int ThunderstormProbability { get; set; }
        public int RainProbability { get; set; }
        public int SnowProbability { get; set; }
        public int IceProbability { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemNightTypeWindType Wind { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemNightTypeWindGustType WindGust { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemNightTypeTotalLiquidType TotalLiquid { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemNightTypeRainType Rain { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemNightTypeSnowType Snow { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemNightTypeIceType Ice { get; set; }
        public double HoursOfPrecipitation { get; set; }
        public double HoursOfRain { get; set; }
        public double HoursOfSnow { get; set; }
        public double HoursOfIce { get; set; }
        public int CloudCover { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemNightTypeEvapotranspirationType Evapotranspiration { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemNightTypeSolarIrradianceType SolarIrradiance { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemNightTypeWindType
    {
        public DailyForcastsResponseDailyForecastsTypeItemNightTypeWindTypeSpeedType Speed { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemNightTypeWindTypeDirectionType Direction { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemNightTypeWindTypeSpeedType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemNightTypeWindTypeDirectionType
    {
        public int Degrees { get; set; }
        public string Localized { get; set; }
        public string English { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemNightTypeWindGustType
    {
        public DailyForcastsResponseDailyForecastsTypeItemNightTypeWindGustTypeSpeedType Speed { get; set; }
        public DailyForcastsResponseDailyForecastsTypeItemNightTypeWindGustTypeDirectionType Direction { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemNightTypeWindGustTypeSpeedType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemNightTypeWindGustTypeDirectionType
    {
        public int Degrees { get; set; }
        public string Localized { get; set; }
        public string English { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemNightTypeTotalLiquidType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemNightTypeRainType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemNightTypeSnowType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemNightTypeIceType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemNightTypeEvapotranspirationType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyForcastsResponseDailyForecastsTypeItemNightTypeSolarIrradianceType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public enum durationInput
    {
        _1 = 1,
        _5 = 5,
        _10 = 10,
        _15 = 15
    }

    public class HourlyForcastsResponseItem
    {
        public string DateTime { get; set; }
        public int EpochDateTime { get; set; }
        public int WeatherIcon { get; set; }
        public string IconPhrase { get; set; }
        public bool HasPrecipitation { get; set; }
        public bool IsDaylight { get; set; }
        public HourlyForcastsResponseItemTemperatureType Temperature { get; set; }
        public HourlyForcastsResponseItemRealFeelTemperatureType RealFeelTemperature { get; set; }
        public HourlyForcastsResponseItemRealFeelTemperatureShadeType RealFeelTemperatureShade { get; set; }
        public HourlyForcastsResponseItemWetBulbTemperatureType WetBulbTemperature { get; set; }
        public HourlyForcastsResponseItemDewPointType DewPoint { get; set; }
        public HourlyForcastsResponseItemWindType Wind { get; set; }
        public HourlyForcastsResponseItemWindGustType WindGust { get; set; }
        public int RelativeHumidity { get; set; }
        public int IndoorRelativeHumidity { get; set; }
        public HourlyForcastsResponseItemVisibilityType Visibility { get; set; }
        public HourlyForcastsResponseItemCeilingType Ceiling { get; set; }
        public int UVIndex { get; set; }
        public string UVIndexText { get; set; }
        public int PrecipitationProbability { get; set; }
        public int ThunderstormProbability { get; set; }
        public int RainProbability { get; set; }
        public int SnowProbability { get; set; }
        public int IceProbability { get; set; }
        public HourlyForcastsResponseItemTotalLiquidType TotalLiquid { get; set; }
        public HourlyForcastsResponseItemRainType Rain { get; set; }
        public HourlyForcastsResponseItemSnowType Snow { get; set; }
        public HourlyForcastsResponseItemIceType Ice { get; set; }
        public int CloudCover { get; set; }
        public HourlyForcastsResponseItemEvapotranspirationType Evapotranspiration { get; set; }
        public HourlyForcastsResponseItemSolarIrradianceType SolarIrradiance { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }
    }

    public class HourlyForcastsResponseItemTemperatureType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HourlyForcastsResponseItemRealFeelTemperatureType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HourlyForcastsResponseItemRealFeelTemperatureShadeType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HourlyForcastsResponseItemWetBulbTemperatureType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HourlyForcastsResponseItemDewPointType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HourlyForcastsResponseItemWindType
    {
        public HourlyForcastsResponseItemWindTypeSpeedType Speed { get; set; }
        public HourlyForcastsResponseItemWindTypeDirectionType Direction { get; set; }
    }

    public class HourlyForcastsResponseItemWindTypeSpeedType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HourlyForcastsResponseItemWindTypeDirectionType
    {
        public int Degrees { get; set; }
        public string Localized { get; set; }
        public string English { get; set; }
    }

    public class HourlyForcastsResponseItemWindGustType
    {
        public HourlyForcastsResponseItemWindGustTypeSpeedType Speed { get; set; }
    }

    public class HourlyForcastsResponseItemWindGustTypeSpeedType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HourlyForcastsResponseItemVisibilityType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HourlyForcastsResponseItemCeilingType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HourlyForcastsResponseItemTotalLiquidType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HourlyForcastsResponseItemRainType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HourlyForcastsResponseItemSnowType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HourlyForcastsResponseItemIceType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HourlyForcastsResponseItemEvapotranspirationType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HourlyForcastsResponseItemSolarIrradianceType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItem
    {
        public string LocalObservationDateTime { get; set; }
        public int EpochTime { get; set; }
        public string WeatherText { get; set; }
        public int WeatherIcon { get; set; }
        public bool HasPrecipitation { get; set; }
        public string PrecipitationType { get; set; }
        public bool IsDayTime { get; set; }
        public CurrentConditionsResponseItemTemperatureType Temperature { get; set; }
        public CurrentConditionsResponseItemRealFeelTemperatureType RealFeelTemperature { get; set; }
        public CurrentConditionsResponseItemRealFeelTemperatureShadeType RealFeelTemperatureShade { get; set; }
        public int RelativeHumidity { get; set; }
        public int IndoorRelativeHumidity { get; set; }
        public CurrentConditionsResponseItemDewPointType DewPoint { get; set; }
        public CurrentConditionsResponseItemWindType Wind { get; set; }
        public CurrentConditionsResponseItemWindGustType WindGust { get; set; }
        public int UVIndex { get; set; }
        public string UVIndexText { get; set; }
        public CurrentConditionsResponseItemVisibilityType Visibility { get; set; }
        public string ObstructionsToVisibility { get; set; }
        public int CloudCover { get; set; }
        public CurrentConditionsResponseItemCeilingType Ceiling { get; set; }
        public CurrentConditionsResponseItemPressureType Pressure { get; set; }
        public CurrentConditionsResponseItemPressureTendencyType PressureTendency { get; set; }
        public CurrentConditionsResponseItemPast24HourTemperatureDepartureType Past24HourTemperatureDeparture { get; set; }
        public CurrentConditionsResponseItemApparentTemperatureType ApparentTemperature { get; set; }
        public CurrentConditionsResponseItemWindChillTemperatureType WindChillTemperature { get; set; }
        public CurrentConditionsResponseItemWetBulbTemperatureType WetBulbTemperature { get; set; }
        public CurrentConditionsResponseItemPrecip1hrType Precip1hr { get; set; }
        public CurrentConditionsResponseItemPrecipitationSummaryType PrecipitationSummary { get; set; }
        public CurrentConditionsResponseItemTemperatureSummaryType TemperatureSummary { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureType
    {
        public CurrentConditionsResponseItemTemperatureTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemTemperatureTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemRealFeelTemperatureType
    {
        public CurrentConditionsResponseItemRealFeelTemperatureTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemRealFeelTemperatureTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemRealFeelTemperatureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemRealFeelTemperatureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemRealFeelTemperatureShadeType
    {
        public CurrentConditionsResponseItemRealFeelTemperatureShadeTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemRealFeelTemperatureShadeTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemRealFeelTemperatureShadeTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemRealFeelTemperatureShadeTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemDewPointType
    {
        public CurrentConditionsResponseItemDewPointTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemDewPointTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemDewPointTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemDewPointTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemWindType
    {
        public CurrentConditionsResponseItemWindTypeDirectionType Direction { get; set; }
        public CurrentConditionsResponseItemWindTypeSpeedType Speed { get; set; }
    }

    public class CurrentConditionsResponseItemWindTypeDirectionType
    {
        public int Degrees { get; set; }
        public string Localized { get; set; }
        public string English { get; set; }
    }

    public class CurrentConditionsResponseItemWindTypeSpeedType
    {
        public CurrentConditionsResponseItemWindTypeSpeedTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemWindTypeSpeedTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemWindTypeSpeedTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemWindTypeSpeedTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemWindGustType
    {
        public CurrentConditionsResponseItemWindGustTypeSpeedType Speed { get; set; }
    }

    public class CurrentConditionsResponseItemWindGustTypeSpeedType
    {
        public CurrentConditionsResponseItemWindGustTypeSpeedTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemWindGustTypeSpeedTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemWindGustTypeSpeedTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemWindGustTypeSpeedTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemVisibilityType
    {
        public CurrentConditionsResponseItemVisibilityTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemVisibilityTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemVisibilityTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemVisibilityTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemCeilingType
    {
        public CurrentConditionsResponseItemCeilingTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemCeilingTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemCeilingTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemCeilingTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPressureType
    {
        public CurrentConditionsResponseItemPressureTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemPressureTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemPressureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPressureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPressureTendencyType
    {
        public string LocalizedText { get; set; }
        public string Code { get; set; }
    }

    public class CurrentConditionsResponseItemPast24HourTemperatureDepartureType
    {
        public CurrentConditionsResponseItemPast24HourTemperatureDepartureTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemPast24HourTemperatureDepartureTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemPast24HourTemperatureDepartureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPast24HourTemperatureDepartureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemApparentTemperatureType
    {
        public CurrentConditionsResponseItemApparentTemperatureTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemApparentTemperatureTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemApparentTemperatureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemApparentTemperatureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemWindChillTemperatureType
    {
        public CurrentConditionsResponseItemWindChillTemperatureTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemWindChillTemperatureTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemWindChillTemperatureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemWindChillTemperatureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemWetBulbTemperatureType
    {
        public CurrentConditionsResponseItemWetBulbTemperatureTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemWetBulbTemperatureTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemWetBulbTemperatureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemWetBulbTemperatureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPrecip1hrType
    {
        public CurrentConditionsResponseItemPrecip1hrTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemPrecip1hrTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemPrecip1hrTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPrecip1hrTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryType
    {
        public CurrentConditionsResponseItemPrecipitationSummaryTypePrecipitationType Precipitation { get; set; }
        public CurrentConditionsResponseItemPrecipitationSummaryTypePastHourType PastHour { get; set; }
        public CurrentConditionsResponseItemPrecipitationSummaryTypePast3HoursType Past3Hours { get; set; }
        public CurrentConditionsResponseItemPrecipitationSummaryTypePast6HoursType Past6Hours { get; set; }
        public CurrentConditionsResponseItemPrecipitationSummaryTypePast9HoursType Past9Hours { get; set; }
        public CurrentConditionsResponseItemPrecipitationSummaryTypePast12HoursType Past12Hours { get; set; }
        public CurrentConditionsResponseItemPrecipitationSummaryTypePast18HoursType Past18Hours { get; set; }
        public CurrentConditionsResponseItemPrecipitationSummaryTypePast24HoursType Past24Hours { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePrecipitationType
    {
        public CurrentConditionsResponseItemPrecipitationSummaryTypePrecipitationTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemPrecipitationSummaryTypePrecipitationTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePrecipitationTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePrecipitationTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePastHourType
    {
        public CurrentConditionsResponseItemPrecipitationSummaryTypePastHourTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemPrecipitationSummaryTypePastHourTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePastHourTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePastHourTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePast3HoursType
    {
        public CurrentConditionsResponseItemPrecipitationSummaryTypePast3HoursTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemPrecipitationSummaryTypePast3HoursTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePast3HoursTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePast3HoursTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePast6HoursType
    {
        public CurrentConditionsResponseItemPrecipitationSummaryTypePast6HoursTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemPrecipitationSummaryTypePast6HoursTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePast6HoursTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePast6HoursTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePast9HoursType
    {
        public CurrentConditionsResponseItemPrecipitationSummaryTypePast9HoursTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemPrecipitationSummaryTypePast9HoursTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePast9HoursTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePast9HoursTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePast12HoursType
    {
        public CurrentConditionsResponseItemPrecipitationSummaryTypePast12HoursTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemPrecipitationSummaryTypePast12HoursTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePast12HoursTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePast12HoursTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePast18HoursType
    {
        public CurrentConditionsResponseItemPrecipitationSummaryTypePast18HoursTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemPrecipitationSummaryTypePast18HoursTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePast18HoursTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePast18HoursTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePast24HoursType
    {
        public CurrentConditionsResponseItemPrecipitationSummaryTypePast24HoursTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemPrecipitationSummaryTypePast24HoursTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePast24HoursTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemPrecipitationSummaryTypePast24HoursTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryType
    {
        public CurrentConditionsResponseItemTemperatureSummaryTypePast6HourRangeType Past6HourRange { get; set; }
        public CurrentConditionsResponseItemTemperatureSummaryTypePast12HourRangeType Past12HourRange { get; set; }
        public CurrentConditionsResponseItemTemperatureSummaryTypePast24HourRangeType Past24HourRange { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryTypePast6HourRangeType
    {
        public CurrentConditionsResponseItemTemperatureSummaryTypePast6HourRangeTypeMinimumType Minimum { get; set; }
        public CurrentConditionsResponseItemTemperatureSummaryTypePast6HourRangeTypeMaximumType Maximum { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryTypePast6HourRangeTypeMinimumType
    {
        public CurrentConditionsResponseItemTemperatureSummaryTypePast6HourRangeTypeMinimumTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemTemperatureSummaryTypePast6HourRangeTypeMinimumTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryTypePast6HourRangeTypeMinimumTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryTypePast6HourRangeTypeMinimumTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryTypePast6HourRangeTypeMaximumType
    {
        public CurrentConditionsResponseItemTemperatureSummaryTypePast6HourRangeTypeMaximumTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemTemperatureSummaryTypePast6HourRangeTypeMaximumTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryTypePast6HourRangeTypeMaximumTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryTypePast6HourRangeTypeMaximumTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryTypePast12HourRangeType
    {
        public CurrentConditionsResponseItemTemperatureSummaryTypePast12HourRangeTypeMinimumType Minimum { get; set; }
        public CurrentConditionsResponseItemTemperatureSummaryTypePast12HourRangeTypeMaximumType Maximum { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryTypePast12HourRangeTypeMinimumType
    {
        public CurrentConditionsResponseItemTemperatureSummaryTypePast12HourRangeTypeMinimumTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemTemperatureSummaryTypePast12HourRangeTypeMinimumTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryTypePast12HourRangeTypeMinimumTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryTypePast12HourRangeTypeMinimumTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryTypePast12HourRangeTypeMaximumType
    {
        public CurrentConditionsResponseItemTemperatureSummaryTypePast12HourRangeTypeMaximumTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemTemperatureSummaryTypePast12HourRangeTypeMaximumTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryTypePast12HourRangeTypeMaximumTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryTypePast12HourRangeTypeMaximumTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryTypePast24HourRangeType
    {
        public CurrentConditionsResponseItemTemperatureSummaryTypePast24HourRangeTypeMinimumType Minimum { get; set; }
        public CurrentConditionsResponseItemTemperatureSummaryTypePast24HourRangeTypeMaximumType Maximum { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryTypePast24HourRangeTypeMinimumType
    {
        public CurrentConditionsResponseItemTemperatureSummaryTypePast24HourRangeTypeMinimumTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemTemperatureSummaryTypePast24HourRangeTypeMinimumTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryTypePast24HourRangeTypeMinimumTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryTypePast24HourRangeTypeMinimumTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryTypePast24HourRangeTypeMaximumType
    {
        public CurrentConditionsResponseItemTemperatureSummaryTypePast24HourRangeTypeMaximumTypeMetricType Metric { get; set; }
        public CurrentConditionsResponseItemTemperatureSummaryTypePast24HourRangeTypeMaximumTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryTypePast24HourRangeTypeMaximumTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsResponseItemTemperatureSummaryTypePast24HourRangeTypeMaximumTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsTopCitiesResponseItem
    {
        public string Key { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
        public CurrentConditionsTopCitiesResponseItemCountryType Country { get; set; }
        public CurrentConditionsTopCitiesResponseItemTimeZoneType TimeZone { get; set; }
        public CurrentConditionsTopCitiesResponseItemGeoPositionType GeoPosition { get; set; }
        public string LocalObservationDateTime { get; set; }
        public int EpochTime { get; set; }
        public string WeatherText { get; set; }
        public int WeatherIcon { get; set; }
        public bool HasPrecipitation { get; set; }
        public string PrecipitationType { get; set; }
        public bool IsDayTime { get; set; }
        public CurrentConditionsTopCitiesResponseItemTemperatureType Temperature { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }
        public CurrentConditionsTopCitiesResponseItemLocalSourceType LocalSource { get; set; }
    }

    public class CurrentConditionsTopCitiesResponseItemCountryType
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
    }

    public class CurrentConditionsTopCitiesResponseItemTimeZoneType
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public double GmtOffset { get; set; }
        public bool IsDaylightSaving { get; set; }
        public string NextOffsetChange { get; set; }
    }

    public class CurrentConditionsTopCitiesResponseItemGeoPositionType
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public CurrentConditionsTopCitiesResponseItemGeoPositionTypeElevationType Elevation { get; set; }
    }

    public class CurrentConditionsTopCitiesResponseItemGeoPositionTypeElevationType
    {
        public CurrentConditionsTopCitiesResponseItemGeoPositionTypeElevationTypeMetricType Metric { get; set; }
        public CurrentConditionsTopCitiesResponseItemGeoPositionTypeElevationTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsTopCitiesResponseItemGeoPositionTypeElevationTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsTopCitiesResponseItemGeoPositionTypeElevationTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsTopCitiesResponseItemTemperatureType
    {
        public CurrentConditionsTopCitiesResponseItemTemperatureTypeMetricType Metric { get; set; }
        public CurrentConditionsTopCitiesResponseItemTemperatureTypeImperialType Imperial { get; set; }
    }

    public class CurrentConditionsTopCitiesResponseItemTemperatureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsTopCitiesResponseItemTemperatureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class CurrentConditionsTopCitiesResponseItemLocalSourceType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WeatherCode { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItem
    {
        public string LocalObservationDateTime { get; set; }
        public int EpochTime { get; set; }
        public string WeatherText { get; set; }
        public int WeatherIcon { get; set; }
        public bool HasPrecipitation { get; set; }
        public string PrecipitationType { get; set; }
        public bool IsDayTime { get; set; }
        public HistoricalCurrentConditions24HResponseItemTemperatureType Temperature { get; set; }
        public HistoricalCurrentConditions24HResponseItemRealFeelTemperatureType RealFeelTemperature { get; set; }
        public HistoricalCurrentConditions24HResponseItemRealFeelTemperatureShadeType RealFeelTemperatureShade { get; set; }
        public int RelativeHumidity { get; set; }
        public int IndoorRelativeHumidity { get; set; }
        public HistoricalCurrentConditions24HResponseItemDewPointType DewPoint { get; set; }
        public HistoricalCurrentConditions24HResponseItemWindType Wind { get; set; }
        public HistoricalCurrentConditions24HResponseItemWindGustType WindGust { get; set; }
        public int UVIndex { get; set; }
        public string UVIndexText { get; set; }
        public HistoricalCurrentConditions24HResponseItemVisibilityType Visibility { get; set; }
        public string ObstructionsToVisibility { get; set; }
        public int CloudCover { get; set; }
        public HistoricalCurrentConditions24HResponseItemCeilingType Ceiling { get; set; }
        public HistoricalCurrentConditions24HResponseItemPressureType Pressure { get; set; }
        public HistoricalCurrentConditions24HResponseItemPressureTendencyType PressureTendency { get; set; }
        public HistoricalCurrentConditions24HResponseItemPast24HourTemperatureDepartureType Past24HourTemperatureDeparture { get; set; }
        public HistoricalCurrentConditions24HResponseItemApparentTemperatureType ApparentTemperature { get; set; }
        public HistoricalCurrentConditions24HResponseItemWindChillTemperatureType WindChillTemperature { get; set; }
        public HistoricalCurrentConditions24HResponseItemWetBulbTemperatureType WetBulbTemperature { get; set; }
        public HistoricalCurrentConditions24HResponseItemPrecip1hrType Precip1hr { get; set; }
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryType PrecipitationSummary { get; set; }
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryType TemperatureSummary { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureType
    {
        public HistoricalCurrentConditions24HResponseItemTemperatureTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemTemperatureTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemRealFeelTemperatureType
    {
        public HistoricalCurrentConditions24HResponseItemRealFeelTemperatureTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemRealFeelTemperatureTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemRealFeelTemperatureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemRealFeelTemperatureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemRealFeelTemperatureShadeType
    {
        public HistoricalCurrentConditions24HResponseItemRealFeelTemperatureShadeTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemRealFeelTemperatureShadeTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemRealFeelTemperatureShadeTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemRealFeelTemperatureShadeTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemDewPointType
    {
        public HistoricalCurrentConditions24HResponseItemDewPointTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemDewPointTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemDewPointTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemDewPointTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemWindType
    {
        public HistoricalCurrentConditions24HResponseItemWindTypeDirectionType Direction { get; set; }
        public HistoricalCurrentConditions24HResponseItemWindTypeSpeedType Speed { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemWindTypeDirectionType
    {
        public int Degrees { get; set; }
        public string Localized { get; set; }
        public string English { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemWindTypeSpeedType
    {
        public HistoricalCurrentConditions24HResponseItemWindTypeSpeedTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemWindTypeSpeedTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemWindTypeSpeedTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemWindTypeSpeedTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemWindGustType
    {
        public HistoricalCurrentConditions24HResponseItemWindGustTypeSpeedType Speed { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemWindGustTypeSpeedType
    {
        public HistoricalCurrentConditions24HResponseItemWindGustTypeSpeedTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemWindGustTypeSpeedTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemWindGustTypeSpeedTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemWindGustTypeSpeedTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemVisibilityType
    {
        public HistoricalCurrentConditions24HResponseItemVisibilityTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemVisibilityTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemVisibilityTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemVisibilityTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemCeilingType
    {
        public HistoricalCurrentConditions24HResponseItemCeilingTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemCeilingTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemCeilingTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemCeilingTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPressureType
    {
        public HistoricalCurrentConditions24HResponseItemPressureTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemPressureTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPressureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPressureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPressureTendencyType
    {
        public string LocalizedText { get; set; }
        public string Code { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPast24HourTemperatureDepartureType
    {
        public HistoricalCurrentConditions24HResponseItemPast24HourTemperatureDepartureTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemPast24HourTemperatureDepartureTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPast24HourTemperatureDepartureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPast24HourTemperatureDepartureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemApparentTemperatureType
    {
        public HistoricalCurrentConditions24HResponseItemApparentTemperatureTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemApparentTemperatureTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemApparentTemperatureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemApparentTemperatureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemWindChillTemperatureType
    {
        public HistoricalCurrentConditions24HResponseItemWindChillTemperatureTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemWindChillTemperatureTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemWindChillTemperatureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemWindChillTemperatureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemWetBulbTemperatureType
    {
        public HistoricalCurrentConditions24HResponseItemWetBulbTemperatureTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemWetBulbTemperatureTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemWetBulbTemperatureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemWetBulbTemperatureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecip1hrType
    {
        public HistoricalCurrentConditions24HResponseItemPrecip1hrTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemPrecip1hrTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecip1hrTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecip1hrTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryType
    {
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePrecipitationType Precipitation { get; set; }
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePastHourType PastHour { get; set; }
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast3HoursType Past3Hours { get; set; }
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast6HoursType Past6Hours { get; set; }
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast9HoursType Past9Hours { get; set; }
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast12HoursType Past12Hours { get; set; }
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast18HoursType Past18Hours { get; set; }
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast24HoursType Past24Hours { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePrecipitationType
    {
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePrecipitationTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePrecipitationTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePrecipitationTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePrecipitationTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePastHourType
    {
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePastHourTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePastHourTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePastHourTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePastHourTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast3HoursType
    {
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast3HoursTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast3HoursTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast3HoursTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast3HoursTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast6HoursType
    {
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast6HoursTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast6HoursTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast6HoursTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast6HoursTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast9HoursType
    {
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast9HoursTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast9HoursTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast9HoursTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast9HoursTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast12HoursType
    {
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast12HoursTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast12HoursTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast12HoursTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast12HoursTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast18HoursType
    {
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast18HoursTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast18HoursTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast18HoursTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast18HoursTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast24HoursType
    {
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast24HoursTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast24HoursTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast24HoursTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemPrecipitationSummaryTypePast24HoursTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryType
    {
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast6HourRangeType Past6HourRange { get; set; }
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast12HourRangeType Past12HourRange { get; set; }
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast24HourRangeType Past24HourRange { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast6HourRangeType
    {
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast6HourRangeTypeMinimumType Minimum { get; set; }
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast6HourRangeTypeMaximumType Maximum { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast6HourRangeTypeMinimumType
    {
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast6HourRangeTypeMinimumTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast6HourRangeTypeMinimumTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast6HourRangeTypeMinimumTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast6HourRangeTypeMinimumTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast6HourRangeTypeMaximumType
    {
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast6HourRangeTypeMaximumTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast6HourRangeTypeMaximumTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast6HourRangeTypeMaximumTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast6HourRangeTypeMaximumTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast12HourRangeType
    {
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast12HourRangeTypeMinimumType Minimum { get; set; }
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast12HourRangeTypeMaximumType Maximum { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast12HourRangeTypeMinimumType
    {
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast12HourRangeTypeMinimumTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast12HourRangeTypeMinimumTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast12HourRangeTypeMinimumTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast12HourRangeTypeMinimumTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast12HourRangeTypeMaximumType
    {
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast12HourRangeTypeMaximumTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast12HourRangeTypeMaximumTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast12HourRangeTypeMaximumTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast12HourRangeTypeMaximumTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast24HourRangeType
    {
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast24HourRangeTypeMinimumType Minimum { get; set; }
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast24HourRangeTypeMaximumType Maximum { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast24HourRangeTypeMinimumType
    {
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast24HourRangeTypeMinimumTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast24HourRangeTypeMinimumTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast24HourRangeTypeMinimumTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast24HourRangeTypeMinimumTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast24HourRangeTypeMaximumType
    {
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast24HourRangeTypeMaximumTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast24HourRangeTypeMaximumTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast24HourRangeTypeMaximumTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions24HResponseItemTemperatureSummaryTypePast24HourRangeTypeMaximumTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItem
    {
        public string LocalObservationDateTime { get; set; }
        public int EpochTime { get; set; }
        public string WeatherText { get; set; }
        public int WeatherIcon { get; set; }
        public bool HasPrecipitation { get; set; }
        public string PrecipitationType { get; set; }
        public bool IsDayTime { get; set; }
        public HistoricalCurrentConditions6HResponseItemTemperatureType Temperature { get; set; }
        public HistoricalCurrentConditions6HResponseItemRealFeelTemperatureType RealFeelTemperature { get; set; }
        public HistoricalCurrentConditions6HResponseItemRealFeelTemperatureShadeType RealFeelTemperatureShade { get; set; }
        public int RelativeHumidity { get; set; }
        public int IndoorRelativeHumidity { get; set; }
        public HistoricalCurrentConditions6HResponseItemDewPointType DewPoint { get; set; }
        public HistoricalCurrentConditions6HResponseItemWindType Wind { get; set; }
        public HistoricalCurrentConditions6HResponseItemWindGustType WindGust { get; set; }
        public int UVIndex { get; set; }
        public string UVIndexText { get; set; }
        public HistoricalCurrentConditions6HResponseItemVisibilityType Visibility { get; set; }
        public string ObstructionsToVisibility { get; set; }
        public int CloudCover { get; set; }
        public HistoricalCurrentConditions6HResponseItemCeilingType Ceiling { get; set; }
        public HistoricalCurrentConditions6HResponseItemPressureType Pressure { get; set; }
        public HistoricalCurrentConditions6HResponseItemPressureTendencyType PressureTendency { get; set; }
        public HistoricalCurrentConditions6HResponseItemPast24HourTemperatureDepartureType Past24HourTemperatureDeparture { get; set; }
        public HistoricalCurrentConditions6HResponseItemApparentTemperatureType ApparentTemperature { get; set; }
        public HistoricalCurrentConditions6HResponseItemWindChillTemperatureType WindChillTemperature { get; set; }
        public HistoricalCurrentConditions6HResponseItemWetBulbTemperatureType WetBulbTemperature { get; set; }
        public HistoricalCurrentConditions6HResponseItemPrecip1hrType Precip1hr { get; set; }
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryType PrecipitationSummary { get; set; }
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryType TemperatureSummary { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureType
    {
        public HistoricalCurrentConditions6HResponseItemTemperatureTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemTemperatureTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemRealFeelTemperatureType
    {
        public HistoricalCurrentConditions6HResponseItemRealFeelTemperatureTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemRealFeelTemperatureTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemRealFeelTemperatureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemRealFeelTemperatureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemRealFeelTemperatureShadeType
    {
        public HistoricalCurrentConditions6HResponseItemRealFeelTemperatureShadeTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemRealFeelTemperatureShadeTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemRealFeelTemperatureShadeTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemRealFeelTemperatureShadeTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemDewPointType
    {
        public HistoricalCurrentConditions6HResponseItemDewPointTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemDewPointTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemDewPointTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemDewPointTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemWindType
    {
        public HistoricalCurrentConditions6HResponseItemWindTypeDirectionType Direction { get; set; }
        public HistoricalCurrentConditions6HResponseItemWindTypeSpeedType Speed { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemWindTypeDirectionType
    {
        public int Degrees { get; set; }
        public string Localized { get; set; }
        public string English { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemWindTypeSpeedType
    {
        public HistoricalCurrentConditions6HResponseItemWindTypeSpeedTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemWindTypeSpeedTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemWindTypeSpeedTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemWindTypeSpeedTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemWindGustType
    {
        public HistoricalCurrentConditions6HResponseItemWindGustTypeSpeedType Speed { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemWindGustTypeSpeedType
    {
        public HistoricalCurrentConditions6HResponseItemWindGustTypeSpeedTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemWindGustTypeSpeedTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemWindGustTypeSpeedTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemWindGustTypeSpeedTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemVisibilityType
    {
        public HistoricalCurrentConditions6HResponseItemVisibilityTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemVisibilityTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemVisibilityTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemVisibilityTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemCeilingType
    {
        public HistoricalCurrentConditions6HResponseItemCeilingTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemCeilingTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemCeilingTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemCeilingTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPressureType
    {
        public HistoricalCurrentConditions6HResponseItemPressureTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemPressureTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPressureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPressureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPressureTendencyType
    {
        public string LocalizedText { get; set; }
        public string Code { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPast24HourTemperatureDepartureType
    {
        public HistoricalCurrentConditions6HResponseItemPast24HourTemperatureDepartureTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemPast24HourTemperatureDepartureTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPast24HourTemperatureDepartureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPast24HourTemperatureDepartureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemApparentTemperatureType
    {
        public HistoricalCurrentConditions6HResponseItemApparentTemperatureTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemApparentTemperatureTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemApparentTemperatureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemApparentTemperatureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemWindChillTemperatureType
    {
        public HistoricalCurrentConditions6HResponseItemWindChillTemperatureTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemWindChillTemperatureTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemWindChillTemperatureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemWindChillTemperatureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemWetBulbTemperatureType
    {
        public HistoricalCurrentConditions6HResponseItemWetBulbTemperatureTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemWetBulbTemperatureTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemWetBulbTemperatureTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemWetBulbTemperatureTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecip1hrType
    {
        public HistoricalCurrentConditions6HResponseItemPrecip1hrTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemPrecip1hrTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecip1hrTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecip1hrTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryType
    {
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePrecipitationType Precipitation { get; set; }
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePastHourType PastHour { get; set; }
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast3HoursType Past3Hours { get; set; }
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast6HoursType Past6Hours { get; set; }
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast9HoursType Past9Hours { get; set; }
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast12HoursType Past12Hours { get; set; }
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast18HoursType Past18Hours { get; set; }
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast24HoursType Past24Hours { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePrecipitationType
    {
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePrecipitationTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePrecipitationTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePrecipitationTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePrecipitationTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePastHourType
    {
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePastHourTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePastHourTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePastHourTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePastHourTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast3HoursType
    {
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast3HoursTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast3HoursTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast3HoursTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast3HoursTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast6HoursType
    {
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast6HoursTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast6HoursTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast6HoursTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast6HoursTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast9HoursType
    {
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast9HoursTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast9HoursTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast9HoursTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast9HoursTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast12HoursType
    {
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast12HoursTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast12HoursTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast12HoursTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast12HoursTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast18HoursType
    {
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast18HoursTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast18HoursTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast18HoursTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast18HoursTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast24HoursType
    {
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast24HoursTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast24HoursTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast24HoursTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemPrecipitationSummaryTypePast24HoursTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryType
    {
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast6HourRangeType Past6HourRange { get; set; }
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast12HourRangeType Past12HourRange { get; set; }
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast24HourRangeType Past24HourRange { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast6HourRangeType
    {
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast6HourRangeTypeMinimumType Minimum { get; set; }
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast6HourRangeTypeMaximumType Maximum { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast6HourRangeTypeMinimumType
    {
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast6HourRangeTypeMinimumTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast6HourRangeTypeMinimumTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast6HourRangeTypeMinimumTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast6HourRangeTypeMinimumTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast6HourRangeTypeMaximumType
    {
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast6HourRangeTypeMaximumTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast6HourRangeTypeMaximumTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast6HourRangeTypeMaximumTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast6HourRangeTypeMaximumTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast12HourRangeType
    {
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast12HourRangeTypeMinimumType Minimum { get; set; }
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast12HourRangeTypeMaximumType Maximum { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast12HourRangeTypeMinimumType
    {
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast12HourRangeTypeMinimumTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast12HourRangeTypeMinimumTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast12HourRangeTypeMinimumTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast12HourRangeTypeMinimumTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast12HourRangeTypeMaximumType
    {
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast12HourRangeTypeMaximumTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast12HourRangeTypeMaximumTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast12HourRangeTypeMaximumTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast12HourRangeTypeMaximumTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast24HourRangeType
    {
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast24HourRangeTypeMinimumType Minimum { get; set; }
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast24HourRangeTypeMaximumType Maximum { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast24HourRangeTypeMinimumType
    {
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast24HourRangeTypeMinimumTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast24HourRangeTypeMinimumTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast24HourRangeTypeMinimumTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast24HourRangeTypeMinimumTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast24HourRangeTypeMaximumType
    {
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast24HourRangeTypeMaximumTypeMetricType Metric { get; set; }
        public HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast24HourRangeTypeMaximumTypeImperialType Imperial { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast24HourRangeTypeMaximumTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class HistoricalCurrentConditions6HResponseItemTemperatureSummaryTypePast24HourRangeTypeMaximumTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class DailyIndexValuesByGroupOfIndiciesResponseItem
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool Ascending { get; set; }
        public string LocalDateTime { get; set; }
        public int EpochDateTime { get; set; }
        public double Value { get; set; }
        public string Category { get; set; }
        public int CategoryValue { get; set; }
        public string Text { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }
    }

    public class DailyIndexValuesBySpecificIndexResponseItem
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool Ascending { get; set; }
        public string LocalDateTime { get; set; }
        public int EpochDateTime { get; set; }
        public double Value { get; set; }
        public string Category { get; set; }
        public int CategoryValue { get; set; }
        public string Text { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }
    }

    public class DailyIndexValuesForAllIndicesResponseItem
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool Ascending { get; set; }
        public string LocalDateTime { get; set; }
        public int EpochDateTime { get; set; }
        public double Value { get; set; }
        public string Category { get; set; }
        public int CategoryValue { get; set; }
        public string Text { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }
    }

    public class ListDailyIndicesResponseItem
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool Ascending { get; set; }
        public string Description { get; set; }
    }

    public class ListIndexGroupsResponseItem
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }

    public class ListOfIndiciesInAGroupByGroupIdResponseItem
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool Ascending { get; set; }
        public string Description { get; set; }
    }

    public class SearchLocationKeyResponse
    {
        public int Version { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public int Rank { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
        public string PrimaryPostalCode { get; set; }
        public SearchLocationKeyResponseRegionType Region { get; set; }
        public SearchLocationKeyResponseCountryType Country { get; set; }
        public SearchLocationKeyResponseAdministrativeAreaType AdministrativeArea { get; set; }
        public SearchLocationKeyResponseTimeZoneType TimeZone { get; set; }
        public SearchLocationKeyResponseGeoPositionType GeoPosition { get; set; }
        public bool IsAlias { get; set; }
        public SearchLocationKeyResponseSupplementalAdminAreasTypeItem[] SupplementalAdminAreas { get; set; }
        public string[] DataSets { get; set; }
    }

    public class SearchLocationKeyResponseRegionType
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
    }

    public class SearchLocationKeyResponseCountryType
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
    }

    public class SearchLocationKeyResponseAdministrativeAreaType
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
        public int Level { get; set; }
        public string LocalizedType { get; set; }
        public string EnglishType { get; set; }
        public string CountryID { get; set; }
    }

    public class SearchLocationKeyResponseTimeZoneType
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int GmtOffset { get; set; }
        public bool IsDaylightSaving { get; set; }
        public string NextOffsetChange { get; set; }
    }

    public class SearchLocationKeyResponseGeoPositionType
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public SearchLocationKeyResponseGeoPositionTypeElevationType Elevation { get; set; }
    }

    public class SearchLocationKeyResponseGeoPositionTypeElevationType
    {
        public SearchLocationKeyResponseGeoPositionTypeElevationTypeMetricType Metric { get; set; }
        public SearchLocationKeyResponseGeoPositionTypeElevationTypeImperialType Imperial { get; set; }
    }

    public class SearchLocationKeyResponseGeoPositionTypeElevationTypeMetricType
    {
        public int Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class SearchLocationKeyResponseGeoPositionTypeElevationTypeImperialType
    {
        public int Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class SearchLocationKeyResponseSupplementalAdminAreasTypeItem
    {
        public int Level { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
    }

    public class SearchLocationIPResponse
    {
        public int Version { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public int Rank { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
        public string PrimaryPostalCode { get; set; }
        public SearchLocationIPResponseRegionType Region { get; set; }
        public SearchLocationIPResponseCountryType Country { get; set; }
        public SearchLocationIPResponseAdministrativeAreaType AdministrativeArea { get; set; }
        public SearchLocationIPResponseTimeZoneType TimeZone { get; set; }
        public SearchLocationIPResponseGeoPositionType GeoPosition { get; set; }
        public bool IsAlias { get; set; }
        public SearchLocationIPResponseSupplementalAdminAreasTypeItem[] SupplementalAdminAreas { get; set; }
        public string[] DataSets { get; set; }
        public SearchLocationIPResponseDetailsType Details { get; set; }
    }

    public class SearchLocationIPResponseRegionType
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
    }

    public class SearchLocationIPResponseCountryType
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
    }

    public class SearchLocationIPResponseAdministrativeAreaType
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
        public int Level { get; set; }
        public string LocalizedType { get; set; }
        public string EnglishType { get; set; }
        public string CountryID { get; set; }
    }

    public class SearchLocationIPResponseTimeZoneType
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int GmtOffset { get; set; }
        public bool IsDaylightSaving { get; set; }
        public string NextOffsetChange { get; set; }
    }

    public class SearchLocationIPResponseGeoPositionType
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public SearchLocationIPResponseGeoPositionTypeElevationType Elevation { get; set; }
    }

    public class SearchLocationIPResponseGeoPositionTypeElevationType
    {
        public SearchLocationIPResponseGeoPositionTypeElevationTypeMetricType Metric { get; set; }
        public SearchLocationIPResponseGeoPositionTypeElevationTypeImperialType Imperial { get; set; }
    }

    public class SearchLocationIPResponseGeoPositionTypeElevationTypeMetricType
    {
        public int Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class SearchLocationIPResponseGeoPositionTypeElevationTypeImperialType
    {
        public int Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class SearchLocationIPResponseSupplementalAdminAreasTypeItem
    {
        public int Level { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
    }

    public class SearchLocationIPResponseDetailsType
    {
        public string Key { get; set; }
        public string StationCode { get; set; }
        public int StationGmtOffset { get; set; }
        public string BandMap { get; set; }
        public string Climo { get; set; }
        public string LocalRadar { get; set; }
        public string MediaRegion { get; set; }
        public string Metar { get; set; }
        public string NXMetro { get; set; }
        public string NXState { get; set; }
        public int Population { get; set; }
        public string PrimaryWarningCountyCode { get; set; }
        public string PrimaryWarningZoneCode { get; set; }
        public string Satellite { get; set; }
        public string Synoptic { get; set; }
        public string MarineStation { get; set; }
        public string MarineStationGMTOffset { get; set; }
        public string VideoCode { get; set; }
        public string LocationStem { get; set; }
        public SearchLocationIPResponseDetailsTypeDMAType DMA { get; set; }
        public string PartnerID { get; set; }
        public SearchLocationIPResponseDetailsTypeSourcesTypeItem[] Sources { get; set; }
        public string CanonicalPostalCode { get; set; }
        public string CanonicalLocationKey { get; set; }
    }

    public class SearchLocationIPResponseDetailsTypeDMAType
    {
        public string ID { get; set; }
        public string EnglishName { get; set; }
    }

    public class SearchLocationIPResponseDetailsTypeSourcesTypeItem
    {
        public string DataType { get; set; }
        public string Source { get; set; }
        public int SourceId { get; set; }
    }

    public class AlarmOneResponseItem
    {
        public string Date { get; set; }
        public int EpochDate { get; set; }
        public AlarmOneResponseItemAlarmsTypeItem[] Alarms { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }
    }

    public class AlarmOneResponseItemAlarmsTypeItem
    {
        public string AlarmType { get; set; }
        public AlarmOneResponseItemAlarmsTypeItemValueType Value { get; set; }
        public AlarmOneResponseItemAlarmsTypeItemDayType Day { get; set; }
    }

    public class AlarmOneResponseItemAlarmsTypeItemValueType
    {
        public AlarmOneResponseItemAlarmsTypeItemValueTypeMetricType Metric { get; set; }
        public AlarmOneResponseItemAlarmsTypeItemValueTypeImperialType Imperial { get; set; }
    }

    public class AlarmOneResponseItemAlarmsTypeItemValueTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class AlarmOneResponseItemAlarmsTypeItemValueTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class AlarmOneResponseItemAlarmsTypeItemDayType
    {
        public AlarmOneResponseItemAlarmsTypeItemDayTypeMetricType Metric { get; set; }
        public AlarmOneResponseItemAlarmsTypeItemDayTypeImperialType Imperial { get; set; }
    }

    public class AlarmOneResponseItemAlarmsTypeItemDayTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class AlarmOneResponseItemAlarmsTypeItemDayTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class AlarmFiveResponseItem
    {
        public string Date { get; set; }
        public int EpochDate { get; set; }
        public AlarmFiveResponseItemAlarmsTypeItem[] Alarms { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }
    }

    public class AlarmFiveResponseItemAlarmsTypeItem
    {
        public string AlarmType { get; set; }
        public AlarmFiveResponseItemAlarmsTypeItemValueType Value { get; set; }
        public AlarmFiveResponseItemAlarmsTypeItemDayType Day { get; set; }
    }

    public class AlarmFiveResponseItemAlarmsTypeItemValueType
    {
        public AlarmFiveResponseItemAlarmsTypeItemValueTypeMetricType Metric { get; set; }
        public AlarmFiveResponseItemAlarmsTypeItemValueTypeImperialType Imperial { get; set; }
    }

    public class AlarmFiveResponseItemAlarmsTypeItemValueTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class AlarmFiveResponseItemAlarmsTypeItemValueTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class AlarmFiveResponseItemAlarmsTypeItemDayType
    {
        public AlarmFiveResponseItemAlarmsTypeItemDayTypeMetricType Metric { get; set; }
        public AlarmFiveResponseItemAlarmsTypeItemDayTypeImperialType Imperial { get; set; }
    }

    public class AlarmFiveResponseItemAlarmsTypeItemDayTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class AlarmFiveResponseItemAlarmsTypeItemDayTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class AlarmTenResponseItem
    {
        public string Date { get; set; }
        public int EpochDate { get; set; }
        public AlarmTenResponseItemAlarmsTypeItem[] Alarms { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }
    }

    public class AlarmTenResponseItemAlarmsTypeItem
    {
        public string AlarmType { get; set; }
        public AlarmTenResponseItemAlarmsTypeItemValueType Value { get; set; }
        public AlarmTenResponseItemAlarmsTypeItemDayType Day { get; set; }
    }

    public class AlarmTenResponseItemAlarmsTypeItemValueType
    {
        public AlarmTenResponseItemAlarmsTypeItemValueTypeMetricType Metric { get; set; }
        public AlarmTenResponseItemAlarmsTypeItemValueTypeImperialType Imperial { get; set; }
    }

    public class AlarmTenResponseItemAlarmsTypeItemValueTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class AlarmTenResponseItemAlarmsTypeItemValueTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class AlarmTenResponseItemAlarmsTypeItemDayType
    {
        public AlarmTenResponseItemAlarmsTypeItemDayTypeMetricType Metric { get; set; }
        public AlarmTenResponseItemAlarmsTypeItemDayTypeImperialType Imperial { get; set; }
    }

    public class AlarmTenResponseItemAlarmsTypeItemDayTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class AlarmTenResponseItemAlarmsTypeItemDayTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class AlarmFifteenResponseItem
    {
        public string Date { get; set; }
        public int EpochDate { get; set; }
        public AlarmFifteenResponseItemAlarmsTypeItem[] Alarms { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }
    }

    public class AlarmFifteenResponseItemAlarmsTypeItem
    {
        public string AlarmType { get; set; }
        public AlarmFifteenResponseItemAlarmsTypeItemValueType Value { get; set; }
        public AlarmFifteenResponseItemAlarmsTypeItemDayType Day { get; set; }
    }

    public class AlarmFifteenResponseItemAlarmsTypeItemValueType
    {
        public AlarmFifteenResponseItemAlarmsTypeItemValueTypeMetricType Metric { get; set; }
        public AlarmFifteenResponseItemAlarmsTypeItemValueTypeImperialType Imperial { get; set; }
    }

    public class AlarmFifteenResponseItemAlarmsTypeItemValueTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class AlarmFifteenResponseItemAlarmsTypeItemValueTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class AlarmFifteenResponseItemAlarmsTypeItemDayType
    {
        public AlarmFifteenResponseItemAlarmsTypeItemDayTypeMetricType Metric { get; set; }
        public AlarmFifteenResponseItemAlarmsTypeItemDayTypeImperialType Imperial { get; set; }
    }

    public class AlarmFifteenResponseItemAlarmsTypeItemDayTypeMetricType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class AlarmFifteenResponseItemAlarmsTypeItemDayTypeImperialType
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }

    public class LanguageListResponseItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string LocalizedName { get; set; }
        public string ISO { get; set; }
        public int LanguageType { get; set; }
        public string MicroSoftName { get; set; }
        public string MicroSoftCode { get; set; }
        public string TimeStamp { get; set; }
    }

    public class LanguageGroupsResponseItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class LanguageTranslationsGroupResponseItem
    {
        public string LanguageCode { get; set; }
        public string PhraseCode { get; set; }
        public string Text { get; set; }
        public string DataCode { get; set; }
    }

    public class AlertLocationResponseItem
    {
        public string CountryCode { get; set; }
        public int AlertID { get; set; }
        public AlertLocationResponseItemDescriptionType Description { get; set; }
        public string Category { get; set; }
        public int Priority { get; set; }
        public string Type { get; set; }
        public string TypeId { get; set; }
        public string Class { get; set; }
        public string Level { get; set; }
        public AlertLocationResponseItemColorType Color { get; set; }
        public string Source { get; set; }
        public int SourceId { get; set; }
        public string Disclaimer { get; set; }
        public AlertLocationResponseItemAreaType Area { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }
    }

    public class AlertLocationResponseItemDescriptionType
    {
        public string Localized { get; set; }
        public string English { get; set; }
    }

    public class AlertLocationResponseItemColorType
    {
        public string Name { get; set; }
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public string Hex { get; set; }
    }

    public class AlertLocationResponseItemAreaType
    {
        public string Name { get; set; }
        public string StartTime { get; set; }
        public int EpochStartTime { get; set; }
        public string EndTime { get; set; }
        public int EpochEndTime { get; set; }
        public AlertLocationResponseItemAreaTypeLastActionType LastAction { get; set; }
        public string Text { get; set; }
        public string LanguageCode { get; set; }
        public string Summary { get; set; }
    }

    public class AlertLocationResponseItemAreaTypeLastActionType
    {
        public string Localized { get; set; }
        public string English { get; set; }
    }

    public class ImageryResponseItem
    {
        public string MobileLink { get; set; }
        public string Link { get; set; }
        public ImageryResponseItemRadarType Radar { get; set; }
        public ImageryResponseItemSatelliteType Satellite { get; set; }
    }

    public class ImageryResponseItemRadarType
    {
        public string Size { get; set; }
        public ImageryResponseItemRadarTypeImagesType Images { get; set; }
    }

    public class ImageryResponseItemRadarTypeImagesType
    {
        public string Date { get; set; }
        public string Url { get; set; }
    }

    public class ImageryResponseItemSatelliteType
    {
        public string Size { get; set; }
        public ImageryResponseItemSatelliteTypeImagesType Images { get; set; }
    }

    public class ImageryResponseItemSatelliteTypeImagesType
    {
        public string Date { get; set; }
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Accuweatherip;

    public partial class WorkflowManagedActions
    {
        public AccuweatheripActions Accuweatherip(string connectionId) => new AccuweatheripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AccuweatheripTriggers Accuweatherip(string connectionId) => new AccuweatheripTriggers(connectionId);
    }
}