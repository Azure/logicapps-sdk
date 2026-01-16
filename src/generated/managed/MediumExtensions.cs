//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Medium
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MediumActions([ConnectionName] string connectionId)
    {
    }

    public class MediumTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<Publications> TriggerPublicationAdded(string triggerName = null)
        {
            var apiCallPath = "/trigger/publications";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<Publications>(callPayload);
        }
    }

    public class Publications
    {
        [JsonProperty("data")]
        public PublicationsPublicationTypeItem[] Publication { get; set; }
    }

    public class PublicationsPublicationTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Medium;

    public partial class WorkflowManagedActions
    {
        public MediumActions Medium(string connectionId) => new MediumActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MediumTriggers Medium(string connectionId) => new MediumTriggers(connectionId);
    }
}