//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.What3wordsip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class What3wordsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "what3wordsip")]
        public IBodyWorkflowAction<ConvertToWordResponse> ConvertToWord([WorkflowExpression] Func<string> coordinates)
        {
            var apiCallPath = "/convert-to-3wa";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["coordinates"] = ExpressionConverter.Convert(coordinates);
            return new ApiConnectionAction<ConvertToWordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "what3wordsip")]
        public IBodyWorkflowAction<ConvertToLatLngResponse> ConvertToLatLng([WorkflowExpression] Func<string> words)
        {
            var apiCallPath = "/convert-to-coordinates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["words"] = ExpressionConverter.Convert(words);
            return new ApiConnectionAction<ConvertToLatLngResponse>(callPayload);
        }
    }

    public class What3wordsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ConvertToWordResponse
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("square")]
        public ConvertToWordResponseSquareType Square { get; set; }

        [JsonProperty("nearestPlace")]
        public string NearestPlace { get; set; }

        [JsonProperty("coordinates")]
        public ConvertToWordResponseCoordinatesType Coordinates { get; set; }

        [JsonProperty("words")]
        public string Words { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("map")]
        public string Map { get; set; }
    }

    public class ConvertToWordResponseSquareType
    {
        [JsonProperty("southwest")]
        public ConvertToWordResponseSquareTypeSouthwestType Southwest { get; set; }

        [JsonProperty("northeast")]
        public ConvertToWordResponseSquareTypeNortheastType Northeast { get; set; }
    }

    public class ConvertToWordResponseSquareTypeSouthwestType
    {
        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }
    }

    public class ConvertToWordResponseSquareTypeNortheastType
    {
        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }
    }

    public class ConvertToWordResponseCoordinatesType
    {
        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }
    }

    public class ConvertToLatLngResponse
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("square")]
        public ConvertToLatLngResponseSquareType Square { get; set; }

        [JsonProperty("nearestPlace")]
        public string NearestPlace { get; set; }

        [JsonProperty("coordinates")]
        public ConvertToLatLngResponseCoordinatesType Coordinates { get; set; }

        [JsonProperty("words")]
        public string Words { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("map")]
        public string Map { get; set; }
    }

    public class ConvertToLatLngResponseSquareType
    {
        [JsonProperty("southwest")]
        public ConvertToLatLngResponseSquareTypeSouthwestType Southwest { get; set; }

        [JsonProperty("northeast")]
        public ConvertToLatLngResponseSquareTypeNortheastType Northeast { get; set; }
    }

    public class ConvertToLatLngResponseSquareTypeSouthwestType
    {
        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }
    }

    public class ConvertToLatLngResponseSquareTypeNortheastType
    {
        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }
    }

    public class ConvertToLatLngResponseCoordinatesType
    {
        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.What3wordsip;

    public partial class WorkflowManagedActions
    {
        public What3wordsipActions What3wordsip(string connectionId) => new What3wordsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public What3wordsipTriggers What3wordsip(string connectionId) => new What3wordsipTriggers(connectionId);
    }
}