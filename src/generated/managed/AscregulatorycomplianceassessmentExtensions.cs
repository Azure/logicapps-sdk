//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ascregulatorycomplianceassessment
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AscregulatorycomplianceassessmentActions([ConnectionName] string connectionId)
    {
    }

    public class AscregulatorycomplianceassessmentTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string, ApiConnectionPollingTriggerConfiguration> ASCRegulatoryComplianceAssessmentTriggerSubscribe()
        {
            return new DeferredBodyTrigger<string, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Microsoft.Security/RegulatoryComplianceAssessment/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<string>(callPayload);
            });
        }
    }

    public class BodyInput
    {
        [JsonProperty("callback_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ascregulatorycomplianceassessment;

    public partial class WorkflowManagedActions
    {
        public AscregulatorycomplianceassessmentActions Ascregulatorycomplianceassessment(string connectionId) => new AscregulatorycomplianceassessmentActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AscregulatorycomplianceassessmentTriggers Ascregulatorycomplianceassessment(string connectionId) => new AscregulatorycomplianceassessmentTriggers(connectionId);
    }
}