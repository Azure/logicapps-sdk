//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wavelength
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WavelengthActions([ConnectionName] string connectionId)
    {
    }

    public class WavelengthTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<FlowListItem[], ApiConnectionPollingTriggerConfiguration> OnFlowChanged(Expression<Func<string>> folderId = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: false);
            return new DeferredBodyTrigger<FlowListItem[], ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/flows";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_folderId != null)
                    callPayload.Queries["folder_id"] = ExpressionConverter.Convert(__workflow_folderId);
                return new ApiConnectionPollingTrigger<FlowListItem[]>(callPayload);
            });
        }
    }

    public class FlowListItem
    {
        [JsonProperty("id")]
        public string FlowId { get; set; }

        [JsonProperty("title")]
        public string FlowTitle { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("folder_id")]
        public string FolderId { get; set; }

        [JsonProperty("is_public")]
        public bool IsPublic { get; set; }

        [JsonProperty("shared")]
        public bool SharedWithMe { get; set; }

        [JsonProperty("role")]
        public string MyRole { get; set; }

        [JsonProperty("open_url")]
        public string OpenUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Wavelength;

    public partial class WorkflowManagedActions
    {
        public WavelengthActions Wavelength(string connectionId) => new WavelengthActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WavelengthTriggers Wavelength(string connectionId) => new WavelengthTriggers(connectionId);
    }
}