// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ----------------------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The flow definition.
    /// </summary>
    public class FlowTemplate
    {
        /// <summary>
        /// Gets or sets the definition metadata.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public JToken Metadata { get; set; }

        /// <summary>
        /// Gets or sets the definition schema.
        /// </summary>
        [JsonProperty(PropertyName = "$schema", Required = Required.Always)]
        public string Schema { get; set; }

        /// <summary>
        /// Gets or sets the flow content version.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string ContentVersion { get; set; }

        /// <summary>
        /// Gets or sets the flow triggers.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public Dictionary<string, FlowTemplateTrigger> Triggers { get; set; }

        /// <summary>
        /// Gets or sets the flow run actions.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public Dictionary<string, FlowTemplateAction> Actions { get; set; }

        /// <summary>
        /// Gets or sets the definition description.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the matched schema version.
        /// </summary>
        [JsonIgnore]
        public string MatchedSchemaVersion { get; set; }
    }
}
