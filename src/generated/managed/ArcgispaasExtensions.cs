//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Arcgispaas
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ArcgispaasActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        public IBodyWorkflowAction<JToken> FeatureLayerApplyEdits([WorkflowExpression] Func<string> appLayer, [WorkflowExpression] Func<object> data = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/featureLayer/applyEdits";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["appLayer"] = SourceExpressionConverter.ConvertO(appLayer);
                callPayload.Body = SourceExpressionConverter.ConvertToken(data);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        public IBodyWorkflowAction<JToken> GetFeatureLayerInfo([WorkflowExpression] Func<string> appLayer)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/featureLayer/information";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["appLayer"] = SourceExpressionConverter.ConvertO(appLayer);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        public IBodyWorkflowAction<ReverseGeocodeResponse> ReverseGeocode([WorkflowExpression] Func<double> x, [WorkflowExpression] Func<double> y, [WorkflowExpression] Func<string> srs = null, [WorkflowExpression] Func<locationTypeInput> locationType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/geocode/reverseGeocode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x"] = SourceExpressionConverter.ConvertO(x);
                callPayload.Queries["y"] = SourceExpressionConverter.ConvertO(y);
                if (srs != null)
                    callPayload.Queries["srs"] = SourceExpressionConverter.ConvertO(srs);
                callPayload.Queries["locationType"] = Convert.ToString("Rooftop");
                if (locationType != null)
                    callPayload.Queries["locationType"] = SourceExpressionConverter.Convert(locationType);
                return callPayload;
            }

            return new ApiConnectionAction<ReverseGeocodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        public IBodyWorkflowAction<JToken> GeometryService([WorkflowExpression] Func<string> operation, [WorkflowExpression] Func<object> data = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/geometry/process";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["operation"] = SourceExpressionConverter.ConvertO(operation);
                callPayload.Body = SourceExpressionConverter.ConvertToken(data);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        public IBodyWorkflowAction<TimeConversionHelperResponse> TimeConversionHelper([WorkflowExpression] Func<string> datadateTime)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/helper/convertTime";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var data = new JObject();
                var datapropCount = 0;
                datapropCount++;
                data["dateTime"] = SourceExpressionConverter.ConvertToken(datadateTime);
                if (datapropCount > 0)
                {
                    callPayload.Body = data;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TimeConversionHelperResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        public IBodyWorkflowAction<CreatePointGeometryHelperResponse> CreatePointGeometryHelper([WorkflowExpression] Func<double> x, [WorkflowExpression] Func<double> y, [WorkflowExpression] Func<string> srs = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/helper/createPointGeometry";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x"] = SourceExpressionConverter.ConvertO(x);
                callPayload.Queries["y"] = SourceExpressionConverter.ConvertO(y);
                if (srs != null)
                    callPayload.Queries["srs"] = SourceExpressionConverter.ConvertO(srs);
                return callPayload;
            }

            return new ApiConnectionAction<CreatePointGeometryHelperResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        public IBodyWorkflowAction<JToken> EXIF([WorkflowExpression] Func<string> data = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/helper/exif";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(data);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        public IBodyWorkflowAction<JToken> GeocodeAddresses([WorkflowExpression] Func<string> dataaddresses)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/geocode/geocodeAddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var data = new JObject();
                var datapropCount = 0;
                datapropCount++;
                data["addresses"] = SourceExpressionConverter.ConvertToken(dataaddresses);
                if (datapropCount > 0)
                {
                    callPayload.Body = data;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        public IBodyWorkflowAction<GeoenrichV2Response> Geoenrich([WorkflowExpression] Func<string> country, [WorkflowExpression] Func<string> datacollection, [WorkflowExpression] Func<string> parameter, [WorkflowExpression] Func<buffertypeInput> buffertype, [WorkflowExpression] Func<object> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/geoenrichment/enrich";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country"] = SourceExpressionConverter.ConvertO(country);
                callPayload.Queries["datacollection"] = SourceExpressionConverter.ConvertO(datacollection);
                callPayload.Queries["parameter"] = SourceExpressionConverter.ConvertO(parameter);
                callPayload.Queries["buffertype"] = SourceExpressionConverter.Convert(buffertype);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<GeoenrichV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arcgispaas")]
        public IBodyWorkflowAction<GetRouteV2Response> GetRoute([WorkflowExpression] Func<string> routingroutingStops, [WorkflowExpression] Func<string> travelModeName = null, [WorkflowExpression] Func<bool> findBestSequence = null, [WorkflowExpression] Func<bool> preserveFirstStop = null, [WorkflowExpression] Func<bool> returnDirections = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/routing";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (travelModeName != null)
                    callPayload.Queries["travelModeName"] = SourceExpressionConverter.ConvertO(travelModeName);
                if (findBestSequence != null)
                    callPayload.Queries["findBestSequence"] = SourceExpressionConverter.ConvertO(findBestSequence);
                if (preserveFirstStop != null)
                    callPayload.Queries["preserveFirstStop"] = SourceExpressionConverter.ConvertO(preserveFirstStop);
                callPayload.Queries["returnDirections"] = Convert.ToString(true);
                if (returnDirections != null)
                    callPayload.Queries["returnDirections"] = SourceExpressionConverter.ConvertO(returnDirections);
                var routing = new JObject();
                var routingpropCount = 0;
                routingpropCount++;
                routing["stops"] = SourceExpressionConverter.ConvertToken(routingroutingStops);
                if (routingpropCount > 0)
                {
                    callPayload.Body = routing;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetRouteV2Response>(BuildSourceInput);
        }
    }

    public class ArcgispaasTriggers([ConnectionName] string connectionId)
    {
    }

    public class ReverseGeocodeResponse
    {
        [JsonProperty("address")]
        public ReverseGeocodeResponseAddressType Address { get; set; }

        [JsonProperty("location")]
        public ReverseGeocodeResponseLocationType Location { get; set; }
    }

    public class ReverseGeocodeResponseAddressType
    {
        [JsonProperty("Address")]
        public string ShortAddress { get; set; }

        [JsonProperty("LongLabel")]
        public string FullAddress { get; set; }
        public string City { get; set; }
        public string Region { get; set; }

        [JsonProperty("CntryName")]
        public string Country { get; set; }

        [JsonProperty("Postal")]
        public string ZIPOrPostalCode { get; set; }
    }

    public class ReverseGeocodeResponseLocationType
    {
        [JsonProperty("x")]
        public double LongitudeX { get; set; }

        [JsonProperty("y")]
        public double LatitudeY { get; set; }
    }

    public enum locationTypeInput
    {
        Rooftop,
        Street
    }

    public class TimeConversionHelperResponse
    {
        [JsonProperty("stringTime")]
        public string DateTime { get; set; }

        [JsonProperty("unixTimeStampSeconds")]
        public double UnixTimeStampInSeconds { get; set; }

        [JsonProperty("unixTimeStampMilliseconds")]
        public double UnixTimeStampInMilliseconds { get; set; }
    }

    public class CreatePointGeometryHelperResponse
    {
        [JsonProperty("geometry")]
        public JToken Geometry { get; set; }
    }

    public class GeoenrichV2Response
    {
        [JsonProperty("value")]
        public double ParameterValue { get; set; }

        [JsonProperty("parameterName")]
        public string ParameterName { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public enum buffertypeInput
    {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "ringbuffer")]
        RingBuffer,
        [EnumMember(Value = "networkservicearea")]
        NetworkServiceArea
    }

    public class GetRouteV2Response
    {
        public GetRouteV2ResponseDirectionsTypeItem[] Directions { get; set; }
        public string Name { get; set; }

        [JsonProperty("Kilometers")]
        public double DistanceInKilometers { get; set; }

        [JsonProperty("Miles")]
        public double DistanceInMiles { get; set; }
        public double TravelTime { get; set; }

        [JsonProperty("Geometry")]
        public JToken RouteGeometry { get; set; }
    }

    public class GetRouteV2ResponseDirectionsTypeItem
    {
        [JsonProperty("text")]
        public string DirectionText { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Arcgispaas;

    public partial class WorkflowManagedActions
    {
        public ArcgispaasActions Arcgispaas(string connectionId) => new ArcgispaasActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ArcgispaasTriggers Arcgispaas(string connectionId) => new ArcgispaasTriggers(connectionId);
    }
}