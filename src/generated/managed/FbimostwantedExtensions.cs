//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fbimostwanted
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FbimostwantedActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fbimostwanted")]
        public IBodyWorkflowAction<ListWantedResponse> ListWanted(Expression<Func<posterClassificationInput>> posterClassification = null, Expression<Func<string>> title = null, Expression<Func<fieldOfficesInput>> fieldOffices = null, Expression<Func<personClassificationInput>> personClassification = null, Expression<Func<statusInput>> status = null, Expression<Func<int>> pageSize = null, Expression<Func<int>> page = null, Expression<Func<sortOnInput>> sortOn = null, Expression<Func<sortOrderInput>> sortOrder = null)
        {
            var __workflow_posterClassification = WorkflowExpression.Compile(posterClassification, nameof(posterClassification), required: false);
            var __workflow_title = WorkflowExpression.Compile(title, nameof(title), required: false);
            var __workflow_fieldOffices = WorkflowExpression.Compile(fieldOffices, nameof(fieldOffices), required: false);
            var __workflow_personClassification = WorkflowExpression.Compile(personClassification, nameof(personClassification), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_sortOn = WorkflowExpression.Compile(sortOn, nameof(sortOn), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            return new DeferredBodyAction<ListWantedResponse>(() =>
            {
                var apiCallPath = "/@wanted";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_posterClassification != null)
                    callPayload.Queries["poster_classification"] = ExpressionConverter.Convert(__workflow_posterClassification);
                if (__workflow_title != null)
                    callPayload.Queries["title"] = ExpressionConverter.Convert(__workflow_title);
                if (__workflow_fieldOffices != null)
                    callPayload.Queries["field_offices"] = ExpressionConverter.Convert(__workflow_fieldOffices);
                if (__workflow_personClassification != null)
                    callPayload.Queries["person_classification"] = ExpressionConverter.Convert(__workflow_personClassification);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_sortOn != null)
                    callPayload.Queries["sort_on"] = ExpressionConverter.Convert(__workflow_sortOn);
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                return new ApiConnectionAction<ListWantedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fbimostwanted")]
        public IBodyWorkflowAction<WantedPerson> GetWantedPerson(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<WantedPerson>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/@wanted-person/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<WantedPerson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fbimostwanted")]
        public IBodyWorkflowAction<ListArtCrimesResponse> ListArtCrimes(Expression<Func<string>> title = null, Expression<Func<string>> crimeCategory = null, Expression<Func<string>> maker = null, Expression<Func<string>> referenceNumber = null, Expression<Func<int>> pageSize = null, Expression<Func<int>> page = null, Expression<Func<sortOnInput>> sortOn = null, Expression<Func<sortOrderInput>> sortOrder = null)
        {
            var __workflow_title = WorkflowExpression.Compile(title, nameof(title), required: false);
            var __workflow_crimeCategory = WorkflowExpression.Compile(crimeCategory, nameof(crimeCategory), required: false);
            var __workflow_maker = WorkflowExpression.Compile(maker, nameof(maker), required: false);
            var __workflow_referenceNumber = WorkflowExpression.Compile(referenceNumber, nameof(referenceNumber), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_sortOn = WorkflowExpression.Compile(sortOn, nameof(sortOn), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            return new DeferredBodyAction<ListArtCrimesResponse>(() =>
            {
                var apiCallPath = "/@artcrimes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_title != null)
                    callPayload.Queries["title"] = ExpressionConverter.Convert(__workflow_title);
                if (__workflow_crimeCategory != null)
                    callPayload.Queries["crimeCategory"] = ExpressionConverter.Convert(__workflow_crimeCategory);
                if (__workflow_maker != null)
                    callPayload.Queries["maker"] = ExpressionConverter.Convert(__workflow_maker);
                if (__workflow_referenceNumber != null)
                    callPayload.Queries["referenceNumber"] = ExpressionConverter.Convert(__workflow_referenceNumber);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_sortOn != null)
                    callPayload.Queries["sort_on"] = ExpressionConverter.Convert(__workflow_sortOn);
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                return new ApiConnectionAction<ListArtCrimesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fbimostwanted")]
        public IBodyWorkflowAction<ArtCrime> GetArtCrime(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ArtCrime>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/@artcrimes/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ArtCrime>(callPayload);
            });
        }
    }

    public class FbimostwantedTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListWantedResponse
    {
        [JsonProperty("total")]
        public int TotalRecords { get; set; }

        [JsonProperty("page")]
        public int PageNumber { get; set; }

        [JsonProperty("items")]
        public WantedPerson[] WantedIndividuals { get; set; }
    }

    public class WantedPerson
    {
        [JsonProperty("@id")]
        public string RecordID { get; set; }

        [JsonProperty("uid")]
        public string UniqueIdentifier { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("images")]
        public WantedPersonImagesTypeItem[] Images { get; set; }

        [JsonProperty("files")]
        public WantedPersonFilesTypeItem[] Files { get; set; }

        [JsonProperty("warning_message")]
        public string WarningMessage { get; set; }

        [JsonProperty("remarks")]
        public string Remarks { get; set; }

        [JsonProperty("details")]
        public string DetailedInformation { get; set; }

        [JsonProperty("additional_information")]
        public string AdditionalInformation { get; set; }

        [JsonProperty("caution")]
        public string CautionNotice { get; set; }

        [JsonProperty("reward_text")]
        public string RewardInformation { get; set; }

        [JsonProperty("reward_min")]
        public int MinimumReward { get; set; }

        [JsonProperty("reward_max")]
        public int MaximumReward { get; set; }

        [JsonProperty("dates_of_birth_used")]
        public string[] DatesOfBirthUsed { get; set; }

        [JsonProperty("languages")]
        public string[] LanguagesSpoken { get; set; }

        [JsonProperty("place_of_birth")]
        public string BirthPlace { get; set; }

        [JsonProperty("locations")]
        public string[] KnownLocations { get; set; }

        [JsonProperty("field_offices")]
        public string[] FieldOffices { get; set; }

        [JsonProperty("legat_names")]
        public string[] LegatNames { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("person_classification")]
        public string Classification { get; set; }

        [JsonProperty("ncic")]
        public string NCICNumber { get; set; }

        [JsonProperty("age_min")]
        public int MinimumAge { get; set; }

        [JsonProperty("age_max")]
        public int MaximumAge { get; set; }

        [JsonProperty("weight_min")]
        public int MinimumWeight { get; set; }

        [JsonProperty("weight_max")]
        public int MaximumWeight { get; set; }

        [JsonProperty("height_min")]
        public int MinimumHeight { get; set; }

        [JsonProperty("height_max")]
        public int MaximumHeight { get; set; }

        [JsonProperty("eyes")]
        public string EyeColor { get; set; }

        [JsonProperty("hair")]
        public string HairColor { get; set; }

        [JsonProperty("build")]
        public string Build { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("race")]
        public string Race { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("scars_and_marks")]
        public string ScarsAndMarks { get; set; }

        [JsonProperty("complexion")]
        public string Complexion { get; set; }

        [JsonProperty("occupations")]
        public string[] Occupations { get; set; }

        [JsonProperty("possible_countries")]
        public string[] PossibleCountries { get; set; }

        [JsonProperty("possible_states")]
        public string[] PossibleStates { get; set; }

        [JsonProperty("modified")]
        public string LastModified { get; set; }

        [JsonProperty("publication")]
        public string PublicationDate { get; set; }

        [JsonProperty("path")]
        public string APIPath { get; set; }
    }

    public class WantedPersonImagesTypeItem
    {
        [JsonProperty("caption")]
        public string ImageCaption { get; set; }

        [JsonProperty("original")]
        public string OriginalImageURL { get; set; }

        [JsonProperty("large")]
        public string LargeImageURL { get; set; }

        [JsonProperty("thumb")]
        public string ThumbnailImageURL { get; set; }
    }

    public class WantedPersonFilesTypeItem
    {
        [JsonProperty("url")]
        public string FileURL { get; set; }

        [JsonProperty("name")]
        public string FileName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum posterClassificationInput
    {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "ten")]
        Ten,
        [EnumMember(Value = "terrorist")]
        Terrorist,
        [EnumMember(Value = "information")]
        Information,
        [EnumMember(Value = "kidnapping")]
        Kidnapping,
        [EnumMember(Value = "missing")]
        Missing,
        [EnumMember(Value = "most")]
        Most,
        [EnumMember(Value = "crimes-against-children")]
        CrimesAgainstChildren,
        [EnumMember(Value = "ecap")]
        Ecap,
        [EnumMember(Value = "law-enforcement-assistance")]
        LawEnforcementAssistance
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldOfficesInput
    {
        [EnumMember(Value = "albany")]
        Albany,
        [EnumMember(Value = "albuquerque")]
        Albuquerque,
        [EnumMember(Value = "anchorage")]
        Anchorage,
        [EnumMember(Value = "atlanta")]
        Atlanta,
        [EnumMember(Value = "baltimore")]
        Baltimore,
        [EnumMember(Value = "birmingham")]
        Birmingham,
        [EnumMember(Value = "boston")]
        Boston,
        [EnumMember(Value = "buffalo")]
        Buffalo,
        [EnumMember(Value = "charlotte")]
        Charlotte,
        [EnumMember(Value = "chicago")]
        Chicago,
        [EnumMember(Value = "cincinnati")]
        Cincinnati,
        [EnumMember(Value = "cleveland")]
        Cleveland,
        [EnumMember(Value = "columbia")]
        Columbia,
        [EnumMember(Value = "dallas")]
        Dallas,
        [EnumMember(Value = "denver")]
        Denver,
        [EnumMember(Value = "detroit")]
        Detroit,
        [EnumMember(Value = "elpaso")]
        Elpaso,
        [EnumMember(Value = "honolulu")]
        Honolulu,
        [EnumMember(Value = "houston")]
        Houston,
        [EnumMember(Value = "indianapolis")]
        Indianapolis,
        [EnumMember(Value = "jackson")]
        Jackson,
        [EnumMember(Value = "jacksonville")]
        Jacksonville,
        [EnumMember(Value = "kansascity")]
        Kansascity,
        [EnumMember(Value = "knoxville")]
        Knoxville,
        [EnumMember(Value = "lasvegas")]
        Lasvegas,
        [EnumMember(Value = "littlerock")]
        Littlerock,
        [EnumMember(Value = "losangeles")]
        Losangeles,
        [EnumMember(Value = "louisville")]
        Louisville,
        [EnumMember(Value = "memphis")]
        Memphis,
        [EnumMember(Value = "miami")]
        Miami,
        [EnumMember(Value = "milwaukee")]
        Milwaukee,
        [EnumMember(Value = "minneapolis")]
        Minneapolis,
        [EnumMember(Value = "mobile")]
        Mobile,
        [EnumMember(Value = "newhaven")]
        Newhaven,
        [EnumMember(Value = "neworleans")]
        Neworleans,
        [EnumMember(Value = "newyork")]
        Newyork,
        [EnumMember(Value = "newark")]
        Newark,
        [EnumMember(Value = "norfolk")]
        Norfolk,
        [EnumMember(Value = "oklahomacity")]
        Oklahomacity,
        [EnumMember(Value = "omaha")]
        Omaha,
        [EnumMember(Value = "philadelphia")]
        Philadelphia,
        [EnumMember(Value = "phoenix")]
        Phoenix,
        [EnumMember(Value = "pittsburgh")]
        Pittsburgh,
        [EnumMember(Value = "portland")]
        Portland,
        [EnumMember(Value = "richmond")]
        Richmond,
        [EnumMember(Value = "sacramento")]
        Sacramento,
        [EnumMember(Value = "saltlakecity")]
        Saltlakecity,
        [EnumMember(Value = "sanantonio")]
        Sanantonio,
        [EnumMember(Value = "sandiego")]
        Sandiego,
        [EnumMember(Value = "sanfrancisco")]
        Sanfrancisco,
        [EnumMember(Value = "sanjuan")]
        Sanjuan,
        [EnumMember(Value = "seattle")]
        Seattle,
        [EnumMember(Value = "springfield")]
        Springfield,
        [EnumMember(Value = "stlouis")]
        Stlouis,
        [EnumMember(Value = "tampa")]
        Tampa,
        [EnumMember(Value = "washingtondc")]
        Washingtondc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum personClassificationInput
    {
        Main,
        Victim,
        Accomplice
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum statusInput
    {
        [EnumMember(Value = "na")]
        Na,
        [EnumMember(Value = "captured")]
        Captured,
        [EnumMember(Value = "recovered")]
        Recovered,
        [EnumMember(Value = "located")]
        Located,
        [EnumMember(Value = "surrendered")]
        Surrendered,
        [EnumMember(Value = "deceased")]
        Deceased
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortOnInput
    {
        [EnumMember(Value = "publication")]
        Publication,
        [EnumMember(Value = "modified")]
        Modified
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortOrderInput
    {
        [EnumMember(Value = "desc")]
        Desc,
        [EnumMember(Value = "asc")]
        Asc
    }

    public class ListArtCrimesResponse
    {
        [JsonProperty("total")]
        public int TotalArtCrimes { get; set; }

        [JsonProperty("page")]
        public int PageNumber { get; set; }

        [JsonProperty("items")]
        public ArtCrime[] ArtCrimes { get; set; }
    }

    public class ArtCrime
    {
        [JsonProperty("@id")]
        public string ODataID { get; set; }

        [JsonProperty("uid")]
        public string UniqueIdentifier { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string CrimeDescription { get; set; }

        [JsonProperty("images")]
        public ArtCrimeImagesTypeItem[] Images { get; set; }

        [JsonProperty("crimeCategory")]
        public string Category { get; set; }

        [JsonProperty("maker")]
        public string Maker { get; set; }

        [JsonProperty("materials")]
        public string MaterialsUsed { get; set; }

        [JsonProperty("measurements")]
        public string Measurements { get; set; }

        [JsonProperty("period")]
        public string CreationPeriod { get; set; }

        [JsonProperty("additionalData")]
        public string AdditionalInformation { get; set; }

        [JsonProperty("modified")]
        public string LastModified { get; set; }

        [JsonProperty("publication")]
        public string PublicationDate { get; set; }

        [JsonProperty("path")]
        public string APIPath { get; set; }
    }

    public class ArtCrimeImagesTypeItem
    {
        [JsonProperty("original")]
        public string OriginalImageURL { get; set; }

        [JsonProperty("thumb")]
        public string ThumbnailImageURL { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fbimostwanted;

    public partial class WorkflowManagedActions
    {
        public FbimostwantedActions Fbimostwanted(string connectionId) => new FbimostwantedActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FbimostwantedTriggers Fbimostwanted(string connectionId) => new FbimostwantedTriggers(connectionId);
    }
}
