//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dpirdweatherip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DpirdweatheripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<GetStationsResponse> GetStations(Expression<Func<string>> stationCode = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<bool>> includeClosed = null, Expression<Func<string>> sort = null, Expression<Func<string>> select = null, Expression<Func<groupInput>> group = null)
        {
            var apiCallPath = "/stations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (stationCode != null)
                callPayload.Queries["stationCode"] = CSharpExpressionConverter.ConvertO(stationCode);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (includeClosed != null)
                callPayload.Queries["includeClosed"] = CSharpExpressionConverter.ConvertO(includeClosed);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            if (group != null)
                callPayload.Queries["group"] = CSharpExpressionConverter.Convert(group);
            return new ApiConnectionAction<GetStationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<GetStationsAvailabilityResponse> GetStationsAvailability(Expression<Func<string>> stationCode = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = "/stations/availability";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (stationCode != null)
                callPayload.Queries["stationCode"] = CSharpExpressionConverter.ConvertO(stationCode);
            if (startDate != null)
                callPayload.Queries["startDate"] = CSharpExpressionConverter.ConvertO(startDate);
            if (endDate != null)
                callPayload.Queries["endDate"] = CSharpExpressionConverter.ConvertO(endDate);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<GetStationsAvailabilityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IWorkflowAction GetNearbyWeatherStations(Expression<Func<double>> latitude, Expression<Func<double>> longitude, Expression<Func<int>> radius = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<bool>> includeClosed = null, Expression<Func<string>> sort = null, Expression<Func<string>> select = null, Expression<Func<groupInput>> group = null)
        {
            var apiCallPath = "/stations/nearby";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["latitude"] = CSharpExpressionConverter.ConvertO(latitude);
            callPayload.Queries["longitude"] = CSharpExpressionConverter.ConvertO(longitude);
            if (radius != null)
                callPayload.Queries["radius"] = CSharpExpressionConverter.ConvertO(radius);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (includeClosed != null)
                callPayload.Queries["includeClosed"] = CSharpExpressionConverter.ConvertO(includeClosed);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            if (group != null)
                callPayload.Queries["group"] = CSharpExpressionConverter.Convert(group);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<GetStationResponse> GetStation(Expression<Func<string>> stationCode, Expression<Func<string>> select = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/station/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<GetStationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<GetWeatherStationAvailabilityResponse> GetWeatherStationAvailability(Expression<Func<string>> stationCode, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/stations/{0}/availability", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (startDate != null)
                callPayload.Queries["startDate"] = CSharpExpressionConverter.ConvertO(startDate);
            if (endDate != null)
                callPayload.Queries["endDate"] = CSharpExpressionConverter.ConvertO(endDate);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<GetWeatherStationAvailabilityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<GetStationsBulletinsResponse> GetStationsBulletins(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> stationCode = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<bool>> includeClosed = null, Expression<Func<string>> sort = null, Expression<Func<string>> select = null, Expression<Func<groupInput>> group = null)
        {
            var apiCallPath = "/stations/bulletins";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startDate"] = CSharpExpressionConverter.ConvertO(startDate);
            callPayload.Queries["endDate"] = CSharpExpressionConverter.ConvertO(endDate);
            if (stationCode != null)
                callPayload.Queries["stationCode"] = CSharpExpressionConverter.ConvertO(stationCode);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (includeClosed != null)
                callPayload.Queries["includeClosed"] = CSharpExpressionConverter.ConvertO(includeClosed);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            if (group != null)
                callPayload.Queries["group"] = CSharpExpressionConverter.Convert(group);
            return new ApiConnectionAction<GetStationsBulletinsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<GetWeatherStationsRainfallResponse> GetWeatherStationsRainfall(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> stationCode = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<bool>> includeClosed = null, Expression<Func<string>> sort = null, Expression<Func<string>> select = null, Expression<Func<groupInput>> group = null)
        {
            var apiCallPath = "/stations/rainfall";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startDate"] = CSharpExpressionConverter.ConvertO(startDate);
            callPayload.Queries["endDate"] = CSharpExpressionConverter.ConvertO(endDate);
            if (stationCode != null)
                callPayload.Queries["stationCode"] = CSharpExpressionConverter.ConvertO(stationCode);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (includeClosed != null)
                callPayload.Queries["includeClosed"] = CSharpExpressionConverter.ConvertO(includeClosed);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            if (group != null)
                callPayload.Queries["group"] = CSharpExpressionConverter.Convert(group);
            return new ApiConnectionAction<GetWeatherStationsRainfallResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<GetWeatherStationRainfallResponse> GetWeatherStationRainfall(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> stationCode = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<bool>> includeClosed = null, Expression<Func<string>> sort = null, Expression<Func<string>> select = null, Expression<Func<groupInput>> group = null)
        {
            var apiCallPath = "/stations1/rainfall";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (stationCode != null)
                callPayload.Queries["stationCode"] = CSharpExpressionConverter.ConvertO(stationCode);
            callPayload.Queries["startDate"] = CSharpExpressionConverter.ConvertO(startDate);
            callPayload.Queries["endDate"] = CSharpExpressionConverter.ConvertO(endDate);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (includeClosed != null)
                callPayload.Queries["includeClosed"] = CSharpExpressionConverter.ConvertO(includeClosed);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            if (group != null)
                callPayload.Queries["group"] = CSharpExpressionConverter.Convert(group);
            return new ApiConnectionAction<GetWeatherStationRainfallResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<GetStationsExtremeConditionsResponse> GetStationsExtremeConditions(Expression<Func<string>> stationCode = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<string>> select = null, Expression<Func<groupInput>> group = null, Expression<Func<bool>> includeClosed = null)
        {
            var apiCallPath = "/stations/extreme-conditions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (stationCode != null)
                callPayload.Queries["stationCode"] = CSharpExpressionConverter.ConvertO(stationCode);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            if (group != null)
                callPayload.Queries["group"] = CSharpExpressionConverter.Convert(group);
            if (includeClosed != null)
                callPayload.Queries["includeClosed"] = CSharpExpressionConverter.ConvertO(includeClosed);
            return new ApiConnectionAction<GetStationsExtremeConditionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<GetStationsExtremeEventsResponse> GetStationsExtremeEvents(Expression<Func<@operatorInput>> @operator, Expression<Func<int>> threshold, Expression<Func<propertyInput>> property, Expression<Func<string>> startDateTime, Expression<Func<string>> endDateTime, Expression<Func<string>> stationCode = null, Expression<Func<intervalInput>> interval = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = "/stations/events";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (stationCode != null)
                callPayload.Queries["stationCode"] = CSharpExpressionConverter.ConvertO(stationCode);
            callPayload.Queries["operator"] = CSharpExpressionConverter.Convert(@operator);
            callPayload.Queries["threshold"] = CSharpExpressionConverter.ConvertO(threshold);
            callPayload.Queries["property"] = CSharpExpressionConverter.Convert(property);
            callPayload.Queries["startDateTime"] = CSharpExpressionConverter.ConvertO(startDateTime);
            callPayload.Queries["endDateTime"] = CSharpExpressionConverter.ConvertO(endDateTime);
            if (interval != null)
                callPayload.Queries["interval"] = CSharpExpressionConverter.Convert(interval);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<GetStationsExtremeEventsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<GetStationsLatestDataResponse> GetStationsLatestData(Expression<Func<string>> stationCode = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> select = null, Expression<Func<groupInput>> group = null)
        {
            var apiCallPath = "/stations/latest";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (stationCode != null)
                callPayload.Queries["stationCode"] = CSharpExpressionConverter.ConvertO(stationCode);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            if (group != null)
                callPayload.Queries["group"] = CSharpExpressionConverter.Convert(group);
            return new ApiConnectionAction<GetStationsLatestDataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<GetStationBulletinsResponse> GetStationBulletins(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> stationCode, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/stations/{0}/bulletin", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startDate"] = CSharpExpressionConverter.ConvertO(startDate);
            callPayload.Queries["endDate"] = CSharpExpressionConverter.ConvertO(endDate);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<GetStationBulletinsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<GetStationLatestDataResponse> GetStationLatestData(Expression<Func<string>> stationCode, Expression<Func<string>> select = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/stations/{0}/latest", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<GetStationLatestDataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<GetStationMinuteDataResponse> GetStationMinuteData(Expression<Func<string>> stationCode, Expression<Func<string>> startDateTime, Expression<Func<string>> endDateTime, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/stations/{0}/data", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startDateTime"] = CSharpExpressionConverter.ConvertO(startDateTime);
            callPayload.Queries["endDateTime"] = CSharpExpressionConverter.ConvertO(endDateTime);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<GetStationMinuteDataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<MultiStationSummarySchemaModel> GetStations15minSummary(Expression<Func<string>> startDateTime, Expression<Func<string>> endDateTime, Expression<Func<string>> stationCode = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<groupInput>> group = null, Expression<Func<bool>> includeClosed = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = "/stations/summaries/15min";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startDateTime"] = CSharpExpressionConverter.ConvertO(startDateTime);
            callPayload.Queries["endDateTime"] = CSharpExpressionConverter.ConvertO(endDateTime);
            if (stationCode != null)
                callPayload.Queries["stationCode"] = CSharpExpressionConverter.ConvertO(stationCode);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (group != null)
                callPayload.Queries["group"] = CSharpExpressionConverter.Convert(group);
            if (includeClosed != null)
                callPayload.Queries["includeClosed"] = CSharpExpressionConverter.ConvertO(includeClosed);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<MultiStationSummarySchemaModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<MultiStationSummarySchemaModel> GetStations30minSummary(Expression<Func<string>> startDateTime, Expression<Func<string>> endDateTime, Expression<Func<string>> stationCode = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<groupInput>> group = null, Expression<Func<bool>> includeClosed = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = "/stations/summaries/30min";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startDateTime"] = CSharpExpressionConverter.ConvertO(startDateTime);
            callPayload.Queries["endDateTime"] = CSharpExpressionConverter.ConvertO(endDateTime);
            if (stationCode != null)
                callPayload.Queries["stationCode"] = CSharpExpressionConverter.ConvertO(stationCode);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (group != null)
                callPayload.Queries["group"] = CSharpExpressionConverter.Convert(group);
            if (includeClosed != null)
                callPayload.Queries["includeClosed"] = CSharpExpressionConverter.ConvertO(includeClosed);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<MultiStationSummarySchemaModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<MultiStationSummarySchemaModel> GetStationsHourlySummary(Expression<Func<string>> startDateTime, Expression<Func<string>> endDateTime, Expression<Func<string>> stationCode = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<groupInput>> group = null, Expression<Func<bool>> includeClosed = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = "/stations/summaries/hourly";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startDateTime"] = CSharpExpressionConverter.ConvertO(startDateTime);
            callPayload.Queries["endDateTime"] = CSharpExpressionConverter.ConvertO(endDateTime);
            if (stationCode != null)
                callPayload.Queries["stationCode"] = CSharpExpressionConverter.ConvertO(stationCode);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (group != null)
                callPayload.Queries["group"] = CSharpExpressionConverter.Convert(group);
            if (includeClosed != null)
                callPayload.Queries["includeClosed"] = CSharpExpressionConverter.ConvertO(includeClosed);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<MultiStationSummarySchemaModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<MultiStationSummarySchemaModel> GetStationsDailySummary(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> stationCode = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<groupInput>> group = null, Expression<Func<bool>> includeClosed = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = "/stations/summaries/daily";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startDate"] = CSharpExpressionConverter.ConvertO(startDate);
            callPayload.Queries["endDate"] = CSharpExpressionConverter.ConvertO(endDate);
            if (stationCode != null)
                callPayload.Queries["stationCode"] = CSharpExpressionConverter.ConvertO(stationCode);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (group != null)
                callPayload.Queries["group"] = CSharpExpressionConverter.Convert(group);
            if (includeClosed != null)
                callPayload.Queries["includeClosed"] = CSharpExpressionConverter.ConvertO(includeClosed);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<MultiStationSummarySchemaModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<MultiStationSummarySchemaModel> GetStationsMonthlySummary(Expression<Func<string>> startMonth, Expression<Func<string>> endMonth, Expression<Func<string>> stationCode = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<groupInput>> group = null, Expression<Func<bool>> includeClosed = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = "/stations/summaries/monthly";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startMonth"] = CSharpExpressionConverter.ConvertO(startMonth);
            callPayload.Queries["endMonth"] = CSharpExpressionConverter.ConvertO(endMonth);
            if (stationCode != null)
                callPayload.Queries["stationCode"] = CSharpExpressionConverter.ConvertO(stationCode);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (group != null)
                callPayload.Queries["group"] = CSharpExpressionConverter.Convert(group);
            if (includeClosed != null)
                callPayload.Queries["includeClosed"] = CSharpExpressionConverter.ConvertO(includeClosed);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<MultiStationSummarySchemaModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<MultiStationSummarySchemaModel> GetStationsYearlySummary(Expression<Func<string>> startYear, Expression<Func<string>> endYear, Expression<Func<string>> stationCode = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<groupInput>> group = null, Expression<Func<bool>> includeClosed = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = "/stations/summaries/yearly";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startYear"] = CSharpExpressionConverter.ConvertO(startYear);
            callPayload.Queries["endYear"] = CSharpExpressionConverter.ConvertO(endYear);
            if (stationCode != null)
                callPayload.Queries["stationCode"] = CSharpExpressionConverter.ConvertO(stationCode);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (group != null)
                callPayload.Queries["group"] = CSharpExpressionConverter.Convert(group);
            if (includeClosed != null)
                callPayload.Queries["includeClosed"] = CSharpExpressionConverter.ConvertO(includeClosed);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<MultiStationSummarySchemaModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<StationTimeSeriesSchemaModel> GetStations15minSummaryTimeSeries(Expression<Func<string>> startDateTime, Expression<Func<string>> endDateTime, Expression<Func<string>> stationCode = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<groupInput>> group = null, Expression<Func<bool>> includeClosed = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = "/stations/summaries/15min/timeseries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startDateTime"] = CSharpExpressionConverter.ConvertO(startDateTime);
            callPayload.Queries["endDateTime"] = CSharpExpressionConverter.ConvertO(endDateTime);
            if (stationCode != null)
                callPayload.Queries["stationCode"] = CSharpExpressionConverter.ConvertO(stationCode);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (group != null)
                callPayload.Queries["group"] = CSharpExpressionConverter.Convert(group);
            if (includeClosed != null)
                callPayload.Queries["includeClosed"] = CSharpExpressionConverter.ConvertO(includeClosed);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<StationTimeSeriesSchemaModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<StationTimeSeriesSchemaModel> GetStations30minSummaryTimeSeries(Expression<Func<string>> startDateTime, Expression<Func<string>> endDateTime, Expression<Func<string>> stationCode = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<groupInput>> group = null, Expression<Func<bool>> includeClosed = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = "/stations/summaries/30min/timeseries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startDateTime"] = CSharpExpressionConverter.ConvertO(startDateTime);
            callPayload.Queries["endDateTime"] = CSharpExpressionConverter.ConvertO(endDateTime);
            if (stationCode != null)
                callPayload.Queries["stationCode"] = CSharpExpressionConverter.ConvertO(stationCode);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (group != null)
                callPayload.Queries["group"] = CSharpExpressionConverter.Convert(group);
            if (includeClosed != null)
                callPayload.Queries["includeClosed"] = CSharpExpressionConverter.ConvertO(includeClosed);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<StationTimeSeriesSchemaModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<StationTimeSeriesSchemaModel> GetStationsHourlySummaryTimeSeries(Expression<Func<string>> startDateTime, Expression<Func<string>> endDateTime, Expression<Func<string>> stationCode = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<groupInput>> group = null, Expression<Func<bool>> includeClosed = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = "/stations/summaries/hourly/timeseries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startDateTime"] = CSharpExpressionConverter.ConvertO(startDateTime);
            callPayload.Queries["endDateTime"] = CSharpExpressionConverter.ConvertO(endDateTime);
            if (stationCode != null)
                callPayload.Queries["stationCode"] = CSharpExpressionConverter.ConvertO(stationCode);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (group != null)
                callPayload.Queries["group"] = CSharpExpressionConverter.Convert(group);
            if (includeClosed != null)
                callPayload.Queries["includeClosed"] = CSharpExpressionConverter.ConvertO(includeClosed);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<StationTimeSeriesSchemaModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<StationTimeSeriesSchemaModel> GetStationsDailySummaryTimeSeries(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> stationCode = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<groupInput>> group = null, Expression<Func<bool>> includeClosed = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = "/stations/summaries/daily/timeseries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startDate"] = CSharpExpressionConverter.ConvertO(startDate);
            callPayload.Queries["endDate"] = CSharpExpressionConverter.ConvertO(endDate);
            if (stationCode != null)
                callPayload.Queries["stationCode"] = CSharpExpressionConverter.ConvertO(stationCode);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (group != null)
                callPayload.Queries["group"] = CSharpExpressionConverter.Convert(group);
            if (includeClosed != null)
                callPayload.Queries["includeClosed"] = CSharpExpressionConverter.ConvertO(includeClosed);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<StationTimeSeriesSchemaModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<StationTimeSeriesSchemaModel> GetStationsMonthlySummaryTimeSeries(Expression<Func<string>> startMonth, Expression<Func<string>> endMonth, Expression<Func<string>> stationCode = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<groupInput>> group = null, Expression<Func<bool>> includeClosed = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = "/stations/summaries/monthly/timeseries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startMonth"] = CSharpExpressionConverter.ConvertO(startMonth);
            callPayload.Queries["endMonth"] = CSharpExpressionConverter.ConvertO(endMonth);
            if (stationCode != null)
                callPayload.Queries["stationCode"] = CSharpExpressionConverter.ConvertO(stationCode);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (group != null)
                callPayload.Queries["group"] = CSharpExpressionConverter.Convert(group);
            if (includeClosed != null)
                callPayload.Queries["includeClosed"] = CSharpExpressionConverter.ConvertO(includeClosed);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<StationTimeSeriesSchemaModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<StationTimeSeriesSchemaModel> GetStationsYearlySummaryTimeSeries(Expression<Func<string>> startYear, Expression<Func<string>> endYear, Expression<Func<string>> stationCode = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<groupInput>> group = null, Expression<Func<bool>> includeClosed = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = "/stations/summaries/yearly/timeseries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startYear"] = CSharpExpressionConverter.ConvertO(startYear);
            callPayload.Queries["endYear"] = CSharpExpressionConverter.ConvertO(endYear);
            if (stationCode != null)
                callPayload.Queries["stationCode"] = CSharpExpressionConverter.ConvertO(stationCode);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (group != null)
                callPayload.Queries["group"] = CSharpExpressionConverter.Convert(group);
            if (includeClosed != null)
                callPayload.Queries["includeClosed"] = CSharpExpressionConverter.ConvertO(includeClosed);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<StationTimeSeriesSchemaModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<SingleStationSummarySchemaModel> GetStation15minSummary(Expression<Func<string>> stationCode, Expression<Func<string>> startDateTime, Expression<Func<string>> endDateTime, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/stations/{0}/summaries/15min", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startDateTime"] = CSharpExpressionConverter.ConvertO(startDateTime);
            callPayload.Queries["endDateTime"] = CSharpExpressionConverter.ConvertO(endDateTime);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<SingleStationSummarySchemaModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<SingleStationSummarySchemaModel> GetStation30minSummary(Expression<Func<string>> stationCode, Expression<Func<string>> startDateTime, Expression<Func<string>> endDateTime, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/stations/{0}/summaries/30min", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startDateTime"] = CSharpExpressionConverter.ConvertO(startDateTime);
            callPayload.Queries["endDateTime"] = CSharpExpressionConverter.ConvertO(endDateTime);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<SingleStationSummarySchemaModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<SingleStationSummarySchemaModel> GetStationHourlySummary(Expression<Func<string>> stationCode, Expression<Func<string>> startDateTime, Expression<Func<string>> endDateTime, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/stations/{0}/summaries/hourly", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startDateTime"] = CSharpExpressionConverter.ConvertO(startDateTime);
            callPayload.Queries["endDateTime"] = CSharpExpressionConverter.ConvertO(endDateTime);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<SingleStationSummarySchemaModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<SingleStationSummarySchemaModel> GetStationDailySummary(Expression<Func<string>> stationCode, Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/stations/{0}/summaries/daily", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startDate"] = CSharpExpressionConverter.ConvertO(startDate);
            callPayload.Queries["endDate"] = CSharpExpressionConverter.ConvertO(endDate);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<SingleStationSummarySchemaModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<SingleStationSummarySchemaModel> GetStationMonthlySummary(Expression<Func<string>> stationCode, Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/stations/{0}/summaries/monthly", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startDate"] = CSharpExpressionConverter.ConvertO(startDate);
            callPayload.Queries["endDate"] = CSharpExpressionConverter.ConvertO(endDate);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<SingleStationSummarySchemaModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        public IBodyWorkflowAction<SingleStationSummarySchemaModel> GetStationYearlySummary(Expression<Func<string>> stationCode, Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/stations/{0}/summaries/yearly", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["startDate"] = CSharpExpressionConverter.ConvertO(startDate);
            callPayload.Queries["endDate"] = CSharpExpressionConverter.ConvertO(endDate);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            return new ApiConnectionAction<SingleStationSummarySchemaModel>(callPayload);
        }
    }

    public class DpirdweatheripTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetStationsResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("collection")]
        public StationModel[] Collection { get; set; }
    }

    public class ApiMetaDataModel
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("links")]
        public LinksModelItem[] Links { get; set; }

        [JsonProperty("collection")]
        public PaginationModel Collection { get; set; }
    }

    public class LinksModelItem
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("rel")]
        public string Rel { get; set; }
    }

    public class PaginationModel
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("links")]
        public LinksModelItem[] Links { get; set; }
    }

    public class StationModel
    {
        [JsonProperty("stationCode")]
        public string StationCode { get; set; }

        [JsonProperty("stationName")]
        public string StationName { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("ownerCode")]
        public string OwnerCode { get; set; }

        [JsonProperty("altitude")]
        public int Altitude { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("capabilities")]
        public StationModelCapabilitiesType Capabilities { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("online")]
        public bool Online { get; set; }

        [JsonProperty("probeHeight")]
        public double ProbeHeight { get; set; }

        [JsonProperty("rainGaugeHeight")]
        public double RainGaugeHeight { get; set; }

        [JsonProperty("windProbeHeights")]
        public int[] WindProbeHeights { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("jobNumber")]
        public string JobNumber { get; set; }

        [JsonProperty("links")]
        public LinksModelItem[] Links { get; set; }
    }

    public class StationModelCapabilitiesType
    {
        [JsonProperty("airTemperature")]
        public bool AirTemperature { get; set; }

        [JsonProperty("batteryVoltage")]
        public bool BatteryVoltage { get; set; }

        [JsonProperty("deltaT")]
        public bool DeltaT { get; set; }

        [JsonProperty("dewPoint")]
        public bool DewPoint { get; set; }

        [JsonProperty("panEvaporation")]
        public bool PanEvaporation { get; set; }

        [JsonProperty("relativeHumidity")]
        public bool RelativeHumidity { get; set; }

        [JsonProperty("barometricPressure")]
        public bool BarometricPressure { get; set; }

        [JsonProperty("rainfall")]
        public bool Rainfall { get; set; }

        [JsonProperty("soilTemperature")]
        public bool SoilTemperature { get; set; }

        [JsonProperty("solarIrradiance")]
        public bool SolarIrradiance { get; set; }

        [JsonProperty("wetBulb")]
        public bool WetBulb { get; set; }

        [JsonProperty("wind1")]
        public bool Wind1 { get; set; }

        [JsonProperty("wind2")]
        public bool Wind2 { get; set; }

        [JsonProperty("wind3")]
        public bool Wind3 { get; set; }

        [JsonProperty("apparentTemperature")]
        public bool ApparentTemperature { get; set; }

        [JsonProperty("etoShort")]
        public bool EtoShort { get; set; }

        [JsonProperty("etoTall")]
        public bool EtoTall { get; set; }

        [JsonProperty("frostCondition")]
        public bool FrostCondition { get; set; }

        [JsonProperty("heatCondition")]
        public bool HeatCondition { get; set; }

        [JsonProperty("windErosionCondition")]
        public bool WindErosionCondition { get; set; }

        [JsonProperty("richardsonUnit")]
        public bool RichardsonUnit { get; set; }

        [JsonProperty("chillHour")]
        public bool ChillHour { get; set; }
    }

    public enum groupInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "api")]
        Api,
        [EnumMember(Value = "web")]
        Web,
        [EnumMember(Value = "rtd")]
        Rtd
    }

    public class GetStationsAvailabilityResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("collection")]
        public StationAvailabilitySummaryModel[] Collection { get; set; }
    }

    public class StationAvailabilitySummaryModel
    {
        [JsonProperty("stationCode")]
        public string StationCode { get; set; }

        [JsonProperty("stationName")]
        public string StationName { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("availability")]
        public StationAvailabilityModel Availability { get; set; }

        [JsonProperty("links")]
        public LinksModelItem[] Links { get; set; }
    }

    public class StationAvailabilityModel
    {
        [JsonProperty("to9AM")]
        public JToken To9AM { get; set; }

        [JsonProperty("since9AM")]
        public JToken Since9AM { get; set; }

        [JsonProperty("since12AM")]
        public JToken Since12AM { get; set; }

        [JsonProperty("currentHour")]
        public JToken CurrentHour { get; set; }

        [JsonProperty("last24Hours")]
        public JToken Last24Hours { get; set; }

        [JsonProperty("last7Days")]
        public StationAvailabilityModelLast7DaysType Last7Days { get; set; }

        [JsonProperty("last14Days")]
        public StationAvailabilityModelLast14DaysType Last14Days { get; set; }

        [JsonProperty("monthToDate")]
        public StationAvailabilityModelMonthToDateType MonthToDate { get; set; }

        [JsonProperty("yearToDate")]
        public StationAvailabilityModelYearToDateType YearToDate { get; set; }

        [JsonProperty("period")]
        public StationAvailabilityModelPeriodType Period { get; set; }
    }

    public class StationAvailabilityModelLast7DaysType
    {
        [JsonProperty("since9AM")]
        public JToken Since9AM { get; set; }

        [JsonProperty("since12AM")]
        public JToken Since12AM { get; set; }
    }

    public class StationAvailabilityModelLast14DaysType
    {
        [JsonProperty("since9AM")]
        public JToken Since9AM { get; set; }

        [JsonProperty("since12AM")]
        public JToken Since12AM { get; set; }
    }

    public class StationAvailabilityModelMonthToDateType
    {
        [JsonProperty("to9AM")]
        public JToken To9AM { get; set; }

        [JsonProperty("since12AM")]
        public JToken Since12AM { get; set; }
    }

    public class StationAvailabilityModelYearToDateType
    {
        [JsonProperty("to9AM")]
        public JToken To9AM { get; set; }

        [JsonProperty("since12AM")]
        public JToken Since12AM { get; set; }
    }

    public class StationAvailabilityModelPeriodType
    {
        [JsonProperty("9AM")]
        public JToken _9AM { get; set; }

        [JsonProperty("12AM")]
        public JToken _12AM { get; set; }
    }

    public class GetStationResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("data")]
        public StationModel Data { get; set; }
    }

    public class GetWeatherStationAvailabilityResponse
    {
        [JsonProperty("metadata")]
        public GetWeatherStationAvailabilityResponseMetadataType Metadata { get; set; }

        [JsonProperty("data")]
        public StationAvailabilitySummaryModel Data { get; set; }
    }

    public class GetWeatherStationAvailabilityResponseMetadataType
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("links")]
        public LinksModelItem[] Links { get; set; }

        [JsonProperty("collection")]
        public PaginationModel Collection { get; set; }
    }

    public class GetStationsBulletinsResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("collection")]
        public StationBulletinsModel[] Collection { get; set; }
    }

    public class StationBulletinsModel
    {
        [JsonProperty("stationCode")]
        public string StationCode { get; set; }

        [JsonProperty("stationName")]
        public string StationName { get; set; }

        [JsonProperty("summaries")]
        public StationBulletinsModelSummariesTypeItem[] Summaries { get; set; }
    }

    public class StationBulletinsModelSummariesTypeItem
    {
        [JsonProperty("stationCode")]
        public string StationCode { get; set; }

        [JsonProperty("stationName")]
        public string StationName { get; set; }

        [JsonProperty("period")]
        public StationBulletinsModelSummariesTypeItemPeriodType Period { get; set; }

        [JsonProperty("airTemperature")]
        public StationBulletinsModelSummariesTypeItemAirTemperatureType AirTemperature { get; set; }

        [JsonProperty("relativeHumidity")]
        public StationBulletinsModelSummariesTypeItemRelativeHumidityType RelativeHumidity { get; set; }

        [JsonProperty("soilTemperature")]
        public StationBulletinsModelSummariesTypeItemSoilTemperatureType SoilTemperature { get; set; }

        [JsonProperty("wind")]
        public StationBulletinsModelSummariesTypeItemWindTypeItem[] Wind { get; set; }

        [JsonProperty("panEvaporation")]
        public double PanEvaporation { get; set; }

        [JsonProperty("evapotranspiration")]
        public StationBulletinsModelSummariesTypeItemEvapotranspirationType Evapotranspiration { get; set; }

        [JsonProperty("solarExposure")]
        public double SolarExposure { get; set; }

        [JsonProperty("rainfall")]
        public double Rainfall { get; set; }

        [JsonProperty("links")]
        public LinksModelItem[] Links { get; set; }
    }

    public class StationBulletinsModelSummariesTypeItemPeriodType
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }

        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }
    }

    public class StationBulletinsModelSummariesTypeItemAirTemperatureType
    {
        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("minTime")]
        public string MinTime { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }

        [JsonProperty("maxTime")]
        public string MaxTime { get; set; }
    }

    public class StationBulletinsModelSummariesTypeItemRelativeHumidityType
    {
        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("minTime")]
        public string MinTime { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }

        [JsonProperty("maxTime")]
        public string MaxTime { get; set; }
    }

    public class StationBulletinsModelSummariesTypeItemSoilTemperatureType
    {
        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("minTime")]
        public string MinTime { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }

        [JsonProperty("maxTime")]
        public string MaxTime { get; set; }
    }

    public class StationBulletinsModelSummariesTypeItemWindTypeItem
    {
        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("avg")]
        public StationBulletinsModelSummariesTypeItemWindTypeItemAvgType Avg { get; set; }

        [JsonProperty("max")]
        public StationBulletinsModelSummariesTypeItemWindTypeItemMaxType Max { get; set; }
    }

    public class StationBulletinsModelSummariesTypeItemWindTypeItemAvgType
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }
    }

    public class StationBulletinsModelSummariesTypeItemWindTypeItemMaxType
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("direction")]
        public StationBulletinsModelSummariesTypeItemWindTypeItemMaxTypeDirectionType Direction { get; set; }
    }

    public class StationBulletinsModelSummariesTypeItemWindTypeItemMaxTypeDirectionType
    {
        [JsonProperty("degrees")]
        public int Degrees { get; set; }

        [JsonProperty("compassPoint")]
        public string CompassPoint { get; set; }
    }

    public class StationBulletinsModelSummariesTypeItemEvapotranspirationType
    {
        [JsonProperty("shortCrop")]
        public double ShortCrop { get; set; }

        [JsonProperty("tallCrop")]
        public double TallCrop { get; set; }
    }

    public class GetWeatherStationsRainfallResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("collection")]
        public StationRainfallModel[] Collection { get; set; }
    }

    public class StationRainfallModel
    {
        [JsonProperty("stationCode")]
        public string StationCode { get; set; }

        [JsonProperty("stationName")]
        public string StationName { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("rainfall")]
        public StationRainfallModelRainfallType Rainfall { get; set; }

        [JsonProperty("links")]
        public LinksModelItem[] Links { get; set; }
    }

    public class StationRainfallModelRainfallType
    {
        [JsonProperty("to9AM")]
        public double To9AM { get; set; }

        [JsonProperty("since9AM")]
        public double Since9AM { get; set; }

        [JsonProperty("currentHour")]
        public double CurrentHour { get; set; }

        [JsonProperty("last24Hrs")]
        public double Last24Hrs { get; set; }

        [JsonProperty("last7Days")]
        public double Last7Days { get; set; }

        [JsonProperty("last14Days")]
        public double Last14Days { get; set; }

        [JsonProperty("monthToDate")]
        public double MonthToDate { get; set; }

        [JsonProperty("yearToDate")]
        public double YearToDate { get; set; }

        [JsonProperty("period")]
        public double Period { get; set; }
    }

    public class GetWeatherStationRainfallResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("collection")]
        public StationRainfallModel[] Collection { get; set; }
    }

    public class GetStationsExtremeConditionsResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("collection")]
        public StationExtremeConditionModelItem[] Collection { get; set; }
    }

    public class StationExtremeConditionModelItem
    {
        [JsonProperty("stationCode")]
        public string StationCode { get; set; }

        [JsonProperty("stationName")]
        public string StationName { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("frostCondition")]
        public StationExtremeConditionModelItemFrostConditionType FrostCondition { get; set; }

        [JsonProperty("heatCondition")]
        public StationExtremeConditionModelItemHeatConditionType HeatCondition { get; set; }

        [JsonProperty("erosionCondition")]
        public StationExtremeConditionModelItemErosionConditionType ErosionCondition { get; set; }
    }

    public class StationExtremeConditionModelItemFrostConditionType
    {
        [JsonProperty("since9AM")]
        public StationExtremeConditionModelItemFrostConditionTypeSince9AMType Since9AM { get; set; }

        [JsonProperty("to9AM")]
        public StationExtremeConditionModelItemFrostConditionTypeTo9AMType To9AM { get; set; }

        [JsonProperty("last7Days")]
        public StationExtremeConditionModelItemFrostConditionTypeLast7DaysType Last7Days { get; set; }

        [JsonProperty("last14Days")]
        public StationExtremeConditionModelItemFrostConditionTypeLast14DaysType Last14Days { get; set; }

        [JsonProperty("monthToDate")]
        public StationExtremeConditionModelItemFrostConditionTypeMonthToDateType MonthToDate { get; set; }

        [JsonProperty("yearToDate")]
        public StationExtremeConditionModelItemFrostConditionTypeYearToDateType YearToDate { get; set; }
    }

    public class StationExtremeConditionModelItemFrostConditionTypeSince9AMType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }
    }

    public class StationExtremeConditionModelItemFrostConditionTypeTo9AMType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }
    }

    public class StationExtremeConditionModelItemFrostConditionTypeLast7DaysType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("days")]
        public int Days { get; set; }
    }

    public class StationExtremeConditionModelItemFrostConditionTypeLast14DaysType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("days")]
        public int Days { get; set; }
    }

    public class StationExtremeConditionModelItemFrostConditionTypeMonthToDateType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("days")]
        public int Days { get; set; }
    }

    public class StationExtremeConditionModelItemFrostConditionTypeYearToDateType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("days")]
        public int Days { get; set; }
    }

    public class StationExtremeConditionModelItemHeatConditionType
    {
        [JsonProperty("since12AM")]
        public StationExtremeConditionModelItemHeatConditionTypeSince12AMType Since12AM { get; set; }

        [JsonProperty("last7Days")]
        public StationExtremeConditionModelItemHeatConditionTypeLast7DaysType Last7Days { get; set; }

        [JsonProperty("last14Days")]
        public StationExtremeConditionModelItemHeatConditionTypeLast14DaysType Last14Days { get; set; }

        [JsonProperty("monthToDate")]
        public StationExtremeConditionModelItemHeatConditionTypeMonthToDateType MonthToDate { get; set; }

        [JsonProperty("yearToDate")]
        public StationExtremeConditionModelItemHeatConditionTypeYearToDateType YearToDate { get; set; }
    }

    public class StationExtremeConditionModelItemHeatConditionTypeSince12AMType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }
    }

    public class StationExtremeConditionModelItemHeatConditionTypeLast7DaysType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("days")]
        public int Days { get; set; }
    }

    public class StationExtremeConditionModelItemHeatConditionTypeLast14DaysType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("days")]
        public int Days { get; set; }
    }

    public class StationExtremeConditionModelItemHeatConditionTypeMonthToDateType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("days")]
        public int Days { get; set; }
    }

    public class StationExtremeConditionModelItemHeatConditionTypeYearToDateType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("days")]
        public int Days { get; set; }
    }

    public class StationExtremeConditionModelItemErosionConditionType
    {
        [JsonProperty("since12AM")]
        public StationExtremeConditionModelItemErosionConditionTypeSince12AMType Since12AM { get; set; }

        [JsonProperty("last7Days")]
        public StationExtremeConditionModelItemErosionConditionTypeLast7DaysType Last7Days { get; set; }

        [JsonProperty("last14Days")]
        public StationExtremeConditionModelItemErosionConditionTypeLast14DaysType Last14Days { get; set; }

        [JsonProperty("monthToDate")]
        public StationExtremeConditionModelItemErosionConditionTypeMonthToDateType MonthToDate { get; set; }

        [JsonProperty("yearToDate")]
        public StationExtremeConditionModelItemErosionConditionTypeYearToDateType YearToDate { get; set; }
    }

    public class StationExtremeConditionModelItemErosionConditionTypeSince12AMType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }
    }

    public class StationExtremeConditionModelItemErosionConditionTypeLast7DaysType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("days")]
        public int Days { get; set; }
    }

    public class StationExtremeConditionModelItemErosionConditionTypeLast14DaysType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("days")]
        public int Days { get; set; }
    }

    public class StationExtremeConditionModelItemErosionConditionTypeMonthToDateType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("days")]
        public int Days { get; set; }
    }

    public class StationExtremeConditionModelItemErosionConditionTypeYearToDateType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("days")]
        public int Days { get; set; }
    }

    public class GetStationsExtremeEventsResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("data")]
        public StationExtremeEventModel Data { get; set; }
    }

    public class StationExtremeEventModel
    {
        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("stations")]
        public StationExtremeEventModelStationsTypeItem[] Stations { get; set; }
    }

    public class StationExtremeEventModelStationsTypeItem
    {
        [JsonProperty("stationCode")]
        public string StationCode { get; set; }

        [JsonProperty("stationName")]
        public string StationName { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("numberOfEvents")]
        public int NumberOfEvents { get; set; }

        [JsonProperty("extremeValue")]
        public double ExtremeValue { get; set; }
    }

    public enum @operatorInput
    {
        [EnumMember(Value = "gt")]
        Gt,
        [EnumMember(Value = "lt")]
        Lt
    }

    public enum propertyInput
    {
        [EnumMember(Value = "airTemperature")]
        AirTemperature,
        [EnumMember(Value = "soilTemperature")]
        SoilTemperature,
        [EnumMember(Value = "relativeHumidity")]
        RelativeHumidity,
        [EnumMember(Value = "windSpeed")]
        WindSpeed,
        [EnumMember(Value = "dewPoint")]
        DewPoint,
        [EnumMember(Value = "deltaT")]
        DeltaT,
        [EnumMember(Value = "wetBulb")]
        WetBulb,
        [EnumMember(Value = "barometricPressure")]
        BarometricPressure
    }

    public enum intervalInput
    {
        [EnumMember(Value = "minute")]
        Minute,
        [EnumMember(Value = "15min")]
        _15min,
        [EnumMember(Value = "30min")]
        _30min,
        [EnumMember(Value = "hourly")]
        Hourly,
        [EnumMember(Value = "daily")]
        Daily,
        [EnumMember(Value = "monthly")]
        Monthly,
        [EnumMember(Value = "yearly")]
        Yearly
    }

    public class GetStationsLatestDataResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("collection")]
        public StationLatestDataModel[] Collection { get; set; }
    }

    public class StationLatestDataModel
    {
        [JsonProperty("stationCode")]
        public string StationCode { get; set; }

        [JsonProperty("stationName")]
        public string StationName { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("airTemperature")]
        public double AirTemperature { get; set; }

        [JsonProperty("airTemperatureMinLast24Hrs")]
        public double AirTemperatureMinLast24Hrs { get; set; }

        [JsonProperty("airTemperatureMaxLast24Hrs")]
        public double AirTemperatureMaxLast24Hrs { get; set; }

        [JsonProperty("apparentTemperature")]
        public double ApparentTemperature { get; set; }

        [JsonProperty("barometricPressure")]
        public string BarometricPressure { get; set; }

        [JsonProperty("relativeHumidity")]
        public double RelativeHumidity { get; set; }

        [JsonProperty("soilTemperature")]
        public double SoilTemperature { get; set; }

        [JsonProperty("dewPoint")]
        public double DewPoint { get; set; }

        [JsonProperty("deltaT")]
        public double DeltaT { get; set; }

        [JsonProperty("wetBulb")]
        public double WetBulb { get; set; }

        [JsonProperty("sprayingConditions")]
        public string SprayingConditions { get; set; }

        [JsonProperty("solarExposure")]
        public double SolarExposure { get; set; }

        [JsonProperty("solarIrradiance")]
        public int SolarIrradiance { get; set; }

        [JsonProperty("wind")]
        public WindDataModelItem[] Wind { get; set; }

        [JsonProperty("etoShortCrop")]
        public double EtoShortCrop { get; set; }

        [JsonProperty("etoTallCrop")]
        public double EtoTallCrop { get; set; }

        [JsonProperty("etoShortCropTo3PM")]
        public double EtoShortCropTo3PM { get; set; }

        [JsonProperty("etoTallCropTo3PM")]
        public double EtoTallCropTo3PM { get; set; }

        [JsonProperty("rainfallSince9AM")]
        public int RainfallSince9AM { get; set; }

        [JsonProperty("rainfallTo3PM")]
        public int RainfallTo3PM { get; set; }

        [JsonProperty("panEvaporation")]
        public double PanEvaporation { get; set; }

        [JsonProperty("panEvaporation12AM")]
        public double PanEvaporation12AM { get; set; }

        [JsonProperty("panEvaporationTo3PM")]
        public double PanEvaporationTo3PM { get; set; }

        [JsonProperty("erosionConditionSince12AM")]
        public StationLatestDataModelErosionConditionSince12AMType ErosionConditionSince12AM { get; set; }

        [JsonProperty("frostConditionSince9AM")]
        public StationLatestDataModelFrostConditionSince9AMType FrostConditionSince9AM { get; set; }

        [JsonProperty("heatConditionSince12AM")]
        public StationLatestDataModelHeatConditionSince12AMType HeatConditionSince12AM { get; set; }

        [JsonProperty("batteryVoltage")]
        public double BatteryVoltage { get; set; }

        [JsonProperty("errors")]
        public StationLatestDataModelErrorsType Errors { get; set; }
    }

    public class WindDataModelItem
    {
        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("avg")]
        public WindDataModelItemAvgType Avg { get; set; }

        [JsonProperty("max")]
        public WindDataModelItemMaxType Max { get; set; }
    }

    public class WindDataModelItemAvgType
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("direction")]
        public WindDataModelItemAvgTypeDirectionType Direction { get; set; }
    }

    public class WindDataModelItemAvgTypeDirectionType
    {
        [JsonProperty("compassPoint")]
        public string CompassPoint { get; set; }

        [JsonProperty("degrees")]
        public int Degrees { get; set; }
    }

    public class WindDataModelItemMaxType
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("direction")]
        public WindDataModelItemMaxTypeDirectionType Direction { get; set; }
    }

    public class WindDataModelItemMaxTypeDirectionType
    {
        [JsonProperty("degrees")]
        public int Degrees { get; set; }

        [JsonProperty("compassPoint")]
        public string CompassPoint { get; set; }
    }

    public class StationLatestDataModelErosionConditionSince12AMType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }
    }

    public class StationLatestDataModelFrostConditionSince9AMType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }
    }

    public class StationLatestDataModelHeatConditionSince12AMType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }
    }

    public class StationLatestDataModelErrorsType
    {
        [JsonProperty("today")]
        public int Today { get; set; }

        [JsonProperty("last7Days")]
        public int Last7Days { get; set; }
    }

    public class GetStationBulletinsResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("data")]
        public StationBulletinsModel Data { get; set; }
    }

    public class GetStationLatestDataResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("data")]
        public StationLatestDataModel Data { get; set; }
    }

    public class GetStationMinuteDataResponse
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("collection")]
        public SingleStationDataModel[] Collection { get; set; }
    }

    public class SingleStationDataModel
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("airTemperature")]
        public double AirTemperature { get; set; }

        [JsonProperty("relativeHumidity")]
        public double RelativeHumidity { get; set; }

        [JsonProperty("soilTemperature")]
        public double SoilTemperature { get; set; }

        [JsonProperty("solarIrradiance")]
        public int SolarIrradiance { get; set; }

        [JsonProperty("rainfall")]
        public int Rainfall { get; set; }

        [JsonProperty("dewPoint")]
        public double DewPoint { get; set; }

        [JsonProperty("wetBulb")]
        public double WetBulb { get; set; }

        [JsonProperty("wind")]
        public WindDataModelItem[] Wind { get; set; }
    }

    public class MultiStationSummarySchemaModel
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("collection")]
        public MultiStationSummarySchemaModelCollectionTypeItem[] Collection { get; set; }
    }

    public class MultiStationSummarySchemaModelCollectionTypeItem
    {
        [JsonProperty("stationCode")]
        public string StationCode { get; set; }

        [JsonProperty("stationName")]
        public string StationName { get; set; }

        [JsonProperty("summaries")]
        public StationSummaryModel[] Summaries { get; set; }
    }

    public class StationSummaryModel
    {
        [JsonProperty("period")]
        public StationSummaryModelPeriodType Period { get; set; }

        [JsonProperty("airTemperature")]
        public StationSummaryModelAirTemperatureType AirTemperature { get; set; }

        [JsonProperty("apparentAirTemperature")]
        public StationSummaryModelApparentAirTemperatureType ApparentAirTemperature { get; set; }

        [JsonProperty("relativeHumidity")]
        public StationSummaryModelRelativeHumidityType RelativeHumidity { get; set; }

        [JsonProperty("dewPoint")]
        public StationSummaryModelDewPointType DewPoint { get; set; }

        [JsonProperty("panEvaporation")]
        public double PanEvaporation { get; set; }

        [JsonProperty("evapotranspiration")]
        public StationSummaryModelEvapotranspirationType Evapotranspiration { get; set; }

        [JsonProperty("richardsonUnits")]
        public double RichardsonUnits { get; set; }

        [JsonProperty("chillHours")]
        public int ChillHours { get; set; }

        [JsonProperty("solarExposure")]
        public double SolarExposure { get; set; }

        [JsonProperty("rainfall")]
        public double Rainfall { get; set; }

        [JsonProperty("erosionCondition")]
        public StationSummaryModelErosionConditionType ErosionCondition { get; set; }

        [JsonProperty("soilTemperature")]
        public StationSummaryModelSoilTemperatureType SoilTemperature { get; set; }

        [JsonProperty("deltaT")]
        public StationSummaryModelDeltaTType DeltaT { get; set; }

        [JsonProperty("wetBulb")]
        public StationSummaryModelWetBulbType WetBulb { get; set; }

        [JsonProperty("wind")]
        public WindDataModelItem[] Wind { get; set; }

        [JsonProperty("barometricPressure")]
        public string BarometricPressure { get; set; }

        [JsonProperty("frostCondition")]
        public StationSummaryModelFrostConditionType FrostCondition { get; set; }

        [JsonProperty("heatCondition")]
        public StationSummaryModelHeatConditionType HeatCondition { get; set; }

        [JsonProperty("battery")]
        public StationSummaryModelBatteryType Battery { get; set; }

        [JsonProperty("errors")]
        public int Errors { get; set; }
    }

    public class StationSummaryModelPeriodType
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }

        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }
    }

    public class StationSummaryModelAirTemperatureType
    {
        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("minTime")]
        public string MinTime { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }

        [JsonProperty("maxTime")]
        public string MaxTime { get; set; }

        [JsonProperty("avg")]
        public double Avg { get; set; }
    }

    public class StationSummaryModelApparentAirTemperatureType
    {
        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("minTime")]
        public string MinTime { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }

        [JsonProperty("maxTime")]
        public string MaxTime { get; set; }

        [JsonProperty("avg")]
        public double Avg { get; set; }
    }

    public class StationSummaryModelRelativeHumidityType
    {
        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("minTime")]
        public string MinTime { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }

        [JsonProperty("maxTime")]
        public string MaxTime { get; set; }

        [JsonProperty("avg")]
        public double Avg { get; set; }
    }

    public class StationSummaryModelDewPointType
    {
        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("minTime")]
        public string MinTime { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }

        [JsonProperty("maxTime")]
        public string MaxTime { get; set; }

        [JsonProperty("avg")]
        public double Avg { get; set; }
    }

    public class StationSummaryModelEvapotranspirationType
    {
        [JsonProperty("shortCrop")]
        public double ShortCrop { get; set; }

        [JsonProperty("tallCrop")]
        public double TallCrop { get; set; }
    }

    public class StationSummaryModelErosionConditionType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }
    }

    public class StationSummaryModelSoilTemperatureType
    {
        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("minTime")]
        public string MinTime { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }

        [JsonProperty("maxTime")]
        public string MaxTime { get; set; }

        [JsonProperty("avg")]
        public double Avg { get; set; }
    }

    public class StationSummaryModelDeltaTType
    {
        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("minTime")]
        public string MinTime { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }

        [JsonProperty("maxTime")]
        public string MaxTime { get; set; }

        [JsonProperty("avg")]
        public double Avg { get; set; }
    }

    public class StationSummaryModelWetBulbType
    {
        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("minTime")]
        public string MinTime { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }

        [JsonProperty("maxTime")]
        public string MaxTime { get; set; }

        [JsonProperty("avg")]
        public double Avg { get; set; }
    }

    public class StationSummaryModelFrostConditionType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }
    }

    public class StationSummaryModelHeatConditionType
    {
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }
    }

    public class StationSummaryModelBatteryType
    {
        [JsonProperty("minVoltage")]
        public double MinVoltage { get; set; }

        [JsonProperty("minVoltageDateTime")]
        public string MinVoltageDateTime { get; set; }
    }

    public class StationTimeSeriesSchemaModel
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("collection")]
        public StationTimeSeriesModel[] Collection { get; set; }
    }

    public class StationTimeSeriesModel
    {
        [JsonProperty("stationCode")]
        public string StationCode { get; set; }

        [JsonProperty("stationName")]
        public string StationName { get; set; }

        [JsonProperty("panEvaporation")]
        public JToken[] PanEvaporation { get; set; }

        [JsonProperty("richardsonUnits")]
        public JToken[] RichardsonUnits { get; set; }

        [JsonProperty("chillHours")]
        public JToken[] ChillHours { get; set; }

        [JsonProperty("solarExposure")]
        public JToken[] SolarExposure { get; set; }

        [JsonProperty("rainfall")]
        public JToken[] Rainfall { get; set; }

        [JsonProperty("errors")]
        public JToken[] Errors { get; set; }

        [JsonProperty("period")]
        public JToken Period { get; set; }

        [JsonProperty("airTemperature")]
        public JToken AirTemperature { get; set; }

        [JsonProperty("apparentAirTemperature")]
        public JToken ApparentAirTemperature { get; set; }

        [JsonProperty("relativeHumidity")]
        public JToken RelativeHumidity { get; set; }

        [JsonProperty("dewPoint")]
        public JToken DewPoint { get; set; }

        [JsonProperty("evapotranspiration")]
        public JToken Evapotranspiration { get; set; }

        [JsonProperty("erosionCondition")]
        public JToken ErosionCondition { get; set; }

        [JsonProperty("soilTemperature")]
        public JToken SoilTemperature { get; set; }

        [JsonProperty("deltaT")]
        public JToken DeltaT { get; set; }

        [JsonProperty("wetBulb")]
        public JToken WetBulb { get; set; }

        [JsonProperty("wind")]
        public JToken[] Wind { get; set; }

        [JsonProperty("barometricPressure")]
        public JToken BarometricPressure { get; set; }

        [JsonProperty("frostCondition")]
        public JToken FrostCondition { get; set; }

        [JsonProperty("heatCondition")]
        public JToken HeatCondition { get; set; }

        [JsonProperty("battery")]
        public JToken Battery { get; set; }

        [JsonProperty("observations")]
        public JToken Observations { get; set; }
    }

    public class SingleStationSummarySchemaModel
    {
        [JsonProperty("metadata")]
        public ApiMetaDataModel Metadata { get; set; }

        [JsonProperty("data")]
        public SingleStationSummarySchemaModelDataType Data { get; set; }
    }

    public class SingleStationSummarySchemaModelDataType
    {
        [JsonProperty("stationCode")]
        public string StationCode { get; set; }

        [JsonProperty("stationName")]
        public string StationName { get; set; }

        [JsonProperty("summaries")]
        public StationSummaryModel[] Summaries { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dpirdweatherip;

    public partial class WorkflowManagedActions
    {
        public DpirdweatheripActions Dpirdweatherip(string connectionId) => new DpirdweatheripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DpirdweatheripTriggers Dpirdweatherip(string connectionId) => new DpirdweatheripTriggers(connectionId);
    }
}