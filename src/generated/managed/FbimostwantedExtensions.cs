//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fbimostwanted
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FbimostwantedActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fbimostwanted")]
        public IBodyWorkflowAction<ListWantedResponse> ListWanted([WorkflowExpression] Func<posterClassificationInput> posterClassification = null, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<fieldOfficesInput> fieldOffices = null, [WorkflowExpression] Func<personClassificationInput> personClassification = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<sortOnInput> sortOn = null, [WorkflowExpression] Func<sortOrderInput> sortOrder = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/@wanted";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (posterClassification != null)
                    callPayload.Queries["poster_classification"] = SourceExpressionConverter.Convert(posterClassification);
                if (title != null)
                    callPayload.Queries["title"] = SourceExpressionConverter.ConvertO(title);
                if (fieldOffices != null)
                    callPayload.Queries["field_offices"] = SourceExpressionConverter.Convert(fieldOffices);
                if (personClassification != null)
                    callPayload.Queries["person_classification"] = SourceExpressionConverter.Convert(personClassification);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.Convert(status);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (sortOn != null)
                    callPayload.Queries["sort_on"] = SourceExpressionConverter.Convert(sortOn);
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = SourceExpressionConverter.Convert(sortOrder);
                return callPayload;
            }

            return new ApiConnectionAction<ListWantedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fbimostwanted")]
        public IBodyWorkflowAction<WantedPerson> GetWantedPerson([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/@wanted-person/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<WantedPerson>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fbimostwanted")]
        public IBodyWorkflowAction<ListArtCrimesResponse> ListArtCrimes([WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string> crimeCategory = null, [WorkflowExpression] Func<string> maker = null, [WorkflowExpression] Func<string> referenceNumber = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<sortOnInput> sortOn = null, [WorkflowExpression] Func<sortOrderInput> sortOrder = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/@artcrimes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (title != null)
                    callPayload.Queries["title"] = SourceExpressionConverter.ConvertO(title);
                if (crimeCategory != null)
                    callPayload.Queries["crimeCategory"] = SourceExpressionConverter.ConvertO(crimeCategory);
                if (maker != null)
                    callPayload.Queries["maker"] = SourceExpressionConverter.ConvertO(maker);
                if (referenceNumber != null)
                    callPayload.Queries["referenceNumber"] = SourceExpressionConverter.ConvertO(referenceNumber);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (sortOn != null)
                    callPayload.Queries["sort_on"] = SourceExpressionConverter.Convert(sortOn);
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = SourceExpressionConverter.Convert(sortOrder);
                return callPayload;
            }

            return new ApiConnectionAction<ListArtCrimesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fbimostwanted")]
        public IBodyWorkflowAction<ArtCrime> GetArtCrime([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/@artcrimes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ArtCrime>(BuildSourceInput);
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

    public enum personClassificationInput
    {
        Main,
        Victim,
        Accomplice
    }

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

    public enum sortOnInput
    {
        [EnumMember(Value = "publication")]
        Publication,
        [EnumMember(Value = "modified")]
        Modified
    }

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