//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Delijnip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class DelijnipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "delijnip")]
        public IBodyWorkflowAction<HaltesHits> SearchStops(Expression<Func<string>> searchTerm, Expression<Func<string>> huidigePositie = null, Expression<Func<int>> startIndex = null, Expression<Func<int>> maxAantalHits = null)
        {
            var __workflow_searchTerm = WorkflowExpression.Compile(searchTerm, nameof(searchTerm), required: true);
            var __workflow_huidigePositie = WorkflowExpression.Compile(huidigePositie, nameof(huidigePositie), required: false);
            var __workflow_startIndex = WorkflowExpression.Compile(startIndex, nameof(startIndex), required: false);
            var __workflow_maxAantalHits = WorkflowExpression.Compile(maxAantalHits, nameof(maxAantalHits), required: false);
            return new DeferredBodyAction<HaltesHits>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/zoek/haltes/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_searchTerm, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_huidigePositie != null)
                    callPayload.Queries["huidigePositie"] = ExpressionConverter.Convert(__workflow_huidigePositie);
                callPayload.Queries["startIndex"] = Convert.ToString(0);
                if (__workflow_startIndex != null)
                    callPayload.Queries["startIndex"] = ExpressionConverter.Convert(__workflow_startIndex);
                callPayload.Queries["maxAantalHits"] = Convert.ToString(10);
                if (__workflow_maxAantalHits != null)
                    callPayload.Queries["maxAantalHits"] = ExpressionConverter.Convert(__workflow_maxAantalHits);
                return new ApiConnectionAction<HaltesHits>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "delijnip")]
        public IBodyWorkflowAction<LijnRichtingHits> SearchLines(Expression<Func<string>> searchTerm, Expression<Func<string>> huidigePositie = null, Expression<Func<int>> startIndex = null, Expression<Func<int>> maxAantalHits = null)
        {
            var __workflow_searchTerm = WorkflowExpression.Compile(searchTerm, nameof(searchTerm), required: true);
            var __workflow_huidigePositie = WorkflowExpression.Compile(huidigePositie, nameof(huidigePositie), required: false);
            var __workflow_startIndex = WorkflowExpression.Compile(startIndex, nameof(startIndex), required: false);
            var __workflow_maxAantalHits = WorkflowExpression.Compile(maxAantalHits, nameof(maxAantalHits), required: false);
            return new DeferredBodyAction<LijnRichtingHits>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/zoek/lijnrichtingen/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_searchTerm, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_huidigePositie != null)
                    callPayload.Queries["huidigePositie"] = ExpressionConverter.Convert(__workflow_huidigePositie);
                callPayload.Queries["startIndex"] = Convert.ToString(0);
                if (__workflow_startIndex != null)
                    callPayload.Queries["startIndex"] = ExpressionConverter.Convert(__workflow_startIndex);
                callPayload.Queries["maxAantalHits"] = Convert.ToString(10);
                if (__workflow_maxAantalHits != null)
                    callPayload.Queries["maxAantalHits"] = ExpressionConverter.Convert(__workflow_maxAantalHits);
                return new ApiConnectionAction<LijnRichtingHits>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "delijnip")]
        public IBodyWorkflowAction<LocatiesHits> SearchLocations(Expression<Func<string>> searchTerm, Expression<Func<string>> huidigePositie = null, Expression<Func<int>> startIndex = null, Expression<Func<int>> maxAantalHits = null)
        {
            var __workflow_searchTerm = WorkflowExpression.Compile(searchTerm, nameof(searchTerm), required: true);
            var __workflow_huidigePositie = WorkflowExpression.Compile(huidigePositie, nameof(huidigePositie), required: false);
            var __workflow_startIndex = WorkflowExpression.Compile(startIndex, nameof(startIndex), required: false);
            var __workflow_maxAantalHits = WorkflowExpression.Compile(maxAantalHits, nameof(maxAantalHits), required: false);
            return new DeferredBodyAction<LocatiesHits>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/zoek/locaties/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_searchTerm, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_huidigePositie != null)
                    callPayload.Queries["huidigePositie"] = ExpressionConverter.Convert(__workflow_huidigePositie);
                callPayload.Queries["startIndex"] = Convert.ToString(0);
                if (__workflow_startIndex != null)
                    callPayload.Queries["startIndex"] = ExpressionConverter.Convert(__workflow_startIndex);
                callPayload.Queries["maxAantalHits"] = Convert.ToString(10);
                if (__workflow_maxAantalHits != null)
                    callPayload.Queries["maxAantalHits"] = ExpressionConverter.Convert(__workflow_maxAantalHits);
                return new ApiConnectionAction<LocatiesHits>(callPayload);
            });
        }
    }

    public class DelijnipTriggers([ConnectionName] string connectionId)
    {
    }

    public class HaltesHits
    {
        [JsonProperty("aantalHits")]
        public int AantalHits { get; set; }

        [JsonProperty("haltes")]
        public Halte[] Haltes { get; set; }
    }

    public class Halte
    {
        [JsonProperty("entiteitnummer")]
        public string Entiteitnummer { get; set; }

        [JsonProperty("haltenummer")]
        public string Haltenummer { get; set; }

        [JsonProperty("omschrijving")]
        public string Omschrijving { get; set; }

        [JsonProperty("gemeentenummer")]
        public int Gemeentenummer { get; set; }

        [JsonProperty("omschrijvingGemeente")]
        public string OmschrijvingGemeente { get; set; }

        [JsonProperty("geoCoordinaat")]
        public GeoCoordinaat GeoCoordinaat { get; set; }

        [JsonProperty("links")]
        public Link[] Links { get; set; }
    }

    public class GeoCoordinaat
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class Link
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class LijnRichtingHits
    {
        [JsonProperty("aantalHits")]
        public int AantalHits { get; set; }

        [JsonProperty("lijnrichtingen")]
        public Lijnrichting[] Lijnrichtingen { get; set; }
    }

    public class Lijnrichting
    {
        [JsonProperty("lijnNummerPubliek")]
        public string LijnNummerPubliek { get; set; }

        [JsonProperty("entiteitnummer")]
        public string Entiteitnummer { get; set; }

        [JsonProperty("lijnnummer")]
        public string Lijnnummer { get; set; }

        [JsonProperty("richting")]
        public LijnrichtingRichtingType Richting { get; set; }

        [JsonProperty("omschrijving")]
        public string Omschrijving { get; set; }

        [JsonProperty("bestemming")]
        public string Bestemming { get; set; }

        [JsonProperty("kleurVoorGrond")]
        public string KleurVoorGrond { get; set; }

        [JsonProperty("kleurAchterGrond")]
        public string KleurAchterGrond { get; set; }

        [JsonProperty("kleurAchterGrondRand")]
        public string KleurAchterGrondRand { get; set; }

        [JsonProperty("links")]
        public Link[] Links { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LijnrichtingRichtingType
    {
        HEEN,
        TERUG
    }

    public class LocatiesHits
    {
        [JsonProperty("aantalHits")]
        public int AantalHits { get; set; }

        [JsonProperty("locaties")]
        public Locatie[] Locaties { get; set; }
    }

    public class Locatie
    {
        [JsonProperty("type")]
        public LocatieTypeType Type { get; set; }

        [JsonProperty("subtype")]
        public LocatieSubtypeType Subtype { get; set; }

        [JsonProperty("deelgemeentes")]
        public string[] Deelgemeentes { get; set; }

        [JsonProperty("hoofdgemeente")]
        public string Hoofdgemeente { get; set; }

        [JsonProperty("straat")]
        public string Straat { get; set; }

        [JsonProperty("haltenummer")]
        public string Haltenummer { get; set; }

        [JsonProperty("huisnummer")]
        public string Huisnummer { get; set; }

        [JsonProperty("geoCoordinaat")]
        public GeoCoordinaat GeoCoordinaat { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LocatieTypeType
    {
        [EnumMember(Value = "adres")]
        Adres,
        [EnumMember(Value = "halte")]
        Halte,
        [EnumMember(Value = "herkenningspunt")]
        Herkenningspunt,
        [EnumMember(Value = "station")]
        Station
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LocatieSubtypeType
    {
        [EnumMember(Value = "hoofdgemeente")]
        Hoofdgemeente,
        [EnumMember(Value = "deelgemeente")]
        Deelgemeente,
        [EnumMember(Value = "straat")]
        Straat,
        [EnumMember(Value = "adres")]
        Adres,
        [EnumMember(Value = "halte")]
        Halte,
        [EnumMember(Value = "herkenningspunt")]
        Herkenningspunt,
        [EnumMember(Value = "station")]
        Station
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Delijnip;

    public partial class WorkflowManagedActions
    {
        public DelijnipActions Delijnip(string connectionId) => new DelijnipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DelijnipTriggers Delijnip(string connectionId) => new DelijnipTriggers(connectionId);
    }
}
