//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dpirdweatherip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DpirdweatheripActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStations))]
        public IBodyWorkflowAction<GetStationsResponse> GetStations([WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<bool> includeClosed = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<groupInput> group = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStationsResponse> __BuildGetStations(WorkflowExpression<string> stationCode = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<bool> includeClosed = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> select = null, WorkflowExpression<groupInput> group = null)
        {
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(includeClosed, nameof(includeClosed), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(group, nameof(group), required: false);
            return new DeferredBodyAction<GetStationsResponse>(() =>
            {
                var apiCallPath = "/stations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (includeClosed != null)
                    callPayload.Queries["includeClosed"] = ExpressionConverter.Convert(includeClosed);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                return new ApiConnectionAction<GetStationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStationsAvailability))]
        public IBodyWorkflowAction<GetStationsAvailabilityResponse> GetStationsAvailability([WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStationsAvailabilityResponse> __BuildGetStationsAvailability(WorkflowExpression<string> stationCode = null, WorkflowExpression<string> startDate = null, WorkflowExpression<string> endDate = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(startDate, nameof(startDate), required: false);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<GetStationsAvailabilityResponse>(() =>
            {
                var apiCallPath = "/stations/availability";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<GetStationsAvailabilityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetNearbyWeatherStations))]
        public IWorkflowAction GetNearbyWeatherStations([WorkflowExpression] Func<double> latitude, [WorkflowExpression] Func<double> longitude, [WorkflowExpression] Func<int> radius = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<bool> includeClosed = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<groupInput> group = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetNearbyWeatherStations(WorkflowExpression<double> latitude, WorkflowExpression<double> longitude, WorkflowExpression<int> radius = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<bool> includeClosed = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> select = null, WorkflowExpression<groupInput> group = null)
        {
            WorkflowExpression.Validate(latitude, nameof(latitude), required: true);
            WorkflowExpression.Validate(longitude, nameof(longitude), required: true);
            WorkflowExpression.Validate(radius, nameof(radius), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(includeClosed, nameof(includeClosed), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(group, nameof(group), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/stations/nearby";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["latitude"] = ExpressionConverter.Convert(latitude);
                callPayload.Queries["longitude"] = ExpressionConverter.Convert(longitude);
                if (radius != null)
                    callPayload.Queries["radius"] = ExpressionConverter.Convert(radius);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (includeClosed != null)
                    callPayload.Queries["includeClosed"] = ExpressionConverter.Convert(includeClosed);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStation))]
        public IBodyWorkflowAction<GetStationResponse> GetStation([WorkflowExpression] Func<string> stationCode, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStationResponse> __BuildGetStation(WorkflowExpression<string> stationCode, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: true);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<GetStationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/station/{0}", ExpressionConverter.ConvertWithUrlEncoding(stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<GetStationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetWeatherStationAvailability))]
        public IBodyWorkflowAction<GetWeatherStationAvailabilityResponse> GetWeatherStationAvailability([WorkflowExpression] Func<string> stationCode, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetWeatherStationAvailabilityResponse> __BuildGetWeatherStationAvailability(WorkflowExpression<string> stationCode, WorkflowExpression<string> startDate = null, WorkflowExpression<string> endDate = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: true);
            WorkflowExpression.Validate(startDate, nameof(startDate), required: false);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<GetWeatherStationAvailabilityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/stations/{0}/availability", ExpressionConverter.ConvertWithUrlEncoding(stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<GetWeatherStationAvailabilityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStationsBulletins))]
        public IBodyWorkflowAction<GetStationsBulletinsResponse> GetStationsBulletins([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<bool> includeClosed = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<groupInput> group = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStationsBulletinsResponse> __BuildGetStationsBulletins(WorkflowExpression<string> startDate, WorkflowExpression<string> endDate, WorkflowExpression<string> stationCode = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<bool> includeClosed = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> select = null, WorkflowExpression<groupInput> group = null)
        {
            WorkflowExpression.Validate(startDate, nameof(startDate), required: true);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: true);
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(includeClosed, nameof(includeClosed), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(group, nameof(group), required: false);
            return new DeferredBodyAction<GetStationsBulletinsResponse>(() =>
            {
                var apiCallPath = "/stations/bulletins";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (includeClosed != null)
                    callPayload.Queries["includeClosed"] = ExpressionConverter.Convert(includeClosed);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                return new ApiConnectionAction<GetStationsBulletinsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetWeatherStationsRainfall))]
        public IBodyWorkflowAction<GetWeatherStationsRainfallResponse> GetWeatherStationsRainfall([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<bool> includeClosed = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<groupInput> group = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetWeatherStationsRainfallResponse> __BuildGetWeatherStationsRainfall(WorkflowExpression<string> startDate, WorkflowExpression<string> endDate, WorkflowExpression<string> stationCode = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<bool> includeClosed = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> select = null, WorkflowExpression<groupInput> group = null)
        {
            WorkflowExpression.Validate(startDate, nameof(startDate), required: true);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: true);
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(includeClosed, nameof(includeClosed), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(group, nameof(group), required: false);
            return new DeferredBodyAction<GetWeatherStationsRainfallResponse>(() =>
            {
                var apiCallPath = "/stations/rainfall";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (includeClosed != null)
                    callPayload.Queries["includeClosed"] = ExpressionConverter.Convert(includeClosed);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                return new ApiConnectionAction<GetWeatherStationsRainfallResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetWeatherStationRainfall))]
        public IBodyWorkflowAction<GetWeatherStationRainfallResponse> GetWeatherStationRainfall([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<bool> includeClosed = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<groupInput> group = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetWeatherStationRainfallResponse> __BuildGetWeatherStationRainfall(WorkflowExpression<string> startDate, WorkflowExpression<string> endDate, WorkflowExpression<string> stationCode = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<bool> includeClosed = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> select = null, WorkflowExpression<groupInput> group = null)
        {
            WorkflowExpression.Validate(startDate, nameof(startDate), required: true);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: true);
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(includeClosed, nameof(includeClosed), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(group, nameof(group), required: false);
            return new DeferredBodyAction<GetWeatherStationRainfallResponse>(() =>
            {
                var apiCallPath = "/stations1/rainfall";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (includeClosed != null)
                    callPayload.Queries["includeClosed"] = ExpressionConverter.Convert(includeClosed);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                return new ApiConnectionAction<GetWeatherStationRainfallResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStationsExtremeConditions))]
        public IBodyWorkflowAction<GetStationsExtremeConditionsResponse> GetStationsExtremeConditions([WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<groupInput> group = null, [WorkflowExpression] Func<bool> includeClosed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStationsExtremeConditionsResponse> __BuildGetStationsExtremeConditions(WorkflowExpression<string> stationCode = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> select = null, WorkflowExpression<groupInput> group = null, WorkflowExpression<bool> includeClosed = null)
        {
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(group, nameof(group), required: false);
            WorkflowExpression.Validate(includeClosed, nameof(includeClosed), required: false);
            return new DeferredBodyAction<GetStationsExtremeConditionsResponse>(() =>
            {
                var apiCallPath = "/stations/extreme-conditions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                if (includeClosed != null)
                    callPayload.Queries["includeClosed"] = ExpressionConverter.Convert(includeClosed);
                return new ApiConnectionAction<GetStationsExtremeConditionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStationsExtremeEvents))]
        public IBodyWorkflowAction<GetStationsExtremeEventsResponse> GetStationsExtremeEvents([WorkflowExpression] Func<@operatorInput> @operator, [WorkflowExpression] Func<int> threshold, [WorkflowExpression] Func<propertyInput> property, [WorkflowExpression] Func<string> startDateTime, [WorkflowExpression] Func<string> endDateTime, [WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<intervalInput> interval = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStationsExtremeEventsResponse> __BuildGetStationsExtremeEvents(WorkflowExpression<@operatorInput> @operator, WorkflowExpression<int> threshold, WorkflowExpression<propertyInput> property, WorkflowExpression<string> startDateTime, WorkflowExpression<string> endDateTime, WorkflowExpression<string> stationCode = null, WorkflowExpression<intervalInput> interval = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(@operator, nameof(@operator), required: true);
            WorkflowExpression.Validate(threshold, nameof(threshold), required: true);
            WorkflowExpression.Validate(property, nameof(property), required: true);
            WorkflowExpression.Validate(startDateTime, nameof(startDateTime), required: true);
            WorkflowExpression.Validate(endDateTime, nameof(endDateTime), required: true);
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(interval, nameof(interval), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<GetStationsExtremeEventsResponse>(() =>
            {
                var apiCallPath = "/stations/events";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                callPayload.Queries["operator"] = ExpressionConverter.Convert(@operator);
                callPayload.Queries["threshold"] = ExpressionConverter.Convert(threshold);
                callPayload.Queries["property"] = ExpressionConverter.Convert(property);
                callPayload.Queries["startDateTime"] = ExpressionConverter.Convert(startDateTime);
                callPayload.Queries["endDateTime"] = ExpressionConverter.Convert(endDateTime);
                if (interval != null)
                    callPayload.Queries["interval"] = ExpressionConverter.Convert(interval);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<GetStationsExtremeEventsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStationsLatestData))]
        public IBodyWorkflowAction<GetStationsLatestDataResponse> GetStationsLatestData([WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<groupInput> group = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStationsLatestDataResponse> __BuildGetStationsLatestData(WorkflowExpression<string> stationCode = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> select = null, WorkflowExpression<groupInput> group = null)
        {
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(group, nameof(group), required: false);
            return new DeferredBodyAction<GetStationsLatestDataResponse>(() =>
            {
                var apiCallPath = "/stations/latest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                return new ApiConnectionAction<GetStationsLatestDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStationBulletins))]
        public IBodyWorkflowAction<GetStationBulletinsResponse> GetStationBulletins([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> stationCode, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStationBulletinsResponse> __BuildGetStationBulletins(WorkflowExpression<string> startDate, WorkflowExpression<string> endDate, WorkflowExpression<string> stationCode, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(startDate, nameof(startDate), required: true);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: true);
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: true);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<GetStationBulletinsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/stations/{0}/bulletin", ExpressionConverter.ConvertWithUrlEncoding(stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<GetStationBulletinsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStationLatestData))]
        public IBodyWorkflowAction<GetStationLatestDataResponse> GetStationLatestData([WorkflowExpression] Func<string> stationCode, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStationLatestDataResponse> __BuildGetStationLatestData(WorkflowExpression<string> stationCode, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: true);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<GetStationLatestDataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/stations/{0}/latest", ExpressionConverter.ConvertWithUrlEncoding(stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<GetStationLatestDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStationMinuteData))]
        public IBodyWorkflowAction<GetStationMinuteDataResponse> GetStationMinuteData([WorkflowExpression] Func<string> stationCode, [WorkflowExpression] Func<string> startDateTime, [WorkflowExpression] Func<string> endDateTime, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStationMinuteDataResponse> __BuildGetStationMinuteData(WorkflowExpression<string> stationCode, WorkflowExpression<string> startDateTime, WorkflowExpression<string> endDateTime, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: true);
            WorkflowExpression.Validate(startDateTime, nameof(startDateTime), required: true);
            WorkflowExpression.Validate(endDateTime, nameof(endDateTime), required: true);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<GetStationMinuteDataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/stations/{0}/data", ExpressionConverter.ConvertWithUrlEncoding(stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDateTime"] = ExpressionConverter.Convert(startDateTime);
                callPayload.Queries["endDateTime"] = ExpressionConverter.Convert(endDateTime);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<GetStationMinuteDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStations15minSummary))]
        public IBodyWorkflowAction<MultiStationSummarySchemaModel> GetStations15minSummary([WorkflowExpression] Func<string> startDateTime, [WorkflowExpression] Func<string> endDateTime, [WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<groupInput> group = null, [WorkflowExpression] Func<bool> includeClosed = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MultiStationSummarySchemaModel> __BuildGetStations15minSummary(WorkflowExpression<string> startDateTime, WorkflowExpression<string> endDateTime, WorkflowExpression<string> stationCode = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<groupInput> group = null, WorkflowExpression<bool> includeClosed = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(startDateTime, nameof(startDateTime), required: true);
            WorkflowExpression.Validate(endDateTime, nameof(endDateTime), required: true);
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(group, nameof(group), required: false);
            WorkflowExpression.Validate(includeClosed, nameof(includeClosed), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<MultiStationSummarySchemaModel>(() =>
            {
                var apiCallPath = "/stations/summaries/15min";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDateTime"] = ExpressionConverter.Convert(startDateTime);
                callPayload.Queries["endDateTime"] = ExpressionConverter.Convert(endDateTime);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                if (includeClosed != null)
                    callPayload.Queries["includeClosed"] = ExpressionConverter.Convert(includeClosed);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<MultiStationSummarySchemaModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStations30minSummary))]
        public IBodyWorkflowAction<MultiStationSummarySchemaModel> GetStations30minSummary([WorkflowExpression] Func<string> startDateTime, [WorkflowExpression] Func<string> endDateTime, [WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<groupInput> group = null, [WorkflowExpression] Func<bool> includeClosed = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MultiStationSummarySchemaModel> __BuildGetStations30minSummary(WorkflowExpression<string> startDateTime, WorkflowExpression<string> endDateTime, WorkflowExpression<string> stationCode = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<groupInput> group = null, WorkflowExpression<bool> includeClosed = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(startDateTime, nameof(startDateTime), required: true);
            WorkflowExpression.Validate(endDateTime, nameof(endDateTime), required: true);
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(group, nameof(group), required: false);
            WorkflowExpression.Validate(includeClosed, nameof(includeClosed), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<MultiStationSummarySchemaModel>(() =>
            {
                var apiCallPath = "/stations/summaries/30min";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDateTime"] = ExpressionConverter.Convert(startDateTime);
                callPayload.Queries["endDateTime"] = ExpressionConverter.Convert(endDateTime);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                if (includeClosed != null)
                    callPayload.Queries["includeClosed"] = ExpressionConverter.Convert(includeClosed);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<MultiStationSummarySchemaModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStationsHourlySummary))]
        public IBodyWorkflowAction<MultiStationSummarySchemaModel> GetStationsHourlySummary([WorkflowExpression] Func<string> startDateTime, [WorkflowExpression] Func<string> endDateTime, [WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<groupInput> group = null, [WorkflowExpression] Func<bool> includeClosed = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MultiStationSummarySchemaModel> __BuildGetStationsHourlySummary(WorkflowExpression<string> startDateTime, WorkflowExpression<string> endDateTime, WorkflowExpression<string> stationCode = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<groupInput> group = null, WorkflowExpression<bool> includeClosed = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(startDateTime, nameof(startDateTime), required: true);
            WorkflowExpression.Validate(endDateTime, nameof(endDateTime), required: true);
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(group, nameof(group), required: false);
            WorkflowExpression.Validate(includeClosed, nameof(includeClosed), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<MultiStationSummarySchemaModel>(() =>
            {
                var apiCallPath = "/stations/summaries/hourly";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDateTime"] = ExpressionConverter.Convert(startDateTime);
                callPayload.Queries["endDateTime"] = ExpressionConverter.Convert(endDateTime);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                if (includeClosed != null)
                    callPayload.Queries["includeClosed"] = ExpressionConverter.Convert(includeClosed);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<MultiStationSummarySchemaModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStationsDailySummary))]
        public IBodyWorkflowAction<MultiStationSummarySchemaModel> GetStationsDailySummary([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<groupInput> group = null, [WorkflowExpression] Func<bool> includeClosed = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MultiStationSummarySchemaModel> __BuildGetStationsDailySummary(WorkflowExpression<string> startDate, WorkflowExpression<string> endDate, WorkflowExpression<string> stationCode = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<groupInput> group = null, WorkflowExpression<bool> includeClosed = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(startDate, nameof(startDate), required: true);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: true);
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(group, nameof(group), required: false);
            WorkflowExpression.Validate(includeClosed, nameof(includeClosed), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<MultiStationSummarySchemaModel>(() =>
            {
                var apiCallPath = "/stations/summaries/daily";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                if (includeClosed != null)
                    callPayload.Queries["includeClosed"] = ExpressionConverter.Convert(includeClosed);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<MultiStationSummarySchemaModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStationsMonthlySummary))]
        public IBodyWorkflowAction<MultiStationSummarySchemaModel> GetStationsMonthlySummary([WorkflowExpression] Func<string> startMonth, [WorkflowExpression] Func<string> endMonth, [WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<groupInput> group = null, [WorkflowExpression] Func<bool> includeClosed = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MultiStationSummarySchemaModel> __BuildGetStationsMonthlySummary(WorkflowExpression<string> startMonth, WorkflowExpression<string> endMonth, WorkflowExpression<string> stationCode = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<groupInput> group = null, WorkflowExpression<bool> includeClosed = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(startMonth, nameof(startMonth), required: true);
            WorkflowExpression.Validate(endMonth, nameof(endMonth), required: true);
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(group, nameof(group), required: false);
            WorkflowExpression.Validate(includeClosed, nameof(includeClosed), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<MultiStationSummarySchemaModel>(() =>
            {
                var apiCallPath = "/stations/summaries/monthly";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startMonth"] = ExpressionConverter.Convert(startMonth);
                callPayload.Queries["endMonth"] = ExpressionConverter.Convert(endMonth);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                if (includeClosed != null)
                    callPayload.Queries["includeClosed"] = ExpressionConverter.Convert(includeClosed);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<MultiStationSummarySchemaModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStationsYearlySummary))]
        public IBodyWorkflowAction<MultiStationSummarySchemaModel> GetStationsYearlySummary([WorkflowExpression] Func<string> startYear, [WorkflowExpression] Func<string> endYear, [WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<groupInput> group = null, [WorkflowExpression] Func<bool> includeClosed = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MultiStationSummarySchemaModel> __BuildGetStationsYearlySummary(WorkflowExpression<string> startYear, WorkflowExpression<string> endYear, WorkflowExpression<string> stationCode = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<groupInput> group = null, WorkflowExpression<bool> includeClosed = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(startYear, nameof(startYear), required: true);
            WorkflowExpression.Validate(endYear, nameof(endYear), required: true);
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(group, nameof(group), required: false);
            WorkflowExpression.Validate(includeClosed, nameof(includeClosed), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<MultiStationSummarySchemaModel>(() =>
            {
                var apiCallPath = "/stations/summaries/yearly";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startYear"] = ExpressionConverter.Convert(startYear);
                callPayload.Queries["endYear"] = ExpressionConverter.Convert(endYear);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                if (includeClosed != null)
                    callPayload.Queries["includeClosed"] = ExpressionConverter.Convert(includeClosed);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<MultiStationSummarySchemaModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStations15minSummaryTimeSeries))]
        public IBodyWorkflowAction<StationTimeSeriesSchemaModel> GetStations15minSummaryTimeSeries([WorkflowExpression] Func<string> startDateTime, [WorkflowExpression] Func<string> endDateTime, [WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<groupInput> group = null, [WorkflowExpression] Func<bool> includeClosed = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StationTimeSeriesSchemaModel> __BuildGetStations15minSummaryTimeSeries(WorkflowExpression<string> startDateTime, WorkflowExpression<string> endDateTime, WorkflowExpression<string> stationCode = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<groupInput> group = null, WorkflowExpression<bool> includeClosed = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(startDateTime, nameof(startDateTime), required: true);
            WorkflowExpression.Validate(endDateTime, nameof(endDateTime), required: true);
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(group, nameof(group), required: false);
            WorkflowExpression.Validate(includeClosed, nameof(includeClosed), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<StationTimeSeriesSchemaModel>(() =>
            {
                var apiCallPath = "/stations/summaries/15min/timeseries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDateTime"] = ExpressionConverter.Convert(startDateTime);
                callPayload.Queries["endDateTime"] = ExpressionConverter.Convert(endDateTime);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                if (includeClosed != null)
                    callPayload.Queries["includeClosed"] = ExpressionConverter.Convert(includeClosed);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<StationTimeSeriesSchemaModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStations30minSummaryTimeSeries))]
        public IBodyWorkflowAction<StationTimeSeriesSchemaModel> GetStations30minSummaryTimeSeries([WorkflowExpression] Func<string> startDateTime, [WorkflowExpression] Func<string> endDateTime, [WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<groupInput> group = null, [WorkflowExpression] Func<bool> includeClosed = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StationTimeSeriesSchemaModel> __BuildGetStations30minSummaryTimeSeries(WorkflowExpression<string> startDateTime, WorkflowExpression<string> endDateTime, WorkflowExpression<string> stationCode = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<groupInput> group = null, WorkflowExpression<bool> includeClosed = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(startDateTime, nameof(startDateTime), required: true);
            WorkflowExpression.Validate(endDateTime, nameof(endDateTime), required: true);
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(group, nameof(group), required: false);
            WorkflowExpression.Validate(includeClosed, nameof(includeClosed), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<StationTimeSeriesSchemaModel>(() =>
            {
                var apiCallPath = "/stations/summaries/30min/timeseries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDateTime"] = ExpressionConverter.Convert(startDateTime);
                callPayload.Queries["endDateTime"] = ExpressionConverter.Convert(endDateTime);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                if (includeClosed != null)
                    callPayload.Queries["includeClosed"] = ExpressionConverter.Convert(includeClosed);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<StationTimeSeriesSchemaModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStationsHourlySummaryTimeSeries))]
        public IBodyWorkflowAction<StationTimeSeriesSchemaModel> GetStationsHourlySummaryTimeSeries([WorkflowExpression] Func<string> startDateTime, [WorkflowExpression] Func<string> endDateTime, [WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<groupInput> group = null, [WorkflowExpression] Func<bool> includeClosed = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StationTimeSeriesSchemaModel> __BuildGetStationsHourlySummaryTimeSeries(WorkflowExpression<string> startDateTime, WorkflowExpression<string> endDateTime, WorkflowExpression<string> stationCode = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<groupInput> group = null, WorkflowExpression<bool> includeClosed = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(startDateTime, nameof(startDateTime), required: true);
            WorkflowExpression.Validate(endDateTime, nameof(endDateTime), required: true);
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(group, nameof(group), required: false);
            WorkflowExpression.Validate(includeClosed, nameof(includeClosed), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<StationTimeSeriesSchemaModel>(() =>
            {
                var apiCallPath = "/stations/summaries/hourly/timeseries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDateTime"] = ExpressionConverter.Convert(startDateTime);
                callPayload.Queries["endDateTime"] = ExpressionConverter.Convert(endDateTime);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                if (includeClosed != null)
                    callPayload.Queries["includeClosed"] = ExpressionConverter.Convert(includeClosed);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<StationTimeSeriesSchemaModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStationsDailySummaryTimeSeries))]
        public IBodyWorkflowAction<StationTimeSeriesSchemaModel> GetStationsDailySummaryTimeSeries([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<groupInput> group = null, [WorkflowExpression] Func<bool> includeClosed = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StationTimeSeriesSchemaModel> __BuildGetStationsDailySummaryTimeSeries(WorkflowExpression<string> startDate, WorkflowExpression<string> endDate, WorkflowExpression<string> stationCode = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<groupInput> group = null, WorkflowExpression<bool> includeClosed = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(startDate, nameof(startDate), required: true);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: true);
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(group, nameof(group), required: false);
            WorkflowExpression.Validate(includeClosed, nameof(includeClosed), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<StationTimeSeriesSchemaModel>(() =>
            {
                var apiCallPath = "/stations/summaries/daily/timeseries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                if (includeClosed != null)
                    callPayload.Queries["includeClosed"] = ExpressionConverter.Convert(includeClosed);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<StationTimeSeriesSchemaModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStationsMonthlySummaryTimeSeries))]
        public IBodyWorkflowAction<StationTimeSeriesSchemaModel> GetStationsMonthlySummaryTimeSeries([WorkflowExpression] Func<string> startMonth, [WorkflowExpression] Func<string> endMonth, [WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<groupInput> group = null, [WorkflowExpression] Func<bool> includeClosed = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StationTimeSeriesSchemaModel> __BuildGetStationsMonthlySummaryTimeSeries(WorkflowExpression<string> startMonth, WorkflowExpression<string> endMonth, WorkflowExpression<string> stationCode = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<groupInput> group = null, WorkflowExpression<bool> includeClosed = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(startMonth, nameof(startMonth), required: true);
            WorkflowExpression.Validate(endMonth, nameof(endMonth), required: true);
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(group, nameof(group), required: false);
            WorkflowExpression.Validate(includeClosed, nameof(includeClosed), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<StationTimeSeriesSchemaModel>(() =>
            {
                var apiCallPath = "/stations/summaries/monthly/timeseries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startMonth"] = ExpressionConverter.Convert(startMonth);
                callPayload.Queries["endMonth"] = ExpressionConverter.Convert(endMonth);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                if (includeClosed != null)
                    callPayload.Queries["includeClosed"] = ExpressionConverter.Convert(includeClosed);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<StationTimeSeriesSchemaModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStationsYearlySummaryTimeSeries))]
        public IBodyWorkflowAction<StationTimeSeriesSchemaModel> GetStationsYearlySummaryTimeSeries([WorkflowExpression] Func<string> startYear, [WorkflowExpression] Func<string> endYear, [WorkflowExpression] Func<string> stationCode = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<groupInput> group = null, [WorkflowExpression] Func<bool> includeClosed = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StationTimeSeriesSchemaModel> __BuildGetStationsYearlySummaryTimeSeries(WorkflowExpression<string> startYear, WorkflowExpression<string> endYear, WorkflowExpression<string> stationCode = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<groupInput> group = null, WorkflowExpression<bool> includeClosed = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(startYear, nameof(startYear), required: true);
            WorkflowExpression.Validate(endYear, nameof(endYear), required: true);
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(group, nameof(group), required: false);
            WorkflowExpression.Validate(includeClosed, nameof(includeClosed), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<StationTimeSeriesSchemaModel>(() =>
            {
                var apiCallPath = "/stations/summaries/yearly/timeseries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startYear"] = ExpressionConverter.Convert(startYear);
                callPayload.Queries["endYear"] = ExpressionConverter.Convert(endYear);
                if (stationCode != null)
                    callPayload.Queries["stationCode"] = ExpressionConverter.Convert(stationCode);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                if (includeClosed != null)
                    callPayload.Queries["includeClosed"] = ExpressionConverter.Convert(includeClosed);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<StationTimeSeriesSchemaModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStation15minSummary))]
        public IBodyWorkflowAction<SingleStationSummarySchemaModel> GetStation15minSummary([WorkflowExpression] Func<string> stationCode, [WorkflowExpression] Func<string> startDateTime, [WorkflowExpression] Func<string> endDateTime, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleStationSummarySchemaModel> __BuildGetStation15minSummary(WorkflowExpression<string> stationCode, WorkflowExpression<string> startDateTime, WorkflowExpression<string> endDateTime, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: true);
            WorkflowExpression.Validate(startDateTime, nameof(startDateTime), required: true);
            WorkflowExpression.Validate(endDateTime, nameof(endDateTime), required: true);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<SingleStationSummarySchemaModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/stations/{0}/summaries/15min", ExpressionConverter.ConvertWithUrlEncoding(stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDateTime"] = ExpressionConverter.Convert(startDateTime);
                callPayload.Queries["endDateTime"] = ExpressionConverter.Convert(endDateTime);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<SingleStationSummarySchemaModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStation30minSummary))]
        public IBodyWorkflowAction<SingleStationSummarySchemaModel> GetStation30minSummary([WorkflowExpression] Func<string> stationCode, [WorkflowExpression] Func<string> startDateTime, [WorkflowExpression] Func<string> endDateTime, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleStationSummarySchemaModel> __BuildGetStation30minSummary(WorkflowExpression<string> stationCode, WorkflowExpression<string> startDateTime, WorkflowExpression<string> endDateTime, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: true);
            WorkflowExpression.Validate(startDateTime, nameof(startDateTime), required: true);
            WorkflowExpression.Validate(endDateTime, nameof(endDateTime), required: true);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<SingleStationSummarySchemaModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/stations/{0}/summaries/30min", ExpressionConverter.ConvertWithUrlEncoding(stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDateTime"] = ExpressionConverter.Convert(startDateTime);
                callPayload.Queries["endDateTime"] = ExpressionConverter.Convert(endDateTime);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<SingleStationSummarySchemaModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStationHourlySummary))]
        public IBodyWorkflowAction<SingleStationSummarySchemaModel> GetStationHourlySummary([WorkflowExpression] Func<string> stationCode, [WorkflowExpression] Func<string> startDateTime, [WorkflowExpression] Func<string> endDateTime, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleStationSummarySchemaModel> __BuildGetStationHourlySummary(WorkflowExpression<string> stationCode, WorkflowExpression<string> startDateTime, WorkflowExpression<string> endDateTime, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: true);
            WorkflowExpression.Validate(startDateTime, nameof(startDateTime), required: true);
            WorkflowExpression.Validate(endDateTime, nameof(endDateTime), required: true);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<SingleStationSummarySchemaModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/stations/{0}/summaries/hourly", ExpressionConverter.ConvertWithUrlEncoding(stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDateTime"] = ExpressionConverter.Convert(startDateTime);
                callPayload.Queries["endDateTime"] = ExpressionConverter.Convert(endDateTime);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<SingleStationSummarySchemaModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStationDailySummary))]
        public IBodyWorkflowAction<SingleStationSummarySchemaModel> GetStationDailySummary([WorkflowExpression] Func<string> stationCode, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleStationSummarySchemaModel> __BuildGetStationDailySummary(WorkflowExpression<string> stationCode, WorkflowExpression<string> startDate, WorkflowExpression<string> endDate, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: true);
            WorkflowExpression.Validate(startDate, nameof(startDate), required: true);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: true);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<SingleStationSummarySchemaModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/stations/{0}/summaries/daily", ExpressionConverter.ConvertWithUrlEncoding(stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<SingleStationSummarySchemaModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStationMonthlySummary))]
        public IBodyWorkflowAction<SingleStationSummarySchemaModel> GetStationMonthlySummary([WorkflowExpression] Func<string> stationCode, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleStationSummarySchemaModel> __BuildGetStationMonthlySummary(WorkflowExpression<string> stationCode, WorkflowExpression<string> startDate, WorkflowExpression<string> endDate, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: true);
            WorkflowExpression.Validate(startDate, nameof(startDate), required: true);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: true);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<SingleStationSummarySchemaModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/stations/{0}/summaries/monthly", ExpressionConverter.ConvertWithUrlEncoding(stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<SingleStationSummarySchemaModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStationYearlySummary))]
        public IBodyWorkflowAction<SingleStationSummarySchemaModel> GetStationYearlySummary([WorkflowExpression] Func<string> stationCode, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dpirdweatherip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleStationSummarySchemaModel> __BuildGetStationYearlySummary(WorkflowExpression<string> stationCode, WorkflowExpression<string> startDate, WorkflowExpression<string> endDate, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(stationCode, nameof(stationCode), required: true);
            WorkflowExpression.Validate(startDate, nameof(startDate), required: true);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: true);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<SingleStationSummarySchemaModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/stations/{0}/summaries/yearly", ExpressionConverter.ConvertWithUrlEncoding(stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<SingleStationSummarySchemaModel>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum @operatorInput
    {
        [EnumMember(Value = "gt")]
        Gt,
        [EnumMember(Value = "lt")]
        Lt
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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