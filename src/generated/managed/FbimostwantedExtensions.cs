//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fbimostwanted
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FbimostwantedActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fbimostwanted")]
        [WorkflowExpressionFactory(nameof(__BuildListWanted))]
        public IBodyWorkflowAction<ListWantedResponse> ListWanted([WorkflowExpression] Func<posterClassificationInput> posterClassification = null, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<fieldOfficesInput> fieldOffices = null, [WorkflowExpression] Func<personClassificationInput> personClassification = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<sortOnInput> sortOn = null, [WorkflowExpression] Func<sortOrderInput> sortOrder = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListWantedResponse> __BuildListWanted(WorkflowValue<posterClassificationInput> posterClassification = null, WorkflowValue<string> title = null, WorkflowValue<fieldOfficesInput> fieldOffices = null, WorkflowValue<personClassificationInput> personClassification = null, WorkflowValue<statusInput> status = null, WorkflowValue<int> pageSize = null, WorkflowValue<int> page = null, WorkflowValue<sortOnInput> sortOn = null, WorkflowValue<sortOrderInput> sortOrder = null)
        {
            WorkflowValue.Validate(posterClassification, nameof(posterClassification), required: false);
            WorkflowValue.Validate(title, nameof(title), required: false);
            WorkflowValue.Validate(fieldOffices, nameof(fieldOffices), required: false);
            WorkflowValue.Validate(personClassification, nameof(personClassification), required: false);
            WorkflowValue.Validate(status, nameof(status), required: false);
            WorkflowValue.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(sortOn, nameof(sortOn), required: false);
            WorkflowValue.Validate(sortOrder, nameof(sortOrder), required: false);
            return new DeferredBodyAction<ListWantedResponse>(() =>
            {
                var apiCallPath = "/@wanted";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (posterClassification != null)
                    callPayload.Queries["poster_classification"] = ExpressionConverter.Convert(posterClassification);
                if (title != null)
                    callPayload.Queries["title"] = ExpressionConverter.Convert(title);
                if (fieldOffices != null)
                    callPayload.Queries["field_offices"] = ExpressionConverter.Convert(fieldOffices);
                if (personClassification != null)
                    callPayload.Queries["person_classification"] = ExpressionConverter.Convert(personClassification);
                if (status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(status);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (sortOn != null)
                    callPayload.Queries["sort_on"] = ExpressionConverter.Convert(sortOn);
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(sortOrder);
                return new ApiConnectionAction<ListWantedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fbimostwanted")]
        [WorkflowExpressionFactory(nameof(__BuildGetWantedPerson))]
        public IBodyWorkflowAction<WantedPerson> GetWantedPerson([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WantedPerson> __BuildGetWantedPerson(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<WantedPerson>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/@wanted-person/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<WantedPerson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fbimostwanted")]
        [WorkflowExpressionFactory(nameof(__BuildListArtCrimes))]
        public IBodyWorkflowAction<ListArtCrimesResponse> ListArtCrimes([WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string> crimeCategory = null, [WorkflowExpression] Func<string> maker = null, [WorkflowExpression] Func<string> referenceNumber = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<sortOnInput> sortOn = null, [WorkflowExpression] Func<sortOrderInput> sortOrder = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListArtCrimesResponse> __BuildListArtCrimes(WorkflowValue<string> title = null, WorkflowValue<string> crimeCategory = null, WorkflowValue<string> maker = null, WorkflowValue<string> referenceNumber = null, WorkflowValue<int> pageSize = null, WorkflowValue<int> page = null, WorkflowValue<sortOnInput> sortOn = null, WorkflowValue<sortOrderInput> sortOrder = null)
        {
            WorkflowValue.Validate(title, nameof(title), required: false);
            WorkflowValue.Validate(crimeCategory, nameof(crimeCategory), required: false);
            WorkflowValue.Validate(maker, nameof(maker), required: false);
            WorkflowValue.Validate(referenceNumber, nameof(referenceNumber), required: false);
            WorkflowValue.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(sortOn, nameof(sortOn), required: false);
            WorkflowValue.Validate(sortOrder, nameof(sortOrder), required: false);
            return new DeferredBodyAction<ListArtCrimesResponse>(() =>
            {
                var apiCallPath = "/@artcrimes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (title != null)
                    callPayload.Queries["title"] = ExpressionConverter.Convert(title);
                if (crimeCategory != null)
                    callPayload.Queries["crimeCategory"] = ExpressionConverter.Convert(crimeCategory);
                if (maker != null)
                    callPayload.Queries["maker"] = ExpressionConverter.Convert(maker);
                if (referenceNumber != null)
                    callPayload.Queries["referenceNumber"] = ExpressionConverter.Convert(referenceNumber);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (sortOn != null)
                    callPayload.Queries["sort_on"] = ExpressionConverter.Convert(sortOn);
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(sortOrder);
                return new ApiConnectionAction<ListArtCrimesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fbimostwanted")]
        [WorkflowExpressionFactory(nameof(__BuildGetArtCrime))]
        public IBodyWorkflowAction<ArtCrime> GetArtCrime([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ArtCrime> __BuildGetArtCrime(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ArtCrime>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/@artcrimes/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
