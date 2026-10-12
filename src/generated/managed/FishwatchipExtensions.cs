//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fishwatchip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FishwatchipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fishwatchip")]
        public IBodyWorkflowAction<SpeciesResponseItem[]> ListSpecies()
        {
            var apiCallPath = "/species";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SpeciesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fishwatchip")]
        [WorkflowExpressionFactory(nameof(__BuildGetSpecies))]
        public IBodyWorkflowAction<SpeciesResponseItem[]> GetSpecies([WorkflowExpression] Func<string> species)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SpeciesResponseItem[]> __BuildGetSpecies(WorkflowExpression<string> species)
        {
            WorkflowExpression.Validate(species, nameof(species), required: true);
            return new DeferredBodyAction<SpeciesResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/species/{0}", ExpressionConverter.ConvertWithUrlEncoding(species, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SpeciesResponseItem[]>(callPayload);
            });
        }
    }

    public class FishwatchipTriggers([ConnectionName] string connectionId)
    {
    }

    public class SpeciesResponseItem
    {
        [JsonProperty("Fishery Management")]
        public string FisheryManagement { get; set; }
        public string Habitat { get; set; }

        [JsonProperty("Habitat Impacts")]
        public string HabitatImpacts { get; set; }
        public string Location { get; set; }
        public string Management { get; set; }

        [JsonProperty("NOAA Fisheries Region")]
        public string NOAAFisheriesRegion { get; set; }
        public string Population { get; set; }

        [JsonProperty("Population Status")]
        public string PopulationStatus { get; set; }

        [JsonProperty("Scientific Name")]
        public string ScientificName { get; set; }

        [JsonProperty("Species Aliases")]
        public string SpeciesAliases { get; set; }

        [JsonProperty("Species Illustration Photo")]
        public SpeciesResponseItemSpeciesIllustrationPhotoType SpeciesIllustrationPhoto { get; set; }

        [JsonProperty("Species Name")]
        public string SpeciesName { get; set; }

        [JsonProperty("Animal Health")]
        public string AnimalHealth { get; set; }
        public string Availability { get; set; }
        public string Biology { get; set; }
        public string Bycatch { get; set; }
        public string Calories { get; set; }
        public string Carbohydrate { get; set; }
        public string Cholesterol { get; set; }
        public string Color { get; set; }

        [JsonProperty("Disease Treatment and Prevention")]
        public string DiseaseTreatmentAndPrevention { get; set; }

        [JsonProperty("Displayed Seafood Profile Illustration")]
        public string DisplayedSeafoodProfileIllustration { get; set; }

        [JsonProperty("Ecosystem Services")]
        public string EcosystemServices { get; set; }

        [JsonProperty("Environmental Considerations")]
        public string EnvironmentalConsiderations { get; set; }

        [JsonProperty("Environmental Effects")]
        public string EnvironmentalEffects { get; set; }

        [JsonProperty("Farming Methods")]
        public string FarmingMethods { get; set; }

        [JsonProperty("Fat, Total")]
        public string FatTotal { get; set; }
        public string Feeds { get; set; }

        [JsonProperty("Fiber, Total Dietary")]
        public string FiberTotalDietary { get; set; }

        [JsonProperty("Fishing Rate")]
        public string FishingRate { get; set; }
        public string Harvest { get; set; }

        [JsonProperty("Harvest Type")]
        public string HarvestType { get; set; }

        [JsonProperty("Health Benefits")]
        public string HealthBenefits { get; set; }

        [JsonProperty("Human Health")]
        public string HumanHealth { get; set; }

        [JsonProperty("Physical Description")]
        public string PhysicalDescription { get; set; }
        public string Production { get; set; }
        public string Protein { get; set; }
        public string Quote { get; set; }
        public string Research { get; set; }

        [JsonProperty("Saturated Fatty Acids, Total")]
        public string SaturatedFattyAcidsTotal { get; set; }
        public string Selenium { get; set; }

        [JsonProperty("Serving Weight")]
        public string ServingWeight { get; set; }
        public string Servings { get; set; }
        public string Sodium { get; set; }
        public string Source { get; set; }

        [JsonProperty("Sugars, Total")]
        public string SugarsTotal { get; set; }
        public string Taste { get; set; }
        public string Texture { get; set; }
        public string Path { get; set; }

        [JsonProperty("last_update")]
        public string LastUpdate { get; set; }
    }

    public class SpeciesResponseItemSpeciesIllustrationPhotoType
    {
        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("alt")]
        public string Alt { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fishwatchip;

    public partial class WorkflowManagedActions
    {
        public FishwatchipActions Fishwatchip(string connectionId) => new FishwatchipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FishwatchipTriggers Fishwatchip(string connectionId) => new FishwatchipTriggers(connectionId);
    }
}