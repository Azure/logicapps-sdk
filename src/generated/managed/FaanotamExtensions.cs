//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Faanotam
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FaanotamActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "faanotam")]
        public IBodyWorkflowAction<GetNotamResponse> GetNotam(Expression<Func<string>> clientId, Expression<Func<string>> clientSecret)
        {
            var apiCallPath = "/notamapi/v1/notams";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["client_id"] = ExpressionConverter.Convert(clientId);
            callPayload.Headers["client_secret"] = ExpressionConverter.Convert(clientSecret);
            return new ApiConnectionAction<GetNotamResponse>(callPayload);
        }
    }

    public class FaanotamTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetNotamResponse
    {
        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("pageNum")]
        public int PageNum { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("items")]
        public GetNotamResponseItemsTypeItem[] Items { get; set; }
    }

    public class GetNotamResponseItemsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public GetNotamResponseItemsTypeItemPropertiesType Properties { get; set; }

        [JsonProperty("geometry")]
        public GetNotamResponseItemsTypeItemGeometryType Geometry { get; set; }
    }

    public class GetNotamResponseItemsTypeItemPropertiesType
    {
        [JsonProperty("coreNOTAMData")]
        public GetNotamResponseItemsTypeItemPropertiesTypeCoreNOTAMDataType CoreNOTAMData { get; set; }
    }

    public class GetNotamResponseItemsTypeItemPropertiesTypeCoreNOTAMDataType
    {
        [JsonProperty("notamEvent")]
        public GetNotamResponseItemsTypeItemPropertiesTypeCoreNOTAMDataTypeNotamEventType NotamEvent { get; set; }

        [JsonProperty("notam")]
        public GetNotamResponseItemsTypeItemPropertiesTypeCoreNOTAMDataTypeNotamType Notam { get; set; }

        [JsonProperty("notamTranslation")]
        public GetNotamResponseItemsTypeItemPropertiesTypeCoreNOTAMDataTypeNotamTranslationTypeItem[] NotamTranslation { get; set; }
    }

    public class GetNotamResponseItemsTypeItemPropertiesTypeCoreNOTAMDataTypeNotamEventType
    {
        [JsonProperty("scenario")]
        public string Scenario { get; set; }
    }

    public class GetNotamResponseItemsTypeItemPropertiesTypeCoreNOTAMDataTypeNotamType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("series")]
        public string Series { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("affectedFIR")]
        public string AffectedFIR { get; set; }

        [JsonProperty("selectionCode")]
        public string SelectionCode { get; set; }

        [JsonProperty("traffic")]
        public string Traffic { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("minimumFL")]
        public string MinimumFL { get; set; }

        [JsonProperty("maximumFL")]
        public string MaximumFL { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("effectiveStart")]
        public string EffectiveStart { get; set; }

        [JsonProperty("effectiveEnd")]
        public string EffectiveEnd { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }

        [JsonProperty("icaoLocation")]
        public string IcaoLocation { get; set; }

        [JsonProperty("coordinates")]
        public string Coordinates { get; set; }

        [JsonProperty("radius")]
        public string Radius { get; set; }

        [JsonProperty("schedule")]
        public string Schedule { get; set; }

        [JsonProperty("lowerLimit")]
        public string LowerLimit { get; set; }

        [JsonProperty("upperLimit")]
        public string UpperLimit { get; set; }
    }

    public class GetNotamResponseItemsTypeItemPropertiesTypeCoreNOTAMDataTypeNotamTranslationTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("formattedText")]
        public string FormattedText { get; set; }
    }

    public class GetNotamResponseItemsTypeItemGeometryType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("geometries")]
        public GetNotamResponseItemsTypeItemGeometryTypeGeometriesTypeItem[] Geometries { get; set; }
    }

    public class GetNotamResponseItemsTypeItemGeometryTypeGeometriesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coordinates")]
        public double[] Coordinates { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Faanotam;

    public partial class WorkflowManagedActions
    {
        public FaanotamActions Faanotam(string connectionId) => new FaanotamActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FaanotamTriggers Faanotam(string connectionId) => new FaanotamTriggers(connectionId);
    }
}