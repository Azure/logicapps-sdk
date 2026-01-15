//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Ascregulatorycomplianceassessment
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AscregulatorycomplianceassessmentActions([ConnectionName] string connectionId)
    {
    }

    public class AscregulatorycomplianceassessmentTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<string> ASCRegulatoryComplianceAssessmentTriggerSubscribe()
        {
            var apiCallPath = "/Microsoft.Security/RegulatoryComplianceAssessment/subscribe";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callback_url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Ascregulatorycomplianceassessment;

    public partial class WorkflowManagedActions
    {
        public AscregulatorycomplianceassessmentActions Ascregulatorycomplianceassessment(string connectionId) => new AscregulatorycomplianceassessmentActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AscregulatorycomplianceassessmentTriggers Ascregulatorycomplianceassessment(string connectionId) => new AscregulatorycomplianceassessmentTriggers(connectionId);
    }
}